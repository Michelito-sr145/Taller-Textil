Public Class UI
    Dim IDUsuarioN As Integer
    Dim IDRolN As Integer
    Dim ModoOscuroUI As Boolean
    Private isDragging As Boolean = False
    Private startPoint As Point
    Public Sub New(idUsuario As Integer, idRol As Integer, modo As Boolean)
        InitializeComponent()
        IDUsuarioN = idUsuario
        IDRolN = idRol
        ModoOscuroUI = modo
        ModoTema(modo)
    End Sub

    Private Sub UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If IDRolN = 2 Then
        '    BtnTodosArti.Visible = True
        '    BtnTodosUsu.Visible = True
        'ElseIf IDRolN = 1 Then
        '    BtnTodosArti.Visible = False
        '    BtnTodosUsu.Visible = False
        ''End If
        Menuvertical()
        Controles(False, BtnInicio)
        AbrirFormPa(New inicio(IDUsuarioN, ModoOscuroUI))
        Label1.Location = New Point(140, 10)
        PociBtns()
        Label1.Text = "Inicio"
        Tema()
        AddHandler PaBarra.MouseDown, AddressOf barra_MouseDown
        AddHandler PaBarra.MouseMove, AddressOf barra_MouseMove
        AddHandler PaBarra.MouseUp, AddressOf barra_MouseUp
        AddHandler Label1.MouseDown, AddressOf barra_MouseDown
        AddHandler Label1.MouseMove, AddressOf barra_MouseMove
        AddHandler Label1.MouseUp, AddressOf barra_MouseUp

    End Sub
    ' Eventos de ratón para arrastrar el formulario
    Private Sub barra_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = e.Location
        End If
    End Sub

    Private Sub barra_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - Me.startPoint.X, p.Y - Me.startPoint.Y)
        End If
    End Sub

    Private Sub barra_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    ' ----------------Parte de Diseño------------

    ' Oculta El Menu Vertical
    Private Function Menuvertical()
        If (PaMenuVertical.Width = 160) Then
            PaMenuVertical.Width = 50
            BtnCerrar.Text = ""
        Else
            PaMenuVertical.Width = 160
            BtnCerrar.Text = "CERRAR SESIÓN"
        End If
    End Function
    Private Sub PbMenuClaro_Click(sender As Object, e As EventArgs) Handles PbMenuClaro.Click
        PociBtns()
        Menuvertical()
    End Sub

    Private Sub PbMenuOscu_Click(sender As Object, e As EventArgs) Handles PbMenuOscu.Click
        PociBtns()
        Menuvertical()
    End Sub


    ' Cerrar Aplicacion
    Private Function CerrarUi()
        Application.Exit()
    End Function
    Private Sub PbCerrarOscu_Click(sender As Object, e As EventArgs) Handles PbCerrarOscu.Click
        CerrarUi()
    End Sub
    Private Sub PbCerrarClaro_Click(sender As Object, e As EventArgs) Handles PbCerrarClaro.Click
        CerrarUi()
    End Sub


    ' Ventana Completa
    Private Function MaximizarVentana()
        Me.WindowState = FormWindowState.Maximized
        IsMaximized = True ' IsMaximized Ventana Completa
        PbMaxiClaro.Visible = False
        PbMaxiOscu.Visible = False
        PociBtns()
        If (ModoOscuroUI = False) Then
            PbMinimizarClaro.Visible = True
            PbMinimizarOscu.Visible = False
        Else
            PbMinimizarClaro.Visible = False
            PbMinimizarOscu.Visible = True
        End If
        UpdateChildForms(PaContenedor)
    End Function
    Private Sub PbMaxiClaro_Click(sender As Object, e As EventArgs) Handles PbMaxiClaro.Click
        MaximizarVentana()
    End Sub
    Private Sub PbMaxiOscu_Click(sender As Object, e As EventArgs) Handles PbMaxiOscu.Click
        MaximizarVentana()
    End Sub


    ' Ventana Normal
    Private Function NomalVentana()
        Me.WindowState = FormWindowState.Normal
        IsMaximized = False ' IsMaximized Ventana Normal
        PbMinimizarClaro.Visible = False
        PbMinimizarOscu.Visible = False
        PociBtns()
        If (ModoOscuroUI = False) Then
            PbMaxiClaro.Visible = True
            PbMaxiOscu.Visible = False
        Else
            PbMaxiClaro.Visible = False
            PbMaxiOscu.Visible = True
        End If
        UpdateChildForms(PaContenedor)
    End Function
    Private Sub PbMinimizarClaro_Click(sender As Object, e As EventArgs) Handles PbMinimizarClaro.Click
        NomalVentana()
    End Sub
    Private Sub PbMinimizarOscu_Click(sender As Object, e As EventArgs) Handles PbMinimizarOscu.Click
        NomalVentana()
    End Sub


    ' Guarda la Aplicacion
    Private Function Minimizar()
        Me.WindowState = FormWindowState.Minimized
    End Function
    Private Sub PbVentanaClaro_Click(sender As Object, e As EventArgs) Handles PbVentanaClaro.Click
        Minimizar()
    End Sub
    Private Sub PbVentanaOscu_Click(sender As Object, e As EventArgs) Handles PbVentanaOscu.Click
        Minimizar()
    End Sub

    Private Sub AbrirFormPa(fh As Form)
        If (PaContenedor.Controls.Count > 0) Then
            PaContenedor.Controls.RemoveAt(0)
        End If
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        PaContenedor.Controls.Add(fh)
        PaContenedor.Tag = fh
        fh.Show()
    End Sub


    ' Pociciones iniciales
    Function PociBtns()
        BtnInicio.Location = New Point(0, 0)
        BtnPerfil.Location = New Point(0, 53)
        BtnDespleArt.Location = New Point(0, 105)
        Ocultar(PaProduc)
        BtnDespleIn.Location = New Point(0, 160)
        Ocultar(PaInsumos)
        BtnGanancias.Location = New Point(0, 215)
        BtnNotas.Location = New Point(0, 270)
    End Function

    Dim alturaOriginal As Integer
    Private Sub Mostrar(alturaOriginal As Integer, panelc As Panel)
        Dim timer As New Timer()
        Dim incremento As Integer = 15 ' Velocidad de la animación
        Dim alturaFinal As Integer = alturaOriginal
        panelc.Visible = True

        AddHandler timer.Tick,
        Sub(sender As Object, e As EventArgs)
            If panelc.Height < alturaFinal Then
                panelc.Height += incremento ' Mostrar
            Else
                timer.Stop()
            End If
        End Sub
        timer.Interval = 10 ' Ajusta el intervalo del temporizador
        timer.Start()

    End Sub
    Private Sub Ocultar(panelc As Panel)
        panelc.Height = 1
        panelc.Visible = False
    End Sub

    Public Sub conBtn()
        Controles(True, BtnPerfil, BtnArticuloUsu, BtnGraficoPro, BtnInsumosUsu, BtnGraficoInsu, BtnGanancias, BtnNotas, BtnInicio, BtnCerrar)
    End Sub


    ' Perfil : Botones
    Private Sub BtnPerfil_Click(sender As Object, e As EventArgs) Handles BtnPerfil.Click
        Label1.Text = "Perfil"
        Menuvertical()
        conBtn()
        Controles(False, BtnPerfil)
        PociBtns()
        AbrirFormPa(New AjusPerfil(IDUsuarioN, ModoOscuroUI))
    End Sub

    ' Produccion : Botones
    Private Sub BtnDespleArt_Click(sender As Object, e As EventArgs) Handles BtnDespleArt.Click
        PociBtns()
        BtnDespleIn.Location = New Point(0, 260)
        BtnGanancias.Location = New Point(0, 315)
        BtnNotas.Location = New Point(0, 370)
        If (PaMenuVertical.Width = 50) Then
            BtnCerrar.Text = "CERRAR SESIÓN"
            PaMenuVertical.Width = 160
        End If
        PaProduc.Location = New Point(20, 150)
        alturaOriginal = 95
        Mostrar(alturaOriginal, PaProduc)
    End Sub

    Public Sub BtnArticuloUsu_Click(sender As Object, e As EventArgs) Handles BtnArticuloUsu.Click
        Label1.Text = "Produccion - Prendas"
        Menuvertical()
        conBtn()
        Controles(False, BtnArticuloUsu)
        PociBtns()
        AbrirFormPa(New Articulos(IDUsuarioN, ModoOscuroUI))
    End Sub

    Private Sub BtnGraficoPro_Click(sender As Object, e As EventArgs) Handles BtnGraficoPro.Click
        BtnDespleArt.Location = New Point(0, 105)
        Label1.Text = "Produccion - Grafico de Produccion y Fallas"
        Menuvertical()
        conBtn()
        Controles(False, BtnGraficoPro)
        PociBtns()
        AbrirFormPa(New GraProducion(IDUsuarioN, ModoOscuroUI))
    End Sub

    ' Insumos : Botones
    Private Sub BtnDepleIn_Click(sender As Object, e As EventArgs) Handles BtnDespleIn.Click
        PociBtns()
        BtnGanancias.Location = New Point(0, 310)
        BtnNotas.Location = New Point(0, 365)
        If (PaMenuVertical.Width = 50) Then
            BtnCerrar.Text = "CERRAR SESIÓN"
            PaMenuVertical.Width = 160
        End If
        PaInsumos.Location = New Point(20, 210)
        alturaOriginal = 95
        Mostrar(alturaOriginal, PaInsumos)
    End Sub

    Private Sub BtnInsumosUsu_Click(sender As Object, e As EventArgs) Handles BtnInsumosUsu.Click
        Label1.Text = "Stock de Insumos"
        Menuvertical()
        conBtn()
        Controles(False, BtnInsumosUsu)
        PociBtns()
        AbrirFormPa(New StockInsumos(IDUsuarioN, ModoOscuroUI))
    End Sub

    Private Sub BtnGraficoInsu_Click(sender As Object, e As EventArgs) Handles BtnGraficoInsu.Click
        Label1.Text = "Movimientos de Stock"
        Menuvertical()
        conBtn()
        Controles(False, BtnGraficoInsu)
        PociBtns()
        AbrirFormPa(New MovimientosInsumos(IDUsuarioN, ModoOscuroUI))
    End Sub

    ' Ganacias : Botones
    Private Sub BtnGanancias_Click(sender As Object, e As EventArgs) Handles BtnGanancias.Click
        Label1.Text = "Grafico Ganancias"
        Menuvertical()
        conBtn()
        Controles(False, BtnGanancias)
        PociBtns()
        AbrirFormPa(New GGanancias(IDUsuarioN, ModoOscuroUI))
    End Sub

    Private Sub BtnNotas_Click(sender As Object, e As EventArgs) Handles BtnNotas.Click
        Label1.Text = "Mis Notas"
        Menuvertical()
        conBtn()
        Controles(False, BtnNotas)
        PociBtns()
        AbrirFormPa(New Boletas(IDUsuarioN, ModoOscuroUI))
    End Sub


    ' Detalle para Tema Claro o Oscuro
    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        'temas
        PbSol.Visible = True
        PbLuna.Visible = False
        'Menu vertical
        PbMenuOscu.Visible = True
        PbMenuClaro.Visible = False
        'Guardar app
        PbVentanaOscu.Visible = True
        PbVentanaClaro.Visible = False
        'ventana normal app
        'PbMinimizarOscu.Visible = True
        'PbMinimizarClaro.Visible = False
        'ventana completa app
        PbMaxiOscu.Visible = True
        PbMaxiClaro.Visible = False
        'Cerrar app
        PbCerrarOscu.Visible = True
        PbCerrarClaro.Visible = False
        'paneles:
        CambiarColorPanel(Color.FromArgb(30, 30, 30), PaBarra)
        CambiarColorPanel(Color.FromArgb(50, 50, 50), PaMenuVertical)
        'Botones:
        CambiarForeColor(Color.White, Label1, BtnPerfil, BtnDespleArt, BtnArticuloUsu, BtnGraficoPro, BtnDespleIn, BtnInsumosUsu, BtnGraficoInsu, BtnGanancias, BtnNotas, BtnInicio, BtnCerrar)

        'Botones con Imagenes o iconos
        BtnPerfil.Image = My.Resources.UsuarioOscu

        BtnDespleArt.Image = My.Resources.ProduccionOscu
        BtnArticuloUsu.Image = My.Resources.ProArticuOscu
        BtnGraficoPro.Image = My.Resources.GraficoProOscu

        BtnDespleIn.Image = My.Resources.InsumosOscu
        BtnInsumosUsu.Image = My.Resources.StockInsuOscu
        BtnGraficoInsu.Image = My.Resources.GraficoOscu

        BtnGanancias.Image = My.Resources.GananciaOscu

        BtnNotas.Image = My.Resources.NotaOscu

        BtnInicio.Image = My.Resources.HomeOscu

        BtnCerrar.Image = My.Resources.SalirOscu

    End Sub

    Public Sub Claro()
        'temas
        PbSol.Visible = False
        PbLuna.Visible = True
        'Menu vertical
        PbMenuOscu.Visible = False
        PbMenuClaro.Visible = True
        'Guardar app
        PbVentanaOscu.Visible = False
        PbVentanaClaro.Visible = True
        'ventana normal app
        'PbMinimizarOscu.Visible = False
        'PbMinimizarClaro.Visible = True
        'ventana completa app
        PbMaxiOscu.Visible = False
        PbMaxiClaro.Visible = True
        'Cerrar app
        PbCerrarOscu.Visible = False
        PbCerrarClaro.Visible = True
        'Paneles:
        CambiarColorPanel(Color.FromArgb(210, 210, 210), PaBarra)
        CambiarColorPanel(Color.White, PaMenuVertical)
        'Botones:
        CambiarForeColor(Color.Black, Label1, BtnPerfil, BtnDespleArt, BtnArticuloUsu, BtnGraficoPro, BtnDespleIn, BtnInsumosUsu, BtnGraficoInsu, BtnGanancias, BtnNotas, BtnInicio, BtnCerrar)

        'Botones con Imagenes o iconos
        BtnPerfil.Image = My.Resources.UsuarioClaro

        BtnDespleArt.Image = My.Resources.ProducionClaro
        BtnArticuloUsu.Image = My.Resources.ProArticuClaro
        BtnGraficoPro.Image = My.Resources.GraficoProClaro

        BtnDespleIn.Image = My.Resources.InsumosClaro
        BtnInsumosUsu.Image = My.Resources.StockInsuClaro
        BtnGraficoInsu.Image = My.Resources.GraficoClaro

        BtnGanancias.Image = My.Resources.GananciaClaro

        BtnNotas.Image = My.Resources.NotaClaro

        BtnInicio.Image = My.Resources.HomeClaro

        BtnCerrar.Image = My.Resources.SalirClaro

    End Sub

    ' Modo Oscuro o Claro
    Private Sub PbSol_Click(sender As Object, e As EventArgs) Handles PbSol.Click
        ModoOscuroUI = False
        ModoTema(False)
        Tema()
        ActuFormPa()
        ' si esta en ventana normal mostrar el boton maximo
        If Me.WindowState = FormWindowState.Normal Then
            PbMinimizarClaro.Visible = False
            PbMinimizarOscu.Visible = False
            PbMaxiOscu.Visible = False
            PbMaxiClaro.Visible = True
        ElseIf Me.WindowState = FormWindowState.Maximized Then ' Si está en ventana completa
            PbMinimizarClaro.Visible = True
            PbMinimizarOscu.Visible = False
            PbMaxiOscu.Visible = False
            PbMaxiClaro.Visible = False
        End If

    End Sub

    Private Sub PbLuna_Click(sender As Object, e As EventArgs) Handles PbLuna.Click
        ModoOscuroUI = True
        ModoTema(True)
        Tema()
        ActuFormPa()
        ' si esta en ventana normal mostrar el boton maximo
        If Me.WindowState = FormWindowState.Normal Then
            PbMinimizarClaro.Visible = False
            PbMinimizarOscu.Visible = False
            PbMaxiOscu.Visible = True
            PbMaxiClaro.Visible = False
        ElseIf Me.WindowState = FormWindowState.Maximized Then ' Si no está normal, mostrar botón minimizar
            PbMinimizarClaro.Visible = False
            PbMinimizarOscu.Visible = True
            PbMaxiOscu.Visible = False
            PbMaxiClaro.Visible = False
        End If
    End Sub

    Private FormularioActual As Form
    Private Sub ActuFormPa()
        If PaContenedor.Controls.Count > 0 Then
            ' Guarda el formulario actual en la variable FormularioActual
            FormularioActual = CType(PaContenedor.Controls(0), Form)
            ' Cierra el formulario actual
            FormularioActual.Close()
            ' Crea una nueva instancia del mismo tipo de formulario
            Dim NuevoFormulario As Form = Activator.CreateInstance(FormularioActual.GetType(), New Object() {IDUsuarioN, ModoOscuroUI})
            ' Configura el nuevo formulario
            NuevoFormulario.TopLevel = False
            NuevoFormulario.Dock = DockStyle.Fill
            ' Agrega el nuevo formulario al contenedor
            PaContenedor.Controls.Clear()
            PaContenedor.Controls.Add(NuevoFormulario)
            PaContenedor.Tag = NuevoFormulario
            ' Muestra el nuevo formulario
            NuevoFormulario.Show()
        End If

    End Sub
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Label1.Text = "Perfil"
        Menuvertical()
        conBtn()
        Controles(False, BtnInicio)
        PociBtns()
        AbrirFormPa(New inicio(IDUsuarioN, ModoOscuroUI))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Label1.Text = ""
        Menuvertical()
        conBtn()
        PociBtns()
        Dim inicioForm As New Login()
        inicioForm.Show()
        Me.Close()

    End Sub


    'a
End Class