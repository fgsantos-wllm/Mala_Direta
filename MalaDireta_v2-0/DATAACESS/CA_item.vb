Public Class CA_item
  Inherits Base

  Private _COD_ERRO As Integer = 0
  Private _MSG_ERRO As String = ""

  Private objdatetime As New Imperia.Common.DateAndTime
  Private objAnexo As New CA_anexo

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

  Public Function Select_Disponiveis_Area(ByRef objDT As DataTable, ByVal area_id_area As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_item_SELECT_disponiveis_area"
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
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

  Public Function Select_Disponiveis_Area_Categoria(ByRef objDT As DataTable, ByVal area_id_area As String, ByVal cat_id_categoria As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_item_SELECT_disponiveis_area_categoria"
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
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


  Public Function Select_Disponiveis(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_item_SELECT_disponiveis"
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
        strSql = "ca_sp_item_SELECT_busca '" & strFiltro & "',  '" & strParametroExtra & "'"""
      Else
        strSql = "ca_sp_item_SELECT_grid '" & strParametroExtra & "'"
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

  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String, ByVal strParametroExtra As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "ca_sp_item_SELECT_busca '" & strFiltro & "',  '" & strParametroExtra & "',  '" & usua_id_usuario & "'"
      Else
        strSql = "ca_sp_item_SELECT_grid '" & strParametroExtra & "', '" & usua_id_usuario & "'"
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

  Public Function Select_Busca(ByRef objDT As DataTable, ByVal area_id_area As String, ByVal usua_id_usuario As String, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_item_SELECT_busca_itens"
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
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

      Dim strSql As String = "ca_sp_item_SELECT_one"
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

      Dim anex_cd_anexos As String = ""
      Dim oDt As New DataTable
      Me.Select_One(oDt, strParametro)

      For Each oRow As DataRow In oDt.Rows

        If Not IsDBNull(oRow("anex_cd_anexos").ToString()) Then

          anex_cd_anexos = oRow("anex_cd_anexos").ToString()

        End If

      Next

      Dim values As String = anex_cd_anexos
      Dim list As New ArrayList
      list.AddRange(values.Split(","c))

      Dim i As Integer
      For i = 0 To list.Count - 1

        objAnexo.Delete(list(i).ToString())

      Next

      Dim strSql As String = "ca_sp_item_DELETE_one "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal strParametro As String, ByVal item_tx_titulo As String, ByVal item_tx_introducao As String, ByVal item_tx_descricao As String, ByVal item_in_bloq As String, ByVal item_in_destaque_area As String, ByVal usua_id_usuario As String, ByVal anex_cd_anexos As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_item_UPDATE "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_tx_titulo, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_tx_introducao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, item_in_destaque_area, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
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

  Public Function Insert(ByVal item_tx_titulo As String, ByVal item_tx_introducao As String, ByVal item_tx_descricao As String, ByVal item_in_bloq As String, ByVal item_in_destaque_area As String, ByVal usua_id_usuario As String, ByVal usua_id_registro As String, ByVal anex_cd_anexos As String) As Integer

    Try

      Dim strSql As String = "ca_sp_item_INSERT "
      _FunctionsDB.MontaSQL(strSql, item_tx_titulo, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_tx_introducao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, item_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, item_in_destaque_area, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_registro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, anex_cd_anexos, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Categorias_Associadas(ByRef objDT As DataTable, ByVal item_id_item As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_item_categoria_SELECT "
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Associar_Anexo(ByVal item_id_item As String, ByVal anex_id_anexo As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_item_anexo_INSERT "
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, anex_id_anexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function DesAssociar_Anexo(ByVal item_id_item As String, ByVal anex_id_anexo As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_item_anexo_DELETE "
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, anex_id_anexo, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Associar_Categoria(ByVal item_id_item As String, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_item_categoria_INSERT "
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function DesAssociar_Categoria(ByVal item_id_item As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_item_categoria_DELETE "
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Item_Usuario(ByVal item_id_item As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_item_usuario_update "
      _FunctionsDB.MontaSQL(strSql, item_id_item, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
