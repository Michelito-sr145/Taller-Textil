Imports System.Data.SqlClient
Public Class AjusPerfil
    Dim IDUsuarioN As Integer
    Dim modoOscuroPer As Boolean
    Dim ar As String
    Dim tamanio As Boolean
    Dim EmailIdUsu As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")

    Private Sub AjusPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos(IDUsuarioN)
        Tema()
        UpdateControlPositions()
    End Sub
    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        IDUsuarioN = idUsuario
        modoOscuroPer = modoOscuro
        tamanio = IsMaximized
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

    Private Sub VentanaNormal1()
        PaPerfil.Location = New Point(219, 12)
        PaActuClave.Location = New Point(219, 50)
    End Sub
    Private Sub VentanaMaximizada1()
        PaPerfil.Location = New Point(219, 12)
        PaActuClave.Location = New Point(219, 50)
    End Sub

    Private Sub BtnActuClave_Click_1(sender As Object, e As EventArgs) Handles BtnActuClave.Click
        Dim nuevaClave As String = TbActuClave.Text.Trim()
        Dim nuevaClave2 As String = TbActuClave2.Text.Trim()
        Dim NombreUsuario As String = Label9.Text
        Dim EmailUsu As String = Label12.Text
        Dim Motivo As String = "Contraseña"
        If nuevaClave = "" Or nuevaClave2 = "" Then
            Label13.Visible = True
            Label13.Text = "complete los Campos"
            Return
        End If
        If nuevaClave = nuevaClave2 Then
            ActualizarClaveUsuario(nuevaClave)
            CambioClaveEmail(NombreUsuario, EmailUsu, Motivo)
            MessageBox.Show("Cambio exitoso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            LimpiarTextRegistros(TbActuClave, TbActuClave2)
            Label13.Visible = True
            Label13.Text = "Las Contraseñas no Coinciden"
            Return
        End If
        PaPerfil.Visible = True
        PaActuClave.Visible = False
    End Sub

    Public Sub MostrarDatos(ByVal IDUsuario As Integer)
        Dim Email As String
        Try
            con.Open()
            Dim query As String = "SELECT * From Usuario WHERE IdUsuario = @IdUsuario"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Asegúrate de que se encontraron filas
            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)

                ' Asignar valores a los labels
                Label9.Text = row("Nombre").ToString()
                Label10.Text = row("Apellido").ToString()
                Label11.Text = row("Usuario").ToString()
                Email = row("Email").ToString()
                Label12.Text = EnmascararCorreo(Email)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Function VerificarClave(clave As String) As Boolean
        Dim query As String = "SELECT Email FROM Usuario WHERE (IdUsuario = @IdUsuario) AND Clave = @Clave"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUsuarioN)
            cmd.Parameters.AddWithValue("@Clave", GetHash(clave)) ' convertir la clave a hash
            con.Open()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    con.Close()
                    Return True
                Else
                    con.Close()
                    Return False
                End If
            End Using
        End Using
    End Function

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim ContraActual As String = InputBox("Tu Clave es: ", "Escriba su Clave Actual")
            If String.IsNullOrEmpty(ContraActual) Then
                Return
            Else
                If VerificarClave(ContraActual) = True Then
                    LimpiarTextRegistros(TbActuClave, TbActuClave2)
                    PaPerfil.Visible = False
                    PaActuClave.Visible = True
                Else
                    MessageBox.Show("La Clave no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo salió mal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ActualizarClaveUsuario(nuevaClave As String)
        Dim query As String = "UPDATE Usuario SET Clave = @Clave WHERE IdUsuario = @idUsuario"
        Using con As New SqlConnection("data source=" & CStr(leerarchivo("")) & "; initial catalog=TallerTextil; integrated security=true"),
              cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@idUsuario", IDUsuarioN)
            cmd.Parameters.AddWithValue("@Clave", GetHash(nuevaClave))
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Sub CambioClaveEmail(NombreUsuario As String, UsuMail As String, Motivo As String)
        Dim moti As String = Motivo
        Dim Usuario As String = NombreUsuario
        Dim destinatario As String = UsuMail
        Dim asunto As String = "Cambio de Contraseña en Tu Cuenta"
        Dim fechaCambio As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        '" & vbCrLf & $"
        Dim cuerpo As String = $"Hola {Usuario}." & vbCrLf & $"Recientemente, tu {moti} fue cambiada en nuestra plataforma. Si realizaste este cambio, no necesitas hacer nada más." & vbCrLf & "" & vbCrLf & $"Fecha y Hora del Cambio: {fechaCambio}" & vbCrLf & "" & vbCrLf & "Si no reconoces esta actividad, por favor, contactar a nuestro equipo de soporte en tallertextilconfeccion@gmail.com" & vbCrLf & "Gracias" & vbCrLf & "El equipo de Taller Textil"
        EnviarCorreo(destinatario, asunto, cuerpo)

    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTextRegistros(TbActuClave, TbActuClave2)
        PaActuClave.Visible = False
        PaPerfil.Visible = True
    End Sub

    Private Sub TbActuClave_TextChanged(sender As Object, e As EventArgs) Handles TbActuClave.TextChanged
        Label13.Visible = False
    End Sub

    Private Sub TbActuClave2_TextChanged(sender As Object, e As EventArgs) Handles TbActuClave2.TextChanged
        Label13.Visible = False
    End Sub

    Function EnmascararCorreo(ByVal correo As String) As String
        Dim partes As String() = correo.Split("@"c)

        If partes.Length <> 2 Then
            Return correo ' Devuelve el correo original si no tiene el formato correcto
        End If

        Dim nombre As String = partes(0)
        Dim dominio As String = partes(1)

        If nombre.Length <= 4 Then
            Return $"{nombre.Substring(0, 1)}***@{dominio}" ' Enmascarar con solo una letra visible si el nombre es muy corto
        Else
            Return $"{nombre.Substring(0, 6)}****@{dominio}" ' Enmascarar con las primeras 6 letras visibles
        End If
    End Function


    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        CambiarColorFormulario(Color.FromArgb(30, 30, 30), Me)
        CambiarColoresFormu(Me, Color.White, Color.FromArgb(30, 30, 30))
        LinkLabel1.LinkColor = Color.Cyan
        Label13.ForeColor = Color.Red
    End Sub

    Public Sub Claro()
        CambiarColorFormulario(Color.White, Me)
        CambiarColoresFormu(Me, Color.Black, Color.White)
        LinkLabel1.LinkColor = Color.Blue
        Label13.ForeColor = Color.Red
    End Sub


End Class