Imports System.Data.SqlClient
Public Class frmDiem
    Private _MaSV As String
    Public Sub New(maSV As String)
        InitializeComponent()
        _MaSV = maSV
    End Sub

    Private Sub frmDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDiem()
    End Sub

    Private Sub LoadDiem()
        Dim conn As SqlConnection = DatabaseConnection.GetConnection()
        Dim dt As New DataTable()
        Dim query As String = "SELECT d.MaSV, sv.HoTen, d.MaMH, mh.TenMH, d.Diem
                               FROM Diem d
                               INNER JOIN SinhVien sv ON d.MaSV = sv.MaSV
                               INNER JOIN MonHoc mh ON d.MaMH = mh.MaMH
                               WHERE d.MaSV = @MaSV"

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@MaSV", _MaSV)

        Dim da As New SqlDataAdapter(cmd)

        conn.Open()
        da.Fill(dt)
        conn.Close()

        dgvDiem.DataSource = dt
    End Sub
End Class
