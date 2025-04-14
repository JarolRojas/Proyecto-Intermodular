Imports System.Collections.ObjectModel

Public Class Voluntario
    Public Property CodVol As Integer
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property FechaNacimiento As Date
    Public Property Descripcion As String
    Public Property Ciclo As Ciclo
    Public Property Disponibilidades As List(Of Disponibilidad)
    Public Property Actividades As List(Of Actividad)
    Public Property TiposActividadPreferidos As List(Of Tipo_Actividad)

    Public Sub New(codvol As Integer, nombre As String, apellido1 As String, apellido2 As String, correo As String, telefono As String, fechaNacimiento As Date, descripcion As String, ciclo As Ciclo, disponibilidades As List(Of Disponibilidad), actividades As List(Of Actividad), tiposActividadPreferidos As List(Of Tipo_Actividad))
        Me.CodVol = codvol
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.Correo = correo
        Me.Telefono = telefono
        Me.FechaNacimiento = fechaNacimiento
        Me.Descripcion = descripcion
        Me.Ciclo = ciclo
        Me.Disponibilidades = New List(Of Disponibilidad)
        Me.Actividades = New List(Of Actividad)
        Me.TiposActividadPreferidos = New List(Of Tipo_Actividad)
    End Sub
End Class
