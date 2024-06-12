Public Class Form1
    Public hrgmakanan, hrgminuman As Integer

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                Label3.Text = "Rp.3500"
                hrgmakanan = 3500
            Case "Bakso"
                Label3.Text = "Rp.6000"
                hrgmakanan = 6000
            Case "Mie Ayam"
                Label3.Text = "Rp.7000"
                hrgmakanan = 7000
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label4.Text = "Rp.3000"
                hrgminuman = 3000
            Case "Jus Alpukat"
                Label4.Text = "Rp.7000"
                hrgminuman = 7000
            Case "Teh Manis"
                Label4.Text = "Rp.4000"
                hrgminuman = 4000
        End Select

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox2.Visible = False
        Label2.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Enabled = False Then
            ComboBox2.Visible = False
        End If

        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            Label2.Visible = True
        End If
    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim porsimkn, porsimnm, jumlah As Integer
        porsimkn = TextBox1.Text
        porsimnm = TextBox2.Text
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        Label7.Text = "Rp." & jumlah.ToString
    End Sub
End Class
