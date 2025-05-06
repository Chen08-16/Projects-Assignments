<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Me.btnOrderList = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBookList = New System.Windows.Forms.PictureBox()
        Me.picOrder = New System.Windows.Forms.PictureBox()
        Me.picTotal = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picBookList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrderList
        '
        Me.btnOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderList.Location = New System.Drawing.Point(103, 302)
        Me.btnOrderList.Name = "btnOrderList"
        Me.btnOrderList.Size = New System.Drawing.Size(113, 74)
        Me.btnOrderList.TabIndex = 20
        Me.btnOrderList.Text = "Ordered Book List"
        Me.btnOrderList.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(381, 302)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(113, 74)
        Me.btnOrder.TabIndex = 19
        Me.btnOrder.Text = "Order Book"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(659, 302)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(113, 74)
        Me.btnTotal.TabIndex = 18
        Me.btnTotal.Text = "Total Order"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(755, 449)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 38)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(-5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1225, 47)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picBookList
        '
        Me.picBookList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBookList.Image = CType(resources.GetObject("picBookList.Image"), System.Drawing.Image)
        Me.picBookList.Location = New System.Drawing.Point(75, 121)
        Me.picBookList.Name = "picBookList"
        Me.picBookList.Size = New System.Drawing.Size(165, 160)
        Me.picBookList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookList.TabIndex = 21
        Me.picBookList.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picBookList, "Click To View Ordered Book List")
        '
        'picOrder
        '
        Me.picOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picOrder.Image = CType(resources.GetObject("picOrder.Image"), System.Drawing.Image)
        Me.picOrder.Location = New System.Drawing.Point(353, 121)
        Me.picOrder.Name = "picOrder"
        Me.picOrder.Size = New System.Drawing.Size(165, 160)
        Me.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOrder.TabIndex = 22
        Me.picOrder.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picOrder, "Click To Order Book")
        '
        'picTotal
        '
        Me.picTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTotal.Image = CType(resources.GetObject("picTotal.Image"), System.Drawing.Image)
        Me.picTotal.Location = New System.Drawing.Point(631, 121)
        Me.picTotal.Name = "picTotal"
        Me.picTotal.Size = New System.Drawing.Size(165, 160)
        Me.picTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTotal.TabIndex = 23
        Me.picTotal.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picTotal, "Click To View Total Order")
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 514)
        Me.Controls.Add(Me.picTotal)
        Me.Controls.Add(Me.picOrder)
        Me.Controls.Add(Me.picBookList)
        Me.Controls.Add(Me.btnOrderList)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrder"
        Me.Text = "Order"
        CType(Me.picBookList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOrderList As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents picBookList As PictureBox
    Friend WithEvents picOrder As PictureBox
    Friend WithEvents picTotal As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
