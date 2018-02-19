Module Module1

    Sub Main()
        Console.WriteLine(frontback(Console.ReadLine, Console.ReadLine))
        Console.ReadKey()
    End Sub
    Function frontback(ByVal a As String, ByVal b As String) As String
        Dim x, y, z, e As String
        Dim c, d As Single
        Dim f, g, h, i As String
        x = Len(a)
        y = Len(b)
        If x Mod 2 = 0 Then
            z = x / 2
            f = Left(a, z)
            g = Right(a, z)
        Else
            c = x / 2
            f = Left(a, c + 0.5)
            g = Right(a, c - 0.5)
        End If
        If y Mod 2 = 0 Then
            e = y / 2
            h = Left(b, e)
            i = Right(b, e)
        Else
            d = y / 2
            h = Left(b, e + 0.5)
            i = Right(b, e - 0.5)
        End If
        Return g & i & f & h

    End Function
End Module
