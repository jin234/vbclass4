<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxMenu = New System.Windows.Forms.ListBox()
        Me.ListBoxselected = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เมนุทางร้าน"
        '
        'ListBoxMenu
        '
        Me.ListBoxMenu.FormattingEnabled = True
        Me.ListBoxMenu.Items.AddRange(New Object() {" "})
        Me.ListBoxMenu.Location = New System.Drawing.Point(12, 37)
        Me.ListBoxMenu.Name = "ListBoxMenu"
        Me.ListBoxMenu.Size = New System.Drawing.Size(128, 186)
        Me.ListBoxMenu.TabIndex = 1
        '
        'ListBoxselected
        '
        Me.ListBoxselected.FormattingEnabled = True
        Me.ListBoxselected.Items.AddRange(New Object() {" "})
        Me.ListBoxselected.Location = New System.Drawing.Point(250, 37)
        Me.ListBoxselected.Name = "ListBoxselected"
        Me.ListBoxselected.Size = New System.Drawing.Size(128, 186)
        Me.ListBoxselected.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "เมนูที่เลือก"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "เพิ่ม >"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "< ออก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(400, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 51)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "ยกเลิก"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(400, 37)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 52)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "สั่งอาหาร"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 236)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBoxselected)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxMenu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxMenu As ListBox
    Friend WithEvents ListBoxselected As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
