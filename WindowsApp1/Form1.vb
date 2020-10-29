Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("I am how much energy you have so don't let it go to waste")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'MsgBox("I'm an X and X means you want to exit out so if you really want that then you can have it")
        Dim result = MsgBox("I'm an X and X means you want to exit out so if you really want that then you can have it", vbOKCancel)
        If result = vbOK Then
            Application.Exit()
        ElseIf vbCancel = result Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Use wasd to move me around")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(" i'm de ground")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim result = MsgBox("Game is not responding, please restart", vbOKCancel)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Application.Exit()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim result = MsgBox("Do you want to actually want to start the REAL game?", vbOKCancel)
        If result = vbOK Then
            Dim form2 = New Form2()
            form2.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
