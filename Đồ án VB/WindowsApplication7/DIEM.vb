Imports System.Data.SqlClient


Public Class frmDiem
    Dim conn As SqlConnection = DatabaseConnection.GetConnection()
    Private _MaSV As String

    Public Sub New(maSV As String)
        InitializeComponent()
        _MaSV = maSV
    End Sub

    Private Sub frmDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDiem()
        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim dt As New DataTable()
        Dim query As String = "
            SELECT d.MaSV, sv.HoTen, d.MaMH, mh.TenMH, d.DiemThi
            FROM Diem d
            INNER JOIN SinhVien sv ON d.MaSV = sv.MaSV
            INNER JOIN MonHoc mh ON d.MaMH = mh.MaMH
            WHERE d.MaSV = @MaSV
        "

        Dim da As New SqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@MaSV", _MaSV)

        conn.Open()
        da.Fill(dt)
        conn.Close()

        dgvDiem.DataSource = dt
    End Sub

    Private Sub LoadDiem()
        Dim dt As New DataTable()
        Dim query As String = "SELECT d.MaSV, sv.HoTen, d.MaMH, mh.TenMH, d.DiemThi 
                               FROM Diem d
                               INNER JOIN SinhVien sv ON d.MaSV = sv.MaSV
                               INNER JOIN MonHoc mh ON d.MaMH = mh.MaMH
                               WHERE d.MaSV = @MaSV"

        Dim da As New SqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@MaSV", _MaSV)

        conn.Open()
        da.Fill(dt)
        conn.Close()

        dgvDiem.DataSource = dt
    End Sub
    Private Sub LoadData()
        Dim da As New SqlDataAdapter("SELECT * FROM Diem", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvDiem.DataSource = dt
    End Sub



    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub dgvDiem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiem.CellContentClick

    End Sub
End Class
