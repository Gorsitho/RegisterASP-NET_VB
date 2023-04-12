Imports System.Windows.Forms

Public Class RegistroClientes
    Inherits System.Web.UI.Page

    Dim MiCliente As New LayerEntity.ClsCliente
    Dim BuscarCliente As New DAL.DALCliente
    Dim ModificarCliente As New DAL.DALCliente
    Dim EliminarCliente As New DAL.DALCliente

    Dim CanSend As Boolean = True

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTN_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_GUARDAR.Click

        MiCliente.ID_CLIENTE = TXT_IDCLIENTE.Text
        MiCliente.NOMBRE_C = TXT_NOMBRE.Text
        MiCliente.SEXO = LIST_SEXO.Text
        MiCliente.EDAD = TXT_EDAD.Text
        MiCliente.OBSERVACIONES = TXT_OBSERVACIONES.Text

        Dim bllclientes As New BLL.BLLCliente

        If bllclientes.AgregarCliente(MiCliente) Then
            BLL_RESPUESTA.Text = " CLIENTE '" + TXT_NOMBRE.Text + "' AGREGADO EXITOSAMENTE"
        Else
            BLL_RESPUESTA.Text = " CLIENTE '" + TXT_NOMBRE.Text + "' NO SE AGREGÓ EXITOSAMENTE"
        End If


    End Sub


    '************************
    'BOTONES 
    '************************


    Protected Sub BTN_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.Click
        ModificarCliente.ModificarCliente(TXT_IDCLIENTE.Text, TXT_NOMBRE.Text, LIST_SEXO.Text, TXT_EDAD.Text, TXT_OBSERVACIONES.Text)
        BLL_RESPUESTA.Text = "CLIENTE MODIFICADO EXITOSAMENTE"

    End Sub

    Protected Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        EliminarCliente.EliminarCliente(TXT_IDCLIENTE.Text, TXT_NOMBRE.Text, LIST_SEXO.Text, TXT_EDAD.Text, TXT_OBSERVACIONES.Text)
        BLL_RESPUESTA.Text = "ELIMINADO EXITOSAMENTE"
    End Sub

    Protected Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        If CanSend Then
            TXT_IDCLIENTE.Text = TXT_IDCLIENTE.Text
            TXT_EDAD.Text = 0
            BuscarCliente.BuscarCliente(TXT_IDCLIENTE.Text, TXT_NOMBRE.Text, LIST_SEXO.Text, TXT_EDAD.Text, TXT_OBSERVACIONES.Text)
            BLL_RESPUESTA.Text = "BUSQUEDA REALIZADA EXITOSAMENTE"
        Else

            LimpiarCampos()

        End If

    End Sub

    Protected Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click
        LimpiarCampos()
    End Sub

    '************************
    'INPUTS DE TEXTOS 
    '************************

    Protected Sub TXT_IDCLIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXT_IDCLIENTE.TextChanged
        Dim input As String = TXT_IDCLIENTE.Text.Trim()

        If Not esNumero(input) Then
            ' Si el input no es un número, muestra un mensaje de error.
            CanSend = False
            MsgBox("El ID de cliente debe ser un número.", vbCritical, "Error")
            ' También podrías limpiar el input o mostrar un mensaje de error en un label.
        Else
            ' Si el input es un número, procesa la información.
            procesarInformacion(input)
        End If
    End Sub

    Private Sub procesarInformacion(ByVal idCliente As String)
        ' Aquí puedes agregar el código para procesar la información del cliente.
    End Sub


    Protected Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged

    End Sub


    Protected Sub TXT_EDAD_TextChanged(sender As Object, e As EventArgs) Handles TXT_EDAD.TextChanged

    End Sub

    Protected Sub TXT_OBSERVACIONES_TextChanged(sender As Object, e As EventArgs) Handles TXT_OBSERVACIONES.TextChanged

    End Sub



#Region "FUNCIONES ADICIONALES"

    Function esNumero(ByVal valor As String) As Boolean
        Dim i As Integer
        esNumero = True
        For i = 1 To Len(valor)
            If Not IsNumeric(Mid(valor, i, 1)) Then
                esNumero = False
                Exit Function
            End If
        Next i
    End Function



    Sub LimpiarCampos()
        TXT_IDCLIENTE.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_EDAD.Text = ""
        TXT_OBSERVACIONES.Text = ""

    End Sub

    Protected Sub LIST_SEXO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LIST_SEXO.SelectedIndexChanged


    End Sub





#End Region
End Class