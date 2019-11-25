Public Class Form1
    Dim mcSubTotal As Double
    Dim mcTotal As Double
    Const cCAPPUCCINO_PRICE = 3
    Const cEXPRESSO_PRICE = 3.25
    Const cLATTE_PRICE = 2.85
    Const cICED_PRICE = 4.25
    Const mcTAX_RATE = 0.75
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        With txtQuantity
            .Text = ""
            .Focus()
        End With
        lblItemAmount.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""

        RadCappuccino.Checked = False
        RadExpresso.Checked = False
        RadIcedLatte.Checked = False
        RadLatte.Checked = False
        RadIcedCappuccino.Checked = False
        chkTax.Checked = False

        mcSubTotal = 0
        mcTotal = 0
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim cPrice As Double
        Dim iQuantity As Double
        Dim cTax As Double
        Dim cItemAmount As Double

        If RadCappuccino.Checked = True Then
            cPrice = cCAPPUCCINO_PRICE
        ElseIf RadExpresso.checked = True Then
            cPrice = cEXPRESSO_PRICE
        ElseIf RadLatte.Checked = True Then
            cPrice = cLATTE_PRICE
        ElseIf RadIcedLatte.Checked = True Then
            cPrice = cICED_PRICE
        ElseIf RadIcedCappuccino.Checked = True Then
            cPrice = cICED_PRICE
        Else : MsgBox("Please Select a Drink", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops")

        End If

        If IsNumeric(txtQuantity.Text) Then
            iQuantity = Val(txtQuantity.Text)
            cItemAmount = cPrice * iQuantity
            mcSubTotal = mcSubTotal + cItemAmount
            If chkTax.Checked = True Then
                cTax = cFindTax(mcSubTotal) 'call a function procedure
            End If
            mcTotal = mcSubTotal + cTax
            lblItemAmount.Text = FormatCurrency$(cItemAmount)
            lblSubTotal.Text = FormatCurrency$(mcSubTotal)
            lblTax.Text = FormatCurrency$(mcTotal)
            lblTotal.Text = FormatCurrency$(mcTotal)
        Else
            MsgBox("Quantity must contain a number", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops")
            txtQuantity.Focus()
        End If
    End Sub

    Private Function cFindTax(ByVal cAmount As Double)
        cFindTax = cAmount * mcTAX_RATE
    End Function
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
