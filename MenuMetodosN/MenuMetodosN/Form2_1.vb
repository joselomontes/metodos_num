Public Class Form2_1
    Dim i As Integer
    Dim c As Integer
    Dim aux As Integer
    Dim y(50) As Single
    Dim z(50) As Single
    Dim x(50) As Single
    Dim ec As Single
    Dim erx(50) As Single
    Dim ery(50) As Single
    Dim erz(50) As Single
    Dim a(3, 3) As Single
    Dim b(3) As Single
    Dim redon As Integer
    Dim first As Boolean
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        i = 0
        c = tc.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)
        x(i) = 0
        y(i) = 0
        z(i) = 0
        erx(i) = 1
        ery(i) = 1
        erz(i) = 1
        Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), ("----"), ("----"), ("----"))
        Do While erx(i) > ec Or erz(i) > ec Or ery(i) > ec
            i = i + 1
            x(i) = (b(1) - (a(1, 2) * y(i - 1)) - (a(1, 3) * z(i - 1))) / a(1, 1)
            y(i) = (b(2) - (a(2, 1) * x(i - 1)) - (a(2, 3) * z(i - 1))) / a(2, 2)
            z(i) = (b(3) - (a(3, 1) * x(i - 1)) - (a(3, 2) * y(i - 1))) / a(3, 3)
            erx(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            ery(i) = Math.Abs((y(i) - y(i - 1)) / y(i))
            erz(i) = Math.Abs((z(i) - z(i - 1)) / z(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), Math.Round(erx(i), redon), Math.Round(ery(i), redon), Math.Round(erz(i), redon))
        Loop
        res1.Text = Math.Round(x(i), redon)
        res2.Text = Math.Round(y(i), redon)
        res3.Text = Math.Round(z(i), redon)
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        tc.Clear()
        Salida.Rows.Clear()
        res1.Clear()
        res2.Clear()
        res3.Clear()

        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False

        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        For i = 1 To 3
            For j = 1 To 3
                a(i, j) = InputBox("a(" & i & "," & j & ")=")
            Next
        Next

        For i = 1 To 3
            b(i) = InputBox("b(" & i & ") = ")
        Next
        TextBox1.Text = a(1, 1)
        TextBox2.Text = a(1, 2)
        TextBox3.Text = a(1, 3)
        TextBox4.Text = a(2, 1)
        TextBox5.Text = a(2, 2)
        TextBox6.Text = a(2, 3)
        TextBox7.Text = a(3, 1)
        TextBox8.Text = a(3, 2)
        TextBox9.Text = a(3, 3)
        TextBox10.Text = b(1)
        TextBox11.Text = b(2)
        TextBox12.Text = b(3)

        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = True

        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
    End Sub
End Class