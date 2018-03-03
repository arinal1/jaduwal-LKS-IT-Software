<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSchedule
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.time2 = New System.Windows.Forms.DateTimePicker()
        Me.time1 = New System.Windows.Forms.DateTimePicker()
        Me.cbSubject = New System.Windows.Forms.ComboBox()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JaduwalDataSet = New Jaduwal.jaduwalDataSet()
        Me.cbClass = New System.Windows.Forms.ComboBox()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.DayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.titlePage = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DayTableAdapter = New Jaduwal.jaduwalDataSetTableAdapters.dayTableAdapter()
        Me.ClassTableAdapter = New Jaduwal.jaduwalDataSetTableAdapters.classTableAdapter()
        Me.SubjectTableAdapter = New Jaduwal.jaduwalDataSetTableAdapters.subjectTableAdapter()
        Me.PanelWrapper.SuspendLayout()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JaduwalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BackColor = System.Drawing.Color.White
        Me.PanelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWrapper.Controls.Add(Me.time2)
        Me.PanelWrapper.Controls.Add(Me.time1)
        Me.PanelWrapper.Controls.Add(Me.cbSubject)
        Me.PanelWrapper.Controls.Add(Me.cbClass)
        Me.PanelWrapper.Controls.Add(Me.cbDay)
        Me.PanelWrapper.Controls.Add(Me.Label5)
        Me.PanelWrapper.Controls.Add(Me.Label4)
        Me.PanelWrapper.Controls.Add(Me.Label3)
        Me.PanelWrapper.Controls.Add(Me.btnReset)
        Me.PanelWrapper.Controls.Add(Me.btnSave)
        Me.PanelWrapper.Controls.Add(Me.Label2)
        Me.PanelWrapper.Controls.Add(Me.Label1)
        Me.PanelWrapper.Controls.Add(Me.PanelHeader)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Size = New System.Drawing.Size(369, 398)
        Me.PanelWrapper.TabIndex = 6
        '
        'time2
        '
        Me.time2.CustomFormat = "HH:mm"
        Me.time2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time2.Location = New System.Drawing.Point(232, 270)
        Me.time2.Name = "time2"
        Me.time2.ShowUpDown = True
        Me.time2.Size = New System.Drawing.Size(88, 25)
        Me.time2.TabIndex = 12
        Me.time2.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'time1
        '
        Me.time1.CustomFormat = "HH:mm"
        Me.time1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time1.Location = New System.Drawing.Point(110, 270)
        Me.time1.Name = "time1"
        Me.time1.ShowUpDown = True
        Me.time1.Size = New System.Drawing.Size(88, 25)
        Me.time1.TabIndex = 12
        Me.time1.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'cbSubject
        '
        Me.cbSubject.DataSource = Me.SubjectBindingSource
        Me.cbSubject.DisplayMember = "name"
        Me.cbSubject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubject.FormattingEnabled = True
        Me.cbSubject.Location = New System.Drawing.Point(110, 231)
        Me.cbSubject.Name = "cbSubject"
        Me.cbSubject.Size = New System.Drawing.Size(210, 25)
        Me.cbSubject.TabIndex = 10
        Me.cbSubject.ValueMember = "subject_id"
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "subject"
        Me.SubjectBindingSource.DataSource = Me.JaduwalDataSet
        '
        'JaduwalDataSet
        '
        Me.JaduwalDataSet.DataSetName = "jaduwalDataSet"
        Me.JaduwalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbClass
        '
        Me.cbClass.DataSource = Me.ClassBindingSource
        Me.cbClass.DisplayMember = "name"
        Me.cbClass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClass.FormattingEnabled = True
        Me.cbClass.Location = New System.Drawing.Point(110, 189)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(210, 25)
        Me.cbClass.TabIndex = 10
        Me.cbClass.ValueMember = "class_id"
        '
        'ClassBindingSource
        '
        Me.ClassBindingSource.DataMember = "class"
        Me.ClassBindingSource.DataSource = Me.JaduwalDataSet
        '
        'cbDay
        '
        Me.cbDay.DataSource = Me.DayBindingSource
        Me.cbDay.DisplayMember = "day"
        Me.cbDay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Location = New System.Drawing.Point(110, 147)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(210, 25)
        Me.cbDay.TabIndex = 10
        Me.cbDay.ValueMember = "id"
        '
        'DayBindingSource
        '
        Me.DayBindingSource.DataMember = "day"
        Me.DayBindingSource.DataSource = Me.JaduwalDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(204, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(156, 336)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(70, 40)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(250, 336)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Day"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelTitleBar)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(367, 100)
        Me.PanelHeader.TabIndex = 2
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.Controls.Add(Me.titlePage)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 35)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(367, 65)
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
        Me.titlePage.Size = New System.Drawing.Size(367, 65)
        Me.titlePage.TabIndex = 0
        Me.titlePage.Text = "Form Schedule"
        Me.titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(367, 35)
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
        Me.windowBar.Size = New System.Drawing.Size(332, 35)
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
        Me.btnClose.Location = New System.Drawing.Point(332, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DayTableAdapter
        '
        Me.DayTableAdapter.ClearBeforeFill = True
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'formSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 398)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formSchedule"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelWrapper.PerformLayout()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JaduwalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents titlePage As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents cbSubject As ComboBox
    Friend WithEvents cbClass As ComboBox
    Friend WithEvents cbDay As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents time2 As DateTimePicker
    Friend WithEvents time1 As DateTimePicker
    Friend WithEvents JaduwalDataSet As jaduwalDataSet
    Friend WithEvents DayBindingSource As BindingSource
    Friend WithEvents DayTableAdapter As jaduwalDataSetTableAdapters.dayTableAdapter
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As jaduwalDataSetTableAdapters.classTableAdapter
    Friend WithEvents SubjectBindingSource As BindingSource
    Friend WithEvents SubjectTableAdapter As jaduwalDataSetTableAdapters.subjectTableAdapter
End Class
