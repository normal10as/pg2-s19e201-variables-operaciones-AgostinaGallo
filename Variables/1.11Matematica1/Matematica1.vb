Imports System

Module Matematica1
    Sub Main()
        Dim numeroIngresado As Double
        Console.WriteLine("Ingrese un numero:" & vbCrLf)
        numeroIngresado = Console.ReadLine()
        Console.WriteLine("Valor absoluto: " & Math.Abs(numeroIngresado))
        Console.WriteLine("Elevado a la d�cima potencia: " & Math.Pow(numeroIngresado, 10))
        Console.WriteLine("Raiz cuadrada: " & Math.Sqrt(numeroIngresado))

        Console.Read()
    End Sub
End Module
