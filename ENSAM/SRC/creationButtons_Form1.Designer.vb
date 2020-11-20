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
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
    Me.Button1 = New System.Windows.Forms.Button
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
    Me.TextBox1 = New System.Windows.Forms.TextBox
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(515, 388)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(14, 13)
    Me.Label2.TabIndex = 9
    Me.Label2.Text = "Y"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(515, 349)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(14, 13)
    Me.Label1.TabIndex = 8
    Me.Label1.Text = "X"
    '
    'NumericUpDown2
    '
    Me.NumericUpDown2.Location = New System.Drawing.Point(536, 386)
    Me.NumericUpDown2.Name = "NumericUpDown2"
    Me.NumericUpDown2.Size = New System.Drawing.Size(61, 20)
    Me.NumericUpDown2.TabIndex = 7
    Me.NumericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(472, 412)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(148, 22)
    Me.Button1.TabIndex = 6
    Me.Button1.Text = "Create buttons"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Location = New System.Drawing.Point(536, 349)
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(61, 20)
    Me.NumericUpDown1.TabIndex = 5
    Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(472, 12)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(148, 326)
    Me.TextBox1.TabIndex = 10
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(632, 446)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.NumericUpDown2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.NumericUpDown1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
