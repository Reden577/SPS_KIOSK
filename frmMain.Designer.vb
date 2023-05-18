<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SidePanel1 = New System.Windows.Forms.Panel()
        Me.SidePanel2 = New System.Windows.Forms.Panel()
        Me.btnWO = New FontAwesome.Sharp.IconButton()
        Me.btnSettings = New FontAwesome.Sharp.IconButton()
        Me.btnLogOut = New FontAwesome.Sharp.IconButton()
        Me.btnLogin = New FontAwesome.Sharp.IconButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PanelFrmContainer = New System.Windows.Forms.Panel()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLogINOUT = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SidePanel1.SuspendLayout()
        Me.SidePanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1910, 26)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SPSApp1.My.Resources.Resources.close__3_
        Me.Button1.Location = New System.Drawing.Point(1869, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SidePanel1
        '
        Me.SidePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SidePanel1.Controls.Add(Me.SidePanel2)
        Me.SidePanel1.Controls.Add(Me.Panel7)
        Me.SidePanel1.Controls.Add(Me.btnHome)
        Me.SidePanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel1.Location = New System.Drawing.Point(0, 26)
        Me.SidePanel1.Name = "SidePanel1"
        Me.SidePanel1.Size = New System.Drawing.Size(53, 1014)
        Me.SidePanel1.TabIndex = 1
        '
        'SidePanel2
        '
        Me.SidePanel2.Controls.Add(Me.btnWO)
        Me.SidePanel2.Controls.Add(Me.btnSettings)
        Me.SidePanel2.Controls.Add(Me.btnLogOut)
        Me.SidePanel2.Controls.Add(Me.btnLogin)
        Me.SidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SidePanel2.Location = New System.Drawing.Point(0, 747)
        Me.SidePanel2.Name = "SidePanel2"
        Me.SidePanel2.Size = New System.Drawing.Size(53, 245)
        Me.SidePanel2.TabIndex = 5
        '
        'btnWO
        '
        Me.btnWO.FlatAppearance.BorderSize = 0
        Me.btnWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWO.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWO.IconChar = FontAwesome.Sharp.IconChar.ListCheck
        Me.btnWO.IconColor = System.Drawing.Color.White
        Me.btnWO.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnWO.IconSize = 40
        Me.btnWO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWO.Location = New System.Drawing.Point(0, 98)
        Me.btnWO.Name = "btnWO"
        Me.btnWO.Size = New System.Drawing.Size(53, 45)
        Me.btnWO.TabIndex = 2
        Me.btnWO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWO.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnSettings.IconColor = System.Drawing.Color.White
        Me.btnSettings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSettings.IconSize = 40
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 147)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(53, 45)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.UserXmark
        Me.btnLogOut.IconColor = System.Drawing.Color.White
        Me.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogOut.IconSize = 40
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 50)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(53, 45)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Tag = ""
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.btnLogin.IconColor = System.Drawing.Color.White
        Me.btnLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogin.IconSize = 40
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(0, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(53, 45)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Tag = ""
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 992)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(53, 22)
        Me.Panel7.TabIndex = 4
        '
        'btnHome
        '
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHome.IconColor = System.Drawing.Color.White
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 40
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(53, 45)
        Me.btnHome.TabIndex = 2
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(53, 1018)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1857, 22)
        Me.Panel4.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(239, 22)
        Me.Panel6.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblDate)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1686, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(171, 22)
        Me.Panel5.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(3, 3)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(143, 16)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "dd/MM/yyyy  hh:mm:ss"
        '
        'PanelFrmContainer
        '
        Me.PanelFrmContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFrmContainer.Location = New System.Drawing.Point(53, 26)
        Me.PanelFrmContainer.Name = "PanelFrmContainer"
        Me.PanelFrmContainer.Size = New System.Drawing.Size(1857, 992)
        Me.PanelFrmContainer.TabIndex = 3
        '
        'TimerDate
        '
        Me.TimerDate.Enabled = True
        Me.TimerDate.Interval = 1000
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'tmrLogINOUT
        '
        Me.tmrLogINOUT.Enabled = True
        Me.tmrLogINOUT.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1910, 1040)
        Me.Controls.Add(Me.PanelFrmContainer)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.SidePanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SidePanel1.ResumeLayout(False)
        Me.SidePanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SidePanel1 As Panel
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SidePanel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PanelFrmContainer As Panel
    Friend WithEvents TimerDate As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents btnWO As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrLogINOUT As Timer
End Class
