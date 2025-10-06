<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMaSV = New System.Windows.Forms.ComboBox()
        Me.cboMaMH = New System.Windows.Forms.ComboBox()
        Me.txtDiemThi = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dgvDiem = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Môn Học"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Điểm Thi"
        '
        'cboMaSV
        '
        Me.cboMaSV.FormattingEnabled = True
        Me.cboMaSV.Location = New System.Drawing.Point(145, 18)
        Me.cboMaSV.Name = "cboMaSV"
        Me.cboMaSV.Size = New System.Drawing.Size(196, 24)
        Me.cboMaSV.TabIndex = 1
        '
        'cboMaMH
        '
        Me.cboMaMH.FormattingEnabled = True
        Me.cboMaMH.Location = New System.Drawing.Point(594, 18)
        Me.cboMaMH.Name = "cboMaMH"
        Me.cboMaMH.Size = New System.Drawing.Size(196, 24)
        Me.cboMaMH.TabIndex = 1
        '
        'txtDiemThi
        '
        Me.txtDiemThi.Location = New System.Drawing.Point(145, 82)
        Me.txtDiemThi.Name = "txtDiemThi"
        Me.txtDiemThi.Size = New System.Drawing.Size(196, 22)
        Me.txtDiemThi.TabIndex = 2
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(23, 182)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(122, 42)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(231, 182)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(122, 42)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(430, 182)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(122, 42)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(644, 182)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(122, 42)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dgvDiem
        '
        Me.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiem.Location = New System.Drawing.Point(14, 265)
        Me.dgvDiem.Name = "dgvDiem"
        Me.dgvDiem.RowTemplate.Height = 24
        Me.dgvDiem.Size = New System.Drawing.Size(812, 142)
        Me.dgvDiem.TabIndex = 4
        '
        'frmDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 427)
        Me.Controls.Add(Me.dgvDiem)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtDiemThi)
        Me.Controls.Add(Me.cboMaMH)
        Me.Controls.Add(Me.cboMaSV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDiem"
        Me.Text = "DiemSV"
        CType(Me.dgvDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMaSV As ComboBox
    Friend WithEvents cboMaMH As ComboBox
    Friend WithEvents txtDiemThi As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents dgvDiem As DataGridView
End Class
