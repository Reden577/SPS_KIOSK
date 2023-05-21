Imports System.Data.SqlClient

Public Class clsUpdateMListNewJobOrder
    Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Public sqlProc1 As String = "UpdProMListNewJobOrder_LoadStat"
    Public JOCode As String
    Public MoldID As String
    Public JOPlanQty As Integer
    Public MachineID As String
    Public LoadStat As String

    Public Sub updateLoadStat()
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(sqlProc1, con)
            cmd.Parameters.AddWithValue("@JOCode", JOCode)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

End Class
