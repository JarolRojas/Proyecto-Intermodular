Public Class ODS
    Public Property NumOds As Integer
    Public Property Descripcion As String

    Public Sub New(numOds As Integer, descripcion As String)
        Me.NumOds = numOds
        Me.Descripcion = descripcion
    End Sub
End Class
