<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNegotiation
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNegotiation))
		Me.daData = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnPrev = New System.Windows.Forms.Button()
		Me.btnLoadData = New System.Windows.Forms.Button()
		Me.dsParameters = New DSS.parameters()
		Me.TAParameters = New DSS.parametersTableAdapters.parametersTableAdapter()
		Me.DSData = New DSS.DSData()
		Me.grbSummary = New DSS.DSSTGroupBox()
		Me.tcoSummary = New System.Windows.Forms.TabControl()
		Me.tpaExposure = New System.Windows.Forms.TabPage()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label90 = New System.Windows.Forms.Label()
		Me.Label91 = New System.Windows.Forms.Label()
		Me.Label92 = New System.Windows.Forms.Label()
		Me.Label93 = New System.Windows.Forms.Label()
		Me.lblF23sei = New System.Windows.Forms.Label()
		Me.lblF23ei = New System.Windows.Forms.Label()
		Me.lblF23si = New System.Windows.Forms.Label()
		Me.lblF23se = New System.Windows.Forms.Label()
		Me.lblF23i = New System.Windows.Forms.Label()
		Me.lblF23e = New System.Windows.Forms.Label()
		Me.lblF23s = New System.Windows.Forms.Label()
		Me.lblF23 = New System.Windows.Forms.Label()
		Me.lblF13sei = New System.Windows.Forms.Label()
		Me.lblF13ei = New System.Windows.Forms.Label()
		Me.lblF13si = New System.Windows.Forms.Label()
		Me.lblF13se = New System.Windows.Forms.Label()
		Me.lblF13i = New System.Windows.Forms.Label()
		Me.lblF13e = New System.Windows.Forms.Label()
		Me.lblF13s = New System.Windows.Forms.Label()
		Me.lblF13 = New System.Windows.Forms.Label()
		Me.lblF22sei = New System.Windows.Forms.Label()
		Me.lblF22ei = New System.Windows.Forms.Label()
		Me.lblF22si = New System.Windows.Forms.Label()
		Me.lblF22se = New System.Windows.Forms.Label()
		Me.lblF22i = New System.Windows.Forms.Label()
		Me.lblF22e = New System.Windows.Forms.Label()
		Me.lblF22s = New System.Windows.Forms.Label()
		Me.lblF22 = New System.Windows.Forms.Label()
		Me.lblF12sei = New System.Windows.Forms.Label()
		Me.lblF12ei = New System.Windows.Forms.Label()
		Me.lblF12si = New System.Windows.Forms.Label()
		Me.lblF12se = New System.Windows.Forms.Label()
		Me.lblF12i = New System.Windows.Forms.Label()
		Me.lblF12e = New System.Windows.Forms.Label()
		Me.lblF12s = New System.Windows.Forms.Label()
		Me.lblF12 = New System.Windows.Forms.Label()
		Me.lblF31sei = New System.Windows.Forms.Label()
		Me.lblF31ei = New System.Windows.Forms.Label()
		Me.lblF31si = New System.Windows.Forms.Label()
		Me.lblF31se = New System.Windows.Forms.Label()
		Me.lblF31i = New System.Windows.Forms.Label()
		Me.lblF31e = New System.Windows.Forms.Label()
		Me.lblF31s = New System.Windows.Forms.Label()
		Me.lblF31 = New System.Windows.Forms.Label()
		Me.lblF21sei = New System.Windows.Forms.Label()
		Me.lblF21ei = New System.Windows.Forms.Label()
		Me.lblF21si = New System.Windows.Forms.Label()
		Me.lblF21se = New System.Windows.Forms.Label()
		Me.lblF21i = New System.Windows.Forms.Label()
		Me.lblF21e = New System.Windows.Forms.Label()
		Me.lblF21s = New System.Windows.Forms.Label()
		Me.lblF21 = New System.Windows.Forms.Label()
		Me.lblF11sei = New System.Windows.Forms.Label()
		Me.lblF11ei = New System.Windows.Forms.Label()
		Me.lblF11si = New System.Windows.Forms.Label()
		Me.lblF11se = New System.Windows.Forms.Label()
		Me.lblF11i = New System.Windows.Forms.Label()
		Me.lblF11e = New System.Windows.Forms.Label()
		Me.lblF11s = New System.Windows.Forms.Label()
		Me.lblF11 = New System.Windows.Forms.Label()
		Me.Label102 = New System.Windows.Forms.Label()
		Me.Label106 = New System.Windows.Forms.Label()
		Me.Label105 = New System.Windows.Forms.Label()
		Me.Label109 = New System.Windows.Forms.Label()
		Me.Label108 = New System.Windows.Forms.Label()
		Me.Label107 = New System.Windows.Forms.Label()
		Me.Label104 = New System.Windows.Forms.Label()
		Me.Label103 = New System.Windows.Forms.Label()
		Me.Label95 = New System.Windows.Forms.Label()
		Me.Label96 = New System.Windows.Forms.Label()
		Me.Label97 = New System.Windows.Forms.Label()
		Me.Label98 = New System.Windows.Forms.Label()
		Me.Label99 = New System.Windows.Forms.Label()
		Me.Label100 = New System.Windows.Forms.Label()
		Me.Label101 = New System.Windows.Forms.Label()
		Me.tpaResilience = New System.Windows.Forms.TabPage()
		Me.Label110 = New System.Windows.Forms.Label()
		Me.Label111 = New System.Windows.Forms.Label()
		Me.Label112 = New System.Windows.Forms.Label()
		Me.Label113 = New System.Windows.Forms.Label()
		Me.Label114 = New System.Windows.Forms.Label()
		Me.Label115 = New System.Windows.Forms.Label()
		Me.Label116 = New System.Windows.Forms.Label()
		Me.lblR23sei = New System.Windows.Forms.Label()
		Me.lblR23ei = New System.Windows.Forms.Label()
		Me.lblR23si = New System.Windows.Forms.Label()
		Me.lblR23se = New System.Windows.Forms.Label()
		Me.lblR23i = New System.Windows.Forms.Label()
		Me.lblR23e = New System.Windows.Forms.Label()
		Me.lblR23s = New System.Windows.Forms.Label()
		Me.lblR23 = New System.Windows.Forms.Label()
		Me.lblR13sei = New System.Windows.Forms.Label()
		Me.lblR13ei = New System.Windows.Forms.Label()
		Me.lblR13si = New System.Windows.Forms.Label()
		Me.lblR13se = New System.Windows.Forms.Label()
		Me.lblR13i = New System.Windows.Forms.Label()
		Me.lblR13e = New System.Windows.Forms.Label()
		Me.lblR13s = New System.Windows.Forms.Label()
		Me.lblR13 = New System.Windows.Forms.Label()
		Me.lblR22sei = New System.Windows.Forms.Label()
		Me.lblR22ei = New System.Windows.Forms.Label()
		Me.lblR22si = New System.Windows.Forms.Label()
		Me.lblR22se = New System.Windows.Forms.Label()
		Me.lblR22i = New System.Windows.Forms.Label()
		Me.lblR22e = New System.Windows.Forms.Label()
		Me.lblR22s = New System.Windows.Forms.Label()
		Me.lblR22 = New System.Windows.Forms.Label()
		Me.lblR12sei = New System.Windows.Forms.Label()
		Me.lblR12ei = New System.Windows.Forms.Label()
		Me.lblR12si = New System.Windows.Forms.Label()
		Me.lblR12se = New System.Windows.Forms.Label()
		Me.lblR12i = New System.Windows.Forms.Label()
		Me.lblR12e = New System.Windows.Forms.Label()
		Me.lblR12s = New System.Windows.Forms.Label()
		Me.lblR12 = New System.Windows.Forms.Label()
		Me.lblR31sei = New System.Windows.Forms.Label()
		Me.lblR31ei = New System.Windows.Forms.Label()
		Me.lblR31si = New System.Windows.Forms.Label()
		Me.lblR31se = New System.Windows.Forms.Label()
		Me.lblR31i = New System.Windows.Forms.Label()
		Me.lblR31e = New System.Windows.Forms.Label()
		Me.lblR31s = New System.Windows.Forms.Label()
		Me.lblR31 = New System.Windows.Forms.Label()
		Me.lblR21sei = New System.Windows.Forms.Label()
		Me.lblR21ei = New System.Windows.Forms.Label()
		Me.lblR21si = New System.Windows.Forms.Label()
		Me.lblR21se = New System.Windows.Forms.Label()
		Me.lblR21i = New System.Windows.Forms.Label()
		Me.lblR21e = New System.Windows.Forms.Label()
		Me.lblR21s = New System.Windows.Forms.Label()
		Me.lblR21 = New System.Windows.Forms.Label()
		Me.lblR11sei = New System.Windows.Forms.Label()
		Me.lblR11ei = New System.Windows.Forms.Label()
		Me.lblR11si = New System.Windows.Forms.Label()
		Me.lblR11se = New System.Windows.Forms.Label()
		Me.lblR11i = New System.Windows.Forms.Label()
		Me.lblR11e = New System.Windows.Forms.Label()
		Me.lblR11s = New System.Windows.Forms.Label()
		Me.lblR11 = New System.Windows.Forms.Label()
		Me.Label176 = New System.Windows.Forms.Label()
		Me.Label177 = New System.Windows.Forms.Label()
		Me.Label178 = New System.Windows.Forms.Label()
		Me.Label179 = New System.Windows.Forms.Label()
		Me.Label180 = New System.Windows.Forms.Label()
		Me.Label181 = New System.Windows.Forms.Label()
		Me.Label182 = New System.Windows.Forms.Label()
		Me.Label183 = New System.Windows.Forms.Label()
		Me.Label185 = New System.Windows.Forms.Label()
		Me.Label186 = New System.Windows.Forms.Label()
		Me.Label187 = New System.Windows.Forms.Label()
		Me.Label188 = New System.Windows.Forms.Label()
		Me.Label189 = New System.Windows.Forms.Label()
		Me.Label190 = New System.Windows.Forms.Label()
		Me.Label191 = New System.Windows.Forms.Label()
		Me.tpaScores = New System.Windows.Forms.TabPage()
		Me.lblScoreResilienceValue7 = New System.Windows.Forms.Label()
		Me.lblScoreResilience7 = New System.Windows.Forms.Label()
		Me.lblScoreResilience5 = New System.Windows.Forms.Label()
		Me.lblScoreResilienceValue6 = New System.Windows.Forms.Label()
		Me.lblScoreResilienceValue4 = New System.Windows.Forms.Label()
		Me.lblScoreResilience6 = New System.Windows.Forms.Label()
		Me.lblScoreResilience4 = New System.Windows.Forms.Label()
		Me.lblScoreResilienceValue5 = New System.Windows.Forms.Label()
		Me.lblScoreResilienceValue3 = New System.Windows.Forms.Label()
		Me.lblScoreResilience3 = New System.Windows.Forms.Label()
		Me.lblScoreResilienceValue2 = New System.Windows.Forms.Label()
		Me.lblScoreResilience2 = New System.Windows.Forms.Label()
		Me.lblScoreResilienceValue1 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue7 = New System.Windows.Forms.Label()
		Me.lblScoreExposure7 = New System.Windows.Forms.Label()
		Me.lblScoreExposure5 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue6 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue4 = New System.Windows.Forms.Label()
		Me.lblScoreExposure6 = New System.Windows.Forms.Label()
		Me.lblScoreExposure4 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue5 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue3 = New System.Windows.Forms.Label()
		Me.lblScoreExposure3 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue2 = New System.Windows.Forms.Label()
		Me.lblScoreExposure2 = New System.Windows.Forms.Label()
		Me.lblScoreExposureValue1 = New System.Windows.Forms.Label()
		Me.lblScoreResilience1 = New System.Windows.Forms.Label()
		Me.lblScoreExposure1 = New System.Windows.Forms.Label()
		Me.Label138 = New System.Windows.Forms.Label()
		Me.Label139 = New System.Windows.Forms.Label()
		Me.tpaGraph0 = New System.Windows.Forms.TabPage()
		Me.btnRedraw0 = New System.Windows.Forms.Button()
		Me.GroupBox13 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph01e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph01i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph01sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph01ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph01si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph01se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph01s = New System.Windows.Forms.RadioButton()
		Me.GroupBox14 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph02e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph02i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph02sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph02ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph02si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph02se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph02s = New System.Windows.Forms.RadioButton()
		Me.pboScores = New System.Windows.Forms.PictureBox()
		Me.tpaGraph1 = New System.Windows.Forms.TabPage()
		Me.btnPlus1 = New System.Windows.Forms.Button()
		Me.btnMinus1 = New System.Windows.Forms.Button()
		Me.btnRedraw1 = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph11e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph11i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph11sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph11ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph11si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph11se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph11s = New System.Windows.Forms.RadioButton()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph12e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph12i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph12sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph12ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph12si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph12se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph12s = New System.Windows.Forms.RadioButton()
		Me.pboGraph1 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph2 = New System.Windows.Forms.TabPage()
		Me.btnPlus2 = New System.Windows.Forms.Button()
		Me.btnMinus2 = New System.Windows.Forms.Button()
		Me.btnRedraw2 = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph21e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph21i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph21sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph21ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph21si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph21se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph21s = New System.Windows.Forms.RadioButton()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph22e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph22i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph22sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph22ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph22si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph22se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph22s = New System.Windows.Forms.RadioButton()
		Me.pboGraph2 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph3 = New System.Windows.Forms.TabPage()
		Me.btnPlus3 = New System.Windows.Forms.Button()
		Me.btnMinus3 = New System.Windows.Forms.Button()
		Me.btnRedraw3 = New System.Windows.Forms.Button()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph31e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph31i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph31sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph31ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph31si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph31se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph31s = New System.Windows.Forms.RadioButton()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph32e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph32i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph32sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph32ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph32si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph32se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph32s = New System.Windows.Forms.RadioButton()
		Me.pboGraph3 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph4 = New System.Windows.Forms.TabPage()
		Me.btnPlus4 = New System.Windows.Forms.Button()
		Me.btnMinus4 = New System.Windows.Forms.Button()
		Me.btnRedraw4 = New System.Windows.Forms.Button()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph41e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph41i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph41sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph41ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph41si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph41se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph41s = New System.Windows.Forms.RadioButton()
		Me.GroupBox8 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph42e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph42i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph42sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph42ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph42si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph42se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph42s = New System.Windows.Forms.RadioButton()
		Me.pboGraph4 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph5 = New System.Windows.Forms.TabPage()
		Me.btnPlus5 = New System.Windows.Forms.Button()
		Me.btnMinus5 = New System.Windows.Forms.Button()
		Me.btnRedraw5 = New System.Windows.Forms.Button()
		Me.GroupBox9 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph51e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph51i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph51sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph51ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph51si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph51se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph51s = New System.Windows.Forms.RadioButton()
		Me.GroupBox10 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph52e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph52i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph52sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph52ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph52si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph52se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph52s = New System.Windows.Forms.RadioButton()
		Me.pboGraph5 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph6 = New System.Windows.Forms.TabPage()
		Me.btnPlus6 = New System.Windows.Forms.Button()
		Me.btnMinus6 = New System.Windows.Forms.Button()
		Me.btnRedraw6 = New System.Windows.Forms.Button()
		Me.GroupBox11 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph61e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph61i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph61sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph61ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph61si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph61se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph61s = New System.Windows.Forms.RadioButton()
		Me.GroupBox12 = New System.Windows.Forms.GroupBox()
		Me.rbuGraph62e = New System.Windows.Forms.RadioButton()
		Me.rbuGraph62i = New System.Windows.Forms.RadioButton()
		Me.rbuGraph62sei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph62ei = New System.Windows.Forms.RadioButton()
		Me.rbuGraph62si = New System.Windows.Forms.RadioButton()
		Me.rbuGraph62se = New System.Windows.Forms.RadioButton()
		Me.rbuGraph62s = New System.Windows.Forms.RadioButton()
		Me.pboGraph6 = New System.Windows.Forms.PictureBox()
		Me.grbWeigth = New DSS.DSSTGroupBox()
		Me.cboW23 = New System.Windows.Forms.ComboBox()
		Me.cboB23 = New System.Windows.Forms.ComboBox()
		Me.cboW22 = New System.Windows.Forms.ComboBox()
		Me.cboB22 = New System.Windows.Forms.ComboBox()
		Me.cboW13 = New System.Windows.Forms.ComboBox()
		Me.cboB13 = New System.Windows.Forms.ComboBox()
		Me.cboW31 = New System.Windows.Forms.ComboBox()
		Me.cboB31 = New System.Windows.Forms.ComboBox()
		Me.cboW21 = New System.Windows.Forms.ComboBox()
		Me.cboB21 = New System.Windows.Forms.ComboBox()
		Me.lblB11 = New System.Windows.Forms.Label()
		Me.lblmop2 = New System.Windows.Forms.Label()
		Me.lblW11 = New System.Windows.Forms.Label()
		Me.lblmop1 = New System.Windows.Forms.Label()
		Me.nudFR = New System.Windows.Forms.NumericUpDown()
		Me.nudDE = New System.Windows.Forms.NumericUpDown()
		Me.nudDU = New System.Windows.Forms.NumericUpDown()
		Me.nudY = New System.Windows.Forms.NumericUpDown()
		Me.nudS1 = New System.Windows.Forms.NumericUpDown()
		Me.nudS2 = New System.Windows.Forms.NumericUpDown()
		Me.nudS3 = New System.Windows.Forms.NumericUpDown()
		Me.nudE23 = New System.Windows.Forms.NumericUpDown()
		Me.nudE22 = New System.Windows.Forms.NumericUpDown()
		Me.nudE31 = New System.Windows.Forms.NumericUpDown()
		Me.nudE13 = New System.Windows.Forms.NumericUpDown()
		Me.nudB12 = New System.Windows.Forms.NumericUpDown()
		Me.nudW12 = New System.Windows.Forms.NumericUpDown()
		Me.nudE12 = New System.Windows.Forms.NumericUpDown()
		Me.nudE21 = New System.Windows.Forms.NumericUpDown()
		Me.nudE11 = New System.Windows.Forms.NumericUpDown()
		Me.lblfef1 = New System.Windows.Forms.Label()
		Me.Label49 = New System.Windows.Forms.Label()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.lblUnit1 = New System.Windows.Forms.Label()
		Me.lblNoMitigation = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.lblUnit = New System.Windows.Forms.Label()
		Me.lblRelativeDistance = New System.Windows.Forms.Label()
		Me.lblFR = New System.Windows.Forms.Label()
		Me.lblFloodDuration = New System.Windows.Forms.Label()
		Me.lblFloodDepth = New System.Windows.Forms.Label()
		Me.grbInterdependencies = New DSS.DSSTGroupBox()
		Me.nudE11r = New System.Windows.Forms.NumericUpDown()
		Me.nudI11x = New System.Windows.Forms.NumericUpDown()
		Me.nudCOse = New System.Windows.Forms.NumericUpDown()
		Me.nudCOs = New System.Windows.Forms.NumericUpDown()
		Me.Label82 = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.Label81 = New System.Windows.Forms.Label()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label80 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label79 = New System.Windows.Forms.Label()
		Me.nudse23x = New System.Windows.Forms.NumericUpDown()
		Me.nudse13x = New System.Windows.Forms.NumericUpDown()
		Me.nudCOsi = New System.Windows.Forms.NumericUpDown()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label87 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label85 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.Label84 = New System.Windows.Forms.Label()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.Label83 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.nudCOsei = New System.Windows.Forms.NumericUpDown()
		Me.nudCOei = New System.Windows.Forms.NumericUpDown()
		Me.nudCOe = New System.Windows.Forms.NumericUpDown()
		Me.nudCOi = New System.Windows.Forms.NumericUpDown()
		Me.grbEngineers = New DSS.DSSTGroupBox()
		Me.nudC = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblStotwat = New System.Windows.Forms.Label()
		Me.nudD = New System.Windows.Forms.NumericUpDown()
		Me.grbSociologists = New DSS.DSSTGroupBox()
		Me.cboRTsclsocQ = New System.Windows.Forms.ComboBox()
		Me.cboRTsclheaQ = New System.Windows.Forms.ComboBox()
		Me.nudRTsclsoc = New System.Windows.Forms.NumericUpDown()
		Me.nudRTsclhea = New System.Windows.Forms.NumericUpDown()
		Me.Label78 = New System.Windows.Forms.Label()
		Me.Label117 = New System.Windows.Forms.Label()
		Me.Label118 = New System.Windows.Forms.Label()
		Me.Label119 = New System.Windows.Forms.Label()
		Me.nudT = New System.Windows.Forms.NumericUpDown()
		Me.nudP = New System.Windows.Forms.NumericUpDown()
		Me.nudTsclsoc1 = New System.Windows.Forms.NumericUpDown()
		Me.nudTsclsoc4 = New System.Windows.Forms.NumericUpDown()
		Me.Label61 = New System.Windows.Forms.Label()
		Me.nudTsclhea1 = New System.Windows.Forms.NumericUpDown()
		Me.Label60 = New System.Windows.Forms.Label()
		Me.nudTsclhea4 = New System.Windows.Forms.NumericUpDown()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.nudTsclsoc2 = New System.Windows.Forms.NumericUpDown()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.nudTsclhea2 = New System.Windows.Forms.NumericUpDown()
		Me.nudTsclsoc3 = New System.Windows.Forms.NumericUpDown()
		Me.nudTsclhea3 = New System.Windows.Forms.NumericUpDown()
		Me.grbEconomists = New DSS.DSSTGroupBox()
		Me.cboRTecnlanQ = New System.Windows.Forms.ComboBox()
		Me.cboRTecnuneQ = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.nudB7 = New System.Windows.Forms.NumericUpDown()
		Me.nudA7 = New System.Windows.Forms.NumericUpDown()
		Me.nudV7 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnlan2 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnune2 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnlan1 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnlan4 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnune1 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnune4 = New System.Windows.Forms.NumericUpDown()
		Me.nudB8 = New System.Windows.Forms.NumericUpDown()
		Me.nudA8 = New System.Windows.Forms.NumericUpDown()
		Me.nudV8 = New System.Windows.Forms.NumericUpDown()
		Me.nudB4 = New System.Windows.Forms.NumericUpDown()
		Me.nudA4 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnlan3 = New System.Windows.Forms.NumericUpDown()
		Me.nudV4 = New System.Windows.Forms.NumericUpDown()
		Me.nudTecnune3 = New System.Windows.Forms.NumericUpDown()
		Me.nudRTecnlan = New System.Windows.Forms.NumericUpDown()
		Me.nudRTecnune = New System.Windows.Forms.NumericUpDown()
		Me.nudB5 = New System.Windows.Forms.NumericUpDown()
		Me.nudA5 = New System.Windows.Forms.NumericUpDown()
		Me.nudV5 = New System.Windows.Forms.NumericUpDown()
		Me.nudm = New System.Windows.Forms.NumericUpDown()
		Me.nudzz = New System.Windows.Forms.NumericUpDown()
		Me.nudz = New System.Windows.Forms.NumericUpDown()
		Me.nudB1 = New System.Windows.Forms.NumericUpDown()
		Me.nudB6 = New System.Windows.Forms.NumericUpDown()
		Me.nudA1 = New System.Windows.Forms.NumericUpDown()
		Me.nudA6 = New System.Windows.Forms.NumericUpDown()
		Me.nudB2 = New System.Windows.Forms.NumericUpDown()
		Me.nudV1 = New System.Windows.Forms.NumericUpDown()
		Me.nudA2 = New System.Windows.Forms.NumericUpDown()
		Me.nudB3 = New System.Windows.Forms.NumericUpDown()
		Me.nudV6 = New System.Windows.Forms.NumericUpDown()
		Me.nudA3 = New System.Windows.Forms.NumericUpDown()
		Me.nudV2 = New System.Windows.Forms.NumericUpDown()
		Me.Label69 = New System.Windows.Forms.Label()
		Me.nudV3 = New System.Windows.Forms.NumericUpDown()
		Me.Label68 = New System.Windows.Forms.Label()
		Me.Label67 = New System.Windows.Forms.Label()
		Me.Label66 = New System.Windows.Forms.Label()
		Me.Label63 = New System.Windows.Forms.Label()
		Me.Label55 = New System.Windows.Forms.Label()
		Me.Label62 = New System.Windows.Forms.Label()
		Me.Label54 = New System.Windows.Forms.Label()
		Me.Label130 = New System.Windows.Forms.Label()
		Me.Label128 = New System.Windows.Forms.Label()
		Me.Label51 = New System.Windows.Forms.Label()
		Me.Label57 = New System.Windows.Forms.Label()
		Me.Label53 = New System.Windows.Forms.Label()
		Me.Label50 = New System.Windows.Forms.Label()
		Me.Label56 = New System.Windows.Forms.Label()
		Me.Label52 = New System.Windows.Forms.Label()
		Me.Label47 = New System.Windows.Forms.Label()
		Me.Label122 = New System.Windows.Forms.Label()
		Me.Label121 = New System.Windows.Forms.Label()
		Me.Label120 = New System.Windows.Forms.Label()
		Me.grbEcologists = New DSS.DSSTGroupBox()
		Me.cboRTeclhabQ = New System.Windows.Forms.ComboBox()
		Me.cboRTeclspeQ = New System.Windows.Forms.ComboBox()
		Me.nudRTeclhab = New System.Windows.Forms.NumericUpDown()
		Me.nudRTeclspe = New System.Windows.Forms.NumericUpDown()
		Me.Label73 = New System.Windows.Forms.Label()
		Me.Label74 = New System.Windows.Forms.Label()
		Me.Label75 = New System.Windows.Forms.Label()
		Me.Label76 = New System.Windows.Forms.Label()
		Me.nudTeclspe4 = New System.Windows.Forms.NumericUpDown()
		Me.nudTeclspe1 = New System.Windows.Forms.NumericUpDown()
		Me.nudTeclhab1du = New System.Windows.Forms.NumericUpDown()
		Me.nudTeclhab4du = New System.Windows.Forms.NumericUpDown()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.nudTeclhab2du = New System.Windows.Forms.NumericUpDown()
		Me.Label42 = New System.Windows.Forms.Label()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.Label43 = New System.Windows.Forms.Label()
		Me.Label40 = New System.Windows.Forms.Label()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.lblTa = New System.Windows.Forms.Label()
		Me.nudTeclhab3du = New System.Windows.Forms.NumericUpDown()
		Me.nudTeclspe2 = New System.Windows.Forms.NumericUpDown()
		Me.nudTeclspe3 = New System.Windows.Forms.NumericUpDown()
		CType(Me.dsParameters, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbSummary.SuspendLayout()
		Me.tcoSummary.SuspendLayout()
		Me.tpaExposure.SuspendLayout()
		Me.tpaResilience.SuspendLayout()
		Me.tpaScores.SuspendLayout()
		Me.tpaGraph0.SuspendLayout()
		Me.GroupBox13.SuspendLayout()
		Me.GroupBox14.SuspendLayout()
		CType(Me.pboScores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.pboGraph1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.pboGraph2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph3.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		CType(Me.pboGraph3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph4.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		Me.GroupBox8.SuspendLayout()
		CType(Me.pboGraph4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph5.SuspendLayout()
		Me.GroupBox9.SuspendLayout()
		Me.GroupBox10.SuspendLayout()
		CType(Me.pboGraph5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph6.SuspendLayout()
		Me.GroupBox11.SuspendLayout()
		Me.GroupBox12.SuspendLayout()
		CType(Me.pboGraph6, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbWeigth.SuspendLayout()
		CType(Me.nudFR, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDU, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudS1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudS2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudS3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE31, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudW12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudE11, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbInterdependencies.SuspendLayout()
		CType(Me.nudE11r, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudI11x, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOse, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOs, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudse23x, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudse13x, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOsi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOsei, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOei, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOe, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCOi, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbEngineers.SuspendLayout()
		CType(Me.nudC, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudD, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbSociologists.SuspendLayout()
		CType(Me.nudRTsclsoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRTsclhea, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclsoc1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclsoc4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclhea1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclhea4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclsoc2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclhea2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclsoc3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsclhea3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbEconomists.SuspendLayout()
		CType(Me.nudB7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnlan2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnune2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnlan1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnlan4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnune1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnune4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnlan3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTecnune3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRTecnlan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRTecnune, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudm, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudzz, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudz, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudB3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudA3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudV3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbEcologists.SuspendLayout()
		CType(Me.nudRTeclhab, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRTeclspe, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclspe4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclspe1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclhab1du, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclhab4du, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclhab2du, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclhab3du, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclspe2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeclspe3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'daData
		'
		Me.daData.DeleteCommand = Me.SqlDeleteCommand
		Me.daData.InsertCommand = Me.SqlInsertCommand
		Me.daData.SelectCommand = Me.SqlSelectCommand
		Me.daData.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "data", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("datID", "datID"), New System.Data.Common.DataColumnMapping("datDE", "datDE"), New System.Data.Common.DataColumnMapping("datDU", "datDU"), New System.Data.Common.DataColumnMapping("datFR", "datFR"), New System.Data.Common.DataColumnMapping("datY", "datY"), New System.Data.Common.DataColumnMapping("datS1", "datS1"), New System.Data.Common.DataColumnMapping("datS2", "datS2"), New System.Data.Common.DataColumnMapping("datS3", "datS3"), New System.Data.Common.DataColumnMapping("datE11", "datE11"), New System.Data.Common.DataColumnMapping("datE11r", "datE11r"), New System.Data.Common.DataColumnMapping("datE21", "datE21"), New System.Data.Common.DataColumnMapping("datE31", "datE31"), New System.Data.Common.DataColumnMapping("datE12", "datE12"), New System.Data.Common.DataColumnMapping("datE22", "datE22"), New System.Data.Common.DataColumnMapping("datE13", "datE13"), New System.Data.Common.DataColumnMapping("datE23", "datE23"), New System.Data.Common.DataColumnMapping("datW11", "datW11"), New System.Data.Common.DataColumnMapping("datW21", "datW21"), New System.Data.Common.DataColumnMapping("datW31", "datW31"), New System.Data.Common.DataColumnMapping("datW12", "datW12"), New System.Data.Common.DataColumnMapping("datW22", "datW22"), New System.Data.Common.DataColumnMapping("datW13", "datW13"), New System.Data.Common.DataColumnMapping("datW23", "datW23"), New System.Data.Common.DataColumnMapping("datB11", "datB11"), New System.Data.Common.DataColumnMapping("datB21", "datB21"), New System.Data.Common.DataColumnMapping("datB31", "datB31"), New System.Data.Common.DataColumnMapping("datB12", "datB12"), New System.Data.Common.DataColumnMapping("datB22", "datB22"), New System.Data.Common.DataColumnMapping("datB13", "datB13"), New System.Data.Common.DataColumnMapping("datB23", "datB23"), New System.Data.Common.DataColumnMapping("datV1", "datV1"), New System.Data.Common.DataColumnMapping("datV2", "datV2"), New System.Data.Common.DataColumnMapping("datV3", "datV3"), New System.Data.Common.DataColumnMapping("datV4", "datV4"), New System.Data.Common.DataColumnMapping("datV5", "datV5"), New System.Data.Common.DataColumnMapping("datV6", "datV6"), New System.Data.Common.DataColumnMapping("datV7", "datV7"), New System.Data.Common.DataColumnMapping("datV8", "datV8"), New System.Data.Common.DataColumnMapping("datA1", "datA1"), New System.Data.Common.DataColumnMapping("datA2", "datA2"), New System.Data.Common.DataColumnMapping("datA3", "datA3"), New System.Data.Common.DataColumnMapping("datA4", "datA4"), New System.Data.Common.DataColumnMapping("datA5", "datA5"), New System.Data.Common.DataColumnMapping("datA6", "datA6"), New System.Data.Common.DataColumnMapping("datA7", "datA7"), New System.Data.Common.DataColumnMapping("datA8", "datA8"), New System.Data.Common.DataColumnMapping("datB1", "datB1"), New System.Data.Common.DataColumnMapping("datB2", "datB2"), New System.Data.Common.DataColumnMapping("datB3", "datB3"), New System.Data.Common.DataColumnMapping("datB4", "datB4"), New System.Data.Common.DataColumnMapping("datB5", "datB5"), New System.Data.Common.DataColumnMapping("datB6", "datB6"), New System.Data.Common.DataColumnMapping("datB7", "datB7"), New System.Data.Common.DataColumnMapping("datB8", "datB8"), New System.Data.Common.DataColumnMapping("datZ", "datZ"), New System.Data.Common.DataColumnMapping("datZZ", "datZZ"), New System.Data.Common.DataColumnMapping("datM", "datM"), New System.Data.Common.DataColumnMapping("datTecnune1", "datTecnune1"), New System.Data.Common.DataColumnMapping("datTecnune2", "datTecnune2"), New System.Data.Common.DataColumnMapping("datTecnune3", "datTecnune3"), New System.Data.Common.DataColumnMapping("datTecnune4", "datTecnune4"), New System.Data.Common.DataColumnMapping("datC", "datC"), New System.Data.Common.DataColumnMapping("datD", "datD"), New System.Data.Common.DataColumnMapping("dati11", "dati11"), New System.Data.Common.DataColumnMapping("dati11x", "dati11x"), New System.Data.Common.DataColumnMapping("datTeclspe1", "datTeclspe1"), New System.Data.Common.DataColumnMapping("datTeclspe2", "datTeclspe2"), New System.Data.Common.DataColumnMapping("datTeclspe3", "datTeclspe3"), New System.Data.Common.DataColumnMapping("datTeclspe4", "datTeclspe4"), New System.Data.Common.DataColumnMapping("datTeclhab1de", "datTeclhab1de"), New System.Data.Common.DataColumnMapping("datTeclhab2de", "datTeclhab2de"), New System.Data.Common.DataColumnMapping("datTeclhab3de", "datTeclhab3de"), New System.Data.Common.DataColumnMapping("datTeclhab4de", "datTeclhab4de"), New System.Data.Common.DataColumnMapping("datTeclhab1du", "datTeclhab1du"), New System.Data.Common.DataColumnMapping("datTeclhab2du", "datTeclhab2du"), New System.Data.Common.DataColumnMapping("datTeclhab3du", "datTeclhab3du"), New System.Data.Common.DataColumnMapping("datTeclhab4du", "datTeclhab4du"), New System.Data.Common.DataColumnMapping("datTsclhea1", "datTsclhea1"), New System.Data.Common.DataColumnMapping("datTsclhea2", "datTsclhea2"), New System.Data.Common.DataColumnMapping("datTsclhea3", "datTsclhea3"), New System.Data.Common.DataColumnMapping("datTsclhea4", "datTsclhea4"), New System.Data.Common.DataColumnMapping("datTsclsoc1", "datTsclsoc1"), New System.Data.Common.DataColumnMapping("datTsclsoc2", "datTsclsoc2"), New System.Data.Common.DataColumnMapping("datTsclsoc3", "datTsclsoc3"), New System.Data.Common.DataColumnMapping("datTsclsoc4", "datTsclsoc4"), New System.Data.Common.DataColumnMapping("datTecnlan", "datTecnlan"), New System.Data.Common.DataColumnMapping("datTecnlan1", "datTecnlan1"), New System.Data.Common.DataColumnMapping("datTecnlan2", "datTecnlan2"), New System.Data.Common.DataColumnMapping("datTecnlan3", "datTecnlan3"), New System.Data.Common.DataColumnMapping("datTecnlan4", "datTecnlan4"), New System.Data.Common.DataColumnMapping("datRTecnuneQ", "datRTecnuneQ"), New System.Data.Common.DataColumnMapping("datRTecnlanQ", "datRTecnlanQ"), New System.Data.Common.DataColumnMapping("datRTecnune", "datRTecnune"), New System.Data.Common.DataColumnMapping("datRTecnlan", "datRTecnlan"), New System.Data.Common.DataColumnMapping("datRTeclspeQ", "datRTeclspeQ"), New System.Data.Common.DataColumnMapping("datRTeclhabQ", "datRTeclhabQ"), New System.Data.Common.DataColumnMapping("datRTeclspe", "datRTeclspe"), New System.Data.Common.DataColumnMapping("datRTeclhab", "datRTeclhab"), New System.Data.Common.DataColumnMapping("datRTsclheaQ", "datRTsclheaQ"), New System.Data.Common.DataColumnMapping("datRTsclsocQ", "datRTsclsocQ"), New System.Data.Common.DataColumnMapping("datRTsclhea", "datRTsclhea"), New System.Data.Common.DataColumnMapping("datRTsclsoc", "datRTsclsoc"), New System.Data.Common.DataColumnMapping("datCOs", "datCOs"), New System.Data.Common.DataColumnMapping("datCOe", "datCOe"), New System.Data.Common.DataColumnMapping("datCOi", "datCOi"), New System.Data.Common.DataColumnMapping("datCOse", "datCOse"), New System.Data.Common.DataColumnMapping("datCOsi", "datCOsi"), New System.Data.Common.DataColumnMapping("datCOei", "datCOei"), New System.Data.Common.DataColumnMapping("datCOsei", "datCOsei"), New System.Data.Common.DataColumnMapping("datsi11", "datsi11"), New System.Data.Common.DataColumnMapping("datei11", "datei11"), New System.Data.Common.DataColumnMapping("datsei11", "datsei11"), New System.Data.Common.DataColumnMapping("datse13", "datse13"), New System.Data.Common.DataColumnMapping("datse13x", "datse13x"), New System.Data.Common.DataColumnMapping("datse23", "datse23"), New System.Data.Common.DataColumnMapping("datse23x", "datse23x"), New System.Data.Common.DataColumnMapping("datB11n", "datB11n"), New System.Data.Common.DataColumnMapping("datW21n", "datW21n"), New System.Data.Common.DataColumnMapping("datW31n", "datW31n"), New System.Data.Common.DataColumnMapping("datW12n", "datW12n"), New System.Data.Common.DataColumnMapping("datW22n", "datW22n"), New System.Data.Common.DataColumnMapping("datW13n", "datW13n"), New System.Data.Common.DataColumnMapping("datW23n", "datW23n"), New System.Data.Common.DataColumnMapping("datB21n", "datB21n"), New System.Data.Common.DataColumnMapping("datB31n", "datB31n"), New System.Data.Common.DataColumnMapping("datB12n", "datB12n"), New System.Data.Common.DataColumnMapping("datB22n", "datB22n"), New System.Data.Common.DataColumnMapping("datB13n", "datB13n"), New System.Data.Common.DataColumnMapping("datB23n", "datB23n"), New System.Data.Common.DataColumnMapping("datP", "datP"), New System.Data.Common.DataColumnMapping("datT", "datT"), New System.Data.Common.DataColumnMapping("datF11", "datF11"), New System.Data.Common.DataColumnMapping("datF11s", "datF11s"), New System.Data.Common.DataColumnMapping("datF11e", "datF11e"), New System.Data.Common.DataColumnMapping("datF11i", "datF11i"), New System.Data.Common.DataColumnMapping("datF11se", "datF11se"), New System.Data.Common.DataColumnMapping("datF11si", "datF11si"), New System.Data.Common.DataColumnMapping("datF11ei", "datF11ei"), New System.Data.Common.DataColumnMapping("datF11sei", "datF11sei"), New System.Data.Common.DataColumnMapping("datF21", "datF21"), New System.Data.Common.DataColumnMapping("datF21s", "datF21s"), New System.Data.Common.DataColumnMapping("datF21e", "datF21e"), New System.Data.Common.DataColumnMapping("datF21i", "datF21i"), New System.Data.Common.DataColumnMapping("datF21se", "datF21se"), New System.Data.Common.DataColumnMapping("datF21si", "datF21si"), New System.Data.Common.DataColumnMapping("datF21ei", "datF21ei"), New System.Data.Common.DataColumnMapping("datF21sei", "datF21sei"), New System.Data.Common.DataColumnMapping("datF31", "datF31"), New System.Data.Common.DataColumnMapping("datF31s", "datF31s"), New System.Data.Common.DataColumnMapping("datF31e", "datF31e"), New System.Data.Common.DataColumnMapping("datF31i", "datF31i"), New System.Data.Common.DataColumnMapping("datF31se", "datF31se"), New System.Data.Common.DataColumnMapping("datF31si", "datF31si"), New System.Data.Common.DataColumnMapping("datF31ei", "datF31ei"), New System.Data.Common.DataColumnMapping("datF31sei", "datF31sei"), New System.Data.Common.DataColumnMapping("datF12", "datF12"), New System.Data.Common.DataColumnMapping("datF12s", "datF12s"), New System.Data.Common.DataColumnMapping("datF12e", "datF12e"), New System.Data.Common.DataColumnMapping("datF12i", "datF12i"), New System.Data.Common.DataColumnMapping("datF12se", "datF12se"), New System.Data.Common.DataColumnMapping("datF12si", "datF12si"), New System.Data.Common.DataColumnMapping("datF12ei", "datF12ei"), New System.Data.Common.DataColumnMapping("datF12sei", "datF12sei"), New System.Data.Common.DataColumnMapping("datF22", "datF22"), New System.Data.Common.DataColumnMapping("datF22s", "datF22s"), New System.Data.Common.DataColumnMapping("datF22e", "datF22e"), New System.Data.Common.DataColumnMapping("datF22i", "datF22i"), New System.Data.Common.DataColumnMapping("datF22se", "datF22se"), New System.Data.Common.DataColumnMapping("datF22si", "datF22si"), New System.Data.Common.DataColumnMapping("datF22ei", "datF22ei"), New System.Data.Common.DataColumnMapping("datF22sei", "datF22sei"), New System.Data.Common.DataColumnMapping("datF13", "datF13"), New System.Data.Common.DataColumnMapping("datF13s", "datF13s"), New System.Data.Common.DataColumnMapping("datF13e", "datF13e"), New System.Data.Common.DataColumnMapping("datF13i", "datF13i"), New System.Data.Common.DataColumnMapping("datF13se", "datF13se"), New System.Data.Common.DataColumnMapping("datF13si", "datF13si"), New System.Data.Common.DataColumnMapping("datF13ei", "datF13ei"), New System.Data.Common.DataColumnMapping("datF13sei", "datF13sei"), New System.Data.Common.DataColumnMapping("datF23", "datF23"), New System.Data.Common.DataColumnMapping("datF23s", "datF23s"), New System.Data.Common.DataColumnMapping("datF23e", "datF23e"), New System.Data.Common.DataColumnMapping("datF23i", "datF23i"), New System.Data.Common.DataColumnMapping("datF23se", "datF23se"), New System.Data.Common.DataColumnMapping("datF23si", "datF23si"), New System.Data.Common.DataColumnMapping("datF23ei", "datF23ei"), New System.Data.Common.DataColumnMapping("datF23sei", "datF23sei"), New System.Data.Common.DataColumnMapping("datXs", "datXs"), New System.Data.Common.DataColumnMapping("datXe", "datXe"), New System.Data.Common.DataColumnMapping("datXi", "datXi"), New System.Data.Common.DataColumnMapping("datXse", "datXse"), New System.Data.Common.DataColumnMapping("datXsi", "datXsi"), New System.Data.Common.DataColumnMapping("datXei", "datXei"), New System.Data.Common.DataColumnMapping("datXsei", "datXsei"), New System.Data.Common.DataColumnMapping("datRXs", "datRXs"), New System.Data.Common.DataColumnMapping("datRXe", "datRXe"), New System.Data.Common.DataColumnMapping("datRXi", "datRXi"), New System.Data.Common.DataColumnMapping("datRXse", "datRXse"), New System.Data.Common.DataColumnMapping("datRXsi", "datRXsi"), New System.Data.Common.DataColumnMapping("datRXei", "datRXei"), New System.Data.Common.DataColumnMapping("datRXsei", "datRXsei"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione"), New System.Data.Common.DataColumnMapping("UtenteCreazione", "UtenteCreazione"), New System.Data.Common.DataColumnMapping("DataAggiornamento", "DataAggiornamento"), New System.Data.Common.DataColumnMapping("UtenteAggiornamento", "UtenteAggiornamento"), New System.Data.Common.DataColumnMapping("Annullato", "Annullato"), New System.Data.Common.DataColumnMapping("DataEstrazione", "DataEstrazione")})})
		Me.daData.UpdateCommand = Me.SqlUpdateCommand
		'
		'SqlDeleteCommand
		'
		Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
		Me.SqlDeleteCommand.Connection = Me.SqlConnection1
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "Data Source=localhost\sqlexpress;Initial Catalog=dss;Persist Security Info=True;U" & _
	"ser ID=DSS;Password=DSS"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'SqlInsertCommand
		'
		Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
		Me.SqlInsertCommand.Connection = Me.SqlConnection1
		Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datDE", System.Data.SqlDbType.Float, 0, "datDE"), New System.Data.SqlClient.SqlParameter("@datDU", System.Data.SqlDbType.Float, 0, "datDU"), New System.Data.SqlClient.SqlParameter("@datFR", System.Data.SqlDbType.Float, 0, "datFR"), New System.Data.SqlClient.SqlParameter("@datY", System.Data.SqlDbType.Float, 0, "datY"), New System.Data.SqlClient.SqlParameter("@datS1", System.Data.SqlDbType.Float, 0, "datS1"), New System.Data.SqlClient.SqlParameter("@datS2", System.Data.SqlDbType.Float, 0, "datS2"), New System.Data.SqlClient.SqlParameter("@datS3", System.Data.SqlDbType.Float, 0, "datS3"), New System.Data.SqlClient.SqlParameter("@datE11", System.Data.SqlDbType.Float, 0, "datE11"), New System.Data.SqlClient.SqlParameter("@datE11r", System.Data.SqlDbType.Float, 0, "datE11r"), New System.Data.SqlClient.SqlParameter("@datE21", System.Data.SqlDbType.Float, 0, "datE21"), New System.Data.SqlClient.SqlParameter("@datE31", System.Data.SqlDbType.Float, 0, "datE31"), New System.Data.SqlClient.SqlParameter("@datE12", System.Data.SqlDbType.Float, 0, "datE12"), New System.Data.SqlClient.SqlParameter("@datE22", System.Data.SqlDbType.Float, 0, "datE22"), New System.Data.SqlClient.SqlParameter("@datE13", System.Data.SqlDbType.Float, 0, "datE13"), New System.Data.SqlClient.SqlParameter("@datE23", System.Data.SqlDbType.Float, 0, "datE23"), New System.Data.SqlClient.SqlParameter("@datW11", System.Data.SqlDbType.Float, 0, "datW11"), New System.Data.SqlClient.SqlParameter("@datW21", System.Data.SqlDbType.NVarChar, 0, "datW21"), New System.Data.SqlClient.SqlParameter("@datW31", System.Data.SqlDbType.NVarChar, 0, "datW31"), New System.Data.SqlClient.SqlParameter("@datW12", System.Data.SqlDbType.Float, 0, "datW12"), New System.Data.SqlClient.SqlParameter("@datW22", System.Data.SqlDbType.NVarChar, 0, "datW22"), New System.Data.SqlClient.SqlParameter("@datW13", System.Data.SqlDbType.NVarChar, 0, "datW13"), New System.Data.SqlClient.SqlParameter("@datW23", System.Data.SqlDbType.NVarChar, 0, "datW23"), New System.Data.SqlClient.SqlParameter("@datB11", System.Data.SqlDbType.Float, 0, "datB11"), New System.Data.SqlClient.SqlParameter("@datB21", System.Data.SqlDbType.NVarChar, 0, "datB21"), New System.Data.SqlClient.SqlParameter("@datB31", System.Data.SqlDbType.NVarChar, 0, "datB31"), New System.Data.SqlClient.SqlParameter("@datB12", System.Data.SqlDbType.Float, 0, "datB12"), New System.Data.SqlClient.SqlParameter("@datB22", System.Data.SqlDbType.NVarChar, 0, "datB22"), New System.Data.SqlClient.SqlParameter("@datB13", System.Data.SqlDbType.NVarChar, 0, "datB13"), New System.Data.SqlClient.SqlParameter("@datB23", System.Data.SqlDbType.NVarChar, 0, "datB23"), New System.Data.SqlClient.SqlParameter("@datV1", System.Data.SqlDbType.Float, 0, "datV1"), New System.Data.SqlClient.SqlParameter("@datV2", System.Data.SqlDbType.Float, 0, "datV2"), New System.Data.SqlClient.SqlParameter("@datV3", System.Data.SqlDbType.Float, 0, "datV3"), New System.Data.SqlClient.SqlParameter("@datV4", System.Data.SqlDbType.Float, 0, "datV4"), New System.Data.SqlClient.SqlParameter("@datV5", System.Data.SqlDbType.Float, 0, "datV5"), New System.Data.SqlClient.SqlParameter("@datV6", System.Data.SqlDbType.Float, 0, "datV6"), New System.Data.SqlClient.SqlParameter("@datV7", System.Data.SqlDbType.Float, 0, "datV7"), New System.Data.SqlClient.SqlParameter("@datV8", System.Data.SqlDbType.Float, 0, "datV8"), New System.Data.SqlClient.SqlParameter("@datA1", System.Data.SqlDbType.Float, 0, "datA1"), New System.Data.SqlClient.SqlParameter("@datA2", System.Data.SqlDbType.Float, 0, "datA2"), New System.Data.SqlClient.SqlParameter("@datA3", System.Data.SqlDbType.Float, 0, "datA3"), New System.Data.SqlClient.SqlParameter("@datA4", System.Data.SqlDbType.Float, 0, "datA4"), New System.Data.SqlClient.SqlParameter("@datA5", System.Data.SqlDbType.Float, 0, "datA5"), New System.Data.SqlClient.SqlParameter("@datA6", System.Data.SqlDbType.Float, 0, "datA6"), New System.Data.SqlClient.SqlParameter("@datA7", System.Data.SqlDbType.Float, 0, "datA7"), New System.Data.SqlClient.SqlParameter("@datA8", System.Data.SqlDbType.Float, 0, "datA8"), New System.Data.SqlClient.SqlParameter("@datB1", System.Data.SqlDbType.Float, 0, "datB1"), New System.Data.SqlClient.SqlParameter("@datB2", System.Data.SqlDbType.Float, 0, "datB2"), New System.Data.SqlClient.SqlParameter("@datB3", System.Data.SqlDbType.Float, 0, "datB3"), New System.Data.SqlClient.SqlParameter("@datB4", System.Data.SqlDbType.Float, 0, "datB4"), New System.Data.SqlClient.SqlParameter("@datB5", System.Data.SqlDbType.Float, 0, "datB5"), New System.Data.SqlClient.SqlParameter("@datB6", System.Data.SqlDbType.Float, 0, "datB6"), New System.Data.SqlClient.SqlParameter("@datB7", System.Data.SqlDbType.Float, 0, "datB7"), New System.Data.SqlClient.SqlParameter("@datB8", System.Data.SqlDbType.Float, 0, "datB8"), New System.Data.SqlClient.SqlParameter("@datZ", System.Data.SqlDbType.Float, 0, "datZ"), New System.Data.SqlClient.SqlParameter("@datZZ", System.Data.SqlDbType.Float, 0, "datZZ"), New System.Data.SqlClient.SqlParameter("@datM", System.Data.SqlDbType.Float, 0, "datM"), New System.Data.SqlClient.SqlParameter("@datTecnune1", System.Data.SqlDbType.Float, 0, "datTecnune1"), New System.Data.SqlClient.SqlParameter("@datTecnune2", System.Data.SqlDbType.Float, 0, "datTecnune2"), New System.Data.SqlClient.SqlParameter("@datTecnune3", System.Data.SqlDbType.Float, 0, "datTecnune3"), New System.Data.SqlClient.SqlParameter("@datTecnune4", System.Data.SqlDbType.Float, 0, "datTecnune4"), New System.Data.SqlClient.SqlParameter("@datC", System.Data.SqlDbType.Float, 0, "datC"), New System.Data.SqlClient.SqlParameter("@datD", System.Data.SqlDbType.Float, 0, "datD"), New System.Data.SqlClient.SqlParameter("@dati11", System.Data.SqlDbType.Float, 0, "dati11"), New System.Data.SqlClient.SqlParameter("@dati11x", System.Data.SqlDbType.Float, 0, "dati11x"), New System.Data.SqlClient.SqlParameter("@datTeclspe1", System.Data.SqlDbType.Float, 0, "datTeclspe1"), New System.Data.SqlClient.SqlParameter("@datTeclspe2", System.Data.SqlDbType.Float, 0, "datTeclspe2"), New System.Data.SqlClient.SqlParameter("@datTeclspe3", System.Data.SqlDbType.Float, 0, "datTeclspe3"), New System.Data.SqlClient.SqlParameter("@datTeclspe4", System.Data.SqlDbType.Float, 0, "datTeclspe4"), New System.Data.SqlClient.SqlParameter("@datTeclhab1de", System.Data.SqlDbType.Float, 0, "datTeclhab1de"), New System.Data.SqlClient.SqlParameter("@datTeclhab2de", System.Data.SqlDbType.Float, 0, "datTeclhab2de"), New System.Data.SqlClient.SqlParameter("@datTeclhab3de", System.Data.SqlDbType.Float, 0, "datTeclhab3de"), New System.Data.SqlClient.SqlParameter("@datTeclhab4de", System.Data.SqlDbType.Float, 0, "datTeclhab4de"), New System.Data.SqlClient.SqlParameter("@datTeclhab1du", System.Data.SqlDbType.Float, 0, "datTeclhab1du"), New System.Data.SqlClient.SqlParameter("@datTeclhab2du", System.Data.SqlDbType.Float, 0, "datTeclhab2du"), New System.Data.SqlClient.SqlParameter("@datTeclhab3du", System.Data.SqlDbType.Float, 0, "datTeclhab3du"), New System.Data.SqlClient.SqlParameter("@datTeclhab4du", System.Data.SqlDbType.Float, 0, "datTeclhab4du"), New System.Data.SqlClient.SqlParameter("@datTsclhea1", System.Data.SqlDbType.Float, 0, "datTsclhea1"), New System.Data.SqlClient.SqlParameter("@datTsclhea2", System.Data.SqlDbType.Float, 0, "datTsclhea2"), New System.Data.SqlClient.SqlParameter("@datTsclhea3", System.Data.SqlDbType.Float, 0, "datTsclhea3"), New System.Data.SqlClient.SqlParameter("@datTsclhea4", System.Data.SqlDbType.Float, 0, "datTsclhea4"), New System.Data.SqlClient.SqlParameter("@datTsclsoc1", System.Data.SqlDbType.Float, 0, "datTsclsoc1"), New System.Data.SqlClient.SqlParameter("@datTsclsoc2", System.Data.SqlDbType.Float, 0, "datTsclsoc2"), New System.Data.SqlClient.SqlParameter("@datTsclsoc3", System.Data.SqlDbType.Float, 0, "datTsclsoc3"), New System.Data.SqlClient.SqlParameter("@datTsclsoc4", System.Data.SqlDbType.Float, 0, "datTsclsoc4"), New System.Data.SqlClient.SqlParameter("@datTecnlan", System.Data.SqlDbType.Float, 0, "datTecnlan"), New System.Data.SqlClient.SqlParameter("@datTecnlan1", System.Data.SqlDbType.Float, 0, "datTecnlan1"), New System.Data.SqlClient.SqlParameter("@datTecnlan2", System.Data.SqlDbType.Float, 0, "datTecnlan2"), New System.Data.SqlClient.SqlParameter("@datTecnlan3", System.Data.SqlDbType.Float, 0, "datTecnlan3"), New System.Data.SqlClient.SqlParameter("@datTecnlan4", System.Data.SqlDbType.Float, 0, "datTecnlan4"), New System.Data.SqlClient.SqlParameter("@datRTecnuneQ", System.Data.SqlDbType.NVarChar, 0, "datRTecnuneQ"), New System.Data.SqlClient.SqlParameter("@datRTecnlanQ", System.Data.SqlDbType.NVarChar, 0, "datRTecnlanQ"), New System.Data.SqlClient.SqlParameter("@datRTecnune", System.Data.SqlDbType.Float, 0, "datRTecnune"), New System.Data.SqlClient.SqlParameter("@datRTecnlan", System.Data.SqlDbType.Float, 0, "datRTecnlan"), New System.Data.SqlClient.SqlParameter("@datRTeclspeQ", System.Data.SqlDbType.NVarChar, 0, "datRTeclspeQ"), New System.Data.SqlClient.SqlParameter("@datRTeclhabQ", System.Data.SqlDbType.NVarChar, 0, "datRTeclhabQ"), New System.Data.SqlClient.SqlParameter("@datRTeclspe", System.Data.SqlDbType.Float, 0, "datRTeclspe"), New System.Data.SqlClient.SqlParameter("@datRTeclhab", System.Data.SqlDbType.Float, 0, "datRTeclhab"), New System.Data.SqlClient.SqlParameter("@datRTsclheaQ", System.Data.SqlDbType.NVarChar, 0, "datRTsclheaQ"), New System.Data.SqlClient.SqlParameter("@datRTsclsocQ", System.Data.SqlDbType.NVarChar, 0, "datRTsclsocQ"), New System.Data.SqlClient.SqlParameter("@datRTsclhea", System.Data.SqlDbType.Float, 0, "datRTsclhea"), New System.Data.SqlClient.SqlParameter("@datRTsclsoc", System.Data.SqlDbType.Float, 0, "datRTsclsoc"), New System.Data.SqlClient.SqlParameter("@datCOs", System.Data.SqlDbType.Float, 0, "datCOs"), New System.Data.SqlClient.SqlParameter("@datCOe", System.Data.SqlDbType.Float, 0, "datCOe"), New System.Data.SqlClient.SqlParameter("@datCOi", System.Data.SqlDbType.Float, 0, "datCOi"), New System.Data.SqlClient.SqlParameter("@datCOse", System.Data.SqlDbType.Float, 0, "datCOse"), New System.Data.SqlClient.SqlParameter("@datCOsi", System.Data.SqlDbType.Float, 0, "datCOsi"), New System.Data.SqlClient.SqlParameter("@datCOei", System.Data.SqlDbType.Float, 0, "datCOei"), New System.Data.SqlClient.SqlParameter("@datCOsei", System.Data.SqlDbType.Float, 0, "datCOsei"), New System.Data.SqlClient.SqlParameter("@datsi11", System.Data.SqlDbType.Float, 0, "datsi11"), New System.Data.SqlClient.SqlParameter("@datei11", System.Data.SqlDbType.Float, 0, "datei11"), New System.Data.SqlClient.SqlParameter("@datsei11", System.Data.SqlDbType.Float, 0, "datsei11"), New System.Data.SqlClient.SqlParameter("@datse13", System.Data.SqlDbType.Float, 0, "datse13"), New System.Data.SqlClient.SqlParameter("@datse13x", System.Data.SqlDbType.Float, 0, "datse13x"), New System.Data.SqlClient.SqlParameter("@datse23", System.Data.SqlDbType.Float, 0, "datse23"), New System.Data.SqlClient.SqlParameter("@datse23x", System.Data.SqlDbType.Float, 0, "datse23x"), New System.Data.SqlClient.SqlParameter("@datB11n", System.Data.SqlDbType.Float, 0, "datB11n"), New System.Data.SqlClient.SqlParameter("@datW21n", System.Data.SqlDbType.Float, 0, "datW21n"), New System.Data.SqlClient.SqlParameter("@datW31n", System.Data.SqlDbType.Float, 0, "datW31n"), New System.Data.SqlClient.SqlParameter("@datW12n", System.Data.SqlDbType.Float, 0, "datW12n"), New System.Data.SqlClient.SqlParameter("@datW22n", System.Data.SqlDbType.Float, 0, "datW22n"), New System.Data.SqlClient.SqlParameter("@datW13n", System.Data.SqlDbType.Float, 0, "datW13n"), New System.Data.SqlClient.SqlParameter("@datW23n", System.Data.SqlDbType.Float, 0, "datW23n"), New System.Data.SqlClient.SqlParameter("@datB21n", System.Data.SqlDbType.Float, 0, "datB21n"), New System.Data.SqlClient.SqlParameter("@datB31n", System.Data.SqlDbType.Float, 0, "datB31n"), New System.Data.SqlClient.SqlParameter("@datB12n", System.Data.SqlDbType.Float, 0, "datB12n"), New System.Data.SqlClient.SqlParameter("@datB22n", System.Data.SqlDbType.Float, 0, "datB22n"), New System.Data.SqlClient.SqlParameter("@datB13n", System.Data.SqlDbType.Float, 0, "datB13n"), New System.Data.SqlClient.SqlParameter("@datB23n", System.Data.SqlDbType.Float, 0, "datB23n"), New System.Data.SqlClient.SqlParameter("@datP", System.Data.SqlDbType.Float, 0, "datP"), New System.Data.SqlClient.SqlParameter("@datT", System.Data.SqlDbType.Float, 0, "datT"), New System.Data.SqlClient.SqlParameter("@datF11", System.Data.SqlDbType.Float, 0, "datF11"), New System.Data.SqlClient.SqlParameter("@datF11s", System.Data.SqlDbType.Float, 0, "datF11s"), New System.Data.SqlClient.SqlParameter("@datF11e", System.Data.SqlDbType.Float, 0, "datF11e"), New System.Data.SqlClient.SqlParameter("@datF11i", System.Data.SqlDbType.Float, 0, "datF11i"), New System.Data.SqlClient.SqlParameter("@datF11se", System.Data.SqlDbType.Float, 0, "datF11se"), New System.Data.SqlClient.SqlParameter("@datF11si", System.Data.SqlDbType.Float, 0, "datF11si"), New System.Data.SqlClient.SqlParameter("@datF11ei", System.Data.SqlDbType.Float, 0, "datF11ei"), New System.Data.SqlClient.SqlParameter("@datF11sei", System.Data.SqlDbType.Float, 0, "datF11sei"), New System.Data.SqlClient.SqlParameter("@datF21", System.Data.SqlDbType.NVarChar, 0, "datF21"), New System.Data.SqlClient.SqlParameter("@datF21s", System.Data.SqlDbType.NVarChar, 0, "datF21s"), New System.Data.SqlClient.SqlParameter("@datF21e", System.Data.SqlDbType.NVarChar, 0, "datF21e"), New System.Data.SqlClient.SqlParameter("@datF21i", System.Data.SqlDbType.NVarChar, 0, "datF21i"), New System.Data.SqlClient.SqlParameter("@datF21se", System.Data.SqlDbType.NVarChar, 0, "datF21se"), New System.Data.SqlClient.SqlParameter("@datF21si", System.Data.SqlDbType.NVarChar, 0, "datF21si"), New System.Data.SqlClient.SqlParameter("@datF21ei", System.Data.SqlDbType.NVarChar, 0, "datF21ei"), New System.Data.SqlClient.SqlParameter("@datF21sei", System.Data.SqlDbType.NVarChar, 0, "datF21sei"), New System.Data.SqlClient.SqlParameter("@datF31", System.Data.SqlDbType.NVarChar, 0, "datF31"), New System.Data.SqlClient.SqlParameter("@datF31s", System.Data.SqlDbType.NVarChar, 0, "datF31s"), New System.Data.SqlClient.SqlParameter("@datF31e", System.Data.SqlDbType.NVarChar, 0, "datF31e"), New System.Data.SqlClient.SqlParameter("@datF31i", System.Data.SqlDbType.NVarChar, 0, "datF31i"), New System.Data.SqlClient.SqlParameter("@datF31se", System.Data.SqlDbType.NVarChar, 0, "datF31se"), New System.Data.SqlClient.SqlParameter("@datF31si", System.Data.SqlDbType.NVarChar, 0, "datF31si"), New System.Data.SqlClient.SqlParameter("@datF31ei", System.Data.SqlDbType.NVarChar, 0, "datF31ei"), New System.Data.SqlClient.SqlParameter("@datF31sei", System.Data.SqlDbType.NVarChar, 0, "datF31sei"), New System.Data.SqlClient.SqlParameter("@datF12", System.Data.SqlDbType.NVarChar, 0, "datF12"), New System.Data.SqlClient.SqlParameter("@datF12s", System.Data.SqlDbType.NVarChar, 0, "datF12s"), New System.Data.SqlClient.SqlParameter("@datF12e", System.Data.SqlDbType.NVarChar, 0, "datF12e"), New System.Data.SqlClient.SqlParameter("@datF12i", System.Data.SqlDbType.NVarChar, 0, "datF12i"), New System.Data.SqlClient.SqlParameter("@datF12se", System.Data.SqlDbType.NVarChar, 0, "datF12se"), New System.Data.SqlClient.SqlParameter("@datF12si", System.Data.SqlDbType.NVarChar, 0, "datF12si"), New System.Data.SqlClient.SqlParameter("@datF12ei", System.Data.SqlDbType.NVarChar, 0, "datF12ei"), New System.Data.SqlClient.SqlParameter("@datF12sei", System.Data.SqlDbType.NVarChar, 0, "datF12sei"), New System.Data.SqlClient.SqlParameter("@datF22", System.Data.SqlDbType.NVarChar, 0, "datF22"), New System.Data.SqlClient.SqlParameter("@datF22s", System.Data.SqlDbType.NVarChar, 0, "datF22s"), New System.Data.SqlClient.SqlParameter("@datF22e", System.Data.SqlDbType.NVarChar, 0, "datF22e"), New System.Data.SqlClient.SqlParameter("@datF22i", System.Data.SqlDbType.NVarChar, 0, "datF22i"), New System.Data.SqlClient.SqlParameter("@datF22se", System.Data.SqlDbType.NVarChar, 0, "datF22se"), New System.Data.SqlClient.SqlParameter("@datF22si", System.Data.SqlDbType.NVarChar, 0, "datF22si"), New System.Data.SqlClient.SqlParameter("@datF22ei", System.Data.SqlDbType.NVarChar, 0, "datF22ei"), New System.Data.SqlClient.SqlParameter("@datF22sei", System.Data.SqlDbType.NVarChar, 0, "datF22sei"), New System.Data.SqlClient.SqlParameter("@datF13", System.Data.SqlDbType.NVarChar, 0, "datF13"), New System.Data.SqlClient.SqlParameter("@datF13s", System.Data.SqlDbType.NVarChar, 0, "datF13s"), New System.Data.SqlClient.SqlParameter("@datF13e", System.Data.SqlDbType.NVarChar, 0, "datF13e"), New System.Data.SqlClient.SqlParameter("@datF13i", System.Data.SqlDbType.NVarChar, 0, "datF13i"), New System.Data.SqlClient.SqlParameter("@datF13se", System.Data.SqlDbType.NVarChar, 0, "datF13se"), New System.Data.SqlClient.SqlParameter("@datF13si", System.Data.SqlDbType.NVarChar, 0, "datF13si"), New System.Data.SqlClient.SqlParameter("@datF13ei", System.Data.SqlDbType.NVarChar, 0, "datF13ei"), New System.Data.SqlClient.SqlParameter("@datF13sei", System.Data.SqlDbType.NVarChar, 0, "datF13sei"), New System.Data.SqlClient.SqlParameter("@datF23", System.Data.SqlDbType.NVarChar, 0, "datF23"), New System.Data.SqlClient.SqlParameter("@datF23s", System.Data.SqlDbType.NVarChar, 0, "datF23s"), New System.Data.SqlClient.SqlParameter("@datF23e", System.Data.SqlDbType.NVarChar, 0, "datF23e"), New System.Data.SqlClient.SqlParameter("@datF23i", System.Data.SqlDbType.NVarChar, 0, "datF23i"), New System.Data.SqlClient.SqlParameter("@datF23se", System.Data.SqlDbType.NVarChar, 0, "datF23se"), New System.Data.SqlClient.SqlParameter("@datF23si", System.Data.SqlDbType.NVarChar, 0, "datF23si"), New System.Data.SqlClient.SqlParameter("@datF23ei", System.Data.SqlDbType.NVarChar, 0, "datF23ei"), New System.Data.SqlClient.SqlParameter("@datF23sei", System.Data.SqlDbType.NVarChar, 0, "datF23sei"), New System.Data.SqlClient.SqlParameter("@datXs", System.Data.SqlDbType.Float, 0, "datXs"), New System.Data.SqlClient.SqlParameter("@datXe", System.Data.SqlDbType.Float, 0, "datXe"), New System.Data.SqlClient.SqlParameter("@datXi", System.Data.SqlDbType.Float, 0, "datXi"), New System.Data.SqlClient.SqlParameter("@datXse", System.Data.SqlDbType.Float, 0, "datXse"), New System.Data.SqlClient.SqlParameter("@datXsi", System.Data.SqlDbType.Float, 0, "datXsi"), New System.Data.SqlClient.SqlParameter("@datXei", System.Data.SqlDbType.Float, 0, "datXei"), New System.Data.SqlClient.SqlParameter("@datXsei", System.Data.SqlDbType.Float, 0, "datXsei"), New System.Data.SqlClient.SqlParameter("@datRXs", System.Data.SqlDbType.Float, 0, "datRXs"), New System.Data.SqlClient.SqlParameter("@datRXe", System.Data.SqlDbType.Float, 0, "datRXe"), New System.Data.SqlClient.SqlParameter("@datRXi", System.Data.SqlDbType.Float, 0, "datRXi"), New System.Data.SqlClient.SqlParameter("@datRXse", System.Data.SqlDbType.Float, 0, "datRXse"), New System.Data.SqlClient.SqlParameter("@datRXsi", System.Data.SqlDbType.Float, 0, "datRXsi"), New System.Data.SqlClient.SqlParameter("@datRXei", System.Data.SqlDbType.Float, 0, "datRXei"), New System.Data.SqlClient.SqlParameter("@datRXsei", System.Data.SqlDbType.Float, 0, "datRXsei"), New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 0, "DataCreazione"), New System.Data.SqlClient.SqlParameter("@UtenteCreazione", System.Data.SqlDbType.Int, 0, "UtenteCreazione"), New System.Data.SqlClient.SqlParameter("@DataAggiornamento", System.Data.SqlDbType.DateTime, 0, "DataAggiornamento"), New System.Data.SqlClient.SqlParameter("@UtenteAggiornamento", System.Data.SqlDbType.Int, 0, "UtenteAggiornamento"), New System.Data.SqlClient.SqlParameter("@Annullato", System.Data.SqlDbType.Bit, 0, "Annullato"), New System.Data.SqlClient.SqlParameter("@DataEstrazione", System.Data.SqlDbType.DateTime, 0, "DataEstrazione")})
		'
		'SqlSelectCommand
		'
		Me.SqlSelectCommand.CommandText = resources.GetString("SqlSelectCommand.CommandText")
		Me.SqlSelectCommand.Connection = Me.SqlConnection1
		'
		'SqlUpdateCommand
		'
		Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
		Me.SqlUpdateCommand.Connection = Me.SqlConnection1
		'
		'btnNext
		'
		Me.btnNext.Location = New System.Drawing.Point(441, 505)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(90, 36)
		Me.btnNext.TabIndex = 0
		Me.btnNext.Text = "Next"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Location = New System.Drawing.Point(342, 505)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(90, 36)
		Me.btnPrev.TabIndex = 29
		Me.btnPrev.Text = "Previous"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'btnLoadData
		'
		Me.btnLoadData.Location = New System.Drawing.Point(114, 505)
		Me.btnLoadData.Name = "btnLoadData"
		Me.btnLoadData.Size = New System.Drawing.Size(90, 36)
		Me.btnLoadData.TabIndex = 29
		Me.btnLoadData.Text = "Load data"
		Me.btnLoadData.UseVisualStyleBackColor = True
		'
		'dsParameters
		'
		Me.dsParameters.DataSetName = "parameters"
		Me.dsParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TAParameters
		'
		Me.TAParameters.ClearBeforeFill = True
		'
		'DSData
		'
		Me.DSData.DataSetName = "DSData"
		Me.DSData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'grbSummary
		'
		Me.grbSummary.Controls.Add(Me.tcoSummary)
		Me.grbSummary.DSSTVisible = True
		Me.grbSummary.ForeColor = System.Drawing.Color.Black
		Me.grbSummary.Location = New System.Drawing.Point(33, 12)
		Me.grbSummary.Name = "grbSummary"
		Me.grbSummary.Size = New System.Drawing.Size(876, 487)
		Me.grbSummary.TabIndex = 26
		Me.grbSummary.TabStop = False
		Me.grbSummary.Text = "Summary"
		Me.grbSummary.Visible = False
		'
		'tcoSummary
		'
		Me.tcoSummary.Controls.Add(Me.tpaExposure)
		Me.tcoSummary.Controls.Add(Me.tpaResilience)
		Me.tcoSummary.Controls.Add(Me.tpaScores)
		Me.tcoSummary.Controls.Add(Me.tpaGraph0)
		Me.tcoSummary.Controls.Add(Me.tpaGraph1)
		Me.tcoSummary.Controls.Add(Me.tpaGraph2)
		Me.tcoSummary.Controls.Add(Me.tpaGraph3)
		Me.tcoSummary.Controls.Add(Me.tpaGraph4)
		Me.tcoSummary.Controls.Add(Me.tpaGraph5)
		Me.tcoSummary.Controls.Add(Me.tpaGraph6)
		Me.tcoSummary.Location = New System.Drawing.Point(2, 13)
		Me.tcoSummary.Name = "tcoSummary"
		Me.tcoSummary.SelectedIndex = 0
		Me.tcoSummary.Size = New System.Drawing.Size(873, 468)
		Me.tcoSummary.TabIndex = 33
		'
		'tpaExposure
		'
		Me.tpaExposure.BackColor = System.Drawing.Color.Transparent
		Me.tpaExposure.Controls.Add(Me.Label5)
		Me.tpaExposure.Controls.Add(Me.Label7)
		Me.tpaExposure.Controls.Add(Me.Label8)
		Me.tpaExposure.Controls.Add(Me.Label90)
		Me.tpaExposure.Controls.Add(Me.Label91)
		Me.tpaExposure.Controls.Add(Me.Label92)
		Me.tpaExposure.Controls.Add(Me.Label93)
		Me.tpaExposure.Controls.Add(Me.lblF23sei)
		Me.tpaExposure.Controls.Add(Me.lblF23ei)
		Me.tpaExposure.Controls.Add(Me.lblF23si)
		Me.tpaExposure.Controls.Add(Me.lblF23se)
		Me.tpaExposure.Controls.Add(Me.lblF23i)
		Me.tpaExposure.Controls.Add(Me.lblF23e)
		Me.tpaExposure.Controls.Add(Me.lblF23s)
		Me.tpaExposure.Controls.Add(Me.lblF23)
		Me.tpaExposure.Controls.Add(Me.lblF13sei)
		Me.tpaExposure.Controls.Add(Me.lblF13ei)
		Me.tpaExposure.Controls.Add(Me.lblF13si)
		Me.tpaExposure.Controls.Add(Me.lblF13se)
		Me.tpaExposure.Controls.Add(Me.lblF13i)
		Me.tpaExposure.Controls.Add(Me.lblF13e)
		Me.tpaExposure.Controls.Add(Me.lblF13s)
		Me.tpaExposure.Controls.Add(Me.lblF13)
		Me.tpaExposure.Controls.Add(Me.lblF22sei)
		Me.tpaExposure.Controls.Add(Me.lblF22ei)
		Me.tpaExposure.Controls.Add(Me.lblF22si)
		Me.tpaExposure.Controls.Add(Me.lblF22se)
		Me.tpaExposure.Controls.Add(Me.lblF22i)
		Me.tpaExposure.Controls.Add(Me.lblF22e)
		Me.tpaExposure.Controls.Add(Me.lblF22s)
		Me.tpaExposure.Controls.Add(Me.lblF22)
		Me.tpaExposure.Controls.Add(Me.lblF12sei)
		Me.tpaExposure.Controls.Add(Me.lblF12ei)
		Me.tpaExposure.Controls.Add(Me.lblF12si)
		Me.tpaExposure.Controls.Add(Me.lblF12se)
		Me.tpaExposure.Controls.Add(Me.lblF12i)
		Me.tpaExposure.Controls.Add(Me.lblF12e)
		Me.tpaExposure.Controls.Add(Me.lblF12s)
		Me.tpaExposure.Controls.Add(Me.lblF12)
		Me.tpaExposure.Controls.Add(Me.lblF31sei)
		Me.tpaExposure.Controls.Add(Me.lblF31ei)
		Me.tpaExposure.Controls.Add(Me.lblF31si)
		Me.tpaExposure.Controls.Add(Me.lblF31se)
		Me.tpaExposure.Controls.Add(Me.lblF31i)
		Me.tpaExposure.Controls.Add(Me.lblF31e)
		Me.tpaExposure.Controls.Add(Me.lblF31s)
		Me.tpaExposure.Controls.Add(Me.lblF31)
		Me.tpaExposure.Controls.Add(Me.lblF21sei)
		Me.tpaExposure.Controls.Add(Me.lblF21ei)
		Me.tpaExposure.Controls.Add(Me.lblF21si)
		Me.tpaExposure.Controls.Add(Me.lblF21se)
		Me.tpaExposure.Controls.Add(Me.lblF21i)
		Me.tpaExposure.Controls.Add(Me.lblF21e)
		Me.tpaExposure.Controls.Add(Me.lblF21s)
		Me.tpaExposure.Controls.Add(Me.lblF21)
		Me.tpaExposure.Controls.Add(Me.lblF11sei)
		Me.tpaExposure.Controls.Add(Me.lblF11ei)
		Me.tpaExposure.Controls.Add(Me.lblF11si)
		Me.tpaExposure.Controls.Add(Me.lblF11se)
		Me.tpaExposure.Controls.Add(Me.lblF11i)
		Me.tpaExposure.Controls.Add(Me.lblF11e)
		Me.tpaExposure.Controls.Add(Me.lblF11s)
		Me.tpaExposure.Controls.Add(Me.lblF11)
		Me.tpaExposure.Controls.Add(Me.Label102)
		Me.tpaExposure.Controls.Add(Me.Label106)
		Me.tpaExposure.Controls.Add(Me.Label105)
		Me.tpaExposure.Controls.Add(Me.Label109)
		Me.tpaExposure.Controls.Add(Me.Label108)
		Me.tpaExposure.Controls.Add(Me.Label107)
		Me.tpaExposure.Controls.Add(Me.Label104)
		Me.tpaExposure.Controls.Add(Me.Label103)
		Me.tpaExposure.Controls.Add(Me.Label95)
		Me.tpaExposure.Controls.Add(Me.Label96)
		Me.tpaExposure.Controls.Add(Me.Label97)
		Me.tpaExposure.Controls.Add(Me.Label98)
		Me.tpaExposure.Controls.Add(Me.Label99)
		Me.tpaExposure.Controls.Add(Me.Label100)
		Me.tpaExposure.Controls.Add(Me.Label101)
		Me.tpaExposure.Location = New System.Drawing.Point(4, 22)
		Me.tpaExposure.Name = "tpaExposure"
		Me.tpaExposure.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaExposure.Size = New System.Drawing.Size(865, 442)
		Me.tpaExposure.TabIndex = 1
		Me.tpaExposure.Text = "Exposure"
		Me.tpaExposure.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(1, 349)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(118, 41)
		Me.Label5.TabIndex = 36
		Me.Label5.Text = "Sand && Evacuation && Insurance"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(1, 181)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(118, 19)
		Me.Label7.TabIndex = 110
		Me.Label7.Text = "Insurance scheme"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(1, 307)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(118, 41)
		Me.Label8.TabIndex = 109
		Me.Label8.Text = "Evacuation && Insurance"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label90
		'
		Me.Label90.Location = New System.Drawing.Point(1, 139)
		Me.Label90.Name = "Label90"
		Me.Label90.Size = New System.Drawing.Size(118, 19)
		Me.Label90.TabIndex = 33
		Me.Label90.Text = "Evacuation plan"
		Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label91
		'
		Me.Label91.Location = New System.Drawing.Point(1, 265)
		Me.Label91.Name = "Label91"
		Me.Label91.Size = New System.Drawing.Size(118, 41)
		Me.Label91.TabIndex = 111
		Me.Label91.Text = "Sand && Insurance"
		Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label92
		'
		Me.Label92.Location = New System.Drawing.Point(1, 97)
		Me.Label92.Name = "Label92"
		Me.Label92.Size = New System.Drawing.Size(118, 19)
		Me.Label92.TabIndex = 114
		Me.Label92.Text = "Sand dune"
		Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label93
		'
		Me.Label93.Location = New System.Drawing.Point(1, 223)
		Me.Label93.Name = "Label93"
		Me.Label93.Size = New System.Drawing.Size(118, 41)
		Me.Label93.TabIndex = 113
		Me.Label93.Text = "Sand && Evacuation"
		Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23sei
		'
		Me.lblF23sei.Location = New System.Drawing.Point(773, 356)
		Me.lblF23sei.Name = "lblF23sei"
		Me.lblF23sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF23sei.TabIndex = 86
		Me.lblF23sei.Text = "[output]"
		Me.lblF23sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23ei
		'
		Me.lblF23ei.Location = New System.Drawing.Point(773, 321)
		Me.lblF23ei.Name = "lblF23ei"
		Me.lblF23ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF23ei.TabIndex = 83
		Me.lblF23ei.Text = "[output]"
		Me.lblF23ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23si
		'
		Me.lblF23si.Location = New System.Drawing.Point(773, 277)
		Me.lblF23si.Name = "lblF23si"
		Me.lblF23si.Size = New System.Drawing.Size(90, 19)
		Me.lblF23si.TabIndex = 84
		Me.lblF23si.Text = "[output]"
		Me.lblF23si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23se
		'
		Me.lblF23se.Location = New System.Drawing.Point(773, 235)
		Me.lblF23se.Name = "lblF23se"
		Me.lblF23se.Size = New System.Drawing.Size(90, 19)
		Me.lblF23se.TabIndex = 87
		Me.lblF23se.Text = "[output]"
		Me.lblF23se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23i
		'
		Me.lblF23i.Location = New System.Drawing.Point(773, 186)
		Me.lblF23i.Name = "lblF23i"
		Me.lblF23i.Size = New System.Drawing.Size(90, 19)
		Me.lblF23i.TabIndex = 90
		Me.lblF23i.Text = "[output]"
		Me.lblF23i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23e
		'
		Me.lblF23e.Location = New System.Drawing.Point(773, 138)
		Me.lblF23e.Name = "lblF23e"
		Me.lblF23e.Size = New System.Drawing.Size(90, 19)
		Me.lblF23e.TabIndex = 91
		Me.lblF23e.Text = "[output]"
		Me.lblF23e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23s
		'
		Me.lblF23s.Location = New System.Drawing.Point(773, 97)
		Me.lblF23s.Name = "lblF23s"
		Me.lblF23s.Size = New System.Drawing.Size(90, 19)
		Me.lblF23s.TabIndex = 88
		Me.lblF23s.Text = "[output]"
		Me.lblF23s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF23
		'
		Me.lblF23.Location = New System.Drawing.Point(773, 69)
		Me.lblF23.Name = "lblF23"
		Me.lblF23.Size = New System.Drawing.Size(90, 19)
		Me.lblF23.TabIndex = 89
		Me.lblF23.Text = "[output]"
		Me.lblF23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13sei
		'
		Me.lblF13sei.Location = New System.Drawing.Point(667, 356)
		Me.lblF13sei.Name = "lblF13sei"
		Me.lblF13sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF13sei.TabIndex = 77
		Me.lblF13sei.Text = "[output]"
		Me.lblF13sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13ei
		'
		Me.lblF13ei.Location = New System.Drawing.Point(667, 321)
		Me.lblF13ei.Name = "lblF13ei"
		Me.lblF13ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF13ei.TabIndex = 74
		Me.lblF13ei.Text = "[output]"
		Me.lblF13ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13si
		'
		Me.lblF13si.Location = New System.Drawing.Point(667, 277)
		Me.lblF13si.Name = "lblF13si"
		Me.lblF13si.Size = New System.Drawing.Size(90, 19)
		Me.lblF13si.TabIndex = 75
		Me.lblF13si.Text = "[output]"
		Me.lblF13si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13se
		'
		Me.lblF13se.Location = New System.Drawing.Point(667, 235)
		Me.lblF13se.Name = "lblF13se"
		Me.lblF13se.Size = New System.Drawing.Size(90, 19)
		Me.lblF13se.TabIndex = 78
		Me.lblF13se.Text = "[output]"
		Me.lblF13se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13i
		'
		Me.lblF13i.Location = New System.Drawing.Point(667, 186)
		Me.lblF13i.Name = "lblF13i"
		Me.lblF13i.Size = New System.Drawing.Size(90, 19)
		Me.lblF13i.TabIndex = 81
		Me.lblF13i.Text = "[output]"
		Me.lblF13i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13e
		'
		Me.lblF13e.Location = New System.Drawing.Point(667, 138)
		Me.lblF13e.Name = "lblF13e"
		Me.lblF13e.Size = New System.Drawing.Size(90, 19)
		Me.lblF13e.TabIndex = 82
		Me.lblF13e.Text = "[output]"
		Me.lblF13e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13s
		'
		Me.lblF13s.Location = New System.Drawing.Point(667, 97)
		Me.lblF13s.Name = "lblF13s"
		Me.lblF13s.Size = New System.Drawing.Size(90, 19)
		Me.lblF13s.TabIndex = 79
		Me.lblF13s.Text = "[output]"
		Me.lblF13s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13
		'
		Me.lblF13.Location = New System.Drawing.Point(667, 69)
		Me.lblF13.Name = "lblF13"
		Me.lblF13.Size = New System.Drawing.Size(90, 19)
		Me.lblF13.TabIndex = 80
		Me.lblF13.Text = "[output]"
		Me.lblF13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22sei
		'
		Me.lblF22sei.Location = New System.Drawing.Point(561, 356)
		Me.lblF22sei.Name = "lblF22sei"
		Me.lblF22sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF22sei.TabIndex = 104
		Me.lblF22sei.Text = "[output]"
		Me.lblF22sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22ei
		'
		Me.lblF22ei.Location = New System.Drawing.Point(561, 321)
		Me.lblF22ei.Name = "lblF22ei"
		Me.lblF22ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF22ei.TabIndex = 101
		Me.lblF22ei.Text = "[output]"
		Me.lblF22ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22si
		'
		Me.lblF22si.Location = New System.Drawing.Point(561, 277)
		Me.lblF22si.Name = "lblF22si"
		Me.lblF22si.Size = New System.Drawing.Size(90, 19)
		Me.lblF22si.TabIndex = 102
		Me.lblF22si.Text = "[output]"
		Me.lblF22si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22se
		'
		Me.lblF22se.Location = New System.Drawing.Point(561, 235)
		Me.lblF22se.Name = "lblF22se"
		Me.lblF22se.Size = New System.Drawing.Size(90, 19)
		Me.lblF22se.TabIndex = 107
		Me.lblF22se.Text = "[output]"
		Me.lblF22se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22i
		'
		Me.lblF22i.Location = New System.Drawing.Point(561, 186)
		Me.lblF22i.Name = "lblF22i"
		Me.lblF22i.Size = New System.Drawing.Size(90, 19)
		Me.lblF22i.TabIndex = 108
		Me.lblF22i.Text = "[output]"
		Me.lblF22i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22e
		'
		Me.lblF22e.Location = New System.Drawing.Point(561, 138)
		Me.lblF22e.Name = "lblF22e"
		Me.lblF22e.Size = New System.Drawing.Size(90, 19)
		Me.lblF22e.TabIndex = 105
		Me.lblF22e.Text = "[output]"
		Me.lblF22e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22s
		'
		Me.lblF22s.Location = New System.Drawing.Point(561, 97)
		Me.lblF22s.Name = "lblF22s"
		Me.lblF22s.Size = New System.Drawing.Size(90, 19)
		Me.lblF22s.TabIndex = 106
		Me.lblF22s.Text = "[output]"
		Me.lblF22s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF22
		'
		Me.lblF22.Location = New System.Drawing.Point(561, 69)
		Me.lblF22.Name = "lblF22"
		Me.lblF22.Size = New System.Drawing.Size(90, 19)
		Me.lblF22.TabIndex = 100
		Me.lblF22.Text = "[output]"
		Me.lblF22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12sei
		'
		Me.lblF12sei.Location = New System.Drawing.Point(455, 356)
		Me.lblF12sei.Name = "lblF12sei"
		Me.lblF12sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF12sei.TabIndex = 95
		Me.lblF12sei.Text = "[output]"
		Me.lblF12sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12ei
		'
		Me.lblF12ei.Location = New System.Drawing.Point(455, 321)
		Me.lblF12ei.Name = "lblF12ei"
		Me.lblF12ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF12ei.TabIndex = 92
		Me.lblF12ei.Text = "[output]"
		Me.lblF12ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12si
		'
		Me.lblF12si.Location = New System.Drawing.Point(455, 277)
		Me.lblF12si.Name = "lblF12si"
		Me.lblF12si.Size = New System.Drawing.Size(90, 19)
		Me.lblF12si.TabIndex = 93
		Me.lblF12si.Text = "[output]"
		Me.lblF12si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12se
		'
		Me.lblF12se.Location = New System.Drawing.Point(455, 235)
		Me.lblF12se.Name = "lblF12se"
		Me.lblF12se.Size = New System.Drawing.Size(90, 19)
		Me.lblF12se.TabIndex = 98
		Me.lblF12se.Text = "[output]"
		Me.lblF12se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12i
		'
		Me.lblF12i.Location = New System.Drawing.Point(455, 186)
		Me.lblF12i.Name = "lblF12i"
		Me.lblF12i.Size = New System.Drawing.Size(90, 19)
		Me.lblF12i.TabIndex = 99
		Me.lblF12i.Text = "[output]"
		Me.lblF12i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12e
		'
		Me.lblF12e.Location = New System.Drawing.Point(455, 138)
		Me.lblF12e.Name = "lblF12e"
		Me.lblF12e.Size = New System.Drawing.Size(90, 19)
		Me.lblF12e.TabIndex = 96
		Me.lblF12e.Text = "[output]"
		Me.lblF12e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12s
		'
		Me.lblF12s.Location = New System.Drawing.Point(455, 97)
		Me.lblF12s.Name = "lblF12s"
		Me.lblF12s.Size = New System.Drawing.Size(90, 19)
		Me.lblF12s.TabIndex = 97
		Me.lblF12s.Text = "[output]"
		Me.lblF12s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF12
		'
		Me.lblF12.Location = New System.Drawing.Point(455, 69)
		Me.lblF12.Name = "lblF12"
		Me.lblF12.Size = New System.Drawing.Size(90, 19)
		Me.lblF12.TabIndex = 48
		Me.lblF12.Text = "[output]"
		Me.lblF12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31sei
		'
		Me.lblF31sei.Location = New System.Drawing.Point(349, 356)
		Me.lblF31sei.Name = "lblF31sei"
		Me.lblF31sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF31sei.TabIndex = 49
		Me.lblF31sei.Text = "[output]"
		Me.lblF31sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31ei
		'
		Me.lblF31ei.Location = New System.Drawing.Point(349, 321)
		Me.lblF31ei.Name = "lblF31ei"
		Me.lblF31ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF31ei.TabIndex = 85
		Me.lblF31ei.Text = "[output]"
		Me.lblF31ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31si
		'
		Me.lblF31si.Location = New System.Drawing.Point(349, 277)
		Me.lblF31si.Name = "lblF31si"
		Me.lblF31si.Size = New System.Drawing.Size(90, 19)
		Me.lblF31si.TabIndex = 47
		Me.lblF31si.Text = "[output]"
		Me.lblF31si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31se
		'
		Me.lblF31se.Location = New System.Drawing.Point(349, 235)
		Me.lblF31se.Name = "lblF31se"
		Me.lblF31se.Size = New System.Drawing.Size(90, 19)
		Me.lblF31se.TabIndex = 50
		Me.lblF31se.Text = "[output]"
		Me.lblF31se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31i
		'
		Me.lblF31i.Location = New System.Drawing.Point(349, 186)
		Me.lblF31i.Name = "lblF31i"
		Me.lblF31i.Size = New System.Drawing.Size(90, 19)
		Me.lblF31i.TabIndex = 53
		Me.lblF31i.Text = "[output]"
		Me.lblF31i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31e
		'
		Me.lblF31e.Location = New System.Drawing.Point(349, 138)
		Me.lblF31e.Name = "lblF31e"
		Me.lblF31e.Size = New System.Drawing.Size(90, 19)
		Me.lblF31e.TabIndex = 54
		Me.lblF31e.Text = "[output]"
		Me.lblF31e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31s
		'
		Me.lblF31s.Location = New System.Drawing.Point(349, 97)
		Me.lblF31s.Name = "lblF31s"
		Me.lblF31s.Size = New System.Drawing.Size(90, 19)
		Me.lblF31s.TabIndex = 51
		Me.lblF31s.Text = "[output]"
		Me.lblF31s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF31
		'
		Me.lblF31.Location = New System.Drawing.Point(349, 69)
		Me.lblF31.Name = "lblF31"
		Me.lblF31.Size = New System.Drawing.Size(90, 19)
		Me.lblF31.TabIndex = 52
		Me.lblF31.Text = "[output]"
		Me.lblF31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21sei
		'
		Me.lblF21sei.Location = New System.Drawing.Point(243, 356)
		Me.lblF21sei.Name = "lblF21sei"
		Me.lblF21sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF21sei.TabIndex = 40
		Me.lblF21sei.Text = "[output]"
		Me.lblF21sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21ei
		'
		Me.lblF21ei.Location = New System.Drawing.Point(243, 321)
		Me.lblF21ei.Name = "lblF21ei"
		Me.lblF21ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF21ei.TabIndex = 37
		Me.lblF21ei.Text = "[output]"
		Me.lblF21ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21si
		'
		Me.lblF21si.Location = New System.Drawing.Point(243, 277)
		Me.lblF21si.Name = "lblF21si"
		Me.lblF21si.Size = New System.Drawing.Size(90, 19)
		Me.lblF21si.TabIndex = 38
		Me.lblF21si.Text = "[output]"
		Me.lblF21si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21se
		'
		Me.lblF21se.Location = New System.Drawing.Point(243, 235)
		Me.lblF21se.Name = "lblF21se"
		Me.lblF21se.Size = New System.Drawing.Size(90, 19)
		Me.lblF21se.TabIndex = 41
		Me.lblF21se.Text = "[output]"
		Me.lblF21se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21i
		'
		Me.lblF21i.Location = New System.Drawing.Point(243, 186)
		Me.lblF21i.Name = "lblF21i"
		Me.lblF21i.Size = New System.Drawing.Size(90, 19)
		Me.lblF21i.TabIndex = 44
		Me.lblF21i.Text = "[output]"
		Me.lblF21i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21e
		'
		Me.lblF21e.Location = New System.Drawing.Point(243, 138)
		Me.lblF21e.Name = "lblF21e"
		Me.lblF21e.Size = New System.Drawing.Size(90, 19)
		Me.lblF21e.TabIndex = 45
		Me.lblF21e.Text = "[output]"
		Me.lblF21e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21s
		'
		Me.lblF21s.Location = New System.Drawing.Point(243, 97)
		Me.lblF21s.Name = "lblF21s"
		Me.lblF21s.Size = New System.Drawing.Size(90, 19)
		Me.lblF21s.TabIndex = 42
		Me.lblF21s.Text = "[output]"
		Me.lblF21s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF21
		'
		Me.lblF21.Location = New System.Drawing.Point(243, 69)
		Me.lblF21.Name = "lblF21"
		Me.lblF21.Size = New System.Drawing.Size(90, 19)
		Me.lblF21.TabIndex = 43
		Me.lblF21.Text = "[output]"
		Me.lblF21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11sei
		'
		Me.lblF11sei.Location = New System.Drawing.Point(137, 356)
		Me.lblF11sei.Name = "lblF11sei"
		Me.lblF11sei.Size = New System.Drawing.Size(90, 19)
		Me.lblF11sei.TabIndex = 67
		Me.lblF11sei.Text = "[output]"
		Me.lblF11sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11ei
		'
		Me.lblF11ei.Location = New System.Drawing.Point(137, 321)
		Me.lblF11ei.Name = "lblF11ei"
		Me.lblF11ei.Size = New System.Drawing.Size(90, 19)
		Me.lblF11ei.TabIndex = 68
		Me.lblF11ei.Text = "[output]"
		Me.lblF11ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11si
		'
		Me.lblF11si.Location = New System.Drawing.Point(137, 277)
		Me.lblF11si.Name = "lblF11si"
		Me.lblF11si.Size = New System.Drawing.Size(90, 19)
		Me.lblF11si.TabIndex = 65
		Me.lblF11si.Text = "[output]"
		Me.lblF11si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11se
		'
		Me.lblF11se.Location = New System.Drawing.Point(137, 235)
		Me.lblF11se.Name = "lblF11se"
		Me.lblF11se.Size = New System.Drawing.Size(90, 19)
		Me.lblF11se.TabIndex = 66
		Me.lblF11se.Text = "[output]"
		Me.lblF11se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11i
		'
		Me.lblF11i.Location = New System.Drawing.Point(137, 186)
		Me.lblF11i.Name = "lblF11i"
		Me.lblF11i.Size = New System.Drawing.Size(90, 19)
		Me.lblF11i.TabIndex = 69
		Me.lblF11i.Text = "[output]"
		Me.lblF11i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11e
		'
		Me.lblF11e.Location = New System.Drawing.Point(137, 138)
		Me.lblF11e.Name = "lblF11e"
		Me.lblF11e.Size = New System.Drawing.Size(90, 19)
		Me.lblF11e.TabIndex = 72
		Me.lblF11e.Text = "[output]"
		Me.lblF11e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11s
		'
		Me.lblF11s.Location = New System.Drawing.Point(137, 97)
		Me.lblF11s.Name = "lblF11s"
		Me.lblF11s.Size = New System.Drawing.Size(90, 19)
		Me.lblF11s.TabIndex = 73
		Me.lblF11s.Text = "[output]"
		Me.lblF11s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF11
		'
		Me.lblF11.Location = New System.Drawing.Point(137, 69)
		Me.lblF11.Name = "lblF11"
		Me.lblF11.Size = New System.Drawing.Size(90, 19)
		Me.lblF11.TabIndex = 70
		Me.lblF11.Text = "[output]"
		Me.lblF11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label102
		'
		Me.Label102.Location = New System.Drawing.Point(1, 69)
		Me.Label102.Name = "Label102"
		Me.Label102.Size = New System.Drawing.Size(118, 19)
		Me.Label102.TabIndex = 58
		Me.Label102.Text = "No MOs or ROs"
		Me.Label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label106
		'
		Me.Label106.Location = New System.Drawing.Point(455, 40)
		Me.Label106.Name = "Label106"
		Me.Label106.Size = New System.Drawing.Size(90, 19)
		Me.Label106.TabIndex = 59
		Me.Label106.Text = "%"
		Me.Label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label105
		'
		Me.Label105.Location = New System.Drawing.Point(349, 40)
		Me.Label105.Name = "Label105"
		Me.Label105.Size = New System.Drawing.Size(90, 19)
		Me.Label105.TabIndex = 56
		Me.Label105.Text = "N to P"
		Me.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label109
		'
		Me.Label109.Location = New System.Drawing.Point(773, 40)
		Me.Label109.Name = "Label109"
		Me.Label109.Size = New System.Drawing.Size(90, 19)
		Me.Label109.TabIndex = 57
		Me.Label109.Text = "N to P"
		Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label108
		'
		Me.Label108.Location = New System.Drawing.Point(667, 40)
		Me.Label108.Name = "Label108"
		Me.Label108.Size = New System.Drawing.Size(90, 19)
		Me.Label108.TabIndex = 60
		Me.Label108.Text = "N to P"
		Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label107
		'
		Me.Label107.Location = New System.Drawing.Point(561, 40)
		Me.Label107.Name = "Label107"
		Me.Label107.Size = New System.Drawing.Size(90, 19)
		Me.Label107.TabIndex = 63
		Me.Label107.Text = "N to P"
		Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label104
		'
		Me.Label104.Location = New System.Drawing.Point(243, 40)
		Me.Label104.Name = "Label104"
		Me.Label104.Size = New System.Drawing.Size(90, 19)
		Me.Label104.TabIndex = 64
		Me.Label104.Text = "N to P"
		Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label103
		'
		Me.Label103.Location = New System.Drawing.Point(137, 40)
		Me.Label103.Name = "Label103"
		Me.Label103.Size = New System.Drawing.Size(90, 19)
		Me.Label103.TabIndex = 61
		Me.Label103.Text = "Mil €/year"
		Me.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label95
		'
		Me.Label95.Location = New System.Drawing.Point(773, 11)
		Me.Label95.Name = "Label95"
		Me.Label95.Size = New System.Drawing.Size(90, 28)
		Me.Label95.TabIndex = 112
		Me.Label95.Text = "Social distress"
		Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label96
		'
		Me.Label96.Location = New System.Drawing.Point(667, 10)
		Me.Label96.Name = "Label96"
		Me.Label96.Size = New System.Drawing.Size(90, 28)
		Me.Label96.TabIndex = 117
		Me.Label96.Text = "Health distress"
		Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label97
		'
		Me.Label97.Location = New System.Drawing.Point(561, 11)
		Me.Label97.Name = "Label97"
		Me.Label97.Size = New System.Drawing.Size(90, 28)
		Me.Label97.TabIndex = 118
		Me.Label97.Text = "Habitat worsening"
		Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label98
		'
		Me.Label98.Location = New System.Drawing.Point(455, 11)
		Me.Label98.Name = "Label98"
		Me.Label98.Size = New System.Drawing.Size(90, 28)
		Me.Label98.TabIndex = 115
		Me.Label98.Text = "Species worsening"
		Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label99
		'
		Me.Label99.Location = New System.Drawing.Point(349, 9)
		Me.Label99.Name = "Label99"
		Me.Label99.Size = New System.Drawing.Size(90, 28)
		Me.Label99.TabIndex = 116
		Me.Label99.Text = "Landscape worsening"
		Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label100
		'
		Me.Label100.Location = New System.Drawing.Point(243, 9)
		Me.Label100.Name = "Label100"
		Me.Label100.Size = New System.Drawing.Size(90, 28)
		Me.Label100.TabIndex = 34
		Me.Label100.Text = "Employment reduction"
		Me.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label101
		'
		Me.Label101.Location = New System.Drawing.Point(137, 9)
		Me.Label101.Name = "Label101"
		Me.Label101.Size = New System.Drawing.Size(90, 28)
		Me.Label101.TabIndex = 35
		Me.Label101.Text = "Economic damage"
		Me.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tpaResilience
		'
		Me.tpaResilience.Controls.Add(Me.Label110)
		Me.tpaResilience.Controls.Add(Me.Label111)
		Me.tpaResilience.Controls.Add(Me.Label112)
		Me.tpaResilience.Controls.Add(Me.Label113)
		Me.tpaResilience.Controls.Add(Me.Label114)
		Me.tpaResilience.Controls.Add(Me.Label115)
		Me.tpaResilience.Controls.Add(Me.Label116)
		Me.tpaResilience.Controls.Add(Me.lblR23sei)
		Me.tpaResilience.Controls.Add(Me.lblR23ei)
		Me.tpaResilience.Controls.Add(Me.lblR23si)
		Me.tpaResilience.Controls.Add(Me.lblR23se)
		Me.tpaResilience.Controls.Add(Me.lblR23i)
		Me.tpaResilience.Controls.Add(Me.lblR23e)
		Me.tpaResilience.Controls.Add(Me.lblR23s)
		Me.tpaResilience.Controls.Add(Me.lblR23)
		Me.tpaResilience.Controls.Add(Me.lblR13sei)
		Me.tpaResilience.Controls.Add(Me.lblR13ei)
		Me.tpaResilience.Controls.Add(Me.lblR13si)
		Me.tpaResilience.Controls.Add(Me.lblR13se)
		Me.tpaResilience.Controls.Add(Me.lblR13i)
		Me.tpaResilience.Controls.Add(Me.lblR13e)
		Me.tpaResilience.Controls.Add(Me.lblR13s)
		Me.tpaResilience.Controls.Add(Me.lblR13)
		Me.tpaResilience.Controls.Add(Me.lblR22sei)
		Me.tpaResilience.Controls.Add(Me.lblR22ei)
		Me.tpaResilience.Controls.Add(Me.lblR22si)
		Me.tpaResilience.Controls.Add(Me.lblR22se)
		Me.tpaResilience.Controls.Add(Me.lblR22i)
		Me.tpaResilience.Controls.Add(Me.lblR22e)
		Me.tpaResilience.Controls.Add(Me.lblR22s)
		Me.tpaResilience.Controls.Add(Me.lblR22)
		Me.tpaResilience.Controls.Add(Me.lblR12sei)
		Me.tpaResilience.Controls.Add(Me.lblR12ei)
		Me.tpaResilience.Controls.Add(Me.lblR12si)
		Me.tpaResilience.Controls.Add(Me.lblR12se)
		Me.tpaResilience.Controls.Add(Me.lblR12i)
		Me.tpaResilience.Controls.Add(Me.lblR12e)
		Me.tpaResilience.Controls.Add(Me.lblR12s)
		Me.tpaResilience.Controls.Add(Me.lblR12)
		Me.tpaResilience.Controls.Add(Me.lblR31sei)
		Me.tpaResilience.Controls.Add(Me.lblR31ei)
		Me.tpaResilience.Controls.Add(Me.lblR31si)
		Me.tpaResilience.Controls.Add(Me.lblR31se)
		Me.tpaResilience.Controls.Add(Me.lblR31i)
		Me.tpaResilience.Controls.Add(Me.lblR31e)
		Me.tpaResilience.Controls.Add(Me.lblR31s)
		Me.tpaResilience.Controls.Add(Me.lblR31)
		Me.tpaResilience.Controls.Add(Me.lblR21sei)
		Me.tpaResilience.Controls.Add(Me.lblR21ei)
		Me.tpaResilience.Controls.Add(Me.lblR21si)
		Me.tpaResilience.Controls.Add(Me.lblR21se)
		Me.tpaResilience.Controls.Add(Me.lblR21i)
		Me.tpaResilience.Controls.Add(Me.lblR21e)
		Me.tpaResilience.Controls.Add(Me.lblR21s)
		Me.tpaResilience.Controls.Add(Me.lblR21)
		Me.tpaResilience.Controls.Add(Me.lblR11sei)
		Me.tpaResilience.Controls.Add(Me.lblR11ei)
		Me.tpaResilience.Controls.Add(Me.lblR11si)
		Me.tpaResilience.Controls.Add(Me.lblR11se)
		Me.tpaResilience.Controls.Add(Me.lblR11i)
		Me.tpaResilience.Controls.Add(Me.lblR11e)
		Me.tpaResilience.Controls.Add(Me.lblR11s)
		Me.tpaResilience.Controls.Add(Me.lblR11)
		Me.tpaResilience.Controls.Add(Me.Label176)
		Me.tpaResilience.Controls.Add(Me.Label177)
		Me.tpaResilience.Controls.Add(Me.Label178)
		Me.tpaResilience.Controls.Add(Me.Label179)
		Me.tpaResilience.Controls.Add(Me.Label180)
		Me.tpaResilience.Controls.Add(Me.Label181)
		Me.tpaResilience.Controls.Add(Me.Label182)
		Me.tpaResilience.Controls.Add(Me.Label183)
		Me.tpaResilience.Controls.Add(Me.Label185)
		Me.tpaResilience.Controls.Add(Me.Label186)
		Me.tpaResilience.Controls.Add(Me.Label187)
		Me.tpaResilience.Controls.Add(Me.Label188)
		Me.tpaResilience.Controls.Add(Me.Label189)
		Me.tpaResilience.Controls.Add(Me.Label190)
		Me.tpaResilience.Controls.Add(Me.Label191)
		Me.tpaResilience.Location = New System.Drawing.Point(4, 22)
		Me.tpaResilience.Name = "tpaResilience"
		Me.tpaResilience.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaResilience.Size = New System.Drawing.Size(865, 442)
		Me.tpaResilience.TabIndex = 7
		Me.tpaResilience.Text = "Resilience"
		Me.tpaResilience.UseVisualStyleBackColor = True
		'
		'Label110
		'
		Me.Label110.Location = New System.Drawing.Point(1, 349)
		Me.Label110.Name = "Label110"
		Me.Label110.Size = New System.Drawing.Size(118, 41)
		Me.Label110.TabIndex = 122
		Me.Label110.Text = "Sand && Evacuation && Insurance"
		Me.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label111
		'
		Me.Label111.Location = New System.Drawing.Point(1, 181)
		Me.Label111.Name = "Label111"
		Me.Label111.Size = New System.Drawing.Size(118, 19)
		Me.Label111.TabIndex = 189
		Me.Label111.Text = "Insurance scheme"
		Me.Label111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label112
		'
		Me.Label112.Location = New System.Drawing.Point(1, 307)
		Me.Label112.Name = "Label112"
		Me.Label112.Size = New System.Drawing.Size(118, 41)
		Me.Label112.TabIndex = 188
		Me.Label112.Text = "Evacuation && Insurance"
		Me.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label113
		'
		Me.Label113.Location = New System.Drawing.Point(1, 139)
		Me.Label113.Name = "Label113"
		Me.Label113.Size = New System.Drawing.Size(118, 19)
		Me.Label113.TabIndex = 119
		Me.Label113.Text = "Evacuation plan"
		Me.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label114
		'
		Me.Label114.Location = New System.Drawing.Point(1, 265)
		Me.Label114.Name = "Label114"
		Me.Label114.Size = New System.Drawing.Size(118, 41)
		Me.Label114.TabIndex = 190
		Me.Label114.Text = "Sand && Insurance"
		Me.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label115
		'
		Me.Label115.Location = New System.Drawing.Point(1, 97)
		Me.Label115.Name = "Label115"
		Me.Label115.Size = New System.Drawing.Size(118, 19)
		Me.Label115.TabIndex = 193
		Me.Label115.Text = "Sand dune"
		Me.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label116
		'
		Me.Label116.Location = New System.Drawing.Point(1, 223)
		Me.Label116.Name = "Label116"
		Me.Label116.Size = New System.Drawing.Size(118, 41)
		Me.Label116.TabIndex = 192
		Me.Label116.Text = "Sand && Evacuation"
		Me.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23sei
		'
		Me.lblR23sei.Location = New System.Drawing.Point(773, 356)
		Me.lblR23sei.Name = "lblR23sei"
		Me.lblR23sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR23sei.TabIndex = 167
		Me.lblR23sei.Text = "[output]"
		Me.lblR23sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23ei
		'
		Me.lblR23ei.Location = New System.Drawing.Point(773, 321)
		Me.lblR23ei.Name = "lblR23ei"
		Me.lblR23ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR23ei.TabIndex = 164
		Me.lblR23ei.Text = "[output]"
		Me.lblR23ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23si
		'
		Me.lblR23si.Location = New System.Drawing.Point(773, 277)
		Me.lblR23si.Name = "lblR23si"
		Me.lblR23si.Size = New System.Drawing.Size(90, 19)
		Me.lblR23si.TabIndex = 165
		Me.lblR23si.Text = "[output]"
		Me.lblR23si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23se
		'
		Me.lblR23se.Location = New System.Drawing.Point(773, 235)
		Me.lblR23se.Name = "lblR23se"
		Me.lblR23se.Size = New System.Drawing.Size(90, 19)
		Me.lblR23se.TabIndex = 168
		Me.lblR23se.Text = "[output]"
		Me.lblR23se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23i
		'
		Me.lblR23i.Location = New System.Drawing.Point(773, 186)
		Me.lblR23i.Name = "lblR23i"
		Me.lblR23i.Size = New System.Drawing.Size(90, 19)
		Me.lblR23i.TabIndex = 171
		Me.lblR23i.Text = "[output]"
		Me.lblR23i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23e
		'
		Me.lblR23e.Location = New System.Drawing.Point(773, 138)
		Me.lblR23e.Name = "lblR23e"
		Me.lblR23e.Size = New System.Drawing.Size(90, 19)
		Me.lblR23e.TabIndex = 172
		Me.lblR23e.Text = "[output]"
		Me.lblR23e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23s
		'
		Me.lblR23s.Location = New System.Drawing.Point(773, 97)
		Me.lblR23s.Name = "lblR23s"
		Me.lblR23s.Size = New System.Drawing.Size(90, 19)
		Me.lblR23s.TabIndex = 169
		Me.lblR23s.Text = "[output]"
		Me.lblR23s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR23
		'
		Me.lblR23.Location = New System.Drawing.Point(773, 69)
		Me.lblR23.Name = "lblR23"
		Me.lblR23.Size = New System.Drawing.Size(90, 19)
		Me.lblR23.TabIndex = 170
		Me.lblR23.Text = "[output]"
		Me.lblR23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13sei
		'
		Me.lblR13sei.Location = New System.Drawing.Point(667, 356)
		Me.lblR13sei.Name = "lblR13sei"
		Me.lblR13sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR13sei.TabIndex = 158
		Me.lblR13sei.Text = "[output]"
		Me.lblR13sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13ei
		'
		Me.lblR13ei.Location = New System.Drawing.Point(667, 321)
		Me.lblR13ei.Name = "lblR13ei"
		Me.lblR13ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR13ei.TabIndex = 156
		Me.lblR13ei.Text = "[output]"
		Me.lblR13ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13si
		'
		Me.lblR13si.Location = New System.Drawing.Point(667, 277)
		Me.lblR13si.Name = "lblR13si"
		Me.lblR13si.Size = New System.Drawing.Size(90, 19)
		Me.lblR13si.TabIndex = 157
		Me.lblR13si.Text = "[output]"
		Me.lblR13si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13se
		'
		Me.lblR13se.Location = New System.Drawing.Point(667, 235)
		Me.lblR13se.Name = "lblR13se"
		Me.lblR13se.Size = New System.Drawing.Size(90, 19)
		Me.lblR13se.TabIndex = 159
		Me.lblR13se.Text = "[output]"
		Me.lblR13se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13i
		'
		Me.lblR13i.Location = New System.Drawing.Point(667, 186)
		Me.lblR13i.Name = "lblR13i"
		Me.lblR13i.Size = New System.Drawing.Size(90, 19)
		Me.lblR13i.TabIndex = 162
		Me.lblR13i.Text = "[output]"
		Me.lblR13i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13e
		'
		Me.lblR13e.Location = New System.Drawing.Point(667, 138)
		Me.lblR13e.Name = "lblR13e"
		Me.lblR13e.Size = New System.Drawing.Size(90, 19)
		Me.lblR13e.TabIndex = 163
		Me.lblR13e.Text = "[output]"
		Me.lblR13e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13s
		'
		Me.lblR13s.Location = New System.Drawing.Point(667, 97)
		Me.lblR13s.Name = "lblR13s"
		Me.lblR13s.Size = New System.Drawing.Size(90, 19)
		Me.lblR13s.TabIndex = 160
		Me.lblR13s.Text = "[output]"
		Me.lblR13s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR13
		'
		Me.lblR13.Location = New System.Drawing.Point(667, 69)
		Me.lblR13.Name = "lblR13"
		Me.lblR13.Size = New System.Drawing.Size(90, 19)
		Me.lblR13.TabIndex = 161
		Me.lblR13.Text = "[output]"
		Me.lblR13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22sei
		'
		Me.lblR22sei.Location = New System.Drawing.Point(561, 356)
		Me.lblR22sei.Name = "lblR22sei"
		Me.lblR22sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR22sei.TabIndex = 183
		Me.lblR22sei.Text = "[output]"
		Me.lblR22sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22ei
		'
		Me.lblR22ei.Location = New System.Drawing.Point(561, 321)
		Me.lblR22ei.Name = "lblR22ei"
		Me.lblR22ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR22ei.TabIndex = 181
		Me.lblR22ei.Text = "[output]"
		Me.lblR22ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22si
		'
		Me.lblR22si.Location = New System.Drawing.Point(561, 277)
		Me.lblR22si.Name = "lblR22si"
		Me.lblR22si.Size = New System.Drawing.Size(90, 19)
		Me.lblR22si.TabIndex = 182
		Me.lblR22si.Text = "[output]"
		Me.lblR22si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22se
		'
		Me.lblR22se.Location = New System.Drawing.Point(561, 235)
		Me.lblR22se.Name = "lblR22se"
		Me.lblR22se.Size = New System.Drawing.Size(90, 19)
		Me.lblR22se.TabIndex = 186
		Me.lblR22se.Text = "[output]"
		Me.lblR22se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22i
		'
		Me.lblR22i.Location = New System.Drawing.Point(561, 186)
		Me.lblR22i.Name = "lblR22i"
		Me.lblR22i.Size = New System.Drawing.Size(90, 19)
		Me.lblR22i.TabIndex = 187
		Me.lblR22i.Text = "[output]"
		Me.lblR22i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22e
		'
		Me.lblR22e.Location = New System.Drawing.Point(561, 138)
		Me.lblR22e.Name = "lblR22e"
		Me.lblR22e.Size = New System.Drawing.Size(90, 19)
		Me.lblR22e.TabIndex = 184
		Me.lblR22e.Text = "[output]"
		Me.lblR22e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22s
		'
		Me.lblR22s.Location = New System.Drawing.Point(561, 97)
		Me.lblR22s.Name = "lblR22s"
		Me.lblR22s.Size = New System.Drawing.Size(90, 19)
		Me.lblR22s.TabIndex = 185
		Me.lblR22s.Text = "[output]"
		Me.lblR22s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR22
		'
		Me.lblR22.Location = New System.Drawing.Point(561, 69)
		Me.lblR22.Name = "lblR22"
		Me.lblR22.Size = New System.Drawing.Size(90, 19)
		Me.lblR22.TabIndex = 180
		Me.lblR22.Text = "[output]"
		Me.lblR22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12sei
		'
		Me.lblR12sei.Location = New System.Drawing.Point(455, 356)
		Me.lblR12sei.Name = "lblR12sei"
		Me.lblR12sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR12sei.TabIndex = 175
		Me.lblR12sei.Text = "[output]"
		Me.lblR12sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12ei
		'
		Me.lblR12ei.Location = New System.Drawing.Point(455, 321)
		Me.lblR12ei.Name = "lblR12ei"
		Me.lblR12ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR12ei.TabIndex = 173
		Me.lblR12ei.Text = "[output]"
		Me.lblR12ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12si
		'
		Me.lblR12si.Location = New System.Drawing.Point(455, 277)
		Me.lblR12si.Name = "lblR12si"
		Me.lblR12si.Size = New System.Drawing.Size(90, 19)
		Me.lblR12si.TabIndex = 174
		Me.lblR12si.Text = "[output]"
		Me.lblR12si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12se
		'
		Me.lblR12se.Location = New System.Drawing.Point(455, 235)
		Me.lblR12se.Name = "lblR12se"
		Me.lblR12se.Size = New System.Drawing.Size(90, 19)
		Me.lblR12se.TabIndex = 178
		Me.lblR12se.Text = "[output]"
		Me.lblR12se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12i
		'
		Me.lblR12i.Location = New System.Drawing.Point(455, 186)
		Me.lblR12i.Name = "lblR12i"
		Me.lblR12i.Size = New System.Drawing.Size(90, 19)
		Me.lblR12i.TabIndex = 179
		Me.lblR12i.Text = "[output]"
		Me.lblR12i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12e
		'
		Me.lblR12e.Location = New System.Drawing.Point(455, 138)
		Me.lblR12e.Name = "lblR12e"
		Me.lblR12e.Size = New System.Drawing.Size(90, 19)
		Me.lblR12e.TabIndex = 176
		Me.lblR12e.Text = "[output]"
		Me.lblR12e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12s
		'
		Me.lblR12s.Location = New System.Drawing.Point(455, 97)
		Me.lblR12s.Name = "lblR12s"
		Me.lblR12s.Size = New System.Drawing.Size(90, 19)
		Me.lblR12s.TabIndex = 177
		Me.lblR12s.Text = "[output]"
		Me.lblR12s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR12
		'
		Me.lblR12.Location = New System.Drawing.Point(455, 69)
		Me.lblR12.Name = "lblR12"
		Me.lblR12.Size = New System.Drawing.Size(90, 19)
		Me.lblR12.TabIndex = 132
		Me.lblR12.Text = "[output]"
		Me.lblR12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31sei
		'
		Me.lblR31sei.Location = New System.Drawing.Point(349, 356)
		Me.lblR31sei.Name = "lblR31sei"
		Me.lblR31sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR31sei.TabIndex = 133
		Me.lblR31sei.Text = "[output]"
		Me.lblR31sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31ei
		'
		Me.lblR31ei.Location = New System.Drawing.Point(349, 321)
		Me.lblR31ei.Name = "lblR31ei"
		Me.lblR31ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR31ei.TabIndex = 166
		Me.lblR31ei.Text = "[output]"
		Me.lblR31ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31si
		'
		Me.lblR31si.Location = New System.Drawing.Point(349, 277)
		Me.lblR31si.Name = "lblR31si"
		Me.lblR31si.Size = New System.Drawing.Size(90, 19)
		Me.lblR31si.TabIndex = 131
		Me.lblR31si.Text = "[output]"
		Me.lblR31si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31se
		'
		Me.lblR31se.Location = New System.Drawing.Point(349, 235)
		Me.lblR31se.Name = "lblR31se"
		Me.lblR31se.Size = New System.Drawing.Size(90, 19)
		Me.lblR31se.TabIndex = 134
		Me.lblR31se.Text = "[output]"
		Me.lblR31se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31i
		'
		Me.lblR31i.Location = New System.Drawing.Point(349, 186)
		Me.lblR31i.Name = "lblR31i"
		Me.lblR31i.Size = New System.Drawing.Size(90, 19)
		Me.lblR31i.TabIndex = 137
		Me.lblR31i.Text = "[output]"
		Me.lblR31i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31e
		'
		Me.lblR31e.Location = New System.Drawing.Point(349, 138)
		Me.lblR31e.Name = "lblR31e"
		Me.lblR31e.Size = New System.Drawing.Size(90, 19)
		Me.lblR31e.TabIndex = 138
		Me.lblR31e.Text = "[output]"
		Me.lblR31e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31s
		'
		Me.lblR31s.Location = New System.Drawing.Point(349, 97)
		Me.lblR31s.Name = "lblR31s"
		Me.lblR31s.Size = New System.Drawing.Size(90, 19)
		Me.lblR31s.TabIndex = 135
		Me.lblR31s.Text = "[output]"
		Me.lblR31s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR31
		'
		Me.lblR31.Location = New System.Drawing.Point(349, 69)
		Me.lblR31.Name = "lblR31"
		Me.lblR31.Size = New System.Drawing.Size(90, 19)
		Me.lblR31.TabIndex = 136
		Me.lblR31.Text = "[output]"
		Me.lblR31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21sei
		'
		Me.lblR21sei.Location = New System.Drawing.Point(243, 356)
		Me.lblR21sei.Name = "lblR21sei"
		Me.lblR21sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR21sei.TabIndex = 125
		Me.lblR21sei.Text = "[output]"
		Me.lblR21sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21ei
		'
		Me.lblR21ei.Location = New System.Drawing.Point(243, 321)
		Me.lblR21ei.Name = "lblR21ei"
		Me.lblR21ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR21ei.TabIndex = 123
		Me.lblR21ei.Text = "[output]"
		Me.lblR21ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21si
		'
		Me.lblR21si.Location = New System.Drawing.Point(243, 277)
		Me.lblR21si.Name = "lblR21si"
		Me.lblR21si.Size = New System.Drawing.Size(90, 19)
		Me.lblR21si.TabIndex = 124
		Me.lblR21si.Text = "[output]"
		Me.lblR21si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21se
		'
		Me.lblR21se.Location = New System.Drawing.Point(243, 235)
		Me.lblR21se.Name = "lblR21se"
		Me.lblR21se.Size = New System.Drawing.Size(90, 19)
		Me.lblR21se.TabIndex = 126
		Me.lblR21se.Text = "[output]"
		Me.lblR21se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21i
		'
		Me.lblR21i.Location = New System.Drawing.Point(243, 186)
		Me.lblR21i.Name = "lblR21i"
		Me.lblR21i.Size = New System.Drawing.Size(90, 19)
		Me.lblR21i.TabIndex = 129
		Me.lblR21i.Text = "[output]"
		Me.lblR21i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21e
		'
		Me.lblR21e.Location = New System.Drawing.Point(243, 138)
		Me.lblR21e.Name = "lblR21e"
		Me.lblR21e.Size = New System.Drawing.Size(90, 19)
		Me.lblR21e.TabIndex = 130
		Me.lblR21e.Text = "[output]"
		Me.lblR21e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21s
		'
		Me.lblR21s.Location = New System.Drawing.Point(243, 97)
		Me.lblR21s.Name = "lblR21s"
		Me.lblR21s.Size = New System.Drawing.Size(90, 19)
		Me.lblR21s.TabIndex = 127
		Me.lblR21s.Text = "[output]"
		Me.lblR21s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR21
		'
		Me.lblR21.Location = New System.Drawing.Point(243, 69)
		Me.lblR21.Name = "lblR21"
		Me.lblR21.Size = New System.Drawing.Size(90, 19)
		Me.lblR21.TabIndex = 128
		Me.lblR21.Text = "[output]"
		Me.lblR21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11sei
		'
		Me.lblR11sei.Location = New System.Drawing.Point(137, 356)
		Me.lblR11sei.Name = "lblR11sei"
		Me.lblR11sei.Size = New System.Drawing.Size(90, 19)
		Me.lblR11sei.TabIndex = 150
		Me.lblR11sei.Text = "[output]"
		Me.lblR11sei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11ei
		'
		Me.lblR11ei.Location = New System.Drawing.Point(137, 321)
		Me.lblR11ei.Name = "lblR11ei"
		Me.lblR11ei.Size = New System.Drawing.Size(90, 19)
		Me.lblR11ei.TabIndex = 151
		Me.lblR11ei.Text = "[output]"
		Me.lblR11ei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11si
		'
		Me.lblR11si.Location = New System.Drawing.Point(137, 277)
		Me.lblR11si.Name = "lblR11si"
		Me.lblR11si.Size = New System.Drawing.Size(90, 19)
		Me.lblR11si.TabIndex = 148
		Me.lblR11si.Text = "[output]"
		Me.lblR11si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11se
		'
		Me.lblR11se.Location = New System.Drawing.Point(137, 235)
		Me.lblR11se.Name = "lblR11se"
		Me.lblR11se.Size = New System.Drawing.Size(90, 19)
		Me.lblR11se.TabIndex = 149
		Me.lblR11se.Text = "[output]"
		Me.lblR11se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11i
		'
		Me.lblR11i.Location = New System.Drawing.Point(137, 186)
		Me.lblR11i.Name = "lblR11i"
		Me.lblR11i.Size = New System.Drawing.Size(90, 19)
		Me.lblR11i.TabIndex = 152
		Me.lblR11i.Text = "[output]"
		Me.lblR11i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11e
		'
		Me.lblR11e.Location = New System.Drawing.Point(137, 138)
		Me.lblR11e.Name = "lblR11e"
		Me.lblR11e.Size = New System.Drawing.Size(90, 19)
		Me.lblR11e.TabIndex = 154
		Me.lblR11e.Text = "[output]"
		Me.lblR11e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11s
		'
		Me.lblR11s.Location = New System.Drawing.Point(137, 97)
		Me.lblR11s.Name = "lblR11s"
		Me.lblR11s.Size = New System.Drawing.Size(90, 19)
		Me.lblR11s.TabIndex = 155
		Me.lblR11s.Text = "[output]"
		Me.lblR11s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblR11
		'
		Me.lblR11.Location = New System.Drawing.Point(137, 69)
		Me.lblR11.Name = "lblR11"
		Me.lblR11.Size = New System.Drawing.Size(90, 19)
		Me.lblR11.TabIndex = 153
		Me.lblR11.Text = "[output]"
		Me.lblR11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label176
		'
		Me.Label176.Location = New System.Drawing.Point(1, 69)
		Me.Label176.Name = "Label176"
		Me.Label176.Size = New System.Drawing.Size(118, 19)
		Me.Label176.TabIndex = 141
		Me.Label176.Text = "No MOs or ROs"
		Me.Label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label177
		'
		Me.Label177.Location = New System.Drawing.Point(455, 40)
		Me.Label177.Name = "Label177"
		Me.Label177.Size = New System.Drawing.Size(90, 19)
		Me.Label177.TabIndex = 142
		Me.Label177.Text = "{0,1}"
		Me.Label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label178
		'
		Me.Label178.Location = New System.Drawing.Point(349, 40)
		Me.Label178.Name = "Label178"
		Me.Label178.Size = New System.Drawing.Size(90, 19)
		Me.Label178.TabIndex = 139
		Me.Label178.Text = "{0,1}"
		Me.Label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label179
		'
		Me.Label179.Location = New System.Drawing.Point(773, 40)
		Me.Label179.Name = "Label179"
		Me.Label179.Size = New System.Drawing.Size(90, 19)
		Me.Label179.TabIndex = 140
		Me.Label179.Text = "{0,1}"
		Me.Label179.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label180
		'
		Me.Label180.Location = New System.Drawing.Point(667, 40)
		Me.Label180.Name = "Label180"
		Me.Label180.Size = New System.Drawing.Size(90, 19)
		Me.Label180.TabIndex = 143
		Me.Label180.Text = "{0,1}"
		Me.Label180.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label181
		'
		Me.Label181.Location = New System.Drawing.Point(561, 40)
		Me.Label181.Name = "Label181"
		Me.Label181.Size = New System.Drawing.Size(90, 19)
		Me.Label181.TabIndex = 146
		Me.Label181.Text = "{0,1}"
		Me.Label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label182
		'
		Me.Label182.Location = New System.Drawing.Point(243, 40)
		Me.Label182.Name = "Label182"
		Me.Label182.Size = New System.Drawing.Size(90, 19)
		Me.Label182.TabIndex = 147
		Me.Label182.Text = "{0,1}"
		Me.Label182.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label183
		'
		Me.Label183.Location = New System.Drawing.Point(137, 40)
		Me.Label183.Name = "Label183"
		Me.Label183.Size = New System.Drawing.Size(90, 19)
		Me.Label183.TabIndex = 144
		Me.Label183.Text = "{0,1}"
		Me.Label183.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label185
		'
		Me.Label185.Location = New System.Drawing.Point(773, 11)
		Me.Label185.Name = "Label185"
		Me.Label185.Size = New System.Drawing.Size(90, 28)
		Me.Label185.TabIndex = 191
		Me.Label185.Text = "Social distress"
		Me.Label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label186
		'
		Me.Label186.Location = New System.Drawing.Point(667, 10)
		Me.Label186.Name = "Label186"
		Me.Label186.Size = New System.Drawing.Size(90, 28)
		Me.Label186.TabIndex = 196
		Me.Label186.Text = "Health distress"
		Me.Label186.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label187
		'
		Me.Label187.Location = New System.Drawing.Point(561, 11)
		Me.Label187.Name = "Label187"
		Me.Label187.Size = New System.Drawing.Size(90, 28)
		Me.Label187.TabIndex = 197
		Me.Label187.Text = "Habitat worsening"
		Me.Label187.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label188
		'
		Me.Label188.Location = New System.Drawing.Point(455, 11)
		Me.Label188.Name = "Label188"
		Me.Label188.Size = New System.Drawing.Size(90, 28)
		Me.Label188.TabIndex = 194
		Me.Label188.Text = "Species worsening"
		Me.Label188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label189
		'
		Me.Label189.Location = New System.Drawing.Point(349, 9)
		Me.Label189.Name = "Label189"
		Me.Label189.Size = New System.Drawing.Size(90, 28)
		Me.Label189.TabIndex = 195
		Me.Label189.Text = "Landscape worsening"
		Me.Label189.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label190
		'
		Me.Label190.Location = New System.Drawing.Point(243, 9)
		Me.Label190.Name = "Label190"
		Me.Label190.Size = New System.Drawing.Size(90, 28)
		Me.Label190.TabIndex = 120
		Me.Label190.Text = "Employment reduction"
		Me.Label190.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label191
		'
		Me.Label191.Location = New System.Drawing.Point(137, 9)
		Me.Label191.Name = "Label191"
		Me.Label191.Size = New System.Drawing.Size(90, 28)
		Me.Label191.TabIndex = 121
		Me.Label191.Text = "Economic damage"
		Me.Label191.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tpaScores
		'
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue7)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience7)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience5)
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue6)
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue4)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience6)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience4)
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue5)
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue3)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience3)
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue2)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience2)
		Me.tpaScores.Controls.Add(Me.lblScoreResilienceValue1)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue7)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure7)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure5)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue6)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue4)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure6)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure4)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue5)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue3)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure3)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue2)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure2)
		Me.tpaScores.Controls.Add(Me.lblScoreExposureValue1)
		Me.tpaScores.Controls.Add(Me.lblScoreResilience1)
		Me.tpaScores.Controls.Add(Me.lblScoreExposure1)
		Me.tpaScores.Controls.Add(Me.Label138)
		Me.tpaScores.Controls.Add(Me.Label139)
		Me.tpaScores.Location = New System.Drawing.Point(4, 22)
		Me.tpaScores.Name = "tpaScores"
		Me.tpaScores.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaScores.Size = New System.Drawing.Size(865, 442)
		Me.tpaScores.TabIndex = 8
		Me.tpaScores.Text = "Scores"
		Me.tpaScores.UseVisualStyleBackColor = True
		'
		'lblScoreResilienceValue7
		'
		Me.lblScoreResilienceValue7.Location = New System.Drawing.Point(169, 365)
		Me.lblScoreResilienceValue7.Name = "lblScoreResilienceValue7"
		Me.lblScoreResilienceValue7.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue7.TabIndex = 160
		Me.lblScoreResilienceValue7.Text = "[output]"
		Me.lblScoreResilienceValue7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience7
		'
		Me.lblScoreResilience7.Location = New System.Drawing.Point(169, 340)
		Me.lblScoreResilience7.Name = "lblScoreResilience7"
		Me.lblScoreResilience7.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience7.TabIndex = 160
		Me.lblScoreResilience7.Text = "[output]"
		Me.lblScoreResilience7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience5
		'
		Me.lblScoreResilience5.Location = New System.Drawing.Point(169, 240)
		Me.lblScoreResilience5.Name = "lblScoreResilience5"
		Me.lblScoreResilience5.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience5.TabIndex = 160
		Me.lblScoreResilience5.Text = "[output]"
		Me.lblScoreResilience5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilienceValue6
		'
		Me.lblScoreResilienceValue6.Location = New System.Drawing.Point(169, 315)
		Me.lblScoreResilienceValue6.Name = "lblScoreResilienceValue6"
		Me.lblScoreResilienceValue6.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue6.TabIndex = 158
		Me.lblScoreResilienceValue6.Text = "[output]"
		Me.lblScoreResilienceValue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilienceValue4
		'
		Me.lblScoreResilienceValue4.Location = New System.Drawing.Point(169, 215)
		Me.lblScoreResilienceValue4.Name = "lblScoreResilienceValue4"
		Me.lblScoreResilienceValue4.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue4.TabIndex = 158
		Me.lblScoreResilienceValue4.Text = "[output]"
		Me.lblScoreResilienceValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience6
		'
		Me.lblScoreResilience6.Location = New System.Drawing.Point(169, 290)
		Me.lblScoreResilience6.Name = "lblScoreResilience6"
		Me.lblScoreResilience6.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience6.TabIndex = 159
		Me.lblScoreResilience6.Text = "[output]"
		Me.lblScoreResilience6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience4
		'
		Me.lblScoreResilience4.Location = New System.Drawing.Point(169, 190)
		Me.lblScoreResilience4.Name = "lblScoreResilience4"
		Me.lblScoreResilience4.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience4.TabIndex = 159
		Me.lblScoreResilience4.Text = "[output]"
		Me.lblScoreResilience4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilienceValue5
		'
		Me.lblScoreResilienceValue5.Location = New System.Drawing.Point(169, 265)
		Me.lblScoreResilienceValue5.Name = "lblScoreResilienceValue5"
		Me.lblScoreResilienceValue5.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue5.TabIndex = 161
		Me.lblScoreResilienceValue5.Text = "[output]"
		Me.lblScoreResilienceValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilienceValue3
		'
		Me.lblScoreResilienceValue3.Location = New System.Drawing.Point(169, 165)
		Me.lblScoreResilienceValue3.Name = "lblScoreResilienceValue3"
		Me.lblScoreResilienceValue3.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue3.TabIndex = 161
		Me.lblScoreResilienceValue3.Text = "[output]"
		Me.lblScoreResilienceValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience3
		'
		Me.lblScoreResilience3.Location = New System.Drawing.Point(169, 140)
		Me.lblScoreResilience3.Name = "lblScoreResilience3"
		Me.lblScoreResilience3.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience3.TabIndex = 164
		Me.lblScoreResilience3.Text = "[output]"
		Me.lblScoreResilience3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilienceValue2
		'
		Me.lblScoreResilienceValue2.Location = New System.Drawing.Point(169, 115)
		Me.lblScoreResilienceValue2.Name = "lblScoreResilienceValue2"
		Me.lblScoreResilienceValue2.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue2.TabIndex = 165
		Me.lblScoreResilienceValue2.Text = "[output]"
		Me.lblScoreResilienceValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience2
		'
		Me.lblScoreResilience2.Location = New System.Drawing.Point(169, 90)
		Me.lblScoreResilience2.Name = "lblScoreResilience2"
		Me.lblScoreResilience2.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience2.TabIndex = 162
		Me.lblScoreResilience2.Text = "[output]"
		Me.lblScoreResilience2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilienceValue1
		'
		Me.lblScoreResilienceValue1.Location = New System.Drawing.Point(169, 65)
		Me.lblScoreResilienceValue1.Name = "lblScoreResilienceValue1"
		Me.lblScoreResilienceValue1.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilienceValue1.TabIndex = 163
		Me.lblScoreResilienceValue1.Text = "[output]"
		Me.lblScoreResilienceValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue7
		'
		Me.lblScoreExposureValue7.Location = New System.Drawing.Point(7, 365)
		Me.lblScoreExposureValue7.Name = "lblScoreExposureValue7"
		Me.lblScoreExposureValue7.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue7.TabIndex = 170
		Me.lblScoreExposureValue7.Text = "[output]"
		Me.lblScoreExposureValue7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure7
		'
		Me.lblScoreExposure7.Location = New System.Drawing.Point(7, 340)
		Me.lblScoreExposure7.Name = "lblScoreExposure7"
		Me.lblScoreExposure7.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure7.TabIndex = 170
		Me.lblScoreExposure7.Text = "[output]"
		Me.lblScoreExposure7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure5
		'
		Me.lblScoreExposure5.Location = New System.Drawing.Point(7, 240)
		Me.lblScoreExposure5.Name = "lblScoreExposure5"
		Me.lblScoreExposure5.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure5.TabIndex = 170
		Me.lblScoreExposure5.Text = "[output]"
		Me.lblScoreExposure5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue6
		'
		Me.lblScoreExposureValue6.Location = New System.Drawing.Point(7, 315)
		Me.lblScoreExposureValue6.Name = "lblScoreExposureValue6"
		Me.lblScoreExposureValue6.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue6.TabIndex = 171
		Me.lblScoreExposureValue6.Text = "[output]"
		Me.lblScoreExposureValue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue4
		'
		Me.lblScoreExposureValue4.Location = New System.Drawing.Point(7, 215)
		Me.lblScoreExposureValue4.Name = "lblScoreExposureValue4"
		Me.lblScoreExposureValue4.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue4.TabIndex = 171
		Me.lblScoreExposureValue4.Text = "[output]"
		Me.lblScoreExposureValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure6
		'
		Me.lblScoreExposure6.Location = New System.Drawing.Point(7, 290)
		Me.lblScoreExposure6.Name = "lblScoreExposure6"
		Me.lblScoreExposure6.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure6.TabIndex = 168
		Me.lblScoreExposure6.Text = "[output]"
		Me.lblScoreExposure6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure4
		'
		Me.lblScoreExposure4.Location = New System.Drawing.Point(7, 190)
		Me.lblScoreExposure4.Name = "lblScoreExposure4"
		Me.lblScoreExposure4.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure4.TabIndex = 168
		Me.lblScoreExposure4.Text = "[output]"
		Me.lblScoreExposure4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue5
		'
		Me.lblScoreExposureValue5.Location = New System.Drawing.Point(7, 265)
		Me.lblScoreExposureValue5.Name = "lblScoreExposureValue5"
		Me.lblScoreExposureValue5.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue5.TabIndex = 169
		Me.lblScoreExposureValue5.Text = "[output]"
		Me.lblScoreExposureValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue3
		'
		Me.lblScoreExposureValue3.Location = New System.Drawing.Point(7, 165)
		Me.lblScoreExposureValue3.Name = "lblScoreExposureValue3"
		Me.lblScoreExposureValue3.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue3.TabIndex = 169
		Me.lblScoreExposureValue3.Text = "[output]"
		Me.lblScoreExposureValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure3
		'
		Me.lblScoreExposure3.Location = New System.Drawing.Point(7, 140)
		Me.lblScoreExposure3.Name = "lblScoreExposure3"
		Me.lblScoreExposure3.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure3.TabIndex = 172
		Me.lblScoreExposure3.Text = "[output]"
		Me.lblScoreExposure3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue2
		'
		Me.lblScoreExposureValue2.Location = New System.Drawing.Point(7, 115)
		Me.lblScoreExposureValue2.Name = "lblScoreExposureValue2"
		Me.lblScoreExposureValue2.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue2.TabIndex = 174
		Me.lblScoreExposureValue2.Text = "[output]"
		Me.lblScoreExposureValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure2
		'
		Me.lblScoreExposure2.Location = New System.Drawing.Point(7, 90)
		Me.lblScoreExposure2.Name = "lblScoreExposure2"
		Me.lblScoreExposure2.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure2.TabIndex = 175
		Me.lblScoreExposure2.Text = "[output]"
		Me.lblScoreExposure2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposureValue1
		'
		Me.lblScoreExposureValue1.Location = New System.Drawing.Point(7, 65)
		Me.lblScoreExposureValue1.Name = "lblScoreExposureValue1"
		Me.lblScoreExposureValue1.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposureValue1.TabIndex = 173
		Me.lblScoreExposureValue1.Text = "[output]"
		Me.lblScoreExposureValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreResilience1
		'
		Me.lblScoreResilience1.Location = New System.Drawing.Point(169, 40)
		Me.lblScoreResilience1.Name = "lblScoreResilience1"
		Me.lblScoreResilience1.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreResilience1.TabIndex = 167
		Me.lblScoreResilience1.Text = "[output]"
		Me.lblScoreResilience1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreExposure1
		'
		Me.lblScoreExposure1.Location = New System.Drawing.Point(7, 40)
		Me.lblScoreExposure1.Name = "lblScoreExposure1"
		Me.lblScoreExposure1.Size = New System.Drawing.Size(158, 19)
		Me.lblScoreExposure1.TabIndex = 166
		Me.lblScoreExposure1.Text = "[output]"
		Me.lblScoreExposure1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label138
		'
		Me.Label138.Location = New System.Drawing.Point(169, 9)
		Me.Label138.Name = "Label138"
		Me.Label138.Size = New System.Drawing.Size(158, 28)
		Me.Label138.TabIndex = 156
		Me.Label138.Text = "Resilience"
		Me.Label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label139
		'
		Me.Label139.Location = New System.Drawing.Point(7, 9)
		Me.Label139.Name = "Label139"
		Me.Label139.Size = New System.Drawing.Size(158, 28)
		Me.Label139.TabIndex = 157
		Me.Label139.Text = "Exposure"
		Me.Label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tpaGraph0
		'
		Me.tpaGraph0.Controls.Add(Me.btnRedraw0)
		Me.tpaGraph0.Controls.Add(Me.GroupBox13)
		Me.tpaGraph0.Controls.Add(Me.GroupBox14)
		Me.tpaGraph0.Controls.Add(Me.pboScores)
		Me.tpaGraph0.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph0.Name = "tpaGraph0"
		Me.tpaGraph0.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph0.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph0.TabIndex = 10
		Me.tpaGraph0.Text = "MO vs RO"
		Me.tpaGraph0.UseVisualStyleBackColor = True
		'
		'btnRedraw0
		'
		Me.btnRedraw0.Location = New System.Drawing.Point(23, 412)
		Me.btnRedraw0.Name = "btnRedraw0"
		Me.btnRedraw0.Size = New System.Drawing.Size(145, 21)
		Me.btnRedraw0.TabIndex = 180
		Me.btnRedraw0.Text = "Redraw"
		Me.btnRedraw0.UseVisualStyleBackColor = True
		'
		'GroupBox13
		'
		Me.GroupBox13.Controls.Add(Me.rbuGraph01e)
		Me.GroupBox13.Controls.Add(Me.rbuGraph01i)
		Me.GroupBox13.Controls.Add(Me.rbuGraph01sei)
		Me.GroupBox13.Controls.Add(Me.rbuGraph01ei)
		Me.GroupBox13.Controls.Add(Me.rbuGraph01si)
		Me.GroupBox13.Controls.Add(Me.rbuGraph01se)
		Me.GroupBox13.Controls.Add(Me.rbuGraph01s)
		Me.GroupBox13.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox13.Name = "GroupBox13"
		Me.GroupBox13.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox13.TabIndex = 179
		Me.GroupBox13.TabStop = False
		'
		'rbuGraph01e
		'
		Me.rbuGraph01e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph01e.Name = "rbuGraph01e"
		Me.rbuGraph01e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph01e.TabIndex = 1
		Me.rbuGraph01e.Text = "Evacuation plan"
		Me.rbuGraph01e.UseVisualStyleBackColor = True
		'
		'rbuGraph01i
		'
		Me.rbuGraph01i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph01i.Name = "rbuGraph01i"
		Me.rbuGraph01i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph01i.TabIndex = 1
		Me.rbuGraph01i.Text = "Insurance scheme"
		Me.rbuGraph01i.UseVisualStyleBackColor = True
		'
		'rbuGraph01sei
		'
		Me.rbuGraph01sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph01sei.Name = "rbuGraph01sei"
		Me.rbuGraph01sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph01sei.TabIndex = 1
		Me.rbuGraph01sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph01sei.UseVisualStyleBackColor = True
		'
		'rbuGraph01ei
		'
		Me.rbuGraph01ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph01ei.Name = "rbuGraph01ei"
		Me.rbuGraph01ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph01ei.TabIndex = 1
		Me.rbuGraph01ei.Text = "Evacuation && Insurance"
		Me.rbuGraph01ei.UseVisualStyleBackColor = True
		'
		'rbuGraph01si
		'
		Me.rbuGraph01si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph01si.Name = "rbuGraph01si"
		Me.rbuGraph01si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph01si.TabIndex = 1
		Me.rbuGraph01si.Text = "Sand && Insurance"
		Me.rbuGraph01si.UseVisualStyleBackColor = True
		'
		'rbuGraph01se
		'
		Me.rbuGraph01se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph01se.Name = "rbuGraph01se"
		Me.rbuGraph01se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph01se.TabIndex = 1
		Me.rbuGraph01se.Text = "Sand && Evacuation"
		Me.rbuGraph01se.UseVisualStyleBackColor = True
		'
		'rbuGraph01s
		'
		Me.rbuGraph01s.Checked = True
		Me.rbuGraph01s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph01s.Name = "rbuGraph01s"
		Me.rbuGraph01s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph01s.TabIndex = 1
		Me.rbuGraph01s.TabStop = True
		Me.rbuGraph01s.Text = "Sand dune"
		Me.rbuGraph01s.UseVisualStyleBackColor = True
		'
		'GroupBox14
		'
		Me.GroupBox14.Controls.Add(Me.rbuGraph02e)
		Me.GroupBox14.Controls.Add(Me.rbuGraph02i)
		Me.GroupBox14.Controls.Add(Me.rbuGraph02sei)
		Me.GroupBox14.Controls.Add(Me.rbuGraph02ei)
		Me.GroupBox14.Controls.Add(Me.rbuGraph02si)
		Me.GroupBox14.Controls.Add(Me.rbuGraph02se)
		Me.GroupBox14.Controls.Add(Me.rbuGraph02s)
		Me.GroupBox14.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox14.Name = "GroupBox14"
		Me.GroupBox14.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox14.TabIndex = 178
		Me.GroupBox14.TabStop = False
		Me.GroupBox14.Text = "minus"
		'
		'rbuGraph02e
		'
		Me.rbuGraph02e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph02e.Name = "rbuGraph02e"
		Me.rbuGraph02e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph02e.TabIndex = 1
		Me.rbuGraph02e.Text = "Evacuation plan"
		Me.rbuGraph02e.UseVisualStyleBackColor = True
		'
		'rbuGraph02i
		'
		Me.rbuGraph02i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph02i.Name = "rbuGraph02i"
		Me.rbuGraph02i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph02i.TabIndex = 1
		Me.rbuGraph02i.Text = "Insurance scheme"
		Me.rbuGraph02i.UseVisualStyleBackColor = True
		'
		'rbuGraph02sei
		'
		Me.rbuGraph02sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph02sei.Name = "rbuGraph02sei"
		Me.rbuGraph02sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph02sei.TabIndex = 1
		Me.rbuGraph02sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph02sei.UseVisualStyleBackColor = True
		'
		'rbuGraph02ei
		'
		Me.rbuGraph02ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph02ei.Name = "rbuGraph02ei"
		Me.rbuGraph02ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph02ei.TabIndex = 1
		Me.rbuGraph02ei.Text = "Evacuation && Insurance"
		Me.rbuGraph02ei.UseVisualStyleBackColor = True
		'
		'rbuGraph02si
		'
		Me.rbuGraph02si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph02si.Name = "rbuGraph02si"
		Me.rbuGraph02si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph02si.TabIndex = 1
		Me.rbuGraph02si.Text = "Sand && Insurance"
		Me.rbuGraph02si.UseVisualStyleBackColor = True
		'
		'rbuGraph02se
		'
		Me.rbuGraph02se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph02se.Name = "rbuGraph02se"
		Me.rbuGraph02se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph02se.TabIndex = 1
		Me.rbuGraph02se.Text = "Sand && Evacuation"
		Me.rbuGraph02se.UseVisualStyleBackColor = True
		'
		'rbuGraph02s
		'
		Me.rbuGraph02s.Checked = True
		Me.rbuGraph02s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph02s.Name = "rbuGraph02s"
		Me.rbuGraph02s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph02s.TabIndex = 1
		Me.rbuGraph02s.TabStop = True
		Me.rbuGraph02s.Text = "Sand dune"
		Me.rbuGraph02s.UseVisualStyleBackColor = True
		'
		'pboScores
		'
		Me.pboScores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboScores.Location = New System.Drawing.Point(181, 3)
		Me.pboScores.Name = "pboScores"
		Me.pboScores.Size = New System.Drawing.Size(681, 433)
		Me.pboScores.TabIndex = 177
		Me.pboScores.TabStop = False
		'
		'tpaGraph1
		'
		Me.tpaGraph1.Controls.Add(Me.btnPlus1)
		Me.tpaGraph1.Controls.Add(Me.btnMinus1)
		Me.tpaGraph1.Controls.Add(Me.btnRedraw1)
		Me.tpaGraph1.Controls.Add(Me.GroupBox1)
		Me.tpaGraph1.Controls.Add(Me.GroupBox2)
		Me.tpaGraph1.Controls.Add(Me.pboGraph1)
		Me.tpaGraph1.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph1.Name = "tpaGraph1"
		Me.tpaGraph1.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph1.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph1.TabIndex = 0
		Me.tpaGraph1.Text = "MO on DE & DU"
		Me.tpaGraph1.UseVisualStyleBackColor = True
		'
		'btnPlus1
		'
		Me.btnPlus1.Location = New System.Drawing.Point(132, 412)
		Me.btnPlus1.Name = "btnPlus1"
		Me.btnPlus1.Size = New System.Drawing.Size(40, 21)
		Me.btnPlus1.TabIndex = 184
		Me.btnPlus1.Text = "+"
		Me.btnPlus1.UseVisualStyleBackColor = True
		'
		'btnMinus1
		'
		Me.btnMinus1.Location = New System.Drawing.Point(87, 412)
		Me.btnMinus1.Name = "btnMinus1"
		Me.btnMinus1.Size = New System.Drawing.Size(40, 21)
		Me.btnMinus1.TabIndex = 183
		Me.btnMinus1.Text = "-"
		Me.btnMinus1.UseVisualStyleBackColor = True
		'
		'btnRedraw1
		'
		Me.btnRedraw1.Location = New System.Drawing.Point(19, 412)
		Me.btnRedraw1.Name = "btnRedraw1"
		Me.btnRedraw1.Size = New System.Drawing.Size(64, 21)
		Me.btnRedraw1.TabIndex = 3
		Me.btnRedraw1.Text = "Redraw"
		Me.btnRedraw1.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.rbuGraph11e)
		Me.GroupBox1.Controls.Add(Me.rbuGraph11i)
		Me.GroupBox1.Controls.Add(Me.rbuGraph11sei)
		Me.GroupBox1.Controls.Add(Me.rbuGraph11ei)
		Me.GroupBox1.Controls.Add(Me.rbuGraph11si)
		Me.GroupBox1.Controls.Add(Me.rbuGraph11se)
		Me.GroupBox1.Controls.Add(Me.rbuGraph11s)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		'
		'rbuGraph11e
		'
		Me.rbuGraph11e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph11e.Name = "rbuGraph11e"
		Me.rbuGraph11e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph11e.TabIndex = 1
		Me.rbuGraph11e.Text = "Evacuation plan"
		Me.rbuGraph11e.UseVisualStyleBackColor = True
		'
		'rbuGraph11i
		'
		Me.rbuGraph11i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph11i.Name = "rbuGraph11i"
		Me.rbuGraph11i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph11i.TabIndex = 1
		Me.rbuGraph11i.Text = "Insurance scheme"
		Me.rbuGraph11i.UseVisualStyleBackColor = True
		'
		'rbuGraph11sei
		'
		Me.rbuGraph11sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph11sei.Name = "rbuGraph11sei"
		Me.rbuGraph11sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph11sei.TabIndex = 1
		Me.rbuGraph11sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph11sei.UseVisualStyleBackColor = True
		'
		'rbuGraph11ei
		'
		Me.rbuGraph11ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph11ei.Name = "rbuGraph11ei"
		Me.rbuGraph11ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph11ei.TabIndex = 1
		Me.rbuGraph11ei.Text = "Evacuation && Insurance"
		Me.rbuGraph11ei.UseVisualStyleBackColor = True
		'
		'rbuGraph11si
		'
		Me.rbuGraph11si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph11si.Name = "rbuGraph11si"
		Me.rbuGraph11si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph11si.TabIndex = 1
		Me.rbuGraph11si.Text = "Sand && Insurance"
		Me.rbuGraph11si.UseVisualStyleBackColor = True
		'
		'rbuGraph11se
		'
		Me.rbuGraph11se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph11se.Name = "rbuGraph11se"
		Me.rbuGraph11se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph11se.TabIndex = 1
		Me.rbuGraph11se.Text = "Sand && Evacuation"
		Me.rbuGraph11se.UseVisualStyleBackColor = True
		'
		'rbuGraph11s
		'
		Me.rbuGraph11s.Checked = True
		Me.rbuGraph11s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph11s.Name = "rbuGraph11s"
		Me.rbuGraph11s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph11s.TabIndex = 1
		Me.rbuGraph11s.TabStop = True
		Me.rbuGraph11s.Text = "Sand dune"
		Me.rbuGraph11s.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.rbuGraph12e)
		Me.GroupBox2.Controls.Add(Me.rbuGraph12i)
		Me.GroupBox2.Controls.Add(Me.rbuGraph12sei)
		Me.GroupBox2.Controls.Add(Me.rbuGraph12ei)
		Me.GroupBox2.Controls.Add(Me.rbuGraph12si)
		Me.GroupBox2.Controls.Add(Me.rbuGraph12se)
		Me.GroupBox2.Controls.Add(Me.rbuGraph12s)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "minus"
		'
		'rbuGraph12e
		'
		Me.rbuGraph12e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph12e.Name = "rbuGraph12e"
		Me.rbuGraph12e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph12e.TabIndex = 1
		Me.rbuGraph12e.Text = "Evacuation plan"
		Me.rbuGraph12e.UseVisualStyleBackColor = True
		'
		'rbuGraph12i
		'
		Me.rbuGraph12i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph12i.Name = "rbuGraph12i"
		Me.rbuGraph12i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph12i.TabIndex = 1
		Me.rbuGraph12i.Text = "Insurance scheme"
		Me.rbuGraph12i.UseVisualStyleBackColor = True
		'
		'rbuGraph12sei
		'
		Me.rbuGraph12sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph12sei.Name = "rbuGraph12sei"
		Me.rbuGraph12sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph12sei.TabIndex = 1
		Me.rbuGraph12sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph12sei.UseVisualStyleBackColor = True
		'
		'rbuGraph12ei
		'
		Me.rbuGraph12ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph12ei.Name = "rbuGraph12ei"
		Me.rbuGraph12ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph12ei.TabIndex = 1
		Me.rbuGraph12ei.Text = "Evacuation && Insurance"
		Me.rbuGraph12ei.UseVisualStyleBackColor = True
		'
		'rbuGraph12si
		'
		Me.rbuGraph12si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph12si.Name = "rbuGraph12si"
		Me.rbuGraph12si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph12si.TabIndex = 1
		Me.rbuGraph12si.Text = "Sand && Insurance"
		Me.rbuGraph12si.UseVisualStyleBackColor = True
		'
		'rbuGraph12se
		'
		Me.rbuGraph12se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph12se.Name = "rbuGraph12se"
		Me.rbuGraph12se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph12se.TabIndex = 1
		Me.rbuGraph12se.Text = "Sand && Evacuation"
		Me.rbuGraph12se.UseVisualStyleBackColor = True
		'
		'rbuGraph12s
		'
		Me.rbuGraph12s.Checked = True
		Me.rbuGraph12s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph12s.Name = "rbuGraph12s"
		Me.rbuGraph12s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph12s.TabIndex = 1
		Me.rbuGraph12s.TabStop = True
		Me.rbuGraph12s.Text = "Sand dune"
		Me.rbuGraph12s.UseVisualStyleBackColor = True
		'
		'pboGraph1
		'
		Me.pboGraph1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboGraph1.Location = New System.Drawing.Point(181, 3)
		Me.pboGraph1.Name = "pboGraph1"
		Me.pboGraph1.Size = New System.Drawing.Size(681, 433)
		Me.pboGraph1.TabIndex = 0
		Me.pboGraph1.TabStop = False
		'
		'tpaGraph2
		'
		Me.tpaGraph2.Controls.Add(Me.btnPlus2)
		Me.tpaGraph2.Controls.Add(Me.btnMinus2)
		Me.tpaGraph2.Controls.Add(Me.btnRedraw2)
		Me.tpaGraph2.Controls.Add(Me.GroupBox3)
		Me.tpaGraph2.Controls.Add(Me.GroupBox4)
		Me.tpaGraph2.Controls.Add(Me.pboGraph2)
		Me.tpaGraph2.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph2.Name = "tpaGraph2"
		Me.tpaGraph2.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph2.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph2.TabIndex = 2
		Me.tpaGraph2.Text = "RO on DE & DU"
		Me.tpaGraph2.UseVisualStyleBackColor = True
		'
		'btnPlus2
		'
		Me.btnPlus2.Location = New System.Drawing.Point(138, 412)
		Me.btnPlus2.Name = "btnPlus2"
		Me.btnPlus2.Size = New System.Drawing.Size(40, 21)
		Me.btnPlus2.TabIndex = 186
		Me.btnPlus2.Text = "+"
		Me.btnPlus2.UseVisualStyleBackColor = True
		'
		'btnMinus2
		'
		Me.btnMinus2.Location = New System.Drawing.Point(93, 412)
		Me.btnMinus2.Name = "btnMinus2"
		Me.btnMinus2.Size = New System.Drawing.Size(40, 21)
		Me.btnMinus2.TabIndex = 185
		Me.btnMinus2.Text = "-"
		Me.btnMinus2.UseVisualStyleBackColor = True
		'
		'btnRedraw2
		'
		Me.btnRedraw2.Location = New System.Drawing.Point(23, 412)
		Me.btnRedraw2.Name = "btnRedraw2"
		Me.btnRedraw2.Size = New System.Drawing.Size(64, 21)
		Me.btnRedraw2.TabIndex = 6
		Me.btnRedraw2.Text = "Redraw"
		Me.btnRedraw2.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.rbuGraph21e)
		Me.GroupBox3.Controls.Add(Me.rbuGraph21i)
		Me.GroupBox3.Controls.Add(Me.rbuGraph21sei)
		Me.GroupBox3.Controls.Add(Me.rbuGraph21ei)
		Me.GroupBox3.Controls.Add(Me.rbuGraph21si)
		Me.GroupBox3.Controls.Add(Me.rbuGraph21se)
		Me.GroupBox3.Controls.Add(Me.rbuGraph21s)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox3.TabIndex = 5
		Me.GroupBox3.TabStop = False
		'
		'rbuGraph21e
		'
		Me.rbuGraph21e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph21e.Name = "rbuGraph21e"
		Me.rbuGraph21e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph21e.TabIndex = 1
		Me.rbuGraph21e.Text = "Evacuation plan"
		Me.rbuGraph21e.UseVisualStyleBackColor = True
		'
		'rbuGraph21i
		'
		Me.rbuGraph21i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph21i.Name = "rbuGraph21i"
		Me.rbuGraph21i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph21i.TabIndex = 1
		Me.rbuGraph21i.Text = "Insurance scheme"
		Me.rbuGraph21i.UseVisualStyleBackColor = True
		'
		'rbuGraph21sei
		'
		Me.rbuGraph21sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph21sei.Name = "rbuGraph21sei"
		Me.rbuGraph21sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph21sei.TabIndex = 1
		Me.rbuGraph21sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph21sei.UseVisualStyleBackColor = True
		'
		'rbuGraph21ei
		'
		Me.rbuGraph21ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph21ei.Name = "rbuGraph21ei"
		Me.rbuGraph21ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph21ei.TabIndex = 1
		Me.rbuGraph21ei.Text = "Evacuation && Insurance"
		Me.rbuGraph21ei.UseVisualStyleBackColor = True
		'
		'rbuGraph21si
		'
		Me.rbuGraph21si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph21si.Name = "rbuGraph21si"
		Me.rbuGraph21si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph21si.TabIndex = 1
		Me.rbuGraph21si.Text = "Sand && Insurance"
		Me.rbuGraph21si.UseVisualStyleBackColor = True
		'
		'rbuGraph21se
		'
		Me.rbuGraph21se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph21se.Name = "rbuGraph21se"
		Me.rbuGraph21se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph21se.TabIndex = 1
		Me.rbuGraph21se.Text = "Sand && Evacuation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.rbuGraph21se.UseVisualStyleBackColor = True
		'
		'rbuGraph21s
		'
		Me.rbuGraph21s.Checked = True
		Me.rbuGraph21s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph21s.Name = "rbuGraph21s"
		Me.rbuGraph21s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph21s.TabIndex = 1
		Me.rbuGraph21s.TabStop = True
		Me.rbuGraph21s.Text = "Sand dune"
		Me.rbuGraph21s.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.rbuGraph22e)
		Me.GroupBox4.Controls.Add(Me.rbuGraph22i)
		Me.GroupBox4.Controls.Add(Me.rbuGraph22sei)
		Me.GroupBox4.Controls.Add(Me.rbuGraph22ei)
		Me.GroupBox4.Controls.Add(Me.rbuGraph22si)
		Me.GroupBox4.Controls.Add(Me.rbuGraph22se)
		Me.GroupBox4.Controls.Add(Me.rbuGraph22s)
		Me.GroupBox4.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox4.TabIndex = 4
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "minus"
		'
		'rbuGraph22e
		'
		Me.rbuGraph22e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph22e.Name = "rbuGraph22e"
		Me.rbuGraph22e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph22e.TabIndex = 1
		Me.rbuGraph22e.Text = "Evacuation plan"
		Me.rbuGraph22e.UseVisualStyleBackColor = True
		'
		'rbuGraph22i
		'
		Me.rbuGraph22i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph22i.Name = "rbuGraph22i"
		Me.rbuGraph22i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph22i.TabIndex = 1
		Me.rbuGraph22i.Text = "Insurance scheme"
		Me.rbuGraph22i.UseVisualStyleBackColor = True
		'
		'rbuGraph22sei
		'
		Me.rbuGraph22sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph22sei.Name = "rbuGraph22sei"
		Me.rbuGraph22sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph22sei.TabIndex = 1
		Me.rbuGraph22sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph22sei.UseVisualStyleBackColor = True
		'
		'rbuGraph22ei
		'
		Me.rbuGraph22ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph22ei.Name = "rbuGraph22ei"
		Me.rbuGraph22ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph22ei.TabIndex = 1
		Me.rbuGraph22ei.Text = "Evacuation && Insurance"
		Me.rbuGraph22ei.UseVisualStyleBackColor = True
		'
		'rbuGraph22si
		'
		Me.rbuGraph22si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph22si.Name = "rbuGraph22si"
		Me.rbuGraph22si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph22si.TabIndex = 1
		Me.rbuGraph22si.Text = "Sand && Insurance"
		Me.rbuGraph22si.UseVisualStyleBackColor = True
		'
		'rbuGraph22se
		'
		Me.rbuGraph22se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph22se.Name = "rbuGraph22se"
		Me.rbuGraph22se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph22se.TabIndex = 1
		Me.rbuGraph22se.Text = "Sand && Evacuation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.rbuGraph22se.UseVisualStyleBackColor = True
		'
		'rbuGraph22s
		'
		Me.rbuGraph22s.Checked = True
		Me.rbuGraph22s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph22s.Name = "rbuGraph22s"
		Me.rbuGraph22s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph22s.TabIndex = 1
		Me.rbuGraph22s.TabStop = True
		Me.rbuGraph22s.Text = "Sand dune"
		Me.rbuGraph22s.UseVisualStyleBackColor = True
		'
		'pboGraph2
		'
		Me.pboGraph2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboGraph2.Location = New System.Drawing.Point(181, 3)
		Me.pboGraph2.Name = "pboGraph2"
		Me.pboGraph2.Size = New System.Drawing.Size(681, 433)
		Me.pboGraph2.TabIndex = 1
		Me.pboGraph2.TabStop = False
		'
		'tpaGraph3
		'
		Me.tpaGraph3.Controls.Add(Me.btnPlus3)
		Me.tpaGraph3.Controls.Add(Me.btnMinus3)
		Me.tpaGraph3.Controls.Add(Me.btnRedraw3)
		Me.tpaGraph3.Controls.Add(Me.GroupBox5)
		Me.tpaGraph3.Controls.Add(Me.GroupBox6)
		Me.tpaGraph3.Controls.Add(Me.pboGraph3)
		Me.tpaGraph3.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph3.Name = "tpaGraph3"
		Me.tpaGraph3.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph3.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph3.TabIndex = 3
		Me.tpaGraph3.Text = "MO on S"
		Me.tpaGraph3.UseVisualStyleBackColor = True
		'
		'btnPlus3
		'
		Me.btnPlus3.Location = New System.Drawing.Point(138, 412)
		Me.btnPlus3.Name = "btnPlus3"
		Me.btnPlus3.Size = New System.Drawing.Size(40, 21)
		Me.btnPlus3.TabIndex = 186
		Me.btnPlus3.Text = "+"
		Me.btnPlus3.UseVisualStyleBackColor = True
		'
		'btnMinus3
		'
		Me.btnMinus3.Location = New System.Drawing.Point(93, 412)
		Me.btnMinus3.Name = "btnMinus3"
		Me.btnMinus3.Size = New System.Drawing.Size(40, 21)
		Me.btnMinus3.TabIndex = 185
		Me.btnMinus3.Text = "-"
		Me.btnMinus3.UseVisualStyleBackColor = True
		'
		'btnRedraw3
		'
		Me.btnRedraw3.Location = New System.Drawing.Point(23, 412)
		Me.btnRedraw3.Name = "btnRedraw3"
		Me.btnRedraw3.Size = New System.Drawing.Size(64, 21)
		Me.btnRedraw3.TabIndex = 6
		Me.btnRedraw3.Text = "Redraw"
		Me.btnRedraw3.UseVisualStyleBackColor = True
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.rbuGraph31e)
		Me.GroupBox5.Controls.Add(Me.rbuGraph31i)
		Me.GroupBox5.Controls.Add(Me.rbuGraph31sei)
		Me.GroupBox5.Controls.Add(Me.rbuGraph31ei)
		Me.GroupBox5.Controls.Add(Me.rbuGraph31si)
		Me.GroupBox5.Controls.Add(Me.rbuGraph31se)
		Me.GroupBox5.Controls.Add(Me.rbuGraph31s)
		Me.GroupBox5.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox5.TabIndex = 5
		Me.GroupBox5.TabStop = False
		'
		'rbuGraph31e
		'
		Me.rbuGraph31e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph31e.Name = "rbuGraph31e"
		Me.rbuGraph31e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph31e.TabIndex = 1
		Me.rbuGraph31e.Text = "Evacuation plan"
		Me.rbuGraph31e.UseVisualStyleBackColor = True
		'
		'rbuGraph31i
		'
		Me.rbuGraph31i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph31i.Name = "rbuGraph31i"
		Me.rbuGraph31i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph31i.TabIndex = 1
		Me.rbuGraph31i.Text = "Insurance scheme"
		Me.rbuGraph31i.UseVisualStyleBackColor = True
		'
		'rbuGraph31sei
		'
		Me.rbuGraph31sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph31sei.Name = "rbuGraph31sei"
		Me.rbuGraph31sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph31sei.TabIndex = 1
		Me.rbuGraph31sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph31sei.UseVisualStyleBackColor = True
		'
		'rbuGraph31ei
		'
		Me.rbuGraph31ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph31ei.Name = "rbuGraph31ei"
		Me.rbuGraph31ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph31ei.TabIndex = 1
		Me.rbuGraph31ei.Text = "Evacuation && Insurance"
		Me.rbuGraph31ei.UseVisualStyleBackColor = True
		'
		'rbuGraph31si
		'
		Me.rbuGraph31si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph31si.Name = "rbuGraph31si"
		Me.rbuGraph31si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph31si.TabIndex = 1
		Me.rbuGraph31si.Text = "Sand && Insurance"
		Me.rbuGraph31si.UseVisualStyleBackColor = True
		'
		'rbuGraph31se
		'
		Me.rbuGraph31se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph31se.Name = "rbuGraph31se"
		Me.rbuGraph31se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph31se.TabIndex = 1
		Me.rbuGraph31se.Text = "Sand && Evacuation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.rbuGraph31se.UseVisualStyleBackColor = True
		'
		'rbuGraph31s
		'
		Me.rbuGraph31s.Checked = True
		Me.rbuGraph31s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph31s.Name = "rbuGraph31s"
		Me.rbuGraph31s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph31s.TabIndex = 1
		Me.rbuGraph31s.TabStop = True
		Me.rbuGraph31s.Text = "Sand dune"
		Me.rbuGraph31s.UseVisualStyleBackColor = True
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.rbuGraph32e)
		Me.GroupBox6.Controls.Add(Me.rbuGraph32i)
		Me.GroupBox6.Controls.Add(Me.rbuGraph32sei)
		Me.GroupBox6.Controls.Add(Me.rbuGraph32ei)
		Me.GroupBox6.Controls.Add(Me.rbuGraph32si)
		Me.GroupBox6.Controls.Add(Me.rbuGraph32se)
		Me.GroupBox6.Controls.Add(Me.rbuGraph32s)
		Me.GroupBox6.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox6.TabIndex = 4
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "minus"
		'
		'rbuGraph32e
		'
		Me.rbuGraph32e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph32e.Name = "rbuGraph32e"
		Me.rbuGraph32e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph32e.TabIndex = 1
		Me.rbuGraph32e.Text = "Evacuation plan"
		Me.rbuGraph32e.UseVisualStyleBackColor = True
		'
		'rbuGraph32i
		'
		Me.rbuGraph32i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph32i.Name = "rbuGraph32i"
		Me.rbuGraph32i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph32i.TabIndex = 1
		Me.rbuGraph32i.Text = "Insurance scheme"
		Me.rbuGraph32i.UseVisualStyleBackColor = True
		'
		'rbuGraph32sei
		'
		Me.rbuGraph32sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph32sei.Name = "rbuGraph32sei"
		Me.rbuGraph32sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph32sei.TabIndex = 1
		Me.rbuGraph32sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph32sei.UseVisualStyleBackColor = True
		'
		'rbuGraph32ei
		'
		Me.rbuGraph32ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph32ei.Name = "rbuGraph32ei"
		Me.rbuGraph32ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph32ei.TabIndex = 1
		Me.rbuGraph32ei.Text = "Evacuation && Insurance"
		Me.rbuGraph32ei.UseVisualStyleBackColor = True
		'
		'rbuGraph32si
		'
		Me.rbuGraph32si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph32si.Name = "rbuGraph32si"
		Me.rbuGraph32si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph32si.TabIndex = 1
		Me.rbuGraph32si.Text = "Sand && Insurance"
		Me.rbuGraph32si.UseVisualStyleBackColor = True
		'
		'rbuGraph32se
		'
		Me.rbuGraph32se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph32se.Name = "rbuGraph32se"
		Me.rbuGraph32se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph32se.TabIndex = 1
		Me.rbuGraph32se.Text = "Sand && Evacuation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.rbuGraph32se.UseVisualStyleBackColor = True
		'
		'rbuGraph32s
		'
		Me.rbuGraph32s.Checked = True
		Me.rbuGraph32s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph32s.Name = "rbuGraph32s"
		Me.rbuGraph32s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph32s.TabIndex = 1
		Me.rbuGraph32s.TabStop = True
		Me.rbuGraph32s.Text = "Sand dune"
		Me.rbuGraph32s.UseVisualStyleBackColor = True
		'
		'pboGraph3
		'
		Me.pboGraph3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboGraph3.Location = New System.Drawing.Point(181, 3)
		Me.pboGraph3.Name = "pboGraph3"
		Me.pboGraph3.Size = New System.Drawing.Size(681, 433)
		Me.pboGraph3.TabIndex = 1
		Me.pboGraph3.TabStop = False
		'
		'tpaGraph4
		'
		Me.tpaGraph4.Controls.Add(Me.btnPlus4)
		Me.tpaGraph4.Controls.Add(Me.btnMinus4)
		Me.tpaGraph4.Controls.Add(Me.btnRedraw4)
		Me.tpaGraph4.Controls.Add(Me.GroupBox7)
		Me.tpaGraph4.Controls.Add(Me.GroupBox8)
		Me.tpaGraph4.Controls.Add(Me.pboGraph4)
		Me.tpaGraph4.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph4.Name = "tpaGraph4"
		Me.tpaGraph4.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph4.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph4.TabIndex = 5
		Me.tpaGraph4.Text = "RO on S"
		Me.tpaGraph4.UseVisualStyleBackColor = True
		'
		'btnPlus4
		'
		Me.btnPlus4.Location = New System.Drawing.Point(138, 412)
		Me.btnPlus4.Name = "btnPlus4"
		Me.btnPlus4.Size = New System.Drawing.Size(40, 21)
		Me.btnPlus4.TabIndex = 186
		Me.btnPlus4.Text = "+"
		Me.btnPlus4.UseVisualStyleBackColor = True
		'
		'btnMinus4
		'
		Me.btnMinus4.Location = New System.Drawing.Point(93, 412)
		Me.btnMinus4.Name = "btnMinus4"
		Me.btnMinus4.Size = New System.Drawing.Size(40, 21)
		Me.btnMinus4.TabIndex = 185
		Me.btnMinus4.Text = "-"
		Me.btnMinus4.UseVisualStyleBackColor = True
		'
		'btnRedraw4
		'
		Me.btnRedraw4.Location = New System.Drawing.Point(23, 412)
		Me.btnRedraw4.Name = "btnRedraw4"
		Me.btnRedraw4.Size = New System.Drawing.Size(64, 21)
		Me.btnRedraw4.TabIndex = 6
		Me.btnRedraw4.Text = "Redraw"
		Me.btnRedraw4.UseVisualStyleBackColor = True
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.rbuGraph41e)
		Me.GroupBox7.Controls.Add(Me.rbuGraph41i)
		Me.GroupBox7.Controls.Add(Me.rbuGraph41sei)
		Me.GroupBox7.Controls.Add(Me.rbuGraph41ei)
		Me.GroupBox7.Controls.Add(Me.rbuGraph41si)
		Me.GroupBox7.Controls.Add(Me.rbuGraph41se)
		Me.GroupBox7.Controls.Add(Me.rbuGraph41s)
		Me.GroupBox7.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox7.TabIndex = 5
		Me.GroupBox7.TabStop = False
		'
		'rbuGraph41e
		'
		Me.rbuGraph41e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph41e.Name = "rbuGraph41e"
		Me.rbuGraph41e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph41e.TabIndex = 1
		Me.rbuGraph41e.Text = "Evacuation plan"
		Me.rbuGraph41e.UseVisualStyleBackColor = True
		'
		'rbuGraph41i
		'
		Me.rbuGraph41i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph41i.Name = "rbuGraph41i"
		Me.rbuGraph41i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph41i.TabIndex = 1
		Me.rbuGraph41i.Text = "Insurance scheme"
		Me.rbuGraph41i.UseVisualStyleBackColor = True
		'
		'rbuGraph41sei
		'
		Me.rbuGraph41sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph41sei.Name = "rbuGraph41sei"
		Me.rbuGraph41sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph41sei.TabIndex = 1
		Me.rbuGraph41sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph41sei.UseVisualStyleBackColor = True
		'
		'rbuGraph41ei
		'
		Me.rbuGraph41ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph41ei.Name = "rbuGraph41ei"
		Me.rbuGraph41ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph41ei.TabIndex = 1
		Me.rbuGraph41ei.Text = "Evacuation && Insurance"
		Me.rbuGraph41ei.UseVisualStyleBackColor = True
		'
		'rbuGraph41si
		'
		Me.rbuGraph41si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph41si.Name = "rbuGraph41si"
		Me.rbuGraph41si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph41si.TabIndex = 1
		Me.rbuGraph41si.Text = "Sand && Insurance"
		Me.rbuGraph41si.UseVisualStyleBackColor = True
		'
		'rbuGraph41se
		'
		Me.rbuGraph41se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph41se.Name = "rbuGraph41se"
		Me.rbuGraph41se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph41se.TabIndex = 1
		Me.rbuGraph41se.Text = "Sand && Evacuation"
		Me.rbuGraph41se.UseVisualStyleBackColor = True
		'
		'rbuGraph41s
		'
		Me.rbuGraph41s.Checked = True
		Me.rbuGraph41s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph41s.Name = "rbuGraph41s"
		Me.rbuGraph41s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph41s.TabIndex = 1
		Me.rbuGraph41s.TabStop = True
		Me.rbuGraph41s.Text = "Sand dune"
		Me.rbuGraph41s.UseVisualStyleBackColor = True
		'
		'GroupBox8
		'
		Me.GroupBox8.Controls.Add(Me.rbuGraph42e)
		Me.GroupBox8.Controls.Add(Me.rbuGraph42i)
		Me.GroupBox8.Controls.Add(Me.rbuGraph42sei)
		Me.GroupBox8.Controls.Add(Me.rbuGraph42ei)
		Me.GroupBox8.Controls.Add(Me.rbuGraph42si)
		Me.GroupBox8.Controls.Add(Me.rbuGraph42se)
		Me.GroupBox8.Controls.Add(Me.rbuGraph42s)
		Me.GroupBox8.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox8.Name = "GroupBox8"
		Me.GroupBox8.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox8.TabIndex = 4
		Me.GroupBox8.TabStop = False
		Me.GroupBox8.Text = "minus"
		'
		'rbuGraph42e
		'
		Me.rbuGraph42e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph42e.Name = "rbuGraph42e"
		Me.rbuGraph42e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph42e.TabIndex = 1
		Me.rbuGraph42e.Text = "Evacuation plan"
		Me.rbuGraph42e.UseVisualStyleBackColor = True
		'
		'rbuGraph42i
		'
		Me.rbuGraph42i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph42i.Name = "rbuGraph42i"
		Me.rbuGraph42i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph42i.TabIndex = 1
		Me.rbuGraph42i.Text = "Insurance scheme"
		Me.rbuGraph42i.UseVisualStyleBackColor = True
		'
		'rbuGraph42sei
		'
		Me.rbuGraph42sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph42sei.Name = "rbuGraph42sei"
		Me.rbuGraph42sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph42sei.TabIndex = 1
		Me.rbuGraph42sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph42sei.UseVisualStyleBackColor = True
		'
		'rbuGraph42ei
		'
		Me.rbuGraph42ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph42ei.Name = "rbuGraph42ei"
		Me.rbuGraph42ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph42ei.TabIndex = 1
		Me.rbuGraph42ei.Text = "Evacuation && Insurance"
		Me.rbuGraph42ei.UseVisualStyleBackColor = True
		'
		'rbuGraph42si
		'
		Me.rbuGraph42si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph42si.Name = "rbuGraph42si"
		Me.rbuGraph42si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph42si.TabIndex = 1
		Me.rbuGraph42si.Text = "Sand && Insurance"
		Me.rbuGraph42si.UseVisualStyleBackColor = True
		'
		'rbuGraph42se
		'
		Me.rbuGraph42se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph42se.Name = "rbuGraph42se"
		Me.rbuGraph42se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph42se.TabIndex = 1
		Me.rbuGraph42se.Text = "Sand && Evacuation"
		Me.rbuGraph42se.UseVisualStyleBackColor = True
		'
		'rbuGraph42s
		'
		Me.rbuGraph42s.Checked = True
		Me.rbuGraph42s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph42s.Name = "rbuGraph42s"
		Me.rbuGraph42s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph42s.TabIndex = 1
		Me.rbuGraph42s.TabStop = True
		Me.rbuGraph42s.Text = "Sand dune"
		Me.rbuGraph42s.UseVisualStyleBackColor = True
		'
		'pboGraph4
		'
		Me.pboGraph4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboGraph4.Location = New System.Drawing.Point(181, 3)
		Me.pboGraph4.Name = "pboGraph4"
		Me.pboGraph4.Size = New System.Drawing.Size(681, 433)
		Me.pboGraph4.TabIndex = 1
		Me.pboGraph4.TabStop = False
		'
		'tpaGraph5
		'
		Me.tpaGraph5.Controls.Add(Me.btnPlus5)
		Me.tpaGraph5.Controls.Add(Me.btnMinus5)
		Me.tpaGraph5.Controls.Add(Me.btnRedraw5)
		Me.tpaGraph5.Controls.Add(Me.GroupBox9)
		Me.tpaGraph5.Controls.Add(Me.GroupBox10)
		Me.tpaGraph5.Controls.Add(Me.pboGraph5)
		Me.tpaGraph5.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph5.Name = "tpaGraph5"
		Me.tpaGraph5.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph5.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph5.TabIndex = 6
		Me.tpaGraph5.Text = "MO on interdependencies"
		Me.tpaGraph5.UseVisualStyleBackColor = True
		'
		'btnPlus5
		'
		Me.btnPlus5.Location = New System.Drawing.Point(138, 412)
		Me.btnPlus5.Name = "btnPlus5"
		Me.btnPlus5.Size = New System.Drawing.Size(40, 21)
		Me.btnPlus5.TabIndex = 186
		Me.btnPlus5.Text = "+"
		Me.btnPlus5.UseVisualStyleBackColor = True
		'
		'btnMinus5
		'
		Me.btnMinus5.Location = New System.Drawing.Point(93, 412)
		Me.btnMinus5.Name = "btnMinus5"
		Me.btnMinus5.Size = New System.Drawing.Size(40, 21)
		Me.btnMinus5.TabIndex = 185
		Me.btnMinus5.Text = "-"
		Me.btnMinus5.UseVisualStyleBackColor = True
		'
		'btnRedraw5
		'
		Me.btnRedraw5.Location = New System.Drawing.Point(23, 412)
		Me.btnRedraw5.Name = "btnRedraw5"
		Me.btnRedraw5.Size = New System.Drawing.Size(64, 21)
		Me.btnRedraw5.TabIndex = 6
		Me.btnRedraw5.Text = "Redraw"
		Me.btnRedraw5.UseVisualStyleBackColor = True
		'
		'GroupBox9
		'
		Me.GroupBox9.Controls.Add(Me.rbuGraph51e)
		Me.GroupBox9.Controls.Add(Me.rbuGraph51i)
		Me.GroupBox9.Controls.Add(Me.rbuGraph51sei)
		Me.GroupBox9.Controls.Add(Me.rbuGraph51ei)
		Me.GroupBox9.Controls.Add(Me.rbuGraph51si)
		Me.GroupBox9.Controls.Add(Me.rbuGraph51se)
		Me.GroupBox9.Controls.Add(Me.rbuGraph51s)
		Me.GroupBox9.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox9.Name = "GroupBox9"
		Me.GroupBox9.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox9.TabIndex = 5
		Me.GroupBox9.TabStop = False
		'
		'rbuGraph51e
		'
		Me.rbuGraph51e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph51e.Name = "rbuGraph51e"
		Me.rbuGraph51e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph51e.TabIndex = 1
		Me.rbuGraph51e.Text = "Evacuation plan"
		Me.rbuGraph51e.UseVisualStyleBackColor = True
		'
		'rbuGraph51i
		'
		Me.rbuGraph51i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph51i.Name = "rbuGraph51i"
		Me.rbuGraph51i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph51i.TabIndex = 1
		Me.rbuGraph51i.Text = "Insurance scheme"
		Me.rbuGraph51i.UseVisualStyleBackColor = True
		'
		'rbuGraph51sei
		'
		Me.rbuGraph51sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph51sei.Name = "rbuGraph51sei"
		Me.rbuGraph51sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph51sei.TabIndex = 1
		Me.rbuGraph51sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph51sei.UseVisualStyleBackColor = True
		'
		'rbuGraph51ei
		'
		Me.rbuGraph51ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph51ei.Name = "rbuGraph51ei"
		Me.rbuGraph51ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph51ei.TabIndex = 1
		Me.rbuGraph51ei.Text = "Evacuation && Insurance"
		Me.rbuGraph51ei.UseVisualStyleBackColor = True
		'
		'rbuGraph51si
		'
		Me.rbuGraph51si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph51si.Name = "rbuGraph51si"
		Me.rbuGraph51si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph51si.TabIndex = 1
		Me.rbuGraph51si.Text = "Sand && Insurance"
		Me.rbuGraph51si.UseVisualStyleBackColor = True
		'
		'rbuGraph51se
		'
		Me.rbuGraph51se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph51se.Name = "rbuGraph51se"
		Me.rbuGraph51se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph51se.TabIndex = 1
		Me.rbuGraph51se.Text = "Sand && Evacuation"
		Me.rbuGraph51se.UseVisualStyleBackColor = True
		'
		'rbuGraph51s
		'
		Me.rbuGraph51s.Checked = True
		Me.rbuGraph51s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph51s.Name = "rbuGraph51s"
		Me.rbuGraph51s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph51s.TabIndex = 1
		Me.rbuGraph51s.TabStop = True
		Me.rbuGraph51s.Text = "Sand dune"
		Me.rbuGraph51s.UseVisualStyleBackColor = True
		'
		'GroupBox10
		'
		Me.GroupBox10.Controls.Add(Me.rbuGraph52e)
		Me.GroupBox10.Controls.Add(Me.rbuGraph52i)
		Me.GroupBox10.Controls.Add(Me.rbuGraph52sei)
		Me.GroupBox10.Controls.Add(Me.rbuGraph52ei)
		Me.GroupBox10.Controls.Add(Me.rbuGraph52si)
		Me.GroupBox10.Controls.Add(Me.rbuGraph52se)
		Me.GroupBox10.Controls.Add(Me.rbuGraph52s)
		Me.GroupBox10.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox10.Name = "GroupBox10"
		Me.GroupBox10.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox10.TabIndex = 4
		Me.GroupBox10.TabStop = False
		Me.GroupBox10.Text = "minus"
		'
		'rbuGraph52e
		'
		Me.rbuGraph52e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph52e.Name = "rbuGraph52e"
		Me.rbuGraph52e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph52e.TabIndex = 1
		Me.rbuGraph52e.Text = "Evacuation plan"
		Me.rbuGraph52e.UseVisualStyleBackColor = True
		'
		'rbuGraph52i
		'
		Me.rbuGraph52i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph52i.Name = "rbuGraph52i"
		Me.rbuGraph52i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph52i.TabIndex = 1
		Me.rbuGraph52i.Text = "Insurance scheme"
		Me.rbuGraph52i.UseVisualStyleBackColor = True
		'
		'rbuGraph52sei
		'
		Me.rbuGraph52sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph52sei.Name = "rbuGraph52sei"
		Me.rbuGraph52sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph52sei.TabIndex = 1
		Me.rbuGraph52sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph52sei.UseVisualStyleBackColor = True
		'
		'rbuGraph52ei
		'
		Me.rbuGraph52ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph52ei.Name = "rbuGraph52ei"
		Me.rbuGraph52ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph52ei.TabIndex = 1
		Me.rbuGraph52ei.Text = "Evacuation && Insurance"
		Me.rbuGraph52ei.UseVisualStyleBackColor = True
		'
		'rbuGraph52si
		'
		Me.rbuGraph52si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph52si.Name = "rbuGraph52si"
		Me.rbuGraph52si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph52si.TabIndex = 1
		Me.rbuGraph52si.Text = "Sand && Insurance"
		Me.rbuGraph52si.UseVisualStyleBackColor = True
		'
		'rbuGraph52se
		'
		Me.rbuGraph52se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph52se.Name = "rbuGraph52se"
		Me.rbuGraph52se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph52se.TabIndex = 1
		Me.rbuGraph52se.Text = "Sand && Evacuation"
		Me.rbuGraph52se.UseVisualStyleBackColor = True
		'
		'rbuGraph52s
		'
		Me.rbuGraph52s.Checked = True
		Me.rbuGraph52s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph52s.Name = "rbuGraph52s"
		Me.rbuGraph52s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph52s.TabIndex = 1
		Me.rbuGraph52s.TabStop = True
		Me.rbuGraph52s.Text = "Sand dune"
		Me.rbuGraph52s.UseVisualStyleBackColor = True
		'
		'pboGraph5
		'
		Me.pboGraph5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboGraph5.Location = New System.Drawing.Point(181, 3)
		Me.pboGraph5.Name = "pboGraph5"
		Me.pboGraph5.Size = New System.Drawing.Size(681, 433)
		Me.pboGraph5.TabIndex = 1
		Me.pboGraph5.TabStop = False
		'
		'tpaGraph6
		'
		Me.tpaGraph6.Controls.Add(Me.btnPlus6)
		Me.tpaGraph6.Controls.Add(Me.btnMinus6)
		Me.tpaGraph6.Controls.Add(Me.btnRedraw6)
		Me.tpaGraph6.Controls.Add(Me.GroupBox11)
		Me.tpaGraph6.Controls.Add(Me.GroupBox12)
		Me.tpaGraph6.Controls.Add(Me.pboGraph6)
		Me.tpaGraph6.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph6.Name = "tpaGraph6"
		Me.tpaGraph6.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph6.Size = New System.Drawing.Size(865, 442)
		Me.tpaGraph6.TabIndex = 9
		Me.tpaGraph6.Text = "RO on interdependencies"
		Me.tpaGraph6.UseVisualStyleBackColor = True
		'
		'btnPlus6
		'
		Me.btnPlus6.Location = New System.Drawing.Point(138, 412)
		Me.btnPlus6.Name = "btnPlus6"
		Me.btnPlus6.Size = New System.Drawing.Size(40, 21)
		Me.btnPlus6.TabIndex = 186
		Me.btnPlus6.Text = "+"
		Me.btnPlus6.UseVisualStyleBackColor = True
		'
		'btnMinus6
		'
		Me.btnMinus6.Location = New System.Drawing.Point(93, 412)
		Me.btnMinus6.Name = "btnMinus6"
		Me.btnMinus6.Size = New System.Drawing.Size(40, 21)
		Me.btnMinus6.TabIndex = 185
		Me.btnMinus6.Text = "-"
		Me.btnMinus6.UseVisualStyleBackColor = True
		'
		'btnRedraw6
		'
		Me.btnRedraw6.Location = New System.Drawing.Point(23, 412)
		Me.btnRedraw6.Name = "btnRedraw6"
		Me.btnRedraw6.Size = New System.Drawing.Size(64, 21)
		Me.btnRedraw6.TabIndex = 6
		Me.btnRedraw6.Text = "Redraw"
		Me.btnRedraw6.UseVisualStyleBackColor = True
		'
		'GroupBox11
		'
		Me.GroupBox11.Controls.Add(Me.rbuGraph61e)
		Me.GroupBox11.Controls.Add(Me.rbuGraph61i)
		Me.GroupBox11.Controls.Add(Me.rbuGraph61sei)
		Me.GroupBox11.Controls.Add(Me.rbuGraph61ei)
		Me.GroupBox11.Controls.Add(Me.rbuGraph61si)
		Me.GroupBox11.Controls.Add(Me.rbuGraph61se)
		Me.GroupBox11.Controls.Add(Me.rbuGraph61s)
		Me.GroupBox11.Location = New System.Drawing.Point(12, 5)
		Me.GroupBox11.Name = "GroupBox11"
		Me.GroupBox11.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox11.TabIndex = 5
		Me.GroupBox11.TabStop = False
		'
		'rbuGraph61e
		'
		Me.rbuGraph61e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph61e.Name = "rbuGraph61e"
		Me.rbuGraph61e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph61e.TabIndex = 1
		Me.rbuGraph61e.Text = "Evacuation plan"
		Me.rbuGraph61e.UseVisualStyleBackColor = True
		'
		'rbuGraph61i
		'
		Me.rbuGraph61i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph61i.Name = "rbuGraph61i"
		Me.rbuGraph61i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph61i.TabIndex = 1
		Me.rbuGraph61i.Text = "Insurance scheme"
		Me.rbuGraph61i.UseVisualStyleBackColor = True
		'
		'rbuGraph61sei
		'
		Me.rbuGraph61sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph61sei.Name = "rbuGraph61sei"
		Me.rbuGraph61sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph61sei.TabIndex = 1
		Me.rbuGraph61sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph61sei.UseVisualStyleBackColor = True
		'
		'rbuGraph61ei
		'
		Me.rbuGraph61ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph61ei.Name = "rbuGraph61ei"
		Me.rbuGraph61ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph61ei.TabIndex = 1
		Me.rbuGraph61ei.Text = "Evacuation && Insurance"
		Me.rbuGraph61ei.UseVisualStyleBackColor = True
		'
		'rbuGraph61si
		'
		Me.rbuGraph61si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph61si.Name = "rbuGraph61si"
		Me.rbuGraph61si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph61si.TabIndex = 1
		Me.rbuGraph61si.Text = "Sand && Insurance"
		Me.rbuGraph61si.UseVisualStyleBackColor = True
		'
		'rbuGraph61se
		'
		Me.rbuGraph61se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph61se.Name = "rbuGraph61se"
		Me.rbuGraph61se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph61se.TabIndex = 1
		Me.rbuGraph61se.Text = "Sand && Evacuation"
		Me.rbuGraph61se.UseVisualStyleBackColor = True
		'
		'rbuGraph61s
		'
		Me.rbuGraph61s.Checked = True
		Me.rbuGraph61s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph61s.Name = "rbuGraph61s"
		Me.rbuGraph61s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph61s.TabIndex = 1
		Me.rbuGraph61s.TabStop = True
		Me.rbuGraph61s.Text = "Sand dune"
		Me.rbuGraph61s.UseVisualStyleBackColor = True
		'
		'GroupBox12
		'
		Me.GroupBox12.Controls.Add(Me.rbuGraph62e)
		Me.GroupBox12.Controls.Add(Me.rbuGraph62i)
		Me.GroupBox12.Controls.Add(Me.rbuGraph62sei)
		Me.GroupBox12.Controls.Add(Me.rbuGraph62ei)
		Me.GroupBox12.Controls.Add(Me.rbuGraph62si)
		Me.GroupBox12.Controls.Add(Me.rbuGraph62se)
		Me.GroupBox12.Controls.Add(Me.rbuGraph62s)
		Me.GroupBox12.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox12.Name = "GroupBox12"
		Me.GroupBox12.Size = New System.Drawing.Size(163, 201)
		Me.GroupBox12.TabIndex = 4
		Me.GroupBox12.TabStop = False
		Me.GroupBox12.Text = "minus"
		'
		'rbuGraph62e
		'
		Me.rbuGraph62e.Location = New System.Drawing.Point(11, 33)
		Me.rbuGraph62e.Name = "rbuGraph62e"
		Me.rbuGraph62e.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph62e.TabIndex = 1
		Me.rbuGraph62e.Text = "Evacuation plan"
		Me.rbuGraph62e.UseVisualStyleBackColor = True
		'
		'rbuGraph62i
		'
		Me.rbuGraph62i.Location = New System.Drawing.Point(11, 55)
		Me.rbuGraph62i.Name = "rbuGraph62i"
		Me.rbuGraph62i.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph62i.TabIndex = 1
		Me.rbuGraph62i.Text = "Insurance scheme"
		Me.rbuGraph62i.UseVisualStyleBackColor = True
		'
		'rbuGraph62sei
		'
		Me.rbuGraph62sei.Location = New System.Drawing.Point(11, 169)
		Me.rbuGraph62sei.Name = "rbuGraph62sei"
		Me.rbuGraph62sei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph62sei.TabIndex = 1
		Me.rbuGraph62sei.Text = "Sand && Evacuation && Insurance"
		Me.rbuGraph62sei.UseVisualStyleBackColor = True
		'
		'rbuGraph62ei
		'
		Me.rbuGraph62ei.Location = New System.Drawing.Point(11, 134)
		Me.rbuGraph62ei.Name = "rbuGraph62ei"
		Me.rbuGraph62ei.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph62ei.TabIndex = 1
		Me.rbuGraph62ei.Text = "Evacuation && Insurance"
		Me.rbuGraph62ei.UseVisualStyleBackColor = True
		'
		'rbuGraph62si
		'
		Me.rbuGraph62si.Location = New System.Drawing.Point(11, 99)
		Me.rbuGraph62si.Name = "rbuGraph62si"
		Me.rbuGraph62si.Size = New System.Drawing.Size(146, 30)
		Me.rbuGraph62si.TabIndex = 1
		Me.rbuGraph62si.Text = "Sand && Insurance"
		Me.rbuGraph62si.UseVisualStyleBackColor = True
		'
		'rbuGraph62se
		'
		Me.rbuGraph62se.Location = New System.Drawing.Point(11, 77)
		Me.rbuGraph62se.Name = "rbuGraph62se"
		Me.rbuGraph62se.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph62se.TabIndex = 1
		Me.rbuGraph62se.Text = "Sand && Evacuation"
		Me.rbuGraph62se.UseVisualStyleBackColor = True
		'
		'rbuGraph62s
		'
		Me.rbuGraph62s.Checked = True
		Me.rbuGraph62s.Location = New System.Drawing.Point(11, 11)
		Me.rbuGraph62s.Name = "rbuGraph62s"
		Me.rbuGraph62s.Size = New System.Drawing.Size(146, 17)
		Me.rbuGraph62s.TabIndex = 1
		Me.rbuGraph62s.TabStop = True
		Me.rbuGraph62s.Text = "Sand dune"
		Me.rbuGraph62s.UseVisualStyleBackColor = True
		'
		'pboGraph6
		'
		Me.pboGraph6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboGraph6.Location = New System.Drawing.Point(181, 3)
		Me.pboGraph6.Name = "pboGraph6"
		Me.pboGraph6.Size = New System.Drawing.Size(681, 433)
		Me.pboGraph6.TabIndex = 1
		Me.pboGraph6.TabStop = False
		'
		'grbWeigth
		'
		Me.grbWeigth.Controls.Add(Me.cboW23)
		Me.grbWeigth.Controls.Add(Me.cboB23)
		Me.grbWeigth.Controls.Add(Me.cboW22)
		Me.grbWeigth.Controls.Add(Me.cboB22)
		Me.grbWeigth.Controls.Add(Me.cboW13)
		Me.grbWeigth.Controls.Add(Me.cboB13)
		Me.grbWeigth.Controls.Add(Me.cboW31)
		Me.grbWeigth.Controls.Add(Me.cboB31)
		Me.grbWeigth.Controls.Add(Me.cboW21)
		Me.grbWeigth.Controls.Add(Me.cboB21)
		Me.grbWeigth.Controls.Add(Me.lblB11)
		Me.grbWeigth.Controls.Add(Me.lblmop2)
		Me.grbWeigth.Controls.Add(Me.lblW11)
		Me.grbWeigth.Controls.Add(Me.lblmop1)
		Me.grbWeigth.Controls.Add(Me.nudFR)
		Me.grbWeigth.Controls.Add(Me.nudDE)
		Me.grbWeigth.Controls.Add(Me.nudDU)
		Me.grbWeigth.Controls.Add(Me.nudY)
		Me.grbWeigth.Controls.Add(Me.nudS1)
		Me.grbWeigth.Controls.Add(Me.nudS2)
		Me.grbWeigth.Controls.Add(Me.nudS3)
		Me.grbWeigth.Controls.Add(Me.nudE23)
		Me.grbWeigth.Controls.Add(Me.nudE22)
		Me.grbWeigth.Controls.Add(Me.nudE31)
		Me.grbWeigth.Controls.Add(Me.nudE13)
		Me.grbWeigth.Controls.Add(Me.nudB12)
		Me.grbWeigth.Controls.Add(Me.nudW12)
		Me.grbWeigth.Controls.Add(Me.nudE12)
		Me.grbWeigth.Controls.Add(Me.nudE21)
		Me.grbWeigth.Controls.Add(Me.nudE11)
		Me.grbWeigth.Controls.Add(Me.lblfef1)
		Me.grbWeigth.Controls.Add(Me.Label49)
		Me.grbWeigth.Controls.Add(Me.Label48)
		Me.grbWeigth.Controls.Add(Me.Label22)
		Me.grbWeigth.Controls.Add(Me.Label19)
		Me.grbWeigth.Controls.Add(Me.Label18)
		Me.grbWeigth.Controls.Add(Me.Label17)
		Me.grbWeigth.Controls.Add(Me.lblUnit1)
		Me.grbWeigth.Controls.Add(Me.lblNoMitigation)
		Me.grbWeigth.Controls.Add(Me.Label16)
		Me.grbWeigth.Controls.Add(Me.Label14)
		Me.grbWeigth.Controls.Add(Me.lblUnit)
		Me.grbWeigth.Controls.Add(Me.lblRelativeDistance)
		Me.grbWeigth.Controls.Add(Me.lblFR)
		Me.grbWeigth.Controls.Add(Me.lblFloodDuration)
		Me.grbWeigth.Controls.Add(Me.lblFloodDepth)
		Me.grbWeigth.DSSTVisible = True
		Me.grbWeigth.ForeColor = System.Drawing.Color.Black
		Me.grbWeigth.Location = New System.Drawing.Point(32, 12)
		Me.grbWeigth.Name = "grbWeigth"
		Me.grbWeigth.Size = New System.Drawing.Size(876, 487)
		Me.grbWeigth.TabIndex = 21
		Me.grbWeigth.TabStop = False
		Me.grbWeigth.Text = "Weigths, attitudes and perceptions"
		Me.grbWeigth.Visible = False
		'
		'cboW23
		'
		Me.cboW23.FormattingEnabled = True
		Me.cboW23.Location = New System.Drawing.Point(705, 275)
		Me.cboW23.Name = "cboW23"
		Me.cboW23.Size = New System.Drawing.Size(72, 21)
		Me.cboW23.TabIndex = 19
		'
		'cboB23
		'
		Me.cboB23.FormattingEnabled = True
		Me.cboB23.Location = New System.Drawing.Point(705, 306)
		Me.cboB23.Name = "cboB23"
		Me.cboB23.Size = New System.Drawing.Size(72, 21)
		Me.cboB23.TabIndex = 25
		'
		'cboW22
		'
		Me.cboW22.FormattingEnabled = True
		Me.cboW22.Location = New System.Drawing.Point(490, 275)
		Me.cboW22.Name = "cboW22"
		Me.cboW22.Size = New System.Drawing.Size(72, 21)
		Me.cboW22.TabIndex = 17
		'
		'cboB22
		'
		Me.cboB22.FormattingEnabled = True
		Me.cboB22.Location = New System.Drawing.Point(490, 306)
		Me.cboB22.Name = "cboB22"
		Me.cboB22.Size = New System.Drawing.Size(72, 21)
		Me.cboB22.TabIndex = 23
		'
		'cboW13
		'
		Me.cboW13.FormattingEnabled = True
		Me.cboW13.Location = New System.Drawing.Point(613, 275)
		Me.cboW13.Name = "cboW13"
		Me.cboW13.Size = New System.Drawing.Size(72, 21)
		Me.cboW13.TabIndex = 18
		'
		'cboB13
		'
		Me.cboB13.FormattingEnabled = True
		Me.cboB13.Location = New System.Drawing.Point(613, 306)
		Me.cboB13.Name = "cboB13"
		Me.cboB13.Size = New System.Drawing.Size(72, 21)
		Me.cboB13.TabIndex = 24
		'
		'cboW31
		'
		Me.cboW31.FormattingEnabled = True
		Me.cboW31.Location = New System.Drawing.Point(281, 275)
		Me.cboW31.Name = "cboW31"
		Me.cboW31.Size = New System.Drawing.Size(72, 21)
		Me.cboW31.TabIndex = 15
		'
		'cboB31
		'
		Me.cboB31.FormattingEnabled = True
		Me.cboB31.Location = New System.Drawing.Point(281, 306)
		Me.cboB31.Name = "cboB31"
		Me.cboB31.Size = New System.Drawing.Size(72, 21)
		Me.cboB31.TabIndex = 21
		'
		'cboW21
		'
		Me.cboW21.FormattingEnabled = True
		Me.cboW21.Location = New System.Drawing.Point(189, 275)
		Me.cboW21.Name = "cboW21"
		Me.cboW21.Size = New System.Drawing.Size(72, 21)
		Me.cboW21.TabIndex = 14
		'
		'cboB21
		'
		Me.cboB21.FormattingEnabled = True
		Me.cboB21.Location = New System.Drawing.Point(189, 306)
		Me.cboB21.Name = "cboB21"
		Me.cboB21.Size = New System.Drawing.Size(72, 21)
		Me.cboB21.TabIndex = 20
		'
		'lblB11
		'
		Me.lblB11.Location = New System.Drawing.Point(100, 306)
		Me.lblB11.Name = "lblB11"
		Me.lblB11.Size = New System.Drawing.Size(72, 13)
		Me.lblB11.TabIndex = 29
		Me.lblB11.Text = "0"
		Me.lblB11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblmop2
		'
		Me.lblmop2.Location = New System.Drawing.Point(14, 306)
		Me.lblmop2.Name = "lblmop2"
		Me.lblmop2.Size = New System.Drawing.Size(80, 13)
		Me.lblmop2.TabIndex = 29
		Me.lblmop2.Text = "Best case Bij"
		'
		'lblW11
		'
		Me.lblW11.Location = New System.Drawing.Point(100, 275)
		Me.lblW11.Name = "lblW11"
		Me.lblW11.Size = New System.Drawing.Size(72, 13)
		Me.lblW11.TabIndex = 28
		Me.lblW11.Text = "Worst case"
		Me.lblW11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblmop1
		'
		Me.lblmop1.Location = New System.Drawing.Point(14, 275)
		Me.lblmop1.Name = "lblmop1"
		Me.lblmop1.Size = New System.Drawing.Size(80, 13)
		Me.lblmop1.TabIndex = 28
		Me.lblmop1.Text = "Worst case Wij"
		'
		'nudFR
		'
		Me.nudFR.DecimalPlaces = 2
		Me.nudFR.Location = New System.Drawing.Point(487, 29)
		Me.nudFR.Name = "nudFR"
		Me.nudFR.Size = New System.Drawing.Size(90, 20)
		Me.nudFR.TabIndex = 1
		Me.nudFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudFR.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudDE
		'
		Me.nudDE.DecimalPlaces = 2
		Me.nudDE.Location = New System.Drawing.Point(171, 29)
		Me.nudDE.Name = "nudDE"
		Me.nudDE.Size = New System.Drawing.Size(90, 20)
		Me.nudDE.TabIndex = 0
		Me.nudDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDE.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudDU
		'
		Me.nudDU.DecimalPlaces = 2
		Me.nudDU.Location = New System.Drawing.Point(171, 61)
		Me.nudDU.Name = "nudDU"
		Me.nudDU.Size = New System.Drawing.Size(90, 20)
		Me.nudDU.TabIndex = 2
		Me.nudDU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDU.Value = New Decimal(New Integer() {15, 0, 0, 0})
		'
		'nudY
		'
		Me.nudY.DecimalPlaces = 2
		Me.nudY.Location = New System.Drawing.Point(487, 61)
		Me.nudY.Name = "nudY"
		Me.nudY.Size = New System.Drawing.Size(90, 20)
		Me.nudY.TabIndex = 3
		Me.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudS1
		'
		Me.nudS1.DecimalPlaces = 2
		Me.nudS1.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudS1.Location = New System.Drawing.Point(180, 118)
		Me.nudS1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudS1.Name = "nudS1"
		Me.nudS1.Size = New System.Drawing.Size(90, 20)
		Me.nudS1.TabIndex = 4
		Me.nudS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudS1.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudS2
		'
		Me.nudS2.DecimalPlaces = 2
		Me.nudS2.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudS2.Location = New System.Drawing.Point(429, 118)
		Me.nudS2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudS2.Name = "nudS2"
		Me.nudS2.Size = New System.Drawing.Size(90, 20)
		Me.nudS2.TabIndex = 5
		Me.nudS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudS2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudS3
		'
		Me.nudS3.DecimalPlaces = 2
		Me.nudS3.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudS3.Location = New System.Drawing.Point(650, 118)
		Me.nudS3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudS3.Name = "nudS3"
		Me.nudS3.Size = New System.Drawing.Size(90, 20)
		Me.nudS3.TabIndex = 6
		Me.nudS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudS3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudE23
		'
		Me.nudE23.DecimalPlaces = 2
		Me.nudE23.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE23.Location = New System.Drawing.Point(705, 230)
		Me.nudE23.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE23.Name = "nudE23"
		Me.nudE23.Size = New System.Drawing.Size(72, 20)
		Me.nudE23.TabIndex = 13
		Me.nudE23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE23.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudE22
		'
		Me.nudE22.DecimalPlaces = 2
		Me.nudE22.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE22.Location = New System.Drawing.Point(490, 230)
		Me.nudE22.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE22.Name = "nudE22"
		Me.nudE22.Size = New System.Drawing.Size(72, 20)
		Me.nudE22.TabIndex = 11
		Me.nudE22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE22.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudE31
		'
		Me.nudE31.DecimalPlaces = 2
		Me.nudE31.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE31.Location = New System.Drawing.Point(281, 230)
		Me.nudE31.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE31.Name = "nudE31"
		Me.nudE31.Size = New System.Drawing.Size(72, 20)
		Me.nudE31.TabIndex = 9
		Me.nudE31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE31.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudE13
		'
		Me.nudE13.DecimalPlaces = 2
		Me.nudE13.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE13.Location = New System.Drawing.Point(613, 230)
		Me.nudE13.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE13.Name = "nudE13"
		Me.nudE13.Size = New System.Drawing.Size(72, 20)
		Me.nudE13.TabIndex = 12
		Me.nudE13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE13.Value = New Decimal(New Integer() {7, 0, 0, 65536})
		'
		'nudB12
		'
		Me.nudB12.DecimalPlaces = 2
		Me.nudB12.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudB12.Location = New System.Drawing.Point(401, 306)
		Me.nudB12.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudB12.Name = "nudB12"
		Me.nudB12.Size = New System.Drawing.Size(72, 20)
		Me.nudB12.TabIndex = 22
		Me.nudB12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB12.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudW12
		'
		Me.nudW12.DecimalPlaces = 2
		Me.nudW12.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudW12.Location = New System.Drawing.Point(401, 275)
		Me.nudW12.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudW12.Name = "nudW12"
		Me.nudW12.Size = New System.Drawing.Size(72, 20)
		Me.nudW12.TabIndex = 16
		Me.nudW12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudW12.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudE12
		'
		Me.nudE12.DecimalPlaces = 2
		Me.nudE12.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE12.Location = New System.Drawing.Point(401, 230)
		Me.nudE12.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE12.Name = "nudE12"
		Me.nudE12.Size = New System.Drawing.Size(72, 20)
		Me.nudE12.TabIndex = 10
		Me.nudE12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE12.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudE21
		'
		Me.nudE21.DecimalPlaces = 2
		Me.nudE21.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE21.Location = New System.Drawing.Point(189, 230)
		Me.nudE21.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE21.Name = "nudE21"
		Me.nudE21.Size = New System.Drawing.Size(72, 20)
		Me.nudE21.TabIndex = 8
		Me.nudE21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE21.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudE11
		'
		Me.nudE11.DecimalPlaces = 2
		Me.nudE11.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE11.Location = New System.Drawing.Point(100, 230)
		Me.nudE11.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE11.Name = "nudE11"
		Me.nudE11.Size = New System.Drawing.Size(72, 20)
		Me.nudE11.TabIndex = 7
		Me.nudE11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE11.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'lblfef1
		'
		Me.lblfef1.Location = New System.Drawing.Point(14, 118)
		Me.lblfef1.Name = "lblfef1"
		Me.lblfef1.Size = New System.Drawing.Size(76, 20)
		Me.lblfef1.TabIndex = 25
		Me.lblfef1.Text = "Sj (%)"
		'
		'Label49
		'
		Me.Label49.Location = New System.Drawing.Point(705, 181)
		Me.Label49.Name = "Label49"
		Me.Label49.Size = New System.Drawing.Size(72, 28)
		Me.Label49.TabIndex = 12
		Me.Label49.Text = "Social distress"
		Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label48
		'
		Me.Label48.Location = New System.Drawing.Point(616, 181)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(72, 28)
		Me.Label48.TabIndex = 12
		Me.Label48.Text = "Health distress"
		Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label22
		'
		Me.Label22.Location = New System.Drawing.Point(490, 181)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(72, 28)
		Me.Label22.TabIndex = 12
		Me.Label22.Text = "Habitat worsening"
		Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label19
		'
		Me.Label19.Location = New System.Drawing.Point(401, 181)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(72, 28)
		Me.Label19.TabIndex = 12
		Me.Label19.Text = "Species worsening"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label18
		'
		Me.Label18.Location = New System.Drawing.Point(281, 181)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(72, 28)
		Me.Label18.TabIndex = 12
		Me.Label18.Text = "Landscape worsening"
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label17
		'
		Me.Label17.Location = New System.Drawing.Point(189, 181)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(72, 28)
		Me.Label17.TabIndex = 12
		Me.Label17.Text = "Employment reduction"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblUnit1
		'
		Me.lblUnit1.Location = New System.Drawing.Point(100, 181)
		Me.lblUnit1.Name = "lblUnit1"
		Me.lblUnit1.Size = New System.Drawing.Size(72, 28)
		Me.lblUnit1.TabIndex = 12
		Me.lblUnit1.Text = "Economic damage"
		Me.lblUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblNoMitigation
		'
		Me.lblNoMitigation.Location = New System.Drawing.Point(14, 230)
		Me.lblNoMitigation.Name = "lblNoMitigation"
		Me.lblNoMitigation.Size = New System.Drawing.Size(76, 13)
		Me.lblNoMitigation.TabIndex = 12
		Me.lblNoMitigation.Text = "Eij (%)"
		'
		'Label16
		'
		Me.Label16.Location = New System.Drawing.Point(613, 159)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(164, 13)
		Me.Label16.TabIndex = 12
		Me.Label16.Text = "Sociology"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(401, 159)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(161, 13)
		Me.Label14.TabIndex = 12
		Me.Label14.Text = "Ecology"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblUnit
		'
		Me.lblUnit.Location = New System.Drawing.Point(100, 159)
		Me.lblUnit.Name = "lblUnit"
		Me.lblUnit.Size = New System.Drawing.Size(253, 13)
		Me.lblUnit.TabIndex = 12
		Me.lblUnit.Text = "Economy"
		Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblRelativeDistance
		'
		Me.lblRelativeDistance.Location = New System.Drawing.Point(276, 61)
		Me.lblRelativeDistance.Name = "lblRelativeDistance"
		Me.lblRelativeDistance.Size = New System.Drawing.Size(207, 20)
		Me.lblRelativeDistance.TabIndex = 12
		Me.lblRelativeDistance.Text = "Relative distance from the best case (%) Y"
		'
		'lblFR
		'
		Me.lblFR.Location = New System.Drawing.Point(276, 29)
		Me.lblFR.Name = "lblFR"
		Me.lblFR.Size = New System.Drawing.Size(207, 20)
		Me.lblFR.TabIndex = 12
		Me.lblFR.Text = "Flood frequency (years) FR"
		'
		'lblFloodDuration
		'
		Me.lblFloodDuration.Location = New System.Drawing.Point(41, 61)
		Me.lblFloodDuration.Name = "lblFloodDuration"
		Me.lblFloodDuration.Size = New System.Drawing.Size(126, 20)
		Me.lblFloodDuration.TabIndex = 12
		Me.lblFloodDuration.Text = "Flood duration (days) DU"
		'
		'lblFloodDepth
		'
		Me.lblFloodDepth.Location = New System.Drawing.Point(41, 29)
		Me.lblFloodDepth.Name = "lblFloodDepth"
		Me.lblFloodDepth.Size = New System.Drawing.Size(126, 20)
		Me.lblFloodDepth.TabIndex = 12
		Me.lblFloodDepth.Text = "Flood depth (m) DE"
		'
		'grbInterdependencies
		'
		Me.grbInterdependencies.Controls.Add(Me.nudE11r)
		Me.grbInterdependencies.Controls.Add(Me.nudI11x)
		Me.grbInterdependencies.Controls.Add(Me.nudCOse)
		Me.grbInterdependencies.Controls.Add(Me.nudCOs)
		Me.grbInterdependencies.Controls.Add(Me.Label82)
		Me.grbInterdependencies.Controls.Add(Me.Label36)
		Me.grbInterdependencies.Controls.Add(Me.Label81)
		Me.grbInterdependencies.Controls.Add(Me.Label35)
		Me.grbInterdependencies.Controls.Add(Me.Label80)
		Me.grbInterdependencies.Controls.Add(Me.Label12)
		Me.grbInterdependencies.Controls.Add(Me.Label79)
		Me.grbInterdependencies.Controls.Add(Me.nudse23x)
		Me.grbInterdependencies.Controls.Add(Me.nudse13x)
		Me.grbInterdependencies.Controls.Add(Me.nudCOsi)
		Me.grbInterdependencies.Controls.Add(Me.Label33)
		Me.grbInterdependencies.Controls.Add(Me.Label87)
		Me.grbInterdependencies.Controls.Add(Me.Label31)
		Me.grbInterdependencies.Controls.Add(Me.Label85)
		Me.grbInterdependencies.Controls.Add(Me.Label30)
		Me.grbInterdependencies.Controls.Add(Me.Label84)
		Me.grbInterdependencies.Controls.Add(Me.Label29)
		Me.grbInterdependencies.Controls.Add(Me.Label83)
		Me.grbInterdependencies.Controls.Add(Me.Label27)
		Me.grbInterdependencies.Controls.Add(Me.Label10)
		Me.grbInterdependencies.Controls.Add(Me.nudCOsei)
		Me.grbInterdependencies.Controls.Add(Me.nudCOei)
		Me.grbInterdependencies.Controls.Add(Me.nudCOe)
		Me.grbInterdependencies.Controls.Add(Me.nudCOi)
		Me.grbInterdependencies.DSSTVisible = True
		Me.grbInterdependencies.ForeColor = System.Drawing.Color.Black
		Me.grbInterdependencies.Location = New System.Drawing.Point(32, 12)
		Me.grbInterdependencies.Name = "grbInterdependencies"
		Me.grbInterdependencies.Size = New System.Drawing.Size(876, 487)
		Me.grbInterdependencies.TabIndex = 25
		Me.grbInterdependencies.TabStop = False
		Me.grbInterdependencies.Text = "Costs and interdependencies"
		Me.grbInterdependencies.Visible = False
		'
		'nudE11r
		'
		Me.nudE11r.DecimalPlaces = 2
		Me.nudE11r.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudE11r.Location = New System.Drawing.Point(359, 146)
		Me.nudE11r.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudE11r.Name = "nudE11r"
		Me.nudE11r.Size = New System.Drawing.Size(90, 20)
		Me.nudE11r.TabIndex = 2
		Me.nudE11r.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudE11r.Value = New Decimal(New Integer() {1, 0, 0, 65536})
		'
		'nudI11x
		'
		Me.nudI11x.DecimalPlaces = 2
		Me.nudI11x.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudI11x.Location = New System.Drawing.Point(244, 187)
		Me.nudI11x.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudI11x.Name = "nudI11x"
		Me.nudI11x.Size = New System.Drawing.Size(90, 20)
		Me.nudI11x.TabIndex = 5
		Me.nudI11x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudI11x.Value = New Decimal(New Integer() {1, 0, 0, 65536})
		'
		'nudCOse
		'
		Me.nudCOse.DecimalPlaces = 2
		Me.nudCOse.Location = New System.Drawing.Point(129, 223)
		Me.nudCOse.Name = "nudCOse"
		Me.nudCOse.Size = New System.Drawing.Size(90, 20)
		Me.nudCOse.TabIndex = 6
		Me.nudCOse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOse.Value = New Decimal(New Integer() {202, 0, 0, 131072})
		'
		'nudCOs
		'
		Me.nudCOs.DecimalPlaces = 2
		Me.nudCOs.Location = New System.Drawing.Point(129, 105)
		Me.nudCOs.Name = "nudCOs"
		Me.nudCOs.Size = New System.Drawing.Size(90, 20)
		Me.nudCOs.TabIndex = 0
		Me.nudCOs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOs.Value = New Decimal(New Integer() {2, 0, 0, 0})
		'
		'Label82
		'
		Me.Label82.Location = New System.Drawing.Point(-1, 339)
		Me.Label82.Name = "Label82"
		Me.Label82.Size = New System.Drawing.Size(118, 41)
		Me.Label82.TabIndex = 4
		Me.Label82.Text = "Sand && Evacuation && Insurance (sei)"
		Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label36
		'
		Me.Label36.Location = New System.Drawing.Point(-1, 175)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(118, 41)
		Me.Label36.TabIndex = 4
		Me.Label36.Text = "Insurance scheme (i)"
		Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label81
		'
		Me.Label81.Location = New System.Drawing.Point(-1, 298)
		Me.Label81.Name = "Label81"
		Me.Label81.Size = New System.Drawing.Size(118, 41)
		Me.Label81.TabIndex = 4
		Me.Label81.Text = "Evacuation && Insurance (ei)"
		Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label35
		'
		Me.Label35.Location = New System.Drawing.Point(-1, 134)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(118, 41)
		Me.Label35.TabIndex = 4
		Me.Label35.Text = "Evacuation plan (e)"
		Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label80
		'
		Me.Label80.Location = New System.Drawing.Point(-1, 257)
		Me.Label80.Name = "Label80"
		Me.Label80.Size = New System.Drawing.Size(118, 41)
		Me.Label80.TabIndex = 4
		Me.Label80.Text = "Sand && Insurance (si)"
		Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label12
		'
		Me.Label12.Location = New System.Drawing.Point(-1, 93)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(118, 41)
		Me.Label12.TabIndex = 4
		Me.Label12.Text = "Sand dune (s)"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label79
		'
		Me.Label79.Location = New System.Drawing.Point(-1, 216)
		Me.Label79.Name = "Label79"
		Me.Label79.Size = New System.Drawing.Size(118, 41)
		Me.Label79.TabIndex = 4
		Me.Label79.Text = "Sand && Evacuation (se)"
		Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudse23x
		'
		Me.nudse23x.DecimalPlaces = 2
		Me.nudse23x.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudse23x.Location = New System.Drawing.Point(589, 223)
		Me.nudse23x.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudse23x.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
		Me.nudse23x.Name = "nudse23x"
		Me.nudse23x.Size = New System.Drawing.Size(90, 20)
		Me.nudse23x.TabIndex = 8
		Me.nudse23x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudse23x.Value = New Decimal(New Integer() {2, 0, 0, -2147418112})
		'
		'nudse13x
		'
		Me.nudse13x.DecimalPlaces = 2
		Me.nudse13x.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudse13x.Location = New System.Drawing.Point(474, 223)
		Me.nudse13x.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudse13x.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
		Me.nudse13x.Name = "nudse13x"
		Me.nudse13x.Size = New System.Drawing.Size(90, 20)
		Me.nudse13x.TabIndex = 7
		Me.nudse13x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudse13x.Value = New Decimal(New Integer() {2, 0, 0, -2147418112})
		'
		'nudCOsi
		'
		Me.nudCOsi.DecimalPlaces = 2
		Me.nudCOsi.Location = New System.Drawing.Point(129, 264)
		Me.nudCOsi.Name = "nudCOsi"
		Me.nudCOsi.Size = New System.Drawing.Size(90, 20)
		Me.nudCOsi.TabIndex = 9
		Me.nudCOsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOsi.Value = New Decimal(New Integer() {22, 0, 0, 65536})
		'
		'Label33
		'
		Me.Label33.Location = New System.Drawing.Point(589, 62)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(90, 28)
		Me.Label33.TabIndex = 4
		Me.Label33.Text = "(%) mo23x"
		Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label87
		'
		Me.Label87.Location = New System.Drawing.Point(589, 22)
		Me.Label87.Name = "Label87"
		Me.Label87.Size = New System.Drawing.Size(90, 28)
		Me.Label87.TabIndex = 4
		Me.Label87.Text = "Social exposure"
		Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label31
		'
		Me.Label31.Location = New System.Drawing.Point(474, 62)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(90, 28)
		Me.Label31.TabIndex = 4
		Me.Label31.Text = "(%) mo13x"
		Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label85
		'
		Me.Label85.Location = New System.Drawing.Point(474, 22)
		Me.Label85.Name = "Label85"
		Me.Label85.Size = New System.Drawing.Size(90, 28)
		Me.Label85.TabIndex = 4
		Me.Label85.Text = "Health exposure"
		Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label30
		'
		Me.Label30.Location = New System.Drawing.Point(359, 62)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(90, 28)
		Me.Label30.TabIndex = 4
		Me.Label30.Text = "(%) mo11r"
		Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label84
		'
		Me.Label84.Location = New System.Drawing.Point(359, 22)
		Me.Label84.Name = "Label84"
		Me.Label84.Size = New System.Drawing.Size(90, 28)
		Me.Label84.TabIndex = 4
		Me.Label84.Text = "Economic resilience"
		Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label29
		'
		Me.Label29.Location = New System.Drawing.Point(244, 62)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(90, 28)
		Me.Label29.TabIndex = 4
		Me.Label29.Text = "(%) mo11x"
		Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label83
		'
		Me.Label83.Location = New System.Drawing.Point(244, 22)
		Me.Label83.Name = "Label83"
		Me.Label83.Size = New System.Drawing.Size(90, 28)
		Me.Label83.TabIndex = 4
		Me.Label83.Text = "Economic exposure"
		Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label27
		'
		Me.Label27.Location = New System.Drawing.Point(129, 62)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(90, 28)
		Me.Label27.TabIndex = 4
		Me.Label27.Text = "(M€/year) COmo"
		Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(129, 22)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(90, 28)
		Me.Label10.TabIndex = 4
		Me.Label10.Text = "Cost"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudCOsei
		'
		Me.nudCOsei.DecimalPlaces = 2
		Me.nudCOsei.Location = New System.Drawing.Point(127, 351)
		Me.nudCOsei.Name = "nudCOsei"
		Me.nudCOsei.Size = New System.Drawing.Size(90, 20)
		Me.nudCOsei.TabIndex = 11
		Me.nudCOsei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOsei.Value = New Decimal(New Integer() {222, 0, 0, 131072})
		'
		'nudCOei
		'
		Me.nudCOei.DecimalPlaces = 2
		Me.nudCOei.Location = New System.Drawing.Point(129, 305)
		Me.nudCOei.Name = "nudCOei"
		Me.nudCOei.Size = New System.Drawing.Size(90, 20)
		Me.nudCOei.TabIndex = 10
		Me.nudCOei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOei.Value = New Decimal(New Integer() {22, 0, 0, 131072})
		'
		'nudCOe
		'
		Me.nudCOe.DecimalPlaces = 2
		Me.nudCOe.Location = New System.Drawing.Point(129, 146)
		Me.nudCOe.Name = "nudCOe"
		Me.nudCOe.Size = New System.Drawing.Size(90, 20)
		Me.nudCOe.TabIndex = 1
		Me.nudCOe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOe.Value = New Decimal(New Integer() {2, 0, 0, 131072})
		'
		'nudCOi
		'
		Me.nudCOi.DecimalPlaces = 2
		Me.nudCOi.Location = New System.Drawing.Point(129, 187)
		Me.nudCOi.Name = "nudCOi"
		Me.nudCOi.Size = New System.Drawing.Size(90, 20)
		Me.nudCOi.TabIndex = 3
		Me.nudCOi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudCOi.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'grbEngineers
		'
		Me.grbEngineers.Controls.Add(Me.nudC)
		Me.grbEngineers.Controls.Add(Me.Label2)
		Me.grbEngineers.Controls.Add(Me.Label1)
		Me.grbEngineers.Controls.Add(Me.lblStotwat)
		Me.grbEngineers.Controls.Add(Me.nudD)
		Me.grbEngineers.DSSTVisible = True
		Me.grbEngineers.ForeColor = System.Drawing.Color.Black
		Me.grbEngineers.Location = New System.Drawing.Point(33, 12)
		Me.grbEngineers.Name = "grbEngineers"
		Me.grbEngineers.Size = New System.Drawing.Size(876, 487)
		Me.grbEngineers.TabIndex = 22
		Me.grbEngineers.TabStop = False
		Me.grbEngineers.Text = "Engineers"
		Me.grbEngineers.Visible = False
		'
		'nudC
		'
		Me.nudC.DecimalPlaces = 2
		Me.nudC.Location = New System.Drawing.Point(188, 59)
		Me.nudC.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudC.Name = "nudC"
		Me.nudC.Size = New System.Drawing.Size(90, 20)
		Me.nudC.TabIndex = 0
		Me.nudC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudC.Value = New Decimal(New Integer() {9, 0, 0, 65536})
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(40, 86)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(132, 20)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Duration reduction (%) SU"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(40, 59)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(132, 20)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Depth reduction (%) SE"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblStotwat
		'
		Me.lblStotwat.Location = New System.Drawing.Point(188, 38)
		Me.lblStotwat.Name = "lblStotwat"
		Me.lblStotwat.Size = New System.Drawing.Size(90, 13)
		Me.lblStotwat.TabIndex = 4
		Me.lblStotwat.Text = "Sand dune"
		Me.lblStotwat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudD
		'
		Me.nudD.DecimalPlaces = 2
		Me.nudD.Location = New System.Drawing.Point(188, 86)
		Me.nudD.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudD.Name = "nudD"
		Me.nudD.Size = New System.Drawing.Size(90, 20)
		Me.nudD.TabIndex = 1
		Me.nudD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudD.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'grbSociologists
		'
		Me.grbSociologists.Controls.Add(Me.cboRTsclsocQ)
		Me.grbSociologists.Controls.Add(Me.cboRTsclheaQ)
		Me.grbSociologists.Controls.Add(Me.nudRTsclsoc)
		Me.grbSociologists.Controls.Add(Me.nudRTsclhea)
		Me.grbSociologists.Controls.Add(Me.Label78)
		Me.grbSociologists.Controls.Add(Me.Label117)
		Me.grbSociologists.Controls.Add(Me.Label118)
		Me.grbSociologists.Controls.Add(Me.Label119)
		Me.grbSociologists.Controls.Add(Me.nudT)
		Me.grbSociologists.Controls.Add(Me.nudP)
		Me.grbSociologists.Controls.Add(Me.nudTsclsoc1)
		Me.grbSociologists.Controls.Add(Me.nudTsclsoc4)
		Me.grbSociologists.Controls.Add(Me.Label61)
		Me.grbSociologists.Controls.Add(Me.nudTsclhea1)
		Me.grbSociologists.Controls.Add(Me.Label60)
		Me.grbSociologists.Controls.Add(Me.nudTsclhea4)
		Me.grbSociologists.Controls.Add(Me.Label13)
		Me.grbSociologists.Controls.Add(Me.Label23)
		Me.grbSociologists.Controls.Add(Me.nudTsclsoc2)
		Me.grbSociologists.Controls.Add(Me.Label24)
		Me.grbSociologists.Controls.Add(Me.Label25)
		Me.grbSociologists.Controls.Add(Me.Label26)
		Me.grbSociologists.Controls.Add(Me.Label28)
		Me.grbSociologists.Controls.Add(Me.Label34)
		Me.grbSociologists.Controls.Add(Me.nudTsclhea2)
		Me.grbSociologists.Controls.Add(Me.nudTsclsoc3)
		Me.grbSociologists.Controls.Add(Me.nudTsclhea3)
		Me.grbSociologists.DSSTVisible = True
		Me.grbSociologists.ForeColor = System.Drawing.Color.Black
		Me.grbSociologists.Location = New System.Drawing.Point(33, 12)
		Me.grbSociologists.Name = "grbSociologists"
		Me.grbSociologists.Size = New System.Drawing.Size(876, 487)
		Me.grbSociologists.TabIndex = 13
		Me.grbSociologists.TabStop = False
		Me.grbSociologists.Text = "Sociologists"
		Me.grbSociologists.Visible = False
		'
		'cboRTsclsocQ
		'
		Me.cboRTsclsocQ.FormattingEnabled = True
		Me.cboRTsclsocQ.Location = New System.Drawing.Point(495, 218)
		Me.cboRTsclsocQ.Name = "cboRTsclsocQ"
		Me.cboRTsclsocQ.Size = New System.Drawing.Size(90, 21)
		Me.cboRTsclsocQ.TabIndex = 11
		'
		'cboRTsclheaQ
		'
		Me.cboRTsclheaQ.FormattingEnabled = True
		Me.cboRTsclheaQ.Location = New System.Drawing.Point(495, 195)
		Me.cboRTsclheaQ.Name = "cboRTsclheaQ"
		Me.cboRTsclheaQ.Size = New System.Drawing.Size(90, 21)
		Me.cboRTsclheaQ.TabIndex = 10
		'
		'nudRTsclsoc
		'
		Me.nudRTsclsoc.DecimalPlaces = 2
		Me.nudRTsclsoc.Location = New System.Drawing.Point(495, 266)
		Me.nudRTsclsoc.Name = "nudRTsclsoc"
		Me.nudRTsclsoc.Size = New System.Drawing.Size(90, 20)
		Me.nudRTsclsoc.TabIndex = 13
		Me.nudRTsclsoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudRTsclsoc.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudRTsclhea
		'
		Me.nudRTsclhea.DecimalPlaces = 2
		Me.nudRTsclhea.Location = New System.Drawing.Point(495, 242)
		Me.nudRTsclhea.Name = "nudRTsclhea"
		Me.nudRTsclhea.Size = New System.Drawing.Size(90, 20)
		Me.nudRTsclhea.TabIndex = 12
		Me.nudRTsclhea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudRTsclhea.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label78
		'
		Me.Label78.Location = New System.Drawing.Point(26, 266)
		Me.Label78.Name = "Label78"
		Me.Label78.Size = New System.Drawing.Size(315, 20)
		Me.Label78.TabIndex = 57
		Me.Label78.Text = "Max flood frequency to observe social resilience (years) RT23FR"
		'
		'Label117
		'
		Me.Label117.Location = New System.Drawing.Point(26, 242)
		Me.Label117.Name = "Label117"
		Me.Label117.Size = New System.Drawing.Size(315, 20)
		Me.Label117.TabIndex = 59
		Me.Label117.Text = "Max flood frequency to observe health resilience (years) RT13FR"
		'
		'Label118
		'
		Me.Label118.Location = New System.Drawing.Point(26, 218)
		Me.Label118.Name = "Label118"
		Me.Label118.Size = New System.Drawing.Size(315, 20)
		Me.Label118.TabIndex = 58
		Me.Label118.Text = "Max social distress to observe resilience (N to P) RT23IM"
		'
		'Label119
		'
		Me.Label119.Location = New System.Drawing.Point(26, 195)
		Me.Label119.Name = "Label119"
		Me.Label119.Size = New System.Drawing.Size(315, 20)
		Me.Label119.TabIndex = 60
		Me.Label119.Text = "Max health distress to observe resilience (N to P) RT13IM"
		'
		'nudT
		'
		Me.nudT.DecimalPlaces = 2
		Me.nudT.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudT.Location = New System.Drawing.Point(399, 165)
		Me.nudT.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudT.Name = "nudT"
		Me.nudT.Size = New System.Drawing.Size(90, 20)
		Me.nudT.TabIndex = 9
		Me.nudT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudT.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudP
		'
		Me.nudP.DecimalPlaces = 2
		Me.nudP.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.nudP.Location = New System.Drawing.Point(399, 136)
		Me.nudP.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudP.Name = "nudP"
		Me.nudP.Size = New System.Drawing.Size(90, 20)
		Me.nudP.TabIndex = 8
		Me.nudP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudP.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTsclsoc1
		'
		Me.nudTsclsoc1.DecimalPlaces = 2
		Me.nudTsclsoc1.Location = New System.Drawing.Point(495, 105)
		Me.nudTsclsoc1.Name = "nudTsclsoc1"
		Me.nudTsclsoc1.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclsoc1.TabIndex = 4
		Me.nudTsclsoc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclsoc1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTsclsoc4
		'
		Me.nudTsclsoc4.DecimalPlaces = 2
		Me.nudTsclsoc4.Location = New System.Drawing.Point(783, 105)
		Me.nudTsclsoc4.Name = "nudTsclsoc4"
		Me.nudTsclsoc4.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclsoc4.TabIndex = 7
		Me.nudTsclsoc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclsoc4.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label61
		'
		Me.Label61.Location = New System.Drawing.Point(26, 165)
		Me.Label61.Name = "Label61"
		Me.Label61.Size = New System.Drawing.Size(315, 20)
		Me.Label61.TabIndex = 48
		Me.Label61.Text = "Reduction of social distress due to evacuation plans (%) ES"
		'
		'nudTsclhea1
		'
		Me.nudTsclhea1.DecimalPlaces = 2
		Me.nudTsclhea1.Location = New System.Drawing.Point(495, 72)
		Me.nudTsclhea1.Name = "nudTsclhea1"
		Me.nudTsclhea1.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclhea1.TabIndex = 0
		Me.nudTsclhea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclhea1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'Label60
		'
		Me.Label60.Location = New System.Drawing.Point(26, 136)
		Me.Label60.Name = "Label60"
		Me.Label60.Size = New System.Drawing.Size(315, 20)
		Me.Label60.TabIndex = 48
		Me.Label60.Text = "Reduction of health distress due to evacuation plans (%) EH"
		'
		'nudTsclhea4
		'
		Me.nudTsclhea4.DecimalPlaces = 2
		Me.nudTsclhea4.Location = New System.Drawing.Point(783, 72)
		Me.nudTsclhea4.Name = "nudTsclhea4"
		Me.nudTsclhea4.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclhea4.TabIndex = 3
		Me.nudTsclhea4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclhea4.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(26, 105)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(315, 20)
		Me.Label13.TabIndex = 48
		Me.Label13.Text = "Min flood duration to observe social distress (days) T23,m"
		'
		'Label23
		'
		Me.Label23.Location = New System.Drawing.Point(26, 72)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(315, 20)
		Me.Label23.TabIndex = 50
		Me.Label23.Text = "Min flood duration to observe health distress (days) T13,m"
		'
		'nudTsclsoc2
		'
		Me.nudTsclsoc2.DecimalPlaces = 2
		Me.nudTsclsoc2.Location = New System.Drawing.Point(591, 105)
		Me.nudTsclsoc2.Name = "nudTsclsoc2"
		Me.nudTsclsoc2.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclsoc2.TabIndex = 5
		Me.nudTsclsoc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclsoc2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(783, 31)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(90, 20)
		Me.Label24.TabIndex = 47
		Me.Label24.Text = "P"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label25
		'
		Me.Label25.Location = New System.Drawing.Point(687, 31)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(90, 20)
		Me.Label25.TabIndex = 49
		Me.Label25.Text = "H"
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label26
		'
		Me.Label26.Location = New System.Drawing.Point(399, 31)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(90, 20)
		Me.Label26.TabIndex = 52
		Me.Label26.Text = "N"
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label28
		'
		Me.Label28.Location = New System.Drawing.Point(591, 31)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(90, 20)
		Me.Label28.TabIndex = 51
		Me.Label28.Text = "M"
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label34
		'
		Me.Label34.Location = New System.Drawing.Point(495, 31)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(90, 20)
		Me.Label34.TabIndex = 46
		Me.Label34.Text = "L"
		Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudTsclhea2
		'
		Me.nudTsclhea2.DecimalPlaces = 2
		Me.nudTsclhea2.Location = New System.Drawing.Point(591, 72)
		Me.nudTsclhea2.Name = "nudTsclhea2"
		Me.nudTsclhea2.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclhea2.TabIndex = 1
		Me.nudTsclhea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclhea2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTsclsoc3
		'
		Me.nudTsclsoc3.DecimalPlaces = 2
		Me.nudTsclsoc3.Location = New System.Drawing.Point(687, 105)
		Me.nudTsclsoc3.Name = "nudTsclsoc3"
		Me.nudTsclsoc3.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclsoc3.TabIndex = 6
		Me.nudTsclsoc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclsoc3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTsclhea3
		'
		Me.nudTsclhea3.DecimalPlaces = 2
		Me.nudTsclhea3.Location = New System.Drawing.Point(687, 72)
		Me.nudTsclhea3.Name = "nudTsclhea3"
		Me.nudTsclhea3.Size = New System.Drawing.Size(90, 20)
		Me.nudTsclhea3.TabIndex = 2
		Me.nudTsclhea3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTsclhea3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'grbEconomists
		'
		Me.grbEconomists.Controls.Add(Me.cboRTecnlanQ)
		Me.grbEconomists.Controls.Add(Me.cboRTecnuneQ)
		Me.grbEconomists.Controls.Add(Me.Label3)
		Me.grbEconomists.Controls.Add(Me.Label4)
		Me.grbEconomists.Controls.Add(Me.Label6)
		Me.grbEconomists.Controls.Add(Me.Label9)
		Me.grbEconomists.Controls.Add(Me.Label15)
		Me.grbEconomists.Controls.Add(Me.nudB7)
		Me.grbEconomists.Controls.Add(Me.nudA7)
		Me.grbEconomists.Controls.Add(Me.nudV7)
		Me.grbEconomists.Controls.Add(Me.nudTecnlan2)
		Me.grbEconomists.Controls.Add(Me.nudTecnune2)
		Me.grbEconomists.Controls.Add(Me.nudTecnlan1)
		Me.grbEconomists.Controls.Add(Me.nudTecnlan4)
		Me.grbEconomists.Controls.Add(Me.nudTecnune1)
		Me.grbEconomists.Controls.Add(Me.nudTecnune4)
		Me.grbEconomists.Controls.Add(Me.nudB8)
		Me.grbEconomists.Controls.Add(Me.nudA8)
		Me.grbEconomists.Controls.Add(Me.nudV8)
		Me.grbEconomists.Controls.Add(Me.nudB4)
		Me.grbEconomists.Controls.Add(Me.nudA4)
		Me.grbEconomists.Controls.Add(Me.nudTecnlan3)
		Me.grbEconomists.Controls.Add(Me.nudV4)
		Me.grbEconomists.Controls.Add(Me.nudTecnune3)
		Me.grbEconomists.Controls.Add(Me.nudRTecnlan)
		Me.grbEconomists.Controls.Add(Me.nudRTecnune)
		Me.grbEconomists.Controls.Add(Me.nudB5)
		Me.grbEconomists.Controls.Add(Me.nudA5)
		Me.grbEconomists.Controls.Add(Me.nudV5)
		Me.grbEconomists.Controls.Add(Me.nudm)
		Me.grbEconomists.Controls.Add(Me.nudzz)
		Me.grbEconomists.Controls.Add(Me.nudz)
		Me.grbEconomists.Controls.Add(Me.nudB1)
		Me.grbEconomists.Controls.Add(Me.nudB6)
		Me.grbEconomists.Controls.Add(Me.nudA1)
		Me.grbEconomists.Controls.Add(Me.nudA6)
		Me.grbEconomists.Controls.Add(Me.nudB2)
		Me.grbEconomists.Controls.Add(Me.nudV1)
		Me.grbEconomists.Controls.Add(Me.nudA2)
		Me.grbEconomists.Controls.Add(Me.nudB3)
		Me.grbEconomists.Controls.Add(Me.nudV6)
		Me.grbEconomists.Controls.Add(Me.nudA3)
		Me.grbEconomists.Controls.Add(Me.nudV2)
		Me.grbEconomists.Controls.Add(Me.Label69)
		Me.grbEconomists.Controls.Add(Me.nudV3)
		Me.grbEconomists.Controls.Add(Me.Label68)
		Me.grbEconomists.Controls.Add(Me.Label67)
		Me.grbEconomists.Controls.Add(Me.Label66)
		Me.grbEconomists.Controls.Add(Me.Label63)
		Me.grbEconomists.Controls.Add(Me.Label55)
		Me.grbEconomists.Controls.Add(Me.Label62)
		Me.grbEconomists.Controls.Add(Me.Label54)
		Me.grbEconomists.Controls.Add(Me.Label130)
		Me.grbEconomists.Controls.Add(Me.Label128)
		Me.grbEconomists.Controls.Add(Me.Label51)
		Me.grbEconomists.Controls.Add(Me.Label57)
		Me.grbEconomists.Controls.Add(Me.Label53)
		Me.grbEconomists.Controls.Add(Me.Label50)
		Me.grbEconomists.Controls.Add(Me.Label56)
		Me.grbEconomists.Controls.Add(Me.Label52)
		Me.grbEconomists.Controls.Add(Me.Label47)
		Me.grbEconomists.Controls.Add(Me.Label122)
		Me.grbEconomists.Controls.Add(Me.Label121)
		Me.grbEconomists.Controls.Add(Me.Label120)
		Me.grbEconomists.DSSTVisible = True
		Me.grbEconomists.ForeColor = System.Drawing.Color.Black
		Me.grbEconomists.Location = New System.Drawing.Point(32, 12)
		Me.grbEconomists.Name = "grbEconomists"
		Me.grbEconomists.Size = New System.Drawing.Size(876, 487)
		Me.grbEconomists.TabIndex = 24
		Me.grbEconomists.TabStop = False
		Me.grbEconomists.Text = "Economists"
		Me.grbEconomists.Visible = False
		'
		'cboRTecnlanQ
		'
		Me.cboRTecnlanQ.FormattingEnabled = True
		Me.cboRTecnlanQ.Location = New System.Drawing.Point(479, 381)
		Me.cboRTecnlanQ.Name = "cboRTecnlanQ"
		Me.cboRTecnlanQ.Size = New System.Drawing.Size(90, 21)
		Me.cboRTecnlanQ.TabIndex = 36
		'
		'cboRTecnuneQ
		'
		Me.cboRTecnuneQ.FormattingEnabled = True
		Me.cboRTecnuneQ.Location = New System.Drawing.Point(479, 357)
		Me.cboRTecnuneQ.Name = "cboRTecnuneQ"
		Me.cboRTecnuneQ.Size = New System.Drawing.Size(90, 21)
		Me.cboRTecnuneQ.TabIndex = 35
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(770, 289)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(90, 18)
		Me.Label3.TabIndex = 41
		Me.Label3.Text = "P"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(674, 289)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(90, 18)
		Me.Label4.TabIndex = 42
		Me.Label4.Text = "H"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(380, 289)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(90, 18)
		Me.Label6.TabIndex = 40
		Me.Label6.Text = "N"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(578, 289)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(90, 18)
		Me.Label9.TabIndex = 38
		Me.Label9.Text = "M"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label15
		'
		Me.Label15.Location = New System.Drawing.Point(479, 289)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(90, 18)
		Me.Label15.TabIndex = 39
		Me.Label15.Text = "L"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudB7
		'
		Me.nudB7.DecimalPlaces = 2
		Me.nudB7.Location = New System.Drawing.Point(674, 177)
		Me.nudB7.Name = "nudB7"
		Me.nudB7.Size = New System.Drawing.Size(90, 20)
		Me.nudB7.TabIndex = 20
		Me.nudB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB7.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudA7
		'
		Me.nudA7.DecimalPlaces = 2
		Me.nudA7.Location = New System.Drawing.Point(578, 177)
		Me.nudA7.Name = "nudA7"
		Me.nudA7.Size = New System.Drawing.Size(90, 20)
		Me.nudA7.TabIndex = 19
		Me.nudA7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA7.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudV7
		'
		Me.nudV7.DecimalPlaces = 2
		Me.nudV7.Location = New System.Drawing.Point(479, 177)
		Me.nudV7.Name = "nudV7"
		Me.nudV7.Size = New System.Drawing.Size(90, 20)
		Me.nudV7.TabIndex = 18
		Me.nudV7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV7.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudTecnlan2
		'
		Me.nudTecnlan2.DecimalPlaces = 2
		Me.nudTecnlan2.Location = New System.Drawing.Point(578, 335)
		Me.nudTecnlan2.Name = "nudTecnlan2"
		Me.nudTecnlan2.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnlan2.TabIndex = 32
		Me.nudTecnlan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnlan2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTecnune2
		'
		Me.nudTecnune2.DecimalPlaces = 2
		Me.nudTecnune2.Location = New System.Drawing.Point(578, 310)
		Me.nudTecnune2.Name = "nudTecnune2"
		Me.nudTecnune2.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnune2.TabIndex = 28
		Me.nudTecnune2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnune2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTecnlan1
		'
		Me.nudTecnlan1.DecimalPlaces = 2
		Me.nudTecnlan1.Location = New System.Drawing.Point(479, 335)
		Me.nudTecnlan1.Name = "nudTecnlan1"
		Me.nudTecnlan1.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnlan1.TabIndex = 31
		Me.nudTecnlan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnlan1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTecnlan4
		'
		Me.nudTecnlan4.DecimalPlaces = 2
		Me.nudTecnlan4.Location = New System.Drawing.Point(768, 335)
		Me.nudTecnlan4.Name = "nudTecnlan4"
		Me.nudTecnlan4.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnlan4.TabIndex = 34
		Me.nudTecnlan4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnlan4.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudTecnune1
		'
		Me.nudTecnune1.DecimalPlaces = 2
		Me.nudTecnune1.Location = New System.Drawing.Point(479, 310)
		Me.nudTecnune1.Name = "nudTecnune1"
		Me.nudTecnune1.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnune1.TabIndex = 27
		Me.nudTecnune1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnune1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTecnune4
		'
		Me.nudTecnune4.DecimalPlaces = 2
		Me.nudTecnune4.Location = New System.Drawing.Point(770, 310)
		Me.nudTecnune4.Name = "nudTecnune4"
		Me.nudTecnune4.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnune4.TabIndex = 30
		Me.nudTecnune4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnune4.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudB8
		'
		Me.nudB8.DecimalPlaces = 2
		Me.nudB8.Location = New System.Drawing.Point(674, 200)
		Me.nudB8.Name = "nudB8"
		Me.nudB8.Size = New System.Drawing.Size(90, 20)
		Me.nudB8.TabIndex = 23
		Me.nudB8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB8.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudA8
		'
		Me.nudA8.DecimalPlaces = 2
		Me.nudA8.Location = New System.Drawing.Point(578, 200)
		Me.nudA8.Name = "nudA8"
		Me.nudA8.Size = New System.Drawing.Size(90, 20)
		Me.nudA8.TabIndex = 22
		Me.nudA8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA8.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'nudV8
		'
		Me.nudV8.DecimalPlaces = 2
		Me.nudV8.Location = New System.Drawing.Point(479, 200)
		Me.nudV8.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.nudV8.Name = "nudV8"
		Me.nudV8.Size = New System.Drawing.Size(90, 20)
		Me.nudV8.TabIndex = 21
		Me.nudV8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV8.Value = New Decimal(New Integer() {284, 0, 0, 0})
		'
		'nudB4
		'
		Me.nudB4.DecimalPlaces = 2
		Me.nudB4.Location = New System.Drawing.Point(674, 108)
		Me.nudB4.Name = "nudB4"
		Me.nudB4.Size = New System.Drawing.Size(90, 20)
		Me.nudB4.TabIndex = 11
		Me.nudB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB4.Value = New Decimal(New Integer() {1082191781, 0, 0, 589824})
		'
		'nudA4
		'
		Me.nudA4.DecimalPlaces = 2
		Me.nudA4.Location = New System.Drawing.Point(578, 108)
		Me.nudA4.Name = "nudA4"
		Me.nudA4.Size = New System.Drawing.Size(90, 20)
		Me.nudA4.TabIndex = 10
		Me.nudA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA4.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTecnlan3
		'
		Me.nudTecnlan3.DecimalPlaces = 2
		Me.nudTecnlan3.Location = New System.Drawing.Point(674, 335)
		Me.nudTecnlan3.Name = "nudTecnlan3"
		Me.nudTecnlan3.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnlan3.TabIndex = 33
		Me.nudTecnlan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnlan3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudV4
		'
		Me.nudV4.DecimalPlaces = 2
		Me.nudV4.Location = New System.Drawing.Point(479, 108)
		Me.nudV4.Name = "nudV4"
		Me.nudV4.Size = New System.Drawing.Size(90, 20)
		Me.nudV4.TabIndex = 9
		Me.nudV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV4.Value = New Decimal(New Integer() {80, 0, 0, 0})
		'
		'nudTecnune3
		'
		Me.nudTecnune3.DecimalPlaces = 2
		Me.nudTecnune3.Location = New System.Drawing.Point(674, 310)
		Me.nudTecnune3.Name = "nudTecnune3"
		Me.nudTecnune3.Size = New System.Drawing.Size(90, 20)
		Me.nudTecnune3.TabIndex = 29
		Me.nudTecnune3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTecnune3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudRTecnlan
		'
		Me.nudRTecnlan.DecimalPlaces = 2
		Me.nudRTecnlan.Location = New System.Drawing.Point(479, 428)
		Me.nudRTecnlan.Name = "nudRTecnlan"
		Me.nudRTecnlan.Size = New System.Drawing.Size(90, 20)
		Me.nudRTecnlan.TabIndex = 38
		Me.nudRTecnlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudRTecnlan.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudRTecnune
		'
		Me.nudRTecnune.DecimalPlaces = 2
		Me.nudRTecnune.Location = New System.Drawing.Point(479, 405)
		Me.nudRTecnune.Name = "nudRTecnune"
		Me.nudRTecnune.Size = New System.Drawing.Size(90, 20)
		Me.nudRTecnune.TabIndex = 37
		Me.nudRTecnune.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudRTecnune.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudB5
		'
		Me.nudB5.DecimalPlaces = 2
		Me.nudB5.Location = New System.Drawing.Point(674, 131)
		Me.nudB5.Name = "nudB5"
		Me.nudB5.Size = New System.Drawing.Size(90, 20)
		Me.nudB5.TabIndex = 14
		Me.nudB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB5.Value = New Decimal(New Integer() {1109589041, 0, 0, 589824})
		'
		'nudA5
		'
		Me.nudA5.DecimalPlaces = 2
		Me.nudA5.Location = New System.Drawing.Point(578, 131)
		Me.nudA5.Name = "nudA5"
		Me.nudA5.Size = New System.Drawing.Size(90, 20)
		Me.nudA5.TabIndex = 13
		Me.nudA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA5.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'nudV5
		'
		Me.nudV5.DecimalPlaces = 2
		Me.nudV5.Location = New System.Drawing.Point(479, 131)
		Me.nudV5.Name = "nudV5"
		Me.nudV5.Size = New System.Drawing.Size(90, 20)
		Me.nudV5.TabIndex = 12
		Me.nudV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV5.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudm
		'
		Me.nudm.DecimalPlaces = 2
		Me.nudm.Location = New System.Drawing.Point(380, 268)
		Me.nudm.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudm.Name = "nudm"
		Me.nudm.Size = New System.Drawing.Size(90, 20)
		Me.nudm.TabIndex = 26
		Me.nudm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudm.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudzz
		'
		Me.nudzz.DecimalPlaces = 2
		Me.nudzz.Location = New System.Drawing.Point(380, 246)
		Me.nudzz.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudzz.Name = "nudzz"
		Me.nudzz.Size = New System.Drawing.Size(90, 20)
		Me.nudzz.TabIndex = 25
		Me.nudzz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudzz.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudz
		'
		Me.nudz.DecimalPlaces = 2
		Me.nudz.Location = New System.Drawing.Point(380, 224)
		Me.nudz.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudz.Name = "nudz"
		Me.nudz.Size = New System.Drawing.Size(90, 20)
		Me.nudz.TabIndex = 24
		Me.nudz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudz.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudB1
		'
		Me.nudB1.DecimalPlaces = 2
		Me.nudB1.Location = New System.Drawing.Point(674, 39)
		Me.nudB1.Name = "nudB1"
		Me.nudB1.Size = New System.Drawing.Size(90, 20)
		Me.nudB1.TabIndex = 2
		Me.nudB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB1.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudB6
		'
		Me.nudB6.DecimalPlaces = 2
		Me.nudB6.Location = New System.Drawing.Point(674, 154)
		Me.nudB6.Name = "nudB6"
		Me.nudB6.Size = New System.Drawing.Size(90, 20)
		Me.nudB6.TabIndex = 17
		Me.nudB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB6.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudA1
		'
		Me.nudA1.DecimalPlaces = 2
		Me.nudA1.Location = New System.Drawing.Point(578, 39)
		Me.nudA1.Name = "nudA1"
		Me.nudA1.Size = New System.Drawing.Size(90, 20)
		Me.nudA1.TabIndex = 1
		Me.nudA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA1.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudA6
		'
		Me.nudA6.DecimalPlaces = 2
		Me.nudA6.Location = New System.Drawing.Point(578, 154)
		Me.nudA6.Name = "nudA6"
		Me.nudA6.Size = New System.Drawing.Size(90, 20)
		Me.nudA6.TabIndex = 16
		Me.nudA6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA6.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudB2
		'
		Me.nudB2.DecimalPlaces = 2
		Me.nudB2.Location = New System.Drawing.Point(674, 62)
		Me.nudB2.Name = "nudB2"
		Me.nudB2.Size = New System.Drawing.Size(90, 20)
		Me.nudB2.TabIndex = 5
		Me.nudB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB2.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudV1
		'
		Me.nudV1.DecimalPlaces = 2
		Me.nudV1.Location = New System.Drawing.Point(479, 39)
		Me.nudV1.Name = "nudV1"
		Me.nudV1.Size = New System.Drawing.Size(90, 20)
		Me.nudV1.TabIndex = 0
		Me.nudV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV1.Value = New Decimal(New Integer() {71, 0, 0, 0})
		'
		'nudA2
		'
		Me.nudA2.DecimalPlaces = 2
		Me.nudA2.Location = New System.Drawing.Point(578, 62)
		Me.nudA2.Name = "nudA2"
		Me.nudA2.Size = New System.Drawing.Size(90, 20)
		Me.nudA2.TabIndex = 4
		Me.nudA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudB3
		'
		Me.nudB3.DecimalPlaces = 2
		Me.nudB3.Location = New System.Drawing.Point(674, 85)
		Me.nudB3.Name = "nudB3"
		Me.nudB3.Size = New System.Drawing.Size(90, 20)
		Me.nudB3.TabIndex = 8
		Me.nudB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudB3.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudV6
		'
		Me.nudV6.DecimalPlaces = 2
		Me.nudV6.Location = New System.Drawing.Point(479, 154)
		Me.nudV6.Name = "nudV6"
		Me.nudV6.Size = New System.Drawing.Size(90, 20)
		Me.nudV6.TabIndex = 15
		Me.nudV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV6.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudA3
		'
		Me.nudA3.DecimalPlaces = 2
		Me.nudA3.Location = New System.Drawing.Point(578, 85)
		Me.nudA3.Name = "nudA3"
		Me.nudA3.Size = New System.Drawing.Size(90, 20)
		Me.nudA3.TabIndex = 7
		Me.nudA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudA3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudV2
		'
		Me.nudV2.DecimalPlaces = 2
		Me.nudV2.Location = New System.Drawing.Point(479, 62)
		Me.nudV2.Name = "nudV2"
		Me.nudV2.Size = New System.Drawing.Size(90, 20)
		Me.nudV2.TabIndex = 3
		Me.nudV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV2.Value = New Decimal(New Integer() {53, 0, 0, 0})
		'
		'Label69
		'
		Me.Label69.Location = New System.Drawing.Point(26, 428)
		Me.Label69.Name = "Label69"
		Me.Label69.Size = New System.Drawing.Size(348, 20)
		Me.Label69.TabIndex = 4
		Me.Label69.Text = "Max flood frequency to observe landscape resilience (years) RT31FR"
		'
		'nudV3
		'
		Me.nudV3.DecimalPlaces = 2
		Me.nudV3.Location = New System.Drawing.Point(479, 85)
		Me.nudV3.Name = "nudV3"
		Me.nudV3.Size = New System.Drawing.Size(90, 20)
		Me.nudV3.TabIndex = 6
		Me.nudV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudV3.Value = New Decimal(New Integer() {58, 0, 0, 0})
		'
		'Label68
		'
		Me.Label68.Location = New System.Drawing.Point(26, 405)
		Me.Label68.Name = "Label68"
		Me.Label68.Size = New System.Drawing.Size(348, 20)
		Me.Label68.TabIndex = 4
		Me.Label68.Text = "Max flood frequency to observe employment resilience (years) RT21FR"
		'
		'Label67
		'
		Me.Label67.Location = New System.Drawing.Point(26, 381)
		Me.Label67.Name = "Label67"
		Me.Label67.Size = New System.Drawing.Size(348, 20)
		Me.Label67.TabIndex = 4
		Me.Label67.Text = "Max landscape worsening to observe resilience  (N to P) RT31IM"
		'
		'Label66
		'
		Me.Label66.Location = New System.Drawing.Point(26, 357)
		Me.Label66.Name = "Label66"
		Me.Label66.Size = New System.Drawing.Size(348, 20)
		Me.Label66.TabIndex = 4
		Me.Label66.Text = "Max employment reducution to observe resilience  (N to P) RT21IM"
		'
		'Label63
		'
		Me.Label63.Location = New System.Drawing.Point(26, 335)
		Me.Label63.Name = "Label63"
		Me.Label63.Size = New System.Drawing.Size(348, 20)
		Me.Label63.TabIndex = 4
		Me.Label63.Text = "Min flood depth to observe landscape worsening (m) T31,m"
		'
		'Label55
		'
		Me.Label55.Location = New System.Drawing.Point(26, 177)
		Me.Label55.Name = "Label55"
		Me.Label55.Size = New System.Drawing.Size(282, 20)
		Me.Label55.TabIndex = 4
		Me.Label55.Text = "Fishing harbour and infrastructuers (7)"
		'
		'Label62
		'
		Me.Label62.Location = New System.Drawing.Point(26, 310)
		Me.Label62.Name = "Label62"
		Me.Label62.Size = New System.Drawing.Size(348, 20)
		Me.Label62.TabIndex = 4
		Me.Label62.Text = "Min flood depth to observe employment reduction (m) T21,m"
		'
		'Label54
		'
		Me.Label54.Location = New System.Drawing.Point(26, 154)
		Me.Label54.Name = "Label54"
		Me.Label54.Size = New System.Drawing.Size(282, 20)
		Me.Label54.TabIndex = 4
		Me.Label54.Text = "Tourism harbour and infrastructuers (6)"
		'
		'Label130
		'
		Me.Label130.Location = New System.Drawing.Point(26, 268)
		Me.Label130.Name = "Label130"
		Me.Label130.Size = New System.Drawing.Size(282, 20)
		Me.Label130.TabIndex = 4
		Me.Label130.Text = "Yearly passive interest rate on loans (%) IR"
		'
		'Label128
		'
		Me.Label128.Location = New System.Drawing.Point(26, 246)
		Me.Label128.Name = "Label128"
		Me.Label128.Size = New System.Drawing.Size(282, 20)
		Me.Label128.TabIndex = 4
		Me.Label128.Text = "Loan annuity over the expected yearly exposure (%) LA"
		'
		'Label51
		'
		Me.Label51.Location = New System.Drawing.Point(26, 85)
		Me.Label51.Name = "Label51"
		Me.Label51.Size = New System.Drawing.Size(282, 20)
		Me.Label51.TabIndex = 4
		Me.Label51.Text = "Historical buildings (3)"
		'
		'Label57
		'
		Me.Label57.Location = New System.Drawing.Point(26, 224)
		Me.Label57.Name = "Label57"
		Me.Label57.Size = New System.Drawing.Size(292, 20)
		Me.Label57.TabIndex = 4
		Me.Label57.Text = "Insurance premium over the expected yearly exposure (%) IP"
		'
		'Label53
		'
		Me.Label53.Location = New System.Drawing.Point(26, 131)
		Me.Label53.Name = "Label53"
		Me.Label53.Size = New System.Drawing.Size(282, 20)
		Me.Label53.TabIndex = 4
		Me.Label53.Text = "Camping sites (5)"
		'
		'Label50
		'
		Me.Label50.Location = New System.Drawing.Point(26, 62)
		Me.Label50.Name = "Label50"
		Me.Label50.Size = New System.Drawing.Size(282, 20)
		Me.Label50.TabIndex = 4
		Me.Label50.Text = "Holiday homes (2)"
		'
		'Label56
		'
		Me.Label56.Location = New System.Drawing.Point(26, 200)
		Me.Label56.Name = "Label56"
		Me.Label56.Size = New System.Drawing.Size(282, 20)
		Me.Label56.TabIndex = 4
		Me.Label56.Text = "Private services (8)"
		'
		'Label52
		'
		Me.Label52.Location = New System.Drawing.Point(26, 108)
		Me.Label52.Name = "Label52"
		Me.Label52.Size = New System.Drawing.Size(282, 20)
		Me.Label52.TabIndex = 4
		Me.Label52.Text = "Hotels (4)"
		'
		'Label47
		'
		Me.Label47.Location = New System.Drawing.Point(26, 39)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(282, 20)
		Me.Label47.TabIndex = 4
		Me.Label47.Text = "Residential homes (1)"
		'
		'Label122
		'
		Me.Label122.Location = New System.Drawing.Point(674, 21)
		Me.Label122.Name = "Label122"
		Me.Label122.Size = New System.Drawing.Size(90, 13)
		Me.Label122.TabIndex = 4
		Me.Label122.Text = "bu (n)"
		Me.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label121
		'
		Me.Label121.Location = New System.Drawing.Point(578, 21)
		Me.Label121.Name = "Label121"
		Me.Label121.Size = New System.Drawing.Size(90, 13)
		Me.Label121.TabIndex = 4
		Me.Label121.Text = "au (n)"
		Me.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label120
		'
		Me.Label120.Location = New System.Drawing.Point(479, 21)
		Me.Label120.Name = "Label120"
		Me.Label120.Size = New System.Drawing.Size(90, 13)
		Me.Label120.TabIndex = 4
		Me.Label120.Text = "vu (€/ha)"
		Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'grbEcologists
		'
		Me.grbEcologists.Controls.Add(Me.cboRTeclhabQ)
		Me.grbEcologists.Controls.Add(Me.cboRTeclspeQ)
		Me.grbEcologists.Controls.Add(Me.nudRTeclhab)
		Me.grbEcologists.Controls.Add(Me.nudRTeclspe)
		Me.grbEcologists.Controls.Add(Me.Label73)
		Me.grbEcologists.Controls.Add(Me.Label74)
		Me.grbEcologists.Controls.Add(Me.Label75)
		Me.grbEcologists.Controls.Add(Me.Label76)
		Me.grbEcologists.Controls.Add(Me.nudTeclspe4)
		Me.grbEcologists.Controls.Add(Me.nudTeclspe1)
		Me.grbEcologists.Controls.Add(Me.nudTeclhab1du)
		Me.grbEcologists.Controls.Add(Me.nudTeclhab4du)
		Me.grbEcologists.Controls.Add(Me.Label38)
		Me.grbEcologists.Controls.Add(Me.nudTeclhab2du)
		Me.grbEcologists.Controls.Add(Me.Label42)
		Me.grbEcologists.Controls.Add(Me.Label41)
		Me.grbEcologists.Controls.Add(Me.Label43)
		Me.grbEcologists.Controls.Add(Me.Label40)
		Me.grbEcologists.Controls.Add(Me.Label39)
		Me.grbEcologists.Controls.Add(Me.lblTa)
		Me.grbEcologists.Controls.Add(Me.nudTeclhab3du)
		Me.grbEcologists.Controls.Add(Me.nudTeclspe2)
		Me.grbEcologists.Controls.Add(Me.nudTeclspe3)
		Me.grbEcologists.DSSTVisible = True
		Me.grbEcologists.ForeColor = System.Drawing.Color.Black
		Me.grbEcologists.Location = New System.Drawing.Point(33, 12)
		Me.grbEcologists.Name = "grbEcologists"
		Me.grbEcologists.Size = New System.Drawing.Size(876, 487)
		Me.grbEcologists.TabIndex = 23
		Me.grbEcologists.TabStop = False
		Me.grbEcologists.Text = "Ecologists"
		Me.grbEcologists.Visible = False
		'
		'cboRTeclhabQ
		'
		Me.cboRTeclhabQ.FormattingEnabled = True
		Me.cboRTeclhabQ.Location = New System.Drawing.Point(451, 165)
		Me.cboRTeclhabQ.Name = "cboRTeclhabQ"
		Me.cboRTeclhabQ.Size = New System.Drawing.Size(90, 21)
		Me.cboRTeclhabQ.TabIndex = 51
		'
		'cboRTeclspeQ
		'
		Me.cboRTeclspeQ.FormattingEnabled = True
		Me.cboRTeclspeQ.Location = New System.Drawing.Point(451, 136)
		Me.cboRTeclspeQ.Name = "cboRTeclspeQ"
		Me.cboRTeclspeQ.Size = New System.Drawing.Size(90, 21)
		Me.cboRTeclspeQ.TabIndex = 50
		'
		'nudRTeclhab
		'
		Me.nudRTeclhab.DecimalPlaces = 2
		Me.nudRTeclhab.Location = New System.Drawing.Point(451, 226)
		Me.nudRTeclhab.Name = "nudRTeclhab"
		Me.nudRTeclhab.Size = New System.Drawing.Size(90, 20)
		Me.nudRTeclhab.TabIndex = 41
		Me.nudRTeclhab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudRTeclhab.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudRTeclspe
		'
		Me.nudRTeclspe.DecimalPlaces = 2
		Me.nudRTeclspe.Location = New System.Drawing.Point(451, 197)
		Me.nudRTeclspe.Name = "nudRTeclspe"
		Me.nudRTeclspe.Size = New System.Drawing.Size(90, 20)
		Me.nudRTeclspe.TabIndex = 42
		Me.nudRTeclspe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudRTeclspe.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label73
		'
		Me.Label73.Location = New System.Drawing.Point(14, 226)
		Me.Label73.Name = "Label73"
		Me.Label73.Size = New System.Drawing.Size(323, 20)
		Me.Label73.TabIndex = 46
		Me.Label73.Text = "Max flood frequency to observe habitat resilience (years) RT22FR"
		'
		'Label74
		'
		Me.Label74.Location = New System.Drawing.Point(14, 197)
		Me.Label74.Name = "Label74"
		Me.Label74.Size = New System.Drawing.Size(323, 20)
		Me.Label74.TabIndex = 48
		Me.Label74.Text = "Max flood frequency to observe species resilience (years) RT12FR"
		'
		'Label75
		'
		Me.Label75.Location = New System.Drawing.Point(14, 165)
		Me.Label75.Name = "Label75"
		Me.Label75.Size = New System.Drawing.Size(323, 20)
		Me.Label75.TabIndex = 47
		Me.Label75.Text = "Max habitat worsening to observe resilience (N to P) RT22IM"
		'
		'Label76
		'
		Me.Label76.Location = New System.Drawing.Point(14, 136)
		Me.Label76.Name = "Label76"
		Me.Label76.Size = New System.Drawing.Size(323, 20)
		Me.Label76.TabIndex = 49
		Me.Label76.Text = "Max species worsening to observe resilience (N to P) RT12IM"
		'
		'nudTeclspe4
		'
		Me.nudTeclspe4.DecimalPlaces = 2
		Me.nudTeclspe4.Location = New System.Drawing.Point(739, 57)
		Me.nudTeclspe4.Name = "nudTeclspe4"
		Me.nudTeclspe4.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclspe4.TabIndex = 39
		Me.nudTeclspe4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclspe4.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudTeclspe1
		'
		Me.nudTeclspe1.DecimalPlaces = 2
		Me.nudTeclspe1.Location = New System.Drawing.Point(451, 57)
		Me.nudTeclspe1.Name = "nudTeclspe1"
		Me.nudTeclspe1.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclspe1.TabIndex = 35
		Me.nudTeclspe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclspe1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTeclhab1du
		'
		Me.nudTeclhab1du.DecimalPlaces = 2
		Me.nudTeclhab1du.Location = New System.Drawing.Point(451, 87)
		Me.nudTeclhab1du.Name = "nudTeclhab1du"
		Me.nudTeclhab1du.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclhab1du.TabIndex = 26
		Me.nudTeclhab1du.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclhab1du.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTeclhab4du
		'
		Me.nudTeclhab4du.DecimalPlaces = 2
		Me.nudTeclhab4du.Location = New System.Drawing.Point(739, 87)
		Me.nudTeclhab4du.Name = "nudTeclhab4du"
		Me.nudTeclhab4du.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclhab4du.TabIndex = 25
		Me.nudTeclhab4du.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclhab4du.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label38
		'
		Me.Label38.Location = New System.Drawing.Point(14, 87)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(323, 20)
		Me.Label38.TabIndex = 37
		Me.Label38.Text = "Min flood duration to observe habitat worsening (days) T22,m"
		'
		'nudTeclhab2du
		'
		Me.nudTeclhab2du.DecimalPlaces = 2
		Me.nudTeclhab2du.Location = New System.Drawing.Point(547, 87)
		Me.nudTeclhab2du.Name = "nudTeclhab2du"
		Me.nudTeclhab2du.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclhab2du.TabIndex = 36
		Me.nudTeclhab2du.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclhab2du.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'Label42
		'
		Me.Label42.Location = New System.Drawing.Point(739, 22)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(90, 20)
		Me.Label42.TabIndex = 37
		Me.Label42.Text = "80-100%"
		Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label41
		'
		Me.Label41.Location = New System.Drawing.Point(643, 22)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(90, 20)
		Me.Label41.TabIndex = 37
		Me.Label41.Text = "60-80%"
		Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label43
		'
		Me.Label43.Location = New System.Drawing.Point(355, 22)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(90, 20)
		Me.Label43.TabIndex = 37
		Me.Label43.Text = "0-20%"
		Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label40
		'
		Me.Label40.Location = New System.Drawing.Point(547, 22)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(90, 20)
		Me.Label40.TabIndex = 37
		Me.Label40.Text = "40-60%"
		Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label39
		'
		Me.Label39.Location = New System.Drawing.Point(451, 22)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(90, 20)
		Me.Label39.TabIndex = 37
		Me.Label39.Text = "20-40%"
		Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblTa
		'
		Me.lblTa.Location = New System.Drawing.Point(14, 57)
		Me.lblTa.Name = "lblTa"
		Me.lblTa.Size = New System.Drawing.Size(323, 20)
		Me.lblTa.TabIndex = 37
		Me.lblTa.Text = "Min flood depth to observe species worsening (m) T12,m"
		'
		'nudTeclhab3du
		'
		Me.nudTeclhab3du.DecimalPlaces = 2
		Me.nudTeclhab3du.Location = New System.Drawing.Point(643, 87)
		Me.nudTeclhab3du.Name = "nudTeclhab3du"
		Me.nudTeclhab3du.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclhab3du.TabIndex = 29
		Me.nudTeclhab3du.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclhab3du.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTeclspe2
		'
		Me.nudTeclspe2.DecimalPlaces = 2
		Me.nudTeclspe2.Location = New System.Drawing.Point(547, 57)
		Me.nudTeclspe2.Name = "nudTeclspe2"
		Me.nudTeclspe2.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclspe2.TabIndex = 30
		Me.nudTeclspe2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclspe2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTeclspe3
		'
		Me.nudTeclspe3.DecimalPlaces = 2
		Me.nudTeclspe3.Location = New System.Drawing.Point(643, 57)
		Me.nudTeclspe3.Name = "nudTeclspe3"
		Me.nudTeclspe3.Size = New System.Drawing.Size(90, 20)
		Me.nudTeclspe3.TabIndex = 31
		Me.nudTeclspe3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTeclspe3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'frmNegotiation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(941, 553)
		Me.Controls.Add(Me.grbSummary)
		Me.Controls.Add(Me.grbSociologists)
		Me.Controls.Add(Me.grbWeigth)
		Me.Controls.Add(Me.grbInterdependencies)
		Me.Controls.Add(Me.grbEngineers)
		Me.Controls.Add(Me.grbEconomists)
		Me.Controls.Add(Me.grbEcologists)
		Me.Controls.Add(Me.btnLoadData)
		Me.Controls.Add(Me.btnPrev)
		Me.Controls.Add(Me.btnNext)
		Me.Name = "frmNegotiation"
		Me.Text = "Decision Support System"
		CType(Me.dsParameters, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbSummary.ResumeLayout(False)
		Me.tcoSummary.ResumeLayout(False)
		Me.tpaExposure.ResumeLayout(False)
		Me.tpaResilience.ResumeLayout(False)
		Me.tpaScores.ResumeLayout(False)
		Me.tpaGraph0.ResumeLayout(False)
		Me.GroupBox13.ResumeLayout(False)
		Me.GroupBox14.ResumeLayout(False)
		CType(Me.pboScores, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph1.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.pboGraph1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph2.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		CType(Me.pboGraph2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph3.ResumeLayout(False)
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox6.ResumeLayout(False)
		CType(Me.pboGraph3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph4.ResumeLayout(False)
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox8.ResumeLayout(False)
		CType(Me.pboGraph4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph5.ResumeLayout(False)
		Me.GroupBox9.ResumeLayout(False)
		Me.GroupBox10.ResumeLayout(False)
		CType(Me.pboGraph5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph6.ResumeLayout(False)
		Me.GroupBox11.ResumeLayout(False)
		Me.GroupBox12.ResumeLayout(False)
		CType(Me.pboGraph6, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbWeigth.ResumeLayout(False)
		CType(Me.nudFR, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDU, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudS1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudS2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudS3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE31, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudW12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudE11, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbInterdependencies.ResumeLayout(False)
		CType(Me.nudE11r, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudI11x, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOse, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOs, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudse23x, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudse13x, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOsi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOsei, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOei, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOe, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCOi, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbEngineers.ResumeLayout(False)
		CType(Me.nudC, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudD, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbSociologists.ResumeLayout(False)
		CType(Me.nudRTsclsoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRTsclhea, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclsoc1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclsoc4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclhea1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclhea4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclsoc2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclhea2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclsoc3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsclhea3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbEconomists.ResumeLayout(False)
		CType(Me.nudB7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnlan2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnune2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnlan1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnlan4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnune1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnune4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnlan3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTecnune3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRTecnlan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRTecnune, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudm, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudzz, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudz, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudB3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudA3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudV3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbEcologists.ResumeLayout(False)
		CType(Me.nudRTeclhab, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRTeclspe, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclspe4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclspe1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclhab1du, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclhab4du, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclhab2du, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclhab3du, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclspe2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeclspe3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents nudS1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudS3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudC As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudCOs As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblStotwat As System.Windows.Forms.Label
	Friend WithEvents nudCOi As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudCOe As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudDE As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudD As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFloodDepth As System.Windows.Forms.Label
	Friend WithEvents nudV1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudV2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudV3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents grbSociologists As DSSTGroupBox
	Friend WithEvents grbWeigth As DSSTGroupBox
	Friend WithEvents grbEngineers As DSSTGroupBox
	Friend WithEvents grbEcologists As DSSTGroupBox
	Friend WithEvents nudTeclspe1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTa As System.Windows.Forms.Label
	Friend WithEvents nudTeclspe2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTeclspe3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTeclspe4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents grbEconomists As DSSTGroupBox
	Friend WithEvents grbInterdependencies As DSSTGroupBox
	Friend WithEvents grbSummary As DSSTGroupBox
	Friend WithEvents btnNext As System.Windows.Forms.Button
	Friend WithEvents btnPrev As System.Windows.Forms.Button
	Friend WithEvents nudS2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents DatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTminagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTindwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTminenewatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxintwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTpopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTwatperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTpopwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTevaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTretDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatImaxagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIminagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIindwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatImarwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInavwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIpopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIwatperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIpopwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatStotwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatOwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxpolintcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmarwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTsidpayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIsidpayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF14DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF17DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF18DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTurkishAgreementDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DatIraqiAgreementDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataCreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UtenteCreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataAggiornamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UtenteAggiornamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents AnnullatoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataEstrazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dsParameters As DSS.parameters
	Friend WithEvents TAParameters As DSS.parametersTableAdapters.parametersTableAdapter
	Friend WithEvents lblUnit1 As System.Windows.Forms.Label
	Friend WithEvents lblUnit As System.Windows.Forms.Label
	Friend WithEvents lblfef1 As System.Windows.Forms.Label
	Friend WithEvents lblNoMitigation As System.Windows.Forms.Label
	Friend WithEvents nudE11 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblmop2 As System.Windows.Forms.Label
	Friend WithEvents lblmop1 As System.Windows.Forms.Label
	Friend WithEvents lblFloodDuration As System.Windows.Forms.Label
	Friend WithEvents nudDU As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblRelativeDistance As System.Windows.Forms.Label
	Friend WithEvents nudY As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label49 As System.Windows.Forms.Label
	Friend WithEvents Label48 As System.Windows.Forms.Label
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents Label18 As System.Windows.Forms.Label
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents nudE31 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudE21 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudE23 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudE22 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudE13 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudE12 As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label51 As System.Windows.Forms.Label
	Friend WithEvents Label50 As System.Windows.Forms.Label
	Friend WithEvents Label47 As System.Windows.Forms.Label
	Friend WithEvents Label54 As System.Windows.Forms.Label
	Friend WithEvents Label53 As System.Windows.Forms.Label
	Friend WithEvents Label52 As System.Windows.Forms.Label
	Friend WithEvents Label63 As System.Windows.Forms.Label
	Friend WithEvents Label55 As System.Windows.Forms.Label
	Friend WithEvents Label62 As System.Windows.Forms.Label
	Friend WithEvents Label57 As System.Windows.Forms.Label
	Friend WithEvents Label56 As System.Windows.Forms.Label
	Friend WithEvents nudV7 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnune4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudV8 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudV4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudV5 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudz As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudV6 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB7 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA7 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnune2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnune1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB8 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA8 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnune3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB5 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA5 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB6 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA6 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudB3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudA3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTeclhab1du As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTeclhab4du As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label38 As System.Windows.Forms.Label
	Friend WithEvents nudTeclhab2du As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTeclhab3du As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label42 As System.Windows.Forms.Label
	Friend WithEvents Label41 As System.Windows.Forms.Label
	Friend WithEvents Label43 As System.Windows.Forms.Label
	Friend WithEvents Label40 As System.Windows.Forms.Label
	Friend WithEvents Label39 As System.Windows.Forms.Label
	Friend WithEvents nudTsclsoc1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTsclsoc4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTsclhea1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTsclhea4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents nudTsclsoc2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents Label25 As System.Windows.Forms.Label
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents Label28 As System.Windows.Forms.Label
	Friend WithEvents Label34 As System.Windows.Forms.Label
	Friend WithEvents nudTsclhea2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTsclsoc3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTsclhea3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label35 As System.Windows.Forms.Label
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents Label82 As System.Windows.Forms.Label
	Friend WithEvents Label36 As System.Windows.Forms.Label
	Friend WithEvents Label81 As System.Windows.Forms.Label
	Friend WithEvents Label80 As System.Windows.Forms.Label
	Friend WithEvents Label79 As System.Windows.Forms.Label
	Friend WithEvents nudCOse As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudCOsi As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudCOsei As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudCOei As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label87 As System.Windows.Forms.Label
	Friend WithEvents Label85 As System.Windows.Forms.Label
	Friend WithEvents Label84 As System.Windows.Forms.Label
	Friend WithEvents Label83 As System.Windows.Forms.Label
	Friend WithEvents nudse23x As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudse13x As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents Label33 As System.Windows.Forms.Label
	Friend WithEvents Label31 As System.Windows.Forms.Label
	Friend WithEvents Label30 As System.Windows.Forms.Label
	Friend WithEvents Label29 As System.Windows.Forms.Label
	Friend WithEvents Label27 As System.Windows.Forms.Label
	Friend WithEvents DSData As DSS.DSData
	Friend WithEvents daData As SqlClient.SqlDataAdapter
	Friend WithEvents tcoSummary As System.Windows.Forms.TabControl
	Friend WithEvents tpaExposure As System.Windows.Forms.TabPage
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents Label90 As System.Windows.Forms.Label
	Friend WithEvents Label91 As System.Windows.Forms.Label
	Friend WithEvents Label92 As System.Windows.Forms.Label
	Friend WithEvents Label93 As System.Windows.Forms.Label
	Friend WithEvents lblF23sei As System.Windows.Forms.Label
	Friend WithEvents lblF23ei As System.Windows.Forms.Label
	Friend WithEvents lblF23si As System.Windows.Forms.Label
	Friend WithEvents lblF23se As System.Windows.Forms.Label
	Friend WithEvents lblF23i As System.Windows.Forms.Label
	Friend WithEvents lblF23e As System.Windows.Forms.Label
	Friend WithEvents lblF23s As System.Windows.Forms.Label
	Friend WithEvents lblF23 As System.Windows.Forms.Label
	Friend WithEvents lblF13sei As System.Windows.Forms.Label
	Friend WithEvents lblF13ei As System.Windows.Forms.Label
	Friend WithEvents lblF13si As System.Windows.Forms.Label
	Friend WithEvents lblF13se As System.Windows.Forms.Label
	Friend WithEvents lblF13i As System.Windows.Forms.Label
	Friend WithEvents lblF13e As System.Windows.Forms.Label
	Friend WithEvents lblF13s As System.Windows.Forms.Label
	Friend WithEvents lblF13 As System.Windows.Forms.Label
	Friend WithEvents lblF22sei As System.Windows.Forms.Label
	Friend WithEvents lblF22ei As System.Windows.Forms.Label
	Friend WithEvents lblF22si As System.Windows.Forms.Label
	Friend WithEvents lblF22se As System.Windows.Forms.Label
	Friend WithEvents lblF22i As System.Windows.Forms.Label
	Friend WithEvents lblF22e As System.Windows.Forms.Label
	Friend WithEvents lblF22s As System.Windows.Forms.Label
	Friend WithEvents lblF22 As System.Windows.Forms.Label
	Friend WithEvents lblF12sei As System.Windows.Forms.Label
	Friend WithEvents lblF12ei As System.Windows.Forms.Label
	Friend WithEvents lblF12si As System.Windows.Forms.Label
	Friend WithEvents lblF12se As System.Windows.Forms.Label
	Friend WithEvents lblF12i As System.Windows.Forms.Label
	Friend WithEvents lblF12e As System.Windows.Forms.Label
	Friend WithEvents lblF12s As System.Windows.Forms.Label
	Friend WithEvents lblF12 As System.Windows.Forms.Label
	Friend WithEvents lblF31sei As System.Windows.Forms.Label
	Friend WithEvents lblF31ei As System.Windows.Forms.Label
	Friend WithEvents lblF31si As System.Windows.Forms.Label
	Friend WithEvents lblF31se As System.Windows.Forms.Label
	Friend WithEvents lblF31i As System.Windows.Forms.Label
	Friend WithEvents lblF31e As System.Windows.Forms.Label
	Friend WithEvents lblF31s As System.Windows.Forms.Label
	Friend WithEvents lblF31 As System.Windows.Forms.Label
	Friend WithEvents lblF21sei As System.Windows.Forms.Label
	Friend WithEvents lblF21ei As System.Windows.Forms.Label
	Friend WithEvents lblF21si As System.Windows.Forms.Label
	Friend WithEvents lblF21se As System.Windows.Forms.Label
	Friend WithEvents lblF21i As System.Windows.Forms.Label
	Friend WithEvents lblF21e As System.Windows.Forms.Label
	Friend WithEvents lblF21s As System.Windows.Forms.Label
	Friend WithEvents lblF21 As System.Windows.Forms.Label
	Friend WithEvents lblF11sei As System.Windows.Forms.Label
	Friend WithEvents lblF11ei As System.Windows.Forms.Label
	Friend WithEvents lblF11si As System.Windows.Forms.Label
	Friend WithEvents lblF11se As System.Windows.Forms.Label
	Friend WithEvents lblF11i As System.Windows.Forms.Label
	Friend WithEvents lblF11e As System.Windows.Forms.Label
	Friend WithEvents lblF11s As System.Windows.Forms.Label
	Friend WithEvents lblF11 As System.Windows.Forms.Label
	Friend WithEvents Label102 As System.Windows.Forms.Label
	Friend WithEvents Label106 As System.Windows.Forms.Label
	Friend WithEvents Label105 As System.Windows.Forms.Label
	Friend WithEvents Label109 As System.Windows.Forms.Label
	Friend WithEvents Label108 As System.Windows.Forms.Label
	Friend WithEvents Label107 As System.Windows.Forms.Label
	Friend WithEvents Label104 As System.Windows.Forms.Label
	Friend WithEvents Label103 As System.Windows.Forms.Label
	Friend WithEvents Label95 As System.Windows.Forms.Label
	Friend WithEvents Label96 As System.Windows.Forms.Label
	Friend WithEvents Label97 As System.Windows.Forms.Label
	Friend WithEvents Label98 As System.Windows.Forms.Label
	Friend WithEvents Label99 As System.Windows.Forms.Label
	Friend WithEvents Label100 As System.Windows.Forms.Label
	Friend WithEvents Label101 As System.Windows.Forms.Label
	Friend WithEvents tpaGraph1 As System.Windows.Forms.TabPage
	Friend WithEvents pboGraph1 As System.Windows.Forms.PictureBox
	Friend WithEvents tpaGraph2 As System.Windows.Forms.TabPage
	Friend WithEvents pboGraph2 As System.Windows.Forms.PictureBox
	Friend WithEvents tpaGraph3 As System.Windows.Forms.TabPage
	Friend WithEvents pboGraph3 As System.Windows.Forms.PictureBox
	Friend WithEvents cboB21 As System.Windows.Forms.ComboBox
	Friend WithEvents cboW23 As System.Windows.Forms.ComboBox
	Friend WithEvents cboB23 As System.Windows.Forms.ComboBox
	Friend WithEvents cboW22 As System.Windows.Forms.ComboBox
	Friend WithEvents cboB22 As System.Windows.Forms.ComboBox
	Friend WithEvents cboW13 As System.Windows.Forms.ComboBox
	Friend WithEvents cboB13 As System.Windows.Forms.ComboBox
	Friend WithEvents cboW31 As System.Windows.Forms.ComboBox
	Friend WithEvents cboB31 As System.Windows.Forms.ComboBox
	Friend WithEvents cboW21 As System.Windows.Forms.ComboBox
	Friend WithEvents nudT As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudP As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label61 As System.Windows.Forms.Label
	Friend WithEvents Label60 As System.Windows.Forms.Label
	Friend WithEvents tpaGraph4 As System.Windows.Forms.TabPage
	Friend WithEvents tpaGraph5 As System.Windows.Forms.TabPage
	Friend WithEvents nudFR As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFR As System.Windows.Forms.Label
	Friend WithEvents nudRTecnlan As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudRTecnune As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label69 As System.Windows.Forms.Label
	Friend WithEvents Label68 As System.Windows.Forms.Label
	Friend WithEvents Label67 As System.Windows.Forms.Label
	Friend WithEvents Label66 As System.Windows.Forms.Label
	Friend WithEvents nudRTeclhab As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudRTeclspe As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label73 As System.Windows.Forms.Label
	Friend WithEvents Label74 As System.Windows.Forms.Label
	Friend WithEvents Label75 As System.Windows.Forms.Label
	Friend WithEvents Label76 As System.Windows.Forms.Label
	Friend WithEvents nudRTsclsoc As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudRTsclhea As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label78 As System.Windows.Forms.Label
	Friend WithEvents Label117 As System.Windows.Forms.Label
	Friend WithEvents Label118 As System.Windows.Forms.Label
	Friend WithEvents Label119 As System.Windows.Forms.Label
	Friend WithEvents nudI11x As System.Windows.Forms.NumericUpDown
	Friend WithEvents tpaResilience As System.Windows.Forms.TabPage
	Friend WithEvents tpaScores As System.Windows.Forms.TabPage
	Friend WithEvents Label110 As System.Windows.Forms.Label
	Friend WithEvents Label111 As System.Windows.Forms.Label
	Friend WithEvents Label112 As System.Windows.Forms.Label
	Friend WithEvents Label113 As System.Windows.Forms.Label
	Friend WithEvents Label114 As System.Windows.Forms.Label
	Friend WithEvents Label115 As System.Windows.Forms.Label
	Friend WithEvents Label116 As System.Windows.Forms.Label
	Friend WithEvents lblR23sei As System.Windows.Forms.Label
	Friend WithEvents lblR23ei As System.Windows.Forms.Label
	Friend WithEvents lblR23si As System.Windows.Forms.Label
	Friend WithEvents lblR23se As System.Windows.Forms.Label
	Friend WithEvents lblR23i As System.Windows.Forms.Label
	Friend WithEvents lblR23e As System.Windows.Forms.Label
	Friend WithEvents lblR23s As System.Windows.Forms.Label
	Friend WithEvents lblR23 As System.Windows.Forms.Label
	Friend WithEvents lblR13sei As System.Windows.Forms.Label
	Friend WithEvents lblR13ei As System.Windows.Forms.Label
	Friend WithEvents lblR13si As System.Windows.Forms.Label
	Friend WithEvents lblR13se As System.Windows.Forms.Label
	Friend WithEvents lblR13i As System.Windows.Forms.Label
	Friend WithEvents lblR13e As System.Windows.Forms.Label
	Friend WithEvents lblR13s As System.Windows.Forms.Label
	Friend WithEvents lblR13 As System.Windows.Forms.Label
	Friend WithEvents lblR22sei As System.Windows.Forms.Label
	Friend WithEvents lblR22ei As System.Windows.Forms.Label
	Friend WithEvents lblR22si As System.Windows.Forms.Label
	Friend WithEvents lblR22se As System.Windows.Forms.Label
	Friend WithEvents lblR22i As System.Windows.Forms.Label
	Friend WithEvents lblR22e As System.Windows.Forms.Label
	Friend WithEvents lblR22s As System.Windows.Forms.Label
	Friend WithEvents lblR22 As System.Windows.Forms.Label
	Friend WithEvents lblR12sei As System.Windows.Forms.Label
	Friend WithEvents lblR12ei As System.Windows.Forms.Label
	Friend WithEvents lblR12si As System.Windows.Forms.Label
	Friend WithEvents lblR12se As System.Windows.Forms.Label
	Friend WithEvents lblR12i As System.Windows.Forms.Label
	Friend WithEvents lblR12e As System.Windows.Forms.Label
	Friend WithEvents lblR12s As System.Windows.Forms.Label
	Friend WithEvents lblR12 As System.Windows.Forms.Label
	Friend WithEvents lblR31sei As System.Windows.Forms.Label
	Friend WithEvents lblR31ei As System.Windows.Forms.Label
	Friend WithEvents lblR31si As System.Windows.Forms.Label
	Friend WithEvents lblR31se As System.Windows.Forms.Label
	Friend WithEvents lblR31i As System.Windows.Forms.Label
	Friend WithEvents lblR31e As System.Windows.Forms.Label
	Friend WithEvents lblR31s As System.Windows.Forms.Label
	Friend WithEvents lblR31 As System.Windows.Forms.Label
	Friend WithEvents lblR21sei As System.Windows.Forms.Label
	Friend WithEvents lblR21ei As System.Windows.Forms.Label
	Friend WithEvents lblR21si As System.Windows.Forms.Label
	Friend WithEvents lblR21se As System.Windows.Forms.Label
	Friend WithEvents lblR21i As System.Windows.Forms.Label
	Friend WithEvents lblR21e As System.Windows.Forms.Label
	Friend WithEvents lblR21s As System.Windows.Forms.Label
	Friend WithEvents lblR21 As System.Windows.Forms.Label
	Friend WithEvents lblR11sei As System.Windows.Forms.Label
	Friend WithEvents lblR11ei As System.Windows.Forms.Label
	Friend WithEvents lblR11si As System.Windows.Forms.Label
	Friend WithEvents lblR11se As System.Windows.Forms.Label
	Friend WithEvents lblR11i As System.Windows.Forms.Label
	Friend WithEvents lblR11e As System.Windows.Forms.Label
	Friend WithEvents lblR11s As System.Windows.Forms.Label
	Friend WithEvents lblR11 As System.Windows.Forms.Label
	Friend WithEvents Label176 As System.Windows.Forms.Label
	Friend WithEvents Label177 As System.Windows.Forms.Label
	Friend WithEvents Label178 As System.Windows.Forms.Label
	Friend WithEvents Label179 As System.Windows.Forms.Label
	Friend WithEvents Label180 As System.Windows.Forms.Label
	Friend WithEvents Label181 As System.Windows.Forms.Label
	Friend WithEvents Label182 As System.Windows.Forms.Label
	Friend WithEvents Label183 As System.Windows.Forms.Label
	Friend WithEvents Label185 As System.Windows.Forms.Label
	Friend WithEvents Label186 As System.Windows.Forms.Label
	Friend WithEvents Label187 As System.Windows.Forms.Label
	Friend WithEvents Label188 As System.Windows.Forms.Label
	Friend WithEvents Label189 As System.Windows.Forms.Label
	Friend WithEvents Label190 As System.Windows.Forms.Label
	Friend WithEvents Label191 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience5 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue4 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience4 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue3 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience3 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue2 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience2 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue1 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure5 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue4 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure4 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue3 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure3 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue2 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure2 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue1 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience1 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure1 As System.Windows.Forms.Label
	Friend WithEvents Label138 As System.Windows.Forms.Label
	Friend WithEvents Label139 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue7 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience7 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue6 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilience6 As System.Windows.Forms.Label
	Friend WithEvents lblScoreResilienceValue5 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue7 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure7 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue6 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposure6 As System.Windows.Forms.Label
	Friend WithEvents lblScoreExposureValue5 As System.Windows.Forms.Label
	Friend WithEvents pboGraph4 As System.Windows.Forms.PictureBox
	Friend WithEvents pboGraph5 As System.Windows.Forms.PictureBox
	Friend WithEvents tpaGraph6 As System.Windows.Forms.TabPage
	Friend WithEvents pboGraph6 As System.Windows.Forms.PictureBox
	Friend WithEvents Label122 As System.Windows.Forms.Label
	Friend WithEvents Label121 As System.Windows.Forms.Label
	Friend WithEvents Label120 As System.Windows.Forms.Label
	Friend WithEvents nudTecnlan2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnlan1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnlan4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTecnlan3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudm As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudzz As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label130 As System.Windows.Forms.Label
	Friend WithEvents Label128 As System.Windows.Forms.Label
	Friend WithEvents nudB12 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudW12 As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudE11r As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblB11 As System.Windows.Forms.Label
	Friend WithEvents lblW11 As System.Windows.Forms.Label
	Friend WithEvents cboRTecnlanQ As System.Windows.Forms.ComboBox
	Friend WithEvents cboRTecnuneQ As System.Windows.Forms.ComboBox
	Friend WithEvents cboRTeclhabQ As System.Windows.Forms.ComboBox
	Friend WithEvents cboRTeclspeQ As System.Windows.Forms.ComboBox
	Friend WithEvents cboRTsclsocQ As System.Windows.Forms.ComboBox
	Friend WithEvents cboRTsclheaQ As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph11e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph11i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph11sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph11ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph11si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph11se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph11s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph12e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph12i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph12sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph12ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph12si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph12se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph12s As System.Windows.Forms.RadioButton
	Friend WithEvents btnRedraw1 As System.Windows.Forms.Button
	Friend WithEvents btnRedraw2 As System.Windows.Forms.Button
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph21e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph21i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph21sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph21ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph21si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph21se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph21s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph22e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph22i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph22sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph22ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph22si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph22se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph22s As System.Windows.Forms.RadioButton
	Friend WithEvents btnRedraw3 As System.Windows.Forms.Button
	Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph31e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph31i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph31sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph31ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph31si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph31se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph31s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph32e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph32i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph32sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph32ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph32si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph32se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph32s As System.Windows.Forms.RadioButton
	Friend WithEvents btnRedraw4 As System.Windows.Forms.Button
	Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph41e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph41i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph41sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph41ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph41si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph41se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph41s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph42e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph42i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph42sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph42ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph42si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph42se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph42s As System.Windows.Forms.RadioButton
	Friend WithEvents btnRedraw5 As System.Windows.Forms.Button
	Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph51e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph51i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph51sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph51ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph51si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph51se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph51s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph52e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph52i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph52sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph52ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph52si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph52se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph52s As System.Windows.Forms.RadioButton
	Friend WithEvents btnRedraw6 As System.Windows.Forms.Button
	Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph61e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph61i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph61sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph61ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph61si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph61se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph61s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph62e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph62i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph62sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph62ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph62si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph62se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph62s As System.Windows.Forms.RadioButton
	Friend WithEvents tpaGraph0 As System.Windows.Forms.TabPage
	Friend WithEvents pboScores As System.Windows.Forms.PictureBox
	Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph01e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph01i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph01sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph01ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph01si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph01se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph01s As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
	Friend WithEvents rbuGraph02e As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph02i As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph02sei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph02ei As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph02si As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph02se As System.Windows.Forms.RadioButton
	Friend WithEvents rbuGraph02s As System.Windows.Forms.RadioButton
	Friend WithEvents btnRedraw0 As System.Windows.Forms.Button
	Friend WithEvents btnLoadData As System.Windows.Forms.Button
	Friend WithEvents SqlInsertCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
	Friend WithEvents SqlSelectCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents btnPlus1 As System.Windows.Forms.Button
	Friend WithEvents btnMinus1 As System.Windows.Forms.Button
	Friend WithEvents btnPlus2 As System.Windows.Forms.Button
	Friend WithEvents btnMinus2 As System.Windows.Forms.Button
	Friend WithEvents btnPlus3 As System.Windows.Forms.Button
	Friend WithEvents btnMinus3 As System.Windows.Forms.Button
	Friend WithEvents btnPlus4 As System.Windows.Forms.Button
	Friend WithEvents btnMinus4 As System.Windows.Forms.Button
	Friend WithEvents btnPlus5 As System.Windows.Forms.Button
	Friend WithEvents btnMinus5 As System.Windows.Forms.Button
	Friend WithEvents btnPlus6 As System.Windows.Forms.Button
	Friend WithEvents btnMinus6 As System.Windows.Forms.Button

End Class
