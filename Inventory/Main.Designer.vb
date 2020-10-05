<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.det = New System.Windows.Forms.Label()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btninventory = New System.Windows.Forms.Button()
        Me.btnass = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 4)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 15, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(83, 614)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.det)
        Me.Panel2.Controls.Add(Me.btnreport)
        Me.Panel2.Controls.Add(Me.btninventory)
        Me.Panel2.Controls.Add(Me.btnass)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.lbldate)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.tim)
        Me.Panel2.Location = New System.Drawing.Point(-2, 519)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 96)
        Me.Panel2.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(347, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 88)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "EMPLOYEES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'det
        '
        Me.det.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.det.AutoSize = True
        Me.det.BackColor = System.Drawing.Color.Transparent
        Me.det.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.det.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.det.Location = New System.Drawing.Point(9, 2)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(50, 21)
        Me.det.TabIndex = 30
        Me.det.Text = "Date"
        '
        'btnreport
        '
        Me.btnreport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnreport.BackColor = System.Drawing.Color.ForestGreen
        Me.btnreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreport.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreport.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.Black
        Me.btnreport.Location = New System.Drawing.Point(147, 4)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(178, 88)
        Me.btnreport.TabIndex = 31
        Me.btnreport.Text = "MASTER LIST"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btninventory
        '
        Me.btninventory.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btninventory.BackColor = System.Drawing.Color.ForestGreen
        Me.btninventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninventory.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninventory.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.ForeColor = System.Drawing.Color.Black
        Me.btninventory.Location = New System.Drawing.Point(537, 4)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Size = New System.Drawing.Size(178, 88)
        Me.btninventory.TabIndex = 30
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.UseVisualStyleBackColor = False
        '
        'btnass
        '
        Me.btnass.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnass.BackColor = System.Drawing.Color.ForestGreen
        Me.btnass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnass.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnass.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnass.ForeColor = System.Drawing.Color.Black
        Me.btnass.Location = New System.Drawing.Point(727, 4)
        Me.btnass.Name = "btnass"
        Me.btnass.Size = New System.Drawing.Size(178, 88)
        Me.btnass.TabIndex = 29
        Me.btnass.Text = "ASSIGN"
        Me.btnass.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblUser.Location = New System.Drawing.Point(9, 66)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(42, 21)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "User"
        '
        'lbldate
        '
        Me.lbldate.Location = New System.Drawing.Point(0, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(100, 23)
        Me.lbldate.TabIndex = 33
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(0, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 23)
        Me.lblTime.TabIndex = 34
        '
        'tim
        '
        Me.tim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tim.AutoSize = True
        Me.tim.BackColor = System.Drawing.Color.Transparent
        Me.tim.Font = New System.Drawing.Font("Century Gothic", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tim.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tim.Location = New System.Drawing.Point(3, 12)
        Me.tim.Name = "tim"
        Me.tim.Size = New System.Drawing.Size(123, 55)
        Me.tim.TabIndex = 32
        Me.tim.Text = "Time"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(441, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 87)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "SCC"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 110.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(89, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(877, 177)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "INVENTORY"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 614)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btninventory As Button
    Friend WithEvents btnass As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tim As Label
    Friend WithEvents det As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents btnreport As Button
End Class
