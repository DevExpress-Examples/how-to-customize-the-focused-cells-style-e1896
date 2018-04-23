﻿Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Controls

Namespace CellStyleSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = ProductList.GetData()
		End Sub
	End Class
	Public Class Product
		Private privateCompanyName As String
		Public Property CompanyName() As String
			Get
				Return privateCompanyName
			End Get
			Set(ByVal value As String)
				privateCompanyName = value
			End Set
		End Property
		Private privateCountry As String
		Public Property Country() As String
			Get
				Return privateCountry
			End Get
			Set(ByVal value As String)
				privateCountry = value
			End Set
		End Property
		Private privateCity As String
		Public Property City() As String
			Get
				Return privateCity
			End Get
			Set(ByVal value As String)
				privateCity = value
			End Set
		End Property
		Private privateUnitPrice As Double
		Public Property UnitPrice() As Double
			Get
				Return privateUnitPrice
			End Get
			Set(ByVal value As Double)
				privateUnitPrice = value
			End Set
		End Property
		Private privateQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return privateQuantity
			End Get
			Set(ByVal value As Integer)
				privateQuantity = value
			End Set
		End Property
	End Class

	Public Class ProductList
		Public Shared Function GetData() As List(Of Product)
			Dim list As New List(Of Product)()
			list.Add(New Product() With {.CompanyName = "Island Trading", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10})
			list.Add(New Product() With {.CompanyName = "Reggiani Caseifici", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16})
			list.Add(New Product() With {.CompanyName = "Ricardo Adocicados", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12})
			list.Add(New Product() With {.CompanyName = "QUICK-Stop", .Country = "Germany", .City = "QUICK-Stop", .UnitPrice = 22, .Quantity = 50})
			list.Add(New Product() With {.CompanyName = "Split Rail Beer & Ale", .Country = "USA", .City = "Reggio Emilia", .UnitPrice = 18, .Quantity = 20})
			list.Add(New Product() With {.CompanyName = "Ernst Handel", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52})
			list.Add(New Product() With {.CompanyName = "Save-a-lot Markets", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120})
			list.Add(New Product() With {.CompanyName = "Tortuga Restaurante", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15})
			list.Add(New Product() With {.CompanyName = "Bottom-Dollar Markets", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16})
			Return list
		End Function
	End Class
End Namespace
