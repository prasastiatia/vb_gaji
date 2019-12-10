<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataAbsenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarAbsenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataGajiKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakSlipGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KaryawanToolStripMenuItem, Me.AbsenToolStripMenuItem, Me.GajiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataKaryawanToolStripMenuItem, Me.DaftarKaryawanToolStripMenuItem})
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'InputDataKaryawanToolStripMenuItem
        '
        Me.InputDataKaryawanToolStripMenuItem.Name = "InputDataKaryawanToolStripMenuItem"
        Me.InputDataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.InputDataKaryawanToolStripMenuItem.Text = "Input Data Karyawan"
        '
        'DaftarKaryawanToolStripMenuItem
        '
        Me.DaftarKaryawanToolStripMenuItem.Name = "DaftarKaryawanToolStripMenuItem"
        Me.DaftarKaryawanToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DaftarKaryawanToolStripMenuItem.Text = "Daftar Karyawan"
        '
        'AbsenToolStripMenuItem
        '
        Me.AbsenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataAbsenToolStripMenuItem, Me.DaftarAbsenToolStripMenuItem})
        Me.AbsenToolStripMenuItem.Name = "AbsenToolStripMenuItem"
        Me.AbsenToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AbsenToolStripMenuItem.Text = "Absen"
        '
        'InputDataAbsenToolStripMenuItem
        '
        Me.InputDataAbsenToolStripMenuItem.Name = "InputDataAbsenToolStripMenuItem"
        Me.InputDataAbsenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.InputDataAbsenToolStripMenuItem.Text = "Input Data Absen"
        '
        'DaftarAbsenToolStripMenuItem
        '
        Me.DaftarAbsenToolStripMenuItem.Name = "DaftarAbsenToolStripMenuItem"
        Me.DaftarAbsenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DaftarAbsenToolStripMenuItem.Text = "Daftar Absen"
        '
        'GajiToolStripMenuItem
        '
        Me.GajiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataGajiKaryawanToolStripMenuItem, Me.CetakSlipGajiToolStripMenuItem})
        Me.GajiToolStripMenuItem.Name = "GajiToolStripMenuItem"
        Me.GajiToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.GajiToolStripMenuItem.Text = "Gaji"
        '
        'InputDataGajiKaryawanToolStripMenuItem
        '
        Me.InputDataGajiKaryawanToolStripMenuItem.Name = "InputDataGajiKaryawanToolStripMenuItem"
        Me.InputDataGajiKaryawanToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.InputDataGajiKaryawanToolStripMenuItem.Text = "Input Data Gaji Karyawan"
        '
        'CetakSlipGajiToolStripMenuItem
        '
        Me.CetakSlipGajiToolStripMenuItem.Name = "CetakSlipGajiToolStripMenuItem"
        Me.CetakSlipGajiToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CetakSlipGajiToolStripMenuItem.Text = "Cetak Slip Gaji"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 274)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(560, 407)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main_Menu"
        Me.Text = "Aplikasi Penggajian"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataAbsenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarAbsenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataGajiKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakSlipGajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
