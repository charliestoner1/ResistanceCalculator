Public Class CircuitLoader
    Private myFileName As String

    Public Sub New(ByVal aFileName As String)
        'GIVEN CODE, DO NOT EDIT
        myFileName = aFileName
    End Sub

    Public Function LoadCircuit() As Circuit
        'reads the input file and returns a newly instantiated
        'and fully populated circuit object
        'YOUR CODE HERE
        Dim circuit As New Circuit

        FileOpen(1, myFileName, OpenMode.Input)
        Do Until (EOF(1))
            Dim branch As New Branch
            Dim resistor As New Double
            For i As Integer = 0 To 4
                Input(1, resistor)
                branch.AddResistor(resistor)
            Next
            circuit.AddBranch(branch)
        Loop
        FileClose(1)
        Return circuit
    End Function
End Class
