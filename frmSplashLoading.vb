Imports System.IO
Imports System.Threading
Imports System.Windows.Media.Media3D

Public Class frmSplashLoading
    Private Sub frmSplashLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim plcCon As New cls002_ModBusConnection
        'plcCon.ConnectModClient()

        Dim stMyConfig(2) As String
        Dim MyConfig As StreamReader
        MyConfig = New StreamReader("MyConfig.txt")
        For i = 0 To 2
            stMyConfig(i) = MyConfig.ReadLine
            If i = 0 Then
                modSetVal_SqlPath = stMyConfig(i)
            ElseIf i = 1 Then
                modSetVal_IPAdd = stMyConfig(i)
            ElseIf i = 2 Then
                modSetVal_Port = stMyConfig(i)
            End If
        Next

        My.Settings.SQLPath = modSetVal_SqlPath
        My.Settings.IPAddress = modSetVal_IPAdd
        My.Settings.Port = modSetVal_Port
        My.Settings.Save()

        'modSetVal_SqlPath = My.Settings.SQLPath
        'modSetVal_IPAdd = My.Settings.IPAddress
        'modSetVal_Port = My.Settings.Port
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