Imports System.Security.Cryptography
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Windows.Media.Imaging
Imports System.Windows.Controls
Imports System.Data.SqlClient
Imports Newtonsoft.Json
Imports SPSApp1.clsJOAPI

Public Class frmJOLoading

    Dim LoggedAndLoaded As Boolean
    Dim McLogged As String
    Dim McSelected As Boolean

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MListNewJobOrder_1.MListNewJobOrder' table. You can move, or remove it, as needed.
        'Me.MListNewJobOrderTableAdapter1.FillByLoadStat(Me.MListNewJobOrder_1.MListNewJobOrder, "Not Loaded")
        'dgvJO.ClearSelection()

        lblDGVMoldID.Text = "-"
        Me.CenterToScreen()
        btnJOLoadBtn2Click.Enabled = False
        DeserializeJSON()
        dgvAPI.ClearSelection()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnJOLoadBtn2Click.Click
        If lblDGVMoldID.Text <> "-" And lblDGVMoldID.Text <> "" Then
            JOLoadBtn2Click = True
            frmJOUserVerification.Show()
        End If

    End Sub
    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvJO.ClearSelection()
        lblDGVMachineId.Text = "-"
        lblDGVJOCode.Text = "-"
        lblDGVMoldID.Text = "-"
        lblDGVJOPlanQty.Text = "-"
    End Sub

    Private Sub dgvJO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJO.CellContentClick
        'lblDGVJOCode.Text = dgvJO.CurrentRow.Cells(2).Value.ToString
        'lblDGVMoldID.Text = dgvJO.CurrentRow.Cells(3).Value.ToString
        'lblDGVJOPlanQty.Text = dgvJO.CurrentRow.Cells(4).Value.ToString
        'lblDGVMachineId.Text = dgvJO.CurrentRow.Cells(5).Value.ToString
        LoggedAndLoaded = False
        'CompareJOCode_Vs_JOCodeLoadedDetails()
        compareMCLogged_VS_MCSelected()
    End Sub
    Private Sub lblDGVMachineId_TextChanged(sender As Object, e As EventArgs) Handles lblDGVMachineId.TextChanged
        'If (lblDGVMoldID.Text <> "-" And lblDGVMoldID.Text <> "") _
        '    And (lblDGVMachineId.Text <> "-" And lblDGVMachineId.Text <> "") Then
        '    btnJOLoadBtn2Click.Enabled = True
        'Else
        '    btnJOLoadBtn2Click.Enabled = False
        'End If

    End Sub

    '// DESERIALIZING JSON API (JOB ORDER SOURCE FORM ARC-STONE)
    Public Sub DeserializeJSON()
        Dim uriString As String = "http://192.168.8.78/arc.flow.PRD/workflows/custom/sps-integration"
        Dim uri As New Uri(uriString)

        'make HTTP request
        Dim Request As HttpWebRequest = HttpWebRequest.Create(uri)
        Request.Method = "GET"

        'get HTTP response
        Dim Response As HttpWebResponse = Request.GetResponse()

        'read HTTP response
        Dim Read = New StreamReader(Response.GetResponseStream)

        Dim Raw As String = Read.ReadToEnd()
        RichTextBox1.Text = Raw

        Dim json As String = RichTextBox1.Text
        Dim data = JsonConvert.DeserializeObject(Of JSON_JobOrder)(json)
        dgvAPI.DataSource = data.Result
    End Sub
    '//

    '// PRELOADING INFORMATIONS/DATA BASED ON THE GIVEN JOB ORDER
    Public Sub PreLoadedJobOrderDetails()
        'preLDJODetail_ShifCode = ""
        preLDJODetail_JOCode = lblDGVJOCode.Text
        preLDJODetail_MachineId = lblDGVMachineId.Text
        preLDJODetail_MoldId = lblDGVMoldID.Text
        preLDJODetail_PlanQty = lblDGVJOPlanQty.Text
        'preLDJODetail_StartTime = ""
        preLDJODetail_LoadedBy = stJOLoadedBy
        getPartNoDetails()
    End Sub
    '//

    '// GETTING THE PART NUMBER DETAILS ACCORDINT TO THE MOLD ID FROM JOB ORDER
    Public Sub getPartNoDetails()
        Dim sel As New clsSelectAllPartNOMList
        sel.SelectMoldIdDetails(lblDGVMoldID.Text)
        preLDJODetail_PN1 = sel.PN1
        preLDJODetail_PN2 = sel.PN2
        preLDJODetail_CavPN1 = sel.CavPN1
        preLDJODetail_CavPN2 = sel.cavPN2
        preLDJODetail_CycleTime = sel.CycleTime
        'preLDJODetail_MachineId = sel.AllowedMC
    End Sub
    '//

    '// PRE LOADED DATA CONFIRMATION
    Public Sub JOLoadConfirm()
        If bolJOLoadConfirm = True Then
            updatedMListNewJobOrder()
            PreLoadedJobOrderDetails()
            preLDJODetail_Confirm = True
            refreshDGV()
        End If
    End Sub
    '//

    '// REFRESH DGV DATA
    Public Sub refreshDGV()
        Me.MListNewJobOrderTableAdapter1.FillByLoadStat(Me.MListNewJobOrder_1.MListNewJobOrder, "Not Loaded")
    End Sub
    '//

    '// REAL TIME STATUS CHECK TIMER
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        JOLoadConfirm()
    End Sub
    '//

    Private Sub dgvJO_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJO.CellValueChanged
        If e.RowIndex < 0 Then Return
        Dim isChecked As Boolean = CBool(dgvJO.Rows(e.RowIndex).Cells(0).Value)
        Dim rowIndx As Integer = e.RowIndex
        Dim mcNO As String
        If isChecked Then
            mcNO = dgvJO.CurrentRow.Cells(5).Value.ToString
            ListBox1.Items.Add(mcNO)
        End If
    End Sub
    Private Sub dgvJO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJO.CellClick

    End Sub

    'Public Sub CompareJOCode_Vs_JOCodeLoadedDetails()
    '    Dim compareJO As New clsSelectAllJODetails_byJOcode
    '    compareJO.JOCode = lblDGVJOCode.Text
    '    compareJO.MachineID = ""
    '    compareJO.CompareIFJoCodeAlreadyLogged()
    '    If compareJO.isLogged = True And compareJO.LoadStat = "Loaded" Then
    '        btnJOLoadBtn2Click.Enabled = False
    '        MessageBox.Show("This Job Order was already loaded to " & compareJO.getMachineID & "!" _
    '                        & vbNewLine & "PLease choose another Job Order!", "Checking Job Order Loaded Status..." _
    '                                                                          , MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        LoggedAndLoaded = True
    '    ElseIf compareJO.isLogged = True And compareJO.LoadStat = "Unloaded" Then
    '        btnJOLoadBtn2Click.Enabled = False
    '        MessageBox.Show("This Job Order has been " & compareJO.LoadStat & " with " & compareJO.ProdnStat & " Production Status!" _
    '                        & vbNewLine & "PLease choose another Job Order!", "Checking Job Order Loaded Status..." _
    '                                                                          , MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        btnJOLoadBtn2Click.Enabled = True
    '    End If
    'End Sub

    Public Sub compareMCLogged_VS_MCSelected()
        Try
            'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
            Dim sqlcmd As String = "Select [Machine_ID] from [Production].[JOLoadedDetails] where [Machine_ID] = '" + lblDGVMachineId.Text + "' AND [Load_Stats] = 'Loaded' "
            Dim con As New SqlConnection(modSetVal_SqlPath)
            Using cmd As SqlCommand = New SqlCommand(sqlcmd, con)
                con.Open()
                McLogged = cmd.ExecuteScalar()
                con.Close()
            End Using

            If McLogged = lblDGVMachineId.Text Then
                btnJOLoadBtn2Click.Enabled = False
                MessageBox.Show("This " & McLogged & " is Busy Processing Loaded Job Order!" _
                                & vbNewLine & "PLease choose different Job Order with different Machine ID!", "Checking Machine Availability..." _
                                                                                   , MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                btnJOLoadBtn2Click.Enabled = True
            End If
        Catch ex As Exception
            If ex.Message IsNot Nothing Then
                Exit Sub
            End If
        End Try

    End Sub

    Public Sub updatedMListNewJobOrder()
        Dim upd8 As New clsUpdateMListNewJobOrder
        upd8.JOCode = lblDGVJOCode.Text
        upd8.LoadStat = "Loaded"
        upd8.updateLoadStat()
    End Sub

    Private Sub dgvAPI_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAPI.CellContentClick
        lblDGVJOCode.Text = dgvAPI.CurrentRow.Cells(0).Value.ToString
        lblDGVJOPlanQty.Text = dgvAPI.CurrentRow.Cells(1).Value.ToString
        lblDGVMoldID.Text = dgvAPI.CurrentRow.Cells(2).Value.ToString
        lblDGVMachineId.Text = dgvAPI.CurrentRow.Cells(3).Value.ToString
    End Sub
End Class