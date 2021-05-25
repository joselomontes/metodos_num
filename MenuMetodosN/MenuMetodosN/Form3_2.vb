Imports info.lundin.math
Public Class Form3_2
    Dim a, b, h, suma, err(500), ec, integral(500), j As Single
    Dim c, n, redon, k, i As Integer
    Dim g As Graphics

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        n = 100
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        h = (b - a) / n
        redon = c + 2
        suma = 0
        For k = 0 To n - 1
            suma = suma + h * f(a + k * h)
        Next
        integral(i) = suma
        Salida.Rows.Add(n, Math.Round(integral(i), redon), "------")

        err(i) = 1

        Do While err(i) > ec
            i = i + 1
            n = n + 100
            suma = 0
            h = (b - a) / n
            For k = 0 To n - 1
                suma = suma + h * f(a + k * h)
            Next
            integral(i) = suma
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            Salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tc.Clear()
        ta.Clear()
        tb.Clear()
        tf.Clear()
        Salida.Rows.Clear()
        Gráfica.Series(0).Points.Clear()
        Gráfica.Series(1).Points.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        g = CreateGraphics()
        j = a - 1
        Do While j <= b + 1
            If j < b And j > a Then
                Gráfica.Series(1).Points.AddXY(Math.Round(j, 2), f(j))
            End If
            Gráfica.Series(0).Points.AddXY(Math.Round(j, 2), f(j))
            j = j + 0.1
        Loop
    End Sub
End Class