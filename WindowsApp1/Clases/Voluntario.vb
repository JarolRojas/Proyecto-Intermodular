Imports System.Collections.ObjectModel

Public Class Voluntario
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property FechaNacimiento As DateTime
    Public Property Descripcion As String
    Public Property CodCiclo As String
    Public Property Ciclo As Ciclo
    Public Property Disponibilidades As New List(Of Disponibilidad)
    Public Property Actividades As New List(Of Actividad)
    Public Property TiposActividadPreferidos As New List(Of Tipo_Actividad)
End Class
