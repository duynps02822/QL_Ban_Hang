Imports System.Data.SqlClient
Public Class frmSP

    Private Sub Clear()
        txtDVT.Clear()
        txtGia.Clear()
        txtMa.Clear()
        txtMota.Clear()
        txtTen.Clear()
        cboLoai.SelectedIndex = 0
    End Sub

    Private Sub FillSP()
        Dim Sql As String =
            <sql>
                SELECT San_Pham.MaSP, San_Pham.TenSP, Loai_San_Pham.TenLoaiSP, San_Pham.DVT, San_Pham.Gia, San_Pham.MoTa
                FROM Loai_San_Pham INNER JOIN San_Pham ON Loai_San_Pham.MaLoaiSP = San_Pham.MaLoai
            </sql>
        Connect(Sql, "SanPham")
        bsSP.DataSource = ds.Tables("SanPham")
        dgvSP.DataSource = bsSP
        bsSP.ResetBindings(False)
    End Sub

    Private Sub SP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSP()
    End Sub

    Private Sub dgvSP_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSP.SelectionChanged
        Try
            Dim RowView As DataRowView = bsSP.Current
            Dim Row As DataRow = RowView.Row

            txtMa.Text = Row("MaSP")
            txtTen.Text = Row("TenSP")
            cboLoai.Text = Row("TenLoaiSP")
            txtDVT.Text = Row("DVT")
            txtGia.Text = Row("Gia")
            txtMota.Text = Row("MoTa")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                delete from San_Pham where (MaSP='{0}')
            </sql>
        Sql = String.Format(Sql, txtMa.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Dim Sql As String =
            <sql>
                UPDATE  San_Pham
                SET     TenSP = N'{0}', MaLoai = '{1}', DVT = N'{2}', Gia = '{3}', MoTa = N'{4}'
                WHERE   (MaSP = '{5}')
            </sql>

        Dim Loai As String
        Select Case cboLoai.Text
            Case "Smart Phone"
                Loai = "Mo"
            Case "Laptop"
                Loai = "La"
            Case Else
                Loai = "LK"
        End Select

        Sql = String.Format(Sql, txtTen.Text, Loai, txtDVT.Text, txtGia.Text, txtMota.Text, txtMa.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Loai As String
        Select Case cboLoai.Text
            Case "Smart Phone"
                Loai = "Mo"
            Case "Laptop"
                Loai = "La"
            Case Else
                Loai = "LK"
        End Select

        Dim Sql As String =
            <sql>
                INSERT INTO San_Pham (MaSP, TenSP, MaLoai, DVT, Gia, MoTa)
                VALUES  ('{0}', N'{1}', '{2}', N'{3}', '{4}', N'{5}')
            </sql>

        Sql = String.Format(Sql, txtMa.Text, txtTen.Text, Loai, txtDVT.Text, txtGia.Text, txtMota.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        FillSP()
    End Sub
End Class