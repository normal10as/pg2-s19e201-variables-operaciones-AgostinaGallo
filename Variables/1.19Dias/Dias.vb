Imports System
'ultimo ejercicio
Module Dias
    Enum diasSemana
        Lunes = 1
        Martes
        Mi�rcoles
        Jueves
        Viernes
        S�bado
        Domingo
    End Enum
    Sub Main()
        Console.WriteLine("-LISTA DE DIAS DE LA SEMANA")
        Console.WriteLine(diasSemana.Lunes & ") {0}", diasSemana.Lunes)
        Console.WriteLine(diasSemana.Martes & ") {0}", diasSemana.Martes)
        Console.WriteLine(diasSemana.Mi�rcoles & ") {0}", diasSemana.Mi�rcoles)
        Console.WriteLine(diasSemana.Jueves & ") {0}", diasSemana.Jueves)
        Console.WriteLine(diasSemana.Viernes & ") {0}", diasSemana.Viernes)
        Console.WriteLine(diasSemana.S�bado & ") {0}", diasSemana.S�bado)
        Console.WriteLine(diasSemana.Domingo & ") {0}", diasSemana.Domingo)

        Console.Read()
    End Sub
End Module
