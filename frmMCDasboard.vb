Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class frmMCDasboard
    'Declaring virables for the listbox in a specific location
    Dim stStopDetails As String = "{0,-40}{1,-30}{2,-30}{3,-30}"

    Private Sub frmMCDasboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SPSDataSet1.Downtime' table. You can move, or remove it, as needed.
        lblQAInfoDetails.Visible = False

        Me.CenterToScreen()

        If bolMCDashboard1 = True Then
            lblMCDasboard.Text = "Machine 1"
            modSetVal_MCID = modMC1_stMCId
            modSetVal_DTNewStoppage = modMC1_stNewStoppage
            modSetVal_JCode = stJOMC1
        ElseIf bolMCDashboard2 = True Then
            lblMCDasboard.Text = "Machine 2"
            modSetVal_DTNewStoppage = modMC2_stNewStoppage
            modSetVal_MCID = modMC2_stMCId
            modSetVal_JCode = stJOMC2
        ElseIf bolMCDashboard3 = True Then
            lblMCDasboard.Text = "Machine 3"
            modSetVal_DTNewStoppage = modMC3_stNewStoppage
            modSetVal_MCID = modMC3_stMCId
            modSetVal_JCode = stJOMC3
        ElseIf bolMCDashboard4 = True Then
            lblMCDasboard.Text = "Machine 4"
            modSetVal_DTNewStoppage = modMC4_stNewStoppage
            modSetVal_MCID = modMC4_stMCId
            modSetVal_JCode = stJOMC4
        ElseIf bolMCDashboard5 = True Then
            lblMCDasboard.Text = "Machine 5"
            modSetVal_DTNewStoppage = modMC5_stNewStoppage
            modSetVal_MCID = modMC5_stMCId
            modSetVal_JCode = stJOMC5
        ElseIf bolMCDashboard6 = True Then
            lblMCDasboard.Text = "Machine 6"
            modSetVal_DTNewStoppage = modMC6_stNewStoppage
            modSetVal_MCID = modMC6_stMCId
            modSetVal_JCode = stJOMC6
        ElseIf bolMCDashboard7 = True Then
            lblMCDasboard.Text = "Machine 7"
            modSetVal_DTNewStoppage = modMC7_stNewStoppage
            modSetVal_MCID = modMC7_stMCId
            modSetVal_JCode = stJOMC7
        ElseIf bolMCDashboard8 = True Then
            lblMCDasboard.Text = "Machine 8"
            modSetVal_DTNewStoppage = modMC8_stNewStoppage
            modSetVal_MCID = modMC8_stMCId
            modSetVal_JCode = stJOMC8
        ElseIf bolMCDashboard9 = True Then
            lblMCDasboard.Text = "Machine 9"
            modSetVal_DTNewStoppage = modMC9_stNewStoppage
            modSetVal_MCID = modMC9_stMCId
            modSetVal_JCode = stJOMC9
        ElseIf bolMCDashboard10 = True Then
            lblMCDasboard.Text = "Machine 10"
            modSetVal_DTNewStoppage = modMC10_stNewStoppage
            modSetVal_MCID = modMC10_stMCId
            modSetVal_JCode = stJOMC10
        ElseIf bolMCDashboard11 = True Then
            lblMCDasboard.Text = "Machine 11"
            modSetVal_DTNewStoppage = modMC11_stNewStoppage
            modSetVal_MCID = modMC11_stMCId
            modSetVal_JCode = stJOMC11
        ElseIf bolMCDashboard12 = True Then
            lblMCDasboard.Text = "Machine 12"
            modSetVal_DTNewStoppage = modMC12_stNewStoppage
            modSetVal_MCID = modMC12_stMCId
            modSetVal_JCode = stJOMC12
        ElseIf bolMCDashboard13 = True Then
            lblMCDasboard.Text = "Machine 13"
            modSetVal_DTNewStoppage = modMC13_stNewStoppage
            modSetVal_MCID = modMC13_stMCId
            modSetVal_JCode = stJOMC13
        ElseIf bolMCDashboard14 = True Then
            lblMCDasboard.Text = "Machine 14"
            modSetVal_DTNewStoppage = modMC14_stNewStoppage
            modSetVal_MCID = modMC14_stMCId
            modSetVal_JCode = stJOMC14
        ElseIf bolMCDashboard15 = True Then
            lblMCDasboard.Text = "Machine 15"
            modSetVal_DTNewStoppage = modMC15_stNewStoppage
            modSetVal_MCID = modMC15_stMCId
            modSetVal_JCode = stJOMC15
        ElseIf bolMCDashboard16 = True Then
            lblMCDasboard.Text = "Machine 16"
            modSetVal_DTNewStoppage = modMC16_stNewStoppage
            modSetVal_MCID = modMC16_stMCId
            modSetVal_JCode = stJOMC16
        ElseIf bolMCDashboard17 = True Then
            lblMCDasboard.Text = "Machine 17"
            modSetVal_DTNewStoppage = modMC17_stNewStoppage
            modSetVal_MCID = modMC17_stMCId
            modSetVal_JCode = stJOMC17
        ElseIf bolMCDashboard18 = True Then
            lblMCDasboard.Text = "Machine 18"
            modSetVal_DTNewStoppage = modMC18_stNewStoppage
            modSetVal_MCID = modMC18_stMCId
            modSetVal_JCode = stJOMC18
        ElseIf bolMCDashboard19 = True Then
            lblMCDasboard.Text = "Machine 19"
            modSetVal_DTNewStoppage = modMC19_stNewStoppage
            modSetVal_MCID = modMC19_stMCId
            modSetVal_JCode = stJOMC19
        End If

        Me.DowntimeTableAdapter.FillByDTStatus(Me.SPSDataSet1.Downtime, "modSetVal_DTNewStoppage")
        DropdownShiftCodeDistinctValue()
        UpdateDowntimetoDataGridVidw()
        cboShiftCode.Text = ""
    End Sub

    Private Sub frmMCDasboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        bolMCDashboard1 = False
        bolMCDashboard2 = False
        bolMCDashboard3 = False
        bolMCDashboard4 = False
        bolMCDashboard5 = False
        bolMCDashboard6 = False
        bolMCDashboard7 = False
        bolMCDashboard8 = False
        bolMCDashboard9 = False
        bolMCDashboard10 = False
        bolMCDashboard11 = False
        bolMCDashboard12 = False
        bolMCDashboard13 = False
        bolMCDashboard14 = False
        bolMCDashboard15 = False
        bolMCDashboard16 = False
        bolMCDashboard17 = False
        bolMCDashboard18 = False
        bolMCDashboard19 = False

        modSetVal_DTNewStoppage = ""
        modSetVal_MCID = ""
    End Sub

    Public Sub MachineStatusImage()
        Dim mcStopImage As New Bitmap(My.Resources.STOPSIGN_1)
        Dim mcRunImage As New Bitmap(My.Resources.RUNSIGN_1)
        Dim mcQAImage As New Bitmap(My.Resources.QASIGN__1)
        Dim mcNOPlanImage As New Bitmap(My.Resources.NOPLAN_SIGN_1)
        Dim mcPlanComplete As New Bitmap(My.Resources.PLANCOMPLETE)
        Dim mcQAStoppage As New Bitmap(My.Resources.QASIGN)


        If bolMCDashboard1 = True And StartStopMC1 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard1 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
        ElseIf bolMCDashboard1 = True And modQA_DTStat_MC1 = True Then
            picMCStatus.Image = mcQAStoppage
        ElseIf bolMCDashboard1 = True And RxPLCM14 = True Then
            picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard2 = True And StartStopMC2 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard2 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
        ElseIf bolMCDashboard1 = True And modQA_DTStat_MC2 = True Then
            picMCStatus.Image = mcQAStoppage
        ElseIf bolMCDashboard2 = True And RxPLCM15 = True Then
            picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard3 = True And StartStopMC3 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard3 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard3 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard4 = True And StartStopMC4 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard4 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard4 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard5 = True And StartStopMC5 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard5 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard5 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard6 = True And StartStopMC6 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard6 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard6 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard7 = True And StartStopMC7 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard7 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard7 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard8 = True And StartStopMC8 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard8 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard8 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard9 = True And StartStopMC9 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard9 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard9 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard10 = True And StartStopMC10 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard10 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard10 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard11 = True And StartStopMC11 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard11 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard11 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard12 = True And StartStopMC12 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard12 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard12 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard13 = True And StartStopMC13 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard13 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard13 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard14 = True And StartStopMC14 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard14 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard14 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard15 = True And StartStopMC15 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard15 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard15 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard16 = True And StartStopMC16 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard16 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard16 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard17 = True And StartStopMC17 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard17 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard17 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard18 = True And StartStopMC18 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard18 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard18 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        ElseIf bolMCDashboard19 = True And StartStopMC19 = True Then
            picMCStatus.Image = mcRunImage
        ElseIf bolMCDashboard19 = True And lblJobOrderCode.Text = "" Then
            picMCStatus.Image = mcNOPlanImage
            'ElseIf bolMCDashboard19 = True And RxPLCM15 = True Then
            '    picMCStatus.Image = mcPlanComplete

        Else
            picMCStatus.Image = mcStopImage
        End If
    End Sub

    Public Sub MachineDetails()
        lblShift.Text = sfShiftCodeMod
        If bolMCDashboard1 = True Then
            lblActualQty0.Text = TotalCountMC1
            lblActualQty1.Text = TotalCountMC1
            lblPPT.Text = iPlanProdTimeMC1    '((CInt(stJOCycleTimeMC1) / (CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60
            lblART.Text = Math.Round((runtimeMC1 / 60), 2) 'minutes
            lblUserName.Text = UNmc1
            lblUserID.Text = UNIdmc1
            lblJobOrderCode.Text = stJOMC1
            lblPartNo1.Text = stJOPartNo1MC1
            lblPartNo2.Text = stJOPartNo2MC1
            lblMoldNo.Text = stJOMoldIDMC1
            lblCavQtyP1.Text = stJOMoldCavP1MC1
            lblCavQtyP2.Text = stJOMoldCavP2MC1
            lblPlannedQTY.Text = stJOQuantityMC1
            lblCycleTime.Text = stJOCycleTimeMC1
            lblDateTimeStart.Text = stJOStartTimeMC1
            lblOutputP1.Text = CounterP1MC1
            lblOutputP2.Text = CounterP2MC1
            lblShift.Text = sfShiftCodeMod & modSetVal_MCID
        End If
        If bolMCDashboard2 = True Then
            lblActualQty0.Text = TotalCountMC2
            lblActualQty1.Text = TotalCountMC2
            lblPPT.Text = iPlanProdTimeMC2    '((CInt(stJOCycleTimeMC2) / (CInt(stJOMoldCavP1MC2) + CInt(stJOMoldCavP2MC2))) * CInt(stJOQuantityMC2)) / 60
            lblART.Text = Math.Round((runtimeMC2 / 60), 2) 'minutes
            lblUserName.Text = UNmc2
            lblUserID.Text = UNIdmc2
            lblJobOrderCode.Text = stJOMC2
            lblPartNo1.Text = stJOPartNo1MC2
            lblPartNo2.Text = stJOPartNo2MC2
            lblMoldNo.Text = stJOMoldIDMC2
            lblCavQtyP1.Text = stJOMoldCavP1MC2
            lblCavQtyP2.Text = stJOMoldCavP2MC2
            lblPlannedQTY.Text = stJOQuantityMC2
            lblCycleTime.Text = stJOCycleTimeMC2
            lblDateTimeStart.Text = stJOStartTimeMC2
            lblOutputP1.Text = CounterP1MC2
            lblOutputP2.Text = CounterP2MC2
            lblShift.Text = sfShiftCodeMod & "MC2"
        End If
        If bolMCDashboard3 = True Then
            lblActualQty0.Text = TotalCountMC3
            lblActualQty1.Text = TotalCountMC3
            lblPPT.Text = iPlanProdTimeMC3 '((CInt(stJOCycleTimeMC3) / (CInt(stJOMoldCavP1MC3) + CInt(stJOMoldCavP2MC3))) * CInt(stJOQuantityMC3)) / 60
            lblART.Text = Math.Round((runtimeMC3 / 60), 2) 'minutes
            lblUserName.Text = UNmc3
            lblUserID.Text = UNIdmc3
            lblJobOrderCode.Text = stJOMC3
            lblPartNo1.Text = stJOPartNo1MC3
            lblPartNo2.Text = stJOPartNo2MC13
            lblMoldNo.Text = stJOMoldIDMC3
            lblCavQtyP1.Text = stJOMoldCavP1MC3
            lblCavQtyP2.Text = stJOMoldCavP2MC3
            lblPlannedQTY.Text = stJOQuantityMC3
            lblCycleTime.Text = stJOCycleTimeMC3
            lblDateTimeStart.Text = stJOStartTimeMC3
            lblOutputP1.Text = CounterP1MC3
            lblOutputP2.Text = CounterP2MC3
            lblShift.Text = sfShiftCodeMod & "MC3"
        End If
        If bolMCDashboard4 = True Then
            lblActualQty0.Text = TotalCountMC4
            lblActualQty1.Text = TotalCountMC4
            lblPPT.Text = iPlanProdTimeMC4  '((CInt(stJOCycleTimeMC4) / (CInt(stJOMoldCavP1MC4) + CInt(stJOMoldCavP2MC4))) * CInt(stJOQuantityMC4)) / 60
            lblART.Text = Math.Round((runtimeMC4 / 60), 2) 'minutes
            lblUserName.Text = UNmc4
            lblUserID.Text = UNIdmc4
            lblJobOrderCode.Text = stJOMC4
            lblPartNo1.Text = stJOPartNo1MC4
            lblPartNo2.Text = stJOPartNo2MC4
            lblMoldNo.Text = stJOMoldIDMC4
            lblCavQtyP1.Text = stJOMoldCavP1MC4
            lblCavQtyP2.Text = stJOMoldCavP2MC4
            lblPlannedQTY.Text = stJOQuantityMC4
            lblCycleTime.Text = stJOCycleTimeMC4
            lblDateTimeStart.Text = stJOStartTimeMC4
            lblOutputP1.Text = CounterP1MC4
            lblOutputP2.Text = CounterP2MC4
            lblShift.Text = sfShiftCodeMod & "MC4"
        End If
        If bolMCDashboard5 = True Then
            lblActualQty0.Text = TotalCountMC5
            lblActualQty1.Text = TotalCountMC5
            lblPPT.Text = iPlanProdTimeMC5  '((CInt(stJOCycleTimeMC5) / (CInt(stJOMoldCavP1MC5) + CInt(stJOMoldCavP2MC5))) * CInt(stJOQuantityMC5)) / 60
            lblART.Text = Math.Round((runtimeMC5 / 60), 2) 'minutes
            lblUserName.Text = UNmc5
            lblUserID.Text = UNIdmc5
            lblJobOrderCode.Text = stJOMC5
            lblPartNo1.Text = stJOPartNo1MC5
            lblPartNo2.Text = stJOPartNo2MC5
            lblMoldNo.Text = stJOMoldIDMC5
            lblCavQtyP1.Text = stJOMoldCavP1MC5
            lblCavQtyP2.Text = stJOMoldCavP2MC5
            lblPlannedQTY.Text = stJOQuantityMC5
            lblCycleTime.Text = stJOCycleTimeMC5
            lblDateTimeStart.Text = stJOStartTimeMC5
            lblOutputP1.Text = CounterP1MC5
            lblOutputP2.Text = CounterP2MC5
            lblShift.Text = sfShiftCodeMod & "MC5"
        End If
        If bolMCDashboard6 = True Then
            lblActualQty0.Text = TotalCountMC6
            lblActualQty1.Text = TotalCountMC6
            lblPPT.Text = iPlanProdTimeMC6    '((CInt(stJOCycleTimeMC6) / (CInt(stJOMoldCavP1MC6) + CInt(stJOMoldCavP2MC6))) * CInt(stJOQuantityMC6)) / 60
            lblART.Text = Math.Round((runtimeMC6 / 60), 2) 'minutes
            lblUserName.Text = UNmc6
            lblUserID.Text = UNIdmc6
            lblJobOrderCode.Text = stJOMC6
            lblPartNo1.Text = stJOPartNo1MC6
            lblPartNo2.Text = stJOPartNo2MC6
            lblMoldNo.Text = stJOMoldIDMC6
            lblCavQtyP1.Text = stJOMoldCavP1MC6
            lblCavQtyP2.Text = stJOMoldCavP2MC6
            lblPlannedQTY.Text = stJOQuantityMC6
            lblCycleTime.Text = stJOCycleTimeMC6
            lblDateTimeStart.Text = stJOStartTimeMC6
            lblOutputP1.Text = CounterP1MC6
            lblOutputP2.Text = CounterP2MC6
            lblShift.Text = sfShiftCodeMod & "MC6"
        End If
        If bolMCDashboard7 = True Then
            lblActualQty0.Text = TotalCountMC7
            lblActualQty1.Text = TotalCountMC7
            lblPPT.Text = iPlanProdTimeMC7   '((CInt(stJOCycleTimeMC7) / (CInt(stJOMoldCavP1MC7) + CInt(stJOMoldCavP2MC7))) * CInt(stJOQuantityMC7)) / 60
            lblART.Text = Math.Round((runtimeMC7 / 60), 2) 'minutes
            lblUserName.Text = UNmc7
            lblUserID.Text = UNIdmc7
            lblJobOrderCode.Text = stJOMC7
            lblPartNo1.Text = stJOPartNo1MC7
            lblPartNo2.Text = stJOPartNo2MC7
            lblMoldNo.Text = stJOMoldIDMC7
            lblCavQtyP1.Text = stJOMoldCavP1MC7
            lblCavQtyP2.Text = stJOMoldCavP2MC7
            lblPlannedQTY.Text = stJOQuantityMC7
            lblCycleTime.Text = stJOCycleTimeMC7
            lblDateTimeStart.Text = stJOStartTimeMC7
            lblOutputP1.Text = CounterP1MC7
            lblOutputP2.Text = CounterP2MC7
            lblShift.Text = sfShiftCodeMod & "MC7"
        End If
        If bolMCDashboard8 = True Then
            lblActualQty0.Text = TotalCountMC8
            lblActualQty1.Text = TotalCountMC8
            lblPPT.Text = iPlanProdTimeMC8    '((CInt(stJOCycleTimeMC8) / (CInt(stJOMoldCavP1MC8) + CInt(stJOMoldCavP2MC8))) * CInt(stJOQuantityMC8)) / 60
            lblART.Text = Math.Round((runtimeMC8 / 60), 2) 'minutes
            lblUserName.Text = UNmc8
            lblUserID.Text = UNIdmc8
            lblJobOrderCode.Text = stJOMC8
            lblPartNo1.Text = stJOPartNo1MC8
            lblPartNo2.Text = stJOPartNo2MC8
            lblMoldNo.Text = stJOMoldIDMC8
            lblCavQtyP1.Text = stJOMoldCavP1MC8
            lblCavQtyP2.Text = stJOMoldCavP2MC8
            lblPlannedQTY.Text = stJOQuantityMC8
            lblCycleTime.Text = stJOCycleTimeMC8
            lblDateTimeStart.Text = stJOStartTimeMC8
            lblOutputP1.Text = CounterP1MC8
            lblOutputP2.Text = CounterP2MC8
            lblShift.Text = sfShiftCodeMod & "MC8"
        End If
        If bolMCDashboard9 = True Then
            lblActualQty0.Text = TotalCountMC9
            lblActualQty1.Text = TotalCountMC9
            lblPPT.Text = iPlanProdTimeMC9   '((CInt(stJOCycleTimeMC9) / (CInt(stJOMoldCavP1MC9) + CInt(stJOMoldCavP2MC9))) * CInt(stJOQuantityMC9)) / 60
            lblART.Text = Math.Round((runtimeMC9 / 60), 2) 'minutes
            lblUserName.Text = UNmc9
            lblUserID.Text = UNIdmc9
            lblJobOrderCode.Text = stJOMC9
            lblPartNo1.Text = stJOPartNo1MC9
            lblPartNo2.Text = stJOPartNo2MC9
            lblMoldNo.Text = stJOMoldIDMC9
            lblCavQtyP1.Text = stJOMoldCavP1MC9
            lblCavQtyP2.Text = stJOMoldCavP2MC9
            lblPlannedQTY.Text = stJOQuantityMC9
            lblCycleTime.Text = stJOCycleTimeMC9
            lblDateTimeStart.Text = stJOStartTimeMC9
            lblOutputP1.Text = CounterP1MC9
            lblOutputP2.Text = CounterP2MC9
            lblShift.Text = sfShiftCodeMod & "MC9"
        End If
        If bolMCDashboard10 = True Then
            lblActualQty0.Text = TotalCountMC10
            lblActualQty1.Text = TotalCountMC10
            lblPPT.Text = iPlanProdTimeMC10    '((CInt(stJOCycleTimeMC10) / (CInt(stJOMoldCavP1MC10) + CInt(stJOMoldCavP2MC10))) * CInt(stJOQuantityMC10)) / 60
            lblART.Text = Math.Round((runtimeMC10 / 60), 2) 'minutes
            lblUserName.Text = UNmc10
            lblUserID.Text = UNIdmc10
            lblJobOrderCode.Text = stJOMC10
            lblPartNo1.Text = stJOPartNo1MC10
            lblPartNo2.Text = stJOPartNo2MC10
            lblMoldNo.Text = stJOMoldIDMC10
            lblCavQtyP1.Text = stJOMoldCavP1MC10
            lblCavQtyP2.Text = stJOMoldCavP2MC10
            lblPlannedQTY.Text = stJOQuantityMC10
            lblCycleTime.Text = stJOCycleTimeMC10
            lblDateTimeStart.Text = stJOStartTimeMC10
            lblOutputP1.Text = CounterP1MC10
            lblOutputP2.Text = CounterP2MC10
            lblShift.Text = sfShiftCodeMod & "MC10"
        End If
        If bolMCDashboard11 = True Then
            lblActualQty0.Text = TotalCountMC11
            lblActualQty1.Text = TotalCountMC11
            lblPPT.Text = iPlanProdTimeMC11   '((CInt(stJOCycleTimeMC11) / (CInt(stJOMoldCavP1MC11) + CInt(stJOMoldCavP2MC11))) * CInt(stJOQuantityMC11)) / 60
            lblART.Text = Math.Round((runtimeMC11 / 60), 2) 'minutes
            lblUserName.Text = UNmc11
            lblUserID.Text = UNIdmc11
            lblJobOrderCode.Text = stJOMC11
            lblPartNo1.Text = stJOPartNo1MC11
            lblPartNo2.Text = stJOPartNo2MC11
            lblMoldNo.Text = stJOMoldIDMC11
            lblCavQtyP1.Text = stJOMoldCavP1MC11
            lblCavQtyP2.Text = stJOMoldCavP2MC11
            lblPlannedQTY.Text = stJOQuantityMC11
            lblCycleTime.Text = stJOCycleTimeMC11
            lblDateTimeStart.Text = stJOStartTimeMC11
            lblOutputP1.Text = CounterP1MC11
            lblOutputP2.Text = CounterP2MC11
            lblShift.Text = sfShiftCodeMod & "MC11"
        End If
        If bolMCDashboard12 = True Then
            lblActualQty0.Text = TotalCountMC12
            lblActualQty1.Text = TotalCountMC12
            lblPPT.Text = iPlanProdTimeMC12     '((CInt(stJOCycleTimeMC12) / (CInt(stJOMoldCavP1MC12) + CInt(stJOMoldCavP2MC12))) * CInt(stJOQuantityMC12)) / 60
            lblART.Text = Math.Round((runtimeMC12 / 60), 2) 'minutes
            lblUserName.Text = UNmc12
            lblUserID.Text = UNIdmc12
            lblJobOrderCode.Text = stJOMC12
            lblPartNo1.Text = stJOPartNo1MC12
            lblPartNo2.Text = stJOPartNo2MC12
            lblMoldNo.Text = stJOMoldIDMC12
            lblCavQtyP1.Text = stJOMoldCavP1MC12
            lblCavQtyP2.Text = stJOMoldCavP2MC12
            lblPlannedQTY.Text = stJOQuantityMC12
            lblCycleTime.Text = stJOCycleTimeMC12
            lblDateTimeStart.Text = stJOStartTimeMC12
            lblOutputP1.Text = CounterP1MC12
            lblOutputP2.Text = CounterP2MC12
            lblShift.Text = sfShiftCodeMod & "MC12"
        End If
        If bolMCDashboard13 = True Then
            lblActualQty0.Text = TotalCountMC13
            lblActualQty1.Text = TotalCountMC13
            lblPPT.Text = iPlanProdTimeMC13    '((CInt(stJOCycleTimeMC13) / (CInt(stJOMoldCavP1MC13) + CInt(stJOMoldCavP2MC13))) * CInt(stJOQuantityMC13)) / 60
            lblART.Text = Math.Round((runtimeMC13 / 60), 2) 'minutes
            lblUserName.Text = UNmc13
            lblUserID.Text = UNIdmc13
            lblJobOrderCode.Text = stJOMC13
            lblPartNo1.Text = stJOPartNo1MC13
            lblPartNo2.Text = stJOPartNo2MC13
            lblMoldNo.Text = stJOMoldIDMC13
            lblCavQtyP1.Text = stJOMoldCavP1MC13
            lblCavQtyP2.Text = stJOMoldCavP2MC13
            lblPlannedQTY.Text = stJOQuantityMC13
            lblCycleTime.Text = stJOCycleTimeMC13
            lblDateTimeStart.Text = stJOStartTimeMC13
            lblOutputP1.Text = CounterP1MC13
            lblOutputP2.Text = CounterP2MC13
            lblShift.Text = sfShiftCodeMod & "MC13"
        End If
        If bolMCDashboard14 = True Then
            lblActualQty0.Text = TotalCountMC14
            lblActualQty1.Text = TotalCountMC14
            lblPPT.Text = iPlanProdTimeMC14 '((CInt(stJOCycleTimeMC14) / (CInt(stJOMoldCavP1MC14) + CInt(stJOMoldCavP2MC14))) * CInt(stJOQuantityMC14)) / 60
            lblART.Text = Math.Round((runtimeMC14 / 60), 2) 'minutes
            lblUserName.Text = UNmc14
            lblUserID.Text = UNIdmc14
            lblJobOrderCode.Text = stJOMC14
            lblPartNo1.Text = stJOPartNo1MC14
            lblPartNo2.Text = stJOPartNo2MC14
            lblMoldNo.Text = stJOMoldIDMC14
            lblCavQtyP1.Text = stJOMoldCavP1MC14
            lblCavQtyP2.Text = stJOMoldCavP2MC14
            lblPlannedQTY.Text = stJOQuantityMC14
            lblCycleTime.Text = stJOCycleTimeMC14
            lblDateTimeStart.Text = stJOStartTimeMC14
            lblOutputP1.Text = CounterP1MC14
            lblOutputP2.Text = CounterP2MC14
            lblShift.Text = sfShiftCodeMod & "MC14"
        End If
        If bolMCDashboard15 = True Then
            lblActualQty0.Text = TotalCountMC15
            lblActualQty1.Text = TotalCountMC15
            lblPPT.Text = iPlanProdTimeMC15    '((CInt(stJOCycleTimeMC1) / (CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60
            lblART.Text = Math.Round((runtimeMC15 / 60), 2) 'minutes
            lblUserName.Text = UNmc15
            lblUserID.Text = UNIdmc15
            lblJobOrderCode.Text = stJOMC15
            lblPartNo1.Text = stJOPartNo1MC15
            lblPartNo2.Text = stJOPartNo2MC15
            lblMoldNo.Text = stJOMoldIDMC15
            lblCavQtyP1.Text = stJOMoldCavP1MC15
            lblCavQtyP2.Text = stJOMoldCavP2MC15
            lblPlannedQTY.Text = stJOQuantityMC15
            lblCycleTime.Text = stJOCycleTimeMC15
            lblDateTimeStart.Text = stJOStartTimeMC15
            lblOutputP1.Text = CounterP1MC15
            lblOutputP2.Text = CounterP2MC15
            lblShift.Text = sfShiftCodeMod & "MC15"
        End If
        If bolMCDashboard16 = True Then
            lblActualQty0.Text = TotalCountMC16
            lblActualQty1.Text = TotalCountMC16
            lblPPT.Text = iPlanProdTimeMC16    '((CInt(stJOCycleTimeMC1) / (CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60
            lblART.Text = Math.Round((runtimeMC16 / 60), 2) 'minutes
            lblUserName.Text = UNmc16
            lblUserID.Text = UNIdmc16
            lblJobOrderCode.Text = stJOMC16
            lblPartNo1.Text = stJOPartNo1MC16
            lblPartNo2.Text = stJOPartNo2MC16
            lblMoldNo.Text = stJOMoldIDMC16
            lblCavQtyP1.Text = stJOMoldCavP1MC16
            lblCavQtyP2.Text = stJOMoldCavP2MC16
            lblPlannedQTY.Text = stJOQuantityMC16
            lblCycleTime.Text = stJOCycleTimeMC16
            lblDateTimeStart.Text = stJOStartTimeMC16
            lblOutputP1.Text = CounterP1MC16
            lblOutputP2.Text = CounterP2MC16
            lblShift.Text = sfShiftCodeMod & "MC16"
        End If
        If bolMCDashboard17 = True Then
            lblActualQty0.Text = TotalCountMC17
            lblActualQty1.Text = TotalCountMC17
            lblPPT.Text = iPlanProdTimeMC17   '((CInt(stJOCycleTimeMC1) / (CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60
            lblART.Text = Math.Round((runtimeMC17 / 60), 2) 'minutes
            lblUserName.Text = UNmc17
            lblUserID.Text = UNIdmc17
            lblJobOrderCode.Text = stJOMC17
            lblPartNo1.Text = stJOPartNo1MC17
            lblPartNo2.Text = stJOPartNo2MC17
            lblMoldNo.Text = stJOMoldIDMC17
            lblCavQtyP1.Text = stJOMoldCavP1MC17
            lblCavQtyP2.Text = stJOMoldCavP2MC17
            lblPlannedQTY.Text = stJOQuantityMC17
            lblCycleTime.Text = stJOCycleTimeMC17
            lblDateTimeStart.Text = stJOStartTimeMC17
            lblOutputP1.Text = CounterP1MC17
            lblOutputP2.Text = CounterP2MC17
            lblShift.Text = sfShiftCodeMod & "MC17"
        End If
        If bolMCDashboard18 = True Then
            lblActualQty0.Text = TotalCountMC18
            lblActualQty1.Text = TotalCountMC18
            lblPPT.Text = iPlanProdTimeMC18   '((CInt(stJOCycleTimeMC1) / (CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60
            lblART.Text = Math.Round((runtimeMC18 / 60), 2) 'minutes
            lblUserName.Text = UNmc18
            lblUserID.Text = UNIdmc18
            lblJobOrderCode.Text = stJOMC18
            lblPartNo1.Text = stJOPartNo1MC18
            lblPartNo2.Text = stJOPartNo2MC18
            lblMoldNo.Text = stJOMoldIDMC18
            lblCavQtyP1.Text = stJOMoldCavP1MC18
            lblCavQtyP2.Text = stJOMoldCavP2MC18
            lblPlannedQTY.Text = stJOQuantityMC18
            lblCycleTime.Text = stJOCycleTimeMC18
            lblDateTimeStart.Text = stJOStartTimeMC18
            lblOutputP1.Text = CounterP1MC18
            lblOutputP2.Text = CounterP2MC18
            lblShift.Text = sfShiftCodeMod & "MC18"
        End If
        If bolMCDashboard19 = True Then
            lblActualQty0.Text = TotalCountMC19
            lblActualQty1.Text = TotalCountMC19
            lblPPT.Text = iPlanProdTimeMC19    '((CInt(stJOCycleTimeMC1) / (CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60
            lblART.Text = Math.Round((runtimeMC19 / 60), 2) 'minutes
            lblUserName.Text = UNmc19
            lblUserID.Text = UNIdmc19
            lblJobOrderCode.Text = stJOMC19
            lblPartNo1.Text = stJOPartNo1MC19
            lblPartNo2.Text = stJOPartNo2MC19
            lblMoldNo.Text = stJOMoldIDMC19
            lblCavQtyP1.Text = stJOMoldCavP1MC19
            lblCavQtyP2.Text = stJOMoldCavP2MC19
            lblPlannedQTY.Text = stJOQuantityMC19
            lblCycleTime.Text = stJOCycleTimeMC19
            lblDateTimeStart.Text = stJOStartTimeMC19
            lblOutputP1.Text = CounterP1MC19
            lblOutputP2.Text = CounterP2MC19
            lblShift.Text = sfShiftCodeMod & "MC19"
        End If
    End Sub


    Private Sub RealtimeUpdate_Tick(sender As Object, e As EventArgs) Handles RealtimeUpdate.Tick
        'mcDTlistBox()
        MachineDetails()
        MachineStatusImage()
        QAInfoDetailsDisplay()
        RTCheckQAStoppage()
    End Sub

    '// 
    Public Sub DropdownShiftCodeDistinctValue()
        'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim sqlSelect As String = "SELECT DISTINCT [Shift_CodeFK] FROM [Maintenance].[Downtime] "
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Dim adapter As New SqlDataAdapter(sqlSelect, con)
        Dim ds As New DataSet()
        con.Open()
        adapter.Fill(ds)
        cboShiftCode.DataSource = ds.Tables(0)
        cboShiftCode.DisplayMember = "Shift_CodeFK"
        con.Close()
        cboShiftCode.Text = ""
    End Sub

    Public Sub UpdateDowntimetoDataGridVidw()
        Me.DowntimeTableAdapter.ShowNewDowntime(Me.SPSDataSet1.Downtime, modSetVal_DTNewStoppage)
        cboShiftCode.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateDowntimetoDataGridVidw()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Me.DowntimeTableAdapter.SearchShiftCode(Me.SPSDataSet1.Downtime, cboShiftCode.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Me.DowntimeTableAdapter.Fill(Me.SPSDataSet1.Downtime)
        cboShiftCode.Text = ""
    End Sub

    Private Sub lblQualityBtn_Click(sender As Object, e As EventArgs) Handles lblQualityBtn.Click
        modQualityBtn_AtMCDash_isTrue = True
        frmJOUserVerification.Show()
    End Sub

    '//
    Public Sub QAInfoDetailsDisplay()
        If bolMCDashboard1 = True Then
            If modQAStopMC1_isTrue = True Then
                lblQAInfoDetails.Visible = True
                lblQAInfoDetails.Text = "NEW QA STOPPAGE WAS CREATED. MACHINE WILL STOP AFTER 1CYCLE..."
            Else
                lblQAInfoDetails.Visible = False
                lblQAInfoDetails.Text = ""
            End If

        ElseIf bolMCDashboard2 = True Then
            If modQAStopMC2_isTrue = True Then
                lblQAInfoDetails.Visible = True
                lblQAInfoDetails.Text = "NEW QA STOPPAGE WAS CREATED. MACHINE WILL STOP AFTER 1CYCLE..."
            Else
                lblQAInfoDetails.Visible = False
                lblQAInfoDetails.Text = ""
            End If
        End If
    End Sub
    '//

    '// CHECKING QA STOPPAGE 
    Public Sub RTCheckQAStoppage()
        'MC1
        Dim qsMC1 As New clsCheckExistingDowntime
        qsMC1.checkDT_stMCId = "MC1"
        qsMC1.checkDT_stNewStoppage = "MC1NewStoppage"
        qsMC1.checkExistingDT()
        If qsMC1.checkDT_Result = "Quality" Then
            modQA_DTStat_MC1 = True
        End If
        If RxPLCM0 = True Then
            modQA_DTStat_MC1 = False
        End If

        'MC2
        Dim qsMC2 As New clsCheckExistingDowntime
        qsMC2.checkDT_stMCId = "MC2"
        qsMC2.checkDT_stNewStoppage = "NewMC2Stoppage"
        qsMC2.checkExistingDT()
        If qsMC2.checkDT_Result = "Quality" Then
            modQA_DTStat_MC2 = True
        End If
        If RxPLCM1 = True Then
            modQA_DTStat_MC2 = False
        End If
    End Sub
End Class