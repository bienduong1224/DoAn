<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiem
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dgvDiem = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(361, 358)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(122, 42)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dgvDiem
        '
        Me.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiem.Location = New System.Drawing.Point(30, 12)
        Me.dgvDiem.Name = "dgvDiem"
        Me.dgvDiem.RowTemplate.Height = 24
        Me.dgvDiem.Size = New System.Drawing.Size(812, 322)
        Me.dgvDiem.TabIndex = 4
        '
        'frmDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 427)
        Me.Controls.Add(Me.dgvDiem)
        Me.Controls.Add(Me.btnThoat)
        Me.Name = "frmDiem"
        Me.Text = "DiemSV"
        CType(Me.dgvDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnThoat As Button
    Friend WithEvents dgvDiem As DataGridView
End Class
