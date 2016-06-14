Public Class Form2
    Public score1 As Integer = 0 'aici vom tine scorul pentru jucatorul 1
    Public score2 As Integer = 0 'aici vom tine scorul pentru jucatorul 2
    Private Sub reset() 'Functia care reseteaza jocul - la apasare de buton sau la finalul partidei
        For Each ctrl As Control In Panel1.Controls
            ctrl.BackColor = Color.Transparent
            ctrl.Text = ""
            ctrl.Enabled = True
        Next
    End Sub
    Private Function remiza() 'Functie care verifica aparitia remizei
        Dim final As Boolean = True
        For Each ctrl As Control In Panel1.Controls
            If ctrl.Text = "" Then
                final = False
            End If
        Next
        Return final
    End Function
    Private Sub update_score() 'Functie care updateaza scorul
        If btn1.Text = "X" Then 'Daca a castigat jucatorul 1
            MsgBox("Haha. " & CheckBox1.Text & " a castigat ! ", vbOKOnly)
            score1 += 1
            lblScore1.Text = score1
        Else 'Daca a castigat jucatorul 2
            MsgBox("Haha. " & CheckBox2.Text & " a castigat ! ", vbOKOnly)
            score2 += 1
            lblScore2.Text = score2
        End If
    End Sub
    Private Sub final() 'se verifica daca a castigat cineva, deci daca sunt 3 casute corecte.
        If btn1.Text = btn2.Text And btn2.Text = btn3.Text And btn2.Text <> "" Then 'verificam combinatia 1-2-3
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn1.Text = btn5.Text And btn5.Text = btn9.Text And btn9.Text <> "" Then 'verificam combinatia 1-5-9
            btn1.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn9.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn4.Text = btn5.Text And btn5.Text = btn6.Text And btn6.Text <> "" Then 'verificam combinatia 4-5-6
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn6.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn7.Text = btn8.Text And btn7.Text = btn9.Text And btn9.Text <> "" Then 'verificam combinatia 7-8-9
            btn7.BackColor = Color.Green
            btn8.BackColor = Color.Green
            btn9.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn3.Text = btn5.Text And btn5.Text = btn7.Text And btn7.Text <> "" Then 'verificam combinatia 3-5-7
            btn3.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn7.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn1.Text = btn4.Text And btn4.Text = btn7.Text And btn7.Text <> "" Then 'verificam combinatia 1-4-7
            btn1.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn7.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn2.Text = btn5.Text And btn5.Text = btn8.Text And btn8.Text <> "" Then 'verificam combinatia 2-5-8
            btn2.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn8.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf btn3.Text = btn6.Text And btn6.Text = btn9.Text And btn9.Text <> "" Then 'verificam combinatia 3-6-9
            btn3.BackColor = Color.Green
            btn6.BackColor = Color.Green
            btn9.BackColor = Color.Green
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            update_score()
            reset()
        ElseIf remiza() Then 'verificare remiza, cand au fost apasate toate butoanele
            MsgBox("Remiza", vbOKOnly, "Remiza")
            reset()
        End If
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Sigur vrei sa parasesti aplicatia?", vbYesNo, "Iesire") = vbYes Then 'Intrebare daca e sigur sa inchida
            Form1.Close()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub clickB(ByVal sender As Object, ByVal e As EventArgs)
        If CheckBox1.Checked Then 'Cand e tura primului jucator completam cu X
            CheckBox1.Checked = False
            CheckBox2.Checked = True
            sender.backcolor = DefaultBackColor
            sender.text = "X"
            sender.enabled = False
            final()
        Else
            CheckBox1.Checked = True 'Completare cu 0
            CheckBox2.Checked = False
            sender.backcolor = DefaultBackColor
            sender.text = "0"
            sender.enabled = False
            final()
        End If

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Text = Form1.lbl1.Text
        CheckBox2.Text = Form1.lbl2.Text
        For Each ctrl As Control In Panel1.Controls
            AddHandler ctrl.Click, AddressOf clickB
        Next
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class