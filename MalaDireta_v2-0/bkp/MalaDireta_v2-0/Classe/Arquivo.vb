Imports System.IO

Public Class Arquivo
    Public Function read(ByVal dir As String) As String

        Dim textFlow As IO.StreamReader
        Dim textLine As String
        Dim textExit As String = ""

        If IO.File.Exists(dir) Then
            textFlow = New IO.StreamReader(dir)
            textLine = textFlow.ReadLine

            While textLine <> Nothing
                textExit &= textLine & vbCrLf
                textLine = textFlow.ReadLine
            End While
            textFlow.Close()
        Else
            MessageBox.Show("Arquivo não existe")
        End If

        Return textExit
    End Function

    Public Sub save(ByVal dir As String, ByVal conteudo As String)
        Dim textflow As IO.StreamWriter

        textflow = New IO.StreamWriter(dir)
        textflow.Write(conteudo)
        textflow.Close()
    End Sub
End Class
