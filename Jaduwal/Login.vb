Public Class Login
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public userId As String
    Public username As String
    Public level As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txUsername.Focus()
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txUsername.Text IsNot "" And txPassword.Text IsNot "" Then
            Dim dt As New DataTable
            dt = LoginTableAdapter.GetData(txUsername.Text, txPassword.Text)
            If dt.Rows.Count > 0 Then
                userId = dt.Rows(0).Item(0)
                username = dt.Rows(0).Item(1)
                level = dt.Rows(0).Item(2)
                Me.Hide()
                mainMenu.ShowDialog()
                If mainMenu.logout = False Then
                    Me.Close()
                End If
                userId = ""
                username = ""
                level = 0
                txUsername.Clear()
                txPassword.Clear()
                txUsername.Focus()
            Else
                messageInfo.varPesan = "Login Gagal!"
                messageInfo.ShowDialog()
                txPassword.Focus()
            End If
        Else
            messageInfo.varPesan = "Mohon data dilengkapi!"
            messageInfo.ShowDialog()
            txUsername.Focus()
        End If
    End Sub
End Class