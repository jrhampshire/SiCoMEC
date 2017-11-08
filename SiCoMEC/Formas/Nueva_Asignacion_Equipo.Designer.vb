<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Asignacion_Equipo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Nombre = New System.Windows.Forms.Button()
        Me.Lbl_Puesto = New System.Windows.Forms.Label()
        Me.Lbl_Area = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Nombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Observaciones = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_Condiciones = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Lbl_Serie_Cargador = New System.Windows.Forms.Label()
        Me.Lbl_Color = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Lbl_Serie_Pila = New System.Windows.Forms.Label()
        Me.Lbl_Modelo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button_NumInv = New System.Windows.Forms.Button()
        Me.Lbl_Serie_Equipo = New System.Windows.Forms.Label()
        Me.Lbl_Marca = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_NumInventario = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_QuitaSoft = New System.Windows.Forms.Button()
        Me.Button_AgregaSoft = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox_Software = New System.Windows.Forms.ComboBox()
        Me.Button_NuevoSoft = New System.Windows.Forms.Button()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.Button_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Nombre)
        Me.GroupBox1.Controls.Add(Me.Lbl_Puesto)
        Me.GroupBox1.Controls.Add(Me.Lbl_Area)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Button_Nombre
        '
        Me.Button_Nombre.Location = New System.Drawing.Point(398, 15)
        Me.Button_Nombre.Name = "Button_Nombre"
        Me.Button_Nombre.Size = New System.Drawing.Size(29, 23)
        Me.Button_Nombre.TabIndex = 1
        Me.Button_Nombre.Text = "..."
        Me.Button_Nombre.UseVisualStyleBackColor = True
        '
        'Lbl_Puesto
        '
        Me.Lbl_Puesto.BackColor = System.Drawing.Color.White
        Me.Lbl_Puesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Puesto.Location = New System.Drawing.Point(313, 47)
        Me.Lbl_Puesto.Name = "Lbl_Puesto"
        Me.Lbl_Puesto.Size = New System.Drawing.Size(342, 21)
        Me.Lbl_Puesto.TabIndex = 4
        Me.Lbl_Puesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Area
        '
        Me.Lbl_Area.BackColor = System.Drawing.Color.White
        Me.Lbl_Area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Area.Location = New System.Drawing.Point(42, 47)
        Me.Lbl_Area.Name = "Lbl_Area"
        Me.Lbl_Area.Size = New System.Drawing.Size(200, 21)
        Me.Lbl_Area.TabIndex = 3
        Me.Lbl_Area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Puesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Área"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(560, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(514, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'ComboBox_Nombre
        '
        Me.ComboBox_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Nombre.FormattingEnabled = True
        Me.ComboBox_Nombre.Location = New System.Drawing.Point(57, 17)
        Me.ComboBox_Nombre.Name = "ComboBox_Nombre"
        Me.ComboBox_Nombre.Size = New System.Drawing.Size(335, 21)
        Me.ComboBox_Nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_Observaciones)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Lbl_Condiciones)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Lbl_Serie_Cargador)
        Me.GroupBox2.Controls.Add(Me.Lbl_Color)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Lbl_Serie_Pila)
        Me.GroupBox2.Controls.Add(Me.Lbl_Modelo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Button_NumInv)
        Me.GroupBox2.Controls.Add(Me.Lbl_Serie_Equipo)
        Me.GroupBox2.Controls.Add(Me.Lbl_Marca)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBox_NumInventario)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 275)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripcion del equipo"
        '
        'Lbl_Observaciones
        '
        Me.Lbl_Observaciones.BackColor = System.Drawing.Color.White
        Me.Lbl_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Observaciones.Location = New System.Drawing.Point(10, 167)
        Me.Lbl_Observaciones.Name = "Lbl_Observaciones"
        Me.Lbl_Observaciones.Size = New System.Drawing.Size(646, 90)
        Me.Lbl_Observaciones.TabIndex = 27
        Me.Lbl_Observaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Observaciones"
        '
        'Lbl_Condiciones
        '
        Me.Lbl_Condiciones.BackColor = System.Drawing.Color.White
        Me.Lbl_Condiciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Condiciones.Location = New System.Drawing.Point(500, 121)
        Me.Lbl_Condiciones.Name = "Lbl_Condiciones"
        Me.Lbl_Condiciones.Size = New System.Drawing.Size(155, 21)
        Me.Lbl_Condiciones.TabIndex = 7
        Me.Lbl_Condiciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(348, 124)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Condiciones del equipo"
        '
        'Lbl_Serie_Cargador
        '
        Me.Lbl_Serie_Cargador.BackColor = System.Drawing.Color.White
        Me.Lbl_Serie_Cargador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Serie_Cargador.Location = New System.Drawing.Point(500, 88)
        Me.Lbl_Serie_Cargador.Name = "Lbl_Serie_Cargador"
        Me.Lbl_Serie_Cargador.Size = New System.Drawing.Size(155, 21)
        Me.Lbl_Serie_Cargador.TabIndex = 5
        Me.Lbl_Serie_Cargador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Color
        '
        Me.Lbl_Color.BackColor = System.Drawing.Color.White
        Me.Lbl_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Color.Location = New System.Drawing.Point(57, 119)
        Me.Lbl_Color.Name = "Lbl_Color"
        Me.Lbl_Color.Size = New System.Drawing.Size(187, 21)
        Me.Lbl_Color.TabIndex = 6
        Me.Lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(348, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Número de serie del cargador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Color"
        '
        'Lbl_Serie_Pila
        '
        Me.Lbl_Serie_Pila.BackColor = System.Drawing.Color.White
        Me.Lbl_Serie_Pila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Serie_Pila.Location = New System.Drawing.Point(500, 55)
        Me.Lbl_Serie_Pila.Name = "Lbl_Serie_Pila"
        Me.Lbl_Serie_Pila.Size = New System.Drawing.Size(155, 21)
        Me.Lbl_Serie_Pila.TabIndex = 3
        Me.Lbl_Serie_Pila.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Modelo
        '
        Me.Lbl_Modelo.BackColor = System.Drawing.Color.White
        Me.Lbl_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Modelo.Location = New System.Drawing.Point(57, 86)
        Me.Lbl_Modelo.Name = "Lbl_Modelo"
        Me.Lbl_Modelo.Size = New System.Drawing.Size(187, 21)
        Me.Lbl_Modelo.TabIndex = 4
        Me.Lbl_Modelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(348, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Número de serie de pila"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Modelo"
        '
        'Button_NumInv
        '
        Me.Button_NumInv.Location = New System.Drawing.Point(313, 23)
        Me.Button_NumInv.Name = "Button_NumInv"
        Me.Button_NumInv.Size = New System.Drawing.Size(29, 23)
        Me.Button_NumInv.TabIndex = 14
        Me.Button_NumInv.Text = "..."
        Me.Button_NumInv.UseVisualStyleBackColor = True
        '
        'Lbl_Serie_Equipo
        '
        Me.Lbl_Serie_Equipo.BackColor = System.Drawing.Color.White
        Me.Lbl_Serie_Equipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Serie_Equipo.Location = New System.Drawing.Point(500, 24)
        Me.Lbl_Serie_Equipo.Name = "Lbl_Serie_Equipo"
        Me.Lbl_Serie_Equipo.Size = New System.Drawing.Size(155, 21)
        Me.Lbl_Serie_Equipo.TabIndex = 1
        Me.Lbl_Serie_Equipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Marca
        '
        Me.Lbl_Marca.BackColor = System.Drawing.Color.White
        Me.Lbl_Marca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Marca.Location = New System.Drawing.Point(57, 55)
        Me.Lbl_Marca.Name = "Lbl_Marca"
        Me.Lbl_Marca.Size = New System.Drawing.Size(187, 21)
        Me.Lbl_Marca.TabIndex = 2
        Me.Lbl_Marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Numero de serie del equipo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Marca"
        '
        'ComboBox_NumInventario
        '
        Me.ComboBox_NumInventario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_NumInventario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_NumInventario.FormattingEnabled = True
        Me.ComboBox_NumInventario.Location = New System.Drawing.Point(122, 24)
        Me.ComboBox_NumInventario.Name = "ComboBox_NumInventario"
        Me.ComboBox_NumInventario.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox_NumInventario.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Numero de Inventario"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_QuitaSoft)
        Me.GroupBox3.Controls.Add(Me.Button_AgregaSoft)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.ComboBox_Software)
        Me.GroupBox3.Controls.Add(Me.Button_NuevoSoft)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(665, 182)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Software"
        '
        'Button_QuitaSoft
        '
        Me.Button_QuitaSoft.Location = New System.Drawing.Point(580, 15)
        Me.Button_QuitaSoft.Name = "Button_QuitaSoft"
        Me.Button_QuitaSoft.Size = New System.Drawing.Size(75, 23)
        Me.Button_QuitaSoft.TabIndex = 2
        Me.Button_QuitaSoft.Text = "Quitar"
        Me.Button_QuitaSoft.UseVisualStyleBackColor = True
        '
        'Button_AgregaSoft
        '
        Me.Button_AgregaSoft.Location = New System.Drawing.Point(498, 15)
        Me.Button_AgregaSoft.Name = "Button_AgregaSoft"
        Me.Button_AgregaSoft.Size = New System.Drawing.Size(75, 23)
        Me.Button_AgregaSoft.TabIndex = 1
        Me.Button_AgregaSoft.Text = "Agregar"
        Me.Button_AgregaSoft.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(649, 132)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Software Instalado"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 113)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBox_Software
        '
        Me.ComboBox_Software.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Software.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Software.FormattingEnabled = True
        Me.ComboBox_Software.Location = New System.Drawing.Point(10, 17)
        Me.ComboBox_Software.Name = "ComboBox_Software"
        Me.ComboBox_Software.Size = New System.Drawing.Size(452, 21)
        Me.ComboBox_Software.TabIndex = 0
        '
        'Button_NuevoSoft
        '
        Me.Button_NuevoSoft.Location = New System.Drawing.Point(468, 15)
        Me.Button_NuevoSoft.Name = "Button_NuevoSoft"
        Me.Button_NuevoSoft.Size = New System.Drawing.Size(24, 23)
        Me.Button_NuevoSoft.TabIndex = 0
        Me.Button_NuevoSoft.Text = "..."
        Me.Button_NuevoSoft.UseVisualStyleBackColor = True
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.Location = New System.Drawing.Point(602, 563)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancelar.TabIndex = 5
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_Aceptar
        '
        Me.Button_Aceptar.Location = New System.Drawing.Point(521, 563)
        Me.Button_Aceptar.Name = "Button_Aceptar"
        Me.Button_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Aceptar.TabIndex = 4
        Me.Button_Aceptar.Text = "Aceptar"
        Me.Button_Aceptar.UseVisualStyleBackColor = True
        '
        'Nueva_Asignacion_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Aceptar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Nueva_Asignacion_Equipo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asiganción de Equipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Nombre As System.Windows.Forms.Button
    Friend WithEvents Lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents Lbl_Area As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Nombre As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Condiciones As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Serie_Cargador As System.Windows.Forms.Label
    Friend WithEvents Lbl_Color As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Serie_Pila As System.Windows.Forms.Label
    Friend WithEvents Lbl_Modelo As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button_NumInv As System.Windows.Forms.Button
    Friend WithEvents Lbl_Serie_Equipo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Marca As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_NumInventario As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_QuitaSoft As System.Windows.Forms.Button
    Friend WithEvents Button_AgregaSoft As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox_Software As System.Windows.Forms.ComboBox
    Friend WithEvents Button_NuevoSoft As System.Windows.Forms.Button
    Friend WithEvents Button_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Button_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
