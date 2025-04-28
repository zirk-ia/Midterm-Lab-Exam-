Public Class Form2
    'Property to store the username and balance
    Public Property Username As String
    Public Property Balance As Decimal

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auto display the username and balance
        lblActiveUserDisplay.Text = Username
        lblBalanceDisplay.Text = Balance.ToString("F2") ' Format the balance to display with 2 decimal places

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        'Variable to store the amount to withdraw
        Dim amount As Decimal

        'Check if the input is a valid decimal
        If Decimal.TryParse(txtAmount.Text, amount) Then
            If amount > 0 Then 'Check if the amount is positive number
                If Balance >= amount Then 'Check if there are sufficient funds
                    Balance -= amount 'Subtract the amount from the balance
                    lblBalanceDisplay.Text = Balance.ToString("F2") 'Update the text of lblBalance with formatted balance
                    MessageBox.Show("Withdrawal successful." & vbCrLf & "Your Balance is: " & lblBalanceDisplay.Text,
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Show a success message
                Else
                    MessageBox.Show("Insufficient balance.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Show an error message if the balance is insufficient
                End If
            Else
                MessageBox.Show("Please enter a positive amount to withdraw.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Show an error message if the amount is not positive
            End If
        Else
            MessageBox.Show("Please enter a valid amount to withdraw.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Show an error message if the input is not a valid decimal
        End If


    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        'Variable to store the amount to deposit
        Dim amount As Decimal

        'Check if the input is a valid decimal
        If Decimal.TryParse(txtAmount.Text, amount) Then
            If amount > 0 Then 'Check if the amount is positive num
                Balance += amount 'Add the amount to the balance
                lblBalanceDisplay.Text = Balance.ToString("F2") 'Update the text of lblBalance with formatted balance
                MessageBox.Show("Deposit successful." & vbCrLf & "Your Balance is: " & lblBalanceDisplay.Text,
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Show a success message
            Else
                MessageBox.Show("Please enter a positive amount to deposit.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Show an error message if the amount is not positive
            End If
        Else
            MessageBox.Show("Please enter a valid amount to deposit.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Show an error message if the input is not a valid decimal
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Clearing inputted data and displayed data
        lblActiveUser.Text = String.Empty
        lblBalance.Text = String.Empty
        txtAmount.Clear()

        Dim f1 As New Form1 ' Create a new instance of Form1
        f1.Show() ' Show Form1
        Me.Close() ' Close Form2
    End Sub


End Class