<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIPChat
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIPChat))
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.HelpTopicsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutIPChatAppToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOptionsLogout = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOptionsLogin = New System.Windows.Forms.ToolStripMenuItem
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txthostname = New System.Windows.Forms.TextBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtuserip = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnsend = New System.Windows.Forms.Button
        Me.txtip = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.lbltimer = New System.Windows.Forms.Label
        Me.txtsend1 = New System.Windows.Forms.RichTextBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'HelpTopicsToolStripMenuItem1
        '
        Me.HelpTopicsToolStripMenuItem1.Name = "HelpTopicsToolStripMenuItem1"
        Me.HelpTopicsToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.HelpTopicsToolStripMenuItem1.Text = "Help Topics"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SaveToolStripMenuItem.Text = "Save Chat"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem2, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(213, 22)
        Me.ToolStripMenuItem2.Text = "Open Saved Chat"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(210, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(-1, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Hostname"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpTopicsToolStripMenuItem1, Me.ToolStripSeparator3, Me.AboutIPChatAppToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'AboutIPChatAppToolStripMenuItem1
        '
        Me.AboutIPChatAppToolStripMenuItem1.Name = "AboutIPChatAppToolStripMenuItem1"
        Me.AboutIPChatAppToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.AboutIPChatAppToolStripMenuItem1.Text = "About OTAD IPChat"
        '
        'mnuOptionsLogout
        '
        Me.mnuOptionsLogout.Name = "mnuOptionsLogout"
        Me.mnuOptionsLogout.Size = New System.Drawing.Size(113, 22)
        Me.mnuOptionsLogout.Text = "Logout"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsLogout, Me.mnuOptionsLogin})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HelpToolStripMenuItem.Text = "Options"
        '
        'mnuOptionsLogin
        '
        Me.mnuOptionsLogin.Enabled = False
        Me.mnuOptionsLogin.Name = "mnuOptionsLogin"
        Me.mnuOptionsLogin.Size = New System.Drawing.Size(113, 22)
        Me.mnuOptionsLogin.Text = "Login"
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(-1, 69)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(124, 24)
        Me.btnConnect.TabIndex = 34
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txthostname
        '
        Me.txthostname.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txthostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthostname.Location = New System.Drawing.Point(-2, 46)
        Me.txthostname.Name = "txthostname"
        Me.txthostname.ReadOnly = True
        Me.txthostname.Size = New System.Drawing.Size(124, 21)
        Me.txthostname.TabIndex = 33
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(320, 398)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(80, 31)
        Me.btnclear.TabIndex = 31
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 93)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(400, 303)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(126, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Host IP Address:"
        '
        'txtuserip
        '
        Me.txtuserip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtuserip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserip.Location = New System.Drawing.Point(121, 46)
        Me.txtuserip.Name = "txtuserip"
        Me.txtuserip.ReadOnly = True
        Me.txtuserip.Size = New System.Drawing.Size(138, 21)
        Me.txtuserip.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(-1, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "My Name:"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(64, 404)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(179, 21)
        Me.txtusername.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(264, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Recipient PC"
        '
        'btnsend
        '
        Me.btnsend.Enabled = False
        Me.btnsend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.Location = New System.Drawing.Point(244, 398)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(83, 31)
        Me.btnsend.TabIndex = 24
        Me.btnsend.Text = "Send"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'txtip
        '
        Me.txtip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtip.Location = New System.Drawing.Point(258, 46)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(140, 21)
        Me.txtip.TabIndex = 22
        Me.txtip.Text = "127.0.0.1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(401, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lbltimer
        '
        Me.lbltimer.AutoSize = True
        Me.lbltimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimer.ForeColor = System.Drawing.Color.Transparent
        Me.lbltimer.Location = New System.Drawing.Point(121, 75)
        Me.lbltimer.Name = "lbltimer"
        Me.lbltimer.Size = New System.Drawing.Size(76, 13)
        Me.lbltimer.TabIndex = 36
        Me.lbltimer.Text = "Chat Timer: "
        '
        'txtsend1
        '
        Me.txtsend1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsend1.Enabled = False
        Me.txtsend1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsend1.Location = New System.Drawing.Point(-1, 430)
        Me.txtsend1.Name = "txtsend1"
        Me.txtsend1.Size = New System.Drawing.Size(401, 58)
        Me.txtsend1.TabIndex = 37
        Me.txtsend1.Text = ""
        '
        'frmIPChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 489)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lbltimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txthostname)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtuserip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtsend1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmIPChat"
        Me.Opacity = 0
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTAD IPChat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HelpTopicsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutIPChatAppToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptionsLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txthostname As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtuserip As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lbltimer As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtsend1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptionsLogin As System.Windows.Forms.ToolStripMenuItem

End Class
