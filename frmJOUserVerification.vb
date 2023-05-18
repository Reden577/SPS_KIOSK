Imports System.Data.SqlClient
Public Class frmJOUserVerification
    Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"

    Private Sub frmJOUserVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        LoadUserDetails_ViaOTS()
    End Sub

    '//
    Public Sub LoadUserDetails_ViaOTS()
        Try
            If txtJOVerification.Text <> "" Then
                Dim sel As New ClassSelectALLUD
                sel.selectDB("", txtJOVerification.Text)
                modLogUserName = sel.UserName
                modLogOTS = sel.OTS
            Else
                MessageBox.Show("You are not allowed to this transaction!!!" _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If txtJOVerification.Text = modLogOTS And txtJOVerification.Text <> "" Then
                If JOloadBtnClick = True Then
                    stJOLoadedBy = modLogUserName
                    bolJOLoadConfirm = True
                    JOloadBtnClick = False
                    modLogOTS = Nothing
                    Me.Close()
                End If
                If JOUnloadBtnClick = True Then
                    stJOUnloadedBy = modLogUserName
                    bolJOUnloadConfirm = True
                    JOUnloadBtnClick = False
                    frmJOUnload.Close()
                    modLogOTS = Nothing
                    Me.Close()
                End If
                If JOLoadBtn2Click = True Then
                    stJOLoadedBy = modLogUserName
                    bolJOLoadConfirm = True
                    JOLoadBtn2Click = False
                    frmJOUnload.Close()
                    modLogOTS = Nothing
                    Me.Close()
                End If
                If bolUpdateAndUnload = True Then
                    stJOUnloadedBy = modLogUserName
                    bolJOUnloadConfirm = True
                    JOUnloadBtnClick = False
                    frmJOUnload.Close()
                    modLogOTS = Nothing
                    Me.Close()
                End If
            Else
                MessageBox.Show("You are not allowed to this transaction!!!" _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get User Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

End Class