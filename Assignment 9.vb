Module Module1

    Sub Main()
        Dim Str1, Str2, Str3 As String
        Dim Fchar, Schar, Fchar2, Schar2 As Char
        Dim RStr1, Rstr2 As String
        Str1 = ""
        Str2 = ""
        Fchar = ""
        Schar = ""
        Str3 = ""
        Schar2 = ""
        Fchar2 = ""
        RStr1 = ""
        Rstr2 = ""
        Console.Write("Enter First Text: ")
        Str1 = Console.ReadLine
        Console.Write("Enter Second Text: ")
        Str2 = Console.ReadLine
        Fchar = Mid(Str1, 1, 1)
        Schar = Mid(Str1, 2, 1)
        Fchar2 = Mid(Str2, 1, 1)
        Schar2 = Mid(Str2, 2, 1)
        RStr1 = Mid(Str1, 3, Len(Str1))
        Rstr2 = Mid(Str2, 3, Len(Str2))
        Str3 = Fchar2 + Schar2 + RStr1 + " " + Fchar + Schar + Rstr2
        Console.Write("Processed String is: " & Str3)
        Console.ReadKey()


    End Sub

End Module
