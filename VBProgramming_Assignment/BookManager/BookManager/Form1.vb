Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dlgAdd.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picAddBook.Click
        dlgAdd.ShowDialog()
    End Sub

    Private Sub picOrder_Click(sender As Object, e As EventArgs) Handles picOrder.Click
        frmOrder.ShowDialog()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        frmOrder.ShowDialog()
    End Sub

    Private Sub picManageBook_Click(sender As Object, e As EventArgs) Handles picManageBook.Click
        dlgManage.ShowDialog()
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        dlgManage.ShowDialog()
    End Sub

    Private Sub picViewBook_Click(sender As Object, e As EventArgs) Handles picViewBook.Click
        frmList.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmList.ShowDialog()
    End Sub

    Private Sub picSearchBook_Click(sender As Object, e As EventArgs) Handles picSearchBook.Click
        frmSearch.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.ShowDialog()
    End Sub

    Private Sub picSales_Click(sender As Object, e As EventArgs) Handles picSales.Click
        frmSales.ShowDialog()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        frmSales.ShowDialog()
    End Sub

End Class
