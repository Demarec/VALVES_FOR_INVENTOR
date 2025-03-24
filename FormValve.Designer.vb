<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmValve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValve))
        Me.TabVALVE_SELECT = New System.Windows.Forms.TabControl()
        Me.tbpButterflyValves = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtButterflyValveSanitaryAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtButterflyValveLugAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtButterflyValveSanitaryManual = New System.Windows.Forms.RadioButton()
        Me.rbtButterflyValveWaferAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtButterflyValveLugMan = New System.Windows.Forms.RadioButton()
        Me.rbtButterflyValveWaferMan = New System.Windows.Forms.RadioButton()
        Me.tbpBallValves = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbtBallValveGluedAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveButtWeldAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveFlangedAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveGluedManual = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveButtWeldManual = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveFlangedManual = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveThreadedAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtBallValveThreadedManual = New System.Windows.Forms.RadioButton()
        Me.tbpCheckValves = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rbtCheckValveBallTrueUnionGlued = New System.Windows.Forms.RadioButton()
        Me.rbtCheckValveBallGlued = New System.Windows.Forms.RadioButton()
        Me.rbtCheckValveBallFlanged = New System.Windows.Forms.RadioButton()
        Me.rbtCheckValveDualPlateWafer = New System.Windows.Forms.RadioButton()
        Me.rbtCheckValveSwingWafer = New System.Windows.Forms.RadioButton()
        Me.rbtCheckValveDiskWafer = New System.Windows.Forms.RadioButton()
        Me.tbpDiaphragm = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.rbtDiaphragmValveGluedAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtDiaphragmValveGluedManual = New System.Windows.Forms.RadioButton()
        Me.rbtDiaphragmValveButtWeldedAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtDiaphragmValveButtWeldedManual = New System.Windows.Forms.RadioButton()
        Me.rbtDiaphragmValveFlangedAutomated = New System.Windows.Forms.RadioButton()
        Me.rbtDiaphragmValveFlangedManual = New System.Windows.Forms.RadioButton()
        Me.tbpGateValves = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.rbtGateValveThreaded = New System.Windows.Forms.RadioButton()
        Me.rbtGateValveKnifeFlanged = New System.Windows.Forms.RadioButton()
        Me.rbtGateValveFlanged = New System.Windows.Forms.RadioButton()
        Me.tbpGlobeValves = New System.Windows.Forms.TabPage()
        Me.rbtGlobeValveWelded = New System.Windows.Forms.RadioButton()
        Me.rbtGlobeValveThreaded = New System.Windows.Forms.RadioButton()
        Me.rbtGlobeValveFlanged = New System.Windows.Forms.RadioButton()
        Me.tbpStrainers = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.rbtStrainerYTypeGlued = New System.Windows.Forms.RadioButton()
        Me.rbtStrainerYTypeThreaded = New System.Windows.Forms.RadioButton()
        Me.rbtStrainerYTypeFlanged = New System.Windows.Forms.RadioButton()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cbxDN = New System.Windows.Forms.ComboBox()
        Me.lblDN = New System.Windows.Forms.Label()
        Me.cbxMaterial = New System.Windows.Forms.ComboBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.picStrainerYTypeFlanged = New System.Windows.Forms.PictureBox()
        Me.picStrainerYTypeThreaded = New System.Windows.Forms.PictureBox()
        Me.picGateValveKnifeFlanged = New System.Windows.Forms.PictureBox()
        Me.picGlobeValveFlanged = New System.Windows.Forms.PictureBox()
        Me.picGlobeValveWelded = New System.Windows.Forms.PictureBox()
        Me.picGlobeValveThreaded = New System.Windows.Forms.PictureBox()
        Me.picStrainerYTypeGlued = New System.Windows.Forms.PictureBox()
        Me.picCheckValveDualPlateWafer = New System.Windows.Forms.PictureBox()
        Me.picCheckValveBallFlanged = New System.Windows.Forms.PictureBox()
        Me.picCheckValveBallGlued = New System.Windows.Forms.PictureBox()
        Me.picCheckValveBallTrueUnionGlued = New System.Windows.Forms.PictureBox()
        Me.picDiaphragmValveButtWeldedManual = New System.Windows.Forms.PictureBox()
        Me.picDiaphragmValveGluedManual = New System.Windows.Forms.PictureBox()
        Me.picDiaphragmValveFlangedAutomated = New System.Windows.Forms.PictureBox()
        Me.picDiaphragmValveButtWeldedAutomated = New System.Windows.Forms.PictureBox()
        Me.picDiaphragmValveGluedAutomated = New System.Windows.Forms.PictureBox()
        Me.picGateValveFlanged = New System.Windows.Forms.PictureBox()
        Me.picButterflyValveWaferMan = New System.Windows.Forms.PictureBox()
        Me.picButterflyValveLugMan = New System.Windows.Forms.PictureBox()
        Me.picButterflyValveWaferAutomated = New System.Windows.Forms.PictureBox()
        Me.picButterflyValveLugAutomated = New System.Windows.Forms.PictureBox()
        Me.picButterflyValveSanitaryManual = New System.Windows.Forms.PictureBox()
        Me.picButterflyValveSanitaryAutomated = New System.Windows.Forms.PictureBox()
        Me.picBallValveThreadedManual = New System.Windows.Forms.PictureBox()
        Me.picBallValveFlangedManual = New System.Windows.Forms.PictureBox()
        Me.picBallValveThreadedAutomated = New System.Windows.Forms.PictureBox()
        Me.picBallValveFlangedAutomated = New System.Windows.Forms.PictureBox()
        Me.picBallValveButtWeldManual = New System.Windows.Forms.PictureBox()
        Me.picBallValveButtWeldAutomated = New System.Windows.Forms.PictureBox()
        Me.picBallValveGluedManual = New System.Windows.Forms.PictureBox()
        Me.picBallValveGluedAutomated = New System.Windows.Forms.PictureBox()
        Me.picCheckValveDiskWafer = New System.Windows.Forms.PictureBox()
        Me.picCheckValveSwingWafer = New System.Windows.Forms.PictureBox()
        Me.picGateValveThreaded = New System.Windows.Forms.PictureBox()
        Me.picDiaphragmValveFlangedManual = New System.Windows.Forms.PictureBox()
        Me.TabVALVE_SELECT.SuspendLayout()
        Me.tbpButterflyValves.SuspendLayout()
        Me.tbpBallValves.SuspendLayout()
        Me.tbpCheckValves.SuspendLayout()
        Me.tbpDiaphragm.SuspendLayout()
        Me.tbpGateValves.SuspendLayout()
        Me.tbpGlobeValves.SuspendLayout()
        Me.tbpStrainers.SuspendLayout()
        CType(Me.picStrainerYTypeFlanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStrainerYTypeThreaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGateValveKnifeFlanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGlobeValveFlanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGlobeValveWelded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGlobeValveThreaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStrainerYTypeGlued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckValveDualPlateWafer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckValveBallFlanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckValveBallGlued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckValveBallTrueUnionGlued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiaphragmValveButtWeldedManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiaphragmValveGluedManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiaphragmValveFlangedAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiaphragmValveButtWeldedAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiaphragmValveGluedAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGateValveFlanged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButterflyValveWaferMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButterflyValveLugMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButterflyValveWaferAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButterflyValveLugAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButterflyValveSanitaryManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picButterflyValveSanitaryAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveThreadedManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveFlangedManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveThreadedAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveFlangedAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveButtWeldManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveButtWeldAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveGluedManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBallValveGluedAutomated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckValveDiskWafer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckValveSwingWafer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGateValveThreaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiaphragmValveFlangedManual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabVALVE_SELECT
        '
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpButterflyValves)
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpBallValves)
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpCheckValves)
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpDiaphragm)
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpGateValves)
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpGlobeValves)
        Me.TabVALVE_SELECT.Controls.Add(Me.tbpStrainers)
        Me.TabVALVE_SELECT.Location = New System.Drawing.Point(3, 6)
        Me.TabVALVE_SELECT.Margin = New System.Windows.Forms.Padding(2)
        Me.TabVALVE_SELECT.Name = "TabVALVE_SELECT"
        Me.TabVALVE_SELECT.SelectedIndex = 0
        Me.TabVALVE_SELECT.Size = New System.Drawing.Size(338, 194)
        Me.TabVALVE_SELECT.TabIndex = 45
        '
        'tbpButterflyValves
        '
        Me.tbpButterflyValves.BackColor = System.Drawing.SystemColors.Control
        Me.tbpButterflyValves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbpButterflyValves.Controls.Add(Me.Label7)
        Me.tbpButterflyValves.Controls.Add(Me.Label6)
        Me.tbpButterflyValves.Controls.Add(Me.Label5)
        Me.tbpButterflyValves.Controls.Add(Me.Label4)
        Me.tbpButterflyValves.Controls.Add(Me.Label3)
        Me.tbpButterflyValves.Controls.Add(Me.Label2)
        Me.tbpButterflyValves.Controls.Add(Me.rbtButterflyValveSanitaryAutomated)
        Me.tbpButterflyValves.Controls.Add(Me.rbtButterflyValveLugAutomated)
        Me.tbpButterflyValves.Controls.Add(Me.rbtButterflyValveSanitaryManual)
        Me.tbpButterflyValves.Controls.Add(Me.rbtButterflyValveWaferAutomated)
        Me.tbpButterflyValves.Controls.Add(Me.rbtButterflyValveLugMan)
        Me.tbpButterflyValves.Controls.Add(Me.rbtButterflyValveWaferMan)
        Me.tbpButterflyValves.Location = New System.Drawing.Point(4, 22)
        Me.tbpButterflyValves.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpButterflyValves.Name = "tbpButterflyValves"
        Me.tbpButterflyValves.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpButterflyValves.Size = New System.Drawing.Size(330, 168)
        Me.tbpButterflyValves.TabIndex = 0
        Me.tbpButterflyValves.Text = "Butterfly"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(71, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Butterfly Valve Sanitary Automated"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(71, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Butterfly Valve Sanitary Manual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(71, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Butterfly Valve Lug Automated"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(71, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Butterfly Valve Wafer Automated"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(71, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Butterfly Valve Lug Manual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(71, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Butterfly Valve Wafer Manual"
        '
        'rbtButterflyValveSanitaryAutomated
        '
        Me.rbtButterflyValveSanitaryAutomated.AutoSize = True
        Me.rbtButterflyValveSanitaryAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtButterflyValveSanitaryAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtButterflyValveSanitaryAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtButterflyValveSanitaryAutomated.Location = New System.Drawing.Point(4, 101)
        Me.rbtButterflyValveSanitaryAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtButterflyValveSanitaryAutomated.Name = "rbtButterflyValveSanitaryAutomated"
        Me.rbtButterflyValveSanitaryAutomated.Size = New System.Drawing.Size(67, 17)
        Me.rbtButterflyValveSanitaryAutomated.TabIndex = 6
        Me.rbtButterflyValveSanitaryAutomated.Text = "LKB-LP"
        Me.rbtButterflyValveSanitaryAutomated.UseVisualStyleBackColor = False
        '
        'rbtButterflyValveLugAutomated
        '
        Me.rbtButterflyValveLugAutomated.AutoSize = True
        Me.rbtButterflyValveLugAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtButterflyValveLugAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtButterflyValveLugAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtButterflyValveLugAutomated.Location = New System.Drawing.Point(4, 62)
        Me.rbtButterflyValveLugAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtButterflyValveLugAutomated.Name = "rbtButterflyValveLugAutomated"
        Me.rbtButterflyValveLugAutomated.Size = New System.Drawing.Size(55, 17)
        Me.rbtButterflyValveLugAutomated.TabIndex = 4
        Me.rbtButterflyValveLugAutomated.Text = "BV12"
        Me.rbtButterflyValveLugAutomated.UseVisualStyleBackColor = False
        '
        'rbtButterflyValveSanitaryManual
        '
        Me.rbtButterflyValveSanitaryManual.AutoSize = True
        Me.rbtButterflyValveSanitaryManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtButterflyValveSanitaryManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtButterflyValveSanitaryManual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtButterflyValveSanitaryManual.Location = New System.Drawing.Point(4, 82)
        Me.rbtButterflyValveSanitaryManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtButterflyValveSanitaryManual.Name = "rbtButterflyValveSanitaryManual"
        Me.rbtButterflyValveSanitaryManual.Size = New System.Drawing.Size(67, 17)
        Me.rbtButterflyValveSanitaryManual.TabIndex = 5
        Me.rbtButterflyValveSanitaryManual.Text = "LKB-LP"
        Me.rbtButterflyValveSanitaryManual.UseVisualStyleBackColor = False
        '
        'rbtButterflyValveWaferAutomated
        '
        Me.rbtButterflyValveWaferAutomated.AutoSize = True
        Me.rbtButterflyValveWaferAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtButterflyValveWaferAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtButterflyValveWaferAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtButterflyValveWaferAutomated.Location = New System.Drawing.Point(4, 43)
        Me.rbtButterflyValveWaferAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtButterflyValveWaferAutomated.Name = "rbtButterflyValveWaferAutomated"
        Me.rbtButterflyValveWaferAutomated.Size = New System.Drawing.Size(55, 17)
        Me.rbtButterflyValveWaferAutomated.TabIndex = 3
        Me.rbtButterflyValveWaferAutomated.Text = "BV10"
        Me.rbtButterflyValveWaferAutomated.UseVisualStyleBackColor = False
        '
        'rbtButterflyValveLugMan
        '
        Me.rbtButterflyValveLugMan.AutoSize = True
        Me.rbtButterflyValveLugMan.BackColor = System.Drawing.Color.Transparent
        Me.rbtButterflyValveLugMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtButterflyValveLugMan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtButterflyValveLugMan.Location = New System.Drawing.Point(4, 23)
        Me.rbtButterflyValveLugMan.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtButterflyValveLugMan.Name = "rbtButterflyValveLugMan"
        Me.rbtButterflyValveLugMan.Size = New System.Drawing.Size(55, 17)
        Me.rbtButterflyValveLugMan.TabIndex = 2
        Me.rbtButterflyValveLugMan.Text = "BV12"
        Me.rbtButterflyValveLugMan.UseVisualStyleBackColor = False
        '
        'rbtButterflyValveWaferMan
        '
        Me.rbtButterflyValveWaferMan.AutoSize = True
        Me.rbtButterflyValveWaferMan.BackColor = System.Drawing.Color.Transparent
        Me.rbtButterflyValveWaferMan.Checked = True
        Me.rbtButterflyValveWaferMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtButterflyValveWaferMan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtButterflyValveWaferMan.Location = New System.Drawing.Point(4, 4)
        Me.rbtButterflyValveWaferMan.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtButterflyValveWaferMan.Name = "rbtButterflyValveWaferMan"
        Me.rbtButterflyValveWaferMan.Size = New System.Drawing.Size(55, 17)
        Me.rbtButterflyValveWaferMan.TabIndex = 1
        Me.rbtButterflyValveWaferMan.TabStop = True
        Me.rbtButterflyValveWaferMan.Text = "BV10"
        Me.rbtButterflyValveWaferMan.UseVisualStyleBackColor = False
        '
        'tbpBallValves
        '
        Me.tbpBallValves.BackColor = System.Drawing.SystemColors.Control
        Me.tbpBallValves.Controls.Add(Me.Label15)
        Me.tbpBallValves.Controls.Add(Me.Label14)
        Me.tbpBallValves.Controls.Add(Me.Label13)
        Me.tbpBallValves.Controls.Add(Me.Label12)
        Me.tbpBallValves.Controls.Add(Me.Label11)
        Me.tbpBallValves.Controls.Add(Me.Label10)
        Me.tbpBallValves.Controls.Add(Me.Label9)
        Me.tbpBallValves.Controls.Add(Me.Label8)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveGluedAutomated)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveButtWeldAutomated)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveFlangedAutomated)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveGluedManual)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveButtWeldManual)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveFlangedManual)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveThreadedAutomated)
        Me.tbpBallValves.Controls.Add(Me.rbtBallValveThreadedManual)
        Me.tbpBallValves.Location = New System.Drawing.Point(4, 22)
        Me.tbpBallValves.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpBallValves.Name = "tbpBallValves"
        Me.tbpBallValves.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpBallValves.Size = New System.Drawing.Size(330, 168)
        Me.tbpBallValves.TabIndex = 1
        Me.tbpBallValves.Text = "Ball"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(105, 142)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Ball Valve Glued Automated"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(105, 122)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Ball Valve Glued Manual"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(54, 103)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Ball Valve Butt Weld Automated"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(54, 83)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Ball Valve Butt Weld Manual"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(54, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ball Valve Flanged Automated"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(54, 44)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Ball Valve Flanged Manual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(54, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Ball Valve Threaded Automated"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(54, 5)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ball Valve Threaded Manual"
        '
        'rbtBallValveGluedAutomated
        '
        Me.rbtBallValveGluedAutomated.AutoSize = True
        Me.rbtBallValveGluedAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveGluedAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveGluedAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveGluedAutomated.Location = New System.Drawing.Point(4, 140)
        Me.rbtBallValveGluedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveGluedAutomated.Name = "rbtBallValveGluedAutomated"
        Me.rbtBallValveGluedAutomated.Size = New System.Drawing.Size(102, 17)
        Me.rbtBallValveGluedAutomated.TabIndex = 15
        Me.rbtBallValveGluedAutomated.Text = "DUAL BLOCK"
        Me.rbtBallValveGluedAutomated.UseVisualStyleBackColor = False
        '
        'rbtBallValveButtWeldAutomated
        '
        Me.rbtBallValveButtWeldAutomated.AutoSize = True
        Me.rbtBallValveButtWeldAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveButtWeldAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveButtWeldAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveButtWeldAutomated.Location = New System.Drawing.Point(4, 101)
        Me.rbtBallValveButtWeldAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveButtWeldAutomated.Name = "rbtBallValveButtWeldAutomated"
        Me.rbtBallValveButtWeldAutomated.Size = New System.Drawing.Size(48, 17)
        Me.rbtBallValveButtWeldAutomated.TabIndex = 13
        Me.rbtBallValveButtWeldAutomated.Text = "BV3"
        Me.rbtBallValveButtWeldAutomated.UseVisualStyleBackColor = False
        '
        'rbtBallValveFlangedAutomated
        '
        Me.rbtBallValveFlangedAutomated.AutoSize = True
        Me.rbtBallValveFlangedAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveFlangedAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveFlangedAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveFlangedAutomated.Location = New System.Drawing.Point(3, 62)
        Me.rbtBallValveFlangedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveFlangedAutomated.Name = "rbtBallValveFlangedAutomated"
        Me.rbtBallValveFlangedAutomated.Size = New System.Drawing.Size(48, 17)
        Me.rbtBallValveFlangedAutomated.TabIndex = 11
        Me.rbtBallValveFlangedAutomated.Text = "BV4"
        Me.rbtBallValveFlangedAutomated.UseVisualStyleBackColor = False
        '
        'rbtBallValveGluedManual
        '
        Me.rbtBallValveGluedManual.AutoSize = True
        Me.rbtBallValveGluedManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveGluedManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveGluedManual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveGluedManual.Location = New System.Drawing.Point(4, 121)
        Me.rbtBallValveGluedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveGluedManual.Name = "rbtBallValveGluedManual"
        Me.rbtBallValveGluedManual.Size = New System.Drawing.Size(102, 17)
        Me.rbtBallValveGluedManual.TabIndex = 14
        Me.rbtBallValveGluedManual.Text = "DUAL BLOCK"
        Me.rbtBallValveGluedManual.UseVisualStyleBackColor = False
        '
        'rbtBallValveButtWeldManual
        '
        Me.rbtBallValveButtWeldManual.AutoSize = True
        Me.rbtBallValveButtWeldManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveButtWeldManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveButtWeldManual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveButtWeldManual.Location = New System.Drawing.Point(4, 82)
        Me.rbtBallValveButtWeldManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveButtWeldManual.Name = "rbtBallValveButtWeldManual"
        Me.rbtBallValveButtWeldManual.Size = New System.Drawing.Size(48, 17)
        Me.rbtBallValveButtWeldManual.TabIndex = 12
        Me.rbtBallValveButtWeldManual.Text = "BV3"
        Me.rbtBallValveButtWeldManual.UseVisualStyleBackColor = False
        '
        'rbtBallValveFlangedManual
        '
        Me.rbtBallValveFlangedManual.AutoSize = True
        Me.rbtBallValveFlangedManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveFlangedManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveFlangedManual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveFlangedManual.Location = New System.Drawing.Point(4, 43)
        Me.rbtBallValveFlangedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveFlangedManual.Name = "rbtBallValveFlangedManual"
        Me.rbtBallValveFlangedManual.Size = New System.Drawing.Size(48, 17)
        Me.rbtBallValveFlangedManual.TabIndex = 10
        Me.rbtBallValveFlangedManual.Text = "BV4"
        Me.rbtBallValveFlangedManual.UseVisualStyleBackColor = False
        '
        'rbtBallValveThreadedAutomated
        '
        Me.rbtBallValveThreadedAutomated.AutoSize = True
        Me.rbtBallValveThreadedAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveThreadedAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveThreadedAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveThreadedAutomated.Location = New System.Drawing.Point(4, 23)
        Me.rbtBallValveThreadedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveThreadedAutomated.Name = "rbtBallValveThreadedAutomated"
        Me.rbtBallValveThreadedAutomated.Size = New System.Drawing.Size(48, 17)
        Me.rbtBallValveThreadedAutomated.TabIndex = 9
        Me.rbtBallValveThreadedAutomated.Text = "BV3"
        Me.rbtBallValveThreadedAutomated.UseVisualStyleBackColor = False
        '
        'rbtBallValveThreadedManual
        '
        Me.rbtBallValveThreadedManual.AutoSize = True
        Me.rbtBallValveThreadedManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtBallValveThreadedManual.Checked = True
        Me.rbtBallValveThreadedManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBallValveThreadedManual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtBallValveThreadedManual.Location = New System.Drawing.Point(4, 4)
        Me.rbtBallValveThreadedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtBallValveThreadedManual.Name = "rbtBallValveThreadedManual"
        Me.rbtBallValveThreadedManual.Size = New System.Drawing.Size(48, 17)
        Me.rbtBallValveThreadedManual.TabIndex = 8
        Me.rbtBallValveThreadedManual.TabStop = True
        Me.rbtBallValveThreadedManual.Text = "BV3"
        Me.rbtBallValveThreadedManual.UseVisualStyleBackColor = False
        '
        'tbpCheckValves
        '
        Me.tbpCheckValves.BackColor = System.Drawing.SystemColors.Control
        Me.tbpCheckValves.Controls.Add(Me.Label16)
        Me.tbpCheckValves.Controls.Add(Me.Label17)
        Me.tbpCheckValves.Controls.Add(Me.Label18)
        Me.tbpCheckValves.Controls.Add(Me.Label19)
        Me.tbpCheckValves.Controls.Add(Me.Label20)
        Me.tbpCheckValves.Controls.Add(Me.Label21)
        Me.tbpCheckValves.Controls.Add(Me.rbtCheckValveBallTrueUnionGlued)
        Me.tbpCheckValves.Controls.Add(Me.rbtCheckValveBallGlued)
        Me.tbpCheckValves.Controls.Add(Me.rbtCheckValveBallFlanged)
        Me.tbpCheckValves.Controls.Add(Me.rbtCheckValveDualPlateWafer)
        Me.tbpCheckValves.Controls.Add(Me.rbtCheckValveSwingWafer)
        Me.tbpCheckValves.Controls.Add(Me.rbtCheckValveDiskWafer)
        Me.tbpCheckValves.Location = New System.Drawing.Point(4, 22)
        Me.tbpCheckValves.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpCheckValves.Name = "tbpCheckValves"
        Me.tbpCheckValves.Size = New System.Drawing.Size(330, 168)
        Me.tbpCheckValves.TabIndex = 2
        Me.tbpCheckValves.Text = "Check"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(69, 103)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(175, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Check Valve Ball True Union Glued"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(69, 83)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Check Valve Ball Glued"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(69, 64)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(129, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Check Valve Ball Flanged"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(68, 44)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Check Valve Dual Plate Wafer"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(68, 25)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(132, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Check Valve Swing Wafer"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(68, 5)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 13)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Check Valve Disk Wafer"
        '
        'rbtCheckValveBallTrueUnionGlued
        '
        Me.rbtCheckValveBallTrueUnionGlued.AutoSize = True
        Me.rbtCheckValveBallTrueUnionGlued.BackColor = System.Drawing.Color.Transparent
        Me.rbtCheckValveBallTrueUnionGlued.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCheckValveBallTrueUnionGlued.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtCheckValveBallTrueUnionGlued.Location = New System.Drawing.Point(4, 101)
        Me.rbtCheckValveBallTrueUnionGlued.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtCheckValveBallTrueUnionGlued.Name = "rbtCheckValveBallTrueUnionGlued"
        Me.rbtCheckValveBallTrueUnionGlued.Size = New System.Drawing.Size(56, 17)
        Me.rbtCheckValveBallTrueUnionGlued.TabIndex = 22
        Me.rbtCheckValveBallTrueUnionGlued.Text = "SRIM"
        Me.rbtCheckValveBallTrueUnionGlued.UseVisualStyleBackColor = False
        '
        'rbtCheckValveBallGlued
        '
        Me.rbtCheckValveBallGlued.AutoSize = True
        Me.rbtCheckValveBallGlued.BackColor = System.Drawing.Color.Transparent
        Me.rbtCheckValveBallGlued.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCheckValveBallGlued.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtCheckValveBallGlued.Location = New System.Drawing.Point(4, 82)
        Me.rbtCheckValveBallGlued.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtCheckValveBallGlued.Name = "rbtCheckValveBallGlued"
        Me.rbtCheckValveBallGlued.Size = New System.Drawing.Size(65, 17)
        Me.rbtCheckValveBallGlued.TabIndex = 21
        Me.rbtCheckValveBallGlued.Text = "VRUIM"
        Me.rbtCheckValveBallGlued.UseVisualStyleBackColor = False
        '
        'rbtCheckValveBallFlanged
        '
        Me.rbtCheckValveBallFlanged.AutoSize = True
        Me.rbtCheckValveBallFlanged.BackColor = System.Drawing.Color.Transparent
        Me.rbtCheckValveBallFlanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCheckValveBallFlanged.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtCheckValveBallFlanged.Location = New System.Drawing.Point(4, 62)
        Me.rbtCheckValveBallFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtCheckValveBallFlanged.Name = "rbtCheckValveBallFlanged"
        Me.rbtCheckValveBallFlanged.Size = New System.Drawing.Size(55, 17)
        Me.rbtCheckValveBallFlanged.TabIndex = 20
        Me.rbtCheckValveBallFlanged.Text = "BV41"
        Me.rbtCheckValveBallFlanged.UseVisualStyleBackColor = False
        '
        'rbtCheckValveDualPlateWafer
        '
        Me.rbtCheckValveDualPlateWafer.AutoSize = True
        Me.rbtCheckValveDualPlateWafer.BackColor = System.Drawing.Color.Transparent
        Me.rbtCheckValveDualPlateWafer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCheckValveDualPlateWafer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtCheckValveDualPlateWafer.Location = New System.Drawing.Point(4, 43)
        Me.rbtCheckValveDualPlateWafer.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtCheckValveDualPlateWafer.Name = "rbtCheckValveDualPlateWafer"
        Me.rbtCheckValveDualPlateWafer.Size = New System.Drawing.Size(55, 17)
        Me.rbtCheckValveDualPlateWafer.TabIndex = 19
        Me.rbtCheckValveDualPlateWafer.Text = "BV40"
        Me.rbtCheckValveDualPlateWafer.UseVisualStyleBackColor = False
        '
        'rbtCheckValveSwingWafer
        '
        Me.rbtCheckValveSwingWafer.AutoSize = True
        Me.rbtCheckValveSwingWafer.BackColor = System.Drawing.Color.Transparent
        Me.rbtCheckValveSwingWafer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCheckValveSwingWafer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtCheckValveSwingWafer.Location = New System.Drawing.Point(4, 23)
        Me.rbtCheckValveSwingWafer.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtCheckValveSwingWafer.Name = "rbtCheckValveSwingWafer"
        Me.rbtCheckValveSwingWafer.Size = New System.Drawing.Size(55, 17)
        Me.rbtCheckValveSwingWafer.TabIndex = 18
        Me.rbtCheckValveSwingWafer.Text = "BV38"
        Me.rbtCheckValveSwingWafer.UseVisualStyleBackColor = False
        '
        'rbtCheckValveDiskWafer
        '
        Me.rbtCheckValveDiskWafer.AutoSize = True
        Me.rbtCheckValveDiskWafer.BackColor = System.Drawing.Color.Transparent
        Me.rbtCheckValveDiskWafer.Checked = True
        Me.rbtCheckValveDiskWafer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCheckValveDiskWafer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtCheckValveDiskWafer.Location = New System.Drawing.Point(4, 4)
        Me.rbtCheckValveDiskWafer.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtCheckValveDiskWafer.Name = "rbtCheckValveDiskWafer"
        Me.rbtCheckValveDiskWafer.Size = New System.Drawing.Size(55, 17)
        Me.rbtCheckValveDiskWafer.TabIndex = 17
        Me.rbtCheckValveDiskWafer.TabStop = True
        Me.rbtCheckValveDiskWafer.Text = "BV36"
        Me.rbtCheckValveDiskWafer.UseVisualStyleBackColor = False
        '
        'tbpDiaphragm
        '
        Me.tbpDiaphragm.BackColor = System.Drawing.SystemColors.Control
        Me.tbpDiaphragm.Controls.Add(Me.Label24)
        Me.tbpDiaphragm.Controls.Add(Me.Label25)
        Me.tbpDiaphragm.Controls.Add(Me.rbtDiaphragmValveGluedAutomated)
        Me.tbpDiaphragm.Controls.Add(Me.rbtDiaphragmValveGluedManual)
        Me.tbpDiaphragm.Controls.Add(Me.rbtDiaphragmValveButtWeldedAutomated)
        Me.tbpDiaphragm.Controls.Add(Me.rbtDiaphragmValveButtWeldedManual)
        Me.tbpDiaphragm.Controls.Add(Me.rbtDiaphragmValveFlangedAutomated)
        Me.tbpDiaphragm.Controls.Add(Me.rbtDiaphragmValveFlangedManual)
        Me.tbpDiaphragm.Location = New System.Drawing.Point(4, 22)
        Me.tbpDiaphragm.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpDiaphragm.Name = "tbpDiaphragm"
        Me.tbpDiaphragm.Size = New System.Drawing.Size(330, 168)
        Me.tbpDiaphragm.TabIndex = 6
        Me.tbpDiaphragm.Text = "Diaphragm"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(75, 103)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(173, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Diaphragm Valve Glued Automated"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(75, 44)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(157, 13)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Diaphragm Valve Glued Manual"
        '
        'rbtDiaphragmValveGluedAutomated
        '
        Me.rbtDiaphragmValveGluedAutomated.AutoSize = True
        Me.rbtDiaphragmValveGluedAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtDiaphragmValveGluedAutomated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDiaphragmValveGluedAutomated.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtDiaphragmValveGluedAutomated.Location = New System.Drawing.Point(4, 101)
        Me.rbtDiaphragmValveGluedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtDiaphragmValveGluedAutomated.Name = "rbtDiaphragmValveGluedAutomated"
        Me.rbtDiaphragmValveGluedAutomated.Size = New System.Drawing.Size(63, 17)
        Me.rbtDiaphragmValveGluedAutomated.TabIndex = 29
        Me.rbtDiaphragmValveGluedAutomated.Text = "DKUIV"
        Me.rbtDiaphragmValveGluedAutomated.UseVisualStyleBackColor = False
        '
        'rbtDiaphragmValveGluedManual
        '
        Me.rbtDiaphragmValveGluedManual.AutoSize = True
        Me.rbtDiaphragmValveGluedManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtDiaphragmValveGluedManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDiaphragmValveGluedManual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtDiaphragmValveGluedManual.Location = New System.Drawing.Point(4, 43)
        Me.rbtDiaphragmValveGluedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtDiaphragmValveGluedManual.Name = "rbtDiaphragmValveGluedManual"
        Me.rbtDiaphragmValveGluedManual.Size = New System.Drawing.Size(63, 17)
        Me.rbtDiaphragmValveGluedManual.TabIndex = 26
        Me.rbtDiaphragmValveGluedManual.Text = "DKUIV"
        Me.rbtDiaphragmValveGluedManual.UseVisualStyleBackColor = False
        '
        'rbtDiaphragmValveButtWeldedAutomated
        '
        Me.rbtDiaphragmValveButtWeldedAutomated.AutoSize = True
        Me.rbtDiaphragmValveButtWeldedAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtDiaphragmValveButtWeldedAutomated.Location = New System.Drawing.Point(4, 82)
        Me.rbtDiaphragmValveButtWeldedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtDiaphragmValveButtWeldedAutomated.Name = "rbtDiaphragmValveButtWeldedAutomated"
        Me.rbtDiaphragmValveButtWeldedAutomated.Size = New System.Drawing.Size(222, 17)
        Me.rbtDiaphragmValveButtWeldedAutomated.TabIndex = 28
        Me.rbtDiaphragmValveButtWeldedAutomated.Text = "Diaphragm Valve Butt Welded Automated"
        Me.rbtDiaphragmValveButtWeldedAutomated.UseVisualStyleBackColor = False
        '
        'rbtDiaphragmValveButtWeldedManual
        '
        Me.rbtDiaphragmValveButtWeldedManual.AutoSize = True
        Me.rbtDiaphragmValveButtWeldedManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtDiaphragmValveButtWeldedManual.Location = New System.Drawing.Point(4, 23)
        Me.rbtDiaphragmValveButtWeldedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtDiaphragmValveButtWeldedManual.Name = "rbtDiaphragmValveButtWeldedManual"
        Me.rbtDiaphragmValveButtWeldedManual.Size = New System.Drawing.Size(206, 17)
        Me.rbtDiaphragmValveButtWeldedManual.TabIndex = 25
        Me.rbtDiaphragmValveButtWeldedManual.Text = "Diaphragm Valve Butt Welded Manual"
        Me.rbtDiaphragmValveButtWeldedManual.UseVisualStyleBackColor = False
        '
        'rbtDiaphragmValveFlangedAutomated
        '
        Me.rbtDiaphragmValveFlangedAutomated.AutoSize = True
        Me.rbtDiaphragmValveFlangedAutomated.BackColor = System.Drawing.Color.Transparent
        Me.rbtDiaphragmValveFlangedAutomated.Location = New System.Drawing.Point(4, 62)
        Me.rbtDiaphragmValveFlangedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtDiaphragmValveFlangedAutomated.Name = "rbtDiaphragmValveFlangedAutomated"
        Me.rbtDiaphragmValveFlangedAutomated.Size = New System.Drawing.Size(201, 17)
        Me.rbtDiaphragmValveFlangedAutomated.TabIndex = 27
        Me.rbtDiaphragmValveFlangedAutomated.Text = "Diaphragm Valve Flanged Automated"
        Me.rbtDiaphragmValveFlangedAutomated.UseVisualStyleBackColor = False
        '
        'rbtDiaphragmValveFlangedManual
        '
        Me.rbtDiaphragmValveFlangedManual.AutoSize = True
        Me.rbtDiaphragmValveFlangedManual.BackColor = System.Drawing.Color.Transparent
        Me.rbtDiaphragmValveFlangedManual.Checked = True
        Me.rbtDiaphragmValveFlangedManual.Location = New System.Drawing.Point(4, 4)
        Me.rbtDiaphragmValveFlangedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtDiaphragmValveFlangedManual.Name = "rbtDiaphragmValveFlangedManual"
        Me.rbtDiaphragmValveFlangedManual.Size = New System.Drawing.Size(185, 17)
        Me.rbtDiaphragmValveFlangedManual.TabIndex = 24
        Me.rbtDiaphragmValveFlangedManual.TabStop = True
        Me.rbtDiaphragmValveFlangedManual.Text = "Diaphragm Valve Flanged Manual"
        Me.rbtDiaphragmValveFlangedManual.UseVisualStyleBackColor = False
        '
        'tbpGateValves
        '
        Me.tbpGateValves.BackColor = System.Drawing.SystemColors.Control
        Me.tbpGateValves.Controls.Add(Me.Label22)
        Me.tbpGateValves.Controls.Add(Me.Label26)
        Me.tbpGateValves.Controls.Add(Me.rbtGateValveThreaded)
        Me.tbpGateValves.Controls.Add(Me.rbtGateValveKnifeFlanged)
        Me.tbpGateValves.Controls.Add(Me.rbtGateValveFlanged)
        Me.tbpGateValves.Location = New System.Drawing.Point(4, 22)
        Me.tbpGateValves.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpGateValves.Name = "tbpGateValves"
        Me.tbpGateValves.Size = New System.Drawing.Size(330, 168)
        Me.tbpGateValves.TabIndex = 3
        Me.tbpGateValves.Text = "Gate"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(63, 44)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Gate Valve Knife Flanged"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(63, 5)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 13)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Gate Valve Flanged"
        '
        'rbtGateValveThreaded
        '
        Me.rbtGateValveThreaded.AutoSize = True
        Me.rbtGateValveThreaded.BackColor = System.Drawing.Color.Transparent
        Me.rbtGateValveThreaded.Location = New System.Drawing.Point(4, 23)
        Me.rbtGateValveThreaded.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtGateValveThreaded.Name = "rbtGateValveThreaded"
        Me.rbtGateValveThreaded.Size = New System.Drawing.Size(127, 17)
        Me.rbtGateValveThreaded.TabIndex = 32
        Me.rbtGateValveThreaded.Text = "Gate Valve Threaded"
        Me.rbtGateValveThreaded.UseVisualStyleBackColor = False
        '
        'rbtGateValveKnifeFlanged
        '
        Me.rbtGateValveKnifeFlanged.AutoSize = True
        Me.rbtGateValveKnifeFlanged.BackColor = System.Drawing.Color.Transparent
        Me.rbtGateValveKnifeFlanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtGateValveKnifeFlanged.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtGateValveKnifeFlanged.Location = New System.Drawing.Point(4, 43)
        Me.rbtGateValveKnifeFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtGateValveKnifeFlanged.Name = "rbtGateValveKnifeFlanged"
        Me.rbtGateValveKnifeFlanged.Size = New System.Drawing.Size(55, 17)
        Me.rbtGateValveKnifeFlanged.TabIndex = 34
        Me.rbtGateValveKnifeFlanged.Text = "BV50"
        Me.rbtGateValveKnifeFlanged.UseVisualStyleBackColor = False
        '
        'rbtGateValveFlanged
        '
        Me.rbtGateValveFlanged.AutoSize = True
        Me.rbtGateValveFlanged.BackColor = System.Drawing.Color.Transparent
        Me.rbtGateValveFlanged.Checked = True
        Me.rbtGateValveFlanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtGateValveFlanged.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtGateValveFlanged.Location = New System.Drawing.Point(4, 4)
        Me.rbtGateValveFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtGateValveFlanged.Name = "rbtGateValveFlanged"
        Me.rbtGateValveFlanged.Size = New System.Drawing.Size(55, 17)
        Me.rbtGateValveFlanged.TabIndex = 31
        Me.rbtGateValveFlanged.TabStop = True
        Me.rbtGateValveFlanged.Text = "BV49"
        Me.rbtGateValveFlanged.UseVisualStyleBackColor = False
        '
        'tbpGlobeValves
        '
        Me.tbpGlobeValves.BackColor = System.Drawing.SystemColors.Control
        Me.tbpGlobeValves.Controls.Add(Me.rbtGlobeValveWelded)
        Me.tbpGlobeValves.Controls.Add(Me.rbtGlobeValveThreaded)
        Me.tbpGlobeValves.Controls.Add(Me.rbtGlobeValveFlanged)
        Me.tbpGlobeValves.Location = New System.Drawing.Point(4, 22)
        Me.tbpGlobeValves.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpGlobeValves.Name = "tbpGlobeValves"
        Me.tbpGlobeValves.Size = New System.Drawing.Size(330, 168)
        Me.tbpGlobeValves.TabIndex = 5
        Me.tbpGlobeValves.Text = "Globe"
        '
        'rbtGlobeValveWelded
        '
        Me.rbtGlobeValveWelded.AutoSize = True
        Me.rbtGlobeValveWelded.BackColor = System.Drawing.Color.Transparent
        Me.rbtGlobeValveWelded.Location = New System.Drawing.Point(4, 43)
        Me.rbtGlobeValveWelded.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtGlobeValveWelded.Name = "rbtGlobeValveWelded"
        Me.rbtGlobeValveWelded.Size = New System.Drawing.Size(123, 17)
        Me.rbtGlobeValveWelded.TabIndex = 38
        Me.rbtGlobeValveWelded.Text = "Globe Valve Welded"
        Me.rbtGlobeValveWelded.UseVisualStyleBackColor = False
        '
        'rbtGlobeValveThreaded
        '
        Me.rbtGlobeValveThreaded.AutoSize = True
        Me.rbtGlobeValveThreaded.BackColor = System.Drawing.Color.Transparent
        Me.rbtGlobeValveThreaded.Location = New System.Drawing.Point(4, 23)
        Me.rbtGlobeValveThreaded.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtGlobeValveThreaded.Name = "rbtGlobeValveThreaded"
        Me.rbtGlobeValveThreaded.Size = New System.Drawing.Size(132, 17)
        Me.rbtGlobeValveThreaded.TabIndex = 37
        Me.rbtGlobeValveThreaded.Text = "Globe Valve Threaded"
        Me.rbtGlobeValveThreaded.UseVisualStyleBackColor = False
        '
        'rbtGlobeValveFlanged
        '
        Me.rbtGlobeValveFlanged.AutoSize = True
        Me.rbtGlobeValveFlanged.BackColor = System.Drawing.Color.Transparent
        Me.rbtGlobeValveFlanged.Checked = True
        Me.rbtGlobeValveFlanged.Location = New System.Drawing.Point(4, 4)
        Me.rbtGlobeValveFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtGlobeValveFlanged.Name = "rbtGlobeValveFlanged"
        Me.rbtGlobeValveFlanged.Size = New System.Drawing.Size(124, 17)
        Me.rbtGlobeValveFlanged.TabIndex = 36
        Me.rbtGlobeValveFlanged.TabStop = True
        Me.rbtGlobeValveFlanged.Text = "Globe Valve Flanged"
        Me.rbtGlobeValveFlanged.UseVisualStyleBackColor = False
        '
        'tbpStrainers
        '
        Me.tbpStrainers.BackColor = System.Drawing.SystemColors.Control
        Me.tbpStrainers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbpStrainers.Controls.Add(Me.Label23)
        Me.tbpStrainers.Controls.Add(Me.Label27)
        Me.tbpStrainers.Controls.Add(Me.rbtStrainerYTypeGlued)
        Me.tbpStrainers.Controls.Add(Me.rbtStrainerYTypeThreaded)
        Me.tbpStrainers.Controls.Add(Me.rbtStrainerYTypeFlanged)
        Me.tbpStrainers.Location = New System.Drawing.Point(4, 22)
        Me.tbpStrainers.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpStrainers.Name = "tbpStrainers"
        Me.tbpStrainers.Size = New System.Drawing.Size(330, 168)
        Me.tbpStrainers.TabIndex = 4
        Me.tbpStrainers.Text = "Strainers"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(67, 44)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Strainer Y-Type Glued"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(67, 5)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(121, 13)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Strainer Y-Type Flanged"
        '
        'rbtStrainerYTypeGlued
        '
        Me.rbtStrainerYTypeGlued.AutoSize = True
        Me.rbtStrainerYTypeGlued.BackColor = System.Drawing.Color.Transparent
        Me.rbtStrainerYTypeGlued.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStrainerYTypeGlued.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtStrainerYTypeGlued.Location = New System.Drawing.Point(4, 43)
        Me.rbtStrainerYTypeGlued.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtStrainerYTypeGlued.Name = "rbtStrainerYTypeGlued"
        Me.rbtStrainerYTypeGlued.Size = New System.Drawing.Size(65, 17)
        Me.rbtStrainerYTypeGlued.TabIndex = 42
        Me.rbtStrainerYTypeGlued.Text = "RVUIM"
        Me.rbtStrainerYTypeGlued.UseVisualStyleBackColor = False
        '
        'rbtStrainerYTypeThreaded
        '
        Me.rbtStrainerYTypeThreaded.AutoSize = True
        Me.rbtStrainerYTypeThreaded.BackColor = System.Drawing.Color.Transparent
        Me.rbtStrainerYTypeThreaded.Location = New System.Drawing.Point(4, 23)
        Me.rbtStrainerYTypeThreaded.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtStrainerYTypeThreaded.Name = "rbtStrainerYTypeThreaded"
        Me.rbtStrainerYTypeThreaded.Size = New System.Drawing.Size(147, 17)
        Me.rbtStrainerYTypeThreaded.TabIndex = 41
        Me.rbtStrainerYTypeThreaded.Text = "Strainer Y-Type Threaded"
        Me.rbtStrainerYTypeThreaded.UseVisualStyleBackColor = False
        '
        'rbtStrainerYTypeFlanged
        '
        Me.rbtStrainerYTypeFlanged.AutoSize = True
        Me.rbtStrainerYTypeFlanged.BackColor = System.Drawing.Color.Transparent
        Me.rbtStrainerYTypeFlanged.Checked = True
        Me.rbtStrainerYTypeFlanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStrainerYTypeFlanged.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbtStrainerYTypeFlanged.Location = New System.Drawing.Point(4, 4)
        Me.rbtStrainerYTypeFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtStrainerYTypeFlanged.Name = "rbtStrainerYTypeFlanged"
        Me.rbtStrainerYTypeFlanged.Size = New System.Drawing.Size(55, 17)
        Me.rbtStrainerYTypeFlanged.TabIndex = 40
        Me.rbtStrainerYTypeFlanged.TabStop = True
        Me.rbtStrainerYTypeFlanged.Text = "BV56"
        Me.rbtStrainerYTypeFlanged.UseVisualStyleBackColor = False
        '
        'btnPlace
        '
        Me.btnPlace.Location = New System.Drawing.Point(392, 308)
        Me.btnPlace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(119, 38)
        Me.btnPlace.TabIndex = 45
        Me.btnPlace.Text = "Place Valve"
        Me.btnPlace.UseVisualStyleBackColor = True
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.BackColor = System.Drawing.Color.Transparent
        Me.lblFilename.Location = New System.Drawing.Point(3, 242)
        Me.lblFilename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(52, 13)
        Me.lblFilename.TabIndex = 23
        Me.lblFilename.Text = "Filename:"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BackColor = System.Drawing.Color.Transparent
        Me.lblPath.Location = New System.Drawing.Point(3, 264)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 13)
        Me.lblPath.TabIndex = 24
        Me.lblPath.Text = "Path:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Location = New System.Drawing.Point(363, 204)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 25
        Me.lblDescription.Text = "Description"
        '
        'cbxDN
        '
        Me.cbxDN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDN.FormatString = "DN50"
        Me.cbxDN.FormattingEnabled = True
        Me.cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN32", "DN40", "DN50", "DN65"})
        Me.cbxDN.Location = New System.Drawing.Point(366, 237)
        Me.cbxDN.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDN.Name = "cbxDN"
        Me.cbxDN.Size = New System.Drawing.Size(65, 21)
        Me.cbxDN.TabIndex = 43
        Me.cbxDN.Tag = ""
        '
        'lblDN
        '
        Me.lblDN.AutoSize = True
        Me.lblDN.BackColor = System.Drawing.Color.Transparent
        Me.lblDN.Location = New System.Drawing.Point(363, 222)
        Me.lblDN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDN.Name = "lblDN"
        Me.lblDN.Size = New System.Drawing.Size(23, 13)
        Me.lblDN.TabIndex = 28
        Me.lblDN.Text = "DN"
        '
        'cbxMaterial
        '
        Me.cbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMaterial.FormatString = "DN50"
        Me.cbxMaterial.FormattingEnabled = True
        Me.cbxMaterial.Items.AddRange(New Object() {"DN15", "DN20", "DN32", "DN40", "DN50", "DN65"})
        Me.cbxMaterial.Location = New System.Drawing.Point(447, 237)
        Me.cbxMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxMaterial.Name = "cbxMaterial"
        Me.cbxMaterial.Size = New System.Drawing.Size(65, 21)
        Me.cbxMaterial.TabIndex = 44
        Me.cbxMaterial.Tag = ""
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.BackColor = System.Drawing.Color.Transparent
        Me.lblMaterial.Location = New System.Drawing.Point(444, 222)
        Me.lblMaterial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(44, 13)
        Me.lblMaterial.TabIndex = 28
        Me.lblMaterial.Text = "Material"
        '
        'picStrainerYTypeFlanged
        '
        Me.picStrainerYTypeFlanged.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.StrainerFLanged
        Me.picStrainerYTypeFlanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picStrainerYTypeFlanged.Location = New System.Drawing.Point(343, 26)
        Me.picStrainerYTypeFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.picStrainerYTypeFlanged.Name = "picStrainerYTypeFlanged"
        Me.picStrainerYTypeFlanged.Size = New System.Drawing.Size(173, 169)
        Me.picStrainerYTypeFlanged.TabIndex = 80
        Me.picStrainerYTypeFlanged.TabStop = False
        '
        'picStrainerYTypeThreaded
        '
        Me.picStrainerYTypeThreaded.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.StrainerThreaded
        Me.picStrainerYTypeThreaded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picStrainerYTypeThreaded.Location = New System.Drawing.Point(343, 26)
        Me.picStrainerYTypeThreaded.Margin = New System.Windows.Forms.Padding(2)
        Me.picStrainerYTypeThreaded.Name = "picStrainerYTypeThreaded"
        Me.picStrainerYTypeThreaded.Size = New System.Drawing.Size(173, 169)
        Me.picStrainerYTypeThreaded.TabIndex = 79
        Me.picStrainerYTypeThreaded.TabStop = False
        '
        'picGateValveKnifeFlanged
        '
        Me.picGateValveKnifeFlanged.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.GateValveKnifeWafer
        Me.picGateValveKnifeFlanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGateValveKnifeFlanged.Location = New System.Drawing.Point(343, 26)
        Me.picGateValveKnifeFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.picGateValveKnifeFlanged.Name = "picGateValveKnifeFlanged"
        Me.picGateValveKnifeFlanged.Size = New System.Drawing.Size(173, 169)
        Me.picGateValveKnifeFlanged.TabIndex = 78
        Me.picGateValveKnifeFlanged.TabStop = False
        '
        'picGlobeValveFlanged
        '
        Me.picGlobeValveFlanged.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.GlobeValveFlangedSS
        Me.picGlobeValveFlanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGlobeValveFlanged.Location = New System.Drawing.Point(343, 26)
        Me.picGlobeValveFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.picGlobeValveFlanged.Name = "picGlobeValveFlanged"
        Me.picGlobeValveFlanged.Size = New System.Drawing.Size(173, 169)
        Me.picGlobeValveFlanged.TabIndex = 77
        Me.picGlobeValveFlanged.TabStop = False
        '
        'picGlobeValveWelded
        '
        Me.picGlobeValveWelded.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.GlobeValveWelded
        Me.picGlobeValveWelded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGlobeValveWelded.Location = New System.Drawing.Point(343, 26)
        Me.picGlobeValveWelded.Margin = New System.Windows.Forms.Padding(2)
        Me.picGlobeValveWelded.Name = "picGlobeValveWelded"
        Me.picGlobeValveWelded.Size = New System.Drawing.Size(173, 169)
        Me.picGlobeValveWelded.TabIndex = 76
        Me.picGlobeValveWelded.TabStop = False
        '
        'picGlobeValveThreaded
        '
        Me.picGlobeValveThreaded.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.GlobeValveThreaded
        Me.picGlobeValveThreaded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGlobeValveThreaded.Location = New System.Drawing.Point(343, 26)
        Me.picGlobeValveThreaded.Margin = New System.Windows.Forms.Padding(2)
        Me.picGlobeValveThreaded.Name = "picGlobeValveThreaded"
        Me.picGlobeValveThreaded.Size = New System.Drawing.Size(173, 169)
        Me.picGlobeValveThreaded.TabIndex = 75
        Me.picGlobeValveThreaded.TabStop = False
        '
        'picStrainerYTypeGlued
        '
        Me.picStrainerYTypeGlued.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.StrainerGlued
        Me.picStrainerYTypeGlued.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picStrainerYTypeGlued.Location = New System.Drawing.Point(343, 26)
        Me.picStrainerYTypeGlued.Margin = New System.Windows.Forms.Padding(2)
        Me.picStrainerYTypeGlued.Name = "picStrainerYTypeGlued"
        Me.picStrainerYTypeGlued.Size = New System.Drawing.Size(173, 169)
        Me.picStrainerYTypeGlued.TabIndex = 74
        Me.picStrainerYTypeGlued.TabStop = False
        '
        'picCheckValveDualPlateWafer
        '
        Me.picCheckValveDualPlateWafer.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DualPlateCheckValve
        Me.picCheckValveDualPlateWafer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCheckValveDualPlateWafer.Location = New System.Drawing.Point(343, 26)
        Me.picCheckValveDualPlateWafer.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheckValveDualPlateWafer.Name = "picCheckValveDualPlateWafer"
        Me.picCheckValveDualPlateWafer.Size = New System.Drawing.Size(173, 169)
        Me.picCheckValveDualPlateWafer.TabIndex = 73
        Me.picCheckValveDualPlateWafer.TabStop = False
        '
        'picCheckValveBallFlanged
        '
        Me.picCheckValveBallFlanged.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallCheckValveFlanged
        Me.picCheckValveBallFlanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCheckValveBallFlanged.Location = New System.Drawing.Point(343, 26)
        Me.picCheckValveBallFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheckValveBallFlanged.Name = "picCheckValveBallFlanged"
        Me.picCheckValveBallFlanged.Size = New System.Drawing.Size(173, 169)
        Me.picCheckValveBallFlanged.TabIndex = 72
        Me.picCheckValveBallFlanged.TabStop = False
        '
        'picCheckValveBallGlued
        '
        Me.picCheckValveBallGlued.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallCheckValveGluedUnionPVC
        Me.picCheckValveBallGlued.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCheckValveBallGlued.Location = New System.Drawing.Point(343, 26)
        Me.picCheckValveBallGlued.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheckValveBallGlued.Name = "picCheckValveBallGlued"
        Me.picCheckValveBallGlued.Size = New System.Drawing.Size(173, 169)
        Me.picCheckValveBallGlued.TabIndex = 71
        Me.picCheckValveBallGlued.TabStop = False
        '
        'picCheckValveBallTrueUnionGlued
        '
        Me.picCheckValveBallTrueUnionGlued.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallCheckValveGluedTrueUnionPVC
        Me.picCheckValveBallTrueUnionGlued.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCheckValveBallTrueUnionGlued.Location = New System.Drawing.Point(343, 26)
        Me.picCheckValveBallTrueUnionGlued.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheckValveBallTrueUnionGlued.Name = "picCheckValveBallTrueUnionGlued"
        Me.picCheckValveBallTrueUnionGlued.Size = New System.Drawing.Size(173, 169)
        Me.picCheckValveBallTrueUnionGlued.TabIndex = 70
        Me.picCheckValveBallTrueUnionGlued.TabStop = False
        '
        'picDiaphragmValveButtWeldedManual
        '
        Me.picDiaphragmValveButtWeldedManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiafragmValveManualWeldedSS
        Me.picDiaphragmValveButtWeldedManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDiaphragmValveButtWeldedManual.Location = New System.Drawing.Point(343, 26)
        Me.picDiaphragmValveButtWeldedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picDiaphragmValveButtWeldedManual.Name = "picDiaphragmValveButtWeldedManual"
        Me.picDiaphragmValveButtWeldedManual.Size = New System.Drawing.Size(173, 169)
        Me.picDiaphragmValveButtWeldedManual.TabIndex = 69
        Me.picDiaphragmValveButtWeldedManual.TabStop = False
        '
        'picDiaphragmValveGluedManual
        '
        Me.picDiaphragmValveGluedManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiafragmValveGluedManualPVC
        Me.picDiaphragmValveGluedManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDiaphragmValveGluedManual.Location = New System.Drawing.Point(343, 26)
        Me.picDiaphragmValveGluedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picDiaphragmValveGluedManual.Name = "picDiaphragmValveGluedManual"
        Me.picDiaphragmValveGluedManual.Size = New System.Drawing.Size(173, 169)
        Me.picDiaphragmValveGluedManual.TabIndex = 68
        Me.picDiaphragmValveGluedManual.TabStop = False
        '
        'picDiaphragmValveFlangedAutomated
        '
        Me.picDiaphragmValveFlangedAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiafragmValveFlangedAutomatedPVC
        Me.picDiaphragmValveFlangedAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDiaphragmValveFlangedAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picDiaphragmValveFlangedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picDiaphragmValveFlangedAutomated.Name = "picDiaphragmValveFlangedAutomated"
        Me.picDiaphragmValveFlangedAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picDiaphragmValveFlangedAutomated.TabIndex = 67
        Me.picDiaphragmValveFlangedAutomated.TabStop = False
        '
        'picDiaphragmValveButtWeldedAutomated
        '
        Me.picDiaphragmValveButtWeldedAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiafragmValveAutomatedWeldedSS
        Me.picDiaphragmValveButtWeldedAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDiaphragmValveButtWeldedAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picDiaphragmValveButtWeldedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picDiaphragmValveButtWeldedAutomated.Name = "picDiaphragmValveButtWeldedAutomated"
        Me.picDiaphragmValveButtWeldedAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picDiaphragmValveButtWeldedAutomated.TabIndex = 66
        Me.picDiaphragmValveButtWeldedAutomated.TabStop = False
        '
        'picDiaphragmValveGluedAutomated
        '
        Me.picDiaphragmValveGluedAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiafragmValveGluedAutomatedPVC
        Me.picDiaphragmValveGluedAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDiaphragmValveGluedAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picDiaphragmValveGluedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picDiaphragmValveGluedAutomated.Name = "picDiaphragmValveGluedAutomated"
        Me.picDiaphragmValveGluedAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picDiaphragmValveGluedAutomated.TabIndex = 65
        Me.picDiaphragmValveGluedAutomated.TabStop = False
        '
        'picGateValveFlanged
        '
        Me.picGateValveFlanged.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.GateValveFlangedSS
        Me.picGateValveFlanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGateValveFlanged.Location = New System.Drawing.Point(343, 26)
        Me.picGateValveFlanged.Margin = New System.Windows.Forms.Padding(2)
        Me.picGateValveFlanged.Name = "picGateValveFlanged"
        Me.picGateValveFlanged.Size = New System.Drawing.Size(173, 169)
        Me.picGateValveFlanged.TabIndex = 64
        Me.picGateValveFlanged.TabStop = False
        '
        'picButterflyValveWaferMan
        '
        Me.picButterflyValveWaferMan.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButterflyManualWafer
        Me.picButterflyValveWaferMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picButterflyValveWaferMan.Location = New System.Drawing.Point(343, 26)
        Me.picButterflyValveWaferMan.Margin = New System.Windows.Forms.Padding(2)
        Me.picButterflyValveWaferMan.Name = "picButterflyValveWaferMan"
        Me.picButterflyValveWaferMan.Size = New System.Drawing.Size(173, 169)
        Me.picButterflyValveWaferMan.TabIndex = 63
        Me.picButterflyValveWaferMan.TabStop = False
        '
        'picButterflyValveLugMan
        '
        Me.picButterflyValveLugMan.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButterflyManualLUG
        Me.picButterflyValveLugMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picButterflyValveLugMan.Location = New System.Drawing.Point(343, 26)
        Me.picButterflyValveLugMan.Margin = New System.Windows.Forms.Padding(2)
        Me.picButterflyValveLugMan.Name = "picButterflyValveLugMan"
        Me.picButterflyValveLugMan.Size = New System.Drawing.Size(173, 169)
        Me.picButterflyValveLugMan.TabIndex = 62
        Me.picButterflyValveLugMan.TabStop = False
        '
        'picButterflyValveWaferAutomated
        '
        Me.picButterflyValveWaferAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButterflyPneumaticWafer
        Me.picButterflyValveWaferAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picButterflyValveWaferAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picButterflyValveWaferAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picButterflyValveWaferAutomated.Name = "picButterflyValveWaferAutomated"
        Me.picButterflyValveWaferAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picButterflyValveWaferAutomated.TabIndex = 61
        Me.picButterflyValveWaferAutomated.TabStop = False
        '
        'picButterflyValveLugAutomated
        '
        Me.picButterflyValveLugAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButterflyPneumaticLUG
        Me.picButterflyValveLugAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picButterflyValveLugAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picButterflyValveLugAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picButterflyValveLugAutomated.Name = "picButterflyValveLugAutomated"
        Me.picButterflyValveLugAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picButterflyValveLugAutomated.TabIndex = 60
        Me.picButterflyValveLugAutomated.TabStop = False
        '
        'picButterflyValveSanitaryManual
        '
        Me.picButterflyValveSanitaryManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButterflyManualSanitary
        Me.picButterflyValveSanitaryManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picButterflyValveSanitaryManual.Location = New System.Drawing.Point(343, 26)
        Me.picButterflyValveSanitaryManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picButterflyValveSanitaryManual.Name = "picButterflyValveSanitaryManual"
        Me.picButterflyValveSanitaryManual.Size = New System.Drawing.Size(173, 169)
        Me.picButterflyValveSanitaryManual.TabIndex = 59
        Me.picButterflyValveSanitaryManual.TabStop = False
        '
        'picButterflyValveSanitaryAutomated
        '
        Me.picButterflyValveSanitaryAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButterflyAutomatedSanitary
        Me.picButterflyValveSanitaryAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picButterflyValveSanitaryAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picButterflyValveSanitaryAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picButterflyValveSanitaryAutomated.Name = "picButterflyValveSanitaryAutomated"
        Me.picButterflyValveSanitaryAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picButterflyValveSanitaryAutomated.TabIndex = 58
        Me.picButterflyValveSanitaryAutomated.TabStop = False
        '
        'picBallValveThreadedManual
        '
        Me.picBallValveThreadedManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ThreadedBallValve3piecesSS
        Me.picBallValveThreadedManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveThreadedManual.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveThreadedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveThreadedManual.Name = "picBallValveThreadedManual"
        Me.picBallValveThreadedManual.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveThreadedManual.TabIndex = 57
        Me.picBallValveThreadedManual.TabStop = False
        '
        'picBallValveFlangedManual
        '
        Me.picBallValveFlangedManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallValveFlangedSS
        Me.picBallValveFlangedManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveFlangedManual.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveFlangedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveFlangedManual.Name = "picBallValveFlangedManual"
        Me.picBallValveFlangedManual.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveFlangedManual.TabIndex = 56
        Me.picBallValveFlangedManual.TabStop = False
        '
        'picBallValveThreadedAutomated
        '
        Me.picBallValveThreadedAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallValveThreadedSSautomated
        Me.picBallValveThreadedAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveThreadedAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveThreadedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveThreadedAutomated.Name = "picBallValveThreadedAutomated"
        Me.picBallValveThreadedAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveThreadedAutomated.TabIndex = 55
        Me.picBallValveThreadedAutomated.TabStop = False
        '
        'picBallValveFlangedAutomated
        '
        Me.picBallValveFlangedAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallValveFlangedSSautomated
        Me.picBallValveFlangedAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveFlangedAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveFlangedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveFlangedAutomated.Name = "picBallValveFlangedAutomated"
        Me.picBallValveFlangedAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveFlangedAutomated.TabIndex = 54
        Me.picBallValveFlangedAutomated.TabStop = False
        '
        'picBallValveButtWeldManual
        '
        Me.picBallValveButtWeldManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.ButtWeldBallValve3pieces1
        Me.picBallValveButtWeldManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveButtWeldManual.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveButtWeldManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveButtWeldManual.Name = "picBallValveButtWeldManual"
        Me.picBallValveButtWeldManual.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveButtWeldManual.TabIndex = 53
        Me.picBallValveButtWeldManual.TabStop = False
        '
        'picBallValveButtWeldAutomated
        '
        Me.picBallValveButtWeldAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallValveButweldSSautomated
        Me.picBallValveButtWeldAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveButtWeldAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveButtWeldAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveButtWeldAutomated.Name = "picBallValveButtWeldAutomated"
        Me.picBallValveButtWeldAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveButtWeldAutomated.TabIndex = 52
        Me.picBallValveButtWeldAutomated.TabStop = False
        '
        'picBallValveGluedManual
        '
        Me.picBallValveGluedManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.SocketGluedBallValvePVC
        Me.picBallValveGluedManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveGluedManual.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveGluedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveGluedManual.Name = "picBallValveGluedManual"
        Me.picBallValveGluedManual.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveGluedManual.TabIndex = 51
        Me.picBallValveGluedManual.TabStop = False
        '
        'picBallValveGluedAutomated
        '
        Me.picBallValveGluedAutomated.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.BallValveGluedPVCautomated
        Me.picBallValveGluedAutomated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBallValveGluedAutomated.Location = New System.Drawing.Point(343, 26)
        Me.picBallValveGluedAutomated.Margin = New System.Windows.Forms.Padding(2)
        Me.picBallValveGluedAutomated.Name = "picBallValveGluedAutomated"
        Me.picBallValveGluedAutomated.Size = New System.Drawing.Size(173, 169)
        Me.picBallValveGluedAutomated.TabIndex = 50
        Me.picBallValveGluedAutomated.TabStop = False
        '
        'picCheckValveDiskWafer
        '
        Me.picCheckValveDiskWafer.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiskCheckValve
        Me.picCheckValveDiskWafer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCheckValveDiskWafer.Location = New System.Drawing.Point(343, 26)
        Me.picCheckValveDiskWafer.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheckValveDiskWafer.Name = "picCheckValveDiskWafer"
        Me.picCheckValveDiskWafer.Size = New System.Drawing.Size(173, 169)
        Me.picCheckValveDiskWafer.TabIndex = 49
        Me.picCheckValveDiskWafer.TabStop = False
        '
        'picCheckValveSwingWafer
        '
        Me.picCheckValveSwingWafer.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.SwingCheckValve
        Me.picCheckValveSwingWafer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCheckValveSwingWafer.Location = New System.Drawing.Point(343, 26)
        Me.picCheckValveSwingWafer.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheckValveSwingWafer.Name = "picCheckValveSwingWafer"
        Me.picCheckValveSwingWafer.Size = New System.Drawing.Size(173, 169)
        Me.picCheckValveSwingWafer.TabIndex = 48
        Me.picCheckValveSwingWafer.TabStop = False
        '
        'picGateValveThreaded
        '
        Me.picGateValveThreaded.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.GateValveThreaded
        Me.picGateValveThreaded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGateValveThreaded.Location = New System.Drawing.Point(343, 26)
        Me.picGateValveThreaded.Margin = New System.Windows.Forms.Padding(2)
        Me.picGateValveThreaded.Name = "picGateValveThreaded"
        Me.picGateValveThreaded.Size = New System.Drawing.Size(173, 169)
        Me.picGateValveThreaded.TabIndex = 47
        Me.picGateValveThreaded.TabStop = False
        '
        'picDiaphragmValveFlangedManual
        '
        Me.picDiaphragmValveFlangedManual.BackgroundImage = Global.Panta_Valve.My.Resources.Resources.DiafragmValveFlangedManualPVC
        Me.picDiaphragmValveFlangedManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDiaphragmValveFlangedManual.Location = New System.Drawing.Point(343, 26)
        Me.picDiaphragmValveFlangedManual.Margin = New System.Windows.Forms.Padding(2)
        Me.picDiaphragmValveFlangedManual.Name = "picDiaphragmValveFlangedManual"
        Me.picDiaphragmValveFlangedManual.Size = New System.Drawing.Size(173, 169)
        Me.picDiaphragmValveFlangedManual.TabIndex = 26
        Me.picDiaphragmValveFlangedManual.TabStop = False
        '
        'frmValve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(523, 365)
        Me.Controls.Add(Me.picStrainerYTypeFlanged)
        Me.Controls.Add(Me.picStrainerYTypeThreaded)
        Me.Controls.Add(Me.picGateValveKnifeFlanged)
        Me.Controls.Add(Me.picGlobeValveFlanged)
        Me.Controls.Add(Me.picGlobeValveWelded)
        Me.Controls.Add(Me.picGlobeValveThreaded)
        Me.Controls.Add(Me.picStrainerYTypeGlued)
        Me.Controls.Add(Me.picCheckValveDualPlateWafer)
        Me.Controls.Add(Me.picCheckValveBallFlanged)
        Me.Controls.Add(Me.picCheckValveBallGlued)
        Me.Controls.Add(Me.picCheckValveBallTrueUnionGlued)
        Me.Controls.Add(Me.picDiaphragmValveButtWeldedManual)
        Me.Controls.Add(Me.picDiaphragmValveGluedManual)
        Me.Controls.Add(Me.picDiaphragmValveFlangedAutomated)
        Me.Controls.Add(Me.picDiaphragmValveButtWeldedAutomated)
        Me.Controls.Add(Me.picDiaphragmValveGluedAutomated)
        Me.Controls.Add(Me.picGateValveFlanged)
        Me.Controls.Add(Me.picButterflyValveWaferMan)
        Me.Controls.Add(Me.picButterflyValveLugMan)
        Me.Controls.Add(Me.picButterflyValveWaferAutomated)
        Me.Controls.Add(Me.picButterflyValveLugAutomated)
        Me.Controls.Add(Me.picButterflyValveSanitaryManual)
        Me.Controls.Add(Me.picButterflyValveSanitaryAutomated)
        Me.Controls.Add(Me.picBallValveThreadedManual)
        Me.Controls.Add(Me.picBallValveFlangedManual)
        Me.Controls.Add(Me.picBallValveThreadedAutomated)
        Me.Controls.Add(Me.picBallValveFlangedAutomated)
        Me.Controls.Add(Me.picBallValveButtWeldManual)
        Me.Controls.Add(Me.picBallValveButtWeldAutomated)
        Me.Controls.Add(Me.picBallValveGluedManual)
        Me.Controls.Add(Me.picBallValveGluedAutomated)
        Me.Controls.Add(Me.picCheckValveDiskWafer)
        Me.Controls.Add(Me.picCheckValveSwingWafer)
        Me.Controls.Add(Me.picGateValveThreaded)
        Me.Controls.Add(Me.lblMaterial)
        Me.Controls.Add(Me.lblDN)
        Me.Controls.Add(Me.cbxMaterial)
        Me.Controls.Add(Me.cbxDN)
        Me.Controls.Add(Me.picDiaphragmValveFlangedManual)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.TabVALVE_SELECT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(539, 404)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(539, 404)
        Me.Name = "frmValve"
        Me.Text = "VALVES FOR INVENTOR"
        Me.TopMost = True
        Me.TabVALVE_SELECT.ResumeLayout(False)
        Me.tbpButterflyValves.ResumeLayout(False)
        Me.tbpButterflyValves.PerformLayout()
        Me.tbpBallValves.ResumeLayout(False)
        Me.tbpBallValves.PerformLayout()
        Me.tbpCheckValves.ResumeLayout(False)
        Me.tbpCheckValves.PerformLayout()
        Me.tbpDiaphragm.ResumeLayout(False)
        Me.tbpDiaphragm.PerformLayout()
        Me.tbpGateValves.ResumeLayout(False)
        Me.tbpGateValves.PerformLayout()
        Me.tbpGlobeValves.ResumeLayout(False)
        Me.tbpGlobeValves.PerformLayout()
        Me.tbpStrainers.ResumeLayout(False)
        Me.tbpStrainers.PerformLayout()
        CType(Me.picStrainerYTypeFlanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStrainerYTypeThreaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGateValveKnifeFlanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGlobeValveFlanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGlobeValveWelded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGlobeValveThreaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStrainerYTypeGlued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckValveDualPlateWafer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckValveBallFlanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckValveBallGlued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckValveBallTrueUnionGlued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiaphragmValveButtWeldedManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiaphragmValveGluedManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiaphragmValveFlangedAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiaphragmValveButtWeldedAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiaphragmValveGluedAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGateValveFlanged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButterflyValveWaferMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButterflyValveLugMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButterflyValveWaferAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButterflyValveLugAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButterflyValveSanitaryManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picButterflyValveSanitaryAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveThreadedManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveFlangedManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveThreadedAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveFlangedAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveButtWeldManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveButtWeldAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveGluedManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBallValveGluedAutomated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckValveDiskWafer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckValveSwingWafer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGateValveThreaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiaphragmValveFlangedManual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabVALVE_SELECT As TabControl
    Friend WithEvents tbpButterflyValves As TabPage
    Friend WithEvents rbtButterflyValveLugMan As RadioButton
    Friend WithEvents rbtButterflyValveWaferMan As RadioButton
    Friend WithEvents tbpBallValves As TabPage
    Friend WithEvents rbtButterflyValveLugAutomated As RadioButton
    Friend WithEvents rbtButterflyValveWaferAutomated As RadioButton
    Friend WithEvents btnPlace As Button
    Friend WithEvents rbtBallValveGluedAutomated As RadioButton
    Friend WithEvents rbtBallValveButtWeldAutomated As RadioButton
    Friend WithEvents rbtBallValveFlangedAutomated As RadioButton
    Friend WithEvents rbtBallValveGluedManual As RadioButton
    Friend WithEvents rbtBallValveButtWeldManual As RadioButton
    Friend WithEvents rbtBallValveFlangedManual As RadioButton
    Friend WithEvents rbtBallValveThreadedAutomated As RadioButton
    Friend WithEvents rbtBallValveThreadedManual As RadioButton
    Friend WithEvents tbpCheckValves As TabPage
    Friend WithEvents tbpGateValves As TabPage
    Friend WithEvents tbpStrainers As TabPage
    Friend WithEvents rbtButterflyValveSanitaryAutomated As RadioButton
    Friend WithEvents rbtButterflyValveSanitaryManual As RadioButton
    Friend WithEvents tbpGlobeValves As TabPage
    Friend WithEvents rbtCheckValveBallGlued As RadioButton
    Friend WithEvents rbtCheckValveBallFlanged As RadioButton
    Friend WithEvents rbtCheckValveDualPlateWafer As RadioButton
    Friend WithEvents rbtCheckValveSwingWafer As RadioButton
    Friend WithEvents rbtCheckValveDiskWafer As RadioButton
    Friend WithEvents tbpDiaphragm As TabPage
    Friend WithEvents rbtDiaphragmValveGluedAutomated As RadioButton
    Friend WithEvents rbtDiaphragmValveGluedManual As RadioButton
    Friend WithEvents rbtDiaphragmValveButtWeldedAutomated As RadioButton
    Friend WithEvents rbtDiaphragmValveButtWeldedManual As RadioButton
    Friend WithEvents rbtDiaphragmValveFlangedAutomated As RadioButton
    Friend WithEvents rbtDiaphragmValveFlangedManual As RadioButton
    Friend WithEvents rbtGateValveThreaded As RadioButton
    Friend WithEvents rbtGateValveKnifeFlanged As RadioButton
    Friend WithEvents rbtGateValveFlanged As RadioButton
    Friend WithEvents rbtGlobeValveWelded As RadioButton
    Friend WithEvents rbtGlobeValveThreaded As RadioButton
    Friend WithEvents rbtGlobeValveFlanged As RadioButton
    Friend WithEvents rbtStrainerYTypeGlued As RadioButton
    Friend WithEvents rbtStrainerYTypeThreaded As RadioButton
    Friend WithEvents rbtStrainerYTypeFlanged As RadioButton
    Friend WithEvents lblFilename As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents picDiaphragmValveFlangedManual As PictureBox
    Friend WithEvents cbxDN As ComboBox
    Friend WithEvents lblDN As Label
    Friend WithEvents cbxMaterial As ComboBox
    Friend WithEvents lblMaterial As Label
    Friend WithEvents rbtCheckValveBallTrueUnionGlued As RadioButton
    Friend WithEvents picGateValveThreaded As PictureBox
    Friend WithEvents picCheckValveSwingWafer As PictureBox
    Friend WithEvents picCheckValveDiskWafer As PictureBox
    Friend WithEvents picBallValveGluedAutomated As PictureBox
    Friend WithEvents picBallValveGluedManual As PictureBox
    Friend WithEvents picBallValveButtWeldAutomated As PictureBox
    Friend WithEvents picBallValveButtWeldManual As PictureBox
    Friend WithEvents picBallValveFlangedAutomated As PictureBox
    Friend WithEvents picBallValveThreadedAutomated As PictureBox
    Friend WithEvents picBallValveFlangedManual As PictureBox
    Friend WithEvents picBallValveThreadedManual As PictureBox
    Friend WithEvents picButterflyValveSanitaryAutomated As PictureBox
    Friend WithEvents picButterflyValveSanitaryManual As PictureBox
    Friend WithEvents picButterflyValveLugAutomated As PictureBox
    Friend WithEvents picButterflyValveWaferAutomated As PictureBox
    Friend WithEvents picButterflyValveLugMan As PictureBox
    Friend WithEvents picButterflyValveWaferMan As PictureBox
    Friend WithEvents picGateValveFlanged As PictureBox
    Friend WithEvents picDiaphragmValveGluedAutomated As PictureBox
    Friend WithEvents picDiaphragmValveButtWeldedAutomated As PictureBox
    Friend WithEvents picDiaphragmValveFlangedAutomated As PictureBox
    Friend WithEvents picDiaphragmValveGluedManual As PictureBox
    Friend WithEvents picDiaphragmValveButtWeldedManual As PictureBox
    Friend WithEvents picCheckValveBallTrueUnionGlued As PictureBox
    Friend WithEvents picCheckValveBallGlued As PictureBox
    Friend WithEvents picCheckValveBallFlanged As PictureBox
    Friend WithEvents picCheckValveDualPlateWafer As PictureBox
    Friend WithEvents picStrainerYTypeGlued As PictureBox
    Friend WithEvents picGlobeValveThreaded As PictureBox
    Friend WithEvents picGlobeValveWelded As PictureBox
    Friend WithEvents picGlobeValveFlanged As PictureBox
    Friend WithEvents picGateValveKnifeFlanged As PictureBox
    Friend WithEvents picStrainerYTypeThreaded As PictureBox
    Friend WithEvents picStrainerYTypeFlanged As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label27 As Label
End Class
