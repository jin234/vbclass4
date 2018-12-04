Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboType.Items.Add("Lecture")
        ComboType.Items.Add("Laboratory")



    End Sub

    Private Sub ComboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboType.SelectedIndexChanged

        Dim lecture() As String = {"Int-101", "Int-103", "Int-301"}
        Dim Laboratory() As String = {"Int-101", "Int-103", "Int-301"}


        If ComboType.SelectedIndex = 0 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(lecture)
        ElseIf ComboType.SelectedIndex = 1 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(Laboratory)
        End If



    End Sub


    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click

        Dim type As String = ComboType.SelectedItem
        Dim subject As String = ComboSubject.SelectedItem
        MessageBox.Show("ประเภทรายวิชา : " & type & vbNewLine & "รายวิชา : " & subject)





    End Sub


End Class
