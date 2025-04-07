Imports System.Data.SqlClient

Public Class Gestion_Actividad
    Private servidor = "LAPTOP-APE4QCK2"
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = VOLUNTARIADO; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Dim conexion As New SqlConnection(cadenaConexion)


    Public Function AnadirActividad(actividad As Actividad)
        conexion.Open()
        Dim sql As String = $""
        Dim cmdActividades As New SqlCommand(sql, conexion)
        Dim drActividad As Integer = cmdActividades.ExecuteNonQuery
        conexion.Close()
        If drActividad = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function MostrarActividades() As List(Of Actividad)
        conexion.Open()
        Dim sql As String = $"SELECT * FROM ACTIVIDAD"
        Dim cmdListaActividades As New SqlCommand(sql, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim actividades As New List(Of Actividad)
        While drActividades.Read
            actividades.Add(New Actividad(drActividades("Nombre"), drActividades("Duracion_Sesion"), drActividades("Fecha_Inicio"), drActividades("Fecha_Fin"), drActividades("N_MAX_VOLUNTARIOS"), drActividades("Descripcion")))
        End While
        conexion.Close()
        Return actividades
    End Function

    'Public Function FiltrarActividad(actividad As Actividad)
    '    Dim conexion As New SqlConnection(cadenaConexion)
    '    conexion.Open()

    'End Function

    'Public Function ModificarActividad(actividad As Actividad)
    '    actividad = New Actividad(txtNombre.Text, txtDuracion.Text, txtFechaInicio.Text, txtFechaFin.Text, txtNumMaxVol.Text, cbxOrganizacion.)
    '    Dim conexion As New SqlConnection(cadenaConexion)
    '    conexion.Open()
    '    Dim sql As String = $"UPDATE PROVINCIA SET NOMBRE = '{nombre}' WHERE ID = '{id}'"
    '    Dim cmdProvincia As New SqlCommand(sql, conexion)
    '    Dim drProvincia As Integer = cmdProvincia.ExecuteNonQuery
    '    conexion.Close()
    '    If drProvincia = 0 Then
    '        Return False
    '    End If
    '    Return True
    'End Function

    Public Function BorrarActividad(nombreActividad As String)
        conexion.Open()
        Dim sql As String = $"DELETE FROM ACTIVIDADES WHERE ACTIVIDADES.NOMBRE='{nombreActividad}'"
        Dim cmdActividad As New SqlCommand(sql, conexion)
        Dim drActividad As Integer = cmdActividad.ExecuteNonQuery
        conexion.Close()
        If drActividad = 0 Then
            Return False
        End If
        Return True
    End Function
End Class

