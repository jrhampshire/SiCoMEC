Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Edita_Equipo
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim Equipo As New Class_Equipo
    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        If Trim(Me.TextBox_Descripcion.Text) = "" Then
            MessageBox.Show("Este dato es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox_Descripcion.Focus()
            Exit Sub
        End If
        If Trim(Me.TextBox_InvInterno.Text) = "" Then
            MessageBox.Show("Este dato es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox_InvInterno.Focus()
            Exit Sub
        End If

        With Equipo
            .Descripcion = Trim(Me.TextBox_Descripcion.Text)
            .NumeroInvInterno = Trim(Me.TextBox_InvInterno.Text)
            .NumeroInvExterno = Trim(Me.TextBox_InvExterno.Text)
            .Marca = Trim(Me.TextBox_Marca.Text)
            .Modelo = Trim(TextBox_Modelo.Text)
            .Color = Trim(TextBox_Color.Text)
            .SerieEquipo = Trim(TextBox_SerieEquipo.Text)
            .SeriePila = Trim(TextBox_SeriePila.Text)
            .SerieCargador = Trim(TextBox_SerieCargador.Text)
            .Procesador = Trim(TextBox_Procesador.Text)
            .DiscoDuro = Trim(TextBox_HD.Text)
            .MemoriaRam = ComboBox_Ram.Text
            If Me.CheckBox1.Checked = True Then
                .UnidadOptica = "Si"
            Else
                .UnidadOptica = "No"
            End If
            If Me.RadioButton_Excelente.Checked = True Then
                .Condicion = "Excelente"
            ElseIf Me.RadioButton_Bueno.Checked = True Then
                .Condicion = "Bueno"
            ElseIf Me.RadioButton_Regular.Checked = True Then
                .Condicion = "Regular"
            ElseIf Me.RadioButton_Malo.Checked = True Then
                .Condicion = "Malo"
            End If
            .Observaciones = Trim(Me.TextBox_Observaciones.Text)
            SQL_Str = "Modifica_Equipos"
            Try
                Cx.Open()

                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo_Temp)
                Cmd.Parameters.AddWithValue("@Descripcion", .Descripcion)
                Cmd.Parameters.AddWithValue("@InventarioInt", .NumeroInvInterno)
                Cmd.Parameters.AddWithValue("@InventarioExt", .NumeroInvExterno)
                Cmd.Parameters.AddWithValue("@Marca", .Marca)
                Cmd.Parameters.AddWithValue("@Modelo", .Modelo)
                Cmd.Parameters.AddWithValue("@Color", .Color)
                Cmd.Parameters.AddWithValue("@SerieEquipo", .SerieEquipo)
                Cmd.Parameters.AddWithValue("@SeriePila", .SeriePila)
                Cmd.Parameters.AddWithValue("@SerieCargador", .SerieCargador)
                Cmd.Parameters.AddWithValue("@Procesador", .Procesador)
                Cmd.Parameters.AddWithValue("@HD", .DiscoDuro)
                Cmd.Parameters.AddWithValue("@Ram", .MemoriaRam)
                Cmd.Parameters.AddWithValue("@Condiciones", .Condicion)
                Cmd.Parameters.AddWithValue("@Observaciones", .Observaciones)
                Cmd.Parameters.AddWithValue("@UnidadOptica", .UnidadOptica)
                Cmd.ExecuteNonQuery()
                Me.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                If Cx.State = ConnectionState.Open Then
                    Cx.Close()
                End If
            End Try
        End With
    End Sub

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Me.Close()
    End Sub

    Sub Carga_Datos()
        SQL_Str = "Select * from Equipos Where id_Equipo = @Id"
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", Id_Equipo_Temp)
            Dim DR As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            With DR
                If .HasRows Then
                    While .Read
                        Me.TextBox_Descripcion.Text = .Item("Descripcion")
                        Me.TextBox_InvInterno.Text = .Item("InventarioInt")
                        Me.TextBox_InvExterno.Text = .Item("InventarioExt")
                        Me.TextBox_Marca.Text = .Item("Marca")
                        Me.TextBox_Modelo.Text = .Item("Modelo")
                        Me.TextBox_Color.Text = .Item("Color")
                        Me.TextBox_SerieEquipo.Text = .Item("SerieEquipo")
                        Me.TextBox_SeriePila.Text = .Item("SeriePila")
                        Me.TextBox_SerieCargador.Text = .Item("SerieCargador")
                        Me.TextBox_Procesador.Text = .Item("Procesador")
                        Me.TextBox_Observaciones.Text = .Item("Observaciones")
                        TextBox_HD.Text = .Item("HD")
                        ComboBox_Ram.Text = .Item("Ram")
                        If .Item("UnidadOptica") = "Si" Then
                            Me.CheckBox1.Checked = True
                        Else
                            Me.CheckBox1.Checked = False
                        End If
                        If .Item("Condiciones") = "Excelente" Then
                            Me.RadioButton_Excelente.Checked = True
                        ElseIf .Item("Condiciones") = "Bueno" Then
                            Me.RadioButton_Bueno.Checked = True
                        ElseIf .Item("Condiciones") = "Regular" Then
                            Me.RadioButton_Regular.Checked = True
                        ElseIf .Item("Condiciones") = "Malo" Then
                            Me.RadioButton_Malo.Checked = True
                        End If
                    End While
                End If
            End With

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub

    Private Sub Edita_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub
End Class