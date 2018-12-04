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
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ListBoxMenu = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.Location = New System.Drawing.Point(265, 26)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(81, 34)
        Me.ButtonOK.TabIndex = 3
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ListBoxMenu
        '
        Me.ListBoxMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxMenu.FormattingEnabled = True
        Me.ListBoxMenu.ItemHeight = 20
        Me.ListBoxMenu.Items.AddRange(New Object() {"Lunch Box Set 1", "Lunch Box Set 2", "Lunch Box Set 3", "Lunch Box Set 4", "Lunch Box Set 5", "Lunch Box Set 6", "Lunch Box Set 7"})
        Me.ListBoxMenu.Location = New System.Drawing.Point(22, 26)
        Me.ListBoxMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxMenu.Name = "ListBoxMenu"
        Me.ListBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxMenu.Size = New System.Drawing.Size(230, 164)
        Me.ListBoxMenu.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 219)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ListBoxMenu)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonOK As Button
    Friend WithEvents ListBoxMenu As ListBox
End Class
