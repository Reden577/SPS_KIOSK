Imports System.Data.SqlClient

Public Class clsUpdateDTAtQAPass
    Inherits clsDowntimeDetails

    Public Sub UpdateDTAt_QAPass()
        If modErrFlag_UpdateQAPass = False Then
            Try
                Dim con As New SqlConnection(modSetVal_SqlPath)
                Dim proc As String = "UPDATE [Maintenance].[Downtime]
                        SET [ForQAVerification] = @QAVeri
                        ,[ttl_QAVeri_mins] = @TtlQAVeri
                        ,[VerifiedBy_QA] = @VeriByQA
                        WHERE [DT_Type] = @DTType And [DTStatus] = @DTStats And [Machine_ID] = @MCId "
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@QAVeri", DTDetails_sfForQAVeri)
                    cmd.Parameters.AddWithValue("@TtlQAVeri", DTDetails_iTtlQAVeri)
                    cmd.Parameters.AddWithValue("@VeriByQA", DTDetails_sfVeriByQA)
                    cmd.Parameters.AddWithValue("@DTType", DTDetails_sfDTType)
                    cmd.Parameters.AddWithValue("@DTStats", DTDetails_sfDTStatus)
                    cmd.Parameters.AddWithValue("@MCId", DTDetails_sfMCId)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_UpdateQAPass = True
                MessageBox.Show(ex.Message, "Updating Downtime At QA Pass...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_UpdateQAPass = False
                End If
            End Try
        End If

    End Sub
End Class
