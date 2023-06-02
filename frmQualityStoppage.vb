Imports System.ComponentModel

Public Class frmQualityStoppage
    Private Sub frmQualityStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SPSDataSet3.MListQualityStoppage' table. You can move, or remove it, as needed.
        Me.MListQualityStoppageTableAdapter.Fill(Me.SPSDataSet3.MListQualityStoppage)
        cboQAStoppage.Text = ""
        grpQAVerification.Enabled = False
        lblUserLog.Text = modQualityUserLogin
        lblUserID.Text = modQualityUIDLogin
        lblJOCode.Text = stJOMC1
        Me.CenterToScreen()
    End Sub

    Private Sub frmQualityStoppage_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub frmQualityStoppage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboQAStoppage.SelectedItem = ""
        cboQAStoppage.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertDowntimeRecord()
    End Sub

    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click

    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click

    End Sub

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
        insertDT.InsertDowntime()
        cboQAStoppage.SelectedItem = ""
        cboQAStoppage.Text = ""
        modQualityUserLogin = Nothing
        modQualityUIDLogin = Nothing
        Me.Close()
    End Sub

End Class