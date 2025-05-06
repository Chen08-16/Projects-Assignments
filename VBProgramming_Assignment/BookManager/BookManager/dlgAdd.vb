Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class dlgAdd
    Dim ms As MemoryStream
    Dim arrImage() As Byte
    Dim sql As String
    Dim cmd As SqlCommand
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
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
            sql = "INSERT INTO BookTable (StockNumber, Title, Author, ISBNNumber, Category, Quantity, Picture, PublicationDate, Publisher, Supplier, WholesalePrice, RetailPrice, Status) VALUES(@num, @title, @author, @isbn, @category, @quantity, @pic, @date, @publisher, @supplier, @wholesale, @retail, @status)"
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
            txtAuthor.Clear()
            txtTitle.Clear()
            datePicker.ResetText()
            cobCategoty.SelectedIndex = 0
            cobStatus.SelectedIndex = 0
            txtPublisher.Clear()
            txtQuantity.Clear()
            txtISBN.Clear()
            txtSupplier.Clear()
            txtWholesalePrice.Clear()
            txtRetailPrice.Clear()
            picBook.Image = picBook.InitialImage
            Me.Close()
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        txtStockNumber.Clear()
        txtAuthor.Clear()
        txtTitle.Clear()
        datePicker.ResetText()
        cobCategoty.SelectedIndex = 0
        cobStatus.SelectedIndex = 0
        txtPublisher.Clear()
        txtQuantity.Clear()
        txtISBN.Clear()
        txtSupplier.Clear()
        txtWholesalePrice.Clear()
        txtRetailPrice.Clear()
        picBook.Image = picBook.InitialImage
        Me.Close()
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picBook.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub dlgAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.CustomFormat = " "
    End Sub

    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        If datePicker.Format = DateTimePickerFormat.Custom AndAlso datePicker.CustomFormat = " " Then
            datePicker.Format = DateTimePickerFormat.Short
        End If
    End Sub
End Class
