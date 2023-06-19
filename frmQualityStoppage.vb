Imports System.ComponentModel

Public Class frmQualityStoppage
    Private Sub frmQualityStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.CenterToScreen()
    End Sub
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        lblFailFreq.Text = QAFailCounter
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
        If cboQAStoppage.Text = "" Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If RxPLCM0 = True Then
            DTStoreValue_ForInsert()
            modQualityMCStopFlag_isTrue = True
        Else
            UpdatingDTStoppage()
        End If

    End Sub
    '//

    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click
        QAFailCounter += 1
        UpdateDT_At_AQFail()
        grpQAVerification.Enabled = False
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click

    End Sub

    '// LOADS THE QA STOPPAGE DETAILS
    Private Sub cboQAStoppage_Click(sender As Object, e As EventArgs) Handles cboQAStoppage.Click
        Me.MListQualityStoppageTableAdapter.Fill(Me.SPSDataSet3.MListQualityStoppage)
        cboQAStoppage.Text = ""

    End Sub
    '//

    '// LOADS THE COUNTERMEASURE BASED ON THE GIVEN QA STOPPAGE
    Private Sub cboQAStoppage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQAStoppage.SelectedIndexChanged
        Me.MListQualityCountermeasureTableAdapter.FillByQAStoppage(Me.SPSDataSet4.MListQualityCountermeasure, cboQAStoppage.Text, "MC1")
        cboCountermeasure.Text = ""
        SaveBtnEnableDisable()
    End Sub
    '//

    '// STORING INFO FOR INSERTING DOWNTIME RECORDS
    Public Sub DTStoreValue_ForInsert()
        DTstoValue_ShiftCode = sfShiftCodeMod + "MC1"
        DTstoValue_UserName = lblUserLog.Text
        DTstoValue_UserID = lblUserID.Text
        DTstoValue_DTType = "Quality"
        DTstoValue_StartTime = Now()
        DTstoValue_DTReason = cboQAStoppage.Text
        DTstoValue_CMeasure = "TBA"
        DTstoValue_AckDate = "Not Yet Ack"
        DTstoValue_EndTime = "TBA"
        DTstoValue_RunTime = "TBA"
        DTstoValue_TtlDTmins = 0
        DTstoValue_TtlRrpTmins = 0
        DTstoValue_ForQAVeri = "n/a"
        DTstoValue_TtlVeriMins = 0
        DTstoValue_TtlFailFreq = 0
        DTstoValue_DTStatus = "MC1NewStoppage"
        DTstoValue_JOCode = lblJOCode.Text
        DTstoValue_MachineID = modMachineIDMC1


        cboQAStoppage.SelectedItem = ""
        cboQAStoppage.Text = ""
        modQualityUserLogin = Nothing
        modQualityUIDLogin = Nothing
        Me.Close()
    End Sub
    '//

    '// INSERTING DOWNTIME STOPPAGE 
    Public Sub InsertDowntimeRecord()
        Dim insertDT As New cls001_InsertDowntime_QAStoppage
        insertDT.cls001_ShiftCode = sfShiftCodeMod + "MC1"
        insertDT.cls001_UserName = lblUserLog.Text
        insertDT.cls001_UserID = lblUserID.Text
        insertDT.cls001_DTType = "Quality"
        insertDT.cls001_StartTime = Now()
        insertDT.cls001_DTReason = cboQAStoppage.Text
        insertDT.cls001_DTCountermeasure = "TBA"
        insertDT.cls001_AckDate = "Not Yet Ack"
        insertDT.cls001_EndTime = "TBA"
        insertDT.cls001_RunTime = "TBA"
        insertDT.cls001_TtlDTmins = 0
        insertDT.cls001_TtlRprtmins = 0
        insertDT.cls001_ForQAVeri = "n/a"
        insertDT.cls001_TtlQAVeriMins = 0
        insertDT.cls001_TtlFailfreg = 0
        insertDT.cls001_DTStatus = "MC1NewStoppage"
        insertDT.cls001_JOCode = lblJOCode.Text
        insertDT.cls001_MachineID = modMachineIDMC1
        insertDT.InsertDowntime()
        cboQAStoppage.SelectedItem = ""
        cboQAStoppage.Text = ""
        modQualityUserLogin = Nothing
        modQualityUIDLogin = Nothing
        Me.Close()
    End Sub

    '// UPDATING DOWNTIME STOPPAGE
    Public Sub UpdatingDTStoppage()
        Dim CM As String
        If cboCountermeasure.Text = "" Then
            CM = "TBA"
        Else
            CM = cboCountermeasure.Text
        End If
        Dim Upd8 As New clsUpdateDTStoppage
        Upd8.cls001_DTStatus = "MC1NewStoppage"
        Upd8.cls001_MachineID = modMachineIDMC1
        Upd8.cls001_UserName = modQualityUserLogin
        Upd8.cls001_UserID = modQualityUIDLogin
        Upd8.cls001_DTType = "Quality"
        Upd8.cls001_DTReason = cboQAStoppage.Text
        Upd8.cls001_DTCountermeasure = CM
        Upd8.UpdateDowntime_At_QAStoppage()
    End Sub
    '//


    '// CHECKING AND LOADING QUALITY STOPPAGE DETAILS
    Public Sub CheckLoggedQualityStoppage()
        Dim result As Integer
        Dim cnt As New clsCountDTType_byDTStatusMCId
        cnt.cls001_DTType = "Quality"
        cnt.cls001_DTStatus = "MC1NewStoppage"
        cnt.cls001_MachineID = modMachineIDMC1
        cnt.CountDTType()
        result = cnt.cntDTtype

        If result >= 1 Then
            Dim sel As New clsSelDTReasonCMeasure
            sel.cls001_DTType = "Quality"
            sel.cls001_MachineID = modMachineIDMC1
            sel.cls001_DTStatus = "MC1NewStoppage"
            sel.SelDTReason_CMeasure()
            cboQAStoppage.Text = sel.cls001_DTReason
            cboCountermeasure.Text = sel.cls001_DTCountermeasure
            QAFailCounter = sel.cls001_TtlFailfreg
            grpQAStoppageDetails.Enabled = False
            grpQAVerification.Enabled = True
        Else
            cboQAStoppage.SelectedIndex = -1
            cboCountermeasure.SelectedIndex = -1
            grpQAStoppageDetails.Enabled = True
            grpQAVerification.Enabled = False
            SaveBtnEnableDisable()
        End If
    End Sub
    '//

    '// UPDATE DOWNTIME AT QA FAIL
    Public Sub UpdateDT_At_AQFail()
        Dim upd8 As New clsUpdateDowntime_QAFail
        upd8.cls001_ForQAVeri = "TBA"
        upd8.cls001_TtlFailfreg = QAFailCounter
        upd8.cls001_DTType = "Quality"
        upd8.cls001_DTStatus = "MC1NewStoppage"
        upd8.cls001_MachineID = modMachineIDMC1
        upd8.UpdateDT_AtQAFail()
    End Sub
    '//


End Class