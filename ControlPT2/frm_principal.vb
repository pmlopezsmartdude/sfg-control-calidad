Imports System.Windows.Forms

Public Class frm_principal

    Private Sub frm_principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ' System.Windows.Forms.Application.Exit()
        ' ClearMemory()

    End Sub

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Login.MdiParent = Me
        Login.ShowDialog()

    End Sub

    Private Sub ControlProductoTerminadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlProductoTerminadoToolStripMenuItem.Click
        frm_controlpt.MdiParent = Me
        frm_controlpt.WindowState = FormWindowState.Maximized
        frm_controlpt.Show()
    End Sub


    Private Sub InicioSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioSesiónToolStripMenuItem.Click
        Login.ShowDialog()

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
