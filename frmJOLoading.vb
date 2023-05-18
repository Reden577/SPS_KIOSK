Imports System.Security.Cryptography
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Windows.Media.Imaging
Imports System.Windows.Controls

Public Class frmJOLoading
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PartNoMasterList.MListPartNumber' table. You can move, or remove it, as needed.
        'Me.MListPartNumberTableAdapter.Fill(Me.PartNoMasterList.MListPartNumber)
        'TODO: This line of code loads data into the 'NewJOMasterList.MListNewJobOrder' table. You can move, or remove it, as needed.
        Me.MListNewJobOrderTableAdapter.Fill(Me.NewJOMasterList.MListNewJobOrder)
        dgvJO.ClearSelection()

        lblDGVMoldID.Text = "-"
        Me.CenterToScreen()
        btnJOLoadBtn2Click.Enabled = False
        'DeserializeJSON()
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
        lblDGVJOCode.Text = dgvJO.CurrentRow.Cells(2).Value.ToString
        lblDGVMoldID.Text = dgvJO.CurrentRow.Cells(3).Value.ToString
        lblDGVJOPlanQty.Text = dgvJO.CurrentRow.Cells(4).Value.ToString
        lblDGVMachineId.Text = dgvJO.CurrentRow.Cells(5).Value.ToString
    End Sub
    Private Sub lblDGVMachineId_TextChanged(sender As Object, e As EventArgs) Handles lblDGVMachineId.TextChanged
        If (lblDGVMoldID.Text <> "-" And lblDGVMoldID.Text <> "") _
            And (lblDGVMachineId.Text <> "-" And lblDGVMachineId.Text <> "") Then
            btnJOLoadBtn2Click.Enabled = True
        Else
            btnJOLoadBtn2Click.Enabled = False
        End If
    End Sub

    '// SAMPLE WORKABLE FETCHING OG API DATA TO DATAGRIDVIEW DISPLAY (DESERIALIZED JSON)
    Public Sub DeserializeJSON()
        Dim uriString As String = "https://jsonplaceholder.typicode.com/posts"
        Dim uri As New Uri(uriString)

        'make HTTP request
        Dim Request As HttpWebRequest = HttpWebRequest.Create(uri)
        Request.Method = "GET"

        'get HTTP response
        Dim Response As HttpWebResponse = Request.GetResponse()

        'read HTTP response
        Dim Read = New StreamReader(Response.GetResponseStream)
        Dim Raw As String = Read.ReadToEnd()

        'convert the response to a dictionary
        'Dim model As Rootobject = .Deserialize(Of Rootboject)(Raw)
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)

        For Each item As Object In dict
            dgvAPI.Rows.Add(item("userId").ToString, item("id").ToString, item("title"), item("body").ToString)
        Next
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
            PreLoadedJobOrderDetails()
            preLDJODetail_Confirm = True
        End If

    End Sub
    '//
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        JOLoadConfirm()
    End Sub


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

    Public Sub SelectJOCode_At_JOLoadedDetails()

    End Sub


End Class