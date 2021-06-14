<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_5
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Gráfica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.Gráfica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gráfica
        '
        Me.Gráfica.BackColor = System.Drawing.Color.Khaki
        Me.Gráfica.BorderlineColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Gráfica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Gráfica.Legends.Add(Legend1)
        Me.Gráfica.Location = New System.Drawing.Point(757, 110)
        Me.Gráfica.Name = "Gráfica"
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Blue
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series2.Color = System.Drawing.Color.Turquoise
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Gráfica.Series.Add(Series1)
        Me.Gráfica.Series.Add(Series2)
        Me.Gráfica.Size = New System.Drawing.Size(702, 657)
        Me.Gráfica.TabIndex = 179
        Me.Gráfica.Text = "Chart1"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(678, 813)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 26)
        Me.TextBox1.TabIndex = 178
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(524, 816)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Raíz aproximada"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(600, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 34)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "&Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(600, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 34)
        Me.Button2.TabIndex = 175
        Me.Button2.Text = "&Graficar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(951, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(334, 20)
        Me.Label11.TabIndex = 174
        Me.Label11.Text = "AGUILÁCTICAS CUADRATURA DE GAUSS"
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.Khaki
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(61, 467)
        Me.Salida.Name = "Salida"
        Me.Salida.RowHeadersWidth = 62
        Me.Salida.RowTemplate.Height = 28
        Me.Salida.Size = New System.Drawing.Size(579, 330)
        Me.Salida.TabIndex = 173
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
        Me.Column2.HeaderText = "Integral"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "error"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Gold
        Me.Salir.Location = New System.Drawing.Point(600, 316)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(116, 29)
        Me.Salir.TabIndex = 172
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Gold
        Me.Calcular.Location = New System.Drawing.Point(600, 100)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(116, 34)
        Me.Calcular.TabIndex = 171
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'tc
        '
        Me.tc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tc.Location = New System.Drawing.Point(269, 317)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(254, 26)
        Me.tc.TabIndex = 170
        '
        'tb
        '
        Me.tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb.Location = New System.Drawing.Point(269, 246)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(254, 26)
        Me.tb.TabIndex = 169
        '
        'ta
        '
        Me.ta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ta.Location = New System.Drawing.Point(269, 167)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(254, 26)
        Me.ta.TabIndex = 168
        '
        'tf
        '
        Me.tf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tf.Location = New System.Drawing.Point(269, 104)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(254, 26)
        Me.tf.TabIndex = 167
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.ForeColor = System.Drawing.Color.Gold
        Me.lc.Location = New System.Drawing.Point(153, 323)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(94, 20)
        Me.lc.TabIndex = 166
        Me.lc.Text = "Dame cifras"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.ForeColor = System.Drawing.Color.Gold
        Me.lb.Location = New System.Drawing.Point(153, 252)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(65, 20)
        Me.lb.TabIndex = 165
        Me.lb.Text = "Dame b"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.ForeColor = System.Drawing.Color.Gold
        Me.la.Location = New System.Drawing.Point(153, 173)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(65, 20)
        Me.la.TabIndex = 164
        Me.la.Text = "Dame a"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.ForeColor = System.Drawing.Color.Gold
        Me.lf.Location = New System.Drawing.Point(153, 110)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(108, 20)
        Me.lf.TabIndex = 163
        Me.lf.Text = "Dame función"
        '
        'Form3_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.MenuMetodosN.My.Resources.Resources.america2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1521, 905)
        Me.Controls.Add(Me.Gráfica)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
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
        Me.Name = "Form3_5"
        Me.Text = "Form3_5"
        CType(Me.Gráfica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gráfica As DataVisualization.Charting.Chart
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
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
