Imports System.Runtime.Remoting.Messaging
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        Entity = New Customer() With {.CustomerID = 1, .FirstName = "Dee", .LastName = "Turman", .CompanyName = "A Good Company"}
        Return Entity
    End Function



End Class
