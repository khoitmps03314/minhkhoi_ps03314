<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Start))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_dangnhap = New System.Windows.Forms.TextBox()
        Me.txt_matkhau = New System.Windows.Forms.TextBox()
        Me.lbl_tendangnhap = New System.Windows.Forms.Label()
        Me.lbl_MatKhau = New System.Windows.Forms.Label()
        Me.bnt_dangnhap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 149)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txt_dangnhap
        '
        Me.txt_dangnhap.Location = New System.Drawing.Point(137, 186)
        Me.txt_dangnhap.Name = "txt_dangnhap"
        Me.txt_dangnhap.Size = New System.Drawing.Size(155, 20)
        Me.txt_dangnhap.TabIndex = 1
        '
        'txt_matkhau
        '
        Me.txt_matkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txt_matkhau.Location = New System.Drawing.Point(137, 221)
        Me.txt_matkhau.Name = "txt_matkhau"
        Me.txt_matkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_matkhau.Size = New System.Drawing.Size(155, 20)
        Me.txt_matkhau.TabIndex = 1
        '
        'lbl_tendangnhap
        '
        Me.lbl_tendangnhap.AutoSize = True
        Me.lbl_tendangnhap.Location = New System.Drawing.Point(47, 189)
        Me.lbl_tendangnhap.Name = "lbl_tendangnhap"
        Me.lbl_tendangnhap.Size = New System.Drawing.Size(90, 13)
        Me.lbl_tendangnhap.TabIndex = 3
        Me.lbl_tendangnhap.Text = "Tên Đăng Nhập :"
        '
        'lbl_MatKhau
        '
        Me.lbl_MatKhau.AutoSize = True
        Me.lbl_MatKhau.Location = New System.Drawing.Point(78, 224)
        Me.lbl_MatKhau.Name = "lbl_MatKhau"
        Me.lbl_MatKhau.Size = New System.Drawing.Size(59, 13)
        Me.lbl_MatKhau.TabIndex = 3
        Me.lbl_MatKhau.Text = "Mật Khẩu :"
        '
        'bnt_dangnhap
        '
        Me.bnt_dangnhap.Location = New System.Drawing.Point(177, 247)
        Me.bnt_dangnhap.Name = "bnt_dangnhap"
        Me.bnt_dangnhap.Size = New System.Drawing.Size(75, 23)
        Me.bnt_dangnhap.TabIndex = 4
        Me.bnt_dangnhap.Text = "Đăng Nhập"
        Me.bnt_dangnhap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "admin"
        '
        'Frm_Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 288)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnt_dangnhap)
        Me.Controls.Add(Me.lbl_MatKhau)
        Me.Controls.Add(Me.lbl_tendangnhap)
        Me.Controls.Add(Me.txt_matkhau)
        Me.Controls.Add(Me.txt_dangnhap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Frm_Start"
        Me.Text = "Quản lý bán hàng"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_dangnhap As System.Windows.Forms.TextBox
    Friend WithEvents txt_matkhau As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tendangnhap As System.Windows.Forms.Label
    Friend WithEvents lbl_MatKhau As System.Windows.Forms.Label
    Friend WithEvents bnt_dangnhap As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
