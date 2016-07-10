<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnconex = New System.Windows.Forms.Button()
        Me.brncerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnconex
        '
        Me.btnconex.Location = New System.Drawing.Point(66, 54)
        Me.btnconex.Name = "btnconex"
        Me.btnconex.Size = New System.Drawing.Size(159, 35)
        Me.btnconex.TabIndex = 0
        Me.btnconex.Text = "Conectar"
        Me.btnconex.UseVisualStyleBackColor = True
        '
        'brncerrar
        '
        Me.brncerrar.Location = New System.Drawing.Point(66, 127)
        Me.brncerrar.Name = "brncerrar"
        Me.brncerrar.Size = New System.Drawing.Size(159, 35)
        Me.brncerrar.TabIndex = 0
        Me.brncerrar.Text = "Cerrar"
        Me.brncerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.brncerrar)
        Me.Controls.Add(Me.btnconex)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnconex As System.Windows.Forms.Button
    Friend WithEvents brncerrar As System.Windows.Forms.Button

End Class
