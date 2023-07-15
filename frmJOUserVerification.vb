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
                'If JOloadBtnClick = True Then
                '    stJOLoadedBy = modLogUserName
                '    bolJOLoadConfirm = True
                '    JOloadBtnClick = False
                '    modLogUserID = Nothing
                '    modLogOTS = Nothing
                '    modLogAccessLevel = Nothing
                '    Me.Close()
                'End If
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
                        Dim Result As String
                        Dim AR As New clsAccessRights
                        AR.AccsRights_UserID = modLogUserID
                        AR.AccsRights_AccessRights = modLogAccessLevel
                        AR.CheckAccessRights()
                        Result = AR.AccsRights_Result
                        If Result = "QALvl1" Or Result = "QALvl2" Then
                            modLogUserName = Nothing
                            modLogUserID = Nothing
                            modLogOTS = Nothing
                            modLogAccessLevel = Nothing
                            Me.Hide()
                            frmQualityStoppage.ShowDialog()
                            Me.Close()
                        Else
                            MessageBox.Show("You are not allowed to do this transaction!!!" _
                                & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If

                        modQualityUserLogin = modLogUserName


                        'Dim Result As Boolean
                        'Dim arights As New clsSelAll_MCDash_AR_QAFeat
                        'arights.checkAccess(modLogAccessLevel)
                        'Result = arights.QABtn_isTrue
                        'If Result = True Then
                        '    modLogUserName = Nothing
                        '    modLogUserID = Nothing
                        '    modLogOTS = Nothing
                        '    modLogAccessLevel = Nothing
                        '    Me.Hide()
                        '    frmQualityStoppage.ShowDialog()
                        '    Me.Close()
                        '    Exit Sub
                        'ElseIf IsDBNull(Result) Then
                        '    MessageBox.Show("You are not allowed to do this transaction!!!" _
                        '    & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    Me.Close()
                        'Else
                        '    MessageBox.Show("You are not allowed to do this transaction!!!" _
                        '    & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    Me.Close()
                        'End If
                        '
                        'modQualityUserLogin = modLogUserName
                    Catch ex As Exception
                        MessageBox.Show(ex.Message _
                            & vbNewLine & "If this error persist please contact your local Admin...", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End Try
                End If

                'FOR BYPASS TRIGGERING
                'MC1
                If bolMCDashboard1 = True Then
                    If modSysFlagMC1_Bypass_init = True Then
                        If txtJOVerification.Text = modLogOTS Then
                            If modSysFlagMC1_Bypass_isTrue = False Then
                                modSysFlagMC1_Bypass_isTrue = True
                                Me.Close()
                            Else
                                modSysFlagMC1_Bypass_isTrue = False
                                Me.Close()
                            End If

                        Else
                            MessageBox.Show("You are not allowed to do this transaction!!!" _
                            & vbNewLine & "If this error persist please contact your local Admin...", "BYPASS Confirmation..", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            modSysFlagMC1_Bypass_isTrue = False
                            modSysFlagMC1_Bypass_init = False
                            Me.Close()
                        End If
                    End If
                    'MC2
                ElseIf bolMCDashboard2 = True Then
                    If modSysFlagMC2_Bypass_init = True Then
                        If txtJOVerification.Text = modLogOTS Then
                            If modSysFlagMC2_Bypass_isTrue = False Then
                                modSysFlagMC2_Bypass_isTrue = True
                                Me.Close()
                            Else
                                modSysFlagMC2_Bypass_isTrue = False
                                Me.Close()
                            End If

                        Else
                            MessageBox.Show("You are not allowed to do this transaction!!!" _
                            & vbNewLine & "If this error persist please contact your local Admin...", "BYPASS Confirmation..", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            modSysFlagMC2_Bypass_isTrue = False
                            modSysFlagMC2_Bypass_init = False
                            Me.Close()
                        End If
                    End If
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