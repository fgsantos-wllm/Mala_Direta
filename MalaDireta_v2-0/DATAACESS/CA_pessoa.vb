Public Class CA_pessoa
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

  Public Function Grid(ByRef objDt As DataTable, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_pessoa_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "CA_sp_pessoa_SELECT_grid"
      End If

      objDt = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Grid(ByRef objDT As DataTable, ByVal strCriterio As String, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_pessoa_SELECT_busca;2 '" & strCriterio & "', '" & strFiltro & "'"
      Else
        strSql = "CA_sp_pessoa_SELECT_busca;2 '" & strCriterio & "', '" & strFiltro & "'"
      End If

      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Grid_Atendimento(ByRef objDT As DataTable, ByVal strCriterio As String, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_pessoa_SELECT_busca;2 '" & strCriterio & "', '" & strFiltro & "'"
      Else
        strSql = "CA_sp_pessoa_SELECT_busca;2 '" & strCriterio & "', '" & strFiltro & "'"
      End If

      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_One(ByRef objDt As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_SELECT_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDt = _AccessData.ExecQueryDt(strSql)

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

      Dim strSql As String = "CA_sp_pessoa_DELETE_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal pess_tx_nome As String, ByVal pess_in_tipopessoa As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_UPDATE"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_tipopessoa, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal pess_tx_nome As String, ByVal pess_in_tipopessoa As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String) As Integer

    Try

      Dim strSql As String = "CA_sp_pessoa_INSERT "
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_tipopessoa, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
