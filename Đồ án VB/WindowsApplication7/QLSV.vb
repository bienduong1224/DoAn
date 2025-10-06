Imports System.Data.SqlClient


Public Class frmSinhVien

    Private Sub LoadData()
        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim dt As New DataTable()
        Dim query As String = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, Lop FROM SinhVien"
        Dim da As New SqlDataAdapter(query, conn)

        conn.Open()
        da.Fill(dt)
        conn.Close()

        dgvSinhVien.DataSource = dt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim query As String = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Lop) 
                               VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @Lop)"
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value)
        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
        cmd.Parameters.AddWithValue("@Lop", txtLop.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Thêm sinh viên thành công!")
        LoadData()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs)
        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim query As String = "UPDATE SinhVien 
                               SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, Lop=@Lop 
                               WHERE MaSV=@MaSV"
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value)
        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
        cmd.Parameters.AddWithValue("@Lop", txtLop.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Sửa thông tin sinh viên thành công!")
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim maSV As String = txtMaSV.Text.Trim()

        If maSV = "" Then
            MessageBox.Show("Vui lòng chọn hoặc nhập mã sinh viên cần xóa!", "Thông báo")
            Return
        End If

        Dim confirm = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không? (Nếu xóa thì toàn bộ điểm của sinh viên cũng bị xóa)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        Dim conn As SqlConnection = DatabaseConnection.GetConnection()

        Try
            conn.Open()

            Dim queryDeleteDiem As String = "DELETE FROM Diem WHERE MaSV = @MaSV"
            Dim cmdDiem As New SqlCommand(queryDeleteDiem, conn)
            cmdDiem.Parameters.AddWithValue("@MaSV", maSV)
            cmdDiem.ExecuteNonQuery()

            Dim queryDeleteSV As String = "DELETE FROM SinhVien WHERE MaSV = @MaSV"
            Dim cmdSV As New SqlCommand(queryDeleteSV, conn)
            cmdSV.Parameters.AddWithValue("@MaSV", maSV)
            Dim rowsAffected As Integer = cmdSV.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Xóa sinh viên thành công!")
                LoadData()
            Else
                MessageBox.Show("Không tìm thấy sinh viên cần xóa!", "Thông báo")
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa sinh viên: " & ex.Message, "Lỗi")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click

        Dim maSV As String = txtTimKiem.Text.Trim()

        If maSV = "" Then
            MessageBox.Show("Vui lòng nhập Mã SV để tìm kiếm!", "Thông báo")
            Return
        End If

        Dim f As New frmDiem(maSV)
        f.Show()
    End Sub


    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub


    Private Sub frmSinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub lblMaSV_Click(sender As Object, e As EventArgs) Handles lblMaSV.Click

    End Sub
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim maGV As String = txtMaGV.Text.Trim()

        If maGV = "" Then
            MessageBox.Show("Vui lòng nhập mã giáo viên!", "Thông báo")
            Return
        End If

        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim query As String = "SELECT COUNT(*) FROM GiaoVien WHERE MaGV = @MaGV"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@MaGV", maGV)

        conn.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        conn.Close()

        If count = 0 Then
            MessageBox.Show("Mã giáo viên không tồn tại!", "Lỗi")
            Return
        End If

        Dim f As New frmNhapDiem(maGV)
        f.ShowDialog()
    End Sub

End Class
