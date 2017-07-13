Public Class frmNegotiation

#Region " Variables and constants "

	Private dummy As Double

	Private myMathWrapper As MW.MathWrapper

	Private groupBoxesID As Integer
	Private groupBoxes(6) As DSSTGroupBox

	'graph range limit
	Dim graph1Range, graph2Range, graph3Range, graph4Range, graph5Range, graph6Range As Double

	'mathematica algorithm variables
	Private DE, DU, Y, FR, S1, S2, S3, E11, E21, E31, E12, E22, E13, E23 As Double
	Private W11, B11, e11r, i11x, se13x, se23x, p, t, z, zz, m As Double
	Private W21, W31, W22, W13, W23, B21, B31, B22, B13, B23 As String
	Private W12, B12 As Double
	Private v1, v2, v3, v4, v5, v6, v7, v8, a1, a2, a3, a4, a5, a6, a7, a8 As Double
	Private b1, b2, b3, b4, b5, b6, b7, b8, Tecnune1, Tecnune2, Tecnune3, Tecnune4 As Double
	Private Tecnlan1, Tecnlan2, Tecnlan3, Tecnlan4 As Double
	Private c, d, Teclspe1, Teclspe2, Teclspe3, Teclspe4 As Double
	Private Teclhab1du, Teclhab2du, Teclhab3du, Teclhab4du, Tsclhea1, Tsclhea2, Tsclhea3, Tsclhea4 As Double
	Private Tsclsoc1, Tsclsoc2, Tsclsoc3, Tsclsoc4 As Double
	Private COs, COe, COi, COse, COsi, COei, COsei As Double
	Private Xs, Xe, Xi, Xse, Xsi, Xei, Xsei As Double
	Private RXs, RXe, RXi, RXse, RXsi, RXei, RXsei As Double
	Private RTecnune, RTecnlan, RTeclspe, RTeclhab As Double
	Private RTsclhea, RTsclsoc As Double
	Private RTecnuneQ, RTecnlanQ, RTeclspeQ, RTeclhabQ As String
	Private RTsclheaQ, RTsclsocQ As String
	Private F11, F11s, F11e, F11i, F11se, F11si, F11ei, F11sei As Double
	Private F21, F31, F12, F22, F13, F23 As String
	Private F21s, F31s, F22s, F13s, F23s, F21e, F31e, F22e, F13e, F23e As String
	Private F12s, F12e, F12i, F12se, F12si, F12ei, F12sei As String
	Private F21i, F31i, F22i, F13i, F23i, F21se, F31se, F22se, F13se, F23se As String
	Private F21si, F31si, F22si, F13si, F23si, F21ei, F31ei, F22ei, F13ei, F23ei As String
	Private F21sei, F31sei, F22sei, F13sei, F23sei As String
	Private R11, R11s, R11e, R11i, R11se, R11si, R11ei, R11sei As Double
	Private R21, R31, R12, R22, R13, R23 As Double
	Private R21s, R31s, R22s, R13s, R23s, R21e, R31e, R22e, R13e, R23e As Double
	Private R12s, R12e, R12i, R12se, R12si, R12ei, R12sei As Double
	Private R21i, R31i, R22i, R13i, R23i, R21se, R31se, R22se, R13se, R23se As Double
	Private R21si, R31si, R22si, R13si, R23si, R21ei, R31ei, R22ei, R13ei, R23ei As Double
	Private R21sei, R31sei, R22sei, R13sei, R23sei As Double
	Private B21n, W21n, B31n, W31n, B12n, W12n, B22n, W22n, B13n, W13n, B23n, W23n As Double
	Private outputExposure(6) As structOutput
	Private outputResilience(6) As structOutput

	Private Structure structOutput
		Implements IComparable(Of structOutput)

		Public label As String
		Public value As Double

		Public Function CompareTo(ByVal other As structOutput) As Integer Implements System.IComparable(Of structOutput).CompareTo
			If Me.value = other.value Then
				Return 0
			Else
				If Me.value < other.value Then
					Return 1
				Else
					Return -1
				End If
			End If
		End Function
	End Structure

	Private Enum enumGraph
		graph0
		graph1
		graph2
		graph3
		graph4
		graph5
		graph6
	End Enum

#End Region

#Region " New "

	Public Sub New()
		' Chiamata richiesta da Progettazione Windows Form.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.SqlConnection1.ConnectionString = My.Settings.DSSConnectionString
		Me.SetComboValues()
		If Me.Init() Then
			'init groupBoxes array
			Me.groupBoxes(0) = Me.grbEconomists
			Me.groupBoxes(1) = Me.grbWeigth
			Me.groupBoxes(2) = Me.grbEngineers
			Me.groupBoxes(3) = Me.grbEcologists
			Me.groupBoxes(4) = Me.grbSociologists
			Me.groupBoxes(5) = Me.grbInterdependencies
			Me.groupBoxes(6) = Me.grbSummary

			Me.groupBoxesID = 0
			Me.ShowBox()
		Else
			End
		End If
	End Sub

#End Region

