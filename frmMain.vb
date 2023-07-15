Imports System.ComponentModel
Imports System.Net.Security
Imports EasyModbus
Imports FontAwesome.Sharp

Public Class frmMain

    Private currentBtn As IconButton
    Private leftborderBtn As Panel ' For Side Panel1 (Home)
    Private leftborderBtn1 As Panel 'For Side Panel2 (Login and Setting)

    Dim ModClient As New EasyModbus.ModbusClient

    'FORM LOAD 
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'center to screen
        Me.CenterToScreen()

        'enable the timer for date
        TimerDate.Enabled = True
        ActiveButton1(btnHome, rgbColors.rgb_BlueGreen)
        change_PanelContainerFrm("Home")

        modSetVal_SqlPath = My.Settings.SQLPath
        modSetVal_IPAdd = My.Settings.IPAddress

        'modSysFlagMC1_Bypass_isTrue = My.Settings.MC1Bypass
        'modSysFlagMC2_Bypass_isTrue = My.Settings.MC2Bypass
        ConnectToModbus()
        readCoilsRegisters()

        If RxPLCM9 = True Then
            modSysFlagMC1_Bypass_isTrue = True
        End If
        If RxPLCM10 = True Then
            modSysFlagMC2_Bypass_isTrue = True
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.SQLPath = modSetVal_SqlPath
        My.Settings.IPAddress = modSetVal_IPAdd

        My.Settings.MC1Bypass = modSysFlagMC1_Bypass_isTrue
        My.Settings.MC2Bypass = modSysFlagMC2_Bypass_isTrue
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
        lblCurrentForm.Text = modCurrentOpenForm 'Current Open Form inside panel
        lblRxPLCM0.Text = RxPLCM0
        lblRxPLCM1.Text = RxPLCM1

        MachineStop_At_QAStoppage()

        If menuTabHome = True Then
            lblCurrentScreen.Text = "Home"
        ElseIf menuTabLogin = True Then
            lblCurrentScreen.Text = "Login"
        ElseIf menuTabLogout = True Then
            lblCurrentScreen.Text = "Logout"
        ElseIf menuTabWorkOrder = True Then
            lblCurrentScreen.Text = "Job Order"
        ElseIf menuTabSetting = True Then
            lblCurrentScreen.Text = "Setting"
        End If

        ReadHoldingRegs()
        readCoilsRegisters()
        PlanQuantityLoadMC1()
        PlanQuantityLoadMC2()
        UnloadJO_PLCCountersTo_0()
        MC1LoadedJOCavQty()
        MC2LoadedJOCavQty()
        LogoutAndNoJOFlag()
        BypassMC()
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
        frmWorkOrder.Close()
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
        frmWorkOrder.Close()
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
        frmWorkOrder.Close()
        menuTabLogin = False
        menuTabSetting = False
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        menuTabSetting = True
        menuTabHome = False
        menuTabWorkOrder = False
        frmWorkOrder.Close()
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

    Public Sub ConnectToModbus()
        ModClient.IPAddress = modSetVal_IPAdd
        ModClient.Port = modSetVal_Port
        ModClient.ConnectionTimeout = 3000
        ModClient.NumberOfRetries = 5

        Try
            ModClient.Connect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connecting To PLC Modbus!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '// READING HOLDING REGISTERS (DELTA PLC)
    Public Sub ReadHoldingRegs()
        If modErrFlag_ReadingHoldingRegistry = False Then
            Try
                Dim ReadValue() As Integer = ModClient.ReadHoldingRegisters(6096, 100)
                ComCheck = ReadValue(0) '6096

                'Double Word Declaration for Modbus 6098,6099 which is equal to D2002,D2003 of delta PLC
                Dim dwD2002(2) As Integer 'MC1 Counter
                dwD2002(0) = ReadValue(2) '6098
                dwD2002(1) = ReadValue(3) '6099
                D2002 = ModbusClient.ConvertRegistersToInt(dwD2002, 0)

                Dim dwD2004(2) As Integer 'MC2 Counter
                dwD2004(0) = ReadValue(4) '6100
                dwD2004(1) = ReadValue(5) '6101
                D2004 = ModbusClient.ConvertRegistersToInt(dwD2004, 0)

                Dim dwD2006(2) As Integer 'MC1 User ID
                dwD2006(0) = ReadValue(6) '6102
                dwD2006(1) = ReadValue(7) '6103
                D2006 = ModbusClient.ConvertRegistersToInt(dwD2006, 0)

                Dim dwD2008(2) As Integer 'MC2 User ID
                dwD2008(0) = ReadValue(8) '6104
                dwD2008(1) = ReadValue(9) '6105
                D2008 = ModbusClient.ConvertRegistersToInt(dwD2008, 0)

                Dim dwD2010(2) As Integer 'MC1 Plan Qty
                dwD2010(0) = ReadValue(10) '6106
                dwD2010(1) = ReadValue(11) '6107
                D2010 = ModbusClient.ConvertRegistersToInt(dwD2010, 0)

                Dim dwD2012(2) As Integer 'MC2 Plan Qty
                dwD2012(0) = ReadValue(12) '6108
                dwD2012(1) = ReadValue(13) '6109
                D2012 = ModbusClient.ConvertRegistersToInt(dwD2012, 0)

                D2014 = ReadValue(14) '6110 MC1 P1CavQty
                D2015 = ReadValue(15) '6111 MC1 P2CavQty
                D2016 = ReadValue(16) '6112 MC2 P1CavQty
                D2017 = ReadValue(17) '6113 MC2 P2CavQty

                D2018 = ReadValue(18) '6114 
                D2019 = ReadValue(19) '6115 
                D2020 = ReadValue(20) '6116 
                D2021 = ReadValue(21) '6117 
                D2022 = ReadValue(22) '6118 
                D2023 = ReadValue(23) '6119 
                D2024 = ReadValue(24) '6120 
                D2025 = ReadValue(25) '6121 
                D2026 = ReadValue(26) '6122 
                D2027 = ReadValue(27) '6123 
                D2028 = ReadValue(28) '6124 
                D2029 = ReadValue(29) '6125 
                D2030 = ReadValue(30) '6126 
                D2031 = ReadValue(31) '6127 
                D2032 = ReadValue(32) '6128
                D2032 = ReadValue(33) '6129 
                D2034 = ReadValue(34) '6130
                D2035 = ReadValue(35) '6131 
                D2036 = ReadValue(36) '6132 
                D2037 = ReadValue(37) '6133
                D2038 = ReadValue(38) '6134 
                D2039 = ReadValue(39) '6135 
                D2040 = ReadValue(40) '6136 
            Catch ex As Exception
                modErrFlag_ReadingHoldingRegistry = True
                MessageBox.Show(ex.Message, "Reading Holding Registers...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_ReadingHoldingRegistry = False

                End If
            End Try
        End If
        'Modbuss address 6096 = D2000 (Delta PLC) and so on for holding registers

    End Sub
    '//

    '// READING COIL REGISTERS (DELTA PLC)
    Public Sub readCoilsRegisters()
        If modErrFlag_ReadingCoilRegistry = False Then
            Try
                'Modbuss address 2048 = M0 (Delta PLC) and so on for Coil registers
                Dim rxCoil() As Boolean = ModClient.ReadCoils(2048, 45)
                RxPLCM0 = rxCoil(0) '2048 MC1 ON/OFF FLAG (TEST INPUT FOR EXTERNAL MACHINE START/STOP OPERATION)
                RxPLCM1 = rxCoil(1) '2049 MC2 ON/OFF FLAG (TEST INPUT FOR EXTERNAL MACHINE START/STOP OPERATION)
                RxPLCM2 = rxCoil(2) '2050
                RxPLCM3 = rxCoil(3) '2051 MC1 KIOSK Login & JO Flag
                RxPLCM4 = rxCoil(4) '2052 MC2 KIOSK Login & JO Flag
                RxPLCM5 = rxCoil(5) '2053
                RxPLCM6 = rxCoil(6) '2054 MC1 Machine Ready (Machine HMI)
                RxPLCM7 = rxCoil(7) '2055 MC2 Machine Ready (Machine HMI)
                RxPLCM8 = rxCoil(8) '2056
                RxPLCM9 = rxCoil(9) '2057 MC1 Bypass
                RxPLCM10 = rxCoil(10) '2058 MC2 Bypass
                RxPLCM11 = rxCoil(11) '2059
                RxPLCM12 = rxCoil(12) '2060 MC1 Test Auto Mode Flag
                RxPLCM13 = rxCoil(13) '2061 MC2 Test Auto Mode Flag
                RxPLCM14 = rxCoil(14) '2062 MC1 Plan Complete
                RxPLCM15 = rxCoil(15) '2063 MC2 Plan Complete
                RxPLCM16 = rxCoil(16) '2064 MC1 Counter InputFlag(x2)
                RxPLCM17 = rxCoil(17) '2065 MC2 Counter InputFlag(x5)
                RxPLCM18 = rxCoil(18) '2066 MC1 Test Auto Mode CounterReached (Machine HMI)
                RxPLCM19 = rxCoil(19) '2067 MC2 Test Auto Mode CounterReached (Machine HMI)
                RxPLCM20 = rxCoil(20) '2068 MC1 QA Stoppage Triggered
                RxPLCM21 = rxCoil(21) '2069 MC2 QA Stoppage Triggered
                RxPLCM22 = rxCoil(22) '2070 MC1 PM Stoppage Triggered
                RxPLCM23 = rxCoil(23) '2071 MC2 PM Stoppage Triggered
                RxPLCM24 = rxCoil(24) '2072 MC1 Tooling Stoppage Triggered
                RxPLCM25 = rxCoil(25) '2073 MC2 Tooling Stoppage Triggered
                RxPLCM26 = rxCoil(26) '2074
                RxPLCM27 = rxCoil(27) '2075
                RxPLCM28 = rxCoil(28) '2076
                RxPLCM29 = rxCoil(29) '2077
                RxPLCM30 = rxCoil(30) '2078
                RxPLCM31 = rxCoil(31) '2079
                RxPLCM32 = rxCoil(32) '2080
                RxPLCM33 = rxCoil(33) '2081
                RxPLCM34 = rxCoil(34) '2082
                RxPLCM35 = rxCoil(35) '2083
                RxPLCM36 = rxCoil(36) '2084
                RxPLCM37 = rxCoil(37) '2085
                RxPLCM38 = rxCoil(38) '2086
                RxPLCM39 = rxCoil(39) '2087
                RxPLCM40 = rxCoil(40) '2088
            Catch ex As Exception
                modErrFlag_ReadingCoilRegistry = True
                MessageBox.Show(ex.Message, "Reading Coil Registers...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_ReadingCoilRegistry = False
                End If
            End Try
        End If

    End Sub
    '//

    '// LOADING THE PLAN QTY FOR MACHINE 1 JO
    Public Sub PlanQuantityLoadMC1()
        If ModClient.Connected = True Then
            If Not stJOQuantityMC1 = Nothing Then
                Dim wrValue As Integer
                wrValue = CInt(stJOQuantityMC1)

                Dim x As Integer()
                x = ModbusClient.ConvertIntToRegisters(wrValue)
                ModClient.WriteSingleRegister(6106, x(0)) 'D2010 MC1 Plan Qty Double Word
                ModClient.WriteSingleRegister(6107, x(1)) 'D2011
            End If
        End If
    End Sub
    '//

    '// LOADING THE PLAN QTY FOR MACHINE 2 JO
    Public Sub PlanQuantityLoadMC2()
        If ModClient.Connected = True Then
            If Not stJOQuantityMC2 = Nothing Then
                Dim wrValue As Integer
                wrValue = CInt(stJOQuantityMC2)

                Dim x As Integer()
                x = ModbusClient.ConvertIntToRegisters(wrValue)
                ModClient.WriteSingleRegister(6108, x(0)) 'D2012 MC2 Plan Qty Double Word
                ModClient.WriteSingleRegister(6109, x(1)) 'D2013
            End If
        End If
    End Sub
    '//

    '// LOADING THE CAVITY QTY FOR MACHINE 1 JOB ORDER
    Public Sub MC1LoadedJOCavQty()
        If ModClient.Connected = True Then
            If stJOMC1 <> "" Then
                Dim wrValue1 As Integer
                Dim wrValue2 As Integer
                wrValue1 = CInt(stJOMoldCavP1MC1)
                wrValue2 = CInt(stJOMoldCavP2MC1)
                ModClient.WriteSingleRegister(6110, wrValue1) 'D2014 MC1 PN1 Cavity Qty
                ModClient.WriteSingleRegister(6111, wrValue2) 'D2015 MC1 PN2 Cavity Qty
            End If
        End If
    End Sub
    '//

    '// LOADING THE CAVITY QTY FOR MACHINE 2 JOB ORDER
    Public Sub MC2LoadedJOCavQty()
        If ModClient.Connected = True Then
            If stJOMC1 <> "" Then
                Dim wrValue1 As Integer
                Dim wrValue2 As Integer
                wrValue1 = CInt(stJOMoldCavP1MC2)
                wrValue2 = CInt(stJOMoldCavP2MC2)
                ModClient.WriteSingleRegister(6112, wrValue1) 'D2016 MC2 PN1 Cavity Qty
                ModClient.WriteSingleRegister(6113, wrValue2) 'D2017 MC2 PN2 Cavity Qty
            End If
        End If
    End Sub
    '//

    '// UNLOADING JO....WRITING ZERO VALUE TO PLC COUNTERS FOR MC1 AND MC2
    Public Sub UnloadJO_PLCCountersTo_0()
        Try
            If ModClient.Connected = True Then
                If stJOMC1 = Nothing Then
                    Dim wrValue As Integer
                    wrValue = 0

                    Dim x As Integer() 'Converting Integer to two separate 16bit/2bytes registers
                    x = ModbusClient.ConvertIntToRegisters(wrValue)
                    ModClient.WriteSingleRegister(6098, x(0)) 'D2002 Machine 1 Counter Double Word
                    ModClient.WriteSingleRegister(6099, x(1)) 'D2003
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unload JO (D2002 = 0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            If ModClient.Connected = True Then
                If stJOMC2 = Nothing Then
                    Dim wrValue As Integer
                    wrValue = 0

                    Dim x As Integer() 'Converting Integer to two separate 16bit/2bytes registers
                    x = ModbusClient.ConvertIntToRegisters(wrValue)
                    ModClient.WriteSingleRegister(6100, x(0)) 'D2004 Machine 2 Counter Double Word
                    ModClient.WriteSingleRegister(6101, x(1)) 'D2005
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unload JO (D2004 = 0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '// CALLING MACHINE TO STOP WHEN QUALITY STOPPAGE IS CREATED 
    Public Sub MachineStop_At_QAStoppage()

        If modQAStopMC1_isTrue = True Then
            If ModClient.Connected = True Then
                ModClient.WriteSingleCoil(2068, True) 'M20 MC1 QA Stoppage Triggered
            End If
        End If

        If modQAStopMC2_isTrue = True Then
            If ModClient.Connected = True Then
                ModClient.WriteSingleCoil(2069, True) 'M21 MC2 QA Stoppage Triggered
            End If
        End If

    End Sub

    'Private Sub lblQAMCStopFlag_TextChanged(sender As Object, e As EventArgs) Handles lblQAMCStopFlag.TextChanged
    '    'MachineStop_At_QAStoppage()
    'End Sub
    '//

    '// RESET THE QUALITY MC STOP FLAG AT MACHINE RUN FOR MC1 AND MC2
    Private Sub lblRxPLCM0_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM0.TextChanged
        If RxPLCM20 = True And RxPLCM0 = False Then
            InsertDowntimeRecordMC1()
        End If
    End Sub
    Private Sub lblRxPLCM1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM1.TextChanged
        If RxPLCM21 = True And RxPLCM1 = False Then
            InsertDowntimeRecordMC2()
        End If
    End Sub
    '//

    '//
    Public Sub InsertDowntimeRecordMC1()
        'MC1
        If modQAStopMC1_isTrue = True Then
            Dim insertDT As New cls001_InsertDowntime_QAStoppage
            insertDT.cls001_ShiftCode = modMC1SVQAStop_stShiftCode
            insertDT.cls001_UserName = modMC1SVQAStop_stUserName
            insertDT.cls001_UserID = modMC1SVQAStop_stUserID
            insertDT.cls001_DTType = modMC1SVQAStop_stDTType
            insertDT.cls001_StartTime = Now()
            insertDT.cls001_DTReason = modMC1SVQAStop_stDTReason
            insertDT.cls001_DTCountermeasure = modMC1SVQAStop_stDTCMeasure
            insertDT.cls001_AckDate = modMC1SVQAStop_stACKDate
            insertDT.cls001_EndTime = modMC1SVQAStop_stEndTime
            insertDT.cls001_RunTime = modMC1SVQAStop_stRunTime
            insertDT.cls001_TtlDTmins = modMC1SVQAStop_iTtlDTMins
            insertDT.cls001_TtlRprtmins = modMC1SVQAStop_iTtlRepTimeMins
            insertDT.cls001_ForQAVeri = modMC1SVQAStop_stForQAVeri
            insertDT.cls001_TtlQAVeriMins = modMC1SVQAStop_iTtlQAVerMins
            insertDT.cls001_TtlFailfreg = modMC1SVQAStop_iTtlFailFeq
            insertDT.cls001_DTStatus = modMC1SVQAStop_stDTStatus
            insertDT.cls001_JOCode = modMC1SVQAStop_stJOCode
            insertDT.cls001_MachineID = modMC1SVQAStop_stMCId
            insertDT.cls001_VeriByQA = modMC1SVQAStop_stVeriByQA
            insertDT.cls001_CreatedBy = modMC1SVQAStop_stCreatedBy
            insertDT.InsertDowntime()

            modQAStopMC1_isTrue = False
            modMC1SVQAStop_stShiftCode = ""
            modMC1SVQAStop_stUserName = ""
            modMC1SVQAStop_stUserID = ""
            modMC1SVQAStop_stDTType = ""
            modMC1SVQAStop_stStartTime = ""
            modMC1SVQAStop_stDTReason = ""
            modMC1SVQAStop_stDTCMeasure = ""
            modMC1SVQAStop_stACKDate = ""
            modMC1SVQAStop_stEndTime = ""
            modMC1SVQAStop_stRunTime = ""
            modMC1SVQAStop_iTtlDTMins = 0
            modMC1SVQAStop_iTtlRepTimeMins = 0
            modMC1SVQAStop_stForQAVeri = ""
            modMC1SVQAStop_iTtlQAVerMins = 0
            modMC1SVQAStop_iTtlFailFeq = 0
            modMC1SVQAStop_stDTStatus = ""
            modMC1SVQAStop_stJOCode = ""
            modMC1SVQAStop_stMCId = ""
            modMC1SVQAStop_stVeriByQA = ""
            modMC1SVQAStop_stCreatedBy = ""
        End If
    End Sub
    Public Sub InsertDowntimeRecordMC2()
        If modQAStopMC2_isTrue = True Then
            Dim insertDT As New cls001_InsertDowntime_QAStoppage
            insertDT.cls001_ShiftCode = modMC2SVQAStop_stShiftCode
            insertDT.cls001_UserName = modMC2SVQAStop_stUserName
            insertDT.cls001_UserID = modMC2SVQAStop_stUserID
            insertDT.cls001_DTType = modMC2SVQAStop_stDTType
            insertDT.cls001_StartTime = Now()
            insertDT.cls001_DTReason = modMC2SVQAStop_stDTReason
            insertDT.cls001_DTCountermeasure = modMC2SVQAStop_stDTCMeasure
            insertDT.cls001_AckDate = modMC2SVQAStop_stACKDate
            insertDT.cls001_EndTime = modMC2SVQAStop_stEndTime
            insertDT.cls001_RunTime = modMC2SVQAStop_stRunTime
            insertDT.cls001_TtlDTmins = modMC2SVQAStop_iTtlDTMins
            insertDT.cls001_TtlRprtmins = modMC2SVQAStop_iTtlRepTimeMins
            insertDT.cls001_ForQAVeri = modMC2SVQAStop_stForQAVeri
            insertDT.cls001_TtlQAVeriMins = modMC2SVQAStop_iTtlQAVerMins
            insertDT.cls001_TtlFailfreg = modMC2SVQAStop_iTtlFailFeq
            insertDT.cls001_DTStatus = modMC2SVQAStop_stDTStatus
            insertDT.cls001_JOCode = modMC2SVQAStop_stJOCode
            insertDT.cls001_MachineID = modMC2SVQAStop_stMCId
            insertDT.cls001_VeriByQA = modMC2SVQAStop_stVeriByQA
            insertDT.cls001_CreatedBy = modMC2SVQAStop_stCreatedBy
            insertDT.InsertDowntime()

            modQAStopMC2_isTrue = False
            modMC2SVQAStop_stShiftCode = ""
            modMC2SVQAStop_stUserName = ""
            modMC2SVQAStop_stUserID = ""
            modMC2SVQAStop_stDTType = ""
            modMC2SVQAStop_stStartTime = ""
            modMC2SVQAStop_stDTReason = ""
            modMC2SVQAStop_stDTCMeasure = ""
            modMC2SVQAStop_stACKDate = ""
            modMC2SVQAStop_stEndTime = ""
            modMC2SVQAStop_stRunTime = ""
            modMC2SVQAStop_iTtlDTMins = 0
            modMC2SVQAStop_iTtlRepTimeMins = 0
            modMC2SVQAStop_stForQAVeri = ""
            modMC2SVQAStop_iTtlQAVerMins = 0
            modMC2SVQAStop_iTtlFailFeq = 0
            modMC2SVQAStop_stDTStatus = ""
            modMC2SVQAStop_stJOCode = ""
            modMC2SVQAStop_stMCId = ""
            modMC2SVQAStop_stVeriByQA = ""
            modMC2SVQAStop_stCreatedBy = ""
        End If
    End Sub
    '//

    '// LOG OUT AND NO JOB ORDER FLAG
    Public Sub LogoutAndNoJOFlag()
        If modMC1Stop_logoutOrNoJO = True Then
            If ModClient.Connected = True Then
                ModClient.WriteSingleCoil(2051, True) '2051 M3 MC1 KIOSK Login & JO Flag
            End If
        Else
            If ModClient.Connected = True Then
                ModClient.WriteSingleCoil(2051, False) '2051 M3 MC1 KIOSK Login & JO Flag
            End If
        End If

        If modMC2Stop_logoutOrNoJO = True Then
            If ModClient.Connected = True Then
                ModClient.WriteSingleCoil(2052, True) '2052 M4 MC1 KIOSK Login & JO Flag
            End If
        Else
            If ModClient.Connected = True Then
                ModClient.WriteSingleCoil(2052, False) '2052 M4 MC1 KIOSK Login & JO Flag
            End If
        End If
    End Sub
    '//

    Public Sub BypassMC()
        'MC1
        If modSysFlagMC1_Bypass_isTrue = True Then
            ModClient.WriteSingleCoil(2057, True) '2057 M9 MC1 BYPASS
        Else
            ModClient.WriteSingleCoil(2057, False) '2057 M9 MC1 BYPASS
        End If
        'MC2
        If modSysFlagMC2_Bypass_isTrue = True Then
            ModClient.WriteSingleCoil(2058, True) '2058 M10 MC2 BYPASS
        Else
            ModClient.WriteSingleCoil(2058, False) '2058 M10 MC2 BYPASS
        End If


    End Sub
End Class
