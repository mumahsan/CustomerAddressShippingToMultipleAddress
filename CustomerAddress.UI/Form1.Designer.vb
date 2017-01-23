<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDeleteAddress = New System.Windows.Forms.Button()
        Me.btnEditAddress = New System.Windows.Forms.Button()
        Me.txtAddressId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.AddressLine1 = New System.Windows.Forms.Label()
        Me.btnSaveAddress = New System.Windows.Forms.Button()
        Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.lblAddressLine1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUserPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerTableAdapter1 = New ConvergeTest.Data.ConvergeTestDataSetTableAdapters.CustomerTableAdapter()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(314, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(314, 161)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(314, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(141, 291)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(411, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Enabled = False
        Me.txtCustomerNo.Location = New System.Drawing.Point(314, 59)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerNo.TabIndex = 9
        Me.txtCustomerNo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(233, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CustomerNo"
        Me.Label3.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(384, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(141, 535)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(411, 150)
        Me.DataGridView2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(141, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 183)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(222, 447)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(222, 691)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnDeleteAddress
        '
        Me.btnDeleteAddress.Location = New System.Drawing.Point(384, 691)
        Me.btnDeleteAddress.Name = "btnDeleteAddress"
        Me.btnDeleteAddress.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteAddress.TabIndex = 15
        Me.btnDeleteAddress.Text = "Delete"
        Me.btnDeleteAddress.UseVisualStyleBackColor = True
        '
        'btnEditAddress
        '
        Me.btnEditAddress.Location = New System.Drawing.Point(303, 691)
        Me.btnEditAddress.Name = "btnEditAddress"
        Me.btnEditAddress.Size = New System.Drawing.Size(75, 23)
        Me.btnEditAddress.TabIndex = 14
        Me.btnEditAddress.Text = "Edit"
        Me.btnEditAddress.UseVisualStyleBackColor = True
        '
        'txtAddressId
        '
        Me.txtAddressId.Enabled = False
        Me.txtAddressId.Location = New System.Drawing.Point(314, 750)
        Me.txtAddressId.Name = "txtAddressId"
        Me.txtAddressId.Size = New System.Drawing.Size(100, 22)
        Me.txtAddressId.TabIndex = 23
        Me.txtAddressId.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(216, 750)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "AddressId"
        Me.Label4.Visible = False
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.Location = New System.Drawing.Point(314, 806)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(100, 22)
        Me.txtAddressLine2.TabIndex = 19
        '
        'AddressLine1
        '
        Me.AddressLine1.AutoSize = True
        Me.AddressLine1.Location = New System.Drawing.Point(216, 806)
        Me.AddressLine1.Name = "AddressLine1"
        Me.AddressLine1.Size = New System.Drawing.Size(95, 17)
        Me.AddressLine1.TabIndex = 20
        Me.AddressLine1.Text = "AddressLine1"
        '
        'btnSaveAddress
        '
        Me.btnSaveAddress.Location = New System.Drawing.Point(314, 852)
        Me.btnSaveAddress.Name = "btnSaveAddress"
        Me.btnSaveAddress.Size = New System.Drawing.Size(93, 30)
        Me.btnSaveAddress.TabIndex = 21
        Me.btnSaveAddress.Text = "Save"
        Me.btnSaveAddress.UseVisualStyleBackColor = True
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.Location = New System.Drawing.Point(314, 778)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.Size = New System.Drawing.Size(100, 22)
        Me.txtAddressLine1.TabIndex = 18
        '
        'lblAddressLine1
        '
        Me.lblAddressLine1.AutoSize = True
        Me.lblAddressLine1.Location = New System.Drawing.Point(216, 778)
        Me.lblAddressLine1.Name = "lblAddressLine1"
        Me.lblAddressLine1.Size = New System.Drawing.Size(95, 17)
        Me.lblAddressLine1.TabIndex = 17
        Me.lblAddressLine1.Text = "AddressLine1"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(141, 735)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(411, 183)
        Me.Panel2.TabIndex = 24
        Me.Panel2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 28)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeUserPasswordToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'ChangeUserPasswordToolStripMenuItem
        '
        Me.ChangeUserPasswordToolStripMenuItem.Name = "ChangeUserPasswordToolStripMenuItem"
        Me.ChangeUserPasswordToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.ChangeUserPasswordToolStripMenuItem.Text = "Change User And Password"
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Location = New System.Drawing.Point(141, 256)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchCustomer.TabIndex = 26
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(247, 255)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(93, 24)
        Me.btnSearchCustomer.TabIndex = 27
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 934)
        Me.Controls.Add(Me.txtSearchCustomer)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.txtAddressId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddressLine2)
        Me.Controls.Add(Me.AddressLine1)
        Me.Controls.Add(Me.btnSaveAddress)
        Me.Controls.Add(Me.txtAddressLine1)
        Me.Controls.Add(Me.lblAddressLine1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDeleteAddress)
        Me.Controls.Add(Me.btnEditAddress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtCustomerNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    'Friend WithEvents CustomerTableAdapter As ConvergeTestDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents txtCustomerNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDeleteAddress As Button
    Friend WithEvents btnEditAddress As Button
    Friend WithEvents txtAddressId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddressLine2 As TextBox
    Friend WithEvents AddressLine1 As Label
    Friend WithEvents btnSaveAddress As Button
    Friend WithEvents txtAddressLine1 As TextBox
    Friend WithEvents lblAddressLine1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CustomerTableAdapter1 As Data.ConvergeTestDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeUserPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents btnSearchCustomer As Button
End Class
