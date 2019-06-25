Module Refrase

    Sub Main()

        Dim Cadena As String = "Aunque la cadena sea de oro, sirve para lo mismo."
        Dim palabraOriginal, palabraNueva, Resultado As String

        Console.WriteLine(Cadena)
        Console.WriteLine(vbCrLf & "Ingresa la palabra a ser reemplazada: ")
        palabraOriginal = Console.ReadLine()
        Console.WriteLine("Ingresa la Nueva palabra: ")
        palabraNueva = Console.ReadLine()

        Dim palabraOriginal1 = " " + palabraOriginal + " "
        Dim palabraNueva1 = " " + palabraNueva + " "

        Resultado = Replace(Cadena, palabraOriginal1, palabraNueva1)

        palabraOriginal1 = " " + palabraOriginal + ","
        palabraNueva1 = " " + palabraNueva + ","

        Resultado = Replace(Resultado, palabraOriginal1, palabraNueva1) 'cambio 1er parametro Cadena por Resultado

        palabraOriginal1 = " " + palabraOriginal + "."
        palabraNueva1 = " " + palabraNueva + "."

        Resultado = Replace(Resultado, palabraOriginal1, palabraNueva1)

        palabraOriginal1 = palabraOriginal + " "
        palabraNueva1 = palabraNueva + " "

        Resultado = Replace(Resultado, palabraOriginal1, palabraNueva1)

        palabraOriginal1 = palabraOriginal
        palabraNueva1 = palabraNueva

        Resultado = Replace(Resultado, palabraOriginal1, palabraNueva1, 1, -1, CompareMethod.Text)

        Console.WriteLine("Resultado: " & Resultado)
        Console.Read()

    End Sub

End Module
