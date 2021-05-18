<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_1
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Gráfica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Salida2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tvx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Salida1 = New System.Windows.Forms.DataGridView()
        Me.índice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Gráfica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salida1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gold
        Me.Button6.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Button6.Location = New System.Drawing.Point(576, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 35)
        Me.Button6.TabIndex = 215
        Me.Button6.Text = "&Introducir parejas"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(311, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "s ="
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(364, 358)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(183, 26)
        Me.TextBox4.TabIndex = 213
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(311, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "m ="
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(364, 308)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(183, 26)
        Me.TextBox3.TabIndex = 211
        '
        'Gráfica
        '
        Me.Gráfica.BackColor = System.Drawing.Color.Khaki
        ChartArea1.Name = "ChartArea1"
        Me.Gráfica.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Gráfica.Legends.Add(Legend1)
        Me.Gráfica.Location = New System.Drawing.Point(825, 92)
        Me.Gráfica.Name = "Gráfica"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Color = System.Drawing.Color.Blue
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Gráfica.Series.Add(Series1)
        Me.Gráfica.Series.Add(Series2)
        Me.Gráfica.Size = New System.Drawing.Size(551, 520)
        Me.Gráfica.TabIndex = 210
        Me.Gráfica.Text = "Chart1"
        '
        'Salida2
        '
        Me.Salida2.BackgroundColor = System.Drawing.Color.Khaki
        Me.Salida2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Salida2.Location = New System.Drawing.Point(850, 634)
        Me.Salida2.Name = "Salida2"
        Me.Salida2.RowHeadersWidth = 62
        Me.Salida2.RowTemplate.Height = 28
        Me.Salida2.Size = New System.Drawing.Size(511, 203)
        Me.Salida2.TabIndex = 209
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "coeficientes"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "deltas k"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Button3.Location = New System.Drawing.Point(604, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 36)
        Me.Button3.TabIndex = 208
        Me.Button3.Text = "&Calcular"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(221, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Interpolación"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(364, 439)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 26)
        Me.TextBox2.TabIndex = 206
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(311, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "ib ="
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 26)
        Me.TextBox1.TabIndex = 204
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Button2.Location = New System.Drawing.Point(604, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 36)
        Me.Button2.TabIndex = 203
        Me.Button2.Text = "&Graficar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tvx
        '
        Me.tvx.Location = New System.Drawing.Point(364, 137)
        Me.tvx.Name = "tvx"
        Me.tvx.Size = New System.Drawing.Size(183, 26)
        Me.tvx.TabIndex = 202
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(113, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 20)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Dame el número a interpolar"
        '
        'tn
        '
        Me.tn.Location = New System.Drawing.Point(364, 68)
        Me.tn.Name = "tn"
        Me.tn.Size = New System.Drawing.Size(183, 26)
        Me.tn.TabIndex = 200
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(113, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 20)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "Dame el número de parejas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(800, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(334, 20)
        Me.Label11.TabIndex = 198
        Me.Label11.Text = "AGUILÁCTICAS INTERPOLACIÓN NEWTON"
        '
        'Salida1
        '
        Me.Salida1.BackgroundColor = System.Drawing.Color.Khaki
        Me.Salida1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.índice, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Salida1.Location = New System.Drawing.Point(51, 492)
        Me.Salida1.Name = "Salida1"
        Me.Salida1.RowHeadersWidth = 62
        Me.Salida1.RowTemplate.Height = 28
        Me.Salida1.Size = New System.Drawing.Size(747, 336)
        Me.Salida1.TabIndex = 197
        '
        'índice
        '
        Me.índice.HeaderText = "índice"
        Me.índice.MinimumWidth = 8
        Me.índice.Name = "índice"
        Me.índice.Width = 90
        '
        'Column1
        '
        Me.Column1.HeaderText = "x(i)(deltak 0)"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "y(i)(deltak 0)"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Δ1"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.HeaderText = "Δ2"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 90
        '
        'Column5
        '
        Me.Column5.HeaderText = "Δ3"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "Δ4"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.HeaderText = "Δ5"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 90
        '
        'Column8
        '
        Me.Column8.HeaderText = "Δ6"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 90
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Gold
        Me.Salir.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Salir.Location = New System.Drawing.Point(604, 349)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(113, 33)
        Me.Salir.TabIndex = 196
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Button1.Location = New System.Drawing.Point(604, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 33)
        Me.Button1.TabIndex = 195
        Me.Button1.Text = "&Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(364, 202)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(183, 26)
        Me.tc.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(113, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "Dame cifras signitivas"
        '
        'Form3_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.MenuMetodosN.My.Resources.Resources.america2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1426, 884)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Gráfica)
        Me.Controls.Add(Me.Salida2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tvx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Salida1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3_1"
        Me.Text = "Form3_1"
        CType(Me.Gráfica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salida1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Gráfica As DataVisualization.Charting.Chart
    Friend WithEvents Salida2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents tvx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Salida1 As DataGridView
    Friend WithEvents índice As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Salir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tc As TextBox
    Friend WithEvents Label1 As Label
End Class
