Public Class CA_cliente
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

  Public Function Insert(ByVal PESS_ID_PESSOA As String) As Integer

    Try

      Dim dt As New DataTable

      Dim strSql As String = "ca_sp_cliente_INSERT"
      _FunctionsDB.MontaSQL(strSql, PESS_ID_PESSOA, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      dt = _AccessData.ExecScalar(strSql)
      Return CInt(dt.Rows(0)(0))

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = ex.Message.ToString()

      Throw ex

      Return 0

    End Try

  End Function

  Public Function Updade_Usuario(ByVal PESS_ID_PESSOA As String, ByVal USUA_ID_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_cliente_UPDATE_usua_id_usuario"
      _FunctionsDB.MontaSQL(strSql, PESS_ID_PESSOA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = ex.Message.ToString()

      Throw ex

      Return False

    End Try

  End Function


  Public Function Select_By_PESSOA(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_cliente_SELECT_pess_id_pessoa"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = ex.Message.ToString()

      Throw ex

      Return False

    End Try

  End Function

  Public Function Select_By_EMAIL(ByRef objDT As DataTable, ByVal strParametro As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_cliente_SELECT_pess_tx_email"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = ex.Message.ToString()

      Throw ex

      Return False

    End Try

  End Function

End Class
