Public Class Main

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private filtros As Filtro

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub limpaFiltros()
        'limpar todos os filtros
        txtAnoLicenciamento.Text = Now.Year.ToString()
        txtValorLicenciamento.Text = "0"
        cboMudouProprietario.SelectedIndex = 0
        cboVeiculoRestricao.SelectedIndex = 0
    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa os filtros
        Me.filtros = New Filtro()
        limpaFiltros()
    End Sub

    Private Sub btnBrowseSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSaida.Click
        'selecionar o arquivo e guardar seu diretório no txtPathSalvamento
        If sfdSaida.ShowDialog = DialogResult.OK Then
            txtPathSalvamento.Text = sfdSaida.FileName
        End If
    End Sub

    Private Sub btnSelecionarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionarXML.Click
        'configurar os filtros do seletor de arquivo
        ofdEntrada.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
        ofdEntrada.FilterIndex = 2

        'selecionar o arquivo e guardar seu diretório no lblAquivoSelecionadoConteudo
        If ofdEntrada.ShowDialog = DialogResult.OK Then
            lblAquivoSelecionadoConteudo.Text = ofdEntrada.FileName
        End If

        'exibir o botão de filtros de processamento
        btnFiltro.Visible = True
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        'exibir janela de filtros
        TabControlFiltro.Visible = Not TabControlFiltro.Visible
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        'chamar método de limpeza de filtros
        limpaFiltros()
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
        Util.TextBoxMoeda(txtValorLicenciamento)
    End Sub

    Private Sub btnProcessarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessarArquivo.Click

    End Sub
End Class