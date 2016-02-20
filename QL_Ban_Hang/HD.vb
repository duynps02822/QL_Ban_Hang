Public Class frmHD

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmHome.Show()
    End Sub
    Private Sub FillHD()
        Dim Sql As String =
            <sql>
                SELECT  Chi_Tiet_Hoa_Don.MaHD, Hoa_Don.MaKH, 
                        Khach_Hang.TenKH, Chi_Tiet_Hoa_Don.MaSP, San_Pham.TenSP, 
                        Chi_Tiet_Hoa_Don.SoLuong, Hoa_Don.NgayLapHD, 
                        (San_Pham.Gia*Chi_Tiet_Hoa_Don.SoLuong) as ThanhTien
                FROM    Chi_Tiet_Hoa_Don INNER JOIN
                        Hoa_Don ON Chi_Tiet_Hoa_Don.MaHD = Hoa_Don.MaHD INNER JOIN
                        Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH INNER JOIN
                        San_Pham ON Chi_Tiet_Hoa_Don.MaSP = San_Pham.MaSP
            </sql>
        Connect(Sql, "Hoa_Don")
        bsHD.DataSource = ds.Tables("Hoa_Don")
        dgvHD.DataSource = bsHD
        bsHD.ResetBindings(False)
    End Sub

    Private Sub frmHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillHD()
    End Sub

    Private Sub dgvHD_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHD.SelectionChanged
        Try
            Dim RowView As DataRowView = bsHD.Current
            Dim Row As DataRow = RowView.Row

            txtMaHD.Text = Row("MaHD")
            txtMaKH.Text = Row("MaKH")
            txtKH.Text = Row("TenKH")
            txtMaSP.Text = Row("MaSP")
            txtSP.Text = Row("TenSP")
            txtSoLuong.Text = Row("SoLuong")
            dtpHD.Text = Row("NgayLapHD")
            txtThanhtien.Text = Row("ThanhTien")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        FillHD()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ngay As String
        ngay = Mid(dtpHD.Text, 7, 4) + Mid(dtpHD.Text, 4, 2) + Mid(dtpHD.Text, 1, 2)

        Dim Sql As String =
            <sql>
                INSERT INTO Hoa_Don(MaHD, MaKH, NgayLapHD)
                VALUES  ('{0}','{1}','{2}')
            </sql>
        Sql = String.Format(Sql, txtMaHD.Text, txtMaKH.Text, ngay)
        ExecuteNonQuery(Sql)

        Dim Sql1 As String =
            <sql>
                INSERT INTO Chi_Tiet_Hoa_Don(MaHD, MaSP, SoLuong)
                VALUES  ('{0}','{1}','{2}')
            </sql>
        Sql1 = String.Format(Sql1, txtMaHD.Text, txtMaSP.Text, txtSoLuong.Text)
        ExecuteNonQuery(Sql1)

        FillHD()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtKH.Clear()
        txtMaHD.Clear()
        txtMaKH.Clear()
        txtMaSP.Clear()
        txtSoLuong.Clear()
        txtSP.Clear()
        txtThanhtien.Clear()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                delete from Hoa_Don where (MaHD = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaHD.Text)

        ExecuteNonQuery(Sql)

        FillHD()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ngay As String
        ngay = Mid(dtpHD.Text, 7, 4) + Mid(dtpHD.Text, 4, 2) + Mid(dtpHD.Text, 1, 2)

        Dim Sql As String =
            <sql>
                UPDATE  Hoa_Don
                SET     MaKH ='{0}', NgayLapHD ='{1}'
                WHERE   (MaHD = '{2}')
            </sql>
        Sql = String.Format(Sql, txtMaKH.Text, ngay, txtMaHD.Text)
        ExecuteNonQuery(Sql)

        Dim Sql1 As String =
            <sql>
                UPDATE  Chi_Tiet_Hoa_Don
                SET     MaSP = '{0}', SoLuong = {1}
                WHERE   (MaHD = '{2}')
            </sql>
        Sql1 = String.Format(Sql1, txtMaSP.Text, txtSoLuong.Text, txtMaHD.Text)
        ExecuteNonQuery(Sql1)

        FillHD()
    End Sub
End Class