Imports System.Data.SqlClient

Public Class Gestion_Actividad
    Private servidor = ""
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = Estado; Integrated Security = SSPI; MultiplerActiveResultSets = true"
    Dim conexion As New SqlConnection(cadenaConexion)




End Class
