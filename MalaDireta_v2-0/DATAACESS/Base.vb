Imports System.Data.SqlClient

Public MustInherit Class Base

  Friend _AccessData As New Imperia.AccessData.AccessData
  Friend _AccessData_ODBC As New Imperia.AccessData.AccessData_ODBC
  Friend _Functions As New Imperia.Common.Functions
  Friend _FunctionsDB As New Imperia.Common.Functions_DB

  Friend Function TrataErros(ByVal MSG_ERRO As String) As String

    If InStr(MSG_ERRO, "Timeout") > 0 Then
      MSG_ERRO = "O sistema pode estar passando por dificuldades t�cnicas devido ao volume de transa��es. Tente novamente mais tarde."
    ElseIf InStr(MSG_ERRO, "IX_Menu") > 0 Then
      MSG_ERRO = "Objeto j� existente. Utilize um outro nome de objeto."
    ElseIf InStr(MSG_ERRO, "IX_Sub_Menu") > 0 Then
      MSG_ERRO = "Objeto j� existente. Utilize um outro nome de objeto."
    ElseIf InStr(MSG_ERRO, "IX_Rotina_Sistema") > 0 Then
      MSG_ERRO = "Objeto j� existente. Utilize um outro nome de objeto."
    ElseIf InStr(MSG_ERRO, "IX_Usuario") > 0 Then
      MSG_ERRO = "N�o foi poss�vel efetuar o cadastro pois este email j� existe cadastrado conosco!"
    ElseIf InStr(MSG_ERRO, "IX_ca_usuario_USUA_TX_LOGIN") > 0 Then
      MSG_ERRO = "N�o foi poss�vel realizar este cadastro ou altera��o pois j� existe um mesmo login igual ao informado no sistema! Informe um outro login."
    ElseIf InStr(MSG_ERRO, "IX_CA_tipo_usuario_TIUS_TX_DESCRICAO_grus_ID_grupo") > 0 Then
      MSG_ERRO = "N�o foi poss�vel realizar este cadastro ou altera��o pois este tipo de usu�rio j� existe neste grupo. Verifique a pr�-exist�ncia do mesmo e se for o caso, tente novamente."
    ElseIf InStr(MSG_ERRO, "FK_IPESSOA_PESSOA") > 0 Then '<< GAIA
      MSG_ERRO = "Esta marca n�o pode ser exclu�da, pois j� est� referenciada em outros cadastros."
    ElseIf InStr(MSG_ERRO, "FK_Usuario_Tipo_Usuario") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir este tipo de usu�rio pois existem usu�rios cadastrados com este tipo."
    ElseIf InStr(MSG_ERRO, "FK_Sub_Menu_Menu") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir este menu, pois existem sub-menus associados."
    ElseIf InStr(MSG_ERRO, "FK_Permissao_Usuario_Usuario") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir este usu�rio, pois existem permiss�es de usu�rio associadas a ele."
    ElseIf InStr(MSG_ERRO, "FK_Assoc_Tipo_Usuario_Rotina_Rotina_Sistema") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir esta rotina de sistema, pois existem associa��es de tipo de usu�rio com esta rotina de sistema."
    ElseIf InStr(MSG_ERRO, "FK_Permissao_Usuario_Rotina_Sistema") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir esta rotina de sistema, pois existem permiss�es de usu�rio associadas a ela."
    ElseIf InStr(MSG_ERRO, "FK_Preferencias_Usuario") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir este usu�rio, pois existem prefer�ncias de usu�rio associadas a ele."
    ElseIf InStr(MSG_ERRO, "FK_Usuario_Tipo_Usuario") > 0 Then
      MSG_ERRO = "N�o foi poss�vel excluir este tipo de usu�rio, pois existem usu�rios associados a ele. Como alternativa voc� pode bloquear este tipo de usu�rio."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_faq_categoria_ca_categoria") > 0 Then
      MSG_ERRO = "N�o � poss�vel apagar esta categoria, pois a mesma est� associada com alguns itens."
    ElseIf InStr(MSG_ERRO, "FK_ca_categoria_ca_categoria") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir uma categoria pai, sem antes excluir as categorias filhas."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_plano_funcionalidade_ca_funcionalidade") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta funcionalidade, pois ela est� sendo utilizada em algum plano."
    ElseIf InStr(MSG_ERRO, "FK_ca_enquete_votos_ca_usuario") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir este usu�rio, pois ele participou de resultados de enquetes."
    ElseIf InStr(MSG_ERRO, "FK_ca_enquete_votos_ca_enquete_respostas") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta enquete, pois ela j� recebeu votos de usu�rios."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_usuario_item_ca_usuario") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir este usu�rio, pois o mesmo possui v�nculos com itens cadastrados. Como alternativa voc� pode bloquear este usu�rio."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_faq_categoria_ca_categoria") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta categoria, pois a mesma possui v�nculos com itens cadastrados. Como alternativa voc� pode bloquear esta categoria."
    ElseIf InStr(MSG_ERRO, "FK_ca_loja_ca_usuario") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir este usu�rio, pois o mesmo possui v�nculos com uma loja cadastrada. Como alternativa voc� pode bloquear este usu�rio."
    ElseIf InStr(MSG_ERRO, "FK_ca_funcionario_ca_loja") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta loja, em virtude dela possuir funcion�rios cadastrados. Voc� deve primeiramente excluir os funcion�rios e em seguida excluir esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_loja_pdv") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta loja, em virtude dela possuir PDV PINPAD cadastrados. Voc� deve primeiramente excluir os PDV PINPAD e em seguida excluir esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_loja_meio_pagamento_ca_loja") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta loja, em virtude dela possuir MEIOS DE PAGAMENTOS cadastrados. Voc� deve primeiramente desassociar os MEIOS DE PAGAMENTOS e em seguida excluir esta loja."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_TEF_ca_funcionario") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir este funcion�rio pois existem opera��es realizadas atreladas a ele. Como alternativa voc� pode bloquear o usu�rio deste funcion�rio. O login de usu�rio � o ID do funcion�rio."
    ElseIf InStr(MSG_ERRO, "FK_OPERACAO_TEF_ca_funcionario") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir este funcion�rio pois existem opera��es realizadas atreladas a ele. Como alternativa voc� pode bloquear o usu�rio deste funcion�rio. O login de usu�rio � o ID do funcion�rio."
    ElseIf InStr(MSG_ERRO, "FK_OPERACAO_TEF_ca_loja") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta loja pois existem opera��es realizadas atreladas a ela. Como alternativa voc� pode bloquear esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_loja_banco_ca_loja") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir esta loja, pois existem cadastros de dados banc�rios atreladas a ela. Como alternativa voc� pode tentar excluir os dados banc�rios primeiro ou se for o caso, bloquear esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_loja_banco_ca_banco") > 0 Then
      MSG_ERRO = "Voc� n�o pode excluir este banco, pois existem cadastros de dados banc�rios de loja atrelados a ele. Como alternativa voc� pode tentar excluir os dados banc�rios atrelados primeiro ou se for o caso, bloquear esta loja."
    ElseIf InStr(MSG_ERRO, "IX_ca_assoc_loja_pdv_unico") > 0 Then
      MSG_ERRO = "O n�mero do PDV deve ser �nico. Jamais ele pode se repetir. Ele provavelmente j� est� sendo utilizado por outra loja. Cuidado ao realizar este tipo de opera��o."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_ca_dpos_convenio") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover este conv�nio pois o mesmo encontra-se atrelado aos perfis de DPOS que est�o atrelados as lojas. Cuidado ao realizar este tipo de opera��o."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_BOLETO_CA_OPERACAO_TEF") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover esta opera��o pois existe um registro de boleto atrelado."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_cedente_ca_dpos") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover esta configura��o pois existe um registro de Cedente atrelado."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_cedente_ca_meio_pagamento") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover meio de pagamento pois existe um registro de Cedente atrelado."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_cedente_ca_banco") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover este banco pois existe um registro de Cedente atrelado."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_TEF_LIBERACAO_ca_usuario") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover este usu�rio pois existem opera��es associadas a ele."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_TEF_LIBERACAO_CA_OPERACAO_TEF") > 0 Then
      MSG_ERRO = "N�o � poss�vel remover esta opera��o. A mesma encontra-se tamb�m na tabela de opera��es pendentes de libera��o."
    ElseIf InStr(MSG_ERRO, "XML parsing error") > 0 Then
      MSG_ERRO = "O XML que est� sendo utilizado na opera��o n�o � um documento XML v�lido."
    ElseIf InStr(MSG_ERRO, "{INFO}") > 0 Then
      MSG_ERRO = Replace(MSG_ERRO, "{INFO}", "")
    End If

    Return MSG_ERRO

  End Function

  Public Sub CloseConnection()

    _AccessData.CloseConnection()

  End Sub

End Class
