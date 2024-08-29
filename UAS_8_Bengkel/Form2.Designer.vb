<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.JenisJasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBoxNamaPelanggan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2TextBoxPlatNomor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBoxInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2TextBoxTipeMotor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBoxJenisJasa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TextBoxHargaSparepart = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBoxTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ButtonHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CheckBoxSparepart = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2ComboBoxSNamaparepart = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBoxHargaJasa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2TextBoxJumlahSparepart = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ButtonSimpan = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 25
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JenisJasa, Me.Sparepart, Me.Harga, Me.Jumlah, Me.Subtotal, Me.IdSparepart})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(23, 235)
        Me.Guna2DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 28
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(634, 181)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'JenisJasa
        '
        Me.JenisJasa.HeaderText = "Jenis Jasa"
        Me.JenisJasa.MinimumWidth = 6
        Me.JenisJasa.Name = "JenisJasa"
        '
        'Sparepart
        '
        Me.Sparepart.HeaderText = "Sparepart"
        Me.Sparepart.MinimumWidth = 6
        Me.Sparepart.Name = "Sparepart"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 6
        Me.Harga.Name = "Harga"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        '
        'IdSparepart
        '
        Me.IdSparepart.HeaderText = "id sparepart"
        Me.IdSparepart.Name = "IdSparepart"
        Me.IdSparepart.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(309, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pelangan"
        '
        'Guna2TextBoxNamaPelanggan
        '
        Me.Guna2TextBoxNamaPelanggan.Animated = True
        Me.Guna2TextBoxNamaPelanggan.AutoRoundedCorners = True
        Me.Guna2TextBoxNamaPelanggan.BorderRadius = 12
        Me.Guna2TextBoxNamaPelanggan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxNamaPelanggan.DefaultText = ""
        Me.Guna2TextBoxNamaPelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxNamaPelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxNamaPelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxNamaPelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxNamaPelanggan.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxNamaPelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxNamaPelanggan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxNamaPelanggan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxNamaPelanggan.Location = New System.Drawing.Point(23, 98)
        Me.Guna2TextBoxNamaPelanggan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxNamaPelanggan.Name = "Guna2TextBoxNamaPelanggan"
        Me.Guna2TextBoxNamaPelanggan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxNamaPelanggan.PlaceholderText = "Pak Supri"
        Me.Guna2TextBoxNamaPelanggan.SelectedText = ""
        Me.Guna2TextBoxNamaPelanggan.Size = New System.Drawing.Size(155, 26)
        Me.Guna2TextBoxNamaPelanggan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Plat Nomor"
        '
        'Guna2TextBoxPlatNomor
        '
        Me.Guna2TextBoxPlatNomor.Animated = True
        Me.Guna2TextBoxPlatNomor.AutoRoundedCorners = True
        Me.Guna2TextBoxPlatNomor.BorderRadius = 12
        Me.Guna2TextBoxPlatNomor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxPlatNomor.DefaultText = ""
        Me.Guna2TextBoxPlatNomor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxPlatNomor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxPlatNomor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxPlatNomor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxPlatNomor.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxPlatNomor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxPlatNomor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxPlatNomor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxPlatNomor.Location = New System.Drawing.Point(197, 98)
        Me.Guna2TextBoxPlatNomor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxPlatNomor.Name = "Guna2TextBoxPlatNomor"
        Me.Guna2TextBoxPlatNomor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxPlatNomor.PlaceholderText = "L 1234 A"
        Me.Guna2TextBoxPlatNomor.SelectedText = ""
        Me.Guna2TextBoxPlatNomor.Size = New System.Drawing.Size(131, 26)
        Me.Guna2TextBoxPlatNomor.TabIndex = 7
        '
        'Guna2TextBoxInvoice
        '
        Me.Guna2TextBoxInvoice.Animated = True
        Me.Guna2TextBoxInvoice.AutoRoundedCorners = True
        Me.Guna2TextBoxInvoice.BorderRadius = 12
        Me.Guna2TextBoxInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxInvoice.DefaultText = ""
        Me.Guna2TextBoxInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxInvoice.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxInvoice.Location = New System.Drawing.Point(499, 52)
        Me.Guna2TextBoxInvoice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxInvoice.Name = "Guna2TextBoxInvoice"
        Me.Guna2TextBoxInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxInvoice.PlaceholderText = ""
        Me.Guna2TextBoxInvoice.ReadOnly = True
        Me.Guna2TextBoxInvoice.SelectedText = ""
        Me.Guna2TextBoxInvoice.Size = New System.Drawing.Size(158, 26)
        Me.Guna2TextBoxInvoice.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipe Motor"
        '
        'Guna2TextBoxTipeMotor
        '
        Me.Guna2TextBoxTipeMotor.Animated = True
        Me.Guna2TextBoxTipeMotor.AutoRoundedCorners = True
        Me.Guna2TextBoxTipeMotor.BorderRadius = 12
        Me.Guna2TextBoxTipeMotor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxTipeMotor.DefaultText = ""
        Me.Guna2TextBoxTipeMotor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxTipeMotor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxTipeMotor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxTipeMotor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxTipeMotor.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxTipeMotor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxTipeMotor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxTipeMotor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxTipeMotor.Location = New System.Drawing.Point(346, 98)
        Me.Guna2TextBoxTipeMotor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxTipeMotor.Name = "Guna2TextBoxTipeMotor"
        Me.Guna2TextBoxTipeMotor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxTipeMotor.PlaceholderText = "Beat"
        Me.Guna2TextBoxTipeMotor.SelectedText = ""
        Me.Guna2TextBoxTipeMotor.Size = New System.Drawing.Size(128, 26)
        Me.Guna2TextBoxTipeMotor.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jenis Jasa"
        '
        'Guna2TextBoxJenisJasa
        '
        Me.Guna2TextBoxJenisJasa.Animated = True
        Me.Guna2TextBoxJenisJasa.AutoRoundedCorners = True
        Me.Guna2TextBoxJenisJasa.BorderRadius = 12
        Me.Guna2TextBoxJenisJasa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxJenisJasa.DefaultText = ""
        Me.Guna2TextBoxJenisJasa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxJenisJasa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxJenisJasa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxJenisJasa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxJenisJasa.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxJenisJasa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxJenisJasa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxJenisJasa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxJenisJasa.Location = New System.Drawing.Point(23, 150)
        Me.Guna2TextBoxJenisJasa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxJenisJasa.Name = "Guna2TextBoxJenisJasa"
        Me.Guna2TextBoxJenisJasa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxJenisJasa.PlaceholderText = "Ganti Oli"
        Me.Guna2TextBoxJenisJasa.SelectedText = ""
        Me.Guna2TextBoxJenisJasa.Size = New System.Drawing.Size(155, 26)
        Me.Guna2TextBoxJenisJasa.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(194, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Sparepart"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 180)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Harga"
        Me.Label7.Visible = False
        '
        'Guna2TextBoxHargaSparepart
        '
        Me.Guna2TextBoxHargaSparepart.Animated = True
        Me.Guna2TextBoxHargaSparepart.AutoRoundedCorners = True
        Me.Guna2TextBoxHargaSparepart.BorderRadius = 12
        Me.Guna2TextBoxHargaSparepart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxHargaSparepart.DefaultText = ""
        Me.Guna2TextBoxHargaSparepart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxHargaSparepart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxHargaSparepart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxHargaSparepart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxHargaSparepart.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxHargaSparepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxHargaSparepart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxHargaSparepart.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxHargaSparepart.Location = New System.Drawing.Point(346, 204)
        Me.Guna2TextBoxHargaSparepart.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxHargaSparepart.Name = "Guna2TextBoxHargaSparepart"
        Me.Guna2TextBoxHargaSparepart.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxHargaSparepart.PlaceholderText = ""
        Me.Guna2TextBoxHargaSparepart.ReadOnly = True
        Me.Guna2TextBoxHargaSparepart.SelectedText = ""
        Me.Guna2TextBoxHargaSparepart.Size = New System.Drawing.Size(92, 26)
        Me.Guna2TextBoxHargaSparepart.TabIndex = 16
        Me.Guna2TextBoxHargaSparepart.Visible = False
        '
        'Guna2TextBoxTotal
        '
        Me.Guna2TextBoxTotal.Animated = True
        Me.Guna2TextBoxTotal.AutoRoundedCorners = True
        Me.Guna2TextBoxTotal.BorderRadius = 13
        Me.Guna2TextBoxTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxTotal.DefaultText = ""
        Me.Guna2TextBoxTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxTotal.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxTotal.Location = New System.Drawing.Point(516, 431)
        Me.Guna2TextBoxTotal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxTotal.Name = "Guna2TextBoxTotal"
        Me.Guna2TextBoxTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxTotal.PlaceholderText = ""
        Me.Guna2TextBoxTotal.SelectedText = ""
        Me.Guna2TextBoxTotal.Size = New System.Drawing.Size(141, 28)
        Me.Guna2TextBoxTotal.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(439, 444)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total     Rp."
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Button1.BorderRadius = 13
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.IndicateFocus = True
        Me.Guna2Button1.Location = New System.Drawing.Point(523, 98)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(110, 29)
        Me.Guna2Button1.TabIndex = 19
        Me.Guna2Button1.Text = "Tambah"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'Guna2ButtonHapus
        '
        Me.Guna2ButtonHapus.AutoRoundedCorners = True
        Me.Guna2ButtonHapus.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ButtonHapus.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2ButtonHapus.BorderRadius = 13
        Me.Guna2ButtonHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2ButtonHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2ButtonHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2ButtonHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2ButtonHapus.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2ButtonHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2ButtonHapus.ForeColor = System.Drawing.Color.White
        Me.Guna2ButtonHapus.IndicateFocus = True
        Me.Guna2ButtonHapus.Location = New System.Drawing.Point(523, 132)
        Me.Guna2ButtonHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ButtonHapus.Name = "Guna2ButtonHapus"
        Me.Guna2ButtonHapus.Size = New System.Drawing.Size(110, 29)
        Me.Guna2ButtonHapus.TabIndex = 20
        Me.Guna2ButtonHapus.Text = "Hapus"
        Me.Guna2ButtonHapus.UseTransparentBackground = True
        '
        'Guna2CheckBoxSparepart
        '
        Me.Guna2CheckBoxSparepart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBoxSparepart.CheckedState.BorderRadius = 0
        Me.Guna2CheckBoxSparepart.CheckedState.BorderThickness = 0
        Me.Guna2CheckBoxSparepart.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBoxSparepart.Location = New System.Drawing.Point(197, 150)
        Me.Guna2CheckBoxSparepart.Name = "Guna2CheckBoxSparepart"
        Me.Guna2CheckBoxSparepart.Size = New System.Drawing.Size(113, 17)
        Me.Guna2CheckBoxSparepart.TabIndex = 0
        Me.Guna2CheckBoxSparepart.Text = "Ganti Sparepart?"
        Me.Guna2CheckBoxSparepart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBoxSparepart.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBoxSparepart.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBoxSparepart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2ComboBoxSNamaparepart
        '
        Me.Guna2ComboBoxSNamaparepart.AutoRoundedCorners = True
        Me.Guna2ComboBoxSNamaparepart.BackColor = System.Drawing.Color.White
        Me.Guna2ComboBoxSNamaparepart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2ComboBoxSNamaparepart.BorderRadius = 17
        Me.Guna2ComboBoxSNamaparepart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBoxSNamaparepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBoxSNamaparepart.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBoxSNamaparepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBoxSNamaparepart.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBoxSNamaparepart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBoxSNamaparepart.ItemHeight = 30
        Me.Guna2ComboBoxSNamaparepart.Location = New System.Drawing.Point(197, 194)
        Me.Guna2ComboBoxSNamaparepart.Name = "Guna2ComboBoxSNamaparepart"
        Me.Guna2ComboBoxSNamaparepart.Size = New System.Drawing.Size(131, 36)
        Me.Guna2ComboBoxSNamaparepart.TabIndex = 22
        Me.Guna2ComboBoxSNamaparepart.Visible = False
        '
        'Guna2TextBoxHargaJasa
        '
        Me.Guna2TextBoxHargaJasa.Animated = True
        Me.Guna2TextBoxHargaJasa.AutoRoundedCorners = True
        Me.Guna2TextBoxHargaJasa.BorderRadius = 12
        Me.Guna2TextBoxHargaJasa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxHargaJasa.DefaultText = ""
        Me.Guna2TextBoxHargaJasa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxHargaJasa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxHargaJasa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxHargaJasa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxHargaJasa.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxHargaJasa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxHargaJasa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxHargaJasa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxHargaJasa.Location = New System.Drawing.Point(23, 204)
        Me.Guna2TextBoxHargaJasa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxHargaJasa.Name = "Guna2TextBoxHargaJasa"
        Me.Guna2TextBoxHargaJasa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxHargaJasa.PlaceholderText = "0"
        Me.Guna2TextBoxHargaJasa.SelectedText = ""
        Me.Guna2TextBoxHargaJasa.Size = New System.Drawing.Size(155, 26)
        Me.Guna2TextBoxHargaJasa.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 185)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Harga Jasa"
        '
        'Guna2TextBoxJumlahSparepart
        '
        Me.Guna2TextBoxJumlahSparepart.Animated = True
        Me.Guna2TextBoxJumlahSparepart.AutoRoundedCorners = True
        Me.Guna2TextBoxJumlahSparepart.BorderRadius = 12
        Me.Guna2TextBoxJumlahSparepart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBoxJumlahSparepart.DefaultText = ""
        Me.Guna2TextBoxJumlahSparepart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBoxJumlahSparepart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBoxJumlahSparepart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxJumlahSparepart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBoxJumlahSparepart.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBoxJumlahSparepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxJumlahSparepart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBoxJumlahSparepart.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBoxJumlahSparepart.Location = New System.Drawing.Point(453, 204)
        Me.Guna2TextBoxJumlahSparepart.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2TextBoxJumlahSparepart.Name = "Guna2TextBoxJumlahSparepart"
        Me.Guna2TextBoxJumlahSparepart.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBoxJumlahSparepart.PlaceholderText = "0"
        Me.Guna2TextBoxJumlahSparepart.SelectedText = ""
        Me.Guna2TextBoxJumlahSparepart.Size = New System.Drawing.Size(32, 26)
        Me.Guna2TextBoxJumlahSparepart.TabIndex = 26
        Me.Guna2TextBoxJumlahSparepart.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(450, 180)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Jumlah"
        Me.Label10.Visible = False
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Image = Global.UAS_8_Bengkel.My.Resources.Resources.arrow
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(-1, -2)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(55, 40)
        Me.Guna2CircleButton1.TabIndex = 27
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(757, 40)
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2PictureBox1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2ButtonSimpan
        '
        Me.Guna2ButtonSimpan.AutoRoundedCorners = True
        Me.Guna2ButtonSimpan.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ButtonSimpan.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2ButtonSimpan.BorderRadius = 13
        Me.Guna2ButtonSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2ButtonSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2ButtonSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2ButtonSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2ButtonSimpan.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2ButtonSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2ButtonSimpan.ForeColor = System.Drawing.Color.White
        Me.Guna2ButtonSimpan.IndicateFocus = True
        Me.Guna2ButtonSimpan.Location = New System.Drawing.Point(523, 165)
        Me.Guna2ButtonSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ButtonSimpan.Name = "Guna2ButtonSimpan"
        Me.Guna2ButtonSimpan.Size = New System.Drawing.Size(110, 29)
        Me.Guna2ButtonSimpan.TabIndex = 28
        Me.Guna2ButtonSimpan.Text = "Simpan "
        Me.Guna2ButtonSimpan.UseTransparentBackground = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 496)
        Me.Controls.Add(Me.Guna2ButtonSimpan)
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.Guna2TextBoxJumlahSparepart)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Guna2TextBoxHargaJasa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Guna2ComboBoxSNamaparepart)
        Me.Controls.Add(Me.Guna2CheckBoxSparepart)
        Me.Controls.Add(Me.Guna2ButtonHapus)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2TextBoxTotal)
        Me.Controls.Add(Me.Guna2TextBoxHargaSparepart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2TextBoxJenisJasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2TextBoxTipeMotor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2TextBoxInvoice)
        Me.Controls.Add(Me.Guna2TextBoxPlatNomor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2TextBoxNamaPelanggan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBoxPlatNomor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2TextBoxNamaPelanggan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2TextBoxInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBoxHargaSparepart As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2TextBoxJenisJasa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBoxTipeMotor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2TextBoxTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ButtonHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBoxSparepart As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2ComboBoxSNamaparepart As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBoxHargaJasa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2TextBoxJumlahSparepart As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ButtonSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents JenisJasa As DataGridViewTextBoxColumn
    Friend WithEvents Sparepart As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents IdSparepart As DataGridViewTextBoxColumn
End Class
