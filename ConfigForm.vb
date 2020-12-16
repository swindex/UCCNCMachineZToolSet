Friend Class ConfigForm

    Private UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin

    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()
    End Sub

End Class