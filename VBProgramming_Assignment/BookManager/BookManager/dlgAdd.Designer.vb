<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAdd))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cobStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.cobCategoty = New System.Windows.Forms.ComboBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtWholesalePrice = New System.Windows.Forms.TextBox()
        Me.lblWholesalePrice = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblISBN_Number = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblPubDate = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblStockNum = New System.Windows.Forms.Label()
        Me.txtStockNumber = New System.Windows.Forms.TextBox()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(886, 548)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'cobStatus
        '
        Me.cobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobStatus.Items.AddRange(New Object() {"Ordered", "Reordered", "Received", "Sold", "In Store", "On Display", "Missing"})
        Me.cobStatus.Location = New System.Drawing.Point(739, 190)
        Me.cobStatus.Name = "cobStatus"
        Me.cobStatus.Size = New System.Drawing.Size(265, 33)
        Me.cobStatus.TabIndex = 206
        Me.cobStatus.Text = "Ordered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(633, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Status :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(-4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1188, 49)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "Add Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImage.Location = New System.Drawing.Point(582, 358)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(139, 25)
        Me.lblImage.TabIndex = 228
        Me.lblImage.Text = "Book Image :"
        '
        'cobCategoty
        '
        Me.cobCategoty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobCategoty.FormattingEnabled = True
        Me.cobCategoty.Items.AddRange(New Object() {"Art and Photography", "Biography", "Business", "Finance and Law", "Children’s", "Computing", "Crime", "Fiction", "Food and Drink", "Health and Wellbeing", "History", "Music", "Stage and Screen", "Natural History", "Poetry and Drama", "Politics", "Philosophy and Religion", "Reference", "Romance", "Science Fiction", "Fantasy and Horror", "Science", "Sport", "Travel"})
        Me.cobCategoty.Location = New System.Drawing.Point(242, 297)
        Me.cobCategoty.Name = "cobCategoty"
        Me.cobCategoty.Size = New System.Drawing.Size(265, 33)
        Me.cobCategoty.TabIndex = 227
        Me.cobCategoty.Text = "Art and Photography"
        '
        'datePicker
        '
        Me.datePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(242, 242)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(265, 30)
        Me.datePicker.TabIndex = 226
        Me.datePicker.Value = New Date(2022, 4, 7, 0, 0, 0, 0)
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetailPrice.Location = New System.Drawing.Point(587, 248)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(134, 25)
        Me.lblRetailPrice.TabIndex = 225
        Me.lblRetailPrice.Text = "Retail Price :"
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailPrice.Location = New System.Drawing.Point(739, 248)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(265, 30)
        Me.txtRetailPrice.TabIndex = 224
        '
        'txtWholesalePrice
        '
        Me.txtWholesalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWholesalePrice.Location = New System.Drawing.Point(739, 303)
        Me.txtWholesalePrice.Name = "txtWholesalePrice"
        Me.txtWholesalePrice.Size = New System.Drawing.Size(265, 30)
        Me.txtWholesalePrice.TabIndex = 223
        '
        'lblWholesalePrice
        '
        Me.lblWholesalePrice.AutoSize = True
        Me.lblWholesalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWholesalePrice.Location = New System.Drawing.Point(539, 303)
        Me.lblWholesalePrice.Name = "lblWholesalePrice"
        Me.lblWholesalePrice.Size = New System.Drawing.Size(182, 25)
        Me.lblWholesalePrice.TabIndex = 222
        Me.lblWholesalePrice.Text = "Wholesale Price :"
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(242, 414)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(265, 30)
        Me.txtSupplier.TabIndex = 221
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(118, 417)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(105, 25)
        Me.lblSupplier.TabIndex = 220
        Me.lblSupplier.Text = "Supplier :"
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(739, 80)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(265, 30)
        Me.txtISBN.TabIndex = 219
        '
        'lblISBN_Number
        '
        Me.lblISBN_Number.AutoSize = True
        Me.lblISBN_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN_Number.Location = New System.Drawing.Point(559, 80)
        Me.lblISBN_Number.Name = "lblISBN_Number"
        Me.lblISBN_Number.Size = New System.Drawing.Size(162, 25)
        Me.lblISBN_Number.TabIndex = 218
        Me.lblISBN_Number.Text = "ISBN  Number :"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(107, 358)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(115, 25)
        Me.lblPublisher.TabIndex = 217
        Me.lblPublisher.Text = "Publisher :"
        '
        'txtPublisher
        '
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(242, 355)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(265, 30)
        Me.txtPublisher.TabIndex = 216
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(109, 300)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(113, 25)
        Me.lblCategory.TabIndex = 215
        Me.lblCategory.Text = "Category :"
        '
        'lblPubDate
        '
        Me.lblPubDate.AutoSize = True
        Me.lblPubDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubDate.Location = New System.Drawing.Point(43, 245)
        Me.lblPubDate.Name = "lblPubDate"
        Me.lblPubDate.Size = New System.Drawing.Size(179, 25)
        Me.lblPubDate.TabIndex = 214
        Me.lblPubDate.Text = "Publication date :"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(242, 187)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(265, 30)
        Me.txtTitle.TabIndex = 213
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(155, 190)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(67, 25)
        Me.lblTitle.TabIndex = 212
        Me.lblTitle.Text = "Title :"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(242, 132)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(265, 30)
        Me.txtAuthor.TabIndex = 211
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(133, 135)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(89, 25)
        Me.lblAuthor.TabIndex = 210
        Me.lblAuthor.Text = "Author :"
        '
        'lblStockNum
        '
        Me.lblStockNum.AutoSize = True
        Me.lblStockNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockNum.Location = New System.Drawing.Point(61, 80)
        Me.lblStockNum.Name = "lblStockNum"
        Me.lblStockNum.Size = New System.Drawing.Size(161, 25)
        Me.lblStockNum.TabIndex = 209
        Me.lblStockNum.Text = "Stock Number :"
        '
        'txtStockNumber
        '
        Me.txtStockNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockNumber.Location = New System.Drawing.Point(242, 77)
        Me.txtStockNumber.Name = "txtStockNumber"
        Me.txtStockNumber.Size = New System.Drawing.Size(265, 30)
        Me.txtStockNumber.TabIndex = 208
        '
        'picBook
        '
        Me.picBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBook.Image = CType(resources.GetObject("picBook.Image"), System.Drawing.Image)
        Me.picBook.InitialImage = CType(resources.GetObject("picBook.InitialImage"), System.Drawing.Image)
        Me.picBook.Location = New System.Drawing.Point(739, 358)
        Me.picBook.Margin = New System.Windows.Forms.Padding(4)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(217, 163)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 207
        Me.picBook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picBook, "Click To Add Image")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(739, 132)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(265, 30)
        Me.txtQuantity.TabIndex = 232
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(616, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "Quantity :"
        '
        'dlgAdd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1097, 599)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cobStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblImage)
        Me.Controls.Add(Me.cobCategoty)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtWholesalePrice)
        Me.Controls.Add(Me.lblWholesalePrice)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblISBN_Number)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblPubDate)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblStockNum)
        Me.Controls.Add(Me.txtStockNumber)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAdd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cobStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblImage As Label
    Friend WithEvents cobCategoty As ComboBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents lblRetailPrice As Label
    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents txtWholesalePrice As TextBox
    Friend WithEvents lblWholesalePrice As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lblISBN_Number As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblPubDate As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblStockNum As Label
    Friend WithEvents txtStockNumber As TextBox
    Private WithEvents picBook As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
End Class
