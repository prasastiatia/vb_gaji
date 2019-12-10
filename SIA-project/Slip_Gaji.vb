Public Class Slip_Gaji

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Sub tampilDataComboBox()
        Call cekkoneksi()
        Dim str As String
        str = "select kd_slip_gaji from gaji"
        Using sqlCommand As New MySqlCommand(str, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                If DR.HasRows Then
                    Do While DR.Read
                        ComboBox1.Items.Add(DR("kd_slip_gaji"))
                    Loop
                    DR.Close()
                End If
            End Using
        End Using

    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Slip_Gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        Call cekkoneksi()
        query = "Select kd_slip_gaji, id_karyawan, nama_karyawan, jabatan, gaji_pokok, trans_makan, uang_lembur, tunjangan, pendapatan, absen, bpjs, total_potongan, seragam, total_gaji from gaji where kd_slip_gaji='" & ComboBox1.Text & "'"
        Using sqlCommand As New MySqlCommand(query, sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    TextBox1.Text = DR.Item(1)
                    TextBox2.Text = DR.Item(2)
                    TextBox16.Text = DR.Item(3)
                    TextBox3.Text = DR.Item(4)
                    TextBox6.Text = DR.Item(5)
                    TextBox5.Text = DR.Item(6)
                    TextBox4.Text = DR.Item(7)
                    TextBox13.Text = DR.Item(8)
                    TextBox12.Text = DR.Item(9)
                    TextBox10.Text = DR.Item(10)
                    TextBox14.Text = DR.Item(11)
                    TextBox8.Text = DR.Item(12)
                    TextBox15.Text = DR.Item(13)

                End If
                DR.Close()
            End Using
        End Using

    End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then

            Form5.CrystalReportViewer1.SelectionFormula = "{gaji.kd_slip_gaji} = '" & ComboBox1.Text & "'"
            Form5.WindowState = FormWindowState.Maximized
            Form5.Show()

        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("Pilih Kode Gaji Untuk Cetak Slip Gaji")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub AxCrystalReport1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class