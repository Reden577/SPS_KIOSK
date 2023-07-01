Imports System.Data.SqlClient

Public Class clsCheckExistingDowntime
    Public checkDT_stMCId As String
    Public checkDT_stNewStoppage As String
    Public checkDT_stDTType As String
    Public checkDT_Result As String

    Public Sub checkExistingDT()
        If modErrFlag_CheckingExistingDT = False Then
            Try
                Dim con As New SqlConnection(modSetVal_SqlPath)
                Dim proc As String = "SELECT [DT_Type]
                        FROM [Maintenance].[Downtime]
                        WHERE [Machine_ID] = @MCId And [DTStatus] = @DTStats"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@MCId", checkDT_stMCId)
                    cmd.Parameters.AddWithValue("@DTStats", checkDT_stNewStoppage)
                    con.Open()
                    checkDT_Result = cmd.ExecuteScalar
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_CheckingExistingDT = True
                MessageBox.Show(ex.Message, "Checking Existing Downtime...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_CheckingExistingDT = False
                End If
            End Try
        End If

    End Sub
End Class
