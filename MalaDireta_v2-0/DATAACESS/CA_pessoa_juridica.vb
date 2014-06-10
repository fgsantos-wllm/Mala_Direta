Public Class CA_pessoa_juridica
  Inherits Base

  Private _COD_ERRO As Integer = 0
  Private _MSG_ERRO As String = ""

  Private _dta_pessoa As New CA_pessoa

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

  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_pessoa_juridica_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "CA_sp_pessoa_juridica_SELECT_grid"
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

  Public Function Select_One(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_juridica_SELECT_one"
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

  Public Function Select_By_CNPJ(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_juridica_SELECT_pepj_cd_cnpj"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
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

      Dim strSql As String = "CA_sp_pessoa_juridica_DELETE_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Update(ByVal pess_id_pessoa As String, ByVal pepj_tx_razaosocial As String, ByVal pepj_cd_cnpj As String, ByVal pepj_cd_inscricaoestadual As String, ByVal pess_tx_nome As String, ByVal pess_tx_email As String) As Boolean

    Try

      Update(pess_id_pessoa, pepj_tx_razaosocial, pepj_cd_cnpj, pepj_cd_inscricaoestadual)
      _dta_pessoa.Update(pess_id_pessoa, pess_tx_nome, "J", pess_tx_email, 0)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal pess_id_pessoa As String, ByVal pepj_tx_razaosocial As String, ByVal pepj_cd_cnpj As String, ByVal pepj_cd_inscricaoestadual As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_juridica_UPDATE"
      _FunctionsDB.MontaSQL(strSql, pess_id_pessoa, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, pepj_tx_razaosocial, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepj_cd_cnpj, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepj_cd_inscricaoestadual, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal pess_id_pessoa As String, ByVal pess_tx_nome As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String, ByVal pepj_tx_razaosocial As String, ByVal pepj_cd_cnpj As String, ByVal pepj_cd_inscricaoestadual As String) As Integer

    Try

      Dim strSql As String = "CA_sp_pessoa_juridica_INSERT_pess_id_pessoa "
      _FunctionsDB.MontaSQL(strSql, pess_id_pessoa, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, pepj_tx_razaosocial.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepj_cd_cnpj, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepj_cd_inscricaoestadual, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal pess_tx_nome As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String, ByVal pepj_tx_razaosocial As String, ByVal pepj_cd_cnpj As String, ByVal pepj_cd_inscricaoestadual As String) As Integer

    Try

      Dim strSql As String = "CA_sp_pessoa_juridica_INSERT "
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, pepj_tx_razaosocial.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepj_cd_cnpj, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepj_cd_inscricaoestadual, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
