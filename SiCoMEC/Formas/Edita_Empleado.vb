Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlTransaction
Public Class Edita_Empleado
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim Id_Persona, Id_Area, Id_Puesto As Integer
    Sub Carga_Datos()
        SQL_Str = "Select * from View_Empleados_conId Where id_Empleado = @Id_Empleado"
        Id_Area = 0
        Id_Persona = 0
        Id_Puesto = 0
        Dim Nombre, Area, Puesto As String
        Nombre = Nothing
        Area = Nothing
        Puesto = Nothing
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id_Empleado", Id_Empleado_Temp)
            Dim DR As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            With DR
                If .HasRows Then
                    While .Read
                        Id_Area = .Item("Id_Area")
                        Id_Persona = .Item("Id_Persona")
                        Id_Puesto = .Item("Id_Puesto")
                        Nombre = .Item("Nombre")
                        Area = .Item("Area")
                        Puesto = .Item("Descripcion")
                    End While
                End If
            End With
            Me.TextBox_Nombre.Text = Nombre
            Me.ComboBox_Area.Text = Area
            Me.ComboBox_Puesto.Text = Puesto
            Me.TextBox_Nombre.Focus()
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
    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Me.Close()
    End Sub
    Sub Carga_Areas()
        SQL_Str = "Select * from Area order by Area"
        Try
            Cx.Open()
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With ComboBox_Area
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Area"
                .ValueMember = "Id_Area"
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
    Sub Carga_Puestos()
        SQL_Str = "Select * from Puestos order by Descripcion"
        Try
            Cx.Open()
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With ComboBox_Puesto
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Descripcion"
                .ValueMember = "Id_Puesto"
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
    Private Sub Edita_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Areas()
        Carga_Puestos()
        Carga_Datos()
        Me.TextBox_Nombre.Focus()
    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Dim Nombre As String = Nothing
        Id_Area = 0
        Id_Puesto = 0
        Nombre = Trim(Me.TextBox_Nombre.Text)
        If Nombre = "" Then
            MessageBox.Show("Este dato es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox_Nombre.Focus()
            Exit Sub
        End If
        Try
            Id_Area = Me.ComboBox_Area.SelectedValue
            If Id_Area = 0 Then
                MessageBox.Show("Este dato es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ComboBox_Area.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        Try
            Id_Puesto = Me.ComboBox_Puesto.SelectedValue
            If Id_Puesto = 0 Then
                MessageBox.Show("Este dato es necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ComboBox_Puesto.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        Dim Transaccion As SqlTransaction = Nothing
        Try
            Cx.Open()
            Transaccion = Cx.BeginTransaction("Actualiza Empleado")
            SQL_Str = "Update Personas set Nombre=@Nombre Where Id_Persona = @Id_Persona"
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.Parameters.AddWithValue("@Nombre", Nombre)
            Cmd.Parameters.AddWithValue("@Id_Persona", Id_Persona)
            Cmd.ExecuteNonQuery()
            SQL_Str = "Update Empleados set Id_Persona = @Id_Persona2, Id_Puesto = @Id_Puesto, Id_Area = @Id_Area Where Id_Empleado = @Id_Empleado"
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.CommandText = SQL_Str
            Cmd.Parameters.AddWithValue("@Id_Persona2", Id_Persona)
            Cmd.Parameters.AddWithValue("@Id_Puesto", Id_Puesto)
            Cmd.Parameters.AddWithValue("@Id_Area", Id_Area)
            Cmd.Parameters.AddWithValue("@Id_Empleado", Id_Empleado_Temp)
            Cmd.ExecuteNonQuery()
            Transaccion.Commit()
            Me.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Transaccion.Rollback()
            Catch ex2 As Exception
                MessageBox.Show("Message: {0}" + ex2.Message, "Rollback Exception Type: {0}" & ex2.GetType.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Transaccion.Rollback()
            Catch ex2 As Exception
                MessageBox.Show("Message: {0}" + ex2.Message, "Rollback Exception Type: {0}" & ex2.GetType.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub
End Class