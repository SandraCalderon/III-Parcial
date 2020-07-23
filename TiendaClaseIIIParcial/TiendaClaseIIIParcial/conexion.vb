Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-I773KQU;Initial Catalog=TiendaClase2;Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public dt As DataTable
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function insertarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                                    psw As String, rol As String, estado As String, correo As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@IdUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@pw", psw)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@estado", estado)
            cmb.Parameters.AddWithValue("@correo", correo.ToLower)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conexion.Close()
        End Try
    End Function

    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

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

    Public Function eliminarUsuario(idUsuario As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@IdUsuario", idUsuario)
            If cmb.ExecuteNonQuery <> 0 Then
                conexion.Close()
                Return True
            Else
                conexion.Close()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function cadena(texto As String)
        texto.ToLower()
        texto.Substring(0, 1).ToLower()
        Return texto
    End Function

    Public Sub buscarYLlenarDGV(dgv As DataGridView, username As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("BuscarNombre", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter(cmb)
            dt = New DataTable
            With cmb.Parameters
                .Add(New SqlParameter("@nombreUsuario", username))
            End With
            da.Fill(dt)
            dgv.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function modificar(ByVal idUsuario As Integer, ByVal nombre As String, ByVal apellido As String, ByVal userName As String, ByVal pw As String, ByVal rol As String, ByVal correo As String) As Boolean
        Try
            conexion.Open()
            cmb = New SqlCommand("modificarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@IdUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@pw", Encriptar(pw))
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@correo", correo.ToLower)
            If cmb.ExecuteNonQuery Then
                conexion.Close()
                Return True
            Else
                conexion.Close()
                Return False
            End If
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function llenarObj(instruccion As String, columnas As String) As String
        Try
            Dim text As String
            Dim dr As SqlDataReader
            conexion.Open()
            cmb = New SqlCommand(instruccion, conexion)
            dr = cmb.ExecuteReader
            While dr.Read
                text = Convert.ToString(dr(columnas))
            End While

            dr.Close()
            conexion.Close()
            Return text
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
        End Try
    End Function

    Public Function comprobarExistencias(ByVal instruccion As String) As Integer
        Try
            conexion.Open()
            Dim cmb As SqlCommand = conexion.CreateCommand()
            cmb.CommandText = instruccion
            Dim existe As String = CStr(cmb.ExecuteScalar())
            If existe <> "" Then
                conexion.Close()
                Return 1
            Else
                conexion.Close()
                Return 2
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

End Class
