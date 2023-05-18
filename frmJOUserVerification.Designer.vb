<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJOUserVerification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtJOVerification = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPSApp1.My.Resources.Resources.PwConfirmation
        Me.PictureBox1.Location = New System.Drawing.Point(24, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtJOVerification
        '
        Me.txtJOVerification.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJOVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJOVerification.Location = New System.Drawing.Point(34, 46)
        Me.txtJOVerification.Name = "txtJOVerification"
        Me.txtJOVerification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtJOVerification.Size = New System.Drawing.Size(334, 31)
        Me.txtJOVerification.TabIndex = 1
        Me.txtJOVerification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please scan QR Code ID:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.ArrowTurnDown
        Me.btnConfirm.IconColor = System.Drawing.Color.Black
        Me.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConfirm.IconSize = 20
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.Location = New System.Drawing.Point(243, 123)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(131, 42)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "   &Confirm"
        Me.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmJOUserVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 186)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJOVerification)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJOUserVerification"
        Me.Text = "Transaction Verification"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtJOVerification As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirm As FontAwesome.Sharp.IconButton
End Class
