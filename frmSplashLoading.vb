Imports System.Threading
Imports System.Windows.Media.Media3D

Public Class frmSplashLoading
    Private Sub frmSplashLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim plcCon As New cls002_ModBusConnection
        'plcCon.ConnectModClient()
        modSetVal_SqlPath = My.Settings.SQLPath
        modSetVal_IPAdd = My.Settings.IPAddress
        modSetVal_Port = My.Settings.Port
        Me.CenterToScreen()
    End Sub

    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        Dim ProgPercent As String


        ProgressBar1.Value += 1
        ProgPercent = ProgressBar1.Value & "%"
        If ProgressBar1.Value <= 30 Then
            lblProgress.Text = "Initializing System...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 50 Then
            lblProgress.Text = "Loading all Components and Settings...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 70 Then
            lblProgress.Text = "Please wait...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 100 Then
            lblProgress.Text = "Opening SPS App...  " & ProgPercent
        ElseIf ProgressBar1.Value = 100 Then
            lblProgress.Text = "Welcome to SPS App...  " & ProgPercent
        End If

        If ProgressBar1.Value = 100 Then
            'Thread.Sleep(2000)
            tmrProgress.Dispose()
            Me.Hide()
            frmMain.ShowDialog()
            Me.Close()
        End If
    End Sub


End Class