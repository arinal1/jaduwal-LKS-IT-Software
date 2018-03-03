<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.titlePage = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.LoginTableAdapter = New Jaduwal.jaduwalDataSetTableAdapters.LoginTableAdapter()
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.PanelHeader.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelWrapper.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelTitleBar)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(348, 100)
        Me.PanelHeader.TabIndex = 2
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.Controls.Add(Me.titlePage)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 35)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(348, 65)
        Me.PanelTitleBar.TabIndex = 1
        '
        'titlePage
        '
        Me.titlePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titlePage.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlePage.ForeColor = System.Drawing.Color.White
        Me.titlePage.Location = New System.Drawing.Point(0, 0)
        Me.titlePage.Name = "titlePage"
        Me.titlePage.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.titlePage.Size = New System.Drawing.Size(348, 65)
        Me.titlePage.TabIndex = 0
        Me.titlePage.Text = "Please Login To Jaduwal"
        Me.titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(348, 35)
        Me.PanelWindowBar.TabIndex = 0
        '
        'windowBar
        '
        Me.windowBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowBar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowBar.ForeColor = System.Drawing.Color.White
        Me.windowBar.Location = New System.Drawing.Point(0, 0)
        Me.windowBar.Name = "windowBar"
        Me.windowBar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.windowBar.Size = New System.Drawing.Size(313, 35)
        Me.windowBar.TabIndex = 4
        Me.windowBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(313, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txUsername
        '
        Me.txUsername.Location = New System.Drawing.Point(128, 147)
        Me.txUsername.Name = "txUsername"
        Me.txUsername.Size = New System.Drawing.Size(173, 20)
        Me.txUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'txPassword
        '
        Me.txPassword.Location = New System.Drawing.Point(128, 205)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPassword.Size = New System.Drawing.Size(173, 20)
        Me.txPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(53, 276)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogin.Size = New System.Drawing.Size(248, 49)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWrapper.Controls.Add(Me.btnLogin)
        Me.PanelWrapper.Controls.Add(Me.Label2)
        Me.PanelWrapper.Controls.Add(Me.txPassword)
        Me.PanelWrapper.Controls.Add(Me.Label1)
        Me.PanelWrapper.Controls.Add(Me.txUsername)
        Me.PanelWrapper.Controls.Add(Me.PanelHeader)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Size = New System.Drawing.Size(350, 350)
        Me.PanelWrapper.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 350)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelWrapper.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents titlePage As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents LoginTableAdapter As jaduwalDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents PanelWrapper As Panel
End Class
