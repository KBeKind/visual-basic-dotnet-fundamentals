Option Strict On


Module MainModule


    Dim ProductID As Integer = 1
    Dim Name As String = "10 Speed Bike"
    Dim SellStartDate As DateTime = #1/1/2019#


    Sub Main()

        Dim isActive As Boolean = ClassConstants.DEFAULT_ACTIVE
        Dim ListPrice As Decimal = ClassConstants.DEFAULT_LIST_PRICE




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
