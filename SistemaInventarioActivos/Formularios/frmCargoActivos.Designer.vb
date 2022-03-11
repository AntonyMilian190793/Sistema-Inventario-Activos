<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargoActivos
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
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbMarca = New System.Windows.Forms.RadioButton()
        Me.rbCodigoA = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalArticulos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigoA = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(476, 114)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(235, 22)
        Me.DTPFechaEntrega.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(334, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 17)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Fecha de Entrega"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(115, 69)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(132, 22)
        Me.txtIdentidad.TabIndex = 81
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(253, 30)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(62, 26)
        Me.btn.TabIndex = 80
        Me.btn.Text = "..."
        Me.btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbMarca)
        Me.Panel1.Controls.Add(Me.rbCodigoA)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalArticulos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvArticulos)
        Me.Panel1.Location = New System.Drawing.Point(15, 275)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1196, 341)
        Me.Panel1.TabIndex = 79
        '
        'rbMarca
        '
        Me.rbMarca.AutoSize = True
        Me.rbMarca.Location = New System.Drawing.Point(377, 24)
        Me.rbMarca.Name = "rbMarca"
        Me.rbMarca.Size = New System.Drawing.Size(68, 21)
        Me.rbMarca.TabIndex = 7
        Me.rbMarca.TabStop = True
        Me.rbMarca.Text = "Marca"
        Me.rbMarca.UseVisualStyleBackColor = True
        '
        'rbCodigoA
        '
        Me.rbCodigoA.AutoSize = True
        Me.rbCodigoA.Location = New System.Drawing.Point(247, 24)
        Me.rbCodigoA.Name = "rbCodigoA"
        Me.rbCodigoA.Size = New System.Drawing.Size(124, 21)
        Me.rbCodigoA.TabIndex = 6
        Me.rbCodigoA.Text = "Código Artículo"
        Me.rbCodigoA.UseVisualStyleBackColor = True
        '
        'rbNombreArticulo
        '
        Me.rbNombreArticulo.AutoSize = True
        Me.rbNombreArticulo.Checked = True
        Me.rbNombreArticulo.Location = New System.Drawing.Point(92, 24)
        Me.rbNombreArticulo.Name = "rbNombreArticulo"
        Me.rbNombreArticulo.Size = New System.Drawing.Size(150, 21)
        Me.rbNombreArticulo.TabIndex = 5
        Me.rbNombreArticulo.TabStop = True
        Me.rbNombreArticulo.Text = "Nombre de Artículo"
        Me.rbNombreArticulo.UseVisualStyleBackColor = True
        '
        'lblTotalArticulos
        '
        Me.lblTotalArticulos.AutoSize = True
        Me.lblTotalArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalArticulos.Location = New System.Drawing.Point(194, 311)
        Me.lblTotalArticulos.Name = "lblTotalArticulos"
        Me.lblTotalArticulos.Size = New System.Drawing.Size(46, 18)
        Me.lblTotalArticulos.TabIndex = 4
        Me.lblTotalArticulos.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 311)
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
        Me.txtBuscar.Size = New System.Drawing.Size(622, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.NombreA, Me.NumeroSerie, Me.CodigoA, Me.NombreM, Me.Modelo, Me.PrecioCompra, Me.EstadoArticulo, Me.FechaCompra, Me.Descripcion})
        Me.dgvArticulos.Location = New System.Drawing.Point(17, 84)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.RowTemplate.Height = 24
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(1081, 212)
        Me.dgvArticulos.TabIndex = 0
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "ID"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        Me.IdArticulo.Width = 5
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE DEL ACTIVO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 150
        '
        'NumeroSerie
        '
        Me.NumeroSerie.DataPropertyName = "NumeroSerie"
        Me.NumeroSerie.HeaderText = "NUMERO DE SERIE"
        Me.NumeroSerie.Name = "NumeroSerie"
        Me.NumeroSerie.ReadOnly = True
        Me.NumeroSerie.Width = 150
        '
        'CodigoA
        '
        Me.CodigoA.DataPropertyName = "CodigoA"
        Me.CodigoA.HeaderText = "CODIGO"
        Me.CodigoA.Name = "CodigoA"
        Me.CodigoA.ReadOnly = True
        Me.CodigoA.Width = 60
        '
        'NombreM
        '
        Me.NombreM.DataPropertyName = "NombreM"
        Me.NombreM.HeaderText = "MARCA"
        Me.NombreM.Name = "NombreM"
        Me.NombreM.ReadOnly = True
        Me.NombreM.Width = 80
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "MODELO"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 70
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "PRECIO DE COMPRA"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        '
        'EstadoArticulo
        '
        Me.EstadoArticulo.DataPropertyName = "EstadoArticulo"
        Me.EstadoArticulo.HeaderText = "ESTADO"
        Me.EstadoArticulo.Name = "EstadoArticulo"
        Me.EstadoArticulo.ReadOnly = True
        Me.EstadoArticulo.Visible = False
        Me.EstadoArticulo.Width = 120
        '
        'FechaCompra
        '
        Me.FechaCompra.DataPropertyName = "FechaCompra"
        Me.FechaCompra.HeaderText = "FECHA DE COMPRA"
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 95
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(1017, 137)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 49)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1117, 137)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 49)
        Me.btnCancelar.TabIndex = 77
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1117, 82)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 49)
        Me.btnEliminar.TabIndex = 76
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(1017, 82)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 49)
        Me.btnEditar.TabIndex = 75
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(1117, 27)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 49)
        Me.btnGuardar.TabIndex = 74
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(1017, 27)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 49)
        Me.btnNuevo.TabIndex = 73
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.cboEstado.Location = New System.Drawing.Point(826, 116)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(124, 24)
        Me.cboEstado.TabIndex = 72
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(826, 39)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(124, 22)
        Me.txtPrecio.TabIndex = 71
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(115, 162)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(835, 79)
        Me.txtDescripcion.TabIndex = 70
        '
        'txtCodigoA
        '
        Me.txtCodigoA.Location = New System.Drawing.Point(115, 31)
        Me.txtCodigoA.Name = "txtCodigoA"
        Me.txtCodigoA.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigoA.TabIndex = 69
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(115, 116)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigo.TabIndex = 68
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(476, 37)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(235, 22)
        Me.txtNombreA.TabIndex = 67
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(946, 74)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(43, 22)
        Me.txtIdEmpleado.TabIndex = 66
        Me.txtIdEmpleado.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(737, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 34)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Estado del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(737, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "N°. Identidad"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 34)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Nombre de Artículo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 17)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Nombre Empleado"
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(476, 74)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(235, 22)
        Me.txtNombreE.TabIndex = 86
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(826, 74)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(124, 22)
        Me.txtDepartamento.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(722, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Departamento"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(946, 118)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(43, 22)
        Me.txtId.TabIndex = 90
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(946, 40)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(43, 22)
        Me.txtIdArticulo.TabIndex = 91
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(253, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 26)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 645)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigoA)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCargoActivos"
        Me.Text = "Asignació de Activos a Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTPFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbMarca As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigoA As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombreArticulo As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalArticulos As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents IdArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoA As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreA As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombreE As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
