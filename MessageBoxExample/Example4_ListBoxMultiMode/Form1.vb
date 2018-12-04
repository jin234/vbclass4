Public Class Form1


    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim message As String = ""
        For Each item In ListBoxMenu.SelectedItems

            message &= item & vbNewLine

        Next

        MessageBox.Show("คุณเลือก : " & vbNewLine & message)


    End Sub


End Class
