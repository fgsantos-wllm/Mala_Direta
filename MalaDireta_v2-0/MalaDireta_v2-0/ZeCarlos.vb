Public Class ZeCarlos

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Function WsConsultaSinaliza(ByVal placa As String) As String

        Dim objFunctions As New Imperia.Common.Functions
        Dim Autenticacao As WSSINALIZA.AuthHeader = New WSSINALIZA.AuthHeader()
        Dim ws_sin As WSSINALIZA.ConsultasVeiculos = New WSSINALIZA.ConsultasVeiculos()
        Dim strReturn As String = ""

        Try
            Autenticacao.Usuario = "ws_etef"
            Autenticacao.Senha = "=%3Ee$4A"

            ws_sin.AuthHeaderValue = Autenticacao
            strReturn = ws_sin.ConsultaSinaliza(35, Replace(placa, "-", ""), "", "", 0)
            strReturn = objFunctions.Tira_CaracteresEstranhosXML(strReturn)
        Catch ex As Exception
        End Try

        Return strReturn
    End Function

    '-------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '-------------------------------------------------------------------------------------------------------------------

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click

    End Sub

    Private Sub btnProcessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessa.Click

    End Sub
End Class