' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in both code and config file together.
Imports ConvergeTest.Entities
Imports ConvergeTest.Data
Imports ConvergeTest.Service
Imports ConvergeTest.Common

Public Class ServiceCustomer
    Implements IServiceCustomer
    Dim db As New DataContext

    Public Function DeleteCustomer(customer As Customer) As Result Implements IServiceCustomer.DeleteCustomer
        Return db.DeleteCustomer(customer)
    End Function

    Public Function GetAddressData(ByVal customerId As Integer) As CompositeType Implements IServiceCustomer.GetAddressData
        Dim obj As CompositeType = New CompositeType()
        obj.DataValue = db.GetAddressData(customerId)
        Return obj
    End Function

    Public Function GetData() As CompositeType Implements IServiceCustomer.GetData
        Dim obj As CompositeType = New CompositeType()
        obj.DataValue = db.GetData()
        Return obj
    End Function

    Public Function InsertAddress(address As Address) As Result Implements IServiceCustomer.InsertAddress
        Return db.InsertAddress(address)
    End Function

    Public Function InsertCustomer(customer As Customer) As Result Implements IServiceCustomer.InsertCustomer
        Return db.InsertCustomer(customer)
    End Function

    Public Function UpdateCustomer(customer As Customer) As Result Implements IServiceCustomer.UpdateCustomer
        Return db.UpdateCustomer(customer)
    End Function
End Class
