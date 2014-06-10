Public Class CA_enquete
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

      Dim strSql As String = "ca_sp_enquete_perguntas_SELECT_disponiveis"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_enquete_perguntas_SELECT_disponiveis_usuario"
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

  Public Function Select_Respostas(ByRef objDT As DataTable, ByVal eqpe_id_enquete As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_enquete_respostas_SELECT_eqpe_id_enquete"
      _FunctionsDB.MontaSQL(strSql, eqpe_id_enquete, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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
        strSql = "ca_sp_enquete_perguntas_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "ca_sp_enquete_perguntas_SELECT_grid"
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

      Dim strSql As String = "ca_sp_enquete_perguntas_SELECT_one"
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

  Public Function Delete(ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_enquete_perguntas_DELETE_one "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal eqpe_tx_pergunta As String, ByVal eqpe_in_bloq As String, ByVal eqpe_tx_observacao As String) As Integer

    Try

      Dim strSql As String = "ca_sp_enquete_perguntas_INSERT "
      _FunctionsDB.MontaSQL(strSql, eqpe_tx_pergunta, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, eqpe_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, eqpe_tx_observacao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal eqpe_id_enquete As String, ByVal eqpe_tx_pergunta As String, ByVal eqpe_in_bloq As String, ByVal eqpe_tx_observacao As String) As Integer

    Try

      Dim strSql As String = "ca_sp_enquete_perguntas_UPDATE "
      _FunctionsDB.MontaSQL(strSql, eqpe_id_enquete, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, eqpe_tx_pergunta, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, eqpe_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, eqpe_tx_observacao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert_Resposta(ByVal eqpe_id_enquete As String, ByVal eqre_tx_resposta As String, ByVal eqre_in_bloq As String) As Integer

    Try

      Dim strSql As String = "ca_sp_enquete_respostas_INSERT "
      _FunctionsDB.MontaSQL(strSql, eqpe_id_enquete, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, eqre_tx_resposta, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, eqre_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert_Voto(ByVal eqre_id_enquete As String, ByVal usua_id_usuario As String) As Integer

    Try

      Dim strSql As String = "ca_sp_enquete_votos_INSERT "
      _FunctionsDB.MontaSQL(strSql, eqre_id_enquete, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

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
