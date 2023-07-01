Imports System.Data.SqlClient

Public Class clsCheckDTby_Quality_N_NewStoppage
    Public checkDT_stMCId As String
    Public checkDT_stNewStoppage As String
    Public checkDT_stDTType As String
    Public chekcDT_tDTStats As String
    Public checkDT_stDTTypeResult As String
    Public checkDT_stDTStatResult As String

    Public Sub CheckDTby_QualityN_NewStoppage()
        If modErrFlag_CheckDTbyQualityNNewStoppage = False Then
            Try
                Dim con As New SqlConnection(modSetVal_SqlPath)
                Dim proc As String = "SELECT [DT_Type], [DTStatus]
                        FROM [Maintenance].[Downtime]
                        WHERE [Machine_ID] = @MCId And [DTStatus] = @DTStats"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@MCId", checkDT_stMCId)
                    cmd.Parameters.AddWithValue("@DTStats", checkDT_stNewStoppage)
                    con.Open()
                    Dim myreader As SqlDataReader
                    myreader = cmd.ExecuteReader
                    myreader.Read()
                    checkDT_stDTTypeResult = myreader("DT_Type")
                    checkDT_stDTStatResult = myreader("DTStatus")
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_CheckDTbyQualityNNewStoppage = True
                MessageBox.Show(ex.Message, "Checking Donwtime by Quality and New Stoppage...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_CheckDTbyQualityNNewStoppage = False
                End If
            End Try
        End If

    End Sub

End Class
