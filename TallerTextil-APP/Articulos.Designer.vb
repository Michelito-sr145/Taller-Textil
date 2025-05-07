<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Articulos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelIDusu = New System.Windows.Forms.Label()
        Me.paDtGrViArt = New System.Windows.Forms.Panel()
        Me.DaGrViArt = New System.Windows.Forms.DataGridView()
        Me.IdProArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeRecibidoArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeEntregaArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TalleArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemporadaArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBuscarText = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbBuscarNM = New System.Windows.Forms.TextBox()
        Me.btnBusText = New System.Windows.Forms.Button()
        Me.btnMosOcuFiltros = New System.Windows.Forms.Button()
        Me.paFiltros = New System.Windows.Forms.Panel()
        Me.BtnLimF = New System.Windows.Forms.Button()
        Me.btnFiltrarPorHoy = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBPrimavera = New System.Windows.Forms.CheckBox()
        Me.PicBPrimavera = New System.Windows.Forms.PictureBox()
        Me.CBInvierno = New System.Windows.Forms.CheckBox()
        Me.PicBInvierno = New System.Windows.Forms.PictureBox()
        Me.CBOtonio = New System.Windows.Forms.CheckBox()
        Me.PicBOtonio = New System.Windows.Forms.PictureBox()
        Me.CBVerano = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PicBVerano = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FFechaIn = New System.Windows.Forms.DateTimePicker()
        Me.FFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOcuMosArt = New System.Windows.Forms.Button()
        Me.PDatosInfo = New System.Windows.Forms.Panel()
        Me.DtpFeEntregaArt = New System.Windows.Forms.DateTimePicker()
        Me.btnSalirModi = New System.Windows.Forms.Button()
        Me.btnGuardarArt = New System.Windows.Forms.Button()
        Me.btnSalirNuv = New System.Windows.Forms.Button()
        Me.LaFeE = New System.Windows.Forms.Label()
        Me.btnConfiModi = New System.Windows.Forms.Button()
        Me.TbCodigoArt = New System.Windows.Forms.TextBox()
        Me.LaCodi = New System.Windows.Forms.Label()
        Me.TxTotal = New System.Windows.Forms.Label()
        Me.CbTemporadaArt = New System.Windows.Forms.ComboBox()
        Me.TbDescripArt = New System.Windows.Forms.TextBox()
        Me.TbTalleArt = New System.Windows.Forms.TextBox()
        Me.DtpFeRecibidoArt = New System.Windows.Forms.DateTimePicker()
        Me.TbModeloArt = New System.Windows.Forms.TextBox()
        Me.LaTemp = New System.Windows.Forms.Label()
        Me.LaMode = New System.Windows.Forms.Label()
        Me.LaTalle = New System.Windows.Forms.Label()
        Me.TbPrecioUniArt = New System.Windows.Forms.TextBox()
        Me.LaTotal = New System.Windows.Forms.Label()
        Me.LaDescrip = New System.Windows.Forms.Label()
        Me.LaIDArt = New System.Windows.Forms.Label()
        Me.LaCant = New System.Windows.Forms.Label()
        Me.TbCantArt = New System.Windows.Forms.TextBox()
        Me.LaFeR = New System.Windows.Forms.Label()
        Me.LaPrec = New System.Windows.Forms.Label()
        Me.TextAccion = New System.Windows.Forms.Label()
        Me.BtnFalla = New System.Windows.Forms.Button()
        Me.btnEliminar1 = New System.Windows.Forms.Button()
        Me.btnModificar1 = New System.Windows.Forms.Button()
        Me.btnNuevo1 = New System.Windows.Forms.Button()
        Me.paDtGrViArt.SuspendLayout()
        CType(Me.DaGrViArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBuscarText.SuspendLayout()
        Me.paFiltros.SuspendLayout()
        CType(Me.PicBPrimavera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBInvierno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBOtonio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBVerano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PDatosInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelIDusu
        '
        Me.LabelIDusu.AutoSize = True
        Me.LabelIDusu.Location = New System.Drawing.Point(566, -4)
        Me.LabelIDusu.Name = "LabelIDusu"
        Me.LabelIDusu.Size = New System.Drawing.Size(45, 13)
        Me.LabelIDusu.TabIndex = 44
        Me.LabelIDusu.Text = "Label19"
        Me.LabelIDusu.Visible = False
        '
        'paDtGrViArt
        '
        Me.paDtGrViArt.Controls.Add(Me.DaGrViArt)
        Me.paDtGrViArt.Location = New System.Drawing.Point(12, 105)
        Me.paDtGrViArt.Name = "paDtGrViArt"
        Me.paDtGrViArt.Size = New System.Drawing.Size(692, 340)
        Me.paDtGrViArt.TabIndex = 42
        '
        'DaGrViArt
        '
        Me.DaGrViArt.AllowUserToAddRows = False
        Me.DaGrViArt.AllowUserToDeleteRows = False
        Me.DaGrViArt.AllowUserToOrderColumns = True
        Me.DaGrViArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DaGrViArt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProArt, Me.IDUsuario, Me.FeRecibidoArt, Me.FeEntregaArt, Me.CodigoArt, Me.ModeloArt, Me.TalleArt, Me.CantArt, Me.PrecioUniArt, Me.DescripArt, Me.TemporadaArt})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DaGrViArt.DefaultCellStyle = DataGridViewCellStyle1
        Me.DaGrViArt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DaGrViArt.Location = New System.Drawing.Point(0, 0)
        Me.DaGrViArt.Margin = New System.Windows.Forms.Padding(4)
        Me.DaGrViArt.Name = "DaGrViArt"
        Me.DaGrViArt.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DaGrViArt.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaGrViArt.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DaGrViArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DaGrViArt.Size = New System.Drawing.Size(692, 340)
        Me.DaGrViArt.TabIndex = 19
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
        'IDUsuario
        '
        Me.IDUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDUsuario.DataPropertyName = "IDUsuario"
        Me.IDUsuario.HeaderText = "IDUsuario"
        Me.IDUsuario.Name = "IDUsuario"
        Me.IDUsuario.ReadOnly = True
        Me.IDUsuario.Visible = False
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
        Me.TemporadaArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.TemporadaArt.DataPropertyName = "TemporadaArt"
        Me.TemporadaArt.HeaderText = "Temporada"
        Me.TemporadaArt.Name = "TemporadaArt"
        Me.TemporadaArt.ReadOnly = True
        Me.TemporadaArt.Width = 5
        '
        'PBuscarText
        '
        Me.PBuscarText.Controls.Add(Me.Label6)
        Me.PBuscarText.Controls.Add(Me.Label5)
        Me.PBuscarText.Controls.Add(Me.Label4)
        Me.PBuscarText.Controls.Add(Me.TbBuscarNM)
        Me.PBuscarText.Controls.Add(Me.btnBusText)
        Me.PBuscarText.Location = New System.Drawing.Point(617, 5)
        Me.PBuscarText.Name = "PBuscarText"
        Me.PBuscarText.Size = New System.Drawing.Size(199, 93)
        Me.PBuscarText.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(78, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "y / o"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(121, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(11, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Modelo"
        '
        'TbBuscarNM
        '
        Me.TbBuscarNM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBuscarNM.Location = New System.Drawing.Point(5, 33)
        Me.TbBuscarNM.Name = "TbBuscarNM"
        Me.TbBuscarNM.Size = New System.Drawing.Size(182, 29)
        Me.TbBuscarNM.TabIndex = 1
        '
        'btnBusText
        '
        Me.btnBusText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusText.Image = Global.TallerTextil.My.Resources.Resources.BuscarClaro
        Me.btnBusText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusText.Location = New System.Drawing.Point(112, 61)
        Me.btnBusText.Name = "btnBusText"
        Me.btnBusText.Size = New System.Drawing.Size(75, 30)
        Me.btnBusText.TabIndex = 0
        Me.btnBusText.Text = "Buscar"
        Me.btnBusText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBusText.UseVisualStyleBackColor = True
        '
        'btnMosOcuFiltros
        '
        Me.btnMosOcuFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMosOcuFiltros.Location = New System.Drawing.Point(4, 12)
        Me.btnMosOcuFiltros.Name = "btnMosOcuFiltros"
        Me.btnMosOcuFiltros.Size = New System.Drawing.Size(75, 23)
        Me.btnMosOcuFiltros.TabIndex = 39
        Me.btnMosOcuFiltros.Text = "Filtrar :"
        Me.btnMosOcuFiltros.UseVisualStyleBackColor = True
        '
        'paFiltros
        '
        Me.paFiltros.Controls.Add(Me.BtnLimF)
        Me.paFiltros.Controls.Add(Me.btnFiltrarPorHoy)
        Me.paFiltros.Controls.Add(Me.Label7)
        Me.paFiltros.Controls.Add(Me.CBPrimavera)
        Me.paFiltros.Controls.Add(Me.PicBPrimavera)
        Me.paFiltros.Controls.Add(Me.CBInvierno)
        Me.paFiltros.Controls.Add(Me.PicBInvierno)
        Me.paFiltros.Controls.Add(Me.CBOtonio)
        Me.paFiltros.Controls.Add(Me.PicBOtonio)
        Me.paFiltros.Controls.Add(Me.CBVerano)
        Me.paFiltros.Controls.Add(Me.Label3)
        Me.paFiltros.Controls.Add(Me.PicBVerano)
        Me.paFiltros.Controls.Add(Me.Label1)
        Me.paFiltros.Controls.Add(Me.FFechaIn)
        Me.paFiltros.Controls.Add(Me.FFechaFin)
        Me.paFiltros.Controls.Add(Me.Label2)
        Me.paFiltros.Location = New System.Drawing.Point(100, 12)
        Me.paFiltros.Name = "paFiltros"
        Me.paFiltros.Size = New System.Drawing.Size(519, 71)
        Me.paFiltros.TabIndex = 38
        Me.paFiltros.Visible = False
        '
        'BtnLimF
        '
        Me.BtnLimF.Location = New System.Drawing.Point(469, 17)
        Me.BtnLimF.Name = "BtnLimF"
        Me.BtnLimF.Size = New System.Drawing.Size(42, 23)
        Me.BtnLimF.TabIndex = 20
        Me.BtnLimF.Text = "Todo"
        Me.BtnLimF.UseVisualStyleBackColor = True
        '
        'btnFiltrarPorHoy
        '
        Me.btnFiltrarPorHoy.Location = New System.Drawing.Point(61, 45)
        Me.btnFiltrarPorHoy.Name = "btnFiltrarPorHoy"
        Me.btnFiltrarPorHoy.Size = New System.Drawing.Size(101, 23)
        Me.btnFiltrarPorHoy.TabIndex = 19
        Me.btnFiltrarPorHoy.Text = "Articulos de Hoy"
        Me.btnFiltrarPorHoy.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "del Año :"
        '
        'CBPrimavera
        '
        Me.CBPrimavera.AutoSize = True
        Me.CBPrimavera.ForeColor = System.Drawing.Color.Transparent
        Me.CBPrimavera.Location = New System.Drawing.Point(437, 43)
        Me.CBPrimavera.Name = "CBPrimavera"
        Me.CBPrimavera.Size = New System.Drawing.Size(15, 14)
        Me.CBPrimavera.TabIndex = 17
        Me.CBPrimavera.Tag = "Primavera"
        Me.CBPrimavera.UseVisualStyleBackColor = True
        '
        'PicBPrimavera
        '
        Me.PicBPrimavera.Image = Global.TallerTextil.My.Resources.Resources.Primavera
        Me.PicBPrimavera.Location = New System.Drawing.Point(423, 7)
        Me.PicBPrimavera.Name = "PicBPrimavera"
        Me.PicBPrimavera.Size = New System.Drawing.Size(40, 40)
        Me.PicBPrimavera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBPrimavera.TabIndex = 9
        Me.PicBPrimavera.TabStop = False
        Me.PicBPrimavera.Tag = "Primavera"
        '
        'CBInvierno
        '
        Me.CBInvierno.AutoSize = True
        Me.CBInvierno.ForeColor = System.Drawing.Color.Transparent
        Me.CBInvierno.Location = New System.Drawing.Point(393, 43)
        Me.CBInvierno.Name = "CBInvierno"
        Me.CBInvierno.Size = New System.Drawing.Size(15, 14)
        Me.CBInvierno.TabIndex = 16
        Me.CBInvierno.Tag = "Invierno"
        Me.CBInvierno.UseVisualStyleBackColor = True
        '
        'PicBInvierno
        '
        Me.PicBInvierno.Image = Global.TallerTextil.My.Resources.Resources.invierno
        Me.PicBInvierno.Location = New System.Drawing.Point(380, 7)
        Me.PicBInvierno.Name = "PicBInvierno"
        Me.PicBInvierno.Size = New System.Drawing.Size(40, 40)
        Me.PicBInvierno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBInvierno.TabIndex = 8
        Me.PicBInvierno.TabStop = False
        Me.PicBInvierno.Tag = "Invierno"
        '
        'CBOtonio
        '
        Me.CBOtonio.AutoSize = True
        Me.CBOtonio.ForeColor = System.Drawing.Color.Transparent
        Me.CBOtonio.Location = New System.Drawing.Point(347, 43)
        Me.CBOtonio.Name = "CBOtonio"
        Me.CBOtonio.Size = New System.Drawing.Size(15, 14)
        Me.CBOtonio.TabIndex = 15
        Me.CBOtonio.Tag = "Otoño"
        Me.CBOtonio.UseVisualStyleBackColor = True
        '
        'PicBOtonio
        '
        Me.PicBOtonio.Image = Global.TallerTextil.My.Resources.Resources.Otoño
        Me.PicBOtonio.Location = New System.Drawing.Point(334, 7)
        Me.PicBOtonio.Name = "PicBOtonio"
        Me.PicBOtonio.Size = New System.Drawing.Size(40, 40)
        Me.PicBOtonio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBOtonio.TabIndex = 7
        Me.PicBOtonio.TabStop = False
        Me.PicBOtonio.Tag = "Otoño"
        '
        'CBVerano
        '
        Me.CBVerano.AutoSize = True
        Me.CBVerano.ForeColor = System.Drawing.Color.Transparent
        Me.CBVerano.Location = New System.Drawing.Point(301, 43)
        Me.CBVerano.Name = "CBVerano"
        Me.CBVerano.Size = New System.Drawing.Size(15, 14)
        Me.CBVerano.TabIndex = 10
        Me.CBVerano.Tag = "Verano"
        Me.CBVerano.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estaciones"
        '
        'PicBVerano
        '
        Me.PicBVerano.Image = Global.TallerTextil.My.Resources.Resources.Verano
        Me.PicBVerano.Location = New System.Drawing.Point(288, 7)
        Me.PicBVerano.Name = "PicBVerano"
        Me.PicBVerano.Size = New System.Drawing.Size(40, 40)
        Me.PicBVerano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBVerano.TabIndex = 5
        Me.PicBVerano.TabStop = False
        Me.PicBVerano.Tag = "Verano"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rango de Fechas"
        '
        'FFechaIn
        '
        Me.FFechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FFechaIn.Location = New System.Drawing.Point(2, 21)
        Me.FFechaIn.Name = "FFechaIn"
        Me.FFechaIn.Size = New System.Drawing.Size(97, 20)
        Me.FFechaIn.TabIndex = 1
        Me.FFechaIn.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        '
        'FFechaFin
        '
        Me.FFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FFechaFin.Location = New System.Drawing.Point(119, 21)
        Me.FFechaFin.Name = "FFechaFin"
        Me.FFechaFin.Size = New System.Drawing.Size(97, 20)
        Me.FFechaFin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(97, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ">A<"
        '
        'btnOcuMosArt
        '
        Me.btnOcuMosArt.Location = New System.Drawing.Point(4, 57)
        Me.btnOcuMosArt.Name = "btnOcuMosArt"
        Me.btnOcuMosArt.Size = New System.Drawing.Size(75, 23)
        Me.btnOcuMosArt.TabIndex = 34
        Me.btnOcuMosArt.Text = "Lista"
        Me.btnOcuMosArt.UseVisualStyleBackColor = True
        '
        'PDatosInfo
        '
        Me.PDatosInfo.Controls.Add(Me.DtpFeEntregaArt)
        Me.PDatosInfo.Controls.Add(Me.btnSalirModi)
        Me.PDatosInfo.Controls.Add(Me.btnGuardarArt)
        Me.PDatosInfo.Controls.Add(Me.btnSalirNuv)
        Me.PDatosInfo.Controls.Add(Me.LaFeE)
        Me.PDatosInfo.Controls.Add(Me.btnConfiModi)
        Me.PDatosInfo.Controls.Add(Me.TbCodigoArt)
        Me.PDatosInfo.Controls.Add(Me.LaCodi)
        Me.PDatosInfo.Controls.Add(Me.TxTotal)
        Me.PDatosInfo.Controls.Add(Me.CbTemporadaArt)
        Me.PDatosInfo.Controls.Add(Me.TbDescripArt)
        Me.PDatosInfo.Controls.Add(Me.TbTalleArt)
        Me.PDatosInfo.Controls.Add(Me.DtpFeRecibidoArt)
        Me.PDatosInfo.Controls.Add(Me.TbModeloArt)
        Me.PDatosInfo.Controls.Add(Me.LaTemp)
        Me.PDatosInfo.Controls.Add(Me.LaMode)
        Me.PDatosInfo.Controls.Add(Me.LaTalle)
        Me.PDatosInfo.Controls.Add(Me.TbPrecioUniArt)
        Me.PDatosInfo.Controls.Add(Me.LaTotal)
        Me.PDatosInfo.Controls.Add(Me.LaDescrip)
        Me.PDatosInfo.Controls.Add(Me.LaIDArt)
        Me.PDatosInfo.Controls.Add(Me.LaCant)
        Me.PDatosInfo.Controls.Add(Me.TbCantArt)
        Me.PDatosInfo.Controls.Add(Me.LaFeR)
        Me.PDatosInfo.Controls.Add(Me.LaPrec)
        Me.PDatosInfo.Location = New System.Drawing.Point(711, 105)
        Me.PDatosInfo.Name = "PDatosInfo"
        Me.PDatosInfo.Size = New System.Drawing.Size(522, 427)
        Me.PDatosInfo.TabIndex = 41
        Me.PDatosInfo.Visible = False
        '
        'DtpFeEntregaArt
        '
        Me.DtpFeEntregaArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFeEntregaArt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFeEntregaArt.Location = New System.Drawing.Point(315, 155)
        Me.DtpFeEntregaArt.Name = "DtpFeEntregaArt"
        Me.DtpFeEntregaArt.Size = New System.Drawing.Size(134, 31)
        Me.DtpFeEntregaArt.TabIndex = 23
        '
        'btnSalirModi
        '
        Me.btnSalirModi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalirModi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirModi.Location = New System.Drawing.Point(415, 295)
        Me.btnSalirModi.Name = "btnSalirModi"
        Me.btnSalirModi.Size = New System.Drawing.Size(100, 37)
        Me.btnSalirModi.TabIndex = 18
        Me.btnSalirModi.Text = "Salir"
        Me.btnSalirModi.UseVisualStyleBackColor = True
        Me.btnSalirModi.Visible = False
        '
        'btnGuardarArt
        '
        Me.btnGuardarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnGuardarArt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarArt.Location = New System.Drawing.Point(411, 340)
        Me.btnGuardarArt.Name = "btnGuardarArt"
        Me.btnGuardarArt.Size = New System.Drawing.Size(90, 30)
        Me.btnGuardarArt.TabIndex = 20
        Me.btnGuardarArt.Text = "Guardar"
        Me.btnGuardarArt.UseVisualStyleBackColor = True
        Me.btnGuardarArt.Visible = False
        '
        'btnSalirNuv
        '
        Me.btnSalirNuv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalirNuv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirNuv.Location = New System.Drawing.Point(411, 391)
        Me.btnSalirNuv.Name = "btnSalirNuv"
        Me.btnSalirNuv.Size = New System.Drawing.Size(90, 30)
        Me.btnSalirNuv.TabIndex = 17
        Me.btnSalirNuv.Text = "Salir"
        Me.btnSalirNuv.UseVisualStyleBackColor = True
        Me.btnSalirNuv.Visible = False
        '
        'LaFeE
        '
        Me.LaFeE.AutoSize = True
        Me.LaFeE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFeE.Location = New System.Drawing.Point(310, 130)
        Me.LaFeE.Name = "LaFeE"
        Me.LaFeE.Size = New System.Drawing.Size(128, 20)
        Me.LaFeE.TabIndex = 22
        Me.LaFeE.Text = "Fecha Entrega"
        '
        'btnConfiModi
        '
        Me.btnConfiModi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnConfiModi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiModi.Location = New System.Drawing.Point(415, 250)
        Me.btnConfiModi.Name = "btnConfiModi"
        Me.btnConfiModi.Size = New System.Drawing.Size(101, 37)
        Me.btnConfiModi.TabIndex = 21
        Me.btnConfiModi.Text = "Guardar"
        Me.btnConfiModi.UseVisualStyleBackColor = True
        Me.btnConfiModi.Visible = False
        '
        'TbCodigoArt
        '
        Me.TbCodigoArt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCodigoArt.Location = New System.Drawing.Point(150, 30)
        Me.TbCodigoArt.Name = "TbCodigoArt"
        Me.TbCodigoArt.Size = New System.Drawing.Size(138, 26)
        Me.TbCodigoArt.TabIndex = 19
        '
        'LaCodi
        '
        Me.LaCodi.AutoSize = True
        Me.LaCodi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCodi.Location = New System.Drawing.Point(40, 30)
        Me.LaCodi.Name = "LaCodi"
        Me.LaCodi.Size = New System.Drawing.Size(65, 20)
        Me.LaCodi.TabIndex = 18
        Me.LaCodi.Text = "Codigo"
        '
        'TxTotal
        '
        Me.TxTotal.AutoSize = True
        Me.TxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTotal.Location = New System.Drawing.Point(325, 360)
        Me.TxTotal.Name = "TxTotal"
        Me.TxTotal.Size = New System.Drawing.Size(49, 20)
        Me.TxTotal.TabIndex = 17
        Me.TxTotal.Text = "9999"
        '
        'CbTemporadaArt
        '
        Me.CbTemporadaArt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTemporadaArt.FormattingEnabled = True
        Me.CbTemporadaArt.Items.AddRange(New Object() {"Verano", "Otoño", "Invierno", "Primavera"})
        Me.CbTemporadaArt.Location = New System.Drawing.Point(150, 180)
        Me.CbTemporadaArt.Name = "CbTemporadaArt"
        Me.CbTemporadaArt.Size = New System.Drawing.Size(138, 26)
        Me.CbTemporadaArt.TabIndex = 16
        Me.CbTemporadaArt.Text = "Ninguno"
        '
        'TbDescripArt
        '
        Me.TbDescripArt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripArt.Location = New System.Drawing.Point(50, 250)
        Me.TbDescripArt.Multiline = True
        Me.TbDescripArt.Name = "TbDescripArt"
        Me.TbDescripArt.Size = New System.Drawing.Size(356, 81)
        Me.TbDescripArt.TabIndex = 12
        '
        'TbTalleArt
        '
        Me.TbTalleArt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTalleArt.Location = New System.Drawing.Point(150, 130)
        Me.TbTalleArt.Name = "TbTalleArt"
        Me.TbTalleArt.Size = New System.Drawing.Size(138, 26)
        Me.TbTalleArt.TabIndex = 11
        '
        'DtpFeRecibidoArt
        '
        Me.DtpFeRecibidoArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFeRecibidoArt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFeRecibidoArt.Location = New System.Drawing.Point(315, 60)
        Me.DtpFeRecibidoArt.Name = "DtpFeRecibidoArt"
        Me.DtpFeRecibidoArt.Size = New System.Drawing.Size(130, 31)
        Me.DtpFeRecibidoArt.TabIndex = 15
        Me.DtpFeRecibidoArt.Value = New Date(2024, 7, 10, 13, 5, 0, 0)
        '
        'TbModeloArt
        '
        Me.TbModeloArt.BackColor = System.Drawing.SystemColors.Window
        Me.TbModeloArt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbModeloArt.Location = New System.Drawing.Point(150, 80)
        Me.TbModeloArt.Name = "TbModeloArt"
        Me.TbModeloArt.Size = New System.Drawing.Size(138, 26)
        Me.TbModeloArt.TabIndex = 10
        '
        'LaTemp
        '
        Me.LaTemp.AutoSize = True
        Me.LaTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTemp.Location = New System.Drawing.Point(40, 180)
        Me.LaTemp.Name = "LaTemp"
        Me.LaTemp.Size = New System.Drawing.Size(99, 20)
        Me.LaTemp.TabIndex = 5
        Me.LaTemp.Text = "Temporada"
        '
        'LaMode
        '
        Me.LaMode.AutoSize = True
        Me.LaMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMode.Location = New System.Drawing.Point(40, 80)
        Me.LaMode.Name = "LaMode"
        Me.LaMode.Size = New System.Drawing.Size(67, 20)
        Me.LaMode.TabIndex = 4
        Me.LaMode.Text = "Modelo"
        '
        'LaTalle
        '
        Me.LaTalle.AutoSize = True
        Me.LaTalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTalle.Location = New System.Drawing.Point(40, 130)
        Me.LaTalle.Name = "LaTalle"
        Me.LaTalle.Size = New System.Drawing.Size(47, 20)
        Me.LaTalle.TabIndex = 3
        Me.LaTalle.Text = "Talle"
        '
        'TbPrecioUniArt
        '
        Me.TbPrecioUniArt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPrecioUniArt.Location = New System.Drawing.Point(135, 375)
        Me.TbPrecioUniArt.Name = "TbPrecioUniArt"
        Me.TbPrecioUniArt.Size = New System.Drawing.Size(87, 26)
        Me.TbPrecioUniArt.TabIndex = 14
        '
        'LaTotal
        '
        Me.LaTotal.AutoSize = True
        Me.LaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTotal.Location = New System.Drawing.Point(250, 360)
        Me.LaTotal.Name = "LaTotal"
        Me.LaTotal.Size = New System.Drawing.Size(49, 20)
        Me.LaTotal.TabIndex = 9
        Me.LaTotal.Text = "Total"
        '
        'LaDescrip
        '
        Me.LaDescrip.AutoSize = True
        Me.LaDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaDescrip.Location = New System.Drawing.Point(40, 221)
        Me.LaDescrip.Name = "LaDescrip"
        Me.LaDescrip.Size = New System.Drawing.Size(103, 20)
        Me.LaDescrip.TabIndex = 2
        Me.LaDescrip.Text = "Descripcion"
        '
        'LaIDArt
        '
        Me.LaIDArt.AutoSize = True
        Me.LaIDArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaIDArt.Location = New System.Drawing.Point(1, 1)
        Me.LaIDArt.Name = "LaIDArt"
        Me.LaIDArt.Size = New System.Drawing.Size(29, 24)
        Me.LaIDArt.TabIndex = 1
        Me.LaIDArt.Text = "ID"
        Me.LaIDArt.Visible = False
        '
        'LaCant
        '
        Me.LaCant.AutoSize = True
        Me.LaCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCant.Location = New System.Drawing.Point(40, 340)
        Me.LaCant.Name = "LaCant"
        Me.LaCant.Size = New System.Drawing.Size(81, 20)
        Me.LaCant.TabIndex = 7
        Me.LaCant.Text = "Cantidad"
        '
        'TbCantArt
        '
        Me.TbCantArt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCantArt.Location = New System.Drawing.Point(135, 340)
        Me.TbCantArt.Name = "TbCantArt"
        Me.TbCantArt.Size = New System.Drawing.Size(87, 26)
        Me.TbCantArt.TabIndex = 13
        '
        'LaFeR
        '
        Me.LaFeR.AutoSize = True
        Me.LaFeR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFeR.Location = New System.Drawing.Point(310, 35)
        Me.LaFeR.Name = "LaFeR"
        Me.LaFeR.Size = New System.Drawing.Size(134, 20)
        Me.LaFeR.TabIndex = 6
        Me.LaFeR.Text = "Fecha Recibido"
        '
        'LaPrec
        '
        Me.LaPrec.AutoSize = True
        Me.LaPrec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaPrec.Location = New System.Drawing.Point(40, 380)
        Me.LaPrec.Name = "LaPrec"
        Me.LaPrec.Size = New System.Drawing.Size(59, 20)
        Me.LaPrec.TabIndex = 8
        Me.LaPrec.Text = "Precio"
        '
        'TextAccion
        '
        Me.TextAccion.AutoSize = True
        Me.TextAccion.Font = New System.Drawing.Font("Consolas", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAccion.Location = New System.Drawing.Point(85, 19)
        Me.TextAccion.Name = "TextAccion"
        Me.TextAccion.Size = New System.Drawing.Size(214, 51)
        Me.TextAccion.TabIndex = 33
        Me.TextAccion.Text = "Articulo"
        '
        'BtnFalla
        '
        Me.BtnFalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.BtnFalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFalla.Image = Global.TallerTextil.My.Resources.Resources.FallaClaro
        Me.BtnFalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFalla.Location = New System.Drawing.Point(196, 455)
        Me.BtnFalla.Name = "BtnFalla"
        Me.BtnFalla.Size = New System.Drawing.Size(88, 37)
        Me.BtnFalla.TabIndex = 45
        Me.BtnFalla.Text = "Falla"
        Me.BtnFalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFalla.UseVisualStyleBackColor = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEliminar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar1.Image = Global.TallerTextil.My.Resources.Resources.EliminarClaro
        Me.btnEliminar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar1.Location = New System.Drawing.Point(490, 455)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(100, 37)
        Me.btnEliminar1.TabIndex = 37
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar1.UseVisualStyleBackColor = True
        '
        'btnModificar1
        '
        Me.btnModificar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar1.ForeColor = System.Drawing.Color.Black
        Me.btnModificar1.Image = Global.TallerTextil.My.Resources.Resources.EditClaro
        Me.btnModificar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar1.Location = New System.Drawing.Point(290, 455)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(100, 37)
        Me.btnModificar1.TabIndex = 36
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar1.UseVisualStyleBackColor = True
        '
        'btnNuevo1
        '
        Me.btnNuevo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnNuevo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo1.Image = Global.TallerTextil.My.Resources.Resources.CrearClaro
        Me.btnNuevo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo1.Location = New System.Drawing.Point(90, 455)
        Me.btnNuevo1.Name = "btnNuevo1"
        Me.btnNuevo1.Size = New System.Drawing.Size(100, 37)
        Me.btnNuevo1.TabIndex = 35
        Me.btnNuevo1.Text = "Nuevo"
        Me.btnNuevo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo1.UseVisualStyleBackColor = True
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TallerTextil.My.Resources.Resources.FondoProOscu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1318, 657)
        Me.Controls.Add(Me.BtnFalla)
        Me.Controls.Add(Me.LabelIDusu)
        Me.Controls.Add(Me.paDtGrViArt)
        Me.Controls.Add(Me.PBuscarText)
        Me.Controls.Add(Me.btnMosOcuFiltros)
        Me.Controls.Add(Me.paFiltros)
        Me.Controls.Add(Me.btnOcuMosArt)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnNuevo1)
        Me.Controls.Add(Me.TextAccion)
        Me.Controls.Add(Me.PDatosInfo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Articulos"
        Me.Text = "Articulos"
        Me.paDtGrViArt.ResumeLayout(False)
        CType(Me.DaGrViArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBuscarText.ResumeLayout(False)
        Me.PBuscarText.PerformLayout()
        Me.paFiltros.ResumeLayout(False)
        Me.paFiltros.PerformLayout()
        CType(Me.PicBPrimavera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBInvierno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBOtonio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBVerano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PDatosInfo.ResumeLayout(False)
        Me.PDatosInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelIDusu As Label
    Friend WithEvents paDtGrViArt As Panel
    Friend WithEvents DaGrViArt As DataGridView
    Friend WithEvents PBuscarText As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbBuscarNM As TextBox
    Friend WithEvents btnBusText As Button
    Friend WithEvents btnMosOcuFiltros As Button
    Friend WithEvents paFiltros As Panel
    Friend WithEvents btnFiltrarPorHoy As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CBPrimavera As CheckBox
    Friend WithEvents PicBPrimavera As PictureBox
    Friend WithEvents CBInvierno As CheckBox
    Friend WithEvents PicBInvierno As PictureBox
    Friend WithEvents CBOtonio As CheckBox
    Friend WithEvents PicBOtonio As PictureBox
    Friend WithEvents CBVerano As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PicBVerano As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FFechaIn As DateTimePicker
    Friend WithEvents FFechaFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOcuMosArt As Button
    Friend WithEvents btnEliminar1 As Button
    Friend WithEvents btnModificar1 As Button
    Friend WithEvents btnNuevo1 As Button
    Friend WithEvents PDatosInfo As Panel
    Friend WithEvents DtpFeEntregaArt As DateTimePicker
    Friend WithEvents btnSalirModi As Button
    Friend WithEvents btnGuardarArt As Button
    Friend WithEvents btnSalirNuv As Button
    Friend WithEvents LaFeE As Label
    Friend WithEvents btnConfiModi As Button
    Friend WithEvents TbCodigoArt As TextBox
    Friend WithEvents LaCodi As Label
    Friend WithEvents TxTotal As Label
    Friend WithEvents CbTemporadaArt As ComboBox
    Friend WithEvents TbDescripArt As TextBox
    Friend WithEvents TbTalleArt As TextBox
    Friend WithEvents DtpFeRecibidoArt As DateTimePicker
    Friend WithEvents TbModeloArt As TextBox
    Friend WithEvents LaTemp As Label
    Friend WithEvents LaMode As Label
    Friend WithEvents LaTalle As Label
    Friend WithEvents TbPrecioUniArt As TextBox
    Friend WithEvents LaTotal As Label
    Friend WithEvents LaDescrip As Label
    Friend WithEvents LaIDArt As Label
    Friend WithEvents LaCant As Label
    Friend WithEvents TbCantArt As TextBox
    Friend WithEvents LaFeR As Label
    Friend WithEvents LaPrec As Label
    Friend WithEvents TextAccion As Label
    Friend WithEvents BtnLimF As Button
    Friend WithEvents BtnFalla As Button
    Friend WithEvents IdProArt As DataGridViewTextBoxColumn
    Friend WithEvents IDUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FeRecibidoArt As DataGridViewTextBoxColumn
    Friend WithEvents FeEntregaArt As DataGridViewTextBoxColumn
    Friend WithEvents CodigoArt As DataGridViewTextBoxColumn
    Friend WithEvents ModeloArt As DataGridViewTextBoxColumn
    Friend WithEvents TalleArt As DataGridViewTextBoxColumn
    Friend WithEvents CantArt As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniArt As DataGridViewTextBoxColumn
    Friend WithEvents DescripArt As DataGridViewTextBoxColumn
    Friend WithEvents TemporadaArt As DataGridViewTextBoxColumn
End Class
