<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJOUnload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJOUnload))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblActualRuntime = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblP2Reject = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblP1Reject = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblP2Output = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblActualOutput = New System.Windows.Forms.Label()
        Me.lblPlanOutput = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblP1Output = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCycleTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMoldNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblShiftCode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblJOCode = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtRejectP2 = New System.Windows.Forms.TextBox()
        Me.txtRejectP1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSaveReject = New FontAwesome.Sharp.IconButton()
        Me.btnUpdateUnload = New FontAwesome.Sharp.IconButton()
        Me.IconSplitButton1 = New FontAwesome.Sharp.IconSplitButton()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblProcessIncomplete = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNLOADING JOB ORDER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.lblActualRuntime)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.lblP2Reject)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lblP1Reject)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.lblP2Output)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblActualOutput)
        Me.GroupBox1.Controls.Add(Me.lblPlanOutput)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblP1Output)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblEndTime)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblStartTime)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblCycleTime)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblMoldNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblShiftCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblJOCode)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 435)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Order Updated Details:"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(288, 212)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(62, 31)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "mins"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActualRuntime
        '
        Me.lblActualRuntime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualRuntime.Location = New System.Drawing.Point(194, 211)
        Me.lblActualRuntime.Name = "lblActualRuntime"
        Me.lblActualRuntime.Size = New System.Drawing.Size(95, 31)
        Me.lblActualRuntime.TabIndex = 0
        Me.lblActualRuntime.Text = "000000"
        Me.lblActualRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(288, 395)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 31)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "pcs"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblP2Reject
        '
        Me.lblP2Reject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Reject.Location = New System.Drawing.Point(194, 394)
        Me.lblP2Reject.Name = "lblP2Reject"
        Me.lblP2Reject.Size = New System.Drawing.Size(95, 31)
        Me.lblP2Reject.TabIndex = 0
        Me.lblP2Reject.Text = "000000"
        Me.lblP2Reject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(288, 365)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 31)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "pcs"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblP1Reject
        '
        Me.lblP1Reject.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Reject.Location = New System.Drawing.Point(194, 364)
        Me.lblP1Reject.Name = "lblP1Reject"
        Me.lblP1Reject.Size = New System.Drawing.Size(95, 31)
        Me.lblP1Reject.TabIndex = 0
        Me.lblP1Reject.Text = "000000"
        Me.lblP1Reject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Actual Run Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Part No.2 Reject:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 367)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(175, 25)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Part No.1 Reject:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(288, 335)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 31)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "pcs"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblP2Output
        '
        Me.lblP2Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Output.Location = New System.Drawing.Point(194, 334)
        Me.lblP2Output.Name = "lblP2Output"
        Me.lblP2Output.Size = New System.Drawing.Size(95, 31)
        Me.lblP2Output.TabIndex = 0
        Me.lblP2Output.Text = "000000"
        Me.lblP2Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 337)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Part No.2 Output:"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(288, 274)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 31)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "pcs"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 31)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "pcs"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActualOutput
        '
        Me.lblActualOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualOutput.Location = New System.Drawing.Point(194, 273)
        Me.lblActualOutput.Name = "lblActualOutput"
        Me.lblActualOutput.Size = New System.Drawing.Size(95, 31)
        Me.lblActualOutput.TabIndex = 0
        Me.lblActualOutput.Text = "000000"
        Me.lblActualOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlanOutput
        '
        Me.lblPlanOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanOutput.Location = New System.Drawing.Point(194, 242)
        Me.lblPlanOutput.Name = "lblPlanOutput"
        Me.lblPlanOutput.Size = New System.Drawing.Size(95, 31)
        Me.lblPlanOutput.TabIndex = 0
        Me.lblPlanOutput.Text = "000000"
        Me.lblPlanOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(288, 305)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 31)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "pcs"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(65, 276)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 25)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Total Shots:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "JO Plan Output:"
        '
        'lblP1Output
        '
        Me.lblP1Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Output.Location = New System.Drawing.Point(194, 304)
        Me.lblP1Output.Name = "lblP1Output"
        Me.lblP1Output.Size = New System.Drawing.Size(95, 31)
        Me.lblP1Output.TabIndex = 0
        Me.lblP1Output.Text = "000000"
        Me.lblP1Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Part No.1 Output:"
        '
        'lblEndTime
        '
        Me.lblEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.Location = New System.Drawing.Point(194, 181)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(237, 31)
        Me.lblEndTime.TabIndex = 0
        Me.lblEndTime.Text = "-"
        Me.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(83, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "End Time:"
        '
        'lblStartTime
        '
        Me.lblStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(194, 151)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(237, 31)
        Me.lblStartTime.TabIndex = 0
        Me.lblStartTime.Text = "-"
        Me.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(233, 119)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 31)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "sec"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Start Time:"
        '
        'lblCycleTime
        '
        Me.lblCycleTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCycleTime.Location = New System.Drawing.Point(194, 118)
        Me.lblCycleTime.Name = "lblCycleTime"
        Me.lblCycleTime.Size = New System.Drawing.Size(44, 31)
        Me.lblCycleTime.TabIndex = 0
        Me.lblCycleTime.Text = "00"
        Me.lblCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Cycle Time:"
        '
        'lblMoldNo
        '
        Me.lblMoldNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoldNo.Location = New System.Drawing.Point(194, 88)
        Me.lblMoldNo.Name = "lblMoldNo"
        Me.lblMoldNo.Size = New System.Drawing.Size(213, 31)
        Me.lblMoldNo.TabIndex = 0
        Me.lblMoldNo.Text = "0"
        Me.lblMoldNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Mold No.:"
        '
        'lblShiftCode
        '
        Me.lblShiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShiftCode.Location = New System.Drawing.Point(194, 28)
        Me.lblShiftCode.Name = "lblShiftCode"
        Me.lblShiftCode.Size = New System.Drawing.Size(213, 31)
        Me.lblShiftCode.TabIndex = 0
        Me.lblShiftCode.Text = "-"
        Me.lblShiftCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Shift Code:"
        '
        'lblJOCode
        '
        Me.lblJOCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJOCode.Location = New System.Drawing.Point(194, 58)
        Me.lblJOCode.Name = "lblJOCode"
        Me.lblJOCode.Size = New System.Drawing.Size(213, 31)
        Me.lblJOCode.TabIndex = 0
        Me.lblJOCode.Text = "-"
        Me.lblJOCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(90, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "JO Code:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtRejectP2)
        Me.GroupBox2.Controls.Add(Me.txtRejectP1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(485, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 116)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reject Details Entry:"
        '
        'TxtRejectP2
        '
        Me.TxtRejectP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRejectP2.Location = New System.Drawing.Point(142, 63)
        Me.TxtRejectP2.MaxLength = 4
        Me.TxtRejectP2.Name = "TxtRejectP2"
        Me.TxtRejectP2.Size = New System.Drawing.Size(128, 29)
        Me.TxtRejectP2.TabIndex = 1
        '
        'txtRejectP1
        '
        Me.txtRejectP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRejectP1.Location = New System.Drawing.Point(142, 32)
        Me.txtRejectP1.MaxLength = 4
        Me.txtRejectP1.Name = "txtRejectP1"
        Me.txtRejectP1.Size = New System.Drawing.Size(128, 29)
        Me.txtRejectP1.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(276, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 25)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "pcs"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(22, 34)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 25)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Part No. 1:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(276, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 25)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "pcs"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(22, 65)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 25)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Part No. 2:"
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 25
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(530, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(144, 40)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSaveReject
        '
        Me.btnSaveReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveReject.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btnSaveReject.IconColor = System.Drawing.Color.Black
        Me.btnSaveReject.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveReject.IconSize = 25
        Me.btnSaveReject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveReject.Location = New System.Drawing.Point(680, 320)
        Me.btnSaveReject.Name = "btnSaveReject"
        Me.btnSaveReject.Size = New System.Drawing.Size(144, 40)
        Me.btnSaveReject.TabIndex = 5
        Me.btnSaveReject.Text = "Save"
        Me.btnSaveReject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveReject.UseVisualStyleBackColor = True
        '
        'btnUpdateUnload
        '
        Me.btnUpdateUnload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateUnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUnload.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btnUpdateUnload.IconColor = System.Drawing.Color.Black
        Me.btnUpdateUnload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdateUnload.IconSize = 25
        Me.btnUpdateUnload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateUnload.Location = New System.Drawing.Point(255, 497)
        Me.btnUpdateUnload.Name = "btnUpdateUnload"
        Me.btnUpdateUnload.Size = New System.Drawing.Size(224, 40)
        Me.btnUpdateUnload.TabIndex = 5
        Me.btnUpdateUnload.Text = "Update and Unload"
        Me.btnUpdateUnload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateUnload.UseVisualStyleBackColor = True
        '
        'IconSplitButton1
        '
        Me.IconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconSplitButton1.IconColor = System.Drawing.Color.Black
        Me.IconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSplitButton1.IconSize = 48
        Me.IconSplitButton1.Name = "IconSplitButton1"
        Me.IconSplitButton1.Rotation = 0R
        Me.IconSplitButton1.Size = New System.Drawing.Size(23, 23)
        Me.IconSplitButton1.Text = "IconSplitButton1"
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblProcessIncomplete)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(485, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 110)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Overall Status:"
        '
        'lblProcessIncomplete
        '
        Me.lblProcessIncomplete.BackColor = System.Drawing.Color.DarkRed
        Me.lblProcessIncomplete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProcessIncomplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessIncomplete.ForeColor = System.Drawing.Color.White
        Me.lblProcessIncomplete.Location = New System.Drawing.Point(3, 22)
        Me.lblProcessIncomplete.Name = "lblProcessIncomplete"
        Me.lblProcessIncomplete.Size = New System.Drawing.Size(333, 85)
        Me.lblProcessIncomplete.TabIndex = 0
        Me.lblProcessIncomplete.Text = "PROCESS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INCOMPLETE"
        Me.lblProcessIncomplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmJOUnload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 551)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveReject)
        Me.Controls.Add(Me.btnUpdateUnload)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJOUnload"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Unload JO Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblP1Reject As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblP2Output As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblP1Output As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCycleTime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMoldNo As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblJOCode As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblShiftCode As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtRejectP2 As TextBox
    Friend WithEvents txtRejectP1 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveReject As FontAwesome.Sharp.IconButton
    Friend WithEvents lblActualRuntime As Label
    Friend WithEvents lblP2Reject As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdateUnload As FontAwesome.Sharp.IconButton
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents IconSplitButton1 As FontAwesome.Sharp.IconSplitButton
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents Label20 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblActualOutput As Label
    Friend WithEvents lblPlanOutput As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblProcessIncomplete As Label
End Class
