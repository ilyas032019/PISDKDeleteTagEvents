Imports PISDK
Imports PISDKCommon

Public Class Form1
    Private ptlist As New PointList
    Private ptlist2 As IPointList2
    Private searchptlist As PointList
    Private Sub Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Connect2.Click
        'get selected server from PICK LIST Control
        Dim PIServer As PISDK.Server = PiServerPickList1.SelectedServer

        'get server from PISDK object hierarchy
        'Dim pisdk As New PISDK.PISDK
        'Dim Server As PISDK.Server = PISDK.Servers.DefaultServer

        'Optional calculation
        'Dim ipicalc As IPICalculation = Server

        'connect to PI Server
        Try
            PIServer.Open()
            MsgBox("Successfully Connected to :" + PIServer.Name.ToString + " as " + PIServer.CurrentUser)

            'Release the object
            PIServer = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'only use UID and PWD in connect string for explicit login(not recommended)
        ' Serverrole only applicable for PI HA Collective
        'Server.Open("UID=;PWD=;Serverrole=<PreferPrimary|Any|RequirePrimary>;")

    End Sub

    Private Sub Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disconnect.Click
        'get selected server from PICK LIST Control
        Dim PIServer As PISDK.Server = PiServerPickList1.SelectedServer
        Try
            PIServer.Close()
            MsgBox("Successfully Disconnected to :" + PIServer.Name.ToString)
            'Release the object
            PIServer = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConnectionManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectionManager.Click
        Dim DlgConnManager As New PISDKDlg.Connections
        DlgConnManager.ShowConnectionDialog2(False, 0, "Any")
    End Sub

    Private Sub TagSearchDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TagSearchDialog.Click
        'ptlist.Sorting = SortOrderConstants.soUnordered
        Dim PIServer As Server = PiServerPickList1.SelectedServer
        Dim tagsearch As New PISDKDlg.TagSearch
        searchptlist = tagsearch.Show()
        'Add Points to ListView1
        ptlist2 = ptlist
        ptlist2.Sorting = SortOrderConstants.soUnordered

        For Each pt As PIPoint In searchptlist
            ptlist.Add(pt)
            'Dim lvi As New ListViewItem
            'lvi.Text = pt.Name
            'ListView1.Items.Add(lvi)
            Dim displayvalues(2) As String
            displayvalues(0) = pt.Name
            displayvalues(1) = pt.PointAttributes("Descriptor").Value
            Dim lvi As New ListViewItem(displayvalues)
            ListView1.Items.Add(lvi)
        Next

    End Sub

    Public Property RemovalConstants As DataRemovalConstants

    Private Sub CompressedValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Function ReadPIValueString(ByVal value As PIValue) As String
        Dim stringvalue As String
        If TypeOf value.Value Is PISDK.DigitalState Then
            Dim ds As DigitalState = value.Value
            stringvalue = ds.Name
        ElseIf TypeOf value.Value Is PITimeServer.PITime Then
            Dim t As PITimeServer.PITime = value.Value
            stringvalue = t.LocalDate.ToString()
        Else
            stringvalue = value.Value.ToString()
        End If
        Return stringvalue
    End Function

    Private Sub TagListClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TagListClear.Click
        ListView1.Items.Clear()
        ptlist = New PointList
    End Sub

    Private Sub ListClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListClear.Click
        ListView2.Items.Clear()
    End Sub

    Private Sub DeleteValues_Click(sender As System.Object, e As System.EventArgs) Handles CompressedValue.Click
        Dim deletestring As String = DeleteValueTextBox.Text.Trim

        ListView2.Items.Clear()
        Dim pointnumber As Integer
        pointnumber = ListView1.SelectedIndices.Count
        If pointnumber < 1 Or ptlist Is Nothing Then
            MsgBox("Please select more than 1 tag from list")
            Return
        End If
        For i As Integer = 0 To pointnumber - 1
            Dim ind As Int32 = ListView1.SelectedIndices(i)
            Dim pt As PIPoint = ptlist(ind + 1)
            Dim values As PIValues = pt.Data.RecordedValues(TextBox3.Text, TextBox4.Text,
                                                            BoundaryTypeConstants.btInside, "",
                                                            FilteredViewConstants.fvRemoveFiltered, Nothing)
            Dim Checktime As String = Nothing
            Dim Checkvalue As String = Nothing
            For Each Value As PIValue In values
                Dim ipid2 As PISDK.IPIData2
                ipid2 = pt.Data
                Checktime = Value.TimeStamp.LocalDate.ToString()
                Checkvalue = ReadPIValueString(Value)

                If Checkvalue = deletestring Then
                    'Specify timestamp and delete all events
                    Dim vals As PIValues = New PIValues()
                    vals.ReadOnly = False
                    vals.Add(Checktime, Checkvalue, Nothing)
                    ipid2.RemoveSpecifiedValues(vals)
                    Dim displayvalues(3) As String
                    displayvalues(0) = pt.Name
                    displayvalues(1) = Checktime
                    displayvalues(2) = Checkvalue
                    Dim lvi As New ListViewItem(displayvalues)
                    ListView2.Items.Add(lvi)
                End If
            Next
        Next
    End Sub
End Class
