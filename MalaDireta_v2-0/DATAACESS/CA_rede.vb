Public Class CA_rede
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

  Public Function Select_Disponiveis(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "CA_sp_rede_SELECT_disponiveis"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String, ByVal grus_id_grupo As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_rede_SELECT_busca '" & strFiltro & "',  '" & grus_id_grupo & "',  '" & usua_id_usuario & "'"
      Else
        strSql = "CA_sp_rede_SELECT_grid '" & grus_id_grupo & "',  '" & usua_id_usuario & "'"
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

  Public Function Select_ONE(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rede_SELECT_one"
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

  Public Function Select_By_TipoRede(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rede_SELECT_rede_in_tipo"
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

  Public Function Select_By_TipoRede_Usuario(ByRef objDT As DataTable, ByVal strParametro As String, ByVal USUA_ID_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rede_SELECT_rede_in_tipo_usuario"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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

      Dim strSql As String = "CA_sp_rede_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal REDE_TX_DESCRICAO As String, ByVal rede_in_tipo As String, ByVal rede_in_bloq As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rede_UPDATE "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, REDE_TX_DESCRICAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, rede_in_tipo, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, rede_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal REDE_TX_DESCRICAO As String, ByVal rede_in_tipo As String, ByVal rede_in_bloq As String, ByVal USUA_ID_USUARIO As String) As Integer

    Try

      Dim strSql As String = "CA_sp_rede_INSERT "
      _FunctionsDB.MontaSQL(strSql, REDE_TX_DESCRICAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, rede_in_tipo, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, rede_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
