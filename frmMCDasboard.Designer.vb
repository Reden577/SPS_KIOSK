﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMCDasboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCDasboard))
        Me.lblMCDasboard = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblPerformance = New System.Windows.Forms.Label()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.lblPPT = New System.Windows.Forms.Label()
        Me.lblART = New System.Windows.Forms.Label()
        Me.lblUPDT = New System.Windows.Forms.Label()
        Me.lblPlannedQTY = New System.Windows.Forms.Label()
        Me.lblActualQty0 = New System.Windows.Forms.Label()
        Me.lblActualQty1 = New System.Windows.Forms.Label()
        Me.lblRejectQty = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblJobOrderCode = New System.Windows.Forms.Label()
        Me.lblPartNo1 = New System.Windows.Forms.Label()
        Me.lblMoldNo = New System.Windows.Forms.Label()
        Me.RealtimeUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblCavQtyP1 = New System.Windows.Forms.Label()
        Me.lblDateTimeStart = New System.Windows.Forms.Label()
        Me.lblCycleTime = New System.Windows.Forms.Label()
        Me.lblOutputP1 = New System.Windows.Forms.Label()
        Me.lblPartNo2 = New System.Windows.Forms.Label()
        Me.lblCavQtyP2 = New System.Windows.Forms.Label()
        Me.lblOutputP2 = New System.Windows.Forms.Label()
        Me.lblOEE = New System.Windows.Forms.Label()
        Me.dgvStoppage = New System.Windows.Forms.DataGridView()
        Me.DTimeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftCodeFKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTCountermeasureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AckDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlDTminsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlRprTminsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForQAVerificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlQAVeriminsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlFailFreqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DowntimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPSDataSet1 = New SPSApp1.SPSDataSet1()
        Me.cboShiftCode = New System.Windows.Forms.ComboBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.lblQAInfoDetails = New System.Windows.Forms.Label()
        Me.SPSDataSet = New SPSApp1.SPSDataSet()
        Me.SPSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DowntimeTableAdapter = New SPSApp1.SPSDataSet1TableAdapters.DowntimeTableAdapter()
        Me.btnBypass = New FontAwesome.Sharp.IconButton()
        Me.lblQualityBtn = New FontAwesome.Sharp.IconButton()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.btnFilter = New FontAwesome.Sharp.IconButton()
        Me.picMCStatus = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtMsgBox = New System.Windows.Forms.TextBox()
        Me.btnClearMsg = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ttpPPT = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpART = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpUDT = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpPQTY = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ttpAQTY = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ttpRQTY = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ttpEraseMessage = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSaveMsg = New FontAwesome.Sharp.IconButton()
        Me.ttpSaveMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpMsgBox = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DowntimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMCStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMCDasboard
        '
        Me.lblMCDasboard.AutoSize = True
        Me.lblMCDasboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMCDasboard.Location = New System.Drawing.Point(7, 3)
        Me.lblMCDasboard.Name = "lblMCDasboard"
        Me.lblMCDasboard.Size = New System.Drawing.Size(153, 31)
        Me.lblMCDasboard.TabIndex = 0
        Me.lblMCDasboard.Text = "Machine 00"
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.ForeColor = System.Drawing.Color.White
        Me.lblShift.Location = New System.Drawing.Point(682, 37)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(154, 26)
        Me.lblShift.TabIndex = 3
        Me.lblShift.Text = "D"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAvailability
        '
        Me.lblAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.ForeColor = System.Drawing.Color.White
        Me.lblAvailability.Location = New System.Drawing.Point(153, 209)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(89, 26)
        Me.lblAvailability.TabIndex = 3
        Me.lblAvailability.Text = "0.00"
        Me.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPerformance
        '
        Me.lblPerformance.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPerformance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerformance.ForeColor = System.Drawing.Color.White
        Me.lblPerformance.Location = New System.Drawing.Point(158, 355)
        Me.lblPerformance.Name = "lblPerformance"
        Me.lblPerformance.Size = New System.Drawing.Size(84, 26)
        Me.lblPerformance.TabIndex = 3
        Me.lblPerformance.Text = "0.00"
        Me.lblPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuality
        '
        Me.lblQuality.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuality.ForeColor = System.Drawing.Color.White
        Me.lblQuality.Location = New System.Drawing.Point(153, 470)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(89, 26)
        Me.lblQuality.TabIndex = 3
        Me.lblQuality.Text = "0.00"
        Me.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPPT
        '
        Me.lblPPT.BackColor = System.Drawing.Color.White
        Me.lblPPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPPT.Location = New System.Drawing.Point(138, 245)
        Me.lblPPT.Name = "lblPPT"
        Me.lblPPT.Size = New System.Drawing.Size(89, 26)
        Me.lblPPT.TabIndex = 3
        Me.lblPPT.Text = "0"
        Me.lblPPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblART
        '
        Me.lblART.BackColor = System.Drawing.Color.White
        Me.lblART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblART.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblART.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblART.Location = New System.Drawing.Point(138, 273)
        Me.lblART.Name = "lblART"
        Me.lblART.Size = New System.Drawing.Size(89, 26)
        Me.lblART.TabIndex = 3
        Me.lblART.Text = "0"
        Me.lblART.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUPDT
        '
        Me.lblUPDT.BackColor = System.Drawing.Color.White
        Me.lblUPDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUPDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUPDT.Location = New System.Drawing.Point(138, 302)
        Me.lblUPDT.Name = "lblUPDT"
        Me.lblUPDT.Size = New System.Drawing.Size(89, 26)
        Me.lblUPDT.TabIndex = 3
        Me.lblUPDT.Text = "0"
        Me.lblUPDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlannedQTY
        '
        Me.lblPlannedQTY.BackColor = System.Drawing.Color.White
        Me.lblPlannedQTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPlannedQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlannedQTY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPlannedQTY.Location = New System.Drawing.Point(88, 393)
        Me.lblPlannedQTY.Name = "lblPlannedQTY"
        Me.lblPlannedQTY.Size = New System.Drawing.Size(138, 26)
        Me.lblPlannedQTY.TabIndex = 3
        Me.lblPlannedQTY.Text = "0"
        Me.lblPlannedQTY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblActualQty0
        '
        Me.lblActualQty0.BackColor = System.Drawing.Color.White
        Me.lblActualQty0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblActualQty0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQty0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblActualQty0.Location = New System.Drawing.Point(88, 422)
        Me.lblActualQty0.Name = "lblActualQty0"
        Me.lblActualQty0.Size = New System.Drawing.Size(138, 26)
        Me.lblActualQty0.TabIndex = 3
        Me.lblActualQty0.Text = "0"
        Me.lblActualQty0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblActualQty1
        '
        Me.lblActualQty1.BackColor = System.Drawing.Color.White
        Me.lblActualQty1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblActualQty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQty1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblActualQty1.Location = New System.Drawing.Point(88, 507)
        Me.lblActualQty1.Name = "lblActualQty1"
        Me.lblActualQty1.Size = New System.Drawing.Size(138, 26)
        Me.lblActualQty1.TabIndex = 3
        Me.lblActualQty1.Text = "0"
        Me.lblActualQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRejectQty
        '
        Me.lblRejectQty.BackColor = System.Drawing.Color.White
        Me.lblRejectQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRejectQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejectQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRejectQty.Location = New System.Drawing.Point(88, 536)
        Me.lblRejectQty.Name = "lblRejectQty"
        Me.lblRejectQty.Size = New System.Drawing.Size(138, 26)
        Me.lblRejectQty.TabIndex = 3
        Me.lblRejectQty.Text = "0"
        Me.lblRejectQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.White
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(418, 72)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(255, 26)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "-"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserID
        '
        Me.lblUserID.BackColor = System.Drawing.Color.White
        Me.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserID.Location = New System.Drawing.Point(418, 101)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(255, 26)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "-"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJobOrderCode
        '
        Me.lblJobOrderCode.BackColor = System.Drawing.Color.White
        Me.lblJobOrderCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblJobOrderCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobOrderCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblJobOrderCode.Location = New System.Drawing.Point(456, 139)
        Me.lblJobOrderCode.Name = "lblJobOrderCode"
        Me.lblJobOrderCode.Size = New System.Drawing.Size(204, 26)
        Me.lblJobOrderCode.TabIndex = 3
        Me.lblJobOrderCode.Text = "-"
        Me.lblJobOrderCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPartNo1
        '
        Me.lblPartNo1.BackColor = System.Drawing.Color.White
        Me.lblPartNo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPartNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPartNo1.Location = New System.Drawing.Point(396, 304)
        Me.lblPartNo1.Name = "lblPartNo1"
        Me.lblPartNo1.Size = New System.Drawing.Size(253, 26)
        Me.lblPartNo1.TabIndex = 3
        Me.lblPartNo1.Text = "-"
        Me.lblPartNo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoldNo
        '
        Me.lblMoldNo.BackColor = System.Drawing.Color.White
        Me.lblMoldNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMoldNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoldNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMoldNo.Location = New System.Drawing.Point(456, 166)
        Me.lblMoldNo.Name = "lblMoldNo"
        Me.lblMoldNo.Size = New System.Drawing.Size(288, 26)
        Me.lblMoldNo.TabIndex = 3
        Me.lblMoldNo.Text = "-"
        Me.lblMoldNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RealtimeUpdate
        '
        Me.RealtimeUpdate.Enabled = True
        '
        'lblCavQtyP1
        '
        Me.lblCavQtyP1.BackColor = System.Drawing.Color.White
        Me.lblCavQtyP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCavQtyP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCavQtyP1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCavQtyP1.Location = New System.Drawing.Point(665, 304)
        Me.lblCavQtyP1.Name = "lblCavQtyP1"
        Me.lblCavQtyP1.Size = New System.Drawing.Size(52, 26)
        Me.lblCavQtyP1.TabIndex = 3
        Me.lblCavQtyP1.Text = "0"
        Me.lblCavQtyP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTimeStart
        '
        Me.lblDateTimeStart.BackColor = System.Drawing.Color.White
        Me.lblDateTimeStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDateTimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTimeStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDateTimeStart.Location = New System.Drawing.Point(456, 223)
        Me.lblDateTimeStart.Name = "lblDateTimeStart"
        Me.lblDateTimeStart.Size = New System.Drawing.Size(268, 26)
        Me.lblDateTimeStart.TabIndex = 3
        Me.lblDateTimeStart.Text = "-"
        Me.lblDateTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCycleTime
        '
        Me.lblCycleTime.BackColor = System.Drawing.Color.White
        Me.lblCycleTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCycleTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCycleTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCycleTime.Location = New System.Drawing.Point(456, 195)
        Me.lblCycleTime.Name = "lblCycleTime"
        Me.lblCycleTime.Size = New System.Drawing.Size(268, 26)
        Me.lblCycleTime.TabIndex = 3
        Me.lblCycleTime.Text = "-"
        Me.lblCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOutputP1
        '
        Me.lblOutputP1.BackColor = System.Drawing.Color.White
        Me.lblOutputP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOutputP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputP1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOutputP1.Location = New System.Drawing.Point(729, 304)
        Me.lblOutputP1.Name = "lblOutputP1"
        Me.lblOutputP1.Size = New System.Drawing.Size(90, 26)
        Me.lblOutputP1.TabIndex = 3
        Me.lblOutputP1.Text = "0"
        Me.lblOutputP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPartNo2
        '
        Me.lblPartNo2.BackColor = System.Drawing.Color.White
        Me.lblPartNo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPartNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPartNo2.Location = New System.Drawing.Point(396, 332)
        Me.lblPartNo2.Name = "lblPartNo2"
        Me.lblPartNo2.Size = New System.Drawing.Size(253, 26)
        Me.lblPartNo2.TabIndex = 3
        Me.lblPartNo2.Text = "-"
        Me.lblPartNo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCavQtyP2
        '
        Me.lblCavQtyP2.BackColor = System.Drawing.Color.White
        Me.lblCavQtyP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCavQtyP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCavQtyP2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCavQtyP2.Location = New System.Drawing.Point(665, 332)
        Me.lblCavQtyP2.Name = "lblCavQtyP2"
        Me.lblCavQtyP2.Size = New System.Drawing.Size(52, 26)
        Me.lblCavQtyP2.TabIndex = 3
        Me.lblCavQtyP2.Text = "0"
        Me.lblCavQtyP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputP2
        '
        Me.lblOutputP2.BackColor = System.Drawing.Color.White
        Me.lblOutputP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOutputP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputP2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOutputP2.Location = New System.Drawing.Point(729, 332)
        Me.lblOutputP2.Name = "lblOutputP2"
        Me.lblOutputP2.Size = New System.Drawing.Size(90, 26)
        Me.lblOutputP2.TabIndex = 3
        Me.lblOutputP2.Text = "0"
        Me.lblOutputP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOEE
        '
        Me.lblOEE.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblOEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOEE.ForeColor = System.Drawing.Color.White
        Me.lblOEE.Location = New System.Drawing.Point(153, 150)
        Me.lblOEE.Name = "lblOEE"
        Me.lblOEE.Size = New System.Drawing.Size(89, 26)
        Me.lblOEE.TabIndex = 3
        Me.lblOEE.Text = "0.00"
        Me.lblOEE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvStoppage
        '
        Me.dgvStoppage.AllowUserToAddRows = False
        Me.dgvStoppage.AllowUserToDeleteRows = False
        Me.dgvStoppage.AutoGenerateColumns = False
        Me.dgvStoppage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStoppage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStoppage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DTimeIDDataGridViewTextBoxColumn, Me.ShiftCodeFKDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.DTTypeDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.DTReasonDataGridViewTextBoxColumn, Me.DTCountermeasureDataGridViewTextBoxColumn, Me.AckDateDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn, Me.RunTimeDataGridViewTextBoxColumn, Me.TtlDTminsDataGridViewTextBoxColumn, Me.TtlRprTminsDataGridViewTextBoxColumn, Me.ForQAVerificationDataGridViewTextBoxColumn, Me.TtlQAVeriminsDataGridViewTextBoxColumn, Me.TtlFailFreqDataGridViewTextBoxColumn, Me.DTStatusDataGridViewTextBoxColumn})
        Me.dgvStoppage.DataSource = Me.DowntimeBindingSource
        Me.dgvStoppage.GridColor = System.Drawing.SystemColors.Control
        Me.dgvStoppage.Location = New System.Drawing.Point(18, 619)
        Me.dgvStoppage.Name = "dgvStoppage"
        Me.dgvStoppage.ReadOnly = True
        Me.dgvStoppage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStoppage.Size = New System.Drawing.Size(820, 142)
        Me.dgvStoppage.TabIndex = 4
        '
        'DTimeIDDataGridViewTextBoxColumn
        '
        Me.DTimeIDDataGridViewTextBoxColumn.DataPropertyName = "DTime_ID"
        Me.DTimeIDDataGridViewTextBoxColumn.HeaderText = "DTime_ID"
        Me.DTimeIDDataGridViewTextBoxColumn.Name = "DTimeIDDataGridViewTextBoxColumn"
        Me.DTimeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShiftCodeFKDataGridViewTextBoxColumn
        '
        Me.ShiftCodeFKDataGridViewTextBoxColumn.DataPropertyName = "Shift_CodeFK"
        Me.ShiftCodeFKDataGridViewTextBoxColumn.HeaderText = "Shift_CodeFK"
        Me.ShiftCodeFKDataGridViewTextBoxColumn.Name = "ShiftCodeFKDataGridViewTextBoxColumn"
        Me.ShiftCodeFKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User_Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTTypeDataGridViewTextBoxColumn
        '
        Me.DTTypeDataGridViewTextBoxColumn.DataPropertyName = "DT_Type"
        Me.DTTypeDataGridViewTextBoxColumn.HeaderText = "DT_Type"
        Me.DTTypeDataGridViewTextBoxColumn.Name = "DTTypeDataGridViewTextBoxColumn"
        Me.DTTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time"
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTReasonDataGridViewTextBoxColumn
        '
        Me.DTReasonDataGridViewTextBoxColumn.DataPropertyName = "DT_Reason"
        Me.DTReasonDataGridViewTextBoxColumn.HeaderText = "DT_Reason"
        Me.DTReasonDataGridViewTextBoxColumn.Name = "DTReasonDataGridViewTextBoxColumn"
        Me.DTReasonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTCountermeasureDataGridViewTextBoxColumn
        '
        Me.DTCountermeasureDataGridViewTextBoxColumn.DataPropertyName = "DT_Countermeasure"
        Me.DTCountermeasureDataGridViewTextBoxColumn.HeaderText = "DT_Countermeasure"
        Me.DTCountermeasureDataGridViewTextBoxColumn.Name = "DTCountermeasureDataGridViewTextBoxColumn"
        Me.DTCountermeasureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AckDateDataGridViewTextBoxColumn
        '
        Me.AckDateDataGridViewTextBoxColumn.DataPropertyName = "Ack_Date"
        Me.AckDateDataGridViewTextBoxColumn.HeaderText = "Ack_Date"
        Me.AckDateDataGridViewTextBoxColumn.Name = "AckDateDataGridViewTextBoxColumn"
        Me.AckDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndTimeDataGridViewTextBoxColumn
        '
        Me.EndTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time"
        Me.EndTimeDataGridViewTextBoxColumn.HeaderText = "End_Time"
        Me.EndTimeDataGridViewTextBoxColumn.Name = "EndTimeDataGridViewTextBoxColumn"
        Me.EndTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RunTimeDataGridViewTextBoxColumn
        '
        Me.RunTimeDataGridViewTextBoxColumn.DataPropertyName = "Run_Time"
        Me.RunTimeDataGridViewTextBoxColumn.HeaderText = "Run_Time"
        Me.RunTimeDataGridViewTextBoxColumn.Name = "RunTimeDataGridViewTextBoxColumn"
        Me.RunTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlDTminsDataGridViewTextBoxColumn
        '
        Me.TtlDTminsDataGridViewTextBoxColumn.DataPropertyName = "ttl_DT_mins"
        Me.TtlDTminsDataGridViewTextBoxColumn.HeaderText = "ttl_DT_mins"
        Me.TtlDTminsDataGridViewTextBoxColumn.Name = "TtlDTminsDataGridViewTextBoxColumn"
        Me.TtlDTminsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlRprTminsDataGridViewTextBoxColumn
        '
        Me.TtlRprTminsDataGridViewTextBoxColumn.DataPropertyName = "ttl_RprT_mins"
        Me.TtlRprTminsDataGridViewTextBoxColumn.HeaderText = "ttl_RprT_mins"
        Me.TtlRprTminsDataGridViewTextBoxColumn.Name = "TtlRprTminsDataGridViewTextBoxColumn"
        Me.TtlRprTminsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ForQAVerificationDataGridViewTextBoxColumn
        '
        Me.ForQAVerificationDataGridViewTextBoxColumn.DataPropertyName = "ForQAVerification"
        Me.ForQAVerificationDataGridViewTextBoxColumn.HeaderText = "ForQAVerification"
        Me.ForQAVerificationDataGridViewTextBoxColumn.Name = "ForQAVerificationDataGridViewTextBoxColumn"
        Me.ForQAVerificationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlQAVeriminsDataGridViewTextBoxColumn
        '
        Me.TtlQAVeriminsDataGridViewTextBoxColumn.DataPropertyName = "ttl_QAVeri_mins"
        Me.TtlQAVeriminsDataGridViewTextBoxColumn.HeaderText = "ttl_QAVeri_mins"
        Me.TtlQAVeriminsDataGridViewTextBoxColumn.Name = "TtlQAVeriminsDataGridViewTextBoxColumn"
        Me.TtlQAVeriminsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlFailFreqDataGridViewTextBoxColumn
        '
        Me.TtlFailFreqDataGridViewTextBoxColumn.DataPropertyName = "ttl_FailFreq"
        Me.TtlFailFreqDataGridViewTextBoxColumn.HeaderText = "ttl_FailFreq"
        Me.TtlFailFreqDataGridViewTextBoxColumn.Name = "TtlFailFreqDataGridViewTextBoxColumn"
        Me.TtlFailFreqDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTStatusDataGridViewTextBoxColumn
        '
        Me.DTStatusDataGridViewTextBoxColumn.DataPropertyName = "DTStatus"
        Me.DTStatusDataGridViewTextBoxColumn.HeaderText = "DTStatus"
        Me.DTStatusDataGridViewTextBoxColumn.Name = "DTStatusDataGridViewTextBoxColumn"
        Me.DTStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DowntimeBindingSource
        '
        Me.DowntimeBindingSource.DataMember = "Downtime"
        Me.DowntimeBindingSource.DataSource = Me.SPSDataSet1
        '
        'SPSDataSet1
        '
        Me.SPSDataSet1.DataSetName = "SPSDataSet1"
        Me.SPSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboShiftCode
        '
        Me.cboShiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShiftCode.FormattingEnabled = True
        Me.cboShiftCode.Location = New System.Drawing.Point(426, 586)
        Me.cboShiftCode.Name = "cboShiftCode"
        Me.cboShiftCode.Size = New System.Drawing.Size(134, 28)
        Me.cboShiftCode.TabIndex = 7
        '
        'btnShowAll
        '
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.Location = New System.Drawing.Point(622, 587)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(102, 26)
        Me.btnShowAll.TabIndex = 8
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'lblQAInfoDetails
        '
        Me.lblQAInfoDetails.AutoSize = True
        Me.lblQAInfoDetails.BackColor = System.Drawing.Color.Yellow
        Me.lblQAInfoDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQAInfoDetails.Location = New System.Drawing.Point(304, 4)
        Me.lblQAInfoDetails.Name = "lblQAInfoDetails"
        Me.lblQAInfoDetails.Size = New System.Drawing.Size(312, 24)
        Me.lblQAInfoDetails.TabIndex = 11
        Me.lblQAInfoDetails.Text = "PENDING FOR QA VERIFICATION!"
        '
        'SPSDataSet
        '
        Me.SPSDataSet.DataSetName = "SPSDataSet"
        Me.SPSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPSDataSetBindingSource
        '
        Me.SPSDataSetBindingSource.DataSource = Me.SPSDataSet
        Me.SPSDataSetBindingSource.Position = 0
        '
        'DowntimeTableAdapter
        '
        Me.DowntimeTableAdapter.ClearBeforeFill = True
        '
        'btnBypass
        '
        Me.btnBypass.BackColor = System.Drawing.Color.White
        Me.btnBypass.FlatAppearance.BorderSize = 0
        Me.btnBypass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBypass.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt
        Me.btnBypass.IconColor = System.Drawing.Color.Green
        Me.btnBypass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBypass.IconSize = 60
        Me.btnBypass.Location = New System.Drawing.Point(810, 807)
        Me.btnBypass.Name = "btnBypass"
        Me.btnBypass.Size = New System.Drawing.Size(268, 58)
        Me.btnBypass.TabIndex = 12
        Me.btnBypass.Text = "SYS BYPASS OFF"
        Me.btnBypass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBypass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBypass.UseVisualStyleBackColor = False
        '
        'lblQualityBtn
        '
        Me.lblQualityBtn.BackColor = System.Drawing.Color.White
        Me.lblQualityBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQualityBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.lblQualityBtn.IconColor = System.Drawing.Color.Red
        Me.lblQualityBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.lblQualityBtn.Location = New System.Drawing.Point(875, 32)
        Me.lblQualityBtn.Name = "lblQualityBtn"
        Me.lblQualityBtn.Size = New System.Drawing.Size(193, 58)
        Me.lblQualityBtn.TabIndex = 10
        Me.lblQualityBtn.Text = "QUALITY"
        Me.lblQualityBtn.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnUpdate.IconColor = System.Drawing.Color.Black
        Me.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdate.Location = New System.Drawing.Point(730, 587)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 26)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnFilter.IconColor = System.Drawing.Color.Black
        Me.btnFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFilter.Location = New System.Drawing.Point(318, 587)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(102, 26)
        Me.btnFilter.TabIndex = 6
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'picMCStatus
        '
        Me.picMCStatus.Image = Global.SPSApp1.My.Resources.Resources.NOPLAN_SIGN_1
        Me.picMCStatus.Location = New System.Drawing.Point(21, 77)
        Me.picMCStatus.Name = "picMCStatus"
        Me.picMCStatus.Size = New System.Drawing.Size(260, 50)
        Me.picMCStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMCStatus.TabIndex = 9
        Me.picMCStatus.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPSApp1.My.Resources.Resources.DASHBOARD_11
        Me.PictureBox1.Location = New System.Drawing.Point(14, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(836, 833)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtMsgBox
        '
        Me.txtMsgBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsgBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMsgBox.Location = New System.Drawing.Point(308, 467)
        Me.txtMsgBox.Multiline = True
        Me.txtMsgBox.Name = "txtMsgBox"
        Me.txtMsgBox.Size = New System.Drawing.Size(478, 94)
        Me.txtMsgBox.TabIndex = 13
        '
        'btnClearMsg
        '
        Me.btnClearMsg.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClearMsg.IconColor = System.Drawing.Color.Black
        Me.btnClearMsg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClearMsg.IconSize = 30
        Me.btnClearMsg.Location = New System.Drawing.Point(792, 507)
        Me.btnClearMsg.Name = "btnClearMsg"
        Me.btnClearMsg.Size = New System.Drawing.Size(48, 37)
        Me.btnClearMsg.TabIndex = 14
        Me.ttpEraseMessage.SetToolTip(Me.btnClearMsg, "Clear Message Box ")
        Me.btnClearMsg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(32, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PPT:"
        Me.ttpPPT.SetToolTip(Me.Label1, "PLAN PRODUCTION TIME")
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(32, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ART:"
        Me.ttpART.SetToolTip(Me.Label2, "ACTUAL RUN TIME")
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(32, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "UDT:"
        Me.ttpUDT.SetToolTip(Me.Label3, "UNPLANNED DOWNTIME")
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(30, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PQTY:"
        Me.ttpPQTY.SetToolTip(Me.Label6, "PLAN QUANTITY")
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(32, 507)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "AQTY:"
        Me.ttpAQTY.SetToolTip(Me.Label4, "ACTUAL QUANTITY")
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(30, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "AQTY:"
        Me.ttpAQTY.SetToolTip(Me.Label7, "ACTUAL QUANTITY")
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(32, 536)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "RQTY:"
        Me.ttpRQTY.SetToolTip(Me.Label5, "REJECT QUANTITY")
        '
        'btnSaveMsg
        '
        Me.btnSaveMsg.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnSaveMsg.IconColor = System.Drawing.Color.Black
        Me.btnSaveMsg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveMsg.IconSize = 30
        Me.btnSaveMsg.Location = New System.Drawing.Point(792, 468)
        Me.btnSaveMsg.Name = "btnSaveMsg"
        Me.btnSaveMsg.Size = New System.Drawing.Size(48, 37)
        Me.btnSaveMsg.TabIndex = 14
        Me.ttpSaveMsg.SetToolTip(Me.btnSaveMsg, "SAVE MESSAGE")
        Me.btnSaveMsg.UseVisualStyleBackColor = True
        '
        'frmMCDasboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 877)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveMsg)
        Me.Controls.Add(Me.btnClearMsg)
        Me.Controls.Add(Me.txtMsgBox)
        Me.Controls.Add(Me.btnBypass)
        Me.Controls.Add(Me.lblQAInfoDetails)
        Me.Controls.Add(Me.lblQualityBtn)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.cboShiftCode)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dgvStoppage)
        Me.Controls.Add(Me.lblCycleTime)
        Me.Controls.Add(Me.lblDateTimeStart)
        Me.Controls.Add(Me.lblOutputP2)
        Me.Controls.Add(Me.lblOutputP1)
        Me.Controls.Add(Me.lblCavQtyP2)
        Me.Controls.Add(Me.lblCavQtyP1)
        Me.Controls.Add(Me.lblMoldNo)
        Me.Controls.Add(Me.lblJobOrderCode)
        Me.Controls.Add(Me.lblQuality)
        Me.Controls.Add(Me.lblPerformance)
        Me.Controls.Add(Me.lblRejectQty)
        Me.Controls.Add(Me.lblPartNo2)
        Me.Controls.Add(Me.lblPartNo1)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblActualQty1)
        Me.Controls.Add(Me.lblActualQty0)
        Me.Controls.Add(Me.lblPlannedQTY)
        Me.Controls.Add(Me.lblUPDT)
        Me.Controls.Add(Me.lblART)
        Me.Controls.Add(Me.lblPPT)
        Me.Controls.Add(Me.lblOEE)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.picMCStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMCDasboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMCDasboard"
        Me.Text = "Machine Dashboard"
        CType(Me.dgvStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DowntimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMCStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMCDasboard As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picMCStatus As PictureBox
    Friend WithEvents lblShift As Label
    Friend WithEvents lblQuality As Label
    Friend WithEvents lblPerformance As Label
    Friend WithEvents lblRejectQty As Label
    Friend WithEvents lblPartNo1 As Label
    Friend WithEvents lblJobOrderCode As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblActualQty1 As Label
    Friend WithEvents lblActualQty0 As Label
    Friend WithEvents lblPlannedQTY As Label
    Friend WithEvents lblUPDT As Label
    Friend WithEvents lblART As Label
    Friend WithEvents lblPPT As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents lblMoldNo As Label
    Friend WithEvents RealtimeUpdate As Timer
    Friend WithEvents lblCavQtyP1 As Label
    Friend WithEvents lblDateTimeStart As Label
    Friend WithEvents lblCycleTime As Label
    Friend WithEvents lblOutputP1 As Label
    Friend WithEvents lblPartNo2 As Label
    Friend WithEvents lblCavQtyP2 As Label
    Friend WithEvents lblOutputP2 As Label
    Friend WithEvents lblOEE As Label
    Friend WithEvents dgvStoppage As DataGridView
    Friend WithEvents SPSDataSetBindingSource As BindingSource
    Friend WithEvents SPSDataSet As SPSDataSet
    Friend WithEvents SPSDataSet1 As SPSDataSet1
    Friend WithEvents DowntimeBindingSource As BindingSource
    Friend WithEvents DowntimeTableAdapter As SPSDataSet1TableAdapters.DowntimeTableAdapter
    Friend WithEvents DTimeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShiftCodeFKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTCountermeasureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AckDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RunTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlDTminsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlRprTminsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForQAVerificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlQAVeriminsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlFailFreqDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents cboShiftCode As ComboBox
    Friend WithEvents btnShowAll As Button
    Friend WithEvents lblQualityBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents lblQAInfoDetails As Label
    Friend WithEvents btnBypass As FontAwesome.Sharp.IconButton
    Friend WithEvents txtMsgBox As TextBox
    Friend WithEvents btnClearMsg As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ttpPPT As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents ttpART As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents ttpUDT As ToolTip
    Friend WithEvents ttpPQTY As ToolTip
    Friend WithEvents ttpAQTY As ToolTip
    Friend WithEvents ttpRQTY As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ttpEraseMessage As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSaveMsg As FontAwesome.Sharp.IconButton
    Friend WithEvents ttpSaveMsg As ToolTip
    Friend WithEvents ttpMsgBox As ToolTip
End Class
