Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo("")) & "; initial catalog=TallerTextil; integrated security=true")
    Public modoOscuroIn As Boolean = False

    Private Sub Inicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    'Tamaño de Ventana
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = PbIcono
        Me.Width = 350
        Me.Height = 450
        PaLogin.Visible = True
        PbIcono.Visible = True
        PbSol.Location = New Point(300, 0)
        PbLuna.Location = New Point(300, 0)
        SetPlaceholder(TbUsuario, "Usuario o Correo Electronico")
        SetPlaceholder(TbClave, "Contraseña (0-6 Digitos)")
        AddHandler waitTimer.Tick, AddressOf WaitTimer_Tick
        waitTimer.Interval = 1000
        PbLuna.Visible = True
        PbSol.Visible = False
        PbOBOscuro.Visible = False
        PbOVOscuro.Visible = False
        PbOBClaro.Visible = True
        PbOVClaro.Visible = False
        ModoTema(modoOscuroIn)
        FondoInviPanel(PaActuClave)
        FondoInviPanel(PaLogin)
        FondoInviPanel(PaOlvideCuenta)
        FondoInviPanel(PaRegistro)
    End Sub

    'Logueo de Usuario/Email y clave.
    Private Function VerificarCredenciales(UsuEmail As String, clave As String, ByRef idUsuario As Integer, ByRef idRol As Integer) As Boolean
        Dim query As String = "SELECT IdUsuario, IdRol FROM Usuario WHERE (Usuario = @UsuEmail OR Email = @UsuEmail) AND Clave = @Clave"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@UsuEmail", UsuEmail)
            cmd.Parameters.AddWithValue("@Clave", GetHash(clave)) ' convertir la clave a hash
            con.Open()
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    idUsuario = reader.GetInt32(0)
                    idRol = reader.GetInt32(1)
                    con.Close()
                    Return True
                Else
                    con.Close()
                    Return False
                End If
            End Using
        End Using

    End Function


    Public Sub BtnLogueo_Click(sender As Object, e As EventArgs) Handles BtnLogueo.Click
        Dim usuarioOEmail As String = TbUsuario.Text.Trim()
        Dim clave As String = TbClave.Text.Trim()
        Dim idUsuario As Integer
        Dim idRol As Integer
        Dim modo As Boolean = modoOscuroIn

        If VerificarCredenciales(usuarioOEmail, clave, idUsuario, idRol) Then
            Dim Ui As New UI(idUsuario, idRol, modo)
            Ui.Show()
            Me.Hide()
        Else
            LabelsVisi(Label3, Label4)
            Label3.Text = "Usuario o email incorrecto"
            Label4.Text = "Clave incorrecta"
        End If

    End Sub

    'Creacion de Nuevo Usuario
    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        Me.Width = 351
        Me.Height = 651
        PaRegistro.Location = New Point(1, 1)
        PaLogin.Visible = False
        PaRegistro.Visible = True
        PbIcono.Visible = False
        LimpiarTextRegistros(TbUsuario, TbClave)

    End Sub

    Private Sub BtnSalirRegis_Click(sender As Object, e As EventArgs) Handles BtnSalirRegis.Click
        Me.Width = 350
        Me.Height = 450
        SetPlaceholder(TbClave, "Contraseña (0-6 Digitos)")
        PaRegistro.Visible = False
        PaLogin.Visible = True
        PbIcono.Visible = True
    End Sub


    Private Function Existencia(usuario As String, email As String) As Integer
        Dim countUsuario As Integer = 0
        Dim countEmail As Integer = 0

        Dim queryUsuario As String = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @Usuario"
        Dim queryEmail As String = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email"

        Using con As New SqlConnection("data source=" & CStr(leerarchivo("")) & "; initial catalog=TallerTextil; integrated security=true")
            con.Open()

            Using cmdUsuario As New SqlCommand(queryUsuario, con)
                cmdUsuario.Parameters.AddWithValue("@Usuario", usuario)
                countUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar())
            End Using

            Using cmdEmail As New SqlCommand(queryEmail, con)
                cmdEmail.Parameters.AddWithValue("@Email", email)
                countEmail = Convert.ToInt32(cmdEmail.ExecuteScalar())
            End Using

            con.Close()
        End Using

        If countUsuario > 0 Then
            Return 1
        ElseIf countEmail > 0 Then
            Return 2
        Else
            Return 0
        End If
    End Function

    'Registro de nuevo usuario
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim nombre As String = TbRNombre.Text.Trim()
        Dim apellido As String = TbRApellido.Text.Trim()
        Dim documento As String = TbRDocu.Text.Trim()
        Dim usuario As String = TbRUsuario.Text.Trim()
        Dim clave As String = TbRClave.Text.Trim()
        Dim clave2 As String = TbRClave2.Text.Trim()
        Dim email As String = TbREmail.Text.Trim()
        Dim idRol As Integer = 1

        ' Verificar campos obligatorios
        Dim todosLosCamposValidos As Boolean = True
        If Not VerificarCampo(TbRNombre, LaRNom, "campo obligatorio") Then todosLosCamposValidos = False
        If Not VerificarCampo(TbRApellido, LaRApe, "campo obligatorio") Then todosLosCamposValidos = False
        If Not VerificarCampo(TbRDocu, LaRDoc, "campo obligatorio") Then todosLosCamposValidos = False
        If Not VerificarCampo(TbRUsuario, LaRUsu, "campo obligatorio") Then todosLosCamposValidos = False
        If Not VerificarCampo(TbRClave, LaRCla, "campo obligatorio") Then todosLosCamposValidos = False
        If Not VerificarCampo(TbRClave2, LaRCla2, "campo obligatorio") Then todosLosCamposValidos = False
        If Not VerificarCampo(TbREmail, LaREma, "campo obligatorio") Then todosLosCamposValidos = False

        If Not todosLosCamposValidos Then
            MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If clave <> clave2 Then ' Verificar si las contraseñas coinciden
            LaRCla2.Visible = True
            LaRCla2.Text = "Las Contraseñas no coinciden"
            Exit Sub
        End If

        Dim existe As Integer = Existencia(usuario, email)

        If existe = 1 Then
            LaRUsu.Visible = True
            LaRUsu.Text = "Usuario ya registrado"
            Exit Sub
        ElseIf existe = 2 Then
            LaREma.Visible = True
            LaREma.Text = "Email ya registrado"
            Exit Sub
        End If

        If Not email.EndsWith("@gmail.com") Then
            email &= "@gmail.com"
        End If

        Dim codigoVerificacion As String = GenerarCodigoVerificacion()
        EnviarCorreo(email, "Código de Verificación", $"Tu código de verificación es:   {codigoVerificacion}")

        Dim codigoIngresado As String = InputBox("Introduce el código de verificación enviado a tu correo:", "Verificación")
        If codigoIngresado = codigoVerificacion Then
            RegistrarUsuario(nombre, apellido, documento, usuario, clave, email, idRol)
            LimpiarTextRegistros(TbRNombre, TbRApellido, TbRDocu, TbRUsuario, TbRClave, TbRClave2, TbREmail, TbUsuario, TbClave)
            SetPlaceholder(TbUsuario, "Usuario o Correo Electronico")
            SetPlaceholder(TbClave, "Contraseña (0-6 Digitos)")
            Me.Width = 350
            Me.Height = 450
            PaLogin.Visible = True
            PbIcono.Visible = True
            PaRegistro.Visible = False
            MessageBox.Show("Registro exitoso, bienvenido!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Código de verificación incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub RegistrarUsuario(nombre As String, apellido As String, documento As String, usuario As String, clave As String, email As String, idRol As Integer)
        Dim query As String = "INSERT INTO Usuario (Nombre, Apellido, Documento, Usuario, Clave, Email, IdRol) VALUES (@Nombre, @Apellido, @Documento, @Usuario, @Clave, @Email, @IdRol)"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Nombre", nombre)
            cmd.Parameters.AddWithValue("@Apellido", apellido)
            cmd.Parameters.AddWithValue("@Documento", documento)
            cmd.Parameters.AddWithValue("@Usuario", usuario)
            cmd.Parameters.AddWithValue("@Clave", GetHash(clave)) ' Guarda la clave como un hash
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@IdRol", idRol)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub


    ' Olvide la Contraseña
    Private Sub LinkOlvClave_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkOlvClave.LinkClicked
        Me.Width = 350
        Me.Height = 300
        LimpiarTextRegistros(TbUsuario, TbClave)
        PbIcono.Visible = False
        PaLogin.Visible = False
        PaRegistro.Visible = False
        PaOlvideCuenta.Location = New Point(1, 12)
        PaOlvideCuenta.Visible = True
        Label14.Text = "Recupera Tu Cuenta"
        Label12.Text = "Escribe tu correo Electronico" & vbCrLf & "te enviaremos un Email:"

    End Sub

    Private Sub BtnSalirOlv_Click(sender As Object, e As EventArgs) Handles BtnSalirOlv.Click
        Me.Width = 350
        Me.Height = 450
        PbIcono.Visible = True
        LimpiarTextRegistros(TbOlvEm, TbUsuario, TbClave)
        SetPlaceholder(TbUsuario, "Usuario o Correo Electronico")
        SetPlaceholder(TbClave, "Contraseña (0-6 Digitos)")
        PaOlvideCuenta.Visible = False
        PaLogin.Visible = True
    End Sub

    'Actualizacion de Contraseña

    Private waitTimer As New Timer()
    Private waitTime As Integer = 25

    Private Sub BtnOlvi_Click(sender As Object, e As EventArgs) Handles BtnOlvi.Click
        BtnOlvi.Enabled = False
        waitTime = 25 'tempo de espera
        waitTimer.Start()

        Dim emailolv As String = TbOlvEm.Text.Trim()

        Dim todosLosCamposValidos As Boolean = True
        If Not VerificarCampo(TbOlvEm, Label15, "campo obligatorio") Then todosLosCamposValidos = False

        If Not emailolv.EndsWith("@gmail.com") Then
            emailolv &= "@gmail.com"
        End If

        Dim existe As Integer = Existencia("", emailolv)
        If existe = 0 Then
            Label15.Visible = True
            Label15.Text = "Email no registrado"
            BtnOlvi.Enabled = True
            Exit Sub
        End If
        LaTimer.Visible = True

        Dim codigoVerificacion As String = GenerarCodigoNumerico()
        EnviarCorreo(emailolv, "Código de Recuperacion", $"Tu código de recuperacion es:   {codigoVerificacion}")

        Dim codigoIngresado As String = InputBox("Comprueba si has recibido un mensaje con tu código de 6 dígitos en tu dirección de correo electrónico:", "Introduce el código de seguridad")

        If codigoIngresado = codigoVerificacion Then
            Label16.Text = emailolv
            PaActuClave.Visible = True
            PaActuClave.Location = New Point(1, 5)
            PaOlvideCuenta.Visible = False

        Else
            MessageBox.Show("Código incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    ' Desabilitamos El Boton de Enviar
    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs)
        If waitTime > 0 Then
            waitTime -= 1
            LaTimer.Text = "Esperar " & waitTime & "s"
        Else
            ' Cuando el tiempo de espera llega a 0, desbloqueamos el botón y detenemos el timer
            waitTimer.Stop()
            BtnOlvi.Enabled = True
            LaTimer.Text = ""
        End If
    End Sub

    Private Sub BtnActuClave_Click(sender As Object, e As EventArgs) Handles BtnActuClave.Click
        Dim emailolv As String = Label16.Text
        Dim nuevaClave As String = TbActuClave.Text.Trim()
        Dim nuevaClaveConfirm As String = TbActuClave2.Text.Trim()
        LlActuClave2.Visible = False
        If nuevaClave <> nuevaClaveConfirm Then
            LlActuClave2.Visible = True
            LlActuClave2.Text = "Las Contraseñas no coinciden"
            Exit Sub
        End If
        ActualizarClaveUsuario(emailolv, nuevaClave)
        MessageBox.Show("Cambio exitoso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Width = 350
        Me.Height = 450
        PbIcono.Visible = True
        PaLogin.Visible = True
        PaActuClave.Visible = False
        LimpiarTextRegistros(TbUsuario, TbClave)
        SetPlaceholder(TbUsuario, "Usuario o Correo Electronico")
        SetPlaceholder(TbClave, "Contraseña (0-6 Digitos)")
    End Sub


    Public Sub ActualizarClaveUsuario(Emailolv As String, nuevaClave As String)
        Dim query As String = "UPDATE Usuario SET Clave = @Clave WHERE Email = @Email"
        Using con As New SqlConnection("data source=" & CStr(leerarchivo("")) & "; initial catalog=TallerTextil; integrated security=true"),
              cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Clave", GetHash(nuevaClave))
            cmd.Parameters.AddWithValue("@Email", Emailolv)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    'ojo bloqueado Claro
    Private Sub PbOBC_Click(sender As Object, e As EventArgs) Handles PbOBClaro.Click
        TogglePasswordChar()
    End Sub

    'ojo bloqueado Oscuro
    Private Sub PbOBO_Click(sender As Object, e As EventArgs) Handles PbOBOscuro.Click
        TogglePasswordChar()
    End Sub

    'ojo visible Claro
    Private Sub PbOVC_Click(sender As Object, e As EventArgs) Handles PbOVClaro.Click
        TogglePasswordChar()
    End Sub

    'ojo visible Oscuro
    Private Sub PbOVO_Click(sender As Object, e As EventArgs) Handles PbOVOscuro.Click
        TogglePasswordChar()
    End Sub

    Private Sub TogglePasswordChar()
        If TbClave.PasswordChar = "*"c Then
            ' Mostrar el texto sin enmascarar
            TbClave.PasswordChar = ControlChars.NullChar
            If modoOscuroIn Then
                PbOVOscuro.Visible = True
                PbOBOscuro.Visible = False
            Else
                PbOVClaro.Visible = True
                PbOBClaro.Visible = False
            End If
        Else
            ' Enmascarar el texto
            TbClave.PasswordChar = "*"c
            If modoOscuroIn Then
                PbOVOscuro.Visible = False
                PbOBOscuro.Visible = True
            Else
                PbOVClaro.Visible = False
                PbOBClaro.Visible = True
            End If
        End If
    End Sub

    Private Sub TbUsuario_TextChanged(sender As Object, e As EventArgs) Handles TbUsuario.TextChanged
        Label3.Visible = False
    End Sub

    Private Sub TbClave_TextChanged(sender As Object, e As EventArgs) Handles TbClave.TextChanged
        Label4.Visible = False
    End Sub

    ' Detalles de Color

    ' Modo Oscuro o Claro
    Public Sub PbSol_Click(sender As Object, e As EventArgs) Handles PbSol.Click
        ModoTema(True)
        Tema()
    End Sub

    'Tema de Oscuro a Claro
    Private Sub PbLuna_Click(sender As Object, e As EventArgs) Handles PbLuna.Click
        ModoTema(False)
        Tema()
    End Sub

    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        modoOscuroIn = False
        PbLuna.Visible = True
        PbSol.Visible = False
        PbOBOscuro.Visible = False
        PbOVOscuro.Visible = False

        If TbClave.PasswordChar = "*"c Then
            PbOVClaro.Visible = False
            PbOBClaro.Visible = True
        Else
            PbOVClaro.Visible = True
            PbOBClaro.Visible = False
        End If
        CambiarColorFormulario(Color.White, Me)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaLogin)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaRegistro)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaOlvideCuenta)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaActuClave)

        CambiarColoresFormu(Me, Color.Black, Color.White)
        LinkOlvClave.LinkColor = Color.Blue
        LaTimer.ForeColor = Color.Blue
        CambiarForeColor(Color.Red, Label3, Label4, LaRApe, LaRCla, LaRCla2, LaRDoc, LaREma, LaRNom, LaRUsu, LlActuClave2, LlActuClave2, Label15)



    End Sub

    Public Sub Claro()
        modoOscuroIn = True
        PbSol.Visible = True
        PbLuna.Visible = False
        PbOBClaro.Visible = False
        PbOBOscuro.Visible = False
        PbOVClaro.Visible = False

        If TbClave.PasswordChar = "*"c Then
            PbOVOscuro.Visible = False
            PbOBOscuro.Visible = True
        Else
            PbOVOscuro.Visible = True
            PbOBOscuro.Visible = False
        End If

        Dim Color As Color = Color.FromArgb(30, 30, 30)

        CambiarColorFormulario(Color, Me)

        CambiarColorPanel(Color, PaLogin)
        CambiarColorPanel(Color, PaRegistro)
        CambiarColorPanel(Color, PaOlvideCuenta)
        CambiarColorPanel(Color, PaActuClave)

        CambiarColoresFormu(Me, Color.White, Color)
        LinkOlvClave.LinkColor = Color.Cyan
        LaTimer.ForeColor = Color.Cyan
        CambiarForeColor(Color.Red, Label3, Label4, LaRApe, LaRCla, LaRCla2, LaRDoc, LaREma, LaRNom, LaRUsu, LlActuClave2, LlActuClave2, Label15)


    End Sub



End Class
