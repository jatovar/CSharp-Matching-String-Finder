# Reto: Encuentra la subcadena más larga presente en una matriz

Sea una matriz cuadrada de dos dimensiones, de caracteres (cualquiera), devuelva la cadena de caracteres adyacentes iguales más larga.

## Cómo compilar y ejecutar

1. **Compilar el Programa**

   Para compilar el programa, necesitarás un compilador de C# como el proporcionado por Visual Studio o el SDK de .NET Core.

   Abre tu terminal o línea de comandos y navega hasta el directorio donde tienes el archivo de código fuente de C# (`Program.cs`) y el archivo de matriz de entrada (`matrix.txt`).

   Ejecuta el siguiente comando para compilar el programa:

   ```bash
   csc Program.cs

Esto generará un archivo ejecutable llamado Program.exe.

2. **Ejecutar el Programa**

    Después de compilar el programa, puedes ejecutarlo con el siguiente comando:
    ```bash
   Program.exe

3. **Matriz de Entrada**

    Para utilizar el programa y encontrar la cadena de caracteres más larga, debes proporcionar una matriz de entrada en un archivo de texto llamado `matrix.txt`. Sigue estos pasos para preparar la matriz de entrada:
    1. Abre un editor de texto o un procesador de texto de tu elección.
    2. Crea un nuevo archivo y guarda con el nombre `matrix.txt` en el mismo directorio donde se encuentra el archivo ejecutable del programa (`Program.exe`) y el archivo de código fuente (`Program.cs`).
    3. Dentro del archivo `matrix.txt`, representa la matriz utilizando caracteres separados por comas y saltos de línea. Cada fila de la matriz debe estar en una línea separada, y los caracteres deben estar separados por comas, como se muestra en este ejemplo:

        ```plaintext
         B, B, D, A, D, E, F
         B, X, C, D, D, J, K
         H, Y, I, 3, D, D, 3
         R, 7, O, Ñ, G, D, 2
         W, N, S, P, E, 0, D
         A, 9, C, D, D, E, F
         B, X, D, D, D, J, K
4. **Resultado**

   Después de ejecutar el programa, se mostrará en la consola la cadena de caracteres adyacentes iguales más larga encontrada en la matriz de entrada. La salida tendrá el siguiente formato:
    ```plaintext
    DDDDD
