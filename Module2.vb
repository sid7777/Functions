Module Module1

    Sub Main()
        Console.WriteLine(notgood(Console.ReadLine))
        Console.ReadKey()
    End Sub
    Function notgood(ByVal s As String) As String
        Dim a, b, c As String
        a = InStr(s, "good")
        b = InStr(s, "not")
        c = Len(s)
        Return If(a > b, Left(s, b - 1) & "bad" & Right(s, c - (a + 3)), s)

    End Function

End Module
