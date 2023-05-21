Imports System.Data.SqlClient

Public Class clsSelectAllJODetails_byJOcode
    Inherits clsUpdateJOLoadedDetailsAll
    Public selProc1 As String = "SelProAllJOLoadedDetails"
    Public isLogged As Boolean
    Public getJOCOde As String
    Public getMachineID As String
    Public dgv As DataGridView
    Public txtBox As TextBox

    Public Sub CompareIFJoCodeAlreadyLogged()
        Try
            Dim con As New SqlConnection(sqlPath)
            Using cmd As SqlCommand = New SqlCommand(selProc1, con)
                cmd.Parameters.AddWithValue("@JoCode", JOCode)
                cmd.Parameters.AddWithValue("@MachineID", MachineID)
                cmd.CommandType = CommandType.StoredProcedure
                con.Open()
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                getMachineID = myreader("Machine_ID")
                ShiftCode = myreader("Shift_Code")
                getJOCOde = myreader("JOB_ORDER")
                ModlID = myreader("Mold_ID")
                PN1 = myreader("PART_NO_1")
                PN2 = myreader("PART_NO_2")
                CavP1 = myreader("MOLD_CAVITY_PART_1")
                CavP2 = myreader("MOLD_CAVITY_PART_2")
                JOQty = myreader("JOB_ORDER_QTY")
                CycleTime = myreader("CYCLE_TIME_SEC")
                StartTime = myreader("START_TIME")
                EndTime = myreader("END_TIME")
                LoadStat = myreader("Load_Stats")
                ProdnStat = myreader("Prodn_Stats")
                LoadedBy = myreader("Loaded_By")
                UnloadedBy = myreader("Unloaded_By")
                UnloadTime = myreader("Unld_DT")
                TotalShots = myreader("Ttl_Shots")
                PN1OUtput = myreader("PN1_Output")
                PN2Output = myreader("PN2_Output")
                PN1Reject = myreader("PN1_Reject")
                Pn2Reject = myreader("PN2_Reject")
                ActualPN1Output = myreader("Actual_PN1_Out")
                ActualPN2Output = myreader("Actual_PN2_Out")
                MSStartTime = myreader("MS_Start_DT")
                MSStopTime = myreader("MS_Stop_DT")
                FPBStartTime = myreader("FPB_Start_DT")
                FPBStopTime = myreader("FPB_Stop_DT")
                TtlMSTime = myreader("Ttl_MS_Time")
                TtlFPBTime = myreader("Ttl_FPB_Time")
                TotalRunTime = myreader("Ttl_RunTime")
                con.Close()

                If MachineID = "" Then
                    If getJOCOde = JOCode Then
                        isLogged = True
                    Else
                        isLogged = False
                    End If
                End If

                If JOCode = "" Then
                    If getMachineID = MachineID Then
                        isLogged = True
                    Else
                        isLogged = False
                    End If
                End If

            End Using
        Catch ex As Exception
            If ex.Message IsNot Nothing Then
                Exit Sub
            End If
        End Try
    End Sub

End Class
