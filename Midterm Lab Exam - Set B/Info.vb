Public Class Info
    'Property to store the username, password, and balance
    Public Property Username As String
    Public Property Password As String
    Public Property Balance As Decimal

    Public Sub New(username As String, password As String, balance As Decimal)
        'Setting the Username, Password, and Balance properties to the values of the parameters
        Me.Username = username
        Me.Password = password
        Me.Balance = balance
    End Sub
End Class
