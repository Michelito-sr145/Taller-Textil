Imports System.Data.SqlClient
Imports System.IO
Public Class inicio
    Dim IdUsuarioN As Integer
    Dim ModoOscu As Boolean
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlPositions()
        MostrarStock(IdUsuarioN)
        VerificarStock()
        Controles(False, TbTitulo, DtpFecha)
        MostrarNotas(IdUsuarioN)
        Tema()
    End Sub

    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        IdUsuarioN = idUsuario
        ModoOscu = modoOscuro
    End Sub

    Public Sub MostrarStock(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdInsumoStock, IdUsuario, FechaStock, CodigoStock, NombreStock, CantStock, PrecioUniStock, DescripStock, CantStock * PrecioUniStock AS Total FROM StockInsumos WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVStock.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar El Stock de Insumos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Campo de Alerta de Poco Stock
    Private Sub VerificarStock()
        Dim alertasRoja As Integer = 0
        Dim alertasNara As Integer = 0
        Dim alertasAmari As Integer = 0
        Dim alerOk As Integer = 0

        For Each row As DataGridViewRow In DGVStock.Rows
            If row.Cells("CantStock").Value IsNot Nothing Then
                Dim stock As Integer = Convert.ToInt32(row.Cells("CantStock").Value)
                If stock <= 3 Then
                    alertasRoja += 1
                ElseIf stock <= 6 Then
                    alertasNara += 1
                ElseIf stock <= 10 Then
                    alertasAmari += 1
                ElseIf stock >= 11 Then
                    alerOk += 1
                End If
            End If
        Next
        BtnAR.Text = alertasRoja
        BtnAN.Text = alertasNara
        BtnAA.Text = alertasAmari
        Aok.Text = alerOk
        Dim total As Integer = alertasAmari + alertasNara + alertasRoja
        If total = 0 Then
            PaAlertas.Visible = False
        Else
            PaAlertas.Visible = True
        End If

        If alertasAmari = 0 Then
            BtnAA.Visible = False
        Else
            BtnAA.Visible = True
        End If

        If alertasNara = 0 Then
            BtnAN.Visible = False
        Else
            BtnAN.Visible = True
        End If

        If alertasRoja = 0 Then
            BtnAR.Visible = False
        Else
            BtnAR.Visible = True
        End If

        If alerOk = 0 Then
            Aok.Visible = False
        Else
            Aok.Visible = True
        End If

    End Sub

    'Alerta Amarillar
    Private Sub BtnAA_Click(sender As Object, e As EventArgs) Handles BtnAA.Click
        FiltrarStockPorCantidad(7, 10)
    End Sub

    ' Alerta Naranja
    Private Sub BtnAN_Click(sender As Object, e As EventArgs) Handles BtnAN.Click
        FiltrarStockPorCantidad(4, 6)
    End Sub

    'Alerta Roja
    Private Sub BtnAR_Click(sender As Object, e As EventArgs) Handles BtnAR.Click
        FiltrarStockPorCantidad(0, 3)
    End Sub

    Private Sub Aok_Click(sender As Object, e As EventArgs) Handles Aok.Click
        FiltrarStockPorCantidad(1, Integer.MaxValue)
    End Sub

    Private Sub FiltrarStockPorCantidad(minCantidad As Integer, maxCantidad As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdInsumoStock, IdUsuario, FechaStock, CodigoStock, NombreStock, CantStock, PrecioUniStock, DescripStock, CantStock * PrecioUniStock AS Total FROM StockInsumos WHERE IdUsuario = @IdUsuario AND CantStock BETWEEN @MinCantidad AND @MaxCantidad"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmd.Parameters.AddWithValue("@MinCantidad", minCantidad)
            cmd.Parameters.AddWithValue("@MaxCantidad", maxCantidad)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVStock.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al filtrar El Stock de Insumos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    ' Pintamos la Fila que tiene menos Cantidad de Stock < 5
    Private Sub DGVStock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVStock.CellFormatting
        If DGVStock.Columns(e.ColumnIndex).Name = "CantStock" Then
            If e.Value IsNot Nothing Then
                Dim stock As Integer = Convert.ToInt32(e.Value)
                Dim color As Color = Color.White ' Default color

                If stock <= 3 Then
                    color = Color.Red
                ElseIf stock <= 6 Then
                    color = Color.Orange
                ElseIf stock <= 10 Then
                    color = Color.Yellow
                ElseIf stock >= 11 Then
                    color = Color.Green
                End If

                For Each cell As DataGridViewCell In DGVStock.Rows(e.RowIndex).Cells
                    cell.Style.BackColor = color
                    cell.Style.ForeColor = Color.Black
                Next
            End If
        End If
    End Sub

    Public texto As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Format(DateAndTime.TimeOfDay, "hh") & ":" & Format(DateAndTime.TimeOfDay, "mm") & ":" & Format(DateAndTime.TimeOfDay, "ss")
        texto = Format(DateAndTime.TimeOfDay, "hh")

        ' Obtener la fecha actual
        Dim fechaActual As DateTime = DateTime.Now

        ' Formatear la fecha en el formato "20 de julio 2024"
        Dim fechaFormateada As String = fechaActual.Day & " de " & MonthName(fechaActual.Month) & " " & fechaActual.Year

        ' Actualizar Label5 con la fecha formateada
        Label6.Text = fechaFormateada
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Val(texto) > 12 Then
            Label8.Text = "AM"
        Else
            Label8.Text = "PM"
        End If

    End Sub

    Public Sub MostrarNotas(ByVal IDUsuario As Integer)
        Try
            con.Open()
            Dim query As String = "SELECT IdNota, IdUsuario, FechaNota, Nota, Titulo FROM NotasUsurio WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVNota.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar La Nota de Insumos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DGVNota_SelectionChanged(sender As Object, e As EventArgs) Handles DGVNota.SelectionChanged
        If DGVNota.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVNota.SelectedRows(0)
            Dim titulo As String = filaSeleccionada.Cells("Titulo").Value.ToString()
            Dim cuerpo As String = filaSeleccionada.Cells("Nota").Value.ToString()
            Dim fecha As Date = filaSeleccionada.Cells("FechaNota").Value.ToString()
            TbTitulo.Text = titulo
            TbCuerpo.Text = cuerpo
            DtpFecha.Value = fecha
        End If
    End Sub

    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        CambiarColorFormulario(Color.FromArgb(30, 30, 30), Me)
        'Color General de los controles de Formulario
        CambiarColoresFormu(Me, Color.White, Color.FromArgb(30, 30, 30))
        CambiarBackColor(Color.Transparent, BtnAR, BtnAN, BtnAA)
        'Color del Panel:
        CambiarColorPanel(Color.FromArgb(170, Color.FromArgb(30, 30, 30)), PaAlertas)
        CambiarColorPanel(Color.FromArgb(170, Color.FromArgb(30, 30, 30)), Panel1)

        Aok.Image = My.Resources.okOscu

        ConfigurarDataG(DGVStock, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)
        ConfigurarDataG(DGVNota, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)

    End Sub

    Public Sub Claro()
        CambiarColorFormulario(Color.White, Me)
        'Color General de los controles de Formulario
        CambiarColoresFormu(Me, Color.Black, Color.White)
        CambiarBackColor(Color.Transparent, BtnAR, BtnAN, BtnAA)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaAlertas)
        CambiarColorPanel(Color.FromArgb(170, Color.White), Panel1)

        Aok.Image = My.Resources.okClaro

        ConfigurarDataG(DGVStock, Color.Black, Color.White, Color.Blue, Color.White, Color.White)
        ConfigurarDataG(DGVNota, Color.Black, Color.White, Color.Blue, Color.White, Color.White)

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

    Public Sub VentanaMaximizada1()
        PaAlertas.Location = New Point(60, 132)
        PaAlertas.Size = New Size(250, 98)
        Label1.Location = New Point(3, 11)
        BtnAA.Location = New Point(45, 42)
        BtnAN.Location = New Point(95, 42)
        BtnAR.Location = New Point(145, 42)

        Panel1.Location = New Point(12, 30)

        PaDGVnota.Location = New Point(12, 296)
        PaDGVnota.Size = New Size(346, 250)

        PaDgvStock.Location = New Point(364, 12)
        PaDgvStock.Size = New Size(594, 278)

        PaDato.Location = New Point(364, 296)
        PaDato.Size = New Size(594, 250)
        TbTitulo.Location = New Point(3, 3)
        DtpFecha.Location = New Point(493, 10)
        TbTitulo.Size = New Size(484, 36)
        TbCuerpo.Size = New Size(594, 205)

        Aok.Location = New Point(315, 169)

    End Sub

    Public Sub VentanaNormal1()
        PaAlertas.Location = New Point(364, 7)
        PaAlertas.Size = New Size(412, 52)
        Label1.Location = New Point(3, 11)
        BtnAA.Location = New Point(255, 0)
        BtnAN.Location = New Point(305, 0)
        BtnAR.Location = New Point(355, 0)

        Panel1.Location = New Point(12, 81)

        PaDGVnota.Location = New Point(12, 263)
        PaDGVnota.Size = New Size(326, 196)

        PaDgvStock.Location = New Point(364, 63)
        PaDgvStock.Size = New Size(459, 194)

        PaDato.Location = New Point(364, 263)
        PaDato.Size = New Size(412, 196)
        TbTitulo.Location = New Point(3, 3)
        DtpFecha.Location = New Point(307, 10)
        TbTitulo.Size = New Size(298, 36)
        TbCuerpo.Size = New Size(412, 151)

        Aok.Location = New Point(779, 7)

    End Sub

End Class