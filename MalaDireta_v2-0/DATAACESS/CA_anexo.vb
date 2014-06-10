Imports System.IO

Public Class CA_anexo
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


  Public Function Grid(ByRef objDT As DataTable, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "ca_sp_anexo_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "ca_sp_anexo_SELECT_grid"
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

      Dim strSql As String = "ca_sp_anexo_SELECT_one"
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

  Public Function Select_Lista(ByRef objDT As DataTable, ByVal strParametro As String, ByVal tpax_in_tipo As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_anexo_SELECT_lista"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, tpax_in_tipo, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Delete(ByVal strParametro As String, Optional ByVal path As String = "", Optional ByVal path2 As String = "") As Boolean

    Try

      Dim anex_tx_caminho As String = ""
      Dim oDt As New DataTable
      Me.Select_One(oDt, strParametro)

      For Each oRow As DataRow In oDt.Rows

        If Not IsDBNull(oRow("anex_tx_caminho").ToString()) Then

          anex_tx_caminho = oRow("anex_tx_caminho").ToString()

        End If

      Next

      If Trim(anex_tx_caminho) <> "" Then

        If Trim(path) = "" Then
          File.Delete(System.Configuration.ConfigurationSettings.AppSettings("UPLOAD_IMG_ANEXO").ToString() & anex_tx_caminho)
        Else
          File.Delete(path & anex_tx_caminho)
          If Trim(path) <> "" Then
            File.Delete(path2 & anex_tx_caminho)
          End If
        End If

      End If

      Dim strSql As String = "ca_sp_anexo_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal tpax_id_tipo As String, ByVal anex_tx_descricao As String, ByVal anex_tx_caminho As String, ByVal usua_id_usuario As String, ByVal anex_tx_arquivo As String) As Integer

    Try

      Dim strSql As String = "ca_sp_anexo_INSERT "
      _FunctionsDB.MontaSQL(strSql, tpax_id_tipo, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, anex_tx_descricao, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, anex_tx_caminho, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, usua_id_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, anex_tx_arquivo, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
