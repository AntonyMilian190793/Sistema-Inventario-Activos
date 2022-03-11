<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuestosTrabajo
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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalPuestos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvPuestos = New System.Windows.Forms.DataGridView()
        Me.IdPuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcionP = New System.Windows.Forms.TextBox()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(232, -32)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 34
        Me.txtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotalPuestos)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.label6)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvPuestos)
        Me.Panel1.Location = New System.Drawing.Point(32, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 312)
        Me.Panel1.TabIndex = 33
        '
        'lblTotalPuestos
        '
        Me.lblTotalPuestos.AutoSize = True
        Me.lblTotalPuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPuestos.Location = New System.Drawing.Point(109, 288)
        Me.lblTotalPuestos.Name = "lblTotalPuestos"
        Me.lblTotalPuestos.Size = New System.Drawing.Size(46, 18)
        Me.lblTotalPuestos.TabIndex = 4
        Me.lblTotalPuestos.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Registros:"
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
        'dgvPuestos
        '
        Me.dgvPuestos.AllowUserToAddRows = False
        Me.dgvPuestos.AllowUserToDeleteRows = False
        Me.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPuesto, Me.NombreP, Me.DescripcionP})
        Me.dgvPuestos.Location = New System.Drawing.Point(17, 84)
        Me.dgvPuestos.Name = "dgvPuestos"
        Me.dgvPuestos.ReadOnly = True
        Me.dgvPuestos.RowHeadersVisible = False
        Me.dgvPuestos.RowTemplate.Height = 24
        Me.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPuestos.Size = New System.Drawing.Size(552, 201)
        Me.dgvPuestos.TabIndex = 0
        '
        'IdPuesto
        '
        Me.IdPuesto.DataPropertyName = "IdPuesto"
        Me.IdPuesto.HeaderText = "ID"
        Me.IdPuesto.Name = "IdPuesto"
        Me.IdPuesto.ReadOnly = True
        Me.IdPuesto.Visible = False
        Me.IdPuesto.Width = 5
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "NombreP"
        Me.NombreP.HeaderText = "PUESTO DE TRABAJO"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 220
        '
        'DescripcionP
        '
        Me.DescripcionP.DataPropertyName = "DescripcionP"
        Me.DescripcionP.HeaderText = "DESCRIPCION"
        Me.DescripcionP.Name = "DescripcionP"
        Me.DescripcionP.ReadOnly = True
        Me.DescripcionP.Width = 190
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(407, 131)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 49)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(507, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 49)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(507, 76)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 49)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(407, 76)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 49)
        Me.btnEditar.TabIndex = 29
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(507, 21)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 49)
        Me.btnGuardar.TabIndex = 28
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(407, 21)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 49)
        Me.btnNuevo.TabIndex = 27
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Puesto"
        '
        'txtDescripcionP
        '
        Me.txtDescripcionP.Location = New System.Drawing.Point(116, 69)
        Me.txtDescripcionP.Multiline = True
        Me.txtDescripcionP.Name = "txtDescripcionP"
        Me.txtDescripcionP.Size = New System.Drawing.Size(255, 97)
        Me.txtDescripcionP.TabIndex = 24
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(116, 21)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(255, 22)
        Me.txtNombreP.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-6, -4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Visible = False
        '
        'frmPuestosTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 521)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Controls.Add(Me.txtDescripcionP)
        Me.Controls.Add(Me.txtNombreP)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPuestosTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Puestos de Trabajo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalPuestos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvPuestos As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionP As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreP As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IdPuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
