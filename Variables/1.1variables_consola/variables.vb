Imports System

Module variables
    Sub Main()
        Console.Write("Ingrese nombre: ")
        Dim nombre As String = Console.ReadLine
        Console.Write("Ingrese apellido: ")
        Dim apellido As String = Console.ReadLine
        Console.Write("Ingrese fecha de nacimiento DD/MM/AAAA: ")
        Dim nacim As Date = Console.ReadLine

        'concateno e imprimo las variables
        Console.WriteLine(apellido & "," & nombre & " nacio el " & nacim)

        Console.Read() 'este comando da un tiempo de espera antes de cerrar
    End Sub
End Module
