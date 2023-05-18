Imports System.Net.Security
Imports FontAwesome.Sharp

Public Class frmMain

    Private currentBtn As IconButton
    Private leftborderBtn As Panel ' For Side Panel1 (Home)
    Private leftborderBtn1 As Panel 'For Side Panel2 (Login and Setting)

    'FORM LOAD 
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'center to screen
        Me.CenterToScreen()

        'enable the timer for date
        TimerDate.Enabled = True
        ActiveButton1(btnHome, rgbColors.rgb_BlueGreen)
        change_PanelContainerFrm("Home")
    End Sub

    '// CLOSE APPLICATION
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim appClose As DialogResult
        appClose = MessageBox.Show("Closing this application will STOP ALL THE MACHINES!!!" &
                                    vbNewLine & "Do you want to proceed?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If appClose = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    '//

    '// DATE ON TIMER TICK
    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub
    '//

    '//
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Label1.Text = modCurrentOpenForm 'Current Open Form inside panel
        If menuTabHome = True Then
            Label2.Text = "Home"
        ElseIf menuTabLogin = True Then
            Label2.Text = "Login"
        ElseIf menuTabLogout = True Then
            Label2.Text = "Logout"
        ElseIf menuTabWorkOrder = True Then
            Label2.Text = "Job Order"
        ElseIf menuTabSetting = True Then
            Label2.Text = "Setting"
        End If
    End Sub
    '//

    '// LEFT CORNER BUTTON BORDER FOR ACTIVE BUTTON
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftborderBtn = New Panel
        leftborderBtn1 = New Panel
        leftborderBtn.Size = New Size(5, 45)
        leftborderBtn1.Size = New Size(5, 45)
        SidePanel1.Controls.Add(leftborderBtn)
        SidePanel2.Controls.Add(leftborderBtn1)
    End Sub
    '//

    '// COLOR COMBINATION FOR ACTIVE BUTTONS (HOME)
    Private Sub ActiveButton1(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            InactiveButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(240, 240, 240)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black

            leftborderBtn.BackColor = customColor
            leftborderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()
        End If
    End Sub
    '//

    '// COLOR COMBINATION FOR ACTIVE BUTTONS (LOGIN, SETTING)
    Private Sub ActiveButton2(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            InactiveButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(240, 240, 240)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black

            leftborderBtn1.BackColor = customColor
            leftborderBtn1.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn1.Visible = True
            leftborderBtn1.BringToFront()
        End If
    End Sub
    '//

    '// COLOR COMBINATION FOR INACTIVE BUTTONS
    Private Sub InactiveButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(12, 97, 112)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            leftborderBtn.BackColor = Color.FromArgb(12, 97, 112)
            leftborderBtn1.BackColor = Color.FromArgb(12, 97, 112)
        End If
    End Sub
    '//

    '// SHOW FORM INSIDE PANEL FRM CONTAINER
    Private Sub showForm(frm As Form)
        PanelFrmContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelFrmContainer.Controls.Add(frm)
        frm.Show()
        modCurrentOpenForm = frm.Name.ToString
    End Sub
    '//

    '// SWITCHING FROM FORM TO FORM BY BUTTONS
    Private Sub change_PanelContainerFrm(menu As String)
        Select Case menu
            Case "Home"
                showForm(frmHome)
            'Case "Login"
            '    showForm(frmLogin)
            Case "Setting"
                showForm(frmSetting1)
            Case "WorkOrder"
                showForm(frmWorkOrder)
        End Select
    End Sub
    '//

    '// BUTTONS FOR SWITCHING FROM FORM TO FORM
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If Not modCurrentOpenForm = "frmHome" Then
            ActiveButton1(sender, rgbColors.rgb_BlueGreen)
            change_PanelContainerFrm("Home")
        Else
            ActiveButton1(sender, rgbColors.rgb_BlueGreen)
        End If
        menuTabHome = True
        menuTabWorkOrder = False
        menuTabLogin = False
        menuTabSetting = False
        menuTabLogout = False
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not modCurrentOpenForm = "frmHome" Then
            ActiveButton2(sender, rgbColors.rgb_BlueGreen)
            change_PanelContainerFrm("Home")
        Else
            ActiveButton2(sender, rgbColors.rgb_BlueGreen)
        End If
        menuTabLogin = True
        menuTabHome = False
        menuTabWorkOrder = False
        menuTabSetting = False
        menuTabLogout = False
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If Not modCurrentOpenForm = "frmHome" Then
            ActiveButton2(sender, rgbColors.rgb_BlueGreen)
            change_PanelContainerFrm("Home")
        Else
            ActiveButton2(sender, rgbColors.rgb_BlueGreen)
        End If
        menuTabLogout = True
        menuTabHome = False
        menuTabWorkOrder = False
        menuTabLogin = False
        menuTabSetting = False
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        menuTabSetting = True
        menuTabHome = False
        menuTabWorkOrder = False
        menuTabLogin = False
        menuTabLogout = False
        ActiveButton2(sender, rgbColors.rgb_BlueGreen)
        change_PanelContainerFrm("Setting")
        'frmSetting1.ShowDialog()
    End Sub
    Private Sub btnWO_Click(sender As Object, e As EventArgs) Handles btnWO.Click
        menuTabWorkOrder = True
        menuTabHome = False
        menuTabLogin = False
        menuTabSetting = False
        menuTabLogout = False
        ActiveButton2(sender, rgbColors.rgb_BlueGreen)
        change_PanelContainerFrm("WorkOrder")
        'frmWorkOrder.ShowDialog()
    End Sub
    '//



End Class