#Region " Private methods "

	Private Sub PrepareOutput()
		Me.outputExposure(0).value = Me.Xs
		Me.outputExposure(0).label = "Sand"
		Me.outputExposure(1).value = Me.Xe
		Me.outputExposure(1).label = "Evacuation"
		Me.outputExposure(2).value = Me.Xi
		Me.outputExposure(2).label = "Insurance"
		Me.outputExposure(3).value = Me.Xse
		Me.outputExposure(3).label = "Sand && Evacuation"
		Me.outputExposure(4).value = Me.Xsi
		Me.outputExposure(4).label = "Sand && Insurance"
		Me.outputExposure(5).value = Me.Xei
		Me.outputExposure(5).label = "Evacuation && Insurance"
		Me.outputExposure(6).value = Me.Xsei
		Me.outputExposure(6).label = "Sand && Evacuation && Insurance"
		Array.Sort(Me.outputExposure)
		Me.outputResilience(0).value = Me.RXs
		Me.outputResilience(0).label = "Sand"
		Me.outputResilience(1).value = Me.RXe
		Me.outputResilience(1).label = "Evacuation"
		Me.outputResilience(2).value = Me.RXi
		Me.outputResilience(2).label = "Insurance"
		Me.outputResilience(3).value = Me.RXse
		Me.outputResilience(3).label = "Sand && Evacuation"
		Me.outputResilience(4).value = Me.RXsi
		Me.outputResilience(4).label = "Sand && Insurance"
		Me.outputResilience(5).value = Me.RXei
		Me.outputResilience(5).label = "Evacuation && Insurance"
		Me.outputResilience(6).value = Me.RXsei
		Me.outputResilience(6).label = "Sand && Evacuation && Insurance"
		Array.Sort(Me.outputResilience)
	End Sub

	''' <summary>
	''' convert a double to corresponding string
	''' </summary>
	''' <param name="value"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function NumberAsString(ByVal value As Double) As String
		Return value.ToString.Replace(","c, "."c)
	End Function

	''' <summary>
	''' set values for all comboboxes in grbGeneric
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetComboValues()
		Dim ctl, gbo As Control
		Dim comboValues As New ArrayList()
		Dim tmpTable As DataTable

		For Each gbo In Me.Controls
			If TypeOf (gbo) Is GroupBox Then
				For Each ctl In gbo.Controls
					If TypeOf (ctl) Is ComboBox Then
						tmpTable = New DataTable

						tmpTable.Columns.Add("value")
						tmpTable.Columns.Add("display")
						tmpTable.Rows.Add("N", "N")
						tmpTable.Rows.Add("L", "L")
						tmpTable.Rows.Add("M", "M")
						tmpTable.Rows.Add("H", "H")
						tmpTable.Rows.Add("P", "P")

						DirectCast(ctl, ComboBox).DataSource = tmpTable
						DirectCast(ctl, ComboBox).DisplayMember = "display"
						DirectCast(ctl, ComboBox).ValueMember = "value"
					End If
				Next
			End If
		Next
	End Sub

	''' <summary>
	''' execute computation using Wolfram Mathematica kernel
	''' </summary>
	''' <remarks></remarks>
	Private Sub Calculate()
		Me.ReadValuesFromGUI()

		Me.daData.Fill(Me.DSData)

		Me.myMathWrapper.WaitAndDiscardAnswer("RTecnuneN = Which[RTecnuneQ == ""N"", 0, RTecnuneQ == ""L"", 0.25, RTecnuneQ == ""M"", 0.5, RTecnuneQ == ""H"", 0.75, RTecnuneQ == ""P"", 1]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTecnlanN = Which[RTecnlanQ == ""N"", 0, RTecnlanQ == ""L"", 0.25, RTecnlanQ == ""M"", 0.5, RTecnlanQ == ""H"", 0.75, RTecnlanQ == ""P"", 1]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTeclspeN = Which[RTeclspeQ == ""N"", 0, RTeclspeQ == ""L"", 0.25, RTeclspeQ == ""M"", 0.5, RTeclspeQ == ""H"", 0.75, RTeclspeQ == ""P"", 1]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTeclhabN = Which[RTeclhabQ == ""N"", 0, RTeclhabQ == ""L"", 0.25, RTeclhabQ == ""M"", 0.5, RTeclhabQ == ""H"", 0.75, RTeclhabQ == ""P"", 1]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTsclheaN = Which[RTsclheaQ == ""N"", 0, RTsclheaQ == ""L"", 0.25, RTsclheaQ == ""M"", 0.5, RTsclheaQ == ""H"", 0.75, RTsclheaQ == ""P"", 1]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTsclsocN = Which[RTsclsocQ == ""N"", 0, RTsclsocQ == ""L"", 0.25, RTsclsocQ == ""M"", 0.5, RTsclsocQ == ""H"", 0.75, RTsclsocQ == ""P"", 1]")

		Me.myMathWrapper.WaitAndDiscardAnswer("B11n = 0")
		Me.myMathWrapper.WaitAndDiscardAnswer("W11n = 1")

		Me.myMathWrapper.WaitAndDiscardAnswer("W11 = (v1*a1*b1 + v2*a2*b2 + v3*a3*b3 + v4*a4*b4 + v5*a5*b5 + v6*a6*b6 + v7*a7*b7 + v8*a8*b8)*30*Sqrt[1.5]")

		Me.myMathWrapper.WaitAndDiscardAnswer("B21n = Which[B21 == ""N"", 0, B21 == ""L"", 1, B21 == ""M"", 2, B21 == ""H"", 3, B21 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("W21n = Which[W21 == ""N"", 0, W21 == ""L"", 1, W21 == ""M"", 2, W21 == ""H"", 3, W21 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("B31n = Which[B31 == ""N"", 0, B31 == ""L"", 1, B31 == ""M"", 2, B31 == ""H"", 3, B31 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("W31n = Which[W31 == ""N"", 0, W31 == ""L"", 1, W31 == ""M"", 2, W31 == ""H"", 3, W31 == ""P"", 4]/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("B12n = B12")
		Me.myMathWrapper.WaitAndDiscardAnswer("W12n = W12")
		Me.myMathWrapper.WaitAndDiscardAnswer("B22n = Which[B22 == ""N"", 0, 22 == ""L"", 1, 22 == ""M"", 2, 22 == ""H"", 3, 22 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("W22n = Which[W22 == ""N"", 0, W22 == ""L"", 1, W22 == ""M"", 2, W22 == ""H"", 3, W22 == ""P"", 4]/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("B13n = Which[B13 == ""N"", 0, B13 == ""L"", 1, B13 == ""M"", 2, B13 == ""H"", 3, B13 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("W13n = Which[W13 == ""N"", 0, W13 == ""L"", 1, W13 == ""M"", 2, W13 == ""H"", 3, W13 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("B23n = Which[B23 == ""N"", 0, B23 == ""L"", 1, B23 == ""M"", 2, B23 == ""H"", 3, B23 == ""P"", 4]/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("W23n = Which[W23 == ""N"", 0, W23 == ""L"", 1, W23 == ""M"", 2, W23 == ""H"", 3, W23 == ""P"", 4]/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("Dummy = (v1*a1*b1 + v2*a2*b2 + v3*a3*b3 + v4*a4*b4 + v5*a5*b5 + v6*a6*b6 + v7*a7*b7 + v8*a8*b8)")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11 = Dummy*DU*Sqrt[DE]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11s = Dummy*(1 - d) DU*Sqrt[(1 - c) DE] + COs")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11e = Dummy*DU*Sqrt[DE] + COe")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11i = If[z == 1, Dummy*DU*Sqrt[DE]*(1 - i11x) + COi, z*W11 + COi]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11se = Dummy*(1 - d) DU*Sqrt[(1 - c) DE] + COse")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11si = If[z == 1, Dummy*(1 - d) DU* Sqrt[(1 - c) DE]*(1 - i11x) + COsi, z*W11*(1 - i11x) + COsi]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11ei = If[z == 1, Dummy*DU*Sqrt[DE]*(1 - i11x) + COei, z*W11*(1 - i11x) + COei]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11sei = If[z == 1, Dummy*(1 - d) DU* Sqrt[(1 - c) DE]*(1 - i11x) + COsei, z*W11*(1 - i11x) + COsei]")

		Me.myMathWrapper.WaitAndDiscardAnswer("F21 = If[DE <= Tecnune1, ""N"", If[DE <= Tecnune2, ""L"", If[DE <= Tecnune3, ""M"", If[DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21s = If[(1 - c) DE <= Tecnune1, ""N"", If[(1 - c) DE <= Tecnune2, ""L"", If[(1 - c) DE <= Tecnune3, ""M"", If[(1 - c) DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21e = If[DE <= Tecnune1, ""N"", If[DE <= Tecnune2, ""L"", If[DE <= Tecnune3, ""M"", If[DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21i = If[DE <= Tecnune1, ""N"", If[DE <= Tecnune2, ""L"", If[DE <= Tecnune3, ""M"", If[DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21se = If[(1 - c) DE <= Tecnune1, ""N"", If[(1 - c) DE <= Tecnune2, L, If[(1 - c) DE <= Tecnune3, ""M"", If[(1 - c) DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21si = If[(1 - c) DE <= Tecnune1, ""N"", If[(1 - c) DE <= Tecnune2, L, If[(1 - c) DE <= Tecnune3, ""M"", If[(1 - c) DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21ei = If[DE <= Tecnune1, ""N"", If[DE <= Tecnune2, ""L"", If[DE <= Tecnune3, ""M"", If[DE <= Tecnune4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F21sei = If[(1 - c) DE <= Tecnune1, ""N"", If[(1 - c) DE <= Tecnune2, ""L"", If[(1 - c) DE <= Tecnune3, ""M"", If[(1 - c) DE <= Tecnune4, ""H"", ""P""]]]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("F31 = If[DE <= Tecnlan1, ""N"", If[DE <= Tecnlan2, ""L"", If[DE <= Tecnlan3, ""M"", If[DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31s = If[(1 - c) DE <= Tecnlan1, ""N"", If[(1 - c) DE <= Tecnlan2, ""L"", If[(1 - c) DE <= Tecnlan3, ""M"", If[(1 - c) DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31e = If[DE <= Tecnlan1, ""N"", If[DE <= Tecnlan2, ""L"", If[DE <= Tecnlan3, ""M"", If[DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31i = If[DE <= Tecnlan1, ""N"", If[DE <= Tecnlan2, ""L"", If[DE <= Tecnlan3, ""M"", If[DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31se = If[(1 - c) DE <= Tecnlan1, ""N"", If[(1 - c) DE <= Tecnlan2, ""L"", If[(1 - c) DE <= Tecnlan3, ""M"", If[(1 - c) DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31si = If[(1 - c) DE <= Tecnlan1, ""N"", If[(1 - c) DE <= Tecnlan2, ""L"", If[(1 - c) DE <= Tecnlan3, ""M"", If[(1 - c) DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31ei = If[DE <= Tecnlan1, ""N"", If[DE <= Tecnlan2, ""L"", If[DE <= Tecnlan3, ""M"", If[DE <= Tecnlan4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F31sei = If[(1 - c) DE <= Tecnlan1, ""N"", If[(1 - c) DE <= Tecnlan2, ""L"", If[(1 - c) DE <= Tecnlan3, ""M"", If[(1 - c) DE <= Tecnlan4, ""H"", ""P""]]]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("F12 = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12s = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12e = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12i = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12se = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12si = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12ei = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F12sei = If[DE <= Teclspe1, ""I1"", If[DE <= Teclspe2, ""I2"", If[DE <= Teclspe3, ""I3"", If[DE <= Teclspe4, ""I4"", ""I5""]]]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("F22 = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22s = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22e = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22i = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22se = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22si = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22ei = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F22sei = If[DU <= Teclhab1du, ""N"", If[DU <= Teclhab2du, ""L"", If[DU <= Teclhab3du, ""M"", If[DU <= Teclhab4du, ""H"", ""P""]]]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("F13 = If[DU <= Tsclhea1, ""N"", If[DU <= Tsclhea2, ""L"", If[DU <= Tsclhea3, ""M"", If[DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13s = If[(1 - d) DU <= Tsclhea1, ""N"", If[(1 - d) DU <= Tsclhea2, ""L"", If[(1 - d) DU <= Tsclhea3, ""M"", If[(1 - d) DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13e = If[DU <= Tsclhea1, ""N"", If[DU <= Tsclhea2, ""L"", If[DU <= Tsclhea3, ""M"", If[DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13i = If[DU <= Tsclhea1, ""N"", If[DU <= Tsclhea2, ""L"", If[DU <= Tsclhea3, ""M"", If[DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13se = If[(1 - d) DU <= Tsclhea1, ""N"", If[(1 - d) DU <= Tsclhea2, ""L"", If[(1 - d) DU <= Tsclhea3, ""M"", If[(1 - d) DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13si = If[(1 - d) DU <= Tsclhea1, ""N"", If[(1 - d) DU <= Tsclhea2, ""L"", If[(1 - d) DU <= Tsclhea3, ""M"", If[(1 - d) DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13ei = If[DU <= Tsclhea1, ""N"", If[DU <= Tsclhea2, ""L"", If[DU <= Tsclhea3, ""M"", If[DU <= Tsclhea4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F13sei = If[(1 - d) DU <= Tsclhea1, ""N"", If[(1 - d) DU <= Tsclhea2, ""L"", If[(1 - d) DU <= Tsclhea3, ""M"", If[(1 - d) DU <= Tsclhea4, ""H"", ""P""]]]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("F23 = If[DU <= Tsclsoc1, ""N"", If[DU <= Tsclsoc2, ""L"", If[DU <= Tsclsoc3, ""M"", If[DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23s = If[(1 - d) DU <= Tsclsoc1, ""N"", If[(1 - d) DU <= Tsclsoc2, ""L"", If[(1 - d) DU <= Tsclsoc3, ""M"", If[(1 - d) DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23e = If[DU <= Tsclsoc1, ""N"", If[DU <= Tsclsoc2, ""L"", If[DU <= Tsclsoc3, ""M"", If[DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23i = If[DU <= Tsclsoc1, ""N"", If[DU <= Tsclsoc2, ""L"", If[DU <= Tsclsoc3, ""M"", If[DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23se = If[(1 - d) DU <= Tsclsoc1, ""N"", If[(1 - d) DU <= Tsclsoc2, ""L"", If[(1 - d) DU <= Tsclsoc3, ""M"", If[(1 - d) DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23si = If[(1 - d) DU <= Tsclsoc1, ""N"", If[(1 - d) DU <= Tsclsoc2, ""L"", If[(1 - d) DU <= Tsclsoc3, ""M"", If[(1 - d) DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23ei = If[DU <= Tsclsoc1, ""N"", If[DU <= Tsclsoc2, ""L"", If[DU <= Tsclsoc3, ""M"", If[DU <= Tsclsoc4, ""H"", ""P""]]]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F23sei = If[(1 - d) DU <= Tsclsoc1, ""N"", If[(1 - d) DU <= Tsclsoc2, ""L"", If[(1 - d) DU <= Tsclsoc3, ""M"", If[(1 - d) DU <= Tsclsoc4, ""H"", ""P""]]]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X11s = F11s/W11")
		Me.myMathWrapper.WaitAndDiscardAnswer("X11e = F11e/W11")
		Me.myMathWrapper.WaitAndDiscardAnswer("X11i = F11i/W11")
		Me.myMathWrapper.WaitAndDiscardAnswer("X11se = F11se/W11")
		Me.myMathWrapper.WaitAndDiscardAnswer("X11si = F11si/W11")
		Me.myMathWrapper.WaitAndDiscardAnswer("X11ei = F11ei/W11")
		Me.myMathWrapper.WaitAndDiscardAnswer("X11sei = F11sei/W11")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX11 = If[(F11/FR + F11*m)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11s = If[(F11/FR + COs)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11e = If[((1 - e11r) F11/FR + COe)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11i = If[(zz*F11/FR + F11*m + COi)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11se = If[((1 - e11r) F11/FR + COse)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11si = If[(zz*F11/FR + F11*m + COsi)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11ei = If[(zz*(1 - e11r) F11/FR + (1 - e11r) F11*m + COei)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX11sei = If[(zz*(1 - e11r) F11/FR + (1 - e11r) F11*m + COsei)/(v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8) < 0.2, 1, 0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F21 == ""N"", (G121 = 1) && (G221 = 0) && (G321 = 0) && (G421 = 0) && (G521 = 0), F21 == ""L"", (G121 = 0) && (G221 = 1) && (G321 = 0) && (G421 = 0) && (G521 = 0), F21 == ""M"", (G121 = 0) && (G221 = 0) && (G321 = 1) && (G421 = 0) && (G521 = 0), F21 == ""H"", (G121 = 0) && (G221 = 0) && (G321 = 0) && (G421 =  1) && (G521 = 0), F21 == ""P"", (G121 = 0) && (G221 = 0) && (G321 = 0) && (G421 = 0) && (G521 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F21s == ""N"", (G121s = 1) && (G221s = 0) && (G321s = 0) && (G421s = 0) && (G521s = 0), F21s == ""L"", (G121s = 0) && (G221s = 1) && (G321s = 0) && (G421s = 0) && (G521s = 0), F21s == ""M"", (G121s = 0) && (G221s = 0) && (G321s = 1) && (G421s = 0) && (G521s = 0), F21s == ""H"", (G121s = 0) && (G221s = 0) && (G321s = 0) && (G421s = 1) && (G521s = 0), F21s == ""P"", (G121s = 0) && (G221s = 0) && (G321s = 0) && (G421s = 0) && (G521s = 1)]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X21 = (0*G121 + 1*G221 + 2*G321 + 3*G421 + 4*G521)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21s = (0*G121s + 1*G221s + 2*G321s + 3*G421s + 4*G521s)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21e = (0*G121 + 1*G221 + 2*G321 + 3*G421 + 4*G521)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21i = (0*G121 + 1*G221 + 2*G321 + 3*G421 + 4*G521)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21se = (0*G121s + 1*G221s + 2*G321s + 3*G421s + 4*G521s)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21si = (0*G121s + 1*G221s + 2*G321s + 3*G421s + 4*G521s)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21ei = (0*G121 + 1*G221 + 2*G321 + 3*G421 + 4*G521)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X21sei = (0*G121s + 1*G221s + 2*G321s + 3*G421s + 4*G521s)/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX21=If[X21<RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21s=If[X21s < RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21e=If[X21e < RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21i=If[X21i < RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21se=If[X21se < RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21si=If[X21si < RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21ei=If[X21ei < RTecnuneN && FR>RTecnune,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX21sei=If[X21sei < RTecnuneN && FR>RTecnune,1,0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F31 == ""N"", (G131 = 1) && (G231 = 0) && (G331 = 0) && (G431 = 0) && (G531 = 0), F31 == ""L"", (G131 = 0) && (G231 = 1) && (G331 = 0) && (G431 = 0) && (G531 = 0), F31 == ""M"", (G131 = 0) && (G231 = 0) && (G331 = 1) && (G431 = 0) && (G531 = 0), F31 == ""H"", (G131 = 0) && (G231 = 0) && (G331 = 0) && (G431 = 1) && (G531 = 0), F31 == ""P"", (G131 = 0) && (G231 = 0) && (G331 = 0) && (G431 = 0) && (G531 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F31s == ""N"", (G131s = 1) && (G231s = 0) && (G331s = 0) && (G431s = 0) && (G531s = 0), F31s == ""L"", (G131s = 0) && (G231s = 1) && (G331s = 0) && (G431s = 0) && (G531s = 0), F31s == ""M"", (G131s = 0) && (G231s = 0) && (G331s = 1) && (G431s = 0) && (G531s = 0), F31s == ""H"", (G131s = 0) && (G231s = 0) && (G331s = 0) && (G431s = 1) && (G531s = 0), F31s == ""P"", (G131s = 0) && (G231s = 0) && (G331s = 0) && (G431s = 0) && (G531s = 1)]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X31 = (0*G131 + 1*G231 + 2*G331 + 3*G431 + 4*G531)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31s = (0*G131s + 1*G231s + 2*G331s + 3*G431s + 4*G531s)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31e = (0*G131 + 1*G231 + 2*G331 + 3*G431 + 4*G531)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31i = (0*G131 + 1*G231 + 2*G331 + 3*G431 + 4*G531)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31se = (0*G131s + 1*G231s + 2*G331s + 3*G431s + 4*G531s)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31si = (0*G131s + 1*G231s + 2*G331s + 3*G431s + 4*G531s)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31ei = (0*G131 + 1*G231 + 2*G331 + 3*G431 + 4*G531)/4")
		Me.myMathWrapper.WaitAndDiscardAnswer("X31sei = (0*G131s + 1*G231s + 2*G331s + 3*G431s + 4*G531s)/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX31=If[X31<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31s=If[X31s<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31e=If[X31e<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31i=If[X31i<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31se=If[X31se<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31si=If[X31si<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31ei=If[X31ei<RTecnlanN&&FR>RTecnlan,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX31sei=If[X31sei<RTecnlanN&&FR>RTecnlan,1,0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("DB1s = Sqrt[E11*(X11s-B11n)^2+E21*(X21s-B21n)^2+E31*(X31s-B31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB1e=Sqrt[E11*(X11e-B11n)^2+E21*(X21e-B21n)^2+E31*(X31e-B31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB1i=Sqrt[E11*(X11i-B11n)^2+E21*(X21i-B21n)^2+E31*(X31i-B31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB1se=Sqrt[E11*(X11se-B11n)^2+E21*(X21se-B21n)^2+E31*(X31se-B31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB1si=Sqrt[E11*(X11si-B11n)^2+E21*(X21si-B21n)^2+E31*(X31si-B31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB1ei=Sqrt[E11*(X11ei-B11n)^2+E21*(X21ei-B21n)^2+E31*(X31ei-B31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB1sei=Sqrt[E11*(X11sei-B11n)^2+E21*(X21sei-B21n)^2+E31*(X31sei-B31n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1s=Sqrt[E11*(RX11s-RB11n)^2+E21*(RX21s-RB21n)^2+E31*(RX31s-RB31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1e=Sqrt[E11*(RX11e-RB11n)^2+E21*(RX21e-RB21n)^2+E31*(RX31e-RB31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1i=Sqrt[E11*(RX11i-RB11n)^2+E21*(RX21i-RB21n)^2+E31*(RX31i-RB31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1se=Sqrt[E11*(RX11se-RB11n)^2+E21*(RX21se-RB21n)^2+E31*(RX31se-RB31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1si=Sqrt[E11*(RX11si-RB11n)^2+E21*(RX21si-RB21n)^2+E31*(RX31si-RB31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1ei=Sqrt[E11*(RX11ei-RB11n)^2+E21*(RX21ei-RB21n)^2+E31*(RX31ei-RB31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB1sei=Sqrt[E11*(RX11sei-RB11n)^2+E21*(RX21sei-RB21n)^2+E31*(RX31sei-RB31n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("DW1s=Sqrt[E11*(X11s-W11n)^2+E21*(X21s-W21n)^2+E31*(X31s-W31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW1e=Sqrt[E11*(X11e-W11n)^2+E21*(X21e-W21n)^2+E31*(X31e-W31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW1i=Sqrt[E11*(X11i-W11n)^2+E21*(X21i-W21n)^2+E31*(X31i-W31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW1se=Sqrt[E11*(X11se-W11n)^2+E21*(X21se-W21n)^2+E31*(X31se-W31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW1si=Sqrt[E11*(X11si-W11n)^2+E21*(X21si-W21n)^2+E31*(X31si-W31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW1ei=Sqrt[E11*(X11ei-W11n)^2+E21*(X21ei-W21n)^2+E31*(X31ei-W31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW1sei=Sqrt[E11*(X11sei-W11n)^2+E21*(X21sei-W21n)^2+E31*(X31sei-W31n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1s=Sqrt[E11*(RX11s-RW11n)^2+E21*(RX21s-RW21n)^2+E31*(RX31s-RW31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1e=Sqrt[E11*(RX11e-RW11n)^2+E21*(RX21e-RW21n)^2+E31*(RX31e-RW31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1i=Sqrt[E11*(RX11i-RW11n)^2+E21*(RX21i-RW21n)^2+E31*(RX31i-RW31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1se=Sqrt[E11*(RX11se-RW11n)^2+E21*(RX21se-RW21n)^2+E31*(RX31se-RW31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1si=Sqrt[E11*(RX11si-RW11n)^2+E21*(RX21si-RW21n)^2+E31*(RX31si-RW31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1ei=Sqrt[E11*(RX11ei-RW11n)^2+E21*(RX21ei-RW21n)^2+E31*(RX31ei-RW31n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW1sei=Sqrt[E11*(RX11sei-RW11n)^2+E21*(RX21sei-RW21n)^2+E31*(RX31sei-RW31n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F12 == ""I1"", (G112 = 1) && (G212 = 0) && (G312 = 0) && (G412 = 0) && (G512 = 0), F12 == ""I2"", (G112 = 0) && (G212 = 1) && (G312 = 0) && (G412 = 0) && (G512 = 0), F12 == ""I3"", (G112 = 0) && (G212 = 0) && (G312 = 1) && (G412 = 0) && (G512 = 0), F12 == ""I4"", (G112 = 0) && (G212 = 0) && (G312 = 0) && (G412 = 1) && (G512 = 0), F12 == ""I5"", (G112 = 0) && (G212 = 0) && (G312 = 0) && (G412 = 0) && (G512 = 1)]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X12 = (0*G112 + 1*G212 + 2*G312 + 3*G412 + 4*G512)/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX12=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12s=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12e=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12i=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12se=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12si=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12ei=If[X12<RTeclspeN && FR>RTeclspe,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX12sei=If[X12<RTeclspeN && FR>RTeclspe,1,0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F22 == ""N"", (G122 = 1) && (G222 = 0) && (G322 = 0) && (G422 = 0) && (G522 = 0), F22 == ""L"", (G122 = 0) && (G222 = 1) && (G322 = 0) && (G422 = 0) && (G522 = 0), F22 == ""M"", (G122 = 0) && (G222 = 0) && (G322 = 1) && (G422 = 0) && (G522 = 0), F22 == ""H"", (G122 = 0) && (G222 = 0) && (G322 = 0) && (G422 = 1) && (G522 = 0), F22 == ""P"", (G122 = 0) && (G222 = 0) && (G322 = 0) && (G422 = 0) && (G522 = 1)]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X22=(0*G122+1*G222+2*G322+3*G422+4*G522)/4")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX22=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22s=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22e=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22i=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22se=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22si=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22ei=If[X22<RTeclhabN && FR>RTeclhab,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX22sei=If[X22<RTeclhabN && FR>RTeclhab,1,0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("DB2s=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB2e=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB2i=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB2se=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB2si=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB2ei=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB2sei=Sqrt[E12*(X12-B12n)^2+E22*(X22-B22n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2s=Sqrt[E12*(RX12s-RB12n)^2+E22*(RX22s-RB22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2e=Sqrt[E12*(RX12e-RB12n)^2+E22*(RX22e-RB22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2i=Sqrt[E12*(RX12i-RB12n)^2+E22*(RX22i-RB22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2se=Sqrt[E12*(RX12se-RB12n)^2+E22*(RX22se-RB22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2si=Sqrt[E12*(RX12si-RB12n)^2+E22*(RX22si-RB22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2ei=Sqrt[E12*(RX12ei-RB12n)^2+E22*(RX22ei-RB22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB2sei=Sqrt[E12*(RX12sei-RB12n)^2+E22*(RX22sei-RB22n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("DW2s=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW2e=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW2i=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW2se=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW2si=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW2ei=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW2sei=Sqrt[E12*(X12-W12n)^2+E22*(X22-W22n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2s=Sqrt[E12*(RX12s-RW12n)^2+E22*(RX22s-RW22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2e=Sqrt[E12*(RX12e-RW12n)^2+E22*(RX22e-RW22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2i=Sqrt[E12*(RX12i-RW12n)^2+E22*(RX22i-RW22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2se=Sqrt[E12*(RX12se-RW12n)^2+E22*(RX22se-RW22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2si=Sqrt[E12*(RX12si-RW12n)^2+E22*(RX22si-RW22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2ei=Sqrt[E12*(RX12ei-RW12n)^2+E22*(RX22ei-RW22n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW2sei=Sqrt[E12*(RX12sei-RW12n)^2+E22*(RX22sei-RW22n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F13 == ""N"", (G113 = 1) && (G213 = 0) && (G313 = 0) && (G413 = 0) && (G513 = 0), F13 == ""L"", (G113 = 0) && (G213 = 1) && (G313 = 0) && (G413 = 0) && (G513 = 0), F13 == ""M"", (G113 = 0) && (G213 = 0) && (G313 = 1) && (G413 = 0) && (G513 = 0), F13 == ""H"", (G113 = 0) && (G213 = 0) && (G313 = 0) && (G413 = 1) && (G513 = 0), F13 == ""P"", (G113 = 0) && (G213 = 0) && (G313 = 0) && (G413 = 0) && (G513 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F13s == ""N"", (G113s = 1) && (G213s = 0) && (G313s = 0) && (G413s = 0) && (G513s = 0), F13s == ""L"", (G113s = 0) && (G213s = 1) && (G313s = 0) && (G413s = 0) && (G513s = 0), F13s == ""M"", (G113s = 0) && (G213s = 0) && (G313s = 1) && (G413s = 0) && (G513s = 0), F13s == ""H"", (G113s = 0) && (G213s = 0) && (G313s = 0) && (G413s = 1) && (G513s = 0), F13s == ""P"", (G113s = 0) && (G213s = 0) && (G313s = 0) && (G413s = 0) && (G513s = 1)]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X13=N[(0*G113+1*G213+2*G313+3*G413+4*G513)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13s=N[(0*G113s+1*G213s+2*G313s+3*G413s+4*G513s)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13e=N[(1-p)*(0*G113+1*G213+2*G313+3*G413+4*G513)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13i=N[(0*G113+1*G213+2*G313+3*G413+4*G513)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13se=N[(1-p)(0*G113s+1*G213s+2*G313s+3*G413s+4*G513s)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13si=N[(0*G113s+1*G213s+2*G313s+3*G413s+4*G513s)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13ei=N[(1-p)(0*G113+1*G213+2*G313+3*G413+4*G513)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X13sei=N[(1-p)(0*G113s+1*G213s+2*G313s+3*G413s+4*G513s)/4]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX13=If[X13<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13s=If[X13s<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13e=If[X13e<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13i=If[X13i<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13se=If[X13se<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13si=If[X13si<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13ei=If[X13ei<RTsclheaN && FR>RTsclhea,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX13sei=If[X13sei<RTsclheaN && FR>RTsclhea,1,0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F23 == ""N"", (G123 = 1) && (G223 = 0) && (G323 = 0) && (G423 = 0) && (G523 = 0), F23 == ""L"", (G123 = 0) && (G223 = 1) && (G323 = 0) && (G423 = 0) && (G523 = 0), F23 == ""M"", (G123 = 0) && (G223 = 0) && (G323 = 1) && (G423 = 0) && (G523 = 0), F23 == ""H"", (G123 = 0) && (G223 = 0) && (G323 = 0) && (G423 = 1) && (G523 = 0), F23 == ""P"", (G123 = 0) && (G223 = 0) && (G323 = 0) && (G423 = 0) && (G523 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F23s == ""N"", (G123s = 1) && (G223s = 0) && (G323s = 0) && (G423s = 0) && (G523s = 0), F23s == ""L"", (G123s = 0) && (G223s = 1) && (G323s = 0) && (G423s = 0) && (G523s = 0), F23s == ""M"", (G123s = 0) && (G223s = 0) && (G323s = 1) && (G423s = 0) && (G523s = 0), F23s == ""H"", (G123s = 0) && (G223s = 0) && (G323s = 0) && (G423s = 1) && (G523s = 0), F23s == ""P"", (G123s = 0) && (G223s = 0) && (G323s = 0) && (G423s = 0) && (G523s = 1)]")

		Me.myMathWrapper.WaitAndDiscardAnswer("X23=N[(0*G123+1*G223+2*G323+3*G423+4*G523)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23s=N[(0*G123s+1*G223s+2*G323s+3*G423s+4*G523s)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23e=N[(1-t)(0*G123+1*G223+2*G323+3*G423+4*G523)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23i=N[(0*G123+1*G223+2*G323+3*G423+4*G523)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23se=N[(1-t)(0*G123s+1*G223s+2*G323s+3*G423s+4*G523s)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23si=N[(0*G123s+1*G223s+2*G323s+3*G423s+4*G523s)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23ei=N[(1-t)(0*G123+1*G223+2*G323+3*G423+4*G523)/4]")
		Me.myMathWrapper.WaitAndDiscardAnswer("X23sei=N[(1-t)(0*G123s+1*G223s+2*G323s+3*G423s+4*G523s)/4]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RX23=If[X13<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23s=If[X13s<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23e=If[X13e<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23i=If[X13i<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23se=If[X13se<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23si=If[X13si<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23ei=If[X13ei<RTsclsocN && FR>RTsclsoc,1,0]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RX23sei=If[X13sei<RTsclsocN && FR>RTsclsoc,1,0]")

		Me.myMathWrapper.WaitAndDiscardAnswer("DB3s=Sqrt[E13*(X13s-B13n)^2+E23*(X23s-B23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB3e=Sqrt[E13*(X13e-B13n)^2+E23*(X23e-B23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB3i=Sqrt[E13*(X13i-B13n)^2+E23*(X23i-B23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB3se=Sqrt[E13*(X13se*(1-se13x)-B13n)^2+E23*(X23se*(1-se23x)-B23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB3si=Sqrt[E13*(X13si-B13n)^2+E23*(X23si-B23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB3ei=Sqrt[E13*(X13ei-B13n)^2+E23*(X23ei-B23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DB3sei=Sqrt[E13*(X13sei-B13n)^2+E23*(X23sei-B23n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3s=Sqrt[E13*(RX13s-RB13n)^2+E23*(RX23s-RB23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3e=Sqrt[E13*(RX13e-RB13n)^2+E23*(RX23e-RB23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3i=Sqrt[E13*(RX13i-RB13n)^2+E23*(RX23i-RB23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3se=Sqrt[E13*(RX13se*(1-se13x)-RB13n)^2+E23*(RX23se*(1-se23x)-RB23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3si=Sqrt[E13*(RX13si-RB13n)^2+E23*(RX23si-RB23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3ei=Sqrt[E13*(RX13ei-RB13n)^2+E23*(RX23ei-RB23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDB3sei=Sqrt[E13*(RX13sei-RB13n)^2+E23*(RX23sei-RB23n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("DW3s=Sqrt[E13*(X13s-W13n)^2+E23*(X23s-W23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW3e=Sqrt[E13*(X13e-W13n)^2+E23*(X23e-W23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW3i=Sqrt[E13*(X13i-W13n)^2+E23*(X23i-W23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW3se=Sqrt[E13*(X13se*(1-se13x)-W13n)^2+E23*(X23se*(1-se23x)-W23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW3si=Sqrt[E13*(X13si-W13n)^2+E23*(X23si-W23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW3ei=Sqrt[E13*(X13ei-W13n)^2+E23*(X23ei-W23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("DW3sei=Sqrt[E13*(X13sei-W13n)^2+E23*(X23sei-W23n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3s=Sqrt[E13*(RX13s-RW13n)^2+E23*(RX23s-RW23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3e=Sqrt[E13*(RX13e-RW13n)^2+E23*(RX23e-RW23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3i=Sqrt[E13*(RX13i-RW13n)^2+E23*(RX23i-RW23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3se=Sqrt[E13*(RX13se*(1-se13x)-RW13n)^2+E23*(RX23se*(1-se23x)-RW23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3si=Sqrt[E13*(RX13si-RW13n)^2+E23*(RX23si-RW23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3ei=Sqrt[E13*(RX13ei-RW13n)^2+E23*(RX23ei-RW23n)^2]")
		Me.myMathWrapper.WaitAndDiscardAnswer("RDW3sei=Sqrt[E13*(RX13sei-RW13n)^2+E23*(RX23sei-RW23n)^2]")

		Me.myMathWrapper.WaitAndDiscardAnswer("Xs = S1*(-Y*DB1s + (1 - Y)*DW1s) + S2*(-Y*DB2s + (1 - Y)*DW2s) + S3*(-Y*DB3s + (1 - Y)*DW3s)")
		Me.myMathWrapper.WaitAndDiscardAnswer("Xe = S1*(-Y*DB1e + (1 - Y)*DW1e) + S2*(-Y*DB2e + (1 - Y)*DW2e) + S3*(-Y*DB3e + (1 - Y)*DW3e)")
		Me.myMathWrapper.WaitAndDiscardAnswer("Xi = S1*(-Y*DB1i + (1 - Y)*DW1i) + S2*(-Y*DB2i + (1 - Y)*DW2i) + S3*(-Y*DB3i + (1 - Y)*DW3i)")
		Me.myMathWrapper.WaitAndDiscardAnswer("Xse = S1*(-Y*DB1se + (1 - Y)*DW1se) + S2*(-Y*DB2se + (1 - Y)*DW2se) + S3*(-Y*DB3se + (1 - Y)*DW3se)")
		Me.myMathWrapper.WaitAndDiscardAnswer("Xsi = S1*(-Y*DB1si + (1 - Y)*DW1si) + S2*(-Y*DB2si + (1 - Y)*DW2si) + S3*(-Y*DB3si + (1 - Y)*DW3si)")
		Me.myMathWrapper.WaitAndDiscardAnswer("Xei = S1*(-Y*DB1ei + (1 - Y)*DW1ei) + S2*(-Y*DB2ei + (1 - Y)*DW2ei) + S3*(-Y*DB3ei + (1 - Y)*DW3ei)")
		Me.myMathWrapper.WaitAndDiscardAnswer("Xsei = S1*(-Y*DB1sei + (1 - Y)*DW1sei) + S2*(-Y*DB2sei + (1 - Y)*DW2sei) + S3*(-Y*DB3sei + (1 - Y)*DW3sei)")

		Me.myMathWrapper.WaitAndDiscardAnswer("RXs=S1*(-Y*RDB1s+(1-Y)*RDW1s) +S2*(-Y*RDB2s+(1-Y)*RDW2s)+S3*(-Y*RDB3s+(1-Y)*RDW3s)")
		Me.myMathWrapper.WaitAndDiscardAnswer("RXe=S1*(-Y*RDB1e+(1-Y)*RDW1e)+S2*(-Y*RDB2e+(1-Y)*RDW2e)+S3*(-Y*RDB3e+(1-Y)*RDW3e)")
		Me.myMathWrapper.WaitAndDiscardAnswer("RXi=S1*(-Y*RDB1i+(1-Y)*RDW1i)+S2*(-Y*RDB2i+(1-Y)*RDW2i)+S3*(-Y*RDB3i+(1-Y)*RDW3i)")
		Me.myMathWrapper.WaitAndDiscardAnswer("RXse=S1*(-Y*RDB1se+(1-Y)*RDW1se)+S2*(-Y*RDB2se+(1-Y)*RDW2se)+S3*(-Y*RDB3se+(1-Y)*RDW3se)")
		Me.myMathWrapper.WaitAndDiscardAnswer("RXsi=S1*(-Y*RDB1si+(1-Y)*RDW1si)+S2*(-Y*RDB2si+(1-Y)*RDW2si)+S3*(-Y*RDB3si+(1-Y)*RDW3si)")
		Me.myMathWrapper.WaitAndDiscardAnswer("RXei=S1*(-Y*RDB1ei+(1-Y)*RDW1ei)+S2*(-Y*RDB2ei+(1-Y)*RDW2ei)+S3*(-Y*RDB3ei+(1-Y)*RDW3ei)")
		Me.myMathWrapper.WaitAndDiscardAnswer("RXsei=S1*(-Y*RDB1sei+(1-Y)*RDW1sei)+S2*(-Y*RDB2sei+(1-Y)*RDW2sei)+S3*(-Y*RDB3sei+(1-Y)*RDW3sei)")

		Me.myMathWrapper.WaitAndDiscardAnswer("DE = " & Me.NumberAsString(Me.DE))
		Me.myMathWrapper.WaitAndDiscardAnswer("DU = " & Me.NumberAsString(Me.DU))
		Me.myMathWrapper.WaitAndDiscardAnswer("Y = " & Me.NumberAsString(Me.Y))
		Me.myMathWrapper.WaitAndDiscardAnswer("FR = " & Me.NumberAsString(Me.FR))

		Me.myMathWrapper.WaitAndDiscardAnswer("RTecnuneQ = """ & Me.RTecnuneQ & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTecnlanQ = """ & Me.RTecnlanQ & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTeclspeQ = """ & Me.RTeclspeQ & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTeclhabQ = """ & Me.RTeclhabQ & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTsclheaQ = """ & Me.RTsclheaQ & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("RTsclsocQ = """ & Me.RTsclsocQ & """")

		Me.myMathWrapper.WaitAndDiscardAnswer("S1 = " & Me.NumberAsString(Me.S1))
		Me.myMathWrapper.WaitAndDiscardAnswer("S2 = " & Me.NumberAsString(Me.S2))
		Me.myMathWrapper.WaitAndDiscardAnswer("S3 = " & Me.NumberAsString(Me.S3))
		Me.myMathWrapper.WaitAndDiscardAnswer("E11 = " & Me.NumberAsString(Me.E11))
		Me.myMathWrapper.WaitAndDiscardAnswer("E21 = " & Me.NumberAsString(Me.E21))
		Me.myMathWrapper.WaitAndDiscardAnswer("E31 = " & Me.NumberAsString(Me.E31))
		Me.myMathWrapper.WaitAndDiscardAnswer("E12 = " & Me.NumberAsString(Me.E12))
		Me.myMathWrapper.WaitAndDiscardAnswer("E22 = " & Me.NumberAsString(Me.E22))
		Me.myMathWrapper.WaitAndDiscardAnswer("E13 = " & Me.NumberAsString(Me.E13))
		Me.myMathWrapper.WaitAndDiscardAnswer("E23 = " & Me.NumberAsString(Me.E23))
		Me.myMathWrapper.WaitAndDiscardAnswer("B11 = " & Me.NumberAsString(Me.B11))

		Me.myMathWrapper.WaitAndDiscardAnswer("B21 = """ & Me.B21 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("W21 = """ & Me.W21 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("B31 = """ & Me.B31 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("W31 = """ & Me.W31 & """")

		Me.myMathWrapper.WaitAndDiscardAnswer("v1 = " & Me.NumberAsString(Me.v1))
		Me.myMathWrapper.WaitAndDiscardAnswer("a1 = " & Me.NumberAsString(Me.a1))
		Me.myMathWrapper.WaitAndDiscardAnswer("b1 = " & Me.NumberAsString(Me.b1))
		Me.myMathWrapper.WaitAndDiscardAnswer("v2 = " & Me.NumberAsString(Me.v2))
		Me.myMathWrapper.WaitAndDiscardAnswer("a2 = " & Me.NumberAsString(Me.a2))
		Me.myMathWrapper.WaitAndDiscardAnswer("b2 = " & Me.NumberAsString(Me.b2))
		Me.myMathWrapper.WaitAndDiscardAnswer("v3 = " & Me.NumberAsString(Me.v3))
		Me.myMathWrapper.WaitAndDiscardAnswer("a3 = " & Me.NumberAsString(Me.a3))
		Me.myMathWrapper.WaitAndDiscardAnswer("b3 = " & Me.NumberAsString(Me.b3))
		Me.myMathWrapper.WaitAndDiscardAnswer("v4 = " & Me.NumberAsString(Me.v4))
		Me.myMathWrapper.WaitAndDiscardAnswer("a4 = " & Me.NumberAsString(Me.a4))
		Me.myMathWrapper.WaitAndDiscardAnswer("b4 = " & Me.NumberAsString(Me.b4))
		Me.myMathWrapper.WaitAndDiscardAnswer("v5 = " & Me.NumberAsString(Me.v5))
		Me.myMathWrapper.WaitAndDiscardAnswer("a5 = " & Me.NumberAsString(Me.a5))
		Me.myMathWrapper.WaitAndDiscardAnswer("b5 = " & Me.NumberAsString(Me.b5))
		Me.myMathWrapper.WaitAndDiscardAnswer("v6 = " & Me.NumberAsString(Me.v6))
		Me.myMathWrapper.WaitAndDiscardAnswer("a6 = " & Me.NumberAsString(Me.a6))
		Me.myMathWrapper.WaitAndDiscardAnswer("b6 = " & Me.NumberAsString(Me.b6))
		Me.myMathWrapper.WaitAndDiscardAnswer("v7 = " & Me.NumberAsString(Me.v7))
		Me.myMathWrapper.WaitAndDiscardAnswer("a7 = " & Me.NumberAsString(Me.a7))
		Me.myMathWrapper.WaitAndDiscardAnswer("b7 = " & Me.NumberAsString(Me.b7))
		Me.myMathWrapper.WaitAndDiscardAnswer("v8 = " & Me.NumberAsString(Me.v8))
		Me.myMathWrapper.WaitAndDiscardAnswer("a8 = " & Me.NumberAsString(Me.a8))
		Me.myMathWrapper.WaitAndDiscardAnswer("b8 = " & Me.NumberAsString(Me.b8))

		Me.myMathWrapper.WaitAndDiscardAnswer("B12 = " & Me.NumberAsString(Me.B12))
		Me.myMathWrapper.WaitAndDiscardAnswer("W12 = " & Me.NumberAsString(Me.W12))
		Me.myMathWrapper.WaitAndDiscardAnswer("B22 = """ & Me.B22 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("W22 = """ & Me.W22 & """")

		Me.myMathWrapper.WaitAndDiscardAnswer("B13 = """ & Me.B13 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("W13 = """ & Me.W13 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("B23 = """ & Me.B23 & """")
		Me.myMathWrapper.WaitAndDiscardAnswer("W23 = """ & Me.W23 & """")

		Me.myMathWrapper.WaitAndDiscardAnswer("RB11n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW11n=0")
		Me.myMathWrapper.WaitAndDiscardAnswer("RB21n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW21n=0")
		Me.myMathWrapper.WaitAndDiscardAnswer("RB31n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW31n=0")

		Me.myMathWrapper.WaitAndDiscardAnswer("RB12n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW12n=0")
		Me.myMathWrapper.WaitAndDiscardAnswer("RB22n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW22n=0")

		Me.myMathWrapper.WaitAndDiscardAnswer("RB13n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW13n=0")
		Me.myMathWrapper.WaitAndDiscardAnswer("RB23n=1")
		Me.myMathWrapper.WaitAndDiscardAnswer("RW23n=0")

		Me.myMathWrapper.WaitAndDiscardAnswer("c = " & Me.NumberAsString(Me.c))
		Me.myMathWrapper.WaitAndDiscardAnswer("d = " & Me.NumberAsString(Me.d))

		Me.myMathWrapper.WaitAndDiscardAnswer("COs = " & Me.NumberAsString(Me.COs))
		Me.myMathWrapper.WaitAndDiscardAnswer("COe = " & Me.NumberAsString(Me.COe))
		Me.myMathWrapper.WaitAndDiscardAnswer("COi = " & Me.NumberAsString(Me.COi))
		Me.myMathWrapper.WaitAndDiscardAnswer("COse = " & Me.NumberAsString(Me.COse))
		Me.myMathWrapper.WaitAndDiscardAnswer("COsi = " & Me.NumberAsString(Me.COsi))
		Me.myMathWrapper.WaitAndDiscardAnswer("COei = " & Me.NumberAsString(Me.COei))
		Me.myMathWrapper.WaitAndDiscardAnswer("COsei = " & Me.NumberAsString(Me.COsei))

		Me.myMathWrapper.WaitAndDiscardAnswer("p = " & Me.NumberAsString(Me.p))
		Me.myMathWrapper.WaitAndDiscardAnswer("t = " & Me.NumberAsString(Me.t))
		Me.myMathWrapper.WaitAndDiscardAnswer("z = " & Me.NumberAsString(Me.z))
		Me.myMathWrapper.WaitAndDiscardAnswer("zz = " & Me.NumberAsString(Me.zz))
		Me.myMathWrapper.WaitAndDiscardAnswer("m = " & Me.NumberAsString(Me.m))

		Me.myMathWrapper.WaitAndDiscardAnswer("e11r = " & Me.NumberAsString(Me.e11r))
		Me.myMathWrapper.WaitAndDiscardAnswer("i11x = " & Me.NumberAsString(Me.i11x))
		Me.myMathWrapper.WaitAndDiscardAnswer("se13x = " & Me.NumberAsString(Me.se13x))
		Me.myMathWrapper.WaitAndDiscardAnswer("se23x = " & Me.NumberAsString(Me.se23x))

		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnune1 = " & Me.NumberAsString(Me.Tecnune1))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnune2 = " & Me.NumberAsString(Me.Tecnune2))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnune3 = " & Me.NumberAsString(Me.Tecnune3))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnune4 = " & Me.NumberAsString(Me.Tecnune4))

		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnlan1 = " & Me.NumberAsString(Me.Tecnlan1))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnlan2 = " & Me.NumberAsString(Me.Tecnune2))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnlan3 = " & Me.NumberAsString(Me.Tecnune3))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecnlan4 = " & Me.NumberAsString(Me.Tecnune4))

		Me.myMathWrapper.WaitAndDiscardAnswer("Teclspe1 = " & Me.NumberAsString(Me.Teclspe1))
		Me.myMathWrapper.WaitAndDiscardAnswer("Teclspe2 = " & Me.NumberAsString(Me.Teclspe2))
		Me.myMathWrapper.WaitAndDiscardAnswer("Teclspe3 = " & Me.NumberAsString(Me.Teclspe3))
		Me.myMathWrapper.WaitAndDiscardAnswer("Teclspe4 = " & Me.NumberAsString(Me.Teclspe4))

		Me.myMathWrapper.WaitAndDiscardAnswer("Teclhab1du = " & Me.NumberAsString(Me.Teclhab1du))
		Me.myMathWrapper.WaitAndDiscardAnswer("Teclhab2du = " & Me.NumberAsString(Me.Teclhab2du))
		Me.myMathWrapper.WaitAndDiscardAnswer("Teclhab3du = " & Me.NumberAsString(Me.Teclhab3du))
		Me.myMathWrapper.WaitAndDiscardAnswer("Teclhab4du = " & Me.NumberAsString(Me.Teclhab4du))

		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclhea1 = " & Me.NumberAsString(Me.Tsclhea1))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclhea2 = " & Me.NumberAsString(Me.Tsclhea2))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclhea3 = " & Me.NumberAsString(Me.Tsclhea3))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclhea4 = " & Me.NumberAsString(Me.Tsclhea4))

		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclsoc1 = " & Me.NumberAsString(Me.Tsclsoc1))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclsoc2 = " & Me.NumberAsString(Me.Tsclsoc2))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclsoc3 = " & Me.NumberAsString(Me.Tsclsoc3))
		Me.myMathWrapper.WaitAndDiscardAnswer("Tsclsoc4 = " & Me.NumberAsString(Me.Tsclsoc4))

		Me.myMathWrapper.WaitAndDiscardAnswer("RTecnune = " & Me.RTecnune)
		Me.myMathWrapper.WaitAndDiscardAnswer("RTecnlan = " & Me.RTecnlan)
		Me.myMathWrapper.WaitAndDiscardAnswer("RTeclspe = " & Me.RTeclspe)
		Me.myMathWrapper.WaitAndDiscardAnswer("RTeclhab = " & Me.RTeclhab)
		Me.myMathWrapper.WaitAndDiscardAnswer("RTsclhea = " & Me.RTsclhea)
		Me.myMathWrapper.WaitAndDiscardAnswer("RTsclsoc = " & Me.RTsclsoc)

		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F21 == ""N"", (G121 = 1) && (G221 = 0) && (G321 = 0) && (G421 = 0) && (G521 = 0), F21 == ""L"", (G121 = 0) && (G221 = 1) && (G321 = 0) && (G421 = 0) && (G521 = 0), F21 == ""M"", (G121 = 0) && (G221 = 0) && (G321 = 1) && (G421 = 0) && (G521 = 0), F21 == ""H"", (G121 = 0) && (G221 = 0) && (G321 = 0) && (G421 =  1) && (G521 = 0), F21 == ""P"", (G121 = 0) && (G221 = 0) && (G321 = 0) && (G421 = 0) && (G521 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F21s == ""N"", (G121s = 1) && (G221s = 0) && (G321s = 0) && (G421s = 0) && (G521s = 0), F21s == ""L"", (G121s = 0) && (G221s = 1) && (G321s = 0) && (G421s = 0) && (G521s = 0), F21s == ""M"", (G121s = 0) && (G221s = 0) && (G321s = 1) && (G421s = 0) && (G521s = 0), F21s == ""H"", (G121s = 0) && (G221s = 0) && (G321s = 0) && (G421s = 1) && (G521s = 0), F21s == ""P"", (G121s = 0) && (G221s = 0) && (G321s = 0) && (G421s = 0) && (G521s = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F31 == ""N"", (G131 = 1) && (G231 = 0) && (G331 = 0) && (G431 = 0) && (G531 = 0), F31 == ""L"", (G131 = 0) && (G231 = 1) && (G331 = 0) && (G431 = 0) && (G531 = 0), F31 == ""M"", (G131 = 0) && (G231 = 0) && (G331 = 1) && (G431 = 0) && (G531 = 0), F31 == ""H"", (G131 = 0) && (G231 = 0) && (G331 = 0) && (G431 = 1) && (G531 = 0), F31 == ""P"", (G131 = 0) && (G231 = 0) && (G331 = 0) && (G431 = 0) && (G531 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F31s == ""N"", (G131s = 1) && (G231s = 0) && (G331s = 0) && (G431s = 0) && (G531s = 0), F31s == ""L"", (G131s = 0) && (G231s = 1) && (G331s = 0) && (G431s = 0) && (G531s = 0), F31s == ""M"", (G131s = 0) && (G231s = 0) && (G331s = 1) && (G431s = 0) && (G531s = 0), F31s == ""H"", (G131s = 0) && (G231s = 0) && (G331s = 0) && (G431s = 1) && (G531s = 0), F31s == ""P"", (G131s = 0) && (G231s = 0) && (G331s = 0) && (G431s = 0) && (G531s = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F12 == ""I1"", (G112 = 1) && (G212 = 0) && (G312 = 0) && (G412 = 0) && (G512 = 0), F12 == ""I2"", (G112 = 0) && (G212 = 1) && (G312 = 0) && (G412 = 0) && (G512 = 0), F12 == ""I3"", (G112 = 0) && (G212 = 0) && (G312 = 1) && (G412 = 0) && (G512 = 0), F12 == ""I4"", (G112 = 0) && (G212 = 0) && (G312 = 0) && (G412 = 1) && (G512 = 0), F12 == ""I5"", (G112 = 0) && (G212 = 0) && (G312 = 0) && (G412 = 0) && (G512 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F22 == ""N"", (G122 = 1) && (G222 = 0) && (G322 = 0) && (G422 = 0) && (G522 = 0), F22 == ""L"", (G122 = 0) && (G222 = 1) && (G322 = 0) && (G422 = 0) && (G522 = 0), F22 == ""M"", (G122 = 0) && (G222 = 0) && (G322 = 1) && (G422 = 0) && (G522 = 0), F22 == ""H"", (G122 = 0) && (G222 = 0) && (G322 = 0) && (G422 = 1) && (G522 = 0), F22 == ""P"", (G122 = 0) && (G222 = 0) && (G322 = 0) && (G422 = 0) && (G522 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F13 == ""N"", (G113 = 1) && (G213 = 0) && (G313 = 0) && (G413 = 0) && (G513 = 0), F13 == ""L"", (G113 = 0) && (G213 = 1) && (G313 = 0) && (G413 = 0) && (G513 = 0), F13 == ""M"", (G113 = 0) && (G213 = 0) && (G313 = 1) && (G413 = 0) && (G513 = 0), F13 == ""H"", (G113 = 0) && (G213 = 0) && (G313 = 0) && (G413 = 1) && (G513 = 0), F13 == ""P"", (G113 = 0) && (G213 = 0) && (G313 = 0) && (G413 = 0) && (G513 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F13s == ""N"", (G113s = 1) && (G213s = 0) && (G313s = 0) && (G413s = 0) && (G513s = 0), F13s == ""L"", (G113s = 0) && (G213s = 1) && (G313s = 0) && (G413s = 0) && (G513s = 0), F13s == ""M"", (G113s = 0) && (G213s = 0) && (G313s = 1) && (G413s = 0) && (G513s = 0), F13s == ""H"", (G113s = 0) && (G213s = 0) && (G313s = 0) && (G413s = 1) && (G513s = 0), F13s == ""P"", (G113s = 0) && (G213s = 0) && (G313s = 0) && (G413s = 0) && (G513s = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F23 == ""N"", (G123 = 1) && (G223 = 0) && (G323 = 0) && (G423 = 0) && (G523 = 0), F23 == ""L"", (G123 = 0) && (G223 = 1) && (G323 = 0) && (G423 = 0) && (G523 = 0), F23 == ""M"", (G123 = 0) && (G223 = 0) && (G323 = 1) && (G423 = 0) && (G523 = 0), F23 == ""H"", (G123 = 0) && (G223 = 0) && (G323 = 0) && (G423 = 1) && (G523 = 0), F23 == ""P"", (G123 = 0) && (G223 = 0) && (G323 = 0) && (G423 = 0) && (G523 = 1)]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Which[F23s == ""N"", (G123s = 1) && (G223s = 0) && (G323s = 0) && (G423s = 0) && (G523s = 0), F23s == ""L"", (G123s = 0) && (G223s = 1) && (G323s = 0) && (G423s = 0) && (G523s = 0), F23s == ""M"", (G123s = 0) && (G223s = 0) && (G323s = 1) && (G423s = 0) && (G523s = 0), F23s == ""H"", (G123s = 0) && (G223s = 0) && (G323s = 0) && (G423s = 1) && (G523s = 0), F23s == ""P"", (G123s = 0) && (G223s = 0) && (G323s = 0) && (G423s = 0) && (G523s = 1)]")

		Me.Xs = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xs")
		Me.Xe = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xe")
		Me.Xi = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xi")
		Me.Xse = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xse")
		Me.Xsi = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xsi")
		Me.Xei = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xei")
		Me.Xsei = Me.myMathWrapper.WaitAndEvaluateAsDouble("Xsei")

		Me.RXs = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXs")
		Me.RXe = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXe")
		Me.RXi = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXi")
		Me.RXse = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXse")
		Me.RXsi = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXsi")
		Me.RXei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXei")
		Me.RXsei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RXsei")

		Me.B21n = Me.myMathWrapper.WaitAndEvaluateAsDouble("B21n")
		Me.W21n = Me.myMathWrapper.WaitAndEvaluateAsDouble("W21n")
		Me.B31n = Me.myMathWrapper.WaitAndEvaluateAsDouble("B31n")
		Me.W31n = Me.myMathWrapper.WaitAndEvaluateAsDouble("W31n")
		Me.B12n = Me.myMathWrapper.WaitAndEvaluateAsDouble("B12n")
		Me.W12n = Me.myMathWrapper.WaitAndEvaluateAsDouble("W12n")
		Me.B22n = Me.myMathWrapper.WaitAndEvaluateAsDouble("B22n")
		Me.W22n = Me.myMathWrapper.WaitAndEvaluateAsDouble("W22n")
		Me.B13n = Me.myMathWrapper.WaitAndEvaluateAsDouble("B13n")
		Me.W13n = Me.myMathWrapper.WaitAndEvaluateAsDouble("W13n")
		Me.B23n = Me.myMathWrapper.WaitAndEvaluateAsDouble("B23n")
		Me.W23n = Me.myMathWrapper.WaitAndEvaluateAsDouble("W23n")
		Me.F11 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11")
		Me.F11s = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11s")
		Me.F11e = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11e")
		Me.F11i = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11i")
		Me.F11se = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11se")
		Me.F11si = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11si")
		Me.F11ei = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11ei")
		Me.F11sei = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11sei")

		Me.F21 = Me.myMathWrapper.WaitAndEvaluateAsString("F21")
		Me.F21s = Me.myMathWrapper.WaitAndEvaluateAsString("F21s")
		Me.F21e = Me.myMathWrapper.WaitAndEvaluateAsString("F21e")
		Me.F21i = Me.myMathWrapper.WaitAndEvaluateAsString("F21i")
		Me.F21se = Me.myMathWrapper.WaitAndEvaluateAsString("F21se")
		Me.F21si = Me.myMathWrapper.WaitAndEvaluateAsString("F21si")
		Me.F21ei = Me.myMathWrapper.WaitAndEvaluateAsString("F21ei")
		Me.F21sei = Me.myMathWrapper.WaitAndEvaluateAsString("F21sei")

		Me.F31 = Me.myMathWrapper.WaitAndEvaluateAsString("F31")
		Me.F31s = Me.myMathWrapper.WaitAndEvaluateAsString("F31s")
		Me.F31e = Me.myMathWrapper.WaitAndEvaluateAsString("F31e")
		Me.F31i = Me.myMathWrapper.WaitAndEvaluateAsString("F31i")
		Me.F31se = Me.myMathWrapper.WaitAndEvaluateAsString("F31se")
		Me.F31si = Me.myMathWrapper.WaitAndEvaluateAsString("F31si")
		Me.F31ei = Me.myMathWrapper.WaitAndEvaluateAsString("F31ei")
		Me.F31sei = Me.myMathWrapper.WaitAndEvaluateAsString("F31sei")

		Me.F12 = Me.myMathWrapper.WaitAndEvaluateAsString("F12")
		Me.F12s = Me.myMathWrapper.WaitAndEvaluateAsString("F12s")
		Me.F12e = Me.myMathWrapper.WaitAndEvaluateAsString("F12e")
		Me.F12i = Me.myMathWrapper.WaitAndEvaluateAsString("F12i")
		Me.F12se = Me.myMathWrapper.WaitAndEvaluateAsString("F12se")
		Me.F12si = Me.myMathWrapper.WaitAndEvaluateAsString("F12si")
		Me.F12ei = Me.myMathWrapper.WaitAndEvaluateAsString("F12ei")
		Me.F12sei = Me.myMathWrapper.WaitAndEvaluateAsString("F12sei")

		Me.F22 = Me.myMathWrapper.WaitAndEvaluateAsString("F22")
		Me.F22s = Me.myMathWrapper.WaitAndEvaluateAsString("F22s")
		Me.F22e = Me.myMathWrapper.WaitAndEvaluateAsString("F22e")
		Me.F22i = Me.myMathWrapper.WaitAndEvaluateAsString("F22i")
		Me.F22se = Me.myMathWrapper.WaitAndEvaluateAsString("F22se")
		Me.F22si = Me.myMathWrapper.WaitAndEvaluateAsString("F22si")
		Me.F22ei = Me.myMathWrapper.WaitAndEvaluateAsString("F22ei")
		Me.F22sei = Me.myMathWrapper.WaitAndEvaluateAsString("F22sei")

		Me.F13 = Me.myMathWrapper.WaitAndEvaluateAsString("F13")
		Me.F13s = Me.myMathWrapper.WaitAndEvaluateAsString("F13s")
		Me.F13e = Me.myMathWrapper.WaitAndEvaluateAsString("F13e")
		Me.F13i = Me.myMathWrapper.WaitAndEvaluateAsString("F13i")
		Me.F13se = Me.myMathWrapper.WaitAndEvaluateAsString("F13se")
		Me.F13si = Me.myMathWrapper.WaitAndEvaluateAsString("F13si")
		Me.F13ei = Me.myMathWrapper.WaitAndEvaluateAsString("F13ei")
		Me.F13sei = Me.myMathWrapper.WaitAndEvaluateAsString("F13sei")

		Me.F23 = Me.myMathWrapper.WaitAndEvaluateAsString("F23")
		Me.F23s = Me.myMathWrapper.WaitAndEvaluateAsString("F23s")
		Me.F23e = Me.myMathWrapper.WaitAndEvaluateAsString("F23e")
		Me.F23i = Me.myMathWrapper.WaitAndEvaluateAsString("F23i")
		Me.F23se = Me.myMathWrapper.WaitAndEvaluateAsString("F23se")
		Me.F23si = Me.myMathWrapper.WaitAndEvaluateAsString("F23si")
		Me.F23ei = Me.myMathWrapper.WaitAndEvaluateAsString("F23ei")
		Me.F23sei = Me.myMathWrapper.WaitAndEvaluateAsString("F23sei")

		Me.R11 = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11")
		Me.R11s = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11s")
		Me.R11e = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11e")
		Me.R11i = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11i")
		Me.R11se = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11se")
		Me.R11si = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11si")
		Me.R11ei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11ei")
		Me.R11sei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX11sei")

		Me.R21 = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21")
		Me.R21s = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21s")
		Me.R21e = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21e")
		Me.R21i = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21i")
		Me.R21se = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21se")
		Me.R21si = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21si")
		Me.R21ei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21ei")
		Me.R21sei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX21sei")

		Me.R31 = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31")
		Me.R31s = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31s")
		Me.R31e = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31e")
		Me.R31i = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31i")
		Me.R31se = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31se")
		Me.R31ei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31ei")
		Me.R31sei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX31sei")

		Me.R12 = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12")
		Me.R12s = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12s")
		Me.R12e = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12e")
		Me.R12i = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12i")
		Me.R12se = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12se")
		Me.R12si = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12si")
		Me.R12ei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12ei")
		Me.R12sei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX12sei")

		Me.R22 = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22")
		Me.R22s = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22s")
		Me.R22e = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22e")
		Me.R22i = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22i")
		Me.R22se = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22se")
		Me.R22si = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22si")
		Me.R22ei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22ei")
		Me.R22sei = Me.myMathWrapper.WaitAndEvaluateAsDouble("RX22sei")

		Me.AdjustDescriptions()
		Me.WriteValuesToDB()
	End Sub

	''' <summary>
	''' resets data to defaults
	''' </summary>
	''' <remarks></remarks>
	Private Sub Reset()
		'Dim tmpDataRowView As DataRowView

		If MessageBox.Show("Are you sure you want to reset data to default values?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
			'read data from DB
			'Me.TADefaultData.Fill(Me.DSDefaultData.dati)

			'If Me.DSDefaultData.dati.DefaultView.Count <> 0 Then
			'    'tmpDataRowView = Me.dsData.dati.DefaultView.Item(0)
			'Else
			'no data in DB
			Me.nudC.Value = 0.8D
			Me.nudD.Value = 0.8D
			Me.nudTeclspe1.Value = 0.2D
			Me.nudTeclspe2.Value = 0.3D
			Me.nudTeclspe3.Value = 0.4D
			Me.nudTeclspe4.Value = 0.5D
			Me.nudCOs.Value = CType(100 / 50, Decimal)
			Me.nudCOe.Value = CType(1 / 50, Decimal)
			Me.nudCOi.Value = CType(10 / 50, Decimal)
			Me.nudS1.Value = 0.23D
			Me.nudS2.Value = 0.19D
			Me.nudS3.Value = 0.58D
			Me.nudDE.Value = 1
			Me.nudDU.Value = 20
			Me.nudY.Value = 0
			Me.nudV1.Value = 71
			Me.nudV2.Value = 53
			Me.nudV3.Value = 58
			Me.nudV4.Value = 80
			Me.nudV5.Value = 12
			Me.nudV6.Value = 6
			Me.nudV7.Value = 10
			Me.nudE11.Value = 0.6D
			Me.nudE21.Value = 0.2D
			Me.nudE31.Value = 0.2D
			Me.nudE12.Value = 0.5D
			Me.nudE22.Value = 0.5D
			Me.nudE13.Value = 0.7D
			Me.nudE23.Value = 0.3D
			Me.cboB21.SelectedValue = "N"
			Me.cboB31.SelectedValue = "N"
			Me.nudB12.Value = 0.5D
			Me.cboB22.SelectedValue = "N"
			Me.cboB13.SelectedValue = "N"
			Me.cboB23.SelectedValue = "N"
			Me.cboW21.SelectedValue = "P"
			Me.cboW31.SelectedValue = "P"
			Me.nudW12.Value = 0.5D
			Me.cboW22.SelectedValue = "N"
			Me.cboW13.SelectedValue = "N"
			Me.cboW23.SelectedValue = "N"
			'End If
		End If
	End Sub

	''' <summary>
	''' change text on btnNext
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetNextText()
		If Me.groupBoxesID = 5 Then
			Me.btnNext.Text = "Calculate"
		Else
			Me.btnNext.Text = "Next"
		End If
	End Sub

	''' <summary>
	''' change text on btnPrev
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetPrevText()
		If Me.groupBoxesID = 0 Then
			Me.btnPrev.Text = "Reset"
		Else
			Me.btnPrev.Text = "Previous"
		End If
	End Sub

	''' <summary>
	''' show previous input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub PreviousStep()
		Me.groupBoxesID -= 1

		Me.SetPrevText()
		Me.ShowButtons()
		Me.ShowBox()
	End Sub

	''' <summary>
	''' show next input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub NextStep()
		Me.groupBoxesID += 1

		Me.SetPrevText()
		Me.ShowButtons()

		If Me.groupBoxesID = Me.groupBoxes.Length - 1 Then
			'end of input phase
			Me.Enabled = False
			Me.Cursor = Cursors.WaitCursor
			Me.Calculate()
			Me.PrepareOutput()
			Me.WriteValuesToGUI(False)
			Me.Enabled = True
			Me.Cursor = Cursors.Default
		End If

		If Me.groupBoxesID = Me.groupBoxes.Length Then
			Me.Close()
		Else
			Me.ShowBox()
			If Me.groupBoxesID = Me.groupBoxes.Length Then
				Me.Close()
			End If
		End If
	End Sub

	''' <summary>
	''' shows or hides btnPrev and btnNext depending on current box shown
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowButtons()
		If Me.groupBoxesID < Me.groupBoxes.Length - 1 Then
			Me.btnPrev.Visible = True
			Me.btnNext.Visible = True
		Else
			'Me.btnPrev.Visible = False
			Me.btnNext.Visible = False
		End If

		If Me.groupBoxesID = Me.groupBoxes.Length - 1 Then
			'end of input phase
			Me.Enabled = False
			Me.Cursor = Cursors.WaitCursor
			Me.Enabled = True
			Me.Cursor = Cursors.Default
		End If
	End Sub

	''' <summary>
	''' shows current groupBox
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowBox()
		Dim i As Integer

		Me.SetPrevText()
		Me.SetNextText()

		If Me.groupBoxesID > 0 Then
			Me.btnLoadData.Visible = False
		Else
			Me.btnLoadData.Visible = True
		End If

		For i = 0 To Me.groupBoxes.Length - 1
			Me.groupBoxes(i).Visible = False
		Next

		Me.groupBoxes(Me.groupBoxesID).DSSTVisible = True
	End Sub

	''' <summary>
	''' Truncates NO to N in linguistic variables
	''' </summary>
	''' <remarks></remarks>
	Private Sub AdjustDescriptions()
		Me.F12 = Me.ReplaceInterval(Me.F12)
		Me.F12s = Me.ReplaceInterval(Me.F12s)
		Me.F12e = Me.ReplaceInterval(Me.F12e)
		Me.F12i = Me.ReplaceInterval(Me.F12i)
		Me.F12se = Me.ReplaceInterval(Me.F12se)
		Me.F12si = Me.ReplaceInterval(Me.F12si)
		Me.F12ei = Me.ReplaceInterval(Me.F12ei)
		Me.F12sei = Me.ReplaceInterval(Me.F12sei)
	End Sub

	Private Function ReplaceInterval(ByVal value As String) As String
		Return value.Replace("I1", "0 - 20%").Replace("I2", "20 - 40%").Replace("I3", "40 - 60%").Replace("I4", "60 - 80%").Replace("I5", "80 - 100%")
	End Function

	''' <summary>
	''' reads data from DB to local variables and to users controls
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromDB()
		Me.ReadValuesFromDB(0)
	End Sub

	''' <summary>
	''' reads data from DB to local variables and to users controls
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromDB(ID As Integer)
		'read data from DB
		Me.daData.Fill(Me.DSData)

		Dim tmpDataRowView As DataRowView

		If ID > 0 Then
			Me.DSData.data.DefaultView.RowFilter = "datID = " & ID
		End If

		If Me.DSData.data.DefaultView.Count > 0 Then
			Me.DSData.data.DefaultView.Sort = " datID ASC "
			tmpDataRowView = Me.DSData.data.DefaultView.Item(Me.DSData.data.DefaultView.Count - 1)

			Me.DE = Me.NullToDouble(tmpDataRowView.Item("datDE"))
			Me.DU = Me.NullToDouble(tmpDataRowView.Item("datDU"))
			Me.FR = Me.NullToDouble(tmpDataRowView.Item("datFR"))
			Me.Y = Me.NullToDouble(tmpDataRowView.Item("datY"))
			Me.S1 = Me.NullToDouble(tmpDataRowView.Item("datS1"))
			Me.S2 = Me.NullToDouble(tmpDataRowView.Item("datS2"))
			Me.S3 = Me.NullToDouble(tmpDataRowView.Item("datS3"))
			Me.E11 = Me.NullToDouble(tmpDataRowView.Item("datE11"))
			Me.e11r = Me.NullToDouble(tmpDataRowView.Item("datE11r"))
			Me.E21 = Me.NullToDouble(tmpDataRowView.Item("datE21"))
			Me.E31 = Me.NullToDouble(tmpDataRowView.Item("datE31"))
			Me.E12 = Me.NullToDouble(tmpDataRowView.Item("datE12"))
			Me.E22 = Me.NullToDouble(tmpDataRowView.Item("datE22"))
			Me.E13 = Me.NullToDouble(tmpDataRowView.Item("datE13"))
			Me.E23 = Me.NullToDouble(tmpDataRowView.Item("datE23"))
			Me.W21 = tmpDataRowView.Item("datW21").ToString
			Me.W31 = tmpDataRowView.Item("datW31").ToString
			Me.W12 = Me.NullToDouble(tmpDataRowView.Item("datW12"))
			Me.W22 = tmpDataRowView.Item("datW22").ToString
			Me.W13 = tmpDataRowView.Item("datW13").ToString
			Me.W23 = tmpDataRowView.Item("datW23").ToString
			Me.B21 = tmpDataRowView.Item("datB21").ToString
			Me.B31 = tmpDataRowView.Item("datB31").ToString
			Me.B12 = Me.NullToDouble(tmpDataRowView.Item("datB12"))
			Me.B22 = tmpDataRowView.Item("datB22").ToString
			Me.B13 = tmpDataRowView.Item("datB13").ToString
			Me.B23 = tmpDataRowView.Item("datB23").ToString
			Me.v1 = Me.NullToDouble(tmpDataRowView.Item("datV1"))
			Me.v2 = Me.NullToDouble(tmpDataRowView.Item("datV2"))
			Me.v3 = Me.NullToDouble(tmpDataRowView.Item("datV3"))
			Me.v4 = Me.NullToDouble(tmpDataRowView.Item("datV4"))
			Me.v5 = Me.NullToDouble(tmpDataRowView.Item("datV5"))
			Me.v6 = Me.NullToDouble(tmpDataRowView.Item("datV6"))
			Me.v7 = Me.NullToDouble(tmpDataRowView.Item("datV7"))
			Me.v8 = Me.NullToDouble(tmpDataRowView.Item("datV8"))
			Me.a1 = Me.NullToDouble(tmpDataRowView.Item("datA1"))
			Me.a2 = Me.NullToDouble(tmpDataRowView.Item("datA2"))
			Me.a3 = Me.NullToDouble(tmpDataRowView.Item("datA3"))
			Me.a4 = Me.NullToDouble(tmpDataRowView.Item("datA4"))
			Me.a5 = Me.NullToDouble(tmpDataRowView.Item("datA5"))
			Me.a6 = Me.NullToDouble(tmpDataRowView.Item("datA6"))
			Me.a7 = Me.NullToDouble(tmpDataRowView.Item("datA7"))
			Me.a8 = Me.NullToDouble(tmpDataRowView.Item("datA8"))
			Me.b1 = Me.NullToDouble(tmpDataRowView.Item("datB1"))
			Me.b2 = Me.NullToDouble(tmpDataRowView.Item("datB2"))
			Me.b3 = Me.NullToDouble(tmpDataRowView.Item("datB3"))
			Me.b4 = Me.NullToDouble(tmpDataRowView.Item("datB4"))
			Me.b5 = Me.NullToDouble(tmpDataRowView.Item("datB5"))
			Me.b6 = Me.NullToDouble(tmpDataRowView.Item("datB6"))
			Me.b7 = Me.NullToDouble(tmpDataRowView.Item("datB7"))
			Me.b8 = Me.NullToDouble(tmpDataRowView.Item("datB8"))
			Me.z = Me.NullToDouble(tmpDataRowView.Item("datz"))
			Me.zz = Me.NullToDouble(tmpDataRowView.Item("datzz"))
			Me.m = Me.NullToDouble(tmpDataRowView.Item("datm"))
			Me.Tecnune1 = Me.NullToDouble(tmpDataRowView.Item("datTecnune1"))
			Me.Tecnune2 = Me.NullToDouble(tmpDataRowView.Item("datTecnune2"))
			Me.Tecnune3 = Me.NullToDouble(tmpDataRowView.Item("datTecnune3"))
			Me.Tecnune4 = Me.NullToDouble(tmpDataRowView.Item("datTecnune4"))
			Me.Tecnlan1 = Me.NullToDouble(tmpDataRowView.Item("datTecnlan1"))
			Me.Tecnlan2 = Me.NullToDouble(tmpDataRowView.Item("datTecnlan2"))
			Me.Tecnlan3 = Me.NullToDouble(tmpDataRowView.Item("datTecnlan3"))
			Me.Tecnlan4 = Me.NullToDouble(tmpDataRowView.Item("datTecnlan4"))
			Me.RTecnuneQ = tmpDataRowView.Item("datRTecnuneQ").ToString
			Me.RTecnlanQ = tmpDataRowView.Item("datRTecnlanQ").ToString
			Me.RTecnune = Me.NullToDouble(tmpDataRowView.Item("datRTecnune"))
			Me.RTecnlan = Me.NullToDouble(tmpDataRowView.Item("datRTecnlan"))
			Me.c = Me.NullToDouble(tmpDataRowView.Item("datC"))
			Me.d = Me.NullToDouble(tmpDataRowView.Item("datD"))
			Me.Teclspe1 = Me.NullToDouble(tmpDataRowView.Item("datTeclspe1"))
			Me.Teclspe2 = Me.NullToDouble(tmpDataRowView.Item("datTeclspe2"))
			Me.Teclspe3 = Me.NullToDouble(tmpDataRowView.Item("datTeclspe3"))
			Me.Teclspe4 = Me.NullToDouble(tmpDataRowView.Item("datTeclspe4"))
			Me.Teclhab1du = Me.NullToDouble(tmpDataRowView.Item("datTeclhab1du"))
			Me.Teclhab2du = Me.NullToDouble(tmpDataRowView.Item("datTeclhab2du"))
			Me.Teclhab3du = Me.NullToDouble(tmpDataRowView.Item("datTeclhab3du"))
			Me.Teclhab4du = Me.NullToDouble(tmpDataRowView.Item("datTeclhab4du"))
			Me.RTeclspeQ = tmpDataRowView.Item("datRTeclspeQ").ToString
			Me.RTeclhabQ = tmpDataRowView.Item("datRTeclhabQ").ToString
			Me.RTeclspe = Me.NullToDouble(tmpDataRowView.Item("datRTeclspe"))
			Me.RTeclhab = Me.NullToDouble(tmpDataRowView.Item("datRTeclhab"))
			Me.Tsclhea1 = Me.NullToDouble(tmpDataRowView.Item("datTsclhea1"))
			Me.Tsclhea2 = Me.NullToDouble(tmpDataRowView.Item("datTsclhea2"))
			Me.Tsclhea3 = Me.NullToDouble(tmpDataRowView.Item("datTsclhea3"))
			Me.Tsclhea4 = Me.NullToDouble(tmpDataRowView.Item("datTsclhea4"))
			Me.Tsclsoc1 = Me.NullToDouble(tmpDataRowView.Item("datTsclsoc1"))
			Me.Tsclsoc2 = Me.NullToDouble(tmpDataRowView.Item("datTsclsoc2"))
			Me.Tsclsoc3 = Me.NullToDouble(tmpDataRowView.Item("datTsclsoc3"))
			Me.Tsclsoc4 = Me.NullToDouble(tmpDataRowView.Item("datTsclsoc4"))
			Me.RTsclheaQ = tmpDataRowView.Item("datRTsclheaQ").ToString
			Me.RTsclsocQ = tmpDataRowView.Item("datRTsclsocQ").ToString
			Me.RTsclhea = Me.NullToDouble(tmpDataRowView.Item("datRTsclhea"))
			Me.RTsclsoc = Me.NullToDouble(tmpDataRowView.Item("datRTsclsoc"))
			Me.COs = Me.NullToDouble(tmpDataRowView.Item("datCOs"))
			Me.COe = Me.NullToDouble(tmpDataRowView.Item("datCOe"))
			Me.COi = Me.NullToDouble(tmpDataRowView.Item("datCOi"))
			Me.COse = Me.NullToDouble(tmpDataRowView.Item("datCOse"))
			Me.COsi = Me.NullToDouble(tmpDataRowView.Item("datCOsi"))
			Me.COei = Me.NullToDouble(tmpDataRowView.Item("datCOei"))
			Me.COsei = Me.NullToDouble(tmpDataRowView.Item("datCOsei"))
			Me.i11x = Me.NullToDouble(tmpDataRowView.Item("datI11x"))
			Me.se13x = Me.NullToDouble(tmpDataRowView.Item("datse13x"))
			Me.se23x = Me.NullToDouble(tmpDataRowView.Item("datse23x"))
			Me.p = Me.NullToDouble(tmpDataRowView.Item("datp"))
			Me.t = Me.NullToDouble(tmpDataRowView.Item("datt"))
		Else
			'no data in DB
			Me.E22 = 0
			Me.E13 = 0
			Me.E23 = 0
			Me.W21 = "N"
			Me.W31 = "N"
			Me.W12 = 0
			Me.W22 = "N"
			Me.W13 = "N"
			Me.W23 = "N"
			Me.B21 = "N"
			Me.B31 = "N"
			Me.B12 = 0
			Me.B22 = "N"
			Me.B13 = "N"
			Me.B23 = "N"
			Me.v1 = 0
			Me.v2 = 0
			Me.v3 = 0
			Me.v4 = 0
			Me.v5 = 0
			Me.v6 = 0
			Me.v7 = 0
			Me.v8 = 0
			Me.a1 = 0
			Me.a2 = 0
			Me.a3 = 0
			Me.a4 = 0
			Me.a5 = 0
			Me.a6 = 0
			Me.a7 = 0
			Me.a8 = 0
			Me.b1 = 0
			Me.b2 = 0
			Me.b3 = 0
			Me.b4 = 0
			Me.b5 = 0
			Me.b6 = 0
			Me.b7 = 0
			Me.b8 = 0
			Me.z = 0
			Me.zz = 0
			Me.m = 0
			Me.Tecnune1 = 0
			Me.Tecnune2 = 0
			Me.Tecnune3 = 0
			Me.Tecnune4 = 0
			Me.Tecnlan1 = 0
			Me.Tecnlan2 = 0
			Me.Tecnlan3 = 0
			Me.Tecnlan4 = 0
			Me.RTecnuneQ = "N"
			Me.RTecnlanQ = "N"
			Me.RTecnune = 0
			Me.RTecnlan = 0
			Me.c = 0
			Me.d = 0
			Me.Teclspe1 = 0
			Me.Teclspe2 = 0
			Me.Teclspe3 = 0
			Me.Teclspe4 = 0
			Me.Teclhab1du = 0
			Me.Teclhab2du = 0
			Me.Teclhab3du = 0
			Me.Teclhab4du = 0
			Me.RTeclspeQ = "N"
			Me.RTeclhabQ = "N"
			Me.RTeclspe = 0
			Me.RTeclhab = 0
			Me.Tsclhea1 = 0
			Me.Tsclhea2 = 0
			Me.Tsclhea3 = 0
			Me.Tsclhea4 = 0
			Me.Tsclsoc1 = 0
			Me.Tsclsoc2 = 0
			Me.Tsclsoc3 = 0
			Me.Tsclsoc4 = 0
			Me.RTsclheaQ = "N"
			Me.RTsclsocQ = "N"
			Me.RTsclhea = 0
			Me.RTsclsoc = 0
			Me.COs = 0
			Me.COe = 0
			Me.COi = 0
			Me.COse = 0
			Me.COsi = 0
			Me.COei = 0
			Me.COsei = 0
			Me.e11r = 0
			Me.i11x = 0
			Me.se13x = 0
			Me.se23x = 0
			Me.p = 0
			Me.t = 0
		End If

		Me.graph1Range = 0.5
		Me.graph2Range = 0.5
		Me.graph3Range = 0.5
		Me.graph4Range = 0.5
		Me.graph5Range = 0.5
		Me.graph6Range = 0.5

		Me.WriteValuesToGUI(True)
	End Sub

	''' <summary>
	''' writes data into DB
	''' </summary>
	''' <remarks></remarks>
	Private Sub WriteValuesToDB()
		Dim newRow As DataRow

		If MessageBox.Show("Do you want to save the current scenario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
			newRow = Me.DSData.Tables("data").NewRow

			'newRow("datID") = Me.ID
			newRow("datDE") = Me.DE
			newRow("datDU") = Me.DU
			newRow("datY") = Me.Y
			newRow("datFR") = Me.FR
			newRow("datS1") = Me.S1
			newRow("datS2") = Me.S2
			newRow("datS3") = Me.S3
			newRow("datE11") = Me.E11
			newRow("datE11r") = Me.e11r
			newRow("datE21") = Me.E21
			newRow("datE31") = Me.E31
			newRow("datE12") = Me.E12
			newRow("datE22") = Me.E22
			newRow("datE13") = Me.E13
			newRow("datE23") = Me.E23
			newRow("datW11") = Me.W11
			newRow("datW21") = Me.W21
			newRow("datW31") = Me.W31
			newRow("datW12") = Me.W12
			newRow("datW22") = Me.W22
			newRow("datW13") = Me.W13
			newRow("datW23") = Me.W23
			newRow("datB11") = Me.B11
			newRow("datB21") = Me.B21
			newRow("datB31") = Me.B31
			newRow("datB12") = Me.B12
			newRow("datB22") = Me.B22
			newRow("datB13") = Me.B13
			newRow("datB23") = Me.B23
			newRow("datV1") = Me.v1
			newRow("datV2") = Me.v2
			newRow("datV3") = Me.v3
			newRow("datV4") = Me.v4
			newRow("datV5") = Me.v5
			newRow("datV6") = Me.v6
			newRow("datV7") = Me.v7
			newRow("datV8") = Me.v8
			newRow("datA1") = Me.a1
			newRow("datA2") = Me.a2
			newRow("datA3") = Me.a3
			newRow("datA4") = Me.a4
			newRow("datA5") = Me.a5
			newRow("datA6") = Me.a6
			newRow("datA7") = Me.a7
			newRow("datA8") = Me.a8
			newRow("datB1") = Me.b1
			newRow("datB2") = Me.b2
			newRow("datB3") = Me.b3
			newRow("datB4") = Me.b4
			newRow("datB5") = Me.b5
			newRow("datB6") = Me.b6
			newRow("datB7") = Me.b7
			newRow("datB8") = Me.b8
			newRow("datZ") = Me.z
			newRow("datZZ") = Me.zz
			newRow("datM") = Me.m
			newRow("datTecnune1") = Me.Tecnune1
			newRow("datTecnune2") = Me.Tecnune2
			newRow("datTecnune3") = Me.Tecnune3
			newRow("datTecnune4") = Me.Tecnune4
			newRow("datTecnlan1") = Me.Tecnlan1
			newRow("datTecnlan2") = Me.Tecnlan2
			newRow("datTecnlan3") = Me.Tecnlan3
			newRow("datTecnlan4") = Me.Tecnlan4
			newRow("datRTecnuneQ") = Me.RTecnuneQ
			newRow("datRTecnlanQ") = Me.RTecnlanQ
			newRow("datRTecnune") = Me.RTecnune
			newRow("datRTecnlan") = Me.RTecnlan
			newRow("datC") = Me.c
			newRow("datD") = Me.d
			newRow("datTeclspe1") = Me.Teclspe1
			newRow("datTeclspe2") = Me.Teclspe2
			newRow("datTeclspe3") = Me.Teclspe3
			newRow("datTeclspe4") = Me.Teclspe4
			newRow("datTeclhab1du") = Me.Teclhab1du
			newRow("datTeclhab2du") = Me.Teclhab2du
			newRow("datTeclhab3du") = Me.Teclhab3du
			newRow("datTeclhab4du") = Me.Teclhab4du
			newRow("datRTeclspeQ") = Me.RTeclspeQ
			newRow("datRTeclhabQ") = Me.RTeclhabQ
			newRow("datRTeclspe") = Me.RTeclspe
			newRow("datRTeclhab") = Me.RTeclhab
			newRow("datTsclhea1") = Me.Tsclhea1
			newRow("datTsclhea2") = Me.Tsclhea2
			newRow("datTsclhea3") = Me.Tsclhea3
			newRow("datTsclhea4") = Me.Tsclhea4
			newRow("datTsclsoc1") = Me.Tsclsoc1
			newRow("datTsclsoc2") = Me.Tsclsoc2
			newRow("datTsclsoc3") = Me.Tsclsoc3
			newRow("datTsclsoc4") = Me.Tsclsoc4
			newRow("datRTsclheaQ") = Me.RTsclheaQ
			newRow("datRTsclsocQ") = Me.RTsclsocQ
			newRow("datRTsclhea") = Me.RTsclhea
			newRow("datRTsclsoc") = Me.RTsclsoc
			newRow("datCOs") = Me.COs
			newRow("datCOe") = Me.COe
			newRow("datCOi") = Me.COi
			newRow("datCOse") = Me.COse
			newRow("datCOsi") = Me.COsi
			newRow("datCOei") = Me.COei
			newRow("datCOsei") = Me.COsei
			newRow("dati11x") = Me.i11x
			newRow("datse13x") = Me.se13x
			newRow("datse23x") = Me.se23x
			newRow("datW21n") = Me.W21n
			newRow("datW31n") = Me.W31n
			newRow("datW12n") = Me.W12n
			newRow("datW22n") = Me.W22n
			newRow("datW13n") = Me.W13n
			newRow("datW23n") = Me.W23n
			newRow("datB21n") = Me.B21n
			newRow("datB31n") = Me.B31n
			newRow("datB12n") = Me.B12n
			newRow("datB22n") = Me.B22n
			newRow("datB13n") = Me.B13n
			newRow("datB23n") = Me.B23n
			newRow("datP") = Me.p
			newRow("datT") = Me.t
			newRow("datF11") = Me.F11
			newRow("datF21") = Me.F21
			newRow("datF31") = Me.F31
			newRow("datF12") = Me.F12
			newRow("datF22") = Me.F22
			newRow("datF13") = Me.F13
			newRow("datF23") = Me.F23
			newRow("datF11s") = Me.F11s
			newRow("datF21s") = Me.F21s
			newRow("datF31s") = Me.F31s
			newRow("datF12s") = Me.F12s
			newRow("datF22s") = Me.F22s
			newRow("datF13s") = Me.F13s
			newRow("datF23s") = Me.F23s
			newRow("datF11e") = Me.F11e
			newRow("datF21e") = Me.F21e
			newRow("datF31e") = Me.F31e
			newRow("datF12e") = Me.F12e
			newRow("datF22e") = Me.F22e
			newRow("datF13e") = Me.F13e
			newRow("datF23e") = Me.F23e
			newRow("datF11i") = Me.F11i
			newRow("datF21i") = Me.F21i
			newRow("datF31i") = Me.F31i
			newRow("datF12i") = Me.F12i
			newRow("datF22i") = Me.F22i
			newRow("datF13i") = Me.F13i
			newRow("datF23i") = Me.F23i
			newRow("datF11se") = Me.F11se
			newRow("datF21se") = Me.F21se
			newRow("datF31se") = Me.F31se
			newRow("datF12se") = Me.F12se
			newRow("datF22se") = Me.F22se
			newRow("datF13se") = Me.F13se
			newRow("datF23se") = Me.F23se
			newRow("datF11si") = Me.F11si
			newRow("datF21si") = Me.F21si
			newRow("datF31si") = Me.F31si
			newRow("datF12si") = Me.F12si
			newRow("datF22si") = Me.F22si
			newRow("datF13si") = Me.F13si
			newRow("datF23si") = Me.F23si
			newRow("datF11ei") = Me.F11ei
			newRow("datF21ei") = Me.F21ei
			newRow("datF31ei") = Me.F31ei
			newRow("datF12ei") = Me.F12ei
			newRow("datF22ei") = Me.F22ei
			newRow("datF13ei") = Me.F13ei
			newRow("datF23ei") = Me.F23ei
			newRow("datF11sei") = Me.F11sei
			newRow("datF21sei") = Me.F21sei
			newRow("datF31sei") = Me.F31sei
			newRow("datF12sei") = Me.F12sei
			newRow("datF22sei") = Me.F22sei
			newRow("datF13sei") = Me.F13sei
			newRow("datF23sei") = Me.F23sei
			newRow("datXs") = Me.Xs
			newRow("datXe") = Me.Xe
			newRow("datXi") = Me.Xi
			newRow("datXse") = Me.Xse
			newRow("datXsi") = Me.Xsi
			newRow("datXei") = Me.Xei
			newRow("datXsei") = Me.Xsei
			newRow("datRXs") = Me.RXs
			newRow("datRXe") = Me.RXe
			newRow("datRXi") = Me.RXi
			newRow("datRXse") = Me.RXse
			newRow("datRXsi") = Me.RXsi
			newRow("datRXei") = Me.RXei
			newRow("datRXsei") = Me.RXsei
			newRow("DataCreazione") = Now
			newRow("UtenteCreazione") = 1
			newRow("DataAggiornamento") = Now
			newRow("UtenteAggiornamento") = 1
			newRow("Annullato") = 0
			newRow.EndEdit()

			Me.DSData.Tables("data").Rows.Add(newRow)

			Me.daData.Update(Me.DSData, "data")
		End If
	End Sub

	''' <summary>
	''' write results tu GUI
	''' </summary>
	''' <remarks></remarks>
	Private Sub WriteValuesToGUI(ByVal userInput As Boolean)
		If userInput Then
			Me.nudDE.Value = CType(Me.DE, Decimal)
			Me.nudDU.Value = CType(Me.DU, Decimal)
			Me.nudY.Value = CType(Me.Y, Decimal)
			Me.nudFR.Value = CType(Me.FR, Decimal)
			Me.nudS1.Value = CType(Me.S1, Decimal)
			Me.nudS2.Value = CType(Me.S2, Decimal)
			Me.nudS3.Value = CType(Me.S3, Decimal)
			Me.nudE11.Value = CType(Me.E11, Decimal)
			Me.nudE21.Value = CType(Me.E21, Decimal)
			Me.nudE31.Value = CType(Me.E31, Decimal)
			Me.nudE11.Value = CType(Me.E12, Decimal)
			Me.nudE22.Value = CType(Me.E22, Decimal)
			Me.nudE13.Value = CType(Me.E13, Decimal)
			Me.nudE23.Value = CType(Me.E23, Decimal)
			Me.nudW12.Value = CType(Me.W12, Decimal)
			Me.nudB12.Value = CType(Me.B12, Decimal)
			Me.nudV1.Value = CType(Me.v1, Decimal)
			Me.nudV2.Value = CType(Me.v2, Decimal)
			Me.nudV3.Value = CType(Me.v3, Decimal)
			Me.nudV4.Value = CType(Me.v4, Decimal)
			Me.nudV5.Value = CType(Me.v5, Decimal)
			Me.nudV6.Value = CType(Me.v6, Decimal)
			Me.nudV7.Value = CType(Me.v7, Decimal)
			Me.nudV8.Value = CType(Me.v8, Decimal)
			Me.nudA1.Value = CType(Me.a1, Decimal)
			Me.nudA2.Value = CType(Me.a2, Decimal)
			Me.nudA3.Value = CType(Me.a3, Decimal)
			Me.nudA4.Value = CType(Me.a4, Decimal)
			Me.nudA5.Value = CType(Me.a5, Decimal)
			Me.nudA6.Value = CType(Me.a6, Decimal)
			Me.nudA7.Value = CType(Me.a7, Decimal)
			Me.nudA8.Value = CType(Me.a8, Decimal)
			Me.nudB1.Value = CType(Me.b1, Decimal)
			Me.nudB2.Value = CType(Me.b2, Decimal)
			Me.nudB3.Value = CType(Me.b3, Decimal)
			Me.nudB4.Value = CType(Me.b4, Decimal)
			Me.nudB5.Value = CType(Me.b5, Decimal)
			Me.nudB6.Value = CType(Me.b6, Decimal)
			Me.nudB7.Value = CType(Me.b7, Decimal)
			Me.nudB8.Value = CType(Me.b8, Decimal)
			Me.nudz.Value = CType(Me.z, Decimal)
			Me.nudzz.Value = CType(Me.zz, Decimal)
			Me.nudm.Value = CType(Me.m, Decimal)
			Me.nudTecnune1.Value = CType(Me.Tecnune1, Decimal)
			Me.nudTecnune2.Value = CType(Me.Tecnune2, Decimal)
			Me.nudTecnune3.Value = CType(Me.Tecnune3, Decimal)
			Me.nudTecnune4.Value = CType(Me.Tecnune4, Decimal)
			Me.nudTecnlan1.Value = CType(Me.Tecnlan1, Decimal)
			Me.nudTecnlan2.Value = CType(Me.Tecnlan2, Decimal)
			Me.nudTecnlan3.Value = CType(Me.Tecnlan3, Decimal)
			Me.nudTecnlan4.Value = CType(Me.Tecnlan4, Decimal)
			Me.nudRTecnune.Value = CType(Me.RTecnune, Decimal)
			Me.nudRTecnlan.Value = CType(Me.RTecnlan, Decimal)
			Me.nudC.Value = CType(Me.c, Decimal)
			Me.nudD.Value = CType(Me.d, Decimal)
			Me.nudTeclspe1.Value = CType(Me.Teclspe1, Decimal)
			Me.nudTeclspe2.Value = CType(Me.Teclspe2, Decimal)
			Me.nudTeclspe3.Value = CType(Me.Teclspe3, Decimal)
			Me.nudTeclspe4.Value = CType(Me.Teclspe4, Decimal)
			Me.nudTeclhab1du.Value = CType(Me.Teclhab1du, Decimal)
			Me.nudTeclhab2du.Value = CType(Me.Teclhab2du, Decimal)
			Me.nudTeclhab3du.Value = CType(Me.Teclhab3du, Decimal)
			Me.nudTeclhab4du.Value = CType(Me.Teclhab4du, Decimal)
			Me.nudRTeclspe.Value = CType(Me.RTeclspe, Decimal)
			Me.nudRTeclhab.Value = CType(Me.RTeclhab, Decimal)
			Me.nudTsclhea1.Value = CType(Me.Tsclhea1, Decimal)
			Me.nudTsclhea2.Value = CType(Me.Tsclhea2, Decimal)
			Me.nudTsclhea3.Value = CType(Me.Tsclhea3, Decimal)
			Me.nudTsclhea4.Value = CType(Me.Tsclhea4, Decimal)
			Me.nudTsclsoc1.Value = CType(Me.Tsclsoc1, Decimal)
			Me.nudTsclsoc2.Value = CType(Me.Tsclsoc2, Decimal)
			Me.nudTsclsoc3.Value = CType(Me.Tsclsoc3, Decimal)
			Me.nudTsclsoc4.Value = CType(Me.Tsclsoc4, Decimal)
			Me.nudRTsclhea.Value = CType(Me.RTsclhea, Decimal)
			Me.nudRTsclsoc.Value = CType(Me.RTsclsoc, Decimal)
			Me.nudCOs.Value = CType(Me.COs, Decimal)
			Me.nudCOe.Value = CType(Me.COe, Decimal)
			Me.nudCOi.Value = CType(Me.COi, Decimal)
			Me.nudCOse.Value = CType(Me.COse, Decimal)
			Me.nudCOsi.Value = CType(Me.COsi, Decimal)
			Me.nudCOei.Value = CType(Me.COei, Decimal)
			Me.nudCOsei.Value = CType(Me.COsei, Decimal)
			Me.nudE11r.Value = CType(Me.e11r, Decimal)
			Me.nudI11x.Value = CType(Me.i11x, Decimal)
			Me.nudse13x.Value = CType(Me.se13x, Decimal)
			Me.nudse23x.Value = CType(Me.se23x, Decimal)
			Me.nudP.Value = CType(Me.p, Decimal)
			Me.nudT.Value = CType(Me.t, Decimal)
			Me.cboW21.SelectedValue = Me.W21
			Me.cboW31.SelectedValue = Me.W31
			Me.cboW22.SelectedValue = Me.W22
			Me.cboW13.SelectedValue = Me.W13
			Me.cboW23.SelectedValue = Me.W23
			Me.cboB21.SelectedValue = Me.B21
			Me.cboB31.SelectedValue = Me.B31
			Me.cboB22.SelectedValue = Me.B22
			Me.cboB13.SelectedValue = Me.B13
			Me.cboB23.SelectedValue = Me.B23
			Me.cboRTecnuneQ.SelectedValue = Me.RTecnuneQ
			Me.cboRTecnlanQ.SelectedValue = Me.RTecnlanQ
			Me.cboRTeclspeQ.SelectedValue = Me.RTeclspeQ
			Me.cboRTeclhabQ.SelectedValue = Me.RTeclhabQ
			Me.cboRTsclheaQ.SelectedValue = Me.RTsclheaQ
			Me.cboRTsclsocQ.SelectedValue = Me.RTsclsocQ
		Else
			'exposure
			Me.lblF11.Text = Format(Me.F11, "##,##0").ToString
			Me.lblF11s.Text = Format(Me.F11s, "##,##0").ToString
			Me.lblF11e.Text = Format(Me.F11e, "##,##0").ToString
			Me.lblF11i.Text = Format(Me.F11i, "##,##0").ToString
			Me.lblF11se.Text = Format(Me.F11se, "##,##0").ToString
			Me.lblF11si.Text = Format(Me.F11si, "##,##0").ToString
			Me.lblF11ei.Text = Format(Me.F11ei, "##,##0").ToString
			Me.lblF11sei.Text = Format(Me.F11sei, "##,##0").ToString
			Me.lblF21s.Text = Me.F21s
			Me.lblF21e.Text = Me.F21e
			Me.lblF21i.Text = Me.F21i
			Me.lblF21se.Text = Me.F21se
			Me.lblF21si.Text = Me.F21si
			Me.lblF21ei.Text = Me.F21ei
			Me.lblF21sei.Text = Me.F21sei
			Me.lblF31s.Text = Me.F31s
			Me.lblF31e.Text = Me.F31e
			Me.lblF31i.Text = Me.F31i
			Me.lblF31se.Text = Me.F31se
			Me.lblF31si.Text = Me.F31si
			Me.lblF31ei.Text = Me.F31ei
			Me.lblF31sei.Text = Me.F31sei
			Me.lblF12.Text = Me.F12
			Me.lblF12s.Text = Me.F12s
			Me.lblF12e.Text = Me.F12e
			Me.lblF12i.Text = Me.F12i
			Me.lblF12se.Text = Me.F12se
			Me.lblF12si.Text = Me.F12si
			Me.lblF12ei.Text = Me.F12ei
			Me.lblF12sei.Text = Me.F12sei
			Me.lblF22s.Text = Me.F22s
			Me.lblF22e.Text = Me.F22e
			Me.lblF22i.Text = Me.F22i
			Me.lblF22se.Text = Me.F22se
			Me.lblF22si.Text = Me.F22si
			Me.lblF22ei.Text = Me.F22ei
			Me.lblF22sei.Text = Me.F22sei
			Me.lblF13s.Text = Me.F13s
			Me.lblF13e.Text = Me.F13e
			Me.lblF13i.Text = Me.F13i
			Me.lblF13se.Text = Me.F13se
			Me.lblF13si.Text = Me.F13si
			Me.lblF13ei.Text = Me.F13ei
			Me.lblF13sei.Text = Me.F13sei
			Me.lblF23s.Text = Me.F23s
			Me.lblF23e.Text = Me.F23e
			Me.lblF23i.Text = Me.F23i
			Me.lblF23se.Text = Me.F23se
			Me.lblF23si.Text = Me.F23si
			Me.lblF23ei.Text = Me.F23ei
			Me.lblF23sei.Text = Me.F23sei
			'Me.lblF11.Text = Format(Me.W11, "##,##0.00").ToString
			Me.lblF21.Text = Me.F21
			Me.lblF31.Text = Me.F31
			Me.lblF22.Text = Me.F22
			Me.lblF13.Text = Me.F13
			Me.lblF23.Text = Me.F23
			'exposure scores
			Me.lblScoreExposure1.Text = Me.outputExposure(0).label
			Me.lblScoreExposureValue1.Text = Format(Me.outputExposure(0).value, "##,##0.0000")
			Me.lblScoreExposure2.Text = Me.outputExposure(1).label
			Me.lblScoreExposureValue2.Text = Format(Me.outputExposure(1).value, "##,##0.0000")
			Me.lblScoreExposure3.Text = Me.outputExposure(2).label
			Me.lblScoreExposureValue3.Text = Format(Me.outputExposure(2).value, "##,##0.0000")
			Me.lblScoreExposure4.Text = Me.outputExposure(3).label
			Me.lblScoreExposureValue4.Text = Format(Me.outputExposure(3).value, "##,##0.0000")
			Me.lblScoreExposure5.Text = Me.outputExposure(4).label
			Me.lblScoreExposureValue5.Text = Format(Me.outputExposure(4).value, "##,##0.0000")
			Me.lblScoreExposure6.Text = Me.outputExposure(5).label
			Me.lblScoreExposureValue6.Text = Format(Me.outputExposure(5).value, "##,##0.0000")
			Me.lblScoreExposure7.Text = Me.outputExposure(6).label
			Me.lblScoreExposureValue7.Text = Format(Me.outputExposure(6).value, "##,##0.0000")
			'resilience
			Me.lblR11.Text = Format(Me.W11, "##,##0").ToString
			Me.lblR11s.Text = Format(Me.R11s, "##,##0").ToString
			Me.lblR11e.Text = Format(Me.R11e, "##,##0").ToString
			Me.lblR11i.Text = Format(Me.R11i, "##,##0").ToString
			Me.lblR11se.Text = Format(Me.R11se, "##,##0").ToString
			Me.lblR11si.Text = Format(Me.R11si, "##,##0").ToString
			Me.lblR11ei.Text = Format(Me.R11ei, "##,##0").ToString
			Me.lblR11sei.Text = Format(Me.R11sei, "##,##0").ToString
			Me.lblR21s.Text = Me.R21s.ToString
			Me.lblR21e.Text = Me.R21e.ToString
			Me.lblR21i.Text = Me.R21i.ToString
			Me.lblR21se.Text = Me.R21se.ToString
			Me.lblR21si.Text = Me.R21si.ToString
			Me.lblR21ei.Text = Me.R21ei.ToString
			Me.lblR21sei.Text = Me.R21sei.ToString
			Me.lblR31s.Text = Me.R31s.ToString
			Me.lblR31e.Text = Me.R31e.ToString
			Me.lblR31i.Text = Me.R31i.ToString
			Me.lblR31se.Text = Me.R31se.ToString
			Me.lblR31si.Text = Me.R31si.ToString
			Me.lblR31ei.Text = Me.R31ei.ToString
			Me.lblR31sei.Text = Me.R31sei.ToString
			Me.lblR12.Text = Me.R12.ToString
			Me.lblR12s.Text = Me.R12s.ToString
			Me.lblR12e.Text = Me.R12e.ToString
			Me.lblR12i.Text = Me.R12i.ToString
			Me.lblR12se.Text = Me.R12se.ToString
			Me.lblR12si.Text = Me.R12si.ToString
			Me.lblR12ei.Text = Me.R12ei.ToString
			Me.lblR12sei.Text = Me.R12sei.ToString
			Me.lblR22s.Text = Me.R22s.ToString
			Me.lblR22e.Text = Me.R22e.ToString
			Me.lblR22i.Text = Me.R22i.ToString
			Me.lblR22se.Text = Me.R22se.ToString
			Me.lblR22si.Text = Me.R22si.ToString
			Me.lblR22ei.Text = Me.R22ei.ToString
			Me.lblR22sei.Text = Me.R22sei.ToString
			Me.lblR13s.Text = Me.R13s.ToString
			Me.lblR13e.Text = Me.R13e.ToString
			Me.lblR13i.Text = Me.R13i.ToString
			Me.lblR13se.Text = Me.R13se.ToString
			Me.lblR13si.Text = Me.R13si.ToString
			Me.lblR13ei.Text = Me.R13ei.ToString
			Me.lblR13sei.Text = Me.R13sei.ToString
			Me.lblR23s.Text = Me.R23s.ToString
			Me.lblR23e.Text = Me.R23e.ToString
			Me.lblR23i.Text = Me.R23i.ToString
			Me.lblR23se.Text = Me.R23se.ToString
			Me.lblR23si.Text = Me.R23si.ToString
			Me.lblR23ei.Text = Me.R23ei.ToString
			Me.lblR23sei.Text = Me.R23sei.ToString
			Me.lblR21.Text = Me.R21.ToString
			Me.lblR31.Text = Me.R31.ToString
			Me.lblR22.Text = Me.R22.ToString
			Me.lblR13.Text = Me.R13.ToString
			Me.lblR23.Text = Me.R23.ToString
			'resilience scores
			Me.lblScoreResilience1.Text = Me.outputResilience(0).label
			Me.lblScoreResilienceValue1.Text = Format(Me.outputResilience(0).value, "##,##0.0000")
			Me.lblScoreResilience2.Text = Me.outputResilience(1).label
			Me.lblScoreResilienceValue2.Text = Format(Me.outputResilience(1).value, "##,##0.0000")
			Me.lblScoreResilience3.Text = Me.outputResilience(2).label
			Me.lblScoreResilienceValue3.Text = Format(Me.outputResilience(2).value, "##,##0.0000")
			Me.lblScoreResilience4.Text = Me.outputResilience(3).label
			Me.lblScoreResilienceValue4.Text = Format(Me.outputResilience(3).value, "##,##0.0000")
			Me.lblScoreResilience5.Text = Me.outputResilience(4).label
			Me.lblScoreResilienceValue5.Text = Format(Me.outputResilience(4).value, "##,##0.0000")
			Me.lblScoreResilience6.Text = Me.outputResilience(5).label
			Me.lblScoreResilienceValue6.Text = Format(Me.outputResilience(5).value, "##,##0.0000")
			Me.lblScoreResilience7.Text = Me.outputResilience(6).label
			Me.lblScoreResilienceValue7.Text = Format(Me.outputResilience(6).value, "##,##0.0000")
		End If
	End Sub

	''' <summary>
	''' read values from user interface to global variables
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromGUI()
		Me.DE = Me.nudDE.Value
		Me.DU = Me.nudDU.Value
		Me.Y = Me.nudY.Value
		Me.FR = Me.nudFR.Value
		Me.S1 = Me.nudS1.Value
		Me.S2 = Me.nudS2.Value
		Me.S3 = Me.nudS3.Value
		Me.E11 = Me.nudE11.Value
		Me.E21 = Me.nudE21.Value
		Me.E31 = Me.nudE31.Value
		Me.E12 = Me.nudE11.Value
		Me.E22 = Me.nudE22.Value
		Me.E13 = Me.nudE13.Value
		Me.E23 = Me.nudE23.Value
		Me.W21 = Me.cboW21.SelectedValue.ToString
		Me.W31 = Me.cboW31.SelectedValue.ToString
		Me.W12 = Me.nudW12.Value
		Me.W22 = Me.cboW22.SelectedValue.ToString
		Me.W13 = Me.cboW13.SelectedValue.ToString
		Me.W23 = Me.cboW23.SelectedValue.ToString
		Me.B21 = Me.cboB21.SelectedValue.ToString
		Me.B31 = Me.cboB31.SelectedValue.ToString
		Me.B12 = Me.nudB12.Value
		Me.B22 = Me.cboB22.SelectedValue.ToString
		Me.B13 = Me.cboB13.SelectedValue.ToString
		Me.B23 = Me.cboB23.SelectedValue.ToString
		Me.v1 = Me.nudV1.Value
		Me.v2 = Me.nudV2.Value
		Me.v3 = Me.nudV3.Value
		Me.v4 = Me.nudV4.Value
		Me.v5 = Me.nudV5.Value
		Me.v6 = Me.nudV6.Value
		Me.v7 = Me.nudV7.Value
		Me.v8 = Me.nudV8.Value
		Me.a1 = Me.nudA1.Value
		Me.a2 = Me.nudA2.Value
		Me.a3 = Me.nudA3.Value
		Me.a4 = Me.nudA4.Value
		Me.a5 = Me.nudA5.Value
		Me.a6 = Me.nudA6.Value
		Me.a7 = Me.nudA7.Value
		Me.a8 = Me.nudA8.Value
		Me.b1 = Me.nudB1.Value
		Me.b2 = Me.nudB2.Value
		Me.b3 = Me.nudB3.Value
		Me.b4 = Me.nudB4.Value
		Me.b5 = Me.nudB5.Value
		Me.b6 = Me.nudB6.Value
		Me.b7 = Me.nudB7.Value
		Me.b8 = Me.nudB8.Value
		Me.z = Me.nudz.Value
		Me.zz = Me.nudzz.Value
		Me.m = Me.nudm.Value
		Me.Tecnune1 = Me.nudTecnune1.Value
		Me.Tecnune2 = Me.nudTecnune2.Value
		Me.Tecnune3 = Me.nudTecnune3.Value
		Me.Tecnune4 = Me.nudTecnune4.Value
		Me.Tecnlan1 = Me.nudTecnlan1.Value
		Me.Tecnlan2 = Me.nudTecnlan2.Value
		Me.Tecnlan3 = Me.nudTecnlan3.Value
		Me.Tecnlan4 = Me.nudTecnlan4.Value
		Me.RTecnuneQ = Me.cboRTecnuneQ.SelectedValue.ToString
		Me.RTecnlanQ = Me.cboRTecnlanQ.SelectedValue.ToString
		Me.RTecnune = Me.nudRTecnune.Value
		Me.RTecnlan = Me.nudRTecnlan.Value
		Me.c = Me.nudC.Value
		Me.d = Me.nudD.Value
		Me.Teclspe1 = Me.nudTeclspe1.Value
		Me.Teclspe2 = Me.nudTeclspe2.Value
		Me.Teclspe3 = Me.nudTeclspe3.Value
		Me.Teclspe4 = Me.nudTeclspe4.Value
		Me.Teclhab1du = Me.nudTeclhab1du.Value
		Me.Teclhab2du = Me.nudTeclhab2du.Value
		Me.Teclhab3du = Me.nudTeclhab3du.Value
		Me.Teclhab4du = Me.nudTeclhab4du.Value
		Me.RTeclspeQ = Me.cboRTeclspeQ.SelectedValue.ToString
		Me.RTeclhabQ = Me.cboRTeclhabQ.SelectedValue.ToString
		Me.RTeclspe = Me.nudRTeclspe.Value
		Me.RTeclhab = Me.nudRTeclhab.Value
		Me.Tsclhea1 = Me.nudTsclhea1.Value
		Me.Tsclhea2 = Me.nudTsclhea2.Value
		Me.Tsclhea3 = Me.nudTsclhea3.Value
		Me.Tsclhea4 = Me.nudTsclhea4.Value
		Me.Tsclsoc1 = Me.nudTsclsoc1.Value
		Me.Tsclsoc2 = Me.nudTsclsoc2.Value
		Me.Tsclsoc3 = Me.nudTsclsoc3.Value
		Me.Tsclsoc4 = Me.nudTsclsoc4.Value
		Me.RTsclheaQ = Me.cboRTsclheaQ.SelectedValue.ToString
		Me.RTsclsocQ = Me.cboRTsclsocQ.SelectedValue.ToString
		Me.RTsclhea = Me.nudRTsclhea.Value
		Me.RTsclsoc = Me.nudRTsclsoc.Value
		Me.COs = Me.nudCOs.Value
		Me.COe = Me.nudCOe.Value
		Me.COi = Me.nudCOi.Value
		Me.COse = Me.nudCOse.Value
		Me.COsi = Me.nudCOsi.Value
		Me.COei = Me.nudCOei.Value
		Me.COsei = Me.nudCOsei.Value
		Me.e11r = Me.nudE11r.Value
		Me.i11x = Me.nudI11x.Value
		Me.se13x = Me.nudse13x.Value
		Me.se23x = Me.nudse23x.Value
		Me.p = Me.nudP.Value
		Me.t = Me.nudT.Value
	End Sub

	''' <summary>
	''' read last record from DB
	''' </summary>
	''' <remarks></remarks>
	Private Function Init() As Boolean
		Dim kernelPath As String
		Dim result As Boolean

		result = False
		kernelPath = ""

		Try
			Me.TAParameters.Fill(Me.dsParameters._parameters)
			'read parameters
			kernelPath = Me.dsParameters._parameters.Rows(0).Item("parKernelPath").ToString
		Catch ex As Exception
			MessageBox.Show("Error reading parameters form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

		If kernelPath = "" OrElse Not System.IO.File.Exists(kernelPath) Then
			'kernel path not present or wrong path is present in db
			MessageBox.Show("Wolfram Mathematica executable kernel path is missing or wrong" & ControlChars.CrLf & "please set correct path", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

			Dim myfrmParameters As New frmParameters

			myfrmParameters.ShowDialog()
			End
		Else
			'start Mathematica kernel
			Me.myMathWrapper = New MW.MathWrapper(kernelPath)
			If Me.myMathWrapper.KernelReady Then
				result = True
			Else
				Exit Function
			End If
			Try
				Me.ReadValuesFromDB()
			Catch ex As Exception
				MessageBox.Show("Error reading data form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End If

		Return result
	End Function

	Private Sub RedrawGraph(ByVal graph As enumGraph)
		Me.Cursor = Cursors.WaitCursor

		Select Case graph
			Case enumGraph.graph0
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=" & Me.NumberAsString(Me.DE))
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=" & Me.NumberAsString(Me.DU))
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=" & Me.NumberAsString(Me.S1))
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=" & Me.NumberAsString(Me.S2))
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=" & Me.NumberAsString(Me.S3))
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=" & Me.NumberAsString(Me.se13x))
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=" & Me.NumberAsString(Me.se23x))
				If Me.rbuGraph01s.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""S>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""S>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""S>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""S>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xsi + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""S>S&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""S>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xs + (1 - al) RXs) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""S>S&E&I""}]", Me.pboScores)
					End If
				ElseIf Me.rbuGraph01e.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""E>S""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""E>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""E>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""E>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xsi + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""E>S&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""E>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xe + (1 - al) RXe) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""E>S&E&I""}]", Me.pboScores)
					End If
				ElseIf Me.rbuGraph01i.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""I>S""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""I>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""I>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""I>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xsi + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""I>S&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""I>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xi + (1 - al) RXi) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""I>S&E&I""}]", Me.pboScores)
					End If
				ElseIf Me.rbuGraph01se.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>S""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xsi + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>S&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xse + (1 - al) RXse) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E>S&E&I""}]", Me.pboScores)
					End If
				ElseIf Me.rbuGraph01si.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>S""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xsi + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>S&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsi + (1 - al) RXsi) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""S&I>S&E&I""}]", Me.pboScores)
					End If
				ElseIf Me.rbuGraph01ei.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>S""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xsi + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>SI""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xei + (1 - al) RXei) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""E&I>S&E&I""}]", Me.pboScores)
					End If
				ElseIf Me.rbuGraph01sei.Checked Then
					If Me.rbuGraph02s.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xs + (1 - al) RXs), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>S""}]", Me.pboScores)
					ElseIf Me.rbuGraph02e.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xe + (1 - al) RXe), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02i.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xi + (1 - al) RXi), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02se.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xse + (1 - al) RXse), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>S&E""}]", Me.pboScores)
					ElseIf Me.rbuGraph02si.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xsr + (1 - al) RXsi), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>S&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02ei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xei + (1 - al) RXei), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>E&I""}]", Me.pboScores)
					ElseIf Me.rbuGraph02sei.Checked Then
						Me.pboScores.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[(al*Xsei + (1 - al) RXsei) - (al*Xsei + (1 - al) RXsei), {al, 0, 1}, AxesLabel -> {""Z"", ""S&E&I>S&E&I""}]", Me.pboScores)
					End If
				End If
			Case enumGraph.graph1
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=" & Me.NumberAsString(Me.S1))
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=" & Me.NumberAsString(Me.S2))
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=" & Me.NumberAsString(Me.S3))
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=" & Me.NumberAsString(Me.se13x))
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=" & Me.NumberAsString(Me.se23x))
				If Me.rbuGraph11s.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				ElseIf Me.rbuGraph11e.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				ElseIf Me.rbuGraph11i.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				ElseIf Me.rbuGraph11se.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				ElseIf Me.rbuGraph11si.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				ElseIf Me.rbuGraph11ei.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				ElseIf Me.rbuGraph11sei.Checked Then
					If Me.rbuGraph12s.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xs, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12e.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xe, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12i.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12se.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xse, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12si.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xsi, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12ei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					ElseIf Me.rbuGraph12sei.Checked Then
						Me.pboGraph1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xsei, {DE, 0, 1.54}, {DU, 0, 30}, ContourLabels -> Automatic, PlotRange->{0," & Me.NumberAsString(Me.graph1Range) & "}, FrameLabel -> { depth , duration }]", Me.pboGraph1)
					End If
				End If
			Case enumGraph.graph2
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=" & Me.NumberAsString(Me.S1))
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=" & Me.NumberAsString(Me.S2))
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=" & Me.NumberAsString(Me.S3))
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=" & Me.NumberAsString(Me.se13x))
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=" & Me.NumberAsString(Me.se23x))
				'Me.Calculate()
				If Me.rbuGraph21s.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				ElseIf Me.rbuGraph21e.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				ElseIf Me.rbuGraph21i.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				ElseIf Me.rbuGraph21se.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				ElseIf Me.rbuGraph21si.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				ElseIf Me.rbuGraph21ei.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				ElseIf Me.rbuGraph21sei.Checked Then
					If Me.rbuGraph22s.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXs, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22e.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXe, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22i.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22se.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXse, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22si.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXsi, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22ei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					ElseIf Me.rbuGraph22sei.Checked Then
						Me.pboGraph2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXsei, {DE, 0, 1.54}, {DU, 0, 30}, PlotRange->{0," & Me.NumberAsString(Me.graph2Range) & "}, ContourLabels->All, FrameLabel->{depth ,duration}]", Me.pboGraph2)
					End If
				End If
			Case enumGraph.graph3
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=" & Me.NumberAsString(Me.DE))
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=" & Me.NumberAsString(Me.DU))
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1 = 1 - S2 - S3")
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=" & Me.NumberAsString(Me.se13x))
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=" & Me.NumberAsString(Me.se23x))

				If Me.rbuGraph31s.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				ElseIf Me.rbuGraph31e.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				ElseIf Me.rbuGraph31i.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				ElseIf Me.rbuGraph31se.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				ElseIf Me.rbuGraph31si.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				ElseIf Me.rbuGraph31ei.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				ElseIf Me.rbuGraph31sei.Checked Then
					If Me.rbuGraph32s.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32e.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32i.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32se.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32si.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32ei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					ElseIf Me.rbuGraph32sei.Checked Then
						Me.pboGraph3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph3Range) & "}, ContourLabels->All, FrameLabel->{S2, S3}]", Me.pboGraph3)
					End If
				End If
			Case enumGraph.graph4
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=" & Me.NumberAsString(Me.DE))
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=" & Me.NumberAsString(Me.DU))
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1= 1 - S2 - S3")
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=" & Me.NumberAsString(Me.se13x))
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=" & Me.NumberAsString(Me.se23x))
				If Me.rbuGraph41s.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels -> Automatic, FrameLabel -> { S2 , S3 }]", Me.pboGraph4)
					End If
				ElseIf Me.rbuGraph41e.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					End If
				ElseIf Me.rbuGraph41i.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					End If
				ElseIf Me.rbuGraph41se.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					End If
				ElseIf Me.rbuGraph41si.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					End If
				ElseIf Me.rbuGraph41ei.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					End If
				ElseIf Me.rbuGraph41sei.Checked Then
					If Me.rbuGraph42s.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXs, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42e.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXe, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42i.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42se.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXse, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42si.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXsi, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42ei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					ElseIf Me.rbuGraph42sei.Checked Then
						Me.pboGraph4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXsei, {S2, 0, 1}, {S3, 0, 1}, PlotRange->{0, " & Me.NumberAsString(Me.graph4Range) & "}, ContourLabels->All, FrameLabel->{S2,S3}]", Me.pboGraph4)
					End If
				End If
			Case enumGraph.graph5
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=" & Me.NumberAsString(Me.DE))
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=" & Me.NumberAsString(Me.DU))
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=" & Me.NumberAsString(Me.S1))
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=" & Me.NumberAsString(Me.S2))
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=" & Me.NumberAsString(Me.S3))
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=.")
				If Me.rbuGraph51s.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xs - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange -> {0, " & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels -> Automatic, FrameLabel -> {se13, se23}]", Me.pboGraph5)
					End If
				ElseIf Me.rbuGraph51e.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xe - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					End If
				ElseIf Me.rbuGraph51i.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xi - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					End If
				ElseIf Me.rbuGraph51se.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xse - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					End If
				ElseIf Me.rbuGraph51si.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsi - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					End If
				ElseIf Me.rbuGraph51ei.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xei - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					End If
				ElseIf Me.rbuGraph51sei.Checked Then
					If Me.rbuGraph52s.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52e.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52i.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52se.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52si.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52ei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					ElseIf Me.rbuGraph52sei.Checked Then
						Me.pboGraph5.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[Xsei - Xsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph5Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph5)
					End If
				End If
			Case enumGraph.graph6
				Me.myMathWrapper.WaitAndDiscardAnswer("DE=" & Me.NumberAsString(Me.DE))
				Me.myMathWrapper.WaitAndDiscardAnswer("DU=" & Me.NumberAsString(Me.DU))
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("S1=" & Me.NumberAsString(Me.S1))
				Me.myMathWrapper.WaitAndDiscardAnswer("S2=" & Me.NumberAsString(Me.S2))
				Me.myMathWrapper.WaitAndDiscardAnswer("S3=" & Me.NumberAsString(Me.S3))
				Me.myMathWrapper.WaitAndDiscardAnswer("se13x=.")
				Me.myMathWrapper.WaitAndDiscardAnswer("se23x=.")
				If Me.rbuGraph61s.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62e.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXs - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				ElseIf Me.rbuGraph61e.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXe - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				ElseIf Me.rbuGraph61i.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62e.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXi - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				ElseIf Me.rbuGraph61se.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62e.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXse - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				ElseIf Me.rbuGraph61si.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62e.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsi - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				ElseIf Me.rbuGraph61ei.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62e.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXei - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				ElseIf Me.rbuGraph61sei.Checked Then
					If Me.rbuGraph62s.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXs, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62e.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXe, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62i.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62se.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXse, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62si.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXsi, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62ei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					ElseIf Me.rbuGraph62sei.Checked Then
						Me.pboGraph6.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[RXsei - RXsei, {se13x, -1, 1}, {se23x, -1, 1}, PlotRange->{0," & Me.NumberAsString(Me.graph6Range) & "}, ContourLabels->All, FrameLabel->{se13,se23}]", Me.pboGraph6)
					End If
				End If
		End Select

		Me.Cursor = Cursors.Default
	End Sub

	Private Function NullToDouble(ByVal var As Object) As Double
		Dim ret As Double

		If var Is Nothing OrElse IsDBNull(var) Then
			ret = 0
		Else
			ret = CType(var, Double)
		End If

		Return ret
	End Function

#End Region

#Region " Event management "

	Private Sub frmNegotiation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		'close Mathematica kernel
		Me.myMathWrapper.KernelStop()
	End Sub

	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		Me.NextStep()
	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
		If Me.groupBoxesID = 0 Then
			Me.Reset()
		Else
			Me.PreviousStep()
		End If
	End Sub

	Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
		Dim frmScenario As New frmScenarioSelection

		If frmScenario.ShowDialog() = Windows.Forms.DialogResult.OK Then
			Me.ReadValuesFromDB(frmScenario.ScenarioID)
		End If

		'If MessageBox.Show("Do you want to load last session stored in DB?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
		'	Me.ReadValuesFromDB()
		'End If
	End Sub

	Private Sub grbWeigth_DSSTInit() Handles grbWeigth.DSSTInit
		'calculate and show worst case
		Me.lblW11.Text = (Math.Round((Me.nudV1.Value * Me.nudA1.Value * Me.nudB1.Value + _
		Me.nudV2.Value * Me.nudA2.Value * Me.nudB2.Value + Me.nudV3.Value * Me.nudA3.Value * Me.nudB3.Value + _
		Me.nudV4.Value * Me.nudA4.Value * Me.nudB4.Value + Me.nudV5.Value * Me.nudA5.Value * Me.nudB5.Value + _
		Me.nudV6.Value * Me.nudA6.Value * Me.nudB6.Value + Me.nudV7.Value * Me.nudA7.Value * Me.nudB7.Value + _
		Me.nudV8.Value * Me.nudA8.Value * Me.nudB8.Value) * 30 * Math.Sqrt(1.5), 0)).ToString
	End Sub

	Private Sub btnRedraw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw1.Click
		Me.RedrawGraph(enumGraph.graph1)
	End Sub

	Private Sub btnRedraw2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw2.Click
		Me.RedrawGraph(enumGraph.graph2)
	End Sub

	Private Sub btnRedraw3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw3.Click
		Me.RedrawGraph(enumGraph.graph3)
	End Sub

	Private Sub btnRedraw4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw4.Click
		Me.RedrawGraph(enumGraph.graph4)
	End Sub

	Private Sub btnRedraw5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw5.Click
		Me.RedrawGraph(enumGraph.graph5)
	End Sub

	Private Sub btnRedraw6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw6.Click
		Me.RedrawGraph(enumGraph.graph6)
	End Sub

	Private Sub btnRedraw0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedraw0.Click
		Me.RedrawGraph(enumGraph.graph0)
	End Sub

	Private Sub btnMinus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus1.Click
		Me.graph1Range /= 2
		Me.RedrawGraph(enumGraph.graph1)
	End Sub

	Private Sub btnPlus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus1.Click
		Me.graph1Range *= 2
		Me.RedrawGraph(enumGraph.graph1)
	End Sub

	Private Sub btnMinus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus2.Click
		Me.graph2Range /= 2
		Me.RedrawGraph(enumGraph.graph2)
	End Sub

	Private Sub btnPlus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus2.Click
		Me.graph2Range *= 2
		Me.RedrawGraph(enumGraph.graph2)
	End Sub

	Private Sub btnMinus3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus3.Click
		Me.graph3Range /= 2
		Me.RedrawGraph(enumGraph.graph3)
	End Sub

	Private Sub btnPlus3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus3.Click
		Me.graph3Range *= 2
		Me.RedrawGraph(enumGraph.graph3)
	End Sub

	Private Sub btnMinus4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus4.Click
		Me.graph4Range /= 2
		Me.RedrawGraph(enumGraph.graph4)
	End Sub

	Private Sub btnPlus4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus4.Click
		Me.graph4Range *= 2
		Me.RedrawGraph(enumGraph.graph4)
	End Sub

	Private Sub btnMinus5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus5.Click
		Me.graph5Range /= 2
		Me.RedrawGraph(enumGraph.graph5)
	End Sub

	Private Sub btnPlus5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus5.Click
		Me.graph5Range *= 2
		Me.RedrawGraph(enumGraph.graph5)
	End Sub

	Private Sub btnMinus6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus6.Click
		Me.graph6Range /= 2
		Me.RedrawGraph(enumGraph.graph6)
	End Sub

	Private Sub btnPlus6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus6.Click
		Me.graph6Range *= 2
		Me.RedrawGraph(enumGraph.graph6)
	End Sub

#End Region

End Class