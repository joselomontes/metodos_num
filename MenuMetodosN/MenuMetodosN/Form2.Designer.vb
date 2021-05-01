<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Tc = New System.Windows.Forms.TextBox()
        Me.Ti = New System.Windows.Forms.TextBox()
        Me.Lc = New System.Windows.Forms.Label()
        Me.Li = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(100, 205)
        Me.Salida.Margin = New System.Windows.Forms.Padding(2)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(466, 198)
        Me.Salida.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Raíz"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(628, 133)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(73, 19)
        Me.Salir.TabIndex = 12
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(628, 77)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(73, 21)
        Me.Calcular.TabIndex = 11
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Tc
        '
        Me.Tc.Location = New System.Drawing.Point(227, 94)
        Me.Tc.Margin = New System.Windows.Forms.Padding(2)
        Me.Tc.Name = "Tc"
        Me.Tc.Size = New System.Drawing.Size(145, 20)
        Me.Tc.TabIndex = 10
        '
        'Ti
        '
        Me.Ti.Location = New System.Drawing.Point(227, 48)
        Me.Ti.Margin = New System.Windows.Forms.Padding(2)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(145, 20)
        Me.Ti.TabIndex = 9
        '
        'Lc
        '
        Me.Lc.AutoSize = True
        Me.Lc.Location = New System.Drawing.Point(140, 94)
        Me.Lc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lc.Name = "Lc"
        Me.Lc.Size = New System.Drawing.Size(63, 13)
        Me.Lc.TabIndex = 8
        Me.Lc.Text = "Dame cifras"
        '
        'Li
        '
        Me.Li.AutoSize = True
        Me.Li.Location = New System.Drawing.Point(140, 52)
        Me.Li.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Li.Name = "Li"
        Me.Li.Size = New System.Drawing.Size(62, 13)
        Me.Li.TabIndex = 7
        Me.Li.Text = "Dame inicio"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Tc)
        Me.Controls.Add(Me.Ti)
        Me.Controls.Add(Me.Lc)
        Me.Controls.Add(Me.Li)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents Tc As TextBox
    Friend WithEvents Ti As TextBox
    Friend WithEvents Lc As Label
    Friend WithEvents Li As Label
End Class
