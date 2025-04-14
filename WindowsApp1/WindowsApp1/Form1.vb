Imports Clases
Public Class Form1
    Dim gestion As New Gestion_Actividad
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActividades.DataSource = gestion.MostrarActividades
        Dim orgs As List(Of String) = gestion.MostrarOrgs
        Dim ods As List(Of String) = gestion.MostrarOds
        Dim tipo As List(Of String) = gestion.MostrarTipo
        Dim voluntarios As List(Of String) = gestion.MostrarVoluntarios
        chkTipoActividad.Items.AddRange(tipo.ToArray)
        chklODS.Items.AddRange(ods.ToArray)
        chkVoluntarios.Items.AddRange(voluntarios.ToArray)
        cbxOrganizacion.Items.AddRange(orgs.ToArray)
        txtFechaInicio.Text = Today
        txtFechaFin.Text = Today
    End Sub

    Private Sub btn_Borrar_Actividad_Click(sender As Object, e As EventArgs) Handles btn_Borrar_Actividad.Click
        Dim respuesta As String = InputBox("Introduce el nombre de la actividad a eliminar", "Entrada de usuario")
        Dim resultado As Boolean = gestion.BorrarActividad(respuesta)
        If resultado Then
            MessageBox.Show($"Actividad ""{txtNombre.Text}"" eliminada")
        Else
            MessageBox.Show($"Actividad ""{txtNombre.Text}"" no existe")
            txtNombre.Clear()
        End If
    End Sub

    Private Sub btn_Añadir_actividad_Click(sender As Object, e As EventArgs) Handles btn_Añadir_actividad.Click
        If controlDeErroresTxt(txtNombre, "No se ha introducido nombre", True) Then
            Exit Sub
        End If
        Dim duracion As TimeSpan
        If Not TimeSpan.TryParse(txtDuracion.Text, duracion) Then
            MessageBox.Show("No se ha introducido duracion o no se cumple el formato")
            txtDuracion.Clear()
            txtDuracion.Focus()
            Exit Sub
        End If
        Dim fechaInicio, fechaFin As Date
        If Not Date.TryParse(txtFechaInicio.Text, fechaInicio) OrElse fechaInicio < Date.Today Then
            MessageBox.Show("La fecha inicio es anterior a hoy o no se cumple el formato")
            txtFechaInicio.Text = Today
            txtFechaInicio.Focus()
            Exit Sub
        End If
        If Not Date.TryParse(txtFechaFin.Text, fechaFin) OrElse fechaInicio > fechaFin Then
            MessageBox.Show("La fecha fin es anterior a fecha inicio o no se cumple el formato")
            txtFechaFin.Text = Today
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
        If controlDeErroresChk(chkTipoActividad, "No se ha seleccionado tipo de actividad") Then
            Exit Sub
        End If
        If controlDeErroresChk(chklODS, "No se ha seleccionado ODS") Then
            Exit Sub
        End If
        If controlDeErroresTxt(txtDescripcion, "No se ha introducido descripción", True) Then
            Exit Sub
        End If

        Dim actividad As New Actividad(txtNombre.Text, duracion, txtFechaInicio.Text, txtFechaFin.Text, txtNumMaxVol.Text, cbxOrganizacion.Text, txtDescripcion.Text)
        For Each t In chkTipoActividad.CheckedItems
            actividad.AñadirTipo(t)
        Next
        For Each o In chklODS.CheckedItems
            actividad.AñadirOds(o)
        Next
        If chkVoluntarios.CheckedItems.Count > 0 Then
            For Each v In chkVoluntarios.CheckedItems
                actividad.AñadirVoluntarios(v)
            Next
        End If

        If gestion.AnadirActividad(actividad) Then
            MessageBox.Show($"Actividad ""{actividad.Nombre}"" añadida")
        Else
            MessageBox.Show($"Ya existe una actividad de nombre ""{actividad.Nombre}""")
        End If

        dgvActividades.DataSource = gestion.MostrarActividades
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

    Private Sub btn_Modificar_actividad_Click(sender As Object, e As EventArgs) Handles btn_Modificar_actividad.Click
        If controlDeErroresTxt(txtNombre, "No se ha introducido nombre", True) Then
            Exit Sub
        End If
        Dim duracion As TimeSpan
        If Not TimeSpan.TryParse(txtDuracion.Text, duracion) Then
            MessageBox.Show("No se ha introducido duracion o no se han rellenado todos los campos")
            txtDuracion.Clear()
            txtDuracion.Focus()
            Exit Sub
        End If
        Dim fechaInicio, fechaFin As Date
        If Not Date.TryParse(txtFechaInicio.Text, fechaInicio) OrElse fechaInicio < Date.Today Then
            MessageBox.Show("La fecha inicio es anterior a hoy o no se cumple el formato")
            txtFechaInicio.Clear()
            txtFechaInicio.Focus()
            Exit Sub
        End If
        If Not Date.TryParse(txtFechaFin.Text, fechaFin) OrElse fechaInicio > fechaFin Then
            MessageBox.Show("La fecha fin es anterior a fecha inicio o no se cumple el formato")
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
        If controlDeErroresChk(chkTipoActividad, "No se ha seleccionado tipo de actividad") Then
            Exit Sub
        End If
        If controlDeErroresChk(chklODS, "No se ha seleccionado ODS") Then
            Exit Sub
        End If
        If controlDeErroresTxt(txtDescripcion, "No se ha introducido descripción", True) Then
            Exit Sub
        End If

        Dim actividad As New Actividad(txtNombre.Text, duracion, txtFechaInicio.Text, txtFechaFin.Text, txtNumMaxVol.Text, cbxOrganizacion.Text, txtDescripcion.Text)
        For Each t In chkTipoActividad.CheckedItems
            actividad.AñadirTipo(t)
        Next
        For Each o In chklODS.CheckedItems
            actividad.AñadirOds(o)
        Next
        If chkVoluntarios.CheckedItems.Count > 0 Then
            For Each v In chkVoluntarios.CheckedItems
                actividad.AñadirVoluntarios(v)
            Next
        End If
        Dim respuesta As String = InputBox("Introduce el nombre de la actividad a modificar", "Entrada de usuario")
        Dim resultado As Boolean = gestion.ModificarActividad(actividad, respuesta)
        If resultado Then
            MessageBox.Show($"Actividad ""{respuesta}"" modificada")
        Else
            MessageBox.Show($"Actividad ""{respuesta}"" no existe")
        End If

        dgvActividades.DataSource = gestion.MostrarActividades
    End Sub
End Class
