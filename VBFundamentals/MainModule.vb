Option Strict On


Module MainModule


    Dim ProductID As Integer = 1

    Dim SellStartDate As DateTime = #1/1/2019#


    Sub Main()

        Dim isActive As Boolean = ClassConstants.DEFAULT_ACTIVE

        'Dim theData As Object

        'theData = "Bike"
        'Console.WriteLine(theData)

        'theData = 999.99
        'Console.WriteLine(theData)

        'theData = DateTime.Now
        'Console.WriteLine(theData)

        'theData = vbEmpty
        'Console.WriteLine(theData)

        'theData = DBNull.Value
        'Console.WriteLine(theData)



        'If True Then
        '    Dim Name As String = "Tricycle"
        '    Dim ListPrice As Decimal = 999.99D
        'End If

        'IncrementListPrice()
        'IncrementListPrice()
        'IncrementListPrice()

        'Dim Name As String = "10 Speed Bike"


        'Console.WriteLine("built-in String methods")
        'Console.WriteLine(Name.Length)
        'Console.WriteLine(Name.IndexOf(" "))
        'Console.WriteLine(Name.LastIndexOf(" "))
        'Console.WriteLine(Name.EndsWith("e"))
        'Console.WriteLine(Name.Insert(9, "Mountain "))
        'Console.WriteLine(Name.Remove(0, 9))
        'Console.WriteLine(Name.Replace("10", "12"))
        'Console.WriteLine(Name.ToUpper())
        'Console.WriteLine(Name.ToLower())
        'Console.WriteLine()

        'Dim ListPrice As Decimal = ClassConstants.DEFAULT_LIST_PRICE
        'Console.WriteLine("built-in Numeric methods")
        'Console.WriteLine(ListPrice.Equals(999.99D))
        'Console.WriteLine(Decimal.MinValue)
        'Console.WriteLine(Decimal.MaxValue)
        'Console.WriteLine(Decimal.Ceiling(ListPrice))
        'Console.WriteLine(Decimal.Floor(ListPrice))
        'Decimal.TryParse("55.01", ListPrice)
        'Console.WriteLine(ListPrice)
        'Decimal.TryParse("Fifty-Five", ListPrice)
        'Console.WriteLine(ListPrice)
        'Console.WriteLine()

        'Dim SellDate As DateTime = #1/1/2024 12:05:01 PM#
        'Console.WriteLine("built-in DateTime Methods")
        'Console.WriteLine(SellDate.AddDays(10))
        'Console.WriteLine(SellDate.AddDays(-10))
        'Console.WriteLine(SellDate.AddYears(1))
        'Console.WriteLine(SellDate.Date)
        'Console.WriteLine(SellDate.Day)
        'Console.WriteLine(SellDate.DayOfWeek)
        'Console.WriteLine(SellDate.Year)
        'Console.WriteLine(SellDate.DayOfYear)
        'Console.WriteLine(SellDate.Hour)
        'Console.WriteLine(SellDate.Minute)
        'Console.WriteLine(SellDate.Second)
        'Console.WriteLine()




        'prod.SellStartDate = #1/1/2024#
        'Dim sellDate As DateTime

        'prod.CalculateSellEndDate(20, sellDate)

        'sellDate = prod.CalculateSellEndDate(20)

        'Console.WriteLine(sellDate)

        'prod.StandardCost = 250
        'prod.ListPrice = 500

        Dim prod As New Product


        Console.WriteLine(prod.CalculateProfit())

        Console.WriteLine(Product.CalculateTheProfit(900, 1400))

        Console.WriteLine(prod.CreatedBy)

        Console.WriteLine()

        Dim cust As New Customer With {
        .CustomerID = 1,
        .CompanyName = "Beach computers",
        .FirstName = "Dee",
        .LastName = "Turman"
        }

        Console.WriteLine(cust.ToString())


        Console.ReadKey()
    End Sub


    Sub IncrementListPrice()
        'Static ListPrice As Decimal = 0

        'ListPrice = ListPrice + 1

        'Console.WriteLine(ListPrice)
    End Sub




End Module
