Public Class mainMenu
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public logout As Boolean
    'schedule
    Public editSchedule As Boolean
    Dim actQry As String
    Public schedules_id As Integer
    Public schedule_id As String
    Public sc_subject As String
    Public sc_time As String
    Public sc_day As String
    Public class_id As Integer

    'windowbar
    Private Sub WindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles windowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub WindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles windowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub WindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles windowBar.MouseUp
        drag = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        logout = False
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Menu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Login.level = 3 Then
            btnSchedule.Text = "Manage Schedule"
            btnStudent.Text = "Manage Student"
            btnProfile.Visible = False
            Label35.Visible = False
            btnTeacher.Visible = True
            btnClass.Visible = True
            btnSubject.Visible = True
            btnStudent.Visible = True
            Label3.Visible = True
        Else
            btnSchedule.Text = "My Schedule"
            btnStudent.Text = "My Student"
            btnProfile.Visible = True
            Label35.Visible = False
            btnTeacher.Visible = False
            btnClass.Visible = False
            btnSubject.Visible = False
            If Login.level = 1 Then
                btnStudent.Visible = False
                Label3.Visible = False
            Else
                btnStudent.Visible = True
                Label3.Visible = True
            End If
        End If
        fillDataSet()
        btnHome_Click(sender, e)
        isiCbSchedule()
    End Sub

    Sub fillDataSet()
        Me.View_subjectTableAdapter.Fill(Me.JaduwalDataSet.view_subject)
        Me.View_studentTableAdapter.Fill(Me.JaduwalDataSet.view_student)
        Me.View_scheduleTableAdapter.Fill(Me.JaduwalDataSet.view_schedule)
        Me.TeacherTableAdapter.Fill(Me.JaduwalDataSet.teacher)
        Me.SubjectTableAdapter.Fill(Me.JaduwalDataSet.subject)
        Me.StudentTableAdapter.Fill(Me.JaduwalDataSet.student)
        Me.ScheduleTableAdapter.Fill(Me.JaduwalDataSet.schedule)
        Me.Header_scheduleTableAdapter.Fill(Me.JaduwalDataSet.header_schedule)
        Me.DayTableAdapter.Fill(Me.JaduwalDataSet.day)
        Me.ClassTableAdapter.Fill(Me.JaduwalDataSet._class)
        Me.FindTeacherTableAdapter.Fill(Me.JaduwalDataSet.findTeacher, "")
    End Sub

    Sub HidePanel()
        PanelKontenHome.Visible = False
        PanelKontenSchedule.Visible = False
        PanelKontenStudent.Visible = False
        PanelKontenProfile.Visible = False
        PanelKontenTeacher.Visible = False
        PanelKontenClass.Visible = False
        PanelKontenSubject.Visible = False
    End Sub

    'Sidebar Button
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        HidePanel()
        PanelKontenHome.Visible = True
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        HidePanel()
        If Login.level = 3 Then
            PanelAdminSchedule.Visible = True
        Else
            If Login.level = 2 Then
                TeacherDataGridViewTextBoxColumn.Visible = False
            Else
                TeacherDataGridViewTextBoxColumn.Visible = True
            End If
            PanelAdminSchedule.Visible = False
        End If
        PanelKontenSchedule.Visible = True
    End Sub

    Sub isiCbSchedule()
        Dim dtc As New jaduwalDataSet.classDataTable
        dtc = ClassTableAdapter.GetData()
        cbScheduleClass.Items.Add("All")
        For Each row As DataRow In dtc.Rows
            cbScheduleClass.Items.Add(row("name"))
        Next row
        Dim dts As New jaduwalDataSet.subjectDataTable
        dts = SubjectTableAdapter.GetData()
        cbScheduleSubject.Items.Add("All")
        For Each row As DataRow In dts.Rows
            cbScheduleSubject.Items.Add(row("name"))
        Next row
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        HidePanel()
        If Login.level = 3 Then
            PanelAdminStudent.Visible = True
        Else
            PanelAdminStudent.Visible = False
        End If
        PanelKontenStudent.Visible = True
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        HidePanel()
        PanelKontenProfile.Visible = True
    End Sub

    Private Sub btnScheduleSubjectInfo_Click(sender As Object, e As EventArgs) Handles btnScheduleSubjectInfo.Click
        subjectInfo.ShowDialog()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        HidePanel()
        PanelKontenTeacher.Visible = True
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        HidePanel()
        PanelKontenClass.Visible = True
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        HidePanel()
        PanelKontenSubject.Visible = True
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        logout = True
        Me.Close()
        Login.Show()
    End Sub

    'teacher
    Private Sub txTeacherSearch_TextChanged(sender As Object, e As EventArgs) Handles txTeacherSearch.TextChanged
        Dim query = txTeacherSearch.Text
        If query = "" Then
            Me.FindTeacherTableAdapter.Fill(Me.JaduwalDataSet.findTeacher, "")
        Else
            Me.FindTeacherTableAdapter.Fill(Me.JaduwalDataSet.findTeacher, query)
        End If
    End Sub

    'schedule
    Private Sub cbScheduleClass_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbScheduleClass.SelectedValueChanged

    End Sub

    Private Sub btnScheduleAdd_Click(sender As Object, e As EventArgs) Handles btnScheduleAdd.Click
        editSchedule = False
        formSchedule.ShowDialog()
    End Sub

    Private Sub tabelSchedule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelSchedule.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            sc_subject = tabelSchedule.Rows(i).Cells(0).Value
            sc_day = tabelSchedule.Rows(i).Cells(4).Value
            sc_time = tabelSchedule.Rows(i).Cells(5).Value
            schedule_id = tabelSchedule.Rows(i).Cells(6).Value
            schedules_id = tabelSchedule.Rows(i).Cells(7).Value
            class_id = tabelSchedule.Rows(i).Cells(8).Value
        End If
    End Sub

    Private Sub btnScheduleEdit_Click(sender As Object, e As EventArgs) Handles btnScheduleEdit.Click
        If schedule_id = "" Then
            messageInfo.varPesan = "Mohon Pilih Data!"
            messageInfo.ShowDialog()
        Else
            editSchedule = True
            formSchedule.ShowDialog()
        End If
    End Sub
End Class