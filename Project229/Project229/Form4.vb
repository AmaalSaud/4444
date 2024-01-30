Imports System.Data.SqlClient

Public Class Form4
    Dim SAPI
    Dim level3 As Integer = Form1.level
    Dim cnn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amaal\Desktop\Visual Programming_29\finle project\Project229\Project229\Database1.mdf;Integrated Security=True "
    Dim conn As SqlConnection = New SqlConnection(cnn)
    Private Sub radA_CheckedChanged_1(sender As Object, e As EventArgs) Handles radA.CheckedChanged
        If radA.Checked Then
            picT1.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Excellent")
            picF1.Hide()
            GroupBox2.Show()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If
    End Sub

    Private Sub radK_CheckedChanged_1(sender As Object, e As EventArgs) Handles radK.CheckedChanged
        If radK.Checked Then
            picT1.Hide()
            picF1.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Wrong Answer")
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If
    End Sub

    Private Sub radM_CheckedChanged(sender As Object, e As EventArgs) Handles radM.CheckedChanged

        If radM.Checked Then
            picT1.Hide()
            picF1.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Try Again")
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If
    End Sub

    Private Sub radB_CheckedChanged(sender As Object, e As EventArgs) Handles radB.CheckedChanged
        If radB.Checked Then
            picT2.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Perfect")
            picF2.Hide()
            GroupBox3.Show()
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If

    End Sub

    Private Sub radX_CheckedChanged(sender As Object, e As EventArgs) Handles radX.CheckedChanged

        If radX.Checked Then
            picT2.Hide()
            picF2.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Wrong")
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If

    End Sub

    Private Sub radZ_CheckedChanged(sender As Object, e As EventArgs) Handles radZ.CheckedChanged

        If radZ.Checked Then
            picT2.Hide()
            picF2.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Try Again")
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If
    End Sub

    Private Sub radT_CheckedChanged(sender As Object, e As EventArgs) Handles radT.CheckedChanged
        If radT.Checked Then
            picT3.Hide()
            picF3.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Try Again")
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If

    End Sub

    Private Sub radC_CheckedChanged(sender As Object, e As EventArgs) Handles radC.CheckedChanged

        If radC.Checked Then
            picT3.Show()
            picF3.Hide()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Good job")
            GroupBox4.Show()
            GroupBox5.Hide()
        End If

    End Sub

    Private Sub radW_CheckedChanged(sender As Object, e As EventArgs) Handles radW.CheckedChanged
        If radW.Checked Then
            picT3.Hide()
            picF3.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("False")
            GroupBox4.Hide()
            GroupBox5.Hide()
        End If
    End Sub
    Private Sub radG_CheckedChanged(sender As Object, e As EventArgs) Handles radG.CheckedChanged
        If radG.Checked Then
            picT4.Hide()
            picF4.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Try Again")
            GroupBox5.Hide()
        End If
    End Sub

    Private Sub radD_CheckedChanged(sender As Object, e As EventArgs) Handles radD.CheckedChanged
        If radD.Checked Then
            picT4.Hide()
            picF4.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Wrong Answer")
            GroupBox5.Hide()
        End If
    End Sub

    Private Sub radI_CheckedChanged(sender As Object, e As EventArgs) Handles radI.CheckedChanged
        If radI.Checked Then
            picT4.Show()
            picF4.Hide()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Perfect")
            GroupBox5.Show()
        End If
    End Sub

    Private Sub radU_CheckedChanged(sender As Object, e As EventArgs) Handles radU.CheckedChanged
        If radU.Checked Then
            picT5.Show()
            picF5.Hide()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Super")
        End If
    End Sub

    Private Sub radO_CheckedChanged(sender As Object, e As EventArgs) Handles radO.CheckedChanged
        If radO.Checked Then
            picT5.Hide()
            picF5.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Try Again")
        End If
    End Sub

    Private Sub radS_CheckedChanged(sender As Object, e As EventArgs) Handles radS.CheckedChanged
        If radS.Checked Then
            picT5.Hide()
            picF5.Show()
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Wrong")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        Me.Close()
        conn.Open()
        Dim cmd As SqlCommand = New SqlCommand("update Information set level='" + level3.ToString + "' where Email='" + Form1.userEmail + "'and Password = '" + Form1.userPass + "'", conn)
        Dim searchData As DataTable = New DataTable()
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub
    ' method for open levels
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If level3 = 7 Then
            GroupBox1.Visible = True
        End If
        If level3 = 8 Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
        End If
        If level3 = 9 Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
        End If
        If level3 = 10 Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
            GroupBox4.Visible = True
        End If
        If level3 = 11 Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
            GroupBox4.Visible = True
            GroupBox5.Visible = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class