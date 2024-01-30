Imports System.Data.SqlClient

Public Class Form2
    Dim cnn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amaal\Desktop\Visual Programming_29\finle project\Project229\Project229\Database1.mdf;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(cnn)
    Private Sub txtSignEmail_TextChanged(sender As Object, e As EventArgs) Handles txtSignEmail.TextChanged
        Dim email As String = txtSignEmail.Text
        If email.Contains("@") And email.Contains(".com") Then
            txtSignEmail.ForeColor = Color.Green
        Else
            txtSignEmail.ForeColor = Color.Red

        End If
    End Sub

    Private Sub txtSignPassword_TextChanged(sender As Object, e As EventArgs) Handles txtSignPassword.TextChanged
        Dim password As String
        password = txtSignPassword.Text

        If password.Length >= 8 And (password.Contains("@") Or password.Contains("#") Or password.Contains("&")) Then
            txtSignPassword.ForeColor = Color.Green
        Else
            txtSignPassword.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim Name As String = txtName.Text
        If Name = Name.ToLower Then
            txtName.ForeColor = Color.Green
        Else
            txtName.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.TextChanged
        Dim number As String
        number = txtMobileNumber.Text
        If number Like "05########" Then
            txtMobileNumber.ForeColor = Color.Green
        Else
            txtMobileNumber.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        Dim Age As Integer
        Integer.TryParse(txtAge.Text, Age)
        If Age >= 2 Then
            txtAge.ForeColor = Color.Green
        Else
            txtAge.ForeColor = Color.Red

        End If
    End Sub

    Private Sub btnCreat_Click(sender As Object, e As EventArgs) Handles btnCreat.Click
        Dim level As String = "0"
        If txtSignEmail.ForeColor = Color.Green Then
            If txtSignPassword.ForeColor = Color.Green Then
                If txtName.ForeColor = Color.Green Then
                    If txtMobileNumber.ForeColor = Color.Green Then
                        If txtAge.ForeColor = Color.Green Then
                            conn.Open()
                            Dim cmd As SqlCommand = New SqlCommand("insert into Information values ('" + txtSignEmail.Text + "','" + txtSignPassword.Text + "','" +
            txtName.Text + "','" + txtMobileNumber.Text + "','" + txtAge.Text + "','" + level + "')", conn)
                            cmd.ExecuteNonQuery()
                            conn.Close()
                            MessageBox.Show("Success creating acount")
                            lblNot.Text = " "
                        Else
                            lblNot.Text = "There is Something Wrong, Check Again Please "
                            lblNot.ForeColor = Color.Red
                        End If
                    Else
                        lblNot.Text = "There is Something Wrong, Check Again Please "
                        lblNot.ForeColor = Color.Red
                    End If
                Else
                    lblNot.Text = "There is Something Wrong, Check Again Please "
                    lblNot.ForeColor = Color.Red
                End If
            Else
                lblNot.Text = "There is Something Wrong, Check Again Please "
                lblNot.ForeColor = Color.Red
            End If
        Else
            lblNot.Text = "There is Something Wrong, Check Again Please "
            lblNot.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnBackRegister_Click(sender As Object, e As EventArgs) Handles btnBackRegister.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class