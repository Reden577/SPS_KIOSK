Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates
Imports EasyModbus
Imports FontAwesome.Sharp
Imports System.IO.Ports
Imports System.Windows.Controls

Public Class frmSetting1

    Dim ModCLient As New EasyModbus.ModbusClient
    Private Sub frmSetting1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ConnectToModbus()
        readCoilsRegisters()
        Connect_Disconnect_Btn_EnableDisable()
    End Sub
    Private Sub frmSetting1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Public Sub ConnectToModbus()
        ModCLient.IPAddress = txtIP.Text
        ModCLient.Port = txtPort.Text
        ModCLient.ConnectionTimeout = 3000
        ModCLient.NumberOfRetries = 5

        Try
            ModCLient.Connect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If ModCLient.Connected = True Then
            lblSatus.Text = "Connected!"
            lblSatus.Update()
        Else
            lblSatus.Text = "Disconnected!"
            lblSatus.Update()
        End If
    End Sub

    Public Sub DisconnetFromModbus()
        ModCLient.Disconnect()
    End Sub

    Public Sub Connect_Disconnect_Btn_EnableDisable()
        If ModCLient.Connected = True Then
            btnConnect.Enabled = False
            btnDisconnect.Enabled = True
        Else
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
        End If
    End Sub

    'No use
    Public Sub ReadHoldingRegs()
        'Modbuss address 6096 = D2000 (Delta PLC) and so on for holding registers
        Try
            Dim ReadValue() As Integer = ModCLient.ReadHoldingRegisters(6096, 100)
            lblRx0.Text = ReadValue(0) '6096
            ComCheck = lblRx0.Text

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

            'Dim dwD2014(2) As Integer 'MC1 Actual Qty
            'dwD2014(0) = ReadValue(14) '6110
            'dwD2014(1) = ReadValue(15) '6111
            'D2014 = ModbusClient.ConvertRegistersToInt(dwD2014, 0)

            D2014 = ReadValue(14) '6110 MC1 P1CavQty
            D2015 = ReadValue(15) '6111 MC1 P2CavQty

            'Dim dwD2016(2) As Integer 'MC2 Actual Qty
            'dwD2016(0) = ReadValue(16) '6112
            'dwD2016(1) = ReadValue(17) '6113
            'D2016 = ModbusClient.ConvertRegistersToInt(dwD2016, 0)

            D2016 = ReadValue(16) '6112 MC2 P1CavQty
            D2017 = ReadValue(17) '6113 MC2 P2CavQty

            D2018 = ReadValue(18) '6114 MC1JOCode1
            D2019 = ReadValue(19) '6115 MC1JOCode2
            D2020 = ReadValue(20) '6116 MC1JOCode3
            D2021 = ReadValue(21) '6117 MC1JOCode4
            D2022 = ReadValue(22) '6118 MC1JOCode5
            D2023 = ReadValue(23) '6119 MC1JOCode6
            D2024 = ReadValue(24) '6120 EMPTY
            D2025 = ReadValue(25) '6121 MC2JOCode1
            D2026 = ReadValue(26) '6122 MC2JOCode2
            D2027 = ReadValue(27) '6123 MC2JOCode3
            D2028 = ReadValue(28) '6124 MC2JOCode4
            D2029 = ReadValue(29) '6125 MC2JOCode5
            D2030 = ReadValue(30) '6126 MC2JOCode6
            D2031 = ReadValue(31) '6127 EMPTY

            Dim dwD2032(2) As Integer 'MC1 Total Actual Qty
            dwD2032(0) = ReadValue(32) '6128
            dwD2032(1) = ReadValue(33) '6129 
            D2032 = ModbusClient.ConvertRegistersToInt(dwD2032, 0)

            Dim dwD2034(2) As Integer 'MC2 Total Actual Qty
            dwD2034(0) = ReadValue(34) '6130
            dwD2034(1) = ReadValue(35) '6131 
            D2034 = ModbusClient.ConvertRegistersToInt(dwD2034, 0)

            D2036 = ReadValue(36) '6132 
            D2037 = ReadValue(37) '6133
            D2038 = ReadValue(38) '6134 
            D2039 = ReadValue(39) '6135 
            D2040 = ReadValue(40) '6136 

            'lblRx4.Text = (ReadValue(5) + ReadValue(4)) * 65535.0F
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'No Use
    'Public Sub comCheckWriteHoldingRegisterTo1()
    '    Try
    '        ModCLient.WriteSingleRegister(4096, 1)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    ''No Use
    'Public Sub comCheckWriteHoldingRegisterTo0()
    '    Try
    '        ModCLient.WriteSingleRegister(4096, 0)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Public Sub readCoilsRegisters()
        Try
            'Modbuss address 2048 = M0 (Delta PLC) and so on for Coil registers
            Dim rxCoil() As Boolean = ModCLient.ReadCoils(2048, 45)
            RxPLCM0 = rxCoil(0) '2048 MC1 ON/OFF FLAG (TEST INPUT FOR EXTERNAL MACHINE START/STOP OPERATION)
            RxPLCM1 = rxCoil(1) '2049 MC2 ON/OFF FLAG (TEST INPUT FOR EXTERNAL MACHINE START/STOP OPERATION)
            RxPLCM2 = rxCoil(2) '2050
            RxPLCM3 = rxCoil(3) '2051 MC1 KIOSK Login & JO Flag
            RxPLCM4 = rxCoil(4) '2052 MC2 KIOSK Login & JO Flag
            RxPLCM5 = rxCoil(5) '2053
            RxPLCM6 = rxCoil(6) '2054 MC1 Machine Ready (Machine HMI)
            RxPLCM7 = rxCoil(7) '2055 MC2 Machine Ready (Machine HMI)
            RxPLCM8 = rxCoil(8) '2056
            RxPLCM9 = rxCoil(9) '2057 MC1 KIOSK CONDITION TRIGGERED Flag
            RxPLCM10 = rxCoil(10) '2058 MC2 KIOSK CONDITION TRIGGERD Flag
            RxPLCM11 = rxCoil(11) '2059
            RxPLCM12 = rxCoil(12) '2060 MC1 Test Auto Mode Flag (Machine HMI)
            RxPLCM13 = rxCoil(13) '2061 MC2 Test Auto Mode Flag (Machine HMI)
            RxPLCM14 = rxCoil(14) '2062 MC1 Plan Complete
            RxPLCM15 = rxCoil(15) '2063 MC2 Plan Complete
            RxPLCM16 = rxCoil(16) '2064
            RxPLCM17 = rxCoil(17) '2065
            RxPLCM18 = rxCoil(18) '2066
            RxPLCM19 = rxCoil(19) '2067
            RxPLCM20 = rxCoil(20) '2068
            RxPLCM21 = rxCoil(21) '2069
            RxPLCM22 = rxCoil(22) '2070
            RxPLCM23 = rxCoil(23) '2071
            RxPLCM24 = rxCoil(24) '2072
            RxPLCM25 = rxCoil(25) '2073
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
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ConnectToModbus()
        Connect_Disconnect_Btn_EnableDisable()
        'btnMCRunStopEndable()
        'btnMCRunStopStatusCheck()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        DisconnetFromModbus()
        Connect_Disconnect_Btn_EnableDisable()
        'btnMCRunStopDisable()
        'btnMCRunStopStatusCheck()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRealtimeCheck.Tick
        If ModCLient.Connected = True Then
            ReadHoldingRegs()
            readCoilsRegisters()
            JOProgressUpdate()
            userLoggedInFlag()
            'JOLoadedFlag()
            JOCodeSplitMC1()
            JOCodeSplitMC2()
            UserIDLoadMC1()
            UserIDLoadMC2()
            PlanQuantityLoadMC1()
            PlanQuantityLoadMC2()
            'TotalQuantityLoadMC1()
            'TotalQuantityLoadMC2()
            UnloadJO_PLCCountersTo_0()
            MC1LoadedJOCavQty()
            MC2LoadedJOCavQty()
        End If
    End Sub

    Private Sub timCom_Tick(sender As Object, e As EventArgs) Handles tmrComCheck.Tick
        'If ModCLient.Connected = True And lblRx0.Text = "0" Then
        '    comCheckWriteHoldingRegisterTo1()
        'ElseIf ModCLient.Connected = True And lblRx0.Text <> "0" Then
        '    comCheckWriteHoldingRegisterTo0()
        'End If
    End Sub

    'JOB ORDER PROGRESS UPDATE COMPLETE OR IN PROGRESS
    Public Sub JOProgressUpdate()
        If ModCLient.Connected = True Then
            lblJOProgressMC1.Text = PlanCompleteMC1
            lblJOProgressMC2.Text = PlanCompleteMC2
            lblJOProgressMC3.Text = PlanCompleteMC3
            lblJOProgressMC4.Text = PlanCompleteMC4
            lblJOProgressMC5.Text = PlanCompleteMC5
            lblJOProgressMC6.Text = PlanCompleteMC6
            lblJOProgressMC7.Text = PlanCompleteMC7
            lblJOProgressMC8.Text = PlanCompleteMC8
            lblJOProgressMC9.Text = PlanCompleteMC9
            lblJOProgressMC10.Text = PlanCompleteMC10
            lblJOProgressMC11.Text = PlanCompleteMC11
            lblJOProgressMC12.Text = PlanCompleteMC12
            lblJOProgressMC13.Text = PlanCompleteMC13
            lblJOProgressMC14.Text = PlanCompleteMC14

            'If lblJOProgressMC1.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2048, False) 'TRIGGERING OFF M0 OF DELTA PLC
            '    ModCLient.WriteSingleCoil(2083, True) 'TRIGGERING ON M35 OF DELTA PLC
            'Else
            '    ModCLient.WriteSingleCoil(2083, False) 'TRIGGERING ON M35 OF DELTA PLC
            'End If
            'If lblJOProgressMC2.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2049, False) 'TRIGGERING OFF M1 OF DELTA PLC
            '    ModCLient.WriteSingleCoil(2084, True) 'TRIGGERING ON M36 OF DELTA PLC
            'Else
            '    ModCLient.WriteSingleCoil(2084, False) 'TRIGGERING ON M36 OF DELTA PLC
            'End If
            'If lblJOProgressMC3.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2050, False)
            'End If
            'If lblJOProgressMC4.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2051, False)
            'End If
            'If lblJOProgressMC5.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2052, False)
            'End If
            'If lblJOProgressMC6.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2053, False)
            'End If
            'If lblJOProgressMC7.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2054, False)
            'End If
            'If lblJOProgressMC8.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2055, False)
            'End If
            'If lblJOProgressMC9.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2056, False)
            'End If
            'If lblJOProgressMC10.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2057, False)
            'End If
            'If lblJOProgressMC11.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2058, False)
            'End If
            'If lblJOProgressMC12.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2059, False)
            'End If
            'If lblJOProgressMC13.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2060, False)
            'End If
            'If lblJOProgressMC14.Text = "True" Then
            '    ModCLient.WriteSingleCoil(2061, False)
            'End If
        End If
    End Sub

    'WRITING TO COIL DEVICES OF THE PLC DURING LOGGEDIN CONFIRMED
    Public Sub userLoggedInFlag()
        If ModCLient.Connected = True Then
            If modMCStopConditionTriggered = False Then
                ModCLient.WriteSingleCoil(2051, True) 'TRIGGERING ON M3 OF DELTA PLC 
            Else
                ModCLient.WriteSingleCoil(2051, False) 'TRIGGERING OFF M3 OF DELTA PLC
            End If
            If modUserLoginFlagMC2 = True Then
                ModCLient.WriteSingleCoil(2052, True) 'TRIGGERING ON M4 OF DELTA PLC
            Else
                ModCLient.WriteSingleCoil(2052, False) 'TRIGGERING OFF M4 OF DELTA PLC
            End If
        End If
    End Sub

    'WRITING TO COIL DEVICE OF THE PLC DURING JOB ORDER LOADED CONFIRM
    'Public Sub JOLoadedFlag()
    '    If ModCLient.Connected = True Then
    '        If modJOLoadedFlagMC1 = True Then
    '            ModCLient.WriteSingleCoil(2054, True) 'TRIGGERING ON M9 OF DELTA PLC
    '        Else
    '            ModCLient.WriteSingleCoil(2054, False) 'TRIGGERING OFF M9 OF DELTA PLC
    '        End If
    '        If modJOLoadedFlagMC1 = True Then
    '            ModCLient.WriteSingleCoil(2055, True) 'TRIGGERING ON M10 OF DELTA PLC
    '        Else
    '            ModCLient.WriteSingleCoil(2055, False) 'TRIGGERING OFF M10 OF DELTA PLC
    '        End If
    '    End If
    'End Sub

    'READABLE VALUE FOR PLC
    Public Sub JOCodeSplitMC1()
        If ModCLient.Connected = True Then
            If Not stJOMC1 = Nothing Then
                Dim arJOMC1 As Array
                arJOMC1 = Split(stJOMC1, "/")
                'ModCLient.WriteSingleRegister(6114, CInt(arJOMC1(0))) 'D2018
                ModCLient.WriteSingleRegister(6115, CInt(arJOMC1(1))) 'D2019
                ModCLient.WriteSingleRegister(6116, CInt(arJOMC1(2))) 'D2020
                ModCLient.WriteSingleRegister(6117, CInt(arJOMC1(3))) 'D2021
            End If
        End If
    End Sub
    Public Sub JOCodeSplitMC2()
        If ModCLient.Connected = True Then
            If Not stJOMC2 = Nothing Then
                Dim arJOMC2 As Array
                arJOMC2 = Split(stJOMC2, "/")
                'ModCLient.WriteSingleRegister(6121, CInt(arJOMC2(0))) 'D2025
                ModCLient.WriteSingleRegister(6122, CInt(arJOMC2(1))) 'D2026
                ModCLient.WriteSingleRegister(6123, CInt(arJOMC2(2))) 'D2027
                ModCLient.WriteSingleRegister(6124, CInt(arJOMC2(3))) 'D2028
            End If
        End If
    End Sub
    Public Sub UserIDLoadMC1()
        If ModCLient.Connected = True Then
            If Not UNIdmc1 = Nothing Then
                Dim wrValue As Integer
                wrValue = CInt(UNIdmc1)

                Dim x As Integer()
                x = ModbusClient.ConvertIntToRegisters(wrValue)
                ModCLient.WriteSingleRegister(6102, x(0))
                ModCLient.WriteSingleRegister(6103, x(1))
            End If
        End If
    End Sub
    Public Sub UserIDLoadMC2()
        If ModCLient.Connected = True Then
            If Not UNIdmc2 = Nothing Then
                Dim wrValue As Integer
                wrValue = CInt(UNIdmc2)

                Dim x As Integer()
                x = ModbusClient.ConvertIntToRegisters(wrValue)
                ModCLient.WriteSingleRegister(6104, x(0))
                ModCLient.WriteSingleRegister(6105, x(1))
            End If
        End If
    End Sub

    Public Sub PlanQuantityLoadMC1()
        If ModCLient.Connected = True Then
            If Not stJOQuantityMC1 = Nothing Then
                Dim wrValue As Integer
                wrValue = CInt(stJOQuantityMC1)

                Dim x As Integer()
                x = ModbusClient.ConvertIntToRegisters(wrValue)
                ModCLient.WriteSingleRegister(6106, x(0))
                ModCLient.WriteSingleRegister(6107, x(1))
            End If
        End If
    End Sub

    Public Sub PlanQuantityLoadMC2()
        If ModCLient.Connected = True Then
            If Not stJOQuantityMC2 = Nothing Then
                Dim wrValue As Integer
                wrValue = CInt(stJOQuantityMC2)

                Dim x As Integer()
                x = ModbusClient.ConvertIntToRegisters(wrValue)
                ModCLient.WriteSingleRegister(6108, x(0))
                ModCLient.WriteSingleRegister(6109, x(1))
            End If
        End If
    End Sub

    'Public Sub TotalQuantityLoadMC1()
    '    If ModCLient.Connected = True Then
    '        If Not TotalCountMC1 = Nothing Then
    '            Dim wrValue As Integer
    '            wrValue = CInt(TotalCountMC1)

    '            Dim x As Integer()
    '            x = ModbusClient.ConvertIntToRegisters(wrValue)
    '            ModCLient.WriteSingleRegister(6128, x(0))
    '            ModCLient.WriteSingleRegister(6129, x(1))
    '        End If
    '    End If
    'End Sub

    'Public Sub TotalQuantityLoadMC2()
    '    If ModCLient.Connected = True Then
    '        If Not TotalCountMC2 = Nothing Then
    '            Dim wrValue As Integer
    '            wrValue = CInt(TotalCountMC2)

    '            Dim x As Integer()
    '            x = ModbusClient.ConvertIntToRegisters(wrValue)
    '            ModCLient.WriteSingleRegister(6130, x(0))
    '            ModCLient.WriteSingleRegister(6131, x(1))
    '        End If
    '    End If
    'End Sub
    '//


    '// LOADING THE CAVITY QTY FOR MACHINE 1 JOB ORDER
    Public Sub MC1LoadedJOCavQty()
        If ModCLient.Connected = True Then
            If stJOMC1 IsNot Nothing Then
                Dim wrValue1 As Integer
                Dim wrValue2 As Integer
                wrValue1 = CInt(stJOMoldCavP1MC1)
                wrValue2 = CInt(stJOMoldCavP2MC1)
                ModCLient.WriteSingleRegister(6110, wrValue1) 'D2014
                ModCLient.WriteSingleRegister(6111, wrValue2) 'D2015
            End If
        End If
    End Sub
    '//

    '// LOADING THE CAVITY QTY FOR MACHINE 2 JOB ORDER
    Public Sub MC2LoadedJOCavQty()
        If ModCLient.Connected = True Then
            If stJOMC1 IsNot Nothing Then
                Dim wrValue1 As Integer
                Dim wrValue2 As Integer
                wrValue1 = CInt(stJOMoldCavP1MC2)
                wrValue2 = CInt(stJOMoldCavP2MC2)
                ModCLient.WriteSingleRegister(6112, wrValue1) 'D2016
                ModCLient.WriteSingleRegister(6113, wrValue2) 'D2017
            End If
        End If
    End Sub
    '//

    '// UNLOADING JO....WRITING ZERO VALUE TO PLC COUNTERS
    Public Sub UnloadJO_PLCCountersTo_0()
        Try
            If ModCLient.Connected = True Then
                If stJOMC1 = Nothing Then
                    Dim wrValue As Integer
                    wrValue = 0

                    Dim x As Integer() 'Converting Integer to two separate 16bit/2bytes registers
                    x = ModbusClient.ConvertIntToRegisters(wrValue)
                    ModCLient.WriteSingleRegister(6098, x(0)) 'D2002
                    ModCLient.WriteSingleRegister(6099, x(1)) 'D2003
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unload JO (D2002 = 0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            If ModCLient.Connected = True Then
                If stJOMC2 = Nothing Then
                    Dim wrValue As Integer
                    wrValue = 0

                    Dim x As Integer() 'Converting Integer to two separate 16bit/2bytes registers
                    x = ModbusClient.ConvertIntToRegisters(wrValue)
                    ModCLient.WriteSingleRegister(6100, x(0)) 'D2004
                    ModCLient.WriteSingleRegister(6101, x(1)) 'D2005
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unload JO (D2004 = 0)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class