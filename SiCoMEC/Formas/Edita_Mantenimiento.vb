Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Edita_Mantenimiento
#Region "Variables"
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim Id_Persona As Integer = 0
    Dim Id_Equipo As Integer = 0
#End Region
   

   

    Private Sub Edita_Mantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Personas()
        Carga_Num_Inventario()
        Carga_Tipos_Solicitud()
        Carga_Personas_Sistemas()
        Carga_Datos_Mtto()
    End Sub

#Region "Carga Informacion"
    Sub Carga_Datos_Mtto()
        Dim m As New Class_Mantenimiento
        Dim Id_Tipos_Solicitud, Solicito, Tecnico, IDEquipo_Temp As Integer
        Dim Falla As String = Nothing, Diagnostico As String = Nothing
        Dim Fecha_Sol, Fecha_Ent As Date

        Using Cx
            Try
                Cx.Open()
                SQL_Str = "Select * from Mantenimientos where id_Mantenimiento = @ID" & _
                " Select * from Personas Where Id_Persona = (Select Solicito from Mantenimientos where id_Mantenimiento = @ID);" & _
                " Select * from Personas Where Id_Persona = (Select Tecnico from Mantenimientos where id_Mantenimiento = @ID);" & _
                " Select * from Tipos_Solicitud Where Id_Tipos_Solicitud =  (Select Id_Tipos_Solicitud from Mantenimientos where id_Mantenimiento = @ID);" & _
                " Select * from Equipos Where Id_Equipo = (Select Id_Equipo from Mantenimientos where id_Mantenimiento = @ID)"
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@ID", Id_Mantenimiento_Temp)
                Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
                With Reader
                    If .HasRows Then
                        While .Read
                            Id_Tipos_Solicitud = .Item("Id_Tipos_Solicitud")
                            Solicito = .Item("Solicito")
                            Tecnico = .Item("Tecnico")
                            IDEquipo_Temp = .Item("Id_Equipo")
                            Falla = .Item("Descripcion_Falla")
                            Diagnostico = .Item("Diagnostico")
                            Fecha_Sol = .Item("Fecha_Solicitud")
                            Fecha_Ent = .Item("Fecha_Entrega")
                        End While
                        Me.ComboBox_Nombre.SelectedValue = Solicito
                        Me.ComboBox_PersonalAsignado.SelectedValue = Tecnico
                        Me.ComboBox_NumInventario.SelectedValue = IDEquipo_Temp
                        Me.ComboBox_TipoSolicitud.SelectedValue = Id_Tipos_Solicitud
                        Me.DateTimePicker_Fecha_Solicitud.Value = Fecha_Sol
                        If Not IsDBNull(Fecha_Ent) Then
                            Me.CheckBox_Fecha.Checked = True
                            Me.DateTimePicker_Fecha_Entrega.Value = Fecha_Ent
                        End If
                        Me.TextBox_Falla.Text = Falla
                        Me.TextBox_ServicioRealizado.Text = Diagnostico
                    End If
                   

                End With
            Catch ex As Exception

            End Try

        End Using
    End Sub
    Sub Carga_Personas()
        SQL_Str = "Select * from Personas Order by Nombre"
        If Cx.State = ConnectionState.Open Then
            Cx.Close()
        End If
        Cx.Open()
        Try
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With Me.ComboBox_Nombre
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Nombre"
                .ValueMember = "Id_Persona"
            End With
            ComboBox_Nombre.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub
    Sub Carga_Personas_Sistemas()
        SQL_Str = "Select * from Personas Where Id_Persona in(1,2) Order by Nombre"
        Cx.Open()
        Try
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With Me.ComboBox_PersonalAsignado
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Nombre"
                .ValueMember = "Id_Persona"
            End With
            ComboBox_PersonalAsignado.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub
    Private Sub ComboBox_Nombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Nombre.SelectedIndexChanged
        Try
            Id_Persona = Me.ComboBox_Nombre.SelectedValue
            Carga_Generales_Persona()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub Carga_Generales_Persona()
        SQL_Str = "Select A.Area, P.Descripcion, E.Id_Empleado from Area as A, Puestos as P, Empleados as E Where E.Id_Persona = @Id_Persona" & _
            " And E.Id_Puesto = P.Id_Puesto" & _
            " And E.Id_Area = A.Id_Area"
        Try
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id_Persona", Id_Persona)
            Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If Reader.HasRows Then
                While Reader.Read
                    Me.Lbl_Area.Text = Reader.Item(0)
                    Me.Lbl_Puesto.Text = Reader.Item(1)
                    Id_Empleado_Temp = Reader.Item(2)
                End While
            End If
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
    Sub Carga_Tipos_Solicitud()
        SQL_Str = "Select * from Tipos_Solicitud Order by Descripcion"
        Cx.Open()
        Try
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With Me.ComboBox_TipoSolicitud
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Descripcion"
                .ValueMember = "Id_Tipos_Solicitud"
            End With
            ComboBox_TipoSolicitud.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub
    Sub Carga_Num_Inventario()
        SQL_Str = "Select * from Equipos  Where Baja = 'False'"
        Cx.Open()
        Try
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With Me.ComboBox_NumInventario
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "InventarioInt"
                .ValueMember = "Id_Equipo"
            End With
            ComboBox_NumInventario.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub
    Sub Carga_Equipos()
        SQL_Str = "Select * from Equipos Where Id_Equipo = @Inv"
        Try
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Inv", Id_Equipo)
            Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If Reader.HasRows Then
                While Reader.Read
                    Me.Lbl_Marca.Text = Reader.Item("Marca")
                    Me.Lbl_Modelo.Text = Reader.Item("Modelo")
                    Me.Lbl_Color.Text = Reader.Item("Color")
                    Me.Lbl_Serie_Equipo.Text = Reader.Item("SerieEquipo")
                    Me.Lbl_Serie_Pila.Text = Reader.Item("SeriePila")
                    Me.Lbl_Serie_Cargador.Text = Reader.Item("SerieCargador")
                    Me.Lbl_Condiciones.Text = Reader.Item("Condiciones")
                    Me.Lbl_Observaciones.Text = Reader.Item("Observaciones")
                    Id_Empleado_Temp = Reader.Item("Id_Equipo")
                End While
            End If
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
    Private Sub CheckBox_Fecha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Fecha.CheckedChanged
        If Me.CheckBox_Fecha.CheckState = CheckState.Checked Then
            Me.DateTimePicker_Fecha_Entrega.Enabled = True
        Else
            Me.DateTimePicker_Fecha_Entrega.Enabled = False
        End If
    End Sub
    Private Sub ComboBox_NumInventario_SelectedIndexChanged(sender As Object, e As EventArgs)
        Carga_Equipos()
    End Sub
    Private Sub Button_NumInv_Click(sender As Object, e As EventArgs) Handles Button_NumInv.Click
        Dim Frm As New Nuevo_Equipo
        Frm.ShowDialog()
        Carga_Num_Inventario()
    End Sub
    Private Sub Button_Nombre_Click(sender As Object, e As EventArgs) Handles Button_Nombre.Click
        Dim Frm As New NuevoEmpleado
        Frm.ShowDialog()
        Carga_Personas()
    End Sub
    Private Sub ComboBox_NumInventario_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_NumInventario.SelectedIndexChanged
        Try
            Id_Equipo = Me.ComboBox_NumInventario.SelectedValue
            Carga_Equipos()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region
