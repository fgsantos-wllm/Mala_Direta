Public Class Util
    ''' <summary>
    ''' Método que formata para moeda o conteúdo de um TextBox
    ''' </summary>
    ''' <param name="txt">Controle a ser formatado</param>
    ''' <remarks></remarks>
    Public Shared Sub TextBoxMoeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MessageBox.Show(ex.Message, "TextBoxMoeda")
        End Try
    End Sub
End Class
