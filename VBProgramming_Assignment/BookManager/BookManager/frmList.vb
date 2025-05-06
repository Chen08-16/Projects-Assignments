Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class frmList
    Dim MyDatAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Dim sql As String
    Dim cmd As SqlCommand
    Dim index As Integer
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If cobStatus.SelectedIndex = 0 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'Ordered'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        ElseIf cobStatus.SelectedIndex = 1 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'Reordered'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        ElseIf cobStatus.SelectedIndex = 2 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'Received'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        ElseIf cobStatus.SelectedIndex = 3 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'Sold'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        ElseIf cobStatus.SelectedIndex = 4 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'In Store'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        ElseIf cobStatus.SelectedIndex = 5 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'On Display'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        ElseIf cobStatus.SelectedIndex = 6 Then
            DataGridView1.DataSource.Clear()
            Mycn.Open()
            MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable where Status = 'Missing'", Mycn)
            MyCmdBld = New SqlCommandBuilder(MyDatAdp)
            MyDatAdp.Fill(MyDataTbl)

            DataGridView1.DataSource = MyDataTbl

            Mycn.Close()
        End If
    End Sub

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mycn.Open()
        MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)

        DataGridView1.DataSource = MyDataTbl
        DataGridView1.Update()
        DataGridView1.RefreshEdit()

        Mycn.Close()
    End Sub
End Class