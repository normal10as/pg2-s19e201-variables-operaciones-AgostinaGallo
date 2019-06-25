Imports System
'ultimo ejercicio
Module Dias
    Enum diasSemana
        Lunes = 1
        Martes
        Miércoles
        Jueves
        Viernes
        Sábado
        Domingo
    End Enum
    Sub Main()
        Console.WriteLine("-LISTA DE DIAS DE LA SEMANA")
        Console.WriteLine(diasSemana.Lunes & ") {0}", diasSemana.Lunes)
        Console.WriteLine(diasSemana.Martes & ") {0}", diasSemana.Martes)
        Console.WriteLine(diasSemana.Miércoles & ") {0}", diasSemana.Miércoles)
        Console.WriteLine(diasSemana.Jueves & ") {0}", diasSemana.Jueves)
        Console.WriteLine(diasSemana.Viernes & ") {0}", diasSemana.Viernes)
        Console.WriteLine(diasSemana.Sábado & ") {0}", diasSemana.Sábado)
        Console.WriteLine(diasSemana.Domingo & ") {0}", diasSemana.Domingo)

        Console.Read()
    End Sub
End Module
