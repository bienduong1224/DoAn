<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinhVien
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
        Me.lblMaSV = New System.Windows.Forms.Label()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblLop = New System.Windows.Forms.Label()
        Me.lblGioiTinh = New System.Windows.Forms.Label()
        Me.lblHoten = New System.Windows.Forms.Label()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.txtLop = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cboGioiTinh = New System.Windows.Forms.ComboBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dgvSinhVien = New System.Windows.Forms.DataGridView()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaGV = New System.Windows.Forms.TextBox()
        Me.btnNhap = New System.Windows.Forms.Button()
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSV
        '
        Me.lblMaSV.AutoSize = True
        Me.lblMaSV.Location = New System.Drawing.Point(40, 18)
        Me.lblMaSV.Name = "lblMaSV"
        Me.lblMaSV.Size = New System.Drawing.Size(91, 17)
        Me.lblMaSV.TabIndex = 0
        Me.lblMaSV.Text = "Mã Sinh Viên"
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(41, 55)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(73, 17)
        Me.lblNgaySinh.TabIndex = 0
        Me.lblNgaySinh.Text = "Ngày Sinh"
        '
        'lblLop
        '
        Me.lblLop.AutoSize = True
        Me.lblLop.Location = New System.Drawing.Point(52, 91)
        Me.lblLop.Name = "lblLop"
        Me.lblLop.Size = New System.Drawing.Size(32, 17)
        Me.lblLop.TabIndex = 0
        Me.lblLop.Text = "Lớp"
        '
        'lblGioiTinh
        '
        Me.lblGioiTinh.AutoSize = True
        Me.lblGioiTinh.Location = New System.Drawing.Point(456, 60)
        Me.lblGioiTinh.Name = "lblGioiTinh"
        Me.lblGioiTinh.Size = New System.Drawing.Size(65, 17)
        Me.lblGioiTinh.TabIndex = 0
        Me.lblGioiTinh.Text = "Giới Tính"
        '
        'lblHoten
        '
        Me.lblHoten.AutoSize = True
        Me.lblHoten.Location = New System.Drawing.Point(456, 21)
        Me.lblHoten.Name = "lblHoten"
        Me.lblHoten.Size = New System.Drawing.Size(55, 17)
        Me.lblHoten.TabIndex = 0
        Me.lblHoten.Text = "Họ Tên"
        '
        'txtMaSV
        '
        Me.txtMaSV.Location = New System.Drawing.Point(156, 18)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(186, 22)
        Me.txtMaSV.TabIndex = 1
        '
        'txtLop
        '
        Me.txtLop.Location = New System.Drawing.Point(156, 91)
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(186, 22)
        Me.txtLop.TabIndex = 1
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(546, 18)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(186, 22)
        Me.txtHoTen.TabIndex = 1
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(156, 55)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(186, 22)
        Me.dtpNgaySinh.TabIndex = 2
        '
        'cboGioiTinh
        '
        Me.cboGioiTinh.FormattingEnabled = True
        Me.cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cboGioiTinh.Location = New System.Drawing.Point(546, 57)
        Me.cboGioiTinh.Name = "cboGioiTinh"
        Me.cboGioiTinh.Size = New System.Drawing.Size(203, 24)
        Me.cboGioiTinh.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(55, 270)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(148, 34)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(386, 270)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(150, 34)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(663, 147)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(103, 29)
        Me.btnTimKiem.TabIndex = 4
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(703, 270)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(151, 34)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dgvSinhVien
        '
        Me.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhVien.Location = New System.Drawing.Point(12, 331)
        Me.dgvSinhVien.Name = "dgvSinhVien"
        Me.dgvSinhVien.RowTemplate.Height = 24
        Me.dgvSinhVien.Size = New System.Drawing.Size(931, 128)
        Me.dgvSinhVien.TabIndex = 5
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(398, 150)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(189, 22)
        Me.txtTimKiem.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "(Nếu muốn tìm kiếm điểm, hãy nhập MSV)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "(Nếu bạn là giáo viên)"
        '
        'txtMaGV
        '
        Me.txtMaGV.Location = New System.Drawing.Point(398, 208)
        Me.txtMaGV.Name = "txtMaGV"
        Me.txtMaGV.Size = New System.Drawing.Size(138, 22)
        Me.txtMaGV.TabIndex = 8
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(663, 208)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(89, 30)
        Me.btnNhap.TabIndex = 9
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'frmSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 471)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.txtMaGV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.dgvSinhVien)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.cboGioiTinh)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtLop)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.lblHoten)
        Me.Controls.Add(Me.lblGioiTinh)
        Me.Controls.Add(Me.lblLop)
        Me.Controls.Add(Me.lblNgaySinh)
        Me.Controls.Add(Me.lblMaSV)
        Me.Name = "frmSinhVien"
        Me.Text = "QLSV"
        CType(Me.dgvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMaSV As Label
    Friend WithEvents lblNgaySinh As Label
    Friend WithEvents lblLop As Label
    Friend WithEvents lblGioiTinh As Label
    Friend WithEvents lblHoten As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtLop As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaGV As TextBox
    Friend WithEvents btnNhap As Button
End Class
