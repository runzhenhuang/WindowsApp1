Public Class Form2
    Dim xdir, ydir As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim velocity As Integer = 4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newx = PictureBox1.Location.X + velocity * xdir
        newx = Math.Min(Math.Max(0, newx), Me.ClientSize.Width - PictureBox1.Width)
        Dim newy = PictureBox1.Location.Y + velocity * ydir
        newy = Math.Min(Math.Max(0, newy), Me.ClientSize.Height - PictureBox1.Height)
        PictureBox1.Location = New Point(newx, newy)
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.W : If ydir = -1 Then ydir = 0
            Case Keys.A : If xdir = -1 Then xdir = 0
            Case Keys.S : If ydir = 1 Then ydir = 0
            Case Keys.D : If xdir = 1 Then xdir = 0
        End Select
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W : ydir = -1
            Case Keys.A : xdir = -1
            Case Keys.S : ydir = 1
            Case Keys.D : xdir = 1
        End Select
    End Sub
End Class