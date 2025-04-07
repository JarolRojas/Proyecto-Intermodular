Public Class Organizacion
    Public Property Nombre As String
    Public Property TipoOrg As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property Sector As String
    Public Property Ambito As String
    Public Property Descripcion As String

    Public Sub New(nombre As String, tipoOrg As String, correo As String, telefono As String, sector As String, ambito As String, descripcion As String)
        Me.Nombre = nombre
        Me.TipoOrg = tipoOrg
        Me.Correo = correo
        Me.Telefono = telefono
        Me.Sector = sector
        Me.Ambito = ambito
        Me.Descripcion = descripcion
    End Sub


    Public Function ListaOrganizaciones(nomOrg As String)

    End Function
End Class
