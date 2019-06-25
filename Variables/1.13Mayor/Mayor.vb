Imports System

Module Mayor
    Sub Main()
        Dim num1, num2, num3, mayor As Double
        Console.WriteLine("--LEER TRES NUMEROS Y MOSTRAR EL MAYOR..")
        Console.WriteLine("Ingrese el primer numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer numero: ")
        num3 = Console.ReadLine()
        mayor = Math.Max(num1, num2)
        mayor = Math.Max(mayor, num3)
        Console.WriteLine(vbCrLf & "El mayor numero ingresado es: " & mayor)

        Console.Read()
    End Sub
End Module
