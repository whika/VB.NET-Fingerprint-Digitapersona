<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim gbEnrollment As System.Windows.Forms.GroupBox
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim gbEventHandlerStatus As System.Windows.Forms.GroupBox
        Dim lblMaxFingers As System.Windows.Forms.Label
        Dim lblMask As System.Windows.Forms.Label
        Dim gbVerification As System.Windows.Forms.GroupBox
        Dim gbReturnValues As System.Windows.Forms.GroupBox
        Dim lblFalseAcceptRate As System.Windows.Forms.Label
        Me.TxtNAMA = New System.Windows.Forms.TextBox()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.MaxFingers = New System.Windows.Forms.NumericUpDown()
        Me.Mask = New System.Windows.Forms.NumericUpDown()
        Me.EnrollButton = New System.Windows.Forms.Button()
        Me.IsFailure = New System.Windows.Forms.RadioButton()
        Me.IsSuccess = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelSync = New System.Windows.Forms.Label()
        Me.VerifyButton = New System.Windows.Forms.Button()
        Me.Lvw_Data = New System.Windows.Forms.ListView()
        Me.FalseAcceptRate = New System.Windows.Forms.TextBox()
        Me.IsFeatureSetMatched = New System.Windows.Forms.CheckBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelSTATUS = New System.Windows.Forms.Label()
        gbEnrollment = New System.Windows.Forms.GroupBox()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        gbEventHandlerStatus = New System.Windows.Forms.GroupBox()
        lblMaxFingers = New System.Windows.Forms.Label()
        lblMask = New System.Windows.Forms.Label()
        gbVerification = New System.Windows.Forms.GroupBox()
        gbReturnValues = New System.Windows.Forms.GroupBox()
        lblFalseAcceptRate = New System.Windows.Forms.Label()
        gbEnrollment.SuspendLayout()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).BeginInit()
        gbEventHandlerStatus.SuspendLayout()
        gbVerification.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        gbReturnValues.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEnrollment
        '
        gbEnrollment.Controls.Add(Label2)
        gbEnrollment.Controls.Add(Label1)
        gbEnrollment.Controls.Add(Me.TxtNAMA)
        gbEnrollment.Controls.Add(Me.TxtNIK)
        gbEnrollment.Controls.Add(Me.MaxFingers)
        gbEnrollment.Controls.Add(Me.Mask)
        gbEnrollment.Controls.Add(Me.EnrollButton)
        gbEnrollment.Controls.Add(gbEventHandlerStatus)
        gbEnrollment.Controls.Add(lblMaxFingers)
        gbEnrollment.Controls.Add(lblMask)
        gbEnrollment.Dock = System.Windows.Forms.DockStyle.Fill
        gbEnrollment.Location = New System.Drawing.Point(3, 3)
        gbEnrollment.Name = "gbEnrollment"
        gbEnrollment.Size = New System.Drawing.Size(633, 435)
        gbEnrollment.TabIndex = 0
        gbEnrollment.TabStop = False
        gbEnrollment.Text = "Enrollment"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(170, 94)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 20)
        Label2.TabIndex = 9
        Label2.Text = "NAMA"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(170, 68)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(61, 20)
        Label1.TabIndex = 8
        Label1.Text = "NIK"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNAMA
        '
        Me.TxtNAMA.Location = New System.Drawing.Point(237, 94)
        Me.TxtNAMA.Name = "TxtNAMA"
        Me.TxtNAMA.Size = New System.Drawing.Size(209, 20)
        Me.TxtNAMA.TabIndex = 7
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(237, 68)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(209, 20)
        Me.TxtNIK.TabIndex = 6
        '
        'MaxFingers
        '
        Me.MaxFingers.Location = New System.Drawing.Point(334, 222)
        Me.MaxFingers.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Name = "MaxFingers"
        Me.MaxFingers.Size = New System.Drawing.Size(94, 20)
        Me.MaxFingers.TabIndex = 3
        Me.ToolTips.SetToolTip(Me.MaxFingers, "Enter a number from 1 to 10")
        Me.MaxFingers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Mask
        '
        Me.Mask.Location = New System.Drawing.Point(334, 196)
        Me.Mask.Maximum = New Decimal(New Integer() {1023, 0, 0, 0})
        Me.Mask.Name = "Mask"
        Me.Mask.Size = New System.Drawing.Size(94, 20)
        Me.Mask.TabIndex = 1
        Me.ToolTips.SetToolTip(Me.Mask, "Enter a number from 0 to 1023")
        '
        'EnrollButton
        '
        Me.EnrollButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EnrollButton.Location = New System.Drawing.Point(3, 382)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(627, 50)
        Me.EnrollButton.TabIndex = 5
        Me.EnrollButton.Text = "Enroll Fingerprints"
        Me.ToolTips.SetToolTip(Me.EnrollButton, "Start fingerprint enrollment")
        Me.EnrollButton.UseVisualStyleBackColor = True
        '
        'gbEventHandlerStatus
        '
        gbEventHandlerStatus.Controls.Add(Me.IsFailure)
        gbEventHandlerStatus.Controls.Add(Me.IsSuccess)
        gbEventHandlerStatus.Location = New System.Drawing.Point(183, 249)
        gbEventHandlerStatus.Name = "gbEventHandlerStatus"
        gbEventHandlerStatus.Size = New System.Drawing.Size(251, 60)
        gbEventHandlerStatus.TabIndex = 4
        gbEventHandlerStatus.TabStop = False
        gbEventHandlerStatus.Text = "Event handler status"
        '
        'IsFailure
        '
        Me.IsFailure.AutoSize = True
        Me.IsFailure.Location = New System.Drawing.Point(151, 29)
        Me.IsFailure.Name = "IsFailure"
        Me.IsFailure.Size = New System.Drawing.Size(56, 17)
        Me.IsFailure.TabIndex = 1
        Me.IsFailure.TabStop = True
        Me.IsFailure.Text = "Failure"
        Me.ToolTips.SetToolTip(Me.IsFailure, "Force an enrollment failure")
        Me.IsFailure.UseVisualStyleBackColor = True
        '
        'IsSuccess
        '
        Me.IsSuccess.AutoSize = True
        Me.IsSuccess.Location = New System.Drawing.Point(26, 29)
        Me.IsSuccess.Name = "IsSuccess"
        Me.IsSuccess.Size = New System.Drawing.Size(66, 17)
        Me.IsSuccess.TabIndex = 0
        Me.IsSuccess.TabStop = True
        Me.IsSuccess.Text = "Success"
        Me.ToolTips.SetToolTip(Me.IsSuccess, "Allow a successful enrollment")
        Me.IsSuccess.UseVisualStyleBackColor = True
        '
        'lblMaxFingers
        '
        lblMaxFingers.Location = New System.Drawing.Point(180, 223)
        lblMaxFingers.Name = "lblMaxFingers"
        lblMaxFingers.Size = New System.Drawing.Size(148, 20)
        lblMaxFingers.TabIndex = 2
        lblMaxFingers.Text = "Max. enrolled fingers count"
        lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMask
        '
        lblMask.Location = New System.Drawing.Point(180, 197)
        lblMask.Name = "lblMask"
        lblMask.Size = New System.Drawing.Size(148, 20)
        lblMask.TabIndex = 0
        lblMask.Text = "Fingerprint Mask"
        lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbVerification
        '
        gbVerification.Controls.Add(Me.SplitContainer1)
        gbVerification.Controls.Add(gbReturnValues)
        gbVerification.Dock = System.Windows.Forms.DockStyle.Fill
        gbVerification.Location = New System.Drawing.Point(3, 3)
        gbVerification.Name = "gbVerification"
        gbVerification.Size = New System.Drawing.Size(794, 549)
        gbVerification.TabIndex = 1
        gbVerification.TabStop = False
        gbVerification.Text = "Click Me to Absen"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelSync)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VerifyButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 530)
        Me.SplitContainer1.SplitterDistance = 44
        Me.SplitContainer1.TabIndex = 2
        '
        'LabelSync
        '
        Me.LabelSync.AutoSize = True
        Me.LabelSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSync.Location = New System.Drawing.Point(18, 10)
        Me.LabelSync.Name = "LabelSync"
        Me.LabelSync.Size = New System.Drawing.Size(0, 24)
        Me.LabelSync.TabIndex = 2
        '
        'VerifyButton
        '
        Me.VerifyButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerifyButton.Location = New System.Drawing.Point(635, 0)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(153, 44)
        Me.VerifyButton.TabIndex = 1
        Me.VerifyButton.Text = "ABSEN"
        Me.ToolTips.SetToolTip(Me.VerifyButton, "Start fingerprint verification")
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'Lvw_Data
        '
        Me.Lvw_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lvw_Data.Location = New System.Drawing.Point(0, 0)
        Me.Lvw_Data.Name = "Lvw_Data"
        Me.Lvw_Data.Size = New System.Drawing.Size(788, 440)
        Me.Lvw_Data.TabIndex = 2
        Me.Lvw_Data.UseCompatibleStateImageBehavior = False
        '
        'gbReturnValues
        '
        gbReturnValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        gbReturnValues.Controls.Add(Me.FalseAcceptRate)
        gbReturnValues.Controls.Add(lblFalseAcceptRate)
        gbReturnValues.Controls.Add(Me.IsFeatureSetMatched)
        gbReturnValues.Location = New System.Drawing.Point(1020, 350)
        gbReturnValues.Name = "gbReturnValues"
        gbReturnValues.Size = New System.Drawing.Size(779, 100)
        gbReturnValues.TabIndex = 0
        gbReturnValues.TabStop = False
        gbReturnValues.Text = "Return values"
        '
        'FalseAcceptRate
        '
        Me.FalseAcceptRate.Location = New System.Drawing.Point(132, 62)
        Me.FalseAcceptRate.Name = "FalseAcceptRate"
        Me.FalseAcceptRate.ReadOnly = True
        Me.FalseAcceptRate.Size = New System.Drawing.Size(113, 20)
        Me.FalseAcceptRate.TabIndex = 2
        Me.ToolTips.SetToolTip(Me.FalseAcceptRate, "Displays the false accept rate (FAR)")
        '
        'lblFalseAcceptRate
        '
        lblFalseAcceptRate.Location = New System.Drawing.Point(6, 62)
        lblFalseAcceptRate.Name = "lblFalseAcceptRate"
        lblFalseAcceptRate.Size = New System.Drawing.Size(120, 20)
        lblFalseAcceptRate.TabIndex = 1
        lblFalseAcceptRate.Text = "False accept rate"
        lblFalseAcceptRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IsFeatureSetMatched
        '
        Me.IsFeatureSetMatched.AutoCheck = False
        Me.IsFeatureSetMatched.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsFeatureSetMatched.Location = New System.Drawing.Point(6, 32)
        Me.IsFeatureSetMatched.Name = "IsFeatureSetMatched"
        Me.IsFeatureSetMatched.Size = New System.Drawing.Size(139, 24)
        Me.IsFeatureSetMatched.TabIndex = 0
        Me.IsFeatureSetMatched.Text = "Feature set matched?"
        Me.ToolTips.SetToolTip(Me.IsFeatureSetMatched, "Displays a match result")
        Me.IsFeatureSetMatched.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 581)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(gbVerification)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 555)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "     ABSEN     "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(gbEnrollment)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(639, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "   REGISTER   "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Lvw_Data)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.LabelSTATUS)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Size = New System.Drawing.Size(788, 482)
        Me.SplitContainer2.SplitterDistance = 440
        Me.SplitContainer2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(691, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sync To HO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelSTATUS
        '
        Me.LabelSTATUS.AutoSize = True
        Me.LabelSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSTATUS.Location = New System.Drawing.Point(3, 11)
        Me.LabelSTATUS.Name = "LabelSTATUS"
        Me.LabelSTATUS.Size = New System.Drawing.Size(251, 17)
        Me.LabelSTATUS.TabIndex = 3
        Me.LabelSTATUS.Text = "Local database, not sync to server HO"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 581)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET UI Demo"
        gbEnrollment.ResumeLayout(False)
        gbEnrollment.PerformLayout()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).EndInit()
        gbEventHandlerStatus.ResumeLayout(False)
        gbEventHandlerStatus.PerformLayout()
        gbVerification.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        gbReturnValues.ResumeLayout(False)
        gbReturnValues.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents EnrollButton As System.Windows.Forms.Button
    Private WithEvents IsFailure As System.Windows.Forms.RadioButton
    Private WithEvents IsSuccess As System.Windows.Forms.RadioButton
	Private WithEvents VerifyButton As System.Windows.Forms.Button
    Private WithEvents FalseAcceptRate As System.Windows.Forms.TextBox
	Private WithEvents IsFeatureSetMatched As System.Windows.Forms.CheckBox
	Friend WithEvents MaxFingers As System.Windows.Forms.NumericUpDown
	Friend WithEvents Mask As System.Windows.Forms.NumericUpDown
	Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtNAMA As TextBox
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Lvw_Data As ListView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelSync As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelSTATUS As Label
End Class
