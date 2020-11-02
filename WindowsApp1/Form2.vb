Public Class Form2
    Dim xdir, ydir As Integer
    Dim collision As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orignx = PictureBox1.Location.X
        origny = PictureBox1.Location.Y
    End Sub

    Dim velocity As Integer = 4
    Dim jumpVelocity As Integer = 8
    Dim orignx As Integer = 0
    Dim origny As Integer = 0
    Dim jump As Boolean = False
    Dim Buttony As Integer
    Dim move As Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim pbxBounds = PictureBox1.Bounds
        pbxBounds.Inflate(1, 1)
        For Each Button In Me.Controls
            If Button IsNot PictureBox1 AndAlso pbxBounds.IntersectsWith(Button.Bounds) Then
                collision = True
                Buttony = Button.Location.Y - PictureBox1.Height
                Exit For 'Exit when at least one collision found 
            Else : collision = False
            End If
        Next
        Dim newx As Integer
        Dim newy As Integer
        newx = PictureBox1.Location.X
        newy = PictureBox1.Location.Y
        If collision = True And jump = False Then
            velocity = 4
            newx = PictureBox1.Location.X + velocity * xdir
            newx = Math.Min(Math.Max(0, newx), Me.ClientSize.Width - PictureBox1.Width)
            newy = Buttony
            'newy = PictureBox1.Location.Y + velocity * ydir
            'newy = Math.Min(Math.Max(0, newy), Me.ClientSize.Height - PictureBox1.Height)
        ElseIf jump = True Then
            jumpVelocity -= 1
            If jumpVelocity = 0 Then
                jump = False
                'velocity = 4
            Else
                newy -= jumpVelocity
                newx = PictureBox1.Location.X + velocity * xdir
            End If
        Else
            newy += velocity
            'newx = PictureBox1.Location.X + velocity * xdir
            velocity += 1
        End If
        If newy > Me.Size.Height Then
            newx = orignx
            newy = origny
            jump = False
            velocity = 4
            jumpVelocity = 17
        End If
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
                jump = True
                jumpVelocity = 17
            Case Keys.A : xdir = -1
            Case Keys.S : ydir = 1
            Case Keys.D : xdir = 1
        End Select
    End Sub
End Class
