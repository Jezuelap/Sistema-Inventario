Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Entidad
Public Class clsUsuarioAD
    Public Function logeo(u As String, p As String) As clsUsuario
        Dim sql As String
        Dim objA As New clsUsuario
        Dim con As New clsConeccion
        Dim sentencia As MySqlCommand
        Dim dr As MySqlDataReader
        Try
            con.conectar()
            sql = "select * from  usuario where username='" & u & "' AND password='" & p & "'"
            sentencia = New MySqlCommand(sql, con.getCon)
            dr = sentencia.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    objA = New clsUsuario With {.nom = dr("nombre").ToString, .ape = dr("apellido"), .usu = u}
                End While
                Return objA
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
