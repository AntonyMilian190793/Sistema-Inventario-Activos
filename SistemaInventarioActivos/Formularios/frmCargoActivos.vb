Imports System.Data.SqlClient

Public Class frmCargoActivos

    Private Sub frmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        txtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigo.AutoCompleteCustomSource = ObtenerCodigos()
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

    Private Function ObtenerCodigos() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT  CodigoA FROM Articulos", obtenerconexion)
        Dim dt As New DataTable("Articulos")
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
End Class