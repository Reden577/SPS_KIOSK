Imports System.Data.SqlClient

Public Class clsSelectAllPartNOMList
    'Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    'Public selAll As String = "SelectProPartNoMListAll"
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

    Public Sub SelectMoldIdDetails(moldID As String)
        If modErrFlag_PartDoesNotExist = False Then
            Dim con As New SqlConnection(modSetVal_SqlPath)
            Dim proc As String = "SELECT * FROM [dbo].[MListNewPartNumber] where [MOLD_ID] = @MoldID"
            Using cmd As SqlCommand = New SqlCommand(proc, con)
                cmd.Parameters.AddWithValue("@MoldID", moldID)
                con.Open()
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                If myreader.Read() Then
                    PN1 = myreader("PART_NO_1")
                    PN2 = myreader("PART_NO_2")
                    AllowedMC = myreader("MACHINE_ID")
                    MldId = myreader("MOLD_ID")
                    CycleTime = myreader("CYCLE_TIMESec")
                    CavPN1 = myreader("CAVITY")
                    con.Close()
                Else
                    modErrFlag_PartDoesNotExist = True
                    MessageBox.Show("Mold Id does not exist!", "Fetching Mold ID Details...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If DialogResult.OK Then
                        modErrFlag_PartDoesNotExist = False
                        Exit Sub
                    End If
                End If
            End Using
        End If
    End Sub


End Class
