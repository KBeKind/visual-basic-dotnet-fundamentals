Option Strict On

Module MainModule


    Dim ProductID As Integer = 1
    Dim isActive As Boolean = True
    Dim Name As String = "10 Speed Bike"
    Dim SellStartDate As DateTime = #1/1/2019#


    Private Const DEFAULT_ACTIVE As Boolean = True
    Private Const DEFAULT_LIST_PRICE As Decimal = 999.99D

    Sub Main()

        Dim theData As Object

        theData = "Bike"
        Console.WriteLine(theData)

        theData = 999.99
        Console.WriteLine(theData)

        theData = DateTime.Now
        Console.WriteLine(theData)

        theData = vbEmpty
        Console.WriteLine(theData)

        theData = DBNull.Value
        Console.WriteLine(theData)



        If True Then
            Dim Name As String = "Tricycle"
            Dim ListPrice As Decimal = 999.99D
        End If


        IncrementListPrice()
        IncrementListPrice()
        IncrementListPrice()

        Console.ReadKey()
    End Sub


    Sub IncrementListPrice()
        Static ListPrice As Decimal = 0

        ListPrice = ListPrice + 1

        Console.WriteLine(ListPrice)
    End Sub


End Module
