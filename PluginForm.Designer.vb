<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PluginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mach_z = New System.Windows.Forms.TextBox()
        Me.txt_z_shift = New System.Windows.Forms.TextBox()
        Me.txt_result_z = New System.Windows.Forms.TextBox()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.BTN_CANCEL = New System.Windows.Forms.Button()
        Me.Table_Outside = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Table_Outside.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_mach_z, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_z_shift, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_result_z, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_OK, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_CANCEL, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(216, 148)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Machine Z"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Shift"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Result Offset"
        Me.Label3.Visible = False
        '
        'txt_mach_z
        '
        Me.txt_mach_z.Location = New System.Drawing.Point(115, 5)
        Me.txt_mach_z.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_mach_z.Name = "txt_mach_z"
        Me.txt_mach_z.Size = New System.Drawing.Size(97, 26)
        Me.txt_mach_z.TabIndex = 2
        '
        'txt_z_shift
        '
        Me.txt_z_shift.Location = New System.Drawing.Point(115, 41)
        Me.txt_z_shift.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_z_shift.Name = "txt_z_shift"
        Me.txt_z_shift.Size = New System.Drawing.Size(97, 26)
        Me.txt_z_shift.TabIndex = 2
        Me.txt_z_shift.TabStop = False
        '
        'txt_result_z
        '
        Me.txt_result_z.Enabled = False
        Me.txt_result_z.Location = New System.Drawing.Point(115, 77)
        Me.txt_result_z.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_result_z.Name = "txt_result_z"
        Me.txt_result_z.Size = New System.Drawing.Size(97, 26)
        Me.txt_result_z.TabIndex = 2
        Me.txt_result_z.TabStop = False
        Me.txt_result_z.Visible = False
        '
        'BTN_OK
        '
        Me.BTN_OK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_OK.AutoSize = True
        Me.BTN_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_OK.Location = New System.Drawing.Point(115, 113)
        Me.BTN_OK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(97, 30)
        Me.BTN_OK.TabIndex = 3
        Me.BTN_OK.TabStop = False
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CANCEL.AutoSize = True
        Me.BTN_CANCEL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_CANCEL.Location = New System.Drawing.Point(4, 113)
        Me.BTN_CANCEL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(103, 30)
        Me.BTN_CANCEL.TabIndex = 3
        Me.BTN_CANCEL.TabStop = False
        Me.BTN_CANCEL.Text = "Cancel"
        Me.BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'Table_Outside
        '
        Me.Table_Outside.AutoSize = True
        Me.Table_Outside.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Table_Outside.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Table_Outside.ColumnCount = 1
        Me.Table_Outside.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table_Outside.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.Table_Outside.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table_Outside.Location = New System.Drawing.Point(0, 0)
        Me.Table_Outside.Margin = New System.Windows.Forms.Padding(0)
        Me.Table_Outside.Name = "Table_Outside"
        Me.Table_Outside.RowCount = 1
        Me.Table_Outside.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table_Outside.Size = New System.Drawing.Size(239, 171)
        Me.Table_Outside.TabIndex = 1
        '
        'PluginForm
        '
        Me.AcceptButton = Me.BTN_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.BTN_CANCEL
        Me.ClientSize = New System.Drawing.Size(239, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.Table_Outside)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "PluginForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Tool Offset"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Table_Outside.ResumeLayout(False)
        Me.Table_Outside.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_mach_z As Windows.Forms.TextBox
    Friend WithEvents txt_z_shift As Windows.Forms.TextBox
    Friend WithEvents txt_result_z As Windows.Forms.TextBox
    Friend WithEvents BTN_OK As Windows.Forms.Button
    Friend WithEvents Table_Outside As Windows.Forms.TableLayoutPanel
    Friend WithEvents BTN_CANCEL As Windows.Forms.Button
End Class
