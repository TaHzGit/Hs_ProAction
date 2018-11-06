<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autodata_Promotion
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbx1 = New System.Windows.Forms.Label()
        Me.txt0 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.gv1 = New System.Windows.Forms.DataGridView()
        Me.gv2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.gv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbx1
        '
        Me.lbx1.AutoSize = True
        Me.lbx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbx1.Location = New System.Drawing.Point(265, 28)
        Me.lbx1.Name = "lbx1"
        Me.lbx1.Size = New System.Drawing.Size(0, 18)
        Me.lbx1.TabIndex = 0
        '
        'txt0
        '
        Me.txt0.Location = New System.Drawing.Point(12, 78)
        Me.txt0.Multiline = True
        Me.txt0.Name = "txt0"
        Me.txt0.Size = New System.Drawing.Size(1057, 195)
        Me.txt0.TabIndex = 3
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 279)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(1057, 232)
        Me.txt1.TabIndex = 4
        '
        'gv1
        '
        Me.gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv1.Location = New System.Drawing.Point(1095, 290)
        Me.gv1.Name = "gv1"
        Me.gv1.Size = New System.Drawing.Size(240, 202)
        Me.gv1.TabIndex = 5
        '
        'gv2
        '
        Me.gv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv2.Location = New System.Drawing.Point(1095, 78)
        Me.gv2.Name = "gv2"
        Me.gv2.Size = New System.Drawing.Size(240, 195)
        Me.gv2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(693, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 7
        '
        'Autodata_Promotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gv2)
        Me.Controls.Add(Me.gv1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt0)
        Me.Controls.Add(Me.lbx1)
        Me.Name = "Autodata_Promotion"
        Me.Text = "Autodata Promotion"
        CType(Me.gv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbx1 As Label
    Friend WithEvents txt0 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents gv1 As DataGridView
    Friend WithEvents gv2 As DataGridView
    Friend WithEvents Label1 As Label
End Class
