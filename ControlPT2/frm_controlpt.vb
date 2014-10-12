Imports System.Data.SqlClient

Public Class frm_controlpt

    Private Sub txtcodbarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodbarra.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            cargar_datos_unitec()
        End If

    End Sub

    Sub cargar_datos_unitec()

        Dim conexion_unitec As New SqlConnection()
        Dim com_caja_unitec As SqlCommand
        Dim data_caja_unitec As SqlDataReader


        If vplacodigo = "01" Then
            conexion_unitec.ConnectionString = "Data Source=192.168.1.140;Initial Catalog=LotManager01;Integrated Security=false;uid=usercontrolpt;pwd=$Control03;"
        Else
            If vplacodigo = "02" Then
                conexion_unitec.ConnectionString = "Data Source=192.168.1.140;Initial Catalog=LotManager40;Integrated Security=false;uid=usercontrolpt;pwd=$Control03;"
            End If
        End If

        Try
            conexion_unitec.Open()

        Catch oExcep As SqlException
            ' si se produce algún error
            MessageBox.Show("Error al conectar con datos contactarse con el desarrollador de Sistemas" & _
            ControlChars.CrLf & _
            oExcep.Message & ControlChars.CrLf & _
            oExcep.Server)
        End Try

        If conexion_unitec.State = ConnectionState.Open Then

            Try
                com_caja_unitec = New SqlCommand("select * from dbo.DatosCajas where codCaja='" & txtcodbarra.Text & "' ", conexion_unitec)
                data_caja_unitec = com_caja_unitec.ExecuteReader()

                If data_caja_unitec.Read() Then
                    txtturcodigo.Text = data_caja_unitec("Turno")
                    txtlincodigo.Text = data_caja_unitec("Linea")
                    txtcptproces.Text = data_caja_unitec("Proceso")
                    txtcptnulote.Text = data_caja_unitec("Lote")
                    txtcptpesone.Text = data_caja_unitec("PesoTimbrado")
                    txtcptcalibr.Text = data_caja_unitec("ClaseCalibreColor")
                    txtcptsalida.Text = data_caja_unitec("Salida")
                    txtcptespcod.Text = data_caja_unitec("codEspecie")
                    lblcptespnom.Text = data_caja_unitec("Especie")
                    txtcptvarcod.Text = data_caja_unitec("codVariedadReal")
                    lblcptvarnom.Text = data_caja_unitec("VariedadReal")
                    txtcptmarca.Text = data_caja_unitec("codMarca")
                    lblcptmarca.Text = data_caja_unitec("Marca")
                    txtcptembcod.Text = data_caja_unitec("codEmbalaje")
                    lblcptembnom.Text = data_caja_unitec("Embalaje")
                    txtcptenvcod.Text = data_caja_unitec("codEnvase")
                    lblcptenvnom.Text = data_caja_unitec("Envase")
                    txtcptrutprr.Text = data_caja_unitec("codProductorReal")
                    lblcptnompre.Text = data_caja_unitec("ProductorReal")
                    txtcptrutpet.Text = data_caja_unitec("codProductorTimbrado")
                    lblcptnompet.Text = data_caja_unitec("ProductorTimbrado")
                    txtdefcalbaj.Focus()

                Else
                    MsgBox("No se han Encontrado Resultados codigo Caja")
                    txtcodbarra.Focus()

                End If

                data_caja_unitec.Close()

            Catch oExcep As SqlException
                ' si se produce algún error
                MessageBox.Show("Error al conectar con datos contactarse con el desarrollador de Sistemas" & _
                ControlChars.CrLf & _
                oExcep.Message & ControlChars.CrLf & _
                oExcep.Server)
            End Try

            conexion_unitec.Close()
            conexion_unitec.Dispose()

        End If

    End Sub

    Private Sub txtdefcalbaj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefcalbaj.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefcalnor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefcalnor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefcalsob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefcalsob.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefprecal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefprecal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefdanotr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefdanotr.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefescama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefescama.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdeffrutode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdeffrutode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdeffrutodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdeffrutodo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefguatab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefguatab.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefherida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefherida.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtmancha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefmancha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefmedial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefmedial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefpiella_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefpiella.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdeffruset_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefrusset.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefsutura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefsutura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdeffaltoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdeffaltoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdeframole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdeframole.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefsinped_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefsinped.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefadhesi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefadhesi.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub txtdefdesfru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefdesfru.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefdesped_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefdesped.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefblando_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefblando.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefherabi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefherabi.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefmachuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefmachuc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefpartid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefpartid.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefparagu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefparagu.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefparcic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefparcic.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefpittin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefpittin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefpudric_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefpudric.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefmanpar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefmanpar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefdanopa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefdanopa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefdesgar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefdesgar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdefcorsie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdefcorsie.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'SendKeys.Send("{TAB}")
            txtcodbarra.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        grabar_datos()

    End Sub

    Private Sub frm_controlpt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'ClearMemory()

    End Sub

    Sub grabar_datos()
        Dim oConexion As SqlConnection
        Dim oDataAdapter As SqlDataAdapter

        'crear conexión
        oConexion = New SqlConnection()
        oConexion.ConnectionString = "Data Source=Jano\SQL_SERVER;Initial Catalog=CONTROLPT;Integrated Security=false;uid=usercontrolpt;pwd=$Control03;"

        ' crear adaptador
        oDataAdapter = New SqlDataAdapter()
        ' crear comandos para inserción, consulta con sus parámetros y asignarlos al adaptador

        Dim oCmdInsercion As New SqlCommand("INSERT INTO controlpt " & _
        "(cptnumero,placodigo,turcodigo,cptfechor,usurutusu,lincodigo,cptproces,cptnulote,cptrutprr,cptnompre,cptrutpet,cptnompet,cptespcod,cptespdes,cptvarcod,cptvardes,cptcalibr,cptmarcod,cptmardes,cptembcod,cptembdes,cptenvcod,cptenvdes,cptpesone,cptsalida,cptcodcja) " & _
        "VALUES(@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9,@c10,@c11,@c12,@c13,@c14,@c15,@c16,@c17,@c18,@c19,@c20,@c21,@c22,@c23,@c24,@c25,@c26)", oConexion)

        oDataAdapter.InsertCommand = oCmdInsercion
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c1", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c2", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c3", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c4", SqlDbType.DateTime))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c5", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c6", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c7", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c8", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c9", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c10", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c11", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c12", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c13", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c14", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c15", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c16", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c17", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c18", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c19", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c20", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c21", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c22", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c23", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c24", SqlDbType.NVarChar))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c25", SqlDbType.Int))
        oDataAdapter.InsertCommand.Parameters.Add(New SqlParameter("@c26", SqlDbType.NVarChar))


        ' buscar correlativo control
        Dim com_planta_corr As New SqlCommand("SELECT planumcpt FROM planta WHERE placodigo='" & vplacodigo & "' ", oConexion)
        Dim dataplantacorr As SqlDataReader
        Dim Num As Integer = 0

        ' abrir conexión
        oConexion.Open()

        dataplantacorr = com_planta_corr.ExecuteReader()

        If dataplantacorr.Read() Then
            txtcptnumero.Text = dataplantacorr("planumcpt")
            Num = Val(txtcptnumero.Text)
            txtcptnumero.Text = Num + 1
            Dim largo As Integer = Len(txtcptnumero.Text)

            If largo = 1 Then
                txtcptnumero.Text = vplacodigo + "0000" + txtcptnumero.Text
            Else
                If largo = 2 Then
                    txtcptnumero.Text = vplacodigo + "000" + txtcptnumero.Text
                Else
                    If largo = 3 Then
                        txtcptnumero.Text = vplacodigo + "00" + txtcptnumero.Text
                    Else
                        If largo = 4 Then
                            txtcptnumero.Text = vplacodigo + "0" + txtcptnumero.Text
                        End If
                    End If
                End If
            End If
        End If
        com_planta_corr.Dispose()
        dataplantacorr.Close()


        Dim iResultado As Integer
        ' asignar valores a los parámetros para el
        ' comando de inserción
        oDataAdapter.InsertCommand.Parameters("@c1").Value = txtcptnumero.Text
        oDataAdapter.InsertCommand.Parameters("@c2").Value = vplacodigo
        oDataAdapter.InsertCommand.Parameters("@c3").Value = txtturcodigo.Text
        oDataAdapter.InsertCommand.Parameters("@c4").Value = Now
        oDataAdapter.InsertCommand.Parameters("@c5").Value = vusurutusu
        oDataAdapter.InsertCommand.Parameters("@c6").Value = txtlincodigo.Text
        oDataAdapter.InsertCommand.Parameters("@c7").Value = txtcptproces.Text
        oDataAdapter.InsertCommand.Parameters("@c8").Value = txtcptnulote.Text
        oDataAdapter.InsertCommand.Parameters("@c9").Value = txtcptrutprr.Text
        oDataAdapter.InsertCommand.Parameters("@c10").Value = lblcptnompre.Text
        oDataAdapter.InsertCommand.Parameters("@c11").Value = txtcptrutpet.Text
        oDataAdapter.InsertCommand.Parameters("@c12").Value = lblcptnompet.Text
        oDataAdapter.InsertCommand.Parameters("@c13").Value = txtcptespcod.Text
        oDataAdapter.InsertCommand.Parameters("@c14").Value = lblcptespnom.Text
        oDataAdapter.InsertCommand.Parameters("@c15").Value = txtcptvarcod.Text
        oDataAdapter.InsertCommand.Parameters("@c16").Value = lblcptvarnom.Text
        oDataAdapter.InsertCommand.Parameters("@c17").Value = txtcptcalibr.Text
        oDataAdapter.InsertCommand.Parameters("@c18").Value = txtcptmarca.Text
        oDataAdapter.InsertCommand.Parameters("@c19").Value = lblcptmarca.Text
        oDataAdapter.InsertCommand.Parameters("@c20").Value = txtcptembcod.Text
        oDataAdapter.InsertCommand.Parameters("@c21").Value = lblcptembnom.Text
        oDataAdapter.InsertCommand.Parameters("@c22").Value = txtcptenvcod.Text
        oDataAdapter.InsertCommand.Parameters("@c23").Value = lblcptenvnom.Text
        oDataAdapter.InsertCommand.Parameters("@c24").Value = txtcptpesone.Text
        oDataAdapter.InsertCommand.Parameters("@c25").Value = Val(txtcptsalida.Text)
        oDataAdapter.InsertCommand.Parameters("@c26").Value = txtcodbarra.Text

        '
        Dim com_clavecpt As New SqlCommand("SELECT cptnumero FROM controlpt WHERE cptnumero='" & txtcptnumero.Text & "' ", oConexion)
        Dim dataclavecpt As SqlDataReader

        dataclavecpt = com_clavecpt.ExecuteReader()

        If dataclavecpt.Read() Then
            MsgBox("Error Numero de control ya existe ")
            dataclavecpt.Close()
        Else
            dataclavecpt.Close()
            ' ejecutar comando de inserción del adaptador
            iResultado = oDataAdapter.InsertCommand.ExecuteNonQuery()

            If iResultado > 0 Then
                'Grabar defectos 
                Dim DataAdapdef As SqlDataAdapter
                ' crear adaptador
                DataAdapdef = New SqlDataAdapter()
                Dim cmdinsdef As New SqlCommand("INSERT INTO defecto " & _
        "(cptnumero,defcalbaj,defcalnor,defcalsob,defprecal,defdanotr,defescama,deffrutode,deffrutodo,defguatab,defherida,defmancha,defmedial,defpiella,defrusset,defsutura,deffaltoc,deframole,defsinped,defadhesi,defdesfru,defdesped,defblando,defherabi,defmachuc,defpartid,defparagu,defparcic,defpittin,defpudric,defmanpar,defdanopa,defdesgar,defcorsie) " & _
        "VALUES('" & txtcptnumero.Text & "','" & txtdefcalbaj.Text & "','" & txtdefcalnor.Text & "','" & txtdefcalsob.Text & "','" & txtdefprecal.Text & "','" & txtdefdanotr.Text & "','" & txtdefescama.Text & "','" & txtdeffrutode.Text & "','" & txtdeffrutodo.Text & "','" & txtdefguatab.Text & "','" & txtdefherida.Text & "','" & txtdefmancha.Text & "','" & txtdefmedial.Text & "','" & txtdefpiella.Text & "','" & txtdefrusset.Text & "','" & txtdefsutura.Text & "','" & txtdeffaltoc.Text & "','" & txtdeframole.Text & "','" & txtdefsinped.Text & "','" & txtdefadhesi.Text & "','" & txtdefdesfru.Text & "','" & txtdefdesped.Text & "','" & txtdefblando.Text & "','" & txtdefherabi.Text & "','" & txtdefmachuc.Text & "','" & txtdefpartid.Text & "','" & txtdefparagu.Text & "','" & txtdefparcic.Text & "','" & txtdefpittin.Text & "','" & txtdefpudric.Text & "','" & txtdefmanpar.Text & "','" & txtdefdanopa.Text & "','" & txtdefdesgar.Text & "','" & txtdefcorsie.Text & "')", oConexion)

                DataAdapdef.InsertCommand = cmdinsdef
                DataAdapdef.InsertCommand.ExecuteNonQuery()

                'actualizar correlativo numero control segun planta
                Dim DataAdapcorr As SqlDataAdapter
                ' crear adaptador
                DataAdapcorr = New SqlDataAdapter()
                Dim cmdinscorr As New SqlCommand("UPDATE planta set planumcpt='" & Mid(txtcptnumero.Text, 3) & "' where placodigo='" & vplacodigo & "' ", oConexion)

                DataAdapcorr.UpdateCommand = cmdinscorr
                DataAdapcorr.UpdateCommand.ExecuteNonQuery()

                MessageBox.Show("Registros añadidos: " & iResultado)
            End If
        End If

        ' cerrar conexión
        oConexion.Close()
        oConexion.Dispose()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtcptnumero.Text = ""
        txtcodbarra.Text = ""
        txtturcodigo.Text = ""
        txtlincodigo.Text = ""
        txtcptproces.Text = ""
        txtcptnulote.Text = ""
        txtcptpesone.Text = ""
        txtcptcalibr.Text = ""
        txtcptsalida.Text = ""
        txtcptespcod.Text = ""
        lblcptespnom.Text = ""
        txtcptvarcod.Text = ""
        lblcptvarnom.Text = ""
        txtcptmarca.Text = ""
        lblcptmarca.Text = ""
        txtcptembcod.Text = ""
        lblcptembnom.Text = ""
        txtcptenvcod.Text = ""
        lblcptenvnom.Text = ""
        txtcptrutprr.Text = ""
        lblcptnompre.Text = ""
        txtcptrutpet.Text = ""
        lblcptnompet.Text = ""

        txtdefcalbaj.Text = ""
        txtdefcalnor.Text = ""
        txtdefcalsob.Text = ""
        txtdefprecal.Text = ""
        txtdefdanotr.Text = ""
        txtdefescama.Text = ""
        txtdeffrutode.Text = ""
        txtdeffrutodo.Text = ""
        txtdefguatab.Text = ""
        txtdefherida.Text = ""
        txtdefmancha.Text = ""
        txtdefmedial.Text = ""
        txtdefpiella.Text = ""
        txtdefrusset.Text = ""
        txtdefsutura.Text = ""
        txtdeffaltoc.Text = ""
        txtdeframole.Text = ""
        txtdefsinped.Text = ""
        txtdefadhesi.Text = ""
        txtdefdesfru.Text = ""
        txtdefdesped.Text = ""
        txtdefblando.Text = ""
        txtdefherabi.Text = ""
        txtdefmachuc.Text = ""
        txtdefmachuc.Text = ""
        txtdefpartid.Text = ""
        txtdefparagu.Text = ""
        txtdefparcic.Text = ""
        txtdefpittin.Text = ""
        txtdefpudric.Text = ""
        txtdefmanpar.Text = ""
        txtdefdanopa.Text = ""
        txtdefdesgar.Text = ""
        txtdefcorsie.Text = ""

        txtcodbarra.Focus()

    End Sub



End Class