Imports System.Data.SqlClient

Module mod_conexion
    Public Conexion As SqlConnection
    Public vplacodigo, vpladescri As String ' variables globales de la planta
    Public vusurutusu, vusunombre, vusudescar As String  ' variables globales del usuario conectado

    'Declaración de la API
    'Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    Public Sub Conectarbd()
        Try
            Conexion = New SqlConnection("Data Source=CHLWCT01AP01\SQLEXPRESS,1433;Initial Catalog=CONTROLPT;Integrated Security=false;uid=usercontrolpt;pwd=$Control03;")
            Conexion.Open()

        Catch oExcep As SqlException
            ' si se produce algún error,
            ' lo capturamos mediante el objeto
            ' de excepciones particular para
            ' el proveedor de SQL Server
            MessageBox.Show("Error al conectar con datos contactarse con el desarrollador de Sistemas" & _
            ControlChars.CrLf & _
            oExcep.Message & ControlChars.CrLf & _
            oExcep.Server)
        End Try

    End Sub


    'Funcion de liberacion de memoria
    'Public Sub ClearMemory()

    '    Try
    '        Dim Mem As Process
    '        Mem = Process.GetCurrentProcess()
    '        SetProcessWorkingSetSize(Mem.Handle, -1, -1)

    '    Catch ex As Exception
    '        'Control de errores
    '    End Try

    'End Sub


End Module

