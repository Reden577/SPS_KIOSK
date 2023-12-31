﻿Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmJOUnload
    Dim Reject1 As Integer
    Dim Reject2 As Integer
    Dim JOCodeCheck As String
    Dim EndTimeCheck As String


    Private Sub frmJOUnload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadingDataToUNLOAD()
        If bolUpdateAndUnload = False Then
            Reject1 = 0
            Reject2 = 0
            txtRejectP1.Text = "0"
            TxtRejectP2.Text = "0"
            lblP1Reject.Text = "0"
            lblP2Reject.Text = "0"
            stJORejectQTyP1MC1 = 0
            stJORejectQTyP2MC1 = 0
        End If
    End Sub
    Private Sub frmJOUnload_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ClearingLoadingPreUnloadDetails()
    End Sub
    Private Sub frmJOUnload_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearingLoadingPreUnloadDetails()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnUpdateUnload.Click
        If (lblEndTime.Text <> "none" And lblEndTime.Text <> "") Then
            If lblP1Reject.Text <> "0" And lblP2Reject.Text <> "0" Then
                'Update database
                bolUpdateAndUnload = True
                frmJOUserVerification.ShowDialog()
            Else
                Dim result As Integer
                result = (MessageBox.Show("Reject Quantity is Zero!" _
                                 & vbNewLine & "Do you want to proceed unloading the Job Order?" _
                                 , "Reject Quantity Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                If result = 6 Then
                    'Update database
                    bolUpdateAndUnload = True
                    frmJOUserVerification.ShowDialog()
                Else
                    Exit Sub
                End If
            End If
        Else
            Dim result As Integer
            result = (MessageBox.Show("Incomplete Process!" _
                             & vbNewLine & "Plan did not meet its Tartget!" _
                             & vbNewLine & "Do you want to proceed unloading the Job Order?" _
                             , "Unloading Job Order Verification...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            If result = 6 Then
                If lblP1Reject.Text <> "0" And lblP2Reject.Text <> "0" Then
                    'Update database
                    bolUpdateAndUnload = True
                    frmJOUserVerification.ShowDialog()
                Else
                    Dim result1 As Integer
                    result1 = (MessageBox.Show("Reject Quantity is Zero!" _
                                     & vbNewLine & "Do you want to proceed unloading the Job Order?" _
                                     , "Reject Quantity Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    If result1 = 6 Then
                        'Update database
                        bolUpdateAndUnload = True
                        frmJOUserVerification.ShowDialog()
                    Else
                        Exit Sub
                    End If
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        If bolJOUnloadConfirm = True Then
            UpdateJO_At_Unloading()
            preUnloadDetails_Confirmed = True
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnSaveReject.Click
        If IsNumeric(txtRejectP1.Text) And IsNumeric(TxtRejectP2.Text) Then
            Reject1 = txtRejectP1.Text
            Reject2 = TxtRejectP2.Text
            MessageBox.Show("Please double check input reject quantity!" _
                             & vbNewLine & "Press OK to Confirm or Cancel to edit...", "Input Reject Quantity!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If DialogResult.OK Then
                RejectLoadedConfirm()
                LoadingDataToUNLOAD()
            End If
        Else
            MessageBox.Show("Invalid Value/s!" _
                      & vbNewLine & "Please Input a Number...", "Reject Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRejectP1.Text = ""
            TxtRejectP2.Text = ""
            Reject1 = Nothing
            Reject2 = Nothing
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRejectP1.Text = ""
        TxtRejectP2.Text = ""
        Reject1 = Nothing
        Reject2 = Nothing
    End Sub

    Public Sub RejectLoadedConfirm()
        'If preUnloadDetails_MCId = "Machine 1" Then
        stJORejectQTyP1MC1 = Reject1
            stJORejectQTyP2MC1 = Reject2
        'End If
        'If preUnloadDetails_MCId = "Machine 2" Then
        '    stJORejectQTyP1MC2 = Reject1
        '    stJORejectQTyP2MC2 = Reject2
        'End If
    End Sub

    '// UNLOADING CONDITION RETURN RESULTS IF PLAN DID NOT MEET THE TARGET
    Public Sub UnloadingConditions()
        If lblEndTime.Text <> "none" And lblEndTime.Text <> "" Then
            'preUnloadDetails_EndTime = preUnloadDetails_EndTime
            preUnloadDetails_ProdnStat = mod_stProdStat_PlanComplete
            preUnloadDetails_LoadStat = mod_stLoadStat_Unloaded
        Else
            preUnloadDetails_EndTime = "none"
            preUnloadDetails_ProdnStat = mod_stProdStat_INC
            preUnloadDetails_LoadStat = mod_stLoadStat_Unloaded
        End If
    End Sub
    '//

    '// LOADING THE INFORMATION TO BE UNLOADED 
    Public Sub LoadingDataToUNLOAD()
        lblShiftCode.Text = preUnloadDetails_SftCode
        lblJOCode.Text = preUnloadDetails_JOCode
        lblMoldNo.Text = preUnloadDetails_MoldId
        lblCycleTime.Text = preUnloadDetails_CycleTime
        lblStartTime.Text = preUnloadDetails_StartTime
        lblEndTime.Text = preUnloadDetails_EndTime
        lblActualRuntime.Text = Math.Round((runtimeMC1 / 60), 2) 'minutes
        lblPlanOutput.Text = preUnloadDetails_JoQty
        lblActualOutput.Text = D2002
        lblP1Output.Text = D2002 * CInt(preUnloadDetails_CavP1)
        lblP2Output.Text = D2002 * CInt(preUnloadDetails_CavP2)
        lblP1Reject.Text = stJORejectQTyP1MC1
        lblP2Reject.Text = stJORejectQTyP2MC1
    End Sub
    '//
    Public Sub ClearingLoadingPreUnloadDetails()
        preUnloadDetails_MCId = Nothing
        preUnloadDetails_SftCode = Nothing
        preUnloadDetails_JOCode = Nothing
        preUnloadDetails_MoldId = Nothing
        preUnloadDetails_PN1 = Nothing
        preUnloadDetails_PN2 = Nothing
        preUnloadDetails_CavP1 = 0
        preUnloadDetails_CavP2 = 0
        preUnloadDetails_JoQty = 0
        preUnloadDetails_CycleTime = 0
        preUnloadDetails_StartTime = Nothing
        preUnloadDetails_EndTime = Nothing
        preUnloadDetails_LoadStat = Nothing
        preUnloadDetails_ProdnStat = Nothing
        preUnloadDetails_LoadedBy = Nothing
        preUnloadDetails_UnloadedBy = Nothing
        stJORejectQTyP1MC1 = 0
        stJORejectQTyP2MC1 = 0
        Reject1 = 0
        Reject2 = 0

    End Sub
    '//

    '// UPDATING JOB OREDER DETAILS AT UNLOADING
    Public Sub UpdateJO_At_Unloading()
        Dim upd8JOUnLD As New clsUpdateJODetailsAtUnloading
        UnloadingConditions()
        upd8JOUnLD.JOCode = lblJOCode.Text
        upd8JOUnLD.EndTime = lblEndTime.Text
        upd8JOUnLD.LoadStat = preUnloadDetails_LoadStat
        upd8JOUnLD.ProdnStat = preUnloadDetails_ProdnStat
        upd8JOUnLD.UnloadedBy = stJOUnloadedBy
        upd8JOUnLD.UnloadTime = Now()
        upd8JOUnLD.TotalShots = D2002
        upd8JOUnLD.PN1OUtput = lblP1Output.Text
        upd8JOUnLD.PN2Output = lblP2Output.Text
        upd8JOUnLD.PN1Reject = lblP1Reject.Text
        upd8JOUnLD.Pn2Reject = lblP2Reject.Text
        upd8JOUnLD.ActualPN1Output = upd8JOUnLD.PN1OUtput - upd8JOUnLD.PN1Reject
        upd8JOUnLD.ActualPN2Output = upd8JOUnLD.PN2Output - upd8JOUnLD.Pn2Reject
        upd8JOUnLD.TotalRunTime = lblActualRuntime.Text
        upd8JOUnLD.UpdateJOLoadedDetailsAtUnloading()
    End Sub

End Class