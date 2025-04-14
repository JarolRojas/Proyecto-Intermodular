Imports Clases
Public Class Form1
    Dim gestion As New Gestion_Actividad
    Dim gestionBD As New Gestion_BBDD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActividades.DataSource = gestionBD.MostrarActividades

        Dim odsList As List(Of ODS) = gestionBD.ListarODS()

        For Each ods As ODS In odsList
            chklODS.Items.Add($"{ods.NumOds}  {ods.Descripcion}")
        Next
        Dim TaList As List(Of Tipo_Actividad) = gestionBD.ListarTipoAct()
        For Each ta As Tipo_Actividad In TaList
            chklTipoActividad.Items.Add($"{ta.Descripcion}")
        Next
        Dim orgList As List(Of Organizacion) = gestionBD.listarOrg()
        For Each org As Organizacion In orgList
            cbxOrganizacion.Items.Add($"{org.Nombre}")
        Next

    End Sub


    Private Sub btn_Borrar_Actividad_Click(sender As Object, e As EventArgs) Handles btn_Borrar_Actividad.Click
        Dim nombre As String
        Dim act As List(Of Actividad) = dgvActividades.DataSource

        nombre = txtNombre.Text.ToUpper

        If String.IsNullOrEmpty(nombre) Then
            MessageBox.Show("La actividad no puede estar vacía. Escriba el nombre", "Error")
        Else
            If gestion.BorrarActividad(nombre) = False Then
                MessageBox.Show("La actividad que intentas borrar no existe.", "Error")
            Else

                Dim resultado As DialogResult = MessageBox.Show("¿Desea eliminar ese registro?", "Confirmación", MessageBoxButtons.YesNo)

                If resultado = DialogResult.Yes Then
                    gestion.BorrarActividad(nombre)
                    MessageBox.Show($"La actividad {nombre} ha sido borrada con éxito")

                End If

                If resultado = DialogResult.No Then
                    MessageBox.Show("No borramos.")
                End If


            End If
        End If

        dgvActividades.DataSource = gestionBD.MostrarActividades
        txtNombre.Text = ""
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
        If controlDeErroresTxt(txtNombre, "No se ha introducido nombre", True) Then
            Exit Sub
        End If
        If txtDuracion.Text.Length < 5 Then
            MessageBox.Show("No se ha introducido duracion o no se han rellenado todos los campos")
            txtDuracion.Clear()
            txtDuracion.Focus()
            Exit Sub
        End If
        If controlDeErroresTxt(txtDuracion, "No se ha introducido nombre", True) Then
            Exit Sub
        End If
        If txtFechaInicio.Text < Date.Today Then
            MessageBox.Show("La fecha inicio no puede ser menor que hoy")
            txtFechaInicio.Clear()
            txtFechaInicio.Focus()
            Exit Sub
        End If
        If txtFechaInicio.Text >= txtFechaFin.Text Then
            MessageBox.Show("La fecha fin no puede ser menor a fecha inicio")
            txtFechaFin.Clear()
            txtFechaFin.Focus()
            Exit Sub
        End If
        If controlDeErroresTxt(txtNumMaxVol, "No se ha introducido numero máximo de voluntarios", True) Then
            Exit Sub
        End If
        If controlDeErroresTxt(txtNumMaxVol, "No se ha introducido descripción", True) Then
            Exit Sub
        End If
        If controlDeErroresTxt(cbxOrganizacion, "No se ha seleccionado organización", False) Then
            Exit Sub
        End If
        If controlDeErroresChk(chklTipoActividad, "No se ha seleccionado tipo de actividad") Then
            Exit Sub
        End If
        If controlDeErroresChk(chklODS, "No se ha seleccionado ODS") Then
            Exit Sub
        End If
        If controlDeErroresTxt(txtDescripcion, "No se ha introducido descripción", True) Then
            Exit Sub
        End If

        Dim duracion As TimeSpan

        TimeSpan.TryParse(txtDuracion.Text, duracion)

        Dim actividad As New Actividad(txtNombre.Text, duracion, txtFechaInicio.Text, txtFechaFin.Text, txtNumMaxVol.Text, 2, txtDescripcion.Text)

        gestion.AnadirActividad(actividad)
        dgvActividades.DataSource = gestionBD.MostrarActividades
    End Sub

    Public Function controlDeErroresTxt(campo As Object, mensaje As String, limpiar As Boolean) As Boolean
        If String.IsNullOrWhiteSpace(campo.text) Then
            MessageBox.Show(mensaje)
            If limpiar = True Then
                campo.Clear()
            End If
            campo.Focus()
            Return True
        End If
        Return False
    End Function

    Public Function controlDeErroresChk(campo As Object, mensaje As String) As Boolean
        If campo.checkeditems.count = 0 Then
            MessageBox.Show(mensaje)
            campo.Focus()
            Return True
        End If
        Return False
    End Function

End Class