#Region "Botones"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Solicitante As Integer = 0
        Dim Tecnico As Integer = 0
        Dim tipo_Solicitud As Integer = 0
        Dim Falla As String = Nothing
        Dim Servicio As String = Nothing
        Dim Fecha_Solicitud As Date = Me.DateTimePicker_Fecha_Solicitud.Value
        Dim Fecha_Entrega As Date = Nothing

        Try
            Solicitante = Me.ComboBox_Nombre.SelectedValue
        Catch ex As Exception
            MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ComboBox_Nombre.Focus()
            Exit Sub
        End Try
        Try
            Tecnico = Me.ComboBox_PersonalAsignado.SelectedValue
        Catch ex As Exception
            MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ComboBox_PersonalAsignado.Focus()
            Exit Sub
        End Try
        Try
            tipo_Solicitud = Me.ComboBox_TipoSolicitud.SelectedValue
        Catch ex As Exception
            MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ComboBox_TipoSolicitud.Focus()
            Exit Sub
        End Try
        Falla = Trim(Me.TextBox_Falla.Text)
        If Falla = "" Then
            MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox_Falla.Focus()
            Exit Sub
        End If
        Servicio = Trim(Me.TextBox_ServicioRealizado.Text)
        If Me.DateTimePicker_Fecha_Entrega.Enabled = True Then
            Fecha_Entrega = Me.DateTimePicker_Fecha_Entrega.Value
        End If
        Using Cx As New SqlConnection(My.Settings.Cadena)
            SQL_Str = "Update Mantenimientos set Id_Tipos_Solicitud = @Id_Tipo_Solicitud, Solicito = @Solicito, Tecnico = @Tecnico, " & _
                " Id_Equipo = @Id_Equipo, Descripcion_Falla = @Descripcion_Falla, Diagnostico = @Diagnostico, Fecha_Solicitud = @Fecha_Solicitud, Fecha_Entrega = @Fecha_Entrega" & _
                " Where Id_Mantenimiento = @ID"
            Try
                Cx.Open()
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@Id_Tipo_Solicitud", tipo_Solicitud)
                Cmd.Parameters.AddWithValue("@Solicito", Solicitante)
                Cmd.Parameters.AddWithValue("@Tecnico", Tecnico)
                Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Empleado_Temp)
                Cmd.Parameters.AddWithValue("@Descripcion_Falla", Falla)
                Cmd.Parameters.AddWithValue("@Diagnostico", Servicio)
                Cmd.Parameters.AddWithValue("@Fecha_Solicitud", Fecha_Solicitud)
                Cmd.Parameters.AddWithValue("@Fecha_Entrega", Fecha_Entrega)
                Cmd.Parameters.AddWithValue("@ID", Id_Mantenimiento_Temp)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha actualizado el mantenimento", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As SqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Cx.State = ConnectionState.Open Then
                    Cx.Close()
                End If
            End Try
        End Using
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region

    Private Sub ComboBox_Nombre_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Nombre.SelectedValueChanged
        Try
            Id_Persona = Me.ComboBox_Nombre.SelectedValue
            Carga_Generales_Persona()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox_NumInventario_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_NumInventario.SelectedValueChanged
        Try
            Id_Equipo = Me.ComboBox_NumInventario.SelectedValue
            Carga_Equipos()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class