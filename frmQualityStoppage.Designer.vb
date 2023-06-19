<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQualityStoppage
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.cboQAStoppage = New System.Windows.Forms.ComboBox()
        Me.MListQualityStoppageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPSDataSet3 = New SPSApp1.SPSDataSet3()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFail = New FontAwesome.Sharp.IconButton()
        Me.btnPass = New FontAwesome.Sharp.IconButton()
        Me.grpQAStoppageDetails = New System.Windows.Forms.GroupBox()
        Me.cboCountermeasure = New System.Windows.Forms.ComboBox()
        Me.MListQualityCountermeasureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPSDataSet4 = New SPSApp1.SPSDataSet4()
        Me.grpQAVerification = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFailFreq = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MListQualityStoppageTableAdapter = New SPSApp1.SPSDataSet3TableAdapters.MListQualityStoppageTableAdapter()
        Me.lblUserLog = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblJOCode = New System.Windows.Forms.Label()
        Me.MListQualityCountermeasureTableAdapter = New SPSApp1.SPSDataSet4TableAdapters.MListQualityCountermeasureTableAdapter()
        Me.lblQAStoppage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MListQualityStoppageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQAStoppageDetails.SuspendLayout()
        CType(Me.MListQualityCountermeasureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQAVerification.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.Location = New System.Drawing.Point(239, 180)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(204, 77)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboQAStoppage
        '
        Me.cboQAStoppage.DataSource = Me.MListQualityStoppageBindingSource
        Me.cboQAStoppage.DisplayMember = "Quality_Issue"
        Me.cboQAStoppage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQAStoppage.FormattingEnabled = True
        Me.cboQAStoppage.Location = New System.Drawing.Point(13, 58)
        Me.cboQAStoppage.Name = "cboQAStoppage"
        Me.cboQAStoppage.Size = New System.Drawing.Size(430, 39)
        Me.cboQAStoppage.TabIndex = 1
        '
        'MListQualityStoppageBindingSource
        '
        Me.MListQualityStoppageBindingSource.DataMember = "MListQualityStoppage"
        Me.MListQualityStoppageBindingSource.DataSource = Me.SPSDataSet3
        '
        'SPSDataSet3
        '
        Me.SPSDataSet3.DataSetName = "SPSDataSet3"
        Me.SPSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.Location = New System.Drawing.Point(13, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 77)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 10)
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
        Me.Label3.Size = New System.Drawing.Size(198, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Countermeasure:"
        '
        'btnFail
        '
        Me.btnFail.BackColor = System.Drawing.Color.DarkRed
        Me.btnFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFail.ForeColor = System.Drawing.Color.White
        Me.btnFail.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnFail.IconColor = System.Drawing.Color.White
        Me.btnFail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFail.Location = New System.Drawing.Point(11, 42)
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
        Me.btnPass.Location = New System.Drawing.Point(237, 42)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(204, 77)
        Me.btnPass.TabIndex = 11
        Me.btnPass.Text = "Pass"
        Me.btnPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'grpQAStoppageDetails
        '
        Me.grpQAStoppageDetails.Controls.Add(Me.Label3)
        Me.grpQAStoppageDetails.Controls.Add(Me.Label1)
        Me.grpQAStoppageDetails.Controls.Add(Me.cboCountermeasure)
        Me.grpQAStoppageDetails.Controls.Add(Me.cboQAStoppage)
        Me.grpQAStoppageDetails.Controls.Add(Me.btnClear)
        Me.grpQAStoppageDetails.Controls.Add(Me.btnSave)
        Me.grpQAStoppageDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQAStoppageDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpQAStoppageDetails.Name = "grpQAStoppageDetails"
        Me.grpQAStoppageDetails.Size = New System.Drawing.Size(457, 289)
        Me.grpQAStoppageDetails.TabIndex = 12
        Me.grpQAStoppageDetails.TabStop = False
        Me.grpQAStoppageDetails.Text = "Quality Stoppage Entry:"
        '
        'cboCountermeasure
        '
        Me.cboCountermeasure.DataSource = Me.MListQualityCountermeasureBindingSource
        Me.cboCountermeasure.DisplayMember = "Countermeasure"
        Me.cboCountermeasure.Enabled = False
        Me.cboCountermeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountermeasure.FormattingEnabled = True
        Me.cboCountermeasure.Location = New System.Drawing.Point(13, 132)
        Me.cboCountermeasure.Name = "cboCountermeasure"
        Me.cboCountermeasure.Size = New System.Drawing.Size(430, 39)
        Me.cboCountermeasure.TabIndex = 1
        '
        'MListQualityCountermeasureBindingSource
        '
        Me.MListQualityCountermeasureBindingSource.DataMember = "MListQualityCountermeasure"
        Me.MListQualityCountermeasureBindingSource.DataSource = Me.SPSDataSet4
        '
        'SPSDataSet4
        '
        Me.SPSDataSet4.DataSetName = "SPSDataSet4"
        Me.SPSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpQAVerification
        '
        Me.grpQAVerification.Controls.Add(Me.Panel1)
        Me.grpQAVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQAVerification.Location = New System.Drawing.Point(12, 307)
        Me.grpQAVerification.Name = "grpQAVerification"
        Me.grpQAVerification.Size = New System.Drawing.Size(456, 188)
        Me.grpQAVerification.TabIndex = 13
        Me.grpQAVerification.TabStop = False
        Me.grpQAVerification.Text = "Verification"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Controls.Add(Me.btnFail)
        Me.Panel1.Controls.Add(Me.btnPass)
        Me.Panel1.Controls.Add(Me.lblFailFreq)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 163)
        Me.Panel1.TabIndex = 12
        '
        'lblFailFreq
        '
        Me.lblFailFreq.AutoSize = True
        Me.lblFailFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailFreq.Location = New System.Drawing.Point(156, 127)
        Me.lblFailFreq.Name = "lblFailFreq"
        Me.lblFailFreq.Size = New System.Drawing.Size(26, 29)
        Me.lblFailFreq.TabIndex = 2
        Me.lblFailFreq.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fail Freq: "
        '
        'MListQualityStoppageTableAdapter
        '
        Me.MListQualityStoppageTableAdapter.ClearBeforeFill = True
        '
        'lblUserLog
        '
        Me.lblUserLog.AutoSize = True
        Me.lblUserLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLog.Location = New System.Drawing.Point(207, 502)
        Me.lblUserLog.Name = "lblUserLog"
        Me.lblUserLog.Size = New System.Drawing.Size(70, 20)
        Me.lblUserLog.TabIndex = 14
        Me.lblUserLog.Text = "UserLog"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Current User Logged In:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(544, 21)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(64, 20)
        Me.lblUserID.TabIndex = 14
        Me.lblUserID.Text = "User ID"
        '
        'lblJOCode
        '
        Me.lblJOCode.AutoSize = True
        Me.lblJOCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJOCode.Location = New System.Drawing.Point(544, 45)
        Me.lblJOCode.Name = "lblJOCode"
        Me.lblJOCode.Size = New System.Drawing.Size(71, 20)
        Me.lblJOCode.TabIndex = 14
        Me.lblJOCode.Text = "JO Code"
        '
        'MListQualityCountermeasureTableAdapter
        '
        Me.MListQualityCountermeasureTableAdapter.ClearBeforeFill = True
        '
        'lblQAStoppage
        '
        Me.lblQAStoppage.AutoSize = True
        Me.lblQAStoppage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQAStoppage.Location = New System.Drawing.Point(656, 70)
        Me.lblQAStoppage.Name = "lblQAStoppage"
        Me.lblQAStoppage.Size = New System.Drawing.Size(0, 20)
        Me.lblQAStoppage.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(544, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "QAStoppage:"
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'frmQualityStoppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 534)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblQAStoppage)
        Me.Controls.Add(Me.lblJOCode)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblUserLog)
        Me.Controls.Add(Me.grpQAVerification)
        Me.Controls.Add(Me.grpQAStoppageDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQualityStoppage"
        Me.ShowIcon = False
        Me.Text = "Quality Stoppage"
        CType(Me.MListQualityStoppageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQAStoppageDetails.ResumeLayout(False)
        Me.grpQAStoppageDetails.PerformLayout()
        CType(Me.MListQualityCountermeasureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQAVerification.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents cboQAStoppage As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFail As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPass As FontAwesome.Sharp.IconButton
    Friend WithEvents grpQAStoppageDetails As GroupBox
    Friend WithEvents grpQAVerification As GroupBox
    Friend WithEvents lblFailFreq As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SPSDataSet3 As SPSDataSet3
    Friend WithEvents MListQualityStoppageBindingSource As BindingSource
    Friend WithEvents MListQualityStoppageTableAdapter As SPSDataSet3TableAdapters.MListQualityStoppageTableAdapter
    Friend WithEvents lblUserLog As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblJOCode As Label
    Friend WithEvents cboCountermeasure As ComboBox
    Friend WithEvents SPSDataSet4 As SPSDataSet4
    Friend WithEvents MListQualityCountermeasureBindingSource As BindingSource
    Friend WithEvents MListQualityCountermeasureTableAdapter As SPSDataSet4TableAdapters.MListQualityCountermeasureTableAdapter
    Friend WithEvents lblQAStoppage As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tmrRealTimeCheck As Timer
End Class
