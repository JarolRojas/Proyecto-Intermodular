Public Class Ciclo
    Public Property CodCiclo As String
    Public Property Nombre As String
    Public Property Curso As Integer

    Public Sub New(codCiclo As String, nombre As String, curso As Integer)
        Me.CodCiclo = codCiclo
        Me.Nombre = nombre
        Me.Curso = curso
    End Sub
End Class
