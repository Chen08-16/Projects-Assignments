Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class frmSalesBookList
    Dim MyDatAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmSalesBookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyDatAdp = New SqlDataAdapter("select SalesID, Title, Author, ISBNNumber, Category, SellingPrice, SoldQuantity, PublicationDate, Publisher, Supplier from BookTable, SalesTable where BookTable.StockNumber = SalesTable.StockNumber", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)

        DataGridView1.DataSource = MyDataTbl
        DataGridView1.Update()
        DataGridView1.RefreshEdit()

        Mycn.Close()
    End Sub
End Class