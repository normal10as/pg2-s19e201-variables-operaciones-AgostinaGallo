Imports System.DateTime


Module Ajustar_reloj
    Sub Main()
        Dim fechaCreada As DateTime
        Dim dia, hora As Byte

        Console.WriteLine("Ingresar el dia (1-31): ")
        dia = Console.ReadLine()

        Console.WriteLine("Ingresar la hora (0-24): ")
        hora = Console.ReadLine()

        fechaCreada = New DateTime(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)

        Console.WriteLine("La fecha creada es: " & fechaCreada)



        Console.Read()
    End Sub
End Module
