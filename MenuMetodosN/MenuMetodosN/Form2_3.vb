Public Class Gráfica
    Dim i, c, redon, ib, n As Integer
    Dim vx, vy, x(), y() As Single

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
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
            Salida.Rows.Add(i, x(i), y(i))
        Next

        i = 0
        Do While vx > x(i)
            i = i + 1
        Loop
        ib = i - 1 'Se queda un índice antes
        TextBox1.Text = ib

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        vy = (vx - x(ib + 1)) / (x(ib) - x(ib + 1)) * y(ib) + (vx - x(ib)) / (x(ib + 1) - x(ib)) * y(ib + 1)
        TextBox2.Text = "f(" & vx & ") =" & vy
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vy = ((vx - x(ib + 1)) * (vx - x(ib + 2)) / (x(ib) - x(ib + 2)) * (x(ib) - x(ib + 1))) * y(ib) +
            ((vx - x(ib)) * (vx - x(ib + 2))) / ((x(ib + 1) - x(ib)) * (x(ib + 1)) - (x(ib + 2)) * y(ib + 1)) +
            ((vx - x(ib)) * (vx - x(ib + 1))) / ((x(ib + 2) - x(ib)) * (x(ib + 2) - x(ib + 1))) * y(ib + 2)
        TextBox2.Text = "f(" & vx & ") =" & vy
    End Sub
End Class