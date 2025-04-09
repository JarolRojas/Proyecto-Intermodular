Imports Clases
Public Class Form1
    Dim gestion As New Gestion_Actividad
    Dim gestionBD As New Gestion_BBDD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActividades.DataSource = gestionBD.MostrarActividades
    End Sub

    'Private Sub btn_Borrar_Actividad_Click(sender As Object, e As EventArgs) Handles btn_Borrar_Actividad.Click
    '    If String.IsNullOrWhiteSpace(txtNombre.Text) Then
    '        MessageBox.Show("No se ha introducido nombre")
    '        txtNombre.Clear()
    '        txtNombre.Focus()
    '    End If
    '    Dim resultado As Boolean = gestion.BorrarActividad(txtNombre.Text)
    '    If resultado Then
    '        MessageBox.Show($"Actividad {txtNombre.Text} eliminada")
    '        txtNombre.Clear()
    '    Else
    '        MessageBox.Show($"Actividad {txtNombre.Text} no existe")
    '        txtNombre.Clear()
    '    End If
    'End Sub

    Private Sub btn_Añadir_actividad_Click(sender As Object, e As EventArgs) Handles btn_Añadir_actividad.Click
        controlDeErroresTxt(txtNombre, "No se ha introducido nombre")
        controlDeErroresTxt(txtDuracion, "No se ha introducido nombre")
        controlDeErroresTxt(txtFechaInicio, "No se ha introducido fecha inicio")
        controlDeErroresTxt(txtFechaFin, "No se ha introducido fecha fin")
        If txtFechaInicio.Text >= txtFechaFin.Text Then
            MessageBox.Show("La fecha fin no puede ser menor que la fecha inicio")
            txtFechaFin.Clear()
            txtFechaFin.Focus()
        End If
        controlDeErroresTxt(txtNumMaxVol, "No se ha introducido numero máximo de voluntarios")
        controlDeErroresTxt(txtNumMaxVol, "No se ha introducido descripción")
    End Sub

    Public Sub controlDeErroresTxt(campo As Object, mensaje As String)
        If String.IsNullOrWhiteSpace(campo.text) Then
            MessageBox.Show(mensaje)
            campo.Clear()
            campo.Focus()
        End If
    End Sub

End Class
