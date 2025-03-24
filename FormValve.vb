Imports System.IO
Imports Inventor


Public Class frmValve
    Dim oItemName As String
    Dim oItemType As String
    Dim oConnType As String
    Dim oActuator As String
    Dim oSize As String
    Dim oMaterial As String
    Dim oProjectPath As String
    Dim oPartPath As String
    Dim oFilename As String

    Dim oInvPDoc As PartDocument
    Dim oInvADoc As AssemblyDocument
    Dim oDescription As String
    Dim oPartToInsert As String
    Dim oIndex As Integer
    Dim asmDoc As AssemblyDocument
    Dim iMateDefItem As Integer

    Public oValveAglePlaneProxy As WorkPlaneProxy
    Public valveOcc As ComponentOccurrence
    Public oInvApp As Application
    Public oValveAngle As Integer
    Public oOrient As String


    Private Sub Valve_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim oExpdate As Long
        'Dim oThisdate = Date.Now.Ticks
        'oExpdate = 636920928000000000 'Monday, April 29, 2019

        ''MsgBox(thisdate)

        'If oThisdate > oExpdate Then
        '    MsgBox("Your database could not be rebuilt." & vbCrLf & "Some files are corrupted." & vbCrLf & "The application will be closed.", vbOKOnly + "4064", "Fatal Error")
        '    Close()
        'End If
        '' Attempt to get a reference to a running instance of Inventor.
        Try
            oInvApp = GetObject(, "Inventor.Application")
        Catch ex As Exception
            MsgBox("Inventor must be running.")
            btnPlace.Enabled = False
        End Try


        rbtButterflyValveWaferMan.Checked = True

        TabVALVE_SELECT.SelectedIndex = 0
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "WAFER"
        oActuator = "MANUAL"
        oPartToInsert = "ManualButterflyValveWaferType.ipt"
        Pictures_Off()
        picButterflyValveWaferMan.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        oldDN = "DN50"
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GG25"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
        Me.TopMost = True

    End Sub



    Private Sub Pictures_Off()
        picStrainerYTypeThreaded.Visible = False
        picGateValveKnifeFlanged.Visible = False
        picGlobeValveFlanged.Visible = False
        picGlobeValveWelded.Visible = False
        picGlobeValveThreaded.Visible = False
        picStrainerYTypeGlued.Visible = False
        picCheckValveDualPlateWafer.Visible = False
        picCheckValveBallFlanged.Visible = False
        picCheckValveBallGlued.Visible = False
        picCheckValveBallTrueUnionGlued.Visible = False
        picDiaphragmValveButtWeldedManual.Visible = False
        picDiaphragmValveGluedManual.Visible = False
        picDiaphragmValveFlangedAutomated.Visible = False
        picDiaphragmValveButtWeldedAutomated.Visible = False
        picDiaphragmValveGluedAutomated.Visible = False
        picGateValveFlanged.Visible = False
        picButterflyValveWaferMan.Visible = False
        picButterflyValveLugMan.Visible = False
        picButterflyValveWaferAutomated.Visible = False
        picButterflyValveLugAutomated.Visible = False
        picButterflyValveSanitaryManual.Visible = False
        picButterflyValveSanitaryAutomated.Visible = False
        picBallValveThreadedManual.Visible = False
        picBallValveFlangedManual.Visible = False
        picBallValveThreadedAutomated.Visible = False
        picBallValveFlangedAutomated.Visible = False
        picBallValveButtWeldManual.Visible = False
        picBallValveButtWeldAutomated.Visible = False
        picBallValveGluedManual.Visible = False
        picBallValveGluedAutomated.Visible = False
        picCheckValveDiskWafer.Visible = False
        picCheckValveSwingWafer.Visible = False
        picGateValveThreaded.Visible = False
        picDiaphragmValveFlangedManual.Visible = False
        picStrainerYTypeFlanged.Visible = False
    End Sub

    Private Sub Get_Filename()
        lblFilename.Text = oItemType & "_" & oItemName & "_" & oConnType & "_" & oActuator & "_" & oMaterial & "_" & oSize & ".ipt"
        oFilename = lblFilename.Text
        lblDescription.Text = oItemType & oItemName
    End Sub

    Private Sub Get_Material()
        oMaterial = cbxMaterial.Text
        Get_iMateDefItem()
    End Sub

    Private Sub Get_DNsize()
        oSize = cbxDN.Text
        Get_iMateDefItem()
    End Sub

    Private Sub Get_ProjectPath()
        Try
            oInvApp = GetObject(, "Inventor.Application")
            oProjectPath = oInvApp.FileLocations.Workspace
            lblPath.Text = oProjectPath & "\Piping\Valves\" & oItemType & oItemName & "\"
        Catch ex As Exception
            lblPath.Text = "No Path Found. Inventor does not run!"
            Exit Sub
        End Try
    End Sub

    Private Sub rbtButterflyValveWaferMan_CheckedChanged(sender As Object, e As EventArgs) Handles rbtButterflyValveWaferMan.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "WAFER"
        oActuator = "MANUAL"
        oPartToInsert = "ManualButterflyValveWaferType.ipt"
        Pictures_Off()
        picButterflyValveWaferMan.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32", "DN40"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GG25"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtButterflyValveLugMan_CheckedChanged(sender As Object, e As EventArgs) Handles rbtButterflyValveLugMan.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "LUG"
        oActuator = "MANUAL"
        oPartToInsert = "ManualButterflyValveLugType.ipt"
        Pictures_Off()
        picButterflyValveLugMan.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32", "DN40"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GG25"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtButterflyValveWaferAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtButterflyValveWaferAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "WAFER"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticButterflyValveWaferType.ipt"
        Pictures_Off()
        picButterflyValveWaferAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32", "DN40"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GG25"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtButterflyValveLugAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtButterflyValveLugAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "LUG"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticButterflyValveLugType.ipt"
        Pictures_Off()
        picButterflyValveLugAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32", "DN40"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GG25"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtButterflyValveSanitaryManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtButterflyValveSanitaryManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "WELDED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualSanitaryButterFlyValveWelded.ipt"
        Pictures_Off()
        picButterflyValveSanitaryManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100"})
        Select Case oldDN
            Case "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtButterflyValveSanitaryAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtButterflyValveSanitaryAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BUTTERFLY"
        oConnType = "WELDED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticSanitaryButterFlyValveWelded.ipt"
        Pictures_Off()
        picButterflyValveSanitaryAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100"})
        Select Case oldDN
            Case "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveThreadedManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveThreadedManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "THREADED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualBallValveThreaded.ipt"
        Pictures_Off()
        picBallValveThreadedManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveThreadedAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveThreadedAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "THREADED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticBallValveThreaded.ipt"
        Pictures_Off()
        picBallValveThreadedAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveFlangedManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveFlangedManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "FLANGED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualBallValveFlanged.ipt"
        Pictures_Off()
        picBallValveFlangedManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveFlangedAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveFlangedAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "FLANGED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticBallValveFlanged.ipt"
        Pictures_Off()
        picBallValveFlangedAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()

    End Sub

    Private Sub rbtBallValveButtWeldManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveButtWeldManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "WELDED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualBallValveButtWeld.ipt"
        Pictures_Off()
        picBallValveButtWeldManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveButtWeldAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveButtWeldAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "WELDED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticBallValveButtWeld.ipt"
        Pictures_Off()
        picBallValveButtWeldAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveGluedManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveGluedManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "GLUED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualBallValveGlued.ipt"
        Pictures_Off()
        picBallValveGluedManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtBallValveGluedAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBallValveGluedAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "BALL"
        oConnType = "GLUED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticBallValveGlued.ipt"
        Pictures_Off()
        picBallValveGluedAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN25"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtCheckValveDiskWafer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCheckValveDiskWafer.CheckedChanged
        oItemName = "VALVE"
        oItemType = "CHECK"
        oConnType = "WAFER"
        oActuator = "DISK"
        oPartToInsert = "CheckValveDiskWafer.ipt"
        Pictures_Off()
        picCheckValveDiskWafer.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtCheckValveSwingWafer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCheckValveSwingWafer.CheckedChanged
        oItemName = "VALVE"
        oItemType = "CHECK"
        oConnType = "WAFER"
        oActuator = "SWING"
        oPartToInsert = "CheckValveSwingWafer.ipt"
        Pictures_Off()
        picCheckValveSwingWafer.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtCheckValveDualPlateWafer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCheckValveDualPlateWafer.CheckedChanged
        oItemName = "VALVE"
        oItemType = "CHECK"
        oConnType = "WAFER"
        oActuator = "DUALPLATE"
        oPartToInsert = "CheckValveDualPlateWafer.ipt"
        Pictures_Off()
        picCheckValveDualPlateWafer.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GG40", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtCheckValveBallFlanged_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCheckValveBallFlanged.CheckedChanged
        oItemName = "VALVE"
        oItemType = "CHECK"
        oConnType = "FLANGED"
        oActuator = "BALL"
        oPartToInsert = "CheckValveBallFlanged.ipt"
        Pictures_Off()
        picCheckValveBallFlanged.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GGG50", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtCheckValveBallGlued_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCheckValveBallGlued.CheckedChanged
        oItemName = "VALVE"
        oItemType = "CHECK"
        oConnType = "GLUED"
        oActuator = "BALL"
        oPartToInsert = "CheckValveBallGlued.ipt"
        Pictures_Off()
        picCheckValveBallGlued.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtCheckValveBallTrueUnionGlued_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCheckValveBallTrueUnionGlued.CheckedChanged
        oItemName = "VALVE"
        oItemType = "CHECK"
        oConnType = "GLUED"
        oActuator = "BALL_TRUE_UNION"
        oPartToInsert = "CheckValveTrueUnionGlued.ipt"
        Pictures_Off()
        picCheckValveBallTrueUnionGlued.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtDiaphragmValveFlangedManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaphragmValveFlangedManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "DIAPHRAGM"
        oConnType = "FLANGED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualDiaphragmValveFlanged.ipt"
        Pictures_Off()
        picDiaphragmValveFlangedManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L", "PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtDiaphragmValveButtWeldedManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaphragmValveButtWeldedManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "DIAPHRAGM"
        oConnType = "WELDED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualDiaphragmValveButtWeld.ipt"
        Pictures_Off()
        picDiaphragmValveButtWeldedManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtDiaphragmValveGluedManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaphragmValveGluedManual.CheckedChanged
        oItemName = "VALVE"
        oItemType = "DIAPHRAGM"
        oConnType = "GLUED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualDiaphragmValveGlued.ipt"
        Pictures_Off()
        picDiaphragmValveGluedManual.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtDiaphragmValveFlangedAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaphragmValveFlangedAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "DIAPHRAGM"
        oConnType = "FLANGED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticDiaphragmValveFlanged.ipt"
        Pictures_Off()
        picDiaphragmValveFlangedAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L", "PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtDiaphragmValveButtWeldedAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaphragmValveButtWeldedAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "DIAPHRAGM"
        oConnType = "WELDED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticDiaphragmValveButtWeld.ipt"
        Pictures_Off()
        picDiaphragmValveButtWeldedAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtDiaphragmValveGluedAutomated_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaphragmValveGluedAutomated.CheckedChanged
        oItemName = "VALVE"
        oItemType = "DIAPHRAGM"
        oConnType = "GLUED"
        oActuator = "AUTOMATED"
        oPartToInsert = "PneumaticDiaphragmValveGlued.ipt"
        Pictures_Off()
        picDiaphragmValveGluedAutomated.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtGateValveFlanged_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGateValveFlanged.CheckedChanged
        oItemName = "VALVE"
        oItemType = "GATE"
        oConnType = "FLANGED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualGateValveFlanged.ipt"
        Pictures_Off()
        picGateValveFlanged.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32", "DN40"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtGateValveThreaded_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGateValveThreaded.CheckedChanged
        oItemName = "VALVE"
        oItemType = "GATE"
        oConnType = "THREADED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualGateValveThreaded.ipt"
        Pictures_Off()
        picGateValveThreaded.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtGateValveKnifeFlanged_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGateValveKnifeFlanged.CheckedChanged
        oItemName = "VALVE"
        oItemType = "KNIFE"
        oConnType = "FLANGED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualGateKnifeValveType.ipt"
        Pictures_Off()
        picGateValveKnifeFlanged.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32", "DN40"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtGlobeValveFlanged_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGlobeValveFlanged.CheckedChanged
        oItemName = "VALVE"
        oItemType = "GLOBE"
        oConnType = "FLANGED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualGlobeValveFlanged.ipt"
        Pictures_Off()
        picGlobeValveFlanged.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtGlobeValveThreaded_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGlobeValveThreaded.CheckedChanged
        oItemName = "VALVE"
        oItemType = "GLOBE"
        oConnType = "THREADED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualGlobeValveThreaded.ipt"
        Pictures_Off()
        picGlobeValveThreaded.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
        Select Case oldDN
            Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtGlobeValveWelded_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGlobeValveWelded.CheckedChanged
        oItemName = "VALVE"
        oItemType = "GLOBE"
        oConnType = "WELDED"
        oActuator = "MANUAL"
        oPartToInsert = "ManualGlobeValveWelded.ipt"
        Pictures_Off()
        picGlobeValveWelded.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150"})
        Select Case oldDN
            Case "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtStrainerYTypeFlanged_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStrainerYTypeFlanged.CheckedChanged
        oItemName = "STRAINER"
        oItemType = "Y-TYPE"
        oConnType = "FLANGED"
        oActuator = ""
        oPartToInsert = "StrainerY-TypeFlanged.ipt"
        Pictures_Off()
        picStrainerYTypeFlanged.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
        Select Case oldDN
            Case "DN15", "DN20", "DN25", "DN32"
                oldDN = "DN40"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"GGG50", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtStrainerYTypeThreaded_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStrainerYTypeThreaded.CheckedChanged
        oItemName = "STRAINER"
        oItemType = "Y-TYPE"
        oConnType = "THREADED"
        oActuator = ""
        oPartToInsert = "StrainerY-TypeThreaded.ipt"
        Pictures_Off()
        picStrainerYTypeThreaded.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50"})
        Select Case oldDN
            Case "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub rbtStrainerYTypeGlued_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStrainerYTypeGlued.CheckedChanged
        oItemName = "STRAINER"
        oItemType = "Y-TYPE"
        oConnType = "GLUED"
        oActuator = ""
        oPartToInsert = "StrainerY-TypeGlued.ipt"
        Pictures_Off()
        picStrainerYTypeGlued.Visible = True
        Dim oldDN As String
        oldDN = cbxDN.Text
        cbxDN.Items.Clear()
        cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50"})
        Select Case oldDN
            Case "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                oldDN = "DN50"
        End Select
        cbxDN.Text = oldDN
        'oldDN = Nothing
        'cbxDN.SelectedIndex = 0
        cbxMaterial.Items.Clear()
        cbxMaterial.Items.AddRange(New Object() {"PVC"})
        cbxMaterial.SelectedIndex = 0
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
        Get_iMateDefItem()
    End Sub

    Private Sub TabVALVE_SELECT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabVALVE_SELECT.SelectedIndexChanged
        Select Case TabVALVE_SELECT.SelectedIndex
            Case 0
                rbtButterflyValveWaferMan.Checked = True
                oItemName = "VALVE"
                oItemType = "BUTTERFLY"
                oConnType = "WAFER"
                oActuator = "MANUAL"
                oPartToInsert = "ManualButterflyValveWaferType.ipt"
                Pictures_Off()
                picButterflyValveWaferMan.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
                Select Case oldDN
                    Case "DN15", "DN20", "DN25", "DN32", "DN40"
                        oldDN = "DN50"
                End Select
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"GG25"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()
            Case 1
                rbtBallValveThreadedManual.Checked = True
                oItemName = "VALVE"
                oItemType = "BALL"
                oConnType = "THREADED"
                oActuator = "MANUAL"
                oPartToInsert = "ManualBallValveThreaded.ipt"
                Pictures_Off()
                picBallValveThreadedManual.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80"})
                Select Case oldDN
                    Case "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"
                        oldDN = "DN25"
                End Select
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()
            Case 2
                rbtCheckValveDiskWafer.Checked = True
                oItemName = "VALVE"
                oItemType = "CHECK"
                oConnType = "WAFER"
                oActuator = "DISK"
                oPartToInsert = "CheckValveDiskWafer.ipt"
                Pictures_Off()
                picCheckValveDiskWafer.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"304L", "316L"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()
            Case 3
                rbtDiaphragmValveFlangedManual.Checked = True
                oItemName = "VALVE"
                oItemType = "DIAPHRAGM"
                oConnType = "FLANGED"
                oActuator = "MANUAL"
                oPartToInsert = "ManualDiaphragmValveFlanged.ipt"
                Pictures_Off()
                picDiaphragmValveFlangedManual.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150"})
                Select Case oldDN
                    Case "DN200", "DN250", "DN300"
                        oldDN = "DN50"
                End Select
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()
            Case 4
                rbtGateValveFlanged.Checked = True
                oItemName = "VALVE"
                oItemType = "GATE"
                oConnType = "FLANGED"
                oActuator = "MANUAL"
                oPartToInsert = "ManualGateValveFlanged.ipt"
                Pictures_Off()
                picGateValveFlanged.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
                Select Case oldDN
                    Case "DN15", "DN20", "DN25", "DN32", "DN40"
                        oldDN = "DN50"
                End Select
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()
            Case 5
                rbtGlobeValveFlanged.Checked = True
                oItemName = "VALVE"
                oItemType = "GLOBE"
                oConnType = "FLANGED"
                oActuator = "MANUAL"
                oPartToInsert = "ManualGlobeValveFlanged.ipt"
                Pictures_Off()
                picGlobeValveFlanged.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN15", "DN20", "DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"S235", "304L", "316L"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()
            Case 6
                rbtStrainerYTypeFlanged.Checked = True
                oItemName = "STRAINER"
                oItemType = "Y-TYPE"
                oConnType = "FLANGED"
                oActuator = ""
                oPartToInsert = "StrainerY-TypeFlanged.ipt"
                Pictures_Off()
                picStrainerYTypeFlanged.Visible = True
                Dim oldDN As String
                oldDN = cbxDN.Text
                cbxDN.Items.Clear()
                cbxDN.Items.AddRange(New Object() {"DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300"})
                Select Case oldDN
                    Case "DN15", "DN20", "DN25", "DN32"
                        oldDN = "DN40"
                End Select
                cbxDN.Text = oldDN
                'oldDN = Nothing
                'cbxDN.SelectedIndex = 0
                cbxMaterial.Items.Clear()
                cbxMaterial.Items.AddRange(New Object() {"GGG50", "304L", "316L"})
                cbxMaterial.SelectedIndex = 0
                Get_DNsize()
                Get_Material()
                Get_Filename()
                Get_ProjectPath()
                Get_iMateDefItem()

        End Select
    End Sub

    Private Sub cbxDN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDN.SelectedIndexChanged
        oSize = cbxDN.Text
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
    End Sub

    Private Sub cbxMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaterial.SelectedIndexChanged
        oMaterial = cbxMaterial.Text
        Get_DNsize()
        Get_Material()
        Get_Filename()
        Get_ProjectPath()
    End Sub


    Private Sub Get_iMateDefItem()
        Select Case oPartToInsert
            Case "ManualButterflyValveWaferType.ipt", "ManualButterflyValveLugType.ipt"
                Select Case oSize
                    Case "DN15"
                        iMateDefItem = 0
                    Case "DN20"
                        iMateDefItem = 0
                    Case "DN25"
                        iMateDefItem = 0
                    Case "DN32"
                        iMateDefItem = 0
                    Case "DN40"
                        iMateDefItem = 1
                    Case "DN50"
                        iMateDefItem = 2
                    Case "DN65"
                        iMateDefItem = 3
                    Case "DN80"
                        iMateDefItem = 4
                    Case "DN100"
                        iMateDefItem = 5
                    Case "DN125"
                        iMateDefItem = 6
                    Case "DN150"
                        iMateDefItem = 7
                    Case "DN200"
                        iMateDefItem = 8
                    Case "DN250"
                        iMateDefItem = 9
                    Case "DN300"
                        iMateDefItem = 10
                End Select
            Case "PneumaticButterflyValveLugType.ipt", "PneumaticButterflyValveWaferType.ipt"
                Select Case oSize
                    Case "DN15"
                        iMateDefItem = 0
                    Case "DN20"
                        iMateDefItem = 0
                    Case "DN25"
                        iMateDefItem = 0
                    Case "DN32"
                        iMateDefItem = 0
                    Case "DN40"
                        iMateDefItem = 0
                    Case "DN50"
                        iMateDefItem = 1
                    Case "DN65"
                        iMateDefItem = 2
                    Case "DN80"
                        iMateDefItem = 3
                    Case "DN100"
                        iMateDefItem = 4
                    Case "DN125"
                        iMateDefItem = 5
                    Case "DN150"
                        iMateDefItem = 6
                    Case "DN200"
                        iMateDefItem = 7
                    Case "DN250"
                        iMateDefItem = 8
                    Case "DN300"
                        iMateDefItem = 9
                End Select
            Case "ManualSanitaryButterFlyValveWelded.ipt", "PneumaticSanitaryButterFlyValveWelded.ipt"
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 1
                        Case "DN20"
                            iMateDefItem = 2
                        Case "DN25"
                            iMateDefItem = 3
                        Case "DN32"
                            iMateDefItem = 4
                        Case "DN40"
                            iMateDefItem = 5
                        Case "DN50"
                            iMateDefItem = 6
                        Case "DN65"
                            iMateDefItem = 7
                        Case "DN80"
                            iMateDefItem = 8
                        Case "DN100"
                            iMateDefItem = 9
                        Case "DN125"
                            iMateDefItem = 10
                        Case "DN150"
                            iMateDefItem = 11
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 12
                        Case "DN20"
                            iMateDefItem = 13
                        Case "DN25"
                            iMateDefItem = 14
                        Case "DN32"
                            iMateDefItem = 15
                        Case "DN40"
                            iMateDefItem = 16
                        Case "DN50"
                            iMateDefItem = 17
                        Case "DN65"
                            iMateDefItem = 18
                        Case "DN80"
                            iMateDefItem = 19
                        Case "DN100"
                            iMateDefItem = 20
                        Case "DN125"
                            iMateDefItem = 21
                        Case "DN150"
                            iMateDefItem = 22
                    End Select
                End If
            Case "ManualBallValveButtWeld.ipt", "ManualBallValveThreaded.ipt", "PneumaticBallValveButtWeld.ipt", "PneumaticBallValveThreaded.ipt", "StrainerY-TypeThreaded.ipt", "ManualGlobeValveThreaded.ipt"
                If oMaterial = "S235" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 1
                        Case "DN20"
                            iMateDefItem = 2
                        Case "DN25"
                            iMateDefItem = 3
                        Case "DN32"
                            iMateDefItem = 4
                        Case "DN40"
                            iMateDefItem = 5
                        Case "DN50"
                            iMateDefItem = 6
                    End Select
                End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 7
                        Case "DN20"
                            iMateDefItem = 8
                        Case "DN25"
                            iMateDefItem = 9
                        Case "DN32"
                            iMateDefItem = 10
                        Case "DN40"
                            iMateDefItem = 11
                        Case "DN50"
                            iMateDefItem = 12

                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 13
                        Case "DN20"
                            iMateDefItem = 14
                        Case "DN25"
                            iMateDefItem = 15
                        Case "DN32"
                            iMateDefItem = 16
                        Case "DN40"
                            iMateDefItem = 17
                        Case "DN50"
                            iMateDefItem = 18
                    End Select
                End If
            Case "ManualBallValveFlanged.ipt", "PneumaticBallValveFlanged.ipt"
                If oMaterial = "S235" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 1
                        Case "DN20"
                            iMateDefItem = 2
                        Case "DN25"
                            iMateDefItem = 3
                        Case "DN32"
                            iMateDefItem = 4
                        Case "DN40"
                            iMateDefItem = 5
                        Case "DN50"
                            iMateDefItem = 6
                        Case "DN65"
                            iMateDefItem = 7
                        Case "DN80"
                            iMateDefItem = 8
                        Case "DN100"
                            iMateDefItem = 9
                    End Select
                End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 10
                        Case "DN20"
                            iMateDefItem = 11
                        Case "DN25"
                            iMateDefItem = 12
                        Case "DN32"
                            iMateDefItem = 13
                        Case "DN40"
                            iMateDefItem = 14
                        Case "DN50"
                            iMateDefItem = 15
                        Case "DN65"
                            iMateDefItem = 16
                        Case "DN80"
                            iMateDefItem = 17
                        Case "DN100"
                            iMateDefItem = 18
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 19
                        Case "DN20"
                            iMateDefItem = 20
                        Case "DN25"
                            iMateDefItem = 21
                        Case "DN32"
                            iMateDefItem = 22
                        Case "DN40"
                            iMateDefItem = 23
                        Case "DN50"
                            iMateDefItem = 24
                        Case "DN65"
                            iMateDefItem = 25
                        Case "DN80"
                            iMateDefItem = 26
                        Case "DN100"
                            iMateDefItem = 27
                    End Select
                End If
            Case "ManualBallValveGlued.ipt", "PneumaticBallValveGlued.ipt", "CheckValveTrueUnionGlued.ipt"
                Select Case oSize
                    Case "DN15"
                        iMateDefItem = 1
                    Case "DN20"
                        iMateDefItem = 2
                    Case "DN25"
                        iMateDefItem = 3
                    Case "DN32"
                        iMateDefItem = 4
                    Case "DN40"
                        iMateDefItem = 5
                    Case "DN50"
                        iMateDefItem = 6
                    Case "DN65"
                        iMateDefItem = 7
                    Case "DN80"
                        iMateDefItem = 8
                    Case "DN100"
                        iMateDefItem = 9
                End Select

            Case "CheckValveSwingWafer.ipt"
                If oMaterial = "304L" Then
                    Select Case oSize

                        Case "DN32"
                            iMateDefItem = 1
                        Case "DN40"
                            iMateDefItem = 2
                        Case "DN50"
                            iMateDefItem = 3
                        Case "DN65"
                            iMateDefItem = 4
                        Case "DN80"
                            iMateDefItem = 5
                        Case "DN100"
                            iMateDefItem = 6
                        Case "DN125"
                            iMateDefItem = 7
                        Case "DN150"
                            iMateDefItem = 8
                        Case "DN200"
                            iMateDefItem = 9
                        Case "DN250"
                            iMateDefItem = 10
                        Case "DN300"
                            iMateDefItem = 11
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize

                        Case "DN32"
                            iMateDefItem = 12
                        Case "DN40"
                            iMateDefItem = 13
                        Case "DN50"
                            iMateDefItem = 14
                        Case "DN65"
                            iMateDefItem = 15
                        Case "DN80"
                            iMateDefItem = 16
                        Case "DN100"
                            iMateDefItem = 17
                        Case "DN125"
                            iMateDefItem = 18
                        Case "DN150"
                            iMateDefItem = 19
                        Case "DN200"
                            iMateDefItem = 20
                        Case "DN250"
                            iMateDefItem = 21
                        Case "DN300"
                            iMateDefItem = 22
                    End Select
                End If
            Case "CheckValveDualPlateWafer.ipt"
                If oMaterial = "GG40" Then
                    Select Case oSize

                        Case "DN50"
                            iMateDefItem = 1
                        Case "DN65"
                            iMateDefItem = 2
                        Case "DN80"
                            iMateDefItem = 3
                        Case "DN100"
                            iMateDefItem = 4
                        Case "DN125"
                            iMateDefItem = 5
                        Case "DN150"
                            iMateDefItem = 6
                        Case "DN200"
                            iMateDefItem = 7
                        Case "DN250"
                            iMateDefItem = 8
                        Case "DN300"
                            iMateDefItem = 9
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize

                        Case "DN50"
                            iMateDefItem = 10
                        Case "DN65"
                            iMateDefItem = 11
                        Case "DN80"
                            iMateDefItem = 12
                        Case "DN100"
                            iMateDefItem = 13
                        Case "DN125"
                            iMateDefItem = 14
                        Case "DN150"
                            iMateDefItem = 15
                        Case "DN200"
                            iMateDefItem = 16
                        Case "DN250"
                            iMateDefItem = 17
                        Case "DN300"
                            iMateDefItem = 18
                    End Select
                End If

            Case "CheckValveDiskWafer.ipt"

                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 1
                        Case "DN20"
                            iMateDefItem = 2
                        Case "DN25"
                            iMateDefItem = 3
                        Case "DN32"
                            iMateDefItem = 4
                        Case "DN40"
                            iMateDefItem = 5
                        Case "DN50"
                            iMateDefItem = 6
                        Case "DN65"
                            iMateDefItem = 7
                        Case "DN80"
                            iMateDefItem = 8
                        Case "DN100"
                            iMateDefItem = 9
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 10
                        Case "DN20"
                            iMateDefItem = 11
                        Case "DN25"
                            iMateDefItem = 12
                        Case "DN32"
                            iMateDefItem = 13
                        Case "DN40"
                            iMateDefItem = 14
                        Case "DN50"
                            iMateDefItem = 15
                        Case "DN65"
                            iMateDefItem = 16
                        Case "DN80"
                            iMateDefItem = 17
                        Case "DN100"
                            iMateDefItem = 18
                    End Select
                End If
            Case "CheckValveBallGlued.ipt", "StrainerY-TypeGlued.ipt", "ManualDiaphragmValveGlued.ipt", "PneumaticDiaphragmValveGlued.ipt"
                Select Case oSize
                    Case "DN15"
                        iMateDefItem = 1
                    Case "DN20"
                        iMateDefItem = 2
                    Case "DN25"
                        iMateDefItem = 3
                    Case "DN32"
                        iMateDefItem = 4
                    Case "DN40"
                        iMateDefItem = 5
                    Case "DN50"
                        iMateDefItem = 6
                End Select

            Case "CheckValveBallFlanged.ipt", "StrainerY-TypeFlanged.ipt"
                If oMaterial = "GGG50" Then
                    Select Case oSize
                        Case "DN40"
                            iMateDefItem = 1
                        Case "DN50"
                            iMateDefItem = 2
                        Case "DN65"
                            iMateDefItem = 3
                        Case "DN80"
                            iMateDefItem = 4
                        Case "DN100"
                            iMateDefItem = 5
                        Case "DN125"
                            iMateDefItem = 6
                        Case "DN150"
                            iMateDefItem = 7
                        Case "DN200"
                            iMateDefItem = 8
                        Case "DN250"
                            iMateDefItem = 9
                        Case "DN300"
                            iMateDefItem = 10
                    End Select
                End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN40"
                            iMateDefItem = 11
                        Case "DN50"
                            iMateDefItem = 12
                        Case "DN65"
                            iMateDefItem = 13
                        Case "DN80"
                            iMateDefItem = 14
                        Case "DN100"
                            iMateDefItem = 15
                        Case "DN125"
                            iMateDefItem = 16
                        Case "DN150"
                            iMateDefItem = 17
                        Case "DN200"
                            iMateDefItem = 18
                        Case "DN250"
                            iMateDefItem = 19
                        Case "DN300"
                            iMateDefItem = 20
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN40"
                            iMateDefItem = 21
                        Case "DN50"
                            iMateDefItem = 22
                        Case "DN65"
                            iMateDefItem = 23
                        Case "DN80"
                            iMateDefItem = 24
                        Case "DN100"
                            iMateDefItem = 25
                        Case "DN125"
                            iMateDefItem = 26
                        Case "DN150"
                            iMateDefItem = 27
                        Case "DN200"
                            iMateDefItem = 28
                        Case "DN250"
                            iMateDefItem = 29
                        Case "DN300"
                            iMateDefItem = 30
                    End Select
                End If
            Case "ManualGateValveFlanged.ipt"
                If oMaterial = "S235" Then
                    Select Case oSize
                        Case "DN50"
                            iMateDefItem = 1
                        Case "DN65"
                            iMateDefItem = 2
                        Case "DN80"
                            iMateDefItem = 3
                        Case "DN100"
                            iMateDefItem = 4
                        Case "DN125"
                            iMateDefItem = 5
                        Case "DN150"
                            iMateDefItem = 6
                        Case "DN200"
                            iMateDefItem = 7
                        Case "DN250"
                            iMateDefItem = 8
                        Case "DN300"
                            iMateDefItem = 9
                    End Select
                End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN50"
                            iMateDefItem = 10
                        Case "DN65"
                            iMateDefItem = 11
                        Case "DN80"
                            iMateDefItem = 12
                        Case "DN100"
                            iMateDefItem = 13
                        Case "DN125"
                            iMateDefItem = 14
                        Case "DN150"
                            iMateDefItem = 15
                        Case "DN200"
                            iMateDefItem = 16
                        Case "DN250"
                            iMateDefItem = 17
                        Case "DN300"
                            iMateDefItem = 18
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN50"
                            iMateDefItem = 19
                        Case "DN65"
                            iMateDefItem = 20
                        Case "DN80"
                            iMateDefItem = 21
                        Case "DN100"
                            iMateDefItem = 22
                        Case "DN125"
                            iMateDefItem = 23
                        Case "DN150"
                            iMateDefItem = 24
                        Case "DN200"
                            iMateDefItem = 25
                        Case "DN250"
                            iMateDefItem = 26
                        Case "DN300"
                            iMateDefItem = 27
                    End Select
                End If
            Case "ManualGateKnifeValveType.ipt"
                Select Case oSize
                    Case "DN50"
                        iMateDefItem = 1
                    Case "DN65"
                        iMateDefItem = 2
                    Case "DN80"
                        iMateDefItem = 3
                    Case "DN100"
                        iMateDefItem = 4
                    Case "DN125"
                        iMateDefItem = 5
                    Case "DN150"
                        iMateDefItem = 6
                    Case "DN200"
                        iMateDefItem = 7
                    Case "DN250"
                        iMateDefItem = 8
                    Case "DN300"
                        iMateDefItem = 9
                End Select
            Case "ManualGateValveThreaded.ipt"
                If oMaterial = "S235" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 1
                        Case "DN20"
                            iMateDefItem = 2
                        Case "DN25"
                            iMateDefItem = 3
                        Case "DN32"
                            iMateDefItem = 4
                        Case "DN40"
                            iMateDefItem = 5
                        Case "DN50"
                            iMateDefItem = 6
                        Case "DN65"
                            iMateDefItem = 7
                        Case "DN80"
                            iMateDefItem = 8
                    End Select
                End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 9
                        Case "DN20"
                            iMateDefItem = 10
                        Case "DN25"
                            iMateDefItem = 11
                        Case "DN32"
                            iMateDefItem = 12
                        Case "DN40"
                            iMateDefItem = 13
                        Case "DN50"
                            iMateDefItem = 14
                        Case "DN65"
                            iMateDefItem = 15
                        Case "DN80"
                            iMateDefItem = 16
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 17
                        Case "DN20"
                            iMateDefItem = 18
                        Case "DN25"
                            iMateDefItem = 19
                        Case "DN32"
                            iMateDefItem = 20
                        Case "DN40"
                            iMateDefItem = 21
                        Case "DN50"
                            iMateDefItem = 22
                        Case "DN65"
                            iMateDefItem = 23
                        Case "DN80"
                            iMateDefItem = 24
                    End Select
                End If


            Case "ManualDiaphragmValveButtWeld.ipt", "PneumaticDiaphragmValveButtWeld.ipt"

                If oMaterial = "S235" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 1
                        Case "DN20"
                            iMateDefItem = 2
                        Case "DN25"
                            iMateDefItem = 3
                        Case "DN32"
                            iMateDefItem = 4
                        Case "DN40"
                            iMateDefItem = 5
                        Case "DN50"
                            iMateDefItem = 6
                        Case "DN65"
                            iMateDefItem = 7
                        Case "DN80"
                            iMateDefItem = 8
                        Case "DN100"
                            iMateDefItem = 9
                        Case "DN125"
                            iMateDefItem = 10
                        Case "DN150"
                            iMateDefItem = 11
                        Case "DN200"
                            iMateDefItem = 12
                        Case "DN250"
                            iMateDefItem = 13
                        Case "DN300"
                            iMateDefItem = 14
                    End Select
                End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 15
                        Case "DN20"
                            iMateDefItem = 16
                        Case "DN25"
                            iMateDefItem = 17
                        Case "DN32"
                            iMateDefItem = 18
                        Case "DN40"
                            iMateDefItem = 19
                        Case "DN50"
                            iMateDefItem = 20
                        Case "DN65"
                            iMateDefItem = 21
                        Case "DN80"
                            iMateDefItem = 22
                        Case "DN100"
                            iMateDefItem = 23
                        Case "DN125"
                            iMateDefItem = 24
                        Case "DN150"
                            iMateDefItem = 25
                        Case "DN200"
                            iMateDefItem = 26
                        Case "DN250"
                            iMateDefItem = 27
                        Case "DN300"
                            iMateDefItem = 28
                    End Select
                End If
                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 29
                        Case "DN20"
                            iMateDefItem = 30
                        Case "DN25"
                            iMateDefItem = 31
                        Case "DN32"
                            iMateDefItem = 32
                        Case "DN40"
                            iMateDefItem = 33
                        Case "DN50"
                            iMateDefItem = 34
                        Case "DN65"
                            iMateDefItem = 35
                        Case "DN80"
                            iMateDefItem = 36
                        Case "DN100"
                            iMateDefItem = 37
                        Case "DN125"
                            iMateDefItem = 38
                        Case "DN150"
                            iMateDefItem = 39
                        Case "DN200"
                            iMateDefItem = 40
                        Case "DN250"
                            iMateDefItem = 41
                        Case "DN300"
                            iMateDefItem = 42
                    End Select

                End If

            Case "ManualDiaphragmValveFlanged.ipt", "PneumaticDiaphragmValveFlanged.ipt"
                    If oMaterial = "S235" Then
                        Select Case oSize
                            Case "DN15"
                                iMateDefItem = 1
                            Case "DN20"
                                iMateDefItem = 2
                            Case "DN25"
                                iMateDefItem = 3
                            Case "DN32"
                                iMateDefItem = 4
                            Case "DN40"
                                iMateDefItem = 5
                            Case "DN50"
                                iMateDefItem = 6
                            Case "DN65"
                                iMateDefItem = 7
                            Case "DN80"
                                iMateDefItem = 8
                            Case "DN100"
                                iMateDefItem = 9
                            Case "DN125"
                                iMateDefItem = 10
                            Case "DN150"
                                iMateDefItem = 11
                            Case "DN200"
                                iMateDefItem = 12
                            Case "DN250"
                                iMateDefItem = 13
                            Case "DN300"
                                iMateDefItem = 14
                        End Select
                    End If
                If oMaterial = "304L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 15
                        Case "DN20"
                            iMateDefItem = 16
                        Case "DN25"
                            iMateDefItem = 17
                        Case "DN32"
                            iMateDefItem = 18
                        Case "DN40"
                            iMateDefItem = 19
                        Case "DN50"
                            iMateDefItem = 20
                        Case "DN65"
                            iMateDefItem = 21
                        Case "DN80"
                            iMateDefItem = 22
                        Case "DN100"
                            iMateDefItem = 23
                        Case "DN125"
                            iMateDefItem = 24
                        Case "DN150"
                            iMateDefItem = 25
                        Case "DN200"
                            iMateDefItem = 26
                        Case "DN250"
                            iMateDefItem = 27
                        Case "DN300"
                            iMateDefItem = 28
                    End Select
                End If

                If oMaterial = "316L" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 29
                        Case "DN20"
                            iMateDefItem = 30
                        Case "DN25"
                            iMateDefItem = 31
                        Case "DN32"
                            iMateDefItem = 32
                        Case "DN40"
                            iMateDefItem = 33
                        Case "DN50"
                            iMateDefItem = 34
                        Case "DN65"
                            iMateDefItem = 35
                        Case "DN80"
                            iMateDefItem = 36
                        Case "DN100"
                            iMateDefItem = 37
                        Case "DN125"
                            iMateDefItem = 38
                        Case "DN150"
                            iMateDefItem = 39
                        Case "DN200"
                            iMateDefItem = 40
                        Case "DN250"
                            iMateDefItem = 41
                        Case "DN300"
                            iMateDefItem = 42
                    End Select
                End If
                If oMaterial = "PVC" Then
                    Select Case oSize
                        Case "DN15"
                            iMateDefItem = 43
                        Case "DN20"
                            iMateDefItem = 44
                        Case "DN25"
                            iMateDefItem = 45
                        Case "DN32"
                            iMateDefItem = 46
                        Case "DN40"
                            iMateDefItem = 47
                        Case "DN50"
                            iMateDefItem = 48
                        Case "DN65"
                            iMateDefItem = 49
                        Case "DN80"
                            iMateDefItem = 50
                        Case "DN100"
                            iMateDefItem = 51
                    End Select
                End If

        End Select
    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        If iMateDefItem = 0 Then
            MsgBox("This size is not supported", vbOKOnly + "4064", "Warning")
            GoTo EndRoutine
        End If
        If oInvApp.ActiveDocumentType = DocumentTypeEnum.kAssemblyDocumentObject Then
            GoTo BeginRoutine
        Else MsgBox("Open, Create or Activate an Assembly !", vbOKOnly + "4064", "Warning")
            GoTo EndRoutine
        End If
