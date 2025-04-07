Imports Clases
Public Class Form1
    Dim gestion As New Gestion_Actividad
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActividades.DataSource = gestion.MostrarActividades
    End Sub

    Private Sub btn_Borrar_Actividad_Click(sender As Object, e As EventArgs) Handles btn_Borrar_Actividad.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("No se ha introducido nombre")
            txtNombre.Clear()
            txtNombre.Focus()
        End If
        Dim resultado As Boolean = gestion.BorrarActividad(txtNombre.Text)
        If resultado Then
            MessageBox.Show($"Actividad {txtNombre.Text} eliminada")
            txtNombre.Clear()
        Else
            MessageBox.Show($"Actividad {txtNombre.Text} no existe")
            txtNombre.Clear()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
