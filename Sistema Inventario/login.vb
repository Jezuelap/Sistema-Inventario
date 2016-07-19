Imports Entidad
Imports AccesoDatos
Public Class login
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim UAD As New clsUsuarioAD
        Dim U As clsUsuario
        U = UAD.logeo(txtUsu.Text.Trim, txtCont.Text.Trim)
        If Not IsNothing(U) Then
            Dim msj As String = "Bienvenido " & U.nom & " " & U.ape
            MsgBox(msj, MsgBoxStyle.Information)
            Dim objfrom As New FrmPrincipal
            objfrom.Show()
            Me.Hide()
        Else
            MsgBox("DATOS INCORRECTOS", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class