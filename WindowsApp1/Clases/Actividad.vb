Imports System.Collections.ObjectModel

Public Class Actividad
    Public Property Nombre As String
    Public Property Duracion As TimeSpan
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property NumMaxVol As Byte
    Public Property Organizacion As String
    Public Property Descripcion As String
    Public Property TipoActividad As List(Of String)
    Public Property Ods As List(Of String)
    Public Property Voluntarios As List(Of String)


    Public Sub New(nombre As String, duracion As TimeSpan, fechaInicio As Date, fechaFin As Date, numMaxVol As Byte, organizacion As String, descripcion As String)
        Me.Nombre = nombre
        Me.Duracion = duracion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.NumMaxVol = numMaxVol
        Me.Organizacion = organizacion
        Me.Descripcion = descripcion
        Me.TipoActividad = New List(Of String)
        Me.Ods = New List(Of String)
        Me.Voluntarios = New List(Of String)
    End Sub

    Public Sub AñadirOds(ods As String)
        Me.Ods.Add(ods)
    End Sub

    Public Sub AñadirTipo(tipo As String)
        Me.TipoActividad.Add(tipo)
    End Sub
    Public Sub AñadirVoluntarios(voluntario As String)
        Me.Voluntarios.Add(voluntario)
    End Sub
End Class
