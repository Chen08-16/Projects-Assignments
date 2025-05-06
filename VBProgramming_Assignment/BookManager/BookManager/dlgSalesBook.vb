Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class dlgSalesBook
    Dim MyDatAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Dim sql As String
    Dim cmd As SqlCommand
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtStockNumber.Text = "" Or Not IsNumeric(txtStockNumber.Text) Then
            MessageBox.Show("Please enter a valid stock number!")
            txtStockNumber.Focus()
        ElseIf txtSalesId.Text = "" Or Not IsNumeric(txtSalesId.Text) Then
            MessageBox.Show("Please enter a valid author!")
            txtSalesId.Focus()
        ElseIf txtPrice.Text = "" Or Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please enter a valid title!")
            txtPrice.Focus()
        ElseIf txtQuantity.Text = "" Or Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Please enter a valid quantity!")
            txtQuantity.Focus()
        ElseIf txtYear.Text = "" Then
            MessageBox.Show("Please enter a valid year!")
            txtYear.Focus()
        Else
            sql = "INSERT INTO SalesTable (StockNumber, SalesID, SoldQuantity, SellingPrice, SalesYear) VALUES(@num, @id, @quantity, @price, @year)"
            cmd = New SqlCommand(sql, Mycn)
            cmd.Parameters.Add(New SqlParameter("@num", SqlDbType.Int)).Value = txtStockNumber.Text
            cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.VarChar)).Value = txtSalesId.Text
            cmd.Parameters.Add(New SqlParameter("@quantity", SqlDbType.VarChar)).Value = txtQuantity.Text
            cmd.Parameters.Add(New SqlParameter("@price", SqlDbType.VarChar, 50)).Value = txtPrice.Text
            cmd.Parameters.Add(New SqlParameter("@year", SqlDbType.Int)).Value = txtYear.Text
            Mycn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record been saved", "Save", MessageBoxButtons.OK)
            Mycn.Close()

            txtStockNumber.Clear()
            txtSalesId.Clear()
            txtPrice.Clear()
            txtQuantity.Clear()
            txtYear.Clear()
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        txtStockNumber.Clear()
        txtSalesId.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtYear.Clear()
        Me.Close()
    End Sub

    Private Sub dlgSalesBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mycn.Open()
        MyDatAdp = New SqlDataAdapter("select StockNumber, Title, Author, ISBNNumber, Category, Quantity, Status from BookTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)

        DataGridView1.DataSource = MyDataTbl
        DataGridView1.Update()
        DataGridView1.RefreshEdit()

        Mycn.Close()
    End Sub
End Class
