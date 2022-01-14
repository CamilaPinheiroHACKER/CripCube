Public Class Face

    Dim Letras(3, 3) As Letra

    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Letras(0, 0) = New Letra
        Letras(0, 1) = New Letra
        Letras(0, 2) = New Letra
        Letras(1, 0) = New Letra
        Letras(1, 1) = New Letra
        Letras(1, 2) = New Letra
        Letras(2, 0) = New Letra
        Letras(2, 1) = New Letra
        Letras(2, 2) = New Letra

        Letras(0, 0).Location = New System.Drawing.Point(0, 0)
        Letras(0, 1).Location = New System.Drawing.Point(0, 41)
        Letras(0, 2).Location = New System.Drawing.Point(0, 82)
        Letras(1, 0).Location = New System.Drawing.Point(41, 0)
        Letras(1, 1).Location = New System.Drawing.Point(41, 41)
        Letras(1, 2).Location = New System.Drawing.Point(41, 82)
        Letras(2, 0).Location = New System.Drawing.Point(82, 0)
        Letras(2, 1).Location = New System.Drawing.Point(82, 41)
        Letras(2, 2).Location = New System.Drawing.Point(82, 82)

        Me.Controls.Add(Letras(0, 0))
        Me.Controls.Add(Letras(0, 1))
        Me.Controls.Add(Letras(0, 2))
        Me.Controls.Add(Letras(1, 0))
        Me.Controls.Add(Letras(1, 1))
        Me.Controls.Add(Letras(1, 2))
        Me.Controls.Add(Letras(2, 0))
        Me.Controls.Add(Letras(2, 1))
        Me.Controls.Add(Letras(2, 2))

    End Sub

End Class
