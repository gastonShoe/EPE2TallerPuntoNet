Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As String = "Data Source=WOLFGANGG;Initial Catalog=persona2;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;"

    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable

            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT codigo, nombre, apellidoPaterno, apellidoMaterno, sexo from persona", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
            MsgBox("Datos cargados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Click(sender As Object, e As EventArgs) Handles Cargar.Click
        actualizarTabla()

    End Sub

    Private Sub EliminarDatos()
        Try            

            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlCommand("DELETE from persona where codigo ='" + BorrarCodigo.Text + "';", cn)
                cn.Open()
                adaptador.ExecuteNonQuery()

            End Using
            MsgBox("Datos borrados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        EliminarDatos()
    End Sub

    Private Sub InsertarDatos()
        Try
            
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlCommand("insert into persona values('" + insertarCodigo.Text + "','" + insertarNombre.Text + "','" + insertarAP.Text + "','" + insertarAM.Text + "','" + insertarSexo.Text + "');", cn)
                cn.Open()
                adaptador.ExecuteNonQuery()

            End Using
            MsgBox("Datos agregados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click
        InsertarDatos()
    End Sub

    Private Sub ComprobarDatos()
        Dim auxiliar As String
        auxiliar = " "
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador1 As New SqlCommand("select nombre from persona where codigo = '" + editarCodigo.Text() + "';", cn)
            cn.Open()
            auxiliar = adaptador1.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        editarNombre.Text = auxiliar
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador1 As New SqlCommand("select apellidoPaterno from persona where codigo = '" + editarCodigo.Text() + "';", cn)
            cn.Open()
            auxiliar = adaptador1.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        editarAP.Text = auxiliar
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador1 As New SqlCommand("select apellidoMaterno from persona where codigo = '" + editarCodigo.Text() + "';", cn)
            cn.Open()
            auxiliar = adaptador1.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        editarAM.Text = auxiliar
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador1 As New SqlCommand("select sexo from persona where codigo = '" + editarCodigo.Text() + "';", cn)
            cn.Open()
            auxiliar = adaptador1.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        editarSexo.Text = auxiliar
        MsgBox("Ejecutado correctamente")

    End Sub


    Private Sub Comprobar_Click(sender As Object, e As EventArgs) Handles Comprobar.Click
        ComprobarDatos()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        EditarDatos()
    End Sub

    Private Sub EditarDatos()

        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("UPDATE persona SET nombre = @nombre ,apellidoPaterno = @ap ,apellidoMaterno = @am, sexo= @sexo WHERE codigo =" + editarCodigo.Text, cn)
            adaptador.Parameters.Add("@nombre", SqlDbType.VarChar).Value = editarNombre.Text()
            adaptador.Parameters.Add("@ap", SqlDbType.VarChar).Value = editarAP.Text()
            adaptador.Parameters.Add("@am", SqlDbType.VarChar).Value = editarAM.Text()
            adaptador.Parameters.Add("@sexo", SqlDbType.VarChar).Value = editarSexo.Text()
            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Ejecutado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
