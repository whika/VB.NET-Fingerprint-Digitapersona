Public Class EnrollmentForm

    Public Data As AppData

	Sub New(ByVal data As AppData)
		InitializeComponent()
		Me.Data = data
		ExchangeData(False)
		AddHandler Data.OnChange, AddressOf OnDataChange
	End Sub

	Private Sub OnDataChange()
		ExchangeData(False)
	End Sub

    Public Sub ExchangeData(ByVal read As Boolean)
        UpdateFPList()
    End Sub

    Sub OnEnroll(ByVal Control As Object, ByVal Finger As Integer, ByVal Template As DPFP.Template, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles EnrollmentControl.OnEnroll
        If (Data.IsEventHandlerSucceeds) Then

            Dim sNO As String = 0
            If Not Template Is Nothing Then
                sNO = sNO + 1
                INSERT_USER(sNO, NIP_Login, Nama_Login, Template.Bytes)
            End If


            Data.Templates = Template
            ExchangeData(True)
        Else
            EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
		End If
	End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub EnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class