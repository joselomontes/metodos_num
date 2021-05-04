Public Class Form6
    Dim i, c, redon, ib, n As Integer
    Dim vx, vy, x(), y(), sx, sy, scx, sxy, a, b, xmedia, ymedia, yvalor As Single

    Private Sub tn_TextChanged(sender As Object, e As EventArgs) Handles tn.TextChanged

    End Sub

    Dim g As Graphics
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tc.Clear()
        tn.Clear()
        tvx.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Salida.Rows.Clear()
        Grafica.Series.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        g = CreateGraphics()
        For i = 1 To n
            Grafica.Series(0).Points.AddXY(Math.Round(x(i), 2), Math.Round(y(i), 2))
        Next
        Grafica.Series(1).Points.AddXY(Math.Round(vx, 2), Math.Round(yvalor, 2))
        Grafica.Series(2).Points.AddXY(x(1), a + b * x(1))
        Grafica.Series(2).Points.AddXY(x(n), a + b * x(n))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = tc.Text
        n = tn.Text
        vx = tvx.Text
        redon = c + 2
        ReDim x(0 To n), y(0 To n)

        For i = 1 To n
            x(i) = InputBox("x(" & i & ")=")
            y(i) = InputBox("y(" & i & ")=")
            Salida.Rows.Add(i, x(i), y(i))
            sx = sx + x(i)
            sy = sy + y(i)
            sxy = sxy + x(i) * y(i)
            scx = scx + x(i) ^ 2
        Next
        xmedia = sx / n
        ymedia = sy / n
        b = (sxy - n * (xmedia * ymedia)) / (scx - n * (xmedia) ^ 2)
        a = (ymedia - b * (xmedia))

        TextBox1.Text = Math.Round(b, redon)
        TextBox2.Text = Math.Round(a, redon)

        i = 1
        Do While vx > x(i)
            i = i + 1
        Loop
        ib = i - 1
        TextBox3.Text = ib

        yvalor = a + b * tvx.Text

        TextBox4.Text = "Y(" & Math.Round(vx, redon) & ")=" & Math.Round(yvalor, redon)
    End Sub
End Class