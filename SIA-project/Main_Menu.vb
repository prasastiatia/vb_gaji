Public Class Main_Menu

    Private Sub InputDataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataKaryawanToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub DaftarKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarKaryawanToolStripMenuItem.Click
        Daftar_Karyawan.Show()
        Me.Hide()
    End Sub

    Private Sub InputDataAbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataAbsenToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub DaftarAbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarAbsenToolStripMenuItem.Click
        Daftar_Seluruh_Absen.Show()
        Me.Hide()
    End Sub

    Private Sub InputDataGajiKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataGajiKaryawanToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub CetakSlipGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSlipGajiToolStripMenuItem.Click
        Slip_Gaji.Show()
        Me.Hide()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class