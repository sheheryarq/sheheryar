Module Module1

    Sub Main()
        Dim highchar, char1, char2 As Char
        Dim count1, count2, highest, Count As Integer
        Dim sentence As String
        sentence = ""
        highchar = ""
        char1 = ""
        char2 = ""
        count1 = 0
        count2 = 0
        highest = 0
        Count = 0
        Console.Write("Enter the sentence: ")
        sentence = Console.ReadLine
        For count1 = 1 To Len(sentence)
            char1 = Mid(sentence, count1, 1)
            Count = 0
            For count2 = 1 To Len(sentence)
                char2 = Mid(sentence, count2, 1)
                If char1 = char2 Then Count = Count + 1
                If Count > highest Then
                    highchar = char2
                    highest = Count
                End If
            Next
        Next
        Console.Write(UCase(highchar) & " " & "is occuring" & " " & highest & " " & "times in your sentence.")
        Console.ReadKey()

    End Sub

End Module
