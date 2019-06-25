Imports System

Module Reloj
    Sub Main()
        Dim fecha As Date
        fecha = Date.Now ' Hora actual
        Console.WriteLine("- Valores en tiempo real -")
        Console.WriteLine("Dia del año: " & fecha.DayOfYear)
        Console.WriteLine("Mes del año: " & fecha.Month)
        Console.WriteLine("Hora y Minuto: " & fecha.Hour & ":" & fecha.Minute)
        Console.Read()
    End Sub
End Module
