Public Class frmWorkOrder

    '// FORM LOAD SUB
    Private Sub frmWorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("Loading Work Order")
        Me.JOLoadedDetailsTableAdapter2.Fill(Me.JOLoadedDetails_MachineIDOnly.JOLoadedDetails)
        cboByMachine.Text = ""
        Me.JOLoadedDetailsTableAdapter.Fill(Me.JOLodedDetails_3.JOLoadedDetails)
        btnUnload.Enabled = False
        Me.CenterToScreen()
    End Sub
    '//

    '// JOB ORDER DETAILS SET VALUES
    Public Sub JobOrderLoadDetails()
        'MC1
        If preLDJODetail_MachineId = modMC1_stMCId Then
            stJOMC1 = preLDJODetail_JOCode
            stJOPartNo1MC1 = preLDJODetail_PN1
            stJOPartNo2MC1 = preLDJODetail_PN2
            stJOMoldCavP1MC1 = preLDJODetail_CavPN1
            stJOMoldCavP2MC1 = preLDJODetail_CavPN1 'ONLY 1 Cavity Qty for Two part numbers using CavPN1 for CavPN2
            stJOQuantityMC1 = preLDJODetail_PlanQty
            stJOCycleTimeMC1 = preLDJODetail_CycleTime
            stJOMoldIDMC1 = preLDJODetail_MoldId
            stJOMachineIDMC1 = stMachineID
            stJOStartTimeMC1 = preLDJODetail_StartTime
            modJOLoadedFlagMC1 = True
        End If
        'MC2
        If preLDJODetail_MachineId = modMC2_stMCId Then
            stJOMC2 = preLDJODetail_JOCode
            stJOPartNo1MC2 = preLDJODetail_PN1
            stJOPartNo2MC2 = preLDJODetail_PN2
            stJOMoldCavP1MC2 = preLDJODetail_CavPN1
            stJOMoldCavP2MC2 = preLDJODetail_CavPN1 'ONLY 1 Cavity Qty for Two part numbers using CavPN1 for CavPN2
            stJOQuantityMC2 = preLDJODetail_PlanQty
            stJOCycleTimeMC2 = preLDJODetail_CycleTime
            stJOMoldIDMC2 = preLDJODetail_MoldId
            stJOMachineIDMC2 = stMachineID
            stJOStartTimeMC2 = preLDJODetail_StartTime
            modJOLoadedFlagMC2 = True
        End If
    End Sub
    '//

    '// CLEARING PRE-LOADED JO DETAILS 
    Public Sub clearPreLDJODetails()
        preLDJODetail_ShifCode = Nothing
        preLDJODetail_MachineId = Nothing
        preLDJODetail_MoldId = Nothing
        preLDJODetail_JOCode = Nothing
        preLDJODetail_PN1 = Nothing
        preLDJODetail_PN2 = Nothing
        preLDJODetail_CavPN1 = 0
        preLDJODetail_CavPN2 = 0
        preLDJODetail_PlanQty = 0
        preLDJODetail_CycleTime = 0
        preLDJODetail_StartTime = Nothing
        preLDJODetail_LoadedBy = Nothing
    End Sub
    '//

    '// BUTTON CLEAR FUNCTION
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDGVSelection()
        btnUnload.Enabled = False
    End Sub
    '//

    '// BUTTON LOAD FUNCTION
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        JOloadBtnClick = True
        frmJOUserVerification.ShowDialog()
    End Sub
    '//

    '// REALTIME CHECK TIMER (100ms)
    Private Sub JOSelectRTCheck_Tick(sender As Object, e As EventArgs) Handles JOSelectRTCheck.Tick
        lblMenuTabWorkOrder.Text = menuTabWorkOrder
        'EnableDisableUnloadBtn()
        'FunctionsEnableDisable_At_MachineRunning()
        'DGVCellFormating_Loaded_Inprogress()
        'DGVCellFormating_Unloaded_Incomplete()
        'DGVCellFormating_PlanComplete_Loaded()
        'lblJOLoadedBy.Text = modLogUserName
        If Not menuTabWorkOrder = True Then
        End If

        If preLDJODetail_Confirm = True Then
            'stJOStartTime = Now()
            JobOrderLoadDetails()
            UpdateJO_At_Loading()
            RefreshDGV()
            'ClearSelectionDetails()
            clearPreLDJODetails()
            preLDJODetail_Confirm = False
            bolJOLoadConfirm = False

        End If

        If preUnloadDetails_Confirmed = True Then
            JobOrderUnloadDetails()
            RefreshDGV()
            bolJOUnloadConfirm = False
            bolUpdateAndUnload = False
            preUnloadDetails_Confirmed = False
            ClearDGVSelection()
        End If
    End Sub
    '//

    '// ENABLE / DISABLE UNLOAD BUTTON
    'Public Sub EnableDisableUnloadBtn()
    '    If RxPLCM0 = False Then
    '        If lblDGVLoadStats.Text = "Loaded" Then
    '            btnUnload.Enabled = True
    '        Else
    '            btnUnload.Enabled = False
    '        End If
    '    End If
    'End Sub
    '//

    '//UNLOADING JOB ORDER
    Public Sub JobOrderUnloadDetails()
        If lblDGVMachineId.Text = modMC1_stMCId And lblDGVLoadStats.Text = mod_stLoadStat_Loaded Then
            stJOMC1 = Nothing
            stJOPartNo1MC1 = Nothing
            stJOPartNo2MC1 = Nothing
            stJOMoldCavP1MC1 = 0
            stJOMoldCavP2MC1 = 0
            stJOQuantityMC1 = 0
            stJOCycleTimeMC1 = 0
            stJOMoldIDMC1 = Nothing
            stJOMachineIDMC1 = Nothing
            stJOStartTimeMC1 = Nothing
            iPlanProdTimeMC1 = 0
            runtimeMC1 = 0
            ckbMachine1 = True
            CounterP1MC1 = 0
            CounterP2MC1 = 0
            modJOLoadedFlagMC1 = False
        End If
        If lblDGVMachineId.Text = modMC2_stMCId And lblDGVLoadStats.Text = mod_stLoadStat_Loaded Then
            stJOMC2 = Nothing
            stJOPartNo1MC2 = Nothing
            stJOPartNo2MC2 = Nothing
            stJOMoldCavP1MC2 = 0
            stJOMoldCavP2MC2 = 0
            stJOQuantityMC2 = 0
            stJOCycleTimeMC2 = 0
            stJOMoldIDMC2 = Nothing
            stJOMachineIDMC2 = Nothing
            stJOStartTimeMC2 = Nothing
            iPlanProdTimeMC2 = 0
            runtimeMC2 = 0
            ckbMachine2 = True
            CounterP1MC2 = 0
            CounterP2MC2 = 0
            modJOLoadedFlagMC2 = False
        End If
    End Sub
    '//

    '// UNLOAD BUTTON FUNCTION
    Private Sub btnUnload_Click(sender As Object, e As EventArgs) Handles btnUnload.Click
        LoadingPreUnloadDetails()
        'bolUpdateAndUnload = True
        'stJOMachineID_Unloading = lblDGVMachineId.Text
        frmJOUnload.ShowDialog()
    End Sub
    '//

    '// PULLS THE SELECTED ROW CONTENT AND DISPLAY TO JO SUMMARY BOX
    Private Sub dgvJobOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobOrder.CellContentClick

        lblDGVid.Text = dgvJobOrder.CurrentRow.Cells(0).Value.ToString
            lblDGVMachineId.Text = dgvJobOrder.CurrentRow.Cells(1).Value.ToString
            lblDGVShiftCode.Text = dgvJobOrder.CurrentRow.Cells(2).Value.ToString
            lblDGVJOCode.Text = dgvJobOrder.CurrentRow.Cells(3).Value.ToString
            lblDGVMoldID.Text = dgvJobOrder.CurrentRow.Cells(4).Value.ToString
            lblDGVP1.Text = dgvJobOrder.CurrentRow.Cells(5).Value.ToString
            lblDGVP2.Text = dgvJobOrder.CurrentRow.Cells(6).Value.ToString
            lblDGVCavP1.Text = dgvJobOrder.CurrentRow.Cells(7).Value.ToString
            lblDGVCavP2.Text = dgvJobOrder.CurrentRow.Cells(8).Value.ToString
            lblDGVJOQty.Text = dgvJobOrder.CurrentRow.Cells(9).Value.ToString
            lblDGVCycleTime.Text = dgvJobOrder.CurrentRow.Cells(10).Value.ToString
            lblDGVStartTime.Text = dgvJobOrder.CurrentRow.Cells(11).Value.ToString
            lblDGVEndtime.Text = dgvJobOrder.CurrentRow.Cells(12).Value.ToString
            lblDGVLoadStats.Text = dgvJobOrder.CurrentRow.Cells(13).Value.ToString
            lblDGVProdnStat.Text = dgvJobOrder.CurrentRow.Cells(14).Value.ToString
            lblJOLoadedBy.Text = dgvJobOrder.CurrentRow.Cells(15).Value.ToString
            lblUnloadedBY.Text = dgvJobOrder.CurrentRow.Cells(16).Value.ToString
            lblDGVUnloadDT.Text = dgvJobOrder.CurrentRow.Cells(17).Value.ToString
            lblDGVTotalShots.Text = dgvJobOrder.CurrentRow.Cells(18).Value.ToString
            lblDGVPN1Output.Text = dgvJobOrder.CurrentRow.Cells(19).Value.ToString
            lblDGVPN2Output.Text = dgvJobOrder.CurrentRow.Cells(20).Value.ToString
            lblDGVPN1Reject.Text = dgvJobOrder.CurrentRow.Cells(21).Value.ToString
            lblDGVPN2Reject.Text = dgvJobOrder.CurrentRow.Cells(22).Value.ToString
            lblDGVActualPN1OUt.Text = dgvJobOrder.CurrentRow.Cells(23).Value.ToString
            lblDGVAvtualP2Out.Text = dgvJobOrder.CurrentRow.Cells(24).Value.ToString
        lblDGVTtlRunTime.Text = dgvJobOrder.CurrentRow.Cells(31).Value.ToString

        CheckMachineID_RunStopStat()

    End Sub
    '//

    '//
    Public Sub LoadingPreUnloadDetails()
        preUnloadDetails_MCId = lblDGVMachineId.Text
        preUnloadDetails_SftCode = lblDGVShiftCode.Text
        preUnloadDetails_JOCode = lblDGVJOCode.Text
        preUnloadDetails_MoldId = lblDGVMoldID.Text
        preUnloadDetails_PN1 = lblDGVP1.Text
        preUnloadDetails_PN2 = lblDGVP2.Text
        preUnloadDetails_CavP1 = lblDGVCavP1.Text
        preUnloadDetails_CavP2 = lblDGVCavP2.Text
        preUnloadDetails_JoQty = lblDGVJOQty.Text
        preUnloadDetails_CycleTime = lblDGVCycleTime.Text
        preUnloadDetails_StartTime = lblDGVStartTime.Text
        preUnloadDetails_EndTime = lblDGVEndtime.Text
        preUnloadDetails_LoadStat = lblDGVLoadStats.Text
        preUnloadDetails_ProdnStat = lblDGVProdnStat.Text
        preUnloadDetails_LoadedBy = lblJOLoadedBy.Text
        preUnloadDetails_UnloadedBy = lblUnloadedBY.Text
    End Sub
    '//

    '// REFRESH BUTTON , DGV BACK TO DEFAULT STATE
    Public Sub RefreshDGV()
        Me.JOLoadedDetailsTableAdapter.Fill(Me.JOLodedDetails_3.JOLoadedDetails)
        DGVCellFormating_Loaded_Inprogress()
        DGVCellFormating_Unloaded_Incomplete()
        DGVCellFormating_PlanComplete_Loaded()
        DGVCellFormating_PlanComplete_Unloaded()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDGV()
        cboByMachine.Text = ""
    End Sub
    '//

    '// FILTER BY MACHINE BUTTON
    Private Sub btnByMachine_Click(sender As Object, e As EventArgs) Handles btnByMachine.Click
        Me.JOLoadedDetailsTableAdapter.FillByMachineID(Me.JOLodedDetails_3.JOLoadedDetails, cboByMachine.Text)
        DGVCellFormating_Loaded_Inprogress()
        DGVCellFormating_Unloaded_Incomplete()
        DGVCellFormating_PlanComplete_Loaded()
        DGVCellFormating_PlanComplete_Unloaded()
    End Sub
    '// 

    '// CHANGING THE DGV ROW BACK AND FORE COLOR TO DEFAULT IF JO IS NOT YET LOADED
    Public Sub DGVCellFormating_NotLoaded()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = mod_stLoadStat_Loaded Then
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR IF JO PRODU'N STAT IS IN PROGRESS
    Public Sub DGVCellFormating_Loaded_Inprogress()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = mod_stLoadStat_Loaded Then
                row.DefaultCellStyle.BackColor = Color.Orange
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR IF PLAN COMPLETE
    Public Sub DGVCellFormating_PlanComplete_Unloaded()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = mod_stLoadStat_Unloaded And row.Cells(14).Value = mod_stProdStat_PlanComplete Then
                row.DefaultCellStyle.BackColor = Color.Green
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR WHEN JO WAS UNLOADED WITH INCOMPLETE DATA
    Public Sub DGVCellFormating_Unloaded_Incomplete()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = mod_stLoadStat_Unloaded And row.DefaultCellStyle.BackColor <> Color.DarkRed _
                And row.Cells(14).Value = mod_stProdStat_INC Then
                row.DefaultCellStyle.BackColor = Color.DarkRed
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR WHEN JO WAS UNLOADED WITH INCOMPLETE DATA
    Public Sub DGVCellFormating_PlanComplete_Loaded()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = mod_stLoadStat_Loaded And row.Cells(14).Value = mod_stProdStat_PlanComplete _
                And row.DefaultCellStyle.BackColor <> Color.GreenYellow Then
                row.DefaultCellStyle.BackColor = Color.GreenYellow
                row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    '//

    '// UPDATING JOB ORDER LOADED DETAILS TO DB TABLE
    'Public Sub MachineIDInitialsSub()
    '    If preLDJODetail_MachineId = "Machine 1" Then stMachineID = "MC1"
    '    If preLDJODetail_MachineId = "Machine 2" Then stMachineID = "MC2"
    'End Sub
    Public Sub UpdateJO_At_Loading()
        'MachineIDInitialsSub()
        Dim insert As New clsLogJODetails
        insert.AllowedMachine = preLDJODetail_MachineId
        insert.ShiftCode = sfShiftCodeMod & preLDJODetail_MachineId
        insert.JOCode = preLDJODetail_JOCode
        insert.ModlID = preLDJODetail_MoldId
        insert.PN1 = preLDJODetail_PN1
        insert.PN2 = preLDJODetail_PN2
        insert.CavP1 = preLDJODetail_CavPN1
        insert.CavP2 = preLDJODetail_CavPN2
        insert.JOQty = preLDJODetail_PlanQty
        insert.CycleTime = preLDJODetail_CycleTime
        insert.StartTime = Now()
        insert.EndTime = "none"
        insert.LoadStat = mod_stLoadStat_Loaded
        insert.ProdnStat = mod_stProdStat_InProg
        insert.LoadedBy = preLDJODetail_LoadedBy
        insert.UnloadedBy = "none"
        insert.UnloadTime = "none"
        insert.TotalShots = 0
        insert.PN1OUtput = 0
        insert.PN2Output = 0
        insert.PN1Reject = 0
        insert.Pn2Reject = 0
        insert.ActualPN1Output = 0
        insert.ActualPN2Output = 0
        insert.MSStartTime = "none"
        insert.MSStopTime = "none"
        insert.FPBStartTime = "none"
        insert.FPBStopTime = "none"
        insert.TtlMSTime = 0
        insert.TtlFPBTime = 0
        insert.TotalRunTime = 0
        insert.BuildingNo = "Building A"
        insert.logJODetails()
    End Sub
    '//

    '// CLEAR SELECTED DGV ROW AND JO SUMMARY DISPLAY
    Public Sub ClearDGVSelection()
        dgvJobOrder.ClearSelection()
        lblDGVid.Text = "0"
        lblDGVJOCode.Text = "-"
        lblDGVP1.Text = "-"
        lblDGVP2.Text = "-"
        lblDGVCavP1.Text = "0"
        lblDGVCavP2.Text = "0"
        lblDGVJOQty.Text = "0"
        lblDGVCycleTime.Text = "0"
        lblDGVStartTime.Text = "-"
        lblDGVEndtime.Text = "-"
        lblDGVMoldID.Text = "-"
        lblDGVMachineId.Text = "-"
        lblDGVLoadStats.Text = "-"
        lblDGVProdnStat.Text = "-"
        cboByMachine.Text = ""
        lblDGVShiftCode.Text = "-"
        lblJOLoadedBy.Text = "-"
        lblUnloadedBY.Text = "-"
        lblDGVUnloadDT.Text = "-"
        lblDGVTotalShots.Text = "0"
        lblDGVPN1Output.Text = "0"
        lblDGVPN2Output.Text = "0"
        lblDGVPN1Reject.Text = "0"
        lblDGVPN2Reject.Text = "0"
        lblDGVActualPN1OUt.Text = "0"
        lblDGVAvtualP2Out.Text = "0"
        lblDGVTtlRunTime.Text = "0"
        RefreshDGV()
    End Sub
    '//

    '//
    Private Sub btnClearDGVselection_Click(sender As Object, e As EventArgs)

    End Sub
    '//

    '// JOB ORDER CODE TEXT CHANGE EVENTS
    Private Sub lblDGVJOCode_TextChanged(sender As Object, e As EventArgs) Handles lblDGVJOCode.TextChanged

    End Sub
    '//

    '// ENDABLE DISABLE BUTTON LOAD
    Private Sub lblDGVLoadStats_TextChanged(sender As Object, e As EventArgs) Handles lblDGVLoadStats.TextChanged
        If lblDGVLoadStats.Text = mod_stLoadStat_Loaded Then
            btnLoad.Enabled = False
        ElseIf lblDGVLoadStats.Text = mod_stLoadStat_Unloaded Then
            btnLoad.Enabled = False
        Else
            btnLoad.Enabled = True
        End If
    End Sub

    Private Sub btnOpenJO_Click(sender As Object, e As EventArgs) Handles btnOpenJO.Click

        ClearDGVSelection()
        frmJOLoading.ShowDialog()
    End Sub

    Private Sub lblMenuTabWorkOrder_TextChanged(sender As Object, e As EventArgs) Handles lblMenuTabWorkOrder.TextChanged
        If menuTabWorkOrder = True Then
            RefreshDGV()
        End If
    End Sub
    '//

    '//
    'Public Sub FunctionsEnableDisable_At_MachineRunning()
    '    If RxPLCM0 = True Then
    '        'grpJO_OrderDetails.Enabled = False
    '        btnOpenJO.Enabled = False
    '    Else
    '        'grpJO_OrderDetails.Enabled = True
    '        btnOpenJO.Enabled = True
    '    End If
    'End Sub
    '//

    '// ENABLE DISABLE UNLOAD BUTTON
    '// check machine ID if Running or Stop
    Public Sub CheckMachineID_RunStopStat()

        If lblDGVMachineId.Text = modMC1_stMCId Then
            If RxPLCM0 = False And lblDGVLoadStats.Text = mod_stLoadStat_Loaded Then
                btnUnload.Enabled = True
            ElseIf RxPLCM0 = True Then
                btnUnload.Enabled = False
                MessageBox.Show("Machine 1 is currently running!" _
                                & vbNewLine & "Unloading JO is not possible...", "Button Status...")
            Else
                btnUnload.Enabled = False
            End If

        ElseIf lblDGVMachineId.Text = modMC2_stMCId Then
            If RxPLCM1 = False And lblDGVLoadStats.Text = mod_stLoadStat_Loaded Then
                btnUnload.Enabled = True
            ElseIf RxPLCM1 = True Then
                btnUnload.Enabled = False
                MessageBox.Show("Machine 2 is currently running!" _
                                & vbNewLine & "Unloading JO is not possible...", "Button Status...")
            Else
                btnUnload.Enabled = False
            End If
        End If

    End Sub
    '//
End Class