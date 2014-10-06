<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menuprincipal = New System.Windows.Forms.MenuStrip()
        Me.mnulogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.InicioSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEntrada = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ControlProductoTerminadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuhelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.bar_planta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bar_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Menuprincipal.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menuprincipal
        '
        Me.Menuprincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnulogin, Me.mnuEntrada, Me.mnuConsulta, Me.mnuhelp})
        Me.Menuprincipal.Location = New System.Drawing.Point(0, 0)
        Me.Menuprincipal.Name = "Menuprincipal"
        Me.Menuprincipal.Size = New System.Drawing.Size(632, 24)
        Me.Menuprincipal.TabIndex = 5
        Me.Menuprincipal.Text = "MenuStrip"
        '
        'mnulogin
        '
        Me.mnulogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.InicioSesiónToolStripMenuItem, Me.ToolStripMenuItem4})
        Me.mnulogin.Name = "mnulogin"
        Me.mnulogin.Size = New System.Drawing.Size(49, 20)
        Me.mnulogin.Text = "Login"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(137, 6)
        '
        'InicioSesiónToolStripMenuItem
        '
        Me.InicioSesiónToolStripMenuItem.Name = "InicioSesiónToolStripMenuItem"
        Me.InicioSesiónToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.InicioSesiónToolStripMenuItem.Text = "Inicio Sesión"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(137, 6)
        '
        'mnuEntrada
        '
        Me.mnuEntrada.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ControlProductoTerminadoToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.mnuEntrada.Name = "mnuEntrada"
        Me.mnuEntrada.Size = New System.Drawing.Size(108, 20)
        Me.mnuEntrada.Text = "&Entrada de Datos"
        Me.mnuEntrada.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(224, 6)
        '
        'ControlProductoTerminadoToolStripMenuItem
        '
        Me.ControlProductoTerminadoToolStripMenuItem.Name = "ControlProductoTerminadoToolStripMenuItem"
        Me.ControlProductoTerminadoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ControlProductoTerminadoToolStripMenuItem.Text = "&Control Producto Terminado"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 6)
        '
        'mnuConsulta
        '
        Me.mnuConsulta.Name = "mnuConsulta"
        Me.mnuConsulta.Size = New System.Drawing.Size(71, 20)
        Me.mnuConsulta.Text = "&Consultas"
        Me.mnuConsulta.Visible = False
        '
        'mnuhelp
        '
        Me.mnuhelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.mnuhelp.Name = "mnuhelp"
        Me.mnuhelp.Size = New System.Drawing.Size(53, 20)
        Me.mnuhelp.Text = "Ay&uda"
        Me.mnuhelp.Visible = False
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bar_planta, Me.bar_usuario, Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'bar_planta
        '
        Me.bar_planta.Name = "bar_planta"
        Me.bar_planta.Size = New System.Drawing.Size(0, 17)
        '
        'bar_usuario
        '
        Me.bar_usuario.Name = "bar_usuario"
        Me.bar_usuario.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(617, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.Menuprincipal)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menuprincipal
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo: Control de Calidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menuprincipal.ResumeLayout(False)
        Me.Menuprincipal.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents bar_planta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Menuprincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuhelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bar_usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuEntrada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ControlProductoTerminadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuConsulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnulogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InicioSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator

End Class
