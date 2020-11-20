Public Class Form1
    Dim boutons(3, 3) As Button

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text += 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text -= 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text += 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label2.Left -= 3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label2.Left += 3
        'attention: Label2.Right is protected
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label2.Top -= 3
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Label2.Top += 3
        'attention: Label2.Bottom is protected   
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        boutons(0, 0) = plan00
        boutons(0, 1) = plan01
        boutons(0, 2) = plan02
        boutons(1, 0) = plan10
        boutons(1, 1) = plan11
        boutons(1, 2) = plan12
        boutons(2, 0) = plan20
        boutons(2, 1) = plan21
        boutons(2, 2) = plan22
        Dim i, j As Integer
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                'Associe une procédure (qui gère l'evenement) à l'evenement de Click au moment de l'execution.
                AddHandler boutons(i, j).Click, AddressOf positionDuBouton
            Next j
        Next i
    End Sub

    Private Sub positionDuBouton(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim boutonClique As Button
        If TypeOf sender Is Button Then
            boutonClique = CType(sender, Windows.Forms.Button)
            If Strings.Left(boutonClique.Name, 4) = "plan" Then
                TextBox1.Text &= Strings.Right(boutonClique.Name, 2) & vbNewLine
                'defiler vers le bas
                TextBox1.SelectionStart = TextBox1.Text.Length
                TextBox1.ScrollToCaret()
            End If
        End If
    End Sub
End Class
