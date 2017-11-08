Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class Nueva_Asignacion_Equipo

#Region "Variables"
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim numInventarioInterno As Integer = 0
    Dim Id_Persona As Integer = 0
    Dim Id_Equipo As Integer = 0
#End Region
    Private Sub Nueva_Asignacion_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Num_Inventario()
        Carga_Personas()
        Carga_Software()
    End Sub
#Region "Carga Datos"
    Sub Carga_Personas()
        SQL_Str = "Select * from Personas Order by Nombre"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub
    Sub Carga_Software()
        SQL_Str = "Select * from Software Order by Descripcion"

        Cx.Open()
        Try
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With Me.ComboBox_Software
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Descripcion"
                .ValueMember = "Id_Software"
            End With
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
        SQL_Str = "Select * from Equipos  Where Baja = 'False'" & _
            " and Id_Equipo not in(Select Id_Equipo from Equipo_x_Empleado)Order by InventarioInt"
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
    Sub Carga_Generales_Persona()
        SQL_Str = "Select A.Area, P.Descripcion, E.Id_Empleado from Area as A, Puestos as P, Empleados as E Where E.Id_Persona = @Id_Persona" & _
            " And E.Id_Puesto = P.Id_Puesto" & _
            " And E.Id_Area = A.Id_Area"
        Try
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
    Private Sub ComboBox_NumInventario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_NumInventario.SelectedIndexChanged
        Try
            Id_Equipo = Me.ComboBox_NumInventario.SelectedValue
            Carga_Equipos()
        Catch ex As Exception
            Exit Sub
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
    Sub Carga_Soft_x_Equipo()
        SQL_Str = "Select * from Software Where id_Software in (Select Id_Software from Software_x_Equipo Where Id_Equipo = @Id_Equipo)"
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo)
            Dim Da As New SqlDataAdapter(Cmd)
            Dim DS As New DataSet
            Da.Fill(DS, "Tabla")
            Me.DataGridView1.DataSource = DS.Tables("Tabla")
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
#End Region
#Region "Agrega y Quita Software de un equipo"
    Private Sub Button_AgregaSoft_Click(sender As Object, e As EventArgs) Handles Button_AgregaSoft.Click
        Dim Id_Software As Integer = 0
        Try
            Id_Software = Me.ComboBox_Software.SelectedValue
            If Id_Software <> 0 Then
                Try
                    Cx.Open()
                    SQL_Str = "Insert into Software_x_Equipo (Id_Equipo,Id_Software) Values(@Id_Equipo,@Id_Software)"
                    Dim Cmd As New SqlCommand(SQL_Str, Cx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@Id_Software", Id_Software)
                    Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo)
                    Cmd.ExecuteNonQuery()
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
                Carga_Soft_x_Equipo()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Button_QuitaSoft_Click(sender As Object, e As EventArgs) Handles Button_QuitaSoft.Click
        Dim Id_Software As Integer = 0
        Dim columna As Integer, fila As Integer
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Id_Software = Me.DataGridView1(columna, fila).Value
        If Id_Software = 0 Then
            MessageBox.Show("Debe seleccionar un software", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
        Else
            Try
                Cx.Open()
                SQL_Str = "Delete Software_x_Equipo Where Id_Equipo = @Id_Equipo AND Id_Software = @Id_Software"
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo)
                Cmd.Parameters.AddWithValue("@Id_Software", Id_Software)
                Cmd.ExecuteNonQuery()

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
            Carga_Soft_x_Equipo()
        End If
    End Sub
#End Region
    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        If Me.DataGridView1.RowCount > 0 Then
            Try
                SQL_Str = "Delete Software_x_Equipo Where Id_Equipo = @Id_Equipo"
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo)
                Cmd.ExecuteNonQuery()
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
                Me.Close()
            End Try
        Else
            Me.Close()
        End If
    End Sub
    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Try
            Cx.Open()
            SQL_Str = "Alta_Equipo_x_Empleado"
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Fecha", Me.DateTimePicker1.Value)
            Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo)
            Cmd.Parameters.AddWithValue("@Id_Empleado", Id_Empleado_Temp)
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
    End Sub
End Class