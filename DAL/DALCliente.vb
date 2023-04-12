Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports LayerEntity

Public Class DALCliente

    Dim cnn As New SqlClient.SqlConnection(ClsConexion.cadcon)

    Public Function AgregarCliente(MiCliente As LayerEntity.ClsCliente) As Boolean
        Dim cnn As New SqlConnection(DAL.ClsConexion.cadcon)
        Dim cmd As New SqlCommand("SP_INSERTAR_CLIENTE", cnn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("ID_CLIENTE", SqlDbType.Int).Value = MiCliente.ID_CLIENTE
        cmd.Parameters.Add("NOMBRE_C", SqlDbType.NVarChar, 100).Value = MiCliente.NOMBRE_C
        cmd.Parameters.Add("SEXO", SqlDbType.NChar).Value = MiCliente.SEXO
        cmd.Parameters.Add("EDAD", SqlDbType.Int).Value = MiCliente.EDAD
        cmd.Parameters.Add("OBSERVACIONES", SqlDbType.NVarChar, 100).Value = MiCliente.OBSERVACIONES

        Try

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception

            Return False

        End Try


        cnn.Close()



    End Function


    Public Sub ModificarCliente(ByVal ID_CLIENTE As Integer, ByRef NOMBRE_C As String, ByRef SEXO As String, ByRef EDAD As Integer, ByRef OBSERVACIONES As String)

        Dim cnn As New SqlClient.SqlConnection(ClsConexion.cadcon)
        Dim cmd As New SqlClient.SqlCommand("SP_MODIFICAR_CLIENTE", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("ID_CLIENTE", SqlDbType.Int).Value = ID_CLIENTE
        cmd.Parameters.Add("NOMBRE_C", SqlDbType.NVarChar, 100).Value = NOMBRE_C
        cmd.Parameters.Add("SEXO", SqlDbType.NChar).Value = SEXO
        cmd.Parameters.Add("EDAD", SqlDbType.Int).Value = EDAD
        cmd.Parameters.Add("OBSERVACIONES", SqlDbType.NVarChar, 100).Value = OBSERVACIONES


        Try

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
                cmd.ExecuteNonQuery()
            End If

            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try


        cnn.Close()

    End Sub

    Public Sub BuscarCliente(ByVal ID_CLIENTE As Integer, ByRef NOMBRE_C As String, ByRef SEXO As String, ByRef EDAD As Integer, ByRef OBSERVACIONES As String)
        Dim cnn As New SqlClient.SqlConnection(ClsConexion.cadcon)
        Dim cmd As New SqlClient.SqlCommand("SP_MODIFICAR_CLIENTE", cnn)

        cmd.Parameters.Add("ID_CLIENTE", SqlDbType.Int).Value = ID_CLIENTE
        cmd.CommandType = CommandType.StoredProcedure



        Try

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()

                Dim dr As SqlDataReader

                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    NOMBRE_C = dr(0).ToString
                    SEXO = dr(1).ToString
                    EDAD = dr(2).ToString
                    OBSERVACIONES = dr(3).ToString
                End If


                cmd.ExecuteNonQuery()
                dr.Close()
            End If



        Catch ex As Exception

        End Try


        cnn.Close()



    End Sub


    Public Sub EliminarCliente(ByVal ID_CLIENTE As Integer, ByRef NOMBRE_C As String, ByRef SEXO As String, ByRef EDAD As Integer, ByRef OBSERVACIONES As String)

        Dim cnn As New SqlClient.SqlConnection(ClsConexion.cadcon)
        Dim cmd As New SqlClient.SqlCommand("SP_ELIMINAR_CLIENTE", cnn)

        cmd.Parameters.Add("ID_CLIENTE", SqlDbType.Int).Value = ID_CLIENTE
        cmd.CommandType = CommandType.StoredProcedure


        Try
            cnn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try

        cnn.Close()

    End Sub


End Class
