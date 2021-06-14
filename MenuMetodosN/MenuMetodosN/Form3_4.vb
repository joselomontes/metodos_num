Imports info.lundin.math
Public Class Form3_4
    Dim a, b, h, suma, err(1000), ec, integral(1000), j As Single
    Dim c, n, redon, k, i As Integer
    Dim g As Graphics

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", Math.E)
        parser.Values.Add("pi", Math.PI)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        'n = 100
        'n = 10
        n = 4
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        h = (b - a) / (2 * n)
        redon = c + 2
        suma = 0
        For k = 1 To n
            suma = suma + (2 * f(a + ((2 * k) - 1) * h)) + f(a + (2 * k * h))
        Next
        suma = h / 3 * (f(a) - f(b) + 2 * suma)
        integral(i) = suma
        Salida.Rows.Add(n, Math.Round(integral(i), redon), "------")

        err(i) = 1
        i = 0
        Do While err(i) > ec
            i = i + 1
            'n = n + 100
            'n = n + 10
            n = n + 4
            suma = 0
            h = (b - a) / (2 * n)
            For k = 1 To n
                suma = suma + (2 * f(a + ((2 * k) - 1) * h)) + f(a + (2 * k * h))
            Next
            suma = h / 3 * (f(a) - f(b) + 2 * suma)
            integral(i) = suma
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            Salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop
        TextBox1.Text = Math.Round(integral(i), redon)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tc.Clear()
        ta.Clear()
        tb.Clear()
        tf.Clear()
        TextBox1.Clear()
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

    'Funcion: 1/(2pi)^(1/2)(e^(-x^2)/2)+0.5
    '0.5+1/((2pi)^(1/2))e^(-x^2/2)
    '0.5+1/sqrt(2pi)e^(-x^2/2)
End Class
