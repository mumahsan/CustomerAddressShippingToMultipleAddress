Imports ConvergeTest.Entities

Public Class frmChangeUser
    Dim userInfo As New LoginInfo
    Dim newUserInfo As New LoginInfo
    Dim path As String = "C:\Data\link.ini"

    Public Sub New(ByVal lInof As LoginInfo)

        ' This call is required by the designer.
        InitializeComponent()
        userInfo = lInof
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newUser = txtNewUser.Text
        Dim newpass = txtNewPassword.Text
        Dim lines = IO.File.ReadAllLines(path)
        For i = 1 To lines.Length - 1
            Dim line = lines(i)
            Dim words As String() = line.Split(New Char() {" "c, CChar(vbTab)})
            If words.Length > 2 Then
                Dim user = words(0)
                Dim m = words(2)
                Dim password = words(4)
                If user = userInfo.user AndAlso password = userInfo.password Then
                    newUserInfo.user = newUser
                    newUserInfo.password = newpass
                    words(0) = newUser
                    words(4) = newpass
                    lines(i) = String.Format("{0}" + CChar(vbTab) + "{1}" + CChar(vbTab) + "{2}", newUser, m, newpass)
                    IO.File.WriteAllLines(path, lines)
                    Dim form1 As New Form1(newUserInfo)
                    form1.Show()
                    Me.Hide()
                End If
            End If
        Next

    End Sub

    Private Sub frmChangeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewUser.Text = userInfo.user
        txtNewPassword.Text = userInfo.password
    End Sub
End Class