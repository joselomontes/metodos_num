Imports info.lundin.math
Public Class Form3_5
    Dim a, b, h, suma, err(1000), ec, integral(1000), j, xk, ck As Single
    Dim c, n, redon, k, i, nfila As Integer
    Dim g As Graphics
    Dim Exceltab = New Microsoft.Office.Interop.Excel.Application
    Dim path As String = Environment.CurrentDirectory + "\" + "Tabla Cuadratura"
    Dim Libro = Exceltab.Workbooks.Open(Filename:=path)

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", Math.E)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        n = 1
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        suma = 0
        i = 0

        For Each celda In Libro.Sheets(1).Range("a2:a37")
            If celda.value = n Then
                nfila = celda.row
            End If
        Next

        For k = 1 To n
            ck = Libro.sheets(1).cells(nfila + k - 1, 4).value 'cells(renglon, columna)
            xk = Libro.sheets(1).cells(nfila + k - 1, 3).value 'cells(renglon, columna)
            suma = suma + ((b - a) / 2) * ck * f((b + a) / 2 + (b - a) / 2 * xk)
        Next
        integral(i) = suma
        Salida.Rows.Add(n, Math.Round(integral(i), redon), "-----")

        err(i) = 1

        Do While err(i) > ec
            n = n + 1
            i = i + 1
            suma = 0

            For Each celda In Libro.Sheets(1).Range("a2:a37")
                If celda.value = n Then
                    nfila = celda.row
                End If
            Next

            For k = 1 To n
                ck = Libro.sheets(1).cells(nfila + k - 1, 4).value 'cells(renglon, columna)
                xk = Libro.sheets(1).cells(nfila + k - 1, 3).value 'cells(renglon, columna)
                suma = suma + ((b - a) / 2) * ck * f((b + a) / 2 + (b - a) / 2 * xk)
            Next

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
End Class