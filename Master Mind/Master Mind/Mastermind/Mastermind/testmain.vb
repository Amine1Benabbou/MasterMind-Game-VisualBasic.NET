Public Class testmain
    Dim hasStarted As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r = New Random

        If hasStarted = False Then
            For i = 0 To 3
                tabcache(i) = r.Next(0, 5)
            Next

        End If
        hasStarted = True
        ' MsgBox(tabcache(0) & " " & tabcache(1) & " " & tabcache(2) & " " & tabcache(3))
        f1.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f4.ShowDialog()
    End Sub


End Class