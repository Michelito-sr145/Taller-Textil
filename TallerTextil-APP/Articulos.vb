Imports System.IO
Imports System.Data.SqlClient
Public Class Articulos
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
    Dim IDUsuarioN As Integer
    Dim ModoOscuroAr As Boolean
    Dim tamanio As Boolean
    Dim alturaOriginal As Integer = 340

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlPositions()
        OcultarPanel()
        Controles(False, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
        MostrarArticulos(IDUsuarioN)
        Tema()
    End Sub
    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        tamanio = IsMaximized
        IDUsuarioN = idUsuario
        ModoOscuroAr = modoOscuro

    End Sub

    Public Sub MostrarArticulos(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdProArt, IdUsuario, FeRecibidoArt, FeEntregaArt, CodigoArt, ModeloArt, TalleArt, CantArt, PrecioUniArt, DescripArt, TemporadaArt, CantArt * PrecioUniArt AS Total FROM Articulos WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DaGrViArt.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar los artículos: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    'Mostrando y Ocultando La lista de los Articulos
    Private Sub MostrarDataGridView(alturaOriginal As Integer)
        Dim timer As New Timer()
        Dim incremento As Integer = 25 ' Velocidad de la animación
        Dim alturaFinal As Integer = alturaOriginal
        paDtGrViArt.Visible = True

        AddHandler timer.Tick,
        Sub(sender As Object, e As EventArgs)
            If paDtGrViArt.Height < alturaFinal Then
                paDtGrViArt.Height += incremento ' Mostrar
            Else
                timer.Stop()
            End If

        End Sub

        timer.Interval = 10 ' Ajusta el intervalo del temporizador
        timer.Start()

    End Sub
    Private Sub OcultarDataGridView()
        Dim timer As New Timer()
        Dim incremento As Integer = 25 ' Velocidad de la animación
        Dim alturaFinal As Integer = 0

        AddHandler timer.Tick,
        Sub(sender As Object, e As EventArgs)
            If paDtGrViArt.Height > 0 Then
                paDtGrViArt.Height -= incremento ' Ocultar
            Else
                paDtGrViArt.Visible = False
                timer.Stop()
            End If

        End Sub

        timer.Interval = 10 ' Ajusta el intervalo del temporizador
        timer.Start()
    End Sub

    Private Sub btnOcultarMostrar_Click(sender As Object, e As EventArgs) Handles btnOcuMosArt.Click
        Controles(False, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
        If paDtGrViArt.Visible Then
            OcultarDataGridView()
        Else
            MostrarDataGridView(alturaOriginal)
        End If

    End Sub

    'Mostrando y Ocultando Los Filtros
    Private Sub MostrarPanel(anchoOriginal As Integer)
        Dim timer As New Timer()
        Dim incremento As Integer = 25 ' Ajusta la velocidad de la animación
        Dim anchoFinal As Integer = anchoOriginal

        paFiltros.Visible = True

        AddHandler timer.Tick,
        Sub(sender As Object, e As EventArgs)
            If paFiltros.Width < anchoFinal Then
                paFiltros.Width += incremento ' Expandir
            Else
                timer.Stop() ' Detiene el temporizador cuando se alcanza el ancho original
            End If
        End Sub

        timer.Interval = 10 ' Ajusta el intervalo del temporizador
        timer.Start()

    End Sub
    Private Sub OcultarPanel()
        Dim timer As New Timer()
        Dim incremento As Integer = 25 ' Ajusta la velocidad de la animación
        Dim anchoFinal As Integer = 0

        AddHandler timer.Tick,
        Sub(sender As Object, e As EventArgs)
            If paFiltros.Width > 0 Then
                paFiltros.Width -= incremento ' Ajustar la posición hacia la izquierda
            Else
                paFiltros.Visible = False
                timer.Stop() ' Detiene el temporizador cuando el panel está completamente oculto
            End If
        End Sub

        timer.Interval = 10 ' Ajusta el intervalo del temporizador
        timer.Start()

    End Sub
    Private Sub btnMostrarOcultarFiltros_Click(sender As Object, e As EventArgs) Handles btnMosOcuFiltros.Click
        Dim anchoOriginal As Integer = 519
        If paFiltros.Visible Then
            OcultarPanel()
            TextAccion.Visible = True
        Else
            MostrarPanel(anchoOriginal)
            TextAccion.Visible = False
        End If

    End Sub

    'Check de Verano
    Private Sub PicBVerano_Click(sender As Object, e As EventArgs) Handles PicBVerano.Click
        SeleccionarPictureBox(PicBVerano, CBVerano)
        AplicarFiltros()
    End Sub
    Private Sub CBVerano_CheckedChanged(sender As Object, e As EventArgs) Handles CBVerano.CheckedChanged
        SeleccionarCheckBox(PicBVerano, CBVerano)
        AplicarFiltros()
    End Sub

    'Check de Primavera
    Private Sub PicBPrimavera_Click(sender As Object, e As EventArgs) Handles PicBPrimavera.Click
        SeleccionarPictureBox(PicBPrimavera, CBPrimavera)
        AplicarFiltros()
    End Sub
    Private Sub CBPrimavera_CheckedChanged(sender As Object, e As EventArgs) Handles CBPrimavera.CheckedChanged
        SeleccionarCheckBox(PicBPrimavera, CBPrimavera)
        AplicarFiltros()
    End Sub

    'Check de Otoño
    Private Sub PicBOtonio_Click(sender As Object, e As EventArgs) Handles PicBOtonio.Click
        SeleccionarPictureBox(PicBOtonio, CBOtonio)
        AplicarFiltros()
    End Sub
    Private Sub CBOtonio_CheckedChanged(sender As Object, e As EventArgs) Handles CBOtonio.CheckedChanged
        SeleccionarCheckBox(PicBOtonio, CBOtonio)
        AplicarFiltros()
    End Sub

    'Check de Invierno
    Private Sub PicBInvierno_Click(sender As Object, e As EventArgs) Handles PicBInvierno.Click
        SeleccionarPictureBox(PicBInvierno, CBInvierno)
        AplicarFiltros()
    End Sub
    Private Sub CBInvierno_CheckedChanged(sender As Object, e As EventArgs) Handles CBInvierno.CheckedChanged
        SeleccionarCheckBox(PicBInvierno, CBInvierno)
        AplicarFiltros()
    End Sub


    'Fucion de los CheckBox y PictureBox
    Private Sub SeleccionarPictureBox(pictureBox As PictureBox, checkBox As CheckBox)
        If pictureBox.BorderStyle = BorderStyle.FixedSingle Then
            pictureBox.BorderStyle = BorderStyle.None
            checkBox.Checked = False
        Else
            pictureBox.BorderStyle = BorderStyle.FixedSingle
            checkBox.Checked = True
        End If
    End Sub

    Private Sub SeleccionarCheckBox(pictureBox As PictureBox, checkBox As CheckBox)
        If checkBox.Checked Then
            pictureBox.BorderStyle = BorderStyle.FixedSingle
        Else
            pictureBox.BorderStyle = BorderStyle.None
        End If
    End Sub


    'Filtro de la Fechas Inicial a Final.
    Private Sub FFechaIn_ValueChanged(sender As Object, e As EventArgs) Handles FFechaIn.ValueChanged
        AplicarFiltros()
    End Sub

    Private Sub FFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles FFechaFin.ValueChanged
        AplicarFiltros()
    End Sub



    'Funcion para Filtrar a la fecha acual
    Private Sub btnFiltrarPorHoy_Click(sender As Object, e As EventArgs) Handles btnFiltrarPorHoy.Click
        Dim fechaActual As String = DateTime.Today.ToString("yyyy-MM-dd")
        FiltrarPorFechaActual(fechaActual)

    End Sub
    Private Sub FiltrarPorFechaActual(fechaActual As String)
        If DaGrViArt.DataSource Is Nothing Then
            Return
        End If

        Dim filtro As String = String.Format("(FeRecibidoArt = #{0}# OR FeEntregaArt = #{0}#)", fechaActual)
        DirectCast(DaGrViArt.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub


    'Filtros juntos
    Private Sub AplicarFiltros()
        ' Verificar si el DataSource del DataGridView está asignado
        If DaGrViArt.DataSource Is Nothing Then
            Return
        End If

        ' Obtener los valores seleccionados de los filtros de temporada
        Dim temporadasSeleccionadas As New List(Of String)
        For Each checkBox As CheckBox In paFiltros.Controls.OfType(Of CheckBox)()
            If checkBox.Checked AndAlso checkBox.Tag IsNot Nothing Then
                temporadasSeleccionadas.Add(checkBox.Tag.ToString())
            End If
        Next

        ' Construir filtro de temporadas
        Dim filtroTemporadas As String = ""
        If temporadasSeleccionadas.Count > 0 Then
            filtroTemporadas = String.Join(" OR ", temporadasSeleccionadas.Select(Function(temporada) $"TemporadaArt = '{temporada}'"))
        End If

        ' Valores seleccionados de los filtros de fecha
        Dim fechaInicio As String = FFechaIn.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = FFechaFin.Value.ToString("yyyy-MM-dd")

        ' Construir filtro de fechas
        Dim filtroFechas As String = ""
        If Not String.IsNullOrWhiteSpace(fechaInicio) AndAlso Not String.IsNullOrWhiteSpace(fechaFin) Then
            Dim filtroFecha As String = String.Format("((FeRecibidoArt >= #{0}# AND FeRecibidoArt <= #{1}#) OR (FeEntregaArt >= #{0}# AND FeEntregaArt <= #{1}#))", fechaInicio, fechaFin)
            filtroFechas &= filtroFecha
        End If

        ' Combino los filtros de temporadas y fechas si ambos están presentes
        Dim filtro As String = ""
        If Not String.IsNullOrWhiteSpace(filtroTemporadas) AndAlso Not String.IsNullOrWhiteSpace(filtroFechas) Then
            filtro = $"({filtroTemporadas}) AND ({filtroFechas})"
        ElseIf Not String.IsNullOrWhiteSpace(filtroTemporadas) Then
            filtro = filtroTemporadas
        ElseIf Not String.IsNullOrWhiteSpace(filtroFechas) Then
            filtro = filtroFechas
        End If

        ' Aplicar el filtro a los datos
        If Not String.IsNullOrWhiteSpace(filtro) Then
            DirectCast(DaGrViArt.DataSource, DataTable).DefaultView.RowFilter = filtro
        Else
            ' Si no hay filtros seleccionados, mostrar todos los datos
            DirectCast(DaGrViArt.DataSource, DataTable).DefaultView.RowFilter = ""
        End If

    End Sub


    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTemporadaArt.SelectedIndexChanged
        If CbTemporadaArt.SelectedItem IsNot Nothing Then
            Dim seleccion As String = CbTemporadaArt.SelectedItem.ToString()

            Select Case seleccion
                Case "Verano"

                Case "Otoño"

                Case "Invierno"

                Case "Primavera"

                Case Else

            End Select
        End If

    End Sub



    'Botones para Crear Nuevo Articulo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo1.Click
        btnNuevo1.Visible = False
        BtnFalla.Visible = False
        LimpiarControles()
        Controles(True, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
        DaGrViArt.Enabled = False
        TxTotal.Visible = False
        LaTotal.Visible = False
        paFiltros.Visible = False
        btnConfiModi.Visible = False
        btnEliminar1.Visible = False
        btnModificar1.Visible = False
        btnMosOcuFiltros.Visible = False
        PBuscarText.Visible = False
        btnSalirNuv.Visible = True
        PDatosInfo.Visible = True
        TextAccion.Visible = True
        TextAccion.Text = "Creando Un Nuevo Articulo"
        LaIDArt.Text = ""
        btnOcuMosArt.Visible = False
        btnGuardarArt.Visible = True
        If IsMaximized Then
            btnOcuMosArt.Visible = False
            MostrarDataGridView(alturaOriginal)
        Else
            OcultarDataGridView()
        End If
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles btnSalirNuv.Click
        btnNuevo1.Visible = True
        BtnFalla.Visible = True
        DaGrViArt.Enabled = True
        btnGuardarArt.Visible = False
        btnOcuMosArt.Visible = True
        paFiltros.Visible = True
        btnConfiModi.Visible = False
        btnEliminar1.Visible = True
        btnModificar1.Visible = True
        btnMosOcuFiltros.Visible = True
        PBuscarText.Visible = True
        btnSalirNuv.Visible = False
        PDatosInfo.Visible = False
        TextAccion.Visible = True
        TextAccion.Text = "Articulo"
        LimpiarControles()
        Controles(False, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
        MostrarArticulos(IDUsuarioN)
        MostrarDataGridView(alturaOriginal)
        If IsMaximized Then
            btnOcuMosArt.Visible = False
        Else
            btnOcuMosArt.Visible = True
        End If

    End Sub


    'Funcion Para Limpiar los TextBox
    Private Sub LimpiarControles()
        TbCodigoArt.Clear()
        TbModeloArt.Clear()
        TbTalleArt.Clear()
        TbCantArt.Clear()
        TbPrecioUniArt.Clear()
        TbDescripArt.Clear()
        CbTemporadaArt.SelectedIndex = -1
        DtpFeRecibidoArt.Value = DateTime.Now
        DtpFeEntregaArt.Value = DateTime.Now

    End Sub


    'Creando Nuevo Articulo
    Function GuardarArticulo(ByVal codigo As String, ByVal modelo As String, ByVal talle As String, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal descri As String, ByVal FeRecibido As Date, ByVal FeEntrega As Date, ByVal temporada As String, ByVal IDUsuario As Integer) As Boolean
        Try
            ' Validar campos obligatorios
            Dim query As String = "INSERT INTO Articulos (CodigoArt, ModeloArt, TalleArt, CantArt, PrecioUniArt, DescripArt, FeRecibidoArt, FeEntregaArt, TemporadaArt, IdUsuario) VALUES (@Codigo, @Modelo, @Talle, @Cantidad, @Precio, @Descripcion, @FechaRecibido, @FechaEntrega, @Temporada, @IDUsuario)"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                cmd As New SqlCommand(query, conn)

                conn.Open()
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Modelo", modelo)
                cmd.Parameters.AddWithValue("@Talle", talle)
                cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@Descripcion", descri)
                cmd.Parameters.AddWithValue("@FechaRecibido", FeRecibido)
                cmd.Parameters.AddWithValue("@FechaEntrega", FeEntrega)
                cmd.Parameters.AddWithValue("@Temporada", temporada)
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Artículo guardado exitosamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Controles(False, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
            btnNuevo1.Visible = True
            TextAccion.Text = "Articulo"
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar el artículo: " & ex.Message, "Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Using writer As New StreamWriter("error.log", True)
                writer.WriteLine("Error al guardar el artículo: " & ex.ToString())
            End Using

            Return False
        End Try
    End Function

    Private Sub ButtonGuardarArticulo_Click(sender As Object, e As EventArgs) Handles btnGuardarArt.Click
        Dim codigo As String = TbCodigoArt.Text
        Dim modelo As String = TbModeloArt.Text
        Dim talle As String = TbTalleArt.Text
        Dim cantidad As Integer
        Dim precio As Decimal
        Dim descri As String = TbDescripArt.Text
        Dim FeRecibido As Date = DtpFeRecibidoArt.Value
        Dim FeEntrega As Date = DtpFeEntregaArt.Value
        Dim temporada As String

        temporada = If(CbTemporadaArt.SelectedItem IsNot Nothing, CbTemporadaArt.SelectedItem.ToString(), "")

        If String.IsNullOrWhiteSpace(codigo) OrElse String.IsNullOrWhiteSpace(modelo) OrElse String.IsNullOrWhiteSpace(talle) Then
            MessageBox.Show("Por favor complete todos los campos obligatorios.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(TbCantArt.Text, cantidad) OrElse Not Decimal.TryParse(ConvertirPrecio(TbPrecioUniArt.Text), precio) Then
            MessageBox.Show("Por favor ingrese valores numéricos válidos para cantidad y precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If precio = 0 Then
            MessageBox.Show("Por favor ingrese valor en precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Guardar el artículo solo si la función de guardar devuelve true
        If GuardarArticulo(codigo, modelo, talle, cantidad, precio, descri, FeRecibido, FeEntrega, temporada, IDUsuarioN) Then
            MostrarArticulos(IDUsuarioN)
            If IsMaximized Then
                MostrarDataGridView(alturaOriginal)
            End If
            DaGrViArt.Enabled = True
            TextAccion.Visible = True
            TextAccion.Text = "Articulo"
            btnGuardarArt.Visible = False
            BtnFalla.Visible = True
            PDatosInfo.Visible = False
            LimpiarControles()
            Salir_Click(sender, e)
        End If

    End Sub


    'Botones de ModificarDatos
    Private Sub ButtonModificarArticulo_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        btnModificar1.Visible = False
        BtnFalla.Visible = False
        Controles(True, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
        TxTotal.Visible = False
        LaTotal.Visible = False
        btnSalirModi.Visible = True
        paFiltros.Visible = False
        btnConfiModi.Visible = True
        btnEliminar1.Visible = False
        btnGuardarArt.Visible = False
        btnNuevo1.Visible = False
        btnMosOcuFiltros.Visible = False
        PBuscarText.Visible = False
        btnSalirNuv.Visible = False
        PDatosInfo.Visible = True
        TextAccion.Visible = True
        btnOcuMosArt.Visible = False

        If IsMaximized Then
            TextAccion.Text = "Seleccione uno a Modificar"
            MostrarDataGridView(alturaOriginal)
        Else
            TextAccion.Text = "Modificando"
            OcultarDataGridView()
        End If

    End Sub

    Private Sub BtnSalirModi_Click(sender As Object, e As EventArgs) Handles btnSalirModi.Click
        LimpiarControles()
        Controles(False, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
        btnModificar1.Visible = True
        btnOcuMosArt.Visible = True
        btnSalirModi.Visible = False
        paFiltros.Visible = True
        btnConfiModi.Visible = False
        btnEliminar1.Visible = True
        btnGuardarArt.Visible = False
        btnNuevo1.Visible = True
        btnMosOcuFiltros.Visible = True
        PBuscarText.Visible = True
        btnSalirModi.Visible = False
        PDatosInfo.Visible = False
        BtnFalla.Visible = True
        TextAccion.Visible = True
        TextAccion.Text = "Articulo"
        MostrarArticulos(IDUsuarioN)
        If IsMaximized Then
            btnOcuMosArt.Visible = False
            MostrarDataGridView(alturaOriginal)
        Else
            MostrarDataGridView(alturaOriginal)
        End If

    End Sub


    'Modificando Datos Del Articulo
    Private Sub DaGrViArt_SelectionChanged(sender As Object, e As EventArgs) Handles DaGrViArt.SelectionChanged
        If DaGrViArt.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DaGrViArt.SelectedRows(0)
            Dim IdProArt As String = filaSeleccionada.Cells("IdProArt").Value.ToString()
            Dim codigo As String = filaSeleccionada.Cells("CodigoArt").Value.ToString()
            Dim modelo As String = filaSeleccionada.Cells("ModeloArt").Value.ToString()
            Dim talle As String = filaSeleccionada.Cells("TalleArt").Value.ToString()
            Dim cantidad As Integer = filaSeleccionada.Cells("CantArt").Value.ToString()
            Dim precio As Decimal = filaSeleccionada.Cells("PrecioUniArt").Value.ToString()
            Dim descripcion As String = filaSeleccionada.Cells("DescripArt").Value.ToString()
            Dim fechaRecibido As Date = filaSeleccionada.Cells("FeRecibidoArt").Value.ToString()
            Dim fechaEntrega As Date = filaSeleccionada.Cells("FeEntregaArt").Value.ToString()
            Dim temporada As String = filaSeleccionada.Cells("TemporadaArt").Value.ToString()
            Dim Total As String = cantidad * precio
            LaTotal.Visible = True
            TxTotal.Visible = True
            LaIDArt.Text = IdProArt
            TbCodigoArt.Text = codigo
            TbModeloArt.Text = modelo
            TbTalleArt.Text = talle
            TbCantArt.Text = cantidad
            TbPrecioUniArt.Text = precio
            TbDescripArt.Text = descripcion
            CbTemporadaArt.Text = temporada
            DtpFeRecibidoArt.Value = fechaRecibido
            DtpFeEntregaArt.Value = fechaEntrega

            TxTotal.Text = (Total) + "$"

            PDatosInfo.Visible = True
        End If
    End Sub

    Private Sub ModificarArticulo(IdProArt As Integer, codigo As String, modelo As String, talle As String, cantidad As Integer, precio As Decimal, descripcion As String, fechaRecibido As Date, fechaEntrega As Date, temporada As String, IDUsuario As Integer)
        Try
            Dim query As String = "UPDATE Articulos SET CodigoArt = @Codigo, ModeloArt = @Modelo, TalleArt = @Talle, CantArt = @Cantidad, PrecioUniArt = @Precio, DescripArt = @Descripcion, FeRecibidoArt = @FechaRecibido, FeEntregaArt = @FechaEntrega, TemporadaArt = @Temporada WHERE IdProArt = @IdProArt AND IdUsuario = @IdUsuario"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
              cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Modelo", modelo)
                cmd.Parameters.AddWithValue("@Talle", talle)
                cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@Descripcion", descripcion)
                cmd.Parameters.AddWithValue("@FechaRecibido", fechaRecibido)
                cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega)
                cmd.Parameters.AddWithValue("@Temporada", temporada)
                cmd.Parameters.AddWithValue("@IdProArt", IdProArt)
                cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Artículo modificado exitosamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnModificar1.Visible = True
            TextAccion.Visible = True
            TextAccion.Text = "Articulo"
            Controles(False, TbCantArt, TbCodigoArt, TbDescripArt, TbModeloArt, TbPrecioUniArt, TbTalleArt, CbTemporadaArt, DtpFeEntregaArt, DtpFeRecibidoArt)
            MostrarDataGridView(alturaOriginal)
        Catch ex As Exception
            MessageBox.Show("Error al modificar el artículo: " & ex.Message, "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtConModificacion_Click(sender As Object, e As EventArgs) Handles btnConfiModi.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas guardar los cambios?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim IdProArt As Integer = Convert.ToInt32(LaIDArt.Text)
            Dim codigo As String = TbCodigoArt.Text
            Dim modelo As String = TbModeloArt.Text
            Dim talle As String = TbTalleArt.Text
            Dim cantidad As Integer = Convert.ToInt32(TbCantArt.Text)
            Dim precio As Decimal = Convert.ToDecimal(TbPrecioUniArt.Text)
            Dim descripcion As String = TbDescripArt.Text
            Dim fechaRecibido As Date = DtpFeRecibidoArt.Value
            Dim fechaEntrega As Date = DtpFeEntregaArt.Value
            Dim temporada As String = CbTemporadaArt.SelectedItem.ToString()
            If Not Integer.TryParse(TbCantArt.Text, cantidad) OrElse Not Decimal.TryParse(ConvertirPrecio(TbPrecioUniArt.Text), precio) Then
                MessageBox.Show("Por favor ingrese valores numéricos válidos para cantidad y precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If precio = 0 Then
                MessageBox.Show("Por favor ingrese valor precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ModificarArticulo(IdProArt, codigo, modelo, talle, cantidad, precio, descripcion, fechaRecibido, fechaEntrega, temporada, IDUsuarioN)
            LimpiarControles()
            btnSalirModi.Visible = False
            paFiltros.Visible = True
            btnConfiModi.Visible = False
            btnEliminar1.Visible = True
            btnGuardarArt.Visible = False
            btnNuevo1.Visible = True
            btnMosOcuFiltros.Visible = True
            PBuscarText.Visible = True
            btnSalirModi.Visible = False
            PDatosInfo.Visible = False
            TextAccion.Visible = False
            BtnFalla.Visible = True
            MostrarArticulos(IDUsuarioN)
            If IsMaximized Then
                btnOcuMosArt.Visible = False
                MostrarDataGridView(alturaOriginal)
            Else
                btnOcuMosArt.Visible = True
            End If
        Else
            LimpiarControles()
            BtnFalla.Visible = True
            btnSalirModi.Visible = False
            paFiltros.Visible = True
            btnConfiModi.Visible = False
            btnEliminar1.Visible = True
            btnGuardarArt.Visible = True
            btnNuevo1.Visible = True
            btnMosOcuFiltros.Visible = True
            PBuscarText.Visible = True
            btnSalirModi.Visible = False
            PDatosInfo.Visible = False
            TextAccion.Visible = False
            MostrarArticulos(IDUsuarioN)
            If IsMaximized Then
                btnOcuMosArt.Visible = False
                MostrarDataGridView(alturaOriginal)
            Else
                btnOcuMosArt.Visible = True
            End If
        End If
    End Sub

    'Eliminando un Articulo
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        If DaGrViArt.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DaGrViArt.SelectedRows(0)
            Dim IdProArt As String = filaSeleccionada.Cells("IdProArt").Value.ToString()
            Dim codigo As String = filaSeleccionada.Cells("CodigoArt").Value.ToString()
            Dim modelo As String = filaSeleccionada.Cells("ModeloArt").Value.ToString()
            Dim descripcion As String = filaSeleccionada.Cells("DescripArt").Value.ToString()
            Dim fechaRecibido As Date = filaSeleccionada.Cells("FeRecibidoArt").Value.ToString()
            Dim fechaEntrega As Date = filaSeleccionada.Cells("FeEntregaArt").Value.ToString()

            Dim confirmacion As DialogResult = MessageBox.Show($"Desea eliminar este artículo: {codigo}" & vbCrLf & $"Modelo:{modelo}" & vbCrLf & $"Fechas:{fechaRecibido} - {fechaEntrega}" & vbCrLf & $"Descripción: {descripcion}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                Dim confirmacion2 As DialogResult = MessageBox.Show($"¿Eliminar {codigo}-{modelo}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmacion2 = DialogResult.Yes Then
                    Dim idArticulo As Integer = Convert.ToInt32(filaSeleccionada.Cells("IdProArt").Value)

                    EliminarArticulo(idArticulo)

                    MostrarArticulos(IDUsuarioN)
                    MostrarDataGridView(340)
                End If
            End If
        Else
            MessageBox.Show("Por favor, seleccione un artículo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub EliminarArticulo(idArticulo As Integer)
        Try
            Dim query As String = "DELETE FROM Articulos WHERE IdProArt = @IdProArt"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                  cmd As New SqlCommand(query, conn)
                conn.Open()

                cmd.Parameters.AddWithValue("@IdProArt", idArticulo)

                cmd.ExecuteNonQuery()

            End Using

            MessageBox.Show("Articulo Eliminado.", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el artículo: " & ex.Message, "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBusText_Click(sender As Object, e As EventArgs) Handles btnBusText.Click
        Dim textoBusqueda As String = TbBuscarNM.Text.Trim()

        If textoBusqueda <> "" Then
            Dim query As String = "SELECT IdProArt, IdUsuario, FeRecibidoArt, FeEntregaArt, CodigoArt, ModeloArt, TalleArt, CantArt, PrecioUniArt, DescripArt, TemporadaArt, CantArt * PrecioUniArt AS Total FROM Articulos WHERE IdUsuario = @IdUsuario AND (ModeloArt LIKE '%' + @TextoBusqueda + '%' OR CodigoArt LIKE '%' + @TextoBusqueda + '%')"

            Using con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda)
                    cmd.Parameters.AddWithValue("@IdUsuario", IDUsuarioN)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DaGrViArt.DataSource = table
                End Using
            End Using
        Else
            MostrarArticulos(IDUsuarioN)
        End If
    End Sub

    Private Sub BtnLimF_Click(sender As Object, e As EventArgs) Handles BtnLimF.Click
        MostrarArticulos(IDUsuarioN)
    End Sub

    Public Sub UpdateControlPositions()
        If IsMaximized Then
            ' Ajustar posiciones y tamaños de controles para ventana completa
            VentanaMaximizada1()
        Else
            ' Ajustar posiciones y tamaños de controles para ventana normal
            VentanaNormal1()
        End If
    End Sub

    ' Ajustes si esta en Ventana Normal
    Private Sub VentanaNormal1()
        Dim x As Integer = 10
        Dim y As Integer = 100
        'Tamaño y posicion del DataGridView Articulos
        paDtGrViArt.Width = 670
        paDtGrViArt.Height = alturaOriginal
        paDtGrViArt.Location = New Point(x, y)

        'Posicion de los Paneles
        PDatosInfo.Location = New Point(x, y)
        PDatosInfo.Size = New Size(660, 340)
        paFiltros.Location = New Point(108, 12)
        PBuscarText.Location = New Point(651, 10)

        ' Labels, Textox, Botones etc........ de Panel Datos
        LaIDArt.Location = New Point(5, 5)
        LaCodi.Location = New Point(40, 30)
        LaMode.Location = New Point(40, 80)
        LaTalle.Location = New Point(40, 130)
        LaTemp.Location = New Point(40, 180)
        LaDescrip.Location = New Point(40, 230)
        LaFeR.Location = New Point(325, 30)
        LaFeE.Location = New Point(480, 30)
        LaCant.Location = New Point(350, 105)
        LaPrec.Location = New Point(350, 155)
        LaTotal.Location = New Point(425, 195)
        TxTotal.Location = New Point(529, 195)
        TbCodigoArt.Location = New Point(160, 30)
        TbModeloArt.Location = New Point(160, 80)
        TbTalleArt.Location = New Point(160, 130)
        CbTemporadaArt.Location = New Point(160, 180)
        TbDescripArt.Location = New Point(160, 230)
        DtpFeEntregaArt.Location = New Point(484, 55)
        DtpFeRecibidoArt.Location = New Point(329, 55)
        TbCantArt.Location = New Point(505, 105)
        TbPrecioUniArt.Location = New Point(505, 155)
        btnGuardarArt.Location = New Point(535, 235)
        btnSalirNuv.Location = New Point(535, 280)
        btnConfiModi.Location = New Point(535, 235)
        btnSalirModi.Location = New Point(535, 280)

        'Posicion de los Botones
        btnOcuMosArt.Visible = True
        btnMosOcuFiltros.Location = New Point(12, 12)
        btnNuevo1.Location = New Point(710, 135)
        btnModificar1.Location = New Point(710, 235)
        btnEliminar1.Location = New Point(710, 335)
        BtnFalla.Location = New Point(710, 180)
        'Label
        TextAccion.Location = New Point(100, 19)

    End Sub

    ' Ajustes si esta en Ventana Completa
    Private Sub VentanaMaximizada1()
        btnOcuMosArt.Visible = False
        MostrarDataGridView(alturaOriginal)
        'Posicion del DataGridView de los Articulos 
        paDtGrViArt.Location = New Point(12, 105)
        paDtGrViArt.Height = alturaOriginal
        'Posicicion de Texto de Accion
        TextAccion.Location = New Point(110, 19)
        'Posicicion del Panel de datos del Articulo
        PDatosInfo.Location = New Point(711, 105)
        PDatosInfo.Size = New Size(522, 427)
        ' Labels, Textox, Botones etc........ de Panel Datos
        LaIDArt.Location = New Point(1, 1)
        LaCodi.Location = New Point(40, 30)
        LaMode.Location = New Point(40, 80)
        LaTalle.Location = New Point(40, 130)
        LaTemp.Location = New Point(40, 180)
        LaDescrip.Location = New Point(40, 230)
        LaCant.Location = New Point(40, 340)
        LaPrec.Location = New Point(40, 380)
        LaFeR.Location = New Point(310, 35)
        LaFeE.Location = New Point(310, 130)
        LaTotal.Location = New Point(250, 360)
        TxTotal.Location = New Point(325, 360)
        TbCodigoArt.Location = New Point(160, 30)
        TbModeloArt.Location = New Point(160, 80)
        TbTalleArt.Location = New Point(160, 130)
        CbTemporadaArt.Location = New Point(160, 180)
        TbDescripArt.Location = New Point(50, 250)
        DtpFeRecibidoArt.Location = New Point(315, 60)
        DtpFeEntregaArt.Location = New Point(315, 155)
        TbCantArt.Location = New Point(135, 340)
        TbPrecioUniArt.Location = New Point(135, 375)
        btnGuardarArt.Location = New Point(415, 250)
        btnSalirNuv.Location = New Point(415, 295)
        btnConfiModi.Location = New Point(415, 250)
        btnSalirModi.Location = New Point(415, 295)
        'Posicicion de los botones
        btnNuevo1.Location = New Point(90, 455)
        btnModificar1.Location = New Point(290, 455)
        btnEliminar1.Location = New Point(490, 455)
        BtnFalla.Location = New Point(196, 455)

    End Sub

    Private Sub BtnFalla_Click(sender As Object, e As EventArgs) Handles BtnFalla.Click
        If DaGrViArt.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DaGrViArt.SelectedRows(0)
            Dim IdProArt As String = filaSeleccionada.Cells("IdProArt").Value.ToString()
            Dim codigo As String = filaSeleccionada.Cells("CodigoArt").Value.ToString()
            Dim modelo As String = filaSeleccionada.Cells("ModeloArt").Value.ToString()
            Dim talle As String = filaSeleccionada.Cells("TalleArt").Value.ToString()
            Dim cantidad As Integer = filaSeleccionada.Cells("CantArt").Value.ToString()
            Dim precio As Decimal = filaSeleccionada.Cells("PrecioUniArt").Value.ToString()
            Dim descripcion As String = filaSeleccionada.Cells("DescripArt").Value.ToString()
            Dim fechaRecibido As Date = filaSeleccionada.Cells("FeRecibidoArt").Value.ToString()
            Dim fechaEntrega As Date = filaSeleccionada.Cells("FeEntregaArt").Value.ToString()
            Dim temporada As String = filaSeleccionada.Cells("TemporadaArt").Value.ToString()

            Try
                Dim inputResult As String = InputBox($"Articulo Seleccionado: {codigo}" & vbCrLf & $"Modelo:{modelo} - Talle:{talle}" & vbCrLf & $"Fechas:{fechaRecibido} - {fechaEntrega}" & vbCrLf & $"Descripción: {descripcion}" & vbCrLf & "" & vbCrLf & "Introduzca la cantidad de fallas:", "Verificación")
                If String.IsNullOrEmpty(inputResult) Then
                    Return
                Else
                    Dim CantFalla As Integer
                    If Integer.TryParse(inputResult, CantFalla) AndAlso CantFalla > 0 Then
                        Dim decripfalla As String = InputBox($"Descripcion De la falla: ", "Si desea deje en blanco; Puede modificarse luego:")
                        NewFalla(IdProArt, codigo, modelo, talle, cantidad, precio, descripcion, fechaRecibido, fechaEntrega, temporada, IDUsuarioN, CantFalla, decripfalla)
                        MostrarArticulos(IDUsuarioN)
                        MostrarDataGridView(340)
                    Else
                        MessageBox.Show("Por favor, ingrese un valor numérico mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Algo salió mal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub NewFalla(IdProArt As Integer, codigo As String, modelo As String, talle As String, cantidad As Integer, precio As Decimal, descripcion As String, fechaRecibido As Date, fechaEntrega As Date, temporada As String, IDUsuario As Integer, CantFalla As String, Decripfalla As String)
        Dim NuevaCant As Integer = cantidad - CantFalla
        Dim NuevaDescrip As String = $"{descripcion}" & vbCrLf & $"Tiene Falla :{Decripfalla}"
        Try
            Dim query As String = "UPDATE Articulos SET CodigoArt = @Codigo, ModeloArt = @Modelo, TalleArt = @Talle, CantArt = @Cantidad, PrecioUniArt = @Precio, DescripArt = @Descripcion, FeRecibidoArt = @FechaRecibido, FeEntregaArt = @FechaEntrega, TemporadaArt = @Temporada WHERE IdProArt = @IdProArt AND IdUsuario = @IdUsuario"
            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Modelo", modelo)
                cmd.Parameters.AddWithValue("@Talle", talle)
                cmd.Parameters.AddWithValue("@Cantidad", NuevaCant)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@Descripcion", NuevaDescrip)
                cmd.Parameters.AddWithValue("@FechaRecibido", fechaRecibido)
                cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega)
                cmd.Parameters.AddWithValue("@Temporada", temporada)
                cmd.Parameters.AddWithValue("@IdProArt", IdProArt)
                cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
                cmd.ExecuteNonQuery()
            End Using

            Dim query2 As String = "INSERT INTO Fallas (CodigoFalla, ModeloFalla, TalleFalla, CantFalla, PrecioUniFalla, DescripFalla, FeRecibidoFalla, FeEntregadoFalla, IdUsuario) VALUES (@Codigo, @Modelo, @Talle, @Cantidad, @Precio, @Descripcion, @FechaRecibido, @FechaEntrega, @IDUsuario)"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                cmd As New SqlCommand(query2, conn)

                conn.Open()
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Modelo", modelo)
                cmd.Parameters.AddWithValue("@Talle", talle)
                cmd.Parameters.AddWithValue("@Cantidad", CantFalla)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@Descripcion", NuevaDescrip)
                cmd.Parameters.AddWithValue("@FechaRecibido", fechaRecibido)
                cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega)
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario)

                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Asignado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Algo salio mal" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Diseño de Tema Claro y Oscuro
    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        Me.BackgroundImage = My.Resources.FondoPreClaro
        Me.BackgroundImageLayout = ImageLayout.Stretch
        ' Opacidad de los Paneles
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PDatosInfo)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), paFiltros)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PBuscarText)

        ' Cambiamos los colores en general de un formulario: (formulario, ForeColor, BackColor)
        CambiarColoresFormu(Me, Color.White, Color.FromArgb(30, 30, 30))
        TextAccion.BackColor = Color.FromArgb(170, Color.Black)

        ConfigurarDataG(DaGrViArt, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)
        btnNuevo1.Image = My.Resources.CrearOscu
        btnModificar1.Image = My.Resources.EditOscu
        btnEliminar1.Image = My.Resources.EliminarOscu
        BtnFalla.Image = My.Resources.FallaOscu
        btnBusText.Image = My.Resources.BuscarOscu

    End Sub

    Public Sub Claro()
        Me.BackgroundImage = My.Resources.FondoProOscu
        Me.BackgroundImageLayout = ImageLayout.Stretch

        CambiarColorPanel(Color.FromArgb(170, Color.White), PDatosInfo)
        CambiarColorPanel(Color.FromArgb(170, Color.White), paFiltros)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PBuscarText)

        ' Cambiamos los colores en general de un formulario: (formulario, ForeColor, BackColor)
        CambiarColoresFormu(Me, Color.Black, Color.White) ' Los controles "Boton, label,TextBox, ComboBox, DateTimePicker"
        TextAccion.BackColor = Color.FromArgb(170, Color.White)

        'ConfigurarDataGridView(DaGrViArt, Color.Black, Color.White, Color.Blue, Color.White, Color.White)
        ConfigurarDataG(DaGrViArt, Color.Black, Color.White, Color.Blue, Color.White, Color.White)

        btnNuevo1.Image = My.Resources.CrearClaro
        btnModificar1.Image = My.Resources.EditClaro
        btnEliminar1.Image = My.Resources.EliminarClaro
        BtnFalla.Image = My.Resources.FallaClaro
        btnBusText.Image = My.Resources.BuscarClaro

    End Sub


End Class