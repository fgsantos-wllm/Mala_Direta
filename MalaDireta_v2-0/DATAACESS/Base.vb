Imports System.Data.SqlClient

Public MustInherit Class Base

  Friend _AccessData As New Imperia.AccessData.AccessData
  Friend _AccessData_ODBC As New Imperia.AccessData.AccessData_ODBC
  Friend _Functions As New Imperia.Common.Functions
  Friend _FunctionsDB As New Imperia.Common.Functions_DB

  Friend Function TrataErros(ByVal MSG_ERRO As String) As String

    If InStr(MSG_ERRO, "Timeout") > 0 Then
      MSG_ERRO = "O sistema pode estar passando por dificuldades técnicas devido ao volume de transações. Tente novamente mais tarde."
    ElseIf InStr(MSG_ERRO, "IX_Menu") > 0 Then
      MSG_ERRO = "Objeto já existente. Utilize um outro nome de objeto."
    ElseIf InStr(MSG_ERRO, "IX_Sub_Menu") > 0 Then
      MSG_ERRO = "Objeto já existente. Utilize um outro nome de objeto."
    ElseIf InStr(MSG_ERRO, "IX_Rotina_Sistema") > 0 Then
      MSG_ERRO = "Objeto já existente. Utilize um outro nome de objeto."
    ElseIf InStr(MSG_ERRO, "IX_Usuario") > 0 Then
      MSG_ERRO = "Não foi possível efetuar o cadastro pois este email já existe cadastrado conosco!"
    ElseIf InStr(MSG_ERRO, "IX_ca_usuario_USUA_TX_LOGIN") > 0 Then
      MSG_ERRO = "Não foi possível realizar este cadastro ou alteração pois já existe um mesmo login igual ao informado no sistema! Informe um outro login."
    ElseIf InStr(MSG_ERRO, "IX_CA_tipo_usuario_TIUS_TX_DESCRICAO_grus_ID_grupo") > 0 Then
      MSG_ERRO = "Não foi possível realizar este cadastro ou alteração pois este tipo de usuário já existe neste grupo. Verifique a pré-existência do mesmo e se for o caso, tente novamente."
    ElseIf InStr(MSG_ERRO, "FK_IPESSOA_PESSOA") > 0 Then '<< GAIA
      MSG_ERRO = "Esta marca não pode ser excluída, pois já está referenciada em outros cadastros."
    ElseIf InStr(MSG_ERRO, "FK_Usuario_Tipo_Usuario") > 0 Then
      MSG_ERRO = "Não foi possível excluir este tipo de usuário pois existem usuários cadastrados com este tipo."
    ElseIf InStr(MSG_ERRO, "FK_Sub_Menu_Menu") > 0 Then
      MSG_ERRO = "Não foi possível excluir este menu, pois existem sub-menus associados."
    ElseIf InStr(MSG_ERRO, "FK_Permissao_Usuario_Usuario") > 0 Then
      MSG_ERRO = "Não foi possível excluir este usuário, pois existem permissões de usuário associadas a ele."
    ElseIf InStr(MSG_ERRO, "FK_Assoc_Tipo_Usuario_Rotina_Rotina_Sistema") > 0 Then
      MSG_ERRO = "Não foi possível excluir esta rotina de sistema, pois existem associações de tipo de usuário com esta rotina de sistema."
    ElseIf InStr(MSG_ERRO, "FK_Permissao_Usuario_Rotina_Sistema") > 0 Then
      MSG_ERRO = "Não foi possível excluir esta rotina de sistema, pois existem permissões de usuário associadas a ela."
    ElseIf InStr(MSG_ERRO, "FK_Preferencias_Usuario") > 0 Then
      MSG_ERRO = "Não foi possível excluir este usuário, pois existem preferências de usuário associadas a ele."
    ElseIf InStr(MSG_ERRO, "FK_Usuario_Tipo_Usuario") > 0 Then
      MSG_ERRO = "Não foi possível excluir este tipo de usuário, pois existem usuários associados a ele. Como alternativa você pode bloquear este tipo de usuário."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_faq_categoria_ca_categoria") > 0 Then
      MSG_ERRO = "Não é possível apagar esta categoria, pois a mesma está associada com alguns itens."
    ElseIf InStr(MSG_ERRO, "FK_ca_categoria_ca_categoria") > 0 Then
      MSG_ERRO = "Você não pode excluir uma categoria pai, sem antes excluir as categorias filhas."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_plano_funcionalidade_ca_funcionalidade") > 0 Then
      MSG_ERRO = "Você não pode excluir esta funcionalidade, pois ela está sendo utilizada em algum plano."
    ElseIf InStr(MSG_ERRO, "FK_ca_enquete_votos_ca_usuario") > 0 Then
      MSG_ERRO = "Você não pode excluir este usuário, pois ele participou de resultados de enquetes."
    ElseIf InStr(MSG_ERRO, "FK_ca_enquete_votos_ca_enquete_respostas") > 0 Then
      MSG_ERRO = "Você não pode excluir esta enquete, pois ela já recebeu votos de usuários."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_usuario_item_ca_usuario") > 0 Then
      MSG_ERRO = "Você não pode excluir este usuário, pois o mesmo possui vínculos com itens cadastrados. Como alternativa você pode bloquear este usuário."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_faq_categoria_ca_categoria") > 0 Then
      MSG_ERRO = "Você não pode excluir esta categoria, pois a mesma possui vínculos com itens cadastrados. Como alternativa você pode bloquear esta categoria."
    ElseIf InStr(MSG_ERRO, "FK_ca_loja_ca_usuario") > 0 Then
      MSG_ERRO = "Você não pode excluir este usuário, pois o mesmo possui vínculos com uma loja cadastrada. Como alternativa você pode bloquear este usuário."
    ElseIf InStr(MSG_ERRO, "FK_ca_funcionario_ca_loja") > 0 Then
      MSG_ERRO = "Você não pode excluir esta loja, em virtude dela possuir funcionários cadastrados. Você deve primeiramente excluir os funcionários e em seguida excluir esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_loja_pdv") > 0 Then
      MSG_ERRO = "Você não pode excluir esta loja, em virtude dela possuir PDV PINPAD cadastrados. Você deve primeiramente excluir os PDV PINPAD e em seguida excluir esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_assoc_loja_meio_pagamento_ca_loja") > 0 Then
      MSG_ERRO = "Você não pode excluir esta loja, em virtude dela possuir MEIOS DE PAGAMENTOS cadastrados. Você deve primeiramente desassociar os MEIOS DE PAGAMENTOS e em seguida excluir esta loja."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_TEF_ca_funcionario") > 0 Then
      MSG_ERRO = "Você não pode excluir este funcionário pois existem operações realizadas atreladas a ele. Como alternativa você pode bloquear o usuário deste funcionário. O login de usuário é o ID do funcionário."
    ElseIf InStr(MSG_ERRO, "FK_OPERACAO_TEF_ca_funcionario") > 0 Then
      MSG_ERRO = "Você não pode excluir este funcionário pois existem operações realizadas atreladas a ele. Como alternativa você pode bloquear o usuário deste funcionário. O login de usuário é o ID do funcionário."
    ElseIf InStr(MSG_ERRO, "FK_OPERACAO_TEF_ca_loja") > 0 Then
      MSG_ERRO = "Você não pode excluir esta loja pois existem operações realizadas atreladas a ela. Como alternativa você pode bloquear esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_loja_banco_ca_loja") > 0 Then
      MSG_ERRO = "Você não pode excluir esta loja, pois existem cadastros de dados bancários atreladas a ela. Como alternativa você pode tentar excluir os dados bancários primeiro ou se for o caso, bloquear esta loja."
    ElseIf InStr(MSG_ERRO, "FK_ca_loja_banco_ca_banco") > 0 Then
      MSG_ERRO = "Você não pode excluir este banco, pois existem cadastros de dados bancários de loja atrelados a ele. Como alternativa você pode tentar excluir os dados bancários atrelados primeiro ou se for o caso, bloquear esta loja."
    ElseIf InStr(MSG_ERRO, "IX_ca_assoc_loja_pdv_unico") > 0 Then
      MSG_ERRO = "O número do PDV deve ser único. Jamais ele pode se repetir. Ele provavelmente já está sendo utilizado por outra loja. Cuidado ao realizar este tipo de operação."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_ca_dpos_convenio") > 0 Then
      MSG_ERRO = "Não é possível remover este convênio pois o mesmo encontra-se atrelado aos perfis de DPOS que estão atrelados as lojas. Cuidado ao realizar este tipo de operação."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_BOLETO_CA_OPERACAO_TEF") > 0 Then
      MSG_ERRO = "Não é possível remover esta operação pois existe um registro de boleto atrelado."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_cedente_ca_dpos") > 0 Then
      MSG_ERRO = "Não é possível remover esta configuração pois existe um registro de Cedente atrelado."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_cedente_ca_meio_pagamento") > 0 Then
      MSG_ERRO = "Não é possível remover meio de pagamento pois existe um registro de Cedente atrelado."
    ElseIf InStr(MSG_ERRO, "FK_ca_dpos_cedente_ca_banco") > 0 Then
      MSG_ERRO = "Não é possível remover este banco pois existe um registro de Cedente atrelado."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_TEF_LIBERACAO_ca_usuario") > 0 Then
      MSG_ERRO = "Não é possível remover este usuário pois existem operações associadas a ele."
    ElseIf InStr(MSG_ERRO, "FK_CA_OPERACAO_TEF_LIBERACAO_CA_OPERACAO_TEF") > 0 Then
      MSG_ERRO = "Não é possível remover esta operação. A mesma encontra-se também na tabela de operações pendentes de liberação."
    ElseIf InStr(MSG_ERRO, "XML parsing error") > 0 Then
      MSG_ERRO = "O XML que está sendo utilizado na operação não é um documento XML válido."
    ElseIf InStr(MSG_ERRO, "{INFO}") > 0 Then
      MSG_ERRO = Replace(MSG_ERRO, "{INFO}", "")
    End If

    Return MSG_ERRO

  End Function

  Public Sub CloseConnection()

    _AccessData.CloseConnection()

  End Sub

End Class
