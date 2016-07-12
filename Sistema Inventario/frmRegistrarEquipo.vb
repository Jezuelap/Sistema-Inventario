Imports Entidad
Imports AccesoDatos
Imports MySql.Data.MySqlClient
Public Class frmRegistrarEquipo

    Private Sub frmRegistrarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ADT As New clsTipoAD
        Dim T As New clsTipo

        Dim dt As DataTable
        dt = ADT.llenarcmb()
        If Not IsNothing(dt) Then
            cmbTipo.DataSource = dt
            cmbTipo.ValueMember = "id"
            cmbTipo.DisplayMember = "descripcion"
        Else
            MsgBox("no da")
        End If

    End Sub
End Class