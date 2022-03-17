Imports System.Data.SqlClient

Public Class frmCargoActivos

    Private Sub frmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        txtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigo.AutoCompleteCustomSource = ObtenerCodigos()

        'Identidad
        txtIdentidad.AutoCompleteMode = AutoCompleteMode.Suggest
        txtIdentidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtIdentidad.AutoCompleteCustomSource = ObtenerIdentidades()

    End Sub

    Sub DesactivarControles()

        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnArticulos.Enabled = False
        btnEmpleados.Enabled = False

        txtCodigo.Enabled = False
        txtNombreA.Enabled = False
        txtPrecio.Enabled = False
        txtIdentidad.Enabled = False
        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False
        txtCodigoInventario.Enabled = False
        DTPFechaEntrega.Enabled = False
        cboEstado.Enabled = False
        txtDescripcion.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()

        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnArticulos.Enabled = True
        btnEmpleados.Enabled = True

        txtCodigo.Enabled = True
        txtNombreA.Enabled = True
        txtPrecio.Enabled = True
        txtIdentidad.Enabled = True
        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True
        txtCodigoInventario.Enabled = True
        DTPFechaEntrega.Enabled = True
        cboEstado.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtCodigo.Text = ""
        txtNombreA.Text = ""
        txtPrecio.Text = ""
        txtIdentidad.Text = ""
        txtNombreE.Text = ""
        txtDepartamento.Text = ""
        txtCodigoInventario.Text = ""
        DTPFechaEntrega.Text = ""
        cboEstado.Text = ""
        txtDescripcion.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""
        txtIdArticulo.Text = ""
        txtIdEmpleado.Text = ""

    End Sub

    Sub insertar()

        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Regisro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM CargoActivos WHERE CodigoInventario = '" & txtCodigoInventario.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            txtCodigoInventario.Text = tabla.Rows(0).Item("CodigoInventrio")
            MsgBox("El registro ya existe en la base de Datos", vbInformation, "Sistena Inventario")
            Exit Sub

        End If

        If txtIdArticulo.Text = "" Or txtIdEmpleado.Text = "" Or txtCodigoInventario.Text = "" Or DTPFechaEntrega.Text = "" Then
            MsgBox("Existen campos vacíos", vbInformation, "Sistena Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO CargoActivos(CodigoInventario, FechaAsignacion, EstadoArticulo, Descripcion, IdArticulo, IdEmpleado) VALUES ('" & txtCodigoInventario.Text & "', '" & DTPFechaEntrega.Text & "', '" & cboEstado.Text & "', '" & txtDescripcion.Text & "', '" & txtIdArticulo.Text & "', '" & txtIdEmpleado.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar
            End Using
            conect.Close()
            ModificarArticulo()
            MsgBox("Registro realizado Exitosamente", vbInformation, "Sistena Inventario")
        End If
    End Sub

    Sub ModificarArticulo()
        Dim id As Integer

            Dim sql As String
        sql = "UPDATE Articulos SET EstadoArticulo = 'ENTREGADO' WHERE IdArticulo = '" & txtIdArticulo.Text & "'"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
    End Sub

    Private Function ObtenerCodigos() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT  CodigoA FROM Articulos WHERE EstadoArticulo = 'PENDIENTE'", obtenerconexion)
        Dim dt As New DataTable("Articulos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos

    End Function

    Private Function ObtenerIdentidades() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT  Identidad FROM Empleados", obtenerconexion)
        Dim dt As New DataTable("Empleados")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos

    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT IdArticulo, NombreA, PrecioCompra FROM Articulos WHERE CodigoA = '" & txtCodigo.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreA.Text = fila("NombreA").ToString
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
            Else
                txtNombreA.Clear()
                txtPrecio.Clear()
                txtCodigo.Focus()

            End If
        End If
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged
        If txtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Departamentos.NombreD FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento WHERE  Identidad = '" & txtIdentidad.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdEmpleado.Text = fila("IdEmpleado").ToString
            Else
                txtNombreE.Clear()
                txtDepartamento.Clear()
                txtIdentidad.Focus()

            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        frmBusquedaArticulos.ShowDialog()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmBusquedaEmpleados.ShowDialog()
    End Sub
End Class