﻿Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

    Protected Overrides Sub OnStartup(ByVal e As System.Windows.StartupEventArgs)

        MyBase.OnStartup(e)

        Dim _bootstrapper As Bootstrapper = New Bootstrapper
        _bootstrapper.Run()

    End Sub

End Class
