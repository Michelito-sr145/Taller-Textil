<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovimientosInsumos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PaDgvEntrada = New System.Windows.Forms.Panel()
        Me.DGVEntrada = New System.Windows.Forms.DataGridView()
        Me.IdInsumoEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInsEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuarioEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInsEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreInsEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantInsEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniInsEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdInsumoInsEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaDgvSalida = New System.Windows.Forms.Panel()
        Me.DGVSalida = New System.Windows.Forms.DataGridView()
        Me.IdInsumoSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInsSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuariosal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInsSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreInsSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantInsSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniInsSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdInsumoInsSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaBusCodigo = New System.Windows.Forms.Panel()
        Me.DtpAnio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbBusCode = New System.Windows.Forms.TextBox()
        Me.BtnGrafico = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaGrafEntSal = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LaCodi = New System.Windows.Forms.Label()
        Me.LaFecha = New System.Windows.Forms.Label()
        Me.LaNombre = New System.Windows.Forms.Label()
        Me.TbDescrip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LaTotal = New System.Windows.Forms.Label()
        Me.LaCant = New System.Windows.Forms.Label()
        Me.LaPre = New System.Windows.Forms.Label()
        Me.PaGeneralGf = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaDgvEntrada.SuspendLayout()
        CType(Me.DGVEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaDgvSalida.SuspendLayout()
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaBusCodigo.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaGrafEntSal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PaGeneralGf.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaDgvEntrada
        '
        Me.PaDgvEntrada.Controls.Add(Me.DGVEntrada)
        Me.PaDgvEntrada.Controls.Add(Me.Label1)
        Me.PaDgvEntrada.Location = New System.Drawing.Point(12, 34)
        Me.PaDgvEntrada.Name = "PaDgvEntrada"
        Me.PaDgvEntrada.Size = New System.Drawing.Size(432, 187)
        Me.PaDgvEntrada.TabIndex = 2
        '
        'DGVEntrada
        '
        Me.DGVEntrada.AllowUserToAddRows = False
        Me.DGVEntrada.AllowUserToDeleteRows = False
        Me.DGVEntrada.AllowUserToOrderColumns = True
        Me.DGVEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntrada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInsumoEnt, Me.FechaInsEnt, Me.IdUsuarioEnt, Me.CodigoInsEnt, Me.NombreInsEnt, Me.CantInsEnt, Me.PrecioUniInsEnt, Me.TotalEnt, Me.IdInsumoInsEnt})
        Me.DGVEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVEntrada.Location = New System.Drawing.Point(0, 22)
        Me.DGVEntrada.Name = "DGVEntrada"
        Me.DGVEntrada.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVEntrada.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEntrada.Size = New System.Drawing.Size(432, 165)
        Me.DGVEntrada.TabIndex = 0
        '
        'IdInsumoEnt
        '
        Me.IdInsumoEnt.DataPropertyName = "IdInsumoEnt"
        Me.IdInsumoEnt.HeaderText = "IdInsumoEnt"
        Me.IdInsumoEnt.Name = "IdInsumoEnt"
        Me.IdInsumoEnt.ReadOnly = True
        Me.IdInsumoEnt.Visible = False
        '
        'FechaInsEnt
        '
        Me.FechaInsEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaInsEnt.DataPropertyName = "FechaInsEnt"
        Me.FechaInsEnt.HeaderText = "Fecha Entrada"
        Me.FechaInsEnt.Name = "FechaInsEnt"
        Me.FechaInsEnt.ReadOnly = True
        Me.FechaInsEnt.Width = 102
        '
        'IdUsuarioEnt
        '
        Me.IdUsuarioEnt.DataPropertyName = "IdUsuario"
        Me.IdUsuarioEnt.HeaderText = "IdUsuario"
        Me.IdUsuarioEnt.Name = "IdUsuarioEnt"
        Me.IdUsuarioEnt.ReadOnly = True
        Me.IdUsuarioEnt.Visible = False
        '
        'CodigoInsEnt
        '
        Me.CodigoInsEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoInsEnt.DataPropertyName = "CodigoInsEnt"
        Me.CodigoInsEnt.HeaderText = "Codigo"
        Me.CodigoInsEnt.Name = "CodigoInsEnt"
        Me.CodigoInsEnt.ReadOnly = True
        Me.CodigoInsEnt.Width = 65
        '
        'NombreInsEnt
        '
        Me.NombreInsEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreInsEnt.DataPropertyName = "NombreInsEnt"
        Me.NombreInsEnt.HeaderText = "Nombre"
        Me.NombreInsEnt.Name = "NombreInsEnt"
        Me.NombreInsEnt.ReadOnly = True
        Me.NombreInsEnt.Width = 69
        '
        'CantInsEnt
        '
        Me.CantInsEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantInsEnt.DataPropertyName = "CantInsEnt"
        Me.CantInsEnt.HeaderText = "CantIdad"
        Me.CantInsEnt.Name = "CantInsEnt"
        Me.CantInsEnt.ReadOnly = True
        Me.CantInsEnt.Width = 75
        '
        'PrecioUniInsEnt
        '
        Me.PrecioUniInsEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioUniInsEnt.DataPropertyName = "PrecioUniInsEnt"
        Me.PrecioUniInsEnt.HeaderText = "PrecioUni"
        Me.PrecioUniInsEnt.Name = "PrecioUniInsEnt"
        Me.PrecioUniInsEnt.ReadOnly = True
        Me.PrecioUniInsEnt.Width = 78
        '
        'TotalEnt
        '
        Me.TotalEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TotalEnt.DataPropertyName = "Total"
        Me.TotalEnt.HeaderText = "Total"
        Me.TotalEnt.Name = "TotalEnt"
        Me.TotalEnt.ReadOnly = True
        Me.TotalEnt.Width = 56
        '
        'IdInsumoInsEnt
        '
        Me.IdInsumoInsEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdInsumoInsEnt.DataPropertyName = "IdInsumo"
        Me.IdInsumoInsEnt.HeaderText = "IdInsumo"
        Me.IdInsumoInsEnt.Name = "IdInsumoInsEnt"
        Me.IdInsumoInsEnt.ReadOnly = True
        Me.IdInsumoInsEnt.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Movimientos de Entrada : "
        '
        'PaDgvSalida
        '
        Me.PaDgvSalida.Controls.Add(Me.DGVSalida)
        Me.PaDgvSalida.Controls.Add(Me.Label2)
        Me.PaDgvSalida.Location = New System.Drawing.Point(450, 34)
        Me.PaDgvSalida.Name = "PaDgvSalida"
        Me.PaDgvSalida.Size = New System.Drawing.Size(423, 187)
        Me.PaDgvSalida.TabIndex = 3
        '
        'DGVSalida
        '
        Me.DGVSalida.AllowUserToAddRows = False
        Me.DGVSalida.AllowUserToDeleteRows = False
        Me.DGVSalida.AllowUserToOrderColumns = True
        Me.DGVSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInsumoSal, Me.FechaInsSal, Me.IdUsuariosal, Me.CodigoInsSal, Me.NombreInsSal, Me.CantInsSal, Me.PrecioUniInsSal, Me.DataGridViewTextBoxColumn8, Me.IdInsumoInsSal})
        Me.DGVSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVSalida.Location = New System.Drawing.Point(0, 22)
        Me.DGVSalida.Name = "DGVSalida"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVSalida.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSalida.Size = New System.Drawing.Size(423, 165)
        Me.DGVSalida.TabIndex = 0
        '
        'IdInsumoSal
        '
        Me.IdInsumoSal.DataPropertyName = "IdInsumoSal"
        Me.IdInsumoSal.HeaderText = "IdInsumoSal"
        Me.IdInsumoSal.Name = "IdInsumoSal"
        Me.IdInsumoSal.ReadOnly = True
        Me.IdInsumoSal.Visible = False
        '
        'FechaInsSal
        '
        Me.FechaInsSal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaInsSal.DataPropertyName = "FechaInsSal"
        Me.FechaInsSal.HeaderText = "Fecha Salida"
        Me.FechaInsSal.Name = "FechaInsSal"
        Me.FechaInsSal.Width = 94
        '
        'IdUsuariosal
        '
        Me.IdUsuariosal.DataPropertyName = "IdUsuario"
        Me.IdUsuariosal.HeaderText = "IdUsuario"
        Me.IdUsuariosal.Name = "IdUsuariosal"
        Me.IdUsuariosal.ReadOnly = True
        Me.IdUsuariosal.Visible = False
        '
        'CodigoInsSal
        '
        Me.CodigoInsSal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoInsSal.DataPropertyName = "CodigoInsSal"
        Me.CodigoInsSal.HeaderText = "Codigo"
        Me.CodigoInsSal.Name = "CodigoInsSal"
        Me.CodigoInsSal.ReadOnly = True
        Me.CodigoInsSal.Width = 65
        '
        'NombreInsSal
        '
        Me.NombreInsSal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreInsSal.DataPropertyName = "NombreInsSal"
        Me.NombreInsSal.HeaderText = "Nombre"
        Me.NombreInsSal.Name = "NombreInsSal"
        Me.NombreInsSal.ReadOnly = True
        Me.NombreInsSal.Width = 69
        '
        'CantInsSal
        '
        Me.CantInsSal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantInsSal.DataPropertyName = "CantInsSal"
        Me.CantInsSal.HeaderText = "CantIdad"
        Me.CantInsSal.Name = "CantInsSal"
        Me.CantInsSal.ReadOnly = True
        Me.CantInsSal.Width = 75
        '
        'PrecioUniInsSal
        '
        Me.PrecioUniInsSal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioUniInsSal.DataPropertyName = "PrecioUniInsSal"
        Me.PrecioUniInsSal.HeaderText = "PrecioUni"
        Me.PrecioUniInsSal.Name = "PrecioUniInsSal"
        Me.PrecioUniInsSal.ReadOnly = True
        Me.PrecioUniInsSal.Width = 78
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 56
        '
        'IdInsumoInsSal
        '
        Me.IdInsumoInsSal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdInsumoInsSal.DataPropertyName = "IdInsumo"
        Me.IdInsumoInsSal.HeaderText = "IdInsumo"
        Me.IdInsumoInsSal.Name = "IdInsumoInsSal"
        Me.IdInsumoInsSal.ReadOnly = True
        Me.IdInsumoInsSal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Movimientos de Salida :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PaBusCodigo
        '
        Me.PaBusCodigo.Controls.Add(Me.DtpAnio)
        Me.PaBusCodigo.Controls.Add(Me.Label3)
        Me.PaBusCodigo.Controls.Add(Me.TbBusCode)
        Me.PaBusCodigo.Controls.Add(Me.BtnGrafico)
        Me.PaBusCodigo.Location = New System.Drawing.Point(889, 12)
        Me.PaBusCodigo.Name = "PaBusCodigo"
        Me.PaBusCodigo.Size = New System.Drawing.Size(126, 188)
        Me.PaBusCodigo.TabIndex = 6
        '
        'DtpAnio
        '
        Me.DtpAnio.CalendarFont = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnio.CustomFormat = "yyyy"
        Me.DtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAnio.Location = New System.Drawing.Point(37, 144)
        Me.DtpAnio.Name = "DtpAnio"
        Me.DtpAnio.Size = New System.Drawing.Size(47, 20)
        Me.DtpAnio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 56)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Digite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codigo:"
        '
        'TbBusCode
        '
        Me.TbBusCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBusCode.Location = New System.Drawing.Point(8, 83)
        Me.TbBusCode.Name = "TbBusCode"
        Me.TbBusCode.Size = New System.Drawing.Size(110, 26)
        Me.TbBusCode.TabIndex = 2
        '
        'BtnGrafico
        '
        Me.BtnGrafico.Location = New System.Drawing.Point(21, 115)
        Me.BtnGrafico.Name = "BtnGrafico"
        Me.BtnGrafico.Size = New System.Drawing.Size(85, 23)
        Me.BtnGrafico.TabIndex = 0
        Me.BtnGrafico.Text = "Ver Grafico"
        Me.BtnGrafico.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Right
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(213, 0)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(395, 299)
        Me.Chart2.TabIndex = 8
        Me.Chart2.Tag = "1"
        Me.Chart2.Text = "Chart2"
        '
        'Chart3
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea2)
        Me.Chart3.Dock = System.Windows.Forms.DockStyle.Right
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend2)
        Me.Chart3.Location = New System.Drawing.Point(608, 0)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart3.Series.Add(Series2)
        Me.Chart3.Size = New System.Drawing.Size(395, 299)
        Me.Chart3.TabIndex = 9
        Me.Chart3.Tag = "2"
        Me.Chart3.Text = "Chart3"
        '
        'PaGrafEntSal
        '
        Me.PaGrafEntSal.Controls.Add(Me.Chart2)
        Me.PaGrafEntSal.Controls.Add(Me.Chart3)
        Me.PaGrafEntSal.Controls.Add(Me.Panel1)
        Me.PaGrafEntSal.Location = New System.Drawing.Point(16, 482)
        Me.PaGrafEntSal.Name = "PaGrafEntSal"
        Me.PaGrafEntSal.Size = New System.Drawing.Size(1003, 299)
        Me.PaGrafEntSal.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LaCodi)
        Me.Panel1.Controls.Add(Me.LaFecha)
        Me.Panel1.Controls.Add(Me.LaNombre)
        Me.Panel1.Controls.Add(Me.TbDescrip)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LaTotal)
        Me.Panel1.Controls.Add(Me.LaCant)
        Me.Panel1.Controls.Add(Me.LaPre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 299)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 33)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Stock Actual"
        '
        'LaCodi
        '
        Me.LaCodi.AutoSize = True
        Me.LaCodi.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCodi.Location = New System.Drawing.Point(3, 37)
        Me.LaCodi.Name = "LaCodi"
        Me.LaCodi.Size = New System.Drawing.Size(81, 19)
        Me.LaCodi.TabIndex = 17
        Me.LaCodi.Text = "Codigo :"
        '
        'LaFecha
        '
        Me.LaFecha.AutoSize = True
        Me.LaFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic)
        Me.LaFecha.Location = New System.Drawing.Point(5, 191)
        Me.LaFecha.Name = "LaFecha"
        Me.LaFecha.Size = New System.Drawing.Size(54, 19)
        Me.LaFecha.TabIndex = 29
        Me.LaFecha.Text = "Fecha"
        '
        'LaNombre
        '
        Me.LaNombre.AutoSize = True
        Me.LaNombre.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaNombre.Location = New System.Drawing.Point(3, 57)
        Me.LaNombre.Name = "LaNombre"
        Me.LaNombre.Size = New System.Drawing.Size(81, 19)
        Me.LaNombre.TabIndex = 19
        Me.LaNombre.Text = "Nombre :"
        '
        'TbDescrip
        '
        Me.TbDescrip.Location = New System.Drawing.Point(7, 99)
        Me.TbDescrip.Multiline = True
        Me.TbDescrip.Name = "TbDescrip"
        Me.TbDescrip.Size = New System.Drawing.Size(186, 89)
        Me.TbDescrip.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Descripcion :"
        '
        'LaTotal
        '
        Me.LaTotal.AutoSize = True
        Me.LaTotal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTotal.Location = New System.Drawing.Point(83, 263)
        Me.LaTotal.Name = "LaTotal"
        Me.LaTotal.Size = New System.Drawing.Size(49, 15)
        Me.LaTotal.TabIndex = 27
        Me.LaTotal.Text = "Label9"
        '
        'LaCant
        '
        Me.LaCant.AutoSize = True
        Me.LaCant.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCant.Location = New System.Drawing.Point(3, 215)
        Me.LaCant.Name = "LaCant"
        Me.LaCant.Size = New System.Drawing.Size(99, 19)
        Me.LaCant.TabIndex = 23
        Me.LaCant.Text = "Cantidad :"
        '
        'LaPre
        '
        Me.LaPre.AutoSize = True
        Me.LaPre.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaPre.Location = New System.Drawing.Point(3, 243)
        Me.LaPre.Name = "LaPre"
        Me.LaPre.Size = New System.Drawing.Size(180, 19)
        Me.LaPre.TabIndex = 25
        Me.LaPre.Text = "Precio por Unidad :"
        '
        'PaGeneralGf
        '
        Me.PaGeneralGf.Controls.Add(Me.Chart1)
        Me.PaGeneralGf.Location = New System.Drawing.Point(12, 227)
        Me.PaGeneralGf.Name = "PaGeneralGf"
        Me.PaGeneralGf.Size = New System.Drawing.Size(861, 249)
        Me.PaGeneralGf.TabIndex = 11
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(861, 249)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'MovimientosInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 788)
        Me.Controls.Add(Me.PaGeneralGf)
        Me.Controls.Add(Me.PaGrafEntSal)
        Me.Controls.Add(Me.PaDgvSalida)
        Me.Controls.Add(Me.PaDgvEntrada)
        Me.Controls.Add(Me.PaBusCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MovimientosInsumos"
        Me.Text = "MovimientosInsumos"
        Me.PaDgvEntrada.ResumeLayout(False)
        Me.PaDgvEntrada.PerformLayout()
        CType(Me.DGVEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaDgvSalida.ResumeLayout(False)
        Me.PaDgvSalida.PerformLayout()
        CType(Me.DGVSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaBusCodigo.ResumeLayout(False)
        Me.PaBusCodigo.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaGrafEntSal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PaGeneralGf.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaDgvEntrada As Panel
    Friend WithEvents DGVEntrada As DataGridView
    Friend WithEvents PaDgvSalida As Panel
    Friend WithEvents DGVSalida As DataGridView
    Friend WithEvents IdInsumoEnt As DataGridViewTextBoxColumn
    Friend WithEvents FechaInsEnt As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarioEnt As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInsEnt As DataGridViewTextBoxColumn
    Friend WithEvents NombreInsEnt As DataGridViewTextBoxColumn
    Friend WithEvents CantInsEnt As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniInsEnt As DataGridViewTextBoxColumn
    Friend WithEvents TotalEnt As DataGridViewTextBoxColumn
    Friend WithEvents IdInsumoInsEnt As DataGridViewTextBoxColumn
    Friend WithEvents IdInsumoSal As DataGridViewTextBoxColumn
    Friend WithEvents FechaInsSal As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuariosal As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInsSal As DataGridViewTextBoxColumn
    Friend WithEvents NombreInsSal As DataGridViewTextBoxColumn
    Friend WithEvents CantInsSal As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniInsSal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents IdInsumoInsSal As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PaBusCodigo As Panel
    Friend WithEvents TbBusCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnGrafico As Button
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents PaGrafEntSal As Panel
    Friend WithEvents LaTotal As Label
    Friend WithEvents LaPre As Label
    Friend WithEvents LaCant As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LaNombre As Label
    Friend WithEvents LaCodi As Label
    Friend WithEvents TbDescrip As TextBox
    Friend WithEvents LaFecha As Label
    Friend WithEvents DtpAnio As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents PaGeneralGf As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
End Class
