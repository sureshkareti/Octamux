' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
'Copyright (C) Microsoft Corporation.  All rights reserved.

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports System.Linq
Imports System.Data.Linq.Mapping
Imports nwind
Imports System.Data.SqlClient

Namespace Samples

    Class Program

        Shared Sub Main()

            ' The following assumes that:
            ' 1. SQL Server 2005 Express is installed on your machine
            ' 2. You install the Data Sample directory that contains Northwind.
            ' Or, if you have installed Northwind, you will need to alter the connection string to
            ' Northwind db = new Northwind("Server=.\\SQLExpress;Database=Northwind;Trusted_Connection=True");
            ' You must edit the path to point to the mdf file on your machine
            ' Northwind db = new Northwind("c:\\northwind\\northwnd.mdf");

            Dim dbPath As String = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, "..\..\Data\NORTHWIND.MDF"))
            Dim sqlServerInstance As String = ".\SQLEXPRESS"
            Dim connString As String = "AttachDBFileName='" + dbPath + "';Server='" + sqlServerInstance + "';user instance=true;Integrated Security=SSPI;"

            Dim path As String = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, "..\..\Northwind.xml"))

            Dim mappingSource As XmlMappingSource = XmlMappingSource.FromXml(File.ReadAllText(path))
            Dim db As Northwind = New Northwind(connString, mappingSource)
            db.Log = Console.Out
            Samples.Sample1(db)
            Console.ReadLine()

        End Sub
    End Class

End Namespace