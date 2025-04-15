Public Class Tipo_Actividad
    Public Property CodTipo As Integer
    Public Property Descripcion As String

    Public Sub New(codtipo As Integer, descripcion As String)
        Me.CODTIPO = codtipo
        Me.Descripcion = descripcion
    End Sub
End Class
