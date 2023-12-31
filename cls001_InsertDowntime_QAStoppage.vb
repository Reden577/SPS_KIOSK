﻿Imports System.Data.SqlClient

Public Class cls001_InsertDowntime_QAStoppage
    Public cls001_ShiftCode As String
    Public cls001_UserName As String
    Public cls001_UserID As String
    Public cls001_DTType As String
    Public cls001_StartTime As String
    Public cls001_DTReason As String
    Public cls001_DTCountermeasure As String
    Public cls001_AckDate As String
    Public cls001_EndTime As String
    Public cls001_RunTime As String
    Public cls001_TtlDTmins As Integer
    Public cls001_TtlRprtmins As Integer
    Public cls001_ForQAVeri As String
    Public cls001_TtlQAVeriMins As Integer
    Public cls001_TtlFailfreg As Integer
    Public cls001_DTStatus As String
    Public cls001_JOCode As String
    Public cls001_MachineID As String
    Public cls001_VeriByQA As String
    Public cls001_CreatedBy As String

    Public Sub InsertDowntime()
        If modErrFlag_InsertDTQAStop = False Then
            Try
                Dim con As New SqlConnection(modSetVal_SqlPath)
                Dim proc As String = "INSERT INTO [Maintenance].[Downtime]
           ([Shift_CodeFK] ,[User_Name] ,[User_ID] ,[DT_Type] ,[Start_Time]
           ,[DT_Reason] ,[DT_Countermeasure] ,[Ack_Date] ,[End_Time] ,[Run_Time]
           ,[ttl_DT_mins] ,[ttl_RprT_mins] ,[ForQAVerification] ,[ttl_QAVeri_mins] ,[ttl_FailFreq]
           ,[DTStatus] ,[JO_Code], [Machine_ID], [VerifiedBy_QA], [CreatedBy] )
           VALUES
           (@ShiftCode ,@UserName ,@UserID ,@DTType ,@StartTime
           ,@DTReason ,@DTCountermeasure ,@AckDate ,@EndTime ,@RunTime
           ,@TtlDTmins ,@TtlRprTimeMins ,@ForQAVeri ,@TtlQAVeriMins ,@TtlFailFreg
           ,@DTStatus ,@JOCode, @MachineID, @VeriBy, @CreatedBy)"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@ShiftCode", cls001_ShiftCode)
                    cmd.Parameters.AddWithValue("@UserName", cls001_UserName)
                    cmd.Parameters.AddWithValue("@UserID", cls001_UserID)
                    cmd.Parameters.AddWithValue("@DTType", cls001_DTType)
                    cmd.Parameters.AddWithValue("@StartTime", cls001_StartTime)
                    cmd.Parameters.AddWithValue("@DTReason", cls001_DTReason)
                    cmd.Parameters.AddWithValue("@DTCountermeasure", cls001_DTCountermeasure)
                    cmd.Parameters.AddWithValue("@AckDate", cls001_AckDate)
                    cmd.Parameters.AddWithValue("@EndTime", cls001_EndTime)
                    cmd.Parameters.AddWithValue("@RunTime", cls001_RunTime)
                    cmd.Parameters.AddWithValue("@TtlDTmins", cls001_TtlDTmins)
                    cmd.Parameters.AddWithValue("@TtlRprTimeMins", cls001_TtlRprtmins)
                    cmd.Parameters.AddWithValue("@ForQAVeri", cls001_ForQAVeri)
                    cmd.Parameters.AddWithValue("@TtlQAVeriMins", cls001_TtlQAVeriMins)
                    cmd.Parameters.AddWithValue("@TtlFailFreg", cls001_TtlFailfreg)
                    cmd.Parameters.AddWithValue("@DTStatus", cls001_DTStatus)
                    cmd.Parameters.AddWithValue("@JOCode", cls001_JOCode)
                    cmd.Parameters.AddWithValue("@MachineID", cls001_MachineID)
                    cmd.Parameters.AddWithValue("@VeriBy", cls001_VeriByQA)
                    cmd.Parameters.AddWithValue("@CreatedBy", cls001_CreatedBy)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    'MessageBox.Show("Quality Issue Downtime Created!", "Create Quality Downtime!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                modErrFlag_InsertDTQAStop = True
                MessageBox.Show(ex.Message, "Inserting QA Downtime...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_InsertDTQAStop = False
                End If
            End Try
        End If

    End Sub

End Class
