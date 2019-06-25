Imports System

Module Redondeo
    Sub Main()
        Dim numeroIngresado As Double
        Console.WriteLine("Ingrese un numero real: ")
        numeroIngresado = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(numeroIngresado)) 'Devuelve el valor entero más pequeño que es mayor o igual Decimal especificado o Double(aproximado por exceso)
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(numeroIngresado)) 'Devuelve el entero más grande que sea menor o igual que Decimal o el número especificado de Double (aproximado por defecto).
        Console.WriteLine("Valor redondeado: " & Math.Round(numeroIngresado)) 'Devuelve un valor de Decimal o de Double redondeado al valor entero más cercano o a un número especificado de dígitos fraccionarios

        Console.Read()
    End Sub
End Module
