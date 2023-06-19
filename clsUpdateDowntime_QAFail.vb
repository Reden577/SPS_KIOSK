Imports System.Data.SqlClient

Public Class clsUpdateDowntime_QAFail
    Inherits cls001_InsertDowntime_QAStoppage

    Public Sub UpdateDT_AtQAFail()
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Dim proc As String = "UPDATE [Maintenance].[Downtime]
                        SET [ForQAVerification] = @ForQAVeri
                            ,[ttl_FailFreq] = @ttlFailFreq
                        WHERE [DT_Type] = @DTType And [DTStatus] = @DTStatus And [Machine_ID] = @MachineID"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@ForQAVeri", cls001_ForQAVeri)
            cmd.Parameters.AddWithValue("@ttlFailFreq", cls001_TtlFailfreg)
            cmd.Parameters.AddWithValue("@DTType", cls001_DTType)
            cmd.Parameters.AddWithValue("@DTStatus", cls001_DTStatus)
            cmd.Parameters.AddWithValue("@MachineID", cls001_MachineID)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
