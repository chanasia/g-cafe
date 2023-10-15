<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_rmOrder = New System.Windows.Forms.Button()
        Me.dgv_order = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_manu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_addManu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rd_small = New System.Windows.Forms.RadioButton()
        Me.rd_big = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_shake = New System.Windows.Forms.RadioButton()
        Me.rd_cool = New System.Windows.Forms.RadioButton()
        Me.rd_hot = New System.Windows.Forms.RadioButton()
        Me.btn_deCount = New System.Windows.Forms.Button()
        Me.btn_inCount = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.lb_manu = New System.Windows.Forms.Label()
        Me.lb_bath = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_cafa = New System.Windows.Forms.Button()
        Me.btn_teaGreen = New System.Windows.Forms.Button()
        Me.btn_late = New System.Windows.Forms.Button()
        Me.btn_teaCool = New System.Windows.Forms.Button()
        Me.btn_oLeng = New System.Windows.Forms.Button()
        Me.btn_coco = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crCount_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lb_totalPrice = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.btn_rmOrder)
        Me.Panel1.Controls.Add(Me.dgv_order)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 307)
        Me.Panel1.TabIndex = 0
        '
        'btn_rmOrder
        '
        Me.btn_rmOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rmOrder.Location = New System.Drawing.Point(1076, 224)
        Me.btn_rmOrder.Name = "btn_rmOrder"
        Me.btn_rmOrder.Size = New System.Drawing.Size(158, 57)
        Me.btn_rmOrder.TabIndex = 8
        Me.btn_rmOrder.Text = "ลบเมนู"
        Me.btn_rmOrder.UseVisualStyleBackColor = True
        '
        'dgv_order
        '
        Me.dgv_order.AllowUserToAddRows = False
        Me.dgv_order.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_manu, Me.col_type, Me.col_size, Me.col_count, Me.col_price})
        Me.dgv_order.Location = New System.Drawing.Point(414, 28)
        Me.dgv_order.Name = "dgv_order"
        Me.dgv_order.ReadOnly = True
        Me.dgv_order.RowHeadersWidth = 51
        Me.dgv_order.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_order.Size = New System.Drawing.Size(829, 190)
        Me.dgv_order.TabIndex = 2
        '
        'col_id
        '
        Me.col_id.HeaderText = "ลำดับ"
        Me.col_id.MinimumWidth = 6
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Width = 125
        '
        'col_manu
        '
        Me.col_manu.HeaderText = "รายการ"
        Me.col_manu.MinimumWidth = 6
        Me.col_manu.Name = "col_manu"
        Me.col_manu.ReadOnly = True
        Me.col_manu.Width = 150
        '
        'col_type
        '
        Me.col_type.HeaderText = "ประเภท"
        Me.col_type.MinimumWidth = 6
        Me.col_type.Name = "col_type"
        Me.col_type.ReadOnly = True
        Me.col_type.Width = 125
        '
        'col_size
        '
        Me.col_size.HeaderText = "ขนาด"
        Me.col_size.MinimumWidth = 6
        Me.col_size.Name = "col_size"
        Me.col_size.ReadOnly = True
        Me.col_size.Width = 125
        '
        'col_count
        '
        Me.col_count.HeaderText = "จำนวน"
        Me.col_count.MinimumWidth = 6
        Me.col_count.Name = "col_count"
        Me.col_count.ReadOnly = True
        Me.col_count.Width = 125
        '
        'col_price
        '
        Me.col_price.HeaderText = "ราคา"
        Me.col_price.MinimumWidth = 6
        Me.col_price.Name = "col_price"
        Me.col_price.ReadOnly = True
        Me.col_price.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 97)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "G-Cafe"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.G_Cafe.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(76, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 307)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_addManu)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_deCount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_inCount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_count)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lb_manu)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lb_bath)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_cafa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_teaGreen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_late)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_teaCool)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_oLeng)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_coco)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1277, 587)
        Me.SplitContainer1.SplitterDistance = 383
        Me.SplitContainer1.TabIndex = 1
        '
        'btn_addManu
        '
        Me.btn_addManu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addManu.Location = New System.Drawing.Point(193, 486)
        Me.btn_addManu.Name = "btn_addManu"
        Me.btn_addManu.Size = New System.Drawing.Size(158, 57)
        Me.btn_addManu.TabIndex = 8
        Me.btn_addManu.Text = "เพิ่มเมนู"
        Me.btn_addManu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rd_small)
        Me.GroupBox2.Controls.Add(Me.rd_big)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 123)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ขนาด"
        '
        'rd_small
        '
        Me.rd_small.AutoSize = True
        Me.rd_small.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_small.Enabled = False
        Me.rd_small.Location = New System.Drawing.Point(169, 54)
        Me.rd_small.Name = "rd_small"
        Me.rd_small.Size = New System.Drawing.Size(71, 37)
        Me.rd_small.TabIndex = 0
        Me.rd_small.Text = "เล็ก"
        Me.rd_small.UseVisualStyleBackColor = False
        '
        'rd_big
        '
        Me.rd_big.AutoSize = True
        Me.rd_big.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_big.Enabled = False
        Me.rd_big.Location = New System.Drawing.Point(70, 54)
        Me.rd_big.Name = "rd_big"
        Me.rd_big.Size = New System.Drawing.Size(84, 37)
        Me.rd_big.TabIndex = 0
        Me.rd_big.Text = "ใหญ่"
        Me.rd_big.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_shake)
        Me.GroupBox1.Controls.Add(Me.rd_cool)
        Me.GroupBox1.Controls.Add(Me.rd_hot)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 123)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภท"
        '
        'rd_shake
        '
        Me.rd_shake.AutoSize = True
        Me.rd_shake.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_shake.Enabled = False
        Me.rd_shake.Location = New System.Drawing.Point(202, 56)
        Me.rd_shake.Name = "rd_shake"
        Me.rd_shake.Size = New System.Drawing.Size(68, 37)
        Me.rd_shake.TabIndex = 0
        Me.rd_shake.TabStop = True
        Me.rd_shake.Text = "ปั่น"
        Me.rd_shake.UseVisualStyleBackColor = False
        '
        'rd_cool
        '
        Me.rd_cool.AutoSize = True
        Me.rd_cool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_cool.Enabled = False
        Me.rd_cool.Location = New System.Drawing.Point(122, 56)
        Me.rd_cool.Name = "rd_cool"
        Me.rd_cool.Size = New System.Drawing.Size(74, 37)
        Me.rd_cool.TabIndex = 0
        Me.rd_cool.TabStop = True
        Me.rd_cool.Text = "เย็น"
        Me.rd_cool.UseVisualStyleBackColor = False
        '
        'rd_hot
        '
        Me.rd_hot.AutoSize = True
        Me.rd_hot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_hot.Enabled = False
        Me.rd_hot.Location = New System.Drawing.Point(36, 55)
        Me.rd_hot.Name = "rd_hot"
        Me.rd_hot.Size = New System.Drawing.Size(80, 37)
        Me.rd_hot.TabIndex = 0
        Me.rd_hot.TabStop = True
        Me.rd_hot.Text = "ร้อน"
        Me.rd_hot.UseVisualStyleBackColor = False
        '
        'btn_deCount
        '
        Me.btn_deCount.BackColor = System.Drawing.Color.Transparent
        Me.btn_deCount.BackgroundImage = Global.G_Cafe.My.Resources.Resources.DOWN
        Me.btn_deCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_deCount.Enabled = False
        Me.btn_deCount.Location = New System.Drawing.Point(156, 123)
        Me.btn_deCount.Name = "btn_deCount"
        Me.btn_deCount.Size = New System.Drawing.Size(95, 42)
        Me.btn_deCount.TabIndex = 8
        Me.btn_deCount.UseVisualStyleBackColor = False
        '
        'btn_inCount
        '
        Me.btn_inCount.BackColor = System.Drawing.Color.Transparent
        Me.btn_inCount.BackgroundImage = Global.G_Cafe.My.Resources.Resources.UP
        Me.btn_inCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inCount.Enabled = False
        Me.btn_inCount.Location = New System.Drawing.Point(156, 85)
        Me.btn_inCount.Name = "btn_inCount"
        Me.btn_inCount.Size = New System.Drawing.Size(95, 42)
        Me.btn_inCount.TabIndex = 8
        Me.btn_inCount.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(-323, -97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 80)
        Me.TextBox2.TabIndex = 0
        '
        'txt_count
        '
        Me.txt_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_count.Location = New System.Drawing.Point(49, 85)
        Me.txt_count.Name = "txt_count"
        Me.txt_count.ReadOnly = True
        Me.txt_count.Size = New System.Drawing.Size(100, 80)
        Me.txt_count.TabIndex = 0
        Me.txt_count.Text = "1"
        Me.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_manu
        '
        Me.lb_manu.AutoSize = True
        Me.lb_manu.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_manu.Location = New System.Drawing.Point(151, 15)
        Me.lb_manu.Name = "lb_manu"
        Me.lb_manu.Size = New System.Drawing.Size(145, 48)
        Me.lb_manu.TabIndex = 7
        Me.lb_manu.Text = "- - -"
        '
        'lb_bath
        '
        Me.lb_bath.AutoSize = True
        Me.lb_bath.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bath.Location = New System.Drawing.Point(151, 426)
        Me.lb_bath.Name = "lb_bath"
        Me.lb_bath.Size = New System.Drawing.Size(145, 48)
        Me.lb_bath.TabIndex = 7
        Me.lb_bath.Text = "- - -"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 48)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "ราคา :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 48)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "เมนู :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(257, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 48)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "แก้ว"
        '
        'btn_cafa
        '
        Me.btn_cafa.BackColor = System.Drawing.Color.Transparent
        Me.btn_cafa.BackgroundImage = Global.G_Cafe.My.Resources.Resources.coffee2
        Me.btn_cafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cafa.Location = New System.Drawing.Point(554, 337)
        Me.btn_cafa.Name = "btn_cafa"
        Me.btn_cafa.Size = New System.Drawing.Size(243, 236)
        Me.btn_cafa.TabIndex = 8
        Me.btn_cafa.UseVisualStyleBackColor = False
        '
        'btn_teaGreen
        '
        Me.btn_teaGreen.BackColor = System.Drawing.Color.Transparent
        Me.btn_teaGreen.BackgroundImage = Global.G_Cafe.My.Resources.Resources.d02d68b31dea4fe5fa975a83d77c5cf4
        Me.btn_teaGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_teaGreen.Location = New System.Drawing.Point(554, 19)
        Me.btn_teaGreen.Name = "btn_teaGreen"
        Me.btn_teaGreen.Size = New System.Drawing.Size(243, 236)
        Me.btn_teaGreen.TabIndex = 8
        Me.btn_teaGreen.UseVisualStyleBackColor = False
        '
        'btn_late
        '
        Me.btn_late.BackColor = System.Drawing.Color.Transparent
        Me.btn_late.BackgroundImage = Global.G_Cafe.My.Resources.Resources.download__1_
        Me.btn_late.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_late.Location = New System.Drawing.Point(312, 337)
        Me.btn_late.Name = "btn_late"
        Me.btn_late.Size = New System.Drawing.Size(243, 236)
        Me.btn_late.TabIndex = 8
        Me.btn_late.UseVisualStyleBackColor = False
        '
        'btn_teaCool
        '
        Me.btn_teaCool.BackColor = System.Drawing.Color.Transparent
        Me.btn_teaCool.BackgroundImage = Global.G_Cafe.My.Resources.Resources.unnamed
        Me.btn_teaCool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_teaCool.Location = New System.Drawing.Point(312, 19)
        Me.btn_teaCool.Name = "btn_teaCool"
        Me.btn_teaCool.Size = New System.Drawing.Size(243, 236)
        Me.btn_teaCool.TabIndex = 8
        Me.btn_teaCool.UseVisualStyleBackColor = False
        '
        'btn_oLeng
        '
        Me.btn_oLeng.BackColor = System.Drawing.Color.Transparent
        Me.btn_oLeng.BackgroundImage = Global.G_Cafe.My.Resources.Resources.download
        Me.btn_oLeng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_oLeng.Location = New System.Drawing.Point(70, 337)
        Me.btn_oLeng.Name = "btn_oLeng"
        Me.btn_oLeng.Size = New System.Drawing.Size(243, 236)
        Me.btn_oLeng.TabIndex = 8
        Me.btn_oLeng.UseVisualStyleBackColor = False
        '
        'btn_coco
        '
        Me.btn_coco.BackColor = System.Drawing.Color.Transparent
        Me.btn_coco.BackgroundImage = Global.G_Cafe.My.Resources.Resources.ไอซ์โกโก้_769x1024
        Me.btn_coco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_coco.Location = New System.Drawing.Point(70, 19)
        Me.btn_coco.Name = "btn_coco"
        Me.btn_coco.Size = New System.Drawing.Size(243, 236)
        Me.btn_coco.TabIndex = 8
        Me.btn_coco.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(563, 582)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 48)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "กาแฟโบราณ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(601, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 48)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ชาเขียว"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(389, 582)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 48)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ลาเต้"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 48)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ชานมเย็น"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 582)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 48)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "โอเลี้ยง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 48)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "โกโก้"
        '
        'crCount_btn
        '
        Me.crCount_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crCount_btn.Location = New System.Drawing.Point(1076, 12)
        Me.crCount_btn.Name = "crCount_btn"
        Me.crCount_btn.Size = New System.Drawing.Size(158, 57)
        Me.crCount_btn.TabIndex = 8
        Me.crCount_btn.Text = "สั่ง"
        Me.crCount_btn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tomato
        Me.Panel2.Controls.Add(Me.crCount_btn)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lb_totalPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 894)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1277, 78)
        Me.Panel2.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(674, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 48)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "ราคารวม :"
        '
        'lb_totalPrice
        '
        Me.lb_totalPrice.AutoSize = True
        Me.lb_totalPrice.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalPrice.Location = New System.Drawing.Point(853, 21)
        Me.lb_totalPrice.Name = "lb_totalPrice"
        Me.lb_totalPrice.Size = New System.Drawing.Size(145, 48)
        Me.lb_totalPrice.TabIndex = 7
        Me.lb_totalPrice.Text = "- - -"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1277, 972)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cafa As Button
    Friend WithEvents btn_teaGreen As Button
    Friend WithEvents btn_late As Button
    Friend WithEvents btn_teaCool As Button
    Friend WithEvents btn_oLeng As Button
    Friend WithEvents btn_coco As Button
    Friend WithEvents txt_count As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents crCount_btn As Button
    Friend WithEvents btn_inCount As Button
    Friend WithEvents dgv_order As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_shake As RadioButton
    Friend WithEvents rd_cool As RadioButton
    Friend WithEvents rd_hot As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rd_small As RadioButton
    Friend WithEvents rd_big As RadioButton
    Friend WithEvents lb_manu As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_deCount As Button
    Friend WithEvents lb_bath As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_addManu As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lb_totalPrice As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_manu As DataGridViewTextBoxColumn
    Friend WithEvents col_type As DataGridViewTextBoxColumn
    Friend WithEvents col_size As DataGridViewTextBoxColumn
    Friend WithEvents col_count As DataGridViewTextBoxColumn
    Friend WithEvents col_price As DataGridViewTextBoxColumn
    Friend WithEvents btn_rmOrder As Button
End Class
