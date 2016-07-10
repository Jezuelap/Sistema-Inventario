Imports MySql.Data.MySqlClient
Public Class clsConeccion
    Public con As New MySqlConnection
    Sub New()
        con.ConnectionString = ("Server=127.0.0.1;DataBase=bd_inventario_ucv;uid=root").ToString
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub conectar()
        Try
            If ConnectionState.Open <> con.State Then
                con.Open()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
    Public ReadOnly Property getCon As MySqlConnection
        Get
            Return con
        End Get
    End Property



End Class
