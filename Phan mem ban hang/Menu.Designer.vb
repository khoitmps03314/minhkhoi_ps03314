<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_menu = New System.Windows.Forms.Label()
        Me.pbx_khachhang = New System.Windows.Forms.PictureBox()
        Me.lbl_khachhang = New System.Windows.Forms.Label()
        Me.lbl_sanpham = New System.Windows.Forms.Label()
        Me.ptb_dskh = New System.Windows.Forms.PictureBox()
        Me.pbx_sanpham = New System.Windows.Forms.PictureBox()
        Me.ptb_dssp = New System.Windows.Forms.PictureBox()
        Me.lbl_dskh = New System.Windows.Forms.Label()
        Me.lbl_dssp = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_khachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_dskh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_sanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_dssp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 149)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbl_menu
        '
        Me.lbl_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_menu.ForeColor = System.Drawing.Color.Red
        Me.lbl_menu.Location = New System.Drawing.Point(165, 9)
        Me.lbl_menu.Name = "lbl_menu"
        Me.lbl_menu.Size = New System.Drawing.Size(85, 38)
        Me.lbl_menu.TabIndex = 2
        Me.lbl_menu.Text = "Menu"
        '
        'pbx_khachhang
        '
        Me.pbx_khachhang.BackgroundImage = CType(resources.GetObject("pbx_khachhang.BackgroundImage"), System.Drawing.Image)
        Me.pbx_khachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbx_khachhang.Location = New System.Drawing.Point(12, 208)
        Me.pbx_khachhang.Name = "pbx_khachhang"
        Me.pbx_khachhang.Size = New System.Drawing.Size(82, 50)
        Me.pbx_khachhang.TabIndex = 3
        Me.pbx_khachhang.TabStop = False
        '
        'lbl_khachhang
        '
        Me.lbl_khachhang.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_khachhang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_khachhang.Location = New System.Drawing.Point(12, 261)
        Me.lbl_khachhang.Name = "lbl_khachhang"
        Me.lbl_khachhang.Size = New System.Drawing.Size(82, 41)
        Me.lbl_khachhang.TabIndex = 4
        Me.lbl_khachhang.Text = "Chỉnh sửa khách hàng"
        Me.lbl_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_sanpham
        '
        Me.lbl_sanpham.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_sanpham.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_sanpham.Location = New System.Drawing.Point(317, 261)
        Me.lbl_sanpham.Name = "lbl_sanpham"
        Me.lbl_sanpham.Size = New System.Drawing.Size(82, 41)
        Me.lbl_sanpham.TabIndex = 4
        Me.lbl_sanpham.Text = "Chỉnh sửa sản phẩm"
        Me.lbl_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptb_dskh
        '
        Me.ptb_dskh.BackgroundImage = CType(resources.GetObject("ptb_dskh.BackgroundImage"), System.Drawing.Image)
        Me.ptb_dskh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptb_dskh.Location = New System.Drawing.Point(114, 208)
        Me.ptb_dskh.Name = "ptb_dskh"
        Me.ptb_dskh.Size = New System.Drawing.Size(82, 50)
        Me.ptb_dskh.TabIndex = 5
        Me.ptb_dskh.TabStop = False
        '
        'pbx_sanpham
        '
        Me.pbx_sanpham.BackgroundImage = CType(resources.GetObject("pbx_sanpham.BackgroundImage"), System.Drawing.Image)
        Me.pbx_sanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbx_sanpham.Location = New System.Drawing.Point(320, 208)
        Me.pbx_sanpham.Name = "pbx_sanpham"
        Me.pbx_sanpham.Size = New System.Drawing.Size(82, 50)
        Me.pbx_sanpham.TabIndex = 3
        Me.pbx_sanpham.TabStop = False
        '
        'ptb_dssp
        '
        Me.ptb_dssp.BackgroundImage = CType(resources.GetObject("ptb_dssp.BackgroundImage"), System.Drawing.Image)
        Me.ptb_dssp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptb_dssp.Location = New System.Drawing.Point(219, 208)
        Me.ptb_dssp.Name = "ptb_dssp"
        Me.ptb_dssp.Size = New System.Drawing.Size(82, 50)
        Me.ptb_dssp.TabIndex = 3
        Me.ptb_dssp.TabStop = False
        '
        'lbl_dskh
        '
        Me.lbl_dskh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_dskh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_dskh.Location = New System.Drawing.Point(111, 261)
        Me.lbl_dskh.Name = "lbl_dskh"
        Me.lbl_dskh.Size = New System.Drawing.Size(82, 41)
        Me.lbl_dskh.TabIndex = 4
        Me.lbl_dskh.Text = "Danh sách khách hàng"
        Me.lbl_dskh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dssp
        '
        Me.lbl_dssp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_dssp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_dssp.Location = New System.Drawing.Point(219, 261)
        Me.lbl_dssp.Name = "lbl_dssp"
        Me.lbl_dssp.Size = New System.Drawing.Size(82, 41)
        Me.lbl_dssp.TabIndex = 4
        Me.lbl_dssp.Text = "Danh sách sản phẩm"
        Me.lbl_dssp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 306)
        Me.Controls.Add(Me.ptb_dskh)
        Me.Controls.Add(Me.lbl_dssp)
        Me.Controls.Add(Me.lbl_sanpham)
        Me.Controls.Add(Me.lbl_dskh)
        Me.Controls.Add(Me.lbl_khachhang)
        Me.Controls.Add(Me.ptb_dssp)
        Me.Controls.Add(Me.pbx_sanpham)
        Me.Controls.Add(Me.pbx_khachhang)
        Me.Controls.Add(Me.lbl_menu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_menu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_khachhang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_dskh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_sanpham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_dssp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_menu As System.Windows.Forms.Label
    Friend WithEvents pbx_khachhang As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_khachhang As System.Windows.Forms.Label
    Friend WithEvents lbl_sanpham As System.Windows.Forms.Label
    Friend WithEvents ptb_dskh As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_sanpham As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_dssp As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_dskh As System.Windows.Forms.Label
    Friend WithEvents lbl_dssp As System.Windows.Forms.Label
End Class
