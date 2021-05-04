<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impares = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Tn = New System.Windows.Forms.TextBox()
        Me.ln = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.Khaki
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Indice, Me.Impares})
        Me.Salida.Location = New System.Drawing.Point(58, 104)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(423, 271)
        Me.Salida.TabIndex = 10
        '
        'Indice
        '
        Me.Indice.HeaderText = "Índice"
        Me.Indice.MinimumWidth = 8
        Me.Indice.Name = "Indice"
        Me.Indice.Width = 150
        '
        'Impares
        '
        Me.Impares.HeaderText = "Impares"
        Me.Impares.MinimumWidth = 8
        Me.Impares.Name = "Impares"
        Me.Impares.Width = 150
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Gold
        Me.Salir.Location = New System.Drawing.Point(558, 243)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 34)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Gold
        Me.Calcular.Location = New System.Drawing.Point(558, 198)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 34)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Tn
        '
        Me.Tn.Location = New System.Drawing.Point(260, 48)
        Me.Tn.Name = "Tn"
        Me.Tn.Size = New System.Drawing.Size(100, 26)
        Me.Tn.TabIndex = 7
        '
        'ln
        '
        Me.ln.AutoSize = True
        Me.ln.ForeColor = System.Drawing.Color.Gold
        Me.ln.Location = New System.Drawing.Point(45, 51)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(192, 20)
        Me.ln.TabIndex = 6
        Me.ln.Text = "Dame numero de impares"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(431, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 20)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "AGUILÁCTICAS IMPARES"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.MenuMetodosN.My.Resources.Resources.america2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(752, 500)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Tn)
        Me.Controls.Add(Me.ln)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salida As DataGridView
    Friend WithEvents Indice As DataGridViewTextBoxColumn
    Friend WithEvents Impares As DataGridViewTextBoxColumn
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents Tn As TextBox
    Friend WithEvents ln As Label
    Friend WithEvents Label11 As Label
End Class
