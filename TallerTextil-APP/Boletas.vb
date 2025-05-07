Imports System.Data.SqlClient

Public Class Boletas
    Dim IdUsuarioN As Integer
    Dim ModoOscu As Boolean
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        IdUsuarioN = idUsuario
        ModoOscu = modoOscuro
    End Sub
    Private Sub Boletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlPositions()
        Controles(False, TbTitulo, DtpFecha)
        TbCuerpo.ReadOnly = True
        MostrarNotas(IdUsuarioN)
        Tema()
        BtnGuardar.Visible = False
        BtnCancelar.Visible = False
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
        LimpiarTextRegistros(TbTitulo, TbCuerpo)
        Controles(True, TbTitulo, DtpFecha)
        TbCuerpo.ReadOnly = False
        BtnGuardar.Visible = True
        BtnCancelar.Visible = True
        DGVNota.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim usuarioid As Integer = IdUsuarioN
            Dim titulo As String = TbTitulo.Text
            Dim cuerpo As String = TbCuerpo.Text
            If titulo = "" Then
                MessageBox.Show("Porfavor Ingresar un Titulo.", "Sin Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If cuerpo = "" Then
                MessageBox.Show("No escribio una nota.", "Sin Nota", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim fecha As String = DateTime.Now.ToString("dd/MM/yyyy")
            Dim query As String = "INSERT INTO NotasUsurio (IdUsuario, FechaNota, Nota, Titulo) VALUES (@IDUsuario, @Fecha, @Cuerpo, @Titulo)"
            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@IDUsuario", usuarioid)
                cmd.Parameters.AddWithValue("@Titulo", titulo)
                cmd.Parameters.AddWithValue("@Cuerpo", cuerpo)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()
            End Using
            DGVNota.Enabled = True
            BtnGuardar.Visible = False
            BtnCancelar.Visible = False
            Panel3.Visible = True
            MostrarNotas(IdUsuarioN)
            Controles(False, TbTitulo, DtpFecha)
            TbCuerpo.ReadOnly = True
            MessageBox.Show("Nota guardada exitosamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar la Nota: " & ex.Message, "Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Verificar(clave As String) As Boolean
        Dim usuarioid As Integer = IdUsuarioN
        Dim query As String = "SELECT Email FROM Usuario WHERE (IdUsuario = @IdUsuario) AND Clave = @Clave"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", usuarioid)
            cmd.Parameters.AddWithValue("@Clave", GetHash(clave))
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If DGVNota.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVNota.SelectedRows(0)
            Dim Id As String = filaSeleccionada.Cells("IdNota").Value.ToString()
            Dim Fecha As String = filaSeleccionada.Cells("FechaNota").Value.ToString()
            Dim Titulo As String = filaSeleccionada.Cells("Titulo").Value.ToString()
            Dim Clave As String = InputBox($"Eliminar {Fecha}-{Titulo}" & vbCrLf & $"Para Eliminar Introduce tu clave", "Confirmar Eliminación")
            If Verificar(Clave) = True Then
                EliminarNota(Id)
            Else
                MessageBox.Show("La Clave no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
    End Sub

    Function EliminarNota(id As Integer)
        Try
            Dim query As String = "DELETE FROM NotasUsurio WHERE IdNota = @IdNota"
            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                  cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@IdNota", id)
                cmd.ExecuteNonQuery()
            End Using
            MostrarNotas(IdUsuarioN)
            Controles(False, TbTitulo, DtpFecha)
            TbCuerpo.ReadOnly = True
            MessageBox.Show("Nota Eliminada.", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message, "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Panel3.Visible = True
        DGVNota.Enabled = True
        BtnGuardar.Visible = False
        BtnCancelar.Visible = False
        MostrarNotas(IdUsuarioN)
        Controles(False, TbTitulo, DtpFecha)
        TbCuerpo.ReadOnly = True
    End Sub

    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        CambiarColorFormulario(Color.FromArgb(15, 15, 15), Me)
        CambiarColoresFormu(Me, Color.White, Color.FromArgb(50, 50, 50))

        ConfigurarDataG(DGVNota, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)

        Button1.Image = My.Resources.CrearOscu
        Button2.Image = My.Resources.EliminarOscu

    End Sub

    Public Sub Claro()
        CambiarColorFormulario(Color.White, Me)
        CambiarColoresFormu(Me, Color.Black, Color.White)
        ConfigurarDataG(DGVNota, Color.Black, Color.White, Color.Blue, Color.White, Color.White)

        Button1.Image = My.Resources.CrearClaro
        Button2.Image = My.Resources.EliminarClaro

    End Sub


    Public Sub UpdateControlPositions()
        If IsMaximized Then
            VentanaMaximizada1()
        Else
            VentanaNormal1()
        End If
    End Sub

    Public Sub VentanaMaximizada1()
        Panel1.Location = New Point(12, 3)
        TextBox1.Location = New Point(3, 36)
        DtpInicio.Location = New Point(321, 54)
        DtpFinal.Location = New Point(419, 54)
        Label1.Location = New Point(3, 3)
        Label2.Location = New Point(322, 12)
        Label3.Location = New Point(317, 32)
        Label3.Text = "Inicio:    Final:"
        Label2.Text = "Filtar por fechas"

        Panel1.Size = New Size(515, 94)
        TextBox1.Size = New Size(231, 32)

        PaDGVnota.Location = New Point(8, 120)
        PaDGVnota.Size = New Size(386, 308)

        Panel3.Location = New Point(397, 166)
        Panel3.Size = New Size(130, 150)
        Button1.Location = New Point(3, 3)
        Button2.Location = New Point(3, 107)

        PaDato.Location = New Point(552, 12)
        TbCuerpo.Size = New Size(433, 335)

        BtnCancelar.Location = New Point(762, 398)
        BtnGuardar.Location = New Point(890, 398)
    End Sub

    Public Sub VentanaNormal1()
        Panel1.Location = New Point(12, 3)
        TextBox1.Location = New Point(3, 36)
        DtpInicio.Location = New Point(265, 37)
        DtpFinal.Location = New Point(265, 68)
        Label1.Location = New Point(3, 3)
        Label3.Location = New Point(199, 34)
        Label2.Location = New Point(249, -4)
        Label3.Text = "Inicio:" & vbCrLf & "" & vbCrLf & "Final:"
        Label2.Text = "Filtar por" & vbCrLf & "  fechas:"

        Panel1.Size = New Size(361, 94)
        TextBox1.Size = New Size(192, 32)

        PaDGVnota.Location = New Point(12, 103)
        PaDGVnota.Size = New Size(361, 272)

        Panel3.Location = New Point(12, 381)
        Panel3.Size = New Size(361, 47)
        Button1.Location = New Point(3, 3)
        Button2.Location = New Point(235, 3)


        PaDato.Location = New Point(379, 12)
        TbCuerpo.Size = New Size(433, 335)

        BtnCancelar.Location = New Point(589, 398)
        BtnGuardar.Location = New Point(717, 398)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Buscar()
    End Sub

    Private Sub Buscar()
        Dim textoBusqueda As String = TextBox1.Text.Trim()
        If textoBusqueda <> "" Then
            Dim query As String = "SELECT IdNota, IdUsuario, FechaNota, Nota, Titulo FROM NotasUsurio WHERE IdUsuario = @IdUsuario AND Titulo LIKE @Titulo"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmd.Parameters.AddWithValue("@Titulo", "%" & textoBusqueda & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVNota.DataSource = table
        Else
            MostrarNotas(IdUsuarioN)
        End If
    End Sub

    Private Sub DtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles DtpInicio.ValueChanged
        BuscarFechas()
    End Sub

    Private Sub DtpFinal_ValueChanged(sender As Object, e As EventArgs) Handles DtpFinal.ValueChanged
        BuscarFechas()
    End Sub

    Private Sub BuscarFechas()
        Dim fechaInicio As DateTime = DtpInicio.Value
        Dim fechaFin As DateTime = DtpFinal.Value
        Try
            con.Open()
            Dim query As String = "SELECT IdNota, IdUsuario, FechaNota, Nota, Titulo FROM NotasUsurio WHERE IdUsuario = @IdUsuario AND FechaNota BETWEEN @FechaInicio AND @FechaFin"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
            cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            cmd.Parameters.AddWithValue("@FechaFin", fechaFin)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGVNota.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al cargar las notas: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub



End Class