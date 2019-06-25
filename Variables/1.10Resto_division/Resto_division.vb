Imports System

Module Program
    Sub Main()
        Dim valorEntero As Integer
        Dim resto As Double
        Console.WriteLine("Ingrese un valor entero: ")
        valorEntero = Console.ReadLine()
        resto = valorEntero Mod 2
        Console.WriteLine(vbCrLf & "El resto del valor dividido por 2 es: " & resto)

    End Sub
End Module
