Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class frmTotalOrder
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If cobYear.SelectedIndex = 0 Then
            Mycn.Open()

            Dim strSql As String

            strSql = "select sum(OrderQuantity) as totalquantity, sum(OrderQuantity * OrderPrice) as totalprice from OrderTable where OrderYear = '2022'"

            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtQuantity.Text = myreader("totalquantity")
            txtPrice.Text = myreader("totalprice")
            Mycn.Close()
        ElseIf cobYear.SelectedIndex = 1 Then
            Mycn.Open()

            Dim strSql As String

            strSql = "select sum(OrderQuantity) as totalquantity, sum(OrderQuantity * OrderPrice) as totalprice from OrderTable where OrderYear = '2021'"

            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtQuantity.Text = myreader("totalquantity")
            txtPrice.Text = myreader("totalprice")
            Mycn.Close()
        ElseIf cobYear.SelectedIndex = 2 Then
            Mycn.Open()

            Dim strSql As String

            strSql = "select sum(OrderQuantity) as totalquantity, sum(OrderQuantity * OrderPrice) as totalprice from OrderTable where OrderYear = '2020'"

            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtQuantity.Text = myreader("totalquantity")
            txtPrice.Text = myreader("totalprice")
            Mycn.Close()
        ElseIf cobYear.SelectedIndex = 3 Then
            Mycn.Open()

            Dim strSql As String

            strSql = "select sum(OrderQuantity) as totalquantity, sum(OrderQuantity * OrderPrice) as totalprice from OrderTable where OrderYear = '2019'"

            Dim cmd1 As New SqlCommand(strSql, Mycn)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            txtQuantity.Text = myreader("totalquantity")
            txtPrice.Text = myreader("totalprice")
            Mycn.Close()
        End If
    End Sub
End Class