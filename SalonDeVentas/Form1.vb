Public Class Form1
    Dim evento As New EVENTO()
    Dim full As New FULL()
    Dim catering As New CATERING()
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If (rbEvento.Checked = True) Then
            If chMozos.Checked = True Then
                If rbViernes.Checked = True Then
                    evento = New EVENTO(txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "V")
                End If
                If rbSabado.Checked = True Then
                    evento = New EVENTO(txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "S")
                End If
                If rbDomingo.Checked = True Then
                    evento = New EVENTO(txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "D")
                End If
            Else
                If rbViernes.Checked = True Then
                    evento = New EVENTO(txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "V")
                End If
                If rbSabado.Checked = True Then
                    evento = New EVENTO(txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "S")
                End If
                If rbDomingo.Checked = True Then
                    evento = New EVENTO(txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "D")
                End If
            End If
            lbDatos.Items.Add(evento.Datos())
        End If
        If (rbCatering.Checked = True) Then
            If (rbBasico.Checked = True) Then
                If chMozos.Checked = True Then
                    If rbViernes.Checked = True Then
                        catering = New CATERING("B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "V")
                    End If
                    If rbSabado.Checked = True Then
                        catering = New CATERING("B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        catering = New CATERING("B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "D")
                    End If
                Else
                    If rbViernes.Checked = True Then
                        catering = New CATERING("B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "V")
                    End If
                    If rbSabado.Checked = True Then
                        catering = New CATERING("B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        catering = New CATERING("B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "D")
                    End If
                End If
            End If
            If (rbPremium.Checked = True) Then
                If chMozos.Checked = True Then
                    If rbViernes.Checked = True Then
                        catering = New CATERING("P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "V")
                    End If
                    If rbSabado.Checked = True Then
                        catering = New CATERING("P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        catering = New CATERING("P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "D")
                    End If
                Else
                    If rbViernes.Checked = True Then
                        catering = New CATERING("P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "V")
                    End If
                    If rbSabado.Checked = True Then
                        catering = New CATERING("P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        catering = New CATERING("P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "D")
                    End If
                End If
            End If

            lbDatos.Items.Add(catering.Datos())
        End If
        If (rbFull.Checked = True) Then
            If (rbBasico.Checked = True) Then
                If chMozos.Checked = True Then
                    If rbViernes.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "V")
                    End If
                    If rbSabado.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "D")
                    End If
                Else
                    If rbViernes.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "V")
                    End If
                    If rbSabado.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "B", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "D")
                    End If
                End If
            End If
            If (rbPremium.Checked = True) Then
                If chMozos.Checked = True Then
                    If rbViernes.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "V")
                    End If
                    If rbSabado.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), True, "D")
                    End If
                Else
                    If rbViernes.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "V")
                    End If
                    If rbSabado.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "S")
                    End If
                    If rbDomingo.Checked = True Then
                        full = New FULL(Val(txtAnim.Text), "P", txtNombre.Text, Val(txtInvi.Text), Val(txtHoras.Text), False, "D")
                    End If
                End If
            End If
            lbDatos.Items.Add(full.Datos())
        End If

    End Sub

    Private Sub rbEvento_CheckedChanged(sender As Object, e As EventArgs) Handles rbEvento.CheckedChanged
        If (rbEvento.Checked = True) Then
            rbBasico.Enabled = False
            rbPremium.Enabled = False
            txtAnim.Enabled = False
        End If
        If (rbEvento.Checked = False) Then
            rbBasico.Enabled = True
            rbPremium.Enabled = True
            txtAnim.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lbDatos.Items.Clear()
    End Sub

    Private Sub lbDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDatos.SelectedIndexChanged

    End Sub
End Class
