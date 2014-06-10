Public Class CA_pessoa_fisica
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

  Dim _objFunctionsDateTime As New Imperia.Common.DateAndTime

  Public Function Grid(ByRef objDt As DataTable, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_pessoa_fisica_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "CA_sp_pessoa_fisica_SELECT_grid"
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

  Public Function Select_One(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_fisica_SELECT_one"
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

  Public Function Select_By_CPF(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_pessoa_fisica_SELECT_pepf_cd_cpf"
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

      Dim strSql As String = "CA_sp_pessoa_fisica_DELETE_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal pess_tx_nome As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String, ByVal tiec_id_tipo_estadocivil As String, ByVal pepf_in_sexo As String, ByVal pepf_cd_rg As String, ByVal pepf_cd_cpf As String, ByVal pepf_dt_nascimento As String) As Boolean

    Try

      Dim objFuncions As New Imperia.Common.Functions
      pess_tx_nome = objFuncions.Tira_CaracteresEstranhos(pess_tx_nome)

      Dim strSql As String = "CA_sp_pessoa_fisica_UPDATE"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, tiec_id_tipo_estadocivil, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_in_sexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_cd_rg, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_cd_cpf, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, _objFunctionsDateTime.Format_SQL_DateTime(pepf_dt_nascimento), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Data, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal pess_id_pessoa As String, ByVal pess_tx_nome As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String, ByVal tiec_id_tipo_estadocivil As String, ByVal pepf_in_sexo As String, ByVal pepf_cd_rg As String, ByVal pepf_cd_cpf As String, ByVal pepf_dt_nascimento As String) As Integer

    Try

      Dim objFuncions As New Imperia.Common.Functions
      pess_tx_nome = objFuncions.Tira_CaracteresEstranhos(pess_tx_nome)

      Dim strSql As String = "ca_sp_pessoa_fisica_INSERT_pess_id_pessoa "
      _FunctionsDB.MontaSQL(strSql, pess_id_pessoa, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, tiec_id_tipo_estadocivil, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_in_sexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_cd_rg, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_cd_cpf, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, _objFunctionsDateTime.Format_SQL_DateTime(pepf_dt_nascimento), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Data, False)

      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal pess_tx_nome As String, ByVal pess_tx_email As String, ByVal pess_in_bloq As String, ByVal tiec_id_tipo_estadocivil As String, ByVal pepf_in_sexo As String, ByVal pepf_cd_rg As String, ByVal pepf_cd_cpf As String, ByVal pepf_dt_nascimento As String) As Integer

    Try

      Dim strSql As String = "CA_sp_pessoa_fisica_INSERT "
      _FunctionsDB.MontaSQL(strSql, pess_tx_nome.ToUpper(), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_tx_email.ToLower(), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pess_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, tiec_id_tipo_estadocivil, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_in_sexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_cd_rg, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, pepf_cd_cpf, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, _objFunctionsDateTime.Format_SQL_DateTime(pepf_dt_nascimento), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Data, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
