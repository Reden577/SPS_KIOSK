Public Class cls002_ModBusConnection
    Public cls002_IPAddress As String = "169.254.190.100"
    Public cls002_Port As Integer = 502

    Public Sub ConnectModClient()
        Dim ModClient As New EasyModbus.ModbusClient
        ModClient.IPAddress = cls002_IPAddress
        ModClient.Port = cls002_Port
        ModClient.ConnectionTimeout = 3000
        ModClient.NumberOfRetries = 5

        Try
            ModClient.Connect()
            If ModClient.Connected = True Then
                ComCheck_isTrue = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connecting To PLC Modbus!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmSplashLoading.Close()
        End Try

    End Sub
End Class
