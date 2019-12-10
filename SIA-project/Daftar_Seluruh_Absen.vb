Public Class Daftar_Seluruh_Absen
    Sub tampilSeluruhAbsen()
        Call cekkoneksi()
        Using sqlAdapter As New MySqlDataAdapter("Select * from data_absen inner join absen on absen.kd_absen = data_absen.kd_absen", sConnection)
            Using ds As New DataSet
                sqlAdapter.Fill(ds, "data_absen")
                dgvDaftarAbsen.DataSource = ds.Tables("data_absen")
            End Using
        End Using

    End Sub
    Sub aturDGV()
        Try
            dgvDaftarAbsen.Columns(0).Width = 70
            dgvDaftarAbsen.Columns(1).Width = 130
            dgvDaftarAbsen.Columns(2).Width = 100
            dgvDaftarAbsen.Columns(3).Width = 100
            dgvDaftarAbsen.Columns(4).Width = 150
            dgvDaftarAbsen.Columns(5).Width = 150
            dgvDaftarAbsen.Columns(0).HeaderText = "Kode Absen"
            dgvDaftarAbsen.Columns(1).HeaderText = "ID Karyawan"
            dgvDaftarAbsen.Columns(2).HeaderText = "Nama Karyawan"
            dgvDaftarAbsen.Columns(3).HeaderText = "Jumlah Hadir"
            dgvDaftarAbsen.Columns(4).HeaderText = "Kode Absen"
            dgvDaftarAbsen.Columns(5).HeaderText = "Tanggal"
            dgvDaftarAbsen.Columns(6).HeaderText = "Jam Masuk"
            dgvDaftarAbsen.Columns(7).HeaderText = "Jam Keluar"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Daftar_Seluruh_Absen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilSeluruhAbsen()
        Call aturDGV()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub
End Class