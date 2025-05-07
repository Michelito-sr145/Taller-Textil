<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockInsumos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockInsumos))
        Me.DGVStock = New System.Windows.Forms.DataGridView()
        Me.IdInsumoStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaDgvStock = New System.Windows.Forms.Panel()
        Me.BtnSalida = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PaDatos = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnModiConfi = New System.Windows.Forms.Button()
        Me.BtnNuCrear = New System.Windows.Forms.Button()
        Me.BtnModiCancelar = New System.Windows.Forms.Button()
        Me.BtnNuCancelar = New System.Windows.Forms.Button()
        Me.LaId = New System.Windows.Forms.Label()
        Me.TbNuPreUni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbNuCant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNuCodigo = New System.Windows.Forms.TextBox()
        Me.TbNuDescrip = New System.Windows.Forms.TextBox()
        Me.TbNuNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaBuscarText = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TbBusCoNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PaEntSal = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnSalGuardar = New System.Windows.Forms.Button()
        Me.BtnSalCancelar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LaFecha = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnEntGuardar = New System.Windows.Forms.Button()
        Me.BtnEntCancelar = New System.Windows.Forms.Button()
        Me.LaCantAnterior = New System.Windows.Forms.Label()
        Me.TbPreUni = New System.Windows.Forms.TextBox()
        Me.LaPreUni = New System.Windows.Forms.Label()
        Me.LaCantidad = New System.Windows.Forms.Label()
        Me.TbCant = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TbCodigo = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.PaAlertas = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAA = New System.Windows.Forms.Button()
        Me.BtnAR = New System.Windows.Forms.Button()
        Me.BtnAN = New System.Windows.Forms.Button()
        Me.PaBtnES = New System.Windows.Forms.Panel()
        Me.BtnEntrada = New System.Windows.Forms.Button()
        Me.Aok = New System.Windows.Forms.Button()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaDgvStock.SuspendLayout()
        Me.PaDatos.SuspendLayout()
        Me.PaBuscarText.SuspendLayout()
        Me.PaEntSal.SuspendLayout()
        Me.PaAlertas.SuspendLayout()
        Me.PaBtnES.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVStock
        '
        Me.DGVStock.AllowUserToAddRows = False
        Me.DGVStock.AllowUserToDeleteRows = False
        Me.DGVStock.AllowUserToOrderColumns = True
        Me.DGVStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInsumoStock, Me.Fecha, Me.IdUsuario, Me.CodigoStock, Me.NombreStock, Me.CantStock, Me.PrecioUniStock, Me.Total, Me.DescripStock})
        Me.DGVStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStock.Location = New System.Drawing.Point(0, 0)
        Me.DGVStock.Name = "DGVStock"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStock.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStock.Size = New System.Drawing.Size(477, 300)
        Me.DGVStock.TabIndex = 0
        '
        'IdInsumoStock
        '
        Me.IdInsumoStock.DataPropertyName = "IdInsumoStock"
        Me.IdInsumoStock.HeaderText = "IdInsumoStock"
        Me.IdInsumoStock.Name = "IdInsumoStock"
        Me.IdInsumoStock.ReadOnly = True
        Me.IdInsumoStock.Visible = False
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.DataPropertyName = "FechaStock"
        Me.Fecha.HeaderText = "Fecha Actual"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 95
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'CodigoStock
        '
        Me.CodigoStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoStock.DataPropertyName = "CodigoStock"
        Me.CodigoStock.HeaderText = "Codigo"
        Me.CodigoStock.Name = "CodigoStock"
        Me.CodigoStock.ReadOnly = True
        Me.CodigoStock.Width = 65
        '
        'NombreStock
        '
        Me.NombreStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreStock.DataPropertyName = "NombreStock"
        Me.NombreStock.HeaderText = "Nombre"
        Me.NombreStock.Name = "NombreStock"
        Me.NombreStock.ReadOnly = True
        Me.NombreStock.Width = 69
        '
        'CantStock
        '
        Me.CantStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CantStock.DataPropertyName = "CantStock"
        Me.CantStock.HeaderText = "CantIdad"
        Me.CantStock.Name = "CantStock"
        Me.CantStock.ReadOnly = True
        Me.CantStock.Width = 75
        '
        'PrecioUniStock
        '
        Me.PrecioUniStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrecioUniStock.DataPropertyName = "PrecioUniStock"
        Me.PrecioUniStock.HeaderText = "PrecioUni"
        Me.PrecioUniStock.Name = "PrecioUniStock"
        Me.PrecioUniStock.ReadOnly = True
        Me.PrecioUniStock.Width = 78
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 56
        '
        'DescripStock
        '
        Me.DescripStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DescripStock.DataPropertyName = "DescripStock"
        Me.DescripStock.HeaderText = "Descripcion"
        Me.DescripStock.Name = "DescripStock"
        Me.DescripStock.ReadOnly = True
        Me.DescripStock.Visible = False
        '
        'PaDgvStock
        '
        Me.PaDgvStock.Controls.Add(Me.DGVStock)
        Me.PaDgvStock.Location = New System.Drawing.Point(12, 100)
        Me.PaDgvStock.Name = "PaDgvStock"
        Me.PaDgvStock.Size = New System.Drawing.Size(477, 300)
        Me.PaDgvStock.TabIndex = 1
        '
        'BtnSalida
        '
        Me.BtnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalida.Image = Global.TallerTextil.My.Resources.Resources.quitarClaro
        Me.BtnSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalida.Location = New System.Drawing.Point(341, 4)
        Me.BtnSalida.Name = "BtnSalida"
        Me.BtnSalida.Size = New System.Drawing.Size(110, 40)
        Me.BtnSalida.TabIndex = 3
        Me.BtnSalida.Text = "Salida"
        Me.BtnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalida.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(495, 220)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 40)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "Editar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(495, 160)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 40)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(495, 280)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 40)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'PaDatos
        '
        Me.PaDatos.Controls.Add(Me.Label9)
        Me.PaDatos.Controls.Add(Me.BtnModiConfi)
        Me.PaDatos.Controls.Add(Me.BtnNuCrear)
        Me.PaDatos.Controls.Add(Me.BtnModiCancelar)
        Me.PaDatos.Controls.Add(Me.BtnNuCancelar)
        Me.PaDatos.Controls.Add(Me.LaId)
        Me.PaDatos.Controls.Add(Me.TbNuPreUni)
        Me.PaDatos.Controls.Add(Me.Label7)
        Me.PaDatos.Controls.Add(Me.Label6)
        Me.PaDatos.Controls.Add(Me.Label5)
        Me.PaDatos.Controls.Add(Me.TbNuCant)
        Me.PaDatos.Controls.Add(Me.Label4)
        Me.PaDatos.Controls.Add(Me.Label3)
        Me.PaDatos.Controls.Add(Me.TbNuCodigo)
        Me.PaDatos.Controls.Add(Me.TbNuDescrip)
        Me.PaDatos.Controls.Add(Me.TbNuNombre)
        Me.PaDatos.Location = New System.Drawing.Point(603, 100)
        Me.PaDatos.Name = "PaDatos"
        Me.PaDatos.Size = New System.Drawing.Size(320, 336)
        Me.PaDatos.TabIndex = 7
        Me.PaDatos.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(161, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Label9"
        '
        'BtnModiConfi
        '
        Me.BtnModiConfi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnModiConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModiConfi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModiConfi.Location = New System.Drawing.Point(36, 300)
        Me.BtnModiConfi.Name = "BtnModiConfi"
        Me.BtnModiConfi.Size = New System.Drawing.Size(100, 30)
        Me.BtnModiConfi.TabIndex = 15
        Me.BtnModiConfi.Text = "Guardar"
        Me.BtnModiConfi.UseVisualStyleBackColor = True
        '
        'BtnNuCrear
        '
        Me.BtnNuCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnNuCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuCrear.Location = New System.Drawing.Point(36, 300)
        Me.BtnNuCrear.Name = "BtnNuCrear"
        Me.BtnNuCrear.Size = New System.Drawing.Size(100, 30)
        Me.BtnNuCrear.TabIndex = 13
        Me.BtnNuCrear.Text = "Guardar"
        Me.BtnNuCrear.UseVisualStyleBackColor = True
        '
        'BtnModiCancelar
        '
        Me.BtnModiCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnModiCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModiCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModiCancelar.Location = New System.Drawing.Point(205, 300)
        Me.BtnModiCancelar.Name = "BtnModiCancelar"
        Me.BtnModiCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnModiCancelar.TabIndex = 14
        Me.BtnModiCancelar.Text = "Cancelar"
        Me.BtnModiCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuCancelar
        '
        Me.BtnNuCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNuCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuCancelar.Location = New System.Drawing.Point(205, 300)
        Me.BtnNuCancelar.Name = "BtnNuCancelar"
        Me.BtnNuCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnNuCancelar.TabIndex = 12
        Me.BtnNuCancelar.Text = "Cancelar"
        Me.BtnNuCancelar.UseVisualStyleBackColor = True
        '
        'LaId
        '
        Me.LaId.AutoSize = True
        Me.LaId.Dock = System.Windows.Forms.DockStyle.Top
        Me.LaId.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaId.Location = New System.Drawing.Point(0, 0)
        Me.LaId.Name = "LaId"
        Me.LaId.Size = New System.Drawing.Size(16, 14)
        Me.LaId.TabIndex = 11
        Me.LaId.Text = "ID"
        Me.LaId.Visible = False
        '
        'TbNuPreUni
        '
        Me.TbNuPreUni.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbNuPreUni.Location = New System.Drawing.Point(197, 240)
        Me.TbNuPreUni.Name = "TbNuPreUni"
        Me.TbNuPreUni.Size = New System.Drawing.Size(108, 29)
        Me.TbNuPreUni.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Precio por Unidad :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cantidad :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripcion :"
        '
        'TbNuCant
        '
        Me.TbNuCant.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbNuCant.Location = New System.Drawing.Point(197, 204)
        Me.TbNuCant.Name = "TbNuCant"
        Me.TbNuCant.Size = New System.Drawing.Size(108, 29)
        Me.TbNuCant.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Codigo :"
        '
        'TbNuCodigo
        '
        Me.TbNuCodigo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNuCodigo.Location = New System.Drawing.Point(150, 8)
        Me.TbNuCodigo.Name = "TbNuCodigo"
        Me.TbNuCodigo.Size = New System.Drawing.Size(155, 29)
        Me.TbNuCodigo.TabIndex = 2
        '
        'TbNuDescrip
        '
        Me.TbNuDescrip.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbNuDescrip.Location = New System.Drawing.Point(36, 116)
        Me.TbNuDescrip.Multiline = True
        Me.TbNuDescrip.Name = "TbNuDescrip"
        Me.TbNuDescrip.Size = New System.Drawing.Size(269, 82)
        Me.TbNuDescrip.TabIndex = 6
        '
        'TbNuNombre
        '
        Me.TbNuNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbNuNombre.Location = New System.Drawing.Point(150, 48)
        Me.TbNuNombre.Name = "TbNuNombre"
        Me.TbNuNombre.Size = New System.Drawing.Size(155, 29)
        Me.TbNuNombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Codigo o Nombre"
        '
        'PaBuscarText
        '
        Me.PaBuscarText.Controls.Add(Me.Button4)
        Me.PaBuscarText.Controls.Add(Me.TbBusCoNo)
        Me.PaBuscarText.Controls.Add(Me.Label2)
        Me.PaBuscarText.Location = New System.Drawing.Point(12, 25)
        Me.PaBuscarText.Name = "PaBuscarText"
        Me.PaBuscarText.Size = New System.Drawing.Size(238, 55)
        Me.PaBuscarText.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(184, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Todo"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TbBusCoNo
        '
        Me.TbBusCoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBusCoNo.Location = New System.Drawing.Point(7, 26)
        Me.TbBusCoNo.Name = "TbBusCoNo"
        Me.TbBusCoNo.Size = New System.Drawing.Size(171, 26)
        Me.TbBusCoNo.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-4, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Seleccione el Insumo:"
        '
        'PaEntSal
        '
        Me.PaEntSal.Controls.Add(Me.Label10)
        Me.PaEntSal.Controls.Add(Me.BtnSalGuardar)
        Me.PaEntSal.Controls.Add(Me.BtnSalCancelar)
        Me.PaEntSal.Controls.Add(Me.Label14)
        Me.PaEntSal.Controls.Add(Me.LaFecha)
        Me.PaEntSal.Controls.Add(Me.DtpFecha)
        Me.PaEntSal.Controls.Add(Me.BtnEntGuardar)
        Me.PaEntSal.Controls.Add(Me.BtnEntCancelar)
        Me.PaEntSal.Controls.Add(Me.LaCantAnterior)
        Me.PaEntSal.Controls.Add(Me.TbPreUni)
        Me.PaEntSal.Controls.Add(Me.LaPreUni)
        Me.PaEntSal.Controls.Add(Me.LaCantidad)
        Me.PaEntSal.Controls.Add(Me.TbCant)
        Me.PaEntSal.Controls.Add(Me.Label15)
        Me.PaEntSal.Controls.Add(Me.Label16)
        Me.PaEntSal.Controls.Add(Me.TbCodigo)
        Me.PaEntSal.Controls.Add(Me.TbNombre)
        Me.PaEntSal.Location = New System.Drawing.Point(929, 100)
        Me.PaEntSal.Name = "PaEntSal"
        Me.PaEntSal.Size = New System.Drawing.Size(320, 336)
        Me.PaEntSal.TabIndex = 13
        Me.PaEntSal.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(169, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Label10"
        '
        'BtnSalGuardar
        '
        Me.BtnSalGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnSalGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalGuardar.Location = New System.Drawing.Point(37, 300)
        Me.BtnSalGuardar.Name = "BtnSalGuardar"
        Me.BtnSalGuardar.Size = New System.Drawing.Size(100, 30)
        Me.BtnSalGuardar.TabIndex = 18
        Me.BtnSalGuardar.Text = "Guardar"
        Me.BtnSalGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalCancelar
        '
        Me.BtnSalCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalCancelar.Location = New System.Drawing.Point(205, 300)
        Me.BtnSalCancelar.Name = "BtnSalCancelar"
        Me.BtnSalCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnSalCancelar.TabIndex = 17
        Me.BtnSalCancelar.Text = "Cancelar"
        Me.BtnSalCancelar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(80, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 32)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Entrada"
        '
        'LaFecha
        '
        Me.LaFecha.AutoSize = True
        Me.LaFecha.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFecha.Location = New System.Drawing.Point(20, 135)
        Me.LaFecha.Name = "LaFecha"
        Me.LaFecha.Size = New System.Drawing.Size(162, 19)
        Me.LaFecha.TabIndex = 15
        Me.LaFecha.Text = "Fecha de Compra :"
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecha.Location = New System.Drawing.Point(197, 134)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(108, 22)
        Me.DtpFecha.TabIndex = 14
        Me.DtpFecha.Value = New Date(2024, 6, 21, 23, 13, 6, 0)
        '
        'BtnEntGuardar
        '
        Me.BtnEntGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEntGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEntGuardar.Location = New System.Drawing.Point(37, 300)
        Me.BtnEntGuardar.Name = "BtnEntGuardar"
        Me.BtnEntGuardar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEntGuardar.TabIndex = 13
        Me.BtnEntGuardar.Text = "Guardar"
        Me.BtnEntGuardar.UseVisualStyleBackColor = True
        '
        'BtnEntCancelar
        '
        Me.BtnEntCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEntCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEntCancelar.Location = New System.Drawing.Point(205, 300)
        Me.BtnEntCancelar.Name = "BtnEntCancelar"
        Me.BtnEntCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEntCancelar.TabIndex = 12
        Me.BtnEntCancelar.Text = "Cancelar"
        Me.BtnEntCancelar.UseVisualStyleBackColor = True
        '
        'LaCantAnterior
        '
        Me.LaCantAnterior.AutoSize = True
        Me.LaCantAnterior.Dock = System.Windows.Forms.DockStyle.Top
        Me.LaCantAnterior.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCantAnterior.Location = New System.Drawing.Point(0, 0)
        Me.LaCantAnterior.Name = "LaCantAnterior"
        Me.LaCantAnterior.Size = New System.Drawing.Size(28, 14)
        Me.LaCantAnterior.TabIndex = 11
        Me.LaCantAnterior.Text = "cant"
        Me.LaCantAnterior.Visible = False
        '
        'TbPreUni
        '
        Me.TbPreUni.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbPreUni.Location = New System.Drawing.Point(197, 230)
        Me.TbPreUni.Name = "TbPreUni"
        Me.TbPreUni.Size = New System.Drawing.Size(108, 29)
        Me.TbPreUni.TabIndex = 10
        '
        'LaPreUni
        '
        Me.LaPreUni.AutoSize = True
        Me.LaPreUni.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaPreUni.Location = New System.Drawing.Point(20, 221)
        Me.LaPreUni.Name = "LaPreUni"
        Me.LaPreUni.Size = New System.Drawing.Size(126, 38)
        Me.LaPreUni.TabIndex = 9
        Me.LaPreUni.Text = "Precio Actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Unidad :"
        '
        'LaCantidad
        '
        Me.LaCantidad.AutoSize = True
        Me.LaCantidad.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCantidad.Location = New System.Drawing.Point(20, 182)
        Me.LaCantidad.Name = "LaCantidad"
        Me.LaCantidad.Size = New System.Drawing.Size(171, 19)
        Me.LaCantidad.TabIndex = 7
        Me.LaCantidad.Text = "Cantidad Comprada:"
        '
        'TbCant
        '
        Me.TbCant.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbCant.Location = New System.Drawing.Point(197, 176)
        Me.TbCant.Name = "TbCant"
        Me.TbCant.Size = New System.Drawing.Size(108, 29)
        Me.TbCant.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 19)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Nombre :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Codigo :"
        '
        'TbCodigo
        '
        Me.TbCodigo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCodigo.Location = New System.Drawing.Point(150, 48)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.Size = New System.Drawing.Size(155, 29)
        Me.TbCodigo.TabIndex = 2
        '
        'TbNombre
        '
        Me.TbNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TbNombre.Location = New System.Drawing.Point(150, 88)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(155, 29)
        Me.TbNombre.TabIndex = 4
        '
        'PaAlertas
        '
        Me.PaAlertas.Controls.Add(Me.Label1)
        Me.PaAlertas.Controls.Add(Me.BtnAA)
        Me.PaAlertas.Controls.Add(Me.BtnAR)
        Me.PaAlertas.Controls.Add(Me.BtnAN)
        Me.PaAlertas.Location = New System.Drawing.Point(325, 25)
        Me.PaAlertas.Name = "PaAlertas"
        Me.PaAlertas.Size = New System.Drawing.Size(141, 68)
        Me.PaAlertas.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Alerta Stock:"
        '
        'BtnAA
        '
        Me.BtnAA.BackColor = System.Drawing.Color.Transparent
        Me.BtnAA.FlatAppearance.BorderSize = 0
        Me.BtnAA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAA.Image = CType(resources.GetObject("BtnAA.Image"), System.Drawing.Image)
        Me.BtnAA.Location = New System.Drawing.Point(95, 25)
        Me.BtnAA.Name = "BtnAA"
        Me.BtnAA.Size = New System.Drawing.Size(40, 40)
        Me.BtnAA.TabIndex = 23
        Me.BtnAA.Text = "999"
        Me.BtnAA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAA.UseVisualStyleBackColor = False
        '
        'BtnAR
        '
        Me.BtnAR.BackColor = System.Drawing.Color.Transparent
        Me.BtnAR.FlatAppearance.BorderSize = 0
        Me.BtnAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAR.Image = CType(resources.GetObject("BtnAR.Image"), System.Drawing.Image)
        Me.BtnAR.Location = New System.Drawing.Point(3, 25)
        Me.BtnAR.Name = "BtnAR"
        Me.BtnAR.Size = New System.Drawing.Size(40, 40)
        Me.BtnAR.TabIndex = 21
        Me.BtnAR.Text = "999"
        Me.BtnAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAR.UseVisualStyleBackColor = False
        '
        'BtnAN
        '
        Me.BtnAN.BackColor = System.Drawing.Color.Transparent
        Me.BtnAN.FlatAppearance.BorderSize = 0
        Me.BtnAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAN.Image = CType(resources.GetObject("BtnAN.Image"), System.Drawing.Image)
        Me.BtnAN.Location = New System.Drawing.Point(49, 25)
        Me.BtnAN.Name = "BtnAN"
        Me.BtnAN.Size = New System.Drawing.Size(40, 40)
        Me.BtnAN.TabIndex = 22
        Me.BtnAN.Text = "999"
        Me.BtnAN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAN.UseVisualStyleBackColor = False
        '
        'PaBtnES
        '
        Me.PaBtnES.Controls.Add(Me.Label8)
        Me.PaBtnES.Controls.Add(Me.BtnSalida)
        Me.PaBtnES.Controls.Add(Me.BtnEntrada)
        Me.PaBtnES.Location = New System.Drawing.Point(12, 406)
        Me.PaBtnES.Name = "PaBtnES"
        Me.PaBtnES.Size = New System.Drawing.Size(454, 48)
        Me.PaBtnES.TabIndex = 21
        '
        'BtnEntrada
        '
        Me.BtnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrada.Image = Global.TallerTextil.My.Resources.Resources.agregarClaro
        Me.BtnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntrada.Location = New System.Drawing.Point(222, 4)
        Me.BtnEntrada.Name = "BtnEntrada"
        Me.BtnEntrada.Size = New System.Drawing.Size(110, 40)
        Me.BtnEntrada.TabIndex = 2
        Me.BtnEntrada.Text = "Entrada"
        Me.BtnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEntrada.UseVisualStyleBackColor = True
        '
        'Aok
        '
        Me.Aok.BackColor = System.Drawing.Color.Transparent
        Me.Aok.FlatAppearance.BorderSize = 0
        Me.Aok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Aok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aok.Image = Global.TallerTextil.My.Resources.Resources.okClaro
        Me.Aok.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Aok.Location = New System.Drawing.Point(278, 32)
        Me.Aok.Name = "Aok"
        Me.Aok.Size = New System.Drawing.Size(44, 55)
        Me.Aok.TabIndex = 25
        Me.Aok.Text = "999"
        Me.Aok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aok.UseVisualStyleBackColor = False
        '
        'StockInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 658)
        Me.Controls.Add(Me.Aok)
        Me.Controls.Add(Me.PaBtnES)
        Me.Controls.Add(Me.PaAlertas)
        Me.Controls.Add(Me.PaEntSal)
        Me.Controls.Add(Me.PaBuscarText)
        Me.Controls.Add(Me.PaDatos)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.PaDgvStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockInsumos"
        Me.Text = "StockInsumos"
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaDgvStock.ResumeLayout(False)
        Me.PaDatos.ResumeLayout(False)
        Me.PaDatos.PerformLayout()
        Me.PaBuscarText.ResumeLayout(False)
        Me.PaBuscarText.PerformLayout()
        Me.PaEntSal.ResumeLayout(False)
        Me.PaEntSal.PerformLayout()
        Me.PaAlertas.ResumeLayout(False)
        Me.PaAlertas.PerformLayout()
        Me.PaBtnES.ResumeLayout(False)
        Me.PaBtnES.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVStock As DataGridView
    Friend WithEvents PaDgvStock As Panel
    Friend WithEvents BtnEntrada As Button
    Friend WithEvents BtnSalida As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents PaDatos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PaBuscarText As Panel
    Friend WithEvents TbBusCoNo As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TbNuPreUni As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbNuCant As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNuCodigo As TextBox
    Friend WithEvents TbNuDescrip As TextBox
    Friend WithEvents TbNuNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LaId As Label
    Friend WithEvents BtnNuCrear As Button
    Friend WithEvents BtnNuCancelar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnModiConfi As Button
    Friend WithEvents BtnModiCancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents IdInsumoStock As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents CodigoStock As DataGridViewTextBoxColumn
    Friend WithEvents NombreStock As DataGridViewTextBoxColumn
    Friend WithEvents CantStock As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniStock As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents DescripStock As DataGridViewTextBoxColumn
    Friend WithEvents PaEntSal As Panel
    Friend WithEvents BtnEntGuardar As Button
    Friend WithEvents BtnEntCancelar As Button
    Friend WithEvents TbPreUni As TextBox
    Friend WithEvents LaPreUni As Label
    Friend WithEvents LaCantidad As Label
    Friend WithEvents TbCant As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TbCodigo As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents LaCantAnterior As Label
    Friend WithEvents LaFecha As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnSalGuardar As Button
    Friend WithEvents BtnSalCancelar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnAR As Button
    Friend WithEvents BtnAA As Button
    Friend WithEvents BtnAN As Button
    Friend WithEvents PaAlertas As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PaBtnES As Panel
    Friend WithEvents Aok As Button
End Class
