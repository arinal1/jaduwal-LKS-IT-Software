Public Class formSchedule
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

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

    Private Sub formSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JaduwalDataSet.subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.JaduwalDataSet.subject)
        'TODO: This line of code loads data into the 'JaduwalDataSet._class' table. You can move, or remove it, as needed.
        Me.ClassTableAdapter.Fill(Me.JaduwalDataSet._class)
        'TODO: This line of code loads data into the 'JaduwalDataSet.day' table. You can move, or remove it, as needed.
        Me.DayTableAdapter.Fill(Me.JaduwalDataSet.day)

        ulangForm()

        If mainMenu.editSchedule Then
            Dim schedules_id As Integer
            Dim schedule_id As String
            Dim time_1 As String
            Dim time_2 As String
            schedules_id = mainMenu.schedules_id
            schedule_id = mainMenu.schedule_id
            cbDay.Text = mainMenu.sc_day
            cbClass.SelectedValue = mainMenu.class_id
            cbSubject.SelectedValue = mainMenu.sc_subject
            time_1 = Mid(mainMenu.sc_time, 1, 5)
            time_2 = Mid(mainMenu.sc_time, 9)
            time1.Value = DateTime.ParseExact(time_1, "HH.mm", Nothing)
            time2.Value = DateTime.ParseExact(time_2, "HH.mm", Nothing)
        End If

    End Sub

    Sub ulangForm()
        cbDay.SelectedIndex = 0
        cbClass.SelectedIndex = 0
        cbSubject.SelectedIndex = 0
        time1.Value = DateTime.ParseExact("00.00", "HH.mm", Nothing)
        time2.Value = DateTime.ParseExact("00.00", "HH.mm", Nothing)
    End Sub

    Private Sub time2_ValueChanged(sender As Object, e As EventArgs) Handles time2.ValueChanged
        If time2.Value < time1.Value Then
            time2.Value = time1.Value
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If mainMenu.editSchedule Then
            'update
        Else
            'insert
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ulangForm()
    End Sub
End Class