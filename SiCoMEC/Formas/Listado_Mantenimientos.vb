Imports System
Imports System.IO
Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.Xml.Serialization

Public Class Listado_Mantenimientos
#Region "Variables"
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
#End Region
#Region "Carga Datos"
    Sub Carga_Datos()
        SQL_Str = "Select * from View_Listado_Mantenimientos"
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
#End Region

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Me.Close()
    End Sub

    Private Sub Listado_Mantenimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub

#Region "Excel"
    Sub Genera_Excel()
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
            xlsheet.Cells(1, 6).Formula = Now
            xlsheet.Range("A2").Font.Bold = True
            xlsheet.Range("A2").Font.Size = 18
            xlsheet.Range("A2").Interior.ColorIndex = 16
            xlsheet.Range("A2").Value = "Listado de Mantenimiento de Equipos"
            xlsheet.Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A2").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlsheet.Range("A2:F3").Merge()
            xlsheet.Range("A2:F3").BorderAround(, Excel.XlBorderWeight.xlMedium, _
                    Excel.XlColorIndex.xlColorIndexAutomatic, )
            xlsheet.Cells(4, 1).Formula = "Folio Mantenimiento"
            xlsheet.Cells(4, 2).Formula = "Tipo de Solicitud"
            xlsheet.Cells(4, 3).Formula = "Fecha de Solicitud"
            xlsheet.Cells(4, 4).Formula = "Descripcion de Falla"
            xlsheet.Cells(4, 5).Formula = "Diagnostico"
            xlsheet.Cells(4, 6).Formula = "Fecha de Entrega"
            xlsheet.Range("A4:F4").Font.Bold = True
            xlsheet.Range("A4:F4").Interior.ColorIndex = 16
            xlsheet.Range("A4:F4").Font.Size = 11
            xlsheet.Range("A4:F4").Borders().Color = 0
            xlsheet.Range("A4:F4").Borders().LineStyle = Excel.XlLineStyle.xlContinuous
            xlsheet.Range("A4:F4").Borders().Weight = 2
            xlsheet.Range("A4:F4").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A4").WrapText = True
            xlsheet.Range("A4").EntireRow.RowHeight = 30
            Dim R As String = "A4:A" + CInt(DataGridView1.RowCount + 5).ToString
            xlsheet.Range(R).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A1").EntireColumn.ColumnWidth = 15
            xlsheet.Range("B1").EntireColumn.ColumnWidth = 16
            xlsheet.Range("C1").EntireColumn.ColumnWidth = 18
            xlsheet.Range("D1").EntireColumn.ColumnWidth = 40
            xlsheet.Range("D1").EntireColumn.WrapText = True
            xlsheet.Range("E1").EntireColumn.ColumnWidth = 40
            xlsheet.Range("E1").EntireColumn.WrapText = True
            xlsheet.Range("F1").EntireColumn.ColumnWidth = 20
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
#End Region
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
#Region "Numeros a Letras 2"
    Public Function NumeroATexto(ByVal d As Double) As String
        Dim parteEntera As Double = Math.Truncate(d)
        Dim parteDecimal As Double = Math.Truncate((d - parteEntera) * 100)
        If (parteDecimal > 0) Then
            Return Num2Text(parteEntera) + " Pesos " + CInt(parteDecimal).ToString + "/100 M.N."
        Else
            Return Num2Text(parteEntera) + " Pesos 00/100 M.N."
        End If

    End Function
    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function

#End Region

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        Dim frm As New Nuevo_Mantenimiento
        frm.ShowDialog()
        Carga_Datos()
    End Sub

    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
        Dim columna As Integer, fila As Integer
        Dim ID_Servicio As Integer = 0
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            Id_Mantenimiento_Temp = Me.DataGridView1(columna, fila).Value
            If Id_Mantenimiento_Temp = 0 Then
                MessageBox.Show("Debe seleccionar un Mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Dim frm As New Edita_Mantenimiento
                frm.ShowDialog()
                Carga_Datos()
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un Mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
        End Try
    End Sub

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click

    End Sub

    Private Sub Button_Excel_Click(sender As Object, e As EventArgs) Handles Button_Excel.Click
        Genera_Excel()
    End Sub

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
                    SQL_Str = "Select * from Mantenimientos where id_Mantenimiento = @ID" & _
                        " SELECT Area.Area, Puestos.Descripcion, Personas.Nombre " & _
                        " FROM Empleados INNER JOIN Area ON Empleados.Id_Area = Area.Id_Area INNER JOIN Puestos ON Empleados.Id_Puesto = Puestos.Id_Puesto INNER JOIN" & _
                        " Personas ON Empleados.Id_Persona = Personas.Id_Persona WHERE (Empleados.Id_Persona = (SELECT Solicito FROM Mantenimientos WHERE (Id_Mantenimiento = @ID)));" & _
                        " Select * from Tipos_Solicitud Where Id_Tipos_Solicitud =  (Select Id_Tipos_Solicitud from Mantenimientos where id_Mantenimiento = @ID);" & _
                        " Select * from Equipos where Id_Equipo = (Select Id_Equipo  from Mantenimientos where id_Mantenimiento = @ID)"
                    Cx.Open()
                    Dim Cmd As New SqlCommand(SQL_Str, Cx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@ID", Inv)
                    Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
                    Dim M As New Class_Mantenimiento
                    With Reader

                        If .HasRows Then
                            While .Read
                                M.Fecha = .Item("Fecha_Solicitud")
                                M.DescripcionFalla = .Item("Descripcion_Falla")
                                M.Diagnostico = .Item("Diagnostico")
                            End While
                        End If
                        .NextResult()
                        If .HasRows Then
                            While .Read
                                M.Empleado = .Item("Nombre")
                                M.Area = .Item("Area")
                                M.Puesto = .Item("Descripcion")
                            End While
                        End If
                        .NextResult()
                        If .HasRows Then
                            While .Read
                                M.TipoSolicitud = .Item("Descripcion")
                            End While
                        End If
                        .NextResult()
                        If .HasRows Then
                            While .Read
                                M.NumeroInvInterno = .Item("InventarioInt")
                            End While
                        End If
                        Dim objStreamWriter As New StreamWriter("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Datos1.xml", False, System.Text.Encoding.UTF8)
                        Dim x As New XmlSerializer(M.GetType)
                        x.Serialize(objStreamWriter, M)
                        objStreamWriter.Close()
                    End With
                    Dim _NombreGuardar As String = "\\SRVPROMOEDO-5\Compartido\SiCoMEC\Reportes\Mantenimiento" & M.NumeroInvInterno
                    If File.Exists(_NombreGuardar + ".pdf") Then
                        Process.Start(_NombreGuardar + ".pdf")
                        Exit Sub
                    End If
                    Dim url As String = "Reportes\ServicioMtto.html"
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
                        .Replace("$Falla$", M.DescripcionFalla) _
                        .Replace("$Diagnostico$", M.Diagnostico) _
                        .Replace("$folio$", Inv) _
                        .Replace("$TipoMtto$", M.TipoSolicitud)
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