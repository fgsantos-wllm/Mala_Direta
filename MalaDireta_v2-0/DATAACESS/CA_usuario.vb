Public Class CA_usuario
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

  Public Function Grid(ByRef objDT As DataTable, ByVal TIUS_ID_TIPO As String, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_usuario_SELECT_busca"
        _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
        _FunctionsDB.MontaSQL(strSql, strFiltro, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
      Else
        strSql = "CA_sp_usuario_SELECT_grid"
        _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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


  Public Function Select_Disponiveis_Categoria_Editor(ByRef objDT As DataTable, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_disponiveis_categoria_editor"
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_Categoria(ByRef objDT As DataTable, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_disponiveis_categoria"
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_Item(ByRef objDT As DataTable, ByVal item_id_item As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_disponiveis_item"
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Associadas_Categoria_Editor(ByRef objDT As DataTable, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_associadas_categoria_editor"
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_Sistema(ByRef objDT As DataTable, ByVal sist_id_sistema As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_disponiveis_sistema"
      _FunctionsDB.MontaSQL(strSql, sist_id_sistema, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Select_Associadas_Categoria(ByRef objDT As DataTable, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_associadas_categoria"
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Associadas_Sistema(ByRef objDT As DataTable, ByVal sist_id_sistema As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_associadas_sistema"
      _FunctionsDB.MontaSQL(strSql, sist_id_sistema, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Select_Associadas_Item(ByRef objDT As DataTable, ByVal item_id_item As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_associadas_item"
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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

      Dim strSql As String = "CA_sp_usuario_select_one"
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

  Public Function Select_By_Login(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_usua_tx_login"
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

  Public Function Select_By_Departamento(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_dep_id_departamento"
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

  Public Function Select_By_Grupo(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_select_grus_id_grupo"
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

  Public Function Select_By_TipoRede(ByRef objDT As DataTable, ByVal strParametro As String, ByVal USUA_ID_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_SELECT_rede_in_tipo"
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

  Public Function Select_By_Tipo(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_select_tius_id_tipo"
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

  Public Function Select_Troca_Grupo(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_select_troca_grupo"
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

  Public Function Select_Troca_Senha(ByVal usua_id_usuario As String, ByVal usua_tx_senha_atual As String, ByVal usua_tx_senha_nova As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_UPDATE_senha"
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, usua_tx_senha_atual, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_tx_senha_nova, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      _AccessData.ExecNonQuery(strSql)

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

      Dim strSql As String = "CA_sp_usuario_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update_Tipo_Usuario(ByVal strParametro As String, ByVal TIUS_ID_TIPO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_update_tius_id_tipo "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal USUA_ID_USUARIO_LOGADO As String, ByVal USUA_NM_USUARIO As String, ByVal USUA_TX_LOGIN As String, ByVal USUA_TX_EMAIL As String, ByVal TIUS_ID_TIPO As String, ByVal USUA_TX_SENHA As String, ByVal USUA_IN_WA As String, ByVal USUA_IN_BLOQ As String, ByVal USUA_HR_DE As String, ByVal USUA_HR_ATE As String, ByVal dep_id_departamento As String, ByVal smtp_id_smtp As String, ByVal smtp_tx_usuario As String, ByVal smtp_tx_senha As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_update "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_NM_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_LOGIN, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, IIf(USUA_TX_SENHA = "", Nothing, USUA_TX_SENHA), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_EMAIL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_WA, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_DE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_ATE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, dep_id_departamento, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_id_smtp, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_senha, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)


      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal USUA_ID_USUARIO_LOGADO As String, ByVal USUA_NM_USUARIO As String, ByVal USUA_TX_LOGIN As String, ByVal USUA_TX_EMAIL As String, ByVal TIUS_ID_TIPO As String, ByVal USUA_TX_SENHA As String, ByVal USUA_IN_WA As String, ByVal USUA_IN_BLOQ As String, ByVal USUA_IN_INATIVO As String, ByVal USUA_HR_DE As String, ByVal USUA_HR_ATE As String, ByVal dep_id_departamento As String, ByVal smtp_id_smtp As String, ByVal smtp_tx_usuario As String, ByVal smtp_tx_senha As String, ByVal USUA_ID_USUARIO_COPIA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_update "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_NM_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_LOGIN, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, IIf(USUA_TX_SENHA = "", Nothing, USUA_TX_SENHA), Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_EMAIL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_INATIVO, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_WA, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_DE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_ATE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, dep_id_departamento, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_id_smtp, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_senha, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO_COPIA, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Insert(ByVal USUA_ID_USUARIO_LOGADO As String, ByVal USUA_NM_USUARIO As String, ByVal USUA_TX_LOGIN As String, ByVal USUA_TX_EMAIL As String, ByVal TIUS_ID_TIPO As String, ByVal USUA_TX_SENHA As String, ByVal USUA_IN_WA As String, ByVal USUA_IN_BLOQ As String, ByVal USUA_IN_INATIVO As String, ByVal USUA_HR_DE As String, ByVal USUA_HR_ATE As String, ByVal PERMISSOES As String, ByVal dep_id_departamento As String, ByVal smtp_id_smtp As String, ByVal smtp_tx_usuario As String, ByVal smtp_tx_senha As String) As Integer

    Try

      Dim strSql As String = "CA_sp_usuario_insert "
      _FunctionsDB.MontaSQL(strSql, IIf(USUA_ID_USUARIO_LOGADO = "", Nothing, USUA_ID_USUARIO_LOGADO), Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_NM_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_LOGIN, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_SENHA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_EMAIL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_INATIVO, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_WA, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_DE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_ATE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PERMISSOES, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, dep_id_departamento, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_id_smtp, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_senha, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal USUA_ID_USUARIO_LOGADO As String, ByVal USUA_NM_USUARIO As String, ByVal USUA_TX_LOGIN As String, ByVal USUA_TX_EMAIL As String, ByVal TIUS_ID_TIPO As String, ByVal USUA_TX_SENHA As String, ByVal USUA_IN_WA As String, ByVal USUA_IN_BLOQ As String, ByVal USUA_IN_INATIVO As String, ByVal USUA_HR_DE As String, ByVal USUA_HR_ATE As String, ByVal PERMISSOES As String, ByVal dep_id_departamento As String, ByVal smtp_id_smtp As String, ByVal smtp_tx_usuario As String, ByVal smtp_tx_senha As String, ByVal USUA_ID_USUARIO_COPIA As String) As Integer

    Try

      Dim strSql As String = "CA_sp_usuario_insert "
      _FunctionsDB.MontaSQL(strSql, IIf(USUA_ID_USUARIO_LOGADO = "", Nothing, USUA_ID_USUARIO_LOGADO), Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_NM_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_LOGIN, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_SENHA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_EMAIL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_INATIVO, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_IN_WA, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_DE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_HR_ATE, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PERMISSOES, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, dep_id_departamento, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_id_smtp, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, smtp_tx_senha, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO_COPIA, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Autenticacao(ByRef objDT As DataTable, ByVal USUA_TX_LOGIN As String, ByVal USUA_TX_SENHA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_usuario_autenticacao"
      _FunctionsDB.MontaSQL(strSql, USUA_TX_LOGIN, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_SENHA, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Select_Disponiveis(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_disponiveis"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Report_Usuarios(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_report_usuarios"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_usuario_SELECT_disponiveis"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Usuario_Categoria(ByVal USUA_ID_USUARIO As String, ByVal CAT_ID_CATEGORIA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_assoc_usuario_categoria_update "
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, CAT_ID_CATEGORIA, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Usuario_Convenio(ByVal USUA_ID_USUARIO As String, ByVal DPOC_ID_DPOC As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_usuario_convenio_update "
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, DPOC_ID_DPOC, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Editor_Categoria(ByVal USUA_ID_USUARIO As String, ByVal CAT_ID_CATEGORIA As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_editor_categoria_update "
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, CAT_ID_CATEGORIA, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function
  Public Function Assoc_Usuario_Sistema(ByVal USUA_ID_USUARIO As String, ByVal sist_id_sistema As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_assoc_usuario_sistema_update "
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, sist_id_sistema, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Usuario_Item(ByVal usua_id_usuario As String, ByVal item_id_item As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_usuario_item_update "
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
