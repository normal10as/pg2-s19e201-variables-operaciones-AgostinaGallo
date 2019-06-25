Imports System

Module variables_tipos
    Sub Main()
        Dim nya, lugarNacimiento, nombreCalle As String
        nya = "Agostina Gallo"
        lugarNacimiento = "Posadas"
        nombreCalle = "Avenida Lavalle"

        Dim fechaNacimiento As Date
        fechaNacimiento = #11/2/1999#

        Dim esArgentino As Boolean
        esArgentino = True

        Dim alturaCorporal, temperatura, alturaCalle, distanciaEntre2Ciudades, profundidadMar, cantHabitantes, pesoProducto, precioProducto As Integer
        Dim dni As Integer
        dni = 41000000
        alturaCorporal = 175
        temperatura = 26
        alturaCalle = 1234
        distanciaEntre2Ciudades = 28
        profundidadMar = 11000
        cantHabitantes = 44072000
        pesoProducto = 15
        precioProducto = 500
        'imprimo cada leyenda seguida del valor del dato.
        Console.WriteLine("La persona se llama  " & nya)
        Console.WriteLine("Su numero de documento es  " & dni)
        Console.WriteLine("Nacio en  " & lugarNacimiento & ", En la fecha  " & fechaNacimiento)
        Console.WriteLine("Su altura corporal es de  " & alturaCorporal & " centimetros")
        Console.WriteLine("¿Es de Argentina?: " & esArgentino)
        Console.WriteLine("Temperatura ambiente de:  " & temperatura & "°C")
        Console.WriteLine("Nombre de la calle es:  " & nombreCalle & ", A la altura de:  " & alturaCalle)
        Console.WriteLine("La distancia entre POSADAS y CANDELARIA es de:  " & distanciaEntre2Ciudades & " kilometros")
        Console.WriteLine("La profundidad maxima del mar es de  " & profundidadMar & " metros")
        Console.WriteLine("La cantidad de habitantes en Argentina es de: " & cantHabitantes)
        Console.WriteLine("El peso de una bolsa de papas es de:  " & pesoProducto & " kilogramos")
        Console.WriteLine("El precio de un Huevo de Pascuas es de:  $" & precioProducto)
        Console.Read()
    End Sub
End Module
