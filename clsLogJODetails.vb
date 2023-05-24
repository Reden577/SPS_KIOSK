Imports System.Data.SqlClient

Public Class clsLogJODetails
    Inherits clsUpdateJOLoadedDetailsAll
    Public getMIdProc As String = "SelectProMoldIdDetailsAll"
    Public logJOProc As String = "InsertProLogJODetails"
    Public Customer As String
    Public ProcessType As String
    Public PartNoDetails As String
    Public AllowedMachine As String

    Public Sub getPartNoDetails(mldId As String)
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Using cmd As SqlCommand = New SqlCommand(getMIdProc, con)
            cmd.Parameters.AddWithValue("@MoldId", mldId)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            BuildingNo = myreader("Building_No")
            PN1 = myreader("Part_No")
            CavP1 = myreader("No_of_Cavity")
            ProcessType = myreader("Process_Type")
            CycleTime = myreader("Cycle_Time_Sec")
            PartNoDetails = myreader("Part_No_Details")
            AllowedMachine = myreader("Allowed_Machine")
            con.Close()
        End Using
    End Sub

    Public Sub logJODetails()
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Using cmd As SqlCommand = New SqlCommand(logJOProc, con)
            cmd.Parameters.AddWithValue("@MachineID", AllowedMachine)
            cmd.Parameters.AddWithValue("@ShiftCode", ShiftCode)
            cmd.Parameters.AddWithValue("@JOCode", JOCode)
            cmd.Parameters.AddWithValue("@MoldId", ModlID)
            cmd.Parameters.AddWithValue("@PN1", PN1)
            cmd.Parameters.AddWithValue("@PN2", PN2)
            cmd.Parameters.AddWithValue("@CavPN1", CavP1)
            cmd.Parameters.AddWithValue("@CavPN2", CavP2)
            cmd.Parameters.AddWithValue("@PlanQty", JOQty)
            cmd.Parameters.AddWithValue("@CycleTime", CycleTime)
            cmd.Parameters.AddWithValue("@StartTime", StartTime)
            cmd.Parameters.AddWithValue("@EndTime", EndTime)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.Parameters.AddWithValue("@ProdnStat", ProdnStat)
            cmd.Parameters.AddWithValue("@Loadedby", LoadedBy)
            cmd.Parameters.AddWithValue("@Unloadedby", UnloadedBy)
            cmd.Parameters.AddWithValue("@UnldDT", UnloadTime)
            cmd.Parameters.AddWithValue("@TtlShots", TotalShots)
            cmd.Parameters.AddWithValue("@PN1Output", PN1OUtput)
            cmd.Parameters.AddWithValue("@PN2Output", PN2Output)
            cmd.Parameters.AddWithValue("@PN1Reject", PN1Reject)
            cmd.Parameters.AddWithValue("@PN2Reject", Pn2Reject)
            cmd.Parameters.AddWithValue("@ActlPN1Output", ActualPN1Output)
            cmd.Parameters.AddWithValue("@ActlPN2Output", ActualPN2Output)
            cmd.Parameters.AddWithValue("@MSStartDtTm", MSStartTime)
            cmd.Parameters.AddWithValue("@MSEndDtTm", MSStopTime)
            cmd.Parameters.AddWithValue("@FPBStartDtTm", FPBStartTime)
            cmd.Parameters.AddWithValue("@FPBEndDtTm", FPBStopTime)
            cmd.Parameters.AddWithValue("@TtlMSTm", TtlMSTime)
            cmd.Parameters.AddWithValue("@TtlFPBTm", TtlFPBTime)
            cmd.Parameters.AddWithValue("@TtlRunTm", TotalRunTime)
            cmd.Parameters.AddWithValue("@BldgNo", BuildingNo)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
