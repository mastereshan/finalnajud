<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.items = New System.Windows.Forms.Panel()
        Me.cboSortby = New System.Windows.Forms.ComboBox()
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.Assigned = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvorder = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Panel()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.items.SuspendLayout()
        Me.Assigned.SuspendLayout()
        Me.Add.SuspendLayout()
        Me.SuspendLayout()
        '
        'items
        '
        Me.items.BackColor = System.Drawing.Color.WhiteSmoke
        Me.items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.items.Controls.Add(Me.cboSortby)
        Me.items.Controls.Add(Me.lblNotify)
        Me.items.Controls.Add(Me.lvProducts)
        Me.items.Controls.Add(Me.Label7)
        Me.items.Controls.Add(Me.Label11)
        Me.items.Controls.Add(Me.tbsearch)
        Me.items.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.items.Location = New System.Drawing.Point(9, 45)
        Me.items.Name = "items"
        Me.items.Size = New System.Drawing.Size(563, 631)
        Me.items.TabIndex = 25
        '
        'cboSortby
        '
        Me.cboSortby.BackColor = System.Drawing.Color.White
        Me.cboSortby.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSortby.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboSortby.FormattingEnabled = True
        Me.cboSortby.Items.AddRange(New Object() {"Name", "Category", "Stock"})
        Me.cboSortby.Location = New System.Drawing.Point(408, 580)
        Me.cboSortby.Name = "cboSortby"
        Me.cboSortby.Size = New System.Drawing.Size(136, 32)
        Me.cboSortby.TabIndex = 45
        Me.cboSortby.Text = "- Sort By -"
        '
        'lblNotify
        '
        Me.lblNotify.AutoSize = True
        Me.lblNotify.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotify.ForeColor = System.Drawing.Color.Teal
        Me.lblNotify.Location = New System.Drawing.Point(13, 591)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(15, 20)
        Me.lblNotify.TabIndex = 32
        Me.lblNotify.Text = "*"
        '
        'lvProducts
        '
        Me.lvProducts.BackColor = System.Drawing.Color.White
        Me.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.lvProducts.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lvProducts.FullRowSelect = True
        Me.lvProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvProducts.Location = New System.Drawing.Point(17, 125)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(527, 447)
        Me.lvProducts.TabIndex = 44
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Category"
        Me.ColumnHeader4.Width = 155
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 98
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Stock"
        Me.ColumnHeader5.Width = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "- Search Item -"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(13, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 21)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "- Item List -"
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.White
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(17, 35)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(527, 50)
        Me.tbsearch.TabIndex = 40
        '
        'Assigned
        '
        Me.Assigned.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Assigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Assigned.Controls.Add(Me.lvorder)
        Me.Assigned.Controls.Add(Me.ComboBox1)
        Me.Assigned.Controls.Add(Me.btncancel)
        Me.Assigned.Controls.Add(Me.Label8)
        Me.Assigned.Controls.Add(Me.Label12)
        Me.Assigned.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Assigned.Location = New System.Drawing.Point(571, 45)
        Me.Assigned.Name = "Assigned"
        Me.Assigned.Size = New System.Drawing.Size(479, 439)
        Me.Assigned.TabIndex = 29
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 17
        Me.ComboBox1.Location = New System.Drawing.Point(20, 49)
        Me.ComboBox1.MaximumSize = New System.Drawing.Size(300, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(273, 25)
        Me.ComboBox1.TabIndex = 39
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Enabled = False
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Crimson
        Me.btncancel.Location = New System.Drawing.Point(326, 35)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(129, 50)
        Me.btncancel.TabIndex = 39
        Me.btncancel.Text = "Cancel Transaction"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "- Assigned Item List -"
        '
        'lvorder
        '
        Me.lvorder.BackColor = System.Drawing.Color.White
        Me.lvorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvorder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader11})
        Me.lvorder.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lvorder.FullRowSelect = True
        Me.lvorder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvorder.Location = New System.Drawing.Point(19, 125)
        Me.lvorder.Name = "lvorder"
        Me.lvorder.Size = New System.Drawing.Size(436, 313)
        Me.lvorder.TabIndex = 28
        Me.lvorder.UseCompatibleStateImageBehavior = False
        Me.lvorder.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 148
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Price"
        Me.ColumnHeader7.Width = 105
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Quantity"
        Me.ColumnHeader8.Width = 81
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "SubTotal"
        Me.ColumnHeader11.Width = 98
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 21)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "- Employee Name -"
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Add.Controls.Add(Me.btnAssign)
        Me.Add.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Add.Location = New System.Drawing.Point(571, 482)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(479, 194)
        Me.Add.TabIndex = 28
        '
        'btnAssign
        '
        Me.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAssign.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssign.ForeColor = System.Drawing.Color.Teal
        Me.btnAssign.Location = New System.Drawing.Point(326, 145)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(129, 50)
        Me.btnAssign.TabIndex = 28
        Me.btnAssign.Text = "ASSIGN"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1014, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 27)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = " X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "ASSIGN ITEMS"
        '
        'Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1058, 686)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Assigned)
        Me.Controls.Add(Me.items)
        Me.Controls.Add(Me.Add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.items.ResumeLayout(False)
        Me.items.PerformLayout()
        Me.Assigned.ResumeLayout(False)
        Me.Assigned.PerformLayout()
        Me.Add.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents items As Panel
    Friend WithEvents cboSortby As ComboBox
    Friend WithEvents lblNotify As Label
    Friend WithEvents lvProducts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbsearch As TextBox
    Friend WithEvents Assigned As Panel
    Friend WithEvents lvorder As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btncancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Add As Panel
    Friend WithEvents btnAssign As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
