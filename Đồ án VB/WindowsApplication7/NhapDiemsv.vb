Imports System.Data.SqlClient

Public Class frmNhapDiem
    Private _maGV As String

    Public Sub New(maGV As String)
        InitializeComponent()
        _maGV = maGV
    End Sub

    Private Sub frmNhapDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaGV.Text = _maGV
        txtMaGV.ReadOnly = True
        LoadMonHoc()
    End Sub

    Private Sub LoadMonHoc()
        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim query As String = "SELECT MaMH, TenMH FROM MonHoc"
        Dim da As New SqlDataAdapter(query, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
            conn.Close()

            cboMonHoc.DataSource = dt
            cboMonHoc.DisplayMember = "TenMH"
            cboMonHoc.ValueMember = "MaMH"
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải môn học: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim maGV As String = txtMaGV.Text.Trim()
        Dim maSV As String = txtMaSV.Text.Trim()
        Dim maMH As String = cboMonHoc.SelectedValue.ToString()
        Dim diemSo As Double

        If maSV = "" Or txtDiem.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sinh viên và điểm số!", "Thông báo")
            Return
        End If

        If Not Double.TryParse(txtDiem.Text, diemSo) OrElse diemSo < 0 OrElse diemSo > 10 Then
            MessageBox.Show("Điểm phải nằm trong khoảng 0 - 10!", "Lỗi nhập liệu")
            Return
        End If

        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim query As String = "
            INSERT INTO Diem (MaSV, MaMH, DiemThi, MaGV)
            VALUES (@MaSV, @MaMH, @DiemThi, @MaGV)
        "

        Try
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MaSV", maSV)
            cmd.Parameters.AddWithValue("@MaMH", maMH)
            cmd.Parameters.AddWithValue("@DiemThi", diemSo)
            cmd.Parameters.AddWithValue("@MaGV", maGV)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Lưu điểm thành công!", "Thông báo")
            txtMaSV.Clear()
            txtDiem.Clear()
            cboMonHoc.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu điểm: " & ex.Message, "Lỗi")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
