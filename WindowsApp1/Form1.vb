Public Class Form1
    Private myCircuit As Circuit

    Private Sub mnuFileLoad_Click(sender As Object, e As EventArgs) Handles mnuFileLoad.Click
        'GIVEN CODE, DO NOT EDIT
        If dlgLoad.ShowDialog = DialogResult.OK Then
            Dim aFileReader As New CircuitLoader(dlgLoad.FileName)
            myCircuit = aFileReader.LoadCircuit()
            PopulateListView()
            PopulateCircuitData()
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'GIVEN CODE, DO NOT EDIT
        If dlgSave.ShowDialog = DialogResult.OK Then
            Dim aFileWriter As New CircuitSaver(dlgSave.FileName)
            aFileWriter.SaveCircuit(myCircuit)
        End If
    End Sub

    Private Sub PopulateListView()
        'displays all branches of the circuit in the listview
        'each branch should be represented by a single row
        'for every position where there is no resistor, a '-' should appear
        'YOUR CODE HERE
        For i As Integer = 0 To myCircuit.BranchCount - 1
            Dim newRow As New ListViewItem(myCircuit.Branch(i).Resistor(0))
            For j As Integer = 1 To 4
                newRow.SubItems.Add(myCircuit.Branch(i).Resistor(j))
            Next
            lvwResistors.Items.Add(newRow)
        Next
    End Sub

    Private Sub PopulateCircuitData()
        'GIVEN CODE, DO NOT EDIT
        lblCircuitResistance.Text = Convert.ToString(myCircuit.Resistance)
        lblCircuitCount.Text = Convert.ToString(myCircuit.ResistorCount)
    End Sub


    Private Sub lvwResistors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwResistors.SelectedIndexChanged
        If lvwResistors.SelectedItems.Count > 0 Then
            ' Get the selected item
            gbxBranch.Enabled = True
            lblBranchResistance.Text = myCircuit.Branch(Convert.ToInt32(lvwResistors.SelectedIndices)).Resistance
            lblBranchCount.Text = myCircuit.Branch(Convert.ToInt32(lvwResistors.SelectedIndices)).ResistorCount
        End If
    End Sub
    'create and code an eventhandler so that each time a new branch is selected in the listview
    'the appropriate information for that branch is populated into the Branch groupbox
    'YOUR CODE HERE

End Class