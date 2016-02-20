<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.lblGrKH = New System.Windows.Forms.Label()
        Me.lblKH = New System.Windows.Forms.Label()
        Me.lblGrSP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGrHD = New System.Windows.Forms.Label()
        Me.lblGrInf = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInf = New System.Windows.Forms.Button()
        Me.btnHD = New System.Windows.Forms.Button()
        Me.btnSP = New System.Windows.Forms.Button()
        Me.btnKH = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGrKH
        '
        Me.lblGrKH.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrKH.Location = New System.Drawing.Point(12, 9)
        Me.lblGrKH.Name = "lblGrKH"
        Me.lblGrKH.Size = New System.Drawing.Size(240, 110)
        Me.lblGrKH.TabIndex = 0
        '
        'lblKH
        '
        Me.lblKH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblKH.Location = New System.Drawing.Point(112, 24)
        Me.lblKH.Name = "lblKH"
        Me.lblKH.Size = New System.Drawing.Size(125, 80)
        Me.lblKH.TabIndex = 2
        Me.lblKH.Text = "Xem và cập nhập thông tin khách hàng"
        Me.lblKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrSP
        '
        Me.lblGrSP.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrSP.Location = New System.Drawing.Point(267, 9)
        Me.lblGrSP.Name = "lblGrSP"
        Me.lblGrSP.Size = New System.Drawing.Size(240, 110)
        Me.lblGrSP.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 80)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Xem và cập nhập thông tin sản phẩm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrHD
        '
        Me.lblGrHD.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrHD.Location = New System.Drawing.Point(12, 134)
        Me.lblGrHD.Name = "lblGrHD"
        Me.lblGrHD.Size = New System.Drawing.Size(240, 110)
        Me.lblGrHD.TabIndex = 0
        '
        'lblGrInf
        '
        Me.lblGrInf.BackColor = System.Drawing.SystemColors.Control
        Me.lblGrInf.Location = New System.Drawing.Point(267, 134)
        Me.lblGrInf.Name = "lblGrInf"
        Me.lblGrInf.Size = New System.Drawing.Size(240, 110)
        Me.lblGrInf.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 80)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Xem và cập nhập thông tin hóa đơn"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 80)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Thông tin phần mềm"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnInf
        '
        Me.btnInf.BackgroundImage = Global.QL_Ban_Hang.My.Resources.Resources.info
        Me.btnInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInf.Location = New System.Drawing.Point(281, 150)
        Me.btnInf.Name = "btnInf"
        Me.btnInf.Size = New System.Drawing.Size(80, 80)
        Me.btnInf.TabIndex = 1
        Me.btnInf.TabStop = False
        Me.btnInf.UseVisualStyleBackColor = True
        '
        'btnHD
        '
        Me.btnHD.BackgroundImage = Global.QL_Ban_Hang.My.Resources.Resources.invoice
        Me.btnHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHD.Location = New System.Drawing.Point(26, 150)
        Me.btnHD.Name = "btnHD"
        Me.btnHD.Size = New System.Drawing.Size(80, 80)
        Me.btnHD.TabIndex = 1
        Me.btnHD.TabStop = False
        Me.btnHD.UseVisualStyleBackColor = True
        '
        'btnSP
        '
        Me.btnSP.BackgroundImage = Global.QL_Ban_Hang.My.Resources.Resources.product
        Me.btnSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSP.Location = New System.Drawing.Point(281, 25)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(80, 80)
        Me.btnSP.TabIndex = 1
        Me.btnSP.TabStop = False
        Me.btnSP.UseVisualStyleBackColor = True
        '
        'btnKH
        '
        Me.btnKH.BackgroundImage = Global.QL_Ban_Hang.My.Resources.Resources.customer
        Me.btnKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKH.Location = New System.Drawing.Point(26, 25)
        Me.btnKH.Name = "btnKH"
        Me.btnKH.Size = New System.Drawing.Size(80, 80)
        Me.btnKH.TabIndex = 1
        Me.btnKH.TabStop = False
        Me.btnKH.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 257)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblKH)
        Me.Controls.Add(Me.btnInf)
        Me.Controls.Add(Me.btnHD)
        Me.Controls.Add(Me.btnSP)
        Me.Controls.Add(Me.lblGrInf)
        Me.Controls.Add(Me.btnKH)
        Me.Controls.Add(Me.lblGrHD)
        Me.Controls.Add(Me.lblGrSP)
        Me.Controls.Add(Me.lblGrKH)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý bán hàng"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblGrKH As System.Windows.Forms.Label
    Friend WithEvents btnKH As System.Windows.Forms.Button
    Friend WithEvents lblKH As System.Windows.Forms.Label
    Friend WithEvents lblGrSP As System.Windows.Forms.Label
    Friend WithEvents btnSP As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGrHD As System.Windows.Forms.Label
    Friend WithEvents lblGrInf As System.Windows.Forms.Label
    Friend WithEvents btnHD As System.Windows.Forms.Button
    Friend WithEvents btnInf As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
