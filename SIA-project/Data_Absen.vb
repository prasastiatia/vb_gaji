Public Class Form2
    Dim urutan As String
    Dim hitung As Long

    Sub KondisiAwal()
        Call cekkoneksi()
        ComboBox2.Text = ""
        ComboBox2.Visible = True
        TextBox1.Visible = False
        ComboBox1.Text = ""
        TextBox2.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Sub tampilDataAbsenExist()
        Call cekkoneksi()
        Dim str1 As String
        str1 = "select kd_absen from data_absen"
        Using sqlCommand As New MySqlCommand(str1, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
            If DR.HasRows Then
                Do While DR.Read
                    ComboBox2.Items.Add(DR("kd_absen"))
                Loop
                DR.Close()
            Else
                End If
            End Using
        End Using

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
    Sub Kode_Otomatis()
        Call cekkoneksi()
        Using sqlCommand As New MySqlCommand("Select * from data_absen where kd_absen in (select max(kd_absen) from absen) ", sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()

                If DR.HasRows = 0 Then
                    TextBox1.Text = "BDC-0001"
                    DR.Close()

                End If
                If Not DR.HasRows Then
                    urutan = "BDC-" + "0001"
                    DR.Close()

                Else
                    hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                    urutan = "BDC-" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
                    DR.Close()
                    TextBox1.Text = urutan
                End If
                DR.Close()
            End Using
        End Using

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or DataGridView1.RowCount = 0 Then
            MessageBox.Show("Input Data Absen Gagal Dilakukan")
            Exit Sub
        ElseIf ComboBox2.Visible = True Then

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1

                Dim str As String
                str = "insert into absen (kd_absen, tanggal, jam_masuk, jam_keluar) values ('" & ComboBox2.Text & "', @tanggal , @jam_masuk , @jam_keluar)"
                Using sqlCommand As New MySqlCommand(str, sConnection)
                    sqlCommand.Parameters.AddWithValue("@tanggal", DataGridView1.Rows(baris).Cells(0).Value)
                    sqlCommand.Parameters.AddWithValue("@jam_masuk", DataGridView1.Rows(baris).Cells(1).Value)
                    sqlCommand.Parameters.AddWithValue("@jam_keluar", DataGridView1.Rows(baris).Cells(2).Value)
                    sqlCommand.ExecuteNonQuery()
                End Using

            Next
            Call KondisiAwal()


            MessageBox.Show("Input Data Absen Berhasil Dilakukan")

        ElseIf TextBox1.Visible = True Then
            Dim query As String
            query = "insert into data_absen (kd_absen, id_karyawan, nama_karyawan) values ('" & TextBox1.Text & "','" & ComboBox1.Text & "', '" & TextBox2.Text & "')"
            Using sqlCommand As New MySqlCommand(query, sConnection)
                sqlCommand.ExecuteNonQuery()
            End Using

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1

                Dim str As String
                str = "insert into absen (kd_absen, tanggal, jam_masuk, jam_keluar,jumlah_hari) values ('" & TextBox1.Text & "', @tanggal , @jam_masuk , @jam_keluar, '""')"
                Using sqlCommand As New MySqlCommand(str, sConnection)
                    sqlCommand.Parameters.AddWithValue("@tanggal", DataGridView1.Rows(baris).Cells(0).Value)
                    sqlCommand.Parameters.AddWithValue("@jam_masuk", DataGridView1.Rows(baris).Cells(1).Value)
                    sqlCommand.Parameters.AddWithValue("@jam_keluar", DataGridView1.Rows(baris).Cells(2).Value)
                    sqlCommand.ExecuteNonQuery()
                End Using
            Next
            MessageBox.Show("Input Data Absen Berhasil Dilakukan")
            Call KondisiAwal()
            Call Kode_Otomatis()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Daftar_Absen.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_Otomatis()
        Call tampilDataComboBox()
        Call tampilDataAbsenExist()
        Call AturDGV()

    End Sub
    Sub AturDGV()
        Dim Style1 = New DataGridViewCellStyle()
        Dim Style2 = New DataGridViewCellStyle()
        Dim Style3 = New DataGridViewCellStyle()

        Style1.Format = "dd/MM/yyyy"
        Style2.Format = "HH:mm tt"
        Style3.Format = "HH:mm tt"

        DataGridView1.Columns(0).DefaultCellStyle.Format = "dd/MM/yyyy"
        DataGridView1.Columns(1).DefaultCellStyle.Format = "HH:mm tt"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "HH:mm tt"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TextBox1.Visible = True And ComboBox2.Visible = False Then
            Dim query As String
            Call cekkoneksi()
            query = "Select id_karyawan, nama_karyawan from karyawan where id_karyawan='" & ComboBox1.Text & "'"
            Using sqlCommand As New MySqlCommand(query, sConnection)

                Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                    DR.Read()
                    If DR.HasRows Then
                        TextBox2.Text = DR.Item(1)
                    End If
                    DR.Close()
                End Using
            End Using

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox2.Text = TextBox1.Text
        TextBox1.Visible = True
        ComboBox2.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Data_Jam_Absen.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim query As String
        Call cekkoneksi()
        query = "Select kd_absen, id_karyawan, nama_karyawan from data_absen where kd_absen='" & ComboBox2.Text & "'"
        Using sqlCommand As New MySqlCommand(query, sConnection)
            Using DR As MySqlDataReader= sqlCommand.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                ComboBox1.Text = DR.Item(1)
                TextBox2.Text = DR.Item(2)
            End If
                DR.Close()
            End Using
        End Using

    End Sub
End Class