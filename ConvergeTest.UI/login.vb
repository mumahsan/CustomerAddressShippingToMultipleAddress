Imports System.IO
Imports System.Text.RegularExpressions
Imports ConvergeTest.Entities

Public Class login
    Dim loginInfo As New LoginInfo
    Dim path As String = "C:\Data\link.ini"
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            'Using sr As StreamReader = New StreamReader("C:\Data\link.ini")
            '    Dim line = Await sr.ReadToEndAsync()
            '    ' Loop through words in string.
            '    Dim arr As String() = line.Split(New Char() {" "c, CChar(vbTab)})
            '    ResultBlock.Text = arr.ToString()

            'End Using
            Dim lines = IO.File.ReadAllLines(path)
            For i = 1 To lines.Length - 1
                Dim line = lines(i)
                Dim words As String() = line.Split(New Char() {" "c, CChar(vbTab)})
                If words.Length > 2 Then
                    Dim user = words(0)
                    Dim password = words(2)
                    If user = txtUser.Text AndAlso password = txtPassword.Text Then
                        loginInfo.user = user
                        loginInfo.password = password
                        Dim form1 As New Form1(loginInfo)
                        form1.Show()
                        Me.Hide()
                    End If
                End If
            Next
        Catch
            ResultBlock.Text = "Could not read the file"
        End Try

    End Sub
End Class