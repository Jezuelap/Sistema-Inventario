<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRegistrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegEqui = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANTENIMIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModulosToolStripMenuItem, Me.MenuRegistrar, Me.MANTENIMIENTOToolStripMenuItem, Me.REPORTESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1270, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ModulosToolStripMenuItem.Text = "MODULOS"
        '
        'MenuRegistrar
        '
        Me.MenuRegistrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegEqui})
        Me.MenuRegistrar.Name = "MenuRegistrar"
        Me.MenuRegistrar.Size = New System.Drawing.Size(67, 20)
        Me.MenuRegistrar.Text = "EQUIPOS"
        '
        'RegEqui
        '
        Me.RegEqui.Name = "RegEqui"
        Me.RegEqui.Size = New System.Drawing.Size(152, 22)
        Me.RegEqui.Text = "Registrar"
        '
        'MANTENIMIENTOToolStripMenuItem
        '
        Me.MANTENIMIENTOToolStripMenuItem.Name = "MANTENIMIENTOToolStripMenuItem"
        Me.MANTENIMIENTOToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.MANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 633)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuRegistrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegEqui As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MANTENIMIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
