Imports System

Module concatenacion
    Sub Main()
        Console.Write("Ingresa nombre de empresa: ")
        Dim NombreEmpresa As String = Console.ReadLine

        Console.Write("Ingresa nombre de la calle: ")
        Dim NombreCalle As String = Console.ReadLine

        Console.Write("Ingresa numero entero de altura de la calle: ")
        Dim AlturaCalle As Integer = Console.ReadLine

        Console.Write("Ingresa fecha de inicio de actividades (DD/MM/AAAA) : ")
        Dim FechaInicioActiv As Date = Console.ReadLine

        'conversion explicita (convierto lo que es necesario hacer)
        Convert.ToString(AlturaCalle)
        Convert.ToString(FechaInicioActiv)
        Console.WriteLine("CONVERTIDO EXPLICITAMENTE: ")
        Console.WriteLine(NombreEmpresa & vbCrLf & NombreCalle & vbCrLf & AlturaCalle & vbCrLf & FechaInicioActiv)

        'conversion implicita
        Console.WriteLine("CONVERTIDO IMPLICITAMENTE: ")
        Console.WriteLine(NombreEmpresa & vbCrLf & NombreCalle & vbCrLf & AlturaCalle & vbCrLf & FechaInicioActiv) 'al imprimir con "&" se convierte implicitamente
        Console.Read()
    End Sub
End Module
