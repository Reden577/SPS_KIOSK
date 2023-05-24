
Imports System.Data.SqlClient

Public Class clsUpdateJODetailsAtUnloading
    Inherits clsUpdateJOLoadedDetailsAll
    Public proc As String = "UpdateProJOUnloaded"

    Public Sub UpdateJOLoadedDetailsAtUnloading()
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@JOCode", JOCode)
            cmd.Parameters.AddWithValue("@EndTime", EndTime)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.Parameters.AddWithValue("@ProdStat", ProdnStat)
            cmd.Parameters.AddWithValue("@UnloadBy", UnloadedBy)
            cmd.Parameters.AddWithValue("@UnloadTime", UnloadTime)
            cmd.Parameters.AddWithValue("@TotalShots", TotalShots)
            cmd.Parameters.AddWithValue("@PN1Output", PN1OUtput)
            cmd.Parameters.AddWithValue("@PN2Output", PN2Output)
            cmd.Parameters.AddWithValue("@PN1Reject", PN1Reject)
            cmd.Parameters.AddWithValue("@PN2Reject", Pn2Reject)
            cmd.Parameters.AddWithValue("@ActualPN1Out", ActualPN1Output)
            cmd.Parameters.AddWithValue("@ActualPN2Out", ActualPN2Output)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
