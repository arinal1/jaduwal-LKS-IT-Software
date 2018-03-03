<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subjectInfo
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
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.finalExam = New System.Windows.Forms.Label()
        Me.midExam = New System.Windows.Forms.Label()
        Me.assignment = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BackColor = System.Drawing.Color.White
        Me.PanelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWrapper.Controls.Add(Me.Label3)
        Me.PanelWrapper.Controls.Add(Me.PanelFooter)
        Me.PanelWrapper.Controls.Add(Me.txDescription)
        Me.PanelWrapper.Controls.Add(Me.Label1)
        Me.PanelWrapper.Controls.Add(Me.Label2)
        Me.PanelWrapper.Controls.Add(Me.subject)
        Me.PanelWrapper.Controls.Add(Me.Label14)
        Me.PanelWrapper.Controls.Add(Me.Label15)
        Me.PanelWrapper.Controls.Add(Me.Label16)
        Me.PanelWrapper.Controls.Add(Me.Label13)
        Me.PanelWrapper.Controls.Add(Me.PanelHeader)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Size = New System.Drawing.Size(284, 350)
        Me.PanelWrapper.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(242, 27)
        Me.Label3.TabIndex = 14
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelFooter
        '
        Me.PanelFooter.Controls.Add(Me.finalExam)
        Me.PanelFooter.Controls.Add(Me.midExam)
        Me.PanelFooter.Controls.Add(Me.assignment)
        Me.PanelFooter.Controls.Add(Me.Label5)
        Me.PanelFooter.Controls.Add(Me.Label4)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(20, 276)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(242, 62)
        Me.PanelFooter.TabIndex = 13
        '
        'finalExam
        '
        Me.finalExam.Dock = System.Windows.Forms.DockStyle.Left
        Me.finalExam.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalExam.Location = New System.Drawing.Point(162, 26)
        Me.finalExam.Name = "finalExam"
        Me.finalExam.Size = New System.Drawing.Size(81, 36)
        Me.finalExam.TabIndex = 14
        Me.finalExam.Text = "Final Exam 35%"
        Me.finalExam.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'midExam
        '
        Me.midExam.Dock = System.Windows.Forms.DockStyle.Left
        Me.midExam.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midExam.Location = New System.Drawing.Point(81, 26)
        Me.midExam.Name = "midExam"
        Me.midExam.Size = New System.Drawing.Size(81, 36)
        Me.midExam.TabIndex = 13
        Me.midExam.Text = "Mid Exam 35%"
        Me.midExam.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'assignment
        '
        Me.assignment.Dock = System.Windows.Forms.DockStyle.Left
        Me.assignment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignment.Location = New System.Drawing.Point(0, 26)
        Me.assignment.Name = "assignment"
        Me.assignment.Size = New System.Drawing.Size(81, 36)
        Me.assignment.TabIndex = 12
        Me.assignment.Text = "Assignment 30%"
        Me.assignment.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(242, 2)
        Me.Label5.TabIndex = 11
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Composition"
        '
        'txDescription
        '
        Me.txDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.txDescription.Enabled = False
        Me.txDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDescription.Location = New System.Drawing.Point(20, 99)
        Me.txDescription.Multiline = True
        Me.txDescription.Name = "txDescription"
        Me.txDescription.Size = New System.Drawing.Size(242, 150)
        Me.txDescription.TabIndex = 11
        Me.txDescription.Text = "Learning about Math and Logic"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(242, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(242, 2)
        Me.Label2.TabIndex = 10
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'subject
        '
        Me.subject.AutoSize = True
        Me.subject.Dock = System.Windows.Forms.DockStyle.Top
        Me.subject.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject.Location = New System.Drawing.Point(20, 55)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(63, 24)
        Me.subject.TabIndex = 3
        Me.subject.Text = "Math"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(262, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(20, 283)
        Me.Label14.TabIndex = 7
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(0, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label15.Size = New System.Drawing.Size(20, 283)
        Me.Label15.TabIndex = 8
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label16.Size = New System.Drawing.Size(282, 20)
        Me.Label16.TabIndex = 9
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(282, 10)
        Me.Label13.TabIndex = 6
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(282, 35)
        Me.PanelHeader.TabIndex = 2
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(282, 35)
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
        Me.windowBar.Size = New System.Drawing.Size(247, 35)
        Me.windowBar.TabIndex = 4
        Me.windowBar.Text = "Subject Info"
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
        Me.btnClose.Location = New System.Drawing.Point(247, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'subjectInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 350)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "subjectInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "subjectInfo"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelWrapper.PerformLayout()
        Me.PanelFooter.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents subject As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents finalExam As Label
    Friend WithEvents midExam As Label
    Friend WithEvents assignment As Label
    Friend WithEvents Label5 As Label
End Class
