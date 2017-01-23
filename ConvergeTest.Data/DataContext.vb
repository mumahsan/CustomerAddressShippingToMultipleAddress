Imports System.Data.SqlClient
Imports ConvergeTest.Entities
Imports ConvergeTest.Common
Public Class DataContext

    Private myConn As SqlConnection = Nothing
    Private myCmd As SqlCommand = Nothing
    Private myReader As SqlDataReader = Nothing
    Private results As String = Nothing
    Private sql As String = Nothing

    Public Function Created() As SqlConnection
        Dim ConnectionString As String = "Initial Catalog=ConvergeTest;" + "Data Source=LAPTOP-9G8UF6TR\SQLSERVER2016; Integrated Security=SSPI;"
        Dim conn = New SqlConnection(ConnectionString)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Return conn
    End Function
    Public Function InsertCustomer(ByVal customer As Customer) As Result
        Using myConn = Created()
            myConn.Open()
            sql = "INSERT INTO [dbo].[Customer]
           ([FirstName]
           ,[LastName])
     VALUES
           ('" + customer.FName + "'
           ,'" + customer.LName + "')"
            myCmd = New SqlCommand(sql, myConn)
            Dim result As Result = New Result()
            Try
                Dim noOfRecord As Int32 = myCmd.ExecuteNonQuery()
                If noOfRecord > 0 Then
                    result.retStatus = "Successful"
                    result.RetValue = GetData()

                Else
                    result.retStatus = "Failed or No Data"
                    result.RetValue = Nothing
                End If
            Catch ex As Exception
                result.retStatus = ex.Message.ToString()
                result.RetValue = Nothing
            End Try
            Return result
        End Using
    End Function
    Public Function UpdateCustomer(ByVal customer As Customer) As Result
        Using myConn = Created()
            sql = "Update Customer set FirstName = '" & customer.FName & "', LastName = '" & customer.LName & "' where CustomerId = " & customer.CustNo
            myCmd = New SqlCommand(sql, myConn)
            Dim result As Result = New Result()
            Try
                myConn.Open()
                Dim noOfRecord As Int32 = myCmd.ExecuteNonQuery()
                If noOfRecord > 0 Then
                    result.retStatus = "Successful"
                    result.RetValue = GetData()

                Else
                    result.retStatus = "Failed or No Data"
                    result.RetValue = Nothing
                End If
            Catch ex As Exception
                result.retStatus = ex.Message.ToString()
                result.RetValue = Nothing
            End Try
            Return result
        End Using
    End Function
    Public Function DeleteCustomer(ByVal customer As Customer) As Result
        Using myConn = Created()
            sql = "Update Customer set Status= 'Deleted' where CustomerId = " & customer.CustNo
            myCmd = New SqlCommand(sql, myConn)
            Dim result As Result = New Result()
            Try
                myConn.Open()
                Dim noOfRecord As Int32 = myCmd.ExecuteNonQuery()
                If noOfRecord > 0 Then
                    result.retStatus = "Successful"
                    result.RetValue = GetData()

                Else
                    result.retStatus = "Failed or No Data"
                    result.RetValue = Nothing
                End If
            Catch ex As Exception
                result.retStatus = ex.Message.ToString()
                result.RetValue = Nothing
            End Try
            Return result
        End Using
    End Function
    Public Function GetData() As DataTable

        Dim northwindConnection As SqlConnection = Created()
        'New SqlConnection(connectionString)
        Dim sql As String = "SELECT CustomerId, FirstName, LastName, CustomerName, Status FROM Customer WHERE  (Status <> 'Deleted') OR (Status IS NULL)"
        'Dim command As New SqlCommand(sqlCommand, northwindConnection)
        Dim command As New SqlCommand(sql, northwindConnection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        adapter.SelectCommand = command
        Dim result As Result = New Result()
        Dim table As New DataTable("Paging")
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)
        'result.RetValue = table
        Return table
    End Function

    Public Function InsertAddress(ByVal address As Address) As Result
        Using myConn = Created()
            myConn.Open()
            '       INSERT INTO [dbo].[Address]
            '      ([CustomerId]
            '      ,[AddressLine1]
            '      ,[AddressLine2]
            '      ,[AddressLine3]
            '      ,[City]
            '      ,[State]
            '      ,[Zip]
            '      ,[Phone]
            '      ,[Contact]
            '      ,[Status])
            'VALUES
            '      (<CustomerId, int,>
            '      ,<AddressLine1, nvarchar(50),>
            '      ,<AddressLine2, nvarchar(50),>
            '      ,<AddressLine3, nvarchar(50),>
            '      ,<City, nvarchar(30),>
            '      ,<State, nvarchar(50),>
            '      ,<Zip, nvarchar(10),>
            '      ,<Phone, nvarchar(10),>
            '      ,<Contact, nvarchar(50),>
            '      ,<Status, nvarchar(50),>)
            sql = "INSERT INTO [dbo].[Address] ([CustomerId], [AddressLine1] ,[AddressLine2]) VALUES (@CustomerId, @AddressLine1, @AddressLine2)"
            'sql = "INSERT INTO [dbo].[Address] ([CustomerId], [AddressLine1] ,[AddressLine2]) VALUES ('" & address.AddressLine1 & "','" & address.AddressLine2 & "')"
            myCmd = New SqlCommand(sql, myConn)

            myCmd.Parameters.Add("@AddressLine1", SqlDbType.NVarChar)
            myCmd.Parameters("@AddressLine1").Value = address.AddressLine1

            myCmd.Parameters.Add("@AddressLine2", SqlDbType.NVarChar)
            myCmd.Parameters("@AddressLine2").Value = address.AddressLine2

            myCmd.Parameters.Add("@CustomerId", SqlDbType.Int)
            myCmd.Parameters("@CustomerId").Value = address.CustomerNo

            Dim result As Result = New Result()
            Try
                Dim noOfRecord As Int32 = myCmd.ExecuteNonQuery()
                If noOfRecord > 0 Then
                    result.retStatus = "Successful"
                    result.RetValue = Nothing

                Else
                    result.retStatus = "Failed or No Data"
                    result.RetValue = Nothing
                End If
            Catch ex As Exception
                result.retStatus = ex.Message.ToString()
                result.RetValue = Nothing
            End Try
            Return result
        End Using
    End Function
    Public Function UpdateAddress(ByVal address As Address) As Result
        Using myConn = Created()
            sql = "Update Address set AddressLine1 = @AddressLine1, AddressLine2 = @AddressLine2 where Id = @Id"
            myCmd = New SqlCommand(sql, myConn)

            myCmd.Parameters.Add("@AddressLine1", SqlDbType.NVarChar)
            myCmd.Parameters("@AddressLine1").Value = address.AddressLine1

            myCmd.Parameters.Add("@AddressLine2", SqlDbType.NVarChar)
            myCmd.Parameters("@AddressLine2").Value = address.AddressLine2

            myCmd.Parameters.Add("@Id", SqlDbType.Int)
            myCmd.Parameters("@Id").Value = address.AddressId

            Dim result As Result = New Result()
            Try
                myConn.Open()
                Dim noOfRecord As Int32 = myCmd.ExecuteNonQuery()
                If noOfRecord > 0 Then
                    result.retStatus = "Successful"
                    result.RetValue = Nothing

                Else
                    result.retStatus = "Failed or No Data"
                    result.RetValue = Nothing
                End If
            Catch ex As Exception
                result.retStatus = ex.Message.ToString()
                result.RetValue = Nothing
            End Try
            Return result
        End Using
    End Function
    Public Function DeleteAddress(ByVal address As Address) As Result
        Using myConn = Created()
            sql = "Update Address set Status= 'Deleted' where Id = @Id"
            myCmd = New SqlCommand(sql, myConn)
            myCmd.Parameters.Add("@Id", SqlDbType.Int)
            myCmd.Parameters("@Id").Value = address.AddressId

            Dim result As Result = New Result()
            Try
                myConn.Open()
                Dim noOfRecord As Int32 = myCmd.ExecuteNonQuery()
                If noOfRecord > 0 Then
                    result.retStatus = "Successful"
                    result.RetValue = Nothing

                Else
                    result.retStatus = "Failed or No Data"
                    result.RetValue = Nothing
                End If
            Catch ex As Exception
                result.retStatus = ex.Message.ToString()
                result.RetValue = Nothing
            End Try
            Return result
        End Using
    End Function
    Public Function GetAddressData(ByVal customerId As Integer) As DataTable
        Dim databaseConnection As SqlConnection = Created()
        'New SqlConnection(connectionString)
        Dim sql As String = "SELECT AddressLine1, AddressLine2, Status FROM Address WHERE  (CustomerId = @CustomerId)"
        'Dim command As New SqlCommand(sqlCommand, northwindConnection)
        Dim command As New SqlCommand(sql, databaseConnection)
        command.Parameters.Add("@CustomerId", SqlDbType.Int)
        command.Parameters("@CustomerId").Value = customerId
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        adapter.SelectCommand = command
        Dim result As Result = New Result()
        Dim table As New DataTable("Paging")
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)
        'result.RetValue = table
        Return table
    End Function
End Class
