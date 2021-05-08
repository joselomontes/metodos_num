Public Class Form2_3
    Dim i, c, redon, ib, n As Integer
    Dim vx, vy, x(), y() As Single

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub tvx_TextChanged(sender As Object, e As EventArgs) Handles tvx.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Gráfica_Click(sender As Object, e As EventArgs) Handles Gráfica.Click

    End Sub

    Private Sub tn_TextChanged(sender As Object, e As EventArgs) Handles tn.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Salida_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Salida.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tc.Clear()
        Salida.Rows.Clear()
        tn.Clear()
        tvx.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        'Gráfica.Series.Clear()
        Gráfica.Series(0).Points.Clear()
        Gráfica.Series(1).Points.Clear()
    End Sub

    Private Sub tc_TextChanged(sender As Object, e As EventArgs) Handles tc.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Dim g As Graphics

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        g = CreateGraphics()
        For i = 0 To n - 1
            Gráfica.Series(0).Points.AddXY(Math.Round(x(i), 2), Math.Round(y(i), 2))
        Next
        Gráfica.Series(1).Points.AddXY(Math.Round(vx, 2), Math.Round(vy, 2))
    End Sub

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
        'vy = ((vx - x(ib + 1)) * (vx - x(ib + 2)) / (x(ib) - x(ib + 2)) * (x(ib) - x(ib + 1))) * y(ib) +
        ' ((vx - x(ib)) * (vx - x(ib + 2))) / ((x(ib + 1) - x(ib)) * (x(ib + 1)) - (x(ib + 2)) * y(ib + 1)) +
        ' ((vx - x(ib)) * (vx - x(ib + 1))) / ((x(ib + 2) - x(ib)) * (x(ib + 2) - x(ib + 1))) * y(ib + 2)

        vy = ((vx - x(ib + 1)) * (vx - x(ib + 2)) / ((x(ib) - x(ib + 1)) * (x(ib) - x(ib + 2)))) * y(ib) +
             ((vx - x(ib)) * (vx - x(ib + 2)) / ((x(ib + 1) - x(ib)) * (x(ib + 1) - x(ib + 2)))) * y(ib + 1) +
             ((vx - x(ib)) * (vx - x(ib + 1)) / ((x(ib + 2) - x(ib)) * (x(ib + 2) - x(ib + 1)))) * y(ib + 2)
        TextBox2.Text = "f(" & vx & ") =" & vy
    End Sub
End Class