Imports System.Data.SqlClient

Public Class clsUpdateJOLoadedDetailsAll
    Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Public sqlProc As String = "UpdateProJOLoadedDetails"
    Public BuildingNo As String
    Public MachineID As String
    Public ShiftCode As String
    Public JOCode As String
    Public ModlID As String
    Public PN1 As String
    Public PN2 As String
    Public CavP1 As Integer
    Public CavP2 As Integer
    Public JOQty As Integer
    Public CycleTime As Integer
    Public StartTime As String
    Public EndTime As String
    Public LoadStat As String
    Public ProdnStat As String
    Public LoadedBy As String
    Public UnloadedBy As String
    Public UnloadTime As String
    Public TotalShots As Integer
    Public PN1OUtput As Integer
    Public PN2Output As Integer
    Public PN1Reject As Integer
    Public Pn2Reject As Integer
    Public ActualPN1Output As Integer
    Public ActualPN2Output As Integer
    Public TotalRunTime As Decimal

    Public Sub UpdateJOLoadedDetailsAll()
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(sqlProc, con)
            cmd.Parameters.AddWithValue("@MachineID", MachineID)
            cmd.Parameters.AddWithValue("@ShiftCode", ShiftCode)
            cmd.Parameters.AddWithValue("@JOCode", JOCode)
            cmd.Parameters.AddWithValue("@MoldID", ModlID)
            cmd.Parameters.AddWithValue("@PN1", PN1)
            cmd.Parameters.AddWithValue("@PN2", PN2)
            cmd.Parameters.AddWithValue("@CavP1", CavP1)
            cmd.Parameters.AddWithValue("@CavP2", CavP2)
            cmd.Parameters.AddWithValue("@JOQty", JOQty)
            cmd.Parameters.AddWithValue("@CycleTime", CycleTime)
            cmd.Parameters.AddWithValue("@StartTime", StartTime)
            cmd.Parameters.AddWithValue("@EndTime", EndTime)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.Parameters.AddWithValue("@ProdnStat", ProdnStat)
            cmd.Parameters.AddWithValue("@LoadedBy", LoadedBy)
            cmd.Parameters.AddWithValue("@UnloadedBY", UnloadedBy)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
