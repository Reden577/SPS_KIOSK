<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJOLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJOLoading))
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnJOLoadBtn2Click = New FontAwesome.Sharp.IconButton()
        Me.dgvJO = New System.Windows.Forms.DataGridView()
        Me.MListNewJobOrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewJOMasterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewJOMasterList = New SPSApp1.NewJOMasterList()
        Me.MListNewJobOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDGVMoldID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MListPartNumberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartNoMasterList = New SPSApp1.PartNoMasterList()
        Me.MListNewJobOrderTableAdapter = New SPSApp1.NewJOMasterListTableAdapters.MListNewJobOrderTableAdapter()
        Me.MListPartNumberTableAdapter = New SPSApp1.PartNoMasterListTableAdapters.MListPartNumberTableAdapter()
        Me.lblDGVJOPlanQty = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDGVJOCode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDGVLoadStat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDGVMachineId = New System.Windows.Forms.Label()
        Me.dgvAPI = New System.Windows.Forms.DataGridView()
        Me.coluserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBody = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.colCkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBORDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoldIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBORDERQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvJO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJOMasterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJOMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MListPartNumberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartNoMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 30
        Me.btnClear.Location = New System.Drawing.Point(672, 307)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(159, 53)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnJOLoadBtn2Click
        '
        Me.btnJOLoadBtn2Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJOLoadBtn2Click.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJOLoadBtn2Click.IconChar = FontAwesome.Sharp.IconChar.DiagramNext
        Me.btnJOLoadBtn2Click.IconColor = System.Drawing.Color.Black
        Me.btnJOLoadBtn2Click.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnJOLoadBtn2Click.IconSize = 30
        Me.btnJOLoadBtn2Click.Location = New System.Drawing.Point(672, 249)
        Me.btnJOLoadBtn2Click.Name = "btnJOLoadBtn2Click"
        Me.btnJOLoadBtn2Click.Size = New System.Drawing.Size(159, 53)
        Me.btnJOLoadBtn2Click.TabIndex = 1
        Me.btnJOLoadBtn2Click.Text = "LOAD"
        Me.btnJOLoadBtn2Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnJOLoadBtn2Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJOLoadBtn2Click.UseVisualStyleBackColor = True
        '
        'dgvJO
        '
        Me.dgvJO.AllowUserToAddRows = False
        Me.dgvJO.AllowUserToDeleteRows = False
        Me.dgvJO.AutoGenerateColumns = False
        Me.dgvJO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCkBox, Me.IDDataGridViewTextBoxColumn, Me.JOBORDERDataGridViewTextBoxColumn, Me.MoldIDDataGridViewTextBoxColumn, Me.JOBORDERQTYDataGridViewTextBoxColumn, Me.MachineIDDataGridViewTextBoxColumn})
        Me.dgvJO.DataSource = Me.MListNewJobOrderBindingSource1
        Me.dgvJO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJO.Location = New System.Drawing.Point(3, 22)
        Me.dgvJO.Name = "dgvJO"
        Me.dgvJO.ReadOnly = True
        Me.dgvJO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJO.Size = New System.Drawing.Size(552, 311)
        Me.dgvJO.TabIndex = 2
        '
        'MListNewJobOrderBindingSource1
        '
        Me.MListNewJobOrderBindingSource1.DataMember = "MListNewJobOrder"
        Me.MListNewJobOrderBindingSource1.DataSource = Me.NewJOMasterListBindingSource
        '
        'NewJOMasterListBindingSource
        '
        Me.NewJOMasterListBindingSource.DataSource = Me.NewJOMasterList
        Me.NewJOMasterListBindingSource.Position = 0
        '
        'NewJOMasterList
        '
        Me.NewJOMasterList.DataSetName = "NewJOMasterList"
        Me.NewJOMasterList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MListNewJobOrderBindingSource
        '
        Me.MListNewJobOrderBindingSource.DataMember = "MListNewJobOrder"
        Me.MListNewJobOrderBindingSource.DataSource = Me.NewJOMasterList
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvJO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 336)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Order Loading"
        '
        'lblDGVMoldID
        '
        Me.lblDGVMoldID.AutoSize = True
        Me.lblDGVMoldID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVMoldID.Location = New System.Drawing.Point(92, 62)
        Me.lblDGVMoldID.Name = "lblDGVMoldID"
        Me.lblDGVMoldID.Size = New System.Drawing.Size(14, 20)
        Me.lblDGVMoldID.TabIndex = 4
        Me.lblDGVMoldID.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mold ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Machine ID:"
        '
        'MListPartNumberBindingSource
        '
        Me.MListPartNumberBindingSource.DataMember = "MListPartNumber"
        Me.MListPartNumberBindingSource.DataSource = Me.PartNoMasterList
        '
        'PartNoMasterList
        '
        Me.PartNoMasterList.DataSetName = "PartNoMasterList"
        Me.PartNoMasterList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MListNewJobOrderTableAdapter
        '
        Me.MListNewJobOrderTableAdapter.ClearBeforeFill = True
        '
        'MListPartNumberTableAdapter
        '
        Me.MListPartNumberTableAdapter.ClearBeforeFill = True
        '
        'lblDGVJOPlanQty
        '
        Me.lblDGVJOPlanQty.AutoSize = True
        Me.lblDGVJOPlanQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVJOPlanQty.Location = New System.Drawing.Point(92, 89)
        Me.lblDGVJOPlanQty.Name = "lblDGVJOPlanQty"
        Me.lblDGVJOPlanQty.Size = New System.Drawing.Size(14, 20)
        Me.lblDGVJOPlanQty.TabIndex = 4
        Me.lblDGVJOPlanQty.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "JO Plan:"
        '
        'lblDGVJOCode
        '
        Me.lblDGVJOCode.AutoSize = True
        Me.lblDGVJOCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVJOCode.Location = New System.Drawing.Point(92, 35)
        Me.lblDGVJOCode.Name = "lblDGVJOCode"
        Me.lblDGVJOCode.Size = New System.Drawing.Size(14, 20)
        Me.lblDGVJOCode.TabIndex = 4
        Me.lblDGVJOCode.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "JO Code:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblDGVJOCode)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblDGVMachineId)
        Me.GroupBox2.Controls.Add(Me.lblDGVJOPlanQty)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblDGVMoldID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(576, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 217)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "JO Summary Load To:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDGVLoadStat)
        Me.Panel1.Location = New System.Drawing.Point(17, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 38)
        Me.Panel1.TabIndex = 6
        '
        'lblDGVLoadStat
        '
        Me.lblDGVLoadStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDGVLoadStat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDGVLoadStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVLoadStat.Location = New System.Drawing.Point(0, 0)
        Me.lblDGVLoadStat.Name = "lblDGVLoadStat"
        Me.lblDGVLoadStat.Size = New System.Drawing.Size(222, 38)
        Me.lblDGVLoadStat.TabIndex = 4
        Me.lblDGVLoadStat.Text = "Not Loaded"
        Me.lblDGVLoadStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Status:"
        '
        'lblDGVMachineId
        '
        Me.lblDGVMachineId.AutoSize = True
        Me.lblDGVMachineId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDGVMachineId.Location = New System.Drawing.Point(115, 115)
        Me.lblDGVMachineId.Name = "lblDGVMachineId"
        Me.lblDGVMachineId.Size = New System.Drawing.Size(14, 20)
        Me.lblDGVMachineId.TabIndex = 4
        Me.lblDGVMachineId.Text = "-"
        '
        'dgvAPI
        '
        Me.dgvAPI.AllowUserToAddRows = False
        Me.dgvAPI.AllowUserToDeleteRows = False
        Me.dgvAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAPI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coluserID, Me.colID, Me.colTitle, Me.colBody})
        Me.dgvAPI.Location = New System.Drawing.Point(1010, 24)
        Me.dgvAPI.Name = "dgvAPI"
        Me.dgvAPI.ReadOnly = True
        Me.dgvAPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAPI.Size = New System.Drawing.Size(282, 323)
        Me.dgvAPI.TabIndex = 8
        '
        'coluserID
        '
        Me.coluserID.HeaderText = "userID"
        Me.coluserID.Name = "coluserID"
        Me.coluserID.ReadOnly = True
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colTitle
        '
        Me.colTitle.HeaderText = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.ReadOnly = True
        '
        'colBody
        '
        Me.colBody.HeaderText = "Body"
        Me.colBody.Name = "colBody"
        Me.colBody.ReadOnly = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(847, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 43)
        Me.ListBox1.TabIndex = 9
        '
        'colCkBox
        '
        Me.colCkBox.DataPropertyName = "colCkBox"
        Me.colCkBox.HeaderText = "Sel"
        Me.colCkBox.Name = "colCkBox"
        Me.colCkBox.ReadOnly = True
        Me.colCkBox.Width = 40
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'JOBORDERDataGridViewTextBoxColumn
        '
        Me.JOBORDERDataGridViewTextBoxColumn.DataPropertyName = "JOB_ORDER"
        Me.JOBORDERDataGridViewTextBoxColumn.HeaderText = "JOCode"
        Me.JOBORDERDataGridViewTextBoxColumn.Name = "JOBORDERDataGridViewTextBoxColumn"
        Me.JOBORDERDataGridViewTextBoxColumn.ReadOnly = True
        Me.JOBORDERDataGridViewTextBoxColumn.Width = 160
        '
        'MoldIDDataGridViewTextBoxColumn
        '
        Me.MoldIDDataGridViewTextBoxColumn.DataPropertyName = "Mold_ID"
        Me.MoldIDDataGridViewTextBoxColumn.HeaderText = "MoldID"
        Me.MoldIDDataGridViewTextBoxColumn.Name = "MoldIDDataGridViewTextBoxColumn"
        Me.MoldIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JOBORDERQTYDataGridViewTextBoxColumn
        '
        Me.JOBORDERQTYDataGridViewTextBoxColumn.DataPropertyName = "JOB_ORDER_QTY"
        Me.JOBORDERQTYDataGridViewTextBoxColumn.HeaderText = "JOPlanQty"
        Me.JOBORDERQTYDataGridViewTextBoxColumn.Name = "JOBORDERQTYDataGridViewTextBoxColumn"
        Me.JOBORDERQTYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MachineIDDataGridViewTextBoxColumn
        '
        Me.MachineIDDataGridViewTextBoxColumn.DataPropertyName = "Machine_ID"
        Me.MachineIDDataGridViewTextBoxColumn.HeaderText = "MachId"
        Me.MachineIDDataGridViewTextBoxColumn.Name = "MachineIDDataGridViewTextBoxColumn"
        Me.MachineIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(844, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'frmJOLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 372)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.dgvAPI)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnJOLoadBtn2Click)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJOLoading"
        Me.Text = "Job Order Loading!"
        CType(Me.dgvJO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJOMasterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJOMasterList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MListPartNumberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartNoMasterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvAPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJOLoadBtn2Click As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvJO As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NewJOMasterList As NewJOMasterList
    Friend WithEvents MListNewJobOrderBindingSource As BindingSource
    Friend WithEvents MListNewJobOrderTableAdapter As NewJOMasterListTableAdapters.MListNewJobOrderTableAdapter
    Friend WithEvents lblDGVMoldID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PartNoMasterList As PartNoMasterList
    Friend WithEvents MListPartNumberBindingSource As BindingSource
    Friend WithEvents MListPartNumberTableAdapter As PartNoMasterListTableAdapters.MListPartNumberTableAdapter
    Friend WithEvents lblDGVJOPlanQty As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDGVJOCode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvAPI As DataGridView
    Friend WithEvents coluserID As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colTitle As DataGridViewTextBoxColumn
    Friend WithEvents colBody As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDGVLoadStat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MListNewJobOrderBindingSource1 As BindingSource
    Friend WithEvents NewJOMasterListBindingSource As BindingSource
    Friend WithEvents lblDGVMachineId As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents colCkBox As DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOBORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoldIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOBORDERQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachineIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents tmrRealTimeCheck As Timer
End Class
