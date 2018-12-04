Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Faculty() As String = {"คณะวิศวกรรมศาสตร์", "ตณะเทคโนโลยีสารสนเทศ", "คณะบริหารธุรกิจ"}
        ComboType.Items.Clear()
        ComboType.Items.AddRange(Faculty)



    End Sub

    Private Sub ComboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboType.SelectedIndexChanged

        Dim Engineer() As String = {"สาขาวิชาวิศวกรรมยานยนต์ (AE)", "สาขาวิชาวิศวกรรมการผลิต (PE)", "สาขาวิชาวิศวกรรมคอมพิวเตอร์ (CE)", "สาขาวิชาวิศวกรรมอุตสาหการ (IE)", "สาขาวิชาวิศวกรรมไฟฟ้า (EE)", "สาขาวิชาเทคโนโลยีวิศวกรรม (MET)(ป.โท)"}
        Dim Information() As String = {"สาขาวิชาเทคโนโลยีสารสนเทศ (IT)", "สาขาวิชาเทคโนโลยีมัลติมิเดีย (MT)", "สาขาวิชาเทคโนโลยีสารสนเทศทางธุรกิจ (BI)", "สาขาวิชาเทคโนโลยีดิจิทัลทางสื่อสารมวลชน (DC)", "Data Science And Analytics (International Program)", "สาขาวิชาเทคโนโลยีสารสนเทศ (MIT) (ป.ตรี)"}
        Dim business() As String = {"สาขาวิชาการจัดการเทคโนโลยี และนวัตกรรมการผลิต (MI)", "สาขาวิชาบริหารธุรกิจอุตสาหกรรม (BM)", "สาขาวิชาบริหารธุรกิจญี่ปุ่น (BJ)", "สาขาวิชาการจัดการธุรกิจระหว่างประเทศ (IB)", "สาขาวิชาการบัญชี (AC)", "สาขาวิชาการจัดการทรัพยากรมนุษย์แบบญี่ปุ่น (HRJ)", "สาขาวิชาการจัดการโลจิสติกส์และโซ่อุปทาน (LM)", "สาขาวิชาการตลาดเชิงสร้างสรรค์ (CM)", "สาขาการจัดการท่องเที่ยวและการบริการเชิงนวัตกรรม (TH)", "สาขาวิชานวัตกรรมการจัดการธุรกิจและอุตสาหกรรม (MBI) (ป.ตรี)", "สาขาวิชาบริหารธุรกิจญี่ปุ่น (MBJ) (ป.ตรี)"}


        If ComboType.SelectedIndex = 0 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(Engineer)
        ElseIf ComboType.SelectedIndex = 1 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(Information)
        ElseIf ComboType.SelectedIndex = 2 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(business)
        End If


    End Sub


    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click

        Dim confirm As DialogResult
        confirm = MessageBox.Show("ยืนยันข้อมูลหรือไม่", "ยืนยันข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then

            Dim type As String = ComboType.SelectedItem
            Dim subject As String = ComboSubject.SelectedItem
            Dim number As String = TextBox1.Text
            Dim name As String = TextBox2.Text

            MessageBox.Show("เลขบัตรประชาชน : " & number & vbNewLine &
                            "ชื่อ นามสกุล : " & name & vbNewLine &
                            "คณะ : " & type & vbNewLine &
                            "สาขา : " & subject & vbNewLine)


        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Dim Faculty() As String = {"คณะวิศวกรรมศาสตร์", "ตณะเทคโนโลยีสารสนเทศ", "คณะบริหารธุรกิจ"}
        ComboType.Items.Clear()
        ComboType.Items.AddRange(Faculty)

        ComboSubject.Items.Clear()
        Button1.Enabled = False
        ButtonShow.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, ComboSubject.SelectedIndexChanged, ComboType.SelectedIndexChanged

        If TextBox1.TextLength <> 0 Or TextBox2.TextLength <> 0 Or ComboType.SelectedIndex <> -1 Or ComboSubject.SelectedIndex <> -1 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 And ComboType.SelectedIndex <> -1 And ComboSubject.SelectedIndex <> -1 Then
            ButtonShow.Enabled = True
        Else
            ButtonShow.Enabled = False
        End If



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
