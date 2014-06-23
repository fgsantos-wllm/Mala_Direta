<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.grpProcessamento = New System.Windows.Forms.GroupBox()
        Me.TabControlFiltro = New System.Windows.Forms.TabControl()
        Me.Filtro = New System.Windows.Forms.TabPage()
        Me.txtValorLicenciamento = New System.Windows.Forms.TextBox()
        Me.btnFecharTabFiltro = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.lblValorLicenciamento = New System.Windows.Forms.Label()
        Me.cboVeiculoRestricao = New System.Windows.Forms.ComboBox()
        Me.lblVeiculoRestricao = New System.Windows.Forms.Label()
        Me.cboMudouProprietario = New System.Windows.Forms.ComboBox()
        Me.lblMesmoProprietario = New System.Windows.Forms.Label()
        Me.txtAnoLicenciamento = New System.Windows.Forms.MaskedTextBox()
        Me.lblAnoLic = New System.Windows.Forms.Label()
        Me.dtgSaida = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDatanasc = New System.Windows.Forms.CheckBox()
        Me.chkFormatarApenas = New System.Windows.Forms.CheckBox()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.lblStatusAtual = New System.Windows.Forms.Label()
        Me.lblRenavamAtual = New System.Windows.Forms.Label()
        Me.chkGerarArquivoPadraoFiltrado = New System.Windows.Forms.CheckBox()
        Me.chkGerarArquivoMailing = New System.Windows.Forms.CheckBox()
        Me.chkGerarArquivoPadrao = New System.Windows.Forms.CheckBox()
        Me.btnFiltro = New System.Windows.Forms.Button()
        Me.lblProgressSaveCount = New System.Windows.Forms.Label()
        Me.lblProgressCount = New System.Windows.Forms.Label()
        Me.ProgressBarSave = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.grpLocalExtracao = New System.Windows.Forms.GroupBox()
        Me.cboLoja = New System.Windows.Forms.ComboBox()
        Me.lblLoja = New System.Windows.Forms.Label()
        Me.btnBrowseSaida = New System.Windows.Forms.Button()
        Me.cboServico = New System.Windows.Forms.ComboBox()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.txtNomeReferencia = New System.Windows.Forms.TextBox()
        Me.lblNomeReferencia = New System.Windows.Forms.Label()
        Me.lblLocalExtracao = New System.Windows.Forms.Label()
        Me.txtPathSalvamento = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArquivoSelecionadoConteudo = New System.Windows.Forms.Label()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.btnSelecionarXML = New System.Windows.Forms.Button()
        Me.btnProcessarArquivo = New System.Windows.Forms.Button()
        Me.ofdEntrada = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaida = New System.Windows.Forms.SaveFileDialog()
        Me.fbdSaida = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpProcessamento.SuspendLayout()
        Me.TabControlFiltro.SuspendLayout()
        Me.Filtro.SuspendLayout()
        CType(Me.dtgSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpLocalExtracao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProcessamento
        '
        Me.grpProcessamento.Controls.Add(Me.TabControlFiltro)
        Me.grpProcessamento.Controls.Add(Me.dtgSaida)
        Me.grpProcessamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpProcessamento.Location = New System.Drawing.Point(0, 257)
        Me.grpProcessamento.Name = "grpProcessamento"
        Me.grpProcessamento.Size = New System.Drawing.Size(1112, 444)
        Me.grpProcessamento.TabIndex = 1
        Me.grpProcessamento.TabStop = False
        Me.grpProcessamento.Text = "Resultado do Processamento:"
        '
        'TabControlFiltro
        '
        Me.TabControlFiltro.Controls.Add(Me.Filtro)
        Me.TabControlFiltro.Location = New System.Drawing.Point(6, 19)
        Me.TabControlFiltro.Name = "TabControlFiltro"
        Me.TabControlFiltro.SelectedIndex = 0
        Me.TabControlFiltro.Size = New System.Drawing.Size(337, 242)
        Me.TabControlFiltro.TabIndex = 0
        Me.TabControlFiltro.Visible = False
        '
        'Filtro
        '
        Me.Filtro.Controls.Add(Me.txtValorLicenciamento)
        Me.Filtro.Controls.Add(Me.btnFecharTabFiltro)
        Me.Filtro.Controls.Add(Me.btnLimpar)
        Me.Filtro.Controls.Add(Me.lblValorLicenciamento)
        Me.Filtro.Controls.Add(Me.cboVeiculoRestricao)
        Me.Filtro.Controls.Add(Me.lblVeiculoRestricao)
        Me.Filtro.Controls.Add(Me.cboMudouProprietario)
        Me.Filtro.Controls.Add(Me.lblMesmoProprietario)
        Me.Filtro.Controls.Add(Me.txtAnoLicenciamento)
        Me.Filtro.Controls.Add(Me.lblAnoLic)
        Me.Filtro.Location = New System.Drawing.Point(4, 22)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Padding = New System.Windows.Forms.Padding(3)
        Me.Filtro.Size = New System.Drawing.Size(329, 216)
        Me.Filtro.TabIndex = 0
        Me.Filtro.Text = "Filtro"
        Me.Filtro.UseVisualStyleBackColor = True
        '
        'txtValorLicenciamento
        '
        Me.txtValorLicenciamento.Location = New System.Drawing.Point(259, 125)
        Me.txtValorLicenciamento.Name = "txtValorLicenciamento"
        Me.txtValorLicenciamento.Size = New System.Drawing.Size(48, 20)
        Me.txtValorLicenciamento.TabIndex = 3
        '
        'btnFecharTabFiltro
        '
        Me.btnFecharTabFiltro.Location = New System.Drawing.Point(182, 170)
        Me.btnFecharTabFiltro.Name = "btnFecharTabFiltro"
        Me.btnFecharTabFiltro.Size = New System.Drawing.Size(117, 23)
        Me.btnFecharTabFiltro.TabIndex = 5
        Me.btnFecharTabFiltro.Text = "[Fechar/SALVAR]"
        Me.btnFecharTabFiltro.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(25, 170)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(117, 23)
        Me.btnLimpar.TabIndex = 4
        Me.btnLimpar.Text = "Limpar Filtros"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'lblValorLicenciamento
        '
        Me.lblValorLicenciamento.AutoSize = True
        Me.lblValorLicenciamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorLicenciamento.Location = New System.Drawing.Point(22, 128)
        Me.lblValorLicenciamento.Name = "lblValorLicenciamento"
        Me.lblValorLicenciamento.Size = New System.Drawing.Size(238, 13)
        Me.lblValorLicenciamento.TabIndex = 11
        Me.lblValorLicenciamento.Text = "Valor de Licenciamento maior ou igual a:"
        '
        'cboVeiculoRestricao
        '
        Me.cboVeiculoRestricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVeiculoRestricao.FormattingEnabled = True
        Me.cboVeiculoRestricao.Items.AddRange(New Object() {"-", "S", "N"})
        Me.cboVeiculoRestricao.Location = New System.Drawing.Point(259, 90)
        Me.cboVeiculoRestricao.Name = "cboVeiculoRestricao"
        Me.cboVeiculoRestricao.Size = New System.Drawing.Size(48, 21)
        Me.cboVeiculoRestricao.TabIndex = 2
        '
        'lblVeiculoRestricao
        '
        Me.lblVeiculoRestricao.AutoSize = True
        Me.lblVeiculoRestricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeiculoRestricao.Location = New System.Drawing.Point(22, 93)
        Me.lblVeiculoRestricao.Name = "lblVeiculoRestricao"
        Me.lblVeiculoRestricao.Size = New System.Drawing.Size(177, 13)
        Me.lblVeiculoRestricao.TabIndex = 9
        Me.lblVeiculoRestricao.Text = "Gerar veículo com Restrição?"
        '
        'cboMudouProprietario
        '
        Me.cboMudouProprietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMudouProprietario.FormattingEnabled = True
        Me.cboMudouProprietario.Items.AddRange(New Object() {"-", "S", "N"})
        Me.cboMudouProprietario.Location = New System.Drawing.Point(259, 54)
        Me.cboMudouProprietario.Name = "cboMudouProprietario"
        Me.cboMudouProprietario.Size = New System.Drawing.Size(48, 21)
        Me.cboMudouProprietario.TabIndex = 1
        '
        'lblMesmoProprietario
        '
        Me.lblMesmoProprietario.AutoSize = True
        Me.lblMesmoProprietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesmoProprietario.Location = New System.Drawing.Point(22, 62)
        Me.lblMesmoProprietario.Name = "lblMesmoProprietario"
        Me.lblMesmoProprietario.Size = New System.Drawing.Size(196, 13)
        Me.lblMesmoProprietario.TabIndex = 7
        Me.lblMesmoProprietario.Text = "Mudou o Proprietário do Veiculo?"
        '
        'txtAnoLicenciamento
        '
        Me.txtAnoLicenciamento.Location = New System.Drawing.Point(259, 20)
        Me.txtAnoLicenciamento.Mask = "####"
        Me.txtAnoLicenciamento.Name = "txtAnoLicenciamento"
        Me.txtAnoLicenciamento.Size = New System.Drawing.Size(48, 20)
        Me.txtAnoLicenciamento.TabIndex = 0
        Me.txtAnoLicenciamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAnoLic
        '
        Me.lblAnoLic.AutoSize = True
        Me.lblAnoLic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnoLic.Location = New System.Drawing.Point(22, 27)
        Me.lblAnoLic.Name = "lblAnoLic"
        Me.lblAnoLic.Size = New System.Drawing.Size(235, 13)
        Me.lblAnoLic.TabIndex = 5
        Me.lblAnoLic.Text = "Ano de Licenciamento menor ou igual a:"
        '
        'dtgSaida
        '
        Me.dtgSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgSaida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSaida.ColumnHeadersVisible = False
        Me.dtgSaida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgSaida.Location = New System.Drawing.Point(3, 16)
        Me.dtgSaida.Name = "dtgSaida"
        Me.dtgSaida.ReadOnly = True
        Me.dtgSaida.Size = New System.Drawing.Size(1106, 425)
        Me.dtgSaida.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDatanasc)
        Me.GroupBox2.Controls.Add(Me.chkFormatarApenas)
        Me.GroupBox2.Controls.Add(Me.btnAbort)
        Me.GroupBox2.Controls.Add(Me.lblStatusAtual)
        Me.GroupBox2.Controls.Add(Me.lblRenavamAtual)
        Me.GroupBox2.Controls.Add(Me.chkGerarArquivoPadraoFiltrado)
        Me.GroupBox2.Controls.Add(Me.chkGerarArquivoMailing)
        Me.GroupBox2.Controls.Add(Me.chkGerarArquivoPadrao)
        Me.GroupBox2.Controls.Add(Me.btnFiltro)
        Me.GroupBox2.Controls.Add(Me.lblProgressSaveCount)
        Me.GroupBox2.Controls.Add(Me.lblProgressCount)
        Me.GroupBox2.Controls.Add(Me.ProgressBarSave)
        Me.GroupBox2.Controls.Add(Me.ProgressBar)
        Me.GroupBox2.Controls.Add(Me.grpLocalExtracao)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.btnSelecionarXML)
        Me.GroupBox2.Controls.Add(Me.btnProcessarArquivo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1112, 257)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'chkDatanasc
        '
        Me.chkDatanasc.AutoSize = True
        Me.chkDatanasc.Location = New System.Drawing.Point(657, 208)
        Me.chkDatanasc.Name = "chkDatanasc"
        Me.chkDatanasc.Size = New System.Drawing.Size(111, 17)
        Me.chkDatanasc.TabIndex = 7
        Me.chkDatanasc.Text = "Apenas Datanasc"
        Me.chkDatanasc.UseVisualStyleBackColor = True
        Me.chkDatanasc.Visible = False
        '
        'chkFormatarApenas
        '
        Me.chkFormatarApenas.AutoSize = True
        Me.chkFormatarApenas.Location = New System.Drawing.Point(657, 184)
        Me.chkFormatarApenas.Name = "chkFormatarApenas"
        Me.chkFormatarApenas.Size = New System.Drawing.Size(106, 17)
        Me.chkFormatarApenas.TabIndex = 6
        Me.chkFormatarApenas.Text = "Apenas Formatar"
        Me.chkFormatarApenas.UseVisualStyleBackColor = True
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(989, 217)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(111, 30)
        Me.btnAbort.TabIndex = 9
        Me.btnAbort.Text = "Abortar e Salvar"
        Me.btnAbort.UseVisualStyleBackColor = True
        Me.btnAbort.Visible = False
        '
        'lblStatusAtual
        '
        Me.lblStatusAtual.AutoSize = True
        Me.lblStatusAtual.Location = New System.Drawing.Point(986, 197)
        Me.lblStatusAtual.Name = "lblStatusAtual"
        Me.lblStatusAtual.Size = New System.Drawing.Size(58, 13)
        Me.lblStatusAtual.TabIndex = 16
        Me.lblStatusAtual.Text = "Status: xxx"
        Me.lblStatusAtual.Visible = False
        '
        'lblRenavamAtual
        '
        Me.lblRenavamAtual.AutoSize = True
        Me.lblRenavamAtual.Location = New System.Drawing.Point(986, 177)
        Me.lblRenavamAtual.Name = "lblRenavamAtual"
        Me.lblRenavamAtual.Size = New System.Drawing.Size(114, 13)
        Me.lblRenavamAtual.TabIndex = 16
        Me.lblRenavamAtual.Text = "Renavam: xxxxxxxxxxx"
        Me.lblRenavamAtual.Visible = False
        '
        'chkGerarArquivoPadraoFiltrado
        '
        Me.chkGerarArquivoPadraoFiltrado.AutoSize = True
        Me.chkGerarArquivoPadraoFiltrado.Location = New System.Drawing.Point(426, 207)
        Me.chkGerarArquivoPadraoFiltrado.Name = "chkGerarArquivoPadraoFiltrado"
        Me.chkGerarArquivoPadraoFiltrado.Size = New System.Drawing.Size(228, 17)
        Me.chkGerarArquivoPadraoFiltrado.TabIndex = 4
        Me.chkGerarArquivoPadraoFiltrado.Text = "Gerar Aquivo XML Retorno Padrão Filtrado"
        Me.chkGerarArquivoPadraoFiltrado.UseVisualStyleBackColor = True
        '
        'chkGerarArquivoMailing
        '
        Me.chkGerarArquivoMailing.AutoSize = True
        Me.chkGerarArquivoMailing.Location = New System.Drawing.Point(426, 230)
        Me.chkGerarArquivoMailing.Name = "chkGerarArquivoMailing"
        Me.chkGerarArquivoMailing.Size = New System.Drawing.Size(189, 17)
        Me.chkGerarArquivoMailing.TabIndex = 5
        Me.chkGerarArquivoMailing.Text = "Gerar Arquivo XML Mailing Filtrado"
        Me.chkGerarArquivoMailing.UseVisualStyleBackColor = True
        '
        'chkGerarArquivoPadrao
        '
        Me.chkGerarArquivoPadrao.AutoSize = True
        Me.chkGerarArquivoPadrao.Location = New System.Drawing.Point(426, 184)
        Me.chkGerarArquivoPadrao.Name = "chkGerarArquivoPadrao"
        Me.chkGerarArquivoPadrao.Size = New System.Drawing.Size(191, 17)
        Me.chkGerarArquivoPadrao.TabIndex = 3
        Me.chkGerarArquivoPadrao.Text = "Gerar Aquivo XML Retorno Padrão"
        Me.chkGerarArquivoPadrao.UseVisualStyleBackColor = True
        '
        'btnFiltro
        '
        Me.btnFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFiltro.Location = New System.Drawing.Point(147, 184)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(92, 54)
        Me.btnFiltro.TabIndex = 2
        Me.btnFiltro.Text = "Ativar Filtro"
        Me.btnFiltro.UseVisualStyleBackColor = False
        Me.btnFiltro.Visible = False
        '
        'lblProgressSaveCount
        '
        Me.lblProgressSaveCount.AutoSize = True
        Me.lblProgressSaveCount.Location = New System.Drawing.Point(933, 226)
        Me.lblProgressSaveCount.Name = "lblProgressSaveCount"
        Me.lblProgressSaveCount.Size = New System.Drawing.Size(37, 13)
        Me.lblProgressSaveCount.TabIndex = 11
        Me.lblProgressSaveCount.Text = "xxxxxx"
        Me.lblProgressSaveCount.Visible = False
        '
        'lblProgressCount
        '
        Me.lblProgressCount.AutoSize = True
        Me.lblProgressCount.Location = New System.Drawing.Point(933, 185)
        Me.lblProgressCount.Name = "lblProgressCount"
        Me.lblProgressCount.Size = New System.Drawing.Size(37, 13)
        Me.lblProgressCount.TabIndex = 9
        Me.lblProgressCount.Text = "xxxxxx"
        Me.lblProgressCount.Visible = False
        '
        'ProgressBarSave
        '
        Me.ProgressBarSave.ForeColor = System.Drawing.Color.Cyan
        Me.ProgressBarSave.Location = New System.Drawing.Point(777, 216)
        Me.ProgressBarSave.Name = "ProgressBarSave"
        Me.ProgressBarSave.Size = New System.Drawing.Size(138, 34)
        Me.ProgressBarSave.TabIndex = 10
        Me.ProgressBarSave.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar.Location = New System.Drawing.Point(777, 176)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(138, 34)
        Me.ProgressBar.TabIndex = 5
        Me.ProgressBar.Visible = False
        '
        'grpLocalExtracao
        '
        Me.grpLocalExtracao.Controls.Add(Me.cboLoja)
        Me.grpLocalExtracao.Controls.Add(Me.lblLoja)
        Me.grpLocalExtracao.Controls.Add(Me.btnBrowseSaida)
        Me.grpLocalExtracao.Controls.Add(Me.cboServico)
        Me.grpLocalExtracao.Controls.Add(Me.lblServico)
        Me.grpLocalExtracao.Controls.Add(Me.txtNomeReferencia)
        Me.grpLocalExtracao.Controls.Add(Me.lblNomeReferencia)
        Me.grpLocalExtracao.Controls.Add(Me.lblLocalExtracao)
        Me.grpLocalExtracao.Controls.Add(Me.txtPathSalvamento)
        Me.grpLocalExtracao.Location = New System.Drawing.Point(15, 12)
        Me.grpLocalExtracao.Name = "grpLocalExtracao"
        Me.grpLocalExtracao.Size = New System.Drawing.Size(1073, 113)
        Me.grpLocalExtracao.TabIndex = 0
        Me.grpLocalExtracao.TabStop = False
        '
        'cboLoja
        '
        Me.cboLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoja.FormattingEnabled = True
        Me.cboLoja.Items.AddRange(New Object() {"SELECIONE"})
        Me.cboLoja.Location = New System.Drawing.Point(187, 80)
        Me.cboLoja.Name = "cboLoja"
        Me.cboLoja.Size = New System.Drawing.Size(675, 21)
        Me.cboLoja.TabIndex = 4
        '
        'lblLoja
        '
        Me.lblLoja.AutoSize = True
        Me.lblLoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoja.Location = New System.Drawing.Point(139, 83)
        Me.lblLoja.Name = "lblLoja"
        Me.lblLoja.Size = New System.Drawing.Size(38, 13)
        Me.lblLoja.TabIndex = 13
        Me.lblLoja.Text = "Loja?"
        '
        'btnBrowseSaida
        '
        Me.btnBrowseSaida.Location = New System.Drawing.Point(787, 13)
        Me.btnBrowseSaida.Name = "btnBrowseSaida"
        Me.btnBrowseSaida.Size = New System.Drawing.Size(75, 26)
        Me.btnBrowseSaida.TabIndex = 1
        Me.btnBrowseSaida.Text = "Procurar..."
        Me.btnBrowseSaida.UseVisualStyleBackColor = True
        '
        'cboServico
        '
        Me.cboServico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServico.FormattingEnabled = True
        Me.cboServico.Items.AddRange(New Object() {"SELECIONE", "LICENCIAMENTO", "PAGAMENTO DE DÉBITOS", "CONSULTA OFFLINE"})
        Me.cboServico.Location = New System.Drawing.Point(698, 49)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Size = New System.Drawing.Size(164, 21)
        Me.cboServico.TabIndex = 3
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServico.Location = New System.Drawing.Point(564, 53)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(128, 13)
        Me.lblServico.TabIndex = 11
        Me.lblServico.Text = "Serviço de Consulta?"
        '
        'txtNomeReferencia
        '
        Me.txtNomeReferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomeReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeReferencia.Location = New System.Drawing.Point(188, 46)
        Me.txtNomeReferencia.Name = "txtNomeReferencia"
        Me.txtNomeReferencia.Size = New System.Drawing.Size(370, 26)
        Me.txtNomeReferencia.TabIndex = 2
        '
        'lblNomeReferencia
        '
        Me.lblNomeReferencia.AutoSize = True
        Me.lblNomeReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeReferencia.Location = New System.Drawing.Point(15, 54)
        Me.lblNomeReferencia.Name = "lblNomeReferencia"
        Me.lblNomeReferencia.Size = New System.Drawing.Size(167, 13)
        Me.lblNomeReferencia.TabIndex = 8
        Me.lblNomeReferencia.Text = "Nome/Referencia de Saída:"
        '
        'lblLocalExtracao
        '
        Me.lblLocalExtracao.AutoSize = True
        Me.lblLocalExtracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalExtracao.Location = New System.Drawing.Point(29, 19)
        Me.lblLocalExtracao.Name = "lblLocalExtracao"
        Me.lblLocalExtracao.Size = New System.Drawing.Size(152, 13)
        Me.lblLocalExtracao.TabIndex = 7
        Me.lblLocalExtracao.Text = "Salvar resultado no local:"
        '
        'txtPathSalvamento
        '
        Me.txtPathSalvamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPathSalvamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathSalvamento.Location = New System.Drawing.Point(188, 12)
        Me.txtPathSalvamento.Name = "txtPathSalvamento"
        Me.txtPathSalvamento.Size = New System.Drawing.Size(593, 26)
        Me.txtPathSalvamento.TabIndex = 0
        Me.txtPathSalvamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArquivoSelecionadoConteudo)
        Me.GroupBox1.Controls.Add(Me.lblArquivo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblArquivoSelecionadoConteudo
        '
        Me.lblArquivoSelecionadoConteudo.AutoSize = True
        Me.lblArquivoSelecionadoConteudo.Location = New System.Drawing.Point(149, 20)
        Me.lblArquivoSelecionadoConteudo.Name = "lblArquivoSelecionadoConteudo"
        Me.lblArquivoSelecionadoConteudo.Size = New System.Drawing.Size(16, 13)
        Me.lblArquivoSelecionadoConteudo.TabIndex = 5
        Me.lblArquivoSelecionadoConteudo.Text = "..."
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArquivo.Location = New System.Drawing.Point(15, 20)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(128, 13)
        Me.lblArquivo.TabIndex = 4
        Me.lblArquivo.Text = "Arquivo Selecionado:"
        '
        'btnSelecionarXML
        '
        Me.btnSelecionarXML.Location = New System.Drawing.Point(15, 184)
        Me.btnSelecionarXML.Name = "btnSelecionarXML"
        Me.btnSelecionarXML.Size = New System.Drawing.Size(126, 54)
        Me.btnSelecionarXML.TabIndex = 1
        Me.btnSelecionarXML.Text = "1) Selecione o arquivo Excel (XLS)"
        Me.btnSelecionarXML.UseVisualStyleBackColor = True
        '
        'btnProcessarArquivo
        '
        Me.btnProcessarArquivo.Location = New System.Drawing.Point(245, 184)
        Me.btnProcessarArquivo.Name = "btnProcessarArquivo"
        Me.btnProcessarArquivo.Size = New System.Drawing.Size(124, 54)
        Me.btnProcessarArquivo.TabIndex = 8
        Me.btnProcessarArquivo.Text = "2) Processar Arquivo"
        Me.btnProcessarArquivo.UseVisualStyleBackColor = True
        '
        'ofdEntrada
        '
        Me.ofdEntrada.FileName = "OpenFileDialog1"
        Me.ofdEntrada.Title = "Planilha do Excel |*.xlsx |"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 701)
        Me.Controls.Add(Me.grpProcessamento)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Processador de Débitos de Véiculos - Retorna formato para processamento de Mala D" & _
            "ireta v2.1"
        Me.grpProcessamento.ResumeLayout(False)
        Me.TabControlFiltro.ResumeLayout(False)
        Me.Filtro.ResumeLayout(False)
        Me.Filtro.PerformLayout()
        CType(Me.dtgSaida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpLocalExtracao.ResumeLayout(False)
        Me.grpLocalExtracao.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpProcessamento As System.Windows.Forms.GroupBox
    Friend WithEvents TabControlFiltro As System.Windows.Forms.TabControl
    Friend WithEvents Filtro As System.Windows.Forms.TabPage
    Friend WithEvents btnFecharTabFiltro As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents lblValorLicenciamento As System.Windows.Forms.Label
    Friend WithEvents cboVeiculoRestricao As System.Windows.Forms.ComboBox
    Friend WithEvents lblVeiculoRestricao As System.Windows.Forms.Label
    Friend WithEvents cboMudouProprietario As System.Windows.Forms.ComboBox
    Friend WithEvents lblMesmoProprietario As System.Windows.Forms.Label
    Friend WithEvents txtAnoLicenciamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAnoLic As System.Windows.Forms.Label
    Friend WithEvents dtgSaida As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDatanasc As System.Windows.Forms.CheckBox
    Friend WithEvents chkFormatarApenas As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents lblStatusAtual As System.Windows.Forms.Label
    Friend WithEvents lblRenavamAtual As System.Windows.Forms.Label
    Friend WithEvents chkGerarArquivoPadraoFiltrado As System.Windows.Forms.CheckBox
    Friend WithEvents chkGerarArquivoMailing As System.Windows.Forms.CheckBox
    Friend WithEvents chkGerarArquivoPadrao As System.Windows.Forms.CheckBox
    Friend WithEvents btnFiltro As System.Windows.Forms.Button
    Friend WithEvents lblProgressSaveCount As System.Windows.Forms.Label
    Friend WithEvents lblProgressCount As System.Windows.Forms.Label
    Friend WithEvents ProgressBarSave As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents grpLocalExtracao As System.Windows.Forms.GroupBox
    Friend WithEvents cboLoja As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoja As System.Windows.Forms.Label
    Friend WithEvents cboServico As System.Windows.Forms.ComboBox
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents txtNomeReferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblNomeReferencia As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArquivoSelecionadoConteudo As System.Windows.Forms.Label
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents btnSelecionarXML As System.Windows.Forms.Button
    Friend WithEvents btnProcessarArquivo As System.Windows.Forms.Button
    Friend WithEvents btnBrowseSaida As System.Windows.Forms.Button
    Friend WithEvents lblLocalExtracao As System.Windows.Forms.Label
    Friend WithEvents txtPathSalvamento As System.Windows.Forms.TextBox
    Friend WithEvents ofdEntrada As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaida As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtValorLicenciamento As System.Windows.Forms.TextBox
    Friend WithEvents fbdSaida As System.Windows.Forms.FolderBrowserDialog
End Class
