<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheckedListBox6 = New System.Windows.Forms.CheckedListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_MAnadir_actividad = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox()
        Me.btn_MBorrar_Actividad = New System.Windows.Forms.Button()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.btn_MModificar_actividad = New System.Windows.Forms.Button()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckedListBox5 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(126, 298)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(198, 66)
        Me.TextBox4.TabIndex = 56
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
        Me.CheckedListBox6.Size = New System.Drawing.Size(298, 124)
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
        'btn_MAnadir_actividad
        '
        Me.btn_MAnadir_actividad.Location = New System.Drawing.Point(1083, 435)
        Me.btn_MAnadir_actividad.Name = "btn_MAnadir_actividad"
        Me.btn_MAnadir_actividad.Size = New System.Drawing.Size(225, 44)
        Me.btn_MAnadir_actividad.TabIndex = 33
        Me.btn_MAnadir_actividad.Text = "Añadir Actividad"
        Me.btn_MAnadir_actividad.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1083, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 41)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Filtrar Actividad(es)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"AMAVIR", "ANA", "CUATROVIENTOS", "UNZUTXIKI"})
        Me.ComboBox2.Location = New System.Drawing.Point(381, 251)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox2.TabIndex = 51
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.Location = New System.Drawing.Point(381, 206)
        Me.MaskedTextBox8.Mask = "12"
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(114, 20)
        Me.MaskedTextBox8.TabIndex = 50
        '
        'btn_MBorrar_Actividad
        '
        Me.btn_MBorrar_Actividad.Location = New System.Drawing.Point(1083, 695)
        Me.btn_MBorrar_Actividad.Name = "btn_MBorrar_Actividad"
        Me.btn_MBorrar_Actividad.Size = New System.Drawing.Size(225, 44)
        Me.btn_MBorrar_Actividad.TabIndex = 38
        Me.btn_MBorrar_Actividad.Text = "Borrar Actividad"
        Me.btn_MBorrar_Actividad.UseVisualStyleBackColor = True
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.Location = New System.Drawing.Point(381, 164)
        Me.MaskedTextBox7.Mask = "00/00/0000"
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(114, 20)
        Me.MaskedTextBox7.TabIndex = 49
        Me.MaskedTextBox7.ValidatingType = GetType(Date)
        '
        'btn_MModificar_actividad
        '
        Me.btn_MModificar_actividad.Location = New System.Drawing.Point(1083, 598)
        Me.btn_MModificar_actividad.Name = "btn_MModificar_actividad"
        Me.btn_MModificar_actividad.Size = New System.Drawing.Size(225, 44)
        Me.btn_MModificar_actividad.TabIndex = 36
        Me.btn_MModificar_actividad.Text = "Modificar Actividad"
        Me.btn_MModificar_actividad.UseVisualStyleBackColor = True
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(126, 251)
        Me.MaskedTextBox6.Mask = "00/00/0000"
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(114, 20)
        Me.MaskedTextBox6.TabIndex = 48
        Me.MaskedTextBox6.ValidatingType = GetType(Date)
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(126, 206)
        Me.MaskedTextBox5.Mask = "00:00"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(114, 20)
        Me.MaskedTextBox5.TabIndex = 47
        Me.MaskedTextBox5.ValidatingType = GetType(Date)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 46
        '
        'CheckedListBox5
        '
        Me.CheckedListBox5.FormattingEnabled = True
        Me.CheckedListBox5.Items.AddRange(New Object() {"01 FIN DE LA POBREZA", "02 HAMBRE CERO", "03 SALUD Y BIENESTAR", "04 EDUCACIÓN DE CALIDAD", "05 IGUALDAD DE GÉNERO", "06 AGUA LIMPIA Y SANEAMIENTO", "07 ENERGÍA ASEQUIBLE Y NO CONTAMINANTE", "08 TRABAJO DECENTE Y CRECIMIENTO ECONÓMICO", "09 INDUSTRIA, INNOVACIÓN E INFRAESTRUCTURA", "10 REDUCCIÓN DE LAS DESIGUALDADES", "11 CIUDADES Y COMUNIDADES SOSTENIBLES", "12 PRODUCCIÓN Y CONSUMO RESPONSABLES", "13 ACCIÓN POR EL CLIMA", "14 VIDA SUBMARINA", "15 VIDA DE ECOSISTEMAS TERRESTRES", "16 PAZ, JUSTICIA E INSTITUCIONES SÓLIDAS", "17 ALIANZAS PARA LOGRAR LOS OBJETIVOS"})
        Me.CheckedListBox5.Location = New System.Drawing.Point(725, 160)
        Me.CheckedListBox5.Name = "CheckedListBox5"
        Me.CheckedListBox5.Size = New System.Drawing.Size(298, 124)
        Me.CheckedListBox5.TabIndex = 45
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.Items.AddRange(New Object() {"Digital", "Salud", "Educativo", "Ambiental", "Deportivo", "Social", "Cultural", "Técnico"})
        Me.CheckedListBox4.Location = New System.Drawing.Point(536, 160)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(162, 124)
        Me.CheckedListBox4.TabIndex = 44
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 405)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 364)
        Me.DataGridView1.TabIndex = 32
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
        Me.ClientSize = New System.Drawing.Size(1360, 736)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CheckedListBox6)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btn_MAnadir_actividad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.MaskedTextBox8)
        Me.Controls.Add(Me.btn_MBorrar_Actividad)
        Me.Controls.Add(Me.MaskedTextBox7)
        Me.Controls.Add(Me.btn_MModificar_actividad)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckedListBox5)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CheckedListBox6 As CheckedListBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_MAnadir_actividad As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MaskedTextBox8 As MaskedTextBox
    Friend WithEvents btn_MBorrar_Actividad As Button
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents btn_MModificar_actividad As Button
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckedListBox5 As CheckedListBox
    Friend WithEvents CheckedListBox4 As CheckedListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
