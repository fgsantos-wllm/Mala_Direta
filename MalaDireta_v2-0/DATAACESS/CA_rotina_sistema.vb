Public Class CA_rotina_sistema
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

  Public Function Get_IDByOBJETO(ByRef objDT As DataTable, ByVal strObjeto As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rotina_sistema_select_ROSI_ID_ROTINA"
      _FunctionsDB.MontaSQL(strSql, strObjeto, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Tipo_Usuario(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rotina_sistema_select_all_TIUS_ID_TIPO"
      _FunctionsDB.MontaSQL(strSql, IIf(strParametro = "", Nothing, strParametro), Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

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
        strSql = "CA_sp_rotina_sistema_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "CA_sp_rotina_sistema_SELECT_grid"
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

      Dim strSql As String = "CA_sp_rotina_sistema_select_one"
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

  Public Function Select_Rotinas_Usuario(ByRef objDT As DataTable, ByVal USUA_ID_USUARIO As String, ByVal USUA_ID_USUARIO_LOGADO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rotina_sistema_SELECT_all_usua_ID_usuario"
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO_LOGADO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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

      Dim strSql As String = "CA_sp_rotina_sistema_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal ROSI_TX_ROTINA As String, ByVal ROSI_TX_DESCRICAO As String, ByVal OBJETO As String, ByVal ROSI_IN_TIPO As String, ByVal ROSI_IN_ADMINISTRATIVA As String, ByVal ROSI_TX_REGRA_TIPO_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_rotina_sistema_update "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_TX_ROTINA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_TX_DESCRICAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, OBJETO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_IN_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_IN_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_TX_REGRA_TIPO_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal ROSI_TX_ROTINA As String, ByVal ROSI_TX_DESCRICAO As String, ByVal OBJETO As String, ByVal ROSI_IN_TIPO As String, ByVal ROSI_IN_ADMINISTRATIVA As String, ByVal ROSI_TX_REGRA_TIPO_USUARIO As String) As Integer

    Try

      Dim strSql As String = "CA_sp_rotina_sistema_insert "
      _FunctionsDB.MontaSQL(strSql, ROSI_TX_ROTINA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_TX_DESCRICAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, OBJETO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_IN_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_IN_ADMINISTRATIVA, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_TX_REGRA_TIPO_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


End Class
