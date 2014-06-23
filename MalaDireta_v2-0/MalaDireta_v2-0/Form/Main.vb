Public Class Main

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private filtros As Filtro

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub limparFiltros()
        'limpar todos os filtros
        txtAnoLicenciamento.Text = Now.Year.ToString()
        txtValorLicenciamento.Text = "0"
        cboMudouProprietario.SelectedIndex = 0
        cboVeiculoRestricao.SelectedIndex = 0
    End Sub

    Private Sub checarPreenchimentoIndividual(ByVal txt As TextBox, ByRef pend() As String, ByVal msg As String)
        If txt.Text = "" Then 'Or Not System.IO.Directory.Exists(txt.Text) Then
            pend(pend.Length - 1) = msg
            ReDim Preserve pend(pend.Length)
        End If
    End Sub

    Private Sub checarPreenchimentoIndividual(ByVal lbl As Label, ByRef pend() As String, ByVal msg As String)
        If lbl.Text = "..." Or Not System.IO.File.Exists(lbl.Text) Then
            pend(pend.Length - 1) = msg
            ReDim Preserve pend(pend.Length)
        End If
    End Sub

    Private Sub checarPreenchimentoIndividual(ByVal cbo As ComboBox, ByRef pend() As String, ByVal msg As String)
        If cbo.SelectedIndex = -1 Then
            pend(pend.Length - 1) = msg
            ReDim Preserve pend(pend.Length)
        End If
    End Sub

    Private Function checarPreenchimento() As String()
        Dim pend(0) As String

        checarPreenchimentoIndividual(txtPathSalvamento, pend, "-Selecione um diretório válido de destino para o resultado do" & vbCrLf & vbTab & "processamento")
        checarPreenchimentoIndividual(txtNomeReferencia, pend, "-Selecione um nome referência para o resultado do processamento")
        checarPreenchimentoIndividual(cboServico, pend, "-Selecione um serviço")
        checarPreenchimentoIndividual(cboLoja, pend, "-Selecione uma loja")
        checarPreenchimentoIndividual(lblArquivoSelecionadoConteudo, pend, "-Selecione um arquivo válido de entrada para o processamento")

        Return pend
    End Function

    '-------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa os filtros
        Me.filtros = New Filtro()
        limparFiltros()
        cboServico.SelectedIndex = 0
        cboLoja.SelectedIndex = 0
    End Sub

    Private Sub btnBrowseSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSaida.Click
        'selecionar o arquivo e guardar seu diretório no txtPathSalvamento
        If fbdSaida.ShowDialog() = DialogResult.OK Then
            txtPathSalvamento.Text = fbdSaida.SelectedPath
        End If
    End Sub

    Private Sub btnSelecionarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionarXML.Click
        'configurar os filtros do seletor de arquivo
        ofdEntrada.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
        ofdEntrada.FilterIndex = 2

        'selecionar o arquivo e guardar seu diretório no lblAquivoSelecionadoConteudo
        If ofdEntrada.ShowDialog = DialogResult.OK Then
            lblArquivoSelecionadoConteudo.Text = ofdEntrada.FileName

            'exibir o botão de filtros de processamento
            btnFiltro.Visible = True
        End If
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        'exibir janela de filtros
        TabControlFiltro.Visible = Not TabControlFiltro.Visible
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        'chamar método de limpeza de filtros
        limparFiltros()
    End Sub

    Private Sub btnFecharTabFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFecharTabFiltro.Click
        'configurar filtro
        Me.filtros.acAnoLic = CInt(txtAnoLicenciamento.Text)
        Me.filtros.acValorLic = CInt(txtValorLicenciamento.Text)
        Me.filtros.acMudouProprietario = cboMudouProprietario.SelectedValue
        Me.filtros.acRestricao = cboVeiculoRestricao.SelectedValue

        'ocultar janela de filtros
        TabControlFiltro.Visible = False
    End Sub

    Private Sub txtValorLicenciamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorLicenciamento.TextChanged
        'formatar o texto no padrão monetário
        Util.TextBoxMoeda(txtValorLicenciamento)
    End Sub

    Private Sub btnProcessarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessarArquivo.Click
        'checar se há erro de preenchimento
        Dim pend() As String = checarPreenchimento()

        If pend.Length > 1 Then
            'se houver erro, exibir mensagem de erro e não processar
            Dim msg As String
            If pend.Length > 2 Then
                'caso haja mais de um erro concatenar todas as mensagens de erro
                msg = "Foram detectados os seguintes erros de preenchimento do formulário. Favor corrija-os e tente novamente:" & vbCrLf & vbCrLf
                For Each erro As String In pend
                    msg &= vbTab & erro & vbCrLf
                Next
            Else
                'caso haja apenas um erro
                msg = "Foi detectado o seguinte erro de preenchimento do formulário. Favor corrija-o e tente novamente:" & vbCrLf & vbCrLf & vbTab & pend(0)
            End If
            MsgBox(msg)
        Else
            'se não houver erro, processar arquivo
            MsgBox("PROCESSANDO")
        End If
    End Sub

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged
        If cboServico.SelectedIndex = 3 Then 'serviço(3) = "CONSULTA OFFLINE"
            chkDatanasc.Visible = True
        Else
            chkDatanasc.Visible = False
        End If
    End Sub
End Class