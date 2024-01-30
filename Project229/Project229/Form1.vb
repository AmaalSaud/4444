Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Activation
Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Dim cnn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amaal\Desktop\Visual Programming_29\finle project\Project229\Project229\Database1.mdf;Integrated Security=True "
    Dim conn As SqlConnection = New SqlConnection(cnn)
    Public level As Integer
    Public userEmail As String
    Public userPass As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        userEmail = txtLogEmail.Text
        userPass = txtLogPassword.Text
        conn.Open()
        Dim myAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Information where Email='" + txtLogEmail.Text + "'and Password = '" + txtLogPassword.Text + "'", conn)
        Dim searchData As DataTable = New DataTable()
        myAdapter.Fill(searchData)
        If searchData.Rows.Count = 1 Then
            MessageBox.Show("Correct Login")
            level = searchData.Rows(0).ItemArray(5)
            If level <= 6 Then
                Form3.Show()
                Me.Hide()
                Form2.Hide()
            ElseIf level > 6 Then
                Form4.Show()
                Form3.Hide()
            ElseIf level > 11 Then
                Form5.Show()
                Form4.Hide()
            End If
        Else
            MessageBox.Show("Check yor Number or Password")
        End If
        conn.Close()


    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
