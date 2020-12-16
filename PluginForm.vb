Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms

Friend Class PluginForm
    Private UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin
    Dim MustClose As Boolean = False

    Public Property Result As Double
    Public Property ShiftZ As Double
    Public Property startedAt As Date
    Public Event OnOkClicked()


    Private _CurrentMachineZPos As Double
    Public Property CurrentMachineZPos() As Double
        Get
            Return _CurrentMachineZPos
        End Get
        Set(ByVal value As Double)
            If (_CurrentMachineZPos <> value) Then
                updateLabels()
            End If
            _CurrentMachineZPos = value
        End Set
    End Property

    Public Property UseCustomMachZ As Boolean = False
    Public Property CustomMachZ As Double = 0

    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()
    End Sub

    Public Shared Sub Main()

    End Sub

    Private Sub PluginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        updateLabels()
    End Sub

    Private Sub PluginForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Do not close the form when the red X button is pressed
        ' But start a Thread which will stop the Loop call from the UCCNC
        ' to prevent the form closing while there is a GUI update in the Loop event
        If Not MustClose Then
            e.Cancel = True
            Dim thrClose As New Thread(Sub() Closeform())
            thrClose.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Preserve regional settings
            thrClose.Start()
        Else
            ' Form is closing here...
        End If
    End Sub

    Public Sub Closeform()
        ' Stop the Loop event to update the GUI
        PluginMain.LoopStop = True
        ' Wait until the loop exited
        While (PluginMain.LoopWorking)
            Thread.Sleep(10)
        End While
        ' Set the mustclose variable to true and call the .Close() function to close the Form
        MustClose = True
        Me.Close()
    End Sub

    Public Sub updateLabels()
        Dim zpos As Double = 0
        If UseCustomMachZ Then
            zpos = CustomMachZ
        Else
            zpos = Me.CurrentMachineZPos
        End If

        Dim zofs As Double = Me.ShiftZ

        txt_mach_z.Text = zpos
        txt_z_shift.Text = Me.ShiftZ

        Me.Result = zpos + zofs
        txt_result_z.Text = zpos + zofs

    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        updateLabels()
        Me.DialogResult = DialogResult.OK
        RaiseEvent OnOkClicked()
        Me.Close()

    End Sub



    Private Sub PluginForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Now().Subtract(Me.startedAt).Milliseconds > 100 Then
            Me.Close()
        End If
    End Sub

    Private Sub PluginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Top = Cursor.Position.Y
        Me.Left = Cursor.Position.X + 50
        Me.startedAt = Now

        'select all text
        txt_mach_z.SelectAll()

    End Sub

    Private Sub BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub txt_mach_z_Validating(sender As Object, e As CancelEventArgs) Handles txt_mach_z.Validating
        Dim res As Double = 0
        If (Double.TryParse(txt_mach_z.Text, res)) Then
            Me.UseCustomMachZ = True
            Me.CustomMachZ = res
            updateLabels()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txt_z_shift_Validating(sender As Object, e As CancelEventArgs) Handles txt_z_shift.Validating
        Dim res As Double = 0
        If (Double.TryParse(txt_z_shift.Text, res)) Then
            Me.ShiftZ = res
            updateLabels()
        Else
            e.Cancel = True
        End If
    End Sub
End Class

