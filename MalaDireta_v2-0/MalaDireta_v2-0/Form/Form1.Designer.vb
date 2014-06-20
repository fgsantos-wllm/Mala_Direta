<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConf = New System.Windows.Forms.Button()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.txtCaminhoEntrada = New System.Windows.Forms.TextBox()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.ofdEntrada = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaida = New System.Windows.Forms.SaveFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.txtCaminhoSaida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowseSaida = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtValorLicenciamento = New System.Windows.Forms.MaskedTextBox()
        Me.lblValorLicenciamento = New System.Windows.Forms.Label()
        Me.cboVeiculoRestricao = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboMudouProprietario = New System.Windows.Forms.ComboBox()
        Me.lblMesmoProprietario = New System.Windows.Forms.Label()
        Me.txtAnoLicenciamento = New System.Windows.Forms.MaskedTextBox()
        Me.lblAnoLic = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(1105, 27)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(82, 70)
        Me.btnConf.TabIndex = 2
        Me.btnConf.Text = "Configuração"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(39, 170)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(75, 13)
        Me.lblEntrada.TabIndex = 5
        Me.lblEntrada.Text = "Arquivo (.xlsx):"
        '
        'txtCaminhoEntrada
        '
        Me.txtCaminhoEntrada.Location = New System.Drawing.Point(120, 167)
        Me.txtCaminhoEntrada.Name = "txtCaminhoEntrada"
        Me.txtCaminhoEntrada.ReadOnly = True
        Me.txtCaminhoEntrada.Size = New System.Drawing.Size(528, 20)
        Me.txtCaminhoEntrada.TabIndex = 4
        Me.txtCaminhoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEntrada
        '
        Me.btnEntrada.Location = New System.Drawing.Point(654, 165)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrada.TabIndex = 3
        Me.btnEntrada.Text = "Procurar..."
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'ofdEntrada
        '
        Me.ofdEntrada.FileName = "OpenFileDialog1"
        Me.ofdEntrada.Title = "Planilha do Excel |*.xlsx |"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SELECIONE", "LICENCIAMENTO", "PAGAMENTO DE DÉBITOS", "CONSULTA OFFLINE"})
        Me.ComboBox1.Location = New System.Drawing.Point(556, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(422, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Serviço de Consulta?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 20)
        Me.TextBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(212, 81)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(517, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'txtCaminhoSaida
        '
        Me.txtCaminhoSaida.Location = New System.Drawing.Point(212, 29)
        Me.txtCaminhoSaida.Name = "txtCaminhoSaida"
        Me.txtCaminhoSaida.Size = New System.Drawing.Size(436, 20)
        Me.txtCaminhoSaida.TabIndex = 4
        Me.txtCaminhoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Loja:"
        '
        'btnBrowseSaida
        '
        Me.btnBrowseSaida.Location = New System.Drawing.Point(654, 27)
        Me.btnBrowseSaida.Name = "btnBrowseSaida"
        Me.btnBrowseSaida.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseSaida.TabIndex = 3
        Me.btnBrowseSaida.Text = "Procurar..."
        Me.btnBrowseSaida.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome/Referencia de Saída:"
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(39, 32)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(152, 13)
        Me.lblDestino.TabIndex = 5
        Me.lblDestino.Text = "Salvar resultado no local:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(697, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "_________________________________________________________________________________" & _
            "__________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(768, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 168)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(777, 160)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(274, 23)
        Me.btnLimpar.TabIndex = 22
        Me.btnLimpar.Text = "Limpar Filtros"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'txtValorLicenciamento
        '
        Me.txtValorLicenciamento.Location = New System.Drawing.Point(1011, 125)
        Me.txtValorLicenciamento.Mask = "#####"
        Me.txtValorLicenciamento.Name = "txtValorLicenciamento"
        Me.txtValorLicenciamento.Size = New System.Drawing.Size(40, 20)
        Me.txtValorLicenciamento.TabIndex = 20
        '
        'lblValorLicenciamento
        '
        Me.lblValorLicenciamento.AutoSize = True
        Me.lblValorLicenciamento.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblValorLicenciamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorLicenciamento.Location = New System.Drawing.Point(774, 128)
        Me.lblValorLicenciamento.Name = "lblValorLicenciamento"
        Me.lblValorLicenciamento.Size = New System.Drawing.Size(238, 13)
        Me.lblValorLicenciamento.TabIndex = 26
        Me.lblValorLicenciamento.Text = "Valor de Licenciamento maior ou igual a:"
        '
        'cboVeiculoRestricao
        '
        Me.cboVeiculoRestricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVeiculoRestricao.FormattingEnabled = True
        Me.cboVeiculoRestricao.Items.AddRange(New Object() {"TODOS", "N", "S"})
        Me.cboVeiculoRestricao.Location = New System.Drawing.Point(957, 90)
        Me.cboVeiculoRestricao.Name = "cboVeiculoRestricao"
        Me.cboVeiculoRestricao.Size = New System.Drawing.Size(94, 21)
        Me.cboVeiculoRestricao.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(774, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Gerar veículo com Restrição?"
        '
        'cboMudouProprietario
        '
        Me.cboMudouProprietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMudouProprietario.FormattingEnabled = True
        Me.cboMudouProprietario.Items.AddRange(New Object() {"TODOS", "N", "S"})
        Me.cboMudouProprietario.Location = New System.Drawing.Point(976, 55)
        Me.cboMudouProprietario.Name = "cboMudouProprietario"
        Me.cboMudouProprietario.Size = New System.Drawing.Size(75, 21)
        Me.cboMudouProprietario.TabIndex = 18
        '
        'lblMesmoProprietario
        '
        Me.lblMesmoProprietario.AutoSize = True
        Me.lblMesmoProprietario.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMesmoProprietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesmoProprietario.Location = New System.Drawing.Point(774, 62)
        Me.lblMesmoProprietario.Name = "lblMesmoProprietario"
        Me.lblMesmoProprietario.Size = New System.Drawing.Size(196, 13)
        Me.lblMesmoProprietario.TabIndex = 24
        Me.lblMesmoProprietario.Text = "Mudou o Proprietário do Veiculo?"
        '
        'txtAnoLicenciamento
        '
        Me.txtAnoLicenciamento.Location = New System.Drawing.Point(1011, 24)
        Me.txtAnoLicenciamento.Mask = "####"
        Me.txtAnoLicenciamento.Name = "txtAnoLicenciamento"
        Me.txtAnoLicenciamento.Size = New System.Drawing.Size(40, 20)
        Me.txtAnoLicenciamento.TabIndex = 17
        '
        'lblAnoLic
        '
        Me.lblAnoLic.AutoSize = True
        Me.lblAnoLic.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAnoLic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnoLic.Location = New System.Drawing.Point(774, 27)
        Me.lblAnoLic.Name = "lblAnoLic"
        Me.lblAnoLic.Size = New System.Drawing.Size(235, 13)
        Me.lblAnoLic.TabIndex = 23
        Me.lblAnoLic.Text = "Ano de Licenciamento menor ou igual a:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(765, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Filtros:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1200, 403)
        Me.DataGridView1.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Processar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(905, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(537, 224)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(293, 46)
        Me.ProgressBar1.TabIndex = 29
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(42, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "XML Padrão"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(129, 224)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "XML Filtrado"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(256, 247)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox3.TabIndex = 30
        Me.CheckBox3.Text = "Somente Formatação"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(129, 247)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(121, 17)
        Me.CheckBox4.TabIndex = 30
        Me.CheckBox4.Text = "XML Mailing Filtrado"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(256, 224)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(168, 17)
        Me.CheckBox5.TabIndex = 30
        Me.CheckBox5.Text = "Somente Data de Nascimento"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(851, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "0%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(836, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "0/TOTAL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 691)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtValorLicenciamento)
        Me.Controls.Add(Me.lblValorLicenciamento)
        Me.Controls.Add(Me.cboVeiculoRestricao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboMudouProprietario)
        Me.Controls.Add(Me.lblMesmoProprietario)
        Me.Controls.Add(Me.txtAnoLicenciamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAnoLic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCaminhoEntrada)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.btnBrowseSaida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCaminhoSaida)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents txtCaminhoEntrada As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrada As System.Windows.Forms.Button
    Friend WithEvents ofdEntrada As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaida As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtCaminhoSaida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseSaida As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtValorLicenciamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblValorLicenciamento As System.Windows.Forms.Label
    Friend WithEvents cboVeiculoRestricao As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboMudouProprietario As System.Windows.Forms.ComboBox
    Friend WithEvents lblMesmoProprietario As System.Windows.Forms.Label
    Friend WithEvents txtAnoLicenciamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAnoLic As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
