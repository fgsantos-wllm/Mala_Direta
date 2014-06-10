<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn1240x730 = New System.Windows.Forms.Button()
        Me.btn1000x650 = New System.Windows.Forms.Button()
        Me.btn800x600 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1240x730
        '
        Me.btn1240x730.Location = New System.Drawing.Point(105, 90)
        Me.btn1240x730.Name = "btn1240x730"
        Me.btn1240x730.Size = New System.Drawing.Size(75, 23)
        Me.btn1240x730.TabIndex = 3
        Me.btn1240x730.Text = "1240 x 730"
        Me.btn1240x730.UseVisualStyleBackColor = True
        '
        'btn1000x650
        '
        Me.btn1000x650.Location = New System.Drawing.Point(105, 119)
        Me.btn1000x650.Name = "btn1000x650"
        Me.btn1000x650.Size = New System.Drawing.Size(75, 23)
        Me.btn1000x650.TabIndex = 2
        Me.btn1000x650.Text = "1000 x 650"
        Me.btn1000x650.UseVisualStyleBackColor = True
        '
        'btn800x600
        '
        Me.btn800x600.Location = New System.Drawing.Point(105, 148)
        Me.btn800x600.Name = "btn800x600"
        Me.btn800x600.Size = New System.Drawing.Size(75, 23)
        Me.btn800x600.TabIndex = 1
        Me.btn800x600.Text = "800 x 600"
        Me.btn800x600.UseVisualStyleBackColor = True
        '
        'Conf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn1240x730)
        Me.Controls.Add(Me.btn1000x650)
        Me.Controls.Add(Me.btn800x600)
        Me.Name = "Conf"
        Me.Text = "Conf"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn1240x730 As System.Windows.Forms.Button
    Friend WithEvents btn1000x650 As System.Windows.Forms.Button
    Friend WithEvents btn800x600 As System.Windows.Forms.Button
End Class
