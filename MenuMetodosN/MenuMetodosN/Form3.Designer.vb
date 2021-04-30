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
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Indice, Me.Impares})
        Me.Salida.Location = New System.Drawing.Point(251, 174)
        Me.Salida.Margin = New System.Windows.Forms.Padding(2)
        Me.Salida.Name = "Salida"
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(200, 131)
        Me.Salida.TabIndex = 10
        '
        'Indice
        '
        Me.Indice.HeaderText = "Índice"
        Me.Indice.Name = "Indice"
        '
        'Impares
        '
        Me.Impares.HeaderText = "Impares"
        Me.Impares.Name = "Impares"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(518, 222)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(50, 22)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(518, 193)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(50, 22)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Tn
        '
        Me.Tn.Location = New System.Drawing.Point(385, 138)
        Me.Tn.Margin = New System.Windows.Forms.Padding(2)
        Me.Tn.Name = "Tn"
        Me.Tn.Size = New System.Drawing.Size(68, 20)
        Me.Tn.TabIndex = 7
        '
        'ln
        '
        Me.ln.AutoSize = True
        Me.ln.Location = New System.Drawing.Point(242, 140)
        Me.ln.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(127, 13)
        Me.ln.TabIndex = 6
        Me.ln.Text = "Dame numero de impares"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Tn)
        Me.Controls.Add(Me.ln)
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
End Class
