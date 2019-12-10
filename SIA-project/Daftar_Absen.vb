Imports MySql.Data.MySqlClient
Public Class Daftar_Absen

    Private Sub Daftar_Absen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDataAbsenExist()
    End Sub
    
    Sub tampilDataAbsenExist()
        Call cekkoneksi()
        Dim str1 As String
        str1 = "select kd_absen from data_absen"
        Using sqlCommand As New MySqlCommand(str1, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                If DR.HasRows Then
                    Do While DR.Read
                        ComboBox1.Items.Add(DR("kd_absen"))
                    Loop
                    DR.Close()
                Else
                End If
            End Using
        End Using

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        Call cekkoneksi()
        query = "Select kd_absen, id_karyawan, nama_karyawan from data_absen where kd_absen='" & ComboBox1.Text & "'"
        Using sqlCommand As New MySqlCommand(query, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()
                If DR.HasRows Then

                    TextBox2.Text = DR.Item(1)
                    TextBox3.Text = DR.Item(2)
                End If
                DR.Close()
            

        
            End Using
        End Using

        Using sqlCommand As New MySqlCommand("SELECT COUNT('kd_absen') FROM absen where kd_absen='" & ComboBox1.Text & "'", sConnection)
            TextBox4.Text = sqlCommand.ExecuteScalar().ToString()
        End Using

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        
    End Sub
    Sub KondisiAwal()
        Call cekkoneksi()
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call cekkoneksi()
        Dim str As String
        str = "update data_absen set jumlah_hari = '" & TextBox4.Text & "' where kd_absen = '" & ComboBox1.Text & "'"
        Using sqlCommand As New MySqlCommand(str, sConnection)
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Update Data Absen Berhasil Dilakukan")
        End Using
        Call KondisiAwal()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Daftar_Seluruh_Absen.Show()
        Me.Hide()
    End Sub
End Class