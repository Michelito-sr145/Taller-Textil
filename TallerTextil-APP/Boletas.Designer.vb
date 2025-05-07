<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boletas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVNota = New System.Windows.Forms.DataGridView()
        Me.IdNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaDGVnota = New System.Windows.Forms.Panel()
        Me.PaDato = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TbTitulo = New System.Windows.Forms.TextBox()
        Me.TbCuerpo = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaDGVnota.SuspendLayout()
        Me.PaDato.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVNota
        '
        Me.DGVNota.AllowUserToAddRows = False
        Me.DGVNota.AllowUserToDeleteRows = False
        Me.DGVNota.AllowUserToOrderColumns = True
        Me.DGVNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdNota, Me.IdUsuario, Me.FechaNota, Me.Nota, Me.Titulo})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVNota.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGVNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVNota.Location = New System.Drawing.Point(0, 0)
        Me.DGVNota.Name = "DGVNota"
        Me.DGVNota.ReadOnly = True
        Me.DGVNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVNota.Size = New System.Drawing.Size(386, 308)
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
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
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
        Me.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Titulo.DataPropertyName = "Titulo"
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        Me.Titulo.ReadOnly = True
        Me.Titulo.Width = 58
        '
        'PaDGVnota
        '
        Me.PaDGVnota.Controls.Add(Me.DGVNota)
        Me.PaDGVnota.Location = New System.Drawing.Point(8, 120)
        Me.PaDGVnota.Name = "PaDGVnota"
        Me.PaDGVnota.Size = New System.Drawing.Size(386, 308)
        Me.PaDGVnota.TabIndex = 1
        '
        'PaDato
        '
        Me.PaDato.Controls.Add(Me.DtpFecha)
        Me.PaDato.Controls.Add(Me.TbTitulo)
        Me.PaDato.Controls.Add(Me.TbCuerpo)
        Me.PaDato.Location = New System.Drawing.Point(552, 12)
        Me.PaDato.Name = "PaDato"
        Me.PaDato.Size = New System.Drawing.Size(433, 380)
        Me.PaDato.TabIndex = 2
        '
        'DtpFecha
        '
        Me.DtpFecha.CalendarFont = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecha.Location = New System.Drawing.Point(305, 7)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(128, 26)
        Me.DtpFecha.TabIndex = 2
        '
        'TbTitulo
        '
        Me.TbTitulo.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTitulo.Location = New System.Drawing.Point(3, 3)
        Me.TbTitulo.Name = "TbTitulo"
        Me.TbTitulo.Size = New System.Drawing.Size(302, 36)
        Me.TbTitulo.TabIndex = 1
        '
        'TbCuerpo
        '
        Me.TbCuerpo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TbCuerpo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCuerpo.Location = New System.Drawing.Point(0, 45)
        Me.TbCuerpo.Multiline = True
        Me.TbCuerpo.Name = "TbCuerpo"
        Me.TbCuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbCuerpo.Size = New System.Drawing.Size(433, 335)
        Me.TbCuerpo.TabIndex = 3
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(762, 398)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 30)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(890, 398)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(95, 30)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(397, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(130, 150)
        Me.Panel3.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 39)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Eliminar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DtpInicio
        '
        Me.DtpInicio.CalendarFont = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpInicio.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpInicio.Location = New System.Drawing.Point(321, 54)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.Size = New System.Drawing.Size(92, 23)
        Me.DtpInicio.TabIndex = 9
        '
        'DtpFinal
        '
        Me.DtpFinal.CalendarFont = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFinal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFinal.Location = New System.Drawing.Point(419, 54)
        Me.DtpFinal.Name = "DtpFinal"
        Me.DtpFinal.Size = New System.Drawing.Size(92, 23)
        Me.DtpFinal.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 32)
        Me.TextBox1.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtpInicio)
        Me.Panel1.Controls.Add(Me.DtpFinal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 94)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(317, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Inicio:    Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Filtar por fechas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Buscar por titulo:"
        '
        'Boletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PaDato)
        Me.Controls.Add(Me.PaDGVnota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Boletas"
        Me.Text = "Boletas"
        CType(Me.DGVNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaDGVnota.ResumeLayout(False)
        Me.PaDato.ResumeLayout(False)
        Me.PaDato.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVNota As DataGridView
    Friend WithEvents PaDGVnota As Panel
    Friend WithEvents PaDato As Panel
    Friend WithEvents TbTitulo As TextBox
    Friend WithEvents TbCuerpo As TextBox
    Friend WithEvents IdNota As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaNota As DataGridViewTextBoxColumn
    Friend WithEvents Nota As DataGridViewTextBoxColumn
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents DtpInicio As DateTimePicker
    Friend WithEvents DtpFinal As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
