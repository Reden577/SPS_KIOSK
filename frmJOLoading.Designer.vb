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
        Me.colCkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBORDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoldIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBORDERQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadStatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MListNewJobOrderBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MListNewJobOrder_1 = New SPSApp1.MListNewJobOrder_1()
        Me.MListNewJobOrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewJOMasterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewJOMasterList = New SPSApp1.NewJOMasterList()
        Me.MListNewJobOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.lblDGVMachineId = New System.Windows.Forms.Label()
        Me.dgvAPI = New System.Windows.Forms.DataGridView()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.MListNewJobOrderBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MListNewJobOrderBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MListNewJobOrderTableAdapter1 = New SPSApp1.MListNewJobOrder_1TableAdapters.MListNewJobOrderTableAdapter()
        Me.MListNewJobOrderBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblLoadStat = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProdStat = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvJO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrder_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJOMasterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJOMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MListPartNumberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartNoMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MListNewJobOrderBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.btnClear.Location = New System.Drawing.Point(641, 518)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(260, 71)
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
        Me.btnJOLoadBtn2Click.Location = New System.Drawing.Point(641, 441)
        Me.btnJOLoadBtn2Click.Name = "btnJOLoadBtn2Click"
        Me.btnJOLoadBtn2Click.Size = New System.Drawing.Size(260, 71)
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
        Me.dgvJO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCkBox, Me.IDDataGridViewTextBoxColumn, Me.JOBORDERDataGridViewTextBoxColumn, Me.MoldIDDataGridViewTextBoxColumn, Me.JOBORDERQTYDataGridViewTextBoxColumn, Me.MachineIDDataGridViewTextBoxColumn, Me.LoadStatDataGridViewTextBoxColumn})
        Me.dgvJO.DataSource = Me.MListNewJobOrderBindingSource5
        Me.dgvJO.Location = New System.Drawing.Point(3, 22)
        Me.dgvJO.Name = "dgvJO"
        Me.dgvJO.ReadOnly = True
        Me.dgvJO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJO.Size = New System.Drawing.Size(552, 311)
        Me.dgvJO.TabIndex = 2
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
        Me.JOBORDERDataGridViewTextBoxColumn.HeaderText = "JO Code"
        Me.JOBORDERDataGridViewTextBoxColumn.Name = "JOBORDERDataGridViewTextBoxColumn"
        Me.JOBORDERDataGridViewTextBoxColumn.ReadOnly = True
        Me.JOBORDERDataGridViewTextBoxColumn.Width = 140
        '
        'MoldIDDataGridViewTextBoxColumn
        '
        Me.MoldIDDataGridViewTextBoxColumn.DataPropertyName = "Mold_ID"
        Me.MoldIDDataGridViewTextBoxColumn.HeaderText = "Mold ID"
        Me.MoldIDDataGridViewTextBoxColumn.Name = "MoldIDDataGridViewTextBoxColumn"
        Me.MoldIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JOBORDERQTYDataGridViewTextBoxColumn
        '
        Me.JOBORDERQTYDataGridViewTextBoxColumn.DataPropertyName = "JOB_ORDER_QTY"
        Me.JOBORDERQTYDataGridViewTextBoxColumn.HeaderText = "Plan Qty"
        Me.JOBORDERQTYDataGridViewTextBoxColumn.Name = "JOBORDERQTYDataGridViewTextBoxColumn"
        Me.JOBORDERQTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.JOBORDERQTYDataGridViewTextBoxColumn.Width = 80
        '
        'MachineIDDataGridViewTextBoxColumn
        '
        Me.MachineIDDataGridViewTextBoxColumn.DataPropertyName = "Machine_ID"
        Me.MachineIDDataGridViewTextBoxColumn.HeaderText = "MC ID"
        Me.MachineIDDataGridViewTextBoxColumn.Name = "MachineIDDataGridViewTextBoxColumn"
        Me.MachineIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoadStatDataGridViewTextBoxColumn
        '
        Me.LoadStatDataGridViewTextBoxColumn.DataPropertyName = "Load_Stat"
        Me.LoadStatDataGridViewTextBoxColumn.HeaderText = "Load Stat"
        Me.LoadStatDataGridViewTextBoxColumn.Name = "LoadStatDataGridViewTextBoxColumn"
        Me.LoadStatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MListNewJobOrderBindingSource5
        '
        Me.MListNewJobOrderBindingSource5.DataMember = "MListNewJobOrder"
        Me.MListNewJobOrderBindingSource5.DataSource = Me.MListNewJobOrder_1
        '
        'MListNewJobOrder_1
        '
        Me.MListNewJobOrder_1.DataSetName = "MListNewJobOrder_1"
        Me.MListNewJobOrder_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(996, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 395)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Order Loading"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(6, 339)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 24)
        Me.ListBox1.TabIndex = 9
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
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblDGVJOCode)
        Me.GroupBox2.Controls.Add(Me.lblProdStat)
        Me.GroupBox2.Controls.Add(Me.lblLoadStat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblDGVMachineId)
        Me.GroupBox2.Controls.Add(Me.lblDGVJOPlanQty)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblDGVMoldID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 434)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 209)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "JO Summary Load To:"
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
        Me.dgvAPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAPI.Location = New System.Drawing.Point(18, 25)
        Me.dgvAPI.Name = "dgvAPI"
        Me.dgvAPI.ReadOnly = True
        Me.dgvAPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAPI.Size = New System.Drawing.Size(883, 403)
        Me.dgvAPI.TabIndex = 8
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'MListNewJobOrderBindingSource4
        '
        Me.MListNewJobOrderBindingSource4.DataMember = "MListNewJobOrder"
        Me.MListNewJobOrderBindingSource4.DataSource = Me.NewJOMasterListBindingSource
        '
        'MListNewJobOrderBindingSource2
        '
        Me.MListNewJobOrderBindingSource2.DataMember = "MListNewJobOrder"
        Me.MListNewJobOrderBindingSource2.DataSource = Me.MListNewJobOrder_1
        '
        'MListNewJobOrderTableAdapter1
        '
        Me.MListNewJobOrderTableAdapter1.ClearBeforeFill = True
        '
        'MListNewJobOrderBindingSource3
        '
        Me.MListNewJobOrderBindingSource3.DataMember = "MListNewJobOrder"
        Me.MListNewJobOrderBindingSource3.DataSource = Me.MListNewJobOrder_1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1002, 442)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(452, 160)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAPI)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnJOLoadBtn2Click)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(27, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(917, 649)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "JOB ORDER SOURCE: ARC-STONE"
        '
        'lblLoadStat
        '
        Me.lblLoadStat.AutoSize = True
        Me.lblLoadStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadStat.Location = New System.Drawing.Point(115, 141)
        Me.lblLoadStat.Name = "lblLoadStat"
        Me.lblLoadStat.Size = New System.Drawing.Size(14, 20)
        Me.lblLoadStat.TabIndex = 4
        Me.lblLoadStat.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Load Stat:"
        '
        'lblProdStat
        '
        Me.lblProdStat.AutoSize = True
        Me.lblProdStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdStat.Location = New System.Drawing.Point(115, 169)
        Me.lblProdStat.Name = "lblProdStat"
        Me.lblProdStat.Size = New System.Drawing.Size(14, 20)
        Me.lblProdStat.TabIndex = 4
        Me.lblProdStat.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Prod Stat:"
        '
        'frmJOLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 674)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJOLoading"
        Me.Text = "Job Order Loading!"
        CType(Me.dgvJO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrder_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJOMasterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJOMasterList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MListPartNumberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartNoMasterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MListNewJobOrderBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents MListNewJobOrderBindingSource1 As BindingSource
    Friend WithEvents NewJOMasterListBindingSource As BindingSource
    Friend WithEvents lblDGVMachineId As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents MListNewJobOrder_1 As MListNewJobOrder_1
    Friend WithEvents MListNewJobOrderBindingSource2 As BindingSource
    Friend WithEvents MListNewJobOrderTableAdapter1 As MListNewJobOrder_1TableAdapters.MListNewJobOrderTableAdapter
    Friend WithEvents MListNewJobOrderBindingSource5 As BindingSource
    Friend WithEvents MListNewJobOrderBindingSource3 As BindingSource
    Friend WithEvents MListNewJobOrderBindingSource4 As BindingSource
    Friend WithEvents colCkBox As DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOBORDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoldIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JOBORDERQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachineIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoadStatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblProdStat As Label
    Friend WithEvents lblLoadStat As Label
End Class
