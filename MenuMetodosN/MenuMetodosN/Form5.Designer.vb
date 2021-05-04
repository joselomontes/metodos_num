<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tfd = New System.Windows.Forms.TextBox()
        Me.Tf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(449, 97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 115)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(384, 467)
        Me.Resultado.Margin = New System.Windows.Forms.Padding(2)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(145, 26)
        Me.Resultado.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(184, 473)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "La raíz aproximada es: "
        '
        'Tfd
        '
        Me.Tfd.Location = New System.Drawing.Point(271, 182)
        Me.Tfd.Margin = New System.Windows.Forms.Padding(2)
        Me.Tfd.Name = "Tfd"
        Me.Tfd.Size = New System.Drawing.Size(145, 26)
        Me.Tfd.TabIndex = 31
        '
        'Tf
        '
        Me.Tf.Location = New System.Drawing.Point(271, 136)
        Me.Tf.Margin = New System.Windows.Forms.Padding(2)
        Me.Tf.Name = "Tf"
        Me.Tf.Size = New System.Drawing.Size(145, 26)
        Me.Tf.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(33, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Dame derivada de función"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(80, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Dame función"
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.Khaki
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(84, 247)
        Me.Salida.Margin = New System.Windows.Forms.Padding(2)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(472, 206)
        Me.Salida.TabIndex = 27
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
        Me.Salir.BackColor = System.Drawing.Color.Gold
        Me.Salir.Location = New System.Drawing.Point(726, 154)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(73, 28)
        Me.Salir.TabIndex = 26
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Gold
        Me.Calcular.Location = New System.Drawing.Point(726, 97)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(88, 35)
        Me.Calcular.TabIndex = 25
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Tc
        '
        Me.Tc.Location = New System.Drawing.Point(271, 89)
        Me.Tc.Margin = New System.Windows.Forms.Padding(2)
        Me.Tc.Name = "Tc"
        Me.Tc.Size = New System.Drawing.Size(145, 26)
        Me.Tc.TabIndex = 24
        '
        'Ti
        '
        Me.Ti.Location = New System.Drawing.Point(271, 42)
        Me.Ti.Margin = New System.Windows.Forms.Padding(2)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(145, 26)
        Me.Ti.TabIndex = 23
        '
        'Lc
        '
        Me.Lc.AutoSize = True
        Me.Lc.ForeColor = System.Drawing.Color.Gold
        Me.Lc.Location = New System.Drawing.Point(80, 89)
        Me.Lc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lc.Name = "Lc"
        Me.Lc.Size = New System.Drawing.Size(112, 20)
        Me.Lc.TabIndex = 22
        Me.Lc.Text = "Dame cifras"
        '
        'Li
        '
        Me.Li.AutoSize = True
        Me.Li.ForeColor = System.Drawing.Color.Gold
        Me.Li.Location = New System.Drawing.Point(80, 46)
        Me.Li.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Li.Name = "Li"
        Me.Li.Size = New System.Drawing.Size(109, 20)
        Me.Li.TabIndex = 21
        Me.Li.Text = "Dame inicio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(460, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(310, 20)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "AGUILÁCTICAS NEWTON RAPSON"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.MenuMetodosN.My.Resources.Resources.america2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(913, 608)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tfd)
        Me.Controls.Add(Me.Tf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Tc)
        Me.Controls.Add(Me.Ti)
        Me.Controls.Add(Me.Lc)
        Me.Controls.Add(Me.Li)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tfd As TextBox
    Friend WithEvents Tf As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents Tc As TextBox
    Friend WithEvents Ti As TextBox
    Friend WithEvents Lc As Label
    Friend WithEvents Li As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
End Class
