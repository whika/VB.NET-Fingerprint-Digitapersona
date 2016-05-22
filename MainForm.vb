Public Class MainForm

    Private Data As AppData
    Private Enroller As EnrollmentForm
    Private Verifier As VerificationForm
    Private sStatus As String
    Public WithEvents AppData As AppData

    Sub New()
        InitializeComponent()

        Data = New AppData()
        AddHandler Data.OnChange, AddressOf OnDataChange
        Enroller = New EnrollmentForm(Data)
        Verifier = New VerificationForm(Data)
        ExchangeData(False)
    End Sub

    Private Sub OnDataChange()
		ExchangeData(False)
	End Sub

    Private Sub ExchangeData(ByVal read As Boolean)
        If (read) Then
            If (Mask.Text.Length > 0) Then
                Data.EnrolledFingersMask = Mask.Value
            Else
                Data.EnrolledFingersMask = 0
            End If

            If (MaxFingers.Text.Length > 0) Then
                Data.MaxEnrollFingerCount = MaxFingers.Value
            Else
                Data.MaxEnrollFingerCount = 0
            End If

            Data.IsEventHandlerSucceeds = IsSuccess.Checked
            Data.Update()
        Else
            Mask.Value = Data.EnrolledFingersMask
            MaxFingers.Value = Data.MaxEnrollFingerCount
            IsSuccess.Checked = Data.IsEventHandlerSucceeds
            IsFailure.Checked = Not IsSuccess.Checked
            IsFeatureSetMatched.Checked = Data.IsFeatureSetMatched
            FalseAcceptRate.Text = Data.FalseAcceptRate.ToString()
        End If
    End Sub

    Private Sub EnrollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollButton.Click

        If Auth_Login <> "OK" Then
            Me.Hide()
            auth.Show()
        Else
            NIP_Login = TxtNIK.Text
            Nama_Login = TxtNAMA.Text

            If NIP_Login = "" Or Nama_Login = "" Then
                MessageBox.Show("Mohon Input NIK dan NAMA dengan BENAR !", "ERROR REGISTRASI KARYAWAN")
                Return
            End If

            ExchangeData(True)
            Enroller.ShowDialog()

        End If
    End Sub

    Private Sub VerifyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyButton.Click
        ExchangeData(True)
        Verifier.ShowDialog()
    End Sub

    Public Sub awal()
        UpdateListAbsen(Lvw_Data)
        CloseSQLite()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CekDatabaseLite()
        UpdateFPList()
        CloseSQLite()
        awal()
        Timer1.Interval = 100000
        Timer1.Start()
        Timer2.Interval = 1000
        Timer2.Start()

        sStatus = "SYNC IDDLE"

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LabelSync.Text = Now().ToString("yyyy-MM-dd HH:mm:ss") & " "
        LabelSTATUS.Text = sStatus
    End Sub

    Public Sub syncTOHO()
        Try
            If CheckForInternetConnection() Then
                sStatus = "SYNCING TO SERVER HO"
                LabelSTATUS.Text = sStatus
                Dim sSQLPOST As String

                sSQL = "Select * From DataABSEN Where STATUS = 'LOCAL OUT' "

                OpenRecordsetLite(sSQL, DBHARI)

                If readerLite.HasRows Then
                    Do While readerLite.Read
                        sSQLPOST = " Insert into absen (nik, nama, dayabsen, absenin, absenout) Select '" + readerLite("NIK") + "', '" + readerLite("NAMA") + "', '" + readerLite("DAYABSEN") + "', '" + readerLite("absenin") + "', '" + readerLite("absenOUT") + "'"
                        OpenExecutePOST(sSQLPOST)
                    Loop

                    readerLite.Close()

                    Dim sSQLINSERT As String = "UPDATE DataABSEN set STATUS = 'SYNC' Where STATUS = 'LOCAL OUT';"
                    readerLite.Close()
                    CloseSQLite()
                    OpenExecuteLite(sSQLINSERT, DBHARI)
                    awal()
                End If

                sStatus = "SYNC TO SERVER HAS DONE - BERHASIL"
            End If
        Catch ex As Exception
            sStatus = "SYNC TO SERVER HAS ERROR CONNECTIONS - GAGAL"
        End Try
        LabelSTATUS.Text = sStatus
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        syncTOHO()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        syncTOHO()
    End Sub
End Class
