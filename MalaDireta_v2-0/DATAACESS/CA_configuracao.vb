Public Class CA_configuracao
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

  Public Function Update_Status(ByVal conf_site_bloq As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_configuracao_UPDATE"
      _FunctionsDB.MontaSQL(strSql, conf_site_bloq, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)
      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update_Termo(ByVal conf_termo As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_configuracao_UPDATE_termo"
      _FunctionsDB.MontaSQL(strSql, conf_termo, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update_Alerta(ByVal conf_fique_alerta As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_configuracao_UPDATE_fique_alerta"
      _FunctionsDB.MontaSQL(strSql, conf_fique_alerta, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      _AccessData.ExecNonQuery(strSql)

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

      Dim strSql As String = "CA_sp_configuracao_SELECT"
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
