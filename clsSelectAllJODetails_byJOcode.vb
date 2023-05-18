Imports System.Data.SqlClient

Public Class clsSelectAllJODetails_byJOcode
    Inherits clsUpdateJOLoadedDetailsAll
    Public selProc1 As String = "SelProAllJOLoadedDetails"
    Public isLogged As Boolean
    Public Sub CompareIFJoCodeAlreadyLogged()
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(selProc1, con)
            cmd.Parameters.AddWithValue("@JoCode", JOCode)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            MachineID = myreader("Machine_ID")
            ShiftCode = myreader("Shift_Code")
            JOCode = myreader("JOB_ORDER")


        End Using
    End Sub



End Class
