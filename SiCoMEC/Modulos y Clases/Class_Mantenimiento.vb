
Public Class Class_Mantenimiento
    Inherits Class_Equipo
    Private _Fecha As Date
    Private _Empleado As String
    Private _Id_Area As Integer
    Private _Area As String
    Private _Id_Puesto As Integer
    Private _Puesto As String
    Private _Diagnostico As String
    Private _DescripcionFalla As String
    Private _TipoSolicitud As String

    Property TipoSolicitud As String
        Get
            Return _TipoSolicitud
        End Get
        Set(value As String)
            _TipoSolicitud = value
        End Set
    End Property
    Property DescripcionFalla As String
        Get
            Return _DescripcionFalla
        End Get
        Set(value As String)
            _DescripcionFalla = value
        End Set
    End Property

    Property Diagnostico As String
        Get
            Return _Diagnostico
        End Get
        Set(value As String)
            _Diagnostico = value
        End Set
    End Property
    Property Fecha As Date
        Get
            Return _Fecha

        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property
    Property Empleado As String
        Get
            Return _Empleado
        End Get
        Set(value As String)
            _Empleado = value
        End Set
    End Property
    Property Area As String
        Get
            Return _Area
        End Get
        Set(value As String)
            _Area = value
        End Set
    End Property
    Property ID_Area As Integer
        Get
            Return _Id_Area
        End Get
        Set(value As Integer)
            _Id_Area = value
        End Set
    End Property
    Property Puesto As String
        Get
            Return _Puesto
        End Get
        Set(value As String)
            _Puesto = value
        End Set
    End Property
    Property Id_Puesto As Integer
        Get
            Return _Id_Puesto
        End Get
        Set(value As Integer)
            _Id_Puesto = value
        End Set
    End Property
End Class
