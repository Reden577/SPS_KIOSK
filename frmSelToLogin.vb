Imports System.Data.SqlClient
Public Class frmSelToLogin

    Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Dim procedure1 As String = "SelectUser"
    Dim proc1Para As String = "@UNID"
    Dim procedure2 As String = "SelectOTS"
    Dim proc2Para As String = "@OTS"

    Private Sub frmSelToLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtOTS.Text = ""
        txtUserID.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtUserID.Text <> "" And txtPassword.Text <> "" Then
            LoadUserDetails_ViaUserIDandPassword()
        ElseIf txtOTS.Text <> "" Then
            LoadUserDetails_ViaOTS()
        Else
            MessageBox.Show("Please Input or Scan Login Details!!!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    '//
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtOTS.Text = ""
        txtUserID.Text = ""
        txtPassword.Text = ""
    End Sub
    '//

    '// MY FUNCTION COUNTING SPACES IN A ROW OF STRINGS
    Private Function CountSpacesInAStrings(txt As String) As Integer
        Dim spcCount As Integer = 0
        Dim spcFind As String = ""
        For count = 1 To txt.Length
            spcFind = Mid(txt, count, 1)
            If spcFind = " " Then
                spcCount += 1
            End If
        Next
        Return spcCount
    End Function
    '//

    '//
    Public Sub LoadUserDetails_ViaUserIDandPassword()
        Try
            If txtUserID.Text <> "" And txtPassword.Text <> "" Then
                Dim con As New SqlConnection(sqlPath)
                con.Open()
                Dim cmd As New SqlCommand(procedure1, con)
                cmd.Parameters.AddWithValue(proc1Para, txtUserID.Text)
                cmd.CommandType = CommandType.StoredProcedure
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                modLogBuildingNO = myreader("Building_No")
                modLogUserID = myreader("User_ID")
                modLogUserName = myreader("User_Name")
                modLogFirstName = myreader("First_Name")
                modLogLastName = myreader("Last_Name")
                modLogMobileNo = myreader("Mobile_Number")
                modLogEmailAdd = myreader("Email_Address")
                modLogPosition = myreader("Position")
                modLogAccessLevel = myreader("Access_Level")
                modLogPW = myreader("Password")
                modLogOTS = myreader("OTS")
                con.Close()
            Else
                MessageBox.Show("Invalid User ID or Password!" _
                    & vbNewLine & "Please Input Valid User ID and Password..." _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If txtPassword.Text = modLogPW And txtUserID.Text <> "" And txtPassword.Text <> "" Then
                bolLoginConfirm = True
                stUserName = modLogUserName
                stUserID = modLogUserID
                stAccessLvl = modLogAccessLevel

                modLogBuildingNO = Nothing
                modLogUserID = Nothing
                modLogUserName = Nothing
                modLogFirstName = Nothing
                modLogLastName = Nothing
                modLogMobileNo = Nothing
                modLogEmailAdd = Nothing
                modLogPosition = Nothing
                modLogAccessLevel = Nothing
                modLogPW = Nothing
                modLogOTS = Nothing


                Me.Close()
            Else
                MessageBox.Show("Invalid User ID or Password!" _
                    & vbNewLine & "Please Input Valid User ID and Password..." _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get User Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadUserDetails_ViaOTS()
        Try
            If txtOTS.Text <> "" Then
                Dim con As New SqlConnection(sqlPath)
                con.Open()
                Dim cmd As New SqlCommand(procedure2, con)
                cmd.Parameters.AddWithValue(proc2Para, txtOTS.Text)
                cmd.CommandType = CommandType.StoredProcedure
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                modLogBuildingNO = myreader("Building_No")
                modLogUserID = myreader("User_ID")
                modLogUserName = myreader("User_Name")
                modLogFirstName = myreader("First_Name")
                modLogLastName = myreader("Last_Name")
                modLogMobileNo = myreader("Mobile_Number")
                modLogEmailAdd = myreader("Email_Address")
                modLogPosition = myreader("Position")
                modLogAccessLevel = myreader("Access_Level")
                modLogPW = myreader("Password")
                modLogOTS = myreader("OTS")
                con.Close()
                'MsgBox(modLogOTS)
            Else
                MessageBox.Show("Invalid OTS Login!" _
                    & vbNewLine & "Please make sure you are provided with correct QR Code ID and Scan Again..." _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If txtOTS.Text = modLogOTS And txtOTS.Text <> "" Then
                bolLoginConfirm = True
                stUserName = modLogUserName
                stUserID = modLogUserID
                stAccessLvl = modLogAccessLevel

                modLogBuildingNO = Nothing
                modLogUserID = Nothing
                modLogUserName = Nothing
                modLogFirstName = Nothing
                modLogLastName = Nothing
                modLogMobileNo = Nothing
                modLogEmailAdd = Nothing
                modLogPosition = Nothing
                modLogAccessLevel = Nothing
                modLogPW = Nothing
                modLogOTS = Nothing


                Me.Close()
            Else
                MessageBox.Show("Invalid User ID or Password!" _
                    & vbNewLine & "Please Input Valid User ID and Password..." _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get User Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtOTS.Text = ""
    End Sub

    Private Sub txtUserID_Click(sender As Object, e As EventArgs) Handles txtUserID.Click
        txtOTS.Text = ""
    End Sub

    Private Sub txtOTS_Click(sender As Object, e As EventArgs) Handles txtOTS.Click
        txtUserID.Text = ""
        txtPassword.Text = ""
    End Sub
    '//


End Class