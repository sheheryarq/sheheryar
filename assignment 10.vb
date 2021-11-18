Module Module1

    Sub Main()
        Dim Str1, Str2, L3, UL3 As String
        Dim length As Integer
        Str1 = ""
        Str2 = ""
        L3 = ""
        length = 0
        UL3 = ""
        Console.Write("add Text: ")
        Str1 = Console.ReadLine
        length = Len(Str1)
        L3 = Right(Str1, 3)
        UL3 = UCase(L3)
        If length < 3 Then
            Str2 = Str2 + Str1
        ElseIf length >= 3 And UL3 = "ING" Then
            Str2 = Str2 + Str1 + "ly"
        ElseIf length >= 3 Then
            Str2 = Str2 + Str1 + "ing"

        End If
        Console.Write("The processed text is: " & Str2)
        Console.ReadKey()

    End Sub

End Module
