Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Public Class Listado_Equipos
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Private Sub Listado_Equipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub
    Sub Carga_Datos()
        SQL_Str = "Select * from View_Equipos"
        Try
            Cx.Open()
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
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
    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        Dim ID_Servicio As Integer = 0
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            Id_Equipo_Temp = Me.DataGridView1(columna, fila).Value
            If Id_Equipo_Temp = 0 Then
                MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Dim frm As New Edita_Equipo
                frm.ShowDialog()
                Carga_Datos()
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Borrar_Click(sender As Object, e As EventArgs) Handles Button_Borrar.Click
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        Dim ID As Integer = 0
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        SQL_Str = "Select count(Id_Equipo_x_Empleado) as Total from Equipo_x_Empleado Where Id_Equipo = @Id_Equipo"
        Try
            Id_Empleado_Temp = Me.DataGridView1(columna, fila).Value
            If Id_Empleado_Temp = 0 Then
                MessageBox.Show("Debe seleccionar un Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Cx.Open()
                Dim Total As Int32 = 0
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo_Temp)
                Total = Convert.ToInt32(Cmd.ExecuteScalar())
                If Total >= 1 Then
                    MessageBox.Show("No se puede eliminar el Equipo ya que esta asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If Cx.State = ConnectionState.Open Then
                        Cx.Close()
                    End If
                    Dim Transaccion As SqlTransaction = Nothing
                    Try
                        Cx.Open()
                        Transaccion = Cx.BeginTransaction("Borra Equipo")
                        Cmd.CommandType = CommandType.Text
                        Cmd.CommandText = "Update Equipos Set Baja = 'True' Where Id_Equipo =  @Id_Equipo"
                        Cmd.Transaction = Transaccion
                        Cmd.Parameters.AddWithValue("@Id_Equipo", Id_Equipo_Temp)
                        Cmd.ExecuteNonQuery()

                        Transaccion.Commit()
                        Carga_Datos()
                    Catch ex As SqlException
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Transaccion.Rollback()
                        Exit Sub
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Transaccion.Rollback()
                        Exit Sub
                    Finally
                        If Cx.State = ConnectionState.Open Then
                            Cx.Close()
                        End If
                    End Try
                End If
            End If
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

    Private Sub Button_Excel_Click(sender As Object, e As EventArgs) Handles Button_Excel.Click
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim DireccionImagenLogo As String = Nothing
        Try
            DireccionImagenLogo = "\\SRVPROMOEDO-5\Compartido\logo_slp_promotora2.png"
        Catch ex As Exception
            MessageBox.Show("Error al intentar obtener la imagen del logo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim app As Object
        Dim xlbook As Object
        Dim xlsheet As Object
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
        Try
            app = CreateObject("Excel.Application")
            xlbook = app.Workbooks.Add()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            xlsheet = xlbook.ActiveSheet
            Dim range As Excel.Range
            ' Crea una nueva Instancia o Excel y un nuevo workbook.
            thisThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            If File.Exists(DireccionImagenLogo) Then
                xlsheet.Shapes.AddPicture(DireccionImagenLogo, CType(False, Microsoft.Office.Core.MsoTriState), CType(True, Microsoft.Office.Core.MsoTriState), 5, 5, 130, 55)
            End If
            xlsheet.Range("A1").EntireRow.RowHeight = 65
            xlsheet.Cells(1, 16).Formula = Now
            'xlsheet.Range("A7").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            'xlsheet.Range("A7").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlsheet.Range("A2").Font.Bold = True
            xlsheet.Range("A2").Font.Size = 18
            xlsheet.Range("A2").Interior.ColorIndex = 16
            xlsheet.Range("A2").Value = "Listado de Equipos"
            xlsheet.Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A2").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlsheet.Range("A2:P3").Merge()
            xlsheet.Range("A2:P3").BorderAround(, Excel.XlBorderWeight.xlMedium, _
                    Excel.XlColorIndex.xlColorIndexAutomatic, )
            xlsheet.Cells(4, 1).Formula = "ID"
            xlsheet.Cells(4, 2).Formula = "Descripcion"
            xlsheet.Cells(4, 3).Formula = "Número de Inventario Interno"
            xlsheet.Cells(4, 4).Formula = "Número de Inventario Externo"
            xlsheet.Cells(4, 5).Formula = "Marca"
            xlsheet.Cells(4, 6).Formula = "Modelo"
            xlsheet.Cells(4, 7).Formula = "Color"
            xlsheet.Cells(4, 8).Formula = "Serie del Equipo"
            xlsheet.Cells(4, 9).Formula = "Serie de la Pila"
            xlsheet.Cells(4, 10).Formula = "Serie del Cargador"
            xlsheet.Cells(4, 11).Formula = "Procesador"
            xlsheet.Cells(4, 12).Formula = "Disco Duro"
            xlsheet.Cells(4, 13).Formula = "Ram"
            xlsheet.Cells(4, 14).Formula = "Unidad Optica"
            xlsheet.Cells(4, 15).Formula = "Condiciones"
            xlsheet.Cells(4, 16).Formula = "Observaciones"
            Dim Rango As String = "A4:P4"
            xlsheet.Range(Rango).Font.Bold = True
            xlsheet.Range(Rango).Interior.ColorIndex = 16
            xlsheet.Range(Rango).Font.Size = 11
            xlsheet.Range(Rango).Borders().Color = 0
            xlsheet.Range(Rango).Borders().LineStyle = Excel.XlLineStyle.xlContinuous
            xlsheet.Range(Rango).Borders().Weight = 2
            xlsheet.Range(Rango).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Dim R As String = "A4:A" + CInt(DataGridView1.RowCount + 5).ToString
            xlsheet.Range(R).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("B1").EntireColumn.ColumnWidth = 30
            xlsheet.Range("C1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("D1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("E1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("F1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("G1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("H1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("I1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("J1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("K1").EntireColumn.ColumnWidth = 15
            xlsheet.Range("L1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("M1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("N1").EntireColumn.ColumnWidth = 10
            xlsheet.Range("O1").EntireColumn.ColumnWidth = 15
            xlsheet.Range("P1").EntireColumn.ColumnWidth = 30
            'Aqui obtengo el tamaño del datagrid y lo copio al excel
            Dim DGRows As Integer = Me.DataGridView1.RowCount
            Dim DGCols As Integer = Me.DataGridView1.ColumnCount
            range = xlsheet.Range("A5", Reflection.Missing.Value)
            range = range.Resize(DGRows, DGCols)
            range.Borders().Color = 0
            range.Borders().LineStyle = Excel.XlLineStyle.xlContinuous
            range.Borders().Weight = 2
            range.Font.Size = 9
            'Crea un array
            Dim saRet(DGRows, DGCols) As String
            'llena el array.
            Dim iRow As Integer
            Dim iCol As Integer
            For iRow = 0 To DataGridView1.RowCount - 1
                For iCol = 0 To DataGridView1.ColumnCount - 1
                    saRet(iRow, iCol) = DataGridView1.Rows(iRow).Cells(iCol).Value.ToString
                Next iCol
            Next iRow
            'establece el valor del rango del array.
            range.Value = saRet
            'Regresa el control del Excel al usuario y Limpia
            range = Nothing
            app.Visible = True
            app.UserControl = True
            releaseobject(app)
            releaseobject(xlbook)
            releaseobject(xlsheet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            thisThread.CurrentCulture = originalCulture
        End Try

    End Sub

    Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        Dim Frm As New Nuevo_Equipo
        Frm.ShowDialog()
        Carga_Datos()
    End Sub

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Me.Close()

    End Sub
End Class