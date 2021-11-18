Module Module1

    Sub Main()
        Dim Str1, Str2, UStr1, FStr1, Lstr1 As String
        Dim notpos, badpos As Integer
        Str1 = ""
        UStr1 = ""
        Str2 = ""
        notpos = 0
        badpos = 0
        FStr1 = ""
        Lstr1 = ""
        Console.Write("Enter Text: ")
        Str1 = Console.ReadLine
        UStr1 = UCase(Str1)
        notpos = InStr(UStr1, "NOT")
        badpos = InStr(UStr1, "BAD")
        If notpos = 0 Or badpos = 0 Then
            Str2 = Str2 + Str1
        ElseIf notpos > badpos Then
            Str2 = Str2 + Str1
        ElseIf notpos < badpos Then
            FStr1 = Left(Str1, notpos - 1)
            Lstr1 = Right(Str1, Len(Str1) - badpos - 2)
            Str2 = Str2 + FStr1 + "good" + Lstr1
        End If

        Console.Write("Processed text is: " & Str2)
        Console.ReadKey()
    End Sub

End Module
