<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.screen = New System.Windows.Forms.TextBox()
        Me.Btn_addpoint = New System.Windows.Forms.Button()
        Me.Btn_num0 = New System.Windows.Forms.Button()
        Me.Btn_adds = New System.Windows.Forms.Button()
        Me.Btn_num3 = New System.Windows.Forms.Button()
        Me.Btn_num2 = New System.Windows.Forms.Button()
        Me.Btn_num1 = New System.Windows.Forms.Button()
        Me.Btn_subtracts = New System.Windows.Forms.Button()
        Me.Btn_sumall = New System.Windows.Forms.Button()
        Me.Btn_num4 = New System.Windows.Forms.Button()
        Me.Btn_num5 = New System.Windows.Forms.Button()
        Me.Btn_num6 = New System.Windows.Forms.Button()
        Me.Btn_multiplys = New System.Windows.Forms.Button()
        Me.Btn_exits = New System.Windows.Forms.Button()
        Me.Btn_num9 = New System.Windows.Forms.Button()
        Me.Btn_num8 = New System.Windows.Forms.Button()
        Me.Btn_num7 = New System.Windows.Forms.Button()
        Me.Btn_divides = New System.Windows.Forms.Button()
        Me.Btn_clearall = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'screen
        '
        Me.screen.Location = New System.Drawing.Point(12, 17)
        Me.screen.Multiline = True
        Me.screen.Name = "screen"
        Me.screen.Size = New System.Drawing.Size(238, 59)
        Me.screen.TabIndex = 37
        '
        'Btn_addpoint
        '
        Me.Btn_addpoint.Location = New System.Drawing.Point(108, 190)
        Me.Btn_addpoint.Name = "Btn_addpoint"
        Me.Btn_addpoint.Size = New System.Drawing.Size(46, 30)
        Me.Btn_addpoint.TabIndex = 36
        Me.Btn_addpoint.Text = "."
        Me.Btn_addpoint.UseVisualStyleBackColor = True
        '
        'Btn_num0
        '
        Me.Btn_num0.Location = New System.Drawing.Point(12, 190)
        Me.Btn_num0.Name = "Btn_num0"
        Me.Btn_num0.Size = New System.Drawing.Size(90, 30)
        Me.Btn_num0.TabIndex = 35
        Me.Btn_num0.Text = "0"
        Me.Btn_num0.UseVisualStyleBackColor = True
        '
        'Btn_adds
        '
        Me.Btn_adds.Location = New System.Drawing.Point(156, 190)
        Me.Btn_adds.Name = "Btn_adds"
        Me.Btn_adds.Size = New System.Drawing.Size(46, 30)
        Me.Btn_adds.TabIndex = 34
        Me.Btn_adds.Text = "+"
        Me.Btn_adds.UseVisualStyleBackColor = True
        '
        'Btn_num3
        '
        Me.Btn_num3.Location = New System.Drawing.Point(108, 154)
        Me.Btn_num3.Name = "Btn_num3"
        Me.Btn_num3.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num3.TabIndex = 33
        Me.Btn_num3.Text = "3"
        Me.Btn_num3.UseVisualStyleBackColor = True
        '
        'Btn_num2
        '
        Me.Btn_num2.Location = New System.Drawing.Point(60, 154)
        Me.Btn_num2.Name = "Btn_num2"
        Me.Btn_num2.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num2.TabIndex = 32
        Me.Btn_num2.Text = "2"
        Me.Btn_num2.UseVisualStyleBackColor = True
        '
        'Btn_num1
        '
        Me.Btn_num1.Location = New System.Drawing.Point(12, 154)
        Me.Btn_num1.Name = "Btn_num1"
        Me.Btn_num1.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num1.TabIndex = 31
        Me.Btn_num1.Text = "1"
        Me.Btn_num1.UseVisualStyleBackColor = True
        '
        'Btn_subtracts
        '
        Me.Btn_subtracts.Location = New System.Drawing.Point(156, 154)
        Me.Btn_subtracts.Name = "Btn_subtracts"
        Me.Btn_subtracts.Size = New System.Drawing.Size(46, 30)
        Me.Btn_subtracts.TabIndex = 30
        Me.Btn_subtracts.Text = "-"
        Me.Btn_subtracts.UseVisualStyleBackColor = True
        '
        'Btn_sumall
        '
        Me.Btn_sumall.Location = New System.Drawing.Point(204, 154)
        Me.Btn_sumall.Name = "Btn_sumall"
        Me.Btn_sumall.Size = New System.Drawing.Size(46, 66)
        Me.Btn_sumall.TabIndex = 29
        Me.Btn_sumall.Text = "="
        Me.Btn_sumall.UseVisualStyleBackColor = True
        '
        'Btn_num4
        '
        Me.Btn_num4.Location = New System.Drawing.Point(12, 118)
        Me.Btn_num4.Name = "Btn_num4"
        Me.Btn_num4.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num4.TabIndex = 28
        Me.Btn_num4.Text = "4"
        Me.Btn_num4.UseVisualStyleBackColor = True
        '
        'Btn_num5
        '
        Me.Btn_num5.Location = New System.Drawing.Point(60, 118)
        Me.Btn_num5.Name = "Btn_num5"
        Me.Btn_num5.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num5.TabIndex = 27
        Me.Btn_num5.Text = "5"
        Me.Btn_num5.UseVisualStyleBackColor = True
        '
        'Btn_num6
        '
        Me.Btn_num6.Location = New System.Drawing.Point(108, 118)
        Me.Btn_num6.Name = "Btn_num6"
        Me.Btn_num6.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num6.TabIndex = 26
        Me.Btn_num6.Text = "6"
        Me.Btn_num6.UseVisualStyleBackColor = True
        '
        'Btn_multiplys
        '
        Me.Btn_multiplys.Location = New System.Drawing.Point(156, 118)
        Me.Btn_multiplys.Name = "Btn_multiplys"
        Me.Btn_multiplys.Size = New System.Drawing.Size(46, 30)
        Me.Btn_multiplys.TabIndex = 25
        Me.Btn_multiplys.Text = "x"
        Me.Btn_multiplys.UseVisualStyleBackColor = True
        '
        'Btn_exits
        '
        Me.Btn_exits.Location = New System.Drawing.Point(204, 118)
        Me.Btn_exits.Name = "Btn_exits"
        Me.Btn_exits.Size = New System.Drawing.Size(46, 30)
        Me.Btn_exits.TabIndex = 24
        Me.Btn_exits.Text = "Ex"
        Me.Btn_exits.UseVisualStyleBackColor = True
        '
        'Btn_num9
        '
        Me.Btn_num9.Location = New System.Drawing.Point(108, 82)
        Me.Btn_num9.Name = "Btn_num9"
        Me.Btn_num9.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num9.TabIndex = 23
        Me.Btn_num9.Text = "9"
        Me.Btn_num9.UseVisualStyleBackColor = True
        '
        'Btn_num8
        '
        Me.Btn_num8.Location = New System.Drawing.Point(60, 82)
        Me.Btn_num8.Name = "Btn_num8"
        Me.Btn_num8.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num8.TabIndex = 22
        Me.Btn_num8.Text = "8"
        Me.Btn_num8.UseVisualStyleBackColor = True
        '
        'Btn_num7
        '
        Me.Btn_num7.Location = New System.Drawing.Point(12, 82)
        Me.Btn_num7.Name = "Btn_num7"
        Me.Btn_num7.Size = New System.Drawing.Size(46, 30)
        Me.Btn_num7.TabIndex = 21
        Me.Btn_num7.Text = "7"
        Me.Btn_num7.UseVisualStyleBackColor = True
        '
        'Btn_divides
        '
        Me.Btn_divides.Location = New System.Drawing.Point(156, 82)
        Me.Btn_divides.Name = "Btn_divides"
        Me.Btn_divides.Size = New System.Drawing.Size(46, 30)
        Me.Btn_divides.TabIndex = 20
        Me.Btn_divides.Text = "/"
        Me.Btn_divides.UseVisualStyleBackColor = True
        '
        'Btn_clearall
        '
        Me.Btn_clearall.Location = New System.Drawing.Point(204, 82)
        Me.Btn_clearall.Name = "Btn_clearall"
        Me.Btn_clearall.Size = New System.Drawing.Size(46, 30)
        Me.Btn_clearall.TabIndex = 19
        Me.Btn_clearall.Text = "CE"
        Me.Btn_clearall.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 226)
        Me.Controls.Add(Me.screen)
        Me.Controls.Add(Me.Btn_addpoint)
        Me.Controls.Add(Me.Btn_num0)
        Me.Controls.Add(Me.Btn_adds)
        Me.Controls.Add(Me.Btn_num3)
        Me.Controls.Add(Me.Btn_num2)
        Me.Controls.Add(Me.Btn_num1)
        Me.Controls.Add(Me.Btn_subtracts)
        Me.Controls.Add(Me.Btn_sumall)
        Me.Controls.Add(Me.Btn_num4)
        Me.Controls.Add(Me.Btn_num5)
        Me.Controls.Add(Me.Btn_num6)
        Me.Controls.Add(Me.Btn_multiplys)
        Me.Controls.Add(Me.Btn_exits)
        Me.Controls.Add(Me.Btn_num9)
        Me.Controls.Add(Me.Btn_num8)
        Me.Controls.Add(Me.Btn_num7)
        Me.Controls.Add(Me.Btn_divides)
        Me.Controls.Add(Me.Btn_clearall)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents screen As System.Windows.Forms.TextBox
    Friend WithEvents Btn_addpoint As System.Windows.Forms.Button
    Friend WithEvents Btn_num0 As System.Windows.Forms.Button
    Friend WithEvents Btn_adds As System.Windows.Forms.Button
    Friend WithEvents Btn_num3 As System.Windows.Forms.Button
    Friend WithEvents Btn_num2 As System.Windows.Forms.Button
    Friend WithEvents Btn_num1 As System.Windows.Forms.Button
    Friend WithEvents Btn_subtracts As System.Windows.Forms.Button
    Friend WithEvents Btn_sumall As System.Windows.Forms.Button
    Friend WithEvents Btn_num4 As System.Windows.Forms.Button
    Friend WithEvents Btn_num5 As System.Windows.Forms.Button
    Friend WithEvents Btn_num6 As System.Windows.Forms.Button
    Friend WithEvents Btn_multiplys As System.Windows.Forms.Button
    Friend WithEvents Btn_exits As System.Windows.Forms.Button
    Friend WithEvents Btn_num9 As System.Windows.Forms.Button
    Friend WithEvents Btn_num8 As System.Windows.Forms.Button
    Friend WithEvents Btn_num7 As System.Windows.Forms.Button
    Friend WithEvents Btn_divides As System.Windows.Forms.Button
    Friend WithEvents Btn_clearall As System.Windows.Forms.Button
End Class
