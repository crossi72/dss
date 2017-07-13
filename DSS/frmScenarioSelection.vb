Public Class frmScenarioSelection

#Region " Variables "

	Private myScenarioID As Integer

#End Region

#Region " Public property"

	Public ReadOnly Property ScenarioID As Integer
		Get
			Return Me.myScenarioID
		End Get
	End Property

#End Region

#Region " Events management "

	Private Sub frmParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.daData.Fill(Me.DSData)
	End Sub

	Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
		If Me.dgvScenarios.SelectedRows.Count = 1 Then
			Me.myScenarioID = CInt(Me.dgvScenarios.SelectedRows(0).Cells(0).Value)
			Me.DialogResult = Windows.Forms.DialogResult.OK
			Me.Close()
		Else
			MessageBox.Show("Please select one row", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.myScenarioID = 0
		Me.DialogResult = Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

#End Region

#Region " New "

	Public Sub New()

		' Chiamata richiesta dalla finestra di progettazione.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.SqlConnection1.ConnectionString = My.Settings.DSSConnectionString

		Me.myScenarioID = 0
	End Sub

#End Region

End Class