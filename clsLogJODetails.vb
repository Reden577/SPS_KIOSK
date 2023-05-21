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
        Dim con As New SqlConnection(sqlPath)
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
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(logJOProc, con)
            cmd.Parameters.AddWithValue("@MachineID", AllowedMachine)
            cmd.Parameters.AddWithValue("@ShiftCode", ShiftCode)
            cmd.Parameters.AddWithValue("@JOCode", JOCode)
            cmd.Parameters.AddWithValue("@MoldId", ModlID)
            cmd.Parameters.AddWithValue("@PN1", PN1)
            cmd.Parameters.AddWithValue("@PN2", "none")
            cmd.Parameters.AddWithValue("@CavPN1", CavP1)
            cmd.Parameters.AddWithValue("@CavPN2", "0")
            cmd.Parameters.AddWithValue("@PlanQty", JOQty)
            cmd.Parameters.AddWithValue("@CycleTime", CycleTime)
            cmd.Parameters.AddWithValue("@StartTime", StartTime)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.Parameters.AddWithValue("@ProdnStat", ProdnStat)
            cmd.Parameters.AddWithValue("@Loadedby", LoadedBy)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
