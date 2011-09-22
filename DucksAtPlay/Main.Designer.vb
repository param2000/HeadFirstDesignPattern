<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Quack = New System.Windows.Forms.Button()
        Me.Fly = New System.Windows.Forms.Button()
        Me.Swim = New System.Windows.Forms.Button()
        Me.lstDuckCollection = New System.Windows.Forms.ListBox()
        Me.lblSelectedDuck = New System.Windows.Forms.Label()
        Me.ChangeToComposition = New System.Windows.Forms.Button()
        Me.ChangeToInheritance = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Quack
        '
        Me.Quack.Location = New System.Drawing.Point(88, 114)
        Me.Quack.Name = "Quack"
        Me.Quack.Size = New System.Drawing.Size(75, 23)
        Me.Quack.TabIndex = 0
        Me.Quack.Text = "Quack"
        Me.Quack.UseVisualStyleBackColor = True
        '
        'Fly
        '
        Me.Fly.Location = New System.Drawing.Point(169, 114)
        Me.Fly.Name = "Fly"
        Me.Fly.Size = New System.Drawing.Size(75, 23)
        Me.Fly.TabIndex = 1
        Me.Fly.Text = "Fly"
        Me.Fly.UseVisualStyleBackColor = True
        '
        'Swim
        '
        Me.Swim.Location = New System.Drawing.Point(250, 114)
        Me.Swim.Name = "Swim"
        Me.Swim.Size = New System.Drawing.Size(75, 23)
        Me.Swim.TabIndex = 2
        Me.Swim.Text = "Swim"
        Me.Swim.UseVisualStyleBackColor = True
        '
        'lstDuckCollection
        '
        Me.lstDuckCollection.FormattingEnabled = True
        Me.lstDuckCollection.Location = New System.Drawing.Point(88, 31)
        Me.lstDuckCollection.Name = "lstDuckCollection"
        Me.lstDuckCollection.Size = New System.Drawing.Size(237, 43)
        Me.lstDuckCollection.TabIndex = 3
        '
        'lblSelectedDuck
        '
        Me.lblSelectedDuck.AutoSize = True
        Me.lblSelectedDuck.Location = New System.Drawing.Point(85, 87)
        Me.lblSelectedDuck.Name = "lblSelectedDuck"
        Me.lblSelectedDuck.Size = New System.Drawing.Size(68, 13)
        Me.lblSelectedDuck.TabIndex = 4
        Me.lblSelectedDuck.Text = "this is default"
        '
        'ChangeToComposition
        '
        Me.ChangeToComposition.Location = New System.Drawing.Point(349, 31)
        Me.ChangeToComposition.Name = "ChangeToComposition"
        Me.ChangeToComposition.Size = New System.Drawing.Size(150, 26)
        Me.ChangeToComposition.TabIndex = 5
        Me.ChangeToComposition.Text = "ChangeToComposition"
        Me.ChangeToComposition.UseVisualStyleBackColor = True
        '
        'ChangeToInheritance
        '
        Me.ChangeToInheritance.Location = New System.Drawing.Point(349, 63)
        Me.ChangeToInheritance.Name = "ChangeToInheritance"
        Me.ChangeToInheritance.Size = New System.Drawing.Size(150, 26)
        Me.ChangeToInheritance.TabIndex = 6
        Me.ChangeToInheritance.Text = "ChangeToInheritance"
        Me.ChangeToInheritance.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(88, 165)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(411, 158)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = "The Idea " & Global.Microsoft.VisualBasic.ChrW(10) & "MallardDuck can Do anything " & Global.Microsoft.VisualBasic.ChrW(10) & "RubberDuck Can Only Swim, " & Global.Microsoft.VisualBasic.ChrW(10) & "CanadianDuck Ca" & _
            "nt Fly" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "SuperDuck Can Do Anything"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 335)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ChangeToInheritance)
        Me.Controls.Add(Me.ChangeToComposition)
        Me.Controls.Add(Me.lblSelectedDuck)
        Me.Controls.Add(Me.lstDuckCollection)
        Me.Controls.Add(Me.Swim)
        Me.Controls.Add(Me.Fly)
        Me.Controls.Add(Me.Quack)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quack As System.Windows.Forms.Button
    Friend WithEvents Fly As System.Windows.Forms.Button
    Friend WithEvents Swim As System.Windows.Forms.Button
    Friend WithEvents lstDuckCollection As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectedDuck As System.Windows.Forms.Label
    Friend WithEvents ChangeToComposition As System.Windows.Forms.Button
    Friend WithEvents ChangeToInheritance As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
