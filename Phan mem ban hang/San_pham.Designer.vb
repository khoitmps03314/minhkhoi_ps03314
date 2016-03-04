<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sp
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
        Me.dgv_Sp = New System.Windows.Forms.DataGridView()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Capnhat = New System.Windows.Forms.Button()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.btn_TimKiem = New System.Windows.Forms.Button()
        Me.txt_SOLUONG = New System.Windows.Forms.TextBox()
        Me.txt_dongia = New System.Windows.Forms.TextBox()
        Me.txt_MALOAI = New System.Windows.Forms.TextBox()
        Me.txt_TENSP = New System.Windows.Forms.TextBox()
        Me.txt_MASP = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_trolai = New System.Windows.Forms.Button()
        CType(Me.dgv_Sp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Sp
        '
        Me.dgv_Sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Sp.Location = New System.Drawing.Point(12, 157)
        Me.dgv_Sp.Name = "dgv_Sp"
        Me.dgv_Sp.Size = New System.Drawing.Size(558, 226)
        Me.dgv_Sp.TabIndex = 20
        '
        'btn_Xoa
        '
        Me.btn_Xoa.Location = New System.Drawing.Point(433, 85)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_Xoa.TabIndex = 19
        Me.btn_Xoa.Text = "Xóa"
        Me.btn_Xoa.UseVisualStyleBackColor = True
        '
        'btn_Capnhat
        '
        Me.btn_Capnhat.Location = New System.Drawing.Point(304, 85)
        Me.btn_Capnhat.Name = "btn_Capnhat"
        Me.btn_Capnhat.Size = New System.Drawing.Size(75, 23)
        Me.btn_Capnhat.TabIndex = 18
        Me.btn_Capnhat.Text = "Cập nhật"
        Me.btn_Capnhat.UseVisualStyleBackColor = True
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(433, 14)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(75, 23)
        Me.btn_Them.TabIndex = 17
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'btn_TimKiem
        '
        Me.btn_TimKiem.Location = New System.Drawing.Point(304, 13)
        Me.btn_TimKiem.Name = "btn_TimKiem"
        Me.btn_TimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btn_TimKiem.TabIndex = 16
        Me.btn_TimKiem.Text = "Tìm Kiếm"
        Me.btn_TimKiem.UseVisualStyleBackColor = True
        '
        'txt_SOLUONG
        '
        Me.txt_SOLUONG.Location = New System.Drawing.Point(72, 118)
        Me.txt_SOLUONG.Name = "txt_SOLUONG"
        Me.txt_SOLUONG.Size = New System.Drawing.Size(197, 20)
        Me.txt_SOLUONG.TabIndex = 14
        '
        'txt_dongia
        '
        Me.txt_dongia.Location = New System.Drawing.Point(72, 92)
        Me.txt_dongia.Name = "txt_dongia"
        Me.txt_dongia.Size = New System.Drawing.Size(197, 20)
        Me.txt_dongia.TabIndex = 13
        '
        'txt_MALOAI
        '
        Me.txt_MALOAI.Location = New System.Drawing.Point(72, 66)
        Me.txt_MALOAI.Name = "txt_MALOAI"
        Me.txt_MALOAI.Size = New System.Drawing.Size(197, 20)
        Me.txt_MALOAI.TabIndex = 15
        '
        'txt_TENSP
        '
        Me.txt_TENSP.Location = New System.Drawing.Point(72, 40)
        Me.txt_TENSP.Name = "txt_TENSP"
        Me.txt_TENSP.Size = New System.Drawing.Size(197, 20)
        Me.txt_TENSP.TabIndex = 12
        '
        'txt_MASP
        '
        Me.txt_MASP.Location = New System.Drawing.Point(72, 14)
        Me.txt_MASP.Name = "txt_MASP"
        Me.txt_MASP.Size = New System.Drawing.Size(197, 20)
        Me.txt_MASP.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Số Lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tên SP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Đơn giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mã Loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên SP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã SP"
        '
        'btn_trolai
        '
        Me.btn_trolai.Location = New System.Drawing.Point(250, 389)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(75, 23)
        Me.btn_trolai.TabIndex = 24
        Me.btn_trolai.Text = "Trở lại Menu"
        Me.btn_trolai.UseVisualStyleBackColor = True
        '
        'frm_sp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 415)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.dgv_Sp)
        Me.Controls.Add(Me.btn_Xoa)
        Me.Controls.Add(Me.btn_Capnhat)
        Me.Controls.Add(Me.btn_Them)
        Me.Controls.Add(Me.btn_TimKiem)
        Me.Controls.Add(Me.txt_SOLUONG)
        Me.Controls.Add(Me.txt_dongia)
        Me.Controls.Add(Me.txt_MALOAI)
        Me.Controls.Add(Me.txt_TENSP)
        Me.Controls.Add(Me.txt_MASP)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_sp"
        Me.Text = "Sản phẩm"
        CType(Me.dgv_Sp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_Sp As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Xoa As System.Windows.Forms.Button
    Friend WithEvents btn_Capnhat As System.Windows.Forms.Button
    Friend WithEvents btn_Them As System.Windows.Forms.Button
    Friend WithEvents btn_TimKiem As System.Windows.Forms.Button
    Friend WithEvents txt_SOLUONG As System.Windows.Forms.TextBox
    Friend WithEvents txt_dongia As System.Windows.Forms.TextBox
    Friend WithEvents txt_MALOAI As System.Windows.Forms.TextBox
    Friend WithEvents txt_TENSP As System.Windows.Forms.TextBox
    Friend WithEvents txt_MASP As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_trolai As System.Windows.Forms.Button

End Class
