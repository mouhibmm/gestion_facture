<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gestion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_gestion))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_produit = New ComboBox()
        txt_prixu = New TextBox()
        txt_quantite = New TextBox()
        txt_montant = New TextBox()
        btn_ajouter = New Button()
        btn_supprimer = New Button()
        btn_vider = New Button()
        btn_modifier = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lst_p = New ListBox()
        lst_pu = New ListBox()
        lst_q = New ListBox()
        lst_m = New ListBox()
        btn_total = New Label()
        txt_tpu = New TextBox()
        txt_tq = New TextBox()
        txt_tm = New TextBox()
        btn_tva = New Label()
        txt_tva = New TextBox()
        txt_remise = New TextBox()
        btn_remise = New Label()
        btn_calcul = New Button()
        btn_quitter = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(98, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 25)
        Label1.TabIndex = 0
        Label1.Text = "Produit :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(98, 60)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 25)
        Label2.TabIndex = 1
        Label2.Text = "Prix Unitaire :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(98, 100)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 2
        Label3.Text = "Quantite :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(100, 141)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 3
        Label4.Text = "Montant HT :"
        ' 
        ' txt_produit
        ' 
        txt_produit.FormattingEnabled = True
        txt_produit.Items.AddRange(New Object() {"ordinateur", "clavier", "souris", "imprimante"})
        txt_produit.Location = New Point(432, 12)
        txt_produit.Margin = New Padding(4)
        txt_produit.Name = "txt_produit"
        txt_produit.Size = New Size(206, 31)
        txt_produit.TabIndex = 4
        ' 
        ' txt_prixu
        ' 
        txt_prixu.Location = New Point(432, 57)
        txt_prixu.Margin = New Padding(4)
        txt_prixu.Name = "txt_prixu"
        txt_prixu.Size = New Size(206, 30)
        txt_prixu.TabIndex = 5
        ' 
        ' txt_quantite
        ' 
        txt_quantite.Location = New Point(432, 95)
        txt_quantite.Margin = New Padding(4)
        txt_quantite.Name = "txt_quantite"
        txt_quantite.Size = New Size(206, 30)
        txt_quantite.TabIndex = 6
        ' 
        ' txt_montant
        ' 
        txt_montant.Location = New Point(432, 141)
        txt_montant.Margin = New Padding(4)
        txt_montant.Name = "txt_montant"
        txt_montant.Size = New Size(206, 30)
        txt_montant.TabIndex = 7
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Location = New Point(820, 18)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(106, 36)
        btn_ajouter.TabIndex = 8
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' btn_supprimer
        ' 
        btn_supprimer.Location = New Point(820, 60)
        btn_supprimer.Name = "btn_supprimer"
        btn_supprimer.Size = New Size(106, 39)
        btn_supprimer.TabIndex = 9
        btn_supprimer.Text = "Supprimer"
        btn_supprimer.UseVisualStyleBackColor = True
        ' 
        ' btn_vider
        ' 
        btn_vider.Location = New Point(820, 105)
        btn_vider.Name = "btn_vider"
        btn_vider.Size = New Size(106, 35)
        btn_vider.TabIndex = 10
        btn_vider.Text = "Vider"
        btn_vider.UseVisualStyleBackColor = True
        ' 
        ' btn_modifier
        ' 
        btn_modifier.Location = New Point(820, 155)
        btn_modifier.Name = "btn_modifier"
        btn_modifier.Size = New Size(106, 38)
        btn_modifier.TabIndex = 11
        btn_modifier.Text = "modifier"
        btn_modifier.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(98, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 25)
        Label5.TabIndex = 12
        Label5.Text = "Produit"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(301, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 25)
        Label6.TabIndex = 13
        Label6.Text = "Prix Unitaire"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(505, 209)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 25)
        Label7.TabIndex = 14
        Label7.Text = "Quantité"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(697, 209)
        Label8.Name = "Label8"
        Label8.Size = New Size(116, 25)
        Label8.TabIndex = 15
        Label8.Text = "Montant HT"
        ' 
        ' lst_p
        ' 
        lst_p.FormattingEnabled = True
        lst_p.ItemHeight = 23
        lst_p.Location = New Point(87, 252)
        lst_p.Name = "lst_p"
        lst_p.Size = New Size(139, 211)
        lst_p.TabIndex = 16
        ' 
        ' lst_pu
        ' 
        lst_pu.FormattingEnabled = True
        lst_pu.ItemHeight = 23
        lst_pu.Location = New Point(277, 252)
        lst_pu.Name = "lst_pu"
        lst_pu.Size = New Size(145, 211)
        lst_pu.TabIndex = 17
        ' 
        ' lst_q
        ' 
        lst_q.FormattingEnabled = True
        lst_q.ItemHeight = 23
        lst_q.Location = New Point(472, 252)
        lst_q.Name = "lst_q"
        lst_q.Size = New Size(145, 211)
        lst_q.TabIndex = 18
        ' 
        ' lst_m
        ' 
        lst_m.FormattingEnabled = True
        lst_m.ItemHeight = 23
        lst_m.Location = New Point(683, 252)
        lst_m.Name = "lst_m"
        lst_m.Size = New Size(145, 211)
        lst_m.TabIndex = 19
        ' 
        ' btn_total
        ' 
        btn_total.AutoSize = True
        btn_total.Location = New Point(162, 507)
        btn_total.Name = "btn_total"
        btn_total.Size = New Size(64, 25)
        btn_total.TabIndex = 20
        btn_total.Text = "Total :"
        ' 
        ' txt_tpu
        ' 
        txt_tpu.Location = New Point(277, 502)
        txt_tpu.Name = "txt_tpu"
        txt_tpu.Size = New Size(145, 30)
        txt_tpu.TabIndex = 21
        ' 
        ' txt_tq
        ' 
        txt_tq.Location = New Point(472, 502)
        txt_tq.Name = "txt_tq"
        txt_tq.Size = New Size(145, 30)
        txt_tq.TabIndex = 22
        ' 
        ' txt_tm
        ' 
        txt_tm.Location = New Point(683, 502)
        txt_tm.Name = "txt_tm"
        txt_tm.Size = New Size(145, 30)
        txt_tm.TabIndex = 23
        ' 
        ' btn_tva
        ' 
        btn_tva.AutoSize = True
        btn_tva.Location = New Point(720, 565)
        btn_tva.Name = "btn_tva"
        btn_tva.Size = New Size(108, 25)
        btn_tva.TabIndex = 24
        btn_tva.Text = "TVA(20%) :"
        ' 
        ' txt_tva
        ' 
        txt_tva.Location = New Point(882, 562)
        txt_tva.Name = "txt_tva"
        txt_tva.Size = New Size(324, 30)
        txt_tva.TabIndex = 25
        ' 
        ' txt_remise
        ' 
        txt_remise.Location = New Point(882, 608)
        txt_remise.Name = "txt_remise"
        txt_remise.Size = New Size(324, 30)
        txt_remise.TabIndex = 26
        ' 
        ' btn_remise
        ' 
        btn_remise.AutoSize = True
        btn_remise.Location = New Point(735, 613)
        btn_remise.Name = "btn_remise"
        btn_remise.Size = New Size(93, 25)
        btn_remise.TabIndex = 27
        btn_remise.Text = "  Remise :"
        ' 
        ' btn_calcul
        ' 
        btn_calcul.Location = New Point(882, 668)
        btn_calcul.Name = "btn_calcul"
        btn_calcul.Size = New Size(145, 41)
        btn_calcul.TabIndex = 28
        btn_calcul.Text = "Calculer"
        btn_calcul.UseVisualStyleBackColor = True
        ' 
        ' btn_quitter
        ' 
        btn_quitter.Location = New Point(1064, 668)
        btn_quitter.Name = "btn_quitter"
        btn_quitter.Size = New Size(145, 41)
        btn_quitter.TabIndex = 29
        btn_quitter.Text = "Quitter"
        btn_quitter.UseVisualStyleBackColor = True
        ' 
        ' frm_gestion
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1221, 709)
        Controls.Add(btn_quitter)
        Controls.Add(btn_calcul)
        Controls.Add(btn_remise)
        Controls.Add(txt_remise)
        Controls.Add(txt_tva)
        Controls.Add(btn_tva)
        Controls.Add(txt_tm)
        Controls.Add(txt_tq)
        Controls.Add(txt_tpu)
        Controls.Add(btn_total)
        Controls.Add(lst_m)
        Controls.Add(lst_q)
        Controls.Add(lst_pu)
        Controls.Add(lst_p)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btn_modifier)
        Controls.Add(btn_vider)
        Controls.Add(btn_supprimer)
        Controls.Add(btn_ajouter)
        Controls.Add(txt_montant)
        Controls.Add(txt_quantite)
        Controls.Add(txt_prixu)
        Controls.Add(txt_produit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "frm_gestion"
        Text = "frm_gestion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_produit As ComboBox
    Friend WithEvents txt_prixu As TextBox
    Friend WithEvents txt_quantite As TextBox
    Friend WithEvents txt_montant As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_vider As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents List1 As ListBox
    Friend WithEvents List2 As ListBox
    Friend WithEvents List3 As ListBox
    Friend WithEvents List4 As ListBox
    Friend WithEvents btn_total As Label
    Friend WithEvents txt_tpu As TextBox
    Friend WithEvents txt_tq As TextBox
    Friend WithEvents txt_tm As TextBox
    Friend WithEvents btn_tva As Label
    Friend WithEvents txt_tva As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents btn_remise As Label
    Friend WithEvents btn_calcul As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents lst_p As ListBox
    Friend WithEvents lst_pu As ListBox
    Friend WithEvents lst_q As ListBox
    Friend WithEvents lst_m As ListBox
End Class
