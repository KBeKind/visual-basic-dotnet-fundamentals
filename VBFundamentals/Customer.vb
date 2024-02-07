Imports System.Runtime.Remoting

Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New()
        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Function GetClassData() As String

        Dim sb As New Text.StringBuilder(1024)
        sb.AppendLine("***Customer Info***")
        sb.AppendLine("Customer Id: " + CustomerID.ToString())
        sb.AppendLine("Company Name: " + CompanyName)
        sb.AppendLine("First Name: " + FirstName)
        sb.AppendLine("LastName: " + LastName)
        sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString)
        sb.AppendLine("Created By: " + CreatedBy)

        Return sb.ToString()

    End Function


End Class
