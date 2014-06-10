Public Class CA_menu
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

  Public Sub Charge_Menus_Not_IE(ByRef WebDataMenu As Object, ByVal usua_ID_usuario As String)

    'Menus
    Dim objDT As New DataTable
    Charge_Menu(objDT, usua_ID_usuario)

    'Sub-Menu
    Dim objDTSubMenu As New DataTable

    Dim m As Integer = 0
    Dim s As Integer = 0

    For m = 0 To objDT.Rows.Count - 1

      'Adiciona o menu.

      WebDataMenu.Items.Add(objDT.Rows(m).Item("MENU_TX_DESCRICAO"), "")

      'Executa os Sub-Menus
      s = 0
      Charge_SubMenu(usua_ID_usuario, objDT.Rows(m).Item("MENU_ID_MENU"), objDTSubMenu)

      For s = 0 To objDTSubMenu.Rows.Count - 1

        'Adiciona o sub-menu
        WebDataMenu.Items(m).Items.Add(objDTSubMenu.Rows(s).Item("SBMN_TX_DESCRICAO").ToString(), "index.aspx?UserControl=" & "~/modules/" & objDTSubMenu.Rows(s)("SBMN_TX_PAGINA") & "&PanelType=" & Imperia.Common.PageOperation.PanelType.Conteudo)
        'WebDataMenu.Items(m).NavigateUrl() = "index.aspx?UserControl=" & "~/modules/" & objDTSubMenu.Rows(s)("SBMN_TX_PAGINA") & "&PanelType=" & Imperia.Common.PageOperation.PanelType.Conteudo

      Next

    Next

    'Incluindo o menu de saída
    WebDataMenu.Items.Add("Sair", "index.aspx?UserControl=" & "~/modules/CA_logout.ascx&PanelType=" & Imperia.Common.PageOperation.PanelType.Conteudo)
    'WebDataMenu.Items(m + 1).NavigateUrl() = "index.aspx?UserControl=" & "~/modules/CA_logout.ascx&PanelType=" & Imperia.Common.PageOperation.PanelType.Conteudo

  End Sub

  Public Sub Charge_Menus(ByRef UltraWebMenu As Object, ByVal usua_ID_usuario As String)

    'Menus
    Dim objDT As New DataTable
    Charge_Menu(objDT, usua_ID_usuario)

    'Sub-Menu
    Dim objDTSubMenu As New DataTable

    Dim m As Integer = 0
    Dim s As Integer = 0

    For m = 0 To objDT.Rows.Count - 1

      'Adiciona o menu.
      UltraWebMenu.Items.Add(objDT.Rows(m).Item("MENU_TX_DESCRICAO"))
      'UltraWebMenu.Items(m).TargetUrl = "#"

      'Executa os Sub-Menus
      s = 0
      Charge_SubMenu(usua_ID_usuario, objDT.Rows(m).Item("MENU_ID_MENU"), objDTSubMenu)

      For s = 0 To objDTSubMenu.Rows.Count - 1

        'Adiciona o sub-menu
        UltraWebMenu.Items(m).Items.Add(objDTSubMenu.Rows(s).Item("SBMN_TX_DESCRICAO").ToString())
        UltraWebMenu.Items(m).Items(s).TargetUrl = "index.aspx?UserControl=" & "~/modules/" & objDTSubMenu.Rows(s)("SBMN_TX_PAGINA") & "&PanelType=" & Imperia.Common.PageOperation.PanelType.Conteudo

      Next

    Next

    'Incluindo o menu de saída
    UltraWebMenu.Items.Add("Sair")
    UltraWebMenu.Items(m).TargetUrl = "index.aspx?UserControl=" & "~/modules/CA_logout.ascx&PanelType=" & Imperia.Common.PageOperation.PanelType.Conteudo

  End Sub

  Public Function Charge_Menu(ByRef objDT As DataTable, ByVal usua_ID_usuario As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_menu_SELECT_usuario"
      _FunctionsDB.MontaSQL(strSql, usua_ID_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Charge_SubMenu(ByVal usua_ID_usuario As Integer, ByVal menu_ID_menu As Integer, ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "CA_sp_sub_menu_select_MENU_ID_MENU"
      _FunctionsDB.MontaSQL(strSql, usua_ID_usuario, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, menu_ID_menu, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
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
        strSql = "CA_sp_menu_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "CA_sp_menu_SELECT_grid"
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

      Dim strSql As String = "CA_sp_menu_select_one"
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

      Dim strSql As String = "CA_sp_menu_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function


  Public Function Update(ByVal strParametro As String, ByVal MENU_TX_DESCRICAO As String, ByVal OBJETO As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_menu_update "
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, MENU_TX_DESCRICAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, OBJETO, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Insert(ByVal MENU_TX_DESCRICAO As String, ByVal OBJETO As String) As Integer

    Try

      Dim strSql As String = "CA_sp_menu_insert "
      _FunctionsDB.MontaSQL(strSql, MENU_TX_DESCRICAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, OBJETO, Imperia.Common.Functions_DB.tipo_Campo.Texto, False)

      Return DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
