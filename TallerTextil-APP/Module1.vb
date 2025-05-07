Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Configuration
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.DataVisualization.Charting

Module Module1
    Public x As Integer

    Public EmailActivo As String = ConfigurationManager.AppSettings("EmailActivo")
    Public Email As String = ConfigurationManager.AppSettings(EmailActivo)
    Public EmailPass As String = ConfigurationManager.AppSettings(EmailActivo & "Pass")

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            Return ""
        End If

    End Function

    Function YaExisteSQL(ByVal sql As String) As Boolean
        Dim ar As String = "c:\ABM\ip.txt" ' Asigna el nombre del archivo a ar
        Dim ip As String = leerarchivo(ar) ' Lee la IP del archivo
        If ip <> "" Then ' Verifica si se pudo leer la IP del archivo
            Dim con As New SqlConnection("data source=" & ip & "; initial catalog=TallerTextil; integrated security=true")
            Dim da1 As New SqlDataAdapter(sql, con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "afidesc")
            If ds1.Tables("afidesc").Rows.Count < 1 Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function

    'Hashear claves
    Function GetHash(plainText As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(plainText)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    ' Enviar Correos electronico
    Function EnviarCorreo(destinatario As String, asunto As String, cuerpo As String) As String
        Dim Resultado As String = "OK"
        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage
        Try
            mail = New MailMessage()
            mail.From = New MailAddress(Email, "Taller Textil")
            mail.To.Add(destinatario)
            mail.Subject = asunto
            mail.Body = cuerpo
            mail.IsBodyHtml = False
            mail.Priority = MailPriority.Normal
            If EmailActivo = "EmailGmail" Then
                SmtpServer.Credentials = New Net.NetworkCredential(Email, EmailPass)
                SmtpServer.Host = "smtp.gmail.com"
                SmtpServer.Port = 587
                SmtpServer.EnableSsl = True
            Else
                SmtpServer.Credentials = New Net.NetworkCredential(Email, EmailPass)
                SmtpServer.Host = "dtcwin033.ferozo.com"
                SmtpServer.Port = 465
                SmtpServer.EnableSsl = True
            End If
            SmtpServer.Send(mail)
        Catch
            Resultado = Err.Description
        End Try
        mail.Dispose()
        Return Resultado
    End Function

    ' TexBox con Letras y se le cambia por el que se coloca
    Public Sub SetPlaceholder(textBox As TextBox, placeholder As String)
        textBox.Text = placeholder
        ' Manejador para el evento Enter
        AddHandler textBox.Enter, Sub(sender As Object, e As EventArgs)
                                      If textBox.Text = placeholder Then
                                          textBox.Text = ""
                                      End If

                                  End Sub

        ' Manejador para el evento Leave
        AddHandler textBox.Leave, Sub(sender As Object, e As EventArgs)
                                      If textBox.Text = "" Then
                                          textBox.Text = placeholder
                                      End If

                                  End Sub
    End Sub

    ' Genera un codigo aleatorio
    Function GenerarCodigoVerificacion() As String
        Dim caracteresPermitidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim random As New Random()
        Dim codigo As New StringBuilder()
        For i As Integer = 1 To 8
            Dim index As Integer = random.Next(0, caracteresPermitidos.Length)
            codigo.Append(caracteresPermitidos(index))
        Next
        Return codigo.ToString()
    End Function

    ' Genera un codigo Numerico
    Function GenerarCodigoNumerico() As String
        Dim caracteresPermitidos As String = "0123456789"
        Dim random As New Random()
        Dim codigo As New StringBuilder()
        For i As Integer = 1 To 6
            Dim index As Integer = random.Next(0, caracteresPermitidos.Length)
            codigo.Append(caracteresPermitidos(index))
        Next
        Return codigo.ToString()
    End Function

    ' Convertidor decimal
    Function ConvertirPrecio(ByVal NTexto As String) As Decimal
        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function

    ' Limpia TextBox
    Public Sub LimpiarTextRegistros(ParamArray textboxes() As TextBox)
        For Each tb As TextBox In textboxes
            tb.Clear()
        Next
    End Sub

    ' Función para hacer Visible los Labels
    Public Sub LabelsVisi(ParamArray labels() As Label)
        For Each lbl As Label In labels
            lbl.Visible = True
        Next
    End Sub

    ' Función para hacer Invisibles los Labels
    Public Sub LabelsInvi(ParamArray labels() As Label)
        For Each lbl As Label In labels
            lbl.Visible = False
        Next
    End Sub

    ' Funcion para Activar o desactivar los TextBox
    Public Sub Controles(ByVal estado As Boolean, ByVal ParamArray controls() As Control)
        For Each control As Control In controls
            If TypeOf control Is TextBox OrElse
               TypeOf control Is Button OrElse
               TypeOf control Is ComboBox OrElse
               TypeOf control Is DateTimePicker Then
                control.Enabled = estado
            End If
        Next
    End Sub

    ' Activamos o desactivamos la Visivilidad de los controles
    Public Sub Visibilidad(ByVal estado As Boolean, ByVal ParamArray controls() As Control)
        For Each control As Control In controls
            If TypeOf control Is TextBox OrElse
               TypeOf control Is Button OrElse
               TypeOf control Is ComboBox OrElse
               TypeOf control Is DateTimePicker Then
                control.Visible = estado
            End If
        Next
    End Sub

    ' Verifica Si texbox esta vacio
    Function VerificarCampo(tb As TextBox, lbl As Label, texto As String) As Boolean
        If String.IsNullOrWhiteSpace(tb.Text) Then
            lbl.Visible = True
            lbl.Text = texto
            Return False
        Else
            lbl.Visible = False
            Return True
        End If
    End Function

    ' Meses
    Function GetNombreMes(ByVal numeroMes As Integer) As String
        Select Case numeroMes
            Case 1
                Return "Enero"
            Case 2
                Return "Febrero"
            Case 3
                Return "Marzo"
            Case 4
                Return "Abril"
            Case 5
                Return "Mayo"
            Case 6
                Return "Junio"
            Case 7
                Return "Julio"
            Case 8
                Return "Agosto"
            Case 9
                Return "Septiembre"
            Case 10
                Return "Octubre"
            Case 11
                Return "Noviembre"
            Case 12
                Return "Diciembre"
            Case Else
                Return "Mes inválido"
        End Select
    End Function

    ' Saber si esta en Ventana Completa o Normal
    Public IsMaximized As Boolean = False
    Public Sub UpdateChildForms(paContenedor As Panel)
        For Each ctrl As Control In paContenedor.Controls
            If TypeOf ctrl Is Form Then
                Dim childForm As Form = DirectCast(ctrl, Form)
                ' Llama al método UpdateControlPositions de cada formulario hijo
                If childForm.GetType().GetMethod("UpdateControlPositions") IsNot Nothing Then
                    childForm.GetType().GetMethod("UpdateControlPositions").Invoke(childForm, Nothing)
                End If
            End If
        Next
    End Sub

    ' Modo de Tema Claro o Oscuro

    Private modoOscuClar As Boolean

    Public Function ModoTema(Optional Estado As Boolean? = Nothing) As Boolean
        If Estado.HasValue Then
            modoOscuClar = Estado.Value
        End If
        Return modoOscuClar
    End Function

    ' Se le pasa los controles y color para su fondo (color ,label,texbox)
    Sub CambiarBackColor(colorFondo As Color, ParamArray controles() As Control)
        For Each ctrl As Control In controles
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is Label OrElse TypeOf ctrl Is ComboBox Then
                ctrl.BackColor = colorFondo
            End If
        Next
    End Sub

    ' Se le pasa los controles y color para su Letras (color ,label,texbox)
    Sub CambiarForeColor(ColorLetra As Color, ParamArray controles() As Control)
        For Each ctrl As Control In controles
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is Label OrElse TypeOf ctrl Is ComboBox Then
                ctrl.ForeColor = ColorLetra
            End If
        Next
    End Sub

    ' Cmabiar el color del fondo del Panel
    Sub CambiarColorPanel(ColorPanel As Color, panel As Panel)
        panel.BackColor = ColorPanel
    End Sub

    ' Volver el fondo del Panel Invisible
    Sub FondoInviPanel(panel As Panel)
        panel.BackColor = Color.Transparent
    End Sub

    ' Cmabiar el color del fondo del Formulario
    Sub CambiarColorFormulario(ColorForm As Color, formu As Form)
        formu.BackColor = ColorForm
    End Sub


    ' Cambiando los colores de todos los controles de un formulario:
    Public Sub CambiarColoresFormu(control As Control, foreColor As Color, backColor As Color)
        ' Cambia los colores solo si el control es del tipo especificado
        If TypeOf control Is Button Then
            control.ForeColor = foreColor
            control.BackColor = backColor
        ElseIf TypeOf control Is Label Then
            control.ForeColor = foreColor
            control.BackColor = Color.Transparent
        ElseIf TypeOf control Is TextBox Then
            control.ForeColor = foreColor
            control.BackColor = backColor
        ElseIf TypeOf control Is ComboBox Then
            control.ForeColor = foreColor
            control.BackColor = backColor
        ElseIf TypeOf control Is DateTimePicker Then
            control.ForeColor = foreColor
            control.BackColor = backColor
        End If
        ' Itera sobre los controles hijos si los hay
        For Each childControl As Control In control.Controls
            CambiarColoresFormu(childControl, foreColor, backColor)
        Next

    End Sub

    Public Sub ConfigurarDataG(dgv As DataGridView, foreColor As Color, backColor As Color, Seleccion As Color, ForeSelec As Color, fondo As Color)
        ' Color de fondo del DataGridView
        dgv.BackgroundColor = fondo

        ' Color de las celdas
        dgv.DefaultCellStyle.BackColor = backColor
        dgv.DefaultCellStyle.ForeColor = foreColor

        ' Color de las celdas seleccionadas
        dgv.DefaultCellStyle.SelectionBackColor = Seleccion
        dgv.DefaultCellStyle.SelectionForeColor = ForeSelec

        ' Color del encabezado
        dgv.ColumnHeadersDefaultCellStyle.BackColor = backColor
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = foreColor
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Seleccion
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = ForeSelec

        ' Otras configuraciones de estilo
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersDefaultCellStyle.BackColor = backColor
        dgv.RowHeadersDefaultCellStyle.ForeColor = foreColor
        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Seleccion
        dgv.RowHeadersDefaultCellStyle.SelectionForeColor = ForeSelec
    End Sub


    Public Sub ColorDato(pf As Series)
        If ModoTema() = True Then
            pf.LabelForeColor = Color.White
        Else
            pf.LabelForeColor = Color.Black
        End If
    End Sub

    Public Sub colorT(chart As Chart)
        If chart.Titles.Count > 0 Then
            For Each title As Title In chart.Titles
                If ModoTema() = True Then
                    title.ForeColor = Color.White
                Else
                    title.ForeColor = Color.Black
                End If
            Next
        End If
    End Sub

    Public Sub ConfigurarChart(chart As Chart, foreColor As Color, backColor As Color, colorXY As Color)
        chart.BackColor = backColor

        ' Configurar el color de los títulos del Chart
        If chart.Titles.Count > 0 Then
            For Each title As Title In chart.Titles
                title.ForeColor = foreColor
                ' Opcional: Si quieres cambiar el color de fondo del título
                ' title.BackColor = backColor
            Next
        End If

        ' Configurar los colores de las áreas del Chart
        For Each chartArea As ChartArea In chart.ChartAreas
            chartArea.BackColor = backColor
            chartArea.AxisX.LineColor = colorXY
            chartArea.AxisY.LineColor = colorXY
            chartArea.AxisX.MajorGrid.LineColor = colorXY
            chartArea.AxisY.MajorGrid.LineColor = colorXY
            chartArea.AxisX.LabelStyle.ForeColor = foreColor
            chartArea.AxisY.LabelStyle.ForeColor = foreColor
            chartArea.AxisX.TitleForeColor = foreColor
            chartArea.AxisY.TitleForeColor = foreColor
        Next

        ' Configurar los colores de las Series y sus puntos
        For Each series As Series In chart.Series
            series.BorderColor = colorXY
            series.LabelForeColor = foreColor ' Cambia el color de las etiquetas de los puntos
            series.Font = New Font("Arial", 10, FontStyle.Bold) ' Configura la fuente y estilo si es necesario

            ' Configurar colores de los puntos individuales y sus etiquetas
            For Each point As DataPoint In series.Points
                point.LabelForeColor = foreColor ' Cambia el color de las etiquetas de los puntos
            Next
        Next

        ' Configurar los colores de la leyenda
        For Each legend As Legend In chart.Legends
            legend.BackColor = backColor
            legend.ForeColor = foreColor
            legend.TitleForeColor = foreColor ' Configura el color del título de la leyenda
        Next
    End Sub



End Module
