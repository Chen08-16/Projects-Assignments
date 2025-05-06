Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class frmTotalSales
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub


    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If cobYear.SelectedIndex = 0 Then
            Mycn.Open()

            Dim strSql As String
            Dim strSql2 As String

            strSql = "select sum(SalesTable.SoldQuantity) as totalquantity, sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) as totalgross from SalesTable where SalesYear = '2022'"
            strSql2 = "select sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) - sum(OrderTable.OrderQuantity * OrderTable.OrderPrice) as totalnet from SalesTable inner join OrderTable on SalesTable.SalesID = OrderTable.OrderID where SalesYear = '2022'"


            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtTotal.Text = myreader("totalquantity")
            txtGross.Text = myreader("totalgross")
            Mycn.Close()

            Mycn.Open()
            Dim myreader1 As SqlDataReader
            Dim cmd2 As New SqlCommand(strSql2, Mycn)

            myreader1 = cmd2.ExecuteReader
            myreader1.Read()
            txtNet.Text = myreader1("totalnet")
            Mycn.Close()
        ElseIf cobYear.SelectedIndex = 1 Then
            Mycn.Open()

            Dim strSql As String
            Dim strSql2 As String

            strSql = "select sum(SalesTable.SoldQuantity) as totalquantity, sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) as totalgross from SalesTable where SalesYear = '2021'"
            strSql2 = "select sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) - sum(OrderTable.OrderQuantity * OrderTable.OrderPrice) as totalnet from SalesTable inner join OrderTable on SalesTable.SalesID = OrderTable.OrderID where SalesYear = '2021'"


            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtTotal.Text = myreader("totalquantity")
            txtGross.Text = myreader("totalgross")
            Mycn.Close()

            Mycn.Open()
            Dim myreader1 As SqlDataReader
            Dim cmd2 As New SqlCommand(strSql2, Mycn)

            myreader1 = cmd2.ExecuteReader
            myreader1.Read()
            txtNet.Text = myreader1("totalnet")
            Mycn.Close()
        ElseIf cobYear.SelectedIndex = 2 Then
            Mycn.Open()

            Dim strSql As String
            Dim strSql2 As String

            strSql = "select sum(SalesTable.SoldQuantity) as totalquantity, sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) as totalgross from SalesTable where SalesYear = '2020'"
            strSql2 = "select sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) - sum(OrderTable.OrderQuantity * OrderTable.OrderPrice) as totalnet from SalesTable inner join OrderTable on SalesTable.SalesID = OrderTable.OrderID where SalesYear = '2020'"


            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtTotal.Text = myreader("totalquantity")
            txtGross.Text = myreader("totalgross")
            Mycn.Close()

            Mycn.Open()
            Dim myreader1 As SqlDataReader
            Dim cmd2 As New SqlCommand(strSql2, Mycn)

            myreader1 = cmd2.ExecuteReader
            myreader1.Read()
            txtNet.Text = myreader1("totalnet")
            Mycn.Close()
        ElseIf cobYear.SelectedIndex = 3 Then
            Mycn.Open()

            Dim strSql As String
            Dim strSql2 As String

            strSql = "select sum(SalesTable.SoldQuantity) as totalquantity, sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) as totalgross from SalesTable where SalesYear = '2019'"
            strSql2 = "select sum(SalesTable.SoldQuantity * SalesTable.SellingPrice) - sum(OrderTable.OrderQuantity * OrderTable.OrderPrice) as totalnet from SalesTable inner join OrderTable on SalesTable.SalesID = OrderTable.OrderID where SalesYear = '2019'"


            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtTotal.Text = myreader("totalquantity")
            txtGross.Text = myreader("totalgross")
            Mycn.Close()

            Mycn.Open()
            Dim myreader1 As SqlDataReader
            Dim cmd2 As New SqlCommand(strSql2, Mycn)

            myreader1 = cmd2.ExecuteReader
            myreader1.Read()
            txtNet.Text = myreader1("totalnet")
            Mycn.Close()
        End If
    End Sub

    Private Sub frmTotalSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class