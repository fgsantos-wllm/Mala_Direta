Public Class CA_termo_uso
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

  Public Function Update_Termo(ByVal term_tx_termo As String, ByVal term_in_tipo_usuario As String, ByVal usua_id_cadastro As String) As Boolean

    Try

      Dim strSql As String = "ca_termo_uso_UPDATE"
      _FunctionsDB.MontaSQL(strSql, term_tx_termo, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, term_in_tipo_usuario, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_cadastro, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "ca_sp_termo_uso_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "ca_sp_termo_uso_SELECT_grid"
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

  Public Function Select_Vigente(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_termo_uso_SELECT_VIGENTE"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Select_ONE(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_termo_uso_SELECT_one"
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

  Public Function Update(ByVal strParametro As String, ByVal term_tx_termo As String, ByVal term_in_tipo_usuario As String, ByVal usua_id_cadastro As String, ByVal term_in_vigente As String, ByVal term_in_forcar_renovacao As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_termo_uso_UPDATE "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, term_tx_termo, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, term_in_tipo_usuario, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_cadastro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, term_in_vigente, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, term_in_forcar_renovacao, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal term_tx_termo As String, ByVal term_in_tipo_usuario As String, ByVal usua_id_cadastro As String, ByVal term_in_vigente As String, ByVal term_in_forcar_renovacao As String) As Integer

    Try

      Dim strSql As String = "ca_sp_termo_uso_INSERT "
      _FunctionsDB.MontaSQL(strSql, term_tx_termo, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, term_in_tipo_usuario, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_cadastro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, term_in_vigente, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, term_in_forcar_renovacao, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Delete(ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_termo_uso_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Termo_Usuario(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_termo_uso_SELECT_USUA_ID_USUARIO"
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Aceite(ByVal strParametro As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_termo_uso_ACEITE "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
