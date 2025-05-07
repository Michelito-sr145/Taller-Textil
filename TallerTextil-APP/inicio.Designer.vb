<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaAlertas = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAA = New System.Windows.Forms.Button()
        Me.BtnAR = New System.Windows.Forms.Button()
        Me.BtnAN = New System.Windows.Forms.Button()
        Me.PaDgvStock = New System.Windows.Forms.Panel()
        Me.DGVStock = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Aok = New System.Windows.Forms.Button()
        Me.PaDato = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TbTitulo = New System.Windows.Forms.TextBox()
        Me.TbCuerpo = New System.Windows.Forms.TextBox()
        Me.PaDGVnota = New System.Windows.Forms.Panel()
        Me.DGVNota = New System.Windows.Forms.DataGridView()
        Me.IdNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdInsumoStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaAlertas.SuspendLayout()
        Me.PaDgvStock.SuspendLayout()
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PaDato.SuspendLayout()
        Me.PaDGVnota.SuspendLayout()
        CType(Me.DGVNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaAlertas
        '
        Me.PaAlertas.Controls.Add(Me.Label1)
        Me.PaAlertas.Controls.Add(Me.BtnAA)
        Me.PaAlertas.Controls.Add(Me.BtnAR)
        Me.PaAlertas.Controls.Add(Me.BtnAN)
        Me.PaAlertas.Location = New System.Drawing.Point(60, 132)
        Me.PaAlertas.Name = "PaAlertas"
        Me.PaAlertas.Size = New System.Drawing.Size(250, 98)
        Me.PaAlertas.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Alerta poco Stock:"
        '
        'BtnAA
        '
        Me.BtnAA.BackColor = System.Drawing.Color.Transparent
        Me.BtnAA.FlatAppearance.BorderSize = 0
        Me.BtnAA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAA.Image = CType(resources.GetObject("BtnAA.Image"), System.Drawing.Image)
        Me.BtnAA.Location = New System.Drawing.Point(45, 42)
        Me.BtnAA.Name = "BtnAA"
        Me.BtnAA.Size = New System.Drawing.Size(50, 50)
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
        Me.BtnAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAR.Image = CType(resources.GetObject("BtnAR.Image"), System.Drawing.Image)
        Me.BtnAR.Location = New System.Drawing.Point(145, 42)
        Me.BtnAR.Name = "BtnAR"
        Me.BtnAR.Size = New System.Drawing.Size(50, 50)
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
        Me.BtnAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAN.Image = CType(resources.GetObject("BtnAN.Image"), System.Drawing.Image)
        Me.BtnAN.Location = New System.Drawing.Point(95, 42)
        Me.BtnAN.Name = "BtnAN"
        Me.BtnAN.Size = New System.Drawing.Size(50, 50)
        Me.BtnAN.TabIndex = 22
        Me.BtnAN.Text = "999"
        Me.BtnAN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAN.UseVisualStyleBackColor = False
        '
        'PaDgvStock
        '
        Me.PaDgvStock.Controls.Add(Me.DGVStock)
        Me.PaDgvStock.Location = New System.Drawing.Point(364, 12)
        Me.PaDgvStock.Name = "PaDgvStock"
        Me.PaDgvStock.Size = New System.Drawing.Size(594, 278)
        Me.PaDgvStock.TabIndex = 21
        '
        'DGVStock
        '
        Me.DGVStock.AllowUserToAddRows = False
        Me.DGVStock.AllowUserToDeleteRows = False
        Me.DGVStock.AllowUserToOrderColumns = True
        Me.DGVStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInsumoStock, Me.Fecha, Me.IdUsuario, Me.CodigoStock, Me.NombreStock, Me.DescripStock, Me.CantStock, Me.PrecioUniStock, Me.Total})
        Me.DGVStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStock.Location = New System.Drawing.Point(0, 0)
        Me.DGVStock.Name = "DGVStock"
        Me.DGVStock.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStock.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStock.Size = New System.Drawing.Size(594, 278)
        Me.DGVStock.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 96)
        Me.Panel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 32)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "PM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "-----------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(312, 75)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
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
        Me.Aok.Location = New System.Drawing.Point(315, 169)
        Me.Aok.Name = "Aok"
        Me.Aok.Size = New System.Drawing.Size(44, 55)
        Me.Aok.TabIndex = 24
        Me.Aok.Text = "999"
        Me.Aok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Aok.UseVisualStyleBackColor = False
        '
        'PaDato
        '
        Me.PaDato.Controls.Add(Me.DtpFecha)
        Me.PaDato.Controls.Add(Me.TbTitulo)
        Me.PaDato.Controls.Add(Me.TbCuerpo)
        Me.PaDato.Location = New System.Drawing.Point(364, 296)
        Me.PaDato.Name = "PaDato"
        Me.PaDato.Size = New System.Drawing.Size(594, 250)
        Me.PaDato.TabIndex = 26
        '
        'DtpFecha
        '
        Me.DtpFecha.CalendarFont = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecha.Location = New System.Drawing.Point(493, 10)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(98, 22)
        Me.DtpFecha.TabIndex = 2
        '
        'TbTitulo
        '
        Me.TbTitulo.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTitulo.Location = New System.Drawing.Point(3, 3)
        Me.TbTitulo.Name = "TbTitulo"
        Me.TbTitulo.Size = New System.Drawing.Size(484, 36)
        Me.TbTitulo.TabIndex = 1
        '
        'TbCuerpo
        '
        Me.TbCuerpo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TbCuerpo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCuerpo.Location = New System.Drawing.Point(0, 45)
        Me.TbCuerpo.Multiline = True
        Me.TbCuerpo.Name = "TbCuerpo"
        Me.TbCuerpo.ReadOnly = True
        Me.TbCuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbCuerpo.Size = New System.Drawing.Size(594, 205)
        Me.TbCuerpo.TabIndex = 3
        '
        'PaDGVnota
        '
        Me.PaDGVnota.Controls.Add(Me.DGVNota)
        Me.PaDGVnota.Location = New System.Drawing.Point(12, 296)
        Me.PaDGVnota.Name = "PaDGVnota"
        Me.PaDGVnota.Size = New System.Drawing.Size(346, 250)
        Me.PaDGVnota.TabIndex = 25
        '
        'DGVNota
        '
        Me.DGVNota.AllowUserToAddRows = False
        Me.DGVNota.AllowUserToDeleteRows = False
        Me.DGVNota.AllowUserToOrderColumns = True
        Me.DGVNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdNota, Me.DataGridViewTextBoxColumn1, Me.FechaNota, Me.Nota, Me.Titulo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVNota.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVNota.Location = New System.Drawing.Point(0, 0)
        Me.DGVNota.Name = "DGVNota"
        Me.DGVNota.ReadOnly = True
        Me.DGVNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVNota.Size = New System.Drawing.Size(346, 250)
        Me.DGVNota.TabIndex = 0
        '
        'IdNota
        '
        Me.IdNota.DataPropertyName = "IdNota"
        Me.IdNota.HeaderText = "IdNota"
        Me.IdNota.Name = "IdNota"
        Me.IdNota.ReadOnly = True
        Me.IdNota.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdUsuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'FechaNota
        '
        Me.FechaNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaNota.DataPropertyName = "FechaNota"
        Me.FechaNota.HeaderText = "Fecha"
        Me.FechaNota.Name = "FechaNota"
        Me.FechaNota.ReadOnly = True
        Me.FechaNota.Width = 62
        '
        'Nota
        '
        Me.Nota.DataPropertyName = "Nota"
        Me.Nota.HeaderText = "Nota"
        Me.Nota.Name = "Nota"
        Me.Nota.ReadOnly = True
        Me.Nota.Visible = False
        '
        'Titulo
        '
        Me.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Titulo.DataPropertyName = "Titulo"
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        Me.Titulo.ReadOnly = True
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
        Me.Fecha.ReadOnly = True
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
        'DescripStock
        '
        Me.DescripStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DescripStock.DataPropertyName = "DescripStock"
        Me.DescripStock.HeaderText = "Descripcion"
        Me.DescripStock.Name = "DescripStock"
        Me.DescripStock.ReadOnly = True
        Me.DescripStock.Width = 88
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
        Me.Total.ReadOnly = True
        Me.Total.Width = 56
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.PaDato)
        Me.Controls.Add(Me.PaDGVnota)
        Me.Controls.Add(Me.Aok)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PaAlertas)
        Me.Controls.Add(Me.PaDgvStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.PaAlertas.ResumeLayout(False)
        Me.PaAlertas.PerformLayout()
        Me.PaDgvStock.ResumeLayout(False)
        CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PaDato.ResumeLayout(False)
        Me.PaDato.PerformLayout()
        Me.PaDGVnota.ResumeLayout(False)
        CType(Me.DGVNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaAlertas As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAA As Button
    Friend WithEvents BtnAR As Button
    Friend WithEvents BtnAN As Button
    Friend WithEvents PaDgvStock As Panel
    Friend WithEvents DGVStock As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Aok As Button
    Friend WithEvents PaDato As Panel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TbTitulo As TextBox
    Friend WithEvents TbCuerpo As TextBox
    Friend WithEvents PaDGVnota As Panel
    Friend WithEvents DGVNota As DataGridView
    Friend WithEvents IdNota As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaNota As DataGridViewTextBoxColumn
    Friend WithEvents Nota As DataGridViewTextBoxColumn
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents IdInsumoStock As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents CodigoStock As DataGridViewTextBoxColumn
    Friend WithEvents NombreStock As DataGridViewTextBoxColumn
    Friend WithEvents DescripStock As DataGridViewTextBoxColumn
    Friend WithEvents CantStock As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniStock As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
