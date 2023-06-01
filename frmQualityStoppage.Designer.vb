<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQualityStoppage
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQAStoppageCM = New System.Windows.Forms.Label()
        Me.btnFail = New FontAwesome.Sharp.IconButton()
        Me.btnPass = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFailFreq = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(239, 168)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(204, 77)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "Save"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(430, 39)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quality Stoppage Details:"
        '
        'IconButton2
        '
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(13, 168)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(204, 77)
        Me.IconButton2.TabIndex = 0
        Me.IconButton2.Text = "Clear"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "QUALITY VERIFICATION:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quality Stoppage Details:"
        '
        'lblQAStoppageCM
        '
        Me.lblQAStoppageCM.AutoSize = True
        Me.lblQAStoppageCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQAStoppageCM.Location = New System.Drawing.Point(8, 129)
        Me.lblQAStoppageCM.Name = "lblQAStoppageCM"
        Me.lblQAStoppageCM.Size = New System.Drawing.Size(21, 29)
        Me.lblQAStoppageCM.TabIndex = 2
        Me.lblQAStoppageCM.Text = "-"
        '
        'btnFail
        '
        Me.btnFail.BackColor = System.Drawing.Color.DarkRed
        Me.btnFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFail.ForeColor = System.Drawing.Color.White
        Me.btnFail.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnFail.IconColor = System.Drawing.Color.White
        Me.btnFail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFail.Location = New System.Drawing.Point(14, 64)
        Me.btnFail.Name = "btnFail"
        Me.btnFail.Size = New System.Drawing.Size(204, 77)
        Me.btnFail.TabIndex = 10
        Me.btnFail.Text = "Fail"
        Me.btnFail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFail.UseVisualStyleBackColor = False
        '
        'btnPass
        '
        Me.btnPass.BackColor = System.Drawing.Color.Green
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.ForeColor = System.Drawing.Color.White
        Me.btnPass.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnPass.IconColor = System.Drawing.Color.White
        Me.btnPass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPass.Location = New System.Drawing.Point(240, 64)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(204, 77)
        Me.btnPass.TabIndex = 11
        Me.btnPass.Text = "Pass"
        Me.btnPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblQAStoppageCM)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.IconButton2)
        Me.GroupBox1.Controls.Add(Me.IconButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 262)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quality Stoppage Entry:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFail)
        Me.GroupBox2.Controls.Add(Me.btnPass)
        Me.GroupBox2.Controls.Add(Me.lblFailFreq)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 188)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Verification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fail Freq: "
        '
        'lblFailFreq
        '
        Me.lblFailFreq.AutoSize = True
        Me.lblFailFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailFreq.Location = New System.Drawing.Point(159, 149)
        Me.lblFailFreq.Name = "lblFailFreq"
        Me.lblFailFreq.Size = New System.Drawing.Size(26, 29)
        Me.lblFailFreq.TabIndex = 2
        Me.lblFailFreq.Text = "0"
        '
        'frmQualityStoppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 484)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQualityStoppage"
        Me.ShowIcon = False
        Me.Text = "Quality Stoppage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQAStoppageCM As Label
    Friend WithEvents btnFail As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPass As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFailFreq As Label
    Friend WithEvents Label4 As Label
End Class
