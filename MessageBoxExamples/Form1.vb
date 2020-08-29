Public Class Form1
    Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
        MsgBox("This is a simple message box.")
    End Sub

    Private Sub btnComplex_Click(sender As Object, e As EventArgs) Handles btnComplex.Click
        'MessageBox.Show("This is a complex message box",
        '                "Test",
        '                MessageBoxButtons.AbortRetryIgnore,
        '                MessageBoxIcon.Error)
        If Val(txtAge.Text) >= 18 Then
            MessageBox.Show("You are an adult",
                            "Congratulations",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("You are not an adult",
                            "Sorry",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you really want to close this form?",
                           "Close",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            MsgBox("You have selected the YES option")
            Me.Dispose()
        Else
            MsgBox("You have selected the NO option")
        End If
    End Sub
End Class
