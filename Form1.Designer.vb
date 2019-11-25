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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.chkTax = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblItemAmount = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.RadCappuccino = New System.Windows.Forms.RadioButton()
        Me.RadExpresso = New System.Windows.Forms.RadioButton()
        Me.RadLatte = New System.Windows.Forms.RadioButton()
        Me.RadIcedLatte = New System.Windows.Forms.RadioButton()
        Me.RadIcedCappuccino = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblItemAmount)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.chkTax)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadIcedCappuccino)
        Me.GroupBox2.Controls.Add(Me.RadIcedLatte)
        Me.GroupBox2.Controls.Add(Me.RadLatte)
        Me.GroupBox2.Controls.Add(Me.RadExpresso)
        Me.GroupBox2.Controls.Add(Me.RadCappuccino)
        Me.GroupBox2.Location = New System.Drawing.Point(496, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 131)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee Selections"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(721, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item Amount"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(91, 29)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'chkTax
        '
        Me.chkTax.AutoSize = True
        Me.chkTax.Location = New System.Drawing.Point(21, 99)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(72, 17)
        Me.chkTax.TabIndex = 5
        Me.chkTax.Text = "Takeout?"
        Me.chkTax.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(126, 127)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(207, 127)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sub Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "VAT (If Takeout)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Due"
        '
        'lblItemAmount
        '
        Me.lblItemAmount.AutoSize = True
        Me.lblItemAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemAmount.Location = New System.Drawing.Point(101, 240)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.lblItemAmount.Size = New System.Drawing.Size(102, 15)
        Me.lblItemAmount.TabIndex = 8
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(117, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.lblSubTotal.Size = New System.Drawing.Size(102, 15)
        Me.lblSubTotal.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(117, 39)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.lblTax.Size = New System.Drawing.Size(102, 15)
        Me.lblTax.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(117, 63)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.lblTotal.Size = New System.Drawing.Size(102, 15)
        Me.lblTotal.TabIndex = 5
        '
        'RadCappuccino
        '
        Me.RadCappuccino.AutoSize = True
        Me.RadCappuccino.Location = New System.Drawing.Point(7, 20)
        Me.RadCappuccino.Name = "RadCappuccino"
        Me.RadCappuccino.Size = New System.Drawing.Size(82, 17)
        Me.RadCappuccino.TabIndex = 0
        Me.RadCappuccino.TabStop = True
        Me.RadCappuccino.Text = "Cappuccino"
        Me.RadCappuccino.UseVisualStyleBackColor = True
        '
        'RadExpresso
        '
        Me.RadExpresso.AutoSize = True
        Me.RadExpresso.Location = New System.Drawing.Point(7, 43)
        Me.RadExpresso.Name = "RadExpresso"
        Me.RadExpresso.Size = New System.Drawing.Size(68, 17)
        Me.RadExpresso.TabIndex = 1
        Me.RadExpresso.TabStop = True
        Me.RadExpresso.Text = "Expresso"
        Me.RadExpresso.UseVisualStyleBackColor = True
        '
        'RadLatte
        '
        Me.RadLatte.AutoSize = True
        Me.RadLatte.Location = New System.Drawing.Point(7, 62)
        Me.RadLatte.Name = "RadLatte"
        Me.RadLatte.Size = New System.Drawing.Size(49, 17)
        Me.RadLatte.TabIndex = 2
        Me.RadLatte.TabStop = True
        Me.RadLatte.Text = "Latte"
        Me.RadLatte.UseVisualStyleBackColor = True
        '
        'RadIcedLatte
        '
        Me.RadIcedLatte.AutoSize = True
        Me.RadIcedLatte.Location = New System.Drawing.Point(7, 81)
        Me.RadIcedLatte.Name = "RadIcedLatte"
        Me.RadIcedLatte.Size = New System.Drawing.Size(73, 17)
        Me.RadIcedLatte.TabIndex = 3
        Me.RadIcedLatte.TabStop = True
        Me.RadIcedLatte.Text = "Iced Latte"
        Me.RadIcedLatte.UseVisualStyleBackColor = True
        '
        'RadIcedCappuccino
        '
        Me.RadIcedCappuccino.AutoSize = True
        Me.RadIcedCappuccino.Location = New System.Drawing.Point(7, 101)
        Me.RadIcedCappuccino.Name = "RadIcedCappuccino"
        Me.RadIcedCappuccino.Size = New System.Drawing.Size(106, 17)
        Me.RadIcedCappuccino.TabIndex = 4
        Me.RadIcedCappuccino.TabStop = True
        Me.RadIcedCappuccino.Text = "Iced Cappuccino"
        Me.RadIcedCappuccino.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents chkTax As CheckBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadIcedCappuccino As RadioButton
    Friend WithEvents RadIcedLatte As RadioButton
    Friend WithEvents RadLatte As RadioButton
    Friend WithEvents RadExpresso As RadioButton
    Friend WithEvents RadCappuccino As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
