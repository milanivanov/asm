Public Class Form1
    Dim p2r, p, v1r As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If neccessary
        ComboBox1.Items.Add("1 - крушовиден, закръглен долу (при шлица)")
        ComboBox1.Items.Add("2 - крушовиден, скосен долу")
        ComboBox1.Items.Add("3 - трапецовиден, закръглен долу")
        ComboBox1.Items.Add("4 - трапецовиден, скосен долу")
        ComboBox1.Items.Add("5 - правоъгълен, полуотворен")
        ComboBox1.Items.Add("6 - правоъгълен, отворен")
        ComboBox2.Items.Add("1 - крушовиден, закръглен горе(при шлица)")
        ComboBox2.Items.Add("2 - крушовиден, скосен горе")
        ComboBox2.Items.Add("3 - трапецовиден, скосен горе")
        ComboBox2.Items.Add("4 - правоъгълен, скосен горе")
        ComboBox2.Items.Add("5 - кръгъл")
        ComboBox2.Items.Add("6 - двоен кафез, горе кръгъл, долу круша")
        ComboBox2.Items.Add("7 - двоен кафез, горе закръглен, долу отрязана ")
        ComboBox2.Items.Add("8 - двоен кафез, горе трапец, долу трапец,скосен горе")
        ComboBox3.Items.Add("E21")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Label2.Text = ComboBox1.SelectedItem
        If ComboBox1.SelectedItem = "1 - крушовиден, закръглен долу (при шлица)" Then
            TextBox20.ReadOnly = False
            TextBox19.ReadOnly = False
            TextBox18.ReadOnly = False
            TextBox17.ReadOnly = False
            TextBox27.ReadOnly = False
            TextBox31.ReadOnly = False
            TextBox32.ReadOnly = False

            TextBox30.ReadOnly = True
            TextBox29.ReadOnly = True
            TextBox28.ReadOnly = True
        End If
        If ComboBox1.SelectedItem = "2 - крушовиден, скосен долу" Then
            TextBox20.ReadOnly = False
            TextBox19.ReadOnly = False
            TextBox18.ReadOnly = False
            TextBox17.ReadOnly = False
            TextBox27.ReadOnly = False
            TextBox30.ReadOnly = False
            TextBox31.ReadOnly = False
            TextBox32.ReadOnly = False


        End If
        If ComboBox1.SelectedItem = "3 - трапецовиден, закръглен долу" Then
            TextBox20.ReadOnly = False
            TextBox19.ReadOnly = False
            TextBox18.ReadOnly = False
            TextBox17.ReadOnly = False
            TextBox27.ReadOnly = False
            TextBox30.ReadOnly = False
            TextBox31.ReadOnly = False
            TextBox32.ReadOnly = False

        End If
        If ComboBox1.SelectedItem = "4 - трапецовиден, скосен долу" Then
            TextBox20.ReadOnly = False
            TextBox19.ReadOnly = False
            TextBox18.ReadOnly = False
            TextBox17.ReadOnly = False
            TextBox27.ReadOnly = False
            TextBox30.ReadOnly = False
            TextBox31.ReadOnly = False
            TextBox32.ReadOnly = False

        End If
        If ComboBox1.SelectedItem = "5 - правоъгълен, полуотворен" Then
            TextBox20.ReadOnly = False
            TextBox19.ReadOnly = False
            TextBox18.ReadOnly = False
            TextBox17.ReadOnly = False
            TextBox27.ReadOnly = False
            TextBox30.ReadOnly = False
            TextBox31.ReadOnly = False
            TextBox32.ReadOnly = False

        End If
        If ComboBox1.SelectedItem = "6 - правоъгълен, отворен" Then
            TextBox20.ReadOnly = False
            TextBox19.ReadOnly = False
            TextBox18.ReadOnly = False
            TextBox17.ReadOnly = False
            TextBox27.ReadOnly = False
            TextBox28.ReadOnly = False
            TextBox29.ReadOnly = False
            TextBox30.ReadOnly = False
            TextBox31.ReadOnly = False
            TextBox32.ReadOnly = False

        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'Label12.Text = ComboBox2.SelectedItem
        If ComboBox2.SelectedItem = "1 - крушовиден, закръглен горе(при шлица)" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "2 - крушовиден, скосен горе" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "3 - трапецовиден, скосен горе" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "4 - правоъгълен, скосен горе" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "5 - кръгъл" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "6 - двоен кафез, горе кръгъл, долу круша" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
            TextBox48.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "7 - двоен кафез, горе закръглен, долу отрязана" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
            TextBox34.ReadOnly = False
            TextBox33.ReadOnly = False
            TextBox48.ReadOnly = False
        End If
        If ComboBox2.SelectedItem = "8 - двоен кафез, горе трапец, долу трапец,скосен горе" Then
            TextBox26.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox40.ReadOnly = False
            TextBox39.ReadOnly = False
            TextBox38.ReadOnly = False
            TextBox37.ReadOnly = False
            TextBox36.ReadOnly = False
            TextBox35.ReadOnly = False
            TextBox34.ReadOnly = False
            TextBox33.ReadOnly = False
            TextBox48.ReadOnly = False
            TextBox47.ReadOnly = False
            TextBox46.ReadOnly = False
        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox58.Text = 0.93

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ELST.Show()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        p2r = TextBox1.Text
        p = TextBox2.Text
        v1r = TextBox3.Text
        Dim temp As Double
        temp = (p2r + p) / 2

        Me.Hide() 'Hide current form
        Results.Show() 'Show new form - form Results
    End Sub
End Class
