Public Class LoginInfo
    Private userid As String
    Public Property user() As String
        Get
            Return userid
        End Get
        Set(ByVal value As String)
            userid = value
        End Set
    End Property
    Private pass As String
    Public Property password() As String
        Get
            Return pass
        End Get
        Set(ByVal value As String)
            pass = value
        End Set
    End Property
End Class
