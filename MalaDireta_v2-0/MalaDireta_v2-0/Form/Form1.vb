Public Class Form1

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private conf As Conf

    '-------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub btnConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConf.Click
        If Application.OpenForms.OfType(Of Conf)().Count() = 0 Then
            Me.conf = New Conf(Me)
            Me.conf.Show()
        Else
            Me.conf.Focus()
        End If
    End Sub

    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If Application.OpenForms.OfType(Of Conf)().Count() > 0 Then
            Me.conf.Focus()
        End If
    End Sub
End Class
