Public Class UCCNCplugin
    Friend UC As Plugininterface.Entry
    Friend LoopStop As Boolean
    Friend LoopWorking As Boolean

    Dim FirstRun As Boolean = True
    Private WithEvents MyForm As PluginForm
    Public Property Ismainscreen As Boolean
    Public Property labelnumber As Integer
    Public Property ShiftZ As Double

    ' Called when the plugin is initialised.
    ' The parameter is the Plugin interface object which contains all functions prototypes for calls and callbacks.
    Public Sub Init_event(UC As Plugininterface.Entry)
        Me.UC = UC
        MyForm = New PluginForm(Me)
    End Sub

    ' Called when the plugin is loaded, the author of the plugin should set the details of the plugin here.
    Public Function Getproperties_event(ByVal Properties As Plugininterface.Entry.Pluginproperties) As Plugininterface.Entry.Pluginproperties
        Properties.author = "Eldar Gerfanov"
        Properties.pluginname = "Machine Z Tool Set"
        ' Properties.pluginversion = "0.0001"
        Properties.pluginversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString ' Get version from Assembly info
        Return Properties
    End Function

    ' Called from UCCNC when the user presses the Configuration button in the Plugin configuration menu.
    ' Typically the plugin configuration window is shown to the user.
    Public Sub Configure_event()
        'Dim CForm As New ConfigForm(Me)
        'CForm.Show()
    End Sub

    ' Called from UCCNC when the plugin is loaded and started.
    Public Sub Startup_event()
        'If MyForm.IsDisposed Then
        ' MyForm = New PluginForm(Me)
        'End If
        'MyForm.Show()
    End Sub

    ' Called when the Pluginshowup(string Pluginfilename); function is executed in the UCCNC.
    Public Sub Showup_event()
        'If MyForm.IsDisposed Then
        'MyForm = New PluginForm(Me)
        'End If
        'MyForm.Show()
        'MyForm.BringToFront()
    End Sub

    ' Called when the UCCNC software is closing.
    Public Sub Shutdown_event()
        Try
            MyForm.Close()
        Catch ex As Exception

        End Try
    End Sub

    ' Called in a loop with a 25Hz interval.
    Public Sub Loop_event()
        If LoopStop Then
            Return
        End If
        LoopWorking = True
        If MyForm Is Nothing Or MyForm.IsDisposed Then
            Return
        End If
        If FirstRun Then
            FirstRun = False
            ' Write code here which has to be run on first cycle only...
        End If
        Try
            'MyForm.Label1.Text = "X: " + UC.Getfield(True, 226)
            ' MyForm.label2.Text = "Y: " + UC.Getfield(True, 227)
            ' MyForm.label3.Text = "Z: " + UC.Getfield(True, 228)
            ' MyForm.label4.Text = "A: " + UC.Getfield(True, 229)
            ' MyForm.label5.Text = "Set feed: " + UC.Getfield(True, 867)
            ' MyForm.label6.Text = "Act feed: " + UC.Getfield(True, 868)
            MyForm.CurrentMachineZPos = UC.GetZmachpos()
        Catch ex As Exception

        End Try
        LoopWorking = False
        ' Console.WriteLine("" + Convert.ToInt32("A"))
    End Sub

    ' This is a direct function call addressed to this plugin dll
    ' The function can be called by macros or by another plugin
    ' The passed parameter is an object and the return value is also an object
    Public Function Informplugin_event(Message As Object) As Object
        'If Not (MyForm Is Nothing Or MyForm.IsDisposed) Then
        '    If TypeOf Message Is String Then
        '        Dim receivedstr As String = Message
        '        MsgBox("Informplugin message received by Plugintest! Message was: " + receivedstr)
        '    End If
        'End If
        'Dim returnstr As String = "Return string by Plugintest"
        'Return returnstr
    End Function

    ' This is a function call made to all plugin dll files
    ' The function can be called by macros or by another plugin
    ' The passed parameter is an object and there is no return value
    Public Sub Informplugins_event(Message As Object)
        'If Not (MyForm Is Nothing Or MyForm.IsDisposed) Then
        '    If TypeOf Message Is String Then
        '        Dim receivedstr As String = Message
        '        MsgBox("Informplugins message received by Plugintest! Message was: " + receivedstr)
        '    End If
        'End If
    End Sub

    ' Called when the user presses a button on the UCCNC GUI or if a Callbutton function is executed.
    ' The int buttonnumber parameter is the ID of the caller button.
    ' The bool onscreen parameter is true if the button was pressed on the GUI and is false if the Callbutton function was called.
    Public Sub Buttonpress_event(ByVal ButtonNumber As Integer, ByVal OnScreen As Boolean)
        If OnScreen Then
            If ButtonNumber = 128 Then
                ' Code...
            End If
        End If
    End Sub

    Private Sub OnMyFormOkClicked() Handles MyForm.OnOkClicked
        If MyForm.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.ShiftZ = MyForm.ShiftZ
            Me.UC.Focusoutoffield()
            Me.UC.Setfield(Ismainscreen, MyForm.Result, labelnumber)
            Me.UC.Validatefield(Ismainscreen, labelnumber)
        End If
    End Sub

    ' Called when the user clicks and enters a Textfield on the screen
    ' The labelnumber parameter is the ID of the accessed Textfield
    ' The bool Ismainscreen parameter is true is the Textfield is on the main screen and false if it is on the jog screen
    Public Sub Textfieldclick_event(labelnumber As Integer, Ismainscreen As Boolean)
        '196-215
        '921-996
        'MsgBox(labelnumber)

        If (labelnumber >= 196 And labelnumber <= 215) Or (labelnumber >= 921 And labelnumber <= 996) Then
            If (Not MyForm.IsDisposed) Then
                MyForm.Close()
            End If

            MyForm = New PluginForm(Me)

            Me.Ismainscreen = Ismainscreen
            Me.labelnumber = labelnumber

            MyForm.ShiftZ = Me.ShiftZ
            MyForm.CurrentMachineZPos = UC.GetZmachpos()
            MyForm.Show()
            MyForm.BringToFront()

        End If

        If Ismainscreen Then
            If labelnumber = 1000 Then
                ' Your code here...
            End If
        End If
    End Sub

    ' Called when the user enters text into the Textfield and it gets validated
    ' The labelnumber parameter is the ID of the accessed Textfield
    ' The bool Ismainscreen parameter is true is the Textfield is on the main screen and false if it is on the jog screen.
    ' The text parameter is the text entered and validated by the user
    Public Sub Textfieldtexttyped_event(labelnumber As Integer, Ismainscreen As Boolean, text As String)
        If Ismainscreen Then
            If labelnumber = 1000 Then
                ' Your code here...
            End If
        End If
    End Sub

    ' Called when the user presses the Cycle start button and before the Cycle starts
    ' This event may be used to show messages or do actions on Cycle start 
    ' For example to cancel the Cycle if a condition met before the Cycle starts with calling the Button code 130 Cycle stop
    Public Sub Cyclethreadstart_event()
        ' MsgBox("Cycle is starting...")
    End Sub

    Public Sub Cyclethreadstop_event()
        ' MsgBox("Cycle is stopping...")
    End Sub

    Public Sub Toolpathclick_event(X As Double, Y As Double, Istopview As Boolean)
        ' Toolpath clicked
    End Sub

    ' Public Function Get_event(pluginfilename As String, exec As Executer) As Boolean ---->>>> ?

End Class
