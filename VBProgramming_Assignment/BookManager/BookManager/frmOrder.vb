Imports System.Windows.Forms
Public Class frmOrder
    Private Sub btnOrderList_Click(sender As Object, e As EventArgs) Handles btnOrderList.Click
        frmOrderedBookList.ShowDialog()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        dlgOrderBook.ShowDialog()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        frmTotalOrder.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub picBookList_Click(sender As Object, e As EventArgs) Handles picBookList.Click
        frmOrderedBookList.ShowDialog()
    End Sub

    Private Sub picOrder_Click(sender As Object, e As EventArgs) Handles picOrder.Click
        dlgOrderBook.ShowDialog()
    End Sub

    Private Sub picTotal_Click(sender As Object, e As EventArgs) Handles picTotal.Click
        frmTotalOrder.ShowDialog()
    End Sub
End Class