Imports System

Module Nueva_fecha
    Sub Main()
        Dim fechaIngresada As Date
        Dim diasASumar As Byte
        Console.WriteLine("Ingrese una fecha dd/mm/aaaa : ")
        fechaIngresada = Console.ReadLine
        Console.WriteLine("Ingrese cantidad de dias: ")
        diasASumar = Console.ReadLine

        Console.WriteLine(vbCrLf & "La fecha al sumar los dias ingresados es: " & fechaIngresada.AddDays(diasASumar))

        Console.Read()
    End Sub
End Module
