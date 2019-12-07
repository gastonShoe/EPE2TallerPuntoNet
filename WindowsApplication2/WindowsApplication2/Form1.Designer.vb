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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Agregar = New System.Windows.Forms.TabPage()
        Me.Enviar = New System.Windows.Forms.Button()
        Me.Sexo = New System.Windows.Forms.Label()
        Me.ApellidoMaterno = New System.Windows.Forms.Label()
        Me.ApellidoPaterno = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Código = New System.Windows.Forms.Label()
        Me.insertarSexo = New System.Windows.Forms.TextBox()
        Me.insertarAM = New System.Windows.Forms.TextBox()
        Me.insertarAP = New System.Windows.Forms.TextBox()
        Me.insertarNombre = New System.Windows.Forms.TextBox()
        Me.insertarCodigo = New System.Windows.Forms.TextBox()
        Me.Modificar = New System.Windows.Forms.TabPage()
        Me.editarSexo = New System.Windows.Forms.TextBox()
        Me.editarAM = New System.Windows.Forms.TextBox()
        Me.editarAP = New System.Windows.Forms.TextBox()
        Me.editarNombre = New System.Windows.Forms.TextBox()
        Me.Sexo2 = New System.Windows.Forms.Label()
        Me.ApellidoMaterno2 = New System.Windows.Forms.Label()
        Me.ApellidoPaterno2 = New System.Windows.Forms.Label()
        Me.Nombre2 = New System.Windows.Forms.Label()
        Me.editarCodigo = New System.Windows.Forms.TextBox()
        Me.Comprobar = New System.Windows.Forms.Button()
        Me.Código2 = New System.Windows.Forms.Label()
        Me.Borrar = New System.Windows.Forms.TabPage()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Código3 = New System.Windows.Forms.Label()
        Me.BorrarCodigo = New System.Windows.Forms.TextBox()
        Me.VerDatos = New System.Windows.Forms.TabPage()
        Me.Cargar = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Editar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Agregar.SuspendLayout()
        Me.Modificar.SuspendLayout()
        Me.Borrar.SuspendLayout()
        Me.VerDatos.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Agregar)
        Me.TabControl1.Controls.Add(Me.Modificar)
        Me.TabControl1.Controls.Add(Me.Borrar)
        Me.TabControl1.Controls.Add(Me.VerDatos)
        Me.TabControl1.Location = New System.Drawing.Point(13, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(420, 344)
        Me.TabControl1.TabIndex = 0
        '
        'Agregar
        '
        Me.Agregar.Controls.Add(Me.Enviar)
        Me.Agregar.Controls.Add(Me.Sexo)
        Me.Agregar.Controls.Add(Me.ApellidoMaterno)
        Me.Agregar.Controls.Add(Me.ApellidoPaterno)
        Me.Agregar.Controls.Add(Me.Nombre)
        Me.Agregar.Controls.Add(Me.Código)
        Me.Agregar.Controls.Add(Me.insertarSexo)
        Me.Agregar.Controls.Add(Me.insertarAM)
        Me.Agregar.Controls.Add(Me.insertarAP)
        Me.Agregar.Controls.Add(Me.insertarNombre)
        Me.Agregar.Controls.Add(Me.insertarCodigo)
        Me.Agregar.Location = New System.Drawing.Point(4, 22)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Padding = New System.Windows.Forms.Padding(3)
        Me.Agregar.Size = New System.Drawing.Size(411, 299)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Enviar
        '
        Me.Enviar.Location = New System.Drawing.Point(172, 252)
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(221, 23)
        Me.Enviar.TabIndex = 10
        Me.Enviar.Text = "Enviar"
        Me.Enviar.UseVisualStyleBackColor = True
        '
        'Sexo
        '
        Me.Sexo.AutoSize = True
        Me.Sexo.Location = New System.Drawing.Point(23, 215)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(31, 13)
        Me.Sexo.TabIndex = 9
        Me.Sexo.Text = "Sexo"
        '
        'ApellidoMaterno
        '
        Me.ApellidoMaterno.AutoSize = True
        Me.ApellidoMaterno.Location = New System.Drawing.Point(23, 170)
        Me.ApellidoMaterno.Name = "ApellidoMaterno"
        Me.ApellidoMaterno.Size = New System.Drawing.Size(86, 13)
        Me.ApellidoMaterno.TabIndex = 8
        Me.ApellidoMaterno.Text = "Apellido Materno"
        '
        'ApellidoPaterno
        '
        Me.ApellidoPaterno.AutoSize = True
        Me.ApellidoPaterno.Location = New System.Drawing.Point(22, 120)
        Me.ApellidoPaterno.Name = "ApellidoPaterno"
        Me.ApellidoPaterno.Size = New System.Drawing.Size(84, 13)
        Me.ApellidoPaterno.TabIndex = 7
        Me.ApellidoPaterno.Text = "Apellido Paterno"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(23, 74)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 6
        Me.Nombre.Text = "Nombre"
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Location = New System.Drawing.Point(23, 28)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(40, 13)
        Me.Código.TabIndex = 5
        Me.Código.Text = "Código"
        '
        'insertarSexo
        '
        Me.insertarSexo.Location = New System.Drawing.Point(172, 208)
        Me.insertarSexo.Name = "insertarSexo"
        Me.insertarSexo.Size = New System.Drawing.Size(221, 20)
        Me.insertarSexo.TabIndex = 4
        '
        'insertarAM
        '
        Me.insertarAM.Location = New System.Drawing.Point(172, 163)
        Me.insertarAM.Name = "insertarAM"
        Me.insertarAM.Size = New System.Drawing.Size(221, 20)
        Me.insertarAM.TabIndex = 3
        '
        'insertarAP
        '
        Me.insertarAP.Location = New System.Drawing.Point(172, 113)
        Me.insertarAP.Name = "insertarAP"
        Me.insertarAP.Size = New System.Drawing.Size(221, 20)
        Me.insertarAP.TabIndex = 2
        '
        'insertarNombre
        '
        Me.insertarNombre.Location = New System.Drawing.Point(172, 67)
        Me.insertarNombre.Name = "insertarNombre"
        Me.insertarNombre.Size = New System.Drawing.Size(221, 20)
        Me.insertarNombre.TabIndex = 1
        '
        'insertarCodigo
        '
        Me.insertarCodigo.Location = New System.Drawing.Point(172, 21)
        Me.insertarCodigo.Name = "insertarCodigo"
        Me.insertarCodigo.Size = New System.Drawing.Size(221, 20)
        Me.insertarCodigo.TabIndex = 0
        '
        'Modificar
        '
        Me.Modificar.Controls.Add(Me.Editar)
        Me.Modificar.Controls.Add(Me.editarSexo)
        Me.Modificar.Controls.Add(Me.editarAM)
        Me.Modificar.Controls.Add(Me.editarAP)
        Me.Modificar.Controls.Add(Me.editarNombre)
        Me.Modificar.Controls.Add(Me.Sexo2)
        Me.Modificar.Controls.Add(Me.ApellidoMaterno2)
        Me.Modificar.Controls.Add(Me.ApellidoPaterno2)
        Me.Modificar.Controls.Add(Me.Nombre2)
        Me.Modificar.Controls.Add(Me.editarCodigo)
        Me.Modificar.Controls.Add(Me.Comprobar)
        Me.Modificar.Controls.Add(Me.Código2)
        Me.Modificar.Location = New System.Drawing.Point(4, 22)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Padding = New System.Windows.Forms.Padding(3)
        Me.Modificar.Size = New System.Drawing.Size(412, 318)
        Me.Modificar.TabIndex = 2
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'editarSexo
        '
        Me.editarSexo.Location = New System.Drawing.Point(161, 236)
        Me.editarSexo.Name = "editarSexo"
        Me.editarSexo.Size = New System.Drawing.Size(231, 20)
        Me.editarSexo.TabIndex = 10
        '
        'editarAM
        '
        Me.editarAM.Location = New System.Drawing.Point(161, 192)
        Me.editarAM.Name = "editarAM"
        Me.editarAM.Size = New System.Drawing.Size(231, 20)
        Me.editarAM.TabIndex = 9
        '
        'editarAP
        '
        Me.editarAP.Location = New System.Drawing.Point(161, 150)
        Me.editarAP.Name = "editarAP"
        Me.editarAP.Size = New System.Drawing.Size(231, 20)
        Me.editarAP.TabIndex = 8
        '
        'editarNombre
        '
        Me.editarNombre.Location = New System.Drawing.Point(161, 108)
        Me.editarNombre.Name = "editarNombre"
        Me.editarNombre.Size = New System.Drawing.Size(231, 20)
        Me.editarNombre.TabIndex = 7
        '
        'Sexo2
        '
        Me.Sexo2.AutoSize = True
        Me.Sexo2.Location = New System.Drawing.Point(27, 244)
        Me.Sexo2.Name = "Sexo2"
        Me.Sexo2.Size = New System.Drawing.Size(31, 13)
        Me.Sexo2.TabIndex = 6
        Me.Sexo2.Text = "Sexo"
        '
        'ApellidoMaterno2
        '
        Me.ApellidoMaterno2.AutoSize = True
        Me.ApellidoMaterno2.Location = New System.Drawing.Point(27, 200)
        Me.ApellidoMaterno2.Name = "ApellidoMaterno2"
        Me.ApellidoMaterno2.Size = New System.Drawing.Size(86, 13)
        Me.ApellidoMaterno2.TabIndex = 5
        Me.ApellidoMaterno2.Text = "Apellido Materno"
        '
        'ApellidoPaterno2
        '
        Me.ApellidoPaterno2.AutoSize = True
        Me.ApellidoPaterno2.Location = New System.Drawing.Point(27, 158)
        Me.ApellidoPaterno2.Name = "ApellidoPaterno2"
        Me.ApellidoPaterno2.Size = New System.Drawing.Size(84, 13)
        Me.ApellidoPaterno2.TabIndex = 4
        Me.ApellidoPaterno2.Text = "Apellido Paterno"
        '
        'Nombre2
        '
        Me.Nombre2.AutoSize = True
        Me.Nombre2.Location = New System.Drawing.Point(27, 116)
        Me.Nombre2.Name = "Nombre2"
        Me.Nombre2.Size = New System.Drawing.Size(44, 13)
        Me.Nombre2.TabIndex = 3
        Me.Nombre2.Text = "Nombre"
        '
        'editarCodigo
        '
        Me.editarCodigo.Location = New System.Drawing.Point(161, 26)
        Me.editarCodigo.Name = "editarCodigo"
        Me.editarCodigo.Size = New System.Drawing.Size(231, 20)
        Me.editarCodigo.TabIndex = 2
        '
        'Comprobar
        '
        Me.Comprobar.Location = New System.Drawing.Point(161, 62)
        Me.Comprobar.Name = "Comprobar"
        Me.Comprobar.Size = New System.Drawing.Size(231, 23)
        Me.Comprobar.TabIndex = 1
        Me.Comprobar.Text = "Comprobar"
        Me.Comprobar.UseVisualStyleBackColor = True
        '
        'Código2
        '
        Me.Código2.AutoSize = True
        Me.Código2.Location = New System.Drawing.Point(27, 33)
        Me.Código2.Name = "Código2"
        Me.Código2.Size = New System.Drawing.Size(40, 13)
        Me.Código2.TabIndex = 0
        Me.Código2.Text = "Código"
        '
        'Borrar
        '
        Me.Borrar.Controls.Add(Me.Eliminar)
        Me.Borrar.Controls.Add(Me.Código3)
        Me.Borrar.Controls.Add(Me.BorrarCodigo)
        Me.Borrar.Location = New System.Drawing.Point(4, 22)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Padding = New System.Windows.Forms.Padding(3)
        Me.Borrar.Size = New System.Drawing.Size(411, 299)
        Me.Borrar.TabIndex = 1
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(145, 71)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(232, 23)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Código3
        '
        Me.Código3.AutoSize = True
        Me.Código3.Location = New System.Drawing.Point(33, 43)
        Me.Código3.Name = "Código3"
        Me.Código3.Size = New System.Drawing.Size(40, 13)
        Me.Código3.TabIndex = 1
        Me.Código3.Text = "Código"
        '
        'BorrarCodigo
        '
        Me.BorrarCodigo.Location = New System.Drawing.Point(145, 36)
        Me.BorrarCodigo.Name = "BorrarCodigo"
        Me.BorrarCodigo.Size = New System.Drawing.Size(232, 20)
        Me.BorrarCodigo.TabIndex = 0
        '
        'VerDatos
        '
        Me.VerDatos.Controls.Add(Me.Cargar)
        Me.VerDatos.Controls.Add(Me.DataGrid)
        Me.VerDatos.Location = New System.Drawing.Point(4, 22)
        Me.VerDatos.Name = "VerDatos"
        Me.VerDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.VerDatos.Size = New System.Drawing.Size(411, 299)
        Me.VerDatos.TabIndex = 3
        Me.VerDatos.Text = "Ver Datos"
        Me.VerDatos.UseVisualStyleBackColor = True
        '
        'Cargar
        '
        Me.Cargar.Location = New System.Drawing.Point(16, 263)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(106, 20)
        Me.Cargar.TabIndex = 2
        Me.Cargar.Text = "Cargar"
        Me.Cargar.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.Size = New System.Drawing.Size(375, 238)
        Me.DataGrid.TabIndex = 0
        '
        'Editar
        '
        Me.Editar.Location = New System.Drawing.Point(162, 277)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(230, 24)
        Me.Editar.TabIndex = 11
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 361)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.Agregar.ResumeLayout(False)
        Me.Agregar.PerformLayout()
        Me.Modificar.ResumeLayout(False)
        Me.Modificar.PerformLayout()
        Me.Borrar.ResumeLayout(False)
        Me.Borrar.PerformLayout()
        Me.VerDatos.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Agregar As System.Windows.Forms.TabPage
    Friend WithEvents Enviar As System.Windows.Forms.Button
    Friend WithEvents Sexo As System.Windows.Forms.Label
    Friend WithEvents ApellidoMaterno As System.Windows.Forms.Label
    Friend WithEvents ApellidoPaterno As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents Código As System.Windows.Forms.Label
    Friend WithEvents insertarSexo As System.Windows.Forms.TextBox
    Friend WithEvents insertarAM As System.Windows.Forms.TextBox
    Friend WithEvents insertarAP As System.Windows.Forms.TextBox
    Friend WithEvents insertarNombre As System.Windows.Forms.TextBox
    Friend WithEvents insertarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Modificar As System.Windows.Forms.TabPage
    Friend WithEvents editarSexo As System.Windows.Forms.TextBox
    Friend WithEvents editarAM As System.Windows.Forms.TextBox
    Friend WithEvents editarAP As System.Windows.Forms.TextBox
    Friend WithEvents editarNombre As System.Windows.Forms.TextBox
    Friend WithEvents Sexo2 As System.Windows.Forms.Label
    Friend WithEvents ApellidoMaterno2 As System.Windows.Forms.Label
    Friend WithEvents ApellidoPaterno2 As System.Windows.Forms.Label
    Friend WithEvents Nombre2 As System.Windows.Forms.Label
    Friend WithEvents editarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Comprobar As System.Windows.Forms.Button
    Friend WithEvents Código2 As System.Windows.Forms.Label
    Friend WithEvents Borrar As System.Windows.Forms.TabPage
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Código3 As System.Windows.Forms.Label
    Friend WithEvents BorrarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents VerDatos As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Cargar As System.Windows.Forms.Button
    Friend WithEvents Editar As System.Windows.Forms.Button

End Class
