Imports System.Data.SqlClient

Public Class clsSelAll_MCDash_AR_QAFeat
    Public QABtn_isTrue As Boolean
    Public Feat0_isTrue As Boolean
    Public Feat1_isTrue As Boolean
    Public Feat2_isTrue As Boolean

    Public Sub checkAccess(AccessRights As String)
        Dim con As New SqlConnection(modSetVal_SqlPath)
        Dim proc As String = "SELECT * FROM [Quality].[AccessRights_QualityFeat] WHERE [Acess_Lvl] = @AccLvl"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@AccLvl", AccessRights)
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            QABtn_isTrue = myreader("QualityBtn")
            Feat0_isTrue = myreader("Feat_0")
            Feat1_isTrue = myreader("Feat_1")
            Feat2_isTrue = myreader("Feat_2")
            con.Close()
        End Using
    End Sub
End Class
