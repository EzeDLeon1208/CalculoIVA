Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P, C, Porc, PTotal, ImpTot, IVA As Double

        If IsNumeric(PrTxt.Text) = True Then
            P = Convert.ToDouble(PrTxt.Text)
            If IsNumeric(CTxt.Text) = True Then
                C = Convert.ToDouble(CTxt.Text)
                If IsNumeric(PorcTxt.Text) = True Then
                    Porc = Convert.ToDouble(PorcTxt.Text)

                    PTotal = P * C
                    IVA = Porc / 100
                    ImpTot = PTotal * IVA
                    ImpResp.Text = ImpTot.ToString
                Else
                    MessageBox.Show("Error, debe ingresar un numero")
                    PorcTxt.Clear()
                End If
            Else
                MessageBox.Show("Error, debe ingresar un numero")
                CTxt.Clear()
            End If
        Else
            MessageBox.Show("Error, debe ingresar un numero")
            PrTxt.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrTxt.Clear()
        CTxt.Clear()
        PorcTxt.Clear()
        ImpResp.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
