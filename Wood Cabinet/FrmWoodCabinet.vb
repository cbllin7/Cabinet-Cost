Public Class FrmWoodCabinet

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Dim decFeet As Decimal
        Dim decCostPerFeet As Decimal
        Dim decCostEstimate As Decimal
        Dim decPineCost As Decimal = 150D
        Dim decOakCost As Decimal = 250D
        Dim DecCherryCost As Decimal = 350D

        If IsNumeric(TxtFeet.Text) Then
            decFeet = Convert.ToDecimal(TxtFeet.Text)
            If decFeet > 0 Then
                If RbPine.Checked Then
                    decCostPerFeet = decPineCost
                ElseIf RBOak.Checked Then
                    decCostPerFeet = decOakCost
                ElseIf RBCherry.Checked Then
                    decCostPerFeet = DecCherryCost
                End If
                decCostEstimate = decFeet * decCostPerFeet
                LblCost.Text = decCostEstimate.ToString("c")
            Else
                MsgBox("You Entered " & decFeet.ToString() & ". Enter a Positive Number", , "Input Error")
                TxtFeet.Text = ""
                TxtFeet.Focus()
            End If
        Else
            MsgBox("Enter the Linear Feet of the Cabinets", , "Input Error")
            TxtFeet.Text = ""
            TxtFeet.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtFeet.Clear()
        LblCost.Text = ""
        RbPine.Checked = True
        RBCherry.Checked = False
        RBOak.Checked = False
        TxtFeet.Focus()

    End Sub

    Private Sub FrmWoodCabinet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFeet.Focus()
        LblCost.Text = ""

    End Sub
End Class
