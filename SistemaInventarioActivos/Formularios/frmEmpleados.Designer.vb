<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbIdentidad = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.lblTotalEmpleado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDepartamento = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Género"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Identidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(469, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Puesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(433, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Departamento"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(3, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(72, 22)
        Me.txtId.TabIndex = 8
        Me.txtId.Visible = False
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(112, 38)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(316, 22)
        Me.txtNombreE.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(312, 80)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 22)
        Me.txtTelefono.TabIndex = 10
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(527, 43)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(228, 22)
        Me.txtIdentidad.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(115, 127)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(313, 70)
        Me.txtDireccion.TabIndex = 12
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(527, 82)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(228, 22)
        Me.txtCorreo.TabIndex = 13
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cboGenero.Location = New System.Drawing.Point(112, 80)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(121, 24)
        Me.cboGenero.TabIndex = 14
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(527, 125)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(159, 24)
        Me.cboDepartamento.TabIndex = 15
        '
        'cboPuesto
        '
        Me.cboPuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Location = New System.Drawing.Point(527, 173)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(159, 24)
        Me.cboPuesto.TabIndex = 16
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(810, 155)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 49)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(910, 155)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 49)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(910, 100)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 49)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(810, 100)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 49)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(910, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 49)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(810, 45)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 49)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbIdentidad)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.lblTotalEmpleado)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvEmpleados)
        Me.Panel1.Location = New System.Drawing.Point(51, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 324)
        Me.Panel1.TabIndex = 27
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(341, 24)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(119, 21)
        Me.rbDepartamento.TabIndex = 7
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbIdentidad
        '
        Me.rbIdentidad.AutoSize = True
        Me.rbIdentidad.Location = New System.Drawing.Point(247, 24)
        Me.rbIdentidad.Name = "rbIdentidad"
        Me.rbIdentidad.Size = New System.Drawing.Size(87, 21)
        Me.rbIdentidad.TabIndex = 6
        Me.rbIdentidad.Text = "Identidad"
        Me.rbIdentidad.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.Checked = True
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(92, 24)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(138, 21)
        Me.rbNombreEmpleado.TabIndex = 5
        Me.rbNombreEmpleado.TabStop = True
        Me.rbNombreEmpleado.Text = "Nombre Empledo"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = True
        '
        'lblTotalEmpleado
        '
        Me.lblTotalEmpleado.AutoSize = True
        Me.lblTotalEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmpleado.Location = New System.Drawing.Point(188, 288)
        Me.lblTotalEmpleado.Name = "lblTotalEmpleado"
        Me.lblTotalEmpleado.Size = New System.Drawing.Size(46, 18)
        Me.lblTotalEmpleado.TabIndex = 4
        Me.lblTotalEmpleado.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Empleados Registrados:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Buscar Por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(476, 23)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(499, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleado, Me.Nombre, Me.Identidad, Me.Genero, Me.Telefono, Me.Correo, Me.NombreD, Me.NombreP, Me.Direccion})
        Me.dgvEmpleados.Location = New System.Drawing.Point(17, 84)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.RowTemplate.Height = 24
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(958, 201)
        Me.dgvEmpleados.TabIndex = 0
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "ID"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        Me.IdEmpleado.Width = 5
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE COMPLETO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 120
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "IDENTIDAD"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        Me.Identidad.Width = 80
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "GENERO"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Width = 60
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "TELEFONO"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 80
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "CORREO"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Width = 130
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "NombreP"
        Me.NombreP.HeaderText = "PUESTO DE TRABAJO"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 120
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 95
        '
        'btnDepartamento
        '
        Me.btnDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartamento.Location = New System.Drawing.Point(693, 122)
        Me.btnDepartamento.Name = "btnDepartamento"
        Me.btnDepartamento.Size = New System.Drawing.Size(62, 32)
        Me.btnDepartamento.TabIndex = 28
        Me.btnDepartamento.Text = "..."
        Me.btnDepartamento.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(693, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 30)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 582)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDepartamento)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboPuesto)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.cboGenero)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmpleados"
        Me.Text = "Registro de Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreE As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents cboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cboPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalEmpleado As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents IdEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbIdentidad As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombreEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents btnDepartamento As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
