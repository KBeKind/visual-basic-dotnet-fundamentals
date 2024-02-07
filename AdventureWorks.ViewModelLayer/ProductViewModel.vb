Imports Common.Library
Imports AdventureWorks.EntityLayer

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProduct(680)
    End Sub

    Public Property Entity As Product

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        'HARD CODED FOR PRACTICE
        Entity = New Product() With {.ProductID = 680, .Name = "HL Road Frame", .ProductNumber = "FR-R9", .Color = "Black", .Size = "58", .Weight = 10, .StandardCost = 1059.99D, .ListPrice = 1399.99D}
        Return Entity
    End Function

End Class

