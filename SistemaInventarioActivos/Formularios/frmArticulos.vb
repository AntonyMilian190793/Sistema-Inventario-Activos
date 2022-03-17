Imports System.Data.SqlClient

Public Class frmArticulos

    Private tabla_marcas As New DataTable

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        LlenarDatos()
        Mostrar_Marcas()
        cboMarca.SelectedIndex = -1
        dgvArticulos.AutoGenerateColumns = False

        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Format = "N2"
    End Sub

    Sub DesactivarControles()

        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnMarcas.Enabled = False

        txtNombreA.Enabled = False
        txtCodigo.Enabled = False
        txtSerie.Enabled = False
        txtModelo.Enabled = False
        cboMarca.Enabled = False
        DTPFechaCompra.Enabled = False
        txtPrecio.Enabled = False
        txtDescripcion.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControles()

        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnMarcas.Enabled = True

        txtNombreA.Enabled = True
        txtCodigo.Enabled = True
        txtSerie.Enabled = True
        txtModelo.Enabled = True
        cboMarca.Enabled = True
        DTPFechaCompra.Enabled = True
        txtPrecio.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()

        txtNombreA.Text = ""
        txtCodigo.Text = ""
        txtSerie.Text = ""
        txtModelo.Text = ""
        cboMarca.Text = ""
        DTPFechaCompra.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub insertar()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar Nuevo Regisro", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Articulos WHERE CodigoA = '" & txtCodigo.Text & "'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            txtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("El registro ya existe en la base de Datos", vbInformation, "Sistena Inventario")
            Exit Sub

        End If

        If txtNombreA.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Existen campos vacíos", vbInformation, "Sistena Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Articulos(NombreA, NumeroSerie, CodigoA, IdMarca, Modelo, PrecioCompra, FechaCompra, EstadoArticulo, Descripcion) VALUES ('" & txtNombreA.Text & "', '" & txtSerie.Text & "', '" & txtCodigo.Text & "', '" & Trim(cboMarca.SelectedValue) & "', '" & txtModelo.Text &
                "', '" & txtPrecio.Text & "', '" & DTPFechaCompra.Text & "', 'PENDIENTE', '" & txtDescripcion.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar
            End Using
            conect.Close()
            MsgBox("Registro realizado Exitosamente", vbInformation, "Sistena Inventario")
        End If

    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT Articulos.IdArticulo, Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo, Articulos.PrecioCompra, Articulos.FechaCompra, Articulos.EstadoArticulo, Articulos.Descripcion FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE Articulos.EstadoArticulo = 'PENDIENTE'"

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvArticulos.DataSource = tabla

            lblTotalArticulos.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try
    End Sub

    Sub BuscarDatos()
        If rbNombreArticulo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo, Articulos.PrecioCompra, Articulos.FechaCompra, Articulos.EstadoArticulo, Articulos.Descripcion FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE Articulos.NombreA LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'", obtenerconexion)

            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If
        End If
        If rbCodigoA.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo, Articulos.PrecioCompra, Articulos.FechaCompra, Articulos.EstadoArticulo, Articulos.Descripcion FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE Articulos.CodigoA LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If
        End If
        If rbMarca.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo, Articulos.PrecioCompra, Articulos.FechaCompra, Articulos.EstadoArticulo, Articulos.Descripcion FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE Marcas.NombreM LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'|", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If
        End If
    End Sub

    Sub editar()
        Dim id As Integer

        If txtId.Text = "" Then
            MsgBox("Existen campos Vacios", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Articulos SET NombreA = '" & txtNombreA.Text & "', NumeroSerie = '" & txtSerie.Text &
                "', CodigoA = '" & txtCodigo.Text & "', IdMarca = '" & Trim(cboMarca.SelectedValue) &
                "', Modelo = '" & txtModelo.Text & "', PrecioCompra = '" & txtPrecio.Text &
                "', FechaCompra = '" & DTPFechaCompra.Text &
                "', Descripcion = '" & txtDescripcion.Text &
                "' WHERE IdArticulo = '" & txtId.Text & "'"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro editado exitosamente", vbInformation, "Sistema de Inventario")
            LimpiarControles()
        End If
    End Sub

    Sub eliminar()
        Dim id As Integer

        If txtId.Text = "" Then
            MsgBox("Existen campos Vacios", vbInformation, "Sistema de Inventario")
        Else
            If MsgBox("Seguro de eliminar a " + Trim(txtNombreA.Text) + " de su registro?", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()
                Exit Sub
            Else
                Dim sql As String
                sql = "DELETE FROM Articulos WHERE IdArticulo = " & Trim(txtId.Text)

                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro eliminado exitosamente", vbInformation, "Sistema de Inventario")
                LimpiarControles()
            End If
        End If
    End Sub

    Public Function Marcas_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdMarca, NombreM FROM  Marcas"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function

    Private Sub Mostrar_Marcas()
        tabla_marcas = Marcas_Listar(True)
        cboMarca.DataSource = tabla_marcas
        cboMarca.DisplayMember = "NombreM"
        cboMarca.ValueMember = "IdMarca"
    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        frmMarcas.ShowDialog()
    End Sub

    Private Sub cboMarca_Click(sender As Object, e As EventArgs) Handles cboMarca.Click
        Mostrar_Marcas()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub rbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoA.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rbMarca.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub dgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvArticulos.Item("IdArticulo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvArticulos.Item("NombreA", dgvArticulos.CurrentCell.RowIndex).Value)
        txtSerie.Text = CStr(dgvArticulos.Item("NumeroSerie", dgvArticulos.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvArticulos.Item("CodigoA", dgvArticulos.CurrentCell.RowIndex).Value)
        cboMarca.Text = CStr(dgvArticulos.Item("NombreM", dgvArticulos.CurrentCell.RowIndex).Value)
        txtModelo.Text = CStr(dgvArticulos.Item("Modelo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvArticulos.Item("PrecioCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        DTPFechaCompra.Text = CStr(dgvArticulos.Item("FechaCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvArticulos.Item("Descripcion", dgvArticulos.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreA.Enabled = True
        txtSerie.Enabled = True
        txtCodigo.Enabled = True
        cboMarca.Enabled = True
        txtModelo.Enabled = True
        txtPrecio.Enabled = True
        DTPFechaCompra.Enabled = True
        txtDescripcion.Enabled = True

        txtNombreA.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
        DesactivarControles()
        LlenarDatos()
    End Sub
End Class