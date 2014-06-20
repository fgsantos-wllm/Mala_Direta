Public Class Filtro

    '-------------------------------------------------------------------------------------------------------------------
    'CONSTRUTORES
    '-------------------------------------------------------------------------------------------------------------------
    'inicializar classe com atributos zerados
    Public Sub New()
        Me.anoLic = Now.Year
        Me.valorLic = 0
        Me.mudouProprietario = "-"
        Me.restricao = "-"
    End Sub

    'inicializar atributos na chama da classe
    Public Sub New(ByVal anoLic As Integer, ByVal valorLic As Integer, ByVal mudouProprietario As String, ByVal restricao As String)
        Me.anoLic = anoLic
        Me.valorLic = valorLic
        Me.mudouProprietario = mudouProprietario
        Me.restricao = restricao
    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private anoLic As Integer '<=
    Private valorLic As Integer '>=
    Private mudouProprietario As String 'S/N/-
    Private restricao As String 'S/N/-

    '-------------------------------------------------------------------------------------------------------------------
    'GETTERS AND SETTERS
    '-------------------------------------------------------------------------------------------------------------------
    Public Property acAnoLic As Integer
        Get
            Return Me.anoLic
        End Get
        Set(ByVal value As Integer)
            Me.anoLic = value
        End Set
    End Property
    Public Property acValorLic As Integer
        Get
            Return Me.valorLic
        End Get
        Set(ByVal value As Integer)
            Me.valorLic = value
        End Set
    End Property
    Public Property acMudouProprietario As String
        Get
            Return Me.mudouProprietario
        End Get
        Set(ByVal value As String)
            Me.mudouProprietario = value
        End Set
    End Property
    Public Property acRestricao As String
        Get
            Return Me.restricao
        End Get
        Set(ByVal value As String)
            Me.restricao = value
        End Set
    End Property

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------


End Class
