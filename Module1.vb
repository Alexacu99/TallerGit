Option Strict On
Module Module1

    Sub Main()
        Dim socio, seguidor, feliz As String


        Console.WriteLine("¿Es usted socio del FC Barcelona?")
        socio = Console.ReadLine()
        Console.WriteLine("¿Sigue usted al EF Cobres?")
        seguidor = Console.ReadLine()
        Console.WriteLine("¿Es usted Feliz?")
        feliz = Console.ReadLine()


        If (socio = "si" Or seguidor = "si") And feliz = "si" Then
            Console.WriteLine("Es usted un campeón")
        Else
            Console.WriteLine("En menudo lío te has metido")

        End If

        Console.ReadLine()




    End Sub

End Module
