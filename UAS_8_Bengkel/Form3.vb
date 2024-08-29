Imports System.Data.Odbc

Public Class Form3
    Dim connStr As String = "dsn=fp_bengkel;"
    Dim conn As New OdbcConnection(connStr)
    Public dr As OdbcDataReader
    Dim cmd As New OdbcCommand

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
    Sub showData()
        cmd = New OdbcCommand("SELECT id_sparepart, nama_sparepart, harga_sparepart, stock_sparepart FROM sparepart", conn)
        dr = cmd.ExecuteReader
        Guna2DataGridView1.Rows.Clear()

        Do While dr.Read = True
            Guna2DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3))
        Loop
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkConnection()
        showData()
    End Sub
    Sub addSparepart()
        Try
            'sparepart
            Dim query As String = "INSERT INTO sparepart (nama_sparepart, harga_sparepart, stock_sparepart) VALUES (?, ?, ?)"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("nama_sparepart", Guna2TextBoxNama.Text)
            cmd.Parameters.AddWithValue("harga_sparepart", Guna2TextBoxHarga.Text)
            cmd.Parameters.AddWithValue("stock_sparepart", Guna2TextBoxJumlah.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Sparepart berhasil disimpan.")

        Catch ex As Exception
            MessageBox.Show("kesalahan: " & ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellDoubleClick
        ' Mengisi TextBox dengan nilai dari kolom yang sesuai di DataGridView saat baris di-double click
        If e.RowIndex >= 0 Then
            Guna2TextBoxNama.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString() ' Nama Sparepart
            Guna2TextBoxHarga.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString() ' Harga Sparepart
            Guna2TextBoxJumlah.Text = Guna2DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString() ' Stock Sparepart
        End If
    End Sub
    Sub updateSparepart()
        Try
            If Guna2DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
                Dim sparepartID As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

                Dim query As String = "UPDATE sparepart SET nama_sparepart = ?, harga_sparepart = ?, stock_sparepart = ? WHERE id_sparepart = ?"
                cmd = New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("nama_sparepart", Guna2TextBoxNama.Text)
                cmd.Parameters.AddWithValue("harga_sparepart", Guna2TextBoxHarga.Text)
                cmd.Parameters.AddWithValue("stock_sparepart", Guna2TextBoxJumlah.Text)
                cmd.Parameters.AddWithValue("id_sparepart", sparepartID)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Sparepart berhasil diperbarui.")
            Else
                MessageBox.Show("Pilih baris terlebih dahulu untuk mengedit data.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message)
        End Try
    End Sub
    Sub deleteSparepart()
        Try
            If Guna2DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
                Dim sparepartID As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

                Dim query As String = "DELETE FROM sparepart WHERE id_sparepart = ?"
                cmd = New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("id_sparepart", sparepartID)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Sparepart berhasil dihapus.")
            Else
                MessageBox.Show("Pilih baris terlebih dahulu untuk menghapus data.")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2ButtonAdd_Click(sender As Object, e As EventArgs) Handles Guna2ButtonAdd.Click
        addSparepart()
        showData()
    End Sub

    Private Sub Guna2ButtonEdit_Click(sender As Object, e As EventArgs) Handles Guna2ButtonEdit.Click
        updateSparepart()
        showData()
    End Sub

    Private Sub Guna2ButtonDelete_Click(sender As Object, e As EventArgs) Handles Guna2ButtonDelete.Click
        deleteSparepart()
        showData()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class