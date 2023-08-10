using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Threading;

namespace EntryTypeScannerDNLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path of the .exe file: ");
            string exePath = Console.ReadLine();

            if (File.Exists(exePath))
            {
                try
                {
                    ModuleDefMD module = ModuleDefMD.Load(exePath);
                    TypeDef entryType = FindEntryPointType(module);
                    MethodDef entryMethod = FindEntryPointMethod(entryType);

                    if (entryType != null && entryMethod != null)
                    {
                        string entryTypeName = entryType.FullName;
                        string entryMethodName = entryMethod.Name;

                        Console.WriteLine($"Entry Type: {entryTypeName}");
                        Console.WriteLine($"Entry Method: {entryMethodName}");
                        Thread.Sleep(1000);

                        string outputPath = "EntryTypeOutput.txt";
                        File.WriteAllText(outputPath, $"Entry Type: {entryTypeName}\nEntry Method: {entryMethodName}");
                        Console.WriteLine($"Output saved to {outputPath}");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Entry type or method not found.");
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
                Thread.Sleep(1000);
            }
        }

        static TypeDef FindEntryPointType(ModuleDefMD module)
        {
            foreach (TypeDef type in module.GetTypes())
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (IsEntryPointMethod(method))
                    {
                        return type;
                    }
                }
            }

            return null;
        }

        static MethodDef FindEntryPointMethod(TypeDef type)
        {
            foreach (MethodDef method in type.Methods)
            {
                if (IsEntryPointMethod(method))
                {
                    return method;
                }
            }

            return null;
        }

        static bool IsEntryPointMethod(MethodDef method)
        {
            if (method.IsStatic && method.Parameters.Count == 1)
            {
                Parameter param = method.Parameters[0];
                if (param.Type.FullName == "System.String[]")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
