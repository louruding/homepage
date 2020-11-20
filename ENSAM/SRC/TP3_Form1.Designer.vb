<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.plan00 = New System.Windows.Forms.Button
        Me.plan10 = New System.Windows.Forms.Button
        Me.plan11 = New System.Windows.Forms.Button
        Me.plan01 = New System.Windows.Forms.Button
        Me.plan12 = New System.Windows.Forms.Button
        Me.plan02 = New System.Windows.Forms.Button
        Me.plan22 = New System.Windows.Forms.Button
        Me.plan21 = New System.Windows.Forms.Button
        Me.plan20 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "0"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "auto incrémentation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 69)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "incrémentation/décrémentation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(192, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 34)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "+ +"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 34)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "- -"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 170)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "gauche / droite / haut / bas"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(110, 130)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 34)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "v"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(110, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 34)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "^"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "O"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 34)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(25, 69)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 34)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'plan00
        '
        Me.plan00.Location = New System.Drawing.Point(14, 52)
        Me.plan00.Name = "plan00"
        Me.plan00.Size = New System.Drawing.Size(20, 20)
        Me.plan00.TabIndex = 4
        Me.plan00.Text = "X"
        Me.plan00.UseVisualStyleBackColor = True
        '
        'plan10
        '
        Me.plan10.Location = New System.Drawing.Point(14, 78)
        Me.plan10.Name = "plan10"
        Me.plan10.Size = New System.Drawing.Size(20, 20)
        Me.plan10.TabIndex = 5
        Me.plan10.Text = "X"
        Me.plan10.UseVisualStyleBackColor = True
        '
        'plan11
        '
        Me.plan11.Location = New System.Drawing.Point(40, 78)
        Me.plan11.Name = "plan11"
        Me.plan11.Size = New System.Drawing.Size(20, 20)
        Me.plan11.TabIndex = 9
        Me.plan11.Text = "X"
        Me.plan11.UseVisualStyleBackColor = True
        '
        'plan01
        '
        Me.plan01.Location = New System.Drawing.Point(40, 52)
        Me.plan01.Name = "plan01"
        Me.plan01.Size = New System.Drawing.Size(20, 20)
        Me.plan01.TabIndex = 8
        Me.plan01.Text = "X"
        Me.plan01.UseVisualStyleBackColor = True
        '
        'plan12
        '
        Me.plan12.Location = New System.Drawing.Point(66, 78)
        Me.plan12.Name = "plan12"
        Me.plan12.Size = New System.Drawing.Size(20, 20)
        Me.plan12.TabIndex = 22
        Me.plan12.Text = "X"
        Me.plan12.UseVisualStyleBackColor = True
        '
        'plan02
        '
        Me.plan02.Location = New System.Drawing.Point(66, 52)
        Me.plan02.Name = "plan02"
        Me.plan02.Size = New System.Drawing.Size(20, 20)
        Me.plan02.TabIndex = 21
        Me.plan02.Text = "X"
        Me.plan02.UseVisualStyleBackColor = True
        '
        'plan22
        '
        Me.plan22.Location = New System.Drawing.Point(66, 104)
        Me.plan22.Name = "plan22"
        Me.plan22.Size = New System.Drawing.Size(20, 20)
        Me.plan22.TabIndex = 25
        Me.plan22.Text = "X"
        Me.plan22.UseVisualStyleBackColor = True
        '
        'plan21
        '
        Me.plan21.Location = New System.Drawing.Point(40, 104)
        Me.plan21.Name = "plan21"
        Me.plan21.Size = New System.Drawing.Size(20, 20)
        Me.plan21.TabIndex = 24
        Me.plan21.Text = "X"
        Me.plan21.UseVisualStyleBackColor = True
        '
        'plan20
        '
        Me.plan20.Location = New System.Drawing.Point(14, 104)
        Me.plan20.Name = "plan20"
        Me.plan20.Size = New System.Drawing.Size(20, 20)
        Me.plan20.TabIndex = 23
        Me.plan20.Text = "X"
        Me.plan20.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.plan22)
        Me.GroupBox4.Controls.Add(Me.plan21)
        Me.GroupBox4.Controls.Add(Me.plan20)
        Me.GroupBox4.Controls.Add(Me.plan12)
        Me.GroupBox4.Controls.Add(Me.plan02)
        Me.GroupBox4.Controls.Add(Me.plan11)
        Me.GroupBox4.Controls.Add(Me.plan01)
        Me.GroupBox4.Controls.Add(Me.plan10)
        Me.GroupBox4.Controls.Add(Me.plan00)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 386)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(277, 138)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "la meme procedure d'evenement"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 53)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(157, 71)
        Me.TextBox1.TabIndex = 27
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(104, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(114, 23)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "affectation_function"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 532)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents plan00 As System.Windows.Forms.Button
    Friend WithEvents plan10 As System.Windows.Forms.Button
    Friend WithEvents plan11 As System.Windows.Forms.Button
    Friend WithEvents plan01 As System.Windows.Forms.Button
    Friend WithEvents plan12 As System.Windows.Forms.Button
    Friend WithEvents plan02 As System.Windows.Forms.Button
    Friend WithEvents plan22 As System.Windows.Forms.Button
    Friend WithEvents plan21 As System.Windows.Forms.Button
    Friend WithEvents plan20 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
