Public Class FormCal
   

    Private Sub OpenCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCalculatorToolStripMenuItem.Click
        Calculator.MdiParent = Me
        Calculator.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
