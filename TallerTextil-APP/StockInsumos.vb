Imports System.Data.SqlClient
Imports System.IO

Public Class StockInsumos
    Dim IdUsuarioN As Integer
    Dim ModoOscu As Boolean
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
    Public Sub New(idUsuario As Integer, modoOscuro As Boolean)
        InitializeComponent()
        IdUsuarioN = idUsuario
        ModoOscu = modoOscuro
    End Sub

    Private Sub StockInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visibilidad(False, BtnModiConfi, BtnModiCancelar, BtnNuCrear, BtnNuCancelar)
        Controles(False, TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
        PaEntSal.Location = New Point(603, 100)
        DtpFecha.Value = DateTime.Now
        MostrarStock(IdUsuarioN)
        VerificarStock()
        MostrarTT()
        tema()
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
        FiltrarStockPorCantidad(11, Integer.MaxValue)
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


    Private Sub DGVStock_SelectionChanged(sender As Object, e As EventArgs) Handles DGVStock.SelectionChanged
        If DGVStock.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVStock.SelectedRows(0)
            Dim Id As String = filaSeleccionada.Cells("IdInsumoStock").Value.ToString()
            Dim codigo As String = filaSeleccionada.Cells("CodigoStock").Value.ToString()
            Dim nombre As String = filaSeleccionada.Cells("NombreStock").Value.ToString()
            Dim cantidad As Integer = filaSeleccionada.Cells("CantStock").Value.ToString()
            Dim precio As Decimal = filaSeleccionada.Cells("PrecioUniStock").Value.ToString()
            Dim descripcion As String = filaSeleccionada.Cells("DescripStock").Value.ToString()
            Dim Total As String = cantidad * precio
            Label9.Text = $"Total=  {Total}$"
            Label9.Visible = True
            LaId.Text = Id
            TbNuCodigo.Text = codigo
            TbNuNombre.Text = nombre
            TbNuDescrip.Text = descripcion
            TbNuCant.Text = cantidad
            TbNuPreUni.Text = precio
            'Parte de Entrada y Salida
            TbCodigo.Text = codigo
            TbNombre.Text = nombre
            TbPreUni.Text = precio
            LaCantAnterior.Text = cantidad
            PaDatos.Visible = True
        Else
            PaDatos.Visible = False
        End If
    End Sub


    ' Creando Nuevo Insumo
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        PaDatos.Visible = True
        Label9.Visible = False
        PaBtnES.Visible = False
        LimpiarTextRegistros(TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
        LimpiarTextRegistros(TbCodigo, TbNombre, TbCant, TbPreUni)
        Visibilidad(False, BtnNuevo, BtnEliminar, BtnModificar, BtnModiConfi, BtnModiCancelar, BtnEntrada, BtnSalida)
        Visibilidad(True, BtnNuCrear, BtnNuCancelar)
        Controles(True, TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
        DGVStock.Enabled = False

    End Sub

    Private Sub BtnNuCrear_Click(sender As Object, e As EventArgs) Handles BtnNuCrear.Click
        Dim codigo As String = TbNuCodigo.Text
        Dim nombre As String = TbNuNombre.Text
        Dim descri As String = TbNuDescrip.Text
        Dim cantidad As Integer
        Dim precio As Decimal
        Dim CantAnt As Decimal = 0
        If String.IsNullOrWhiteSpace(codigo) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(TbNuCant.Text) Or String.IsNullOrWhiteSpace(TbNuPreUni.Text) Then
            MessageBox.Show("Por favor complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(TbNuCant.Text, cantidad) OrElse Not Decimal.TryParse(ConvertirPrecio(TbNuPreUni.Text), precio) Then
            MessageBox.Show("Por favor ingrese valores numéricos válidos para cantidad y precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If precio = 0 Then
            MessageBox.Show("Por favor ingrese valor en precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim fecha As Date = DateTime.Now.ToString("dd/MM/yyyy")

        ' Crea el insumo solo si la función de guardar devuelve true
        If GuardarInsumo(codigo, nombre, cantidad, precio, descri, IdUsuarioN) Then
            ' Obtener el ID del insumo recién creado
            Dim insumoID As Integer = ObtenerIdInsumo(codigo, nombre, IdUsuarioN)
            If insumoID <> -1 Then
                ' Pasar el ID del insumo a la función GuardarEntrada
                GuardarEntrada(codigo, nombre, fecha, cantidad, precio, IdUsuarioN, insumoID, CantAnt)
                Controles(False, TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
                Visibilidad(True, BtnNuevo, BtnEliminar, BtnModificar, BtnEntrada, BtnSalida)
                Visibilidad(False, BtnNuCrear, BtnNuCancelar, BtnModiConfi, BtnModiCancelar)
                MostrarStock(IdUsuarioN)
                PaBtnES.Visible = True
                DGVStock.Enabled = True
            End If
        End If
    End Sub

    Function GuardarInsumo(ByVal codigo As String, ByVal nombre As String, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal descri As String, ByVal IDUsuario As Integer) As Boolean
        Try
            Dim fecha As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            Dim query As String = "INSERT INTO StockInsumos (CodigoStock, NombreStock, CantStock, PrecioUniStock, DescripStock, IdUsuario, FechaStock) VALUES (@Codigo, @Nombre, @Cantidad, @Precio, @Descripcion, @IDUsuario, @Fecha)"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario)
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                cmd.Parameters.AddWithValue("@Precio", precio)
                cmd.Parameters.AddWithValue("@Descripcion", descri)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Insumo guardado exitosamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar el artículo: " & ex.Message, "Error de guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Using writer As New StreamWriter("error.log", True)
                writer.WriteLine("Error al guardar el artículo: " & ex.ToString())
            End Using
            Return False
        End Try
    End Function

    Function ObtenerIdInsumo(ByVal codigo As String, ByVal nombre As String, ByVal IDUsuario As Integer) As Integer
        Try
            Dim query As String = "SELECT IdInsumoStock FROM StockInsumos WHERE CodigoStock = @Codigo AND NombreStock = @Nombre AND IdUsuario = @IDUsuario ORDER BY IdInsumoStock DESC"
            Dim idInsumo As Integer = -1

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
            cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario)
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Nombre", nombre)

                idInsumo = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            Return idInsumo
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID del insumo: " & ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Using writer As New StreamWriter("error.log", True)
                writer.WriteLine("Error al obtener el ID del insumo: " & ex.ToString())
            End Using
            Return -1
        End Try
    End Function


    Private Sub BtnNuCancelar_Click(sender As Object, e As EventArgs) Handles BtnNuCancelar.Click
        Visibilidad(True, BtnNuevo, BtnEliminar, BtnModificar, BtnEntrada, BtnSalida)
        PaBtnES.Visible = True
        Visibilidad(False, BtnNuCrear, BtnNuCancelar, BtnModiConfi, BtnModiCancelar)
        Controles(False, TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
        MostrarStock(IdUsuarioN)
        DGVStock.Enabled = True
    End Sub


    ' Modificar el Insumo
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Label9.Visible = False
        PaBtnES.Visible = False
        Visibilidad(False, BtnModificar, BtnEliminar, BtnNuevo, BtnNuCrear, BtnNuCancelar, BtnEntrada, BtnSalida)
        Visibilidad(True, BtnModiConfi, BtnModiCancelar)
        Controles(True, TbNuNombre, TbNuDescrip)
        Controles(False, TbNuCodigo, TbNuCant, TbNuPreUni)
        DGVStock.Enabled = True
    End Sub

    Private Sub BtnModiConfi_Click(sender As Object, e As EventArgs) Handles BtnModiConfi.Click
        Dim codigo As String = TbNuCodigo.Text
        Dim nombre As String = TbNuNombre.Text
        Dim descri As String = TbNuDescrip.Text

        If String.IsNullOrWhiteSpace(codigo) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(TbNuCant.Text) Or String.IsNullOrWhiteSpace(TbNuPreUni.Text) Then
            MessageBox.Show("Por favor complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Actualiza el insumo solo si la función de guardar devuelve true
        If ModificarInsumo(codigo, nombre, descri, IdUsuarioN) Then
            Visibilidad(True, BtnModificar, BtnEliminar, BtnNuevo, BtnEntrada, BtnSalida)
            PaBtnES.Visible = True
            Visibilidad(False, BtnModiConfi, BtnModiCancelar, BtnNuCrear, BtnNuCancelar)
            Controles(False, TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
            MostrarStock(IdUsuarioN)
            DGVStock.Enabled = True
            VerificarStock()
        End If
    End Sub

    Function ModificarInsumo(ByVal codigo As String, ByVal nombre As String, ByVal descri As String, ByVal IDUsuario As Integer) As Boolean
        Try ' CantStock = @Cantidad, PrecioUniStock = @Precio,
            Dim IdInsumo As Integer = LaId.Text
            Dim query As String = "UPDATE StockInsumos SET CodigoStock = @Codigo, NombreStock = @Nombre, DescripStock = @Descrip WHERE IdInsumoStock = @IdInsumo AND IdUsuario = @IdUsuario"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
              cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Codigo", codigo)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Descrip", descri)
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo)
                cmd.Parameters.AddWithValue("@IdUsuario", IDUsuario)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Artículo modificado exitosamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar el artículo: " & ex.Message, "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub BtnModiCancelar_Click(sender As Object, e As EventArgs) Handles BtnModiCancelar.Click
        Visibilidad(True, BtnModificar, BtnEliminar, BtnNuevo, BtnEntrada, BtnSalida)
        PaBtnES.Visible = True
        Visibilidad(False, BtnModiConfi, BtnModiCancelar, BtnNuCrear, BtnNuCancelar)
        Controles(False, TbNuCodigo, TbNuNombre, TbNuDescrip, TbNuCant, TbNuPreUni)
        MostrarStock(IdUsuarioN)
        DGVStock.Enabled = True
    End Sub


    ' Eliminar un Insumo
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DGVStock.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVStock.SelectedRows(0)
            Dim Id As String = filaSeleccionada.Cells("IdInsumoStock").Value.ToString()
            Dim codigo As String = filaSeleccionada.Cells("CodigoStock").Value.ToString()
            Dim nombre As String = filaSeleccionada.Cells("NombreStock").Value.ToString()
            Dim descripcion As String = filaSeleccionada.Cells("DescripStock").Value.ToString()

            Dim confirmacion As DialogResult = MessageBox.Show($"Desea eliminar este Insumo: {codigo}" & vbCrLf & $"Nombre:{nombre}" & vbCrLf & $"Descripción: {descripcion}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.Yes Then
                Dim confirmacion2 As DialogResult = MessageBox.Show($"¿Eliminar {codigo}-{nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmacion2 = DialogResult.Yes Then
                    Dim IdInsumo As Integer = Convert.ToInt32(filaSeleccionada.Cells("IdInsumoStock").Value)
                    EliminarInsumo(IdInsumo)
                    MostrarStock(IdUsuarioN)
                End If
            End If
        Else
            MessageBox.Show("Por favor, seleccione un Stock de Insumo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EliminarInsumo(IdInsumo As Integer)
        Try
            Dim query As String = "DELETE FROM StockInsumos WHERE IdInsumoStock = @IdInsumo"
            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true"),
                  cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Insumo Eliminado.", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Stock de Insumo: " & ex.Message, "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Buscar por Codigo o Nombre
    Private Sub TbBusCoNo_TextChanged(sender As Object, e As EventArgs) Handles TbBusCoNo.TextChanged
        Buscar()
        Dim texto As String = TbBusCoNo.Text
        If texto <> "" Then
            Button4.Text = "Buscar"
        Else
            Button4.Text = "Todo"
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Buscar()
    End Sub
    Private Function Buscar()
        Dim textoBusqueda As String = TbBusCoNo.Text.Trim()
        If textoBusqueda <> "" Then 'SELECT IdInsumoStock, IdUsuario, CodigoStock, NombreStock, CantStock, PrecioUniStock, DescripStock, CantStock * PrecioUniStock AS Total
            Dim query As String = "SELECT IdInsumoStock, IdUsuario, FechaStock, CodigoStock, NombreStock, CantStock, PrecioUniStock, DescripStock, CantStock * PrecioUniStock AS Total FROM StockInsumos WHERE IdUsuario = @IdUsuario AND (CodigoStock LIKE '%' + @TextoBusqueda + '%' OR NombreStock LIKE '%' + @TextoBusqueda + '%')"
            Using con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda)
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioN)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DGVStock.DataSource = table
                End Using
            End Using
        Else
            MostrarStock(IdUsuarioN)
        End If
    End Function

    ' Entrada de Stock
    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles BtnEntrada.Click
        DGVStock.Enabled = False
        PaDatos.Visible = False
        PaEntSal.Visible = True
        PaBtnES.Visible = False
        Visibilidad(False, BtnNuevo, BtnModificar, BtnEliminar, BtnSalida, BtnEntrada, BtnSalGuardar, BtnSalCancelar)
        Visibilidad(True, BtnEntGuardar, BtnEntCancelar)
        Controles(False, TbCodigo, TbNombre)
        Controles(True, TbCant, TbPreUni, DtpFecha)
        Label14.Text = "Entrada"
        LaFecha.Text = "Fecha de Compra :"
        LaCantidad.Text = "Cantidad Comprada:"
        LaPreUni.Text = "Precio Actual" & vbCrLf & " por Unidad :"
        LimpiarTextRegistros(TbCant, TbPreUni)
    End Sub

    Private Sub BtnEntGuardar_Click(sender As Object, e As EventArgs) Handles BtnEntGuardar.Click
        Dim id As Integer = Integer.Parse(LaId.Text)
        Dim CantAnt As Integer = Integer.Parse(LaCantAnterior.Text)
        Dim codigo As String = TbCodigo.Text
        Dim nombre As String = TbNombre.Text
        Dim fecha As Date = DtpFecha.Value
        Dim cantidad As Integer
        Dim precio As Decimal
        If Not Integer.TryParse(TbCant.Text, cantidad) OrElse Not Decimal.TryParse(ConvertirPrecio(TbPreUni.Text), precio) Then
            MessageBox.Show("Por favor ingrese valores numéricos válidos para cantidad y precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If precio = 0 Then
            MessageBox.Show("Por favor ingrese valor en precio.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Crea La Entrada solo si la función de guardar devuelve true
        If GuardarEntrada(codigo, nombre, fecha, cantidad, precio, IdUsuarioN, id, CantAnt) Then
            MessageBox.Show("Insumo actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PaDatos.Visible = True
            PaEntSal.Visible = False
            Visibilidad(True, BtnNuevo, BtnModificar, BtnEliminar, BtnSalida, BtnEntrada, BtnSalGuardar, BtnSalCancelar)
            Visibilidad(False, BtnEntGuardar, BtnEntCancelar)
            MostrarStock(IdUsuarioN)
            PaBtnES.Visible = True
            DGVStock.Enabled = True
        End If

    End Sub

    Function GuardarEntrada(ByVal codigo As String, ByVal nombre As String, ByVal fecha As Date, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal IDUsuario As Integer, ByVal idInsumo As Integer, ByVal CantAnt As Integer) As Boolean
        Try
            Dim NuevaCant As Integer = CantAnt + cantidad

            ' Consulta combinada para Insertar y Actualizar
            Dim query As String = "BEGIN TRANSACTION; BEGIN TRY INSERT INTO EntradaInsumos (IdUsuario, FechaInsEnt, CodigoInsEnt, NombreInsEnt, CantInsEnt, PrecioUniInsEnt, IdInsumo) VALUES (@IDUsuario, @Fecha , @Codigo, @Nombre, @Cantidad, @Precio, @Idinsumo); UPDATE StockInsumos SET CantStock = @NuevaCantidad, PrecioUniStock = @Precio, FechaStock = @Fecha WHERE IdInsumoStock = @Idinsumo AND IdUsuario = @IDUsuario; COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION;THROW; END CATCH"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario)
                    cmd.Parameters.AddWithValue("@Codigo", codigo)
                    cmd.Parameters.AddWithValue("@Nombre", nombre)
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@Precio", precio)
                    cmd.Parameters.AddWithValue("@Fecha", fecha)
                    cmd.Parameters.AddWithValue("@Idinsumo", idInsumo)
                    cmd.Parameters.AddWithValue("@NuevaCantidad", NuevaCant)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el stock: " & ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub BtnEntCancelar_Click(sender As Object, e As EventArgs) Handles BtnEntCancelar.Click
        PaDatos.Visible = True
        PaEntSal.Visible = False
        PaBtnES.Visible = True
        Visibilidad(True, BtnNuevo, BtnModificar, BtnEliminar, BtnSalida, BtnEntrada, BtnSalGuardar, BtnSalCancelar)
        Visibilidad(False, BtnEntGuardar, BtnEntCancelar)
        MostrarStock(IdUsuarioN)
        DGVStock.Enabled = True
    End Sub

    ' Salida de Stock
    Private Sub BtnSalida_Click(sender As Object, e As EventArgs) Handles BtnSalida.Click
        PaDatos.Visible = False
        PaEntSal.Visible = True
        DGVStock.Enabled = False
        PaBtnES.Visible = False
        Visibilidad(False, BtnNuevo, BtnModificar, BtnEliminar, BtnSalida, BtnEntrada, BtnEntGuardar, BtnEntCancelar)
        Visibilidad(True, BtnSalGuardar, BtnSalCancelar)
        Controles(False, TbCodigo, TbNombre, TbPreUni)
        Controles(True, TbCant, DtpFecha)
        Label14.Text = "Salida"
        LaFecha.Text = "Fecha de Gasto :"
        LaCantidad.Text = "Cantidad Gastada:"
        LaPreUni.Text = "Precio Actual" & vbCrLf & " por Unidad :"
        LimpiarTextRegistros(TbCant)

    End Sub

    Private Sub BtnSalGuardar_Click(sender As Object, e As EventArgs) Handles BtnSalGuardar.Click
        Dim codigo As String = TbCodigo.Text
        Dim nombre As String = TbNombre.Text
        Dim fecha As Date = DtpFecha.Value
        Dim cantidad As Integer
        Dim precio As Decimal = TbPreUni.Text
        Dim cantactu As Integer = Integer.Parse(LaCantAnterior.Text)

        If Not Integer.TryParse(TbCant.Text, cantidad) Then
            MessageBox.Show("Por favor ingrese la cantidad.", "Error de Valor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim resultado As Integer = cantactu - cantidad
        If resultado < 0 Then
            MessageBox.Show("No hay stock suficiente.", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf resultado = 0 Then
            MessageBox.Show("Te quedaste sin stock.", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf resultado < 10 Then
            MessageBox.Show("Te queda poco stock.", "Poco Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Crea La Entrada solo si la función de guardar devuelve true
        If GuardarSalida(codigo, nombre, fecha, cantidad, precio, IdUsuarioN) Then
            PaDatos.Visible = True
            PaEntSal.Visible = False
            Visibilidad(True, BtnNuevo, BtnModificar, BtnEliminar, BtnSalida, BtnEntrada, BtnEntGuardar, BtnEntCancelar)
            Visibilidad(False, BtnSalGuardar, BtnSalCancelar)
            MostrarStock(IdUsuarioN)
            DGVStock.Enabled = True
            PaBtnES.Visible = True
            VerificarStock()
        End If
    End Sub

    Function GuardarSalida(ByVal codigo As String, ByVal nombre As String, ByVal fecha As Date, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal IDUsuario As Integer) As Boolean
        Try
            Dim id As Integer = Integer.Parse(LaId.Text)
            Dim CantAnt As Integer = Integer.Parse(LaCantAnterior.Text)
            Dim NuevaCant As Integer = CantAnt - cantidad

            ' Consulta combinada para Insertar y Actualizar
            Dim query As String = "BEGIN TRANSACTION; BEGIN TRY INSERT INTO SalidaInsumos (IdUsuario, FechaInsSal, CodigoInsSal, NombreInsSal, CantInsSal, PrecioUniInsSal, IdInsumo) VALUES (@IDUsuario, @Fecha , @Codigo, @Nombre, @Cantidad, @Precio, @Idinsumo); UPDATE StockInsumos SET CantStock = @NuevaCantidad, PrecioUniStock = @Precio, FechaStock = @Fecha WHERE IdInsumoStock = @Idinsumo AND IdUsuario = @IDUsuario; COMMIT TRANSACTION; END TRY BEGIN CATCH ROLLBACK TRANSACTION;THROW; END CATCH"

            Using conn As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=TallerTextil; integrated security=true")
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario)
                    cmd.Parameters.AddWithValue("@Codigo", codigo)
                    cmd.Parameters.AddWithValue("@Nombre", nombre)
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@Precio", precio)
                    cmd.Parameters.AddWithValue("@Fecha", fecha)
                    cmd.Parameters.AddWithValue("@Idinsumo", id)
                    cmd.Parameters.AddWithValue("@NuevaCantidad", NuevaCant)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Insumo actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el stock: " & ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub BtnSalCancelar_Click(sender As Object, e As EventArgs) Handles BtnSalCancelar.Click
        PaDatos.Visible = True
        PaEntSal.Visible = False
        PaBtnES.Visible = True
        Visibilidad(True, BtnNuevo, BtnModificar, BtnEliminar, BtnSalida, BtnEntrada, BtnEntGuardar, BtnEntCancelar)
        Visibilidad(False, BtnSalGuardar, BtnSalCancelar)
        MostrarStock(IdUsuarioN)
        DGVStock.Enabled = True
    End Sub

    Sub MostrarTT()
        Dim C As Decimal
        Dim P As Decimal

        Dim isCValid As Boolean = True
        Dim isPValid As Boolean = True

        ' Intentar convertir C y P a valor decimal
        Try
            P = ConvertirPrecio(TbPreUni.Text)
        Catch ex As Exception
            isPValid = False
        End Try

        Try
            C = ConvertirPrecio(TbCant.Text)
        Catch ex As Exception
            isCValid = False
        End Try


        ' Si alguno de los valores no es válido, ocultar el Label y salir de la función
        If Not isCValid OrElse Not isPValid Then
            Label10.Visible = False
            Return
        End If

        ' Calcular el total
        Dim total As Decimal = C * P

        ' Mostrar el resultado si el total es diferente de cero
        If total = 0 Then
            Label10.Visible = False
        Else
            Label10.Visible = True
            Label10.Text = $"Total = {total}$"
        End If

    End Sub

    Private Sub TbCant_TextChanged(sender As Object, e As EventArgs) Handles TbCant.TextChanged
        MostrarTT()
    End Sub

    Private Sub TbPreUni_TextChanged(sender As Object, e As EventArgs) Handles TbPreUni.TextChanged
        MostrarTT()
    End Sub


    'Diseño de Tema Claro o Oscuro
    Public Sub Tema()
        If ModoTema() = True Then
            Oscuro()
        Else
            Claro()
        End If
    End Sub
    Public Sub Oscuro()
        Me.BackgroundImage = My.Resources.FondoClaro
        Me.BackgroundImageLayout = ImageLayout.Stretch
        'Color General de los controles de Formulario
        CambiarColoresFormu(Me, Color.White, Color.FromArgb(30, 30, 30))
        CambiarBackColor(Color.Transparent, BtnAR, BtnAN, BtnAA)
        CambiarBackColor(Color.FromArgb(170, Color.Black), Aok)
        'Color del Panel:
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaDatos)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaEntSal)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaBuscarText)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaAlertas)
        CambiarColorPanel(Color.FromArgb(170, Color.Black), PaBtnES)

        ConfigurarDataG(DGVStock, Color.White, Color.Black, Color.FromArgb(20, 20, 255), Color.White, Color.Black)

        BtnNuevo.Image = My.Resources.CrearOscu
        BtnEliminar.Image = My.Resources.EliminarOscu
        BtnModificar.Image = My.Resources.EditOscu
        BtnModificar.Image = My.Resources.EditOscu
        BtnEntrada.Image = My.Resources.agregarOscu
        BtnSalida.Image = My.Resources.quitarOscu

        Aok.Image = My.Resources.okOscu

    End Sub

    Public Sub Claro()
        Me.BackgroundImage = My.Resources.FondoOscuro
        Me.BackgroundImageLayout = ImageLayout.Stretch
        'Color General de los controles de Formulario
        CambiarColoresFormu(Me, Color.Black, Color.White)
        CambiarBackColor(Color.Transparent, BtnAR, BtnAN, BtnAA)
        CambiarBackColor(Color.FromArgb(170, Color.White), Aok)
        'Color del Panel:
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaDatos)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaEntSal)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaBuscarText)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaAlertas)
        CambiarColorPanel(Color.FromArgb(170, Color.White), PaBtnES)

        ConfigurarDataG(DGVStock, Color.Black, Color.White, Color.Blue, Color.White, Color.White)

        BtnNuevo.Image = My.Resources.CrearClaro
        BtnEliminar.Image = My.Resources.EliminarClaro
        BtnModificar.Image = My.Resources.EditClaro
        BtnEntrada.Image = My.Resources.agregarClaro
        BtnSalida.Image = My.Resources.quitarClaro

        Aok.Image = My.Resources.okClaro

    End Sub


End Class