Imports MySql.Data.MySqlClient
Public Class Form1
    Public con As New MySqlConnection
    Private Sub btnconex_Click(sender As Object, e As EventArgs) Handles btnconex.Click
        conectar()
    End Sub

    Public Sub conectar()
        Try
            If ConnectionState.Open <> con.State Then
                con.ConnectionString = ("Server=127.0.0.1;DataBase=bd_inventario_ucv;uid=root").ToString
                con.Open()
                MessageBox.Show("Funciona")

            End If
        Catch ex As Exception
            MsgBox("Error al conectar al Servidor")
        End Try
    End Sub
    Public Sub cerrar()
        con.Close()
    End Sub

    Private Sub brncerrar_Click(sender As Object, e As EventArgs) Handles brncerrar.Click
        cerrar()
    End Sub
End Class
