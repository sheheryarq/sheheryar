Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim F2, L2 As String
        Dim Length As Integer
        Str1 = ""
        Str2 = ""
        F2 = ""
        L2 = ""
        Length = 0
        Console.Write("Enter string: ")
        Str1 = Console.ReadLine
        Length = Len(Str1)
        If Length <= 2 Then
            Console.Write("The Processed String is: " & Str1)
        ElseIf Length > 2 Then
            F2 = Left(Str1, 2)
            L2 = Right(Str1, 2)
            Str2 = F2 & L2
            Console.Write("The processed String is: " & Str2)

        End If
        Console.ReadKey()
    End Sub

End Module
