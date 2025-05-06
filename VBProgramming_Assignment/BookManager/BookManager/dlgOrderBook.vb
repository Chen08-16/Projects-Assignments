Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Public Class dlgOrderBook
    Dim sql As String
    Dim cmd As SqlCommand
    Dim Mycn As New SqlConnection("Server=LAPTOP-DN78T6U4\SQLEXPRESS; Database=BookDB; Trusted_Connection=True")
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtStockNumber.Text = "" Or Not IsNumeric(txtStockNumber.Text) Then
            MessageBox.Show("Please enter a valid stock number!")
            txtStockNumber.Focus()
        ElseIf txtOrderId.Text = "" Or Not IsNumeric(txtOrderId.Text) Then
            MessageBox.Show("Please enter a valid author!")
            txtOrderId.Focus()
        ElseIf txtTitle.Text = "" Then
            MessageBox.Show("Please enter a valid title!")
            txtTitle.Focus()
        ElseIf txtQuantity.Text = "" Or Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("Please enter a valid quantity!")
            txtQuantity.Focus()
        ElseIf txtPrice.Text = "" Or Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please enter a valid price!")
            txtPrice.Focus()
        ElseIf txtYear.Text = "" Then
            MessageBox.Show("Please enter a valid year!")
            txtYear.Focus()
        Else
            sql = "INSERT INTO OrderTable (OrderID, StockNumber, OrderTitle, OrderQuantity, OrderPrice, OrderYear) VALUES(@id, @num, @title, @quantity, @price, @year)"
            cmd = New SqlCommand(sql, Mycn)
            cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.Int)).Value = txtOrderId.Text
            cmd.Parameters.Add(New SqlParameter("@num", SqlDbType.Int)).Value = txtStockNumber.Text
            cmd.Parameters.Add(New SqlParameter("@title", SqlDbType.VarChar)).Value = txtTitle.Text
            cmd.Parameters.Add(New SqlParameter("@quantity", SqlDbType.Int)).Value = txtQuantity.Text
            cmd.Parameters.Add(New SqlParameter("@price", SqlDbType.Decimal)).Value = txtPrice.Text
            cmd.Parameters.Add(New SqlParameter("@year", SqlDbType.Int)).Value = txtYear.Text
            Mycn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record been saved", "Save", MessageBoxButtons.OK)
            Mycn.Close()

            txtStockNumber.Clear()
            txtOrderId.Clear()
            txtTitle.Clear()
            txtQuantity.Clear()
            txtPrice.Clear()
            txtYear.Clear()
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

        txtStockNumber.Clear()
        txtOrderId.Clear()
        txtTitle.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtYear.Clear()

        Me.Close()
    End Sub

End Class
