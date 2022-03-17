Imports System.Data.SqlClient

Public Class frmBusquedaArticulos

    Private Sub frmBusquedaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()

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
            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA, Articulos.NumeroSerie, Articulos.CodigoA, Marcas.NombreM, Articulos.Modelo, Articulos.PrecioCompra, Articulos.FechaCompra, Articulos.EstadoArticulo, Articulos.Descripcion FROM Articulos INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca WHERE Marcas.NombreM LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE'", obtenerconexion)
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub dgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        On Error Resume Next

        frmCargoActivos.txtIdArticulo.Text = CStr(dgvArticulos.Item("IdArticulo", dgvArticulos.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtNombreA.Text = CStr(dgvArticulos.Item("NombreA", dgvArticulos.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtPrecio.Text = CStr(dgvArticulos.Item("PrecioCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtCodigo.Text = CStr(dgvArticulos.Item("CodigoA", dgvArticulos.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class