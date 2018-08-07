' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
'Copyright (C) Microsoft Corporation.  All rights reserved.

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports nwind

Namespace Samples
    Public Class Samples

        Public Shared Sub Sample1(ByVal db As Northwind)
            ' Use Where() to find only elements that match
            Dim q As IEnumerable(Of Customer) = db.Customers.Where(Function(c) c.City = "London")
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample2(ByVal db As Northwind)
            ' Use First() in place of Where() to find the first or only one 
            Dim cust As Customer = db.Customers.First(Function(c) c.CustomerID = "ALFKI")
            ObjectDumper.Write(cust, 0)
        End Sub

        Public Shared Sub Sample3(ByVal db As Northwind)
            ' Use Select() to map/project results
            Dim q = db.Customers.Select(Function(c) c.ContactName)
            ObjectDumper.Write(q, 0)

        End Sub
        Public Shared Sub Sample4(ByVal db As Northwind)
            ' Use Anonymous Type constructors to retrieve only particular data
            Dim q = db.Customers.Select(Function(c) New With {c.ContactName, c.Phone})
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample5(ByVal db As Northwind)
            ' Combine Where() and Select() for common queries
            Dim q = db.Customers.Where(Function(c) c.City = "London").Select(Function(c) c.ContactName)
            ObjectDumper.Write(q, 0)

        End Sub
        Public Shared Sub Sample6(ByVal db As Northwind)
            ' Use SelectMany() to flatten collections
            Dim q As IEnumerable(Of Order) = db.Customers.SelectMany(Function(c) c.Orders)
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample7(ByVal db As Northwind)
            ' Use query expressions to simplify common select/where patterns
            Dim q = From c In db.Customers _
                    From o In c.Orders _
                    Where c.City = "London" _
                    Select New With {c.ContactName, o.OrderDate}
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample8(ByVal db As Northwind)
            ' Use orderby to order results
            Dim q = From c In db.Customers Order By c.City, c.ContactName Select c
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample9(ByVal db As Northwind)
            ' Use group x by y to produce a series of group partitions
            Dim q = From p In db.Products Group p By p.CategoryID Into Group Select New With {.CategoryID = Group, Group}
            ObjectDumper.Write(q, 1)
        End Sub

        Public Shared Sub Sample10(ByVal db As Northwind)
            ' Use group-by and aggregates like Min()/Max() to compute values over group partitions
            Dim q = From p In db.Products _
                    Group p By p.CategoryID Into Group _
                    Select New With { _
                        .Category = CategoryID, _
                        .MinPrice = Group.Min(Function(p) p.UnitPrice), _
                        .MaxPrice = Group.Max(Function(p) p.UnitPrice) _
                        }
            ObjectDumper.Write(q, 1)
        End Sub

        Public Shared Sub Sample11(ByVal db As Northwind)
            ' Use Any() to determine if a collection has at least one element, or at least one element matches a condition
            Dim q = From c In db.Customers _
                    Where c.Orders.Any() _
                    Select c
            ObjectDumper.Write(q, 0)

        End Sub
        Public Shared Sub Sample12(ByVal db As Northwind)
            ' Use All() to determine if all elements of a collection match a condition (or that the collection is empty!)
            Dim q = From c In db.Customers _
                    Where c.Orders.All(Function(o) o.ShipCity = c.City) _
                    Select c
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample13(ByVal db As Northwind)
            ' Use Take(n) to limit the sequence to only the first n elements
            Dim q = db.Customers.OrderBy(Function(c) c.ContactName).Take(5)
            ObjectDumper.Write(q, 0)
        End Sub

        Public Shared Sub Sample14(ByVal db As Northwind)
            ' Use SubmitChanges() to submit all changes back to the database
            Dim cust = db.Customers.First(Function(c) c.CustomerID = "ALFKI")
            cust.ContactTitle = "Sith Lord"
            ' other changes ...
            db.SubmitChanges()
        End Sub

        Public Shared Sub Sample15(ByVal db As Northwind)

            Using ts As System.Transactions.TransactionScope = New System.Transactions.TransactionScope()
                ' Use SubmitChanges() to submit all changes back to the database
                Dim cust = db.Customers.First(Function(c) c.CustomerID = "ALFKI")
                cust.ContactTitle = "Sith Lord"
                ' other changes ...
                db.SubmitChanges()
                ts.Complete()
            End Using
        End Sub
    End Class
End Namespace
