Public Class messageInfo
    Public varPesan As String
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
    Private Sub messageInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        pesan.Text = varPesan
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class