Imports System.Collections.Specialized.BitVector32
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Gestion_Actividad
    Private servidor = "LAPTOP-APE4QCK2"
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = VOLUNTARIADO; Integrated Security = SSPI; MultipleActiveResultSets=true"
    Dim conexion As New SqlConnection(cadenaConexion)


    Public Function AnadirActividad(actividad As Actividad)
        conexion.Open()
        Dim sqlnombre As String = $"SELECT NOMBRE FROM ACTIVIDAD WHERE NOMBRE='{actividad.Nombre}'"
        Dim cmdNombre As New SqlCommand(sqlnombre, conexion)
        Dim drNombre As SqlDataReader = cmdNombre.ExecuteReader()
        If drNombre.HasRows Then
            conexion.Close()
            Return False
        End If
        Dim sql As String = $"INSERT INTO ACTIVIDAD VALUES ('{actividad.Nombre}','{actividad.Duracion}','{actividad.FechaInicio}','{actividad.FechaFin}','{actividad.NumMaxVol}',(SELECT CODORG FROM ORGANIZACION WHERE NOMBRE='{actividad.Organizacion}'),'{actividad.Descripcion}')"
        Dim sqlOds, sqlTipo, sqlVoluntarios As String
        Dim cmdAnadirActividades As New SqlCommand(sql, conexion)
        cmdAnadirActividades.ExecuteNonQuery()
        Dim cmdActividades As SqlCommand
        For Each o In actividad.ListaOds
            sqlOds = $"INSERT INTO ACT_PRACTICA_ODS VALUES ((SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}'),(SELECT NUMODS FROM ODS WHERE DESCRIPCION ='{o}'))"
            cmdActividades = New SqlCommand(sqlOds, conexion)
            cmdActividades.ExecuteNonQuery()
        Next
        For Each t In actividad.ListaTipoActividad
            sqlTipo = $"INSERT INTO ACT_ASOCIADO_TACT VALUES ((SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}'),(SELECT CODTIPO FROM TIPO_ACTIVIDAD WHERE DESCRIPCION ='{t}'))"
            cmdActividades = New SqlCommand(sqlTipo, conexion)
            cmdActividades.ExecuteNonQuery()
        Next
        If actividad.ListaVoluntarios.Count > 0 Then
            For Each v In actividad.ListaVoluntarios
                sqlVoluntarios = $"INSERT INTO VOL_PARTICIPA_ACT VALUES ((SELECT CODVOL FROM VOLUNTARIO WHERE NOMBRE+' '+APELLIDO1+' '+APELLIDO2='{v}'),(SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}'))"
                cmdActividades = New SqlCommand(sqlVoluntarios, conexion)
                cmdActividades.ExecuteNonQuery()
            Next
        End If
        conexion.Close()
        Return True
    End Function

    Public Function MostrarActividades() As List(Of Actividad)
        conexion.Open()
        Dim sql As String = $"SELECT ACTIVIDAD.*,ORGANIZACION.NOMBRE AS [NOMORGS] FROM ACTIVIDAD INNER JOIN ORGANIZACION ON ACTIVIDAD.CODORG=ORGANIZACION.CODORG"
        Dim cmdListaActividades As New SqlCommand(sql, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim actividad As Actividad
        Dim actividades As New List(Of Actividad)
        Dim gestion As New Gestion_Actividad
        While drActividades.Read
            actividad = New Actividad(drActividades("Nombre"), drActividades("Duracion_Sesion"), drActividades("Fecha_Inicio"), drActividades("Fecha_Fin"), drActividades("N_MAX_VOLUNTARIOS"), drActividades("NomOrgs"), drActividades("Descripcion"), gestion.MostrarDesTipo(drActividades("Nombre")), gestion.MostrarDesOds(drActividades("Nombre")), gestion.MostrarDesVol(drActividades("Nombre")))
            actividades.Add(actividad)
        End While
        conexion.Close()
        Return actividades
    End Function

    Public Function MostrarDesTipo(nombre As String) As String
        conexion.Open()
        Dim sqlCod As String = $"SELECT CODTIPO FROM ACT_ASOCIADO_TACT WHERE CODACT=(SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{nombre}') "
        Dim cmdListaActividades As New SqlCommand(sqlCod, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim sqlNom As String
        Dim codTipoString As New List(Of String)
        Dim tipoString As New List(Of String)
        While drActividades.Read
            codTipoString.Add(drActividades("CODTIPO"))
        End While
        For Each t In codTipoString
            sqlNom = $"SELECT DESCRIPCION FROM TIPO_ACTIVIDAD WHERE CODTIPO='{t}'"
            cmdListaActividades = New SqlCommand(sqlNom, conexion)
            Dim drDesTipo As SqlDataReader = cmdListaActividades.ExecuteReader
            While drDesTipo.Read
                tipoString.Add(drDesTipo("DESCRIPCION"))
            End While
        Next
        conexion.Close()
        Return String.Join(", ", tipoString)
    End Function

    Public Function MostrarDesOds(nombre As String) As String
        conexion.Open()
        Dim sqlCod As String = $"SELECT NUMODS FROM ACT_PRACTICA_ODS WHERE CODACT=(SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{nombre}') "
        Dim cmdListaActividades As New SqlCommand(sqlCod, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim tipoString As New List(Of String)
        While drActividades.Read
            tipoString.Add(drActividades("NUMODS"))
        End While
        conexion.Close()
        Return String.Join(", ", tipoString)
    End Function


    Public Function MostrarDesVol(nombre As String) As String
        conexion.Open()
        Dim sqlCod As String = $"SELECT CODVOL FROM VOL_PARTICIPA_ACT WHERE CODACT=(SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{nombre}') "
        Dim cmdListaActividades As New SqlCommand(sqlCod, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        Dim sqlNom As String
        Dim codTipoString As New List(Of String)
        Dim tipoString As New List(Of String)
        While drActividades.Read
            codTipoString.Add(drActividades("CODVOL"))
        End While
        For Each t In codTipoString
            sqlNom = $"SELECT NOMBRE+' '+APELLIDO1+' '+APELLIDO2 AS VOLUNTARIO FROM VOLUNTARIO WHERE CODVOL='{t}'"
            cmdListaActividades = New SqlCommand(sqlNom, conexion)
            Dim drDesTipo As SqlDataReader = cmdListaActividades.ExecuteReader
            While drDesTipo.Read
                tipoString.Add(drDesTipo("VOLUNTARIO"))
            End While
        Next
        conexion.Close()
        Return String.Join(", ", tipoString)
    End Function




    Public Function MostrarOds() As List(Of String)
        conexion.Open()
        Dim sql As String = $"SELECT DESCRIPCION FROM ODS"
        Dim cmdListaODS As New SqlCommand(sql, conexion)
        Dim drODS As SqlDataReader = cmdListaODS.ExecuteReader
        Dim ods As New List(Of String)
        While drODS.Read
            ods.Add(drODS("DESCRIPCION"))
        End While
        conexion.Close()
        Return ods
    End Function

    Public Function MostrarTipo() As List(Of String)
        conexion.Open()
        Dim sql As String = $"SELECT DESCRIPCION FROM TIPO_ACTIVIDAD"
        Dim cmdListaTipo As New SqlCommand(sql, conexion)
        Dim drTipo As SqlDataReader = cmdListaTipo.ExecuteReader
        Dim tipo As New List(Of String)
        While drTipo.Read
            tipo.Add(drTipo("DESCRIPCION"))
        End While
        conexion.Close()
        Return tipo
    End Function

    Public Function MostrarVoluntarios() As List(Of String)
        conexion.Open()
        Dim sql As String = $"SELECT NOMBRE+' '+APELLIDO1+' '+APELLIDO2 AS VOLUNTARIO FROM VOLUNTARIO"
        Dim cmdListaVol As New SqlCommand(sql, conexion)
        Dim drVol As SqlDataReader = cmdListaVol.ExecuteReader
        Dim voluntarios As New List(Of String)
        While drVol.Read
            voluntarios.Add(drVol("Voluntario"))
        End While
        conexion.Close()
        Return voluntarios
    End Function

    Public Function MostrarOrgs() As List(Of String)
        conexion.Open()
        Dim sql As String = $"SELECT NOMBRE FROM ORGANIZACION"
        Dim cmdOrgs As New SqlCommand(sql, conexion)
        Dim drOrg As SqlDataReader = cmdOrgs.ExecuteReader
        Dim orgs As New List(Of String)
        While drOrg.Read
            orgs.Add(drOrg("NOMBRE"))
        End While
        conexion.Close()
        Return orgs
    End Function


    Public Function FiltrarActividad(nombre As String)
        conexion.Open()
        Dim sql As String = $"SELECT ACTIVIDAD.*,ORGANIZACION.NOMBRE AS [NOMORGS] FROM ACTIVIDAD INNER JOIN ORGANIZACION ON ACTIVIDAD.CODORG=ORGANIZACION.CODORG WHERE ACTIVIDAD.NOMBRE = '{nombre}'"
        Dim cmdListaActividades As New SqlCommand(sql, conexion)
        Dim drActividades As SqlDataReader = cmdListaActividades.ExecuteReader
        If Not drActividades.HasRows Then
            conexion.Close()
            Return Nothing
        End If
        Dim gestion As New Gestion_Actividad
        Dim actividadFiltro As New List(Of Actividad)
        While drActividades.Read
            actividadFiltro.Add(New Actividad(drActividades("Nombre"), drActividades("Duracion_Sesion"), drActividades("Fecha_Inicio"), drActividades("Fecha_Fin"), drActividades("N_MAX_VOLUNTARIOS"), drActividades("NomOrgs"), drActividades("Descripcion"), gestion.MostrarDesTipo(drActividades("Nombre")), gestion.MostrarDesOds(drActividades("Nombre")), gestion.MostrarDesVol(drActividades("Nombre"))))
        End While
        conexion.Close()
        Return actividadFiltro
    End Function
    Public Function ModificarActividad(actividad As Actividad, nombreAnterior As String)
        conexion.Open()
        Dim sqlnombre As String = $"SELECT NOMBRE FROM ACTIVIDAD WHERE NOMBRE='{nombreAnterior}'"
        Dim cmdNombre As New SqlCommand(sqlnombre, conexion)
        Dim drNombre As SqlDataReader = cmdNombre.ExecuteReader()
        If Not drNombre.HasRows Then
            conexion.Close()
            Return False
        End If
        Dim sql As String = $"UPDATE ACTIVIDAD SET NOMBRE = '{actividad.Nombre}', DURACION_SESION = '{actividad.Duracion}', FECHA_INICIO = '{actividad.FechaInicio}', FECHA_FIN = '{actividad.FechaFin}', N_MAX_VOLUNTARIOS = '{actividad.NumMaxVol}', CODORG = (SELECT CODORG FROM ORGANIZACION WHERE NOMBRE='{actividad.Organizacion}'), DESCRIPCION='{actividad.Descripcion}'  WHERE NOMBRE = '{nombreAnterior}'"
        Dim cmdActividades As New SqlCommand(sql, conexion)
        cmdActividades.ExecuteNonQuery()
        Dim sqlOds, sqlTipo, sqlVoluntarios As String
        sqlOds = $"DELETE FROM ACT_PRACTICA_ODS WHERE CODACT = (SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}')"
        cmdActividades = New SqlCommand(sqlOds, conexion)
        cmdActividades.ExecuteNonQuery()
        For Each o In actividad.ListaOds
            sqlOds = $"INSERT INTO ACT_PRACTICA_ODS VALUES ((SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}'),(SELECT NUMODS FROM ODS WHERE DESCRIPCION ='{o}'))"
            cmdActividades = New SqlCommand(sqlOds, conexion)
            cmdActividades.ExecuteNonQuery()
        Next
        sqlTipo = $"DELETE FROM ACT_ASOCIADO_TACT WHERE CODACT = (SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}')"
        cmdActividades = New SqlCommand(sqlTipo, conexion)
        cmdActividades.ExecuteNonQuery()
        For Each t In actividad.ListaTipoActividad
            sqlTipo = $"INSERT INTO ACT_ASOCIADO_TACT VALUES ((SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}'),(SELECT CODTIPO FROM TIPO_ACTIVIDAD WHERE DESCRIPCION ='{t}'))"
            cmdActividades = New SqlCommand(sqlTipo, conexion)
            cmdActividades.ExecuteNonQuery()
        Next
        sqlVoluntarios = $"DELETE FROM VOL_PARTICIPA_ACT WHERE CODACT = (SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}')"
        cmdActividades = New SqlCommand(sqlVoluntarios, conexion)
        cmdActividades.ExecuteNonQuery()
        If actividad.ListaVoluntarios.Count > 0 Then
            For Each v In actividad.ListaVoluntarios
                sqlVoluntarios = $"INSERT INTO VOL_PARTICIPA_ACT VALUES ((SELECT CODVOL FROM VOLUNTARIO WHERE NOMBRE+' '+APELLIDO1+' '+APELLIDO2='{v}'),(SELECT CODACT FROM ACTIVIDAD WHERE NOMBRE = '{actividad.Nombre}'))"
                cmdActividades = New SqlCommand(sqlVoluntarios, conexion)
                cmdActividades.ExecuteNonQuery()
            Next
        End If
        conexion.Close()
        Return True
    End Function

    Public Function BorrarActividad(nombreActividad As String)
        conexion.Open()
        Dim sql As String = $"DELETE FROM VOL_PARTICIPA_ACT WHERE VOL_PARTICIPA_ACT.CODACT=(SELECT ACTIVIDAD.CODACT FROM ACTIVIDAD WHERE ACTIVIDAD.NOMBRE= '{nombreActividad}')
DELETE FROM ACT_ASOCIADO_TACT WHERE ACT_ASOCIADO_TACT.CODACT=(SELECT ACTIVIDAD.CODACT FROM ACTIVIDAD WHERE ACTIVIDAD.NOMBRE= '{nombreActividad}')
DELETE FROM ACT_PRACTICA_ODS WHERE ACT_PRACTICA_ODS.CODACT=(SELECT ACTIVIDAD.CODACT FROM ACTIVIDAD WHERE ACTIVIDAD.NOMBRE= '{nombreActividad}')
DELETE FROM ACTIVIDAD WHERE ACTIVIDAD.NOMBRE= '{nombreActividad}'"
        Dim cmdActividad As New SqlCommand(sql, conexion)
        Dim drActividad As Integer = cmdActividad.ExecuteNonQuery
        conexion.Close()
        If drActividad = 0 Then
            Return False
        End If
        Return True
    End Function
End Class

