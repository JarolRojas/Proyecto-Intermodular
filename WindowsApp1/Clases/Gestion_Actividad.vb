Imports System.Data.SqlClient

Public Class Gestion_Actividad

    Private servidor = "ASUSMAITE\SQLEXPRESS" ' Aquí pondremos el nombre de nuestro servidor de SqlServer

    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = Voluntariado;Integrated Security = SSPI; MultipleActiveResultSets=true" ' Cadena de conexión para indicar la base de datos, en este caso Estado, con la que vamos a conectar


    Public Function MostrarActividades(actividad As String) As String
        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()
        Dim consultaSql As String = $""
    End Function


End Class
