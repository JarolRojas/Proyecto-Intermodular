Imports System.Data.SqlClient

Public Class Gestion_BBDD
    Private servidor = "DESKTOP-H03H3Q2"
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = VOLUNTARIADO; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Dim conexion As New SqlConnection(cadenaConexion)

    Public Sub ListarODS()
        conexion.Open()
        Dim sql As String = $"SELECT * FROM ACTIVIDAD"
        Dim cmdListaODS As New SqlCommand(sql, conexion)
        Dim drODS As SqlDataReader = cmdListaODS.ExecuteReader
        While drODS.Read
            Dim nODS As New ODS(drODS("NumODS"), drODS("Descripcion"))
        End While

        'dim p1 as persona = new
        'dim p2 as persona = new



        conexion.Close()
    End Sub

    Public Function MostrarActividades() As List(Of Actividad)
        conexion.Open()
        Dim sql As String = $"SELECT * FROM ACTIVIDAD"
        Dim cmdListaActividades As New SqlCommand(sql, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim actividades As New List(Of Actividad)
        While drActividades.Read
            actividades.Add(New Actividad(drActividades("Nombre"), drActividades("Duracion_Sesion"), drActividades("Fecha_Inicio"), drActividades("Fecha_Fin"), drActividades("N_MAX_VOLUNTARIOS"), drActividades("codOrg"), drActividades("Descripcion")))
        End While
        conexion.Close()
        Return actividades
    End Function

End Class
