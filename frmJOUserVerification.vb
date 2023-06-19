Imports System.Data.SqlClient
Public Class frmJOUserVerification
    'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"

    Private Sub frmJOUserVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub frmJOUserVerification_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        txtJOVerification.Text = ""
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        LoadUserDetails_ViaOTS()
    End Sub

    '//
    Public Sub LoadUserDetails_ViaOTS()
        Try
            ' Getting User Name and One Time Scan pasword 
            If txtJOVerification.Text <> "" Then
                Dim sel As New ClassSelectALLUD
                sel.selectDB("", txtJOVerification.Text)
                modLogUserName = sel.UserName
                modLogUserID = sel.UserID
                modLogOTS = sel.OTS
                modLogAccessLevel = sel.AccRights

            Else
                MessageBox.Show("You are not allowed to do this transaction!!!" _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Compare Condidtion if login details exist 
            If txtJOVerification.Text = modLogOTS And txtJOVerification.Text <> "" Then

                ' For Job Order Loading Ver.1
                If JOloadBtnClick = True Then
                    stJOLoadedBy = modLogUserName
                    bolJOLoadConfirm = True
                    JOloadBtnClick = False
                    modLogUserID = Nothing
                    modLogOTS = Nothing
                    modLogAccessLevel = Nothing
                    Me.Close()
                End If
                'If JOUnloadBtnClick = True Then
                '    stJOUnloadedBy = modLogUserName
                '    bolJOUnloadConfirm = True
                '    JOUnloadBtnClick = False
                '    frmJOUnload.Close()
                '    modLogOTS = Nothing
                '    Me.Close()
                'End If

                ' For Job Order Loading Ver.2
                If JOLoadBtn2Click = True Then
                    stJOLoadedBy = modLogUserName
                    bolJOLoadConfirm = True
                    JOLoadBtn2Click = False
                    frmJOUnload.Close()
                    modLogUserID = Nothing
                    modLogOTS = Nothing
                    modLogAccessLevel = Nothing
                    Me.Close()
                End If

                ' For JOb Order Unloading
                If bolUpdateAndUnload = True Then
                    stJOUnloadedBy = modLogUserName
                    bolJOUnloadConfirm = True
                    JOUnloadBtnClick = False
                    frmJOUnload.Close()
                    modLogUserID = Nothing
                    modLogOTS = Nothing
                    modLogAccessLevel = Nothing
                    Me.Close()
                End If

                ' For Quality Stoppage and Verification
                If modQualityBtn_AtMCDash_isTrue = True Then
                    modQualityBtn_AtMCDash_isTrue = False
                    modQualityUserLogin = modLogUserName
                    modQualityUIDLogin = modLogUserID
                    Try
                        Dim Result As Boolean
                        Dim arights As New clsSelAll_MCDash_AR_QAFeat
                        arights.checkAccess(modLogAccessLevel)
                        Result = arights.QABtn_isTrue
                        If Result = True Then
                            modLogUserName = Nothing
                            modLogUserID = Nothing
                            modLogOTS = Nothing
                            modLogAccessLevel = Nothing
                            Me.Hide()
                            frmQualityStoppage.ShowDialog()
                            Me.Close()
                            Exit Sub
                        ElseIf IsDBNull(Result) Then
                            MessageBox.Show("You are not allowed to do this transaction!!!" _
                            & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        Else
                            MessageBox.Show("You are not allowed to do this transaction!!!" _
                            & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                        '
                        'modQualityUserLogin = modLogUserName
                    Catch ex As Exception
                        MessageBox.Show(ex.Message _
                            & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End Try

                End If
            Else
                MessageBox.Show("You are not allowed to do this transaction!!!" _
                    & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get User Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    '//

End Class