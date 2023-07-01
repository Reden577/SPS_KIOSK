Imports System.Xml
Imports FontAwesome.Sharp
Imports System.IO
Imports Newtonsoft.Json
Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles
Imports System.Web
Imports System.Data.SqlClient

Public Class frmHome

    Dim JOStatusMC1 As String
    Dim JOStatusMC2 As String
    Dim JOStatusMC3 As String
    Dim JOStatusMC4 As String
    Dim JOStatusMC5 As String
    Dim JOStatusMC6 As String
    Dim JOStatusMC7 As String
    Dim JOStatusMC8 As String
    Dim JOStatusMC9 As String
    Dim JOStatusMC10 As String
    Dim JOStatusMC11 As String
    Dim JOStatusMC12 As String
    Dim JOStatusMC13 As String
    Dim JOStatusMC14 As String



    '// FORM LOAD SUB
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMysetting()
        JOLoadDetails()
        Counters()
        MCStatusPIC()
        PPT()
        ckbBtnVisibleFalse()
        'UpdateUserLogin_ClearLoginDetails()
        lblLogiLogNote.Text = ""
    End Sub
    '//


    '// SAVING DATA TO MY.SETTING WHEN FORM CLOSING (FROM CLOSING SUB)
    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        UpdateUserLogin_ClearLoginDetails()
        My.Settings.JOCodeMC1 = stJOMC1
        My.Settings.JOCodeMC2 = stJOMC2
        My.Settings.JOCodeMC3 = stJOMC4
        My.Settings.JOCodeMC4 = stJOMC4
        My.Settings.JOCodeMC5 = stJOMC5
        My.Settings.JOCodeMC6 = stJOMC6
        My.Settings.JOCodeMC7 = stJOMC7
        My.Settings.JOCodeMC8 = stJOMC8
        My.Settings.JOCodeMC9 = stJOMC9
        My.Settings.JOCodeMC10 = stJOMC10
        My.Settings.JOCodeMC11 = stJOMC11
        My.Settings.JOCodeMC12 = stJOMC12
        My.Settings.JOCodeMC13 = stJOMC13
        My.Settings.JOCodeMC14 = stJOMC14
        My.Settings.JOCodeMC15 = stJOMC15
        My.Settings.JOCodeMC16 = stJOMC16
        My.Settings.JOCodeMC17 = stJOMC17
        My.Settings.JOCodeMC18 = stJOMC18
        My.Settings.JOCodeMC19 = stJOMC19

        My.Settings.MoldNoMC1 = stJOMoldIDMC1
        My.Settings.MoldNoMC2 = stJOMoldIDMC2
        My.Settings.MoldNoMC3 = stJOMoldIDMC3
        My.Settings.MoldNoMC4 = stJOMoldIDMC4
        My.Settings.MoldNoMC5 = stJOMoldIDMC5
        My.Settings.MoldNoMC6 = stJOMoldIDMC6
        My.Settings.MoldNoMC7 = stJOMoldIDMC7
        My.Settings.MoldNoMC8 = stJOMoldIDMC8
        My.Settings.MoldNoMC9 = stJOMoldIDMC9
        My.Settings.MoldNoMC10 = stJOMoldIDMC10
        My.Settings.MoldNoMC11 = stJOMoldIDMC11
        My.Settings.MoldNoMC12 = stJOMoldIDMC12
        My.Settings.MoldNoMC13 = stJOMoldIDMC13
        My.Settings.MoldNoMC14 = stJOMoldIDMC14
        My.Settings.MoldNoMC15 = stJOMoldIDMC15
        My.Settings.MoldNoMC16 = stJOMoldIDMC16
        My.Settings.MoldNoMC17 = stJOMoldIDMC17
        My.Settings.MoldNoMC18 = stJOMoldIDMC18
        My.Settings.MoldNoMC18 = stJOMoldIDMC19



        My.Settings.CycleTimeMC1 = stJOCycleTimeMC1
        My.Settings.CycleTimeMC2 = stJOCycleTimeMC2
        My.Settings.CycleTimeMC3 = stJOCycleTimeMC3
        My.Settings.CycleTimeMC4 = stJOCycleTimeMC4
        My.Settings.CycleTimeMC5 = stJOCycleTimeMC5
        My.Settings.CycleTimeMC6 = stJOCycleTimeMC6
        My.Settings.CycleTimeMC7 = stJOCycleTimeMC7
        My.Settings.CycleTimeMC8 = stJOCycleTimeMC8
        My.Settings.CycleTimeMC9 = stJOCycleTimeMC9
        My.Settings.CycleTimeMC10 = stJOCycleTimeMC10
        My.Settings.CycleTimeMC11 = stJOCycleTimeMC11
        My.Settings.CycleTimeMC12 = stJOCycleTimeMC12
        My.Settings.CycleTimeMC13 = stJOCycleTimeMC13
        My.Settings.CycleTimeMC14 = stJOCycleTimeMC14
        My.Settings.CycleTimeMC15 = stJOCycleTimeMC15
        My.Settings.CycleTimeMC16 = stJOCycleTimeMC16
        My.Settings.CycleTimeMC17 = stJOCycleTimeMC17
        My.Settings.CycleTimeMC18 = stJOCycleTimeMC18
        My.Settings.CycleTimeMC19 = stJOCycleTimeMC19

        My.Settings.StartTimeMC1 = stJOStartTimeMC1
        My.Settings.StartTimeMC2 = stJOStartTimeMC2
        My.Settings.StartTimeMC3 = stJOStartTimeMC3
        My.Settings.StartTimeMC4 = stJOStartTimeMC4
        My.Settings.StartTimeMC5 = stJOStartTimeMC5
        My.Settings.StartTimeMC6 = stJOStartTimeMC6
        My.Settings.StartTimeMC7 = stJOStartTimeMC7
        My.Settings.StartTimeMC8 = stJOStartTimeMC8
        My.Settings.StartTimeMC9 = stJOStartTimeMC9
        My.Settings.StartTimeMC10 = stJOStartTimeMC10
        My.Settings.StartTimeMC11 = stJOStartTimeMC11
        My.Settings.StartTimeMC12 = stJOStartTimeMC12
        My.Settings.StartTimeMC13 = stJOStartTimeMC13
        My.Settings.StartTimeMC14 = stJOStartTimeMC14
        My.Settings.StartTimeMC15 = stJOStartTimeMC15
        My.Settings.StartTimeMC16 = stJOStartTimeMC16
        My.Settings.StartTimeMC17 = stJOStartTimeMC17
        My.Settings.StartTimeMC18 = stJOStartTimeMC18
        My.Settings.StartTimeMC19 = stJOStartTimeMC19

        My.Settings.PartNo1MC1 = stJOPartNo1MC1
        My.Settings.PartNo1MC2 = stJOPartNo1MC2
        My.Settings.PartNo1MC3 = stJOPartNo1MC3
        My.Settings.PartNo1MC4 = stJOPartNo1MC4
        My.Settings.PartNo1MC5 = stJOPartNo1MC5
        My.Settings.PartNo1MC6 = stJOPartNo1MC6
        My.Settings.PartNo1MC7 = stJOPartNo1MC7
        My.Settings.PartNo1MC8 = stJOPartNo1MC8
        My.Settings.PartNo1MC9 = stJOPartNo1MC9
        My.Settings.PartNo1MC10 = stJOPartNo1MC10
        My.Settings.PartNo1MC11 = stJOPartNo1MC11
        My.Settings.PartNo1MC12 = stJOPartNo1MC12
        My.Settings.PartNo1MC13 = stJOPartNo1MC13
        My.Settings.PartNo1MC14 = stJOPartNo1MC14
        My.Settings.PartNo1MC15 = stJOPartNo1MC15
        My.Settings.PartNo1MC16 = stJOPartNo1MC16
        My.Settings.PartNo1MC17 = stJOPartNo1MC17
        My.Settings.PartNo1MC18 = stJOPartNo1MC18
        My.Settings.PartNo1MC19 = stJOPartNo1MC19

        My.Settings.PartNo2MC1 = stJOPartNo2MC1
        My.Settings.PartNo2MC2 = stJOPartNo2MC2
        My.Settings.PartNo2MC3 = stJOPartNo2MC3
        My.Settings.PartNo2MC4 = stJOPartNo2MC4
        My.Settings.PartNo2MC5 = stJOPartNo2MC5
        My.Settings.PartNo2MC6 = stJOPartNo2MC6
        My.Settings.PartNo2MC7 = stJOPartNo2MC7
        My.Settings.PartNo2MC8 = stJOPartNo2MC8
        My.Settings.PartNo2MC9 = stJOPartNo2MC9
        My.Settings.PartNo2MC10 = stJOPartNo2MC10
        My.Settings.PartNo2MC11 = stJOPartNo2MC11
        My.Settings.PartNo2MC12 = stJOPartNo2MC12
        My.Settings.PartNo2MC13 = stJOPartNo2MC13
        My.Settings.PartNo2MC14 = stJOPartNo2MC14
        My.Settings.PartNo2MC15 = stJOPartNo2MC15
        My.Settings.PartNo2MC16 = stJOPartNo2MC16
        My.Settings.PartNo2MC17 = stJOPartNo2MC17
        My.Settings.PartNo2MC18 = stJOPartNo2MC18
        My.Settings.PartNo2MC19 = stJOPartNo2MC19

        My.Settings.CavQtyPn1MC1 = stJOMoldCavP1MC1
        My.Settings.CavQtyPn1MC2 = stJOMoldCavP1MC2
        My.Settings.CavQtyPn1MC3 = stJOMoldCavP1MC3
        My.Settings.CavQtyPn1MC4 = stJOMoldCavP1MC4
        My.Settings.CavQtyPn1MC5 = stJOMoldCavP1MC5
        My.Settings.CavQtyPn1MC6 = stJOMoldCavP1MC6
        My.Settings.CavQtyPn1MC7 = stJOMoldCavP1MC7
        My.Settings.CavQtyPn1MC8 = stJOMoldCavP1MC8
        My.Settings.CavQtyPn1MC9 = stJOMoldCavP1MC9
        My.Settings.CavQtyPn1MC10 = stJOMoldCavP1MC10
        My.Settings.CavQtyPn1MC11 = stJOMoldCavP1MC11
        My.Settings.CavQtyPn1MC12 = stJOMoldCavP1MC12
        My.Settings.CavQtyPn1MC13 = stJOMoldCavP1MC13
        My.Settings.CavQtyPn1MC14 = stJOMoldCavP1MC14
        My.Settings.CavQtyPn1MC15 = stJOMoldCavP1MC15
        My.Settings.CavQtyPn1MC16 = stJOMoldCavP1MC16
        My.Settings.CavQtyPn1MC17 = stJOMoldCavP1MC17
        My.Settings.CavQtyPn1MC18 = stJOMoldCavP1MC18
        My.Settings.CavQtyPn1MC19 = stJOMoldCavP1MC19

        My.Settings.CavQtyPn2MC1 = stJOMoldCavP2MC1
        My.Settings.CavQtyPn2MC2 = stJOMoldCavP2MC2
        My.Settings.CavQtyPn2MC3 = stJOMoldCavP2MC3
        My.Settings.CavQtyPn2MC4 = stJOMoldCavP2MC4
        My.Settings.CavQtyPn2MC5 = stJOMoldCavP2MC5
        My.Settings.CavQtyPn2MC6 = stJOMoldCavP2MC6
        My.Settings.CavQtyPn2MC7 = stJOMoldCavP2MC7
        My.Settings.CavQtyPn2MC8 = stJOMoldCavP2MC8
        My.Settings.CavQtyPn2MC9 = stJOMoldCavP2MC9
        My.Settings.CavQtyPn2MC10 = stJOMoldCavP2MC10
        My.Settings.CavQtyPn2MC11 = stJOMoldCavP2MC11
        My.Settings.CavQtyPn2MC12 = stJOMoldCavP2MC12
        My.Settings.CavQtyPn2MC13 = stJOMoldCavP2MC13
        My.Settings.CavQtyPn2MC14 = stJOMoldCavP2MC14
        My.Settings.CavQtyPn2MC15 = stJOMoldCavP2MC15
        My.Settings.CavQtyPn2MC16 = stJOMoldCavP2MC16
        My.Settings.CavQtyPn2MC17 = stJOMoldCavP2MC17
        My.Settings.CavQtyPn2MC18 = stJOMoldCavP2MC18
        My.Settings.CavQtyPn2MC19 = stJOMoldCavP2MC19

        My.Settings.PlanQtyMC1 = stJOQuantityMC1
        My.Settings.PlanQtyMC2 = stJOQuantityMC2
        My.Settings.PlanQtyMC3 = stJOQuantityMC3
        My.Settings.PlanQtyMC4 = stJOQuantityMC4
        My.Settings.PlanQtyMC5 = stJOQuantityMC5
        My.Settings.PlanQtyMC6 = stJOQuantityMC6
        My.Settings.PlanQtyMC7 = stJOQuantityMC7
        My.Settings.PlanQtyMC8 = stJOQuantityMC8
        My.Settings.PlanQtyMC9 = stJOQuantityMC9
        My.Settings.PlanQtyMC10 = stJOQuantityMC10
        My.Settings.PlanQtyMC11 = stJOQuantityMC11
        My.Settings.PlanQtyMC12 = stJOQuantityMC12
        My.Settings.PlanQtyMC13 = stJOQuantityMC13
        My.Settings.PlanQtyMC14 = stJOQuantityMC14
        My.Settings.PlanQtyMC15 = stJOQuantityMC15
        My.Settings.PlanQtyMC16 = stJOQuantityMC16
        My.Settings.PlanQtyMC17 = stJOQuantityMC17
        My.Settings.PlanQtyMC18 = stJOQuantityMC18
        My.Settings.PlanQtyMC19 = stJOQuantityMC19

        My.Settings.ActualRunTMC1 = runtimeMC1
        My.Settings.ActualRunTMC2 = runtimeMC2
        My.Settings.ActualRunTMC3 = runtimeMC3
        My.Settings.ActualRunTMC4 = runtimeMC4
        My.Settings.ActualRunTMC5 = runtimeMC5
        My.Settings.ActualRunTMC6 = runtimeMC6
        My.Settings.ActualRunTMC7 = runtimeMC7
        My.Settings.ActualRunTMC8 = runtimeMC8
        My.Settings.ActualRunTMC9 = runtimeMC9
        My.Settings.ActualRunTMC10 = runtimeMC10
        My.Settings.ActualRunTMC11 = runtimeMC11
        My.Settings.ActualRunTMC12 = runtimeMC12
        My.Settings.ActualRunTMC13 = runtimeMC13
        My.Settings.ActualRunTMC14 = runtimeMC14
        My.Settings.ActualRunTMC15 = runtimeMC15
        My.Settings.ActualRunTMC16 = runtimeMC16
        My.Settings.ActualRunTMC17 = runtimeMC17
        My.Settings.ActualRunTMC18 = runtimeMC18
        My.Settings.ActualRunTMC19 = runtimeMC19

        My.Settings.OuputPn1MC1 = CounterP1MC1
        My.Settings.OuputPn1MC2 = CounterP1MC2
        My.Settings.OuputPn1MC3 = CounterP1MC3
        My.Settings.OuputPn1MC4 = CounterP1MC4
        My.Settings.OuputPn1MC5 = CounterP1MC5
        My.Settings.OuputPn1MC6 = CounterP1MC6
        My.Settings.OuputPn1MC7 = CounterP1MC7
        My.Settings.OuputPn1MC8 = CounterP1MC8
        My.Settings.OuputPn1MC9 = CounterP1MC9
        My.Settings.OuputPn1MC10 = CounterP1MC10
        My.Settings.OuputPn1MC11 = CounterP1MC11
        My.Settings.OuputPn1MC12 = CounterP1MC12
        My.Settings.OuputPn1MC13 = CounterP1MC13
        My.Settings.OuputPn1MC14 = CounterP1MC14
        My.Settings.OuputPn1MC15 = CounterP1MC15
        My.Settings.OuputPn1MC16 = CounterP1MC16
        My.Settings.OuputPn1MC17 = CounterP1MC17
        My.Settings.OuputPn1MC18 = CounterP1MC18
        My.Settings.OuputPn1MC19 = CounterP1MC19

        My.Settings.OuputPn2MC1 = CounterP2MC1
        My.Settings.OuputPn2MC2 = CounterP2MC2
        My.Settings.OuputPn2MC3 = CounterP2MC3
        My.Settings.OuputPn2MC4 = CounterP2MC4
        My.Settings.OuputPn2MC5 = CounterP2MC5
        My.Settings.OuputPn2MC6 = CounterP2MC6
        My.Settings.OuputPn2MC7 = CounterP2MC7
        My.Settings.OuputPn2MC8 = CounterP2MC8
        My.Settings.OuputPn2MC9 = CounterP2MC9
        My.Settings.OuputPn2MC10 = CounterP2MC10
        My.Settings.OuputPn2MC11 = CounterP2MC11
        My.Settings.OuputPn2MC12 = CounterP2MC12
        My.Settings.OuputPn2MC13 = CounterP2MC13
        My.Settings.OuputPn2MC14 = CounterP2MC14
        My.Settings.OuputPn2MC15 = CounterP2MC15
        My.Settings.OuputPn2MC16 = CounterP2MC16
        My.Settings.OuputPn2MC17 = CounterP2MC17
        My.Settings.OuputPn2MC18 = CounterP2MC18
        My.Settings.OuputPn2MC19 = CounterP2MC19

        My.Settings.ActualQtyMC1 = TotalCountMC1
        My.Settings.ActualQtyMC2 = TotalCountMC2
        My.Settings.ActualQtyMC3 = TotalCountMC3
        My.Settings.ActualQtyMC4 = TotalCountMC4
        My.Settings.ActualQtyMC5 = TotalCountMC5
        My.Settings.ActualQtyMC6 = TotalCountMC6
        My.Settings.ActualQtyMC7 = TotalCountMC7
        My.Settings.ActualQtyMC8 = TotalCountMC8
        My.Settings.ActualQtyMC9 = TotalCountMC9
        My.Settings.ActualQtyMC10 = TotalCountMC10
        My.Settings.ActualQtyMC11 = TotalCountMC11
        My.Settings.ActualQtyMC12 = TotalCountMC12
        My.Settings.ActualQtyMC13 = TotalCountMC13
        My.Settings.ActualQtyMC14 = TotalCountMC14
        My.Settings.ActualQtyMC15 = TotalCountMC15
        My.Settings.ActualQtyMC16 = TotalCountMC16
        My.Settings.ActualQtyMC17 = TotalCountMC17
        My.Settings.ActualQtyMC18 = TotalCountMC18
        My.Settings.ActualQtyMC19 = TotalCountMC19

        My.Settings.IPAddress = modSetVal_IPAdd
        My.Settings.Port = modSetVal_Port
        My.Settings.SQLPath = modSetVal_SqlPath
    End Sub
    '//

    '// LOADING THE MY.SETTING 
    Public Sub loadMysetting()
        stJOMC1 = My.Settings.JOCodeMC1
        If stJOMC1 IsNot Nothing Then
            modJOLoadedFlagMC1 = True
            lblTest1.Text = modJOLoadedFlagMC1
        End If

        stJOMC2 = My.Settings.JOCodeMC2
        If stJOMC2 IsNot Nothing Then
            modJOLoadedFlagMC2 = True
        End If


        stJOMC3 = My.Settings.JOCodeMC3
        stJOMC4 = My.Settings.JOCodeMC4

        stJOMC5 = My.Settings.JOCodeMC5
        If stJOMC5 IsNot Nothing Then
            modJOLoadedFlagMC5 = True
        End If

        stJOMC6 = My.Settings.JOCodeMC6
        stJOMC7 = My.Settings.JOCodeMC7
        stJOMC8 = My.Settings.JOCodeMC8
        stJOMC9 = My.Settings.JOCodeMC9
        stJOMC10 = My.Settings.JOCodeMC10
        stJOMC11 = My.Settings.JOCodeMC11
        stJOMC12 = My.Settings.JOCodeMC12
        stJOMC13 = My.Settings.JOCodeMC13
        stJOMC14 = My.Settings.JOCodeMC14
        stJOMC15 = My.Settings.JOCodeMC15
        stJOMC16 = My.Settings.JOCodeMC16
        stJOMC17 = My.Settings.JOCodeMC17
        stJOMC18 = My.Settings.JOCodeMC18
        stJOMC19 = My.Settings.JOCodeMC19

        stJOMoldIDMC1 = My.Settings.MoldNoMC1
        stJOMoldIDMC2 = My.Settings.MoldNoMC2
        stJOMoldIDMC3 = My.Settings.MoldNoMC3
        stJOMoldIDMC4 = My.Settings.MoldNoMC4
        stJOMoldIDMC5 = My.Settings.MoldNoMC5
        stJOMoldIDMC6 = My.Settings.MoldNoMC6
        stJOMoldIDMC7 = My.Settings.MoldNoMC7
        stJOMoldIDMC8 = My.Settings.MoldNoMC8
        stJOMoldIDMC9 = My.Settings.MoldNoMC9
        stJOMoldIDMC10 = My.Settings.MoldNoMC10
        stJOMoldIDMC11 = My.Settings.MoldNoMC11
        stJOMoldIDMC12 = My.Settings.MoldNoMC12
        stJOMoldIDMC13 = My.Settings.MoldNoMC13
        stJOMoldIDMC14 = My.Settings.MoldNoMC14
        stJOMoldIDMC15 = My.Settings.MoldNoMC15
        stJOMoldIDMC16 = My.Settings.MoldNoMC16
        stJOMoldIDMC17 = My.Settings.MoldNoMC17
        stJOMoldIDMC18 = My.Settings.MoldNoMC18
        stJOMoldIDMC19 = My.Settings.MoldNoMC19

        stJOCycleTimeMC1 = My.Settings.CycleTimeMC1
        stJOCycleTimeMC2 = My.Settings.CycleTimeMC2
        stJOCycleTimeMC3 = My.Settings.CycleTimeMC3
        stJOCycleTimeMC4 = My.Settings.CycleTimeMC4
        stJOCycleTimeMC5 = My.Settings.CycleTimeMC5
        stJOCycleTimeMC6 = My.Settings.CycleTimeMC6
        stJOCycleTimeMC7 = My.Settings.CycleTimeMC7
        stJOCycleTimeMC8 = My.Settings.CycleTimeMC8
        stJOCycleTimeMC9 = My.Settings.CycleTimeMC9
        stJOCycleTimeMC10 = My.Settings.CycleTimeMC10
        stJOCycleTimeMC11 = My.Settings.CycleTimeMC11
        stJOCycleTimeMC12 = My.Settings.CycleTimeMC12
        stJOCycleTimeMC13 = My.Settings.CycleTimeMC13
        stJOCycleTimeMC14 = My.Settings.CycleTimeMC14
        stJOCycleTimeMC15 = My.Settings.CycleTimeMC15
        stJOCycleTimeMC16 = My.Settings.CycleTimeMC16
        stJOCycleTimeMC17 = My.Settings.CycleTimeMC17
        stJOCycleTimeMC18 = My.Settings.CycleTimeMC18
        stJOCycleTimeMC19 = My.Settings.CycleTimeMC19

        stJOStartTimeMC1 = My.Settings.StartTimeMC1
        stJOStartTimeMC2 = My.Settings.StartTimeMC2
        stJOStartTimeMC3 = My.Settings.StartTimeMC3
        stJOStartTimeMC4 = My.Settings.StartTimeMC4
        stJOStartTimeMC5 = My.Settings.StartTimeMC5
        stJOStartTimeMC6 = My.Settings.StartTimeMC6
        stJOStartTimeMC7 = My.Settings.StartTimeMC7
        stJOStartTimeMC8 = My.Settings.StartTimeMC8
        stJOStartTimeMC9 = My.Settings.StartTimeMC9
        stJOStartTimeMC10 = My.Settings.StartTimeMC10
        stJOStartTimeMC11 = My.Settings.StartTimeMC11
        stJOStartTimeMC12 = My.Settings.StartTimeMC12
        stJOStartTimeMC13 = My.Settings.StartTimeMC13
        stJOStartTimeMC14 = My.Settings.StartTimeMC14
        stJOStartTimeMC15 = My.Settings.StartTimeMC15
        stJOStartTimeMC16 = My.Settings.StartTimeMC16
        stJOStartTimeMC17 = My.Settings.StartTimeMC17
        stJOStartTimeMC18 = My.Settings.StartTimeMC18
        stJOStartTimeMC19 = My.Settings.StartTimeMC19

        stJOPartNo1MC1 = My.Settings.PartNo1MC1
        stJOPartNo1MC2 = My.Settings.PartNo1MC2
        stJOPartNo1MC3 = My.Settings.PartNo1MC3
        stJOPartNo1MC4 = My.Settings.PartNo1MC4
        stJOPartNo1MC5 = My.Settings.PartNo1MC5
        stJOPartNo1MC6 = My.Settings.PartNo1MC6
        stJOPartNo1MC7 = My.Settings.PartNo1MC7
        stJOPartNo1MC8 = My.Settings.PartNo1MC8
        stJOPartNo1MC9 = My.Settings.PartNo1MC9
        stJOPartNo1MC10 = My.Settings.PartNo1MC10
        stJOPartNo1MC11 = My.Settings.PartNo1MC11
        stJOPartNo1MC12 = My.Settings.PartNo1MC12
        stJOPartNo1MC13 = My.Settings.PartNo1MC13
        stJOPartNo1MC14 = My.Settings.PartNo1MC14
        stJOPartNo1MC15 = My.Settings.PartNo1MC15
        stJOPartNo1MC16 = My.Settings.PartNo1MC16
        stJOPartNo1MC17 = My.Settings.PartNo1MC17
        stJOPartNo1MC18 = My.Settings.PartNo1MC18
        stJOPartNo1MC19 = My.Settings.PartNo1MC19

        stJOPartNo2MC1 = My.Settings.PartNo2MC1
        stJOPartNo2MC2 = My.Settings.PartNo2MC2
        stJOPartNo2MC3 = My.Settings.PartNo2MC3
        stJOPartNo2MC4 = My.Settings.PartNo2MC4
        stJOPartNo2MC5 = My.Settings.PartNo2MC5
        stJOPartNo2MC6 = My.Settings.PartNo2MC6
        stJOPartNo2MC7 = My.Settings.PartNo2MC7
        stJOPartNo2MC8 = My.Settings.PartNo2MC8
        stJOPartNo2MC9 = My.Settings.PartNo2MC9
        stJOPartNo2MC10 = My.Settings.PartNo2MC10
        stJOPartNo2MC11 = My.Settings.PartNo2MC11
        stJOPartNo2MC12 = My.Settings.PartNo2MC12
        stJOPartNo2MC13 = My.Settings.PartNo2MC13
        stJOPartNo2MC14 = My.Settings.PartNo2MC14
        stJOPartNo2MC15 = My.Settings.PartNo2MC15
        stJOPartNo2MC16 = My.Settings.PartNo2MC16
        stJOPartNo2MC17 = My.Settings.PartNo2MC17
        stJOPartNo2MC18 = My.Settings.PartNo2MC18
        stJOPartNo2MC19 = My.Settings.PartNo2MC19

        stJOMoldCavP1MC1 = My.Settings.CavQtyPn1MC1
        stJOMoldCavP1MC2 = My.Settings.CavQtyPn1MC2
        stJOMoldCavP1MC3 = My.Settings.CavQtyPn1MC3
        stJOMoldCavP1MC4 = My.Settings.CavQtyPn1MC4
        stJOMoldCavP1MC5 = My.Settings.CavQtyPn1MC5
        stJOMoldCavP1MC6 = My.Settings.CavQtyPn1MC6
        stJOMoldCavP1MC7 = My.Settings.CavQtyPn1MC7
        stJOMoldCavP1MC8 = My.Settings.CavQtyPn1MC8
        stJOMoldCavP1MC9 = My.Settings.CavQtyPn1MC9
        stJOMoldCavP1MC10 = My.Settings.CavQtyPn1MC10
        stJOMoldCavP1MC11 = My.Settings.CavQtyPn1MC11
        stJOMoldCavP1MC12 = My.Settings.CavQtyPn1MC12
        stJOMoldCavP1MC13 = My.Settings.CavQtyPn1MC13
        stJOMoldCavP1MC14 = My.Settings.CavQtyPn1MC14
        stJOMoldCavP1MC15 = My.Settings.CavQtyPn1MC15
        stJOMoldCavP1MC16 = My.Settings.CavQtyPn1MC16
        stJOMoldCavP1MC17 = My.Settings.CavQtyPn1MC17
        stJOMoldCavP1MC18 = My.Settings.CavQtyPn1MC18
        stJOMoldCavP1MC19 = My.Settings.CavQtyPn1MC19

        stJOMoldCavP2MC1 = My.Settings.CavQtyPn2MC1
        stJOMoldCavP2MC2 = My.Settings.CavQtyPn2MC2
        stJOMoldCavP2MC3 = My.Settings.CavQtyPn2MC3
        stJOMoldCavP2MC4 = My.Settings.CavQtyPn2MC4
        stJOMoldCavP2MC5 = My.Settings.CavQtyPn2MC5
        stJOMoldCavP2MC6 = My.Settings.CavQtyPn2MC6
        stJOMoldCavP2MC7 = My.Settings.CavQtyPn2MC7
        stJOMoldCavP2MC8 = My.Settings.CavQtyPn2MC8
        stJOMoldCavP2MC9 = My.Settings.CavQtyPn2MC9
        stJOMoldCavP2MC10 = My.Settings.CavQtyPn2MC10
        stJOMoldCavP2MC11 = My.Settings.CavQtyPn2MC11
        stJOMoldCavP2MC12 = My.Settings.CavQtyPn2MC12
        stJOMoldCavP2MC13 = My.Settings.CavQtyPn2MC13
        stJOMoldCavP2MC14 = My.Settings.CavQtyPn2MC14
        stJOMoldCavP2MC15 = My.Settings.CavQtyPn2MC15
        stJOMoldCavP2MC16 = My.Settings.CavQtyPn2MC16
        stJOMoldCavP2MC17 = My.Settings.CavQtyPn2MC17
        stJOMoldCavP2MC18 = My.Settings.CavQtyPn2MC18
        stJOMoldCavP2MC19 = My.Settings.CavQtyPn2MC19

        stJOQuantityMC1 = My.Settings.PlanQtyMC1
        stJOQuantityMC2 = My.Settings.PlanQtyMC2
        stJOQuantityMC3 = My.Settings.PlanQtyMC3
        stJOQuantityMC4 = My.Settings.PlanQtyMC4
        stJOQuantityMC5 = My.Settings.PlanQtyMC5
        stJOQuantityMC6 = My.Settings.PlanQtyMC6
        stJOQuantityMC7 = My.Settings.PlanQtyMC7
        stJOQuantityMC8 = My.Settings.PlanQtyMC8
        stJOQuantityMC9 = My.Settings.PlanQtyMC9
        stJOQuantityMC10 = My.Settings.PlanQtyMC10
        stJOQuantityMC11 = My.Settings.PlanQtyMC11
        stJOQuantityMC12 = My.Settings.PlanQtyMC12
        stJOQuantityMC13 = My.Settings.PlanQtyMC13
        stJOQuantityMC14 = My.Settings.PlanQtyMC14
        stJOQuantityMC15 = My.Settings.PlanQtyMC15
        stJOQuantityMC16 = My.Settings.PlanQtyMC16
        stJOQuantityMC17 = My.Settings.PlanQtyMC17
        stJOQuantityMC18 = My.Settings.PlanQtyMC18
        stJOQuantityMC19 = My.Settings.PlanQtyMC19

        runtimeMC1 = My.Settings.ActualRunTMC1
        runtimeMC2 = My.Settings.ActualRunTMC2
        runtimeMC3 = My.Settings.ActualRunTMC3
        runtimeMC4 = My.Settings.ActualRunTMC4
        runtimeMC5 = My.Settings.ActualRunTMC5
        runtimeMC6 = My.Settings.ActualRunTMC6
        runtimeMC7 = My.Settings.ActualRunTMC7
        runtimeMC8 = My.Settings.ActualRunTMC8
        runtimeMC9 = My.Settings.ActualRunTMC9
        runtimeMC10 = My.Settings.ActualRunTMC10
        runtimeMC11 = My.Settings.ActualRunTMC11
        runtimeMC12 = My.Settings.ActualRunTMC12
        runtimeMC13 = My.Settings.ActualRunTMC13
        runtimeMC14 = My.Settings.ActualRunTMC14
        runtimeMC15 = My.Settings.ActualRunTMC15
        runtimeMC16 = My.Settings.ActualRunTMC16
        runtimeMC17 = My.Settings.ActualRunTMC17
        runtimeMC18 = My.Settings.ActualRunTMC18
        runtimeMC19 = My.Settings.ActualRunTMC19

        CounterP1MC1 = My.Settings.OuputPn1MC1
        CounterP1MC2 = My.Settings.OuputPn1MC2
        CounterP1MC3 = My.Settings.OuputPn1MC3
        CounterP1MC4 = My.Settings.OuputPn1MC4
        CounterP1MC5 = My.Settings.OuputPn1MC5
        CounterP1MC6 = My.Settings.OuputPn1MC6
        CounterP1MC7 = My.Settings.OuputPn1MC7
        CounterP1MC8 = My.Settings.OuputPn1MC8
        CounterP1MC9 = My.Settings.OuputPn1MC9
        CounterP1MC10 = My.Settings.OuputPn1MC10
        CounterP1MC11 = My.Settings.OuputPn1MC11
        CounterP1MC12 = My.Settings.OuputPn1MC12
        CounterP1MC13 = My.Settings.OuputPn1MC13
        CounterP1MC14 = My.Settings.OuputPn1MC14
        CounterP1MC15 = My.Settings.OuputPn1MC15
        CounterP1MC16 = My.Settings.OuputPn1MC16
        CounterP1MC17 = My.Settings.OuputPn1MC17
        CounterP1MC18 = My.Settings.OuputPn1MC18
        CounterP1MC19 = My.Settings.OuputPn1MC19

        CounterP2MC1 = My.Settings.OuputPn2MC1
        CounterP2MC2 = My.Settings.OuputPn2MC2
        CounterP2MC3 = My.Settings.OuputPn2MC3
        CounterP2MC4 = My.Settings.OuputPn2MC4
        CounterP2MC5 = My.Settings.OuputPn2MC5
        CounterP2MC6 = My.Settings.OuputPn2MC6
        CounterP2MC7 = My.Settings.OuputPn2MC7
        CounterP2MC8 = My.Settings.OuputPn2MC8
        CounterP2MC9 = My.Settings.OuputPn2MC9
        CounterP2MC10 = My.Settings.OuputPn2MC10
        CounterP2MC11 = My.Settings.OuputPn2MC11
        CounterP2MC12 = My.Settings.OuputPn2MC12
        CounterP2MC13 = My.Settings.OuputPn2MC13
        CounterP2MC14 = My.Settings.OuputPn2MC14
        CounterP2MC15 = My.Settings.OuputPn2MC15
        CounterP2MC16 = My.Settings.OuputPn2MC16
        CounterP2MC17 = My.Settings.OuputPn2MC17
        CounterP2MC18 = My.Settings.OuputPn2MC18
        CounterP2MC19 = My.Settings.OuputPn2MC19

        TotalCountMC1 = My.Settings.ActualQtyMC1
        TotalCountMC2 = My.Settings.ActualQtyMC2
        TotalCountMC3 = My.Settings.ActualQtyMC3
        TotalCountMC4 = My.Settings.ActualQtyMC4
        TotalCountMC5 = My.Settings.ActualQtyMC5
        TotalCountMC6 = My.Settings.ActualQtyMC6
        TotalCountMC7 = My.Settings.ActualQtyMC7
        TotalCountMC8 = My.Settings.ActualQtyMC8
        TotalCountMC9 = My.Settings.ActualQtyMC9
        TotalCountMC10 = My.Settings.ActualQtyMC10
        TotalCountMC11 = My.Settings.ActualQtyMC11
        TotalCountMC12 = My.Settings.ActualQtyMC12
        TotalCountMC13 = My.Settings.ActualQtyMC13
        TotalCountMC14 = My.Settings.ActualQtyMC14
        TotalCountMC15 = My.Settings.ActualQtyMC15
        TotalCountMC16 = My.Settings.ActualQtyMC16
        TotalCountMC17 = My.Settings.ActualQtyMC17
        TotalCountMC18 = My.Settings.ActualQtyMC18
        TotalCountMC19 = My.Settings.ActualQtyMC19

        modSetVal_SqlPath = My.Settings.SQLPath
        modSetVal_IPAdd = My.Settings.IPAddress
        modSetVal_Port = My.Settings.Port
    End Sub
    '//

    '// AUTO GENERATION OF SHIFTCODES
    Public Sub shiftUpdate()
        Dim sc As Date
        sfHoursMod = Date.Now.ToString("HH")
        sfMonthMod = Date.Now.ToString("MM")
        sfYearMod = Date.Now.ToString("yy")

        'Shift change Day to Nigh and vice versa
        lblHours.Text = sfHoursMod
        If sfHoursMod >= 8 And sfHoursMod < 20 Then
            sfShiftMod = "D"
        ElseIf sfHoursMod >= 20 Or (sfHoursMod >= 0 And sfHoursMod < 8) Then
            sfShiftMod = "N"
        End If

        'Shift Date, continue the same date and will change on the next morning shift schedule
        If sfHoursMod >= 0 And sfHoursMod < 8 Then
            'adding date set 1 to 1
            'subtracting date set 1 to -1 
            '1 is just as sample i used since im only adding or subtracting 1 day to the current date and time
            sc = DateAdd(DateInterval.Day, -1, Now())
            sfDayMod = sc.Date.ToString("dd")
        Else
            sfDayMod = Date.Now.ToString("dd")
        End If

        'shiftcode format D/N & dd & MM & yy & MC#
        sfShiftCodeMod = sfShiftMod & sfDayMod & sfMonthMod & sfYearMod
    End Sub
    '//

    '// LOADING USER INFO DETAILS TO MINIDASH DURING LOGIN
    Public Sub LoginConfirm()
        If modUserLoginFlagMC1 = True And modTempCheckMC1 = True Then lblOptNm1.Text = stUserName
        If modUserLoginFlagMC2 = True And modTempCheckMC2 = True Then lblOptNm2.Text = stUserName
        If modUserLoginFlagMC3 = True And modTempCheckMC3 = True Then lblOptNm3.Text = stUserName
        If modUserLoginFlagMC4 = True And modTempCheckMC4 = True Then lblOptNm4.Text = stUserName
        If modUserLoginFlagMC5 = True And modTempCheckMC5 = True Then lblOptNm5.Text = stUserName
        If modUserLoginFlagMC6 = True And modTempCheckMC6 = True Then lblOptNm6.Text = stUserName
        If modUserLoginFlagMC7 = True And modTempCheckMC7 = True Then lblOptNm7.Text = stUserName
        If modUserLoginFlagMC8 = True And modTempCheckMC8 = True Then lblOptNm8.Text = stUserName
        If modUserLoginFlagMC9 = True And modTempCheckMC9 = True Then lblOptNm9.Text = stUserName
        If modUserLoginFlagMC10 = True And modTempCheckMC10 = True Then lblOptNm10.Text = stUserName
        If modUserLoginFlagMC11 = True And modTempCheckMC11 = True Then lblOptNm11.Text = stUserName
        If modUserLoginFlagMC12 = True And modTempCheckMC12 = True Then lblOptNm12.Text = stUserName
        If modUserLoginFlagMC13 = True And modTempCheckMC13 = True Then lblOptNm13.Text = stUserName
        If modUserLoginFlagMC14 = True And modTempCheckMC14 = True Then lblOptNm14.Text = stUserName
        If modUserLoginFlagMC15 = True And modTempCheckMC15 = True Then lblOptNm15.Text = stUserName
        If modUserLoginFlagMC16 = True And modTempCheckMC16 = True Then lblOptNm16.Text = stUserName
        If modUserLoginFlagMC17 = True And modTempCheckMC17 = True Then lblOptNm17.Text = stUserName
        If modUserLoginFlagMC18 = True And modTempCheckMC18 = True Then lblOptNm18.Text = stUserName
        If modUserLoginFlagMC19 = True And modTempCheckMC19 = True Then lblOptNm19.Text = stUserName

        If modUserLoginFlagMC1 = True And modTempCheckMC1 = True Then UNIdmc1 = stUserID
        If modUserLoginFlagMC2 = True And modTempCheckMC2 = True Then UNIdmc2 = stUserID
        If modUserLoginFlagMC3 = True And modTempCheckMC3 = True Then UNIdmc3 = stUserID
        If modUserLoginFlagMC4 = True And modTempCheckMC4 = True Then UNIdmc4 = stUserID
        If modUserLoginFlagMC5 = True And modTempCheckMC5 = True Then UNIdmc5 = stUserID
        If modUserLoginFlagMC6 = True And modTempCheckMC6 = True Then UNIdmc6 = stUserID
        If modUserLoginFlagMC7 = True And modTempCheckMC7 = True Then UNIdmc7 = stUserID
        If modUserLoginFlagMC8 = True And modTempCheckMC8 = True Then UNIdmc8 = stUserID
        If modUserLoginFlagMC9 = True And modTempCheckMC9 = True Then UNIdmc9 = stUserID
        If modUserLoginFlagMC10 = True And modTempCheckMC10 = True Then UNIdmc10 = stUserID
        If modUserLoginFlagMC11 = True And modTempCheckMC11 = True Then UNIdmc11 = stUserID
        If modUserLoginFlagMC12 = True And modTempCheckMC12 = True Then UNIdmc12 = stUserID
        If modUserLoginFlagMC13 = True And modTempCheckMC13 = True Then UNIdmc13 = stUserID
        If modUserLoginFlagMC14 = True And modTempCheckMC14 = True Then UNIdmc14 = stUserID
        If modUserLoginFlagMC15 = True And modTempCheckMC15 = True Then UNIdmc15 = stUserID
        If modUserLoginFlagMC16 = True And modTempCheckMC16 = True Then UNIdmc16 = stUserID
        If modUserLoginFlagMC17 = True And modTempCheckMC17 = True Then UNIdmc17 = stUserID
        If modUserLoginFlagMC18 = True And modTempCheckMC18 = True Then UNIdmc18 = stUserID
        If modUserLoginFlagMC19 = True And modTempCheckMC19 = True Then UNIdmc19 = stUserID
        'Bellow will be displayed on each of the machine dashboard
        UNmc1 = lblOptNm1.Text
        UNmc2 = lblOptNm2.Text
        UNmc3 = lblOptNm3.Text
        UNmc4 = lblOptNm4.Text
        UNmc5 = lblOptNm5.Text
        UNmc6 = lblOptNm6.Text
        UNmc7 = lblOptNm7.Text
        UNmc8 = lblOptNm8.Text
        UNmc9 = lblOptNm9.Text
        UNmc10 = lblOptNm10.Text
        UNmc11 = lblOptNm11.Text
        UNmc12 = lblOptNm12.Text
        UNmc13 = lblOptNm13.Text
        UNmc14 = lblOptNm14.Text
        UNmc15 = lblOptNm15.Text
        UNmc16 = lblOptNm16.Text
        UNmc17 = lblOptNm17.Text
        UNmc18 = lblOptNm18.Text
        UNmc19 = lblOptNm19.Text
    End Sub
    '//

    '// CLEARING USER DETAIL INPUTS
    Public Sub ClearUserDetailInputs()
        stUserName = Nothing
        stUserID = Nothing
        stAccessLvl = Nothing
    End Sub
    '//

    '// UNLOADING USER INFO DETAILS FROM MINIDASH DURING LOGOUT
    Public Sub LogoutConfirmSub(btn As IconButton, lbl As Label)
        If btn.IconChar = IconChar.None Then
            lbl.Text = "-"
        End If
    End Sub
    Public Sub LogoutConfirm()
        LogoutConfirmSub(btnCheckMC1, lblOptNm1)
        LogoutConfirmSub(btnCheckMC2, lblOptNm2)
        LogoutConfirmSub(btnCheckMC3, lblOptNm3)
        LogoutConfirmSub(btnCheckMC4, lblOptNm4)
        LogoutConfirmSub(btnCheckMC5, lblOptNm5)
        LogoutConfirmSub(btnCheckMC6, lblOptNm6)
        LogoutConfirmSub(btnCheckMC7, lblOptNm7)
        LogoutConfirmSub(btnCheckMC8, lblOptNm8)
        LogoutConfirmSub(btnCheckMC9, lblOptNm9)
        LogoutConfirmSub(btnCheckMC10, lblOptNm10)
        LogoutConfirmSub(btnCheckMC11, lblOptNm11)
        LogoutConfirmSub(btnCheckMC12, lblOptNm12)
        LogoutConfirmSub(btnCheckMC13, lblOptNm13)
        LogoutConfirmSub(btnCheckMC14, lblOptNm14)
        LogoutConfirmSub(btnCheckMC15, lblOptNm15)
        LogoutConfirmSub(btnCheckMC16, lblOptNm16)
        LogoutConfirmSub(btnCheckMC17, lblOptNm17)
        LogoutConfirmSub(btnCheckMC18, lblOptNm18)
        LogoutConfirmSub(btnCheckMC19, lblOptNm19)

        If btnCheckMC1.IconChar = IconChar.None Then UNmc1 = Nothing
        If btnCheckMC2.IconChar = IconChar.None Then UNmc2 = Nothing
        If btnCheckMC3.IconChar = IconChar.None Then UNmc3 = Nothing
        If btnCheckMC4.IconChar = IconChar.None Then UNmc4 = Nothing
        If btnCheckMC5.IconChar = IconChar.None Then UNmc5 = Nothing
        If btnCheckMC6.IconChar = IconChar.None Then UNmc6 = Nothing
        If btnCheckMC7.IconChar = IconChar.None Then UNmc7 = Nothing
        If btnCheckMC8.IconChar = IconChar.None Then UNmc8 = Nothing
        If btnCheckMC9.IconChar = IconChar.None Then UNmc9 = Nothing
        If btnCheckMC10.IconChar = IconChar.None Then UNmc10 = Nothing
        If btnCheckMC11.IconChar = IconChar.None Then UNmc11 = Nothing
        If btnCheckMC12.IconChar = IconChar.None Then UNmc12 = Nothing
        If btnCheckMC13.IconChar = IconChar.None Then UNmc13 = Nothing
        If btnCheckMC14.IconChar = IconChar.None Then UNmc14 = Nothing
        If btnCheckMC15.IconChar = IconChar.None Then UNmc15 = Nothing
        If btnCheckMC16.IconChar = IconChar.None Then UNmc16 = Nothing
        If btnCheckMC17.IconChar = IconChar.None Then UNmc17 = Nothing
        If btnCheckMC18.IconChar = IconChar.None Then UNmc18 = Nothing
        If btnCheckMC19.IconChar = IconChar.None Then UNmc19 = Nothing
    End Sub
    '//

    '// LOADING JOB ORDER DETAIL TO MINIDASH 
    Public Sub JOLoadDetails()
        lblWO1.Text = stJOMC1
        lblTO1.Text = stJOQuantityMC1
        lblWO2.Text = stJOMC2
        lblTO2.Text = stJOQuantityMC2
        lblWO3.Text = stJOMC3
        lblTO3.Text = stJOQuantityMC3
        lblWO4.Text = stJOMC4
        lblTO4.Text = stJOQuantityMC4
        lblWO5.Text = stJOMC5
        lblTO5.Text = stJOQuantityMC5
        lblWO6.Text = stJOMC6
        lblTO6.Text = stJOQuantityMC6
        lblWO7.Text = stJOMC7
        lblTO7.Text = stJOQuantityMC7
        lblWO8.Text = stJOMC8
        lblTO8.Text = stJOQuantityMC8
        lblWO9.Text = stJOMC9
        lblTO9.Text = stJOQuantityMC9
        lblWO10.Text = stJOMC10
        lblTO10.Text = stJOQuantityMC10
        lblWO11.Text = stJOMC11
        lblTO11.Text = stJOQuantityMC11
        lblWO12.Text = stJOMC12
        lblTO12.Text = stJOQuantityMC12
        lblWO13.Text = stJOMC13
        lblTO13.Text = stJOQuantityMC13
        lblWO14.Text = stJOMC14
        lblTO14.Text = stJOQuantityMC14
        lblWO15.Text = stJOMC15
        lblTO15.Text = stJOQuantityMC15
        lblWO16.Text = stJOMC16
        lblTO16.Text = stJOQuantityMC16
        lblWO17.Text = stJOMC17
        lblTO17.Text = stJOQuantityMC17
        lblWO18.Text = stJOMC18
        lblTO18.Text = stJOQuantityMC18
        lblWO19.Text = stJOMC19
        lblTO19.Text = stJOQuantityMC19
        bolJOLoadedatHome = True
    End Sub
    '//

    '// CHECKBOX BUTTON VISIBLE.FALSE
    Public Sub ckbBtnVisibleFalse()
        btnCheckMC1.Visible = False
        btnCheckMC2.Visible = False
        btnCheckMC3.Visible = False
        btnCheckMC4.Visible = False
        btnCheckMC5.Visible = False
        btnCheckMC6.Visible = False
        btnCheckMC7.Visible = False
        btnCheckMC8.Visible = False
        btnCheckMC9.Visible = False
        btnCheckMC10.Visible = False
        btnCheckMC11.Visible = False
        btnCheckMC12.Visible = False
        btnCheckMC13.Visible = False
        btnCheckMC14.Visible = False
        btnCheckMC15.Visible = False
        btnCheckMC16.Visible = False
        btnCheckMC17.Visible = False
        btnCheckMC18.Visible = False
        btnCheckMC19.Visible = False
        btnMCSelect.Visible = False
        btnMCSelClear.Visible = False
    End Sub
    '//

    '// CHECKBOX BUTTON VISIBLE.TRUE
    Public Sub ckbBtnVisibleTrue()
        btnCheckMC1.Visible = True
        btnCheckMC2.Visible = True
        btnCheckMC3.Visible = True
        btnCheckMC4.Visible = True
        btnCheckMC5.Visible = True
        btnCheckMC6.Visible = True
        btnCheckMC7.Visible = True
        btnCheckMC8.Visible = True
        btnCheckMC9.Visible = True
        btnCheckMC10.Visible = True
        btnCheckMC11.Visible = True
        btnCheckMC12.Visible = True
        btnCheckMC13.Visible = True
        btnCheckMC14.Visible = True
        btnCheckMC15.Visible = True
        btnCheckMC16.Visible = True
        btnCheckMC17.Visible = True
        btnCheckMC18.Visible = True
        btnCheckMC19.Visible = True
        btnMCSelect.Visible = True
        btnMCSelClear.Visible = True
    End Sub
    '//

    '// REVERT CHECKBOX BUTTON STATE AT LOGIN IF NOT CONFIRMED
    Public Sub ckbBtnClear(optn As Label, check As IconButton)
        If optn.Text = "-" Then
            check.IconChar = IconChar.None
        End If
    End Sub
    Public Sub checkboxBtnClearLoginTab()
        ckbBtnClear(lblOptNm1, btnCheckMC1)
        ckbBtnClear(lblOptNm2, btnCheckMC2)
        ckbBtnClear(lblOptNm3, btnCheckMC3)
        ckbBtnClear(lblOptNm4, btnCheckMC4)
        ckbBtnClear(lblOptNm5, btnCheckMC5)
        ckbBtnClear(lblOptNm6, btnCheckMC6)
        ckbBtnClear(lblOptNm7, btnCheckMC7)
        ckbBtnClear(lblOptNm8, btnCheckMC8)
        ckbBtnClear(lblOptNm9, btnCheckMC9)
        ckbBtnClear(lblOptNm10, btnCheckMC10)
        ckbBtnClear(lblOptNm11, btnCheckMC11)
        ckbBtnClear(lblOptNm12, btnCheckMC12)
        ckbBtnClear(lblOptNm13, btnCheckMC13)
        ckbBtnClear(lblOptNm14, btnCheckMC14)
        ckbBtnClear(lblOptNm15, btnCheckMC15)
        ckbBtnClear(lblOptNm16, btnCheckMC16)
        ckbBtnClear(lblOptNm17, btnCheckMC17)
        ckbBtnClear(lblOptNm18, btnCheckMC18)
        ckbBtnClear(lblOptNm19, btnCheckMC19)
    End Sub
    '//

    '// REVERT CHECKBOX BUTTON STATE AT LOUTOUT IF NOT CONFIRMED
    Public Sub checkboxBtnClearLogoutTabSub(lbl As Label, btn As IconButton)
        If lbl.Text <> "-" Then
            btn.IconChar = IconChar.Check
        End If
    End Sub
    Public Sub checkboxBtnClearLogoutTab()
        checkboxBtnClearLogoutTabSub(lblOptNm1, btnCheckMC1)
        checkboxBtnClearLogoutTabSub(lblOptNm2, btnCheckMC2)
        checkboxBtnClearLogoutTabSub(lblOptNm3, btnCheckMC3)
        checkboxBtnClearLogoutTabSub(lblOptNm4, btnCheckMC4)
        checkboxBtnClearLogoutTabSub(lblOptNm5, btnCheckMC5)
        checkboxBtnClearLogoutTabSub(lblOptNm6, btnCheckMC6)
        checkboxBtnClearLogoutTabSub(lblOptNm7, btnCheckMC7)
        checkboxBtnClearLogoutTabSub(lblOptNm8, btnCheckMC8)
        checkboxBtnClearLogoutTabSub(lblOptNm9, btnCheckMC9)
        checkboxBtnClearLogoutTabSub(lblOptNm10, btnCheckMC10)
        checkboxBtnClearLogoutTabSub(lblOptNm11, btnCheckMC11)
        checkboxBtnClearLogoutTabSub(lblOptNm12, btnCheckMC12)
        checkboxBtnClearLogoutTabSub(lblOptNm13, btnCheckMC13)
        checkboxBtnClearLogoutTabSub(lblOptNm14, btnCheckMC14)
        checkboxBtnClearLogoutTabSub(lblOptNm15, btnCheckMC15)
        checkboxBtnClearLogoutTabSub(lblOptNm16, btnCheckMC16)
        checkboxBtnClearLogoutTabSub(lblOptNm17, btnCheckMC17)
        checkboxBtnClearLogoutTabSub(lblOptNm18, btnCheckMC18)
        checkboxBtnClearLogoutTabSub(lblOptNm19, btnCheckMC19)
    End Sub
    '//

    '// SELECT AND CLEAR BUTTON ENABLE AND DISABLE CONDITION AT LOGIN TAB
    Public Sub btnEnable_Disable_at_Login()
        If (btnCheckMC1.IconChar = IconChar.None Or lblOptNm1.Text <> "-") And
                (btnCheckMC2.IconChar = IconChar.None Or lblOptNm2.Text <> "-") And
                (btnCheckMC3.IconChar = IconChar.None Or lblOptNm3.Text <> "-") And
                (btnCheckMC4.IconChar = IconChar.None Or lblOptNm4.Text <> "-") And
                (btnCheckMC5.IconChar = IconChar.None Or lblOptNm5.Text <> "-") And
                (btnCheckMC6.IconChar = IconChar.None Or lblOptNm6.Text <> "-") And
                (btnCheckMC7.IconChar = IconChar.None Or lblOptNm7.Text <> "-") And
                (btnCheckMC8.IconChar = IconChar.None Or lblOptNm8.Text <> "-") And
                (btnCheckMC9.IconChar = IconChar.None Or lblOptNm9.Text <> "-") And
                (btnCheckMC10.IconChar = IconChar.None Or lblOptNm10.Text <> "-") And
                (btnCheckMC11.IconChar = IconChar.None Or lblOptNm11.Text <> "-") And
                (btnCheckMC12.IconChar = IconChar.None Or lblOptNm12.Text <> "-") And
                (btnCheckMC13.IconChar = IconChar.None Or lblOptNm13.Text <> "-") And
                (btnCheckMC14.IconChar = IconChar.None Or lblOptNm14.Text <> "-") And
                (btnCheckMC15.IconChar = IconChar.None Or lblOptNm15.Text <> "-") And
                (btnCheckMC16.IconChar = IconChar.None Or lblOptNm16.Text <> "-") And
                (btnCheckMC17.IconChar = IconChar.None Or lblOptNm17.Text <> "-") And
                (btnCheckMC18.IconChar = IconChar.None Or lblOptNm18.Text <> "-") And
                (btnCheckMC19.IconChar = IconChar.None Or lblOptNm19.Text <> "-") Then
            btnMCSelect.Enabled = False
            btnMCSelClear.Enabled = False
        Else
            btnMCSelect.Enabled = True
            btnMCSelClear.Enabled = True
        End If
    End Sub
    '//

    '// SELECT AND CLEAR BUTTON ENABLE AND DISABLE CONDITION AT LOGOUT TAB
    Public Sub btnEnable_Disable_at_Logout()
        If (btnCheckMC1.IconChar = IconChar.Check Or lblOptNm1.Text = "-") And
                (btnCheckMC2.IconChar = IconChar.Check Or lblOptNm2.Text = "-") And
                (btnCheckMC3.IconChar = IconChar.Check Or lblOptNm3.Text = "-") And
                (btnCheckMC4.IconChar = IconChar.Check Or lblOptNm4.Text = "-") And
                (btnCheckMC5.IconChar = IconChar.Check Or lblOptNm5.Text = "-") And
                (btnCheckMC6.IconChar = IconChar.Check Or lblOptNm6.Text = "-") And
                (btnCheckMC7.IconChar = IconChar.Check Or lblOptNm7.Text = "-") And
                (btnCheckMC8.IconChar = IconChar.Check Or lblOptNm8.Text = "-") And
                (btnCheckMC9.IconChar = IconChar.Check Or lblOptNm9.Text = "-") And
                (btnCheckMC10.IconChar = IconChar.Check Or lblOptNm10.Text = "-") And
                (btnCheckMC11.IconChar = IconChar.Check Or lblOptNm11.Text = "-") And
                (btnCheckMC12.IconChar = IconChar.Check Or lblOptNm12.Text = "-") And
                (btnCheckMC13.IconChar = IconChar.Check Or lblOptNm13.Text = "-") And
                (btnCheckMC14.IconChar = IconChar.Check Or lblOptNm14.Text = "-") And
                (btnCheckMC15.IconChar = IconChar.Check Or lblOptNm15.Text = "-") And
                (btnCheckMC16.IconChar = IconChar.Check Or lblOptNm16.Text = "-") And
                (btnCheckMC17.IconChar = IconChar.Check Or lblOptNm17.Text = "-") And
                (btnCheckMC18.IconChar = IconChar.Check Or lblOptNm18.Text = "-") And
                (btnCheckMC19.IconChar = IconChar.Check Or lblOptNm19.Text = "-") Then
            btnMCSelect.Enabled = False
            btnMCSelClear.Enabled = False
        Else
            btnMCSelect.Enabled = True
            btnMCSelClear.Enabled = True
        End If
    End Sub
    '//

    '// CHECKBOX BUTTONS ENABLE AND DISABLE CONDTION AT LOGIN TAB
    Private Sub ckbBtnEnableDisable_Login(bol As Boolean, btn As IconButton)
        If bol = True Then
            btn.Enabled = False
        Else
            btn.Enabled = True
        End If
    End Sub
    Public Sub btnStat_at_Login() 'Checkbox Button (Enable,Disable) Status at Login Tab
        ckbBtnEnableDisable_Login(modUserLoginFlagMC1, btnCheckMC1)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC2, btnCheckMC2)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC3, btnCheckMC3)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC4, btnCheckMC4)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC5, btnCheckMC5)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC6, btnCheckMC6)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC7, btnCheckMC7)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC8, btnCheckMC8)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC9, btnCheckMC9)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC10, btnCheckMC10)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC11, btnCheckMC11)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC12, btnCheckMC12)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC13, btnCheckMC13)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC14, btnCheckMC14)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC15, btnCheckMC15)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC16, btnCheckMC16)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC17, btnCheckMC17)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC18, btnCheckMC18)
        ckbBtnEnableDisable_Login(modUserLoginFlagMC19, btnCheckMC19)
    End Sub
    '//

    '// CHECKBOX BUTTONS ENABLE / DISABLE AND VISIBILTY CONDITION AT LOGOUT TAB
    Private Sub ckbBtnEnableDisable_Visibility_Logout(bol As Boolean, btn1 As IconButton)
        If bol = True Then
            btn1.Visible = True
            btn1.Enabled = True
        Else
            btn1.Visible = False
        End If
    End Sub
    Public Sub btnStats_at_Logout() 'Checkbox Button (Enable,Disable & Visibility) Status at Logout Tab
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC1, btnCheckMC1)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC2, btnCheckMC2)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC3, btnCheckMC3)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC4, btnCheckMC4)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC5, btnCheckMC5)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC6, btnCheckMC6)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC7, btnCheckMC7)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC8, btnCheckMC8)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC9, btnCheckMC9)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC10, btnCheckMC10)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC11, btnCheckMC11)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC12, btnCheckMC12)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC13, btnCheckMC13)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC14, btnCheckMC14)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC15, btnCheckMC15)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC16, btnCheckMC16)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC17, btnCheckMC17)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC18, btnCheckMC18)
        ckbBtnEnableDisable_Visibility_Logout(modUserLoginFlagMC19, btnCheckMC19)
    End Sub
    '//

    '// DISPLAY COUNTER DETAILS TO LABEL TEXT
    Public Sub Counters()
        lblAO1.Text = CounterP1MC1
        lblAO2.Text = CounterP1MC2
        lblAO3.Text = CounterP1MC3
        lblAO4.Text = CounterP1MC4
        lblAO5.Text = CounterP1MC5
        lblAO6.Text = CounterP1MC6
        lblAO7.Text = CounterP1MC7
        lblAO8.Text = CounterP1MC8
        lblAO9.Text = CounterP1MC9
        lblAO10.Text = CounterP1MC10
        lblAO11.Text = CounterP1MC11
        lblAO12.Text = CounterP1MC12
        lblAO13.Text = CounterP1MC13
        lblAO14.Text = CounterP1MC14
        lblAO15.Text = CounterP1MC15
        lblAO16.Text = CounterP1MC16
        lblAO17.Text = CounterP1MC17
        lblAO18.Text = CounterP1MC18
        lblAO19.Text = CounterP1MC19

    End Sub
    '//

    '// INDICATOR IMAGES DURING MACHINE RUN, MACHINE STOP and PLAN COMPLETE
    Public Sub MCStatusPIC()
        Dim StatMC1 As New clsHomeMCStatusIndicator
        StatMC1.bolStartStop = StartStopMC1
        StatMC1.bolPlanComplete = RxPLCM14
        StatMC1.stJOPlan = stJOMC1
        StatMC1.McStatusIndicator()
        picStatMC1.Image = StatMC1.iStats_Indicator

        Dim StatMC2 As New clsHomeMCStatusIndicator
        StatMC2.bolStartStop = StartStopMC2
        StatMC2.bolPlanComplete = RxPLCM15
        StatMC2.stJOPlan = stJOMC2
        StatMC2.McStatusIndicator()
        picStatMC2.Image = StatMC2.iStats_Indicator
    End Sub
    '//

    '// MENU TABS STATE AND CONDITIONS
    Public Sub MenuTabStats()
        lblHomeTab.Text = menuTabHome
        lblLoginTab.Text = menuTabLogin
        lblLogoutTab.Text = menuTabLogout
        lblJobOrderTab.Text = menuTabWorkOrder
        lblSettingTab.Text = menuTabSetting
    End Sub
    Public Sub ckbButtonStatCheck()
        If menuTabHome = True Then
            ckbBtnVisibleFalse()
            checkboxBtnClearLoginTab()
            checkboxBtnClearLogoutTab()
            lblLogiLogNote.Text = ""
        ElseIf menuTabLogin = True Then
            checkboxBtnClearLogoutTab()
            ckbBtnVisibleTrue()
            btnStat_at_Login() 'Checkbox Button (Enable,Disable) Status at Login Tab
            lblLogiLogNote.Text = "Please Select the Machine to Login!"
            btnEnable_Disable_at_Login()
        ElseIf menuTabLogout = True Then
            checkboxBtnClearLoginTab()
            ckbBtnVisibleTrue()
            btnStats_at_Logout() 'Checkbox Button (Enable,Disable & Visibility) Status at Logout Tab
            lblLogiLogNote.Text = "Please Select the Machine to Logout!"
            btnEnable_Disable_at_Logout()
        ElseIf menuTabWorkOrder = True Then
            checkboxBtnClearLoginTab()
            checkboxBtnClearLogoutTab()
        ElseIf menuTabSetting = True Then
            checkboxBtnClearLoginTab()
            checkboxBtnClearLogoutTab()
        End If
    End Sub
    '//

    '// TIMER TICK Production Details Realtime Checking
    Private Sub ProdDetailsRealtimeCheck_Tick(sender As Object, e As EventArgs) Handles ProdDetailsRealtimeCheck.Tick
        Label10.Text = ComCheck_isTrue

        If ComCheck = "1" Then
            picComCheckOnOff.Image = My.Resources.indicator_green
        Else
        picComCheckOnOff.Image = My.Resources.indicator_red
        End If

        Label9.Text = modSetVal_SqlPath

        MenuTabStats()
        ckbButtonStatCheck()
        shiftUpdate()
        Counters()
        MCStatusPIC()
        JOLoadDetails()
        runtimeTimers()
        PPT()
        ART_actualRunningQuantity()
        machineONOFFStatUpdate()
        'MachineStop_Plancomplete()
        readPLCcounters()
        lblLoginInProgress.Text = modLogiInProgress
        lblLogoutInProgress.Text = modLogOutInProgress
        ConditionsToTriggerMachineOFF()

        If bolLoginConfirm = True Then
            ckbBtnConfirmed() 'Confirmed checked
            LoginConfirm()
            btnStat_at_Login() 'Checkbox Button (Enable,Disable) Status at Login Tab
            modLogiInProgress = True
            bolLoginConfirm = False
        End If

        If bolLogoutConfirm = True Then
            LogoutConfirm()

            btnStats_at_Logout() 'Checkbox Button (Enable,Disable & Visibility) Status
            modLogOutInProgress = True
            bolLogoutConfirm = False
        End If
    End Sub
    '//

    '// OPENG MACHINE DASHBOARD ACCORDING TO MACHINE NUMBER
    Private Sub MC1Dash_Click(ByVal sender As Object, e As System.EventArgs) _
        Handles PicMC1.Click, picMC2.Click, picMC3.Click, picMC4.Click, picMC5.Click _
        , picMC6.Click, picMC7.Click, picMC8.Click, picMC9.Click, picMC10.Click _
        , picMC11.Click, picMC12.Click, picMC13.Click, picMC14.Click, picMC15.Click _
        , picMC16.Click, picMC17.Click, picMC18.Click, picMC19.Click

        Dim currentPic As PictureBox = sender
        If currentPic.Tag = 1 Then bolMCDashboard1 = True
        If currentPic.Tag = 2 Then bolMCDashboard2 = True
        If currentPic.Tag = 3 Then bolMCDashboard3 = True
        If currentPic.Tag = 4 Then bolMCDashboard4 = True
        If currentPic.Tag = 5 Then bolMCDashboard5 = True
        If currentPic.Tag = 6 Then bolMCDashboard6 = True
        If currentPic.Tag = 7 Then bolMCDashboard7 = True
        If currentPic.Tag = 8 Then bolMCDashboard8 = True
        If currentPic.Tag = 9 Then bolMCDashboard9 = True
        If currentPic.Tag = 10 Then bolMCDashboard10 = True
        If currentPic.Tag = 11 Then bolMCDashboard11 = True
        If currentPic.Tag = 12 Then bolMCDashboard12 = True
        If currentPic.Tag = 13 Then bolMCDashboard13 = True
        If currentPic.Tag = 14 Then bolMCDashboard14 = True
        If currentPic.Tag = 15 Then bolMCDashboard15 = True
        If currentPic.Tag = 16 Then bolMCDashboard16 = True
        If currentPic.Tag = 17 Then bolMCDashboard17 = True
        If currentPic.Tag = 18 Then bolMCDashboard18 = True
        If currentPic.Tag = 19 Then bolMCDashboard19 = True
        frmMCDasboard.ShowDialog()
    End Sub
    '//

    '// SWITCH CHECKBOX BUTTON FROM UNCHECKED TO CHECKED AND VICE VERSA
    Private Sub CheckBtn_Click(ByVal sender As Object, e As System.EventArgs) _
        Handles btnCheckMC1.Click, btnCheckMC2.Click, btnCheckMC3.Click, btnCheckMC4.Click, btnCheckMC5.Click _
        , btnCheckMC6.Click, btnCheckMC7.Click, btnCheckMC8.Click, btnCheckMC9.Click, btnCheckMC10.Click _
        , btnCheckMC11.Click, btnCheckMC12.Click, btnCheckMC13.Click, btnCheckMC14.Click, btnCheckMC15.Click _
        , btnCheckMC16.Click, btnCheckMC17.Click, btnCheckMC18.Click, btnCheckMC19.Click

        Dim currentBtn As IconButton = sender
        If currentBtn.IconChar = IconChar.None Then
            currentBtn.IconChar = IconChar.Check
        ElseIf currentBtn.IconChar = IconChar.Check Then
            currentBtn.IconChar = IconChar.None
        End If

        If menuTabLogin = True Then
            If modUserLoginFlagMC1 = False And btnCheckMC1.IconChar = IconChar.Check Then modTempCheckMC1 = True
            If modUserLoginFlagMC2 = False And btnCheckMC2.IconChar = IconChar.Check Then modTempCheckMC2 = True
            If modUserLoginFlagMC3 = False And btnCheckMC3.IconChar = IconChar.Check Then modTempCheckMC3 = True
            If modUserLoginFlagMC4 = False And btnCheckMC4.IconChar = IconChar.Check Then modTempCheckMC4 = True
            If modUserLoginFlagMC5 = False And btnCheckMC5.IconChar = IconChar.Check Then modTempCheckMC5 = True
            If modUserLoginFlagMC6 = False And btnCheckMC6.IconChar = IconChar.Check Then modTempCheckMC6 = True
            If modUserLoginFlagMC7 = False And btnCheckMC7.IconChar = IconChar.Check Then modTempCheckMC7 = True
            If modUserLoginFlagMC8 = False And btnCheckMC8.IconChar = IconChar.Check Then modTempCheckMC8 = True
            If modUserLoginFlagMC9 = False And btnCheckMC9.IconChar = IconChar.Check Then modTempCheckMC9 = True
            If modUserLoginFlagMC10 = False And btnCheckMC10.IconChar = IconChar.Check Then modTempCheckMC10 = True
            If modUserLoginFlagMC11 = False And btnCheckMC11.IconChar = IconChar.Check Then modTempCheckMC11 = True
            If modUserLoginFlagMC12 = False And btnCheckMC12.IconChar = IconChar.Check Then modTempCheckMC12 = True
            If modUserLoginFlagMC13 = False And btnCheckMC13.IconChar = IconChar.Check Then modTempCheckMC13 = True
            If modUserLoginFlagMC14 = False And btnCheckMC14.IconChar = IconChar.Check Then modTempCheckMC14 = True
            If modUserLoginFlagMC15 = False And btnCheckMC15.IconChar = IconChar.Check Then modTempCheckMC15 = True
            If modUserLoginFlagMC16 = False And btnCheckMC16.IconChar = IconChar.Check Then modTempCheckMC16 = True
            If modUserLoginFlagMC17 = False And btnCheckMC17.IconChar = IconChar.Check Then modTempCheckMC17 = True
            If modUserLoginFlagMC18 = False And btnCheckMC18.IconChar = IconChar.Check Then modTempCheckMC18 = True
            If modUserLoginFlagMC19 = False And btnCheckMC19.IconChar = IconChar.Check Then modTempCheckMC19 = True
        End If
    End Sub
    '//

    '// CONFIRMING BUTTON CHECKBOX FROM CHECKED OR UNCHECKED
    Public Sub ckbBtnConfirmed() 'Confirmed checked
        If modTempCheckMC1 = True Then modUserLoginFlagMC1 = True
        If modTempCheckMC2 = True Then modUserLoginFlagMC2 = True
        If modTempCheckMC3 = True Then modUserLoginFlagMC3 = True
        If modTempCheckMC4 = True Then modUserLoginFlagMC4 = True
        If modTempCheckMC5 = True Then modUserLoginFlagMC5 = True
        If modTempCheckMC6 = True Then modUserLoginFlagMC6 = True
        If modTempCheckMC7 = True Then modUserLoginFlagMC7 = True
        If modTempCheckMC8 = True Then modUserLoginFlagMC8 = True
        If modTempCheckMC9 = True Then modUserLoginFlagMC9 = True
        If modTempCheckMC10 = True Then modUserLoginFlagMC10 = True
        If modTempCheckMC11 = True Then modUserLoginFlagMC11 = True
        If modTempCheckMC12 = True Then modUserLoginFlagMC12 = True
        If modTempCheckMC13 = True Then modUserLoginFlagMC13 = True
        If modTempCheckMC14 = True Then modUserLoginFlagMC14 = True
        If modTempCheckMC15 = True Then modUserLoginFlagMC15 = True
        If modTempCheckMC16 = True Then modUserLoginFlagMC16 = True
        If modTempCheckMC17 = True Then modUserLoginFlagMC17 = True
        If modTempCheckMC18 = True Then modUserLoginFlagMC18 = True
        If modTempCheckMC19 = True Then modUserLoginFlagMC19 = True

        If btnCheckMC1.IconChar = IconChar.None Then modUserLoginFlagMC1 = False
        If btnCheckMC2.IconChar = IconChar.None Then modUserLoginFlagMC2 = False
        If btnCheckMC3.IconChar = IconChar.None Then modUserLoginFlagMC3 = False
        If btnCheckMC4.IconChar = IconChar.None Then modUserLoginFlagMC4 = False
        If btnCheckMC5.IconChar = IconChar.None Then modUserLoginFlagMC5 = False
        If btnCheckMC6.IconChar = IconChar.None Then modUserLoginFlagMC6 = False
        If btnCheckMC7.IconChar = IconChar.None Then modUserLoginFlagMC7 = False
        If btnCheckMC8.IconChar = IconChar.None Then modUserLoginFlagMC8 = False
        If btnCheckMC9.IconChar = IconChar.None Then modUserLoginFlagMC9 = False
        If btnCheckMC10.IconChar = IconChar.None Then modUserLoginFlagMC10 = False
        If btnCheckMC11.IconChar = IconChar.None Then modUserLoginFlagMC11 = False
        If btnCheckMC12.IconChar = IconChar.None Then modUserLoginFlagMC12 = False
        If btnCheckMC13.IconChar = IconChar.None Then modUserLoginFlagMC13 = False
        If btnCheckMC14.IconChar = IconChar.None Then modUserLoginFlagMC14 = False
        If btnCheckMC15.IconChar = IconChar.None Then modUserLoginFlagMC15 = False
        If btnCheckMC16.IconChar = IconChar.None Then modUserLoginFlagMC16 = False
        If btnCheckMC17.IconChar = IconChar.None Then modUserLoginFlagMC17 = False
        If btnCheckMC18.IconChar = IconChar.None Then modUserLoginFlagMC18 = False
        If btnCheckMC19.IconChar = IconChar.None Then modUserLoginFlagMC19 = False
    End Sub
    '//

    '// CLEAR TEMPCHECKBOX
    Public Sub ClearTempCheckbox()
        modTempCheckMC1 = False
        modTempCheckMC2 = False
        modTempCheckMC3 = False
        modTempCheckMC4 = False
        modTempCheckMC5 = False
        modTempCheckMC6 = False
        modTempCheckMC7 = False
        modTempCheckMC8 = False
        modTempCheckMC9 = False
        modTempCheckMC10 = False
        modTempCheckMC11 = False
        modTempCheckMC12 = False
        modTempCheckMC13 = False
        modTempCheckMC14 = False
        modTempCheckMC15 = False
        modTempCheckMC16 = False
        modTempCheckMC17 = False
        modTempCheckMC18 = False
        modTempCheckMC19 = False
    End Sub
    '//

    '// BUTTON CLEAR FOR BUTTON CHECKBOX
    Private Sub btnMCSelClear_Click(sender As Object, e As EventArgs) Handles btnMCSelClear.Click
        checkboxBtnClearLoginTab()
        checkboxBtnClearLogoutTab()
    End Sub
    '//

    '// BUTTON SELECT INITIATES USER LOGIN LOGOUT VERIFICATION
    Private Sub btnMCSelect_Click(sender As Object, e As EventArgs) Handles btnMCSelect.Click
        If menuTabLogin = True Then
            frmSelToLogin.ShowDialog()
        End If
        If menuTabLogout = True Then
            Dim i As Integer
            i = (MessageBox.Show("Machine will stop in a few seconds!" &
                                 vbNewLine & "Do want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            'result = 6
            If i = 6 Then
                bolLogoutConfirm = True
            Else
                checkboxBtnClearLogoutTab()
            End If
        End If
    End Sub
    '//

    '// MACHINE RUN-TIME START/STOP TIMER
    Private Sub runtimeTimersSub(bol As Boolean, tim As Timer)
        If bol = True Then
            tim.Start()
        Else
            tim.Stop()
        End If
    End Sub
    Public Sub runtimeTimers()
        runtimeTimersSub(StartStopMC1, timMC1)
        runtimeTimersSub(StartStopMC2, timMC2)
        runtimeTimersSub(StartStopMC3, timMC3)
        runtimeTimersSub(StartStopMC4, timMC4)
        runtimeTimersSub(StartStopMC5, timMC5)
        runtimeTimersSub(StartStopMC6, timMC6)
        runtimeTimersSub(StartStopMC7, timMC7)
        runtimeTimersSub(StartStopMC8, timMC8)
        runtimeTimersSub(StartStopMC9, timMC9)
        runtimeTimersSub(StartStopMC10, timMC10)
        runtimeTimersSub(StartStopMC11, timMC11)
        runtimeTimersSub(StartStopMC12, timMC12)
        runtimeTimersSub(StartStopMC13, timMC13)
        runtimeTimersSub(StartStopMC14, timMC14)
        runtimeTimersSub(StartStopMC15, timMC15)
        runtimeTimersSub(StartStopMC16, timMC16)
        runtimeTimersSub(StartStopMC17, timMC17)
        runtimeTimersSub(StartStopMC18, timMC18)
        runtimeTimersSub(StartStopMC19, timMC19)
    End Sub
    '//

    '// MACHINE RUNTIME TIMERS
    Private Sub RunTime_Tick(ByVal sender As Object, e As System.EventArgs) _
        Handles timMC1.Tick, timMC2.Tick, timMC3.Tick, timMC4.Tick, timMC5.Tick _
        , timMC6.Tick, timMC7.Tick, timMC8.Tick, timMC9.Tick, timMC10.Tick _
        , timMC11.Tick, timMC12.Tick, timMC13.Tick, timMC14.Tick, timMC15.Tick _
        , timMC16.Tick, timMC17.Tick, timMC18.Tick, timMC19.Tick

        Dim currentTime As Timer = sender
        If currentTime.Tag = 1 And RxPLCM12 = False Then runtimeMC1 += 1
        If currentTime.Tag = 2 And RxPLCM13 = False Then runtimeMC2 += 1
        If currentTime.Tag = 3 Then runtimeMC3 += 1
        If currentTime.Tag = 4 Then runtimeMC4 += 1
        If currentTime.Tag = 5 Then runtimeMC5 += 1
        If currentTime.Tag = 6 Then runtimeMC6 += 1
        If currentTime.Tag = 7 Then runtimeMC7 += 1
        If currentTime.Tag = 8 Then runtimeMC8 += 1
        If currentTime.Tag = 9 Then runtimeMC9 += 1
        If currentTime.Tag = 10 Then runtimeMC10 += 1
        If currentTime.Tag = 11 Then runtimeMC11 += 1
        If currentTime.Tag = 12 Then runtimeMC12 += 1
        If currentTime.Tag = 13 Then runtimeMC13 += 1
        If currentTime.Tag = 14 Then runtimeMC14 += 1
        If currentTime.Tag = 15 Then runtimeMC15 += 1
        If currentTime.Tag = 16 Then runtimeMC16 += 1
        If currentTime.Tag = 17 Then runtimeMC17 += 1
        If currentTime.Tag = 18 Then runtimeMC18 += 1
        If currentTime.Tag = 19 Then runtimeMC19 += 1
    End Sub
    '//

    '// PLANNED PRODUCTION TIME COMPUTATION CODING
    Function PlannedProductionTime(Cavity1 As Integer, Cavity2 As Integer, CycleTime As Integer, JOQuantity As Integer) As Decimal
        Dim decMold45 As Decimal
        'decMold45 = (CycleTime / (Cavity1 + Cavity2)) * JOQuantity 'in seconds
        decMold45 = (CycleTime / (Cavity1 + Cavity2)) * JOQuantity / 60 'in minutes
        Return decMold45
    End Function
    Public Sub PPT()
        'Try
        If stJOCycleTimeMC1 <> "" And stJOMoldCavP1MC1 <> "" And stJOMoldCavP2MC1 <> "" And stJOQuantityMC1 <> "" Then
            iPlanProdTimeMC1 = ((CInt(stJOCycleTimeMC1) / ((CInt(stJOMoldCavP1MC1) + CInt(stJOMoldCavP2MC1))) * CInt(stJOQuantityMC1)) / 60)
        End If

        If stJOCycleTimeMC2 <> "" And stJOMoldCavP1MC2 <> "" And stJOMoldCavP2MC2 <> "" And stJOQuantityMC2 <> "" Then
            iPlanProdTimeMC2 = ((CInt(stJOCycleTimeMC2) / ((CInt(stJOMoldCavP1MC2) + CInt(stJOMoldCavP2MC2))) * CInt(stJOQuantityMC2)) / 60)
        End If

        'iPlanProdTimeMC3 = ((CInt(stJOCycleTimeMC3) / ((CInt(stJOMoldCavP1MC3) + CInt(stJOMoldCavP2MC3))) * CInt(stJOQuantityMC3)) / 60)
        'iPlanProdTimeMC4 = ((CInt(stJOCycleTimeMC4) / ((CInt(stJOMoldCavP1MC4) + CInt(stJOMoldCavP2MC4))) * CInt(stJOQuantityMC4)) / 60)
        'iPlanProdTimeMC5 = ((CInt(stJOCycleTimeMC5) / ((CInt(stJOMoldCavP1MC5) + CInt(stJOMoldCavP2MC5))) * CInt(stJOQuantityMC5)) / 60)
        'iPlanProdTimeMC6 = ((CInt(stJOCycleTimeMC6) / ((CInt(stJOMoldCavP1MC6) + CInt(stJOMoldCavP2MC6))) * CInt(stJOQuantityMC6)) / 60)
        'iPlanProdTimeMC7 = ((CInt(stJOCycleTimeMC7) / ((CInt(stJOMoldCavP1MC7) + CInt(stJOMoldCavP2MC7))) * CInt(stJOQuantityMC7)) / 60)
        'iPlanProdTimeMC8 = ((CInt(stJOCycleTimeMC8) / ((CInt(stJOMoldCavP1MC8) + CInt(stJOMoldCavP2MC8))) * CInt(stJOQuantityMC8)) / 60)
        'iPlanProdTimeMC9 = ((CInt(stJOCycleTimeMC9) / ((CInt(stJOMoldCavP1MC9) + CInt(stJOMoldCavP2MC9))) * CInt(stJOQuantityMC9)) / 60)
        'iPlanProdTimeMC10 = ((CInt(stJOCycleTimeMC10) / ((CInt(stJOMoldCavP1MC10) + CInt(stJOMoldCavP2MC10))) * CInt(stJOQuantityMC10)) / 60)
        'iPlanProdTimeMC11 = ((CInt(stJOCycleTimeMC11) / ((CInt(stJOMoldCavP1MC11) + CInt(stJOMoldCavP2MC11))) * CInt(stJOQuantityMC11)) / 60)
        'iPlanProdTimeMC12 = ((CInt(stJOCycleTimeMC12) / ((CInt(stJOMoldCavP1MC12) + CInt(stJOMoldCavP2MC12))) * CInt(stJOQuantityMC12)) / 60)
        'iPlanProdTimeMC13 = ((CInt(stJOCycleTimeMC13) / ((CInt(stJOMoldCavP1MC13) + CInt(stJOMoldCavP2MC13))) * CInt(stJOQuantityMC13)) / 60)
        'iPlanProdTimeMC14 = ((CInt(stJOCycleTimeMC14) / ((CInt(stJOMoldCavP1MC14) + CInt(stJOMoldCavP2MC14))) * CInt(stJOQuantityMC14)) / 60)
        'iPlanProdTimeMC15 = ((CInt(stJOCycleTimeMC15) / ((CInt(stJOMoldCavP1MC15) + CInt(stJOMoldCavP2MC15))) * CInt(stJOQuantityMC15)) / 60)
        'iPlanProdTimeMC16 = ((CInt(stJOCycleTimeMC16) / ((CInt(stJOMoldCavP1MC16) + CInt(stJOMoldCavP2MC16))) * CInt(stJOQuantityMC16)) / 60)
        'iPlanProdTimeMC17 = ((CInt(stJOCycleTimeMC17) / ((CInt(stJOMoldCavP1MC17) + CInt(stJOMoldCavP2MC17))) * CInt(stJOQuantityMC17)) / 60)
        'iPlanProdTimeMC18 = ((CInt(stJOCycleTimeMC18) / ((CInt(stJOMoldCavP1MC18) + CInt(stJOMoldCavP2MC18))) * CInt(stJOQuantityMC18)) / 60)
        'iPlanProdTimeMC19 = ((CInt(stJOCycleTimeMC19) / ((CInt(stJOMoldCavP1MC19) + CInt(stJOMoldCavP2MC19))) * CInt(stJOQuantityMC19)) / 60)
        'Catch ex As Exception
        '    MsgBox(ex.Message & " This the the one !")
        'End Try
    End Sub
    '//

    '// READ PLC COUNTERS
    Public Sub readPLCcounters()

        If stJOMoldCavP1MC1 <> "" Then CounterP1MC1 = D2002 * CInt(stJOMoldCavP1MC1)
        If stJOMoldCavP2MC1 <> "" Then CounterP2MC1 = D2002 * CInt(stJOMoldCavP2MC1)
        If stJOMoldCavP1MC2 <> "" Then CounterP1MC2 = D2004 * CInt(stJOMoldCavP1MC2)
        If stJOMoldCavP2MC2 <> "" Then CounterP2MC2 = D2004 * CInt(stJOMoldCavP2MC2)

    End Sub
    '//

    '// ACTUAL TOTAL RUNNING QUANTITY
    Public Sub ART_actualRunningQuantity()
        Try
            If CounterP1MC1 <> "" And CounterP2MC1 <> "" Then TotalCountMC1 = CInt(CounterP1MC1) + CInt(CounterP2MC1)
            If CounterP1MC2 <> "" And CounterP2MC2 <> "" Then TotalCountMC2 = CInt(CounterP1MC2) + CInt(CounterP2MC2)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Reading Actual Running Quantity...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '// MACHINE START/STOP STATUS UPDATE
    Public Sub machineONOFFStatUpdate()
        lblOnOffMC1.Text = RxPLCM0
        lblOnOffMC2.Text = RxPLCM1

    End Sub
    Private Sub lblOnOffMC1_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC1.TextChanged
        If lblOnOffMC1.Text = "True" Then
            StartStopMC1 = True
        Else
            StartStopMC1 = False
        End If
    End Sub
    Private Sub lblOnOffMC2_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC2.TextChanged
        If lblOnOffMC2.Text = "True" Then
            StartStopMC2 = True
        Else
            StartStopMC2 = False
        End If
    End Sub

    'Private Sub lblOnOffMC3_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC3.TextChanged
    '    If lblOnOffMC3.Text = "True" Then
    '        bolMachine3 = True
    '        StartStopMC3 = True
    '    Else
    '        StartStopMC3 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC4_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC4.TextChanged
    '    If lblOnOffMC4.Text = "True" Then
    '        bolMachine4 = True
    '        StartStopMC4 = True
    '    Else
    '        StartStopMC4 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC5_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC5.TextChanged
    '    If lblOnOffMC5.Text = "True" Then
    '        bolMachine5 = True
    '        StartStopMC5 = True
    '    Else
    '        StartStopMC5 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC6_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC6.TextChanged
    '    If lblOnOffMC6.Text = "True" Then
    '        bolMachine6 = True
    '        StartStopMC6 = True
    '    Else
    '        StartStopMC6 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC7_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC7.TextChanged
    '    If lblOnOffMC7.Text = "True" Then
    '        bolMachine7 = True
    '        StartStopMC7 = True
    '    Else
    '        StartStopMC7 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC8_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC8.TextChanged
    '    If lblOnOffMC8.Text = "True" Then
    '        bolMachine8 = True
    '        StartStopMC8 = True
    '    Else
    '        StartStopMC8 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC9_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC9.TextChanged
    '    If lblOnOffMC9.Text = "True" Then
    '        bolMachine9 = True
    '        StartStopMC9 = True
    '    Else
    '        StartStopMC9 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC10_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC10.TextChanged
    '    If lblOnOffMC10.Text = "True" Then
    '        bolMachine10 = True
    '        StartStopMC10 = True
    '    Else
    '        StartStopMC10 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC11_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC11.TextChanged
    '    If lblOnOffMC11.Text = "True" Then
    '        bolMachine11 = True
    '        StartStopMC11 = True
    '    Else
    '        StartStopMC11 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC12_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC12.TextChanged
    '    If lblOnOffMC12.Text = "True" Then
    '        bolMachine12 = True
    '        StartStopMC12 = True
    '    Else
    '        StartStopMC12 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC13_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC13.TextChanged
    '    If lblOnOffMC13.Text = "True" Then
    '        bolMachine13 = True
    '        StartStopMC13 = True
    '    Else
    '        StartStopMC13 = False
    '    End If
    'End Sub

    'Private Sub lblOnOffMC14_TextChanged(sender As Object, e As EventArgs) Handles lblOnOffMC14.TextChanged
    '    If lblOnOffMC14.Text = "True" Then
    '        bolMachine14 = True
    '        StartStopMC14 = True
    '    Else
    '        StartStopMC14 = False
    '    End If
    'End Sub
    '//

    '// LOGING DETAILS SQL TABLE UPGDATE COMMAND
    Public Sub UpdateUserLogin()
        'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim sqlProc As String = "UpdateProLoginDetails"
        Dim con As New SqlConnection(modSetVal_SqlPath) 'Strings set in  My.Setting
        Using cmd As SqlCommand = New SqlCommand(sqlProc, con)
            cmd.Parameters.AddWithValue("@UserName", modMCUnNow)
            cmd.Parameters.AddWithValue("@UserID", modMCUNIdNow)
            cmd.Parameters.AddWithValue("@AccessLvl", modMCAcLvlNow)
            cmd.Parameters.AddWithValue("@MachId", modMCIdNow)
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
    '//

    '// CLEAR ALL LOGIN DETAILS IN SQL LOGIN DETAILS TABLE
    Public Sub UpdateUserLogin_ClearLoginDetails()
        'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim sqlProc As String = "UpdateProLoginDetailsClear"
        Dim con As New SqlConnection(modSetVal_SqlPath) 'Strings set in  My.Setting
        Using cmd As SqlCommand = New SqlCommand(sqlProc, con)
            cmd.Parameters.AddWithValue("@UserName", "none")
            cmd.Parameters.AddWithValue("@UserID", "none")
            cmd.Parameters.AddWithValue("@AccessLvl", "none")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()



        End Using
    End Sub
    '//

    '// UPDATING LOGIN DETAILS DURING LAOGIN (TEXT CHNAGE PROPERTIES)
    Private Sub lblLoginInProgress_TextChanged(sender As Object, e As EventArgs) Handles lblLoginInProgress.TextChanged
        If modSetVal_SqlPath IsNot Nothing Then
            CheckAndUpdateMachineLog_AtLogin()
        End If

        ClearUserDetailInputs()
        ClearTempCheckbox()
        modLogiInProgress = False
    End Sub
    Public Sub CheckAndUpdateMachineLog_AtLogin()
        If modUserLoginFlagMC1 = True And modTempCheckMC1 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC1_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC2 = True And modTempCheckMC2 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC2_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC3 = True And modTempCheckMC3 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC3_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC4 = True And modTempCheckMC4 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC4_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC5 = True And modTempCheckMC5 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC5_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC6 = True And modTempCheckMC6 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC6_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC7 = True And modTempCheckMC7 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC7_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC8 = True And modTempCheckMC8 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC8_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC9 = True And modTempCheckMC9 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC9_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC10 = True And modTempCheckMC10 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC10_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC11 = True And modTempCheckMC11 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC11_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC12 = True And modTempCheckMC12 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC12_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC13 = True And modTempCheckMC13 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC13_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC14 = True And modTempCheckMC14 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC14_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC15 = True And modTempCheckMC15 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC15_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC16 = True And modTempCheckMC16 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC16_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC17 = True And modTempCheckMC17 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC17_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC18 = True And modTempCheckMC18 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC18_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC19 = True And modTempCheckMC19 = True Then
            modMCUnNow = stUserName
            modMCUNIdNow = stUserID
            modMCAcLvlNow = stAccessLvl
            modMCIdNow = modMC19_stMCId
            UpdateUserLogin()
        End If
    End Sub
    '//

    '// UPDATING LOGING DETAILS TABLE DURING LOGOUT (TEXT CHANGE PROPERTIES)
    Private Sub lblLogoutInProgress_TextChanged(sender As Object, e As EventArgs) Handles lblLogoutInProgress.TextChanged
        ckbBtnConfirmed() 'Confirmed checked
        If modSetVal_SqlPath IsNot Nothing Then
            CheckAndUpdateMachineLog_AtLogOut()
        End If

        modLogOutInProgress = False
    End Sub
    Public Sub CheckAndUpdateMachineLog_AtLogOut()
        If modUserLoginFlagMC1 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC1_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC2 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC2_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC3 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC3_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC4 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC4_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC5 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC5_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC6 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC6_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC7 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC7_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC8 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC8_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC9 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC9_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC10 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC10_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC11 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC11_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC12 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC12_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC13 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC13_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC14 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC14_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC15 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC15_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC16 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC16_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC17 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC17_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC18 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC18_stMCId
            UpdateUserLogin()
        End If
        If modUserLoginFlagMC19 = False Then
            modMCUnNow = "none"
            modMCUNIdNow = "none"
            modMCAcLvlNow = "none"
            modMCIdNow = modMC19_stMCId
            UpdateUserLogin()
        End If
    End Sub
    '//

    '// CONDITIONS THAT WILL TRIGGER THE MACHINE TO STOP
    Public Sub ConditionsToTriggerMachineOFF()
        'MC1
        If modUserLoginFlagMC1 = False _
            Or (stJOMC1 = "-" Or stJOMC1 = Nothing) Then
            modMC1Stop_logoutOrNoJO = True
        Else
            modMC1Stop_logoutOrNoJO = False
        End If
        'MC2
        If modUserLoginFlagMC2 = False _
            Or (stJOMC2 = "-" Or stJOMC2 = Nothing) Then
            modMC2Stop_logoutOrNoJO = True
        Else
            modMC2Stop_logoutOrNoJO = False
        End If
    End Sub
    '//

End Class
