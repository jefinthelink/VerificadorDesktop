<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicial
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
        LabelPropriedades = New Label()
        CheckBoxProgInstalados = New CheckBox()
        CheckBoxIpv4 = New CheckBox()
        ButtonGerarRelatorio = New Button()
        ButtonEnviaEmail = New Button()
        SuspendLayout()
        ' 
        ' LabelPropriedades
        ' 
        LabelPropriedades.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelPropriedades.AutoSize = True
        LabelPropriedades.Location = New Point(105, 9)
        LabelPropriedades.Name = "LabelPropriedades"
        LabelPropriedades.Size = New Size(76, 15)
        LabelPropriedades.TabIndex = 0
        LabelPropriedades.Text = "Propriedades"
        ' 
        ' CheckBoxProgInstalados
        ' 
        CheckBoxProgInstalados.AutoSize = True
        CheckBoxProgInstalados.Location = New Point(5, 70)
        CheckBoxProgInstalados.Name = "CheckBoxProgInstalados"
        CheckBoxProgInstalados.Size = New Size(195, 19)
        CheckBoxProgInstalados.TabIndex = 2
        CheckBoxProgInstalados.Text = "Comparar programas instalados"
        CheckBoxProgInstalados.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxIpv4
        ' 
        CheckBoxIpv4.AutoSize = True
        CheckBoxIpv4.Location = New Point(5, 95)
        CheckBoxIpv4.Name = "CheckBoxIpv4"
        CheckBoxIpv4.Size = New Size(93, 19)
        CheckBoxIpv4.TabIndex = 3
        CheckBoxIpv4.Text = "verificar ipv4"
        CheckBoxIpv4.UseVisualStyleBackColor = True
        ' 
        ' ButtonGerarRelatorio
        ' 
        ButtonGerarRelatorio.Location = New Point(12, 415)
        ButtonGerarRelatorio.Name = "ButtonGerarRelatorio"
        ButtonGerarRelatorio.Size = New Size(109, 23)
        ButtonGerarRelatorio.TabIndex = 4
        ButtonGerarRelatorio.Text = "Gerar relatório"
        ButtonGerarRelatorio.UseVisualStyleBackColor = True
        ' 
        ' ButtonEnviaEmail
        ' 
        ButtonEnviaEmail.Enabled = False
        ButtonEnviaEmail.Location = New Point(176, 415)
        ButtonEnviaEmail.Name = "ButtonEnviaEmail"
        ButtonEnviaEmail.Size = New Size(109, 23)
        ButtonEnviaEmail.TabIndex = 5
        ButtonEnviaEmail.Text = "Enviar por e-mail"
        ButtonEnviaEmail.UseVisualStyleBackColor = True
        ' 
        ' FormInicial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(297, 450)
        Controls.Add(ButtonEnviaEmail)
        Controls.Add(ButtonGerarRelatorio)
        Controls.Add(CheckBoxIpv4)
        Controls.Add(CheckBoxProgInstalados)
        Controls.Add(LabelPropriedades)
        Name = "FormInicial"
        Text = "Relatorio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelPropriedades As Label
    Friend WithEvents CheckBoxProgInstalados As CheckBox
    Friend WithEvents CheckBoxIpv4 As CheckBox
    Friend WithEvents ButtonGerarRelatorio As Button
    Friend WithEvents ButtonEnviaEmail As Button

End Class
