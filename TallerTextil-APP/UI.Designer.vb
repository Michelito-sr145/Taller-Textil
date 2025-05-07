<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI))
        Me.PaMenuVertical = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.BtnNotas = New System.Windows.Forms.Button()
        Me.BtnGanancias = New System.Windows.Forms.Button()
        Me.BtnDespleIn = New System.Windows.Forms.Button()
        Me.BtnDespleArt = New System.Windows.Forms.Button()
        Me.PaProduc = New System.Windows.Forms.Panel()
        Me.BtnArticuloUsu = New System.Windows.Forms.Button()
        Me.BtnGraficoPro = New System.Windows.Forms.Button()
        Me.BtnPerfil = New System.Windows.Forms.Button()
        Me.PaInsumos = New System.Windows.Forms.Panel()
        Me.BtnGraficoInsu = New System.Windows.Forms.Button()
        Me.BtnInsumosUsu = New System.Windows.Forms.Button()
        Me.PaBarra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbLuna = New System.Windows.Forms.PictureBox()
        Me.PbSol = New System.Windows.Forms.PictureBox()
        Me.PbMenuOscu = New System.Windows.Forms.PictureBox()
        Me.PbMenuClaro = New System.Windows.Forms.PictureBox()
        Me.PbVentanaOscu = New System.Windows.Forms.PictureBox()
        Me.PbVentanaClaro = New System.Windows.Forms.PictureBox()
        Me.PbMinimizarOscu = New System.Windows.Forms.PictureBox()
        Me.PbMinimizarClaro = New System.Windows.Forms.PictureBox()
        Me.PbMaxiOscu = New System.Windows.Forms.PictureBox()
        Me.PbMaxiClaro = New System.Windows.Forms.PictureBox()
        Me.PbCerrarClaro = New System.Windows.Forms.PictureBox()
        Me.PbCerrarOscu = New System.Windows.Forms.PictureBox()
        Me.PaContenedor = New System.Windows.Forms.Panel()
        Me.PaMenuVertical.SuspendLayout()
        Me.PaProduc.SuspendLayout()
        Me.PaInsumos.SuspendLayout()
        Me.PaBarra.SuspendLayout()
        CType(Me.PbLuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbSol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMenuOscu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMenuClaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbVentanaOscu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbVentanaClaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMinimizarOscu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMinimizarClaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMaxiOscu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMaxiClaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCerrarClaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCerrarOscu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaMenuVertical
        '
        Me.PaMenuVertical.BackColor = System.Drawing.Color.Gray
        Me.PaMenuVertical.Controls.Add(Me.BtnCerrar)
        Me.PaMenuVertical.Controls.Add(Me.BtnInicio)
        Me.PaMenuVertical.Controls.Add(Me.BtnNotas)
        Me.PaMenuVertical.Controls.Add(Me.BtnGanancias)
        Me.PaMenuVertical.Controls.Add(Me.BtnDespleIn)
        Me.PaMenuVertical.Controls.Add(Me.BtnDespleArt)
        Me.PaMenuVertical.Controls.Add(Me.PaProduc)
        Me.PaMenuVertical.Controls.Add(Me.BtnPerfil)
        Me.PaMenuVertical.Controls.Add(Me.PaInsumos)
        Me.PaMenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.PaMenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.PaMenuVertical.Name = "PaMenuVertical"
        Me.PaMenuVertical.Size = New System.Drawing.Size(160, 501)
        Me.PaMenuVertical.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Image = Global.TallerTextil.My.Resources.Resources.SalirClaro
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 465)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(160, 36)
        Me.BtnCerrar.TabIndex = 9
        Me.BtnCerrar.Text = "CERRAR SESIÓN"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnInicio
        '
        Me.BtnInicio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnInicio.BackColor = System.Drawing.Color.Transparent
        Me.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.Location = New System.Drawing.Point(-82, 230)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(160, 50)
        Me.BtnInicio.TabIndex = 8
        Me.BtnInicio.Text = "INICIO"
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'BtnNotas
        '
        Me.BtnNotas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnNotas.BackColor = System.Drawing.Color.Transparent
        Me.BtnNotas.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnNotas.FlatAppearance.BorderSize = 0
        Me.BtnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotas.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotas.ForeColor = System.Drawing.Color.White
        Me.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotas.Location = New System.Drawing.Point(-82, 180)
        Me.BtnNotas.Name = "BtnNotas"
        Me.BtnNotas.Size = New System.Drawing.Size(160, 50)
        Me.BtnNotas.TabIndex = 7
        Me.BtnNotas.Text = "MIS NOTAS "
        Me.BtnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNotas.UseVisualStyleBackColor = False
        '
        'BtnGanancias
        '
        Me.BtnGanancias.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnGanancias.BackColor = System.Drawing.Color.Transparent
        Me.BtnGanancias.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnGanancias.FlatAppearance.BorderSize = 0
        Me.BtnGanancias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGanancias.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGanancias.ForeColor = System.Drawing.Color.White
        Me.BtnGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGanancias.Location = New System.Drawing.Point(-85, 124)
        Me.BtnGanancias.Name = "BtnGanancias"
        Me.BtnGanancias.Size = New System.Drawing.Size(160, 50)
        Me.BtnGanancias.TabIndex = 6
        Me.BtnGanancias.Text = "GANACIAS  "
        Me.BtnGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGanancias.UseVisualStyleBackColor = False
        '
        'BtnDespleIn
        '
        Me.BtnDespleIn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnDespleIn.BackColor = System.Drawing.Color.Transparent
        Me.BtnDespleIn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnDespleIn.FlatAppearance.BorderSize = 0
        Me.BtnDespleIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDespleIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDespleIn.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDespleIn.ForeColor = System.Drawing.Color.White
        Me.BtnDespleIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDespleIn.Location = New System.Drawing.Point(-66, 83)
        Me.BtnDespleIn.Name = "BtnDespleIn"
        Me.BtnDespleIn.Size = New System.Drawing.Size(160, 50)
        Me.BtnDespleIn.TabIndex = 2
        Me.BtnDespleIn.Text = "INSUMOS   "
        Me.BtnDespleIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDespleIn.UseVisualStyleBackColor = False
        '
        'BtnDespleArt
        '
        Me.BtnDespleArt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnDespleArt.BackColor = System.Drawing.Color.Transparent
        Me.BtnDespleArt.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnDespleArt.FlatAppearance.BorderSize = 0
        Me.BtnDespleArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDespleArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDespleArt.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDespleArt.ForeColor = System.Drawing.Color.White
        Me.BtnDespleArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDespleArt.Location = New System.Drawing.Point(-85, 43)
        Me.BtnDespleArt.Name = "BtnDespleArt"
        Me.BtnDespleArt.Size = New System.Drawing.Size(160, 50)
        Me.BtnDespleArt.TabIndex = 4
        Me.BtnDespleArt.Text = "PRODUCCION"
        Me.BtnDespleArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDespleArt.UseVisualStyleBackColor = False
        '
        'PaProduc
        '
        Me.PaProduc.BackColor = System.Drawing.Color.Transparent
        Me.PaProduc.Controls.Add(Me.BtnArticuloUsu)
        Me.PaProduc.Controls.Add(Me.BtnGraficoPro)
        Me.PaProduc.Location = New System.Drawing.Point(58, 25)
        Me.PaProduc.Name = "PaProduc"
        Me.PaProduc.Size = New System.Drawing.Size(153, 127)
        Me.PaProduc.TabIndex = 4
        '
        'BtnArticuloUsu
        '
        Me.BtnArticuloUsu.BackColor = System.Drawing.Color.Transparent
        Me.BtnArticuloUsu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnArticuloUsu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnArticuloUsu.FlatAppearance.BorderSize = 0
        Me.BtnArticuloUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnArticuloUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArticuloUsu.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArticuloUsu.ForeColor = System.Drawing.Color.White
        Me.BtnArticuloUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnArticuloUsu.Location = New System.Drawing.Point(0, 27)
        Me.BtnArticuloUsu.Name = "BtnArticuloUsu"
        Me.BtnArticuloUsu.Size = New System.Drawing.Size(153, 50)
        Me.BtnArticuloUsu.TabIndex = 0
        Me.BtnArticuloUsu.Text = "Prendas"
        Me.BtnArticuloUsu.UseVisualStyleBackColor = False
        '
        'BtnGraficoPro
        '
        Me.BtnGraficoPro.BackColor = System.Drawing.Color.Transparent
        Me.BtnGraficoPro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGraficoPro.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnGraficoPro.FlatAppearance.BorderSize = 0
        Me.BtnGraficoPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGraficoPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGraficoPro.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGraficoPro.ForeColor = System.Drawing.Color.White
        Me.BtnGraficoPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGraficoPro.Location = New System.Drawing.Point(0, 77)
        Me.BtnGraficoPro.Name = "BtnGraficoPro"
        Me.BtnGraficoPro.Size = New System.Drawing.Size(153, 50)
        Me.BtnGraficoPro.TabIndex = 3
        Me.BtnGraficoPro.Text = "Grafico"
        Me.BtnGraficoPro.UseVisualStyleBackColor = False
        '
        'BtnPerfil
        '
        Me.BtnPerfil.BackColor = System.Drawing.Color.Transparent
        Me.BtnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnPerfil.FlatAppearance.BorderSize = 0
        Me.BtnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPerfil.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPerfil.ForeColor = System.Drawing.Color.White
        Me.BtnPerfil.Image = Global.TallerTextil.My.Resources.Resources.UsuarioClaro
        Me.BtnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPerfil.Location = New System.Drawing.Point(0, 0)
        Me.BtnPerfil.Name = "BtnPerfil"
        Me.BtnPerfil.Size = New System.Drawing.Size(160, 50)
        Me.BtnPerfil.TabIndex = 7
        Me.BtnPerfil.Text = "Perfil"
        Me.BtnPerfil.UseVisualStyleBackColor = False
        '
        'PaInsumos
        '
        Me.PaInsumos.BackColor = System.Drawing.Color.Transparent
        Me.PaInsumos.Controls.Add(Me.BtnGraficoInsu)
        Me.PaInsumos.Controls.Add(Me.BtnInsumosUsu)
        Me.PaInsumos.Location = New System.Drawing.Point(58, 158)
        Me.PaInsumos.Name = "PaInsumos"
        Me.PaInsumos.Size = New System.Drawing.Size(153, 99)
        Me.PaInsumos.TabIndex = 5
        '
        'BtnGraficoInsu
        '
        Me.BtnGraficoInsu.BackColor = System.Drawing.Color.Transparent
        Me.BtnGraficoInsu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGraficoInsu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnGraficoInsu.FlatAppearance.BorderSize = 0
        Me.BtnGraficoInsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGraficoInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGraficoInsu.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGraficoInsu.ForeColor = System.Drawing.Color.White
        Me.BtnGraficoInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGraficoInsu.Location = New System.Drawing.Point(0, 50)
        Me.BtnGraficoInsu.Name = "BtnGraficoInsu"
        Me.BtnGraficoInsu.Size = New System.Drawing.Size(153, 50)
        Me.BtnGraficoInsu.TabIndex = 0
        Me.BtnGraficoInsu.Text = "In/Out"
        Me.BtnGraficoInsu.UseVisualStyleBackColor = False
        '
        'BtnInsumosUsu
        '
        Me.BtnInsumosUsu.BackColor = System.Drawing.Color.Transparent
        Me.BtnInsumosUsu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInsumosUsu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnInsumosUsu.FlatAppearance.BorderSize = 0
        Me.BtnInsumosUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnInsumosUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsumosUsu.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsumosUsu.ForeColor = System.Drawing.Color.White
        Me.BtnInsumosUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsumosUsu.Location = New System.Drawing.Point(0, 0)
        Me.BtnInsumosUsu.Name = "BtnInsumosUsu"
        Me.BtnInsumosUsu.Size = New System.Drawing.Size(153, 50)
        Me.BtnInsumosUsu.TabIndex = 1
        Me.BtnInsumosUsu.Text = "Stock"
        Me.BtnInsumosUsu.UseVisualStyleBackColor = False
        '
        'PaBarra
        '
        Me.PaBarra.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PaBarra.Controls.Add(Me.Label1)
        Me.PaBarra.Controls.Add(Me.PbLuna)
        Me.PaBarra.Controls.Add(Me.PbSol)
        Me.PaBarra.Controls.Add(Me.PbMenuOscu)
        Me.PaBarra.Controls.Add(Me.PbMenuClaro)
        Me.PaBarra.Controls.Add(Me.PbVentanaOscu)
        Me.PaBarra.Controls.Add(Me.PbVentanaClaro)
        Me.PaBarra.Controls.Add(Me.PbMinimizarOscu)
        Me.PaBarra.Controls.Add(Me.PbMinimizarClaro)
        Me.PaBarra.Controls.Add(Me.PbMaxiOscu)
        Me.PaBarra.Controls.Add(Me.PbMaxiClaro)
        Me.PaBarra.Controls.Add(Me.PbCerrarClaro)
        Me.PaBarra.Controls.Add(Me.PbCerrarOscu)
        Me.PaBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaBarra.Location = New System.Drawing.Point(160, 0)
        Me.PaBarra.Name = "PaBarra"
        Me.PaBarra.Size = New System.Drawing.Size(824, 40)
        Me.PaBarra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'PbLuna
        '
        Me.PbLuna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbLuna.BackColor = System.Drawing.Color.Transparent
        Me.PbLuna.Image = Global.TallerTextil.My.Resources.Resources.Luna
        Me.PbLuna.Location = New System.Drawing.Point(698, 7)
        Me.PbLuna.Name = "PbLuna"
        Me.PbLuna.Size = New System.Drawing.Size(30, 30)
        Me.PbLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLuna.TabIndex = 11
        Me.PbLuna.TabStop = False
        Me.PbLuna.Visible = False
        '
        'PbSol
        '
        Me.PbSol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbSol.BackColor = System.Drawing.Color.Transparent
        Me.PbSol.Image = Global.TallerTextil.My.Resources.Resources.Sol
        Me.PbSol.Location = New System.Drawing.Point(698, 7)
        Me.PbSol.Name = "PbSol"
        Me.PbSol.Size = New System.Drawing.Size(30, 30)
        Me.PbSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbSol.TabIndex = 10
        Me.PbSol.TabStop = False
        Me.PbSol.Visible = False
        '
        'PbMenuOscu
        '
        Me.PbMenuOscu.Image = Global.TallerTextil.My.Resources.Resources.MenuOscu
        Me.PbMenuOscu.Location = New System.Drawing.Point(3, 3)
        Me.PbMenuOscu.Name = "PbMenuOscu"
        Me.PbMenuOscu.Size = New System.Drawing.Size(35, 35)
        Me.PbMenuOscu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbMenuOscu.TabIndex = 9
        Me.PbMenuOscu.TabStop = False
        Me.PbMenuOscu.Visible = False
        '
        'PbMenuClaro
        '
        Me.PbMenuClaro.Image = Global.TallerTextil.My.Resources.Resources.MenuClaro
        Me.PbMenuClaro.Location = New System.Drawing.Point(0, 3)
        Me.PbMenuClaro.Name = "PbMenuClaro"
        Me.PbMenuClaro.Size = New System.Drawing.Size(35, 35)
        Me.PbMenuClaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbMenuClaro.TabIndex = 8
        Me.PbMenuClaro.TabStop = False
        Me.PbMenuClaro.Visible = False
        '
        'PbVentanaOscu
        '
        Me.PbVentanaOscu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbVentanaOscu.Image = Global.TallerTextil.My.Resources.Resources.MiniOscu
        Me.PbVentanaOscu.Location = New System.Drawing.Point(734, 9)
        Me.PbVentanaOscu.Name = "PbVentanaOscu"
        Me.PbVentanaOscu.Size = New System.Drawing.Size(25, 25)
        Me.PbVentanaOscu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbVentanaOscu.TabIndex = 7
        Me.PbVentanaOscu.TabStop = False
        Me.PbVentanaOscu.Visible = False
        '
        'PbVentanaClaro
        '
        Me.PbVentanaClaro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbVentanaClaro.Image = Global.TallerTextil.My.Resources.Resources.MiniClaro
        Me.PbVentanaClaro.Location = New System.Drawing.Point(734, 9)
        Me.PbVentanaClaro.Name = "PbVentanaClaro"
        Me.PbVentanaClaro.Size = New System.Drawing.Size(25, 25)
        Me.PbVentanaClaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbVentanaClaro.TabIndex = 6
        Me.PbVentanaClaro.TabStop = False
        Me.PbVentanaClaro.Visible = False
        '
        'PbMinimizarOscu
        '
        Me.PbMinimizarOscu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbMinimizarOscu.Image = Global.TallerTextil.My.Resources.Resources.MinimizarOscu
        Me.PbMinimizarOscu.Location = New System.Drawing.Point(765, 9)
        Me.PbMinimizarOscu.Name = "PbMinimizarOscu"
        Me.PbMinimizarOscu.Size = New System.Drawing.Size(25, 25)
        Me.PbMinimizarOscu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbMinimizarOscu.TabIndex = 5
        Me.PbMinimizarOscu.TabStop = False
        Me.PbMinimizarOscu.Visible = False
        '
        'PbMinimizarClaro
        '
        Me.PbMinimizarClaro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbMinimizarClaro.Image = Global.TallerTextil.My.Resources.Resources.MinimizarClaro
        Me.PbMinimizarClaro.Location = New System.Drawing.Point(765, 9)
        Me.PbMinimizarClaro.Name = "PbMinimizarClaro"
        Me.PbMinimizarClaro.Size = New System.Drawing.Size(25, 25)
        Me.PbMinimizarClaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbMinimizarClaro.TabIndex = 4
        Me.PbMinimizarClaro.TabStop = False
        Me.PbMinimizarClaro.Visible = False
        '
        'PbMaxiOscu
        '
        Me.PbMaxiOscu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbMaxiOscu.Image = Global.TallerTextil.My.Resources.Resources.MaximoOscu
        Me.PbMaxiOscu.Location = New System.Drawing.Point(765, 9)
        Me.PbMaxiOscu.Name = "PbMaxiOscu"
        Me.PbMaxiOscu.Size = New System.Drawing.Size(25, 25)
        Me.PbMaxiOscu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbMaxiOscu.TabIndex = 3
        Me.PbMaxiOscu.TabStop = False
        Me.PbMaxiOscu.Visible = False
        '
        'PbMaxiClaro
        '
        Me.PbMaxiClaro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbMaxiClaro.Image = Global.TallerTextil.My.Resources.Resources.MaximoClaro
        Me.PbMaxiClaro.Location = New System.Drawing.Point(765, 9)
        Me.PbMaxiClaro.Name = "PbMaxiClaro"
        Me.PbMaxiClaro.Size = New System.Drawing.Size(25, 25)
        Me.PbMaxiClaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbMaxiClaro.TabIndex = 2
        Me.PbMaxiClaro.TabStop = False
        Me.PbMaxiClaro.Visible = False
        '
        'PbCerrarClaro
        '
        Me.PbCerrarClaro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbCerrarClaro.Image = Global.TallerTextil.My.Resources.Resources.CerraClaro
        Me.PbCerrarClaro.Location = New System.Drawing.Point(796, 9)
        Me.PbCerrarClaro.Name = "PbCerrarClaro"
        Me.PbCerrarClaro.Size = New System.Drawing.Size(25, 25)
        Me.PbCerrarClaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbCerrarClaro.TabIndex = 1
        Me.PbCerrarClaro.TabStop = False
        Me.PbCerrarClaro.Visible = False
        '
        'PbCerrarOscu
        '
        Me.PbCerrarOscu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbCerrarOscu.Image = Global.TallerTextil.My.Resources.Resources.CerraOscu
        Me.PbCerrarOscu.Location = New System.Drawing.Point(796, 9)
        Me.PbCerrarOscu.Name = "PbCerrarOscu"
        Me.PbCerrarOscu.Size = New System.Drawing.Size(25, 25)
        Me.PbCerrarOscu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbCerrarOscu.TabIndex = 0
        Me.PbCerrarOscu.TabStop = False
        Me.PbCerrarOscu.Visible = False
        '
        'PaContenedor
        '
        Me.PaContenedor.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PaContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaContenedor.Location = New System.Drawing.Point(160, 40)
        Me.PaContenedor.Name = "PaContenedor"
        Me.PaContenedor.Size = New System.Drawing.Size(824, 461)
        Me.PaContenedor.TabIndex = 2
        '
        'UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 501)
        Me.Controls.Add(Me.PaContenedor)
        Me.Controls.Add(Me.PaBarra)
        Me.Controls.Add(Me.PaMenuVertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UI"
        Me.PaMenuVertical.ResumeLayout(False)
        Me.PaProduc.ResumeLayout(False)
        Me.PaInsumos.ResumeLayout(False)
        Me.PaBarra.ResumeLayout(False)
        Me.PaBarra.PerformLayout()
        CType(Me.PbLuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbSol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMenuOscu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMenuClaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbVentanaOscu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbVentanaClaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMinimizarOscu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMinimizarClaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMaxiOscu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMaxiClaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCerrarClaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCerrarOscu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaMenuVertical As Panel
    Friend WithEvents PaBarra As Panel
    Friend WithEvents PbVentanaOscu As PictureBox
    Friend WithEvents PbVentanaClaro As PictureBox
    Friend WithEvents PbMinimizarOscu As PictureBox
    Friend WithEvents PbMinimizarClaro As PictureBox
    Friend WithEvents PbMaxiOscu As PictureBox
    Friend WithEvents PbMaxiClaro As PictureBox
    Friend WithEvents PbCerrarClaro As PictureBox
    Friend WithEvents PbCerrarOscu As PictureBox
    Friend WithEvents PaContenedor As Panel
    Friend WithEvents PbMenuOscu As PictureBox
    Friend WithEvents PbMenuClaro As PictureBox
    Friend WithEvents PbLuna As PictureBox
    Friend WithEvents PbSol As PictureBox
    Friend WithEvents BtnArticuloUsu As Button
    Friend WithEvents BtnInsumosUsu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PaProduc As Panel
    Friend WithEvents BtnGraficoPro As Button
    Friend WithEvents BtnDespleArt As Button
    Friend WithEvents PaInsumos As Panel
    Friend WithEvents BtnGraficoInsu As Button
    Friend WithEvents BtnDespleIn As Button
    Friend WithEvents BtnGanancias As Button
    Friend WithEvents BtnPerfil As Button
    Friend WithEvents BtnNotas As Button
    Friend WithEvents BtnInicio As Button
    Friend WithEvents BtnCerrar As Button
End Class
