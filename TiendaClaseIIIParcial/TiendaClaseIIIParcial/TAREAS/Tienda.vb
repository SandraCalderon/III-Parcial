Imports System.Text.RegularExpressions
Imports System.Globalization.CultureInfo
Imports System.Security.Cryptography
Imports System.Text
Imports System
Public Class Tienda
    Dim conexion As New conexion()
    Dim cultureInfo As New System.Globalization.CultureInfo("es-MX")

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        conexion.mostar(dgv1)
    End Sub

    'username@midominio.com
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUsername.Clear()
        txtPsw.Clear()
        txtCorreo.Clear()
        conexion.mostar(dgv1)
        txtUsuarioB.Clear()
        cmbRol.SelectedIndex = -1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuaurio()

        End If


    End Sub
    Private Sub insertarUsuaurio()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = cadenaTexto(txtNombre.Text)
        apellido = cadenaTexto(txtApellido.Text)
        userName = txtUsername.Text
        psw = conexion.Encriptar(txtPsw.Text)
        correo = LCase(txtCorreo.Text)
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, fTCase(nombre), fTCase(apellido), userName, psw, fTCase(rol), fTCase(estado), LCase(correo)) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Function fTCase(str As String) As String
        'Return cultureInfo.TextInfo.ToTitleCase(str)
        Return StrConv(str, VbStrConv.ProperCase)
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If conexion.eliminarUsuario(Val(txtCodigo.Text)) = True Then
            MessageBox.Show("Usuario Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function cadenaTexto(ByVal text As String)

        Return StrConv(text, VbStrConv.ProperCase)

    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.buscarYLlenarDGV(dgv1, txtUsuarioB.Text)
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If conexion.modificar(Val(txtCodigo.Text), fTCase(txtNombre.Text), fTCase(txtApellido.Text), txtUsername.Text, txtPsw.Text, fTCase(cmbRol.Text), LCase(txtCorreo.Text)) Then
                MessageBox.Show("Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Try
            Dim data As DataGridViewRow = dgv1.Rows(e.RowIndex)
            txtCodigo.Text = data.Cells(0).Value.ToString()
            txtNombre.Text = data.Cells(1).Value.ToString()
            txtApellido.Text = data.Cells(2).Value.ToString()
            txtUserName.Text = data.Cells(3).Value.ToString()
            txtPsw.Text = Desencriptar(data.Cells(4).Value.ToString())
            cmbRol.Text = data.Cells(5).Value.ToString()
            txtCorreo.Text = data.Cells(6).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub
End Class
