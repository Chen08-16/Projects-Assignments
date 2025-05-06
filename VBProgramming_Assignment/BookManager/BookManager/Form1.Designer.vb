<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.picOrder = New System.Windows.Forms.PictureBox()
        Me.picManageBook = New System.Windows.Forms.PictureBox()
        Me.picViewBook = New System.Windows.Forms.PictureBox()
        Me.picAddBook = New System.Windows.Forms.PictureBox()
        Me.picSearchBook = New System.Windows.Forms.PictureBox()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picManageBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picViewBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAddBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearchBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1077, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK MANAGER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(-2, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1168, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Home Page"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOrder
        '
        Me.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(48, 370)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(114, 61)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Order Details"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(240, 370)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 61)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Book"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(620, 370)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(114, 61)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View Book List"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnManage
        '
        Me.btnManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.Location = New System.Drawing.Point(429, 370)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(114, 61)
        Me.btnManage.TabIndex = 6
        Me.btnManage.Text = "Manage Book"
        Me.btnManage.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(808, 370)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 61)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search Book"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.Location = New System.Drawing.Point(996, 370)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(114, 61)
        Me.btnSales.TabIndex = 8
        Me.btnSales.Text = "Sales Details"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'picOrder
        '
        Me.picOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picOrder.Image = CType(resources.GetObject("picOrder.Image"), System.Drawing.Image)
        Me.picOrder.Location = New System.Drawing.Point(23, 192)
        Me.picOrder.Name = "picOrder"
        Me.picOrder.Size = New System.Drawing.Size(165, 160)
        Me.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOrder.TabIndex = 9
        Me.picOrder.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picOrder, "Click To Order Book")
        '
        'picManageBook
        '
        Me.picManageBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picManageBook.Image = CType(resources.GetObject("picManageBook.Image"), System.Drawing.Image)
        Me.picManageBook.Location = New System.Drawing.Point(403, 192)
        Me.picManageBook.Name = "picManageBook"
        Me.picManageBook.Size = New System.Drawing.Size(165, 160)
        Me.picManageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picManageBook.TabIndex = 10
        Me.picManageBook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picManageBook, "Click To Manage Book")
        '
        'picViewBook
        '
        Me.picViewBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picViewBook.Image = CType(resources.GetObject("picViewBook.Image"), System.Drawing.Image)
        Me.picViewBook.Location = New System.Drawing.Point(593, 192)
        Me.picViewBook.Name = "picViewBook"
        Me.picViewBook.Size = New System.Drawing.Size(165, 160)
        Me.picViewBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picViewBook.TabIndex = 11
        Me.picViewBook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picViewBook, "Click To View Book Details")
        '
        'picAddBook
        '
        Me.picAddBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAddBook.Image = CType(resources.GetObject("picAddBook.Image"), System.Drawing.Image)
        Me.picAddBook.Location = New System.Drawing.Point(213, 192)
        Me.picAddBook.Name = "picAddBook"
        Me.picAddBook.Size = New System.Drawing.Size(165, 160)
        Me.picAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAddBook.TabIndex = 12
        Me.picAddBook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picAddBook, "Click To Add Book")
        '
        'picSearchBook
        '
        Me.picSearchBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSearchBook.Image = CType(resources.GetObject("picSearchBook.Image"), System.Drawing.Image)
        Me.picSearchBook.Location = New System.Drawing.Point(783, 192)
        Me.picSearchBook.Name = "picSearchBook"
        Me.picSearchBook.Size = New System.Drawing.Size(165, 160)
        Me.picSearchBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearchBook.TabIndex = 12
        Me.picSearchBook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picSearchBook, "Click To Search Book")
        '
        'picSales
        '
        Me.picSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSales.Image = CType(resources.GetObject("picSales.Image"), System.Drawing.Image)
        Me.picSales.Location = New System.Drawing.Point(973, 192)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(165, 160)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSales.TabIndex = 12
        Me.picSales.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picSales, "Click To View Sales Details")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 553)
        Me.Controls.Add(Me.picSearchBook)
        Me.Controls.Add(Me.picSales)
        Me.Controls.Add(Me.picAddBook)
        Me.Controls.Add(Me.picViewBook)
        Me.Controls.Add(Me.picManageBook)
        Me.Controls.Add(Me.picOrder)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnManage)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Book Manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picManageBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picViewBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAddBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearchBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnManage As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents picOrder As PictureBox
    Friend WithEvents picManageBook As PictureBox
    Friend WithEvents picViewBook As PictureBox
    Friend WithEvents picAddBook As PictureBox
    Friend WithEvents picSearchBook As PictureBox
    Friend WithEvents picSales As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
