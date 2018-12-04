Public Class Form1



    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim menu As String = ListBoxMenu.SelectedItem
        MessageBox.Show("คุณเลือก : " & vbNewLine & menu)
    End Sub



End Class
