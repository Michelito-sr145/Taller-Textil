Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting

Public Class GGanancias
    Dim IDUsuarioN As Integer
    Dim modoOscuroGraf As Boolean
    Dim ar As String
    Dim tamanio As Boolean
    Dim alturaOriginal As Integer = 340
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")

    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        IDUsuarioN = idUsuario
        modoOscuroGraf = modoOscuro
        tamanio = IsMaximized
        DtpAnio.Format = DateTimePickerFormat.Custom
        DtpAnio.CustomFormat = "yyyy"
        DtpAnio.ShowUpDown = True
        DtpCompa.Format = DateTimePickerFormat.Custom
        DtpCompa.CustomFormat = "yyyy"
        DtpCompa.ShowUpDown = True
    End Sub

    Private Sub GGanancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlPositions()
        Tema()
        BtnMensual.Enabled = False
        BtnOcul.Enabled = False
        PaBotones.Visible = True
        PaMensual.Visible = True
        PaSemestral.Visible = False
        PaAnual.Visible = False
        PaCompSemes.Visible = False
        PaCompAnual.Visible = False
        Panel1.Visible = False
        Dim anio As Integer = DtpAnio.Value.Year
        CalculoMensual(anio)
    End Sub

    Private Sub DtpAnio_ValueChanged(sender As Object, e As EventArgs) Handles DtpAnio.ValueChanged
        Dim anio As Integer = DtpAnio.Value.Year
        CalculoMensual(anio)
        CalculoSemanal(IDUsuarioN, anio)
        CalculoAnual(IDUsuarioN, anio)
        CalculoMesArtIns(anio)
    End Sub

    Private Sub BtnMensual_Click_1(sender As Object, e As EventArgs) Handles BtnMensual.Click
        Controles(True, BtnMensual, BtnSemestral, BtnAnual)
        Visibilidad(False, tbSeme1, tbSeme2, TextBox1, TextBox2)
        BtnMensual.Enabled = False
        Dim anio As Integer = DtpAnio.Value.Year
        PaMensual.Visible = True
        PaSemestral.Visible = False
        PaAnual.Visible = False
        PaCompSemes.Visible = False
        PaCompAnual.Visible = False
        Panel1.Visible = False
        CalculoMensual(anio)
    End Sub

    Private Sub BtnSemestral_Click_1(sender As Object, e As EventArgs) Handles BtnSemestral.Click
        cualpanel = 1
        Visibilidad(False, tbSeme1, tbSeme2, TextBox1, TextBox2)
        Visibilidad(True, tbSeme1, tbSeme2)
        Controles(True, BtnMensual, BtnSemestral, BtnAnual)
        BtnSemestral.Enabled = False
        PaMensual.Visible = False
        PaSemestral.Visible = True
        PaAnual.Visible = False
        PaCompAnual.Visible = False
        PaCompSemes.Visible = False
        PaSemestral.Size = New Size(800, 300)
        Panel1.Visible = True
        Dim anio As Integer = DtpAnio.Value.Year
        CalculoSemanal(IDUsuarioN, anio)
        CalculoMesArtIns(anio)

    End Sub

    Private Sub BtnAnual_Click_1(sender As Object, e As EventArgs) Handles BtnAnual.Click
        cualpanel = 2
        Visibilidad(False, tbSeme1, tbSeme2, TextBox1, TextBox2)
        Controles(True, BtnMensual, BtnSemestral, BtnAnual)
        BtnAnual.Enabled = False
        PaMensual.Visible = False
        PaSemestral.Visible = False
        PaAnual.Visible = True
        PaCompAnual.Visible = False
        PaCompSemes.Visible = False
        PaAnual.Size = New Size(800, 300)
        Panel1.Visible = True
        Dim anio As Integer = DtpAnio.Value.Year
        CalculoAnual(IDUsuarioN, anio)
    End Sub

    ' Grafico Mensual :
    Private Sub CalculoMensual(anio As Integer)
        Dim monthlyProfits As New Dictionary(Of String, (Decimal, Decimal, Decimal))
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, DATEPART(MONTH, A.FeEntregaArt) AS Month, SUM(A.CantArt * A.PrecioUniArt) - COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND DATEPART(MONTH, S.FechaInsSal) = DATEPART(MONTH, A.FeEntregaArt)), 0) AS Ganancias,SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos,COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND DATEPART(MONTH, S.FechaInsSal) = DATEPART(MONTH, A.FeEntregaArt)), 0) AS TotalInsumos FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Anio GROUP BY DATEPART(YEAR, A.FeEntregaArt), DATEPART(MONTH, A.FeEntregaArt) ORDER BY Year, Month"
        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", IDUsuarioN)
                command.Parameters.AddWithValue("@Anio", anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim month As Integer = reader.GetInt32(1)
                        Dim profit As Decimal = reader.GetDecimal(2)
                        Dim totalArticulos As Decimal = reader.GetDecimal(3)
                        Dim totalInsumos As Decimal = reader.GetDecimal(4)
                        monthlyProfits($"{year}-{month}") = (profit, totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using
        GraficoMensual(monthlyProfits, anio)
    End Sub

    Private Sub GraficoMensual(monthlyData As Dictionary(Of String, (Decimal, Decimal, Decimal)), anio As Integer)
        Chart1.Series.Clear()

        Dim profitSeries As New Series($"Ganancia Mensual {anio}")
        Dim totalArticulosSeries As New Series($"Total de Producción {anio}")
        Dim totalInsumosSeries As New Series($"Total de Gastos {anio}")

        profitSeries.ChartType = SeriesChartType.Column
        totalArticulosSeries.ChartType = SeriesChartType.Column
        totalInsumosSeries.ChartType = SeriesChartType.Column

        profitSeries.Color = Color.Green
        totalArticulosSeries.Color = Color.Blue
        totalInsumosSeries.Color = Color.Red

        If monthlyData.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            profitSeries.Points.Add(point)
        Else
            For Each key In monthlyData.Keys
                Dim yearMonth As String = key
                Dim data = monthlyData(key)
                Dim profit As Decimal = data.Item1
                Dim totalArticulos As Decimal = data.Item2
                Dim totalInsumos As Decimal = data.Item3

                Dim monthNumber As Integer = Convert.ToInt32(key.Split("-")(1))
                Dim monthName As String = GetNombreMes(monthNumber)

                Dim profitPoint As New DataPoint()
                profitPoint.AxisLabel = monthName
                profitPoint.SetValueY(profit)
                profitPoint.Label = profit.ToString()
                profitSeries.Points.Add(profitPoint)

                Dim articulosPoint As New DataPoint()
                articulosPoint.AxisLabel = monthName
                articulosPoint.SetValueY(totalArticulos)
                articulosPoint.Label = totalArticulos.ToString()
                totalArticulosSeries.Points.Add(articulosPoint)

                Dim insumosPoint As New DataPoint()
                insumosPoint.AxisLabel = monthName
                insumosPoint.SetValueY(totalInsumos)
                insumosPoint.Label = totalInsumos.ToString()
                totalInsumosSeries.Points.Add(insumosPoint)
            Next
        End If

        profitSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        profitSeries.IsValueShownAsLabel = True
        totalArticulosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalArticulosSeries.IsValueShownAsLabel = True
        totalInsumosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalInsumosSeries.IsValueShownAsLabel = True

        ColorDato(profitSeries)
        ColorDato(totalArticulosSeries)
        ColorDato(totalInsumosSeries)

        Chart1.Series.Add(profitSeries)
        Chart1.Series.Add(totalArticulosSeries)
        Chart1.Series.Add(totalInsumosSeries)

        Chart1.ChartAreas(0).AxisX.Title = "Meses"
        Chart1.ChartAreas(0).AxisY.Title = "Valor($)"
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -45

        ' Mostrar datos específicos en el Label
        If monthlyData.Count > 0 Then
            Dim datosText As New StringBuilder()
            For Each key In monthlyData.Keys
                Dim yearMonth As String = key
                Dim data = monthlyData(key)
                Dim profit As Decimal = data.Item1
                Dim totalArticulos As Decimal = data.Item2
                Dim totalInsumos As Decimal = data.Item3

                Dim monthNumber As Integer = Convert.ToInt32(key.Split("-")(1))
                Dim monthName As String = GetNombreMes(monthNumber).ToUpper()

                datosText.AppendLine($"{monthName}:   Ganancia: {profit}$")
                datosText.AppendLine($"Producción de Prenda: {totalArticulos}" & vbCrLf & $"Salida de Insumos: {totalInsumos}")
                datosText.AppendLine() ' Añadir una línea en blanco para separar los meses
            Next
            datosLabel.Text = datosText.ToString()
        Else
            datosLabel.Text = "Sin Datos"
        End If

    End Sub

    ' Grafico Semestral :
    Private Sub CalculoSemanal(idUsuario As Integer, Anio As Integer)
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1 AS Semester, SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos, COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND (DATEPART(MONTH, S.FechaInsSal) - 1) / 6 + 1 = (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1), 0) AS TotalInsumos,SUM(A.CantArt * A.PrecioUniArt) - COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND (DATEPART(MONTH, S.FechaInsSal) - 1) / 6 + 1 = (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1), 0) AS Ganancias FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Año GROUP BY DATEPART(YEAR, A.FeEntregaArt), (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1 ORDER BY Year, Semester"
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim semestralData As New Dictionary(Of String, (Decimal, Decimal, Decimal))()

        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", idUsuario)
                command.Parameters.AddWithValue("@Año", Anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim semester As Integer = reader.GetInt32(1)
                        Dim totalArticulos As Decimal = reader.GetDecimal(2)
                        Dim totalInsumos As Decimal = reader.GetDecimal(3)
                        Dim profit As Decimal = reader.GetDecimal(4)
                        semestralData($"{year}-Semestre {semester}") = (profit, totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using

        GraficoSemestral(semestralData, Anio)
    End Sub

    Private Sub GraficoSemestral(semestralData As Dictionary(Of String, (Decimal, Decimal, Decimal)), Anio As Integer)
        Chart2.Series.Clear()

        ' Crear y configurar las series
        Dim profitSeries As New Series($"Ganancia Semestral {Anio}")
        Dim totalArticulosSeries As New Series($"Total de Producción {Anio}")
        Dim totalInsumosSeries As New Series($"Total de Gastos {Anio}")

        profitSeries.ChartType = SeriesChartType.Column
        totalArticulosSeries.ChartType = SeriesChartType.Column
        totalInsumosSeries.ChartType = SeriesChartType.Column

        profitSeries.Color = Color.Green
        totalArticulosSeries.Color = Color.Blue
        totalInsumosSeries.Color = Color.Red

        ColorDato(profitSeries)
        ColorDato(totalArticulosSeries)
        ColorDato(totalInsumosSeries)

        ' Añadir los puntos a las series
        If semestralData.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            profitSeries.Points.Add(point)
        Else
            For Each key In semestralData.Keys
                Dim semesterName As String = key
                Dim data = semestralData(key)
                Dim profit As Decimal = data.Item1
                Dim totalArticulos As Decimal = data.Item2
                Dim totalInsumos As Decimal = data.Item3

                Dim profitPoint As New DataPoint()
                profitPoint.AxisLabel = semesterName
                profitPoint.SetValueY(profit)
                profitPoint.Label = String.Format($"{profit}$")
                profitSeries.Points.Add(profitPoint)

                Dim articulosPoint As New DataPoint()
                articulosPoint.AxisLabel = semesterName
                articulosPoint.SetValueY(totalArticulos)
                articulosPoint.Label = String.Format($"{totalArticulos}$")
                totalArticulosSeries.Points.Add(articulosPoint)

                Dim insumosPoint As New DataPoint()
                insumosPoint.AxisLabel = semesterName
                insumosPoint.SetValueY(totalInsumos)
                insumosPoint.Label = String.Format($"{totalInsumos}$")
                totalInsumosSeries.Points.Add(insumosPoint)
            Next
        End If
        ' Configuración de las series
        profitSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        profitSeries.IsValueShownAsLabel = True
        totalArticulosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalArticulosSeries.IsValueShownAsLabel = True
        totalInsumosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalInsumosSeries.IsValueShownAsLabel = True

        ' Agregar las series al gráfico
        Chart2.Series.Add(profitSeries)
        Chart2.Series.Add(totalArticulosSeries)
        Chart2.Series.Add(totalInsumosSeries)
        ' Configuración del área del gráfico
        Chart2.ChartAreas(0).AxisX.Title = "Semestre"
        Chart2.ChartAreas(0).AxisY.Title = "Valor($)"
        Chart2.ChartAreas(0).AxisX.Interval = 1
        Chart2.ChartAreas(0).AxisX.LabelStyle.Angle = 0

    End Sub


    ' Grafico Anual :
    Private Sub CalculoAnual(idUsuario As Integer, Anio As Integer)
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, SUM(A.CantArt * A.PrecioUniArt) - COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt)), 0) AS Ganancias, SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos, COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt)), 0) AS TotalInsumos FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Año GROUP BY DATEPART(YEAR, A.FeEntregaArt) ORDER BY Year"
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim annualData As New Dictionary(Of Integer, (Decimal, Decimal, Decimal))()

        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", idUsuario)
                command.Parameters.AddWithValue("@Año", Anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim profit As Decimal = reader.GetDecimal(1)
                        Dim totalArticulos As Decimal = reader.GetDecimal(2)
                        Dim totalInsumos As Decimal = reader.GetDecimal(3)
                        annualData(year) = (profit, totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using

        GraficoAnual(annualData, Anio)
    End Sub

    Private Sub GraficoAnual(annualData As Dictionary(Of Integer, (Decimal, Decimal, Decimal)), Anio As Integer)
        Chart3.Series.Clear()

        Dim profitSeries As New Series($"Ganancia Anual {Anio}")
        Dim totalArticulosSeries As New Series($"Total de Producción {Anio}")
        Dim totalInsumosSeries As New Series($"Total de Gastos {Anio}")

        profitSeries.ChartType = SeriesChartType.Column
        totalArticulosSeries.ChartType = SeriesChartType.Column
        totalInsumosSeries.ChartType = SeriesChartType.Column

        profitSeries.Color = Color.Green
        totalArticulosSeries.Color = Color.Blue
        totalInsumosSeries.Color = Color.Red
        If annualData.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            profitSeries.Points.Add(point)
        Else
            For Each key In annualData.Keys
                Dim year As Integer = key
                Dim data = annualData(key)
                Dim profit As Decimal = data.Item1
                Dim totalArticulos As Decimal = data.Item2
                Dim totalInsumos As Decimal = data.Item3

                Dim profitPoint As New DataPoint()
                profitPoint.AxisLabel = year.ToString()
                profitPoint.SetValueY(profit)
                profitPoint.Label = String.Format($"{profit}$")
                profitSeries.Points.Add(profitPoint)

                Dim articulosPoint As New DataPoint()
                articulosPoint.AxisLabel = year.ToString()
                articulosPoint.SetValueY(totalArticulos)
                articulosPoint.Label = String.Format($"{totalArticulos}$")
                totalArticulosSeries.Points.Add(articulosPoint)

                Dim insumosPoint As New DataPoint()
                insumosPoint.AxisLabel = year.ToString()
                insumosPoint.SetValueY(totalInsumos)
                insumosPoint.Label = String.Format($"{totalInsumos}$")
                totalInsumosSeries.Points.Add(insumosPoint)
            Next
        End If

        profitSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        profitSeries.IsValueShownAsLabel = True
        totalArticulosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalArticulosSeries.IsValueShownAsLabel = True
        totalInsumosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalInsumosSeries.IsValueShownAsLabel = True

        ColorDato(profitSeries)
        ColorDato(totalArticulosSeries)
        ColorDato(totalInsumosSeries)

        Chart3.Series.Add(profitSeries)
        Chart3.Series.Add(totalArticulosSeries)
        Chart3.Series.Add(totalInsumosSeries)
        Chart3.ChartAreas(0).AxisX.Title = "Año"
        Chart3.ChartAreas(0).AxisY.Title = "Valor ($)"
        Chart3.ChartAreas(0).AxisX.Interval = 1
        Chart3.ChartAreas(0).AxisX.LabelStyle.Angle = 0

    End Sub

    Private Sub DtpCompa_ValueChanged(sender As Object, e As EventArgs) Handles DtpCompa.ValueChanged
        Dim anio2 As Integer = DtpCompa.Value.Year
        CompaSemanal(IDUsuarioN, anio2)
        CompaAnual(IDUsuarioN, anio2)
        CalculoMesArtIns2(anio2)
    End Sub

    ' Comparador Grafico Semestral :
    Private Sub CompaSemanal(idUsuario As Integer, Anio As Integer)
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1 AS Semester, SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos, COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND (DATEPART(MONTH, S.FechaInsSal) - 1) / 6 + 1 = (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1), 0) AS TotalInsumos,SUM(A.CantArt * A.PrecioUniArt) - COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND (DATEPART(MONTH, S.FechaInsSal) - 1) / 6 + 1 = (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1), 0) AS Ganancias FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Año GROUP BY DATEPART(YEAR, A.FeEntregaArt), (DATEPART(MONTH, A.FeEntregaArt) - 1) / 6 + 1 ORDER BY Year, Semester"
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim semestralData As New Dictionary(Of String, (Decimal, Decimal, Decimal))()

        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", idUsuario)
                command.Parameters.AddWithValue("@Año", Anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim semester As Integer = reader.GetInt32(1)
                        Dim totalArticulos As Decimal = reader.GetDecimal(2)
                        Dim totalInsumos As Decimal = reader.GetDecimal(3)
                        Dim profit As Decimal = reader.GetDecimal(4)
                        semestralData($"{year}-Semestre {semester}") = (profit, totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using

        GraficoSemestral2(semestralData, Anio)
    End Sub

    Private Sub GraficoSemestral2(semestralData As Dictionary(Of String, (Decimal, Decimal, Decimal)), anio As Integer)
        Chart4.Series.Clear()

        ' Crear y configurar las series
        Dim profitSeries As New Series($"Ganancia Semestral {anio}")
        Dim totalArticulosSeries As New Series($"Total de Producción {anio}")
        Dim totalInsumosSeries As New Series($"Total de Gastos {anio}")

        profitSeries.ChartType = SeriesChartType.Column
        totalArticulosSeries.ChartType = SeriesChartType.Column
        totalInsumosSeries.ChartType = SeriesChartType.Column

        profitSeries.Color = Color.Green
        totalArticulosSeries.Color = Color.Blue
        totalInsumosSeries.Color = Color.Red

        ColorDato(profitSeries)
        ColorDato(totalArticulosSeries)
        ColorDato(totalInsumosSeries)

        ' Añadir los puntos a las series
        If semestralData.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            profitSeries.Points.Add(point)
        Else
            For Each key In semestralData.Keys
                Dim semesterName As String = key
                Dim data = semestralData(key)
                Dim profit As Decimal = data.Item1
                Dim totalArticulos As Decimal = data.Item2
                Dim totalInsumos As Decimal = data.Item3

                Dim profitPoint As New DataPoint()
                profitPoint.AxisLabel = semesterName
                profitPoint.SetValueY(profit)
                profitPoint.Label = String.Format($"{profit}$")
                profitSeries.Points.Add(profitPoint)

                Dim articulosPoint As New DataPoint()
                articulosPoint.AxisLabel = semesterName
                articulosPoint.SetValueY(totalArticulos)
                articulosPoint.Label = String.Format($"{totalArticulos}$")
                totalArticulosSeries.Points.Add(articulosPoint)

                Dim insumosPoint As New DataPoint()
                insumosPoint.AxisLabel = semesterName
                insumosPoint.SetValueY(totalInsumos)
                insumosPoint.Label = String.Format($"{totalInsumos}$")
                totalInsumosSeries.Points.Add(insumosPoint)
            Next
        End If
        ' Configuración de las series
        profitSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        profitSeries.IsValueShownAsLabel = True
        totalArticulosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalArticulosSeries.IsValueShownAsLabel = True
        totalInsumosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalInsumosSeries.IsValueShownAsLabel = True

        ' Agregar las series al gráfico
        Chart4.Series.Add(profitSeries)
        Chart4.Series.Add(totalArticulosSeries)
        Chart4.Series.Add(totalInsumosSeries)
        ' Configuración del área del gráfico
        Chart4.ChartAreas(0).AxisX.Title = "Semestres"
        Chart4.ChartAreas(0).AxisY.Title = "Valor($)"
        Chart4.ChartAreas(0).AxisX.Interval = 1
        Chart4.ChartAreas(0).AxisX.LabelStyle.Angle = 0
    End Sub

    ' Comparador de Grafico Anual :
    Private Sub CompaAnual(idUsuario As Integer, Anio As Integer)
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, SUM(A.CantArt * A.PrecioUniArt) - COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt)), 0) AS Ganancias, SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos, COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt)), 0) AS TotalInsumos FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Año GROUP BY DATEPART(YEAR, A.FeEntregaArt) ORDER BY Year"
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim annualData As New Dictionary(Of Integer, (Decimal, Decimal, Decimal))()

        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", idUsuario)
                command.Parameters.AddWithValue("@Año", Anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim profit As Decimal = reader.GetDecimal(1)
                        Dim totalArticulos As Decimal = reader.GetDecimal(2)
                        Dim totalInsumos As Decimal = reader.GetDecimal(3)
                        annualData(year) = (profit, totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using

        GraficoAnual2(annualData, Anio)
    End Sub

    Private Sub GraficoAnual2(annualData As Dictionary(Of Integer, (Decimal, Decimal, Decimal)), Anio As Integer)
        Chart5.Series.Clear()

        Dim profitSeries As New Series($"Ganancia Anual {Anio}")
        Dim totalArticulosSeries As New Series($"Total de Producción {Anio}")
        Dim totalInsumosSeries As New Series($"Total de Gastos {Anio}")

        profitSeries.ChartType = SeriesChartType.Column
        totalArticulosSeries.ChartType = SeriesChartType.Column
        totalInsumosSeries.ChartType = SeriesChartType.Column

        profitSeries.Color = Color.Green
        totalArticulosSeries.Color = Color.Blue
        totalInsumosSeries.Color = Color.Red
        If annualData.Count = 0 Then
            ' Añadir un punto indicando que no hay datos disponibles
            Dim point As New DataPoint()
            point.AxisLabel = "0"
            point.SetValueY(0)
            point.Label = "No hay datos"
            profitSeries.Points.Add(point)
        Else
            For Each key In annualData.Keys
                Dim year As Integer = key
                Dim data = annualData(key)
                Dim profit As Decimal = data.Item1
                Dim totalArticulos As Decimal = data.Item2
                Dim totalInsumos As Decimal = data.Item3

                Dim profitPoint As New DataPoint()
                profitPoint.AxisLabel = year.ToString()
                profitPoint.SetValueY(profit)
                profitPoint.Label = String.Format($"{profit}$")
                profitSeries.Points.Add(profitPoint)

                Dim articulosPoint As New DataPoint()
                articulosPoint.AxisLabel = year.ToString()
                articulosPoint.SetValueY(totalArticulos)
                articulosPoint.Label = String.Format($"{totalArticulos}$")
                totalArticulosSeries.Points.Add(articulosPoint)

                Dim insumosPoint As New DataPoint()
                insumosPoint.AxisLabel = year.ToString()
                insumosPoint.SetValueY(totalInsumos)
                insumosPoint.Label = String.Format($"{totalInsumos}$")
                totalInsumosSeries.Points.Add(insumosPoint)
            Next
        End If
        profitSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        profitSeries.IsValueShownAsLabel = True
        totalArticulosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalArticulosSeries.IsValueShownAsLabel = True
        totalInsumosSeries.Font = New Font("Arial", 10, FontStyle.Bold)
        totalInsumosSeries.IsValueShownAsLabel = True

        ColorDato(profitSeries)
        ColorDato(totalArticulosSeries)
        ColorDato(totalInsumosSeries)

        Chart5.Series.Add(profitSeries)
        Chart5.Series.Add(totalArticulosSeries)
        Chart5.Series.Add(totalInsumosSeries)
        Chart5.ChartAreas(0).AxisX.Title = "Año"
        Chart5.ChartAreas(0).AxisY.Title = "Valor ($)"
        Chart5.ChartAreas(0).AxisX.Interval = 1
        Chart5.ChartAreas(0).AxisX.LabelStyle.Angle = 0
    End Sub

    Dim cualpanel As Integer
    Private Sub BtnCompa_Click(sender As Object, e As EventArgs) Handles BtnCompa.Click
        BtnOcul.Enabled = True
        If cualpanel = 1 Then
            PaCompSemes.Visible = True
            Visibilidad(True, TextBox1, TextBox2)
            PaCompAnual.Visible = False
        ElseIf cualpanel = 2 Then
            PaCompAnual.Visible = True
            Visibilidad(False, TextBox1, TextBox2)
            PaCompSemes.Visible = False
        End If
        Dim anio2 As Integer = DtpAnio.Value.Year
        CompaSemanal(IDUsuarioN, anio2)
        CompaAnual(IDUsuarioN, anio2)
        CalculoMesArtIns2(anio2)

        If IsMaximized Then
            PaSemestral.Size = New Size(800, 300)
            PaAnual.Size = New Size(800, 300)
        Else
            PaSemestral.Size = New Size(450, 300)
            PaAnual.Size = New Size(450, 300)
        End If

    End Sub

    Private Sub BtnOcul_Click(sender As Object, e As EventArgs) Handles BtnOcul.Click
        BtnOcul.Enabled = False
        Visibilidad(False, TextBox1, TextBox2)
        If IsMaximized Then
            PaCompSemes.Visible = False
            PaCompAnual.Visible = False
        Else
            PaCompSemes.Visible = False
            PaCompAnual.Visible = False
            PaSemestral.Size = New Size(800, 300)
            PaAnual.Size = New Size(800, 300)
        End If
    End Sub

    Public Sub UpdateControlPositions()
        If IsMaximized Then
            VentanaMaximizada1()
        Else
            VentanaNormal1()
        End If
    End Sub

    Public Sub VentanaMaximizada1()
        PaMensual.Location = New Point(12, 49)
        PaMensual.Size = New Size(1100, 500)
        Chart1.Size = New Size(800, 500)
        PaSemestral.Location = New Point(12, 49)
        PaSemestral.Size = New Size(800, 300)
        PaAnual.Location = New Point(12, 49)
        PaAnual.Size = New Size(800, 300)
        'Comparacion
        PaCompSemes.Location = New Point(12, 400)
        PaCompSemes.Size = New Size(800, 300)
        PaCompAnual.Location = New Point(12, 400)
        PaCompAnual.Size = New Size(800, 300)

        tbSeme1.Location = New Point(816, 49)
        tbSeme1.Size = New Size(190, 300)
        tbSeme2.Location = New Point(1012, 49)
        tbSeme2.Size = New Size(190, 300)

        TextBox1.Location = New Point(816, 381)
        TextBox1.Size = New Size(190, 300)
        TextBox2.Location = New Point(1012, 381)
        TextBox2.Size = New Size(190, 300)

    End Sub
    Public Sub VentanaNormal1()
        PaMensual.Location = New Point(-15, 49)
        PaMensual.Size = New Size(950, 425)
        Chart1.Size = New Size(696, 425)
        PaSemestral.Location = New Point(12, 49)
        PaSemestral.Size = New Size(450, 300)
        PaAnual.Location = New Point(12, 49)
        PaAnual.Size = New Size(450, 300)
        'Comparacion
        PaCompSemes.Location = New Point(480, 49)
        PaCompSemes.Size = New Size(450, 300)
        PaCompAnual.Location = New Point(480, 49)
        PaCompAnual.Size = New Size(450, 300)

        tbSeme1.Location = New Point(12, 355)
        tbSeme1.Size = New Size(190, 100)
        tbSeme2.Location = New Point(220, 355)
        tbSeme2.Size = New Size(190, 100)

        TextBox1.Location = New Point(480, 355)
        TextBox1.Size = New Size(190, 100)
        TextBox2.Location = New Point(688, 355)
        TextBox2.Size = New Size(190, 100)

    End Sub

    ' Diseño Color
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
        ' Panel
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaBotones)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), Panel1)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaMensual)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaSemestral)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaAnual)
        CambiarColorPanel(Color.FromArgb(100, Color.Violet), PaCompSemes)
        CambiarColorPanel(Color.FromArgb(100, Color.Violet), PaCompAnual)
        CambiarBackColor(Color.Purple, TextBox1, TextBox2)

        ' Graficos
        ConfigurarChart(Chart1, Color.White, Color.FromArgb(140, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart2, Color.White, Color.FromArgb(140, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart3, Color.White, Color.FromArgb(140, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart4, Color.White, Color.FromArgb(140, Color.Black), Color.DarkBlue)
        ConfigurarChart(Chart5, Color.White, Color.FromArgb(140, Color.Black), Color.DarkBlue)


    End Sub

    Public Sub Claro()
        Me.BackgroundImage = My.Resources.FondoGraOscu
        Me.BackgroundImageLayout = ImageLayout.Stretch
        CambiarColorFormulario(Color.White, Me)
        CambiarColoresFormu(Me, Color.Black, Color.White)
        ' Panel
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaBotones)
        CambiarColorPanel(Color.FromArgb(170, Color.White), Panel1)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaMensual)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaSemestral)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaAnual)
        CambiarColorPanel(Color.FromArgb(100, Color.Violet), PaCompSemes)
        CambiarColorPanel(Color.FromArgb(100, Color.Violet), PaCompAnual)
        CambiarBackColor(Color.Violet, TextBox1, TextBox2)
        ' Graficos
        ConfigurarChart(Chart1, Color.Black, Color.FromArgb(80, Color.White), Color.Red)
        ConfigurarChart(Chart2, Color.Black, Color.FromArgb(80, Color.White), Color.Red)
        ConfigurarChart(Chart3, Color.Black, Color.FromArgb(80, Color.White), Color.Red)
        ConfigurarChart(Chart4, Color.Black, Color.FromArgb(80, Color.White), Color.Red)
        ConfigurarChart(Chart5, Color.Black, Color.FromArgb(80, Color.White), Color.Red)

    End Sub

    Private Sub CalculoMesArtIns(anio As Integer)
        Dim monthlyData As New Dictionary(Of String, (Decimal, Decimal))
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, DATEPART(MONTH, A.FeEntregaArt) AS Month, SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos, COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND DATEPART(MONTH, S.FechaInsSal) = DATEPART(MONTH, A.FeEntregaArt)), 0) AS TotalInsumos FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Anio GROUP BY DATEPART(YEAR, A.FeEntregaArt), DATEPART(MONTH, A.FeEntregaArt) ORDER BY Year, Month"
        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", IDUsuarioN)
                command.Parameters.AddWithValue("@Anio", anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim month As Integer = reader.GetInt32(1)
                        Dim totalArticulos As Decimal = reader.GetDecimal(2)
                        Dim totalInsumos As Decimal = reader.GetDecimal(3)
                        monthlyData($"{year}-{month}") = (totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using
        DatosTbSemestrales(monthlyData, anio)
    End Sub

    Private Sub DatosTbSemestrales(monthlyData As Dictionary(Of String, (Decimal, Decimal)), anio As Integer)
        tbSeme1.Clear()
        tbSeme2.Clear()
        Dim total1 As Decimal = 0
        Dim total2 As Decimal = 0

        Dim mesesSemestre1 As New List(Of String) From {"1", "2", "3", "4", "5", "6"}
        Dim mesesSemestre2 As New List(Of String) From {"7", "8", "9", "10", "11", "12"}

        Dim tbSeme1Content As New StringBuilder()
        Dim tbSeme2Content As New StringBuilder()

        For Each key In monthlyData.Keys
            Dim parts As String() = key.Split("-"c)
            Dim year As Integer = Integer.Parse(parts(0))
            Dim month As Integer = Integer.Parse(parts(1))
            Dim data = monthlyData(key)
            Dim totalArticulos As Decimal = data.Item1
            Dim totalInsumos As Decimal = data.Item2

            Dim monthNameString As String = GetNombreMes(month)

            ' Si el nombre del mes es "Mes inválido", mostramos un mensaje de error
            If monthNameString = "Mes inválido" Then
                MessageBox.Show($"Error al obtener el nombre del mes para el valor {month}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Continue For
            End If

            Dim textLine As String = $"{monthNameString.ToUpper}:" & vbCrLf & $" Producción: {totalArticulos}$" & vbCrLf & $" Gastos: {totalInsumos}$" & vbCrLf & ""

            If mesesSemestre1.Contains(month.ToString()) Then
                total1 = total1 + (totalArticulos - totalInsumos)
                tbSeme1Content.Append(textLine)
            ElseIf mesesSemestre2.Contains(month.ToString()) Then
                total2 = total2 + (totalArticulos - totalInsumos)
                tbSeme2Content.Append(textLine)
            End If
        Next

        tbSeme1.Text = $"Semestre 1:{total1}$" & vbCrLf & "" + tbSeme1Content.ToString()
        tbSeme2.Text = $"Semestre 2:{total2}$" & vbCrLf & "" + tbSeme2Content.ToString()

    End Sub

    Private Sub CalculoMesArtIns2(anio As Integer)
        Dim monthlyData As New Dictionary(Of String, (Decimal, Decimal))
        Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
        Dim query As String = "SELECT DATEPART(YEAR, A.FeEntregaArt) AS Year, DATEPART(MONTH, A.FeEntregaArt) AS Month, SUM(A.CantArt * A.PrecioUniArt) AS TotalArticulos, COALESCE((SELECT SUM(S.CantInsSal * S.PrecioUniInsSal) FROM SalidaInsumos S WHERE S.IdUsuario = @IdUsuario AND DATEPART(YEAR, S.FechaInsSal) = DATEPART(YEAR, A.FeEntregaArt) AND DATEPART(MONTH, S.FechaInsSal) = DATEPART(MONTH, A.FeEntregaArt)), 0) AS TotalInsumos FROM Articulos A WHERE A.IdUsuario = @IdUsuario AND DATEPART(YEAR, A.FeEntregaArt) = @Anio GROUP BY DATEPART(YEAR, A.FeEntregaArt), DATEPART(MONTH, A.FeEntregaArt) ORDER BY Year, Month"
        Using con
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@IdUsuario", IDUsuarioN)
                command.Parameters.AddWithValue("@Anio", anio)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32(0)
                        Dim month As Integer = reader.GetInt32(1)
                        Dim totalArticulos As Decimal = reader.GetDecimal(2)
                        Dim totalInsumos As Decimal = reader.GetDecimal(3)
                        monthlyData($"{year}-{month}") = (totalArticulos, totalInsumos)
                    End While
                End Using
            End Using
        End Using
        CDatosTbSemestrales(monthlyData, anio)
    End Sub

    Private Sub CDatosTbSemestrales(monthlyData As Dictionary(Of String, (Decimal, Decimal)), anio As Integer)
        TextBox1.Clear()
        TextBox2.Clear()
        Dim total1 As Decimal = 0
        Dim total2 As Decimal = 0

        Dim mesesSemestre1 As New List(Of String) From {"1", "2", "3", "4", "5", "6"}
        Dim mesesSemestre2 As New List(Of String) From {"7", "8", "9", "10", "11", "12"}

        Dim tbSeme1Content As New StringBuilder()
        Dim tbSeme2Content As New StringBuilder()

        For Each key In monthlyData.Keys
            Dim parts As String() = key.Split("-"c)
            Dim year As Integer = Integer.Parse(parts(0))
            Dim month As Integer = Integer.Parse(parts(1))
            Dim data = monthlyData(key)
            Dim totalArticulos As Decimal = data.Item1
            Dim totalInsumos As Decimal = data.Item2

            Dim monthNameString As String = GetNombreMes(month)

            ' Si el nombre del mes es "Mes inválido", mostramos un mensaje de error
            If monthNameString = "Mes inválido" Then
                MessageBox.Show($"Error al obtener el nombre del mes para el valor {month}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Continue For
            End If

            Dim textLine As String = $"{monthNameString.ToUpper}:" & vbCrLf & $" Producción: {totalArticulos}$" & vbCrLf & $" Gastos: {totalInsumos}$" & vbCrLf & ""
            If mesesSemestre1.Contains(month.ToString()) Then
                total1 = total1 + (totalArticulos - totalInsumos)
                tbSeme1Content.Append(textLine)
            ElseIf mesesSemestre2.Contains(month.ToString()) Then
                total2 = total2 + (totalArticulos - totalInsumos)
                tbSeme2Content.Append(textLine)
            End If
        Next

        TextBox1.Text = $"Semestre 1:{total1}$" & vbCrLf & "" + tbSeme1Content.ToString()
        TextBox2.Text = $"Semestre 2:{total2}$" & vbCrLf & "" + tbSeme2Content.ToString()
    End Sub


End Class