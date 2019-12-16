<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKecilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPengarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenerbitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1282, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataAnggotaToolStripMenuItem, Me.DataKecilToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Anggota"
        '
        'DataKecilToolStripMenuItem
        '
        Me.DataKecilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPengarangToolStripMenuItem, Me.DataPenerbitToolStripMenuItem})
        Me.DataKecilToolStripMenuItem.Name = "DataKecilToolStripMenuItem"
        Me.DataKecilToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DataKecilToolStripMenuItem.Text = "Data Kecil"
        '
        'DataPengarangToolStripMenuItem
        '
        Me.DataPengarangToolStripMenuItem.Name = "DataPengarangToolStripMenuItem"
        Me.DataPengarangToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.DataPengarangToolStripMenuItem.Text = "Data Pengarang"
        '
        'DataPenerbitToolStripMenuItem
        '
        Me.DataPenerbitToolStripMenuItem.Name = "DataPenerbitToolStripMenuItem"
        Me.DataPenerbitToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.DataPenerbitToolStripMenuItem.Text = "Data Penerbit"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKecilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPengarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenerbitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
