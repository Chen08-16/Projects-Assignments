Imports System.Windows.Forms
Public Class frmSales
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        frmTotalSales.ShowDialog()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        dlgSalesBook.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnSold_Click(sender As Object, e As EventArgs) Handles btnSold.Click
        frmSalesBookList.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmSalesBookList.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        dlgSalesBook.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmTotalSales.ShowDialog()
    End Sub
End Class