Public Class Product
    Inherits CommonBase

    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub


    'Private _IsActive As Boolean
    'Public Property IsActive() As Boolean
    '    Get
    '        Return _IsActive
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _IsActive = value
    '    End Set
    'End Property

    'Private _Name As String
    'Public Property Name() As String
    '    Get
    '        Return _Name
    '    End Get
    '    Set(ByVal value As String)
    '        _Name = value
    '    End Set
    'End Property

    'Private _ProductNumber As String
    'Public Property ProductNumber() As String
    '    Get
    '        Return _ProductNumber
    '    End Get
    '    Set(ByVal value As String)
    '        _ProductNumber = value
    '    End Set
    'End Property


    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime


    'Sub CalculateSellEndDate(ByVal days As Integer)
    '    SellEndDate = SellStartDate.AddDays(days)
    'End Sub

    'Sub CalculateSellEndDate(ByVal days As Integer, ByRef sellDate As DateTime)
    '    SellEndDate = SellStartDate.AddDays(days)
    '    sellDate = SellEndDate
    'End Sub

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellStartDate.AddDays(days)
        Return SellEndDate
    End Function

    'Function CalculateProfit(Optional ByVal newCost As Decimal = 0) As Decimal
    '    If newCost <> 0 Then
    '        StandardCost = newCost
    '    End If
    '    Return ListPrice - StandardCost
    'End Function

    Overloads Function CalculateProfit() As Decimal
        Return CalculateProfit(StandardCost)
    End Function

    Overloads Function CalculateProfit(ByVal newCost As Decimal) As Decimal
        If newCost <> 0 Then
            StandardCost = newCost
        End If
        Return ListPrice - StandardCost
    End Function


    Shared Function CalculateTheProfit(ByVal cost As Decimal, ByVal price As Decimal) As Decimal
        Return price - cost
    End Function


    Public Overrides Function ToString() As String
        Return Name + " (" + ProductNumber + ")"
    End Function


End Class
