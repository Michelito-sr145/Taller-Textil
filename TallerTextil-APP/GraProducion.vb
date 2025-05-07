Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class GraProducion

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

    Private Sub GraProducion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlPositions()
        MostrarFallas(IdUsuarioN)
        MostrarProducion(IdUsuarioN)
        GraficoProduccionFalla(IdUsuarioN)
        Tema()
        PaGraIndi.Visible = False
    End Sub
    Public Sub MostrarProducion(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdProArt, IdUsuario, FeRecibidoArt, FeEntregaArt, CodigoArt, ModeloArt, TalleArt, CantArt, PrecioUniArt, DescripArt, TemporadaArt, CantArt * PrecioUniArt AS Total FROM Articulos WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVArt.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar los artículos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Function MostrarFallas(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdFalla, IdUsuario, CodigoFalla, FeRecibidoFalla, FeEntregadoFalla, ModeloFalla, TalleFalla, CantFalla, PrecioUniFalla, DescripFalla FROM Fallas WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVFallas.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar los artículos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Function

    Function Buscar()
        Dim textoBusqueda As String = TbBuscarNM.Text.Trim()
        If textoBusqueda <> "" Then
            Dim query As String = "SELECT IdProArt, IdUsuario, FeRecibidoArt, FeEntregaArt, CodigoArt, ModeloArt, TalleArt, CantArt, PrecioUniArt, DescripArt, TemporadaArt, CantArt * PrecioUniArt AS Total FROM Articulos WHERE IdUsuario = @IdUsuario AND (CodigoArt LIKE '%' + @TextoBusqueda + '%')" 'ModeloArt LIKE '%' + @TextoBusqueda + '%' OR 
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda)
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                DGVArt.DataSource = table
            End Using
            Dim query2 As String = "SELECT IdFalla, IdUsuario, CodigoFalla, FeRecibidoFalla, FeEntregadoFalla, ModeloFalla, TalleFalla, CantFalla, PrecioUniFalla, DescripFalla FROM Fallas WHERE IdUsuario = @IdUsuario AND (CodigoFalla LIKE '%' + @TextoBusqueda + '%')" 'ModeloArt LIKE '%' + @TextoBusqueda + '%' OR 
            Using cmd As New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda)
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                DGVFallas.DataSource = table
            End Using
        Else
            MostrarProducion(IdUsuarioN)
            MostrarFallas(IdUsuarioN)
        End If
    End Function
    Public Sub CargarDatos(IdUsuario As Integer, CodigoStock As String)
        Try
            con.Open()
            Dim query As String = "SELECT CodigoArt, ModeloArt, TalleArt, TemporadaArt FROM Articulos WHERE IdUsuario = @IdUsuario AND CodigoArt = @Codigo"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            cmd.Parameters.AddWithValue("@Codigo", CodigoStock)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim Codi As String = reader("CodigoArt").ToString()
                Dim Mode As String = reader("ModeloArt").ToString()
                Dim Talle As String = reader("TalleArt").ToString()
                Dim Temp As String = reader("TemporadaArt").ToString()
                LaCodiArt.Text = Codi
                LaModeArt.Text = Mode
                LaTalleArt.Text = Talle
                LaTempArt.Text = Temp

            Else
                LaCodiArt.Text = "No Encontrado"
                LaModeArt.Text = ""
                LaTalleArt.Text = ""
                LaTempArt.Text = ""
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos del insumo: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TbBuscarNM_TextChanged(sender As Object, e As EventArgs) Handles TbBuscarNM.TextChanged
        Buscar()
        Dim texto As String = TbBuscarNM.Text.Trim()
        If texto <> "" Then
            CargarDatos(IdUsuarioN, texto)
            PaGraGeneral.Visible = False
            PaGraIndi.Visible = True
            GraficoIndiPF(texto, texto)
        Else
            PaGraIndi.Visible = False
            PaGraGeneral.Visible = True
        End If
    End Sub

    Private Sub btnBusText_Click(sender As Object, e As EventArgs) Handles btnBusText.Click
        Buscar()
    End Sub

    ' HACEMOS LA PARTE GENERAL DE PRODUCCION Y FALLAR CON GRAFICO
    ' Parte de Funciones Totales por mes
    Private Function CalcularProduccionPorMes(ByVal IDUsuario As Integer, ByVal Anio As Integer) As Dictionary(Of Integer, Integer)
        Dim productionByMonth As New Dictionary(Of Integer, Integer)
        Try
            con.Open()
            Dim query As String = "SELECT MONTH(FeEntregaArt) AS Mes, SUM(CantArt) AS TotalProduccion FROM Articulos WHERE IdUsuario = @IdUsuario AND YEAR(FeEntregaArt) = @Anio GROUP BY MONTH(FeEntregaArt)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            cmd.Parameters.AddWithValue("@Anio", Anio)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim mes As Integer = reader("Mes")
                Dim totalProduccion As Integer = reader("TotalProduccion")
                productionByMonth(mes) = totalProduccion
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al calcular la producción: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return productionByMonth
    End Function

    Private Function CalcularFallasPorMes(ByVal IDUsuario As Integer, ByVal Anio As Integer) As Dictionary(Of Integer, Integer)
        Dim faultsByMonth As New Dictionary(Of Integer, Integer)
        Try
            con.Open()
            Dim query As String = "SELECT MONTH(FeEntregadoFalla) AS Mes, SUM(CantFalla) AS TotalFallas FROM Fallas WHERE IdUsuario = @IdUsuario AND YEAR(FeEntregadoFalla) = @Anio GROUP BY MONTH(FeEntregadoFalla)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            cmd.Parameters.AddWithValue("@Anio", Anio)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim mes As Integer = reader("Mes")
                Dim totalFallas As Integer = reader("TotalFallas")
                faultsByMonth(mes) = totalFallas
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al calcular las fallas: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return faultsByMonth
    End Function

    ' Mostrar Grafico
    Private Sub GraficoProduccionFalla(ByVal IDUsuario As Integer)
        ' Limpia las series existentes en el gráfico
        Chart1.Series.Clear()

        ' Serie para la producción de artículos
        Dim seriesProduccion As New Series("Producción")
        seriesProduccion.ChartType = SeriesChartType.Column
        seriesProduccion.Color = Color.Blue

        ' Serie para las fallas
        Dim seriesFallas As New Series("Fallas")
        seriesFallas.ChartType = SeriesChartType.Column
        seriesFallas.Color = Color.Red

        ' Obtener el año seleccionado del DateTimePicker
        Dim Anio As Integer = DtpAnio.Value.Year

        ' Obtener datos de producción y fallas por mes y año
        Dim produccionPorMes As Dictionary(Of Integer, Integer) = CalcularProduccionPorMes(IDUsuario, Anio)
        Dim fallasPorMes As Dictionary(Of Integer, Integer) = CalcularFallasPorMes(IDUsuario, Anio)

        ' Agregar datos al gráfico
        If produccionPorMes.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            seriesProduccion.Points.Add(point)
        Else
            For mes As Integer = 1 To 12
                Dim produccion As Integer = If(produccionPorMes.ContainsKey(mes), produccionPorMes(mes), 0)
                Dim fallas As Integer = If(fallasPorMes.ContainsKey(mes), fallasPorMes(mes), 0)

                seriesProduccion.Points.AddXY(GetNombreMes(mes), produccion)
                seriesFallas.Points.AddXY(GetNombreMes(mes), fallas)
            Next
        End If

        seriesProduccion.Font = New Font("Arial", 10, FontStyle.Bold)
        seriesProduccion.IsValueShownAsLabel = True
        ColorDato(seriesProduccion)

        seriesFallas.Font = New Font("Arial", 10, FontStyle.Bold)
        seriesFallas.IsValueShownAsLabel = True
        ColorDato(seriesFallas)


        ' Agregar las series al gráfico
        Chart1.Series.Add(seriesProduccion)
        Chart1.Series.Add(seriesFallas)

        ' Configurar el área del gráfico
        Chart1.ChartAreas(0).AxisX.Title = "Mes"
        Chart1.ChartAreas(0).AxisY.Title = "Cantidad"
        Chart1.ChartAreas(0).AxisX.Interval = 1

        ' Opcional: Títulos del gráfico
        Chart1.Titles.Clear()
        Chart1.Titles.Add($"Cantidad de Producción y Fallas del año {Anio}")

    End Sub

    ' Parte de Grafico individual
    Private Sub GraficoIndiPF(ByVal codigoArticulo As String, ByVal codigoFalla As String)
        Chart2.Series.Clear()

        Dim seriesArticulos As New Series("Artículos")
        seriesArticulos.ChartType = SeriesChartType.Column
        seriesArticulos.Color = Color.Blue
        seriesArticulos.IsValueShownAsLabel = True

        Dim seriesFallas As New Series("Fallas")
        seriesFallas.ChartType = SeriesChartType.Column
        seriesFallas.Color = Color.Red
        seriesFallas.IsValueShownAsLabel = True

        Dim Anio As Integer = DtpAnio.Value.Year
        Dim IdUsuario As Integer = IdUsuarioN

        Dim monthlyArticulos As New Dictionary(Of String, Integer)

        Dim monthlyFallas As New Dictionary(Of String, Integer)

        Try
            con.Open()
            Dim queryArticulos As String = "SELECT MONTH(FeEntregaArt) AS Mes, SUM(CantArt) AS TotalArticulos FROM Articulos WHERE IdUsuario = @IdUsuario AND CodigoArt = @CodigoArt AND YEAR(FeEntregaArt) = @Anio GROUP BY MONTH(FeEntregaArt)"
            Dim cmdArticulos As New SqlCommand(queryArticulos, con)
            cmdArticulos.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            cmdArticulos.Parameters.AddWithValue("@CodigoArt", codigoArticulo)
            cmdArticulos.Parameters.AddWithValue("@Anio", Anio)
            Dim readerArticulos As SqlDataReader = cmdArticulos.ExecuteReader()
            While readerArticulos.Read()
                Dim mes As Integer = readerArticulos("Mes")
                Dim totalArticulos As Integer = readerArticulos("TotalArticulos")
                monthlyArticulos(mes.ToString()) = totalArticulos
            End While
            readerArticulos.Close()

            Dim queryFallas As String = "SELECT MONTH(FeEntregadoFalla) AS Mes, SUM(CantFalla) AS TotalFallas FROM Fallas WHERE IdUsuario = @IdUsuario AND CodigoFalla = @CodigoFalla AND YEAR(FeEntregadoFalla) = @Anio GROUP BY MONTH(FeEntregadoFalla)"
            Dim cmdFallas As New SqlCommand(queryFallas, con)
            cmdFallas.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            cmdFallas.Parameters.AddWithValue("@CodigoFalla", codigoFalla)
            cmdFallas.Parameters.AddWithValue("@Anio", Anio)
            Dim readerFallas As SqlDataReader = cmdFallas.ExecuteReader()
            While readerFallas.Read()
                Dim mes As Integer = readerFallas("Mes")
                Dim totalFallas As Integer = readerFallas("TotalFallas")
                monthlyFallas(mes.ToString()) = totalFallas
            End While
            readerFallas.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message)
        Finally
            con.Close()
        End Try

        For Each kvp As KeyValuePair(Of String, Integer) In monthlyArticulos.OrderBy(Function(k) k.Key)
            seriesArticulos.Points.AddXY(GetNombreMes(Convert.ToInt32(kvp.Key)), kvp.Value)
        Next

        For Each kvp As KeyValuePair(Of String, Integer) In monthlyFallas.OrderBy(Function(k) k.Key)
            seriesFallas.Points.AddXY(GetNombreMes(Convert.ToInt32(kvp.Key)), kvp.Value)
        Next

        seriesArticulos.Font = New Font("Arial", 10, FontStyle.Bold)
        seriesArticulos.IsValueShownAsLabel = True
        ColorDato(seriesArticulos)

        seriesFallas.Font = New Font("Arial", 10, FontStyle.Bold)
        seriesFallas.IsValueShownAsLabel = True
        ColorDato(seriesFallas)

        Chart2.Series.Add(seriesArticulos)
        Chart2.Series.Add(seriesFallas)

        Chart2.ChartAreas(0).AxisX.Title = "Mes"
        Chart2.ChartAreas(0).AxisY.Title = "Cantidad"
        Chart2.ChartAreas(0).AxisX.Interval = 1
        Chart2.ChartAreas(0).AxisX.LabelStyle.Angle = -45 ' Opcional: para mejorar la legibilidad de las etiquetas

    End Sub

    Private Sub DtpAnio_ValueChanged(sender As Object, e As EventArgs) Handles DtpAnio.ValueChanged
        GraficoProduccionFalla(IdUsuarioN)
        Dim texto As String = TbBuscarNM.Text.Trim()
        GraficoIndiPF(texto, texto)
    End Sub

    Public Sub UpdateControlPositions()
        If IsMaximized Then
            VentanaMaximizada1()
        Else
            VentanaNormal1()
        End If
    End Sub
    Private Sub VentanaNormal1()
        paDtGrViArt.Size = New Size(473, 154)
        Panel1.Size = New Size(418, 154)
        PaGraGeneral.Size = New Size(898, 259)
        PaGraIndi.Size = New Size(898, 255)

        PBuscarText.Location = New Point(214, -3)
        paDtGrViArt.Location = New Point(12, 47)
        Panel1.Location = New Point(492, 47)
        PaGraGeneral.Location = New Point(12, 204)
        PaGraIndi.Location = New Point(12, 204)

    End Sub
    Private Sub VentanaMaximizada1()
        paDtGrViArt.Size = New Size(473, 258)
        Panel1.Size = New Size(418, 258)
        PaGraGeneral.Size = New Size(898, 295)
        PaGraIndi.Size = New Size(898, 295)

        PBuscarText.Location = New Point(214, -3)
        paDtGrViArt.Location = New Point(12, 47)
        Panel1.Location = New Point(492, 47)
        PaGraGeneral.Location = New Point(12, 318)
        PaGraIndi.Location = New Point(12, 318)

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
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PBuscarText)
        CambiarColorPanel(Color.FromArgb(10, Color.Black), Panel2)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaGraIndi)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaGraGeneral)

        ConfigurarDataG(DGVArt, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)
        ConfigurarDataG(DGVFallas, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)

        ConfigurarChart(Chart1, Color.White, Color.FromArgb(10, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart2, Color.White, Color.FromArgb(10, Color.Black), Color.DarkBlue)

    End Sub

    Public Sub Claro()
        Me.BackgroundImage = My.Resources.FondoGraOscu
        Me.BackgroundImageLayout = ImageLayout.Stretch
        CambiarColorFormulario(Color.White, Me)
        CambiarColoresFormu(Me, Color.Black, Color.White)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PBuscarText)
        CambiarColorPanel(Color.FromArgb(10, Color.White), Panel2)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaGraIndi)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaGraGeneral)

        ConfigurarDataG(DGVArt, Color.Black, Color.White, Color.Blue, Color.White, Color.White)
        ConfigurarDataG(DGVFallas, Color.Black, Color.White, Color.Blue, Color.White, Color.White)

        ConfigurarChart(Chart1, Color.Black, Color.FromArgb(10, Color.White), Color.Red)
        ConfigurarChart(Chart2, Color.Black, Color.FromArgb(10, Color.White), Color.Red)



    End Sub



End Class