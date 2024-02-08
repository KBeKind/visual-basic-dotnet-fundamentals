Option Strict On
Imports System.Reflection

Module MainModule


    Dim ProductID As Integer = 1

    Dim SellStartDate As DateTime = #1/1/2019#


    Function LoadProducts() As List(Of Product)
        Dim products As New List(Of Product) From {
  New Product() With {.ProductID = 680, .Name = "HL Road Frame - Black, 58", .ProductNumber = "FR-R92B-58", .Color = "Black", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D, .ListPrice = 1431.5D, .SellStartDate = #6/1/1998 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 706, .Name = "HL Road Frame - Red, 58", .ProductNumber = "FR-R92R-58", .Color = "Red", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D, .ListPrice = 1431.5D, .SellStartDate = #6/1/1998 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 707, .Name = "Sport-100 Helmet, Red", .ProductNumber = "HL-U509-R", .Color = "Red", .Size = "L", .Weight = 15.1D, .StandardCost = 13.0863D, .ListPrice = 34.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 708, .Name = "Sport-100 Helmet, Black", .ProductNumber = "HL-U509", .Color = "Black", .Size = "L", .Weight = 15.1D, .StandardCost = 13.0863D, .ListPrice = 34.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 709, .Name = "Mountain Bike Socks, M", .ProductNumber = "SO-B909-M", .Color = "White", .Size = "M", .Weight = 10, .StandardCost = 3.3963D, .ListPrice = 9.5D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #6/30/2002 12:00:00 AM#},
  New Product() With {.ProductID = 710, .Name = "Mountain Bike Socks, L", .ProductNumber = "SO-B909-L", .Color = "White", .Size = "L", .Weight = 10, .StandardCost = 3.3963D, .ListPrice = 9.5D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #6/30/2002 12:00:00 AM#},
  New Product() With {.ProductID = 711, .Name = "Sport-100 Helmet, Blue", .ProductNumber = "HL-U509-B", .Color = "Blue", .Size = "M", .Weight = 10, .StandardCost = 13.0863D, .ListPrice = 34.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 712, .Name = "AWC Logo Cap", .ProductNumber = "CA-1098", .Color = "Multi", .Size = "L", .Weight = 5.5D, .StandardCost = 6.9223D, .ListPrice = 8.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 713, .Name = "Long-Sleeve Logo Jersey, S", .ProductNumber = "LJ-0192-S", .Color = "Multi", .Size = "S", .Weight = 3.5D, .StandardCost = 38.4923D, .ListPrice = 49.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#},
  New Product() With {.ProductID = 714, .Name = "Long-Sleeve Logo Jersey, M", .ProductNumber = "LJ-0192-M", .Color = "Multi", .Size = "M", .Weight = 3.5D, .StandardCost = 38.4923D, .ListPrice = 49.99D, .SellStartDate = #7/1/2001 12:00:00 AM#, .SellEndDate = #12/31/2021 12:00:00 AM#}
}

        Return products
    End Function




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

        'Dim prod As New Product


        'Console.WriteLine(prod.CalculateProfit())

        'Console.WriteLine(Product.CalculateTheProfit(900, 1400))

        'Console.WriteLine(prod.CreatedBy)

        'Console.WriteLine()

        'Dim cust As New Customer With {
        '.CustomerID = 1,
        '.CompanyName = "Beach computers",
        '.FirstName = "Dee",
        '.LastName = "Turman"
        '}

        'Console.WriteLine(cust.ToString())

        'ARRAY
        'Dim products As String() = {"Bike1", "Bike2", "Bike3"}

        'Dim products(3) As String
        'products(0) = "Bike1"
        'products(1) = "Bike2"
        'products(2) = "Bike3"

        'Console.WriteLine(products.Length)

        'ARRAYLIST
        'Dim products As New ArrayList From {
        '    "Bike1", "Bike2", "Bike3", 1, 3.35D, New Product With {.ProductNumber = "23"}
        '}
        'Console.WriteLine(products.Count)
        'Console.WriteLine(DirectCast(products(0), Product).Name)


        Dim products = LoadProducts()
        Dim index As Integer
        Dim sum As Decimal = 0

        'Do While index < (products.Count - 1)
        '    Console.WriteLine(products(index).ToString())
        '    sum += products(index).ListPrice
        '    index += 1
        'Loop

        'Do
        '    Console.WriteLine(products(index).ToString())
        '    sum += products(index).ListPrice
        '    index += 1
        'Loop While index < (products.Count)


        'Do Until index > (products.Count - 1)
        '    Console.WriteLine("Loop stuff")
        '    index += 1
        'Loop

        'Do
        '    Console.WriteLine(products(index).ToString())
        '    sum += products(index).ListPrice
        '    index += 1
        'Loop Until index > (products.Count - 1)

        'For anIndex As Integer = 0 To (products.Count - 1)
        '    Console.WriteLine(products(anIndex).ToString())
        'Next

        For Each aProd As Product In products

            If (aProd.Color = "Red") Then
                Console.WriteLine("Red Color Product: " & aProd.ToString())

            ElseIf (aProd.Color = "Black") Then
                Console.WriteLine("Black Color Product: " & aProd.ToString())

            Else
                Console.WriteLine("Other Color Product: " & aProd.ToString())

            End If

        Next


        'Console.WriteLine("Sum: " & sum.ToString("c"))




        Console.ReadKey()

    End Sub





    Sub IncrementListPrice()
        'Static ListPrice As Decimal = 0

        'ListPrice = ListPrice + 1

        'Console.WriteLine(ListPrice)
    End Sub




End Module
