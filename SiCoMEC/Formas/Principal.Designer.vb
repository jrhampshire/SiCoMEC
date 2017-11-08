<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArcchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionDeEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDelPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportarUnErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArcchivoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArcchivoToolStripMenuItem
        '
        Me.ArcchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignacionDeEquiposToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.ToolStripMenuItem4, Me.SalirToolStripMenuItem})
        Me.ArcchivoToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Folder_with_Contents
        Me.ArcchivoToolStripMenuItem.Name = "ArcchivoToolStripMenuItem"
        Me.ArcchivoToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ArcchivoToolStripMenuItem.Text = "Archivo"
        '
        'AsignacionDeEquiposToolStripMenuItem
        '
        Me.AsignacionDeEquiposToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Monitor
        Me.AsignacionDeEquiposToolStripMenuItem.Name = "AsignacionDeEquiposToolStripMenuItem"
        Me.AsignacionDeEquiposToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AsignacionDeEquiposToolStripMenuItem.Text = "Asignacion de Equipos"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Tools
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(191, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Log_Out_32x32
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoDelPeriodoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Presentation_32x32
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MantenimientoDelPeriodoToolStripMenuItem
        '
        Me.MantenimientoDelPeriodoToolStripMenuItem.Name = "MantenimientoDelPeriodoToolStripMenuItem"
        Me.MantenimientoDelPeriodoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MantenimientoDelPeriodoToolStripMenuItem.Text = "Mantenimientos"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Settings_32x32
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EquiposToolStripMenuItem, Me.SoftwareToolStripMenuItem, Me.TiposDeSolicitudToolStripMenuItem, Me.ToolStripMenuItem1, Me.EmpleadosToolStripMenuItem, Me.PuestosToolStripMenuItem, Me.AreasToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CatalogosToolStripMenuItem.Text = "Catalogos"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Monitor
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SoftwareToolStripMenuItem.Text = "Software"
        '
        'TiposDeSolicitudToolStripMenuItem
        '
        Me.TiposDeSolicitudToolStripMenuItem.Name = "TiposDeSolicitudToolStripMenuItem"
        Me.TiposDeSolicitudToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TiposDeSolicitudToolStripMenuItem.Text = "Tipos de solicitud"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 6)
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Users
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'PuestosToolStripMenuItem
        '
        Me.PuestosToolStripMenuItem.Name = "PuestosToolStripMenuItem"
        Me.PuestosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PuestosToolStripMenuItem.Text = "Puestos"
        '
        'AreasToolStripMenuItem
        '
        Me.AreasToolStripMenuItem.Name = "AreasToolStripMenuItem"
        Me.AreasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AreasToolStripMenuItem.Text = "Areas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem, Me.ToolStripMenuItem2, Me.ReportarUnErrorToolStripMenuItem, Me.ToolStripMenuItem3, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Help_32x32
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Information_32x32
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 6)
        '
        'ReportarUnErrorToolStripMenuItem
        '
        Me.ReportarUnErrorToolStripMenuItem.Image = Global.SiCoMEC.My.Resources.Resources.Mail_32x32
        Me.ReportarUnErrorToolStripMenuItem.Name = "ReportarUnErrorToolStripMenuItem"
        Me.ReportarUnErrorToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ReportarUnErrorToolStripMenuItem.Text = "Reportar un error"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(170, 6)
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 654)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Control de Mantenimiento de Equipos de Computo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArcchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeSolicitudToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportarUnErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDelPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignacionDeEquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
