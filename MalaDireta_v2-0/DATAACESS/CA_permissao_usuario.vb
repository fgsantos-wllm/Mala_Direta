Public Class CA_permissao_usuario
  Inherits Base

  Private _COD_ERRO As Integer = 0
  Private _MSG_ERRO As String = ""
  Private _dta_sub_menu As New CA_sub_menu
  Private _dta_rotina_sistema As New CA_rotina_sistema

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

  Enum TipoPermissao

    Ver = 1
    Incluir = 2
    Alterar = 3
    Excluir = 4

  End Enum

  Public Function Check_Permissions(ByVal eTipoPermissao As TipoPermissao, ByVal strUC As String, ByVal USUA_ID_USUARIO_LOGADO As String, Optional ByVal OBJETO As String = "") As Boolean

    Try

      Dim PEUS_IN_PERMISSAO As String = ""
      Dim ROSI_ID_ROTINA As String = ""

      If OBJETO = "" Then
        Get_ObjetoByURL(OBJETO, strUC)
      End If

      Get_IDByOBJETO(ROSI_ID_ROTINA, OBJETO)

      Dim objDT As New DataTable
      Check_Permissions(objDT, USUA_ID_USUARIO_LOGADO, ROSI_ID_ROTINA)

      If objDT.Rows.Count = 0 Then

        Return False

      Else

        PEUS_IN_PERMISSAO = objDT.Rows(0)("PEUS_IN_PERMISSAO")
        PEUS_IN_PERMISSAO = Right("0" & PEUS_IN_PERMISSAO, 2)

        If eTipoPermissao = TipoPermissao.Ver Then

          If PEUS_IN_PERMISSAO <> "" Then Return True

        ElseIf eTipoPermissao = TipoPermissao.Incluir Then

          Select Case PEUS_IN_PERMISSAO
            Case "02", "03", "06", "07"
              Return True
          End Select

        ElseIf eTipoPermissao = TipoPermissao.Excluir Then

          Select Case PEUS_IN_PERMISSAO
            Case "04", "05", "06", "07"
              Return True
          End Select

        ElseIf eTipoPermissao = TipoPermissao.Alterar Then

          Select Case PEUS_IN_PERMISSAO
            Case "01", "03", "05", "07"
              Return True
          End Select

        End If

        Return False

      End If

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Get_ObjetoByURL(ByRef OBJETO As String, ByVal strUC As String) As Boolean

    Try

      Dim objDT As New DataTable
      _dta_sub_menu.Get_ObjetoByURL(objDT, strUC)

      If objDT.Rows.Count = 0 Then

        Return False

      Else

        OBJETO = objDT.Rows(0)("OBJETO")

      End If

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Get_IDByOBJETO(ByRef ROSI_ID_ROTINA As String, ByVal strObjeto As String) As Boolean

    Try

      Dim objDT As New DataTable
      _dta_rotina_sistema.Get_IDByOBJETO(objDT, strObjeto)

      If objDT.Rows.Count = 0 Then

        Return False

      Else

        ROSI_ID_ROTINA = objDT.Rows(0)("ROSI_ID_ROTINA")

      End If

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Check_Permissions(ByRef objDt As DataTable, ByVal USUA_ID_USUARIO As String, ByVal ROSI_ID_ROTINA As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_permissao_usuario_select_PEUS_IN_PERMISSAO"
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_ID_ROTINA, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      objDt = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Delete_Permissions(ByVal USUA_ID_USUARIO As String, ByVal USUA_ID_USUARIO_LOGADO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_permissao_usuario_delete_USUA_ID_USUARIO"
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO_LOGADO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert_Permissions(ByVal USUA_ID_USUARIO As String, ByVal ROSI_ID_ROTINA As String, ByVal PEUS_IN_PERMISSAO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_permissao_usuario_INSERT"
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, ROSI_ID_ROTINA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, PEUS_IN_PERMISSAO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert_Permissions_Cliente(ByVal USUA_ID_USUARIO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_permissao_usuario_cliente_INSERT"
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


End Class
