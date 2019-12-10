Public Class Data_Jam_Absen

    Private Sub Data_Jam_Absen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "HH:mm tt"
        DateTimePicker3.CustomFormat = "HH:mm tt"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form2.DataGridView1.Rows.Add(1)
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = DateTimePicker1.Value
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(1).Value = DateTimePicker2.Value
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(2).Value = DateTimePicker3.Value
        Me.Hide()
        Form2.DataGridView1.Update()
    End Sub
End Class