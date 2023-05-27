Public Class clsHomeMCStatusIndicator
    Public iStats_Indicator As Bitmap
    Public bolStartStop As Boolean
    Public bolPlanComplete As Boolean
    Public stJOPlan As String

    Public Sub McStatusIndicator()
        If bolStartStop = True Then
            iStats_Indicator = My.Resources.LineRun
        ElseIf bolStartStop = False And stJOPlan = "" Then
            iStats_Indicator = My.Resources.LineNoPlan
        Else
            iStats_Indicator = My.Resources.LineStop
        End If
    End Sub

End Class
