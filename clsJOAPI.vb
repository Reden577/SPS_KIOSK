Imports Newtonsoft.Json

Public Class clsJOAPI
    Public Class Result

        <JsonProperty("JOB_ORDER")>
        Public Property JOBORDER As String

        '<JsonProperty("PART_NO_1")>
        'Public Property PARTNO1 As String

        <JsonProperty("JOB_ORDER_QTY")>
        Public Property JOBORDERQTY As Double

        <JsonProperty("MOLD_ID")>
        Public Property MOLDID As String

        <JsonProperty("MACHINE_ID")>
        Public Property MACHINEID As String

        '<JsonProperty("MOLD_SETUP_START")>
        'Public Property MOLDSETUPSTART As String

        '<JsonProperty("MOLD_SETUP_END")>
        'Public Property MOLDSETUPEND As String

        '<JsonProperty("FIRST_BUYOFF_START")>
        'Public Property FIRSTBUYOFFSTART As String

        '<JsonProperty("FIRST_BUYOFF_END")>
        'Public Property FIRSTBUYOFFEND As String

        '<JsonProperty("MASS_PRODUCTION_START")>
        'Public Property MASSPRODUCTIONSTART As String

        '<JsonProperty("MASS_PRODUCTION_END")>
        'Public Property MASSPRODUCTIONEND As String
    End Class

    Public Class JSON_JobOrder

        <JsonProperty("Status")>
        Public Property Status As String

        <JsonProperty("Message")>
        Public Property Message As String

        <JsonProperty("Result")>
        Public Property Result As Result()
    End Class

End Class
