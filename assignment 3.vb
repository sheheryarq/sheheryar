Module Module1

    Sub Main()
        Sub Main()
        Dim Str1 As String
        Dim alphacounter, digitscounter, sccasecounter, i As Integer
        Dim thischar As Char
        Str1 = ""
        alphacounter = 0
        digitscounter = 0
        sccasecounter = 0
        i = 0
        thischar = ""
        Console.Write("Enter Sentence: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        For i = 1 To Len(Str1)
            thischar = Mid(Str1, i, 1)
            If thischar >= "A" And thischar <= "Z" Then
                alphacounter = alphacounter + 1
            ElseIf thischar >= "0" And thischar <= "9" Then
                digitscounter = digitscounter + 1
            Else
                sccasecounter = sccasecounter + 1

            End If
        Next
        Console.WriteLine("The Number of alphabets in entered sentence are: " & alphacounter)
        Console.WriteLine("The Number of digits in entered sentence are: " & digitscounter)
        Console.WriteLine("The Number of specialcasecharachter in entered sentence are: " & sccasecounter)
        Console.ReadKey()
    End Sub

End Module
