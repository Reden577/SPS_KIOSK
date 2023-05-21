Public Class frmWorkOrder

    '// FORM LOAD SUB
    Private Sub frmWorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.JOLoadedDetailsTableAdapter2.Fill(Me.JOLoadedDetails_MachineIDOnly.JOLoadedDetails)
        cboByMachine.Text = ""
        Me.JOLoadedDetailsTableAdapter.Fill(Me.JOLodedDetails_3.JOLoadedDetails)
        Me.CenterToScreen()
    End Sub
    '//

    '// JOB ORDER DETAILS SET VALUES
    Public Sub JobOrderLoadDetails()
        If preLDJODetail_MachineId = "Machine 1" Then
            stJOMC1 = preLDJODetail_JOCode
            stJOPartNo1MC1 = preLDJODetail_PN1
            stJOPartNo2MC1 = preLDJODetail_PN1
            stJOMoldCavP1MC1 = preLDJODetail_CavPN1
            stJOMoldCavP2MC1 = preLDJODetail_CavPN2
            stJOQuantityMC1 = preLDJODetail_PlanQty
            stJOCycleTimeMC1 = preLDJODetail_CycleTime
            stJOMoldIDMC1 = preLDJODetail_MoldId
            stJOMachineIDMC1 = preLDJODetail_MachineId
            stJOStartTimeMC1 = preLDJODetail_StartTime
            modJOLoadedFlagMC1 = True
        End If
        If preLDJODetail_MachineId = "Machine 2" Then
            stJOMC2 = preLDJODetail_JOCode
            stJOPartNo1MC2 = preLDJODetail_PN1
            stJOPartNo2MC2 = preLDJODetail_PN1
            stJOMoldCavP1MC2 = preLDJODetail_CavPN1
            stJOMoldCavP2MC2 = preLDJODetail_CavPN2
            stJOQuantityMC2 = preLDJODetail_PlanQty
            stJOCycleTimeMC2 = preLDJODetail_CycleTime
            stJOMoldIDMC2 = preLDJODetail_MoldId
            stJOMachineIDMC2 = preLDJODetail_MachineId
            stJOStartTimeMC2 = preLDJODetail_StartTime
            modJOLoadedFlagMC2 = True
        End If
        'If lblDGVMachineId.Text = "Machine 3" Then
        '    stJOMC3 = lblDGVJOCode.Text
        '    stJOPartNo1MC3 = lblDGVP1.Text
        '    stJOPartNo2MC3 = lblDGVP2.Text
        '    stJOMoldCavP1MC3 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC3 = lblDGVCavP2.Text
        '    stJOQuantityMC3 = lblDGVJOQty.Text
        '    stJOCycleTimeMC3 = lblDGVCycleTime.Text
        '    stJOMoldIDMC3 = lblDGVMoldID.Text
        '    stJOMachineIDMC3 = lblDGVMachineId.Text
        '    stJOStartTimeMC3 = stJOStartTime
        '    modJOLoadedFlagMC3 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 4" Then
        '    stJOMC4 = lblDGVJOCode.Text
        '    stJOPartNo1MC4 = lblDGVP1.Text
        '    stJOPartNo2MC4 = lblDGVP2.Text
        '    stJOMoldCavP1MC4 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC4 = lblDGVCavP2.Text
        '    stJOQuantityMC4 = lblDGVJOQty.Text
        '    stJOCycleTimeMC4 = lblDGVCycleTime.Text
        '    stJOMoldIDMC4 = lblDGVMoldID.Text
        '    stJOMachineIDMC4 = lblDGVMachineId.Text
        '    stJOStartTimeMC4 = stJOStartTime
        '    modJOLoadedFlagMC4 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 5" Then
        '    stJOMC5 = lblDGVJOCode.Text
        '    stJOPartNo1MC5 = lblDGVP1.Text
        '    stJOPartNo2MC5 = lblDGVP2.Text
        '    stJOMoldCavP1MC5 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC5 = lblDGVCavP2.Text
        '    stJOQuantityMC5 = lblDGVJOQty.Text
        '    stJOCycleTimeMC5 = lblDGVCycleTime.Text
        '    stJOMoldIDMC5 = lblDGVMoldID.Text
        '    stJOMachineIDMC5 = lblDGVMachineId.Text
        '    stJOStartTimeMC5 = stJOStartTime
        '    modJOLoadedFlagMC5 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 6" Then
        '    stJOMC6 = lblDGVJOCode.Text
        '    stJOPartNo1MC6 = lblDGVP1.Text
        '    stJOPartNo2MC6 = lblDGVP2.Text
        '    stJOMoldCavP1MC6 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC6 = lblDGVCavP2.Text
        '    stJOQuantityMC6 = lblDGVJOQty.Text
        '    stJOCycleTimeMC6 = lblDGVCycleTime.Text
        '    stJOMoldIDMC6 = lblDGVMoldID.Text
        '    stJOMachineIDMC6 = lblDGVMachineId.Text
        '    stJOStartTimeMC6 = stJOStartTime
        '    modJOLoadedFlagMC6 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 7" Then
        '    stJOMC7 = lblDGVJOCode.Text
        '    stJOPartNo1MC7 = lblDGVP1.Text
        '    stJOPartNo2MC7 = lblDGVP2.Text
        '    stJOMoldCavP1MC7 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC7 = lblDGVCavP2.Text
        '    stJOQuantityMC7 = lblDGVJOQty.Text
        '    stJOCycleTimeMC7 = lblDGVCycleTime.Text
        '    stJOMoldIDMC7 = lblDGVMoldID.Text
        '    stJOMachineIDMC7 = lblDGVMachineId.Text
        '    stJOStartTimeMC7 = stJOStartTime
        '    modJOLoadedFlagMC7 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 8" Then
        '    stJOMC8 = lblDGVJOCode.Text
        '    stJOPartNo1MC8 = lblDGVP1.Text
        '    stJOPartNo2MC8 = lblDGVP2.Text
        '    stJOMoldCavP1MC8 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC8 = lblDGVCavP2.Text
        '    stJOQuantityMC8 = lblDGVJOQty.Text
        '    stJOCycleTimeMC8 = lblDGVCycleTime.Text
        '    stJOMoldIDMC8 = lblDGVMoldID.Text
        '    stJOMachineIDMC8 = lblDGVMachineId.Text
        '    stJOStartTimeMC8 = stJOStartTime
        '    modJOLoadedFlagMC8 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 9" Then
        '    stJOMC9 = lblDGVJOCode.Text
        '    stJOPartNo1MC9 = lblDGVP1.Text
        '    stJOPartNo2MC9 = lblDGVP2.Text
        '    stJOMoldCavP1MC9 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC9 = lblDGVCavP2.Text
        '    stJOQuantityMC9 = lblDGVJOQty.Text
        '    stJOCycleTimeMC9 = lblDGVCycleTime.Text
        '    stJOMoldIDMC9 = lblDGVMoldID.Text
        '    stJOMachineIDMC9 = lblDGVMachineId.Text
        '    stJOStartTimeMC9 = stJOStartTime
        '    modJOLoadedFlagMC9 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 10" Then
        '    stJOMC10 = lblDGVJOCode.Text
        '    stJOPartNo1MC10 = lblDGVP1.Text
        '    stJOPartNo2MC10 = lblDGVP2.Text
        '    stJOMoldCavP1MC10 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC10 = lblDGVCavP2.Text
        '    stJOQuantityMC10 = lblDGVJOQty.Text
        '    stJOCycleTimeMC10 = lblDGVCycleTime.Text
        '    stJOMoldIDMC10 = lblDGVMoldID.Text
        '    stJOMachineIDMC10 = lblDGVMachineId.Text
        '    stJOStartTimeMC10 = stJOStartTime
        '    modJOLoadedFlagMC10 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 11" Then
        '    stJOMC11 = lblDGVJOCode.Text
        '    stJOPartNo1MC11 = lblDGVP1.Text
        '    stJOPartNo2MC11 = lblDGVP2.Text
        '    stJOMoldCavP1MC11 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC11 = lblDGVCavP2.Text
        '    stJOQuantityMC11 = lblDGVJOQty.Text
        '    stJOCycleTimeMC11 = lblDGVCycleTime.Text
        '    stJOMoldIDMC11 = lblDGVMoldID.Text
        '    stJOMachineIDMC11 = lblDGVMachineId.Text
        '    stJOStartTimeMC11 = stJOStartTime
        '    modJOLoadedFlagMC11 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 12" Then
        '    stJOMC12 = lblDGVJOCode.Text
        '    stJOPartNo1MC12 = lblDGVP1.Text
        '    stJOPartNo2MC12 = lblDGVP2.Text
        '    stJOMoldCavP1MC12 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC12 = lblDGVCavP2.Text
        '    stJOQuantityMC12 = lblDGVJOQty.Text
        '    stJOCycleTimeMC12 = lblDGVCycleTime.Text
        '    stJOMoldIDMC12 = lblDGVMoldID.Text
        '    stJOMachineIDMC12 = lblDGVMachineId.Text
        '    stJOStartTimeMC12 = stJOStartTime
        '    modJOLoadedFlagMC12 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 13" Then
        '    stJOMC13 = lblDGVJOCode.Text
        '    stJOPartNo1MC13 = lblDGVP1.Text
        '    stJOPartNo2MC13 = lblDGVP2.Text
        '    stJOMoldCavP1MC13 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC13 = lblDGVCavP2.Text
        '    stJOQuantityMC13 = lblDGVJOQty.Text
        '    stJOCycleTimeMC13 = lblDGVCycleTime.Text
        '    stJOMoldIDMC13 = lblDGVMoldID.Text
        '    stJOMachineIDMC13 = lblDGVMachineId.Text
        '    stJOStartTimeMC13 = stJOStartTime
        '    modJOLoadedFlagMC13 = True
        'End If
        'If lblDGVMachineId.Text = "Machine 14" Then
        '    stJOMC14 = lblDGVJOCode.Text
        '    stJOPartNo1MC14 = lblDGVP1.Text
        '    stJOPartNo2MC14 = lblDGVP2.Text
        '    stJOMoldCavP1MC14 = lblDGVCavP1.Text
        '    stJOMoldCavP2MC14 = lblDGVCavP2.Text
        '    stJOQuantityMC14 = lblDGVJOQty.Text
        '    stJOCycleTimeMC14 = lblDGVCycleTime.Text
        '    stJOMoldIDMC14 = lblDGVMoldID.Text
        '    stJOMachineIDMC14 = lblDGVMachineId.Text
        '    stJOStartTimeMC14 = stJOStartTime
        '    modJOLoadedFlagMC14 = True
        'End If
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
        lblChecking.Text = bolUpdateAndUnload
        EnableDisableUnloadBtn()
        DGVCellFormating_Loaded_Inprogress()
        DGVCellFormating_Unloaded_Incomplete()
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
    Public Sub EnableDisableUnloadBtn()
        If lblDGVLoadStats.Text = "Loaded" Then
            btnUnload.Enabled = True
        Else
            btnUnload.Enabled = False
        End If
    End Sub
    '//

    '//UNLOADING JOB ORDER
    Public Sub JobOrderUnloadDetails()
        If lblDGVMachineId.Text = "Machine 1" And lblDGVLoadStats.Text = "Loaded" Then
            stJOMC1 = Nothing
            stJOPartNo1MC1 = Nothing
            stJOPartNo2MC1 = Nothing
            stJOMoldCavP1MC1 = 0
            stJOMoldCavP2MC1 = 0
            stJOQuantityMC1 = Nothing
            stJOCycleTimeMC1 = Nothing
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
        If lblDGVMachineId.Text = "Machine 2" And lblDGVLoadStats.Text = "Loaded" Then
            stJOMC2 = Nothing
            stJOPartNo1MC2 = Nothing
            stJOPartNo2MC2 = Nothing
            stJOMoldCavP1MC2 = 0
            stJOMoldCavP2MC2 = 0
            stJOQuantityMC2 = Nothing
            stJOCycleTimeMC2 = Nothing
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
        '    If ckbMC3.Checked = True Then
        '        stJOMC3 = Nothing
        '        stJOPartNo1MC3 = Nothing
        '        stJOPartNo2MC3 = Nothing
        '        stJOMoldCavP1MC3 = 0
        '        stJOMoldCavP2MC3 = 0
        '        stJOQuantityMC3 = Nothing
        '        stJOCycleTimeMC3 = Nothing
        '        stJOMoldIDMC3 = Nothing
        '        stJOMachineIDMC3 = Nothing
        '        stJOStartTimeMC3 = Nothing
        '        iPlanProdTimeMC3 = 0
        '        runtimeMC3 = 0
        '        ckbMachine3 = True
        '        CounterP1MC3 = 0
        '        CounterP2MC3 = 0
        '        modJOLoadedFlagMC3 = False
        '    End If
        '    If ckbMC4.Checked = True Then
        '        stJOMC14 = Nothing
        '        stJOPartNo1MC4 = Nothing
        '        stJOPartNo2MC4 = Nothing
        '        stJOMoldCavP1MC4 = 0
        '        stJOMoldCavP2MC4 = 0
        '        stJOQuantityMC4 = Nothing
        '        stJOCycleTimeMC4 = Nothing
        '        stJOMoldIDMC4 = Nothing
        '        stJOMachineIDMC4 = Nothing
        '        stJOStartTimeMC4 = Nothing
        '        iPlanProdTimeMC4 = 0
        '        runtimeMC4 = 0
        '        ckbMachine4 = True
        '        CounterP1MC4 = 0
        '        CounterP2MC4 = 0
        '        modJOLoadedFlagMC4 = False
        '    End If
        '    If ckbMC5.Checked = True Then
        '        stJOMC5 = Nothing
        '        stJOPartNo1MC5 = Nothing
        '        stJOPartNo2MC5 = Nothing
        '        stJOMoldCavP1MC5 = 0
        '        stJOMoldCavP2MC5 = 0
        '        stJOQuantityMC5 = Nothing
        '        stJOCycleTimeMC5 = Nothing
        '        stJOMoldIDMC5 = Nothing
        '        stJOMachineIDMC5 = Nothing
        '        stJOStartTimeMC5 = Nothing
        '        iPlanProdTimeMC5 = 0
        '        runtimeMC5 = 0
        '        ckbMachine5 = True
        '        CounterP1MC5 = 0
        '        CounterP2MC5 = 0
        '        modJOLoadedFlagMC5 = False
        '    End If
        '    If ckbMC6.Checked = True Then
        '        stJOMC6 = Nothing
        '        stJOPartNo1MC6 = Nothing
        '        stJOPartNo2MC6 = Nothing
        '        stJOMoldCavP1MC6 = 0
        '        stJOMoldCavP2MC6 = 0
        '        stJOQuantityMC6 = Nothing
        '        stJOCycleTimeMC6 = Nothing
        '        stJOMoldIDMC6 = Nothing
        '        stJOMachineIDMC6 = Nothing
        '        stJOStartTimeMC6 = Nothing
        '        iPlanProdTimeMC6 = 0
        '        runtimeMC6 = 0
        '        ckbMachine6 = True
        '        CounterP1MC6 = 0
        '        CounterP2MC6 = 0
        '        modJOLoadedFlagMC6 = False
        '    End If
        '    If ckbMC7.Checked = True Then
        '        stJOMC7 = Nothing
        '        stJOPartNo1MC7 = Nothing
        '        stJOPartNo2MC7 = Nothing
        '        stJOMoldCavP1MC7 = 0
        '        stJOMoldCavP2MC7 = 0
        '        stJOQuantityMC7 = Nothing
        '        stJOCycleTimeMC7 = Nothing
        '        stJOMoldIDMC7 = Nothing
        '        stJOMachineIDMC7 = Nothing
        '        stJOStartTimeMC7 = Nothing
        '        iPlanProdTimeMC7 = 0
        '        runtimeMC7 = 0
        '        ckbMachine7 = True
        '        CounterP1MC7 = 0
        '        CounterP2MC7 = 0
        '        modJOLoadedFlagMC7 = False
        '    End If
        '    If ckbMC8.Checked = True Then
        '        stJOMC8 = Nothing
        '        stJOPartNo1MC8 = Nothing
        '        stJOPartNo2MC8 = Nothing
        '        stJOMoldCavP1MC8 = 0
        '        stJOMoldCavP2MC8 = 0
        '        stJOQuantityMC8 = Nothing
        '        stJOCycleTimeMC8 = Nothing
        '        stJOMoldIDMC8 = Nothing
        '        stJOMachineIDMC8 = Nothing
        '        stJOStartTimeMC8 = Nothing
        '        iPlanProdTimeMC8 = 0
        '        runtimeMC8 = 0
        '        ckbMachine8 = True
        '        CounterP1MC8 = 0
        '        CounterP2MC8 = 0
        '        modJOLoadedFlagMC8 = False
        '    End If
        '    If ckbMC9.Checked = True Then
        '        stJOMC9 = Nothing
        '        stJOPartNo1MC9 = Nothing
        '        stJOPartNo2MC9 = Nothing
        '        stJOMoldCavP1MC9 = 0
        '        stJOMoldCavP2MC9 = 0
        '        stJOQuantityMC9 = Nothing
        '        stJOCycleTimeMC9 = Nothing
        '        stJOMoldIDMC9 = Nothing
        '        stJOMachineIDMC9 = Nothing
        '        stJOStartTimeMC9 = Nothing
        '        iPlanProdTimeMC9 = 0
        '        runtimeMC9 = 0
        '        ckbMachine9 = True
        '        CounterP1MC9 = 0
        '        CounterP2MC9 = 0
        '        modJOLoadedFlagMC9 = False
        '    End If
        '    If ckbMC10.Checked = True Then
        '        stJOMC10 = Nothing
        '        stJOPartNo1MC10 = Nothing
        '        stJOPartNo2MC10 = Nothing
        '        stJOMoldCavP1MC10 = 0
        '        stJOMoldCavP2MC10 = 0
        '        stJOQuantityMC10 = Nothing
        '        stJOCycleTimeMC10 = Nothing
        '        stJOMoldIDMC10 = Nothing
        '        stJOMachineIDMC10 = Nothing
        '        stJOStartTimeMC10 = Nothing
        '        iPlanProdTimeMC10 = 0
        '        runtimeMC10 = 0
        '        ckbMachine10 = True
        '        CounterP1MC10 = 0
        '        CounterP2MC10 = 0
        '        modJOLoadedFlagMC10 = False
        '    End If
        '    If ckbMC11.Checked = True Then
        '        stJOMC11 = Nothing
        '        stJOPartNo1MC11 = Nothing
        '        stJOPartNo2MC11 = Nothing
        '        stJOMoldCavP1MC11 = 0
        '        stJOMoldCavP2MC11 = 0
        '        stJOQuantityMC11 = Nothing
        '        stJOCycleTimeMC11 = Nothing
        '        stJOMoldIDMC11 = Nothing
        '        stJOMachineIDMC11 = Nothing
        '        stJOStartTimeMC11 = Nothing
        '        iPlanProdTimeMC11 = 0
        '        runtimeMC11 = 0
        '        ckbMachine11 = True
        '        CounterP1MC11 = 0
        '        CounterP2MC11 = 0
        '        modJOLoadedFlagMC11 = False
        '    End If
        '    If ckbMC12.Checked = True Then
        '        stJOMC12 = Nothing
        '        stJOPartNo1MC12 = Nothing
        '        stJOPartNo2MC12 = Nothing
        '        stJOMoldCavP1MC12 = 0
        '        stJOMoldCavP2MC12 = 0
        '        stJOQuantityMC12 = Nothing
        '        stJOCycleTimeMC12 = Nothing
        '        stJOMoldIDMC12 = Nothing
        '        stJOMachineIDMC12 = Nothing
        '        stJOStartTimeMC12 = Nothing
        '        iPlanProdTimeMC12 = 0
        '        runtimeMC12 = 0
        '        ckbMachine12 = True
        '        CounterP1MC12 = 0
        '        CounterP2MC12 = 0
        '        modJOLoadedFlagMC12 = False
        '    End If
        '    If ckbMC13.Checked = True Then
        '        stJOMC13 = Nothing
        '        stJOPartNo1MC13 = Nothing
        '        stJOPartNo2MC13 = Nothing
        '        stJOMoldCavP1MC13 = 0
        '        stJOMoldCavP2MC13 = 0
        '        stJOQuantityMC13 = Nothing
        '        stJOCycleTimeMC13 = Nothing
        '        stJOMoldIDMC13 = Nothing
        '        stJOMachineIDMC13 = Nothing
        '        stJOStartTimeMC13 = Nothing
        '        iPlanProdTimeMC13 = 0
        '        runtimeMC13 = 0
        '        ckbMachine13 = True
        '        CounterP1MC13 = 0
        '        CounterP2MC13 = 0
        '        modJOLoadedFlagMC13 = False
        '    End If
        '    If ckbMC14.Checked = True Then
        '        stJOMC14 = Nothing
        '        stJOPartNo1MC14 = Nothing
        '        stJOPartNo2MC14 = Nothing
        '        stJOMoldCavP1MC14 = 0
        '        stJOMoldCavP2MC14 = 0
        '        stJOQuantityMC14 = Nothing
        '        stJOCycleTimeMC14 = Nothing
        '        stJOMoldIDMC14 = Nothing
        '        stJOMachineIDMC14 = Nothing
        '        stJOStartTimeMC14 = Nothing
        '        iPlanProdTimeMC14 = 0
        '        runtimeMC14 = 0
        '        ckbMachine14 = True
        '        CounterP1MC14 = 0
        '        CounterP2MC14 = 0
        '        modJOLoadedFlagMC14 = False
        '    End If
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
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDGV()
        cboByMachine.Text = ""
    End Sub
    '//

    '// FILTER BY MACHINE BUTTON
    Private Sub btnByMachine_Click(sender As Object, e As EventArgs) Handles btnByMachine.Click
        Me.JOLoadedDetailsTableAdapter.FillByMachineID(Me.JOLodedDetails_3.JOLoadedDetails, cboByMachine.Text)
    End Sub
    '// 

    '// CHANGING THE DGV ROW BACK AND FORE COLOR TO DEFAULT IF JO IS NOT YET LOADED
    Public Sub DGVCellFormating_NotLoaded()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = "Loaded" Then
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR IF JO PRODU'N STAT IS IN PROGRESS
    Public Sub DGVCellFormating_Loaded_Inprogress()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = "Loaded" Then
                row.DefaultCellStyle.BackColor = Color.Orange
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR IF JO IS ALREADY LOADED
    Public Sub DGVCellFormating_Loaded_Complete()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = "Loaded" Then
                row.DefaultCellStyle.BackColor = Color.Green
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
    '//

    '// CHANGING THE DGV ROW BACK AND FORE COLOR WHEN JO WAS UNLOADED WITH INCOMPLETE DATA
    Public Sub DGVCellFormating_Unloaded_Incomplete()
        For Each row As DataGridViewRow In dgvJobOrder.Rows
            If row.Cells(13).Value = "Unloaded" Then
                row.DefaultCellStyle.BackColor = Color.DarkRed
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
    '//

    '// UPDATING JOB ORDER LOADED DETAILS TO DB TABLE
    Public Sub MachineIDInitialsSub()
        If preLDJODetail_MachineId = "Machine 1" Then stMachineID = "MC1"
        If preLDJODetail_MachineId = "Machine 2" Then stMachineID = "MC2"
    End Sub
    Public Sub UpdateJO_At_Loading()
        MachineIDInitialsSub()
        Dim insert As New clsLogJODetails
        insert.AllowedMachine = preLDJODetail_MachineId
        insert.ShiftCode = sfShiftCodeMod & stMachineID
        insert.JOCode = preLDJODetail_JOCode
        insert.ModlID = preLDJODetail_MoldId
        insert.PN1 = preLDJODetail_PN1
        insert.PN2 = preLDJODetail_PN2
        insert.CavP1 = preLDJODetail_CavPN1
        insert.CavP2 = preLDJODetail_CavPN2
        insert.JOQty = preLDJODetail_PlanQty
        insert.CycleTime = preLDJODetail_CycleTime
        insert.StartTime = Now()
        insert.LoadStat = "Loaded"
        insert.ProdnStat = "In Progress"
        insert.LoadedBy = preLDJODetail_LoadedBy
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
        If lblDGVLoadStats.Text = "Loaded" Then
            btnLoad.Enabled = False
        ElseIf lblDGVLoadStats.Text = "Unloaded" Then
            btnLoad.Enabled = False
        Else
            btnLoad.Enabled = True
        End If
    End Sub

    Private Sub btnOpenJO_Click(sender As Object, e As EventArgs) Handles btnOpenJO.Click

        ClearDGVSelection()
        frmJOLoading.ShowDialog()
    End Sub



    '//
End Class