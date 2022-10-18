Module Module1

    Sub Main()
        Const MAX_CANT_NUMEROS As Integer = 20
        Dim valorIntroducido As String
        Dim numero, contador, numMaximo, aleatorio, contadorMayorA50 As Integer
        Dim numMinimo As Integer = Integer.MaxValue
        Dim rnd As New Random

        Console.WriteLine("EJERCICIO PARA ANALIZAR TU MEMORIA VISUAL Y CÁLCULO")
        Console.WriteLine("")
        Do
            Console.Write($"Introduce la cantidad de números que debemos visualizar(1..{MAX_CANT_NUMEROS}): ")
            valorIntroducido = Console.ReadLine()
            If Not Integer.TryParse(valorIntroducido, numero) Then
                Console.WriteLine("Debe ser un número entre 1 y 20")
            End If
        Loop Until numero > 1 AndAlso numero < 20

        Console.WriteLine($"Observa detenidamente estos {numero} números: ")

        Do
            aleatorio = rnd.Next(1, 101)
            Console.Write(aleatorio)
            Console.Write(" ")
            contador += 1

            If aleatorio > numMaximo Then
                numMaximo = aleatorio
            ElseIf aleatorio < numMinimo Then
                numMinimo = aleatorio
            End If
            If aleatorio > 50 Then
                contadorMayorA50 += 1
            End If
        Loop Until contador = numero
        Console.WriteLine("")
        Console.WriteLine("Pulsa para continuar...")
        Console.ReadKey()
        Console.Clear()

        Do
            Console.WriteLine("¿Cuál era el mayor de todos ellos? ")
            valorIntroducido = Console.ReadLine
        Loop Until Integer.TryParse(valorIntroducido, numero) AndAlso numero >= 1 AndAlso numero <= 100

        If numero = numMaximo Then
            Console.WriteLine("Has acertado!")
        Else
            Console.WriteLine($"Lo siento, el número mayor era {numMaximo}")
        End If

        Do
            Console.WriteLine("¿Cuál era el menor de todos ellos? ")
            valorIntroducido = Console.ReadLine
        Loop Until Integer.TryParse(valorIntroducido, numero) AndAlso numero >= 1 AndAlso numero <= 100

        If numero = numMinimo Then
            Console.WriteLine("Has acertado!")
        Else
            Console.WriteLine($"Lo siento, el número menor era {numMinimo}")
        End If

        Do
            Console.WriteLine("¿Cuántos números había mayores que 50? ")
            valorIntroducido = Console.ReadLine
        Loop Until Integer.TryParse(valorIntroducido, numero) AndAlso numero >= 1 AndAlso numero <= 100

        If numero = contadorMayorA50 Then
            Console.WriteLine("Has acertado!")
        Else
            Console.WriteLine($"Lo siento, te has equivocado, había {contadorMayorA50} números mayores de 50")
        End If

        Console.ReadKey()
    End Sub

End Module
