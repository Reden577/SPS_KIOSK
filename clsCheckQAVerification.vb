Imports System.Data.SqlClient

Public Class clsCheckQAVerification
    Inherits clsDowntimeDetails

    Public Sub CheckQAVerificaition()
        If modErrFlag_CheckQAVerification = False Then
            Try
                Dim con As New SqlConnection(modSetVal_SqlPath)
                Dim proc As String = "SELECT [ForQAVerification]
                        FROM [Maintenance].[Downtime]
                        WHERE [DT_Type] = @DTType And [DTStatus] = @DTStats And [Machine_ID] = @MCId"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@DTType", DTDetails_sfDTType)
                    cmd.Parameters.AddWithValue("@DTStats", DTDetails_sfDTStatus)
                    cmd.Parameters.AddWithValue("@MCId", DTDetails_sfMCId)
                    con.Open()
                    DTDetails_sfForQAVeri = cmd.ExecuteScalar
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_CheckQAVerification = True
                MessageBox.Show(ex.Message, "Checking QA Verification...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_CheckQAVerification = False
                End If
            End Try
        End If

    End Sub

End Class
