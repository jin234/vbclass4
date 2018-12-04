Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Menu() As String = {"ข้าวกระเพราหมู", "ข้าวกระเพราไก่", "ข้าวกระเพราเนื้อ", "ข้าวกระเพราทะเล", "ข้าวกระเพรามังสวิรัติ", "ข้าวกระเพราเจ", "น้ำเปล่า", "น้ำผลไม้รวม", "น้ำชา"}
        ListBoxselected.Items.Clear()
        ListBoxMenu.Items.Clear()
        ListBoxMenu.Items.AddRange(Menu)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim menu As String = ListBoxMenu.SelectedItem
        ListBoxselected.Items.Add(menu)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim menu As String = ListBoxselected.SelectedIndex
        ListBoxselected.Items.RemoveAt(menu)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim message As String = ""
        For Each item In ListBoxselected.Items

            message &= item & vbNewLine

        Next

        Dim confirm As DialogResult
        confirm = MessageBox.Show("ยืนยันรายการอาหารหรือไม่", "ยืนยันรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            MessageBox.Show("คุณสั่ง : " & vbNewLine & message)
            ListBoxselected.Items.Clear()
        End If





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBoxselected.Items.Clear()


    End Sub
End Class
