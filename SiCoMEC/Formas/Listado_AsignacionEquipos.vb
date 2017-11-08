Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports System.Xml.Serialization
Imports System.Text
Public Class Listado_AsignacionEquipos
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Sub Carga_Datos()
        SQL_Str = "Select * from View_Equipos_X_Persona Where Estado = 'Activo'"
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
    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Me.Close()
    End Sub

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        Dim Frm As New Nueva_Asignacion_Equipo
        Frm.ShowDialog()
        Carga_Datos()
    End Sub

    Private Sub Listado_AsignacionEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub

    Private Sub Button_Editar_Click(sender As Object, e As EventArgs)
        Dim Frm As New Nueva_Asignacion_Equipo
        Frm.ShowDialog()
        Carga_Datos()
    End Sub

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        SQL_Str = "UPDATE Equipo_x_Empleado Set Estado = 'Baja' WHERE  Id_Equipo = (SELECT Id_Equipo FROM Equipos WHERE inventarioint = @InventarioInt)" & _
            " AND Estado = 'Activo'"
        Dim Inv As Integer = 0
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            Inv = Me.DataGridView1(columna, fila).Value
            If Inv = 0 Then
                MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Try
                    Cx.Open()
                    Dim Cmd As New SqlCommand(SQL_Str, Cx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@InventarioInt", Inv)
                    Cmd.ExecuteNonQuery()
                    Carga_Datos()
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
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
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
            xlsheet.Cells(1, 5).Formula = Now
            'xlsheet.Range("A7").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            'xlsheet.Range("A7").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlsheet.Range("A2").Font.Bold = True
            xlsheet.Range("A2").Font.Size = 18
            xlsheet.Range("A2").Interior.ColorIndex = 16
            xlsheet.Range("A2").Value = "Listado de Equipos Asignados"
            xlsheet.Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A2").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlsheet.Range("A2:E3").Merge()
            xlsheet.Range("A2:E3").BorderAround(, Excel.XlBorderWeight.xlMedium, _
                    Excel.XlColorIndex.xlColorIndexAutomatic, )
            xlsheet.Cells(4, 1).Formula = "Inventario Interno"
            xlsheet.Cells(4, 2).Formula = "Descripción"
            xlsheet.Cells(4, 3).Formula = "Empleado al cual se asigno el equipo"
            xlsheet.Cells(4, 4).Formula = "Fecha"
            xlsheet.Cells(4, 5).Formula = "Estado Actual"
            xlsheet.Range("A4:E4").Font.Bold = True
            xlsheet.Range("A4:E4").Interior.ColorIndex = 16
            xlsheet.Range("A4:E4").Font.Size = 11
            xlsheet.Range("A4:E4").Borders().Color = 0
            xlsheet.Range("A4:E4").Borders().LineStyle = Excel.XlLineStyle.xlContinuous
            xlsheet.Range("A4:E4").Borders().Weight = 2
            xlsheet.Range("A4:E4").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Dim R As String = "A4:A" + CInt(DataGridView1.RowCount + 5).ToString
            xlsheet.Range(R).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A1").EntireColumn.ColumnWidth = 17
            xlsheet.Range("B1").EntireColumn.ColumnWidth = 45
            xlsheet.Range("C1").EntireColumn.ColumnWidth = 36
            xlsheet.Range("D1").EntireColumn.ColumnWidth = 18
            xlsheet.Range("E1").EntireColumn.ColumnWidth = 13.5

      
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

#Region "HtmltoPDF"
    Public Enum eNavegador
        iexplore
        firefox
        chrome
    End Enum
    Private Sub FormatHtmlFileName(ByRef _htm As String)
        If _htm.Trim = "" Then
            _htm = IO.Path.GetTempFileName.Replace(" ", "_")
        Else
            _htm = _htm.Replace(" ", "_")
        End If
        If _htm.EndsWith(".xml") = True Then _htm = _htm.Remove(".xml")
        If _htm.EndsWith(".html") = False Then _htm += ".html"
    End Sub
    Public Sub GuardaFormatoPDF(ByRef _htm As String)
        Dim proc As New ProcessStartInfo("Resources\wkhtmltopdf.exe")

        proc.Arguments = _htm + " " + _htm.Replace(".html", ".pdf")
        proc.WindowStyle = ProcessWindowStyle.Hidden

        Process.Start(proc)
    End Sub
    Public Sub ImprimirFormato(ByVal _htm As String)

        ' Create a WebBrowser instance. 
        Dim webBrowserForPrinting As New WebBrowser()

        ' Add an event handler that prints the document after it loads.
        AddHandler webBrowserForPrinting.DocumentCompleted, New  _
            WebBrowserDocumentCompletedEventHandler(AddressOf PrintDocument)

        FormatHtmlFileName(_htm)
        ' Set the Url property to load the document.
        'webBrowserForPrinting.Url = New Uri(_htm)
        webBrowserForPrinting.Navigate(New Uri(_htm))

    End Sub
    Private Sub PrintDocument(ByVal sender As Object, _
    ByVal e As WebBrowserDocumentCompletedEventArgs)

        Dim webBrowserForPrinting As WebBrowser = CType(sender, WebBrowser)

        ' Print the document now that it is fully loaded.
        webBrowserForPrinting.Print()

        ' Dispose the WebBrowser now that the task is complete. 
        webBrowserForPrinting.Dispose()

    End Sub
#End Region

    Private Sub Button_Imprimir_Click(sender As Object, e As EventArgs) Handles Button_Imprimir.Click
        Dim Inv As String = Nothing
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            Inv = Me.DataGridView1(columna, fila).Value
            Dim Total_Registros As Integer = 0
            If Inv = "" Then
                MessageBox.Show("Debe seleccionar una asignación de equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Try
                    SQL_Str = "Select Fecha from Equipo_x_Empleado Where Id_Equipo = (Select Id_Equipo from Equipos Where InventarioInt= @InventarioInt);" & _
                        " Select * from View_Empleados_conId Where Id_Empleado = (Select Id_Empleado from Equipo_x_Empleado Where Id_Equipo = (Select Id_Equipo from Equipos Where InventarioInt= @InventarioInt));" & _
                        " Select * from View_Equipos where InventarioInt = @InventarioInt;" & _
                        " Select Count(Id_Equipo) as Total from View_Software_x_Equipo Where Id_Equipo = (Select Id_Equipo from Equipos Where InventarioInt= @InventarioInt);" & _
                        " Select Descripcion from View_Software_x_Equipo Where Id_Equipo = (Select Id_Equipo from Equipos Where InventarioInt= @InventarioInt)"
                    Cx.Open()
                    Dim Cmd As New SqlCommand(SQL_Str, Cx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@InventarioInt", Inv)
                    Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
                    Dim M As New Class_Mantenimiento
                    With Reader

                        If .HasRows Then
                            While .Read
                                M.Fecha = .Item("Fecha")
                            End While
                        End If
                        .NextResult()
                        If .HasRows Then
                            While .Read
                                M.Empleado = .Item("Nombre")
                                M.ID_Area = .Item("Id_Area")
                                M.Area = .Item("Area")
                                M.Id_Puesto = .Item("Id_Puesto")
                                M.Puesto = .Item("Descripcion")
                            End While
                        End If
                        .NextResult()
                        If .HasRows Then
                            While .Read
                                M.Descripcion = .Item("Descripcion")
                                M.NumeroInvInterno = .Item("InventarioInt")
                                M.NumeroInvExterno = .Item("InventarioExt")
                                M.Marca = .Item("Marca")
                                M.Modelo = .Item("Modelo")
                                M.Color = .Item("Color")
                                M.SerieEquipo = .Item("SerieEquipo")
                                M.SeriePila = .Item("SeriePila")
                                M.SerieCargador = .Item("SerieCargador")
                                M.Procesador = .Item("Procesador")
                                M.DiscoDuro = .Item("HD")
                                M.MemoriaRam = .Item("Ram")
                                M.UnidadOptica = .Item("UnidadOptica")
                                M.Condicion = .Item("Condiciones")
                                M.Observaciones = .Item("Observaciones")
                            End While
                        End If
                        .NextResult()
                        If .HasRows Then
                            While .Read
                                Total_Registros = .Item("Total")
                            End While
                        End If
                        .NextResult()
                        Dim _Software As New Text.StringBuilder
                        If .HasRows Then
                            Dim Arreglo(Total_Registros)
                            While .Read
                                Dim _Soft As String = _
                                    "<tr>" & vbNewLine & _
                                        "<td class=""texto-centrado"">" & .Item(0) & "</td>" & vbNewLine & _
                                    "</tr>"
                                _Software.Append(_Soft)
                            End While
                            M.TablaSoftware = _Software.ToString
                        End If
                        Dim objStreamWriter As New StreamWriter("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Datos.xml", False, System.Text.Encoding.UTF8)
                        Dim x As New XmlSerializer(M.GetType)
                        x.Serialize(objStreamWriter, M)
                        objStreamWriter.Close()
                    End With
                    Dim _NombreGuardar As String = "\\SRVPROMOEDO-5\Compartido\SiCoMEC\Reportes\Asignacion_" & M.NumeroInvInterno
                    If File.Exists(_NombreGuardar + ".pdf") Then
                        Process.Start(_NombreGuardar + ".pdf")
                        Exit Sub
                    End If
                    Dim url As String = "Reportes\AsignacionEquipo.html"
                    Dim sr As New IO.StreamReader(url)
                    Dim _htm As String = sr.ReadToEnd
                    sr.Close()
                    Dim _new As String = ""
                    _new = _htm _
                        .Replace("$Nombre$", M.Empleado) _
                        .Replace("$Area$", M.Area) _
                        .Replace("$Puesto$", M.Puesto) _
                        .Replace("$Fecha$", M.Fecha) _
                        .Replace("$Inventario$", M.NumeroInvInterno) _
                        .Replace("$Marca$", M.Marca) _
                        .Replace("$Modelo$", M.Modelo) _
                        .Replace("$Color$", M.Color) _
                        .Replace("$SerieE$", M.SerieEquipo) _
                        .Replace("$SerieP$", M.SeriePila) _
                        .Replace("$SerieC$", M.SerieCargador) _
                        .Replace("$CondicionesEquipo$", M.Condicion) _
                        .Replace("$Procesador$", M.Procesador) _
                        .Replace("$HD$", M.DiscoDuro) _
                        .Replace("$Ram$", M.MemoriaRam) _
                        .Replace("$CD$", M.UnidadOptica) _
                        .Replace("$Soft$", M.TablaSoftware) _
                        .Replace("$Observaciones$", M.Observaciones)
                    FormatHtmlFileName(_NombreGuardar)
                    If _NombreGuardar.EndsWith(".html") = False Then
                        FormatHtmlFileName(_NombreGuardar.Replace(".xml", ".html"))
                    End If
                    Using sw As New IO.StreamWriter(_NombreGuardar, False, System.Text.Encoding.UTF8)
                        For Each cr In _new.ToCharArray
                            sw.Write(cr)
                        Next
                        sw.Flush()
                        sw.Close()
                    End Using
                    GuardaFormatoPDF(_NombreGuardar)
                    If File.Exists(_NombreGuardar.Replace(".html", ".pdf")) Then
                        Process.Start(_NombreGuardar.Replace(".html", ".pdf"))
                    Else
                        Try
                            Dim result As System.IO.WaitForChangedResult
                            Dim watcher As New System.IO.FileSystemWatcher("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Reportes\")
                            result = watcher.WaitForChanged(System.IO.WatcherChangeTypes.Created)
                        Catch ex As IOException
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                    End If
                    If File.Exists(_NombreGuardar.Replace(".html", ".pdf")) Then
                        Process.Start(_NombreGuardar.Replace(".html", ".pdf"))
                    End If
                    ' Process.Start("iexplore.exe", _NombreGuardar)
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
            End If

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
        End Try

    End Sub
End Class