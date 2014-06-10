Public Class CA_mensagem_alerta
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

  Public Function Update_Alerta(ByVal mensagem_aviso As String, ByVal ativa As String, ByVal data_expiracao As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_mensagem_alerta_UPDATE"
      _FunctionsDB.MontaSQL(strSql, mensagem_aviso, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, ativa, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, _objFunctionsDateTime.Format_SQL_DateTime(data_expiracao), Imperia.Common.Functions_DB.tipo_Campo.ToNull_Data, False)

      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Ativa(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_mensagem_alerta_SELECT_ATIVA"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_All(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_mensagem_alerta_SELECT"
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
