Public Class Form1

    Dim ic As Double
    Dim Ve As Double
    Dim Vbase As Double
    Dim Vcol As Double
    Dim R = {1, 1.1, 1.2, 1.3, 1.5, 1.6, 1.8, 2, 2.2, 2.4, 2.7, 3, 3.3, 3.6, 3.9, 4.3, 4.7, 5.1, 5.6, 6.2, 6.8, 7.5, 8.2, 9.1}
    Dim k As Integer
    Dim flag As Integer = 0
    Dim diff As Double
    Dim mini As Double
    Dim R1_bis As Double
    Dim R2_bis As Double
    Dim R3_bis As Double
    Dim R4_bis As Double
    Sub calculs()
        R3.Text = Val(RL.Text) / 5 & " " & "Ω"
        R4.Text = Val(R3.Text) / Val(Gain.Text) & " " & "Ω"
        ic = ((Val(Vcc.Text) / 2) / (Val(R3.Text) + Val(R4.Text)))
        Ve = ic * Val(R4.Text)
        R2.Text = Math.Round((Val(Hfe.Text) * Val(R4.Text)) / 10, 2) & " " & "Ω"
        R1.Text = Math.Round(((Val(Vcc.Text) * Val(R2.Text)) / (Val(Vbe.Text) + Ve)) - Val(R2.Text), 2) & " " & "Ω"
        Ic1.Text = Math.Round(ic * 1000, 2) & " " & "mA"
        Ve1.Text = Math.Round(Ve, 2) & " " & "V"
        Vb.Text = Math.Round((Val(R2.Text) / (Val(R1.Text) + Val(R2.Text))) * Val(Vcc.Text), 2) & " " & "V"
        Vc.Text = Math.Round(ic * Val(R3.Text), 2) & " " & "V"
        Vce.Text = (Vcc.Text) - (ic * Val(R3.Text) + Ve) & " " & "V"
    End Sub

    Sub Calcul_R1()

        diff = Math.Abs(Math.Round(Val(R1.Text), 0) - R(0))
        mini = diff

        For k As Integer = 1 To 23
            diff = Math.Abs(Math.Round(Val(R1.Text), 0) - R(k))
            If diff <= mini Then
                mini = diff
                R1_bis = R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R1.Text), 0) - (10 * R(k)))
            If diff <= mini Then
                mini = diff
                R1_bis = 10 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R1.Text), 0) - (100 * R(k)))
            If diff <= mini Then
                mini = diff
                R1_bis = 100 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R1.Text), 0) - (1000 * R(k)))
            If diff <= mini Then
                mini = diff
                R1_bis = 1000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R1.Text), 0) - (10000 * R(k)))
            If diff <= mini Then
                mini = diff
                R1_bis = 10000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R1.Text), 0) - (100000 * R(k)))
            If diff <= mini Then
                mini = diff
                R1_bis = 100000 * R(k)
            End If
        Next

        If R1_bis >= 1000 Then
            R1.Text = R1_bis / 1000 & " " & "KΩ"
        Else
            R1.Text = R1_bis & " " & "Ω"
        End If

    End Sub

    Sub Calcul_R2()

        diff = Math.Abs(Math.Round(Val(R2.Text), 0) - R(0))
        mini = diff

        For k As Integer = 1 To 23
            diff = Math.Abs(Math.Round(Val(R2.Text), 0) - R(k))
            If diff <= mini Then
                mini = diff
                R2_bis = R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R2.Text), 0) - (10 * R(k)))
            If diff <= mini Then
                mini = diff
                R2_bis = 10 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R2.Text), 0) - (100 * R(k)))
            If diff <= mini Then
                mini = diff
                R2_bis = 100 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R2.Text), 0) - (1000 * R(k)))
            If diff <= mini Then
                mini = diff
                R2_bis = 1000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R2.Text), 0) - (10000 * R(k)))
            If diff <= mini Then
                mini = diff
                R2_bis = 10000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R2.Text), 0) - (100000 * R(k)))
            If diff <= mini Then
                mini = diff
                R2_bis = 100000 * R(k)
            End If
        Next

        If R2_bis >= 1000 Then
            R2.Text = R2_bis / 1000 & " " & "KΩ"
        Else
            R2.Text = R2_bis & " " & "Ω"
        End If

    End Sub

    Sub Calcul_R3()

        diff = Math.Abs(Math.Round(Val(R3.Text), 0) - R(0))
        mini = diff

        For k As Integer = 1 To 23
            diff = Math.Abs(Math.Round(Val(R3.Text), 0) - R(k))
            If diff <= mini Then
                mini = diff
                R3_bis = R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R3.Text), 0) - (10 * R(k)))
            If diff <= mini Then
                mini = diff
                R3_bis = 10 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R3.Text), 0) - (100 * R(k)))
            If diff <= mini Then
                mini = diff
                R3_bis = 100 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R3.Text), 0) - (1000 * R(k)))
            If diff <= mini Then
                mini = diff
                R3_bis = 1000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R3.Text), 0) - (10000 * R(k)))
            If diff <= mini Then
                mini = diff
                R3_bis = 10000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R3.Text), 0) - (100000 * R(k)))
            If diff <= mini Then
                mini = diff
                R3_bis = 100000 * R(k)
            End If
        Next

        If R3_bis >= 1000 Then
            R3.Text = R3_bis / 1000 & " " & "KΩ"
        Else
            R3.Text = R3_bis & " " & "Ω"
        End If

    End Sub

    Sub Calcul_R4()

        diff = Math.Abs(Math.Round(Val(R4.Text), 0) - R(0))
        mini = diff

        For k As Integer = 1 To 23
            diff = Math.Abs(Math.Round(Val(R4.Text), 0) - R(k))
            If diff <= mini Then
                mini = diff
                R4_bis = R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R4.Text), 0) - (10 * R(k)))
            If diff <= mini Then
                mini = diff
                R4_bis = 10 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R4.Text), 0) - (100 * R(k)))
            If diff <= mini Then
                mini = diff
                R4_bis = 100 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R4.Text), 0) - (1000 * R(k)))
            If diff <= mini Then
                mini = diff
                R4_bis = 1000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R4.Text), 0) - (10000 * R(k)))
            If diff <= mini Then
                mini = diff
                R4_bis = 10000 * R(k)
            End If
        Next

        For k As Integer = 0 To 23
            diff = Math.Abs(Math.Round(Val(R4.Text), 0) - (100000 * R(k)))
            If diff <= mini Then
                mini = diff
                R4_bis = 100000 * R(k)
            End If
        Next
        If R4_bis >= 1000 Then
            R4.Text = R4_bis / 1000 & " " & "KΩ"
        Else
            R4.Text = R4_bis & " " & "Ω"
        End If
    End Sub

    Sub calculs_tensions()
        Vbase = (R2_bis / (R1_bis + R2_bis)) * Val(Vcc.Text)
        Ve = Vbase - Val(Vbe.Text)
        Ic_vrai.Text = Math.Round(1000 * Ve / R4_bis, 2) & " " & "mA"
        Ve_vrai.Text = Math.Round(Ve, 2) & " " & "V"
        Vb_vrai.Text = Math.Round(Vbase, 2) & " " & "V"
        Vc_vrai.Text = Math.Round(R3_bis * Ve / R4_bis, 2) & " " & "V"
        Vce_vrai.Text = Math.Round(Val(Vcc.Text) - (R3_bis * Ve / R4_bis) - (Vbase - Val(Vbe.Text)), 2) & " " & "V"
        Vin_max.Text = Val(Vce_vrai.Text) * 0.8 / Val(Gain.Text) * 1000 & " " & "mV"
    End Sub


    Private Sub Gain_TextChanged(sender As Object, e As EventArgs) Handles Gain.TextChanged
        calculs()
        Calcul_R1()
        Calcul_R2()
        Calcul_R3()
        Calcul_R4()
        calculs_tensions()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vcc.Text = "12"
        Vbe.Text = "0.65"
        Hfe.Text = "110"
        RL.Text = "47000"
        Gain.Text = "10"
    End Sub

    Private Sub Vcc_TextChanged(sender As Object, e As EventArgs) Handles Vcc.TextChanged
        calculs()
        Calcul_R1()
        Calcul_R2()
        Calcul_R3()
        Calcul_R4()
        calculs_tensions()
    End Sub

    Private Sub Vbe_TextChanged(sender As Object, e As EventArgs) Handles Vbe.TextChanged
        calculs()
        Calcul_R1()
        Calcul_R2()
        Calcul_R3()
        Calcul_R4()
        calculs_tensions()
    End Sub

    Private Sub Hfe_TextChanged(sender As Object, e As EventArgs) Handles Hfe.TextChanged
        calculs()
        Calcul_R1()
        Calcul_R2()
        Calcul_R3()
        Calcul_R4()
        calculs_tensions()
    End Sub

    Private Sub RL_TextChanged(sender As Object, e As EventArgs) Handles RL.TextChanged
        calculs()
        Calcul_R1()
        Calcul_R2()
        Calcul_R3()
        Calcul_R4()
        calculs_tensions()
    End Sub
End Class
