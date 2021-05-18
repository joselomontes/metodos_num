Public Class Form3_1
    Dim i, c, redon, ib, n, k, j As Integer
    Dim vx, vy, x(), y(), s, m, cf(), fact, dk(), sum As Single
    Dim g As Graphics

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        g = CreateGraphics()
        For i = 0 To n - 1
            Gráfica.Series(0).Points.AddXY(Math.Round(x(i), 2), Math.Round(y(i), 2))
        Next
        Gráfica.Series(1).Points.AddXY(Math.Round(vx, 2), Math.Round(vy, 2))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c = tc.Text
        n = tn.Text
        vx = tvx.Text
        redon = c + 2
        ReDim x(0 To n), y(0 To n)

        For i = 0 To n - 1
            x(i) = InputBox("x(" & i & ") =")
            y(i) = InputBox("y(" & i & ") =")
            Salida1.Rows.Add(i, x(i), y(i))
            Salida1.Rows.Add("", "", "")
        Next

        i = 0
        Do While vx > x(i)
            i = i + 1
        Loop
        ib = i - 1 'Se queda un índice antes
        m = n - (ib + 1)
        s = (vx - x(ib)) / (x(ib + 1) - x(ib))

        TextBox1.Text = ib
        TextBox3.Text = m
        TextBox4.Text = s

        ReDim cf(0 To m), dk(0 To m)
        dk(0) = y(ib)
        cf(0) = 1
        k = 0
        vy = cf(0) * dk(0)
        Salida2.Rows.Add(cf(k), dk(k))
        For k = 1 To m 'utilizar este for
            fact = 1
            For i = 1 To k
                fact = fact * (s - (i - 1)) / i
            Next
            cf(k) = fact

            sum = 0
            For j = 0 To k
                fact = 1
                For i = 1 To j
                    fact = fact * (k - (i - 1)) / i
                Next
                sum = sum + (((-1) ^ j) * fact * y(ib + k - j))
            Next
            dk(k) = sum
            vy = vy + cf(k) * dk(k)
            Salida1.Rows((2 * ib + k)).Cells((j + 1)).Value = Math.Round(dk(k), redon)

            Salida2.Rows.Add(cf(k), Math.Round(dk(k), redon))
        Next
        TextBox2.Text = Math.Round(vy, redon)
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tc.Clear()
        tn.Clear()
        tvx.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Salida1.Rows.Clear()
        Salida1.Rows.Clear()
        'Grafica.Series.Clear()
        Gráfica.Series(0).Points.Clear()
        Gráfica.Series(1).Points.Clear()
    End Sub
End Class