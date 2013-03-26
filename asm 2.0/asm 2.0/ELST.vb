Public Class ELST

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox1.Visible = True
        'If ComboBox1.SelectedItem = "E21" Then
        '    PictureBox1.Image = My.Resources.Е21
        'End If
        'If ComboBox1.SelectedItem = "E31" Then
        '    PictureBox1.Image = My.Resources.Е31
        'End If

        Select Case ComboBox1.SelectedItem 'More info:http://msdn.microsoft.com/en-us/library/cy37t14y.aspx
            Case "E21" 'from ELST.inf
                PictureBox1.Image = My.Resources.Е21
            Case "E31"
                PictureBox1.Image = My.Resources.Е31
        End Select
    End Sub

    Private Sub ELST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("E21")
        ComboBox1.Items.Add("E31")
    End Sub
End Class