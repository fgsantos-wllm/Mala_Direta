Public Class CA_pessoa_logradouro
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

  Public Function Busca_CEP(ByRef objDT As DataTable, ByVal CEP As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_cidade_logradouro_SELECT_CEP"
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

  Public Function Insert(ByVal PESS_ID_PESSOA As String, ByVal CILO_ID_CIDADE_LOGRADOURO As String, ByVal TILO_ID_TIPO_LOGRADOURO As String, ByVal PELO_TX_LOGRADOURO As String, ByVal PELO_NR_LOGRADOURO As String, ByVal PELO_TX_COMPLEMENTO As String, ByVal PELO_TX_BAIRRO As String, ByVal PELO_TX_CEP As String, ByVal UF_ID_UF As String) As Integer

    Try

      Dim strSql As String = "CA_sp_pessoa_logradouro_INSERT"
      _FunctionsDB.MontaSQL(strSql, PESS_ID_PESSOA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, CILO_ID_CIDADE_LOGRADOURO, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, TILO_ID_TIPO_LOGRADOURO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, PELO_TX_LOGRADOURO.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, PELO_NR_LOGRADOURO, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, PELO_TX_COMPLEMENTO.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, PELO_TX_BAIRRO.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, PELO_TX_CEP, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, UF_ID_UF.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Grid(ByRef objDT As DataTable, ByVal PESS_ID_PESSOA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_logradouro_SELECT_grid"
      _FunctionsDB.MontaSQL(strSql, PESS_ID_PESSOA, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Delete(ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_logradouro_DELETE_pess_id_pessoa"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_One(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_logradouro_SELECT_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_By_PESS_ID_PESSOA(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_logradouro_SELECT_pess_id_pessoa"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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
