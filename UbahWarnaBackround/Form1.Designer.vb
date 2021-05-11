<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GbBox = New System.Windows.Forms.GroupBox()
        Me.GbWarna = New System.Windows.Forms.GroupBox()
        Me.RdUngu = New System.Windows.Forms.RadioButton()
        Me.RdKuning = New System.Windows.Forms.RadioButton()
        Me.RdPutih = New System.Windows.Forms.RadioButton()
        Me.RdHijau = New System.Windows.Forms.RadioButton()
        Me.RdBiru = New System.Windows.Forms.RadioButton()
        Me.RdMerah = New System.Windows.Forms.RadioButton()
        Me.GbWarna.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbBox
        '
        Me.GbBox.BackgroundImage = Global.UbahWarnaBackround.My.Resources.Resources.gambar
        Me.GbBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GbBox.Location = New System.Drawing.Point(25, 13)
        Me.GbBox.Name = "GbBox"
        Me.GbBox.Size = New System.Drawing.Size(128, 166)
        Me.GbBox.TabIndex = 0
        Me.GbBox.TabStop = False
        Me.GbBox.Text = "Box Gambar"
        '
        'GbWarna
        '
        Me.GbWarna.Controls.Add(Me.RdUngu)
        Me.GbWarna.Controls.Add(Me.RdKuning)
        Me.GbWarna.Controls.Add(Me.RdPutih)
        Me.GbWarna.Controls.Add(Me.RdHijau)
        Me.GbWarna.Controls.Add(Me.RdBiru)
        Me.GbWarna.Controls.Add(Me.RdMerah)
        Me.GbWarna.Location = New System.Drawing.Point(183, 13)
        Me.GbWarna.Name = "GbWarna"
        Me.GbWarna.Size = New System.Drawing.Size(248, 166)
        Me.GbWarna.TabIndex = 1
        Me.GbWarna.TabStop = False
        Me.GbWarna.Text = "Kumpulan Warna"
        '
        'RdUngu
        '
        Me.RdUngu.AutoSize = True
        Me.RdUngu.Location = New System.Drawing.Point(148, 121)
        Me.RdUngu.Name = "RdUngu"
        Me.RdUngu.Size = New System.Drawing.Size(51, 17)
        Me.RdUngu.TabIndex = 11
        Me.RdUngu.TabStop = True
        Me.RdUngu.Text = "Ungu"
        Me.RdUngu.UseVisualStyleBackColor = True
        '
        'RdKuning
        '
        Me.RdKuning.AutoSize = True
        Me.RdKuning.Location = New System.Drawing.Point(24, 121)
        Me.RdKuning.Name = "RdKuning"
        Me.RdKuning.Size = New System.Drawing.Size(58, 17)
        Me.RdKuning.TabIndex = 10
        Me.RdKuning.TabStop = True
        Me.RdKuning.Text = "Kuning"
        Me.RdKuning.UseVisualStyleBackColor = True
        '
        'RdPutih
        '
        Me.RdPutih.AutoSize = True
        Me.RdPutih.Location = New System.Drawing.Point(148, 74)
        Me.RdPutih.Name = "RdPutih"
        Me.RdPutih.Size = New System.Drawing.Size(49, 17)
        Me.RdPutih.TabIndex = 9
        Me.RdPutih.TabStop = True
        Me.RdPutih.Text = "Putih"
        Me.RdPutih.UseVisualStyleBackColor = True
        '
        'RdHijau
        '
        Me.RdHijau.AutoSize = True
        Me.RdHijau.Location = New System.Drawing.Point(148, 29)
        Me.RdHijau.Name = "RdHijau"
        Me.RdHijau.Size = New System.Drawing.Size(49, 17)
        Me.RdHijau.TabIndex = 8
        Me.RdHijau.TabStop = True
        Me.RdHijau.Text = "Hijau"
        Me.RdHijau.UseVisualStyleBackColor = True
        '
        'RdBiru
        '
        Me.RdBiru.AutoSize = True
        Me.RdBiru.Location = New System.Drawing.Point(24, 74)
        Me.RdBiru.Name = "RdBiru"
        Me.RdBiru.Size = New System.Drawing.Size(43, 17)
        Me.RdBiru.TabIndex = 7
        Me.RdBiru.TabStop = True
        Me.RdBiru.Text = "Biru"
        Me.RdBiru.UseVisualStyleBackColor = True
        '
        'RdMerah
        '
        Me.RdMerah.AutoSize = True
        Me.RdMerah.Location = New System.Drawing.Point(24, 29)
        Me.RdMerah.Name = "RdMerah"
        Me.RdMerah.Size = New System.Drawing.Size(55, 17)
        Me.RdMerah.TabIndex = 6
        Me.RdMerah.TabStop = True
        Me.RdMerah.Text = "Merah"
        Me.RdMerah.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 191)
        Me.Controls.Add(Me.GbWarna)
        Me.Controls.Add(Me.GbBox)
        Me.Name = "Form1"
        Me.Text = "UbahWarnaBackground"
        Me.GbWarna.ResumeLayout(False)
        Me.GbWarna.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbBox As System.Windows.Forms.GroupBox
    Friend WithEvents GbWarna As System.Windows.Forms.GroupBox
    Friend WithEvents RdUngu As System.Windows.Forms.RadioButton
    Friend WithEvents RdKuning As System.Windows.Forms.RadioButton
    Friend WithEvents RdPutih As System.Windows.Forms.RadioButton
    Friend WithEvents RdHijau As System.Windows.Forms.RadioButton
    Friend WithEvents RdBiru As System.Windows.Forms.RadioButton
    Friend WithEvents RdMerah As System.Windows.Forms.RadioButton

End Class
