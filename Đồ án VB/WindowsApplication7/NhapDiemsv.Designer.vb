<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapDiem
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
        Me.lblMSV = New System.Windows.Forms.Label()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.lblMH = New System.Windows.Forms.Label()
        Me.lblDiem = New System.Windows.Forms.Label()
        Me.cboMonHoc = New System.Windows.Forms.ComboBox()
        Me.txtDiem = New System.Windows.Forms.TextBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaGV = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMSV
        '
        Me.lblMSV.AutoSize = True
        Me.lblMSV.Location = New System.Drawing.Point(64, 58)
        Me.lblMSV.Name = "lblMSV"
        Me.lblMSV.Size = New System.Drawing.Size(91, 17)
        Me.lblMSV.TabIndex = 0
        Me.lblMSV.Text = "Mã Sinh Viên"
        '
        'txtMaSV
        '
        Me.txtMaSV.Location = New System.Drawing.Point(247, 58)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(222, 22)
        Me.txtMaSV.TabIndex = 1
        '
        'lblMH
        '
        Me.lblMH.AutoSize = True
        Me.lblMH.Location = New System.Drawing.Point(64, 104)
        Me.lblMH.Name = "lblMH"
        Me.lblMH.Size = New System.Drawing.Size(64, 17)
        Me.lblMH.TabIndex = 0
        Me.lblMH.Text = "Môn Học"
        '
        'lblDiem
        '
        Me.lblDiem.AutoSize = True
        Me.lblDiem.Location = New System.Drawing.Point(64, 150)
        Me.lblDiem.Name = "lblDiem"
        Me.lblDiem.Size = New System.Drawing.Size(40, 17)
        Me.lblDiem.TabIndex = 0
        Me.lblDiem.Text = "Điểm"
        '
        'cboMonHoc
        '
        Me.cboMonHoc.FormattingEnabled = True
        Me.cboMonHoc.Location = New System.Drawing.Point(247, 101)
        Me.cboMonHoc.Name = "cboMonHoc"
        Me.cboMonHoc.Size = New System.Drawing.Size(222, 24)
        Me.cboMonHoc.TabIndex = 2
        '
        'txtDiem
        '
        Me.txtDiem.Location = New System.Drawing.Point(247, 147)
        Me.txtDiem.Name = "txtDiem"
        Me.txtDiem.Size = New System.Drawing.Size(222, 22)
        Me.txtDiem.TabIndex = 1
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(142, 235)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(129, 29)
        Me.btnLuu.TabIndex = 3
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(429, 235)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(129, 29)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(633, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Giáo Viên"
        '
        'txtMaGV
        '
        Me.txtMaGV.Location = New System.Drawing.Point(568, 89)
        Me.txtMaGV.Name = "txtMaGV"
        Me.txtMaGV.ReadOnly = True
        Me.txtMaGV.Size = New System.Drawing.Size(222, 22)
        Me.txtMaGV.TabIndex = 1
        '
        'frmNhapDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 405)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.cboMonHoc)
        Me.Controls.Add(Me.txtDiem)
        Me.Controls.Add(Me.txtMaGV)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.lblDiem)
        Me.Controls.Add(Me.lblMH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMSV)
        Me.Name = "frmNhapDiem"
        Me.Text = "NhapDiemSV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMSV As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents lblMH As Label
    Friend WithEvents lblDiem As Label
    Friend WithEvents cboMonHoc As ComboBox
    Friend WithEvents txtDiem As TextBox
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaGV As TextBox
End Class
