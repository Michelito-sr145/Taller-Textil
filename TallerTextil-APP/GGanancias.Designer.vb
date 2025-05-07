<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GGanancias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BtnMensual = New System.Windows.Forms.Button()
        Me.BtnSemestral = New System.Windows.Forms.Button()
        Me.BtnAnual = New System.Windows.Forms.Button()
        Me.PaBotones = New System.Windows.Forms.Panel()
        Me.DtpAnio = New System.Windows.Forms.DateTimePicker()
        Me.DtpCompa = New System.Windows.Forms.DateTimePicker()
        Me.BtnCompa = New System.Windows.Forms.Button()
        Me.PaMensual = New System.Windows.Forms.Panel()
        Me.datosLabel = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaSemestral = New System.Windows.Forms.Panel()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaAnual = New System.Windows.Forms.Panel()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaCompSemes = New System.Windows.Forms.Panel()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaCompAnual = New System.Windows.Forms.Panel()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnOcul = New System.Windows.Forms.Button()
        Me.tbSeme2 = New System.Windows.Forms.TextBox()
        Me.tbSeme1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PaBotones.SuspendLayout()
        Me.PaMensual.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaSemestral.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaAnual.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaCompSemes.SuspendLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaCompAnual.SuspendLayout()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMensual
        '
        Me.BtnMensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMensual.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMensual.Location = New System.Drawing.Point(3, 5)
        Me.BtnMensual.Name = "BtnMensual"
        Me.BtnMensual.Size = New System.Drawing.Size(84, 28)
        Me.BtnMensual.TabIndex = 2
        Me.BtnMensual.Text = "Mensual"
        Me.BtnMensual.UseVisualStyleBackColor = True
        '
        'BtnSemestral
        '
        Me.BtnSemestral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSemestral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSemestral.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSemestral.Location = New System.Drawing.Point(88, 5)
        Me.BtnSemestral.Name = "BtnSemestral"
        Me.BtnSemestral.Size = New System.Drawing.Size(94, 28)
        Me.BtnSemestral.TabIndex = 3
        Me.BtnSemestral.Text = "Semestral"
        Me.BtnSemestral.UseVisualStyleBackColor = True
        '
        'BtnAnual
        '
        Me.BtnAnual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.BtnAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnual.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnual.Location = New System.Drawing.Point(183, 5)
        Me.BtnAnual.Name = "BtnAnual"
        Me.BtnAnual.Size = New System.Drawing.Size(84, 28)
        Me.BtnAnual.TabIndex = 4
        Me.BtnAnual.Text = "Anual"
        Me.BtnAnual.UseVisualStyleBackColor = True
        '
        'PaBotones
        '
        Me.PaBotones.Controls.Add(Me.DtpAnio)
        Me.PaBotones.Controls.Add(Me.BtnMensual)
        Me.PaBotones.Controls.Add(Me.BtnAnual)
        Me.PaBotones.Controls.Add(Me.BtnSemestral)
        Me.PaBotones.Location = New System.Drawing.Point(12, 12)
        Me.PaBotones.Name = "PaBotones"
        Me.PaBotones.Size = New System.Drawing.Size(346, 40)
        Me.PaBotones.TabIndex = 5
        '
        'DtpAnio
        '
        Me.DtpAnio.CalendarFont = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnio.CustomFormat = "yyyy"
        Me.DtpAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAnio.Location = New System.Drawing.Point(273, 7)
        Me.DtpAnio.Name = "DtpAnio"
        Me.DtpAnio.Size = New System.Drawing.Size(70, 26)
        Me.DtpAnio.TabIndex = 5
        '
        'DtpCompa
        '
        Me.DtpCompa.CalendarFont = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpCompa.CustomFormat = "yyyy"
        Me.DtpCompa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpCompa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpCompa.Location = New System.Drawing.Point(91, 7)
        Me.DtpCompa.Name = "DtpCompa"
        Me.DtpCompa.Size = New System.Drawing.Size(66, 26)
        Me.DtpCompa.TabIndex = 12
        '
        'BtnCompa
        '
        Me.BtnCompa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.BtnCompa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompa.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompa.Location = New System.Drawing.Point(161, 5)
        Me.BtnCompa.Name = "BtnCompa"
        Me.BtnCompa.Size = New System.Drawing.Size(84, 28)
        Me.BtnCompa.TabIndex = 11
        Me.BtnCompa.Text = "Comparar"
        Me.BtnCompa.UseVisualStyleBackColor = True
        '
        'PaMensual
        '
        Me.PaMensual.Controls.Add(Me.datosLabel)
        Me.PaMensual.Controls.Add(Me.Chart1)
        Me.PaMensual.Location = New System.Drawing.Point(0, 56)
        Me.PaMensual.Name = "PaMensual"
        Me.PaMensual.Size = New System.Drawing.Size(461, 84)
        Me.PaMensual.TabIndex = 6
        '
        'datosLabel
        '
        Me.datosLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datosLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datosLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datosLabel.Location = New System.Drawing.Point(369, 0)
        Me.datosLabel.Multiline = True
        Me.datosLabel.Name = "datosLabel"
        Me.datosLabel.ReadOnly = True
        Me.datosLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datosLabel.Size = New System.Drawing.Size(92, 84)
        Me.datosLabel.TabIndex = 13
        Me.datosLabel.Text = "hola" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hola" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hola" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hola"
        '
        'Chart1
        '
        ChartArea6.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea6)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Left
        Legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend6.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend6)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(369, 84)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'PaSemestral
        '
        Me.PaSemestral.Controls.Add(Me.Chart2)
        Me.PaSemestral.Location = New System.Drawing.Point(12, 161)
        Me.PaSemestral.Name = "PaSemestral"
        Me.PaSemestral.Size = New System.Drawing.Size(201, 84)
        Me.PaSemestral.TabIndex = 7
        '
        'Chart2
        '
        ChartArea7.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea7)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend7.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend7)
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart2.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Me.Chart2.Series.Add(Series7)
        Me.Chart2.Size = New System.Drawing.Size(201, 84)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart2"
        '
        'PaAnual
        '
        Me.PaAnual.Controls.Add(Me.Chart3)
        Me.PaAnual.Location = New System.Drawing.Point(423, 58)
        Me.PaAnual.Name = "PaAnual"
        Me.PaAnual.Size = New System.Drawing.Size(200, 84)
        Me.PaAnual.TabIndex = 8
        '
        'Chart3
        '
        ChartArea8.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea8)
        Me.Chart3.Dock = System.Windows.Forms.DockStyle.Fill
        Legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend8.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend8)
        Me.Chart3.Location = New System.Drawing.Point(0, 0)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart3.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.RoyalBlue}
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        Me.Chart3.Series.Add(Series8)
        Me.Chart3.Size = New System.Drawing.Size(200, 84)
        Me.Chart3.TabIndex = 0
        Me.Chart3.Text = "Chart3"
        '
        'PaCompSemes
        '
        Me.PaCompSemes.Controls.Add(Me.Chart4)
        Me.PaCompSemes.Location = New System.Drawing.Point(219, 161)
        Me.PaCompSemes.Name = "PaCompSemes"
        Me.PaCompSemes.Size = New System.Drawing.Size(198, 84)
        Me.PaCompSemes.TabIndex = 9
        '
        'Chart4
        '
        ChartArea9.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea9)
        Me.Chart4.Dock = System.Windows.Forms.DockStyle.Fill
        Legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend9.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend9)
        Me.Chart4.Location = New System.Drawing.Point(0, 0)
        Me.Chart4.Name = "Chart4"
        Me.Chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart4.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.Chart4.Series.Add(Series9)
        Me.Chart4.Size = New System.Drawing.Size(198, 84)
        Me.Chart4.TabIndex = 0
        Me.Chart4.Text = "Chart4"
        '
        'PaCompAnual
        '
        Me.PaCompAnual.Controls.Add(Me.Chart5)
        Me.PaCompAnual.Location = New System.Drawing.Point(423, 159)
        Me.PaCompAnual.Name = "PaCompAnual"
        Me.PaCompAnual.Size = New System.Drawing.Size(189, 86)
        Me.PaCompAnual.TabIndex = 10
        '
        'Chart5
        '
        ChartArea10.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea10)
        Me.Chart5.Dock = System.Windows.Forms.DockStyle.Fill
        Legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend10.Name = "Legend1"
        Me.Chart5.Legends.Add(Legend10)
        Me.Chart5.Location = New System.Drawing.Point(0, 0)
        Me.Chart5.Name = "Chart5"
        Me.Chart5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart5.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.RoyalBlue}
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        Me.Chart5.Series.Add(Series10)
        Me.Chart5.Size = New System.Drawing.Size(189, 86)
        Me.Chart5.TabIndex = 0
        Me.Chart5.Text = "Chart5"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnOcul)
        Me.Panel1.Controls.Add(Me.DtpCompa)
        Me.Panel1.Controls.Add(Me.BtnCompa)
        Me.Panel1.Location = New System.Drawing.Point(466, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 40)
        Me.Panel1.TabIndex = 11
        '
        'BtnOcul
        '
        Me.BtnOcul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.BtnOcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOcul.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOcul.Location = New System.Drawing.Point(3, 5)
        Me.BtnOcul.Name = "BtnOcul"
        Me.BtnOcul.Size = New System.Drawing.Size(84, 28)
        Me.BtnOcul.TabIndex = 12
        Me.BtnOcul.Text = "Ocultar"
        Me.BtnOcul.UseVisualStyleBackColor = True
        '
        'tbSeme2
        '
        Me.tbSeme2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSeme2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSeme2.Location = New System.Drawing.Point(1012, 49)
        Me.tbSeme2.Multiline = True
        Me.tbSeme2.Name = "tbSeme2"
        Me.tbSeme2.ReadOnly = True
        Me.tbSeme2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSeme2.Size = New System.Drawing.Size(190, 300)
        Me.tbSeme2.TabIndex = 15
        Me.tbSeme2.Text = "tb2"
        Me.tbSeme2.Visible = False
        '
        'tbSeme1
        '
        Me.tbSeme1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSeme1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSeme1.Location = New System.Drawing.Point(816, 49)
        Me.tbSeme1.Multiline = True
        Me.tbSeme1.Name = "tbSeme1"
        Me.tbSeme1.ReadOnly = True
        Me.tbSeme1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSeme1.Size = New System.Drawing.Size(190, 300)
        Me.tbSeme1.TabIndex = 14
        Me.tbSeme1.Text = "tb1"
        Me.tbSeme1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1012, 381)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(190, 100)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "tb2c"
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Purple
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(816, 394)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(190, 100)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "Tb1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c"
        Me.TextBox2.Visible = False
        '
        'GGanancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 660)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbSeme2)
        Me.Controls.Add(Me.tbSeme1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PaCompAnual)
        Me.Controls.Add(Me.PaCompSemes)
        Me.Controls.Add(Me.PaAnual)
        Me.Controls.Add(Me.PaSemestral)
        Me.Controls.Add(Me.PaMensual)
        Me.Controls.Add(Me.PaBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GGanancias"
        Me.Text = "GGanancias"
        Me.PaBotones.ResumeLayout(False)
        Me.PaMensual.ResumeLayout(False)
        Me.PaMensual.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaSemestral.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaAnual.ResumeLayout(False)
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaCompSemes.ResumeLayout(False)
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaCompAnual.ResumeLayout(False)
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMensual As Button
    Friend WithEvents BtnSemestral As Button
    Friend WithEvents BtnAnual As Button
    Friend WithEvents PaBotones As Panel
    Friend WithEvents PaMensual As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PaSemestral As Panel
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents PaAnual As Panel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents DtpAnio As DateTimePicker
    Friend WithEvents PaCompSemes As Panel
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents PaCompAnual As Panel
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents BtnCompa As Button
    Friend WithEvents DtpCompa As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnOcul As Button
    Friend WithEvents datosLabel As TextBox
    Friend WithEvents tbSeme2 As TextBox
    Friend WithEvents tbSeme1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
