Imports System

Module cuadratica
    Sub Main()
        Dim a, b, c, determinante As Integer
        Dim raiz1, raiz2 As Decimal
        a = 1
        b = 5
        c = 2
        Console.WriteLine("La funcion a resolver es: " & vbCrLf & " x = b^2 - 4ac / 2  ")
        determinante = (b ^ 2) - (4 * a * c)
        raiz1 = (-b + Math.Sqrt(determinante)) / (2 * a)
        raiz2 = (-b - Math.Sqrt(determinante)) / (2 * a)

        Console.WriteLine("Las raices son.. " & vbCrLf & "Raiz(+): " & raiz1 & vbCrLf & "Raiz(-): " & raiz2)

        Console.Read()
    End Sub
End Module
