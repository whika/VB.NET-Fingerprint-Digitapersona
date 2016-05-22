Public Class VerificationForm

    Public Data As AppData

	Sub New(ByVal data As AppData)
		InitializeComponent()
		Me.Data = data
	End Sub

	Sub OnComplete(ByVal Control As Object, ByVal FeatureSet As DPFP.FeatureSet, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles VerificationControl.OnComplete
		Dim ver As New DPFP.Verification.Verification()
		Dim res As New DPFP.Verification.Verification.Result()
        Dim template As DPFP.Template
        Dim cekDATA As Boolean = False

        For Each FPData As AppData In FPList
            template = FPData.Templates   ' Compare feature set with all stored templates:
            If Not template Is Nothing Then                     '   Get template from storage.
                ver.Verify(FeatureSet, template, res)           '   Compare feature set with particular template.
                Data.IsFeatureSetMatched = res.Verified         '   Check the result of the comparison
                Data.FalseAcceptRate = res.FARAchieved          '   Determine the current False Accept Rate
                If res.Verified Then
                    EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Success
                    MessageBox.Show("ABSEN BERHASIL " + FPData.Nama)
                    NIP_Login = FPData.NIK
                    Nama_Login = FPData.Nama
                    cekDATA = True
                    Exit For
                End If
            End If
        Next
        If cekDATA Then

            Dim sSQLINSERT As String

            sSQL = "Select * From DataABSEN Where NIK = '" + NIP_Login + "' And NAMA ='" + Nama_Login + "' And  DAYABSEN = '" + Now().ToString("yyyyMMdd") + "' And STATUS = 'LOCAL IN';"

            OpenRecordsetLite(sSQL, DBHARI)

            If readerLite.HasRows Then
                sSQLINSERT = "UPDATE DataABSEN set AbsenOUT = '" + Now().ToString("yyyy-MM-dd HH:mm:ss") + "', STATUS = 'LOCAL OUT' Where NIK = '" + NIP_Login + "' And NAMA ='" + Nama_Login + "' And  DAYABSEN = '" + Now().ToString("yyyyMMdd") + "';"
            Else
                sSQLINSERT = "INSERT INTO DataABSEN VALUES('" + NIP_Login + "', '" + Nama_Login + "', '" + Now().ToString("yyyyMMdd") + "', '" + Now().ToString("yyyy-MM-dd HH:mm:ss") + "', '" + Now().ToString("yyyy-MM-dd HH:mm:ss") + "', 'LOCAL IN');"
            End If

            readerLite.Close()
            CloseSQLite()
            OpenExecuteLite(sSQLINSERT, DBHARI)
            MainForm.awal()
            Me.Close()
        End If
        If Not res.Verified Then EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
		Data.Update()
	End Sub

    Private Sub VerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class