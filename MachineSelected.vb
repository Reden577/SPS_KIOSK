Module MachineSelected
    Public bolMachine1 As Boolean
    Public bolMachine2 As Boolean
    Public bolMachine3 As Boolean
    Public bolMachine4 As Boolean
    Public bolMachine5 As Boolean
    Public bolMachine6 As Boolean
    Public bolMachine7 As Boolean
    Public bolMachine8 As Boolean
    Public bolMachine9 As Boolean
    Public bolMachine10 As Boolean
    Public bolMachine11 As Boolean
    Public bolMachine12 As Boolean
    Public bolMachine13 As Boolean
    Public bolMachine14 As Boolean
    Public bolMachine15 As Boolean
    Public bolMachine16 As Boolean
    Public bolMachine17 As Boolean
    Public bolMachine18 As Boolean
    Public bolMachine19 As Boolean
    Public bolMachine20 As Boolean

    Public bolLoginConfirm As Boolean
    Public bolLogoutConfirm As Boolean
    Public stUserName As String
    Public stUserID As String
    Public stAccessLvl As String

End Module

Module MachineUserName
    Public UNmc1 As String
    Public UNmc2 As String
    Public UNmc3 As String
    Public UNmc4 As String
    Public UNmc5 As String
    Public UNmc6 As String
    Public UNmc7 As String
    Public UNmc8 As String
    Public UNmc9 As String
    Public UNmc10 As String
    Public UNmc11 As String
    Public UNmc12 As String
    Public UNmc13 As String
    Public UNmc14 As String
    Public UNmc15 As String
    Public UNmc16 As String
    Public UNmc17 As String
    Public UNmc18 As String
    Public UNmc19 As String

    Public UNIdmc1 As String
    Public UNIdmc2 As String
    Public UNIdmc3 As String
    Public UNIdmc4 As String
    Public UNIdmc5 As String
    Public UNIdmc6 As String
    Public UNIdmc7 As String
    Public UNIdmc8 As String
    Public UNIdmc9 As String
    Public UNIdmc10 As String
    Public UNIdmc11 As String
    Public UNIdmc12 As String
    Public UNIdmc13 As String
    Public UNIdmc14 As String
    Public UNIdmc15 As String
    Public UNIdmc16 As String
    Public UNIdmc17 As String
    Public UNIdmc18 As String
    Public UNIdmc19 As String

    'USER LOGGED IN FLAG
    Public modUserLoginFlagMC1 As Boolean
    Public modUserLoginFlagMC2 As Boolean
    Public modUserLoginFlagMC3 As Boolean
    Public modUserLoginFlagMC4 As Boolean
    Public modUserLoginFlagMC5 As Boolean
    Public modUserLoginFlagMC6 As Boolean
    Public modUserLoginFlagMC7 As Boolean
    Public modUserLoginFlagMC8 As Boolean
    Public modUserLoginFlagMC9 As Boolean
    Public modUserLoginFlagMC10 As Boolean
    Public modUserLoginFlagMC11 As Boolean
    Public modUserLoginFlagMC12 As Boolean
    Public modUserLoginFlagMC13 As Boolean
    Public modUserLoginFlagMC14 As Boolean
    Public modUserLoginFlagMC15 As Boolean
    Public modUserLoginFlagMC16 As Boolean
    Public modUserLoginFlagMC17 As Boolean
    Public modUserLoginFlagMC18 As Boolean
    Public modUserLoginFlagMC19 As Boolean

    Public modTempCheckMC1 As Boolean
    Public modTempCheckMC2 As Boolean
    Public modTempCheckMC3 As Boolean
    Public modTempCheckMC4 As Boolean
    Public modTempCheckMC5 As Boolean
    Public modTempCheckMC6 As Boolean
    Public modTempCheckMC7 As Boolean
    Public modTempCheckMC8 As Boolean
    Public modTempCheckMC9 As Boolean
    Public modTempCheckMC10 As Boolean
    Public modTempCheckMC11 As Boolean
    Public modTempCheckMC12 As Boolean
    Public modTempCheckMC13 As Boolean
    Public modTempCheckMC14 As Boolean
    Public modTempCheckMC15 As Boolean
    Public modTempCheckMC16 As Boolean
    Public modTempCheckMC17 As Boolean
    Public modTempCheckMC18 As Boolean
    Public modTempCheckMC19 As Boolean

    Public modMC1_stMCId As String = "MC1"
    Public modMC2_stMCId As String = "MC2"
    Public modMC3_stMCId As String = "MC3"
    Public modMC4_stMCId As String = "MC4"
    Public modMC5_stMCId As String = "MC5"
    Public modMC6_stMCId As String = "MC6"
    Public modMC7_stMCId As String = "MC7"
    Public modMC8_stMCId As String = "MC8"
    Public modMC9_stMCId As String = "MC9"
    Public modMC10_stMCId As String = "MC10"
    Public modMC11_stMCId As String = "MC11"
    Public modMC12_stMCId As String = "MC12"
    Public modMC13_stMCId As String = "MC13"
    Public modMC14_stMCId As String = "MC14"
    Public modMC15_stMCId As String = "MC15"
    Public modMC16_stMCId As String = "MC16"
    Public modMC17_stMCId As String = "MC16"
    Public modMC18_stMCId As String = "MC18"
    Public modMC19_stMCId As String = "MC19"

    Public modMC1_stDTComplete As String = "MC1DTComplete"
    Public modMC2_stDTComplete As String = "MC2DTComplete"
    Public modMC3_stDTComplete As String = "MC3DTComplete"
    Public modMC4_stDTComplete As String = "MC4DTComplete"
    Public modMC5_stDTComplete As String = "MC5DTComplete"
    Public modMC6_stDTComplete As String = "MC6DTComplete"
    Public modMC7_stDTComplete As String = "MC7DTComplete"
    Public modMC8_stDTComplete As String = "MC8DTComplete"
    Public modMC9_stDTComplete As String = "MC9DTComplete"
    Public modMC10_stDTComplete As String = "MC10DTComplete"
    Public modMC11_stDTComplete As String = "MC11DTComplete"
    Public modMC12_stDTComplete As String = "MC12DTComplete"
    Public modMC13_stDTComplete As String = "MC13DTComplete"
    Public modMC14_stDTComplete As String = "MC14DTComplete"
    Public modMC15_stDTComplete As String = "MC15DTComplete"
    Public modMC16_stDTComplete As String = "MC16DTComplete"
    Public modMC17_stDTComplete As String = "MC17DTComplete"
    Public modMC18_stDTComplete As String = "MC18DTComplete"
    Public modMC19_stDTComplete As String = "MC19DTComplete"

    Public modMC1_stNewStoppage As String = "MC1NewStoppage"
    Public modMC2_stNewStoppage As String = "MC2NewStoppage"
    Public modMC3_stNewStoppage As String = "MC3NewStoppage"
    Public modMC4_stNewStoppage As String = "MC4NewStoppage"
    Public modMC5_stNewStoppage As String = "MC5NewStoppage"
    Public modMC6_stNewStoppage As String = "MC6NewStoppage"
    Public modMC7_stNewStoppage As String = "MC7NewStoppage"
    Public modMC8_stNewStoppage As String = "MC8NewStoppage"
    Public modMC9_stNewStoppage As String = "MC9NewStoppage"
    Public modMC10_stNewStoppage As String = "MC10NewStoppage"
    Public modMC11_stNewStoppage As String = "MC11NewStoppage"
    Public modMC12_stNewStoppage As String = "MC12NewStoppage"
    Public modMC13_stNewStoppage As String = "MC13NewStoppage"
    Public modMC14_stNewStoppage As String = "MC14NewStoppage"
    Public modMC15_stNewStoppage As String = "MC15NewStoppage"
    Public modMC16_stNewStoppage As String = "MC16NewStoppage"
    Public modMC17_stNewStoppage As String = "MC17NewStoppage"
    Public modMC18_stNewStoppage As String = "MC18NewStoppage"
    Public modMC19_stNewStoppage As String = "MC19NewStoppage"

    Public mod_stLoadStat_Loaded As String = "Loaded"
    Public mod_stLoadStat_Unloaded As String = "Unloaded"
    Public mod_stProdStat_INC As String = "Incomplete"
    Public mod_stProdStat_InProg As String = "In Progress"
    Public mod_stProdStat_PlanComplete As String = "Plan Complete"

    Public modMCIdNow As String
    Public modMCUnNow As String
    Public modMCUNIdNow As String
    Public modMCAcLvlNow As String
    Public modLogiInProgress As Boolean
    Public modLogOutInProgress As Boolean

End Module






