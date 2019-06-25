Module Cadenas1

    Sub Main()
        Dim palabraIngresada, buscoA, buscoO As String
        Dim posicion As Integer
        buscoA = "a"
        buscoO = "o"
        Console.WriteLine("Ingresa una palabra: ")
        palabraIngresada = Console.ReadLine()
        posicion = InStr(1, palabraIngresada, buscoA, CompareMethod.Text)
        Console.WriteLine("La primer letra -a- aparece en la posición: " & posicion)
        posicion = InStr(1, palabraIngresada, buscoO, CompareMethod.Text)
        Console.WriteLine("La primer letra -o- aparece en la posición: " & posicion)

        Console.WriteLine("La palabra invertida es: " & StrReverse(palabraIngresada))
        Console.Read()
    End Sub

End Module
