Imports System.Data.SqlClient

Public Class ClassSelectALLUD
    Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Public sqlProc As String = "SelectProAllUserDetails"
    Public BuildingNo As String
    Public UserName As String
    Public UserID As String
    Public MobileNumber As String
    Public EmailAddress As String
    Public Position As String
    Public AccLvl As String
    Public Password As String
    Public OTS As String

    Public Sub selectDB(w1 As String, w2 As String)
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(sqlProc, con)
            cmd.Parameters.AddWithValue("@UserID", w1)
            cmd.Parameters.AddWithValue("@OTS", w2)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            BuildingNo = myreader("Building_No")
            UserName = myreader("User_Name")
            UserID = myreader("User_ID")
            MobileNumber = myreader("Mobile_Number")
            EmailAddress = myreader("Email_Address")
            Position = myreader("Position")
            AccLvl = myreader("Access_Level")
            Password = myreader("Password")
            OTS = myreader("OTS")
            con.Close()
        End Using
    End Sub
End Class
