Public Class ClsCliente

#Region "CAMPOS"

    Private _ID_CLIENTE As Integer
    Private _NOMBRE_C As String
    Private _SEXO As String
    Private _EDAD As Integer
    Private _OBSERVACIONES As String



#End Region

#Region "PROPIEDADES"
    Public Property ID_CLIENTE As Integer
        Get
            Return _ID_CLIENTE
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property NOMBRE_C As String
        Get
            Return _NOMBRE_C
        End Get
        Set(value As String)
            _NOMBRE_C = value
        End Set
    End Property


    Public Property SEXO As String
        Get
            Return _SEXO
        End Get
        Set(value As String)
            _SEXO = value
        End Set
    End Property


    Public Property EDAD As Integer
        Get
            Return _EDAD
        End Get
        Set(value As Integer)
            _EDAD = value
        End Set
    End Property

    Public Property OBSERVACIONES As String
        Get
            Return _OBSERVACIONES
        End Get
        Set(value As String)
            _OBSERVACIONES = value
        End Set
    End Property
#End Region

    Public Sub New()


    End Sub

    Public Sub New(ByVal ID_CLIENTE As Integer, ByVal NOMBRE_C As String, ByVal SEXO As String, ByVal EDAD As Integer, ByVal OBSERVACIONES As String)

        _ID_CLIENTE = ID_CLIENTE
        _NOMBRE_C = NOMBRE_C
        _SEXO = SEXO
        _EDAD = EDAD
        _OBSERVACIONES = OBSERVACIONES
    End Sub



End Class
