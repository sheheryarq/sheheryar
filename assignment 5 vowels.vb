Module Module1

    Sub Main()
        Dim Str1 As String
        Dim vowelcounter As Integer
        Dim i As Integer
        Dim thischar As Char
        Str1 = ""
        vowelcounter = 0
        i = 0
        thischar = ""
        Console.Write("Enter Sentence: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        For i = 1 To Len(Str1)
            thischar = Mid(Str1, i, 1)
            If thischar = "A" Or thischar = "E" Or thischar = "I" Or thischar = "O" Or thischar = "U" Then
                vowelcounter = vowelcounter + 1
            End If
        Next
        Console.Write("Number of vowels are " & vowelcounter)
        Console.ReadKey()
    End Sub

End Module
