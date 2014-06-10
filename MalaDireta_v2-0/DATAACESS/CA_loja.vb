Public Class CA_loja
  Inherits Base

  Private _COD_ERRO As Integer = 0
  Private _MSG_ERRO As String = ""

  Dim _objMoney As New Imperia.Common.Money

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

  Public Function Select_Disponiveis(ByRef objDT As DataTable, Optional ByVal dpos_id_dpos As String = "", Optional ByVal uf_cd_operacao As String = "", Optional ByVal banc_id_banco As String = "", Optional ByVal pdv_cadastrado As String = "", Optional ByVal mppg_id_meio_pagamento As String = "") As Boolean

    Try

      Dim strSql As String = "CA_sp_loja_SELECT_disponiveis"
      _FunctionsDB.MontaSQL(strSql, dpos_id_dpos, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, uf_cd_operacao, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, banc_id_banco, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, pdv_cadastrado, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, True)
      _FunctionsDB.MontaSQL(strSql, mppg_id_meio_pagamento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Numero, False)

      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_By_usua_id_usuario(ByRef objDT As DataTable, ByVal usua_id_usuario As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_loja_SELECT_disponiveis_usua_id_usuario"
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

  Public Function Select_All(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "CA_sp_loja_SELECT_all"
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
        strSql = "CA_sp_loja_SELECT_busca '" & strFiltro & "'"
      Else
        strSql = "CA_sp_loja_SELECT_grid "
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

  Public Function Grid_Excel(ByRef objDT As DataTable, ByVal strFiltro As String) As Boolean

    Try

      Dim strSql As String
      If Trim(strFiltro) <> "" Then
        strSql = "CA_sp_loja_SELECT_busca_excel '" & strFiltro & "'"
      Else
        strSql = "CA_sp_loja_SELECT_grid_excel "
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

      Dim strSql As String = "CA_sp_loja_SELECT_one"
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

      Dim strSql As String = "CA_sp_loja_delete_one"
      _FunctionsDB.MontaSQL(strSql, strParametro, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Update(ByVal LOJA_ID_LOJA As String, ByVal PESS_IN_TIPOPESSOA As String, ByVal PESS_ID_PESSOA As String, ByVal REDE_ID_REDE As String, ByVal LOJA_IN_TIPO_ADMINISTRACAO As String, ByVal USUA_ID_REPRESENTANTE As String, ByVal PESS_TX_NOME As String, ByVal PESS_TX_EMAIL As String, ByVal PEPJ_TX_RAZAOSOCIAL As String, ByVal PEPF_CD_CPF As String, ByVal PEPJ_CD_CNPJ As String, ByVal PEPJ_CD_INSCRICAOESTADUAL As String, ByVal TILJ_ID_TIPO_LOJA As String, ByVal LOJA_TX_CONTATO As String, ByVal LOJA_TX_LOGOTIPO As String, ByVal USUA_TX_LOGIN As String, ByVal USUA_TX_SENHA_MASTER As String, ByVal objDTEndereco As DataTable, ByVal objDTTelefone As DataTable, ByVal UF_OPERACAO As String, ByVal LOJA_IN_BLOQ As String) As Boolean

    Try

      Dim _bsr_pessoa_fisica As New CA_pessoa_fisica
      Dim _bsr_pessoa_juridica As New CA_pessoa_juridica
      Dim _bsr_pessoa_logradouro As New CA_pessoa_logradouro
      Dim _bsr_pessoa_telefone As New CA_pessoa_telefone
      Dim objFuncions As New Imperia.Common.Functions

      PESS_TX_NOME = objFuncions.Tira_CaracteresEstranhos(PESS_TX_NOME)

      _bsr_pessoa_fisica.Delete(PESS_ID_PESSOA)
      _bsr_pessoa_juridica.Delete(PESS_ID_PESSOA)

      If PESS_IN_TIPOPESSOA = "F" Then
        _bsr_pessoa_fisica.Insert(PESS_ID_PESSOA, PESS_TX_NOME, PESS_TX_EMAIL, 0, "", "", "", PEPF_CD_CPF, "")
      ElseIf PESS_IN_TIPOPESSOA = "J" Then
        _bsr_pessoa_juridica.Insert(PESS_ID_PESSOA, PESS_TX_NOME, PESS_TX_EMAIL, 0, PEPJ_TX_RAZAOSOCIAL, PEPJ_CD_CNPJ, PEPJ_CD_INSCRICAOESTADUAL)
      End If

      Dim dtrE As DataTableReader = objDTEndereco.CreateDataReader
      _bsr_pessoa_logradouro.Delete(PESS_ID_PESSOA)
      While dtrE.Read

        _bsr_pessoa_logradouro.Insert(PESS_ID_PESSOA, dtrE("CILO_ID_CIDADE_LOGRADOURO").ToString(), dtrE("TILO_ID_TIPO_LOGRADOURO").ToString(), dtrE("PELO_TX_LOGRADOURO").ToString(), dtrE("PELO_NR_LOGRADOURO").ToString(), dtrE("PELO_TX_COMPLEMENTO").ToString(), dtrE("PELO_TX_BAIRRO").ToString(), dtrE("PELO_TX_CEP").ToString(), dtrE("UF_ID_UF").ToString())

      End While

      Dim dtrT As DataTableReader = objDTTelefone.CreateDataReader
      _bsr_pessoa_telefone.Delete(PESS_ID_PESSOA)
      While dtrT.Read

        _bsr_pessoa_telefone.Insert(PESS_ID_PESSOA, dtrT("TITE_ID_TIPO_TELEFONE").ToString(), dtrT("PETE_NR_DDD").ToString(), dtrT("PETE_NR_TELEFONE").ToString(), dtrT("PETE_NR_RAMAL").ToString())

      End While

      Dim strSql As String = "CA_sp_loja_UPDATE "
      _FunctionsDB.MontaSQL(strSql, LOJA_ID_LOJA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, PESS_ID_PESSOA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, PESS_IN_TIPOPESSOA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, TILJ_ID_TIPO_LOJA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_TX_CONTATO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_TX_LOGOTIPO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_LOGIN, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_SENHA_MASTER, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_REPRESENTANTE, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_IN_TIPO_ADMINISTRACAO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, UF_OPERACAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)

      _AccessData.ExecNonQuery(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Grid_Supervisores_Ativos(ByRef objDT As DataTable) As Boolean

    Try

      Dim strSql As String = "ca_sp_loja_supervisores_ativos_SELECT_grid"
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Insert(ByVal REDE_ID_REDE As String, ByVal LOJA_IN_TIPO_ADMINISTRACAO As String, ByVal USUA_ID_REPRESENTANTE As String, ByVal PESS_IN_TIPOPESSOA As String, ByVal PESS_TX_NOME As String, ByVal PESS_TX_EMAIL As String, ByVal PESS_IN_BLOQ As String, ByVal PEPF_CD_CPF As String, ByVal PEPJ_TX_RAZAOSOCIAL As String, ByVal PEPJ_CD_CNPJ As String, ByVal PEPJ_CD_INSCRICAOESTADUAL As String, ByVal TILJ_ID_TIPO_LOJA As String, ByVal LOJA_TX_CONTATO As String, ByVal LOJA_TX_LOGOTIPO As String, ByVal USUA_ID_USUARIO_LOGADO As String, ByVal USUA_TX_SENHA_MASTER As String, ByVal objDtEndereco As DataTable, ByVal objDtTelefone As DataTable, ByVal USUA_ID_USUARIO_MODELO As String, ByVal GRUS_ID_GRUPO_MODELO As String, ByVal TIUS_ID_TIPO_MODELO As String, ByVal UF_OPERACAO As String, ByVal LOJA_IN_BLOQ As String) As Integer

    Dim pess_id_pessoa As Integer

    Try

      Dim objDTLoja As New DataTable
      Dim _bsr_pessoa_logradouro As New CA_pessoa_logradouro
      Dim _bsr_pessoa_telefone As New CA_pessoa_telefone
      Dim objFuncions As New Imperia.Common.Functions

      PESS_TX_NOME = objFuncions.Tira_CaracteresEstranhos(PESS_TX_NOME)

      Dim strSql As String = "CA_sp_loja_INSERT "
      _FunctionsDB.MontaSQL(strSql, REDE_ID_REDE, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, PESS_IN_TIPOPESSOA, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PESS_TX_NOME, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PESS_TX_EMAIL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PESS_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, True)
      _FunctionsDB.MontaSQL(strSql, PEPF_CD_CPF, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PEPJ_TX_RAZAOSOCIAL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PEPJ_CD_CNPJ, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, PEPJ_CD_INSCRICAOESTADUAL, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, TILJ_ID_TIPO_LOJA, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_TX_CONTATO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_TX_LOGOTIPO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO_LOGADO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_TX_SENHA_MASTER, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_REPRESENTANTE, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_IN_TIPO_ADMINISTRACAO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, USUA_ID_USUARIO_MODELO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, GRUS_ID_GRUPO_MODELO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, TIUS_ID_TIPO_MODELO, Imperia.Common.Functions_DB.tipo_Campo.Numero, True)
      _FunctionsDB.MontaSQL(strSql, UF_OPERACAO, Imperia.Common.Functions_DB.tipo_Campo.Texto, True)
      _FunctionsDB.MontaSQL(strSql, LOJA_IN_BLOQ, Imperia.Common.Functions_DB.tipo_Campo.Boleano, False)


      pess_id_pessoa = DirectCast(_AccessData.ExecScalar(strSql), DataTable).Rows(0)(0)

      For Each objDR As DataRow In objDtEndereco.Rows

        _bsr_pessoa_logradouro.Insert(pess_id_pessoa, objDR("CILO_ID_CIDADE_LOGRADOURO"), objDR("TILO_ID_TIPO_LOGRADOURO"), objDR("PELO_TX_LOGRADOURO"), objDR("PELO_NR_LOGRADOURO"), objDR("PELO_TX_COMPLEMENTO"), objDR("PELO_TX_BAIRRO"), objDR("PELO_TX_CEP"), objDR("UF_ID_UF"))

      Next

      For Each objDR As DataRow In objDtTelefone.Rows

        _bsr_pessoa_telefone.Insert(pess_id_pessoa, objDR("TITE_ID_TIPO_TELEFONE"), objDR("PETE_NR_DDD"), objDR("PETE_NR_TELEFONE"), objDR("PETE_NR_RAMAL"))

      Next

      Return pess_id_pessoa

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex

      Return False

    End Try

  End Function

  Public Function Select_ONE_pess_id_pessoa(ByRef objDT As DataTable, ByVal pess_id_pessoa As String) As Boolean

    Try

      Dim strSql As String = "CA_sp_loja_SELECT_one_pess_id_pessoa"
      _FunctionsDB.MontaSQL(strSql, pess_id_pessoa, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Disponiveis_Loja(ByRef objDT As DataTable, ByVal loja_id_loja As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_loja_SELECT_disponiveis_meio_pagamento"
      _FunctionsDB.MontaSQL(strSql, loja_id_loja, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Select_Associadas_Loja(ByRef objDT As DataTable, ByVal loja_id_loja As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_loja_SELECT_associadas_meio_pagamento"
      _FunctionsDB.MontaSQL(strSql, loja_id_loja, Imperia.Common.Functions_DB.tipo_Campo.Numero, False)
      objDT = _AccessData.ExecQueryDt(strSql)

      Return True

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

  Public Function Assoc_Loja_Meio(ByVal loja_id_loja As String, ByVal meio_id_meio_pagamento As String) As Boolean

    Try

      Dim strSql As String = "ca_sp_assoc_loja_meio_pagamento_update "
      _FunctionsDB.MontaSQL(strSql, loja_id_loja, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, True)
      _FunctionsDB.MontaSQL(strSql, meio_id_meio_pagamento, Imperia.Common.Functions_DB.tipo_Campo.ToNull_Texto, False)

      Return _AccessData.ExecNonQuery(strSql)

    Catch ex As Exception

      COD_ERRO = 1
      MSG_ERRO = TrataErros(ex.Message.ToString())
      Throw ex


      Return False

    End Try

  End Function

End Class
