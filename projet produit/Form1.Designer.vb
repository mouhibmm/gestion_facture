<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_login = New TextBox()
        txt_pw = New TextBox()
        btn_valider = New Button()
        bnt_annuler = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txt_login
        ' 
        txt_login.Location = New Point(146, 481)
        txt_login.Multiline = True
        txt_login.Name = "txt_login"
        txt_login.PlaceholderText = "  Nom d'utilisateur "
        txt_login.Size = New Size(287, 31)
        txt_login.TabIndex = 2
        ' 
        ' txt_pw
        ' 
        txt_pw.Location = New Point(146, 562)
        txt_pw.Multiline = True
        txt_pw.Name = "txt_pw"
        txt_pw.PasswordChar = "*"c
        txt_pw.PlaceholderText = "  Mot de passe "
        txt_pw.Size = New Size(287, 32)
        txt_pw.TabIndex = 3
        ' 
        ' btn_valider
        ' 
        btn_valider.BackgroundImageLayout = ImageLayout.Center
        btn_valider.ForeColor = SystemColors.ActiveCaptionText
        btn_valider.Location = New Point(305, 615)
        btn_valider.Name = "btn_valider"
        btn_valider.Size = New Size(151, 44)
        btn_valider.TabIndex = 4
        btn_valider.Text = "valider"
        btn_valider.UseVisualStyleBackColor = True
        ' 
        ' bnt_annuler
        ' 
        bnt_annuler.ForeColor = SystemColors.ActiveCaptionText
        bnt_annuler.Location = New Point(130, 615)
        bnt_annuler.Name = "bnt_annuler"
        bnt_annuler.Size = New Size(137, 44)
        bnt_annuler.TabIndex = 5
        bnt_annuler.Text = "annuler"
        bnt_annuler.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Felix Titling", 20.0347824F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(218, 278)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 38)
        Label1.TabIndex = 6
        Label1.Text = "Log In"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(587, 671)
        Controls.Add(Label1)
        Controls.Add(bnt_annuler)
        Controls.Add(btn_valider)
        Controls.Add(txt_pw)
        Controls.Add(txt_login)
        ForeColor = SystemColors.ControlLight
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_pw As TextBox
    Friend WithEvents btn_valider As Button
    Friend WithEvents bnt_annuler As Button
    Friend WithEvents Label1 As Label

End Class
