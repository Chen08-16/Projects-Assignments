Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class dlgManage
    Dim MyDatAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Private MyDataTbl As New DataTable
    Dim ms As MemoryStream
    Dim arrImage() As Byte
    Dim sql As String
    Dim cmd As SqlCommand
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ms = New MemoryStream()
        picBook.Image.Save(ms, picBook.Image.RawFormat)
        arrImage = ms.GetBuffer()
        ms.Close()

        If txtStockNumber.Text = "" Or Not IsNumeric(txtStockNumber.Text) Then
            MessageBox.Show("Please enter a valid stock number!")
            txtStockNumber.Focus()
        ElseIf txtAuthor.Text = "" Then
            MessageBox.Show("Please enter a valid author!")
            txtAuthor.Focus()
        ElseIf txtTitle.Text = "" Then
            MessageBox.Show("Please enter a valid title!")
            txtTitle.Focus()
        ElseIf txtQuantity.Text = "" Or Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Please enter a valid quantity!")
            txtQuantity.Focus()
        ElseIf txtISBN.Text = "" Then
            MessageBox.Show("Please enter a valid ISBN number!")
            txtISBN.Focus()
        ElseIf cobStatus.Text = "" Or IsNumeric(cobStatus.Text) Then
            MessageBox.Show("Please select a valid status!")
            cobStatus.Focus()
        ElseIf cobCategoty.Text = "" Or IsNumeric(cobCategoty.Text) Then
            MessageBox.Show("Please enter a valid category!")
            cobCategoty.Focus()
        ElseIf datePicker.Text = "" Then
            MessageBox.Show("Please select a valid date!")
            datePicker.Focus()
        ElseIf txtPublisher.Text = "" Or IsNumeric(txtPublisher.Text) Then
            MessageBox.Show("Please enter a valid publisher!")
            txtPublisher.Focus()
        ElseIf txtSupplier.Text = "" Or IsNumeric(txtSupplier.Text) Then
            MessageBox.Show("Please enter a valid supplier!")
            txtSupplier.Focus()
        ElseIf txtWholesalePrice.Text = "" Or Not IsNumeric(txtWholesalePrice.Text) Then
            MessageBox.Show("Please enter a valid wholesale price!")
            txtWholesalePrice.Focus()
        ElseIf txtRetailPrice.Text = "" Or Not IsNumeric(txtRetailPrice.Text) Then
            MessageBox.Show("Please enter a valid retail price!")
            txtRetailPrice.Focus()
        ElseIf picBook.Image Is Nothing Then
            MessageBox.Show("Please select an image!")
        Else
            sql = "UPDATE BookTable SET Title=@title, Author=@author, ISBNNumber=@isbn, Category=@category, Quantity=@quantity, Picture=@pic, PublicationDate=@date, Publisher=@publisher, Supplier=@supplier, WholesalePrice=@wholesale, RetailPrice=@retail, Status=@status WHERE StockNumber=@num"
            cmd = New SqlCommand(sql, Mycn)
            cmd.Parameters.Add(New SqlParameter("@num", SqlDbType.Int)).Value = txtStockNumber.Text
            cmd.Parameters.Add(New SqlParameter("@title", SqlDbType.VarChar)).Value = txtTitle.Text
            cmd.Parameters.Add(New SqlParameter("@author", SqlDbType.VarChar)).Value = txtAuthor.Text
            cmd.Parameters.Add(New SqlParameter("@isbn", SqlDbType.VarChar, 50)).Value = txtISBN.Text
            cmd.Parameters.Add(New SqlParameter("@category", SqlDbType.VarChar, 50)).Value = cobCategoty.Text
            cmd.Parameters.Add(New SqlParameter("@quantity", SqlDbType.Int)).Value = txtQuantity.Text
            cmd.Parameters.Add(New SqlParameter("@pic", SqlDbType.Image)).Value = arrImage
            cmd.Parameters.Add(New SqlParameter("@date", SqlDbType.Date)).Value = datePicker.Text
            cmd.Parameters.Add(New SqlParameter("@publisher", SqlDbType.VarChar, 50)).Value = txtPublisher.Text
            cmd.Parameters.Add(New SqlParameter("@supplier", SqlDbType.VarChar, 50)).Value = txtSupplier.Text
            cmd.Parameters.Add(New SqlParameter("@wholesale", SqlDbType.Decimal)).Value = txtWholesalePrice.Text
            cmd.Parameters.Add(New SqlParameter("@retail", SqlDbType.Decimal)).Value = txtRetailPrice.Text
            cmd.Parameters.Add(New SqlParameter("@status", SqlDbType.VarChar, 50)).Value = cobStatus.Text

            Mycn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record been saved", "Save", MessageBoxButtons.OK)
            Mycn.Close()


            txtStockNumber.Clear()
            txtTitle.Clear()
            txtAuthor.Clear()
            txtISBN.Clear()
            cobCategoty.ResetText()
            txtQuantity.Clear()
            txtStockNumber.Clear()
            txtPublisher.Clear()
            txtSupplier.Clear()
            txtWholesalePrice.Clear()
            txtRetailPrice.Clear()
            cobStatus.ResetText()
            Me.Close()
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        txtStockNumber.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtISBN.Clear()
        cobCategoty.ResetText()
        txtQuantity.Clear()
        txtStockNumber.Clear()
        txtPublisher.Clear()
        txtSupplier.Clear()
        txtWholesalePrice.Clear()
        txtRetailPrice.Clear()
        cobStatus.ResetText()
        ListBox1.Items.Clear()
        Me.Close()
    End Sub

    Private Sub dlgManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idx As Integer

        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.CustomFormat = " "

        Mycn.Open()
        MyDatAdp = New SqlDataAdapter("select * from BookTable", Mycn)
        MyCmdBld = New SqlCommandBuilder(MyDatAdp)
        MyDatAdp.Fill(MyDataTbl)

        For idx = 0 To MyDataTbl.Rows.Count - 1
            ListBox1.Items.Add(MyDataTbl.Rows(idx)(0).ToString())
        Next

        Mycn.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtStockNumber.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(0).ToString()
        txtTitle.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(1).ToString()
        txtAuthor.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(2).ToString()
        txtISBN.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(3).ToString()
        cobCategoty.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(4).ToString()
        txtQuantity.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(5).ToString()
        datePicker.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(7).ToString()
        txtPublisher.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(8).ToString()
        txtSupplier.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(9).ToString()
        txtWholesalePrice.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(10).ToString()
        txtRetailPrice.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(11).ToString()
        cobStatus.Text = MyDataTbl.Rows(ListBox1.SelectedIndex)(12).ToString()
        arrImage = CType(MyDataTbl.Rows(ListBox1.SelectedIndex)("Picture"), Byte())

        ms = New MemoryStream(arrImage)
        picBook.Image = Image.FromStream(ms)
    End Sub

    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        If datePicker.Format = DateTimePickerFormat.Custom AndAlso datePicker.CustomFormat = " " Then
            datePicker.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim reply As Integer
        reply = MessageBox.Show("Are you sure to delete?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If reply = DialogResult.Yes Then
            sql = "DELETE FROM BookTable WHERE StockNumber=@num"
            cmd = New SqlCommand(sql, Mycn)
            cmd.Parameters.Add(New SqlParameter("@num", SqlDbType.Int)).Value = txtStockNumber.Text
            Mycn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record has been deleted", "Save", MessageBoxButtons.OK)

            Mycn.Close()
        End If
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picBook.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

End Class
