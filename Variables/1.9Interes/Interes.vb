Imports System

Module Interes
    Sub Main()
        Dim interesAnual, monto As Decimal
        Dim interesProducido As Double
        Dim tiempo As Integer
        Console.WriteLine("INGRESE MONTO DEL CAPITAL: ")
        monto = Console.ReadLine()
        Console.WriteLine("INGRESE INTERES ANUAL: ")
        interesAnual = Console.ReadLine()
        Console.WriteLine("INGRESE CANTIDAD DE DIAS: ")
        tiempo = Console.ReadLine()
        interesProducido = (monto * interesAnual * tiempo) / (360 * 100)
        Console.WriteLine(vbCrLf & "EL INTERES PRODUCIDO ES:  " & interesProducido)


        Console.Read()
    End Sub
End Module
