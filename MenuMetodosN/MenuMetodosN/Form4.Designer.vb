<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Respuesta = New System.Windows.Forms.TextBox()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 540)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "La raíz aproximada es:"
        '
        'Respuesta
        '
        Me.Respuesta.Location = New System.Drawing.Point(352, 536)
        Me.Respuesta.Margin = New System.Windows.Forms.Padding(2)
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.Size = New System.Drawing.Size(95, 20)
        Me.Respuesta.TabIndex = 26
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Salida.Location = New System.Drawing.Point(135, 276)
        Me.Salida.Margin = New System.Windows.Forms.Padding(2)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(809, 242)
        Me.Salida.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "a"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "xi"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "b"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "f(a)"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "f(xi)"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "f(b)"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "error"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(760, 210)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(77, 19)
        Me.Salir.TabIndex = 23
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(760, 133)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(77, 22)
        Me.Calcular.TabIndex = 22
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(336, 239)
        Me.tc.Margin = New System.Windows.Forms.Padding(2)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(171, 20)
        Me.tc.TabIndex = 21
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(336, 189)
        Me.tb.Margin = New System.Windows.Forms.Padding(2)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(171, 20)
        Me.tb.TabIndex = 20
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(336, 138)
        Me.ta.Margin = New System.Windows.Forms.Padding(2)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(171, 20)
        Me.ta.TabIndex = 19
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(336, 97)
        Me.tf.Margin = New System.Windows.Forms.Padding(2)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(171, 20)
        Me.tf.TabIndex = 18
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Location = New System.Drawing.Point(220, 243)
        Me.lc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(63, 13)
        Me.lc.TabIndex = 17
        Me.lc.Text = "Dame cifras"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(220, 193)
        Me.lb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(44, 13)
        Me.lb.TabIndex = 16
        Me.lb.Text = "Dame b"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(220, 142)
        Me.la.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(44, 13)
        Me.la.TabIndex = 15
        Me.la.Text = "Dame a"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(220, 101)
        Me.lf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 14
        Me.lf.Text = "Dame función"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(540, 96)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 97)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 652)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Respuesta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lf)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Respuesta As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents tc As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents lc As Label
    Friend WithEvents lb As Label
    Friend WithEvents la As Label
    Friend WithEvents lf As Label
End Class
