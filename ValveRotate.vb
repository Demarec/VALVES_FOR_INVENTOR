Imports Inventor


Public Class frmValveRotate

    Public oldPartAngle As Double
    Public newPartAngle As Double
    Public oEnterclick As Boolean = False
    Dim pi = Math.Acos(-1)
    Dim oRotateByAngle


    Private Sub frmValveRotate_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        TopMost = True
        oldPartAngle = frmValve.oValveAngle
        cbxValveTurnByAngle.SelectedIndex = 5
        oRotateByAngle = 45

    End Sub




    Private Sub RotateElbowByNewValues()


        If frmValve.oOrient = "XYaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oValveInsertAngle As Double
            oValveInsertAngle = newPartAngle
            asmDoc = frmValve.oInvApp.ActiveDocument
            Try
                frmValve.valveOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(3), frmValve.oValveAglePlaneProxy, oValveInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oValveInsertAngle
        End If

        If frmValve.oOrient = "XZaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oValveInsertAngle As Double
            oValveInsertAngle = newPartAngle
            asmDoc = frmValve.oInvApp.ActiveDocument
            Try
                frmValve.valveOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(2), frmValve.oValveAglePlaneProxy, oValveInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oValveInsertAngle
        End If

        If frmValve.oOrient = "YZaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oValveInsertAngle As Double
            oValveInsertAngle = newPartAngle
            asmDoc = frmValve.oInvApp.ActiveDocument
            Try
                frmValve.valveOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(1), frmValve.oValveAglePlaneProxy, oValveInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oValveInsertAngle
        End If


    End Sub



    Private Sub btnTurnPos_Click(sender As Object, e As EventArgs) Handles btnTurnPos.Click
        oEnterclick = False
        newPartAngle = oldPartAngle + (oRotateByAngle * pi / 180)
        If newPartAngle >= (360 * pi / 180) Then
            newPartAngle = 0
        End If
        If newPartAngle <= (-360 * pi / 180) Then
            newPartAngle = 0
        End If
        RotateElbowByNewValues()
    End Sub

    Private Sub btnTurnNeg_Click(sender As Object, e As EventArgs) Handles btnTurnNeg.Click
        oEnterclick = False
        newPartAngle = oldPartAngle - (oRotateByAngle * pi / 180)
        If newPartAngle >= (360 * pi / 180) Then
            newPartAngle = 0
        End If
        If newPartAngle <= (-360 * pi / 180) Then
            newPartAngle = 0
        End If
        RotateElbowByNewValues()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceptValveAngle.Click
        oEnterclick = True
        Close()
    End Sub

    Private Sub CbxTurnByAngle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxValveTurnByAngle.SelectedIndexChanged
        oRotateByAngle = cbxValveTurnByAngle.Text
    End Sub
End Class