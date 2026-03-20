Public Class hospital
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtPatientName_TextChanged(sender As Object, e As EventArgs) Handles txtPatientName.TextChanged


    End Sub

    Private Sub btnCalculateBill_Click(sender As Object, e As EventArgs) Handles btnCalculateBill.Click
        Dim patientName As String
        patientName = txtPatientName.Text

        ' Checking whether patient name is entered or not
        If (patientName = "") Then
            MessageBox.Show("Please enter patient name")
        End If

        If (txtDays.Text = "") Then
            MessageBox.Show("please enter number of Days")
        End If

        ' Get the ward rate based on selection

        Dim wardRate As Decimal = 0
        Dim wardName As String = ""

        If (genWard.Checked) Then
            wardRate = 200
            wardName = "General ward"
        ElseIf (semPrivate.Checked) Then
            wardRate = 350
            wardName = "Semi-private"
        ElseIf (radPrivate.Checked) Then
            wardRate = 500
            wardName = "Private"
        Else
            MessageBox.Show("Please select a ward type")
        End If

        Dim days As Integer = Convert.ToInt32(txtDays.Text)

        Dim wardCharges As Decimal = wardRate * days

        Dim treatmentCharges As Decimal = 0
        If labTest.Checked Then treatmentCharges += 150
        If xray.Checked Then treatmentCharges += 100
        If surg.Checked Then treatmentCharges += 1000

        Dim subtotal As Decimal = wardCharges + treatmentCharges
        Dim vat As Decimal = subtotal * 0.12
        Dim finalBill As Decimal = subtotal + vat

        txtBill.Text = "Patient Name: " & txtPatientName.Text & vbNewLine &
                      "Ward Type: " & wardName & vbNewLine &
                      "Days Admitted: " & days & vbNewLine &
                      "Ward Charges: GHS " & wardCharges & vbNewLine &
                      "Treatment Charges: GHS " & treatmentCharges & vbNewLine &
                      "Subtotal: GHS " & subtotal & vbNewLine &
                      "VAT (12%): GHS " & vat & vbNewLine &
                      "Final Bill: GHS " & finalBill
        If finalBill > 5000 Then
            txtBill.Text &= vbNewLine & "*** Premium Billing Category ***"
        End If

        ' Build the bill message
        Dim billMessage As String = "==============================" & vbNewLine &
                                    "      HOSPITAL BILL RECEIPT   " & vbNewLine &
                                    "==============================" & vbNewLine &
                                    "Patient Name  : " & txtPatientName.Text & vbNewLine &
                                    "Ward Type     : " & wardName & vbNewLine &
                                    "Days Admitted : " & days & vbNewLine &
                                    "------------------------------" & vbNewLine &
                                    "Ward Charges  : GHS " & wardCharges & vbNewLine &
                                    "Treatment     : GHS " & treatmentCharges & vbNewLine &
                                    "------------------------------" & vbNewLine &
                                    "Subtotal      : GHS " & subtotal & vbNewLine &
                                    "VAT (12%)     : GHS " & vat & vbNewLine &
                                    "==============================" & vbNewLine &
                                    "FINAL BILL    : GHS " & finalBill & vbNewLine &
                                    "=============================="

        ' Check for premium billing
        If finalBill > 5000 Then
            billMessage &= vbNewLine & "⚠ PREMIUM BILLING CATEGORY"
        End If

        ' Display in a MessageBox
        MessageBox.Show(billMessage, "Hospital Bill Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub hospital_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class