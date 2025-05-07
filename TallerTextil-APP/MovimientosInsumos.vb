Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MovimientosInsumos
    Dim IdUsuarioN As Integer
    Dim ModoOscu As Boolean
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        IdUsuarioN = idUsuario
        ModoOscu = modoOscuro
        DtpAnio.Format = DateTimePickerFormat.Custom
        DtpAnio.CustomFormat = "yyyy"
        DtpAnio.ShowUpDown = True
    End Sub

    Private Sub MovimientosInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tema()
        UpdateControlPositions()
        MostrarInsEntrada(IdUsuarioN)
        MostrarInsSalida(IdUsuarioN)
        PaGrafEntSal.Visible = False
        Controles(False, TbDescrip)
        LoadChartGeneral()
    End Sub

    ' Tabla de Datos Entrada
    Public Sub MostrarInsEntrada(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdInsumoEnt, FechaInsEnt, IdUsuario, CodigoInsEnt, NombreInsEnt, CantInsEnt, PrecioUniInsEnt, CantInsEnt * PrecioUniInsEnt AS Total, IdInsumo FROM EntradaInsumos WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVEntrada.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar El Stock de Insumos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Tabla de Datos de Salida
    Public Sub MostrarInsSalida(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdInsumoSal, FechaInsSal, IdUsuario, CodigoInsSal, NombreInsSal, CantInsSal, PrecioUniInsSal, CantInsSal * PrecioUniInsSal AS Total, IdInsumo FROM SalidaInsumos WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVSalida.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar El Stock de Insumos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub CargarDatos(IdUsuario As Integer, CodigoStock As String)
        Try
            con.Open()
            Dim query As String = "SELECT CodigoStock, NombreStock, CantStock, PrecioUniStock, DescripStock, FechaStock FROM StockInsumos WHERE IdUsuario = @IdUsuario AND CodigoStock = @CodigoStock"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            cmd.Parameters.AddWithValue("@CodigoStock", CodigoStock)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim Codi As String = reader("CodigoStock").ToString()
                Dim Nom As String = reader("NombreStock").ToString()
                Dim Cant As String = reader("CantStock").ToString()
                Dim Pre As String = reader("PrecioUniStock").ToString()
                Dim Des As String = reader("DescripStock").ToString()
                Dim Fecha As Date = reader("FechaStock").ToString()
                Dim FechaSolo As String = Fecha.ToString("dd/MM/yyyy")
                LaCodi.Text = $"Codigo :    {Codi}"
                LaNombre.Text = $"nombre :    {Nom}"
                LaCant.Text = $"Cantidad :    {Cant}"
                LaPre.Text = $"Precio*Uni :    {Pre}"
                LaFecha.Text = $"Fecha :    {FechaSolo}"
                TbDescrip.Text = Des
                LaTotal.Visible = True
                LaTotal.Text = $"Total :     {Cant * Pre}$"

            Else
                LaCodi.Text = "Codigo :No Encontrado"
                LaNombre.Text = $"nombre :"
                LaCant.Text = $"Cantidad :"
                LaPre.Text = $"Precio*Uni :"
                LaFecha.Text = $"Fecha :"
                TbDescrip.Text = ""
                LaTotal.Visible = False
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos del insumo: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub TbBusCode_TextChanged(sender As Object, e As EventArgs) Handles TbBusCode.TextChanged
        Buscar()
        Dim texto As String = TbBusCode.Text.Trim()
        If texto <> "" Then
            PaGeneralGf.Visible = False
            PaGrafEntSal.Visible = True
            CargarDatos(IdUsuarioN, texto)
            LoadChartsEntradaSalida(texto)
            BtnGrafico.Text = "Grafico"
        Else
            PaGeneralGf.Visible = True
            PaGrafEntSal.Visible = False
            BtnGrafico.Text = "General"
        End If
    End Sub

    Private Function Buscar()
        Dim textoBusqueda As String = TbBusCode.Text.Trim()
        If textoBusqueda <> "" Then
            Dim query As String = "SELECT IdInsumoEnt, FechaInsEnt, IdUsuario, CodigoInsEnt, NombreInsEnt, CantInsEnt, PrecioUniInsEnt, CantInsEnt * PrecioUniInsEnt AS Total, IdInsumo FROM EntradaInsumos WHERE IdUsuario = @IdUsuario AND (CodigoInsEnt LIKE '%' + @TextoBusqueda)"
            Using con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda)
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DGVEntrada.DataSource = table
                End Using
            End Using
            Dim query2 As String = "SELECT IdInsumoSal, FechaInsSal, IdUsuario, CodigoInsSal, NombreInsSal, CantInsSal, PrecioUniInsSal, CantInsSal * PrecioUniInsSal AS Total, IdInsumo FROM SalidaInsumos WHERE IdUsuario = @IdUsuario AND (CodigoInsSal LIKE '%' + @TextoBusqueda)"
            Using con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
                Using cmd As New SqlCommand(query2, con)
                    cmd.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda)
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DGVSalida.DataSource = table
                End Using
            End Using
        Else
            MostrarInsEntrada(IdUsuarioN)
            MostrarInsSalida(IdUsuarioN)
        End If
    End Function

    ' Ajustamos las Pociciones dependiendo si Ventana Normal o Ventana Completa
    Public Sub UpdateControlPositions()
        If IsMaximized Then
            VentanaMaximizada1()
        Else
            VentanaNormal1()
        End If
    End Sub
    Private Sub VentanaNormal1()
        PaBusCodigo.Location = New Point(240, -5)
        PaBusCodigo.Size = New Size(460, 53)
        Label3.Text = "Digite Codigo:"
        Label3.Location = New Point(4, 9)
        TbBusCode.Location = New Point(205, 12)
        BtnGrafico.Location = New Point(321, 14)
        DtpAnio.Location = New Point(410, 15)


        PaDgvEntrada.Location = New Point(5, 35)
        PaDgvEntrada.Size = New Size(400, 200)

        PaDgvSalida.Location = New Point(480, 35)
        PaDgvSalida.Size = New Size(400, 200)

        PaGrafEntSal.Location = New Point(5, 240)
        PaGrafEntSal.Size = New Size(880, 220)
        Chart2.Size = New Size(320, 220)
        Chart3.Size = New Size(320, 220)
        'Datos
        TbDescrip.Size = New Size(238, 41)
        LaFecha.Location = New Point(3, 143)
        LaCant.Location = New Point(3, 161)
        LaPre.Location = New Point(3, 182)
        LaTotal.Location = New Point(131, 201)

        PaGeneralGf.Location = New Point(5, 240)
        PaGeneralGf.Size = New Size(880, 220)


    End Sub
    Private Sub VentanaMaximizada1()
        PaBusCodigo.Location = New Point(510, 50)
        PaBusCodigo.Size = New Size(126, 188)
        Label3.Text = "Digite" & vbCrLf & "Codigo"
        Label3.Location = New Point(13, 11)
        TbBusCode.Location = New Point(8, 83)
        BtnGrafico.Location = New Point(21, 115)
        DtpAnio.Location = New Point(37, 144)

        PaDgvEntrada.Location = New Point(5, 50)
        PaDgvEntrada.Size = New Size(500, 200)

        PaDgvSalida.Location = New Point(650, 50)
        PaDgvSalida.Size = New Size(500, 200)

        PaGrafEntSal.Location = New Point(5, 260)
        PaGrafEntSal.Size = New Size(1100, 306)
        Chart2.Size = New Size(440, 220)
        Chart3.Size = New Size(440, 220)
        'Datos
        TbDescrip.Size = New Size(186, 89)
        LaFecha.Location = New Point(5, 190)
        LaCant.Location = New Point(3, 215)
        LaPre.Location = New Point(3, 243)
        LaTotal.Location = New Point(83, 263)

        PaGeneralGf.Location = New Point(10, 260)
        PaGeneralGf.Size = New Size(1100, 306)
    End Sub

    ' Parte de Graficos
    Private Sub BtnGrafico_Click(sender As Object, e As EventArgs) Handles BtnGrafico.Click
        Buscar()
        Dim codigoInsumo As String = TbBusCode.Text.Trim()
        If codigoInsumo <> "" Then
            PaGeneralGf.Visible = False
            PaGrafEntSal.Visible = True
        Else
            PaGeneralGf.Visible = True
            PaGrafEntSal.Visible = False
        End If
    End Sub
    Private Sub LoadChartsEntradaSalida(codigoInsumo As String)
        LoadEntradaChart(codigoInsumo)
        LoadSalidaChart(codigoInsumo)
    End Sub

    'Grafico de Entradas
    Private Sub LoadEntradaChart(codigoInsumo As String)
        Chart2.Series.Clear()

        Dim series As New Series("Entradas")
        series.ChartType = SeriesChartType.Column
        series.Color = Color.Blue
        series.IsValueShownAsLabel = True

        Dim monthlyEntradas As New Dictionary(Of String, Integer)
        Dim Anio As Integer = DtpAnio.Value.Year

        Try
            con.Open()
            Dim queryEntrada As String = "SELECT MONTH(FechaInsEnt) AS Mes, SUM(CantInsEnt) AS TotalEntrada FROM EntradaInsumos WHERE IdUsuario = @IdUsuario AND CodigoInsEnt = @CodigoInsEnt AND YEAR(FechaInsEnt) = @Anio GROUP BY MONTH(FechaInsEnt)"
            Dim cmdEntrada As New SqlCommand(queryEntrada, con)
            cmdEntrada.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmdEntrada.Parameters.AddWithValue("@CodigoInsEnt", codigoInsumo)
            cmdEntrada.Parameters.AddWithValue("@Anio", Anio)
            Dim readerEntrada As SqlDataReader = cmdEntrada.ExecuteReader()
            While readerEntrada.Read()
                Dim month As Integer = readerEntrada("Mes")
                Dim totalEntrada As Integer = readerEntrada("TotalEntrada")
                monthlyEntradas(month.ToString()) = totalEntrada
            End While
            readerEntrada.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message)
        Finally
            con.Close()
        End Try

        For Each kvp As KeyValuePair(Of String, Integer) In monthlyEntradas.OrderBy(Function(k) k.Key)
            Dim monthName As String = GetNombreMes(kvp.Key)
            series.Points.AddXY(monthName, kvp.Value)
        Next

        series.Font = New Font("Arial", 10, FontStyle.Bold)
        series.IsValueShownAsLabel = True
        ColorDato(series)

        Chart2.Series.Add(series)
        Chart2.ChartAreas(0).AxisX.Title = "Mes"
        Chart2.ChartAreas(0).AxisY.Title = "Cantidad de Entradas"
        Chart2.ChartAreas(0).AxisX.Interval = 1
        Chart2.ChartAreas(0).AxisX.LabelStyle.Angle = -45 ' Grados de inclinacion

        Chart2.Titles.Clear()
        Chart2.Titles.Add($"Cantidad de Entradas de Insumos por Mes del Año {Anio}")
        colorT(Chart2)

    End Sub

    ' Grafico de Salidas
    Private Sub LoadSalidaChart(codigoInsumo As String)
        Chart3.Series.Clear()

        Dim series As New Series("Salidas")
        series.ChartType = SeriesChartType.Column
        series.Color = Color.Red
        series.IsValueShownAsLabel = True

        Dim monthlySalidas As New Dictionary(Of String, Integer)
        Dim Anio As Integer = DtpAnio.Value.Year

        Try
            con.Open()
            Dim querySalida As String = "SELECT MONTH(FechaInsSal) AS Mes, SUM(CantInsSal) AS TotalSalida FROM SalidaInsumos WHERE IdUsuario = @IdUsuario AND CodigoInsSal = @CodigoInsSal AND YEAR(FechaInsSal) = @Anio GROUP BY MONTH(FechaInsSal)"
            Dim cmdSalida As New SqlCommand(querySalida, con)
            cmdSalida.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmdSalida.Parameters.AddWithValue("@CodigoInsSal", codigoInsumo)
            cmdSalida.Parameters.AddWithValue("@Anio", Anio)

            Dim readerSalida As SqlDataReader = cmdSalida.ExecuteReader()
            While readerSalida.Read()
                Dim month As Integer = readerSalida("Mes")
                Dim totalSalida As Integer = readerSalida("TotalSalida")
                monthlySalidas(month.ToString()) = totalSalida
            End While
            readerSalida.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message)
        Finally
            con.Close()
        End Try

        For Each kvp As KeyValuePair(Of String, Integer) In monthlySalidas.OrderBy(Function(k) k.Key)
            Dim monthName As String = GetNombreMes(kvp.Key)
            series.Points.AddXY(monthName, kvp.Value)
        Next
        series.Font = New Font("Arial", 10, FontStyle.Bold)
        series.IsValueShownAsLabel = True
        ColorDato(series)

        Chart3.Series.Add(series)
        Chart3.ChartAreas(0).AxisX.Title = "Mes"
        Chart3.ChartAreas(0).AxisY.Title = "Cantidad de Salidas"
        Chart3.ChartAreas(0).AxisX.Interval = 1
        Chart3.ChartAreas(0).AxisX.LabelStyle.Angle = -45

        Chart3.Titles.Clear()
        Chart3.Titles.Add($"Cantidad de Salidas de Insumos por Mes del Año {Anio}")
        colorT(Chart3)

    End Sub

    ' Grafico General
    Private Sub LoadChartGeneral()
        Chart1.Series.Clear()

        Dim seriesEntradas As New Series("Entradas")
        seriesEntradas.ChartType = SeriesChartType.Column
        seriesEntradas.Color = Color.Blue
        seriesEntradas.IsValueShownAsLabel = True

        Dim seriesSalidas As New Series("Salidas")
        seriesSalidas.ChartType = SeriesChartType.Column
        seriesSalidas.Color = Color.Red
        seriesSalidas.IsValueShownAsLabel = True

        Dim monthlyData As New Dictionary(Of String, Tuple(Of Integer, Integer)) ' Mes -> (Entradas, Salidas)
        Dim Anio As Integer = DtpAnio.Value.Year

        Try
            con.Open()

            ' Obtener datos de entradas
            Dim queryEntrada As String = "SELECT MONTH(FechaInsEnt) AS Mes, SUM(CantInsEnt) AS TotalEntrada FROM EntradaInsumos WHERE IdUsuario = @IdUsuario AND YEAR(FechaInsEnt) = @Anio GROUP BY MONTH(FechaInsEnt)"
            Dim cmdEntrada As New SqlCommand(queryEntrada, con)
            cmdEntrada.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmdEntrada.Parameters.AddWithValue("@Anio", Anio)
            Dim readerEntrada As SqlDataReader = cmdEntrada.ExecuteReader()
            While readerEntrada.Read()
                Dim month As Integer = readerEntrada("Mes")
                Dim totalEntrada As Integer = readerEntrada("TotalEntrada")
                If Not monthlyData.ContainsKey(month.ToString()) Then
                    monthlyData(month.ToString()) = New Tuple(Of Integer, Integer)(totalEntrada, 0)
                Else
                    monthlyData(month.ToString()) = New Tuple(Of Integer, Integer)(totalEntrada, monthlyData(month.ToString()).Item2)
                End If
            End While
            readerEntrada.Close()

            ' Obtener datos de salidas
            Dim querySalida As String = "SELECT MONTH(FechaInsSal) AS Mes, SUM(CantInsSal) AS TotalSalida FROM SalidaInsumos WHERE IdUsuario = @IdUsuario AND YEAR(FechaInsSal) = @Anio GROUP BY MONTH(FechaInsSal)"
            Dim cmdSalida As New SqlCommand(querySalida, con)
            cmdSalida.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmdSalida.Parameters.AddWithValue("@Anio", Anio)
            Dim readerSalida As SqlDataReader = cmdSalida.ExecuteReader()
            While readerSalida.Read()
                Dim month As Integer = readerSalida("Mes")
                Dim totalSalida As Integer = readerSalida("TotalSalida")
                If Not monthlyData.ContainsKey(month.ToString()) Then
                    monthlyData(month.ToString()) = New Tuple(Of Integer, Integer)(0, totalSalida)
                Else
                    monthlyData(month.ToString()) = New Tuple(Of Integer, Integer)(monthlyData(month.ToString()).Item1, totalSalida)
                End If
            End While
            readerSalida.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message)
        Finally
            con.Close()
        End Try

        If monthlyData.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            seriesEntradas.Points.Add(point)
        Else
            For Each kvp As KeyValuePair(Of String, Tuple(Of Integer, Integer)) In monthlyData.OrderBy(Function(k) k.Key)
                Dim monthName As String = GetNombreMes(kvp.Key)
                seriesEntradas.Points.AddXY(monthName, kvp.Value.Item1)
                seriesSalidas.Points.AddXY(monthName, kvp.Value.Item2)
            Next
        End If

        seriesEntradas.Font = New Font("Arial", 10, FontStyle.Bold)
        seriesEntradas.IsValueShownAsLabel = True
        ColorDato(seriesEntradas)

        seriesSalidas.Font = New Font("Arial", 10, FontStyle.Bold)
        seriesSalidas.IsValueShownAsLabel = True
        ColorDato(seriesSalidas)

        Chart1.Series.Add(seriesEntradas)
        Chart1.Series.Add(seriesSalidas)

        Chart1.ChartAreas(0).AxisX.Title = "Mes"
        Chart1.ChartAreas(0).AxisY.Title = "Cantidad"
        Chart1.ChartAreas(0).AxisX.Interval = 1
        'Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -45 ' Grados de inclinacion

        Chart1.Titles.Clear()
        Chart1.Titles.Add($"Cantidad de Entradas y Salidas de Insumos del Año {Anio}")
        colorT(Chart1)

    End Sub

    Private Sub DtpAnio_ValueChanged(sender As Object, e As EventArgs) Handles DtpAnio.ValueChanged
        Dim texto As String = TbBusCode.Text
        CargarDatos(IdUsuarioN, texto)
        LoadChartsEntradaSalida(texto)
        LoadChartGeneral()
    End Sub

    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        Me.BackgroundImage = My.Resources.FondoGraClaro
        Me.BackgroundImageLayout = ImageLayout.Stretch
        CambiarColorFormulario(Color.FromArgb(50, 50, 50), Me)
        CambiarColoresFormu(Me, Color.White, Color.FromArgb(50, 50, 50))
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaBusCodigo)
        CambiarColorPanel(Color.FromArgb(100, Color.Black), PaDgvEntrada)
        CambiarColorPanel(Color.FromArgb(100, Color.Black), PaDgvSalida)
        CambiarColorPanel(Color.FromArgb(100, Color.Black), PaGeneralGf)
        CambiarColorPanel(Color.FromArgb(100, Color.Black), PaGrafEntSal)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), Panel1)

        ConfigurarDataG(DGVEntrada, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)
        ConfigurarDataG(DGVSalida, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)

        ConfigurarChart(Chart1, Color.White, Color.FromArgb(80, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart2, Color.White, Color.FromArgb(80, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart3, Color.White, Color.FromArgb(80, Color.Black), Color.DarkBlue)

        CambiarBackColor(Color.FromArgb(200, Color.Black), Label1, Label2)

    End Sub

    Public Sub Claro()
        Me.BackgroundImage = My.Resources.FondoGraOscu
        Me.BackgroundImageLayout = ImageLayout.Stretch
        CambiarColorFormulario(Color.White, Me)
        CambiarColoresFormu(Me, Color.Black, Color.White)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaBusCodigo)
        CambiarColorPanel(Color.FromArgb(100, Color.White), PaDgvEntrada)
        CambiarColorPanel(Color.FromArgb(100, Color.White), PaDgvSalida)
        CambiarColorPanel(Color.FromArgb(100, Color.White), PaGeneralGf)
        CambiarColorPanel(Color.FromArgb(100, Color.White), PaGrafEntSal)
        CambiarColorPanel(Color.FromArgb(170, Color.White), Panel1)

        ConfigurarDataG(DGVEntrada, Color.Black, Color.White, Color.Blue, Color.White, Color.White)
        ConfigurarDataG(DGVSalida, Color.Black, Color.White, Color.Blue, Color.White, Color.White)

        ConfigurarChart(Chart1, Color.Black, Color.FromArgb(80, Color.White), Color.Red)
        ConfigurarChart(Chart2, Color.Black, Color.FromArgb(80, Color.White), Color.Red)
        ConfigurarChart(Chart3, Color.Black, Color.FromArgb(80, Color.White), Color.Red)

        CambiarBackColor(Color.FromArgb(200, Color.White), Label1, Label2)


    End Sub
End Class