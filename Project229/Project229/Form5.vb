Imports System.Data.SqlClient

Public Class Form5
    Dim score As Integer = 0
    Dim level4 As Integer = Form1.level
    Dim cnn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amaal\Desktop\Visual Programming_29\finle project\Project229\Project229\Database1.mdf;Integrated Security=True "
    Dim conn As SqlConnection = New SqlConnection(cnn)
    ' Method for calculating score
    Private Function checkScore(ByVal input As String, ByVal key As String) As Integer
        If input = key Then
            score += 1
        Else
            score += 0
        End If
        Return score
    End Function
    ' Method for open picture depends on score
    Private Sub PictureVisible(ByVal finalScore As String)
        If finalScore = 6 Then
            picPerfecrt.Show()
            picGood.Hide()
            picTryAgain.Hide()

        ElseIf finalScore >= 3 Then
            picPerfecrt.Hide()
            picGood.Show()
            picTryAgain.Hide()
        Else
            picPerfecrt.Hide()
            picGood.Hide()
            picTryAgain.Show()
        End If
    End Sub
    ' calling methods
    Private Sub btnMyScore_Click(sender As Object, e As EventArgs) Handles btnMyScore.Click
        checkScore(txtFirst.Text.Trim, "c")
        checkScore(txtSecond.Text.Trim, "l")
        checkScore(txtThird.Text.Trim, "u")
        checkScore(txtForth.Text.Trim, "f")
        checkScore(txtFifth.Text.Trim, "p")
        checkScore(txtSixth.Text.Trim, "z")

        lblOut.Text = score
        PictureVisible(score)
    End Sub

    Private Sub btnBackLevel_Click(sender As Object, e As EventArgs) Handles btnBackLevel.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        conn.Open()
        Dim cmd As SqlCommand = New SqlCommand("update Information set level='" + level4.ToString + "' where Email='" + Form1.userEmail + "'and Password = '" + Form1.userPass + "'", conn)
        Dim searchData As DataTable = New DataTable()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        txtFirst.Text = " "
        txtSecond.Text = " "
        txtThird.Text = " "
        txtForth.Text = " "
        txtFifth.Text = " "
        txtSixth.Text = " "
        lblOut.Text = " "
        score = 0
        picGood.Hide()
        picPerfecrt.Hide()
        picTryAgain.Hide()
    End Sub
End Class