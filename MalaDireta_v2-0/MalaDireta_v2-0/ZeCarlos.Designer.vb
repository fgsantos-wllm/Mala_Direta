<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZeCarlos
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
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.lblCaminhoEntrada = New System.Windows.Forms.TextBox()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.ofdEntrada = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colPlaca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMunicipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChassi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnProcessa = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEntrada
        '
        Me.btnEntrada.Location = New System.Drawing.Point(532, 12)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrada.TabIndex = 0
        Me.btnEntrada.Text = "Procurar..."
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'lblCaminhoEntrada
        '
        Me.lblCaminhoEntrada.Location = New System.Drawing.Point(90, 14)
        Me.lblCaminhoEntrada.Name = "lblCaminhoEntrada"
        Me.lblCaminhoEntrada.ReadOnly = True
        Me.lblCaminhoEntrada.Size = New System.Drawing.Size(436, 20)
        Me.lblCaminhoEntrada.TabIndex = 1
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(12, 17)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(72, 13)
        Me.lblEntrada.TabIndex = 2
        Me.lblEntrada.Text = "Arquivo (.xlsx)"
        '
        'ofdEntrada
        '
        Me.ofdEntrada.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPlaca, Me.colDocumento, Me.colNome, Me.colMunicipio, Me.colChassi})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 335)
        Me.DataGridView1.TabIndex = 3
        '
        'colPlaca
        '
        Me.colPlaca.HeaderText = "Placa"
        Me.colPlaca.Name = "colPlaca"
        '
        'colDocumento
        '
        Me.colDocumento.HeaderText = "Documento"
        Me.colDocumento.Name = "colDocumento"
        '
        'colNome
        '
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        '
        'colMunicipio
        '
        Me.colMunicipio.HeaderText = "Município"
        Me.colMunicipio.Name = "colMunicipio"
        '
        'colChassi
        '
        Me.colChassi.HeaderText = "Chassi"
        Me.colChassi.Name = "colChassi"
        '
        'btnProcessa
        '
        Me.btnProcessa.Location = New System.Drawing.Point(15, 41)
        Me.btnProcessa.Name = "btnProcessa"
        Me.btnProcessa.Size = New System.Drawing.Size(592, 23)
        Me.btnProcessa.TabIndex = 0
        Me.btnProcessa.Text = "Processar..."
        Me.btnProcessa.UseVisualStyleBackColor = True
        '
        'ZeCarlos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.lblCaminhoEntrada)
        Me.Controls.Add(Me.btnProcessa)
        Me.Controls.Add(Me.btnEntrada)
        Me.Name = "ZeCarlos"
        Me.Text = "ZeCarlos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEntrada As System.Windows.Forms.Button
    Friend WithEvents lblCaminhoEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents ofdEntrada As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents colPlaca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMunicipio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChassi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnProcessa As System.Windows.Forms.Button
End Class
