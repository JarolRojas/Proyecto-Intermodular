Public Class Organizacion
    Public Property CodOrg As Integer
    Public Property Nombre As String
    Public Property Tipo_Org As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property Sector As String
    Public Property Ambito As String
    Public Property Descripcion As String

    Public Sub New(codOrg As Integer, nombre As String, tipoOrg As String, correo As String, telefono As String, sector As String, ambito As String, descripcion As String)
        Me.CodOrg = codOrg
        Me.Nombre = nombre
        Me.Tipo_Org = tipoOrg
        Me.Correo = correo
        Me.Telefono = telefono
        Me.Sector = sector
        Me.Ambito = ambito
        Me.Descripcion = descripcion
    End Sub

End Class
