'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Customer
    Public Property CustomerID As Integer
    Public Property CustomerName As String
    Public Property BillToCustomerID As Integer
    Public Property CustomerCategoryID As Integer
    Public Property BuyingGroupID As Nullable(Of Integer)
    Public Property PrimaryContactPersonID As Integer
    Public Property AlternateContactPersonID As Nullable(Of Integer)
    Public Property DeliveryMethodID As Integer
    Public Property DeliveryCityID As Integer
    Public Property PostalCityID As Integer
    Public Property CreditLimit As Nullable(Of Decimal)
    Public Property AccountOpenedDate As Date
    Public Property StandardDiscountPercentage As Decimal
    Public Property IsStatementSent As Boolean
    Public Property IsOnCreditHold As Boolean
    Public Property PaymentDays As Integer
    Public Property PhoneNumber As String
    Public Property FaxNumber As String
    Public Property DeliveryRun As String
    Public Property RunPosition As String
    Public Property WebsiteURL As String
    Public Property DeliveryAddressLine1 As String
    Public Property DeliveryAddressLine2 As String
    Public Property DeliveryPostalCode As String
    Public Property DeliveryLocation As System.Data.Entity.Spatial.DbGeography
    Public Property PostalAddressLine1 As String
    Public Property PostalAddressLine2 As String
    Public Property PostalPostalCode As String
    Public Property LastEditedBy As Integer
    Public Property ValidFrom As Date
    Public Property ValidTo As Date

    Public Overridable Property Customers1 As ICollection(Of Customer) = New HashSet(Of Customer)
    Public Overridable Property Customer1 As Customer

End Class