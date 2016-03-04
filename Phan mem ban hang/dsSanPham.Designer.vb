<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dssp
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
        Me.btn_dssp = New System.Windows.Forms.Button()
        Me.btn_trolai = New System.Windows.Forms.Button()
        Me.dgv_dssp = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_dssp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_dssp
        '
        Me.btn_dssp.Location = New System.Drawing.Point(210, 5)
        Me.btn_dssp.Name = "btn_dssp"
        Me.btn_dssp.Size = New System.Drawing.Size(130, 23)
        Me.btn_dssp.TabIndex = 29
        Me.btn_dssp.Text = "Danh sách sản phẩm"
        Me.btn_dssp.UseVisualStyleBackColor = True
        '
        'btn_trolai
        '
        Me.btn_trolai.Location = New System.Drawing.Point(234, 281)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(75, 23)
        Me.btn_trolai.TabIndex = 28
        Me.btn_trolai.Text = "Trở lại Menu"
        Me.btn_trolai.UseVisualStyleBackColor = True
        '
        'dgv_dssp
        '
        Me.dgv_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dssp.Location = New System.Drawing.Point(11, 34)
        Me.dgv_dssp.Name = "dgv_dssp"
        Me.dgv_dssp.Size = New System.Drawing.Size(534, 241)
        Me.dgv_dssp.TabIndex = 27
        '
        'frm_dssp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 309)
        Me.Controls.Add(Me.btn_dssp)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.dgv_dssp)
        Me.Name = "frm_dssp"
        Me.Text = "dsSanPham"
        CType(Me.dgv_dssp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_dssp As System.Windows.Forms.Button
    Friend WithEvents btn_trolai As System.Windows.Forms.Button
    Friend WithEvents dgv_dssp As System.Windows.Forms.DataGridView
End Class
