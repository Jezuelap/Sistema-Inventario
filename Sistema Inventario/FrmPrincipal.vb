Public Class FrmPrincipal
    Private Sub RegEqui_Click(sender As Object, e As EventArgs) Handles RegEqui.Click
        Dim objE As frmRegistrarEquipo = New frmRegistrarEquipo
        objE.Show()
    End Sub
    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class