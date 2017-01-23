Imports ConvergeTest.Entities
Imports ConvergeTest.Common
Imports System.Data.SqlClient
Public Class Form1
    Dim initial As Integer = 0
    Dim AddressInitial As Integer = 0
    Private bindingSource1 As New BindingSource()
    Private bindingSource2 As New BindingSource()
    Dim DataSvc As New ServiceReferenceCustomer.ServiceCustomerClient

    Dim loginInfo As New LoginInfo
    Public Sub New(ByVal empid As LoginInfo)
        InitializeComponent()
        loginInfo = empid
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConvergeTestDataSet.Customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.ConvergeTestDataSet.Customer)

        InitializeDataGridView()
        'Panel1.Controls.Add(TextBox1)
        Panel1.Visible = False

    End Sub
    Private Sub InitializeDataGridView()
        'DataGridView1.DataSource = Nothing
        Try
            ' Set up the DataGridView.
            With Me.DataGridView1
                ' Automatically generate the DataGridView columns.
                .AutoGenerateColumns = True
                ' Set up the data source.
                'bindingSource1.DataSource = GetData("Select * From Customer")
                Dim ct As New ServiceReferenceCustomer.CompositeType
                'ct = DataSvc.GetData("SELECT CustomerId, FirstName, LastName, CustomerName, Status FROM Customer WHERE  (Status <> 'Deleted') OR (Status IS NULL)")
                ct = DataSvc.GetData()
                bindingSource1.DataSource = ct.DataValue
                .DataSource = bindingSource1

                .Columns("CustomerId").Visible = False
                .Columns("FirstName").Visible = False
                .Columns("LastName").Visible = False
                .Columns("Status").Visible = False
                If initial < 1 Then
                    initial = initial + 1
                    Dim chk As New DataGridViewCheckBoxColumn()
                    chk.Name = "Select"
                    DataGridView1.Columns.Add(chk)
                End If
                ' Automatically resize the visible rows.
                .AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

                ' Set the DataGridView control's border.
                .BorderStyle = BorderStyle.Fixed3D

                ' Put the cells in edit mode when user enters them.
                .EditMode = DataGridViewEditMode.EditProgrammatically
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As Result = New Result()
        Dim customer As Customer
        customer = New Customer()
        If btnSave.Text = "Save" AndAlso Not TextBox1.Text = "" Then
            customer.FName = TextBox1.Text
            customer.LName = TextBox2.Text
            result = DataSvc.InsertCustomer(customer)
            'If result.retStatus = "Successful" Then
            '    InitializeDataGridView()
            'End If
            MessageBox.Show(result.retStatus)
        ElseIf btnSave.Text = "Update" Then
            customer.CustNo = txtCustomerNo.Text
            customer.FName = TextBox1.Text
            customer.LName = TextBox2.Text
            result = DataSvc.UpdateCustomer(customer)
            If result.retStatus = "Successful" Then
                btnSave.Text = "Save"
            End If
        End If
        If result.retStatus = "Successful" Then
            InitializeDataGridView()
            btnSave.Text = "Save"
            Panel1.Visible = False
            ClearAll()
        End If

    End Sub

    Private Sub ClearAll()
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtCustomerNo.Text = ""
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.CustomerTableAdapter.FillBy(Me.ConvergeTestDataSet.Customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim sdr As DataGridViewRow
        Dim srCount As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not IsDBNull(row.Cells("Select").Value) AndAlso (row.Cells("Select").Value = True) Then
                sdr = row
                srCount = srCount + 1
                If srCount > 1 Then
                    For Each row2 As DataGridViewRow In DataGridView1.Rows
                        If Not IsNothing(row2.Cells("Select").Value) AndAlso (row2.Cells("Select").Value = True) Then
                            row2.Cells(5).Value = False
                        End If
                    Next
                    MessageBox.Show("Please select one row to edit!!!")
                    Exit For
                End If
            End If
        Next
        If Not IsNothing(sdr) Then
            Panel1.Visible = True
            txtCustomerNo.Text = sdr.Cells(0).Value
            TextBox1.Text = sdr.Cells(1).Value
            TextBox2.Text = sdr.Cells(2).Value
            btnSave.Text = "Update"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As Result = New Result()
        Dim customer As Customer
        customer = New Customer()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not IsDBNull(row.Cells("Select").Value) AndAlso (row.Cells("Select").Value = True) Then
                customer.CustNo = row.Cells("CustomerId").Value
                customer.FName = row.Cells("FirstName").Value
                customer.LName = row.Cells("LastName").Value
                result = DataSvc.DeleteCustomer(customer)
            End If
        Next
        If result.retStatus = "Successful" Then
            InitializeDataGridView()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim cr As New DataGridViewRow
        cr = DataGridView1.CurrentRow
        If Not IsDBNull(cr.Cells("Select").Value) AndAlso (cr.Cells("Select").Value = True) Then
            cr.Cells("Select").Value = False
            'bindingSource2 = Nothing
        ElseIf cr.Cells("Select").Value = False Then
            cr.Cells("Select").Value = True
            txtCustomerNo.Text = cr.Cells("CustomerId").Value
            InitializeAddressDataGridView(cr.Cells("CustomerId").Value)
        End If
    End Sub

    Private Sub InitializeAddressDataGridView(value As Integer)

        Try
            ' Set up the DataGridView.
            With Me.DataGridView2
                ' Automatically generate the DataGridView columns.
                .AutoGenerateColumns = True
                ' Set up the data source.
                'bindingSource1.DataSource = GetData("Select * From Customer")
                Dim ct As New ServiceReferenceCustomer.CompositeType
                ct = DataSvc.GetAddressData(value)

                If ct.DataValue.Rows.Count > 0 Then
                    bindingSource2.DataSource = ct.DataValue
                    .DataSource = bindingSource2
                    .Columns("Status").Visible = False
                    If AddressInitial < 1 Then
                        AddressInitial = AddressInitial + 1
                        Dim chk As New DataGridViewCheckBoxColumn()
                        chk.Name = "Select"
                        DataGridView2.Columns.Add(chk)
                    End If
                Else
                    bindingSource2.DataSource = Nothing
                End If

                ' Automatically resize the visible rows.
                .AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

                ' Set the DataGridView control's border.
                .BorderStyle = BorderStyle.Fixed3D

                ' Put the cells in edit mode when user enters them.
                .EditMode = DataGridViewEditMode.EditProgrammatically
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel1.Visible = True
    End Sub

    Private Sub btnSaveAddress_Click(sender As Object, e As EventArgs) Handles btnSaveAddress.Click
        Dim result As Result = New Result()
        Dim address As Address
        address = New Address()
        If btnSaveAddress.Text = "Save" AndAlso Not txtAddressLine1.Text = "" Then
            address.CustomerNo = txtCustomerNo.Text
            address.AddressLine1 = txtAddressLine1.Text
            address.AddressLine2 = txtAddressLine2.Text
            result = DataSvc.InsertAddress(address)
            If result.retStatus = "Successful" Then
                InitializeAddressDataGridView(address.CustomerNo)
            End If
            MessageBox.Show(result.retStatus)
        ElseIf btnSave.Text = "Update" Then
            address.CustomerNo = txtCustomerNo.Text
            address.AddressLine1 = txtAddressLine1.Text
            address.AddressLine2 = txtAddressLine2.Text
            'result = DataSvc.UpdateCustomer(address)
            If result.retStatus = "Successful" Then
                btnSave.Text = "Save"
            End If
        End If
        If result.retStatus = "Successful" Then
            InitializeDataGridView()
            btnSave.Text = "Save"
            Panel1.Visible = False
            ClearAll()
        End If
    End Sub

    Private Sub ChangeUserPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserPasswordToolStripMenuItem.Click
        Dim frmChange As New frmChangeUser(loginInfo)
        frmChange.Show()
        Me.Hide()
    End Sub


    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        Dim ct As New ServiceReferenceCustomer.CompositeType
        ct = DataSvc.GetData()
        Dim dt As New DataTable
        Dim resultSet As New DataTable
        dt = ct.DataValue
        resultSet = dt.Clone
        If Not String.IsNullOrEmpty(txtSearchCustomer.Text) Then
            For Each dr In dt.Rows
                For i = 0 To dt.Columns.Count - 1
                    If Not dr(i).ToString().ToLower().IndexOf(txtSearchCustomer.Text) = -1 Then
                        resultSet.ImportRow(dr)
                    End If
                Next
            Next
        End If

        If resultSet.Rows.Count > 0 Then
            bindingSource1.DataSource = resultSet
            With DataGridView1
                .DataSource = bindingSource1
                .Columns("CustomerId").Visible = False
                .Columns("FirstName").Visible = False
                .Columns("LastName").Visible = False
                .Columns("Status").Visible = False
                If initial < 1 Then
                    initial = initial + 1
                    Dim chk As New DataGridViewCheckBoxColumn()
                    chk.Name = "Select"
                    DataGridView1.Columns.Add(chk)
                End If
            End With
        End If
    End Sub
End Class
