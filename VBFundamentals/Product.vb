Public Class Product

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


    Public Property IsActive As Boolean
    Public Property Name As String
    Public Property ProductNumber As String

    Public ReadOnly Property NameAndNumber() As String
        Get
            Return Name + "-" + ProductNumber
        End Get
    End Property

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

End Class
