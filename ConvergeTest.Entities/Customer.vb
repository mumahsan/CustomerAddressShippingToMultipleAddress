Public Class Customer
    Private CustomerNo As Integer
    Public Property CustNo() As Integer
        Get
            Return CustomerNo
        End Get
        Set(ByVal value As Integer)
            CustomerNo = value
        End Set
    End Property
    Private FirstName As String
    Public Property FName() As String
        Get
            Return FirstName
        End Get
        Set(ByVal value As String)
            FirstName = value
        End Set
    End Property
    Private LastName As String
    Public Property LName() As String
        Get
            Return LastName
        End Get
        Set(ByVal value As String)
            LastName = value
        End Set
    End Property
End Class
