Imports ConvergeTest.Entities
Imports ConvergeTest.Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IServiceCustomer
    <OperationContract()>
    Function InsertCustomer(ByVal customer As Customer) As Result
    <OperationContract()>
    Function UpdateCustomer(ByVal customer As Customer) As Result
    <OperationContract()>
    Function DeleteCustomer(ByVal customer As Customer) As Result
    <OperationContract>
    Function GetData() As CompositeType
    <OperationContract>
    Function GetAddressData(ByVal customerId As Integer) As CompositeType
    <OperationContract()>
    Function InsertAddress(ByVal address As Address) As Result
    '<OperationContract()>
    'Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: Add your service operations here

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.
' You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ConvergeTest.Service.ContractType".

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property DataValue() As DataTable

    <DataMember()>
    Public Property StringValue() As String

End Class
