Imports System.Drawing
Imports System.Windows.Forms

Public Class FormGame

    Private Sub proc(filename As String)
        Dim b = New Button
        Dim nbp, nmp As Integer
        If (filename = "bluebtn") Then
            b.BackgroundImage = My.Resources.bluebtn
        ElseIf (filename = "greenbtn") Then
            b.BackgroundImage = My.Resources.greenbtn
        ElseIf (filename = "redbtn") Then
            b.BackgroundImage = My.Resources.redbtn
        ElseIf (filename = "yellowbtn") Then
            b.BackgroundImage = My.Resources.yellowbtn
        ElseIf (filename = "purplebtn") Then
            b.BackgroundImage = My.Resources.purplebtn

        End If
        b.Dock = DockStyle.Fill
        b.FlatStyle = FlatStyle.Flat
        b.FlatAppearance.BorderSize = 0
        b.BackgroundImageLayout = ImageLayout.Stretch

        TableLayoutPanel1.Controls.Add(b, col, row)
        col = col + 1
        If (col = 4) Then
            'MsgBox(tabjouer(0) & " " & tabjouer(1) & " " & tabjouer(2) & " " & tabjouer(3))
            Compare(tabcache, tabjouer, nbp, nmp)
            ' MsgBox(nbp & "    " & nmp)
            If nbp <> 4 Then
                drawResult(nbp, nmp)

                row = row + 1
                col = 0
            Else
                MsgBox("YOU WIN!")
                lockBtns()
                Close()
            End If


        End If
        If (9 = row) Then
            MessageBox.Show("Game Over!")
            lockBtns()
            Close()
        End If
    End Sub



    Private Sub drawResult(nbp As Integer, nmp As Integer)
        Dim b As Button
        col2 = 0
        row2 = row * 2

        For i = 1 To nbp
            b = New Button
            b.BackgroundImage = My.Resources.greenpin_mini
            b.Dock = DockStyle.Fill
            b.FlatStyle = FlatStyle.Flat
            b.FlatAppearance.BorderSize = 0
            b.BackgroundImageLayout = ImageLayout.Stretch
            If i < 3 Then
                TableLayoutPanel2.Controls.Add(b, col2, row2)
            Else
                row2 += 1
                col2 = 0
                TableLayoutPanel2.Controls.Add(b, col2, row2)
            End If

        Next
        For i = 1 To nmp
            b = New Button
            b.BackgroundImage = My.Resources.redpin_mini
            b.Dock = DockStyle.Fill
            b.FlatStyle = FlatStyle.Flat
            b.FlatAppearance.BorderSize = 0
            b.BackgroundImageLayout = ImageLayout.Stretch

            If i < 3 Then
                TableLayoutPanel2.Controls.Add(b, col2, row2)
            Else
                row2 += 1
                col2 = 0
                TableLayoutPanel2.Controls.Add(b, col2, row2)
            End If

        Next

    End Sub

    Private Sub Compare(tabcache() As Integer, tabjouer() As Integer, ByRef nbp As Object, ByRef nmp As Object)
        nbp = 0
        nmp = 0
        For i = 0 To 3
            If tabcache(i) = tabjouer(i) Then
                nbp += 1
            Else
                For j = 0 To 3
                    If tabjouer(i) = tabcache(j) Then
                        nmp += 1
                        j = 4
                    End If
                Next
            End If


        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tabjouer(col) = 0
        proc("bluebtn")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tabjouer(col) = 1
        proc("greenbtn")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tabjouer(col) = 2
        proc("redbtn")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tabjouer(col) = 3
        proc("yellowbtn")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tabjouer(col) = 4
        proc("purplebtn")

    End Sub

    Sub lockBtns()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub

End Class