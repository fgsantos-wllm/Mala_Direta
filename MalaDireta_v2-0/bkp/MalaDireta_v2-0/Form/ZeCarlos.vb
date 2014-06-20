Imports Microsoft.Office.Interop
Imports System.Xml

Public Class ZeCarlos

    '-------------------------------------------------------------------------------------------------------------------
    'CONSTANTES
    '-------------------------------------------------------------------------------------------------------------------
    Private Const PLA As Integer = 0
    Private Const CPF As Integer = 1
    Private Const NOM As Integer = 2
    Private Const COD As Integer = 3
    Private Const CHA As Integer = 4

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private nome As String
    Private doc As String

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Function WsConsultaSinaliza(ByVal placa As String) As String

        Dim Autenticacao As WSSINALIZA.AuthHeader = New WSSINALIZA.AuthHeader()
        Dim ws_sin As WSSINALIZA.ConsultasVeiculos = New WSSINALIZA.ConsultasVeiculos()
        Dim strReturn As String = ""

        Try
            Autenticacao.Usuario = "ws_etef"
            Autenticacao.Senha = "=%3Ee$4A"

            ws_sin.AuthHeaderValue = Autenticacao
            System.Net.ServicePointManager.Expect100Continue = False
            strReturn = ws_sin.ConsultaSinaliza(35, Replace(placa, "-", ""), "", "", 0)
        Catch ex As Exception
        End Try

        Return strReturn
    End Function

    Private Sub consulta(ByVal placa As String, ByRef dtg As DataGridView)
        If (placa <> "") Then
            Dim strXML As String = WsConsultaSinaliza(placa)
            Dim linha(5) As String

            Dim oXML As New XmlDocument
            oXML.LoadXml(strXML)

            Dim oNoListaHeader As XmlNodeList = oXML.SelectNodes("/PRODUTO/DETALHES/SERVICO/CONSULTA/RETORNO")
            Dim oNoListaBody As XmlNodeList = oXML.SelectNodes("/PRODUTO/DETALHES/SERVICO/CONSULTA/RESPOSTA")
            Dim oNoListaEnd As XmlNodeList = oXML.SelectNodes("/PRODUTO/DETALHES/SERVICO/CONSULTA/RESPOSTA/ENDERECO")

            For Each oNoHeader As XmlNode In oNoListaHeader
                If (oNoHeader.Item("ERRO").InnerXml.ToString()) = "" Then
                    For Each oNoBody As XmlNode In oNoListaBody
                        linha(PLA) = placa
                        linha(NOM) = Me.nome
                        If (Not (oNoBody.Item("CPF") Is Nothing)) Then
                            linha(CPF) = oNoBody.Item("CPF").InnerXml.ToString()
                        Else
                            linha(CPF) = Me.doc
                        End If
                        If (Not (oNoBody.Item("CHASSI") Is Nothing)) Then
                            linha(CHA) = oNoBody.Item("CHASSI").InnerXml.ToString()
                        End If
                        For Each oNoEnd As XmlNode In oNoListaEnd
                            If (Not (oNoEnd.Item("CODMUNICIPIO") Is Nothing)) Then
                                linha(COD) = oNoEnd.Item("CODMUNICIPIO").InnerXml.ToString()
                            End If
                        Next
                    Next
                End If
            Next

            dtg.Rows.Add(linha)
        End If
    End Sub

    Private Sub processaXls(ByVal caminho As String, ByVal plan As String)
        Dim xl As New Excel.Application
        Dim xlw As Excel.Workbook

        'Abrir o arquivo do Excel 
        xlw = xl.Workbooks.Open(caminho)

        Try
            'Definir qual a planilha de trabalho
            xlw.Sheets(plan).Select()
            Dim i As Integer = 2
            While (xlw.Application.Cells(i, 4).Value.ToString() <> "$$$")
                Me.nome = xlw.Application.Cells(i, 14).Value.ToString()
                Me.doc = xlw.Application.Cells(i, 3).Value.ToString()
                consulta(xlw.Application.Cells(i, 4).Value.ToString(), dtgSaida)
                i += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Fechar a planilha sem salvar alterações
            'Para salvar mude False para True
            xlw.Close(False)
            'Liberamos a memória
            xlw = Nothing
            xl = Nothing
        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '-------------------------------------------------------------------------------------------------------------------

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        If (ofdEntrada.ShowDialog() = DialogResult.OK) Then
            txtCaminhoEntrada.Text = ofdEntrada.FileName
            btnProcessa.Enabled = True
            btnEntrada.Enabled = False
        End If
    End Sub

    Private Sub btnProcessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessa.Click
        'dtgSaida.Rows.Add("DRI-5165", "429.652.488-70", "Fernando Gavinhos dos Santos", "São Paulo", "928378493")
        processaXls(txtCaminhoEntrada.Text, "Plan1")
        btnProcessa.Enabled = False
        btnEntrada.Enabled = True
        txtCaminhoEntrada.Clear()
    End Sub
End Class