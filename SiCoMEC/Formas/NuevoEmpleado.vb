Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlTransaction


Public Class NuevoEmpleado
#Region "Variables"
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
#End Region
#Region "Carga Datos"
    Sub Carga_Areas()
        SQL_Str = "Select * from Area order by area"
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

#End Region
    Private Sub NuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Areas()
        Carga_Puestos()
        Me.TextBox_Nombre.Focus()

    End Sub

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Dim Nombre As String = Nothing
        Dim Id_Area As Integer = 0
        Dim Id_Puesto As Integer = 0
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
            Transaccion = Cx.BeginTransaction("Inserta Empleado")
            SQL_Str = "Insert into Personas(Nombre) Values(@Nombre); Select @ID = @@Identity"
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.Parameters.AddWithValue("@Nombre", Nombre)
            Cmd.Parameters.Add("@ID", SqlDbType.Int)
            Cmd.Parameters("@ID").Direction = ParameterDirection.Output
            Cmd.ExecuteNonQuery()
            Dim Id_Persona As Integer = Cmd.Parameters("@ID").Value.ToString
            SQL_Str = "Insert into Empleados(Id_Persona, Id_Puesto, Id_Area) Values(@Id_Persona, @Id_Puesto, @Id_Area)"
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.CommandText = SQL_Str
            Cmd.Parameters.AddWithValue("@Id_Persona", Id_Persona)
            Cmd.Parameters.AddWithValue("@Id_Puesto", Id_Puesto)
            Cmd.Parameters.AddWithValue("@Id_Area", Id_Area)
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