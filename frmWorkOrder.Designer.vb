<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkOrder))
        Me.grpJO_OrderDetails = New System.Windows.Forms.GroupBox()
        Me.dgvJobOrder = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadStatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdnStatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnloadedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnldDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlShotsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PN1OutputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PN2OutputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PN1RejectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PN2RejectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualPN1OutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualPN2OutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSStartDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSStopDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPBStartDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPBStopDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlMSTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlFPBTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtlRunTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOLoadedDetailsBindingSource16 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLodedDetails_3 = New SPSApp1.JOLodedDetails_3()
        Me.JOLoadedDetailsBindingSource11 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetails_2 = New SPSApp1.JOLoadedDetails_2()
        Me.JOLoadedDetails1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MListJobOrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOSelectRTCheck = New System.Windows.Forms.Timer(Me.components)
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnLoad = New FontAwesome.Sharp.IconButton()
        Me.btnUnload = New FontAwesome.Sharp.IconButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.MListJobOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPSDataSet1 = New SPSApp1.SPSDataSet1()
        Me.SPSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DowntimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DowntimeTableAdapter = New SPSApp1.SPSDataSet1TableAdapters.DowntimeTableAdapter()
        Me.lblDGVJOCode = New System.Windows.Forms.Label()
        Me.lblDGVP1 = New System.Windows.Forms.Label()
        Me.lblDGVP2 = New System.Windows.Forms.Label()
        Me.lblDGVCavP1 = New System.Windows.Forms.Label()
        Me.lblDGVCavP2 = New System.Windows.Forms.Label()
        Me.lblDGVJOQty = New System.Windows.Forms.Label()
        Me.lblDGVCycleTime = New System.Windows.Forms.Label()
        Me.lblDGVStartTime = New System.Windows.Forms.Label()
        Me.lblDGVEndtime = New System.Windows.Forms.Label()
        Me.lblDGVMoldID = New System.Windows.Forms.Label()
        Me.lblDGVMachineId = New System.Windows.Forms.Label()
        Me.lblDGVLoadStats = New System.Windows.Forms.Label()
        Me.lblDGVProdnStat = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblDGVid = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.btnByMachine = New FontAwesome.Sharp.IconButton()
        Me.cboByMachine = New System.Windows.Forms.ComboBox()
        Me.JOLoadedDetailsBindingSource17 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetails_MachineIDOnly = New SPSApp1.JOLoadedDetails_MachineIDOnly()
        Me.JOLoadedDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedMachineID = New SPSApp1.JOLoadedMachineID()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblJOLoadedBy = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblMenuTabWorkOrder = New System.Windows.Forms.Label()
        Me.lblDGVTtlRunTime = New System.Windows.Forms.Label()
        Me.lblDGVAvtualP2Out = New System.Windows.Forms.Label()
        Me.lblDGVActualPN1OUt = New System.Windows.Forms.Label()
        Me.lblDGVPN2Reject = New System.Windows.Forms.Label()
        Me.lblDGVPN1Reject = New System.Windows.Forms.Label()
        Me.lblDGVPN2Output = New System.Windows.Forms.Label()
        Me.lblDGVPN1Output = New System.Windows.Forms.Label()
        Me.lblDGVUnloadDT = New System.Windows.Forms.Label()
        Me.lblDGVTotalShots = New System.Windows.Forms.Label()
        Me.lblUnloadedBY = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDGVShiftCode = New System.Windows.Forms.Label()
        Me.btnOpenJO = New FontAwesome.Sharp.IconButton()
        Me.JOLoadedDetailsTableAdapter1 = New SPSApp1.JOLoadedMachineIDTableAdapters.JOLoadedDetailsTableAdapter()
        Me.JOLoadedDetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.JOLoadedDetailsBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetails1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource10 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsTableAdapter3 = New SPSApp1.JOLoadedDetails_2TableAdapters.JOLoadedDetailsTableAdapter()
        Me.JOLoadedDetails2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource12 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource13 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource14 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetails2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsBindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsTableAdapter = New SPSApp1.JOLodedDetails_3TableAdapters.JOLoadedDetailsTableAdapter()
        Me.JOLoadedDetailsBindingSource15 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOLoadedDetailsTableAdapter2 = New SPSApp1.JOLoadedDetails_MachineIDOnlyTableAdapters.JOLoadedDetailsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpJO_OrderDetails.SuspendLayout()
        CType(Me.dgvJobOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLodedDetails_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetails_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetails1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListJobOrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListJobOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DowntimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetails_MachineIDOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedMachineID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.JOLoadedDetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetails1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetails2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetails2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOLoadedDetailsBindingSource15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpJO_OrderDetails
        '
        Me.grpJO_OrderDetails.Controls.Add(Me.dgvJobOrder)
        Me.grpJO_OrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpJO_OrderDetails.Location = New System.Drawing.Point(40, 64)
        Me.grpJO_OrderDetails.Name = "grpJO_OrderDetails"
        Me.grpJO_OrderDetails.Size = New System.Drawing.Size(1502, 813)
        Me.grpJO_OrderDetails.TabIndex = 2
        Me.grpJO_OrderDetails.TabStop = False
        Me.grpJO_OrderDetails.Text = "Job Order Details:"
        '
        'dgvJobOrder
        '
        Me.dgvJobOrder.AllowUserToAddRows = False
        Me.dgvJobOrder.AllowUserToDeleteRows = False
        Me.dgvJobOrder.AutoGenerateColumns = False
        Me.dgvJobOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvJobOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.ShiftCodeDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.LoadStatsDataGridViewTextBoxColumn, Me.ProdnStatsDataGridViewTextBoxColumn, Me.LoadedByDataGridViewTextBoxColumn, Me.UnloadedByDataGridViewTextBoxColumn, Me.UnldDTDataGridViewTextBoxColumn, Me.TtlShotsDataGridViewTextBoxColumn, Me.PN1OutputDataGridViewTextBoxColumn, Me.PN2OutputDataGridViewTextBoxColumn, Me.PN1RejectDataGridViewTextBoxColumn, Me.PN2RejectDataGridViewTextBoxColumn, Me.ActualPN1OutDataGridViewTextBoxColumn, Me.ActualPN2OutDataGridViewTextBoxColumn, Me.MSStartDTDataGridViewTextBoxColumn, Me.MSStopDTDataGridViewTextBoxColumn, Me.FPBStartDTDataGridViewTextBoxColumn, Me.FPBStopDTDataGridViewTextBoxColumn, Me.TtlMSTimeDataGridViewTextBoxColumn, Me.TtlFPBTimeDataGridViewTextBoxColumn, Me.TtlRunTimeDataGridViewTextBoxColumn})
        Me.dgvJobOrder.DataSource = Me.JOLoadedDetailsBindingSource16
        Me.dgvJobOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJobOrder.Location = New System.Drawing.Point(3, 22)
        Me.dgvJobOrder.Name = "dgvJobOrder"
        Me.dgvJobOrder.ReadOnly = True
        Me.dgvJobOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvJobOrder.Size = New System.Drawing.Size(1496, 788)
        Me.dgvJobOrder.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Machine_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Machine_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ShiftCodeDataGridViewTextBoxColumn
        '
        Me.ShiftCodeDataGridViewTextBoxColumn.DataPropertyName = "Shift_Code"
        Me.ShiftCodeDataGridViewTextBoxColumn.HeaderText = "Shift_Code"
        Me.ShiftCodeDataGridViewTextBoxColumn.Name = "ShiftCodeDataGridViewTextBoxColumn"
        Me.ShiftCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "JOB_ORDER"
        Me.DataGridViewTextBoxColumn3.HeaderText = "JOB_ORDER"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Mold_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mold_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PART_NO_1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PART_NO_1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PART_NO_2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PART_NO_2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MOLD_CAVITY_PART_1"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MOLD_CAVITY_PART_1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MOLD_CAVITY_PART_2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MOLD_CAVITY_PART_2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "JOB_ORDER_QTY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "JOB_ORDER_QTY"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CYCLE_TIME_SEC"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CYCLE_TIME_SEC"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "START_TIME"
        Me.DataGridViewTextBoxColumn11.HeaderText = "START_TIME"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "END_TIME"
        Me.DataGridViewTextBoxColumn12.HeaderText = "END_TIME"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'LoadStatsDataGridViewTextBoxColumn
        '
        Me.LoadStatsDataGridViewTextBoxColumn.DataPropertyName = "Load_Stats"
        Me.LoadStatsDataGridViewTextBoxColumn.HeaderText = "Load_Stats"
        Me.LoadStatsDataGridViewTextBoxColumn.Name = "LoadStatsDataGridViewTextBoxColumn"
        Me.LoadStatsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdnStatsDataGridViewTextBoxColumn
        '
        Me.ProdnStatsDataGridViewTextBoxColumn.DataPropertyName = "Prodn_Stats"
        Me.ProdnStatsDataGridViewTextBoxColumn.HeaderText = "Prodn_Stats"
        Me.ProdnStatsDataGridViewTextBoxColumn.Name = "ProdnStatsDataGridViewTextBoxColumn"
        Me.ProdnStatsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoadedByDataGridViewTextBoxColumn
        '
        Me.LoadedByDataGridViewTextBoxColumn.DataPropertyName = "Loaded_By"
        Me.LoadedByDataGridViewTextBoxColumn.HeaderText = "Loaded_By"
        Me.LoadedByDataGridViewTextBoxColumn.Name = "LoadedByDataGridViewTextBoxColumn"
        Me.LoadedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnloadedByDataGridViewTextBoxColumn
        '
        Me.UnloadedByDataGridViewTextBoxColumn.DataPropertyName = "Unloaded_By"
        Me.UnloadedByDataGridViewTextBoxColumn.HeaderText = "Unloaded_By"
        Me.UnloadedByDataGridViewTextBoxColumn.Name = "UnloadedByDataGridViewTextBoxColumn"
        Me.UnloadedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnldDTDataGridViewTextBoxColumn
        '
        Me.UnldDTDataGridViewTextBoxColumn.DataPropertyName = "Unld_DT"
        Me.UnldDTDataGridViewTextBoxColumn.HeaderText = "Unld_DT"
        Me.UnldDTDataGridViewTextBoxColumn.Name = "UnldDTDataGridViewTextBoxColumn"
        Me.UnldDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlShotsDataGridViewTextBoxColumn
        '
        Me.TtlShotsDataGridViewTextBoxColumn.DataPropertyName = "Ttl_Shots"
        Me.TtlShotsDataGridViewTextBoxColumn.HeaderText = "Ttl_Shots"
        Me.TtlShotsDataGridViewTextBoxColumn.Name = "TtlShotsDataGridViewTextBoxColumn"
        Me.TtlShotsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PN1OutputDataGridViewTextBoxColumn
        '
        Me.PN1OutputDataGridViewTextBoxColumn.DataPropertyName = "PN1_Output"
        Me.PN1OutputDataGridViewTextBoxColumn.HeaderText = "PN1_Output"
        Me.PN1OutputDataGridViewTextBoxColumn.Name = "PN1OutputDataGridViewTextBoxColumn"
        Me.PN1OutputDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PN2OutputDataGridViewTextBoxColumn
        '
        Me.PN2OutputDataGridViewTextBoxColumn.DataPropertyName = "PN2_Output"
        Me.PN2OutputDataGridViewTextBoxColumn.HeaderText = "PN2_Output"
        Me.PN2OutputDataGridViewTextBoxColumn.Name = "PN2OutputDataGridViewTextBoxColumn"
        Me.PN2OutputDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PN1RejectDataGridViewTextBoxColumn
        '
        Me.PN1RejectDataGridViewTextBoxColumn.DataPropertyName = "PN1_Reject"
        Me.PN1RejectDataGridViewTextBoxColumn.HeaderText = "PN1_Reject"
        Me.PN1RejectDataGridViewTextBoxColumn.Name = "PN1RejectDataGridViewTextBoxColumn"
        Me.PN1RejectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PN2RejectDataGridViewTextBoxColumn
        '
        Me.PN2RejectDataGridViewTextBoxColumn.DataPropertyName = "PN2_Reject"
        Me.PN2RejectDataGridViewTextBoxColumn.HeaderText = "PN2_Reject"
        Me.PN2RejectDataGridViewTextBoxColumn.Name = "PN2RejectDataGridViewTextBoxColumn"
        Me.PN2RejectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActualPN1OutDataGridViewTextBoxColumn
        '
        Me.ActualPN1OutDataGridViewTextBoxColumn.DataPropertyName = "Actual_PN1_Out"
        Me.ActualPN1OutDataGridViewTextBoxColumn.HeaderText = "Actual_PN1_Out"
        Me.ActualPN1OutDataGridViewTextBoxColumn.Name = "ActualPN1OutDataGridViewTextBoxColumn"
        Me.ActualPN1OutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActualPN2OutDataGridViewTextBoxColumn
        '
        Me.ActualPN2OutDataGridViewTextBoxColumn.DataPropertyName = "Actual_PN2_Out"
        Me.ActualPN2OutDataGridViewTextBoxColumn.HeaderText = "Actual_PN2_Out"
        Me.ActualPN2OutDataGridViewTextBoxColumn.Name = "ActualPN2OutDataGridViewTextBoxColumn"
        Me.ActualPN2OutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MSStartDTDataGridViewTextBoxColumn
        '
        Me.MSStartDTDataGridViewTextBoxColumn.DataPropertyName = "MS_Start_DT"
        Me.MSStartDTDataGridViewTextBoxColumn.HeaderText = "MS_Start_DT"
        Me.MSStartDTDataGridViewTextBoxColumn.Name = "MSStartDTDataGridViewTextBoxColumn"
        Me.MSStartDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MSStopDTDataGridViewTextBoxColumn
        '
        Me.MSStopDTDataGridViewTextBoxColumn.DataPropertyName = "MS_Stop_DT"
        Me.MSStopDTDataGridViewTextBoxColumn.HeaderText = "MS_Stop_DT"
        Me.MSStopDTDataGridViewTextBoxColumn.Name = "MSStopDTDataGridViewTextBoxColumn"
        Me.MSStopDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FPBStartDTDataGridViewTextBoxColumn
        '
        Me.FPBStartDTDataGridViewTextBoxColumn.DataPropertyName = "FPB_Start_DT"
        Me.FPBStartDTDataGridViewTextBoxColumn.HeaderText = "FPB_Start_DT"
        Me.FPBStartDTDataGridViewTextBoxColumn.Name = "FPBStartDTDataGridViewTextBoxColumn"
        Me.FPBStartDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FPBStopDTDataGridViewTextBoxColumn
        '
        Me.FPBStopDTDataGridViewTextBoxColumn.DataPropertyName = "FPB_Stop_DT"
        Me.FPBStopDTDataGridViewTextBoxColumn.HeaderText = "FPB_Stop_DT"
        Me.FPBStopDTDataGridViewTextBoxColumn.Name = "FPBStopDTDataGridViewTextBoxColumn"
        Me.FPBStopDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlMSTimeDataGridViewTextBoxColumn
        '
        Me.TtlMSTimeDataGridViewTextBoxColumn.DataPropertyName = "Ttl_MS_Time"
        Me.TtlMSTimeDataGridViewTextBoxColumn.HeaderText = "Ttl_MS_Time"
        Me.TtlMSTimeDataGridViewTextBoxColumn.Name = "TtlMSTimeDataGridViewTextBoxColumn"
        Me.TtlMSTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlFPBTimeDataGridViewTextBoxColumn
        '
        Me.TtlFPBTimeDataGridViewTextBoxColumn.DataPropertyName = "Ttl_FPB_Time"
        Me.TtlFPBTimeDataGridViewTextBoxColumn.HeaderText = "Ttl_FPB_Time"
        Me.TtlFPBTimeDataGridViewTextBoxColumn.Name = "TtlFPBTimeDataGridViewTextBoxColumn"
        Me.TtlFPBTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TtlRunTimeDataGridViewTextBoxColumn
        '
        Me.TtlRunTimeDataGridViewTextBoxColumn.DataPropertyName = "Ttl_RunTime"
        Me.TtlRunTimeDataGridViewTextBoxColumn.HeaderText = "Ttl_RunTime"
        Me.TtlRunTimeDataGridViewTextBoxColumn.Name = "TtlRunTimeDataGridViewTextBoxColumn"
        Me.TtlRunTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JOLoadedDetailsBindingSource16
        '
        Me.JOLoadedDetailsBindingSource16.DataMember = "JOLoadedDetails"
        Me.JOLoadedDetailsBindingSource16.DataSource = Me.JOLodedDetails_3
        '
        'JOLodedDetails_3
        '
        Me.JOLodedDetails_3.DataSetName = "JOLodedDetails_3"
        Me.JOLodedDetails_3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JOLoadedDetails_2
        '
        Me.JOLoadedDetails_2.DataSetName = "JOLoadedDetails_2"
        Me.JOLoadedDetails_2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MListJobOrderBindingSource1
        '
        Me.MListJobOrderBindingSource1.DataMember = "MListJobOrder"
        '
        'JOSelectRTCheck
        '
        Me.JOSelectRTCheck.Enabled = True
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 40
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(847, 883)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 84)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.IconChar = FontAwesome.Sharp.IconChar.DiagramNext
        Me.btnLoad.IconColor = System.Drawing.Color.Black
        Me.btnLoad.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLoad.IconSize = 40
        Me.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoad.Location = New System.Drawing.Point(642, 883)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(199, 84)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoad.UseVisualStyleBackColor = True
        Me.btnLoad.Visible = False
        '
        'btnUnload
        '
        Me.btnUnload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUnload.Flip = FontAwesome.Sharp.FlipOrientation.Vertical
        Me.btnUnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnload.IconChar = FontAwesome.Sharp.IconChar.DiagramNext
        Me.btnUnload.IconColor = System.Drawing.Color.Black
        Me.btnUnload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUnload.IconSize = 40
        Me.btnUnload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnload.Location = New System.Drawing.Point(1052, 883)
        Me.btnUnload.Name = "btnUnload"
        Me.btnUnload.Size = New System.Drawing.Size(199, 84)
        Me.btnUnload.TabIndex = 3
        Me.btnUnload.Text = "Unload"
        Me.btnUnload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUnload.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(306, 31)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Job Order Transactions:"
        '
        'MListJobOrderBindingSource
        '
        Me.MListJobOrderBindingSource.DataMember = "MListJobOrder"
        '
        'SPSDataSet1
        '
        Me.SPSDataSet1.DataSetName = "SPSDataSet1"
        Me.SPSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPSDataSet1BindingSource
        '
        Me.SPSDataSet1BindingSource.DataSource = Me.SPSDataSet1
        Me.SPSDataSet1BindingSource.Position = 0
        '
        'DowntimeBindingSource
        '
        Me.DowntimeBindingSource.DataMember = "Downtime"
        Me.DowntimeBindingSource.DataSource = Me.SPSDataSet1BindingSource
        '
        'DowntimeTableAdapter
        '
        Me.DowntimeTableAdapter.ClearBeforeFill = True
        '
        'lblDGVJOCode
        '
        Me.lblDGVJOCode.AutoSize = True
        Me.lblDGVJOCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVJOCode.Location = New System.Drawing.Point(77, 92)
        Me.lblDGVJOCode.Name = "lblDGVJOCode"
        Me.lblDGVJOCode.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVJOCode.TabIndex = 8
        Me.lblDGVJOCode.Tag = ""
        Me.lblDGVJOCode.Text = "-"
        '
        'lblDGVP1
        '
        Me.lblDGVP1.AutoSize = True
        Me.lblDGVP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVP1.Location = New System.Drawing.Point(42, 132)
        Me.lblDGVP1.Name = "lblDGVP1"
        Me.lblDGVP1.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVP1.TabIndex = 8
        Me.lblDGVP1.Tag = ""
        Me.lblDGVP1.Text = "-"
        '
        'lblDGVP2
        '
        Me.lblDGVP2.AutoSize = True
        Me.lblDGVP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVP2.Location = New System.Drawing.Point(42, 152)
        Me.lblDGVP2.Name = "lblDGVP2"
        Me.lblDGVP2.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVP2.TabIndex = 8
        Me.lblDGVP2.Text = "-"
        '
        'lblDGVCavP1
        '
        Me.lblDGVCavP1.AutoSize = True
        Me.lblDGVCavP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVCavP1.Location = New System.Drawing.Point(65, 172)
        Me.lblDGVCavP1.Name = "lblDGVCavP1"
        Me.lblDGVCavP1.Size = New System.Drawing.Size(14, 16)
        Me.lblDGVCavP1.TabIndex = 8
        Me.lblDGVCavP1.Text = "0"
        '
        'lblDGVCavP2
        '
        Me.lblDGVCavP2.AutoSize = True
        Me.lblDGVCavP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVCavP2.Location = New System.Drawing.Point(65, 192)
        Me.lblDGVCavP2.Name = "lblDGVCavP2"
        Me.lblDGVCavP2.Size = New System.Drawing.Size(14, 16)
        Me.lblDGVCavP2.TabIndex = 8
        Me.lblDGVCavP2.Text = "0"
        '
        'lblDGVJOQty
        '
        Me.lblDGVJOQty.AutoSize = True
        Me.lblDGVJOQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVJOQty.Location = New System.Drawing.Point(65, 212)
        Me.lblDGVJOQty.Name = "lblDGVJOQty"
        Me.lblDGVJOQty.Size = New System.Drawing.Size(14, 16)
        Me.lblDGVJOQty.TabIndex = 8
        Me.lblDGVJOQty.Text = "0"
        '
        'lblDGVCycleTime
        '
        Me.lblDGVCycleTime.AutoSize = True
        Me.lblDGVCycleTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVCycleTime.Location = New System.Drawing.Point(91, 232)
        Me.lblDGVCycleTime.Name = "lblDGVCycleTime"
        Me.lblDGVCycleTime.Size = New System.Drawing.Size(14, 16)
        Me.lblDGVCycleTime.TabIndex = 8
        Me.lblDGVCycleTime.Text = "0"
        '
        'lblDGVStartTime
        '
        Me.lblDGVStartTime.AutoSize = True
        Me.lblDGVStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVStartTime.Location = New System.Drawing.Point(84, 252)
        Me.lblDGVStartTime.Name = "lblDGVStartTime"
        Me.lblDGVStartTime.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVStartTime.TabIndex = 8
        Me.lblDGVStartTime.Text = "-"
        '
        'lblDGVEndtime
        '
        Me.lblDGVEndtime.AutoSize = True
        Me.lblDGVEndtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVEndtime.Location = New System.Drawing.Point(84, 272)
        Me.lblDGVEndtime.Name = "lblDGVEndtime"
        Me.lblDGVEndtime.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVEndtime.TabIndex = 8
        Me.lblDGVEndtime.Text = "-"
        '
        'lblDGVMoldID
        '
        Me.lblDGVMoldID.AutoSize = True
        Me.lblDGVMoldID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVMoldID.Location = New System.Drawing.Point(84, 112)
        Me.lblDGVMoldID.Name = "lblDGVMoldID"
        Me.lblDGVMoldID.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVMoldID.TabIndex = 8
        Me.lblDGVMoldID.Text = "-"
        '
        'lblDGVMachineId
        '
        Me.lblDGVMachineId.AutoSize = True
        Me.lblDGVMachineId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVMachineId.Location = New System.Drawing.Point(91, 52)
        Me.lblDGVMachineId.Name = "lblDGVMachineId"
        Me.lblDGVMachineId.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVMachineId.TabIndex = 8
        Me.lblDGVMachineId.Text = "-"
        '
        'lblDGVLoadStats
        '
        Me.lblDGVLoadStats.AutoSize = True
        Me.lblDGVLoadStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVLoadStats.Location = New System.Drawing.Point(91, 292)
        Me.lblDGVLoadStats.Name = "lblDGVLoadStats"
        Me.lblDGVLoadStats.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVLoadStats.TabIndex = 8
        Me.lblDGVLoadStats.Text = "-"
        '
        'lblDGVProdnStat
        '
        Me.lblDGVProdnStat.AutoSize = True
        Me.lblDGVProdnStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVProdnStat.Location = New System.Drawing.Point(91, 312)
        Me.lblDGVProdnStat.Name = "lblDGVProdnStat"
        Me.lblDGVProdnStat.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVProdnStat.TabIndex = 8
        Me.lblDGVProdnStat.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "JO Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "P1:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "P2:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "CavP1:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "CavP2:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 212)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 16)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "JO Qty:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 232)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 16)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Cycle Time:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(13, 252)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 16)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Start Time:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 272)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 16)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "End Time:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 16)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Mold ID:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 52)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 16)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Machine ID:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 292)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 16)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Load Stats:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(13, 312)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Prodn Stat:"
        '
        'lblDGVid
        '
        Me.lblDGVid.AutoSize = True
        Me.lblDGVid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVid.Location = New System.Drawing.Point(37, 32)
        Me.lblDGVid.Name = "lblDGVid"
        Me.lblDGVid.Size = New System.Drawing.Size(14, 16)
        Me.lblDGVid.TabIndex = 8
        Me.lblDGVid.Text = "0"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(13, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(23, 16)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "ID:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnRefresh.IconColor = System.Drawing.Color.Black
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.Location = New System.Drawing.Point(1442, 39)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(98, 28)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnByMachine
        '
        Me.btnByMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByMachine.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnByMachine.IconColor = System.Drawing.Color.Black
        Me.btnByMachine.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnByMachine.Location = New System.Drawing.Point(1338, 39)
        Me.btnByMachine.Name = "btnByMachine"
        Me.btnByMachine.Size = New System.Drawing.Size(98, 28)
        Me.btnByMachine.TabIndex = 10
        Me.btnByMachine.Text = "Filter"
        Me.btnByMachine.UseVisualStyleBackColor = True
        '
        'cboByMachine
        '
        Me.cboByMachine.DataSource = Me.JOLoadedDetailsBindingSource17
        Me.cboByMachine.DisplayMember = "Machine_ID"
        Me.cboByMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboByMachine.FormattingEnabled = True
        Me.cboByMachine.Location = New System.Drawing.Point(1197, 40)
        Me.cboByMachine.Name = "cboByMachine"
        Me.cboByMachine.Size = New System.Drawing.Size(135, 28)
        Me.cboByMachine.TabIndex = 11
        '
        'JOLoadedDetailsBindingSource17
        '
        Me.JOLoadedDetailsBindingSource17.DataMember = "JOLoadedDetails"
        Me.JOLoadedDetailsBindingSource17.DataSource = Me.JOLoadedDetails_MachineIDOnly
        '
        'JOLoadedDetails_MachineIDOnly
        '
        Me.JOLoadedDetails_MachineIDOnly.DataSetName = "JOLoadedDetails_MachineIDOnly"
        Me.JOLoadedDetails_MachineIDOnly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JOLoadedMachineID
        '
        Me.JOLoadedMachineID.DataSetName = "JOLoadedMachineID"
        Me.JOLoadedMachineID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(13, 332)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(93, 16)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "JO LoadedBy:"
        '
        'lblJOLoadedBy
        '
        Me.lblJOLoadedBy.AutoSize = True
        Me.lblJOLoadedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJOLoadedBy.Location = New System.Drawing.Point(110, 332)
        Me.lblJOLoadedBy.Name = "lblJOLoadedBy"
        Me.lblJOLoadedBy.Size = New System.Drawing.Size(11, 16)
        Me.lblJOLoadedBy.TabIndex = 8
        Me.lblJOLoadedBy.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblMenuTabWorkOrder)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.lblDGVJOCode)
        Me.GroupBox3.Controls.Add(Me.lblDGVid)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.lblDGVTtlRunTime)
        Me.GroupBox3.Controls.Add(Me.lblDGVAvtualP2Out)
        Me.GroupBox3.Controls.Add(Me.lblDGVActualPN1OUt)
        Me.GroupBox3.Controls.Add(Me.lblDGVPN2Reject)
        Me.GroupBox3.Controls.Add(Me.lblDGVPN1Reject)
        Me.GroupBox3.Controls.Add(Me.lblDGVPN2Output)
        Me.GroupBox3.Controls.Add(Me.lblDGVPN1Output)
        Me.GroupBox3.Controls.Add(Me.lblDGVUnloadDT)
        Me.GroupBox3.Controls.Add(Me.lblDGVTotalShots)
        Me.GroupBox3.Controls.Add(Me.lblUnloadedBY)
        Me.GroupBox3.Controls.Add(Me.lblJOLoadedBy)
        Me.GroupBox3.Controls.Add(Me.lblDGVP1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.label)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblDGVP2)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblDGVProdnStat)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.lblDGVLoadStats)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblDGVShiftCode)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.lblDGVMachineId)
        Me.GroupBox3.Controls.Add(Me.lblDGVCavP1)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lblDGVMoldID)
        Me.GroupBox3.Controls.Add(Me.lblDGVCavP2)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.lblDGVEndtime)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.lblDGVStartTime)
        Me.GroupBox3.Controls.Add(Me.lblDGVCycleTime)
        Me.GroupBox3.Controls.Add(Me.lblDGVJOQty)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1548, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 809)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "JO Summary:"
        '
        'lblMenuTabWorkOrder
        '
        Me.lblMenuTabWorkOrder.AutoSize = True
        Me.lblMenuTabWorkOrder.Location = New System.Drawing.Point(12, 770)
        Me.lblMenuTabWorkOrder.Name = "lblMenuTabWorkOrder"
        Me.lblMenuTabWorkOrder.Size = New System.Drawing.Size(153, 20)
        Me.lblMenuTabWorkOrder.TabIndex = 16
        Me.lblMenuTabWorkOrder.Text = "MenuTabWorkOrder"
        Me.lblMenuTabWorkOrder.Visible = False
        '
        'lblDGVTtlRunTime
        '
        Me.lblDGVTtlRunTime.AutoSize = True
        Me.lblDGVTtlRunTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVTtlRunTime.Location = New System.Drawing.Point(116, 535)
        Me.lblDGVTtlRunTime.Name = "lblDGVTtlRunTime"
        Me.lblDGVTtlRunTime.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVTtlRunTime.TabIndex = 8
        Me.lblDGVTtlRunTime.Text = "-"
        '
        'lblDGVAvtualP2Out
        '
        Me.lblDGVAvtualP2Out.AutoSize = True
        Me.lblDGVAvtualP2Out.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVAvtualP2Out.Location = New System.Drawing.Point(116, 515)
        Me.lblDGVAvtualP2Out.Name = "lblDGVAvtualP2Out"
        Me.lblDGVAvtualP2Out.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVAvtualP2Out.TabIndex = 8
        Me.lblDGVAvtualP2Out.Text = "-"
        '
        'lblDGVActualPN1OUt
        '
        Me.lblDGVActualPN1OUt.AutoSize = True
        Me.lblDGVActualPN1OUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVActualPN1OUt.Location = New System.Drawing.Point(116, 495)
        Me.lblDGVActualPN1OUt.Name = "lblDGVActualPN1OUt"
        Me.lblDGVActualPN1OUt.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVActualPN1OUt.TabIndex = 8
        Me.lblDGVActualPN1OUt.Text = "-"
        '
        'lblDGVPN2Reject
        '
        Me.lblDGVPN2Reject.AutoSize = True
        Me.lblDGVPN2Reject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVPN2Reject.Location = New System.Drawing.Point(96, 474)
        Me.lblDGVPN2Reject.Name = "lblDGVPN2Reject"
        Me.lblDGVPN2Reject.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVPN2Reject.TabIndex = 8
        Me.lblDGVPN2Reject.Text = "-"
        '
        'lblDGVPN1Reject
        '
        Me.lblDGVPN1Reject.AutoSize = True
        Me.lblDGVPN1Reject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVPN1Reject.Location = New System.Drawing.Point(96, 453)
        Me.lblDGVPN1Reject.Name = "lblDGVPN1Reject"
        Me.lblDGVPN1Reject.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVPN1Reject.TabIndex = 8
        Me.lblDGVPN1Reject.Text = "-"
        '
        'lblDGVPN2Output
        '
        Me.lblDGVPN2Output.AutoSize = True
        Me.lblDGVPN2Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVPN2Output.Location = New System.Drawing.Point(96, 432)
        Me.lblDGVPN2Output.Name = "lblDGVPN2Output"
        Me.lblDGVPN2Output.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVPN2Output.TabIndex = 8
        Me.lblDGVPN2Output.Text = "-"
        '
        'lblDGVPN1Output
        '
        Me.lblDGVPN1Output.AutoSize = True
        Me.lblDGVPN1Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVPN1Output.Location = New System.Drawing.Point(96, 411)
        Me.lblDGVPN1Output.Name = "lblDGVPN1Output"
        Me.lblDGVPN1Output.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVPN1Output.TabIndex = 8
        Me.lblDGVPN1Output.Text = "-"
        '
        'lblDGVUnloadDT
        '
        Me.lblDGVUnloadDT.AutoSize = True
        Me.lblDGVUnloadDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVUnloadDT.Location = New System.Drawing.Point(96, 372)
        Me.lblDGVUnloadDT.Name = "lblDGVUnloadDT"
        Me.lblDGVUnloadDT.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVUnloadDT.TabIndex = 8
        Me.lblDGVUnloadDT.Text = "-"
        '
        'lblDGVTotalShots
        '
        Me.lblDGVTotalShots.AutoSize = True
        Me.lblDGVTotalShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVTotalShots.Location = New System.Drawing.Point(96, 392)
        Me.lblDGVTotalShots.Name = "lblDGVTotalShots"
        Me.lblDGVTotalShots.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVTotalShots.TabIndex = 8
        Me.lblDGVTotalShots.Text = "-"
        '
        'lblUnloadedBY
        '
        Me.lblUnloadedBY.AutoSize = True
        Me.lblUnloadedBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnloadedBY.Location = New System.Drawing.Point(125, 352)
        Me.lblUnloadedBY.Name = "lblUnloadedBY"
        Me.lblUnloadedBY.Size = New System.Drawing.Size(11, 16)
        Me.lblUnloadedBY.TabIndex = 8
        Me.lblUnloadedBY.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 535)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total RunTime:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 515)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 16)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Actual PN2 Out:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 453)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "PN1 Reject:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 494)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 16)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Actual PN1 Out:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "PN2 Output:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 473)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 16)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "PN2 Reject:"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(13, 411)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(77, 16)
        Me.label.TabIndex = 8
        Me.label.Text = "PN1 Output:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Unload DT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Shots:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "JO UnloadedBy:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Shift Code:"
        '
        'lblDGVShiftCode
        '
        Me.lblDGVShiftCode.AutoSize = True
        Me.lblDGVShiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVShiftCode.Location = New System.Drawing.Point(91, 72)
        Me.lblDGVShiftCode.Name = "lblDGVShiftCode"
        Me.lblDGVShiftCode.Size = New System.Drawing.Size(11, 16)
        Me.lblDGVShiftCode.TabIndex = 8
        Me.lblDGVShiftCode.Text = "-"
        '
        'btnOpenJO
        '
        Me.btnOpenJO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenJO.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.btnOpenJO.IconColor = System.Drawing.Color.Black
        Me.btnOpenJO.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOpenJO.Location = New System.Drawing.Point(1257, 883)
        Me.btnOpenJO.Name = "btnOpenJO"
        Me.btnOpenJO.Size = New System.Drawing.Size(282, 84)
        Me.btnOpenJO.TabIndex = 15
        Me.btnOpenJO.Text = "Open JOList"
        Me.btnOpenJO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpenJO.UseVisualStyleBackColor = True
        '
        'JOLoadedDetailsTableAdapter1
        '
        Me.JOLoadedDetailsTableAdapter1.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SPSApp1.My.Resources.Resources.Powered_by_SPS
        Me.PictureBox2.Location = New System.Drawing.Point(1679, 954)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'JOLoadedDetailsTableAdapter3
        '
        Me.JOLoadedDetailsTableAdapter3.ClearBeforeFill = True
        '
        'JOLoadedDetails2BindingSource1
        '
        Me.JOLoadedDetails2BindingSource1.DataSource = Me.JOLoadedDetails_2
        Me.JOLoadedDetails2BindingSource1.Position = 0
        '
        'JOLoadedDetailsBindingSource3
        '
        Me.JOLoadedDetailsBindingSource3.DataMember = "JOLoadedDetails"
        Me.JOLoadedDetailsBindingSource3.DataSource = Me.JOLoadedDetails_2
        '
        'JOLoadedDetailsBindingSource6
        '
        Me.JOLoadedDetailsBindingSource6.DataMember = "JOLoadedDetails"
        Me.JOLoadedDetailsBindingSource6.DataSource = Me.JOLoadedDetails2BindingSource1
        '
        'JOLoadedDetailsBindingSource9
        '
        Me.JOLoadedDetailsBindingSource9.DataMember = "JOLoadedDetails"
        Me.JOLoadedDetailsBindingSource9.DataSource = Me.JOLodedDetails_3
        '
        'JOLoadedDetailsTableAdapter
        '
        Me.JOLoadedDetailsTableAdapter.ClearBeforeFill = True
        '
        'JOLoadedDetailsBindingSource15
        '
        Me.JOLoadedDetailsBindingSource15.DataMember = "JOLoadedDetails"
        Me.JOLoadedDetailsBindingSource15.DataSource = Me.JOLodedDetails_3
        '
        'JOLoadedDetailsTableAdapter2
        '
        Me.JOLoadedDetailsTableAdapter2.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPSApp1.My.Resources.Resources.JOLegend
        Me.PictureBox1.Location = New System.Drawing.Point(40, 883)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frmWorkOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1857, 992)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnOpenJO)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cboByMachine)
        Me.Controls.Add(Me.btnByMachine)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUnload)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.grpJO_OrderDetails)
        Me.Controls.Add(Me.Label19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkOrder"
        Me.Text = "Work Order"
        Me.grpJO_OrderDetails.ResumeLayout(False)
        CType(Me.dgvJobOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLodedDetails_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetails_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetails1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListJobOrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListJobOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DowntimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetails_MachineIDOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedMachineID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.JOLoadedDetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetails1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetails2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetails2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOLoadedDetailsBindingSource15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpJO_OrderDetails As GroupBox
    Friend WithEvents btnLoad As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents JOSelectRTCheck As Timer
    Friend WithEvents btnUnload As FontAwesome.Sharp.IconButton
    Friend WithEvents Label19 As Label
    Friend WithEvents dgvJobOrder As DataGridView
    Friend WithEvents SPSDataSet1BindingSource As BindingSource
    Friend WithEvents SPSDataSet1 As SPSDataSet1
    Friend WithEvents DowntimeBindingSource As BindingSource
    Friend WithEvents DowntimeTableAdapter As SPSDataSet1TableAdapters.DowntimeTableAdapter

    Friend WithEvents MListJobOrderBindingSource As BindingSource

    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOBORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PARTNO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PARTNO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOLDCAVITYPART1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOLDCAVITYPART2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOBORDERQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CYCLETIMESECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STARTTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENDTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoldIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachineIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MListJobOrderBindingSource1 As BindingSource
    Friend WithEvents lblDGVJOCode As Label
    Friend WithEvents lblDGVP1 As Label
    Friend WithEvents lblDGVP2 As Label
    Friend WithEvents lblDGVCavP1 As Label
    Friend WithEvents lblDGVCavP2 As Label
    Friend WithEvents lblDGVJOQty As Label
    Friend WithEvents lblDGVCycleTime As Label
    Friend WithEvents lblDGVStartTime As Label
    Friend WithEvents lblDGVEndtime As Label
    Friend WithEvents lblDGVMoldID As Label
    Friend WithEvents lblDGVMachineId As Label
    Friend WithEvents lblDGVLoadStats As Label
    Friend WithEvents lblDGVProdnStat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblDGVid As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents btnByMachine As FontAwesome.Sharp.IconButton
    Friend WithEvents cboByMachine As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents lblJOLoadedBy As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnOpenJO As FontAwesome.Sharp.IconButton
    Friend WithEvents JOLoadedDetailsBindingSource As BindingSource
    Friend WithEvents lblUnloadedBY As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents JOLoadedMachineID As JOLoadedMachineID
    Friend WithEvents JOLoadedDetailsBindingSource1 As BindingSource
    Friend WithEvents JOLoadedDetailsTableAdapter1 As JOLoadedMachineIDTableAdapters.JOLoadedDetailsTableAdapter
    Friend WithEvents JOLoadedDetailsBindingSource2 As BindingSource
    Friend WithEvents JOLoadedDetails1BindingSource As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDGVShiftCode As Label
    Friend WithEvents JOLoadedDetailsBindingSource4 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource5 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource7 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource8 As BindingSource
    Friend WithEvents JOLoadedDetails1BindingSource1 As BindingSource
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblDGVAvtualP2Out As Label
    Friend WithEvents lblDGVActualPN1OUt As Label
    Friend WithEvents lblDGVPN2Reject As Label
    Friend WithEvents lblDGVPN1Reject As Label
    Friend WithEvents lblDGVPN2Output As Label
    Friend WithEvents lblDGVPN1Output As Label
    Friend WithEvents lblDGVTotalShots As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents JOLoadedDetailsBindingSource10 As BindingSource
    Friend WithEvents JOLoadedDetails_2 As JOLoadedDetails_2
    Friend WithEvents JOLoadedDetailsBindingSource11 As BindingSource
    Friend WithEvents JOLoadedDetailsTableAdapter3 As JOLoadedDetails_2TableAdapters.JOLoadedDetailsTableAdapter
    Friend WithEvents JOLoadedDetails2BindingSource As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource12 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource14 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource13 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource3 As BindingSource
    Friend WithEvents JOLoadedDetails2BindingSource1 As BindingSource
    Friend WithEvents JOLoadedDetailsBindingSource6 As BindingSource
    Friend WithEvents lblDGVTtlRunTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents JOLodedDetails_3 As JOLodedDetails_3
    Friend WithEvents JOLoadedDetailsBindingSource9 As BindingSource
    Friend WithEvents JOLoadedDetailsTableAdapter As JOLodedDetails_3TableAdapters.JOLoadedDetailsTableAdapter
    Friend WithEvents JOLoadedDetailsBindingSource15 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ShiftCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents LoadStatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdnStatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoadedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnloadedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnldDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlShotsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PN1OutputDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PN2OutputDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PN1RejectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PN2RejectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActualPN1OutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActualPN2OutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MSStartDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MSStopDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FPBStartDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FPBStopDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlMSTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlFPBTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtlRunTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOLoadedDetailsBindingSource16 As BindingSource
    Friend WithEvents lblDGVUnloadDT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents JOLoadedDetails_MachineIDOnly As JOLoadedDetails_MachineIDOnly
    Friend WithEvents JOLoadedDetailsBindingSource17 As BindingSource
    Friend WithEvents JOLoadedDetailsTableAdapter2 As JOLoadedDetails_MachineIDOnlyTableAdapters.JOLoadedDetailsTableAdapter
    Friend WithEvents lblMenuTabWorkOrder As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
