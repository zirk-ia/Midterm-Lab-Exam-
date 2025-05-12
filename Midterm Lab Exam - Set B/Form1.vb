Public Class Form1
    'Using dictionary to store the account information
    Dim acc As New Dictionary(Of String, Info) From {
        {"Jose", New Info("Jose", "1234", 5000)},
        {"Carding", New Info("Carding", "Juana", 0)},
        {"Juana", New Info("Juana", "secret", 6000)}
    }

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim f2 As New Form2

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill up all fields.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf acc.ContainsKey(txtUsername.Text) AndAlso acc(txtUsername.Text).Password = txtPassword.Text Then
            f2.Username = txtUsername.Text  ' Set the Username property of Form2 to the value of txtUsername
            f2.Balance = acc(txtUsername.Text).Balance ' Set the Balance property of Form2 to the balance of the user
            f2.Show() ' Show Form2
            Me.Hide() ' Hide Form1
        Else
            'error message if the username or password is incorrect
            MessageBox.Show("User Not Found or Incorrect Password",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing the text of the textboxes
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub


End Class
