<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CloseButton As System.Windows.Forms.Button
        Me.EnrollmentControl = New DPFP.Gui.Enrollment.EnrollmentControl()
        CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK
        CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        CloseButton.ForeColor = System.Drawing.SystemColors.HotTrack
        CloseButton.Location = New System.Drawing.Point(327, 322)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New System.Drawing.Size(157, 31)
        CloseButton.TabIndex = 2
        CloseButton.Text = "SAVE ALL DATA"
        CloseButton.UseVisualStyleBackColor = True
        AddHandler CloseButton.Click, AddressOf Me.CloseButton_Click
        '
        'EnrollmentControl
        '
        Me.EnrollmentControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EnrollmentControl.EnrolledFingerMask = 0
        Me.EnrollmentControl.Location = New System.Drawing.Point(2, 2)
        Me.EnrollmentControl.MaxEnrollFingerCount = 10
        Me.EnrollmentControl.Name = "EnrollmentControl"
        Me.EnrollmentControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.EnrollmentControl.Size = New System.Drawing.Size(492, 314)
        Me.EnrollmentControl.TabIndex = 3
        '
        'EnrollmentForm
        '
        Me.AcceptButton = CloseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = CloseButton
        Me.ClientSize = New System.Drawing.Size(496, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.EnrollmentControl)
        Me.Controls.Add(CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnrollmentForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fingerprint Enrollment"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EnrollmentControl As DPFP.Gui.Enrollment.EnrollmentControl
End Class
