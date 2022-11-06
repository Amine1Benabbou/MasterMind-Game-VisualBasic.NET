Module Module1
    Public f1 As FormGame
    Public row As Integer = 0
    Public col As Integer = 0
    Public row2 As Integer = 0
    Public col2 As Integer = 0
    Public f2 As Form1
    Public f3 As Form2
    Public f4 As testform
    Public f5 As testmain
    Public tabcache(4) As Integer
    Public tabjouer(4) As Integer
    Sub Main()
        f3 = New Form2
        f2 = New Form1
        f4 = New testform
        f1 = New FormGame
        f5 = New testmain
        'f2.ShowDialog()
        f5.ShowDialog()
    End Sub

End Module
