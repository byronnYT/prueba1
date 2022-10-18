Module Module1

    Sub Main()
        Dim letraStr, palabra As String
        Dim contadorPalabras, contadorCaracteres As Integer
        Dim letraChar As Char
        Do
            Console.Write("Introduce una letra: ")
            letraStr = Console.ReadLine.ToUpper
        Loop While letraStr.Length > 1
        letraChar = letraStr

        Console.WriteLine($"Debes introducir palabras que comiencen por {letraChar}")
        Do
            Console.Write($"Palabra que comienza por {letraChar} de mínimo 10 caracteres: ")
            palabra = Console.ReadLine
            contadorPalabras += 1
            contadorCaracteres += palabra.Length
        Loop Until contadorCaracteres <= 10 OrElse Not palabra.ToUpper.StartsWith(letraChar.ToString)
        Console.WriteLine($"{palabra} no llega a 10 caracteres, ya no puedes introducir más palabras")
        Console.WriteLine($"¡Bien!, has tecleado {contadorCaracteres} en {contadorPalabras}")
        Console.WriteLine("Pulsa para finalizar...")
        Console.ReadKey()
        Select Case contadorCaracteres
            Case 0
                Console.WriteLine("No has introducido ninguna palabra válida")
            Case 1 To 99
                Console.WriteLine($"Solo has tecleado {contadorCaracteres} caracteres en {contadorPalabras} palabras")
            Case 100 To 1000
                Console.WriteLine($"¡Bien! {contadorCaracteres} caracteres en {contadorPalabras} palabras")
            Case Else
                Console.WriteLine($"¡¡¡Vaya dominio!!!, has tecleado {contadorCaracteres} caracteres en {contadorPalabras} palabras")
        End Select

        Console.ReadKey()

    End Sub

End Module
