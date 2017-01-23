Public Class Result
    Private Status As String
    Public Property retStatus() As String
        Get
            Return Status
        End Get
        Set(ByVal value As String)
            Status = value
        End Set
    End Property
    Private Value As DataTable
    Public Property RetValue() As DataTable
        Get
            Return Value
        End Get
        Set(ByVal value As DataTable)
            value = value
        End Set
    End Property
End Class
