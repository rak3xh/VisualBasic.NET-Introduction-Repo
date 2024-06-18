Public Class Form1
    Private Sub btnbLinearSeach_Click(sender As Object, e As EventArgs) Handles btnbLinearSeach.Click
        Dim numbers(20) As Integer
        Dim n As Integer
        n = InputBox("Enter the size of the Array")
        Dim i As Integer
        For i = 0 To n - 1
            numbers(i) = InputBox("enter the element" & (i + 1) & "of array")
        Next


        ' Value to search for
        Dim searchValue As Integer
        searchValue = InputBox("Enter the number to be searched")


        ' Perform linear search
        Dim index As Integer = LinearSearch(numbers, searchValue)

        ' Output the result
        If index <> -1 Then
            ' Console.WriteLine("Value " & searchValue & " found at index " & index)
            MsgBox("Found at " & index + 1 & " Position")
        Else
            'Console.WriteLine("Value " & searchValue & " not found in the array")
            MsgBox("Not Found")
        End If
    End Sub
    Function LinearSearch(ByVal arr() As Integer, ByVal value As Integer) As Integer
        ' Iterate through the array
        For i As Integer = 0 To arr.Length - 1
            ' Check if the current element is the one we're looking for
            If arr(i) = value Then
                ' Return the index if found
                Return i
            End If
        Next

        ' Return -1 if the value is not found
        Return -1
    End Function


End Class
