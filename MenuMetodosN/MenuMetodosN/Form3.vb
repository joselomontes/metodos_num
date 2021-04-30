Public Class Form3
    Dim fin As Integer
    Dim k As Integer
    Dim impar As Integer

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Salida.Rows.Clear()
        fin = Tn.Text
        For k = 0 To fin
            If (k = 0) Then
                Salida.Rows.Add(k, "-")
            Else
                impar = 2 * k - 1
                Salida.Rows.Add(k, impar)
            End If
        Next
    End Sub

    Private Sub Tn_TextChanged(sender As Object, e As EventArgs) Handles Tn.TextChanged

    End Sub
End Class