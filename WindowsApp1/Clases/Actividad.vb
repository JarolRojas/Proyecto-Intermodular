Imports System.Collections.ObjectModel

Public Class Actividad
    Public Property CodAct As Integer
    Public Property Nombre As String
    Public Property Duracion As TimeSpan
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property NumMaxVol As Byte
    Public Property Organizacion As String
    Public Property Descripcion As String
    Public Property ListaTipoActividad As List(Of String)
    Public Property ListaOds As List(Of String)
    Public Property ListaVoluntarios As List(Of String)
    Public Property TipoActividad As String
    Public Property Ods As String
    Public Property Voluntarios As String

    Public Sub New(nombre As String, duracion As TimeSpan, fechaInicio As Date, fechaFin As Date, numMaxVol As Byte, organizacion As String, descripcion As String)
>>>>>>> Daniel
        Me.Nombre = nombre
        Me.Duracion = duracion
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.NumMaxVol = numMaxVol
        Me.Organizacion = organizacion
        Me.Descripcion = descripcion
        Me.ListaTipoActividad = New List(Of String)
        Me.ListaOds = New List(Of String)
        Me.ListaVoluntarios = New List(Of String)
    End Sub

    Public Sub New(nombre As String, duracion As TimeSpan, fechaInicio As Date, fechaFin As Date, numMaxVol As Byte, organizacion As String, descripcion As String, Tipo As String, Ods As String, Voluntarios As String)
        Me.New(nombre, duracion, fechaInicio, fechaFin, numMaxVol, organizacion, descripcion)
        Me.Ods = Ods
        Me.TipoActividad = Tipo
        Me.Voluntarios = Voluntarios
>>>>>>> Daniel
    End Sub

    Public Sub AñadirOds(ods As String)
        Me.ListaOds.Add(ods)
    End Sub

    Public Sub AñadirTipo(tipo As String)
        Me.ListaTipoActividad.Add(tipo)
    End Sub
    Public Sub AñadirVoluntarios(voluntario As String)
        Me.ListaVoluntarios.Add(voluntario)
    End Sub
End Class
