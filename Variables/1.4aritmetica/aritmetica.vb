Imports System

Module aritmetica
    Sub Main()
        'DECLARAR Y ASIGNAR DOS VALORES ENTEROS Y DOS PUNTO FLOTANTE
        Dim entero1, entero2 As Integer
        entero1 = 11
        entero2 = 75

        Dim flota1, flota2 As Single
        flota1 = 14.333
        flota2 = 2.89

        Console.WriteLine("Los numeros enteros son: " & entero1 & ", " & entero2)
        Console.WriteLine("Los numeros flotantes son: " & flota1 & ", " & flota2)

        Console.WriteLine(vbCrLf & "\n---SUMAS")
        Console.WriteLine("Entero con entero " & entero1 & " + " & entero2 & " = " & entero1 + entero2)
        Console.WriteLine("Flotante con flotante " & flota1 & " + " & flota2 & " = " & flota1 + flota2)
        Console.WriteLine("Entero con flotante " & entero1 & " + " & flota2 & " = " & entero1 + flota2)
        Console.WriteLine("Flotante con entero " & flota1 & " + " & entero2 & " = " & flota1 + entero2)

        Console.WriteLine(vbCrLf & "---RESTAS")
        Console.WriteLine("Entero con entero " & entero2 & " - " & entero1 & " = " & entero2 - entero1)
        Console.WriteLine("Flotante con flotante " & flota1 & " - " & flota2 & " = " & flota1 - flota2)
        Console.WriteLine("Entero con flotante " & entero1 & " - " & flota2 & " = " & entero1 - flota2)
        Console.WriteLine("Flotante con entero " & flota1 & " - " & entero2 & " = " & flota1 - entero2)

        Console.WriteLine(vbCrLf & "---MULTIPLICACION")
        Console.WriteLine("Entero con entero " & entero1 & " * " & entero2 & " = " & entero1 * entero2)
        Console.WriteLine("Flotante con flotante " & flota1 & " * " & flota2 & " = " & flota1 * flota2)
        Console.WriteLine("Entero con flotante " & entero1 & " * " & flota2 & " = " & entero1 * flota2)
        Console.WriteLine("Flotante con entero " & flota1 & " * " & entero2 & " = " & flota1 * entero2)

        Console.WriteLine(vbCrLf & "---DIVISION")
        Console.WriteLine("Entero con entero " & entero2 & " / " & entero1 & " = " & entero2 \ entero1)
        Console.WriteLine("Flotante con flotante " & flota1 & " / " & flota2 & " = " & flota1 / flota2)
        Console.WriteLine("Entero con flotante " & entero1 & " / " & flota2 & " = " & entero1 / flota2)
        Console.WriteLine("Flotante con entero " & flota1 & " / " & entero2 & " = " & flota1 / entero2)

        Console.WriteLine(vbCrLf & "............ADIOS!!")

        Console.Read()
    End Sub
End Module