BeginRoutine:
        Dim valveAngle As Double = 0
        oPartPath = oProjectPath & "\Piping\Valves\"
        'MsgBox(oPartPath, vbOKOnly + "4064", "Warning")

        Try
            If Not Directory.Exists(oPartPath) Then
                Directory.CreateDirectory(oPartPath)
            End If
        Catch ex As Exception
            MsgBox("Could not create the part directory.", vbOKOnly + "4064", "Warning")
            Exit Sub
        End Try


        If Dir(oPartPath & oPartToInsert) = "" Then
            GoTo CopyValve
        Else
            GoTo PlaceValve
        End If


CopyValve:

        Try
            Dim oPartStream As IO.Stream = System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream("Panta_Valve." & oPartToInsert)
            Dim bytes() As Byte
            Using br As New IO.BinaryReader(oPartStream)
                bytes = br.ReadBytes(oPartStream.Length)
            End Using

            IO.File.WriteAllBytes(oPartPath & oPartToInsert, bytes)
        Catch ex As Exception
            MsgBox("something went wrong saving this file", vbOKOnly + "4064", "Warning")
            Exit Sub
        End Try

PlaceValve:

        asmDoc = oInvApp.ActiveDocument
        If asmDoc.ComponentDefinition.ImmediateReferencedDefinitions.Count < 1 Then
            Dim trans As Matrix
            trans = oInvApp.TransientGeometry.CreateMatrix
            valveOcc = asmDoc.ComponentDefinition.Occurrences.AddiPartMember((oPartPath & oPartToInsert), oInvApp.TransientGeometry.CreateMatrix, iMateDefItem)
            'valveOcc = asmDoc.ComponentDefinition.Occurrences.Add((oPartPath & oPartToInsert), trans)
            valveOcc.Grounded = True
            GoTo EndRoutine
        End If

        'Placing an i-part with an insert i-mate 

        Me.Hide()
        Dim oSelectEdge As Edge

        oSelectEdge = oInvApp.CommandManager.Pick(SelectionFilterEnum.kAllCircularEntities, "Select a circular edge.")
        If oSelectEdge Is Nothing Then
            GoTo EndRoutine
        End If

        valveOcc = asmDoc.ComponentDefinition.Occurrences.AddiPartMember((oPartPath & oPartToInsert), oInvApp.TransientGeometry.CreateMatrix, iMateDefItem)
        Dim valveDoc As PartDocument
        valveDoc = valveOcc.Definition.Document

        Call asmDoc.ComponentDefinition.Constraints.AddInsertConstraint(oSelectEdge, valveOcc.iMateDefinitions.Item(1), True, 0)

        Select Case oPartToInsert
            Case "CheckValveDiskWafer.ipt", "CheckValveDualPlateWafer.ipt", "CheckValveSwingWafer.ipt", "CheckValveTrueUnionGlued.ipt"
                GoTo EndRoutine
        End Select


        'MsgBox(oPartPath, vbOKOnly + "4064", "Warning")
        Dim pi As Double
        pi = Math.Acos(-1)





        'Proxyplane maken van het werkvlak paralel met het insertvlak

        Dim oCrossPlane As WorkPlane
        oCrossPlane = Nothing
        Dim oCrossPlaneProxy As WorkPlaneProxy
        oCrossPlaneProxy = Nothing
        oCrossPlane = valveDoc.ComponentDefinition.WorkPlanes(2)
        Call valveOcc.CreateGeometryProxy(oCrossPlane, oCrossPlaneProxy)

        'bepaal de hoek tussen het insertvlak en één der werkvlakken van de assembly in graden

        Dim oOrientXY As Double
        Dim oOrientXZ As Double
        Dim oOrientYZ As Double

        oOrientXY = (oInvApp.MeasureTools.GetAngle(asmDoc.ComponentDefinition.WorkPlanes(3), oCrossPlaneProxy) / pi * 180)
        oOrientXZ = (oInvApp.MeasureTools.GetAngle(asmDoc.ComponentDefinition.WorkPlanes(2), oCrossPlaneProxy) / pi * 180)
        oOrientYZ = (oInvApp.MeasureTools.GetAngle(asmDoc.ComponentDefinition.WorkPlanes(1), oCrossPlaneProxy) / pi * 180)

        'oOrient is public gedeclareerd zie begin

        oOrient = "Not aligned"

        'Check the orientation of the part

        If oOrientXY = 90 Then
            oOrient = "XYaxis"
        End If
        If oOrientXZ = 90 Then
            oOrient = "XZaxis"
        End If
        If oOrientYZ = 90 Then
            oOrient = "YZaxis"
        End If

        'MsgBox(oOrient)















        'MsgBox(oOrient)


        oValveAngle = 0

        'Afhangkelijk van welk vlak er haaks tov het insertvlak staat wordt er een constraint gemaakt met middenvlak (werkvlak1) van de elbow

        If oOrient = "XYaxis" Then
            Dim oPartAnglePlane As WorkPlane
            oPartAnglePlane = valveDoc.ComponentDefinition.WorkPlanes(1)

            oValveAglePlaneProxy = Nothing
            Try
                Call valveOcc.CreateGeometryProxy(oPartAnglePlane, oValveAglePlaneProxy)
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(3), oValveAglePlaneProxy, oValveAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try

            frmValveRotate.ShowDialog()

            If frmValveRotate.oEnterclick = True Then
                GoTo EndRoutine
            End If
            If frmValveRotate.oEnterclick = False Then
                GoTo EnterclickFalse
            End If

        End If

        If oOrient = "XZaxis" Then
            Dim oPartAnglePlane As WorkPlane
            oPartAnglePlane = valveDoc.ComponentDefinition.WorkPlanes(1)

            oValveAglePlaneProxy = Nothing
            Try
                Call valveOcc.CreateGeometryProxy(oPartAnglePlane, oValveAglePlaneProxy)
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(2), oValveAglePlaneProxy, oValveAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try

            frmValveRotate.ShowDialog()

            If frmValveRotate.oEnterclick = True Then
                GoTo EndRoutine
            End If
            If frmValveRotate.oEnterclick = False Then
                GoTo EnterclickFalse
            End If
        End If

        If oOrient = "YZaxis" Then
            Dim oPartAnglePlane As WorkPlane
            oPartAnglePlane = valveDoc.ComponentDefinition.WorkPlanes(1)

            oValveAglePlaneProxy = Nothing
            Try
                Call valveOcc.CreateGeometryProxy(oPartAnglePlane, oValveAglePlaneProxy)
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(1), oValveAglePlaneProxy, oValveAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try

            frmValveRotate.ShowDialog()

            If frmValveRotate.oEnterclick = True Then
                GoTo EndRoutine
            End If
            If frmValveRotate.oEnterclick = False Then
                GoTo EnterclickFalse
            End If
        End If
        If frmValveRotate.oEnterclick = False Then
            GoTo EnterclickFalse
        End If
        'END TEST ROTATION ELBOW
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 
        '- - - - - - - - - - - - - - - - - - - - - -- - - - -- - -- - - - - -- 

EnterclickFalse:
        Me.Show()

EndRoutine:
        Me.Show()
    End Sub


End Class