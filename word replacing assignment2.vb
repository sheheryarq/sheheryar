Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim char1, thischar, char2 As Char
        Dim i As Integer
        Str1 = ""
        Str2 = ""
        char1 = ""
        thischar = ""
        i = 0
        char2 = ""
        Console.Write("Please enter sentence: ")
        Str1 = Console.ReadLine
        Console.Write("Please enter the charachter you want to remove: ")
        char1 = Console.ReadLine
        Console.Write("Please enter the character you want to remove with: ")
        char2 = Console.ReadLine
        For i = 1 To Len(Str1)
            thischar = Mid(Str1, i, 1)
            If thischar = char1 Then
                Str2 = Str2 + char2
            Else : Str2 = Str2 + thischar

            End If
        Next
        Console.Write("Processed String is: " & Str2)
        Console.ReadKey()
    End Sub

End Module
