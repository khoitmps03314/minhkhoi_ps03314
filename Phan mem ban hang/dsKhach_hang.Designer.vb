<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dsKH
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
        Me.dgv_dskh = New System.Windows.Forms.DataGridView()
        Me.btn_trolai = New System.Windows.Forms.Button()
        Me.btn_dskh = New System.Windows.Forms.Button()
        CType(Me.dgv_dskh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dskh
        '
        Me.dgv_dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dskh.Location = New System.Drawing.Point(12, 36)
        Me.dgv_dskh.Name = "dgv_dskh"
        Me.dgv_dskh.Size = New System.Drawing.Size(534, 241)
        Me.dgv_dskh.TabIndex = 5
        '
        'btn_trolai
        '
        Me.btn_trolai.Location = New System.Drawing.Point(235, 283)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(75, 23)
        Me.btn_trolai.TabIndex = 26
        Me.btn_trolai.Text = "Trở lại Menu"
        Me.btn_trolai.UseVisualStyleBackColor = True
        '
        'btn_dskh
        '
        Me.btn_dskh.Location = New System.Drawing.Point(206, 7)
        Me.btn_dskh.Name = "btn_dskh"
        Me.btn_dskh.Size = New System.Drawing.Size(139, 23)
        Me.btn_dskh.TabIndex = 26
        Me.btn_dskh.Text = "Danh sách khách hàng"
        Me.btn_dskh.UseVisualStyleBackColor = True
        '
        'frm_dsKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 309)
        Me.Controls.Add(Me.btn_dskh)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.dgv_dskh)
        Me.Name = "frm_dsKH"
        Me.Text = "Danh sách khách hàng"
        CType(Me.dgv_dskh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_dskh As System.Windows.Forms.DataGridView
    Friend WithEvents btn_trolai As System.Windows.Forms.Button
    Friend WithEvents btn_dskh As System.Windows.Forms.Button
End Class
