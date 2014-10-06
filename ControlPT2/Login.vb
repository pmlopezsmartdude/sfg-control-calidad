Imports System.Data.SqlClient

Public Class Login

    Sub cargarpla()
        If Conexion.State = ConnectionState.Open Then

            Dim oComando As New SqlCommand("SELECT * FROM planta", Conexion)
            Dim oDataReader As SqlDataReader

            oDataReader = oComando.ExecuteReader()
            com_planta.Items.Clear()
            While oDataReader.Read()
                Me.com_planta.Items.Add(oDataReader("placodigo") & " - " & oDataReader("pladescri"))
            End While

            oDataReader.Close()
            Conexion.Dispose()

        End If

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'ClearMemory()


    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load

        Conectarbd()
        cargarpla()

    End Sub

    Private Sub Txtusuario_KeyPress(ByVal sender As Object, _
                                  ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                  Handles txtusuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If com_planta.SelectedItem = "" Then
            MsgBox("seleccione la planta", MsgBoxStyle.Information)
            com_planta.Focus()
        Else
            If txtusuario.Text = "" Then
                MsgBox("ingrese usuario", MsgBoxStyle.Information)
                txtusuario.Focus()
            Else
                If txtcontraseña.Text = "" Then
                    MsgBox("ingesar contraseña")
                    txtcontraseña.Focus()
                Else
                    Conectarbd()
                    Dim com_usu As New SqlCommand("SELECT * FROM usuario WHERE usurutusu='" & txtusuario.Text & "' AND usupasswo='" & txtcontraseña.Text & "' ", Conexion)
                    Dim datausu As SqlDataReader

                    datausu = com_usu.ExecuteReader()

                    If datausu.Read() Then
                        vplacodigo = Mid(com_planta.SelectedItem, 1, 2)
                        vpladescri = Mid(com_planta.SelectedItem, 6)
                        vusurutusu = datausu("usurutusu")
                        vusunombre = datausu("usunombre")
                        vusudescar = datausu("usudescar")

                        frm_principal.mnulogin.Visible = False
                        frm_principal.mnuEntrada.Visible = True
                        frm_principal.mnuConsulta.Visible = True
                        frm_principal.mnuhelp.Visible = True

                        frm_principal.bar_planta.Text = "PLANTA: " + vpladescri
                        frm_principal.bar_usuario.Text = "USUARIO: " + vusunombre

                        datausu.Close()
                        'Conexion.Close()
                        Conexion.Dispose()
                        Me.Close()

                    Else

                        MsgBox("Usuario no Valido")
                        txtusuario.Focus()
                        datausu.Close()
                        ' Conexion.Close()
                        Conexion.Dispose()

                    End If

                End If
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Me.Close()

    End Sub


    Private Sub com_planta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles com_planta.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

End Class

