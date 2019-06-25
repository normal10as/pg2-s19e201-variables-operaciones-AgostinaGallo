Imports System

Module suma_promedio
    Sub Main()
        Console.WriteLine("Ingrese el primer numero: ")
        Dim PrimerNumero As Integer = Console.ReadLine

        Console.WriteLine("Ingrese el segundo numero: ")
        Dim SegundoNumero As Integer = Console.ReadLine

        Console.WriteLine("Ingrese el tercer numero: ")
        Dim TercerNumero As Integer = Console.ReadLine

        Console.WriteLine("Ingrese el cuarto numero: ")
        Dim CuartoNumero As Integer = Console.ReadLine

        Dim SumaTotal As Integer = PrimerNumero + SegundoNumero + TercerNumero + CuartoNumero
        Console.WriteLine("LA SUMA DE LOS CUATROS NUMEROS ES: " & SumaTotal)
        Console.WriteLine(vbCrLf & "EL PROMEDIO DE LA SUMATORIA TOTAL DE LOS CUATRO NUMEROS ES: " & SumaTotal / 4)

        Console.Read()
    End Sub
End Module
