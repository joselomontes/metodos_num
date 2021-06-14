<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_8
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.th = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.ty0 = New System.Windows.Forms.TextBox()
        Me.tx0 = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(228, 671)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 26)
        Me.TextBox1.TabIndex = 236
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(74, 674)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Raíz aproximada"
        '
        'th
        '
        Me.th.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.th.Location = New System.Drawing.Point(245, 366)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(254, 26)
        Me.th.TabIndex = 234
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(129, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Dame h"
        '
        'txf
        '
        Me.txf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txf.Location = New System.Drawing.Point(245, 303)
        Me.txf.Name = "txf"
        Me.txf.Size = New System.Drawing.Size(254, 26)
        Me.txf.TabIndex = 232
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(129, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Dame xf"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(891, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 34)
        Me.Button1.TabIndex = 230
        Me.Button1.Text = "&Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(927, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 20)
        Me.Label11.TabIndex = 229
        Me.Label11.Text = "AGUILÁCTICAS RUNGE KUTTA"
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.Khaki
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(620, 446)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(758, 382)
        Me.Salida.TabIndex = 228
        '
        'Column1
        '
        Me.Column1.HeaderText = "n"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "xi"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "yi"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Gold
        Me.Salir.Location = New System.Drawing.Point(891, 309)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(116, 29)
        Me.Salir.TabIndex = 227
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Gold
        Me.Calcular.Location = New System.Drawing.Point(891, 172)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(116, 34)
        Me.Calcular.TabIndex = 226
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'tc
        '
        Me.tc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tc.Location = New System.Drawing.Point(891, 104)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(254, 26)
        Me.tc.TabIndex = 225
        '
        'ty0
        '
        Me.ty0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ty0.Location = New System.Drawing.Point(245, 232)
        Me.ty0.Name = "ty0"
        Me.ty0.Size = New System.Drawing.Size(254, 26)
        Me.ty0.TabIndex = 224
        '
        'tx0
        '
        Me.tx0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tx0.Location = New System.Drawing.Point(245, 153)
        Me.tx0.Name = "tx0"
        Me.tx0.Size = New System.Drawing.Size(254, 26)
        Me.tx0.TabIndex = 223
        '
        'tf
        '
        Me.tf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tf.Location = New System.Drawing.Point(245, 430)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(254, 26)
        Me.tf.TabIndex = 222
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.ForeColor = System.Drawing.Color.Gold
        Me.lc.Location = New System.Drawing.Point(775, 110)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(94, 20)
        Me.lc.TabIndex = 221
        Me.lc.Text = "Dame cifras"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.ForeColor = System.Drawing.Color.Gold
        Me.lb.Location = New System.Drawing.Point(129, 238)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(72, 20)
        Me.lb.TabIndex = 220
        Me.lb.Text = "Dame y0"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.ForeColor = System.Drawing.Color.Gold
        Me.la.Location = New System.Drawing.Point(129, 159)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(72, 20)
        Me.la.TabIndex = 219
        Me.la.Text = "Dame x0"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.ForeColor = System.Drawing.Color.Gold
        Me.lf.Location = New System.Drawing.Point(129, 436)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(108, 20)
        Me.lf.TabIndex = 218
        Me.lf.Text = "Dame función"
        '
        'Form3_8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.MenuMetodosN.My.Resources.Resources.america2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1452, 878)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.ty0)
        Me.Controls.Add(Me.tx0)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lf)
        Me.Name = "Form3_8"
        Me.Text = "Form3_8"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents th As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txf As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents tc As TextBox
    Friend WithEvents ty0 As TextBox
    Friend WithEvents tx0 As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents lc As Label
    Friend WithEvents lb As Label
    Friend WithEvents la As Label
    Friend WithEvents lf As Label
End Class
