Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        'Son cambios muy sencillos
        'Hola zoex
        'HOlaaa josso777
    End Sub

    Private Sub hideSubMenu()
        PanelDepUno.Visible = False
        PanelDep2.Visible = False
        PanelDepa3.Visible = False
    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Depa1_Click(sender As Object, e As EventArgs) Handles Depa1.Click
        showSubMenu(PanelDepUno)
    End Sub

    Private Sub Depa2_Click(sender As Object, e As EventArgs) Handles Depa2.Click
        showSubMenu(PanelDep2)
    End Sub

    Private Sub Depa3_Click(sender As Object, e As EventArgs) Handles Depa3.Click
        showSubMenu(PanelDepa3)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        openChildForm(New Form2())
        hideSubMenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openChildForm(New Form3())
        hideSubMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New Form4())
        hideSubMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New Form5())
        hideSubMenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        openChildForm(New Form2_1())
        hideSubMenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        openChildForm(New Form2_2())
        hideSubMenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        openChildForm(New Form2_3())
        hideSubMenu()
    End Sub
    Private Sub MínimosCuad_Click(sender As Object, e As EventArgs) Handles MínimosCuad.Click
        openChildForm(New Form6())
        hideSubMenu()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        openChildForm(New Form3_1())
        hideSubMenu()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        openChildForm(New Form7())
        hideSubMenu()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        openChildForm(New Form3_3())
        hideSubMenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Form3_5())
        hideSubMenu()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        openChildForm(New Form3_4())
        hideSubMenu()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        openChildForm(New Form3_6())
        hideSubMenu()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        openChildForm(New Form3_7())
        hideSubMenu()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        openChildForm(New Form3_8())
        hideSubMenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub PanelLogo_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogo.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        openChildForm(New FormInit())
        hideSubMenu()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        openChildForm(New FormInit())
        hideSubMenu()
    End Sub
End Class
