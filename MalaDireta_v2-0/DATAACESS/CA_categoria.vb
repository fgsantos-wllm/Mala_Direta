Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class CA_categoria
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

  Public Function LoadDataSet(ByRef ds As DataSet, ByVal nameds As String, ByVal area_id_area As String) As Boolean

    Try

      Dim objConn As New Imperia.AccessData.AccessData
      Dim strConn As String
      strConn = objConn.XML_ConnectionString

      Dim strSql As String = "select cat_id_categoria, cat_tx_descricao, cat_id_categoria_pai from ca_categoria where area_id_area = '" & area_id_area & "' order by cat_tx_descricao asc"

      Dim myAdapter As New SqlDataAdapter(strSql, strConn)

      myAdapter.Fill(ds, nameds)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function LoadDataSet(ByRef ds As DataSet, ByVal nameds As String, ByVal area_id_area As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim objConn As New Imperia.AccessData.AccessData
      Dim strConn As String
      strConn = objConn.XML_ConnectionString

      Dim strSql As String = "select cat_id_categoria, cat_tx_descricao, cat_id_categoria_pai from ca_categoria where area_id_area = '" & area_id_area & "' and cat_id_categoria in (select cat_id_categoria from ca_assoc_usuario_categoria_editor where usua_id_usuario = '" & usua_id_usuario & "') order by cat_tx_descricao asc"

      Dim myAdapter As New SqlDataAdapter(strSql, strConn)

      myAdapter.Fill(ds, nameds)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function LoadDataSetV(ByRef ds As DataSet, ByVal nameds As String, ByVal area_id_area As String, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim objConn As New Imperia.AccessData.AccessData
      Dim strConn As String
      strConn = objConn.XML_ConnectionString

      Dim strSql As String = "select cat_id_categoria, cat_tx_descricao, cat_id_categoria_pai from ca_categoria where area_id_area = '" & area_id_area & "' and cat_id_categoria in (select cat_id_categoria from ca_assoc_usuario_categoria where usua_id_usuario = '" & usua_id_usuario & "') order by cat_tx_descricao asc"

      Dim myAdapter As New SqlDataAdapter(strSql, strConn)

      myAdapter.Fill(ds, nameds)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function ChargeTreeView(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_disponiveis"
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

      Dim strSql As String = "ca_sp_categoria_SELECT_disponiveis"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_Associacao(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_disponiveis_associacao"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Select_Disponiveis_Usuario(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_disponiveis_usuario"
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
  Public Function Select_Disponiveis_Editor(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_disponiveis_editor"
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

  Public Function Select_Associadas_Usuario(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_associadas_usuario"
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

  Public Function Select_Associadas_Editor(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_associadas_editor"
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

  Public Function Select_Editor_Categoria(ByRef objDT As DataTable, ByVal usua_id_usuario As String, ByVal item_id_item As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_editor_categoria_select"
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
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

  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "ca_sp_categoria_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "ca_sp_categoria_SELECT_grid   '" & strParametro & "'"
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

      Dim strSql As String = "CA_sp_categoria_select_one"
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

  Public Function Select_Area(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_area_id_area"
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

  Public Function Select_Imagens_Categorias_Filhas(ByRef objDT As DataTable, ByVal usua_id_usuario As String, ByVal area_id_area As String, ByVal cat_id_categoria As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_categoria_SELECT_categoria_pai_imagens"
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, False)
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

      Dim strSql As String = "CA_sp_categoria_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal cat_tx_descricao As String, ByVal cat_tx_caminho As String, ByVal cat_in_bloq As String, ByVal area_id_area As String, ByVal cate_id_categoria_pai As String) As Integer

    Try

      Dim strSql As String = "ca_sp_categoria_INSERT "
      _FunctionsDB.MontaSQL(strSql, cat_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_tx_caminho, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, cate_id_categoria_pai, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal cat_tx_descricao As String, ByVal cat_tx_caminho As String, ByVal cat_in_bloq As String, ByVal area_id_area As String, ByVal cate_id_categoria_pai As String, ByVal usua_id_usuario_cadastro As String) As Integer

    Try

      Dim strSql As String = "ca_sp_categoria_INSERT "
      _FunctionsDB.MontaSQL(strSql, cat_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_tx_caminho, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, cate_id_categoria_pai, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario_cadastro, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal cat_id_categoria As String, ByVal cat_tx_descricao As String, ByVal cat_tx_caminho As String, ByVal cat_in_bloq As String, ByVal area_id_area As String) As Integer

    Try

      Dim strSql As String = "ca_sp_categoria_UPDATE "
      _FunctionsDB.MontaSQL(strSql, cat_id_categoria, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, cat_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_tx_caminho, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, cat_in_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, area_id_area, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Categoria_Usuario(ByVal CAT_ID_CATEGORIA As String, ByVal USUA_ID_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_assoc_categoria_usuario_update "
      _FunctionsDB.MontaSQL(strSql, CAT_ID_CATEGORIA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Categoria_Usuario_Editor(ByVal CAT_ID_CATEGORIA As String, ByVal USUA_ID_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_assoc_categoria_usuario_editor_update "
      _FunctionsDB.MontaSQL(strSql, CAT_ID_CATEGORIA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
