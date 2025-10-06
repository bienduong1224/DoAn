Imports System.Data.SqlClient

Public Class DatabaseConnection
    Public Shared Function GetConnection() As SqlConnection
        Dim connString As String = "Data Source=DESKTOP-ULMESMU\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True"
        Dim conn As New SqlConnection(connString)
        Return conn
    End Function
End Class
