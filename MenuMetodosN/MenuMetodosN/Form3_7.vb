Imports info.lundin.math
Public Class Form3_7
    Dim h, x0(1000), y0(1000), xf, n, A As Double
    Dim c, redon, i As Integer

    Function f(x As Single, y As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("e", Math.E)
        parser.Values.Add("pi", Math.PI)
        parser.Values.Add("xy", x * y)
        parser.Values.Add("yx", y * x)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x0(0) = tx0.Text '1
        y0(0) = ty0.Text '0
        xf = txf.Text '1.5
        h = th.Text '0.1
        c = tc.Text '2
        redon = c + 2

        i = 0
        Salida.Rows.Add(n, Math.Round(x0(0), redon), Math.Round(y0(0), redon))

        Do While x0(i) < xf
            i = i + 1
            'y0(i) = y0(i - 1) + h * f(x0(i - 1), y0(i - 1))
            A = y0(i - 1) + h * f(x0(i - 1), y0(i - 1))
            y0(i) = y0(i - 1) + ((h / 2) * (f(x0(i - 1), y0(i - 1)) + f(x0(i - 1) + h, A)))
            x0(i) = x0(i - 1) + h
            Salida.Rows.Add(i, Math.Round(x0(i), redon), Math.Round(y0(i), redon))
            'x0(i) = x0(i) + h
        Loop
        TextBox1.Text = Math.Round(y0(i), redon)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tx0.Clear()
        ty0.Clear()
        txf.Clear()
        tf.Clear()
        tc.Clear()
        th.Clear()
        TextBox1.Clear()
        Salida.Rows.Clear()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class

'Funcion: (2y+1)/(x^2)
'Nueva Funcion: xy
'
