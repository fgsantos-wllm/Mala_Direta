Public Class CA_painel_controle
  Inherits Base

  Private _COD_ERRO As Integer = 0
  Private _MSG_ERRO As String = ""

  Property COD_ERRO() As Integer
    Get
      COD_ERRO = _COD_ERRO
    End Get
    Set(ByVal value As Integer)
      _COD_ERRO = value
    End Set
  End Property

  Property MSG_ERRO() As String
    Get
      MSG_ERRO = _MSG_ERRO
    End Get
    Set(ByVal value As String)
      _MSG_ERRO = value
    End Set
  End Property

  Public Function Executar_Rotina(ByVal rotina As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_painel_controle_EXECUTAR_ROTINA"
      _FunctionsDB.MontaSQL(strSql, rotina, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

End Class
