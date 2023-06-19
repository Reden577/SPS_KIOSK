Imports System.Data.SqlClient

Public Class clsSelDTReasonCMeasure
    Inherits cls001_InsertDowntime_QAStoppage

    Public Sub SelDTReason_CMeasure()
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Dim proc As String = "SELECT [DT_Reason] ,[DT_Countermeasure], [ttl_FailFreq]
                    FROM [Maintenance].[Downtime]
                    WHERE [DT_Type] = @DTType And [Machine_ID] = @MachineID And [DTStatus] = @DTStatus"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@DTType", cls001_DTType)
            cmd.Parameters.AddWithValue("@MachineID", cls001_MachineID)
            cmd.Parameters.AddWithValue("@DTStatus", cls001_DTStatus)
            con.Open()
            Dim myReader As SqlDataReader
            myReader = cmd.ExecuteReader
            myReader.Read()
            If myReader("DT_Reason") IsNot DBNull.Value Then
                cls001_DTReason = myReader("DT_Reason")
            Else
                cls001_DTReason = ""
            End If
            If myReader("DT_Countermeasure") IsNot DBNull.Value Then
                cls001_DTCountermeasure = myReader("DT_Countermeasure")
            Else
                cls001_DTCountermeasure = ""
            End If
            If myReader("ttl_FailFreq") IsNot DBNull.Value Then
                cls001_TtlFailfreg = myReader("ttl_FailFreq")
            Else
                cls001_TtlFailfreg = 0
            End If
            con.Close()
        End Using
    End Sub
End Class
