Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class frmSearch
    Dim MyDatAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Dim mfmtStr As String
    Dim formattedStr As String
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mycn.Open()
        MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status from BookTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)

        mfmtStr = "{0, -15} {1, -30} {2, -50} {3, -15} {4, -30}"
        formattedStr = String.Format(mfmtStr, "Stock Number", "Title", "Author", "ISBN Number", "Category")
        ListBox1.Items.Add(formattedStr)
        formattedStr = String.Format(mfmtStr, "------------", "-----", "------", "-----------", "--------")
        ListBox1.Items.Add(formattedStr)

        DataGridView1.DataSource = MyDataTbl

        Mycn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()
        txtSearch.Focus()
        cobSearch.SelectedIndex = 0
        ListBox1.Items.Clear()

        mfmtStr = "{0, -15} {1, -30} {2, -50} {3, -15} {4, -30}"
        formattedStr = String.Format(mfmtStr, "Stock Number", "Title", "Author", "ISBN Number", "Category")
        ListBox1.Items.Add(formattedStr)
        formattedStr = String.Format(mfmtStr, "------------", "-----", "------", "-----------", "--------")
        ListBox1.Items.Add(formattedStr)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim found As Integer = 0
        Dim idx As Integer = 0
        Dim row As DataGridViewRow

        If cobSearch.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(txtSearch.Text) Or Not IsNumeric(txtSearch.Text) Then
                found = 1
                MessageBox.Show("Please enter a valid stock number!")
                txtSearch.Focus()
            End If
        ElseIf cobSearch.SelectedIndex = 1 Then
            If String.IsNullOrEmpty(txtSearch.Text) Or IsNumeric(txtSearch.Text) Then
                found = 1
                MessageBox.Show("Please enter a valid title!")
                txtSearch.Focus()
            End If
        ElseIf cobSearch.SelectedIndex = 2 Then
            If String.IsNullOrEmpty(txtSearch.Text) Or IsNumeric(txtSearch.Text) Then
                found = 1
                MessageBox.Show("Please enter a valid author!")
                txtSearch.Focus()
            End If
        End If

        For idx = 0 To DataGridView1.Rows.Count - 2
            row = DataGridView1.Rows(idx)
            If cobSearch.SelectedIndex = 0 Then
                If txtSearch.Text = row.Cells(0).Value.ToString Then
                    formattedStr = String.Format(mfmtStr, row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString)
                    ListBox1.Items.Add(formattedStr)
                    found = 1
                End If
            ElseIf cobSearch.SelectedIndex = 1 Then
                If txtSearch.Text.ToUpper = row.Cells(1).Value.ToString.ToUpper Then
                    formattedStr = String.Format(mfmtStr, row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString)
                    ListBox1.Items.Add(formattedStr)
                    found = 1
                End If
            ElseIf cobSearch.SelectedIndex = 2 Then
                If txtSearch.Text.ToUpper = row.Cells(2).Value.ToString.ToUpper Then
                    formattedStr = String.Format(mfmtStr, row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString)
                    ListBox1.Items.Add(formattedStr)
                    found = 1
                End If
            End If
        Next

        If found = 0 Then
            MessageBox.Show("No Book found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSearch.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class