Imports System.Collections.ObjectModel

Public Class Actividad
    Public Property Nombre As String
    Public Property Duracion As TimeSpan
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property NumMaxVol As Byte
    Public Property Organizacion As Organizacion
    Public Property Descripcion As String
    Public Property TipoActividad As List(Of Tipo_Actividad)
    Public Property Ods As List(Of ODS)

    Public Sub New(nombre As String, duracion As TimeSpan, fechaInicio As Date, fechaFin As Date, numMaxVol As Byte, organizacion As Organizacion, descripcion As String, tipoActividad As List(Of Tipo_Actividad), ods As List(Of ODS))
        Me.Nombre = nombre
        Me.Duracion = duracion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.NumMaxVol = numMaxVol
        Me.Organizacion = organizacion
        Me.Descripcion = descripcion
        Me.TipoActividad = New List(Of Tipo_Actividad)
        Me.Ods = New List(Of ODS)
    End Sub

    Public Sub New(nombre As String, duracion As TimeSpan, fechaInicio As Date, fechaFin As Date, numMaxVol As Byte, organizacion As Organizacion, descripcion As String)
        Me.Nombre = nombre
        Me.Duracion = duracion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.NumMaxVol = numMaxVol
        Me.Organizacion = organizacion
        Me.Descripcion = descripcion
        Me.TipoActividad = New List(Of Tipo_Actividad)
    End Sub

    Public Sub New(nombre As String, duracion As TimeSpan, fechaInicio As Date, fechaFin As Date, numMaxVol As Byte, descripcion As String)
        Me.Nombre = nombre
        Me.Duracion = duracion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.NumMaxVol = numMaxVol
        Me.Descripcion = descripcion
    End Sub
End Class
