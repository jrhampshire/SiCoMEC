<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_AsignacionEquipos
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.Button_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.Button_Excel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button_Salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button_Agregar, Me.Button_Cancelar, Me.ToolStripSeparator1, Me.Button_Imprimir, Me.Button_Excel, Me.ToolStripSeparator2, Me.Button_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button_Agregar
        '
        Me.Button_Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Agregar.Image = Global.SiCoMEC.My.Resources.Resources.Add_32x32
        Me.Button_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(23, 22)
        Me.Button_Agregar.Text = "Agregar"
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Cancelar.Image = Global.SiCoMEC.My.Resources.Resources.Cancel_32x32
        Me.Button_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(23, 22)
        Me.Button_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Button_Imprimir
        '
        Me.Button_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Imprimir.Image = Global.SiCoMEC.My.Resources.Resources.Print_32x32
        Me.Button_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Imprimir.Name = "Button_Imprimir"
        Me.Button_Imprimir.Size = New System.Drawing.Size(23, 22)
        Me.Button_Imprimir.Text = "Imprimir"
        '
        'Button_Excel
        '
        Me.Button_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Excel.Image = Global.SiCoMEC.My.Resources.Resources.Excel_32_x_32
        Me.Button_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Excel.Name = "Button_Excel"
        Me.Button_Excel.Size = New System.Drawing.Size(23, 22)
        Me.Button_Excel.Text = "Exportar a Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Button_Salir
        '
        Me.Button_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Salir.Image = Global.SiCoMEC.My.Resources.Resources.Log_Out_32x32
        Me.Button_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(23, 22)
        Me.Button_Salir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 557)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servicios"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(863, 538)
        Me.DataGridView1.TabIndex = 0
        '
        'Listado_AsignacionEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Listado_AsignacionEquipos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Asignacion de Equipos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Button_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button_Excel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
