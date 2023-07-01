Imports System.Data.SqlClient

Public Class clsUpdateDTStoppage
    Inherits cls001_InsertDowntime_QAStoppage

    Public Sub UpdateDowntime_At_QAStoppage()
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Dim proc As String = "UPDATE [Maintenance].[Downtime]
                      SET [User_Name] = @UserName
                        ,[User_ID] = @UserID
                        ,[DT_Type] = @DTType
                        ,[DT_Reason] = @DTReason
                        ,[DT_Countermeasure] = @DTCMeasure
                        ,[VerifiedBy_QA] = @VerByQA
                        ,[CreatedBy] = @CreatedBy
                      WHERE [DTStatus] = @DTStatus  And [Machine_ID] = @MachineID"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@DTStatus", cls001_DTStatus)
            cmd.Parameters.AddWithValue("@MachineID", cls001_MachineID)
            cmd.Parameters.AddWithValue("@UserName", cls001_UserName)
            cmd.Parameters.AddWithValue("@UserID", cls001_UserID)
            cmd.Parameters.AddWithValue("@DTType", cls001_DTType)
            cmd.Parameters.AddWithValue("@DTReason", cls001_DTReason)
            cmd.Parameters.AddWithValue("@DTCMeasure", cls001_DTCountermeasure)
            cmd.Parameters.AddWithValue("@VerByQA", cls001_VeriByQA)
            cmd.Parameters.AddWithValue("@CreatedBy", cls001_CreatedBy)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

End Class
