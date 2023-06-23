<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Persona
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Persona))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PANTALLA = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTN_Eliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.pct_picture = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_Salir = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Registrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nace_nacimiento = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nmb_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.tpn_telefono = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_nombreCompleto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_identificacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_Buscar = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_Buscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MENU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_Limpiar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PANTALLA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pct_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(154, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de información"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ErrorImage = CType(resources.GetObject("Guna2PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(122, 72)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'PANTALLA
        '
        Me.PANTALLA.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.PANTALLA.Controls.Add(Me.TabPage1)
        Me.PANTALLA.Controls.Add(Me.TabPage2)
        Me.PANTALLA.Controls.Add(Me.TabPage3)
        Me.PANTALLA.ItemSize = New System.Drawing.Size(180, 40)
        Me.PANTALLA.Location = New System.Drawing.Point(26, 90)
        Me.PANTALLA.Name = "PANTALLA"
        Me.PANTALLA.SelectedIndex = 0
        Me.PANTALLA.Size = New System.Drawing.Size(804, 348)
        Me.PANTALLA.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.PANTALLA.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PANTALLA.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.PANTALLA.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.PANTALLA.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PANTALLA.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.PANTALLA.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.PANTALLA.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.PANTALLA.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PANTALLA.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.PANTALLA.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.PANTALLA.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PANTALLA.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.PANTALLA.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.PANTALLA.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PANTALLA.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.PANTALLA.TabIndex = 2
        Me.PANTALLA.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTN_Limpiar)
        Me.TabPage1.Controls.Add(Me.BTN_Eliminar)
        Me.TabPage1.Controls.Add(Me.pct_picture)
        Me.TabPage1.Controls.Add(Me.BTN_Salir)
        Me.TabPage1.Controls.Add(Me.BTN_Registrar)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.nace_nacimiento)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.nmb_telefono)
        Me.TabPage1.Controls.Add(Me.tpn_telefono)
        Me.TabPage1.Controls.Add(Me.txt_nombreCompleto)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_identificacion)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 340)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.BorderRadius = 20
        Me.BTN_Eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Eliminar.ForeColor = System.Drawing.Color.White
        Me.BTN_Eliminar.Image = CType(resources.GetObject("BTN_Eliminar.Image"), System.Drawing.Image)
        Me.BTN_Eliminar.ImageSize = New System.Drawing.Size(26, 26)
        Me.BTN_Eliminar.Location = New System.Drawing.Point(6, 277)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(119, 45)
        Me.BTN_Eliminar.TabIndex = 14
        Me.BTN_Eliminar.Text = "Eliminar"
        '
        'pct_picture
        '
        Me.pct_picture.ErrorImage = CType(resources.GetObject("pct_picture.ErrorImage"), System.Drawing.Image)
        Me.pct_picture.Image = CType(resources.GetObject("pct_picture.Image"), System.Drawing.Image)
        Me.pct_picture.ImageRotate = 0!
        Me.pct_picture.InitialImage = CType(resources.GetObject("pct_picture.InitialImage"), System.Drawing.Image)
        Me.pct_picture.Location = New System.Drawing.Point(378, 25)
        Me.pct_picture.Name = "pct_picture"
        Me.pct_picture.Size = New System.Drawing.Size(185, 178)
        Me.pct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_picture.TabIndex = 13
        Me.pct_picture.TabStop = False
        Me.pct_picture.Tag = ""
        '
        'BTN_Salir
        '
        Me.BTN_Salir.BorderRadius = 20
        Me.BTN_Salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Salir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Salir.ForeColor = System.Drawing.Color.White
        Me.BTN_Salir.Image = CType(resources.GetObject("BTN_Salir.Image"), System.Drawing.Image)
        Me.BTN_Salir.Location = New System.Drawing.Point(455, 277)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(146, 45)
        Me.BTN_Salir.TabIndex = 12
        Me.BTN_Salir.Text = "Salir"
        '
        'BTN_Registrar
        '
        Me.BTN_Registrar.BorderRadius = 20
        Me.BTN_Registrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Registrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Registrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Registrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Registrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Registrar.ForeColor = System.Drawing.Color.White
        Me.BTN_Registrar.Image = CType(resources.GetObject("BTN_Registrar.Image"), System.Drawing.Image)
        Me.BTN_Registrar.Location = New System.Drawing.Point(305, 277)
        Me.BTN_Registrar.Name = "BTN_Registrar"
        Me.BTN_Registrar.Size = New System.Drawing.Size(144, 45)
        Me.BTN_Registrar.TabIndex = 11
        Me.BTN_Registrar.Text = "Registrar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nacimiento"
        '
        'nace_nacimiento
        '
        Me.nace_nacimiento.BorderRadius = 20
        Me.nace_nacimiento.Checked = True
        Me.nace_nacimiento.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.nace_nacimiento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nace_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.nace_nacimiento.Location = New System.Drawing.Point(136, 218)
        Me.nace_nacimiento.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.nace_nacimiento.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.nace_nacimiento.Name = "nace_nacimiento"
        Me.nace_nacimiento.Size = New System.Drawing.Size(200, 36)
        Me.nace_nacimiento.TabIndex = 9
        Me.nace_nacimiento.Value = New Date(2023, 5, 26, 21, 16, 12, 63)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teléfono"
        '
        'nmb_telefono
        '
        Me.nmb_telefono.Location = New System.Drawing.Point(136, 169)
        Me.nmb_telefono.Mask = "9999-9999"
        Me.nmb_telefono.Name = "nmb_telefono"
        Me.nmb_telefono.Size = New System.Drawing.Size(100, 20)
        Me.nmb_telefono.TabIndex = 7
        '
        'tpn_telefono
        '
        Me.tpn_telefono.BackColor = System.Drawing.Color.Transparent
        Me.tpn_telefono.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tpn_telefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tpn_telefono.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpn_telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpn_telefono.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tpn_telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tpn_telefono.ItemHeight = 30
        Me.tpn_telefono.Items.AddRange(New Object() {"Móvil ", "Fijo"})
        Me.tpn_telefono.Location = New System.Drawing.Point(136, 112)
        Me.tpn_telefono.Name = "tpn_telefono"
        Me.tpn_telefono.Size = New System.Drawing.Size(140, 36)
        Me.tpn_telefono.TabIndex = 6
        '
        'txt_nombreCompleto
        '
        Me.txt_nombreCompleto.BorderRadius = 18
        Me.txt_nombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nombreCompleto.DefaultText = ""
        Me.txt_nombreCompleto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nombreCompleto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nombreCompleto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nombreCompleto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nombreCompleto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nombreCompleto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nombreCompleto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nombreCompleto.Location = New System.Drawing.Point(136, 65)
        Me.txt_nombreCompleto.Name = "txt_nombreCompleto"
        Me.txt_nombreCompleto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombreCompleto.PlaceholderText = "Digite el nombre completo"
        Me.txt_nombreCompleto.SelectedText = ""
        Me.txt_nombreCompleto.Size = New System.Drawing.Size(199, 32)
        Me.txt_nombreCompleto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo teléfono"
        '
        'txt_identificacion
        '
        Me.txt_identificacion.BorderRadius = 18
        Me.txt_identificacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_identificacion.DefaultText = ""
        Me.txt_identificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_identificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_identificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_identificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_identificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_identificacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_identificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_identificacion.Location = New System.Drawing.Point(136, 16)
        Me.txt_identificacion.Name = "txt_identificacion"
        Me.txt_identificacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_identificacion.PlaceholderText = "Digite la identificación"
        Me.txt_identificacion.SelectedText = ""
        Me.txt_identificacion.Size = New System.Drawing.Size(199, 32)
        Me.txt_identificacion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identificación"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.L)
        Me.TabPage2.Controls.Add(Me.BTN_Buscar)
        Me.TabPage2.Controls.Add(Me.TXT_Buscar)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 340)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Busqueda"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(37, 72)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(520, 253)
        Me.L.TabIndex = 13
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Identificación"
        Me.ColumnHeader2.Width = 116
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre completo"
        Me.ColumnHeader3.Width = 320
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Teléfono"
        Me.ColumnHeader4.Width = 131
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.BorderRadius = 20
        Me.BTN_Buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Buscar.ForeColor = System.Drawing.Color.White
        Me.BTN_Buscar.Location = New System.Drawing.Point(414, 16)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(108, 35)
        Me.BTN_Buscar.TabIndex = 12
        Me.BTN_Buscar.Text = "Buscar"
        '
        'TXT_Buscar
        '
        Me.TXT_Buscar.BorderRadius = 20
        Me.TXT_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Buscar.DefaultText = ""
        Me.TXT_Buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Buscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Buscar.Location = New System.Drawing.Point(115, 16)
        Me.TXT_Buscar.Name = "TXT_Buscar"
        Me.TXT_Buscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Buscar.PlaceholderText = ""
        Me.TXT_Buscar.SelectedText = ""
        Me.TXT_Buscar.Size = New System.Drawing.Size(278, 36)
        Me.TXT_Buscar.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Guna2Button4)
        Me.TabPage3.Controls.Add(Me.Guna2CheckBox1)
        Me.TabPage3.Controls.Add(Me.Guna2TextBox5)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Guna2TextBox4)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(582, 340)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Credenciales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BorderRadius = 20
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(319, 209)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(144, 45)
        Me.Guna2Button4.TabIndex = 12
        Me.Guna2Button4.Text = "Registrar"
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(420, 163)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.Guna2CheckBox1.TabIndex = 8
        Me.Guna2CheckBox1.Text = "Ver clave"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.BorderRadius = 18
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(203, 154)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = "Digite la clave"
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(199, 32)
        Me.Guna2TextBox5.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(138, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Clave"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(138, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Usuario"
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.BorderRadius = 18
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(203, 116)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = "Digite el usuario"
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(199, 32)
        Me.Guna2TextBox4.TabIndex = 3
        '
        'Abrir
        '
        Me.Abrir.Filter = "Imagenes | *.jpg; *.png; *.jpeg; *.bmp"
        Me.Abrir.Title = "Imagenes disponibles"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU_ELIMINAR})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'MENU_ELIMINAR
        '
        Me.MENU_ELIMINAR.Name = "MENU_ELIMINAR"
        Me.MENU_ELIMINAR.Size = New System.Drawing.Size(117, 22)
        Me.MENU_ELIMINAR.Text = "Eliminar"
        '
        'BTN_Limpiar
        '
        Me.BTN_Limpiar.BorderRadius = 20
        Me.BTN_Limpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Limpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Limpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Limpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Limpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Limpiar.ForeColor = System.Drawing.Color.White
        Me.BTN_Limpiar.Image = CType(resources.GetObject("BTN_Limpiar.Image"), System.Drawing.Image)
        Me.BTN_Limpiar.ImageSize = New System.Drawing.Size(26, 26)
        Me.BTN_Limpiar.Location = New System.Drawing.Point(131, 277)
        Me.BTN_Limpiar.Name = "BTN_Limpiar"
        Me.BTN_Limpiar.Size = New System.Drawing.Size(119, 45)
        Me.BTN_Limpiar.TabIndex = 15
        Me.BTN_Limpiar.Text = "Limpiar"
        '
        'FRM_Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 461)
        Me.Controls.Add(Me.PANTALLA)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FRM_Persona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de personas"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PANTALLA.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pct_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PANTALLA As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_identificacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_nombreCompleto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tpn_telefono As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents nace_nacimiento As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents nmb_telefono As MaskedTextBox
    Friend WithEvents BTN_Salir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Registrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_Buscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pct_picture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents L As ListView
    Friend WithEvents BTN_Buscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Abrir As OpenFileDialog
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MENU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents BTN_Eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Limpiar As Guna.UI2.WinForms.Guna2Button
End Class
