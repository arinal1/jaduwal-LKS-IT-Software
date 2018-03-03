<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class messageInfo
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
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pesan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWrapper.Controls.Add(Me.btnOk)
        Me.PanelWrapper.Controls.Add(Me.pesan)
        Me.PanelWrapper.Controls.Add(Me.Label1)
        Me.PanelWrapper.Controls.Add(Me.PanelWindowBar)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Size = New System.Drawing.Size(200, 200)
        Me.PanelWrapper.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(12, 139)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(176, 49)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'pesan
        '
        Me.pesan.AutoSize = True
        Me.pesan.BackColor = System.Drawing.Color.White
        Me.pesan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesan.Location = New System.Drawing.Point(12, 73)
        Me.pesan.Name = "pesan"
        Me.pesan.Size = New System.Drawing.Size(55, 21)
        Me.pesan.TabIndex = 2
        Me.pesan.Text = "Pesan!"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 163)
        Me.Label1.TabIndex = 2
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(198, 35)
        Me.PanelWindowBar.TabIndex = 1
        '
        'windowBar
        '
        Me.windowBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.windowBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowBar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowBar.ForeColor = System.Drawing.Color.White
        Me.windowBar.Location = New System.Drawing.Point(0, 0)
        Me.windowBar.Name = "windowBar"
        Me.windowBar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.windowBar.Size = New System.Drawing.Size(163, 35)
        Me.windowBar.TabIndex = 4
        Me.windowBar.Text = "Message"
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
        Me.btnClose.Location = New System.Drawing.Point(163, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'messageInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "messageInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "messageInfo"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelWrapper.PerformLayout()
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents pesan As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label1 As Label
End Class
