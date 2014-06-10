Public Class CA_localidade
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

  Public Function Select_UF(ByRef objDT As DataTable) As Boolean
    Try

      Dim strSql As String = "CA_sp_uf_SELECT_all"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Select_CEP(ByRef objDT As DataTable, ByVal CEP As String) As Boolean
    Try

      Dim strSql As String = "sp_busca_CEP"
      _FunctionsDB.MontaSQL(strSql, CEP, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_CIDADE_GERAL(ByRef objDT As DataTable, ByVal UF_SIGLA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_cidade_logradouro_SELECT_all"
      _FunctionsDB.MontaSQL(strSql, UF_SIGLA, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_CIDADE(ByRef objDT As DataTable, ByVal UF_SIGLA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_cidade_logradouro_SELECT_CILO_TX_UF"
      _FunctionsDB.MontaSQL(strSql, UF_SIGLA, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_ZONA(ByRef objDT As DataTable, ByVal ID_CIDADE As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_zona_SELECT_cilo_id_cidade_logradouro"
      _FunctionsDB.MontaSQL(strSql, ID_CIDADE, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_BAIRRO(ByRef objDT As DataTable, ByVal CI_CODIGO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_bairro_SELECT_CI_CODIGO"
      _FunctionsDB.MontaSQL(strSql, CI_CODIGO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class