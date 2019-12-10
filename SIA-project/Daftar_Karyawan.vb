Imports MySql.Data.MySqlClient
Public Class Daftar_Karyawan
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilKaryawan()
        Call aturDGV()
    End Sub
    Sub tampilKaryawan()
        Call cekkoneksi()
        Using sqlAdapter As New MySqlDataAdapter("select id_karyawan, nama_karyawan, jabatan, no_telp, jenis_kelamin, alamat from karyawan", sConnection)
            Using ds As New DataSet
                sqlAdapter.Fill(ds, "karyawan")
                dgvDaftarKaryawan.DataSource = ds.Tables("karyawan")
            End Using
        End Using

    End Sub
    Sub aturDGV()
        Try
            dgvDaftarKaryawan.Columns(0).Width = 70
            dgvDaftarKaryawan.Columns(1).Width = 130
            dgvDaftarKaryawan.Columns(2).Width = 100
            dgvDaftarKaryawan.Columns(3).Width = 100
            dgvDaftarKaryawan.Columns(4).Width = 150
            dgvDaftarKaryawan.Columns(5).Width = 150
            dgvDaftarKaryawan.Columns(0).HeaderText = "NIP"
            dgvDaftarKaryawan.Columns(1).HeaderText = "Nama"
            dgvDaftarKaryawan.Columns(2).HeaderText = "Jabatan"
            dgvDaftarKaryawan.Columns(3).HeaderText = "No Telepon"
            dgvDaftarKaryawan.Columns(4).HeaderText = "Jenis Kelamin"
            dgvDaftarKaryawan.Columns(5).HeaderText = "Alamat"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class