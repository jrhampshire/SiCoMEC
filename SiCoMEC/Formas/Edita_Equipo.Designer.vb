<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edita_Equipo
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
        Me.Button_Aceptar = New System.Windows.Forms.Button()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.TextBox_Observaciones = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Malo = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Regular = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Bueno = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Excelente = New System.Windows.Forms.RadioButton()
        Me.ComboBox_Ram = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_HD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_Procesador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_SerieCargador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_SeriePila = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_SerieEquipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Modelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_InvExterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Color = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Marca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_InvInterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Aceptar
        '
        Me.Button_Aceptar.Location = New System.Drawing.Point(469, 358)
        Me.Button_Aceptar.Name = "Button_Aceptar"
        Me.Button_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Aceptar.TabIndex = 2
        Me.Button_Aceptar.Text = "Aceptar"
        Me.Button_Aceptar.UseVisualStyleBackColor = True
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.Location = New System.Drawing.Point(550, 358)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancelar.TabIndex = 3
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'TextBox_Observaciones
        '
        Me.TextBox_Observaciones.Location = New System.Drawing.Point(12, 244)
        Me.TextBox_Observaciones.Multiline = True
        Me.TextBox_Observaciones.Name = "TextBox_Observaciones"
        Me.TextBox_Observaciones.Size = New System.Drawing.Size(614, 107)
        Me.TextBox_Observaciones.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Observaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Ram)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox_HD)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox_Procesador)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox_SerieCargador)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox_SeriePila)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox_SerieEquipo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox_Modelo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox_InvExterno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_Color)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_Marca)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_InvInterno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Descripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caracteristicas del Equipo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(125, 173)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Unidad Optica"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_Malo)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Regular)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Bueno)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Excelente)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 49)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condiciones Generales del equipo"
        '
        'RadioButton_Malo
        '
        Me.RadioButton_Malo.AutoSize = True
        Me.RadioButton_Malo.Location = New System.Drawing.Point(215, 20)
        Me.RadioButton_Malo.Name = "RadioButton_Malo"
        Me.RadioButton_Malo.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_Malo.TabIndex = 3
        Me.RadioButton_Malo.Text = "Malo"
        Me.RadioButton_Malo.UseVisualStyleBackColor = True
        '
        'RadioButton_Regular
        '
        Me.RadioButton_Regular.AutoSize = True
        Me.RadioButton_Regular.Location = New System.Drawing.Point(147, 20)
        Me.RadioButton_Regular.Name = "RadioButton_Regular"
        Me.RadioButton_Regular.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton_Regular.TabIndex = 2
        Me.RadioButton_Regular.Text = "Regular"
        Me.RadioButton_Regular.UseVisualStyleBackColor = True
        '
        'RadioButton_Bueno
        '
        Me.RadioButton_Bueno.AutoSize = True
        Me.RadioButton_Bueno.Location = New System.Drawing.Point(85, 20)
        Me.RadioButton_Bueno.Name = "RadioButton_Bueno"
        Me.RadioButton_Bueno.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton_Bueno.TabIndex = 1
        Me.RadioButton_Bueno.Text = "Bueno"
        Me.RadioButton_Bueno.UseVisualStyleBackColor = True
        '
        'RadioButton_Excelente
        '
        Me.RadioButton_Excelente.AutoSize = True
        Me.RadioButton_Excelente.Checked = True
        Me.RadioButton_Excelente.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton_Excelente.Name = "RadioButton_Excelente"
        Me.RadioButton_Excelente.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton_Excelente.TabIndex = 0
        Me.RadioButton_Excelente.TabStop = True
        Me.RadioButton_Excelente.Text = "Excelente"
        Me.RadioButton_Excelente.UseVisualStyleBackColor = True
        '
        'ComboBox_Ram
        '
        Me.ComboBox_Ram.FormattingEnabled = True
        Me.ComboBox_Ram.Items.AddRange(New Object() {"N/A", "1 Gb", "2 Gb", "3 Gb", "4 Gb", "6 Gb", "8 Gb", "12 Gb", "16 Gb"})
        Me.ComboBox_Ram.Location = New System.Drawing.Point(469, 123)
        Me.ComboBox_Ram.Name = "ComboBox_Ram"
        Me.ComboBox_Ram.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox_Ram.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(391, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Memoria Ram"
        '
        'TextBox_HD
        '
        Me.TextBox_HD.Location = New System.Drawing.Point(285, 123)
        Me.TextBox_HD.Name = "TextBox_HD"
        Me.TextBox_HD.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_HD.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Disco Duro"
        '
        'TextBox_Procesador
        '
        Me.TextBox_Procesador.Location = New System.Drawing.Point(73, 123)
        Me.TextBox_Procesador.Name = "TextBox_Procesador"
        Me.TextBox_Procesador.Size = New System.Drawing.Size(123, 20)
        Me.TextBox_Procesador.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Procesador"
        '
        'TextBox_SerieCargador
        '
        Me.TextBox_SerieCargador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_SerieCargador.Location = New System.Drawing.Point(491, 97)
        Me.TextBox_SerieCargador.Name = "TextBox_SerieCargador"
        Me.TextBox_SerieCargador.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SerieCargador.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(391, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Serie del Cargador"
        '
        'TextBox_SeriePila
        '
        Me.TextBox_SeriePila.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_SeriePila.Location = New System.Drawing.Point(285, 97)
        Me.TextBox_SeriePila.Name = "TextBox_SeriePila"
        Me.TextBox_SeriePila.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SeriePila.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Serie de la Pila"
        '
        'TextBox_SerieEquipo
        '
        Me.TextBox_SerieEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_SerieEquipo.Location = New System.Drawing.Point(96, 97)
        Me.TextBox_SerieEquipo.Name = "TextBox_SerieEquipo"
        Me.TextBox_SerieEquipo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SerieEquipo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Serie del Equipo"
        '
        'TextBox_Modelo
        '
        Me.TextBox_Modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_Modelo.Location = New System.Drawing.Point(214, 71)
        Me.TextBox_Modelo.Name = "TextBox_Modelo"
        Me.TextBox_Modelo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Modelo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Modelo"
        '
        'TextBox_InvExterno
        '
        Me.TextBox_InvExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_InvExterno.Location = New System.Drawing.Point(417, 45)
        Me.TextBox_InvExterno.Name = "TextBox_InvExterno"
        Me.TextBox_InvExterno.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_InvExterno.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Numero de Inventario Externo"
        '
        'TextBox_Color
        '
        Me.TextBox_Color.Location = New System.Drawing.Point(366, 71)
        Me.TextBox_Color.Name = "TextBox_Color"
        Me.TextBox_Color.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Color.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Color"
        '
        'TextBox_Marca
        '
        Me.TextBox_Marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_Marca.Location = New System.Drawing.Point(49, 71)
        Me.TextBox_Marca.Name = "TextBox_Marca"
        Me.TextBox_Marca.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Marca.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Marca"
        '
        'TextBox_InvInterno
        '
        Me.TextBox_InvInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_InvInterno.Location = New System.Drawing.Point(157, 45)
        Me.TextBox_InvInterno.Name = "TextBox_InvInterno"
        Me.TextBox_InvInterno.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_InvInterno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero de Inventario Interno"
        '
        'TextBox_Descripcion
        '
        Me.TextBox_Descripcion.Location = New System.Drawing.Point(73, 19)
        Me.TextBox_Descripcion.Name = "TextBox_Descripcion"
        Me.TextBox_Descripcion.Size = New System.Drawing.Size(523, 20)
        Me.TextBox_Descripcion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Edita_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Aceptar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.Controls.Add(Me.TextBox_Observaciones)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Edita_Equipo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edita Equipo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Button_Cancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Malo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Regular As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Bueno As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Excelente As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox_Ram As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_HD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Procesador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SerieCargador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SeriePila As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SerieEquipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_InvExterno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Color As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Marca As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_InvInterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
