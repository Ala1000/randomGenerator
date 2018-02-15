Public Class Form1
    Dim rand_arr(20)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim random As New Random()

        Try
            For i = 0 To rand_arr.Length - 1
                rand_arr(i) = random.Next(0, 100)
                rand_disp.AppendText(rand_arr(i) & " ")
            Next
            sort(rand_arr)
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("OUT OF RANGE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub


    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        If search_box.Text <> String.Empty Then
            search_result_label.Text = String.Empty
            search()
        End If
       
    End Sub

    Private Sub linear_CheckedChanged(sender As Object, e As EventArgs) Handles linear.CheckedChanged
        If search_box.Text <> String.Empty Then
            search_result_label.Text = String.Empty
            search()
        End If
    End Sub

    Private Sub binary_CheckedChanged(sender As Object, e As EventArgs) Handles binary.CheckedChanged
        If search_box.Text <> String.Empty Then
            search_result_label.Text = String.Empty
            search()
        End If
    End Sub

    Private Sub search()
        Try
            Dim num_to_look_for As Integer = Convert.ToInt32(search_box.Text)
            Dim pos As Integer = -1
            If (linear.Checked) Then
                For i = 0 To rand_arr.Length - 1
                    If rand_arr(i) = num_to_look_for Then
                        pos = i
                        Exit For
                    End If
                Next
            Else
                pos = Array.BinarySearch(rand_arr, num_to_look_for)
            End If
            search_result_label.Text = pos
        Catch ex As FormatException
            MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sort(ByVal arr())
        Array.Sort(arr)
        For Each num In arr
            sorted_txt_box.AppendText(num & " ")
        Next
        min.Text = arr(0)
        max.Text = arr(arr.Length - 1)
    End Sub

End Class
