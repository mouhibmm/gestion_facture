Public Class Form1
    Private Sub init()
        txt_login.Clear()
        txt_pw.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_login.Text
        pw = txt_pw.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_gestion.Show()
        Else
            init()

        End If
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_login_TextChanged(sender As Object, e As EventArgs) Handles txt_login.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub bnt_annuler_Click(sender As Object, e As EventArgs) Handles bnt_annuler.Click
        Me.Close()

    End Sub
End Class

