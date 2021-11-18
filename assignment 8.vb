Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim firstchar, samechar As Char
        Dim i As Integer
        Str1 = ""
        Str2 = ""
        firstchar = ""
        i = 0
        samechar = ""
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        firstchar = Mid(Str1, 1, 1)
        Str2 = Str2 + firstchar
        For i = 2 To Len(Str1)
            samechar = Mid(Str1, i, 1)
            If samechar = firstchar Then
                Str2 = Str2 + "*"
            Else : Str2 = Str2 + samechar

            End If
        Next
        Console.Write("The processed String is: " & Str2)
        Console.ReadKey()
    End Sub

End Module
