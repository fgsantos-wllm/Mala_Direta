Public Class Form1

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private conf As Conf

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub guardar()
        Dim abc() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t"}
        Dim texto As String = ""

        For i As Integer = 0 To 16 Step 4
            texto &= abc(i)
            For j As Integer = 1 To 3
                texto &= vbTab & abc(i + j)
            Next
            texto &= vbCrLf
        Next

        If sfdSaida.ShowDialog = DialogResult.OK Then
            Dim a As New Arquivo
            a.save(sfdSaida.FileName, texto)
        End If
    End Sub

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

    Private Sub btnBrowseDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSaida.Click
        If ofdEntrada.ShowDialog = DialogResult.OK Then
            txtCaminhoSaida.Text = ofdEntrada.FileName
        End If
    End Sub
End Class