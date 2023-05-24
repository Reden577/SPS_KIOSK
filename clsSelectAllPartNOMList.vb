Imports System.Data.SqlClient

Public Class clsSelectAllPartNOMList
    'Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Public selAll As String = "SelectProPartNoMListAll"
    Public BuildingNo As String
    Public MldId As String
    Public AllowedMC As String
    Public PN1 As String
    Public PN2 As String
    Public CavPN1 As Integer
    Public cavPN2 As Integer
    Public Customer As String
    Public ProcsType As String
    Public CycleTime As String
    Public PartNoDetailsP1 As String
    Public PartNoDetailsP2 As String

    Public Sub SelectMoldIdDetails(mldID As String)
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Using cmd As SqlCommand = New SqlCommand(selAll, con)
            cmd.Parameters.AddWithValue("@MoldID", mldID)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            BuildingNo = myreader("Building_No")
            PN1 = myreader("Part_No1")
            PN2 = myreader("Part_No2")
            CavPN1 = myreader("No_of_CavityP1")
            cavPN2 = myreader("No_of_CavityP2")
            Customer = myreader("Customer")
            ProcsType = myreader("Process_Type")
            CycleTime = myreader("Cycle_Time_Sec")
            PartNoDetailsP1 = myreader("Part_No_DetailsP1")
            PartNoDetailsP2 = myreader("Part_No_DetailsP2")
            AllowedMC = myreader("Allowed_Machine")
            con.Close()
        End Using
    End Sub


End Class
