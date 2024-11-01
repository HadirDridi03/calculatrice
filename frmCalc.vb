Public Class frmCalc
    Dim A As String
    Dim B As String
    Dim op = ""

    Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        If Not A = "" Then
            op = "+"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
        If Not A = "" Then
            op = "*"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub moin_Click(sender As Object, e As EventArgs) Handles moin.Click
        If Not A = "" Then
            op = "-"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        If Not A = "" Then
            op = "/"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub efface_Click(sender As Object, e As EventArgs) Handles efface.Click
        txt_affiche.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub

    Private Sub egal_Click(sender As Object, e As EventArgs) Handles egal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not vb = "0" Then
                res = va / vb
            Else
                MessageBox.Show("division par 0")
                test = False
            End If
        Else
            MessageBox.Show("A et B doivent etre deux entiers")
            test = False

        End If
        If test Then
            txt_affiche.Text = txt_affiche.Text + "=" + res.ToString
        End If

    End Sub
End Class
