Imports System

Module Tabla_booleana
    Sub Main()
        Console.WriteLine("______TABLA BOOLEANA______" & vbCrLf)
        Console.WriteLine(vbTab & "TABLA AND")
        Console.WriteLine("Verdad AND Verdad = " & (True And True))
        Console.WriteLine("Verdad AND Falso = " & (True And False))
        Console.WriteLine("Falso AND Verdad = " & (False And True))
        Console.WriteLine("Falso AND Falso = " & (False And False) & vbCrLf)

        Console.WriteLine(vbTab & "TABLA OR")
        Console.WriteLine("Verdad OR Verdad = " & (True Or True))
        Console.WriteLine("Verdad OR Falso = " & (True Or False))
        Console.WriteLine("Falso OR Verdad = " & (False Or True))
        Console.WriteLine("Falso OR Falso = " & (False Or False) & vbCrLf)

        Console.WriteLine(vbTab & "TABLA XOR")
        Console.WriteLine("Verdad XOR Verdad = " & (True Xor True))
        Console.WriteLine("Verdad XOR Falso = " & (True Xor False))
        Console.WriteLine("Falso XOR Verdad = " & (False Xor True))
        Console.WriteLine("Falso XOR Falso = " & (False Xor False) & vbCrLf)

        Console.WriteLine(vbTab & "TABLA NOT")
        Console.WriteLine("NOT Verdad= " & (Not True))
        Console.WriteLine("NOT Falso= " & (Not False))

        Console.Read()
    End Sub
End Module
