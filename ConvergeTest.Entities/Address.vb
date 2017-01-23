Public Class Address
    Private AddId As Integer
    Public Property AddressId() As Integer
        Get
            Return AddId
        End Get
        Set(ByVal value As Integer)
            AddId = value
        End Set
    End Property
    Private CustNo As Integer
    Public Property CustomerNo() As Integer
        Get
            Return CustNo
        End Get
        Set(ByVal value As Integer)
            CustNo = value
        End Set
    End Property
    Private AddLine1 As String
    Public Property AddressLine1() As String
        Get
            Return AddLine1
        End Get
        Set(ByVal value As String)
            AddLine1 = value
        End Set
    End Property
    Private AddLine2 As String
    Public Property AddressLine2() As String
        Get
            Return AddLine2
        End Get
        Set(ByVal value As String)
            AddLine2 = value
        End Set
    End Property
End Class
