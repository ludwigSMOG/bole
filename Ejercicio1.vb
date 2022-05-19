Imports System.IO
Public Class Ejercicio1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim suma As Integer

        If Ckbox1.Checked Then
            suma += 100
        End If
        If Ckbox2.Checked Then
            suma += 500
        End If
        If Ckbox3.Checked Then
            suma += 200
        End If
        If Ckbox4.Checked Then
            suma += 80
        End If
        If Ckbox5.Checked Then
            suma += 300
        End If
        If Ckbox6.Checked Then
            suma += 150
        End If

        txtTotal.Text = suma
    End Sub

    Private Sub Ckbox1_CheckedChanged(sender As Object, e As EventArgs) Handles Ckbox1.CheckedChanged, Ckbox2.CheckedChanged, Ckbox3.CheckedChanged, Ckbox4.CheckedChanged, Ckbox5.CheckedChanged, Ckbox6.CheckedChanged
        txtTotal.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtTotal.Clear()
        Ckbox1.Checked = False
        Ckbox2.Checked = False
        Ckbox3.Checked = False
        Ckbox4.Checked = False
        Ckbox5.Checked = False
        Ckbox6.Checked = False

    End Sub
End Class
