Imports MySql.Data.MySqlClient
Public Class Form1
    Dim urutan As String
    Dim hitung As Long
    Dim ds As DataSet
    Dim mycmd As MySqlCommand
    Dim objdatareader As MySqlDataReader

    Sub KondisiAwal()
        cekkoneksi()
        TextBox1.Text = urutan
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Enabled = False
        Button1.Text = "Simpan"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Kode_Otomatis()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub

    Sub Kode_Otomatis()
        Call cekkoneksi()
        Using sqlCommand As New MySqlCommand("Select * from karyawan where id_karyawan in (select max(id_karyawan) from karyawan) ", sConnection)
            Using DR As MySqlDataReader = sqlCommand.ExecuteReader
                DR.Read()

                If DR.HasRows = 0 Then
                    TextBox1.Text = "NIP-0001"
                    DR.Close()

                End If
                If Not DR.HasRows Then
                    urutan = "NIP-" + "0001"
                    DR.Close()

                Else
                    hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                    urutan = "NIP-" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
                    DR.Close()
                    TextBox1.Text = urutan
                End If
            End Using
        End Using

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Then
            MessageBox.Show("Input Data Karyawan Gagal Dilakukan")
            Exit Sub
        Else

            Dim Gender As String = Nothing
            If RadioButton1.Checked Then
                Gender = RadioButton1.Text.ToString
            ElseIf RadioButton2.Checked Then
                Gender = RadioButton2.Text.ToString
            End If
            Dim str As String
            str = "insert into karyawan values ('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & Gender & "', '" & TextBox5.Text & "')"
            Using sqlCommand As New MySqlCommand(str, sConnection)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("Input Data Karyawan Berhasil Dilakukan")
                Call KondisiAwal()
                Call Kode_Otomatis()
            End Using

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Daftar_Karyawan.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub
End Class
