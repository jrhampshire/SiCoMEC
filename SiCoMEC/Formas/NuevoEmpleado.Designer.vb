﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_Area = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Puesto = New System.Windows.Forms.ComboBox()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.Button_Aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(62, 6)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(434, 20)
        Me.TextBox_Nombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Puesto"
        '
        'ComboBox_Area
        '
        Me.ComboBox_Area.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Area.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Area.FormattingEnabled = True
        Me.ComboBox_Area.Location = New System.Drawing.Point(62, 32)
        Me.ComboBox_Area.Name = "ComboBox_Area"
        Me.ComboBox_Area.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox_Area.TabIndex = 1
        '
        'ComboBox_Puesto
        '
        Me.ComboBox_Puesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Puesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Puesto.FormattingEnabled = True
        Me.ComboBox_Puesto.Location = New System.Drawing.Point(307, 32)
        Me.ComboBox_Puesto.Name = "ComboBox_Puesto"
        Me.ComboBox_Puesto.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox_Puesto.TabIndex = 2
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.Location = New System.Drawing.Point(420, 60)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancelar.TabIndex = 4
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_Aceptar
        '
        Me.Button_Aceptar.Location = New System.Drawing.Point(339, 60)
        Me.Button_Aceptar.Name = "Button_Aceptar"
        Me.Button_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Aceptar.TabIndex = 3
        Me.Button_Aceptar.Text = "Aceptar"
        Me.Button_Aceptar.UseVisualStyleBackColor = True
        '
        'NuevoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 91)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Aceptar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.Controls.Add(Me.ComboBox_Puesto)
        Me.Controls.Add(Me.ComboBox_Area)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevoEmpleado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Area As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Puesto As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Button_Aceptar As System.Windows.Forms.Button
End Class
