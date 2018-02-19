Module Module1

    Sub Main()
        Console.WriteLine(mixup(Console.ReadLine, Console.ReadLine))
        Console.ReadKey()
    End Sub
    Function mixup(ByVal x As String, ByVal y As String) As String
        Dim a, b, c, d As String
        c = Len(x)
        d = Len(y)
        a = Left(x, 2)
        b = Left(y, 2)
        Return b & Right(x, c - 2) & "" & a & Right(y, d - 2)

    End Function
End Module
