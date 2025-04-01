Imports System.Collections.ObjectModel

Public Class Actividad
    Public Property Nombre As String
    Public Property Duracion As Date
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property NumMaxVol As Byte
    Public Property Organizacion As Organizacion
    Public Property Descripcion As String
    Public Property TipoActividad As New List(Of Tipo_Actividad)
    Public Property Ods As New List(Of ODS)


End Class
