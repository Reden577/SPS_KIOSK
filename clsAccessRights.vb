Imports System.Data.SqlClient

Public Class clsAccessRights
    Public AccsRights_UserName As String
    Public AccsRights_UserID As String
    Public AccsRights_AccessRights As String
    Public AccsRights_Result As String

    Public Sub CheckAccessRights()
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Dim proc As String = "SELECT [Acess_Rights]
                        FROM [Production].[MListUserDetails]
                        Where [User_ID] = @UserID And [Acess_Rights] = @AccRights"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@UserID", AccsRights_UserID)
            cmd.Parameters.AddWithValue("@AccRights", AccsRights_AccessRights)
            con.Open()
            AccsRights_Result = cmd.ExecuteScalar
            con.Close()
        End Using
    End Sub

End Class
