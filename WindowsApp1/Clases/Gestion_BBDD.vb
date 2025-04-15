Imports System.Data.SqlClient

Public Class Gestion_BBDD
    Private servidor = "DESKTOP-H03H3Q2"
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = VOLUNTARIADO; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Dim conexion As New SqlConnection(cadenaConexion)

    Public Function ListarODS() As List(Of ODS)
        conexion.Open()
        Dim sql As String = $"SELECT * FROM ODS"
        Dim cmdListaODS As New SqlCommand(sql, conexion)
        Dim drODS As SqlDataReader = cmdListaODS.ExecuteReader
        Dim odsList As New List(Of ODS)
        While drODS.Read
            odsList.Add(New ODS(drODS("NUMODS"), drODS("DESCRIPCION")))
        End While
        conexion.Close()
        Return odsList
    End Function

    Public Function ListarTipoAct() As List(Of Tipo_Actividad)
        conexion.Open()
        Dim sql As String = $"SELECT * FROM TIPO_ACTIVIDAD"
        Dim cmdListaTipoAct As New SqlCommand(sql, conexion)
        Dim drTipoAct As SqlDataReader = cmdListaTipoAct.ExecuteReader
        Dim listaAct As New List(Of Tipo_Actividad)
        While drTipoAct.Read
            listaAct.Add(New Tipo_Actividad(drTipoAct("CODTIPO"), drTipoAct("DESCRIPCION")))
        End While
        conexion.Close()
        Return listaAct
    End Function

    Public Function listarOrg() As List(Of Organizacion)
        conexion.Open()
        Dim sql As String = $"SELECT * FROM ORGANIZACION"
        Dim cmdListaOrg As New SqlCommand(sql, conexion)
        Dim drOrg As SqlDataReader = cmdListaOrg.ExecuteReader
        Dim listaOrg As New List(Of Organizacion)
        While drOrg.Read
            listaOrg.Add(New Organizacion(drOrg("CODORG"), drOrg("NOMBRE"), drOrg("TIPO_ORG"), drOrg("CORREO"), drOrg("TELEFONO"), drOrg("SECTOR"), drOrg("AMBITO"), drOrg("DESCRIPCION")))
        End While
        conexion.Close()
        Return listaOrg
    End Function

    Public Function AnadirActividad(actividad As Actividad)
        conexion.Open()
        Dim sql As String = $"INSERT INTO ACTIVIDAD VALUES ('{actividad.Nombre}','{actividad.Duracion}','{actividad.FechaInicio}','{actividad.FechaFin}','{actividad.NumMaxVol}','{actividad.Organizacion}','{actividad.Descripcion}')"
        Dim cmdActividades As New SqlCommand(sql, conexion)
        Dim drActividad As Integer = cmdActividades.ExecuteNonQuery
        conexion.Close()
        If drActividad = 0 Then
            Return False
        End If
        Return True
    End Function
    'Public Function listarVoluntarios() As List(Of Voluntario)
    '    conexion.Open()
    '    Dim sql As String = $""
    '    Dim cmdListaVol As New SqlCommand(sql, conexion)
    '    Dim drVols As SqlDataReader = cmdListaVol.ExecuteReader
    '    Dim vols As New List(Of Voluntario)
    '    While drVols.Read
    '        vols.Add(New Voluntario())
    '    End While
    '    conexion.Close()
    '    Return vols
    'End Function

    Public Function MostrarActividades() As List(Of Actividad)
        conexion.Open()
        Dim sql As String = $"SELECT A.CODACT, A.Nombre, A.Duracion_Sesion, A.Fecha_Inicio, A.Fecha_Fin, A.N_MAX_VOLUNTARIOS, A.Descripcion, O.NOMBRE FROM ACTIVIDAD AS A INNER JOIN ORGANIZACION AS O ON A.CODORG = O.CODORG"
        Dim cmdListaActividades As New SqlCommand(sql, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim actividades As New List(Of Actividad)
        While drActividades.Read
            actividades.Add(New Actividad(drActividades("CodAct"), drActividades("Nombre"), drActividades("Duracion_Sesion"), drActividades("Fecha_Inicio"), drActividades("Fecha_Fin"), drActividades("N_MAX_VOLUNTARIOS"), drActividades("NOMBRE"), drActividades("Descripcion")))
        End While
        conexion.Close()
        Return actividades
    End Function

End Class
