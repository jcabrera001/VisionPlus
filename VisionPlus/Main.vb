Module Main
    Sub Main()

        'Verifica si ya existe una instancia o sesion de nuestra aplicacion en linea
        'If Process.GetProcessesByName( _
        '   Process.GetCurrentProcess.ProcessName).Length > 1 Then
        '    MessageBox.Show("Ya existe una instancia abierta...")
        'Else
        'Registrar el paquete de skins extras
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        Application.Run(New GenPrincipalFrm())
        'End If
    End Sub

End Module
