Public Class Form1
  Public buttonHorizontalNumber As Integer
  Public buttonVerticalNumber As Integer
  Public buttonNumber As Integer
  Public buttons() As System.Windows.Forms.Button

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.buttonHorizontalNumber = 0
    Me.buttonVerticalNumber = 0
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim i, x, y As Integer
    Dim size As Integer = 30

    'enlever les buttons depuis la Form
    Me.buttonNumber = Me.buttonHorizontalNumber * Me.buttonVerticalNumber
    For i = 0 To buttonNumber - 1 Step 1
      Me.Controls.Remove(buttons(i))
    Next i

    'recuperer le nombre des buttons a creer
    Me.buttonHorizontalNumber = Me.NumericUpDown1.Value
    Me.buttonVerticalNumber = Me.NumericUpDown2.Value

    'ajouter les buttons sur la Form
    Me.buttonNumber = Me.buttonHorizontalNumber * Me.buttonVerticalNumber
    Array.Resize(Me.buttons, buttonNumber)
    For i = 0 To buttonNumber - 1 Step 1
      buttons(i) = New System.Windows.Forms.Button()
      Me.Controls.Add(buttons(i))
      x = (i Mod buttonHorizontalNumber) * size
      y = (i \ buttonHorizontalNumber) * size
      Me.buttons(i).Location = New System.Drawing.Point(x, y)
      Me.buttons(i).Size = New System.Drawing.Size(size, size)
      Me.buttons(i).Text = i
      'ici je specifie l'action lors du click
      AddHandler Me.buttons(i).Click, AddressOf myClickEvent
    Next i
    Me.PerformLayout()
  End Sub

  'ici c'est l'action que je detaille
  Private Sub myClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim msgHearder = "System.Windows.Forms.Button, Text:"
    Dim buttonText As String
    Dim buttonNo As Integer
    Dim i As Integer

    Dim button As Button = CType(sender, Button)

    For i = 0 To Me.buttonNumber - 1 Step 1
      If Me.buttons(i).TabIndex = button.TabIndex Then
        TextBox1.Text += "text: " & button.Text & "  index: " & button.TabIndex & vbCrLf
        Exit For
      End If
    Next

    'TextBox1.Text += "test: " & button.Text



    'buttonText = sender.ToString
    'For i = 0 To msgHearder.Length - 1
    '  buttonText = buttonText.Trim(msgHearder(i))
    'Next

    'If IsNumeric(buttonText) Then
    '  buttonNo = CInt(buttonText)
    'Else
    '  MsgBox("Error: the clicked button's text is not numeric: " & buttonText)
    '  Exit Sub
    'End If

    'TextBox1.Text += "button: " & buttonNo \ buttonHorizontalNumber & ", " & buttonNo Mod buttonHorizontalNumber & vbCrLf

  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub
End Class
