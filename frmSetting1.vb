
Public Class frmSetting1

    Dim ModCLient As New EasyModbus.ModbusClient
    Private Sub frmSetting1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewJOMasterList.MListNewJobOrder' table. You can move, or remove it, as needed.
        Me.MListNewJobOrderTableAdapter.Fill(Me.NewJOMasterList.MListNewJobOrder)
        'TODO: This line of code loads data into the 'SPSDataSet2.Sample' table. You can move, or remove it, as needed.
        Me.SampleTableAdapter.Fill(Me.SPSDataSet2.Sample)
        Me.CenterToScreen()

        txtSQLPath.Text = My.Settings.SQLPath

        txtIP.Text = My.Settings.IPAddress
        txtPort.Text = My.Settings.Port
    End Sub
    Private Sub frmSetting1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.SQLPath = txtSQLPath.Text
        My.Settings.IPAddress = txtIP.Text
        My.Settings.Port = txtPort.Text
        My.Settings.Save()
        MessageBox.Show("Settings Saved to My.Settings Complete!", "Saving Settings to My.Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class