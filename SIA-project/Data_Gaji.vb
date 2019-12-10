Public Class Form3
    Dim urutan As String
    Dim hitung As Long
    Sub Kode_Otomatis()
        Call cekkoneksi()
        Using sqlCommand As New MySqlCommand("Select * from gaji where kd_slip_gaji in (select max(kd_slip_gaji) from gaji) ", sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()

                If DR.HasRows = 0 Then
                    TextBox1.Text = "GJ/BDC/0001"
                    DR.Close()

                End If
                If Not DR.HasRows Then
                    urutan = "GJ/BDC/" + "0001"
                    DR.Close()

                Else
                    hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                    urutan = "GJ/BDC/" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
                    DR.Close()
                    TextBox1.Text = urutan
                End If
                DR.Close()
            End Using
        End Using

    End Sub
    Sub Tampilgajipokok()
        If TextBox7.Text = "Manager Operasional" Then
            TextBox3.Text = 6800000

        ElseIf TextBox7.Text = "Cashier" Then
            TextBox3.Text = 3500000

        ElseIf TextBox7.Text = "Waiter" Then
            TextBox3.Text = 3000000

        ElseIf TextBox7.Text = "Security" Then
            TextBox3.Text = 1500000

        End If

    End Sub
    Sub Tampilseragam()

        If TextBox7.Text <> "Manager Operasional" Then
            TextBox8.Text = 50000

        End If

    End Sub
    Sub tampilDataComboBox()
        Call cekkoneksi()
        Dim str As String
        str = "select id_karyawan from karyawan"
        Using sqlCommand As New MySqlCommand(str, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                If DR.HasRows Then
                    Do While DR.Read
                        ComboBox1.Items.Add(DR("id_karyawan"))
                    Loop
                    DR.Close()
                End If
            End Using
        End Using

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_Otomatis()
        Call tampilDataComboBox()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        Call cekkoneksi()
        query = "Select id_karyawan, nama_karyawan,jabatan from karyawan where id_karyawan='" & ComboBox1.Text & "'"
        Using sqlCommand As New MySqlCommand(query, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    TextBox2.Text = DR.Item(1)
                    TextBox7.Text = DR.Item(2)
                End If
                DR.Close()
            End Using
        End Using

        Call Tampilgajipokok()
        Call Tampilseragam()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button1.Visible = True
        Button3.Visible = False

        Dim query As String
        Dim jumlah_hari As New Integer
        Call cekkoneksi()
        query = "Select kd_absen, id_karyawan, nama_karyawan, jumlah_hari from data_absen where id_karyawan='" & ComboBox1.Text & "'"
        Using sqlCommand As New MySqlCommand(query, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()
                If DR.HasRows Then

                    jumlah_hari = DR.Item(3)
                End If

            End Using
        End Using
        Dim total_pendapatan As New Integer
        Dim gaji_pokok As New Integer
        Dim makan As New Integer
        Dim lembur As New Integer
        Dim tunjangan As New Integer
        Dim hitung_makan As New Integer
        gaji_pokok = Val(TextBox3.Text)
        hitung_makan = 20000 * jumlah_hari
        TextBox4.Text = hitung_makan
        lembur = Val(TextBox5.Text)
        tunjangan = Val(TextBox6.Text)
        total_pendapatan = gaji_pokok + makan + lembur + tunjangan
        TextBox13.Text = total_pendapatan

        Dim absen As New Integer
        Dim harga_absen As New Integer
        Dim bpjs As New Integer
        Dim pph_21 As New Integer
        Dim total_potongan As New Integer
        Dim set_hari As New Integer
        Dim hitung_hari As New Integer


        set_hari = 30
        hitung_hari = set_hari - jumlah_hari
        harga_absen = 150000
        absen = harga_absen * hitung_hari
        TextBox12.Text = absen
        bpjs = Val(TextBox10.Text)
        pph_21 = Val(TextBox8.Text)
        total_potongan = absen + bpjs + pph_21
        TextBox14.Text = total_potongan

        Dim total_gaji As New Integer
        total_gaji = Val(TextBox13.Text) - Val(TextBox14.Text)
        TextBox15.Text = total_gaji


    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            Me.Close()
        Else

            Dim str As String
            str = "insert into gaji (kd_slip_gaji, id_karyawan, nama_karyawan, jabatan, gaji_pokok, trans_makan, uang_lembur, tunjangan, pendapatan, absen, bpjs, total_potongan, seragam, total_gaji) values ('" & TextBox1.Text & "' ,'" & ComboBox1.Text & "','" & TextBox2.Text & "', '" & TextBox7.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox13.Text & "', '" & TextBox12.Text & "', '" & TextBox10.Text & "', '" & TextBox14.Text & "' , '" & TextBox8.Text & "', '" & TextBox15.Text & "')"
            Using sqlCommand As New MySqlCommand(str, sConnection)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("Input Data Gaji Berhasil Dilakukan")
            End Using

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Slip_Gaji.Show()
        Me.Hide()
    End Sub
End Class