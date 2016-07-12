Imports MySql.Data.MySqlClient
Public Class clsEquipoAD
    Public Function datos() As DataTable
        Dim sql As String
        Dim con As New clsConeccion
        Dim sentencia As MySqlCommand
        Dim dr As MySqlDataReader
        Try
            con.conectar()
            sql = "select * from  tipo"
            sentencia = New MySqlCommand(sql, con.getCon)
            dr = sentencia.ExecuteReader()
            If dr.HasRows Then
                Dim dt As New DataTable
                dt.Columns.Add("id")
                dt.Columns.Add("Descripcion")
                Dim datar As DataRow
                datar = dt.NewRow()
                datar("id") = "nothing"
                datar("descripcion") = "-- SELECCIONAR --"
                dt.Rows.Add(datar)
                While dr.Read()
                    datar = dt.NewRow()
                    datar("id") = dr("id").ToString
                    datar("descripcion") = dr("descripcion").ToString.ToUpper
                    dt.Rows.Add(datar)
                End While
                Return dt
            End If
        Catch ex As Exception

        End Try

    End Function
End Class
