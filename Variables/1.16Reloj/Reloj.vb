Imports System

Module Reloj
    Sub Main()
        Dim fecha As Date
        fecha = Date.Now ' Hora actual
        Console.WriteLine("- Valores en tiempo real -")
        Console.WriteLine("Dia del a�o: " & fecha.DayOfYear)
        Console.WriteLine("Mes del a�o: " & fecha.Month)
        Console.WriteLine("Hora y Minuto: " & fecha.Hour & ":" & fecha.Minute)
        Console.Read()
    End Sub
End Module
