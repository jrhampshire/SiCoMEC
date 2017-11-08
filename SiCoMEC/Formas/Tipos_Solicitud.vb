Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class Tipos_Solicitud
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)

    Private Sub Tipos_Solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Series()
    End Sub

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        Guarda_Datos()
        Carga_Series()
        Me.TextBox1.Text = ""
        Me.TextBox1.Focus()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Guarda_Datos()
            Carga_Series()
            Me.TextBox1.Text = ""
            Me.TextBox1.Focus()
        End If
    End Sub
    Private Sub Button_Borrar_Click(sender As Object, e As EventArgs) Handles Button_Borrar.Click
        Dim ID As Integer = 0
        ID = Me.ListBox1.SelectedValue
        If ID = 0 Then
            MessageBox.Show("Debe de seleccionar una Solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                Cx.Open()
                Dim SQL_Str As String = "Delete from Tipos_Solicitud where Id_Tipos_Solicitud = @Id_Tipos_Solicitud"
                Dim Cmd_Borra As SqlCommand = New SqlCommand(SQL_Str, Cx)
                Cmd_Borra.CommandType = CommandType.Text
                Cmd_Borra.Parameters.AddWithValue("@Id_Tipos_Solicitud", ID)
                Cmd_Borra.ExecuteNonQuery()
                Cx.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                If Cx.State = ConnectionState.Open Then
                    Cx.Close()
                End If
            End Try
            Carga_Series()
        End If
    End Sub
    Sub Guarda_Datos()
        Dim Serie As String = Nothing
        Serie = Trim(Me.TextBox1.Text)
        If Serie = "" Then
            MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox1.Focus()
            Exit Sub

        End If

        SQL_Str = "Insert into Tipos_Solicitud (Descripcion) Values (@Tipos_Solicitud)"
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Tipos_Solicitud", Serie)
            Cmd.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub
    Sub Carga_Series()

        SQL_Str = "Select * from Tipos_Solicitud Order by Descripcion"
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Dim DA As New SqlDataAdapter(Cmd)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With ListBox1
                .DataSource = DS.Tables(0)
                .DisplayMember = "Descripcion"
                .ValueMember = "Id_Tipos_Solicitud"
            End With
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class