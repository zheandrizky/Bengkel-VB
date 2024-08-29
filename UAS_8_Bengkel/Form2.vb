Imports System.Data.Odbc

Public Class Form2
    Dim connStr As String = "dsn=fp_bengkel;"
    Dim conn As New OdbcConnection(connStr)
    Public dr As OdbcDataReader
    Dim cmd As New OdbcCommand

    Dim idSparepartsementara As Integer = 0
    Dim totalkeranjang As Integer = 0
    Dim total As Integer = 0
    Private selectedRowIndex As Integer = -1


    Sub checkConnection()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal " & ex.Message)
        End Try
    End Sub
    Sub GenerateInvoice()
        Dim currentDate As String = DateTime.Now.ToString("dd/MM/yyyy")
        Dim day As String = DateTime.Now.Day.ToString("00")
        Dim month As String = DateTime.Now.Month.ToString("00")
        Dim year As String = DateTime.Now.Year.ToString("0000")

        Dim transactionCount As Integer = 1 ' Default value jika tidak ada transaksi sebelumnya

        Try
            ' Mengambil jumlah transaksi dari tabel transaksi
            Dim query As String = "SELECT COUNT(*) FROM transaksi"
            cmd = New OdbcCommand(query, conn)
            transactionCount = Convert.ToInt32(cmd.ExecuteScalar()) + 1
        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message)
        End Try

        ' Membuat kode transaksi dengan format yang diinginkan
        Dim transactionCode As String = $"INV/{day}/{month}/{year}/{transactionCount}"

        ' Menetapkan kode transaksi ke TextBox
        Guna2TextBoxInvoice.Text = transactionCode
    End Sub

    Private Sub ComboBoxSparepart()
        Try
            ' Mengambil data nama sparepart dari tabel sparepart
            Dim query As String = "SELECT nama_sparepart FROM sparepart"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            ' Membersihkan item-item sebelumnya (jika ada)
            Guna2ComboBoxSNamaparepart.Items.Clear()

            ' Menambahkan nama sparepart ke dalam ComboBox
            While dr.Read()
                Guna2ComboBoxSNamaparepart.Items.Add(dr("nama_sparepart").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message)
        Finally
            ' Pastikan untuk menutup reader setelah selesai
            If dr IsNot Nothing Then
                dr.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CheckBoxSparepart_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxSparepart.CheckedChanged
        If Guna2CheckBoxSparepart.Checked Then
            ' Jika CheckBox dicentang, tampilkan elemen yang diinginkan
            Label6.Visible = True
            Label7.Visible = True
            Label10.Visible = True
            Guna2ComboBoxSNamaparepart.Visible = True
            Guna2TextBoxHargaSparepart.Visible = True
            Guna2TextBoxJumlahSparepart.Visible = True
        Else
            ' Jika CheckBox tidak dicentang, sembunyikan elemen yang diinginkan
            Label6.Visible = False
            Label7.Visible = False
            Label10.Visible = False
            Guna2ComboBoxSNamaparepart.Visible = False
            Guna2TextBoxHargaSparepart.Visible = False
            Guna2TextBoxJumlahSparepart.Visible = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkConnection()
        GenerateInvoice()
        ComboBoxSparepart()
    End Sub

    Private Sub Guna2ComboBoxSNamaparepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBoxSNamaparepart.SelectedIndexChanged
        Try
            ' Ambil harga dari barang yang dipilih dari tabel sparepart
            Dim selectedSparepart As String = Guna2ComboBoxSNamaparepart.SelectedItem.ToString()
            Dim query As String = $"SELECT id_sparepart, harga_sparepart FROM sparepart WHERE nama_sparepart = '{selectedSparepart}'"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.Add(New OdbcParameter("Sparepart", selectedSparepart))
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Guna2TextBoxHargaSparepart.Text = dr("harga_sparepart").ToString()
                idSparepartsementara = dr("id_sparepart").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Ambil data dari kontrol input (Guna2ComboBoxSNamaparepart, Guna2TextBoxHargaSparepart, Guna2TextBoxJumlahSparepart, dll.)
        Dim jenisJasa As String = Guna2TextBoxJenisJasa.Text
        Dim namaSparepart As String = If(Guna2CheckBoxSparepart.Checked, Guna2ComboBoxSNamaparepart.SelectedItem?.ToString(), "")
        Dim hargaSparepart As Integer = If(Guna2CheckBoxSparepart.Checked, Guna2TextBoxHargaSparepart.Text, 0)
        Dim jumlahSparepart As Integer = If(Guna2CheckBoxSparepart.Checked, Guna2TextBoxJumlahSparepart.Text, 0)
        Dim subtotal As Integer = If(Guna2CheckBoxSparepart.Checked, hargaSparepart * jumlahSparepart, 0)

        ' Periksa apakah data sparepart diperlukan jika CheckBox dicentang
        If Guna2CheckBoxSparepart.Checked AndAlso (String.IsNullOrEmpty(namaSparepart) OrElse hargaSparepart = 0 OrElse jumlahSparepart = 0) Then
            MessageBox.Show("Mohon lengkapi data sparepart.")
            Return
        End If

        ' Tambahkan data ke DataGridView
        Guna2DataGridView1.Rows.Add(jenisJasa, namaSparepart, hargaSparepart, jumlahSparepart, subtotal, idSparepartsementara)

        ' Update total
        totalkeranjang += subtotal
        total = totalkeranjang + Guna2TextBoxHargaJasa.Text
        ' Tampilkan total di Guna2TextBoxTotal
        Guna2TextBoxTotal.Text = total.ToString()
    End Sub

    Private Sub Guna2DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellDoubleClick
        ' Ambil indeks baris yang diklik dua kali
        selectedRowIndex = e.RowIndex
    End Sub


    Private Sub UpdateTotal()
        totalkeranjang = 0

        ' Hitung ulang total dari semua subtotal
        For Each row As DataGridViewRow In Guna2DataGridView1.Rows
            ' Pastikan sel "Subtotal" ada sebelum mencoba mengakses nilainya
            If row.Cells("Subtotal").Value IsNot Nothing Then
                Dim subtotal As Integer
                If Integer.TryParse(row.Cells("Subtotal").Value.ToString(), subtotal) Then
                    totalkeranjang += subtotal
                End If
            End If
        Next

        ' Tambahkan harga jasa
        total = totalkeranjang + Guna2TextBoxHargaJasa.Text

        ' Tampilkan total di Guna2TextBoxTotal
        Guna2TextBoxTotal.Text = total.ToString()
    End Sub


    Private Sub Guna2ButtonHapus_Click(sender As Object, e As EventArgs) Handles Guna2ButtonHapus.Click
        ' Periksa apakah ada baris yang dipilih
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < Guna2DataGridView1.Rows.Count Then
            ' Hapus baris dari DataGridView
            Guna2DataGridView1.Rows.RemoveAt(selectedRowIndex)

            ' Reset variabel selectedRowIndex setelah penghapusan
            selectedRowIndex = -1

            ' Update total
            UpdateTotal()
        Else
            MessageBox.Show("Pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2ButtonSimpan_Click(sender As Object, e As EventArgs) Handles Guna2ButtonSimpan.Click
        ' Pastikan ada data dalam keranjang sebelum menyimpan
        If Guna2DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Keranjang belanja kosong. Tambahkan barang atau jasa terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil data dari TextBox dan DataGridView
        Dim kodeTransaksi As String = Guna2TextBoxInvoice.Text
        Dim namaPembeli As String = Guna2TextBoxNamaPelanggan.Text
        Dim totalTransaksi As Integer = total
        Dim platNomor As String = Guna2TextBoxPlatNomor.Text
        Dim jenisJasa As String = Guna2TextBoxJenisJasa.Text
        Dim hargaJasa As Integer = Guna2TextBoxHargaJasa.Text
        Dim tipeMotor As String = Guna2TextBoxTipeMotor.Text
        Dim waktuTransaksi As DateTime = DateTime.Now

        ' Simpan data ke tabel transaksi
        Dim queryTransaksi As String = "INSERT INTO transaksi (id_transaksi, nama_pembeli, total, plat_nomor, jenis_jasa, harga_jasa, tipe_motor, waktu_transaksi) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(queryTransaksi, conn)
        cmd.Parameters.AddWithValue("@kode_transaksi", kodeTransaksi)
        cmd.Parameters.AddWithValue("@nama_pembeli", namaPembeli)
        cmd.Parameters.AddWithValue("@total", totalTransaksi)
        cmd.Parameters.AddWithValue("@plat_nomor", platNomor)
        cmd.Parameters.AddWithValue("@jenis_jasa", jenisJasa)
        cmd.Parameters.AddWithValue("@harga_jasa", hargaJasa)
        cmd.Parameters.AddWithValue("@tipe_motor", tipeMotor)
        cmd.Parameters.AddWithValue("@waktu_transaksi", waktuTransaksi)
        cmd.ExecuteNonQuery()

        Try

            For Each row As DataGridViewRow In Guna2DataGridView1.Rows
                Dim jumlahSparepart As Integer = If(row.Cells("Jumlah").Value IsNot DBNull.Value, CInt(row.Cells("Jumlah").Value), 0)
                Dim subTotal As Integer = If(row.Cells("Subtotal").Value IsNot DBNull.Value, CInt(row.Cells("Subtotal").Value), 0)

                ' Hanya simpan baris dengan subtotal yang valid
                If subTotal > 0 Then
                    Dim queryDetailTransaksi As String = "INSERT INTO detail_transaksi (id_transaksi, id_sparepart, jumlah, subtotal) VALUES (?, ?, ?, ?)"
                    cmd = New OdbcCommand(queryDetailTransaksi, conn)
                    cmd.Parameters.AddWithValue("id_transaksi", Guna2TextBoxInvoice.Text)
                    cmd.Parameters.AddWithValue("id_sparepart", row.Cells("IdSparepart").Value)
                    cmd.Parameters.AddWithValue("jumlah", jumlahSparepart)
                    cmd.Parameters.AddWithValue("subtotal", subTotal)

                    cmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Detail Transaksi berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ' Bersihkan formulir setelah penyimpanan
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Kesalahan saat menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub

    Private Sub ClearForm()
        ' Bersihkan TextBox dan DataGridView
        Guna2TextBoxInvoice.Clear()
        Guna2TextBoxNamaPelanggan.Clear()
        Guna2TextBoxPlatNomor.Clear()
        Guna2TextBoxJenisJasa.Clear()
        Guna2TextBoxHargaJasa.Clear()
        Guna2TextBoxTipeMotor.Clear()
        Guna2TextBoxTotal.Clear()

        ' Bersihkan DataGridView
        Guna2DataGridView1.Rows.Clear()

        ' Generate invoice baru, dan mengembalikan combobox sparepart
        GenerateInvoice()
        ComboBoxSparepart()
    End Sub

End Class