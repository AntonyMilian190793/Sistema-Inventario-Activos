Imports System.Data.SqlClient

Public Class frmBusquedaEmpleados

    Private Sub frmBusquedaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Telefono, Empleados.Correo, Empleados.Genero, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto"

        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvEmpleados.DataSource = tabla

            lblTotalEmpleado.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error" + ex.ToString + "Sistema Inventario")
        End Try
    End Sub

    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Telefono, Empleados.Correo, Empleados.Genero, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleado.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If
        If rbIdentidad.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Telefono, Empleados.Correo, Empleados.Genero, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Empleados.Identidad LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleado.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If
        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Telefono, Empleados.Correo, Empleados.Genero, Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleado.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        On Error Resume Next
        frmCargoActivos.txtIdEmpleado.Text = CStr(dgvEmpleados.Item("IdEmpleado", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtNombreE.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtIdentidad.Text = CStr(dgvEmpleados.Item("Identidad", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtDepartamento.Text = CStr(dgvEmpleados.Item("NombreD", dgvEmpleados.CurrentCell.RowIndex).Value)
        Me.Close()
    End Sub
End Class