﻿Public Class frmHome

    Private Sub btnKH_MouseMove(sender As Object, e As MouseEventArgs) Handles btnKH.MouseMove
        lblGrKH.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnKH_MouseLeave(sender As Object, e As EventArgs) Handles btnKH.MouseLeave
        lblGrKH.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnSP_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSP.MouseMove
        lblGrSP.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnSP_MouseLeave(sender As Object, e As EventArgs) Handles btnSP.MouseLeave
        lblGrSP.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnHD_MouseMove(sender As Object, e As MouseEventArgs) Handles btnHD.MouseMove
        lblGrHD.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnHD_MouseLeave(sender As Object, e As EventArgs) Handles btnHD.MouseLeave
        lblGrHD.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnInf_MouseMove(sender As Object, e As MouseEventArgs) Handles btnInf.MouseMove
        lblGrInf.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub btnInf_MouseLeave(sender As Object, e As EventArgs) Handles btnInf.MouseLeave
        lblGrInf.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnKH_Click(sender As Object, e As EventArgs) Handles btnKH.Click
        Me.Hide()
        frmKH.Show()
    End Sub

    Private Sub btnSP_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        Me.Hide()
        frmSP.Show()
    End Sub

    Private Sub btnHD_Click(sender As Object, e As EventArgs) Handles btnHD.Click
        Me.Hide()
        frmHD.Show()
    End Sub
End Class
