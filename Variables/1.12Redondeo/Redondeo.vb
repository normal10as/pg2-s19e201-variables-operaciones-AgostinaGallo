Imports System

Module Redondeo
    Sub Main()
        Dim numeroIngresado As Double
        Console.WriteLine("Ingrese un numero real: ")
        numeroIngresado = Console.ReadLine()

        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(numeroIngresado)) 'Devuelve el valor entero m�s peque�o que es mayor o igual Decimal especificado o Double(aproximado por exceso)
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(numeroIngresado)) 'Devuelve el entero m�s grande que sea menor o igual que Decimal o el n�mero especificado de Double (aproximado por defecto).
        Console.WriteLine("Valor redondeado: " & Math.Round(numeroIngresado)) 'Devuelve un valor de Decimal o de Double redondeado al valor entero m�s cercano o a un n�mero especificado de d�gitos fraccionarios

        Console.Read()
    End Sub
End Module
