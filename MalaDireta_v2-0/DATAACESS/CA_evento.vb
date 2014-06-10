Public Class CA_evento
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

  Private objdatetime As New Imperia.Common.DateAndTime

  Public Function Select_Disponiveis_Area(ByRef objDT As DataTable, ByVal area_id_area As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_evento_SELECT_disponiveis_area"
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_Area_Categoria(ByRef objDT As DataTable, ByVal area_id_area As String, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_evento_SELECT_disponiveis_area_categoria"
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
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


  Public Function Select_Disponiveis(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_evento_SELECT_disponiveis"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String, ByVal strParametroExtra As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "ca_sp_evento_SELECT_busca '" & strFiltro & "',  '" & strParametroExtra & "'"""
      Else
        strSql = "ca_sp_evento_SELECT_grid '" & strParametroExtra & "'"
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

      Dim strSql As String = "ca_sp_evento_SELECT_one"
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

      Dim strSql As String = "ca_sp_evento_DELETE_one "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal TPEV_IN_TIPO As String, ByVal even_nm_evento As String, ByVal even_tx_assunto As String, ByVal even_tx_descricao As String, ByVal even_tx_local As String, ByVal even_dt_evento As String, ByVal even_nr_duracao As String, ByVal even_tp_duracao As String, ByVal even_hr_inicio As String, ByVal even_hr_fim As String, ByVal even_qt_vagas As String, ByVal EVEN_QT_VAGAS_ALOCADAS As String, ByVal even_nm_responsaveis As String, ByVal even_nm_patrocinadores As String, ByVal even_in_encerrado As String, ByVal even_in_bloq As String, ByVal even_in_destaque As String, ByVal usua_id_usuario As String, ByVal anex_cd_anexos As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_evento_UPDATE "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, TPEV_IN_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_nm_evento, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tx_assunto, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tx_local, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, objdatetime.Format_SQL_DateTime(even_dt_evento), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Data, True)
      _FunctionsDB.MontaSQL(strSql, even_nr_duracao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tp_duracao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_hr_inicio, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_hr_fim, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_qt_vagas, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, EVEN_QT_VAGAS_ALOCADAS, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_nm_responsaveis, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_nm_patrocinadores, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_in_encerrado, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, even_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, even_in_destaque, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, anex_cd_anexos, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal TPEV_IN_TIPO As String, ByVal even_nm_evento As String, ByVal even_tx_assunto As String, ByVal even_tx_descricao As String, ByVal even_tx_local As String, ByVal even_dt_evento As String, ByVal even_nr_duracao As String, ByVal even_tp_duracao As String, ByVal even_hr_inicio As String, ByVal even_hr_fim As String, ByVal even_qt_vagas As String, ByVal EVEN_QT_VAGAS_ALOCADAS As String, ByVal even_nm_responsaveis As String, ByVal even_nm_patrocinadores As String, ByVal even_in_encerrado As String, ByVal even_in_bloq As String, ByVal even_in_destaque As String, ByVal usua_id_usuario As String, ByVal anex_cd_anexos As String) As Integer

    Try

      Dim strSql As String = "ca_sp_evento_INSERT "
      _FunctionsDB.MontaSQL(strSql, TPEV_IN_TIPO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_nm_evento, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tx_assunto, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tx_local, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, objdatetime.Format_SQL_DateTime(even_dt_evento), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Data, True)
      _FunctionsDB.MontaSQL(strSql, even_nr_duracao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_tp_duracao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_hr_inicio, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_hr_fim, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_qt_vagas, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, EVEN_QT_VAGAS_ALOCADAS, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_nm_responsaveis, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_nm_patrocinadores, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, even_in_encerrado, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, even_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, even_in_destaque, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, anex_cd_anexos, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Categorias_Associadas(ByRef objDT As DataTable, ByVal even_id_evento As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_categoria_SELECT "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Associar_Anexo(ByVal even_id_evento As String, ByVal anex_id_anexo As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_anexo_INSERT "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, anex_id_anexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function DesAssociar_Anexo(ByVal even_id_evento As String, ByVal anex_id_anexo As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_anexo_DELETE "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, anex_id_anexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Associar_Categoria(ByVal even_id_evento As String, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_categoria_INSERT "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function DesAssociar_Categoria(ByVal even_id_evento As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_categoria_DELETE "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Participar(ByVal even_id_evento As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_usuario_INSERT "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Cancelar_Participacao(ByVal even_id_evento As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_usuario_DELETE "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Buscar_Participacao(ByRef objDT As DataTable, ByVal even_id_evento As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_usuario_SELECT "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Buscar_Participacao(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_usuario_SELECT_usua_id_usuario "
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Buscar_Participacao_Ativos(ByRef objDT As DataTable, ByVal even_id_evento As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_usuario_SELECT_even_id_evento_ATIVOS "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Buscar_Participacao_Desistentes(ByRef objDT As DataTable, ByVal even_id_evento As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_evento_usuario_SELECT_even_id_evento_DESISTENTES "
      _FunctionsDB.MontaSQL(strSql, even_id_evento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
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
