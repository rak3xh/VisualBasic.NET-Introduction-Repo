Public Class Form1
    Private Sub btnBinarySearch_Click(sender As Object, e As EventArgs) Handles btnBinarySearch.Click
        Dim numbers(20) As Integer
        Dim n As Integer
        n = InputBox("Enter the size of the Array")
        Dim i As Integer
        For i = 0 To n - 1
            numbers(i) = InputBox("enter the element " & (i + 1) & " of array")
        Next


        ' Value to search for
        Dim searchValue As Integer
        searchValue = InputBox("Enter the number to be searched")


        ' Perform linear search
        Dim index As Integer = BinarySearch(numbers, searchValue, n)

        ' Output the result
        If index <> -1 Then
            ' Console.WriteLine("Value " & searchValue & " found at index " & index)
            MsgBox("Found at " & index + 1 & " Position")
        Else
            'Console.WriteLine("Value " & searchValue & " not found in the array")
            MsgBox("Not Found")
        End If
    End Sub
    Function BinarySearch(ByVal arr() As Integer, ByVal value As Integer, ByVal n As Integer) As Integer
        Dim first As Integer = 0
        Dim last As Integer = n - 1
        Dim middle As Integer = (first + last) / 2

        While (first <= last)
            If arr(middle) = value Then
                Return middle
            ElseIf arr(middle) < value Then
                first = middle + 1
            Else
                last = middle - 1
            End If
            middle = (first + last) / 2
        End While
        Return -1
    End Function


End Class
