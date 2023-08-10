# EntryPointScanner

**English:**

**Program Title:** Entry Type and Method Scanner using dnlib

**Description:**

This program is a utility tool that uses the dnlib library to scan and identify the entry type and method of a .NET executable (`.exe`) file. The entry type and method are crucial components that define the starting point of execution in a .NET application. By providing the path to a valid .exe file, this program loads the assembly, analyzes its structure, and identifies the entry type and method.

The program performs the following steps:
1. Prompt the user to enter the path of the .exe file.
2. Load the executable using the dnlib library.
3. Traverse through the module and type definitions to locate the entry type.
4. Within the entry type, search for the entry method (typically named "Main").
5. Display the identified entry type and method names.
6. Optionally, save the output to a text file named "EntryTypeOutput.txt" for reference.

**Note:** The dnlib library is used for parsing and analyzing .NET assemblies, providing the ability to navigate through their structure and extract information.

**Usage:**
1. Run the program.
2. Enter the path to the target .exe file.
3. The program will display the detected entry type and method.

**Spanish:**

**Título del Programa:** Escáner de Tipo de Entrada y Método usando dnlib

**Descripción:**

Este programa es una herramienta de utilidad que utiliza la biblioteca dnlib para escanear e identificar el tipo de entrada y método de un archivo ejecutable (.exe) de .NET. El tipo de entrada y el método son componentes cruciales que definen el punto de inicio de la ejecución en una aplicación .NET. Al proporcionar la ruta a un archivo .exe válido, este programa carga el ensamblado, analiza su estructura e identifica el tipo de entrada y el método.

El programa realiza los siguientes pasos:
1. Solicita al usuario que ingrese la ruta del archivo .exe.
2. Carga el ejecutable utilizando la biblioteca dnlib.
3. Recorre el módulo y las definiciones de tipos para localizar el tipo de entrada.
4. Dentro del tipo de entrada, busca el método de entrada (normalmente llamado "Main").
5. Muestra los nombres del tipo de entrada y del método identificados.
6. Opcionalmente, guarda la salida en un archivo de texto llamado "EntryTypeOutput.txt" para referencia.

**Nota:** La biblioteca dnlib se utiliza para analizar y comprender los ensamblados de .NET, proporcionando la capacidad de navegar por su estructura y extraer información.

**Uso:**
1. Ejecuta el programa.
2. Ingresa la ruta al archivo .exe objetivo.
3. El programa mostrará el tipo de entrada y el método detectados.
