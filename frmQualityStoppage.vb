Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class frmQualityStoppage
    Dim CheckDTResult_MC1 As String
    Dim CheckDTResult_MC2 As String
    Dim CheckDTResult_MC3 As String
    Dim CheckDTResult_MC4 As String
    Dim CheckDTResult_MC5 As String
    Dim CheckDTResult_MC6 As String
    Dim CheckDTResult_MC7 As String
    Dim CheckDTResult_MC8 As String
    Dim CheckDTResult_MC9 As String
    Dim CheckDTResult_MC10 As String
    Dim CheckDTResult_MC11 As String
    Dim CheckDTResult_MC12 As String
    Dim CheckDTResult_MC13 As String
    Dim CheckDTResult_MC14 As String
    Dim CheckDTResult_MC15 As String
    Dim CheckDTResult_MC16 As String
    Dim CheckDTResult_MC17 As String
    Dim CheckDTResult_MC18 As String
    Dim CheckDTResult_MC19 As String

    Private Sub frmQualityStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("QA stoppage")
        ''TODO: This line of code loads data into the 'SPSDataSet4.MListQualityCountermeasure' table. You can move, or remove it, as needed.
        'Me.MListQualityCountermeasureTableAdapter.Fill(Me.SPSDataSet4.MListQualityCountermeasure)
        'TODO: This line of code loads data into the 'SPSDataSet3.MListQualityStoppage' table. You can move, or remove it, as needed.
        'Me.MListQualityStoppageTableAdapter.Fill(Me.SPSDataSet3.MListQualityStoppage)

        cboQAStoppage.SelectedIndex = -1
        cboCountermeasure.SelectedIndex = -1

        grpQAVerification.Enabled = False
        lblUserLog.Text = modQualityUserLogin
        lblUserID.Text = modQualityUIDLogin
        lblJOCode.Text = stJOMC1

        CheckLoggedQualityStoppage()
        CheckForQAVeriVlaue()
        Me.CenterToScreen()
    End Sub
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        lblFailFreq.Text = QAFailCounter
        CheckForQAVeriVlaue()
    End Sub

    Private Sub frmQualityStoppage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        cboQAStoppage.SelectedIndex = -1
        cboCountermeasure.SelectedIndex = -1
    End Sub

    Private Sub frmQualityStoppage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboQAStoppage.SelectedIndex = -1
        cboCountermeasure.SelectedIndex = -1
    End Sub


    '// SAVE BUTTON ENABLE DISABLED
    Public Sub SaveBtnEnableDisable()
        If cboQAStoppage.SelectedIndex = -1 Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'MC1
        If bolMCDashboard1 = True Then
            If modSetVal_MCID = modMC1_stMCId Then
                If RxPLCM0 = True Then
                    DTStoreValue_ForInsert()
                    modQAStopMC1_isTrue = True
                Else
                    UpdatingDTStoppage()
                End If
            End If
            'MC2
        ElseIf bolMCDashboard2 = True Then
            If modSetVal_MCID = modMC2_stMCId Then
                If RxPLCM1 = True Then
                    DTStoreValue_ForInsert()
                    modQAStopMC2_isTrue = True
                Else
                    UpdatingDTStoppage()
                End If
            End If
        End If
    End Sub
    '//

    '//
    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click
        QAFailCounter += 1
        UpdateDT_At_AQFail()
        'grpQAVerification.Enabled = False
        Me.Close()
    End Sub

    '//
    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        UpdateDtQAPass()
    End Sub
    Public Sub UpdateDtQAPass()

        'MC1
        If bolMCDashboard1 = True Then
            Dim UpDt As New clsUpdateDTAtQAPass
            UpDt.DTDetails_sfForQAVeri = Now()
            UpDt.DTDetails_iTtlQAVeri = 1
            UpDt.DTDetails_sfVeriByQA = lblUserLog.Text
            UpDt.DTDetails_sfDTType = "Quality"
            UpDt.DTDetails_sfDTStatus = modMC1_stNewStoppage
            UpDt.DTDetails_sfMCId = modMC1_stMCId
            UpDt.UpdateDTAt_QAPass()

            cboQAStoppage.SelectedIndex = -1
            cboCountermeasure.SelectedIndex = -1
            Me.Close()

            'Mc2
        ElseIf bolMCDashboard2 = True Then
            Dim UpDt As New clsUpdateDTAtQAPass
            UpDt.DTDetails_sfForQAVeri = Now()
            UpDt.DTDetails_iTtlQAVeri = 1
            UpDt.DTDetails_sfVeriByQA = lblUserLog.Text
            UpDt.DTDetails_sfDTType = "Quality"
            UpDt.DTDetails_sfDTStatus = modMC2_stNewStoppage
            UpDt.DTDetails_sfMCId = modMC2_stMCId
            UpDt.UpdateDTAt_QAPass()

            cboQAStoppage.SelectedIndex = -1
            cboCountermeasure.SelectedIndex = -1
            Me.Close()
        End If

    End Sub
    '//

    '// LOADS THE QA STOPPAGE DETAILS
    Private Sub cboQAStoppage_Click(sender As Object, e As EventArgs) Handles cboQAStoppage.Click

        CheckExistingDT()
        'MC1
        If bolMCDashboard1 = True Then
            If CheckDTResult_MC1 <> "TBA" And CheckDTResult_MC1 <> "" Then
                btnSave.Enabled = False
                MessageBox.Show("There is an existing Downtime..." &
                                vbNewLine & "Please verify at " & modMC1_stMCId & " HMI for details...", "Checking Existing Downtime..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Me.MListQualityStoppageTableAdapter.Fill(Me.SPSDataSet3.MListQualityStoppage)
                cboQAStoppage.SelectedIndex = -1
            End If

            'MC2
        ElseIf bolMCDashboard2 = True Then
            If CheckDTResult_MC2 <> "TBA" And CheckDTResult_MC2 <> "" Then
                btnSave.Enabled = False
                MessageBox.Show("There is an existing Downtime..." &
                                vbNewLine & "Please verify at " & modMC2_stMCId & " HMI for details...", "Checking Existing Downtime..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Me.MListQualityStoppageTableAdapter.Fill(Me.SPSDataSet3.MListQualityStoppage)
                cboQAStoppage.SelectedIndex = -1
            End If
        End If

    End Sub
    '//

    '// LOADS THE COUNTERMEASURE BASED ON THE GIVEN QA STOPPAGE
    Private Sub cboQAStoppage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQAStoppage.SelectedIndexChanged

        'MC1
        If bolMCDashboard1 = True Then
            Me.MListQualityCountermeasureTableAdapter.FillByQAStoppage(Me.SPSDataSet4.MListQualityCountermeasure, cboQAStoppage.Text, modMC1_stMCId)
            cboCountermeasure.SelectedIndex = -1
            SaveBtnEnableDisable()

            'MC2
        ElseIf bolMCDashboard2 = True Then
            Me.MListQualityCountermeasureTableAdapter.FillByQAStoppage(Me.SPSDataSet4.MListQualityCountermeasure, cboQAStoppage.Text, modMC2_stMCId)
            cboCountermeasure.SelectedIndex = -1
            SaveBtnEnableDisable()
        End If

    End Sub
    '//

    '// STORING INFO FOR INSERTING DOWNTIME RECORDS
    Public Sub DTStoreValue_ForInsert()
        'MC1
        If bolMCDashboard1 = True Then
            modMC1SVQAStop_stShiftCode = sfShiftCodeMod + modSetVal_MCID
            modMC1SVQAStop_stUserName = lblUserLog.Text
            modMC1SVQAStop_stUserID = lblUserID.Text
            modMC1SVQAStop_stDTType = "Quality"
            modMC1SVQAStop_stStartTime = Now()
            modMC1SVQAStop_stDTReason = cboQAStoppage.Text
            modMC1SVQAStop_stDTCMeasure = "TBA"
            modMC1SVQAStop_stACKDate = "Not Yet Ack"
            modMC1SVQAStop_stEndTime = "TBA"
            modMC1SVQAStop_stRunTime = "TBA"
            modMC1SVQAStop_iTtlDTMins = 0
            modMC1SVQAStop_iTtlRepTimeMins = 0
            modMC1SVQAStop_stForQAVeri = "TBA"
            modMC1SVQAStop_iTtlQAVerMins = 0
            modMC1SVQAStop_iTtlFailFeq = 0
            modMC1SVQAStop_stDTStatus = modMC1_stNewStoppage
            modMC1SVQAStop_stJOCode = stJOMC1
            modMC1SVQAStop_stMCId = modMC1_stMCId
            modMC1SVQAStop_stVeriByQA = "TBA"
            modMC1SVQAStop_stCreatedBy = lblUserLog.Text
        End If

        'MC2
        If bolMCDashboard2 = True Then
            modMC2SVQAStop_stShiftCode = sfShiftCodeMod + modMC2_stMCId
            modMC2SVQAStop_stUserName = lblUserLog.Text
            modMC2SVQAStop_stUserID = lblUserID.Text
            modMC2SVQAStop_stDTType = "Quality"
            modMC2SVQAStop_stStartTime = Now()
            modMC2SVQAStop_stDTReason = cboQAStoppage.Text
            modMC2SVQAStop_stDTCMeasure = "TBA"
            modMC2SVQAStop_stACKDate = "Not Yet Ack"
            modMC2SVQAStop_stEndTime = "TBA"
            modMC2SVQAStop_stRunTime = "TBA"
            modMC2SVQAStop_iTtlDTMins = 0
            modMC2SVQAStop_iTtlRepTimeMins = 0
            modMC2SVQAStop_stForQAVeri = "TBA"
            modMC2SVQAStop_iTtlQAVerMins = 0
            modMC2SVQAStop_iTtlFailFeq = 0
            modMC2SVQAStop_stDTStatus = modMC2_stNewStoppage
            modMC2SVQAStop_stJOCode = stJOMC2
            modMC2SVQAStop_stMCId = modMC2_stMCId
            modMC2SVQAStop_stVeriByQA = "TBA"
            modMC2SVQAStop_stCreatedBy = lblUserLog.Text
        End If

        cboQAStoppage.SelectedIndex = -1
        cboCountermeasure.SelectedIndex = -1
        modQualityUserLogin = Nothing
        modQualityUIDLogin = Nothing
        Me.Close()
    End Sub
    '//

    '// UPDATING DOWNTIME STOPPAGE
    Public Sub UpdatingDTStoppage()

        'MC1
        If bolMCDashboard1 = True Then
            Dim CM As String
            If cboCountermeasure.SelectedIndex = -1 Then
                CM = "TBA"
            Else
                CM = cboCountermeasure.Text
            End If
            Dim Upd8 As New clsUpdateDTStoppage
            Upd8.cls001_DTStatus = modMC1_stNewStoppage
            Upd8.cls001_MachineID = modMC1_stMCId
            Upd8.cls001_UserName = modQualityUserLogin
            Upd8.cls001_UserID = modQualityUIDLogin
            Upd8.cls001_DTType = "Quality"
            Upd8.cls001_DTReason = cboQAStoppage.Text
            Upd8.cls001_DTCountermeasure = CM
            Upd8.cls001_VeriByQA = "TBA"
            Upd8.cls001_CreatedBy = lblUserLog.Text
            Upd8.UpdateDowntime_At_QAStoppage()
            Me.Close()

            'MC2
        ElseIf bolMCDashboard2 = True Then
            Dim CM As String
            If cboCountermeasure.SelectedIndex = -1 Then
                CM = "TBA"
            Else
                CM = cboCountermeasure.Text
            End If
            Dim Upd8 As New clsUpdateDTStoppage
            Upd8.cls001_DTStatus = modMC2_stNewStoppage
            Upd8.cls001_MachineID = modMC2_stMCId
            Upd8.cls001_UserName = modQualityUserLogin
            Upd8.cls001_UserID = modQualityUIDLogin
            Upd8.cls001_DTType = "Quality"
            Upd8.cls001_DTReason = cboQAStoppage.Text
            Upd8.cls001_DTCountermeasure = CM
            Upd8.cls001_VeriByQA = "TBA"
            Upd8.cls001_CreatedBy = lblUserLog.Text
            Upd8.UpdateDowntime_At_QAStoppage()
            Me.Close()
        End If


    End Sub
    '//


    '// CHECKING AND LOADING QUALITY STOPPAGE DETAILS
    Public Sub CheckLoggedQualityStoppage()
        'MC1
        If bolMCDashboard1 = True Then
            Dim result As String
            Dim dttype As String
            Dim dtstat As String
            Dim checkDT As New clsCheckExistingDowntime
            checkDT.checkDT_stMCId = modMC1_stMCId
            checkDT.checkDT_stNewStoppage = modMC1_stNewStoppage
            checkDT.checkExistingDT()
            result = checkDT.checkDT_Result

            If result = "Quality" Then
                Dim chckDT As New clsCheckDTby_Quality_N_NewStoppage
                chckDT.checkDT_stMCId = modMC1_stMCId
                chckDT.checkDT_stNewStoppage = modMC1_stNewStoppage
                chckDT.CheckDTby_QualityN_NewStoppage()
                dttype = chckDT.checkDT_stDTTypeResult
                dtstat = chckDT.checkDT_stDTStatResult

                If dttype = "Quality" And dtstat = modMC1_stNewStoppage Then
                    Dim sel As New clsSelDTReasonCMeasure
                    sel.cls001_DTType = "Quality"
                    sel.cls001_MachineID = modMC1_stMCId
                    sel.cls001_DTStatus = modMC1_stNewStoppage
                    sel.SelDTReason_CMeasure()
                    cboQAStoppage.Text = sel.cls001_DTReason
                    cboCountermeasure.Text = sel.cls001_DTCountermeasure
                    QAFailCounter = sel.cls001_TtlFailfreg
                    grpQAStoppageDetails.Enabled = False
                    'grpQAVerification.Enabled = True
                Else
                    cboQAStoppage.SelectedIndex = -1
                    cboCountermeasure.SelectedIndex = -1
                    grpQAStoppageDetails.Enabled = True
                    'grpQAVerification.Enabled = False
                    SaveBtnEnableDisable()
                End If

            Else
                cboQAStoppage.SelectedIndex = -1
                cboCountermeasure.SelectedIndex = -1
                grpQAStoppageDetails.Enabled = True
                'grpQAVerification.Enabled = False
                SaveBtnEnableDisable()
            End If

            'MC2
        ElseIf bolMCDashboard2 = True Then
            Dim result As String
            Dim dttype As String
            Dim dtstat As String
            Dim checkDT As New clsCheckExistingDowntime
            checkDT.checkDT_stMCId = modMC2_stMCId
            checkDT.checkDT_stNewStoppage = modMC2_stNewStoppage
            checkDT.checkExistingDT()
            result = checkDT.checkDT_Result

            If result = "Quality" Then
                Dim chckDT As New clsCheckDTby_Quality_N_NewStoppage
                chckDT.checkDT_stMCId = modMC2_stMCId
                chckDT.checkDT_stNewStoppage = modMC2_stNewStoppage
                chckDT.CheckDTby_QualityN_NewStoppage()
                dttype = chckDT.checkDT_stDTTypeResult
                dtstat = chckDT.checkDT_stDTStatResult

                If dttype = "Quality" And dtstat = modMC2_stNewStoppage Then
                    Dim sel As New clsSelDTReasonCMeasure
                    sel.cls001_DTType = "Quality"
                    sel.cls001_MachineID = modMC2_stMCId
                    sel.cls001_DTStatus = modMC2_stNewStoppage
                    sel.SelDTReason_CMeasure()
                    cboQAStoppage.Text = sel.cls001_DTReason
                    cboCountermeasure.Text = sel.cls001_DTCountermeasure
                    QAFailCounter = sel.cls001_TtlFailfreg
                    grpQAStoppageDetails.Enabled = False
                    'grpQAVerification.Enabled = True
                Else
                    cboQAStoppage.SelectedIndex = -1
                    cboCountermeasure.SelectedIndex = -1
                    grpQAStoppageDetails.Enabled = True
                    'grpQAVerification.Enabled = False
                    SaveBtnEnableDisable()
                End If

            Else
                cboQAStoppage.SelectedIndex = -1
                cboCountermeasure.SelectedIndex = -1
                grpQAStoppageDetails.Enabled = True
                'grpQAVerification.Enabled = False
                SaveBtnEnableDisable()
            End If
        End If

    End Sub
    '//

    '// UPDATE DOWNTIME AT QA FAIL
    Public Sub UpdateDT_At_AQFail()

        'MC1
        If bolMCDashboard1 = True Then
            Dim upd8 As New clsUpdateDowntime_QAFail
            upd8.cls001_ForQAVeri = "TBA"
            upd8.cls001_TtlFailfreg = QAFailCounter
            upd8.cls001_DTType = "Quality"
            upd8.cls001_DTStatus = modMC1_stNewStoppage
            upd8.cls001_MachineID = modMC1_stMCId
            upd8.UpdateDT_AtQAFail()

            'MC2
        ElseIf bolMCDashboard2 = True Then
            Dim upd8 As New clsUpdateDowntime_QAFail
            upd8.cls001_ForQAVeri = "TBA"
            upd8.cls001_TtlFailfreg = QAFailCounter
            upd8.cls001_DTType = "Quality"
            upd8.cls001_DTStatus = modMC2_stNewStoppage
            upd8.cls001_MachineID = modMC2_stMCId
            upd8.UpdateDT_AtQAFail()
        End If

    End Sub
    '//

    '//
    Public Sub CheckExistingDT()

        'MC1
        If bolMCDashboard1 = True Then
            Dim checkDT As New clsCheckExistingDowntime
            checkDT.checkDT_stMCId = modMC1_stMCId
            checkDT.checkDT_stNewStoppage = modMC1_stNewStoppage
            checkDT.checkExistingDT()
            CheckDTResult_MC1 = checkDT.checkDT_Result

            'MC2
        ElseIf bolMCDashboard2 = True Then
            Dim checkDT As New clsCheckExistingDowntime
            checkDT.checkDT_stMCId = modMC2_stMCId
            checkDT.checkDT_stNewStoppage = modMC2_stNewStoppage
            checkDT.checkExistingDT()
            CheckDTResult_MC2 = checkDT.checkDT_Result
        End If

    End Sub
    '//

    '// CHECKING IF DOWNTIME HAS FOR QA VERIFICATION VALUE
    Public Sub CheckForQAVeriVlaue()

        'MC1
        If bolMCDashboard1 = True Then
            Dim result As String
            Dim QAVeri As New clsCheckQAVerification
            QAVeri.DTDetails_sfDTType = "Quality"
            QAVeri.DTDetails_sfDTStatus = modMC1_stNewStoppage
            QAVeri.DTDetails_sfMCId = modMC1_stMCId
            QAVeri.CheckQAVerificaition()
            result = QAVeri.DTDetails_sfForQAVeri

            If result <> "" And result <> "TBA" And cboCountermeasure.Text <> "TBA" And RxPLCM6 = False Then
                grpQAVerification.Enabled = True
            Else
                grpQAVerification.Enabled = False
            End If

            'MC2
        ElseIf bolMCDashboard2 = True Then
            Dim result As String
            Dim QAVeri As New clsCheckQAVerification
            QAVeri.DTDetails_sfDTType = "Quality"
            QAVeri.DTDetails_sfDTStatus = modMC2_stNewStoppage
            QAVeri.DTDetails_sfMCId = modMC2_stMCId
            QAVeri.CheckQAVerificaition()
            result = QAVeri.DTDetails_sfForQAVeri

            If result <> "" And result <> "TBA" And cboCountermeasure.Text <> "TBA" And RxPLCM7 = False Then
                grpQAVerification.Enabled = True
            Else
                grpQAVerification.Enabled = False
            End If
        End If

    End Sub
    '//

End Class