Public Class Principal


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Frm As New AboutBox
        Frm.ShowDialog()
    End Sub


    Private Sub TiposDeSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeSolicitudToolStripMenuItem.Click
        Dim Frm As New Tipos_Solicitud
        Frm.ShowDialog()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Dim Frm As New Listado_Mantenimientos
        Frm.ShowDialog()

    End Sub

    Private Sub AsignacionDeEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionDeEquiposToolStripMenuItem.Click
        Dim Frm As New Listado_AsignacionEquipos
        Frm.ShowDialog()

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim frm As New Listado_Empleados
        frm.ShowDialog()
    End Sub

    Private Sub AreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreasToolStripMenuItem.Click
        Dim Frm As New Areas
        Frm.ShowDialog()

    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        Dim Frm As New Puestos
        Frm.ShowDialog()

    End Sub

    Private Sub EquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposToolStripMenuItem.Click
        Dim FRM As New Listado_Equipos
        FRM.ShowDialog()

    End Sub

    Private Sub SoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        Dim Frm As New Software
        Frm.ShowDialog()

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DirectorioInicio As String = Nothing
        DirectorioInicio = System.AppDomain.CurrentDomain.BaseDirectory()

        If Not My.Computer.FileSystem.DirectoryExists("\\SRVPROMOEDO-5\Compartido\SiCoMEC") Then
            My.Computer.FileSystem.CreateDirectory("\\SRVPROMOEDO-5\Compartido\SiCoMEC")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Reportes") Then
            My.Computer.FileSystem.CreateDirectory("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Reportes")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Archivos") Then
            My.Computer.FileSystem.CreateDirectory("\\SRVPROMOEDO-5\Compartido\SiCoMEC\Archivos")
        End If

    End Sub

    Private Sub MantenimientoDelPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDelPeriodoToolStripMenuItem.Click

    End Sub
End Class
