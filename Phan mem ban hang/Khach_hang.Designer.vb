<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kh
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
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.dgv_KH = New System.Windows.Forms.DataGridView()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_capnhat = New System.Windows.Forms.Button()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_SDT = New System.Windows.Forms.TextBox()
        Me.txt_Tenkh = New System.Windows.Forms.TextBox()
        Me.txt_MaKH = New System.Windows.Forms.TextBox()
        Me.btn_timkiem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_trolai = New System.Windows.Forms.Button()
        CType(Me.dgv_KH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(70, 62)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(197, 20)
        Me.txt_diachi.TabIndex = 20
        '
        'dgv_KH
        '
        Me.dgv_KH.AllowUserToOrderColumns = True
        Me.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_KH.Location = New System.Drawing.Point(11, 151)
        Me.dgv_KH.Name = "dgv_KH"
        Me.dgv_KH.Size = New System.Drawing.Size(558, 237)
        Me.dgv_KH.TabIndex = 19
        '
        'btn_xoa
        '
        Me.btn_xoa.Location = New System.Drawing.Point(433, 85)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 16
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(433, 14)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 17
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_capnhat
        '
        Me.btn_capnhat.Location = New System.Drawing.Point(304, 85)
        Me.btn_capnhat.Name = "btn_capnhat"
        Me.btn_capnhat.Size = New System.Drawing.Size(75, 23)
        Me.btn_capnhat.TabIndex = 18
        Me.btn_capnhat.Text = "Cập Nhật"
        Me.btn_capnhat.UseVisualStyleBackColor = True
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(70, 115)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(197, 20)
        Me.txt_Email.TabIndex = 12
        '
        'txt_SDT
        '
        Me.txt_SDT.Location = New System.Drawing.Point(70, 88)
        Me.txt_SDT.Name = "txt_SDT"
        Me.txt_SDT.Size = New System.Drawing.Size(197, 20)
        Me.txt_SDT.TabIndex = 13
        '
        'txt_Tenkh
        '
        Me.txt_Tenkh.Location = New System.Drawing.Point(70, 36)
        Me.txt_Tenkh.Name = "txt_Tenkh"
        Me.txt_Tenkh.Size = New System.Drawing.Size(197, 20)
        Me.txt_Tenkh.TabIndex = 14
        '
        'txt_MaKH
        '
        Me.txt_MaKH.Location = New System.Drawing.Point(70, 10)
        Me.txt_MaKH.Name = "txt_MaKH"
        Me.txt_MaKH.Size = New System.Drawing.Size(197, 20)
        Me.txt_MaKH.TabIndex = 15
        '
        'btn_timkiem
        '
        Me.btn_timkiem.Location = New System.Drawing.Point(304, 13)
        Me.btn_timkiem.Name = "btn_timkiem"
        Me.btn_timkiem.Size = New System.Drawing.Size(75, 23)
        Me.btn_timkiem.TabIndex = 11
        Me.btn_timkiem.Text = "Tìm kiếm"
        Me.btn_timkiem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Địa chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SĐT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mã KH"
        '
        'btn_trolai
        '
        Me.btn_trolai.Location = New System.Drawing.Point(247, 394)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(75, 23)
        Me.btn_trolai.TabIndex = 25
        Me.btn_trolai.Text = "Trở lại Menu"
        Me.btn_trolai.UseVisualStyleBackColor = True
        '
        'frm_kh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 418)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.dgv_KH)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.btn_capnhat)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_SDT)
        Me.Controls.Add(Me.txt_Tenkh)
        Me.Controls.Add(Me.txt_MaKH)
        Me.Controls.Add(Me.btn_timkiem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_kh"
        Me.Text = "Khách hàng"
        CType(Me.dgv_KH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_diachi As System.Windows.Forms.TextBox
    Friend WithEvents dgv_KH As System.Windows.Forms.DataGridView
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_capnhat As System.Windows.Forms.Button
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_SDT As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tenkh As System.Windows.Forms.TextBox
    Friend WithEvents txt_MaKH As System.Windows.Forms.TextBox
    Friend WithEvents btn_timkiem As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_trolai As System.Windows.Forms.Button
End Class
