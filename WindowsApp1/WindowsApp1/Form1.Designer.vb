﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheckedListBox6 = New System.Windows.Forms.CheckedListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_Añadir_actividad = New System.Windows.Forms.Button()
        Me.btn_Filtrar_actividad = New System.Windows.Forms.Button()
        Me.cbxOrganizacion = New System.Windows.Forms.ComboBox()
        Me.txtNumMaxVol = New System.Windows.Forms.MaskedTextBox()
        Me.btn_Borrar_Actividad = New System.Windows.Forms.Button()
        Me.txtFechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.btn_Modificar_actividad = New System.Windows.Forms.Button()
        Me.txtFechaInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txtDuracion = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.chklODS = New System.Windows.Forms.CheckedListBox()
        Me.chklTipoActividad = New System.Windows.Forms.CheckedListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(126, 298)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(198, 66)
        Me.txtDescripcion.TabIndex = 56
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(51, 298)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Descripción"
        '
        'CheckedListBox6
        '
        Me.CheckedListBox6.FormattingEnabled = True
        Me.CheckedListBox6.Location = New System.Drawing.Point(1049, 160)
        Me.CheckedListBox6.Name = "CheckedListBox6"
        Me.CheckedListBox6.Size = New System.Drawing.Size(298, 109)
        Me.CheckedListBox6.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1170, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Voluntarios"
        '
        'btn_Añadir_actividad
        '
        Me.btn_Añadir_actividad.Location = New System.Drawing.Point(1083, 435)
        Me.btn_Añadir_actividad.Name = "btn_Añadir_actividad"
        Me.btn_Añadir_actividad.Size = New System.Drawing.Size(225, 44)
        Me.btn_Añadir_actividad.TabIndex = 33
        Me.btn_Añadir_actividad.Text = "Añadir Actividad"
        Me.btn_Añadir_actividad.UseVisualStyleBackColor = True
        '
        'btn_Filtrar_actividad
        '
        Me.btn_Filtrar_actividad.Location = New System.Drawing.Point(1083, 510)
        Me.btn_Filtrar_actividad.Name = "btn_Filtrar_actividad"
        Me.btn_Filtrar_actividad.Size = New System.Drawing.Size(225, 41)
        Me.btn_Filtrar_actividad.TabIndex = 52
        Me.btn_Filtrar_actividad.Text = "Filtrar Actividad(es)"
        Me.btn_Filtrar_actividad.UseVisualStyleBackColor = True
        '
        'cbxOrganizacion
        '
        Me.cbxOrganizacion.FormattingEnabled = True
        Me.cbxOrganizacion.Items.AddRange(New Object() {"AMAVIR", "ANA", "CUATROVIENTOS", "UNZUTXIKI"})
        Me.cbxOrganizacion.Location = New System.Drawing.Point(381, 251)
        Me.cbxOrganizacion.Name = "cbxOrganizacion"
        Me.cbxOrganizacion.Size = New System.Drawing.Size(114, 21)
        Me.cbxOrganizacion.TabIndex = 51
        '
        'txtNumMaxVol
        '
        Me.txtNumMaxVol.Location = New System.Drawing.Point(381, 206)
        Me.txtNumMaxVol.Mask = "12"
        Me.txtNumMaxVol.Name = "txtNumMaxVol"
        Me.txtNumMaxVol.Size = New System.Drawing.Size(114, 20)
        Me.txtNumMaxVol.TabIndex = 50
        '
        'btn_Borrar_Actividad
        '
        Me.btn_Borrar_Actividad.Location = New System.Drawing.Point(1083, 695)
        Me.btn_Borrar_Actividad.Name = "btn_Borrar_Actividad"
        Me.btn_Borrar_Actividad.Size = New System.Drawing.Size(225, 44)
        Me.btn_Borrar_Actividad.TabIndex = 38
        Me.btn_Borrar_Actividad.Text = "Borrar Actividad"
        Me.btn_Borrar_Actividad.UseVisualStyleBackColor = True
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(381, 164)
        Me.txtFechaFin.Mask = "00/00/0000"
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaFin.TabIndex = 49
        Me.txtFechaFin.ValidatingType = GetType(Date)
        '
        'btn_Modificar_actividad
        '
        Me.btn_Modificar_actividad.Location = New System.Drawing.Point(1083, 598)
        Me.btn_Modificar_actividad.Name = "btn_Modificar_actividad"
        Me.btn_Modificar_actividad.Size = New System.Drawing.Size(225, 44)
        Me.btn_Modificar_actividad.TabIndex = 36
        Me.btn_Modificar_actividad.Text = "Modificar Actividad"
        Me.btn_Modificar_actividad.UseVisualStyleBackColor = True
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Location = New System.Drawing.Point(126, 251)
        Me.txtFechaInicio.Mask = "00/00/0000"
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaInicio.TabIndex = 48
        Me.txtFechaInicio.ValidatingType = GetType(Date)
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(126, 206)
        Me.txtDuracion.Mask = "00:00"
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(114, 20)
        Me.txtDuracion.TabIndex = 47
        Me.txtDuracion.ValidatingType = GetType(Date)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(126, 164)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(114, 20)
        Me.txtNombre.TabIndex = 46
        '
        'chklODS
        '
        Me.chklODS.FormattingEnabled = True
        Me.chklODS.Items.AddRange(New Object() {"01 FIN DE LA POBREZA", "02 HAMBRE CERO", "03 SALUD Y BIENESTAR", "04 EDUCACIÓN DE CALIDAD", "05 IGUALDAD DE GÉNERO", "06 AGUA LIMPIA Y SANEAMIENTO", "07 ENERGÍA ASEQUIBLE Y NO CONTAMINANTE", "08 TRABAJO DECENTE Y CRECIMIENTO ECONÓMICO", "09 INDUSTRIA, INNOVACIÓN E INFRAESTRUCTURA", "10 REDUCCIÓN DE LAS DESIGUALDADES", "11 CIUDADES Y COMUNIDADES SOSTENIBLES", "12 PRODUCCIÓN Y CONSUMO RESPONSABLES", "13 ACCIÓN POR EL CLIMA", "14 VIDA SUBMARINA", "15 VIDA DE ECOSISTEMAS TERRESTRES", "16 PAZ, JUSTICIA E INSTITUCIONES SÓLIDAS", "17 ALIANZAS PARA LOGRAR LOS OBJETIVOS"})
        Me.chklODS.Location = New System.Drawing.Point(725, 160)
        Me.chklODS.Name = "chklODS"
        Me.chklODS.Size = New System.Drawing.Size(298, 109)
        Me.chklODS.TabIndex = 45
        '
        'chklTipoActividad
        '
        Me.chklTipoActividad.FormattingEnabled = True
        Me.chklTipoActividad.Items.AddRange(New Object() {"Digital", "Salud", "Educativo", "Ambiental", "Deportivo", "Social", "Cultural", "Técnico"})
        Me.chklTipoActividad.Location = New System.Drawing.Point(536, 160)
        Me.chklTipoActividad.Name = "chklTipoActividad"
        Me.chklTipoActividad.Size = New System.Drawing.Size(162, 109)
        Me.chklTipoActividad.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(305, 254)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Organización"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(260, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Número de Voluntarios"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(864, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "ODS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(320, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Fecha Fin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Fecha Inicio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(567, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Tipo de Actividad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(64, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Duracion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Nombre"
        '
        'dgvActividades
        '
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Location = New System.Drawing.Point(67, 405)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.RowHeadersWidth = 51
        Me.dgvActividades.Size = New System.Drawing.Size(945, 364)
        Me.dgvActividades.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 73)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "ACTIVIDADES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 783)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CheckedListBox6)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btn_Añadir_actividad)
        Me.Controls.Add(Me.btn_Filtrar_actividad)
        Me.Controls.Add(Me.cbxOrganizacion)
        Me.Controls.Add(Me.txtNumMaxVol)
        Me.Controls.Add(Me.btn_Borrar_Actividad)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.btn_Modificar_actividad)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chklODS)
        Me.Controls.Add(Me.chklTipoActividad)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvActividades)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CheckedListBox6 As CheckedListBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_Añadir_actividad As Button
    Friend WithEvents btn_Filtrar_actividad As Button
    Friend WithEvents cbxOrganizacion As ComboBox
    Friend WithEvents txtNumMaxVol As MaskedTextBox
    Friend WithEvents btn_Borrar_Actividad As Button
    Friend WithEvents txtFechaFin As MaskedTextBox
    Friend WithEvents btn_Modificar_actividad As Button
    Friend WithEvents txtFechaInicio As MaskedTextBox
    Friend WithEvents txtDuracion As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents chklODS As CheckedListBox
    Friend WithEvents chklTipoActividad As CheckedListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents Label1 As Label
End Class
