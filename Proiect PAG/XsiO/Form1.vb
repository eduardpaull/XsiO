Public Class Form1

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged 'Aici adaugam numele primului jucator
        If txt1.Text.Trim <> "" Then 'Daca e diferit de nimic
            lbl1.Text = txt1.Text.Trim 'modificam numele curent
            For Each ctrl As Control In Panel1.Controls ' Verificam daca a selectat un erou
                If ctrl.Enabled = False Then
                    btnNext1.Visible = True 'Daca a selectat un erou si daca a introdus si nume, putem trece la urmatorul player
                End If
            Next
        End If
    End Sub

    Private Sub btnBatman1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatman1.Click
        If btnSuperman1.Enabled = True Then 'Atunci cand este selectat Batman, la primul jucator, ceilalti eroi nu pot fi selectati
            btnSuperman1.Enabled = False 'Decat in situatia in care deselectam eroul selectat
            btnJoker1.Enabled = False
            If txt1.Text.Trim <> "" Then
                btnNext1.Visible = True
            End If
        Else
            btnSuperman1.Enabled = True
            btnJoker1.Enabled = True
            btnNext1.Visible = False
        End If
      
    End Sub

    Private Sub btnSuperman1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuperman1.Click
        If btnJoker1.Enabled = True Then 'Atunci cand este selectat Superman, la primul jucator, ceilalti eroi nu pot fi selectati
            btnBatman1.Enabled = False 'Decat in situatia in care deselectam eroul selectat
            btnJoker1.Enabled = False
            If txt1.Text.Trim <> "" Then
                btnNext1.Visible = True
            End If
        Else
            btnBatman1.Enabled = True
            btnJoker1.Enabled = True
            btnNext1.Visible = False
        End If
       
    End Sub

    Private Sub btnJoker1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoker1.Click
        If btnBatman1.Enabled = True Then 'Atunci cand este selectat Joker, la primul jucator, ceilalti eroi nu pot fi selectati
            btnSuperman1.Enabled = False 'Decat in situatia in care deselectam eroul selectat
            btnBatman1.Enabled = False
            If txt1.Text.Trim <> "" Then
                btnNext1.Visible = True
            End If
        Else
            btnSuperman1.Enabled = True
            btnBatman1.Enabled = True
            btnNext1.Visible = False
        End If
       
    End Sub

    Private Sub btnNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext1.Click
        btnBatman1.Visible = False 'Butonul Next pentru primul jucator inchide toate controalele pentru jucator1 si afiseaza eroul selectat
        lbl1.Visible = False 'inchide label
        btnSuperman1.Visible = False 'inchide toti eroii
        btnJoker1.Visible = False
        txt1.Visible = False
        If btnBatman1.Enabled = True Then ' Verificam eroul selectat
            PictureBox1.Image = My.Resources.batman
        ElseIf btnSuperman1.Enabled = True Then
            PictureBox1.Image = My.Resources.Superman
        Else
            PictureBox1.Image = My.Resources.joker
        End If
        PictureBox1.Visible = True 'Afisam toate controalele pentru jucator 2, pentru ca jucatorul sa isi poate alege numele si eroul
        btnNext1.Visible = False
        Panel2.Visible = True
        lbl2.Visible = True
        txt2.Visible = True
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged 'Aici adaugam celui de al 2 lea jucator
        If txt1.Text.Trim <> "" Then 'Daca e diferit de nimic
            If txt2.Text.Trim <> "" Then 'modificam numele curent
                lbl2.Text = txt2.Text.Trim
                For Each ctrl As Control In Panel2.Controls ' Verificam daca a selectat un erou
                    If ctrl.Enabled = False Then
                        btnNext2.Visible = True 'Daca a selectat un erou si daca a introdus si nume, putem trece la start joc
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnBatman2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatman2.Click
        If btnSuperman2.Enabled = True Then 'Atunci cand este selectat Batman, la al 2-lea jucator, ceilalti eroi nu pot fi selectati
            btnSuperman2.Enabled = False 'Decat in situatia in care deselectam eroul selectat
            btnJoker2.Enabled = False
            If txt2.Text.Trim <> "" Then
                btnNext2.Visible = True
            End If
        Else
            btnSuperman2.Enabled = True
            btnJoker2.Enabled = True
            btnNext2.Visible = False
        End If
    End Sub

    Private Sub btnSuperman2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuperman2.Click
        If btnJoker2.Enabled = True Then 'Atunci cand este selectat Superman, la al 2-lea jucator, ceilalti eroi nu pot fi selectati
            btnBatman2.Enabled = False 'Decat in situatia in care deselectam eroul selectat
            btnJoker2.Enabled = False
            If txt2.Text.Trim <> "" Then
                btnNext2.Visible = True
            End If
        Else
            btnBatman2.Enabled = True
            btnJoker2.Enabled = True
            btnNext2.Visible = False
        End If
    End Sub

    Private Sub btnJoker2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoker2.Click
        If btnBatman2.Enabled = True Then 'Atunci cand este selectat Joker, la al 2-lea jucator, ceilalti eroi nu pot fi selectati
            btnSuperman2.Enabled = False 'Decat in situatia in care deselectam eroul selectat
            btnBatman2.Enabled = False
            If txt2.Text.Trim <> "" Then
                btnNext2.Visible = True
            End If
        Else
            btnSuperman2.Enabled = True
            btnBatman2.Enabled = True
            btnNext2.Visible = False
        End If

    End Sub

    Private Sub btnNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        If btnBatman2.Enabled = True Then 'Butonul Next pentru primul jucator inchide toate controalele pentru jucator1 si afiseaza eroul selectat
            Panel3.BackgroundImage = My.Resources.batman
        ElseIf btnSuperman2.Enabled = True Then
            Panel3.BackgroundImage = My.Resources.Superman
        Else
            Panel3.BackgroundImage = My.Resources.joker
        End If
        btnNext2.Visible = False
        Panel2.Visible = False 'Inchide totul pentru jucator 2 si afiseaza Start pentru inceperea jocului
        lbl2.Visible = False
        txt2.Visible = False
        Panel3.Visible = True
        btnStart.Visible = True
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Me.Hide() 'inchidem forma curenta si deschidem forma de joc
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
