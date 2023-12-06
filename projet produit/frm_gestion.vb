Imports System.Configuration
Imports System.Runtime.InteropServices
Imports System.Web

Public Class frm_gestion
    Private Sub frm_gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_produit.SelectedIndexChanged
        If txt_produit.SelectedItem = "ordinateur" Then
            txt_prixu.Text = 1000
        ElseIf txt_produit.SelectedItem = "clavier" Then
            txt_prixu.Text = 30
        ElseIf txt_produit.SelectedItem = "imprimante" Then
            txt_prixu.Text = 500
        ElseIf txt_produit.SelectedItem = "souris" Then
            txt_prixu.Text = 15
        End If
    End Sub

    Private Sub txt_quantite_TextChanged(sender As Object, e As EventArgs) Handles txt_quantite.TextChanged
        Dim prix As Integer = Val(txt_prixu.Text)
        Dim quantite As Integer = Val(txt_quantite.Text)
        Dim mont As Integer = prix * quantite
        txt_montant.Text = mont.ToString()

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If txt_quantite.Text < 1 Then
            MessageBox.Show("txt_quantite invalide")
            txt_quantite.Clear()
        Else
            lst_p.Items.Add(txt_produit.SelectedItem())
            lst_pu.Items.Add(txt_prixu.Text)
            lst_q.Items.Add(txt_quantite.Text)
            lst_m.Items.Add(txt_montant.Text)
            txt_produit.SelectedIndex = -1
            txt_prixu.Clear()
            txt_quantite.Clear()
            txt_montant.Clear()

        End If
    End Sub

    Private Sub btn_vider_Click(sender As Object, e As EventArgs) Handles btn_vider.Click
        txt_produit.SelectedIndex = -1
        txt_prixu.Clear()
        txt_quantite.Clear()
        txt_montant.Clear()
        txt_tpu.Clear()
        txt_tq.Clear()
        txt_tm.Clear()
        txt_tva.Clear()
        txt_remise.Clear()
        lst_pu.Items.Clear()
        lst_p.Items.Clear()
        lst_m.Items.Clear()
        lst_q.Items.Clear()
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim selected As Integer = lst_p.SelectedIndex
        lst_p.Items.RemoveAt(selected)
        lst_pu.Items.RemoveAt(selected)
        lst_q.Items.RemoveAt(selected)
        lst_m.Items.RemoveAt(selected)
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Dim modfiQ As String = InputBox("saisir une quantite pour modifier:")
        If (lst_q.SelectedIndex > -1) Then
            lst_q.Items(lst_q.SelectedIndex) = modfiQ
            lst_m.Items(lst_q.SelectedIndex) = Val(modfiQ) * Val(lst_pu.Items(lst_q.SelectedIndex))
        End If

    End Sub

    Private Sub btn_calcul_Click(sender As Object, e As EventArgs) Handles btn_calcul.Click
        Dim sompro As Integer = 0
        For Each item As Object In lst_pu.Items
            If IsNumeric(item.ToString()) Then
                sompro += Val(item.ToString())
            End If
        Next
        txt_tpu.Text = sompro.ToString()

        Dim somqu As Integer = 0
        For Each item As Object In lst_q.Items
            If IsNumeric(item.ToString()) Then
                somqu += Val(item.ToString())
            End If
        Next
        txt_tq.Text = somqu.ToString()

        Dim sommt As Integer = 0
        For Each item As Object In lst_m.Items
            If IsNumeric(item.ToString()) Then
                sommt += Val(item.ToString())
            End If
        Next
        txt_tm.Text = sommt.ToString()

        Dim totalmont As Integer = Val(txt_tm.Text)
        Dim tva As Double = Val(txt_tva.Text)
        tva = totalmont * 1.2
        txt_tva.Text = tva.ToString()

        Dim remise As Double = Val(txt_remise.Text)
        If (totalmont > 1000) Then
            remise = tva - (tva * 0.01)
        Else
            remise = totalmont
        End If
        txt_remise.Text = remise.ToString()

    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
    End Sub

    Private Sub txt_remise_TextChanged(sender As Object, e As EventArgs) Handles txt_remise.TextChanged

    End Sub
End Class