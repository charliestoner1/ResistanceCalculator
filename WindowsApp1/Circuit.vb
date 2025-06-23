Public Class Circuit
    Private myBranchList As New List(Of Branch)

    Public Function Resistance() As Double
        'returns total resistance of the circuit
        Dim total As Double = 0
        For Each bra In myBranchList
            total += 1 / bra.Resistance
        Next
        Return Math.Round(1 / total, 2)
    End Function

    Public Function ResistorCount() As Double
        'returns the number of resistors in the circuit
        Dim count As Integer = 0
        For Each bra In myBranchList
            count += bra.ResistorCount()
        Next
        Return count
    End Function

    Public ReadOnly Property BranchCount As Integer
        'GIVEN CODE, DO NOT EDIT
        Get
            Return myBranchList.count
        End Get
    End Property

    Public Function Branch(ByVal index As Integer) As Branch
        'GIVEN CODE, DO NOT EDIT
        Return myBranchList.item(index)
    End Function

    Public Sub AddBranch(ByVal aBranch As Branch)
        'GIVEN CODE, DO NOT EDIT
        myBranchList.Add(aBranch)
    End Sub

End Class
