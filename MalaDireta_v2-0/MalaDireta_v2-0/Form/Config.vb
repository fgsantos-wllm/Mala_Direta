Public Class Conf

    '-------------------------------------------------------------------------------------------------------------------
    'ATRIBUTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private f As New Form

    '-------------------------------------------------------------------------------------------------------------------
    'CONSTRUTORES
    '-------------------------------------------------------------------------------------------------------------------
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByRef f As Form)
        InitializeComponent()

        Me.f = f
    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'MÉTODOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub alteraTam(ByRef obj As Control, ByVal novoTam As Point)
        Dim antigoTam As Point = obj.Size
        Dim antigaRes As Point = Me.f.Size

        Dim x As Integer = antigoTam.X * novoTam.X / antigaRes.X
        Dim y As Integer = antigoTam.Y * novoTam.Y / antigaRes.Y
        obj.Font = New Font(obj.Font.Name, obj.Font.Size * novoTam.X / antigaRes.X)

        obj.Size = New Point(x, y)
    End Sub
    Private Sub alteraPos(ByRef obj As Control, ByVal novaRes As Point)
        Dim antigaRes As Point = Me.f.Size

        Dim x As Integer = obj.Location.X * novaRes.X / antigaRes.X
        Dim y As Integer = obj.Location.Y * novaRes.Y / antigaRes.Y

        obj.Location = New Point(x, y)
    End Sub

    Private Sub alteraRes(ByVal w As Integer, ByVal h As Integer)
        Dim novaRes As Point = New Point(w, h)
        Dim controles As ControlCollection = Me.f.Controls

        For Each con As Control In controles
            alteraPos(con, novaRes)
            alteraTam(con, novaRes)
        Next

        Me.f.Size = New System.Drawing.Size(novaRes)
    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '-------------------------------------------------------------------------------------------------------------------
    Private Sub btn1240x730_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1240x730.Click
        alteraRes(1240, 730)
    End Sub

    Private Sub btn1000x650_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1000x650.Click
        alteraRes(1000, 650)
    End Sub

    Private Sub btn800x600_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn800x600.Click
        alteraRes(800, 600)
    End Sub
End Class