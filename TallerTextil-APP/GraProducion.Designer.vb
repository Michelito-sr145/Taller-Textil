<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraProducion
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.paDtGrViArt = New System.Windows.Forms.Panel()
        Me.DGVArt = New System.Windows.Forms.DataGridView()
        Me.IdProArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeRecibidoArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeEntregaArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TalleArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemporadaArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVFallas = New System.Windows.Forms.DataGridView()
        Me.IdFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeRecibidoFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeEntregadoFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TalleFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripFalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBuscarText = New System.Windows.Forms.Panel()
        Me.DtpAnio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbBuscarNM = New System.Windows.Forms.TextBox()
        Me.btnBusText = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PaGraGeneral = New System.Windows.Forms.Panel()
        Me.PaGraIndi = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LaTempArt = New System.Windows.Forms.Label()
        Me.LaCodiArt = New System.Windows.Forms.Label()
        Me.LaCodi = New System.Windows.Forms.Label()
        Me.LaModeArt = New System.Windows.Forms.Label()
        Me.LaTalleArt = New System.Windows.Forms.Label()
        Me.LaTalle = New System.Windows.Forms.Label()
        Me.LaMode = New System.Windows.Forms.Label()
        Me.LaTemp = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.paDtGrViArt.SuspendLayout()
        CType(Me.DGVArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVFallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBuscarText.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaGraGeneral.SuspendLayout()
        Me.PaGraIndi.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paDtGrViArt
        '
        Me.paDtGrViArt.Controls.Add(Me.DGVArt)
        Me.paDtGrViArt.Location = New System.Drawing.Point(12, 47)
        Me.paDtGrViArt.Name = "paDtGrViArt"
        Me.paDtGrViArt.Size = New System.Drawing.Size(473, 258)
        Me.paDtGrViArt.TabIndex = 45
        '
        'DGVArt
        '
        Me.DGVArt.AllowUserToAddRows = False
        Me.DGVArt.AllowUserToDeleteRows = False
        Me.DGVArt.AllowUserToOrderColumns = True
        Me.DGVArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProArt, Me.DataGridViewTextBoxColumn1, Me.FeRecibidoArt, Me.FeEntregaArt, Me.CodigoArt, Me.ModeloArt, Me.TalleArt, Me.CantArt, Me.PrecioUniArt, Me.DescripArt, Me.TemporadaArt})
        Me.DGVArt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVArt.Location = New System.Drawing.Point(0, 0)
        Me.DGVArt.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVArt.Name = "DGVArt"
        Me.DGVArt.ReadOnly = True
        Me.DGVArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVArt.Size = New System.Drawing.Size(473, 258)
        Me.DGVArt.TabIndex = 19
        '
        'IdProArt
        '
        Me.IdProArt.DataPropertyName = "IdProArt"
        Me.IdProArt.HeaderText = "IdProArt"
        Me.IdProArt.Name = "IdProArt"
        Me.IdProArt.ReadOnly = True
        Me.IdProArt.Visible = False
        Me.IdProArt.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDUsuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDUsuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'FeRecibidoArt
        '
        Me.FeRecibidoArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FeRecibidoArt.DataPropertyName = "FeRecibidoArt"
        Me.FeRecibidoArt.HeaderText = "Recibido"
        Me.FeRecibidoArt.Name = "FeRecibidoArt"
        Me.FeRecibidoArt.ReadOnly = True
        Me.FeRecibidoArt.Width = 74
        '
        'FeEntregaArt
        '
        Me.FeEntregaArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FeEntregaArt.DataPropertyName = "FeEntregaArt"
        Me.FeEntregaArt.HeaderText = "Entrega"
        Me.FeEntregaArt.Name = "FeEntregaArt"
        Me.FeEntregaArt.ReadOnly = True
        Me.FeEntregaArt.Width = 69
        '
        'CodigoArt
        '
        Me.CodigoArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoArt.DataPropertyName = "CodigoArt"
        Me.CodigoArt.HeaderText = "Codigo"
        Me.CodigoArt.Name = "CodigoArt"
        Me.CodigoArt.ReadOnly = True
        Me.CodigoArt.Width = 65
        '
        'ModeloArt
        '
        Me.ModeloArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModeloArt.DataPropertyName = "ModeloArt"
        Me.ModeloArt.HeaderText = "Modelo"
        Me.ModeloArt.Name = "ModeloArt"
        Me.ModeloArt.ReadOnly = True
        Me.ModeloArt.Width = 67
        '
        'TalleArt
        '
        Me.TalleArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TalleArt.DataPropertyName = "TalleArt"
        Me.TalleArt.HeaderText = "Talle"
        Me.TalleArt.Name = "TalleArt"
        Me.TalleArt.ReadOnly = True
        Me.TalleArt.Width = 55
        '
        'CantArt
        '
        Me.CantArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantArt.DataPropertyName = "CantArt"
        Me.CantArt.HeaderText = "Cantidad"
        Me.CantArt.Name = "CantArt"
        Me.CantArt.ReadOnly = True
        Me.CantArt.Width = 74
        '
        'PrecioUniArt
        '
        Me.PrecioUniArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioUniArt.DataPropertyName = "PrecioUniArt"
        Me.PrecioUniArt.HeaderText = "PrecioUn"
        Me.PrecioUniArt.Name = "PrecioUniArt"
        Me.PrecioUniArt.ReadOnly = True
        Me.PrecioUniArt.Width = 76
        '
        'DescripArt
        '
        Me.DescripArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescripArt.DataPropertyName = "DescripArt"
        Me.DescripArt.HeaderText = "Descripcion"
        Me.DescripArt.Name = "DescripArt"
        Me.DescripArt.ReadOnly = True
        Me.DescripArt.Visible = False
        '
        'TemporadaArt
        '
        Me.TemporadaArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TemporadaArt.DataPropertyName = "TemporadaArt"
        Me.TemporadaArt.HeaderText = "Temporada"
        Me.TemporadaArt.Name = "TemporadaArt"
        Me.TemporadaArt.ReadOnly = True
        Me.TemporadaArt.Width = 86
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGVFallas)
        Me.Panel1.Location = New System.Drawing.Point(492, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 258)
        Me.Panel1.TabIndex = 44
        '
        'DGVFallas
        '
        Me.DGVFallas.AllowUserToAddRows = False
        Me.DGVFallas.AllowUserToDeleteRows = False
        Me.DGVFallas.AllowUserToOrderColumns = True
        Me.DGVFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFallas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFalla, Me.IdUsuario, Me.CodigoFalla, Me.FeRecibidoFalla, Me.FeEntregadoFalla, Me.ModeloFalla, Me.TalleFalla, Me.PrecioUniFalla, Me.DescripFalla})
        Me.DGVFallas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVFallas.Location = New System.Drawing.Point(0, 0)
        Me.DGVFallas.Name = "DGVFallas"
        Me.DGVFallas.ReadOnly = True
        Me.DGVFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFallas.Size = New System.Drawing.Size(418, 258)
        Me.DGVFallas.TabIndex = 0
        '
        'IdFalla
        '
        Me.IdFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdFalla.DataPropertyName = "IdFalla"
        Me.IdFalla.HeaderText = "IdFalla"
        Me.IdFalla.Name = "IdFalla"
        Me.IdFalla.ReadOnly = True
        Me.IdFalla.Visible = False
        '
        'IdUsuario
        '
        Me.IdUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'CodigoFalla
        '
        Me.CodigoFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoFalla.DataPropertyName = "CodigoFalla"
        Me.CodigoFalla.HeaderText = "Codigo"
        Me.CodigoFalla.Name = "CodigoFalla"
        Me.CodigoFalla.ReadOnly = True
        Me.CodigoFalla.Width = 65
        '
        'FeRecibidoFalla
        '
        Me.FeRecibidoFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FeRecibidoFalla.DataPropertyName = "FeRecibidoFalla"
        Me.FeRecibidoFalla.HeaderText = "Recibido"
        Me.FeRecibidoFalla.Name = "FeRecibidoFalla"
        Me.FeRecibidoFalla.ReadOnly = True
        Me.FeRecibidoFalla.Width = 74
        '
        'FeEntregadoFalla
        '
        Me.FeEntregadoFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FeEntregadoFalla.DataPropertyName = "FeEntregadoFalla"
        Me.FeEntregadoFalla.HeaderText = "Entregado"
        Me.FeEntregadoFalla.Name = "FeEntregadoFalla"
        Me.FeEntregadoFalla.ReadOnly = True
        Me.FeEntregadoFalla.Width = 81
        '
        'ModeloFalla
        '
        Me.ModeloFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModeloFalla.DataPropertyName = "ModeloFalla"
        Me.ModeloFalla.HeaderText = "Modelo"
        Me.ModeloFalla.Name = "ModeloFalla"
        Me.ModeloFalla.ReadOnly = True
        Me.ModeloFalla.Width = 67
        '
        'TalleFalla
        '
        Me.TalleFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TalleFalla.DataPropertyName = "TalleFalla"
        Me.TalleFalla.HeaderText = "Talle"
        Me.TalleFalla.Name = "TalleFalla"
        Me.TalleFalla.ReadOnly = True
        Me.TalleFalla.Width = 55
        '
        'PrecioUniFalla
        '
        Me.PrecioUniFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioUniFalla.DataPropertyName = "PrecioUniFalla"
        Me.PrecioUniFalla.HeaderText = "PrecioUni"
        Me.PrecioUniFalla.Name = "PrecioUniFalla"
        Me.PrecioUniFalla.ReadOnly = True
        Me.PrecioUniFalla.Width = 78
        '
        'DescripFalla
        '
        Me.DescripFalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescripFalla.DataPropertyName = "DescripFalla"
        Me.DescripFalla.HeaderText = "Descrip"
        Me.DescripFalla.Name = "DescripFalla"
        Me.DescripFalla.ReadOnly = True
        Me.DescripFalla.Width = 68
        '
        'PBuscarText
        '
        Me.PBuscarText.Controls.Add(Me.DtpAnio)
        Me.PBuscarText.Controls.Add(Me.Label1)
        Me.PBuscarText.Controls.Add(Me.TbBuscarNM)
        Me.PBuscarText.Controls.Add(Me.btnBusText)
        Me.PBuscarText.Location = New System.Drawing.Point(214, -3)
        Me.PBuscarText.Name = "PBuscarText"
        Me.PBuscarText.Size = New System.Drawing.Size(393, 44)
        Me.PBuscarText.TabIndex = 46
        '
        'DtpAnio
        '
        Me.DtpAnio.CalendarFont = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnio.CustomFormat = "yyyy"
        Me.DtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAnio.Location = New System.Drawing.Point(339, 12)
        Me.DtpAnio.Name = "DtpAnio"
        Me.DtpAnio.Size = New System.Drawing.Size(47, 20)
        Me.DtpAnio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Digite Codigo"
        '
        'TbBuscarNM
        '
        Me.TbBuscarNM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBuscarNM.Location = New System.Drawing.Point(113, 7)
        Me.TbBuscarNM.Name = "TbBuscarNM"
        Me.TbBuscarNM.Size = New System.Drawing.Size(139, 29)
        Me.TbBuscarNM.TabIndex = 1
        '
        'btnBusText
        '
        Me.btnBusText.Location = New System.Drawing.Point(258, 10)
        Me.btnBusText.Name = "btnBusText"
        Me.btnBusText.Size = New System.Drawing.Size(75, 23)
        Me.btnBusText.TabIndex = 0
        Me.btnBusText.Text = "Buscar"
        Me.btnBusText.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(898, 295)
        Me.Chart1.TabIndex = 47
        Me.Chart1.Text = "Chart1"
        '
        'PaGraGeneral
        '
        Me.PaGraGeneral.Controls.Add(Me.Chart1)
        Me.PaGraGeneral.Location = New System.Drawing.Point(916, 324)
        Me.PaGraGeneral.Name = "PaGraGeneral"
        Me.PaGraGeneral.Size = New System.Drawing.Size(898, 295)
        Me.PaGraGeneral.TabIndex = 48
        '
        'PaGraIndi
        '
        Me.PaGraIndi.Controls.Add(Me.Panel2)
        Me.PaGraIndi.Controls.Add(Me.Chart2)
        Me.PaGraIndi.Location = New System.Drawing.Point(12, 324)
        Me.PaGraIndi.Name = "PaGraIndi"
        Me.PaGraIndi.Size = New System.Drawing.Size(898, 295)
        Me.PaGraIndi.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LaTempArt)
        Me.Panel2.Controls.Add(Me.LaCodiArt)
        Me.Panel2.Controls.Add(Me.LaCodi)
        Me.Panel2.Controls.Add(Me.LaModeArt)
        Me.Panel2.Controls.Add(Me.LaTalleArt)
        Me.Panel2.Controls.Add(Me.LaTalle)
        Me.Panel2.Controls.Add(Me.LaMode)
        Me.Panel2.Controls.Add(Me.LaTemp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(535, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 295)
        Me.Panel2.TabIndex = 50
        '
        'LaTempArt
        '
        Me.LaTempArt.AutoSize = True
        Me.LaTempArt.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempArt.Location = New System.Drawing.Point(198, 191)
        Me.LaTempArt.Name = "LaTempArt"
        Me.LaTempArt.Size = New System.Drawing.Size(150, 32)
        Me.LaTempArt.TabIndex = 37
        Me.LaTempArt.Text = "Temporada"
        '
        'LaCodiArt
        '
        Me.LaCodiArt.AutoSize = True
        Me.LaCodiArt.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCodiArt.Location = New System.Drawing.Point(150, 40)
        Me.LaCodiArt.Name = "LaCodiArt"
        Me.LaCodiArt.Size = New System.Drawing.Size(105, 32)
        Me.LaCodiArt.TabIndex = 36
        Me.LaCodiArt.Text = "ART000"
        '
        'LaCodi
        '
        Me.LaCodi.AutoSize = True
        Me.LaCodi.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCodi.Location = New System.Drawing.Point(32, 40)
        Me.LaCodi.Name = "LaCodi"
        Me.LaCodi.Size = New System.Drawing.Size(112, 33)
        Me.LaCodi.TabIndex = 33
        Me.LaCodi.Text = "Codigo :"
        '
        'LaModeArt
        '
        Me.LaModeArt.AutoSize = True
        Me.LaModeArt.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaModeArt.Location = New System.Drawing.Point(155, 90)
        Me.LaModeArt.Name = "LaModeArt"
        Me.LaModeArt.Size = New System.Drawing.Size(105, 32)
        Me.LaModeArt.TabIndex = 35
        Me.LaModeArt.Text = "Modelo"
        '
        'LaTalleArt
        '
        Me.LaTalleArt.AutoSize = True
        Me.LaTalleArt.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTalleArt.Location = New System.Drawing.Point(123, 141)
        Me.LaTalleArt.Name = "LaTalleArt"
        Me.LaTalleArt.Size = New System.Drawing.Size(45, 32)
        Me.LaTalleArt.TabIndex = 34
        Me.LaTalleArt.Text = "XX"
        '
        'LaTalle
        '
        Me.LaTalle.AutoSize = True
        Me.LaTalle.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTalle.Location = New System.Drawing.Point(32, 140)
        Me.LaTalle.Name = "LaTalle"
        Me.LaTalle.Size = New System.Drawing.Size(85, 33)
        Me.LaTalle.TabIndex = 21
        Me.LaTalle.Text = "Talle :"
        '
        'LaMode
        '
        Me.LaMode.AutoSize = True
        Me.LaMode.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMode.Location = New System.Drawing.Point(32, 90)
        Me.LaMode.Name = "LaMode"
        Me.LaMode.Size = New System.Drawing.Size(117, 33)
        Me.LaMode.TabIndex = 22
        Me.LaMode.Text = "Modelo :"
        '
        'LaTemp
        '
        Me.LaTemp.AutoSize = True
        Me.LaTemp.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTemp.Location = New System.Drawing.Point(32, 190)
        Me.LaTemp.Name = "LaTemp"
        Me.LaTemp.Size = New System.Drawing.Size(160, 33)
        Me.LaTemp.TabIndex = 23
        Me.LaTemp.Text = "Temporada :"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Left
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(529, 295)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart2"
        '
        'GraProducion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TallerTextil.My.Resources.Resources.FondoGraClaro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1319, 660)
        Me.Controls.Add(Me.PaGraIndi)
        Me.Controls.Add(Me.PaGraGeneral)
        Me.Controls.Add(Me.PBuscarText)
        Me.Controls.Add(Me.paDtGrViArt)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GraProducion"
        Me.Text = "GraProducion"
        Me.paDtGrViArt.ResumeLayout(False)
        CType(Me.DGVArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVFallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBuscarText.ResumeLayout(False)
        Me.PBuscarText.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaGraGeneral.ResumeLayout(False)
        Me.PaGraIndi.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents paDtGrViArt As Panel
    Friend WithEvents DGVArt As DataGridView
    Friend WithEvents IdProArt As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FeRecibidoArt As DataGridViewTextBoxColumn
    Friend WithEvents FeEntregaArt As DataGridViewTextBoxColumn
    Friend WithEvents CodigoArt As DataGridViewTextBoxColumn
    Friend WithEvents ModeloArt As DataGridViewTextBoxColumn
    Friend WithEvents TalleArt As DataGridViewTextBoxColumn
    Friend WithEvents CantArt As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniArt As DataGridViewTextBoxColumn
    Friend WithEvents DescripArt As DataGridViewTextBoxColumn
    Friend WithEvents TemporadaArt As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVFallas As DataGridView
    Friend WithEvents PBuscarText As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TbBuscarNM As TextBox
    Friend WithEvents btnBusText As Button
    Friend WithEvents IdFalla As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents CodigoFalla As DataGridViewTextBoxColumn
    Friend WithEvents FeRecibidoFalla As DataGridViewTextBoxColumn
    Friend WithEvents FeEntregadoFalla As DataGridViewTextBoxColumn
    Friend WithEvents ModeloFalla As DataGridViewTextBoxColumn
    Friend WithEvents TalleFalla As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniFalla As DataGridViewTextBoxColumn
    Friend WithEvents DescripFalla As DataGridViewTextBoxColumn
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PaGraGeneral As Panel
    Friend WithEvents PaGraIndi As Panel
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents DtpAnio As DateTimePicker
    Friend WithEvents LaCodiArt As Label
    Friend WithEvents LaModeArt As Label
    Friend WithEvents LaTalleArt As Label
    Friend WithEvents LaCodi As Label
    Friend WithEvents LaTemp As Label
    Friend WithEvents LaMode As Label
    Friend WithEvents LaTalle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LaTempArt As Label
End Class
