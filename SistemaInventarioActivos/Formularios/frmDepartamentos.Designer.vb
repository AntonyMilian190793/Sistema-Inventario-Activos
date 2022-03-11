<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentos
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
        Me.txtNombreD = New System.Windows.Forms.TextBox()
        Me.txtDescripcionD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalDepartamentos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.IdDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreD
        '
        Me.txtNombreD.Location = New System.Drawing.Point(136, 48)
        Me.txtNombreD.Name = "txtNombreD"
        Me.txtNombreD.Size = New System.Drawing.Size(255, 22)
        Me.txtNombreD.TabIndex = 0
        '
        'txtDescripcionD
        '
        Me.txtDescripcionD.Location = New System.Drawing.Point(136, 96)
        Me.txtDescripcionD.Multiline = True
        Me.txtDescripcionD.Name = "txtDescripcionD"
        Me.txtDescripcionD.Size = New System.Drawing.Size(255, 97)
        Me.txtDescripcionD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(527, 158)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 49)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(527, 103)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 49)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(427, 103)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 49)
        Me.btnEditar.TabIndex = 17
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(527, 48)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 49)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(427, 48)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 49)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(427, 158)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 49)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotalDepartamentos)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.label6)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvDepartamentos)
        Me.Panel1.Location = New System.Drawing.Point(52, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 312)
        Me.Panel1.TabIndex = 21
        '
        'lblTotalDepartamentos
        '
        Me.lblTotalDepartamentos.AutoSize = True
        Me.lblTotalDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDepartamentos.Location = New System.Drawing.Point(232, 288)
        Me.lblTotalDepartamentos.Name = "lblTotalDepartamentos"
        Me.lblTotalDepartamentos.Size = New System.Drawing.Size(46, 18)
        Me.lblTotalDepartamentos.TabIndex = 4
        Me.lblTotalDepartamentos.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Departamentos Registrados:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(17, 23)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 17)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(125, 23)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(444, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvDepartamentos
        '
        Me.dgvDepartamentos.AllowUserToAddRows = False
        Me.dgvDepartamentos.AllowUserToDeleteRows = False
        Me.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamento, Me.NombreD, Me.DescripcionD})
        Me.dgvDepartamentos.Location = New System.Drawing.Point(17, 84)
        Me.dgvDepartamentos.Name = "dgvDepartamentos"
        Me.dgvDepartamentos.ReadOnly = True
        Me.dgvDepartamentos.RowHeadersVisible = False
        Me.dgvDepartamentos.RowTemplate.Height = 24
        Me.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartamentos.Size = New System.Drawing.Size(552, 201)
        Me.dgvDepartamentos.TabIndex = 0
        '
        'IdDepartamento
        '
        Me.IdDepartamento.DataPropertyName = "IdDepartamento"
        Me.IdDepartamento.HeaderText = "ID"
        Me.IdDepartamento.Name = "IdDepartamento"
        Me.IdDepartamento.ReadOnly = True
        Me.IdDepartamento.Visible = False
        Me.IdDepartamento.Width = 5
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "NOMBRE DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 205
        '
        'DescripcionD
        '
        Me.DescripcionD.DataPropertyName = "DescripcionD"
        Me.DescripcionD.HeaderText = "DESCRIPCION"
        Me.DescripcionD.Name = "DescripcionD"
        Me.DescripcionD.ReadOnly = True
        Me.DescripcionD.Width = 189
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(35, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 22
        Me.txtId.Visible = False
        '
        'frmDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 578)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcionD)
        Me.Controls.Add(Me.txtNombreD)
        Me.MinimizeBox = False
        Me.Name = "frmDepartamentos"
        Me.Text = "Departamentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreD As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalDepartamentos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvDepartamentos As System.Windows.Forms.DataGridView
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents IdDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
