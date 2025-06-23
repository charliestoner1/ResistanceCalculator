Public Class Branch
    Private myResistorList As New List(Of Double)

    Public Sub AddResistor(ByVal aResistor As Double)
        'GIVEN CODE, DO NOT EDIT
        myResistorList.Add(aResistor)
    End Sub

    Public Function ResistorCount() As Integer
        'returns the number of resistors in this branch
        Dim count As Integer = 0
        For Each res In myResistorList
            If res > 0 Then
                count += 1
            End If
        Next
        Return count
    End Function

    Public Function Resistance() As Double
        'GIVEN CODE, DO NOT EDIT
        Dim totalresistance As Double
        For Each aResistor In myResistorList
            totalresistance += aResistor
        Next
        Return totalresistance
    End Function

    Public Function StringToFile() As String
        'returns a string with every resistor in the branch
        '(missing resistors not included) to be written to the file
        'YOUR CODE HERE
    End Function

    Public Function Resistor(ByVal index As Integer) As String
        'returns the resistance value at the specified branch position
        ' as a string (“-“ if no resistor at that position)
        'YOUR CODE HERE
        Dim s As String = "-"
        If myResistorList(index) > 0 Then
            s = Convert.ToString(myResistorList(index))
        End If
        Return s
    End Function
End Class
