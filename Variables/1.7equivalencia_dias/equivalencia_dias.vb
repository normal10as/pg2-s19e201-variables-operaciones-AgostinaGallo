Imports System

Module equivalencia_dias
    Sub Main()
        Const diasPorSemana As Byte = 7
        Const horasPorDia As Byte = 24
        Const minutosPorHora As Double = 60

        Console.WriteLine("INGRESA NUMERO DE DIAS: ")
        Dim ingresoNumDias As Integer = Console.ReadLine()
        Console.WriteLine("INGRESASTE " & ingresoNumDias & " DIAS..")
        Console.WriteLine("CALCULO SEMANAS: " & ingresoNumDias \ diasPorSemana)
        Console.WriteLine("CALCULO HORAS: " & ingresoNumDias * horasPorDia)
        Console.WriteLine("CALCULO MINUTOS: " & (ingresoNumDias * horasPorDia) * minutosPorHora)
        Console.WriteLine("Terminado.--")

        Console.Read()
    End Sub
End Module
