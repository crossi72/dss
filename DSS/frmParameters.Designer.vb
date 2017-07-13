<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParameters
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtParKernelPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSetPath = New System.Windows.Forms.Button
        Me.Parameters = New DSS.parameters
        Me.ParametersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAParameters = New DSS.parametersTableAdapters.parametersTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.Parameters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Executable files (*.exe)|*.exe|All files|*.*"
        '
        'txtParKernelPath
        '
        Me.txtParKernelPath.Location = New System.Drawing.Point(12, 57)
        Me.txtParKernelPath.Name = "txtParKernelPath"
        Me.txtParKernelPath.Size = New System.Drawing.Size(420, 20)
        Me.txtParKernelPath.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wolfram Mathematica kernel path"
        '
        'btnSetPath
        '
        Me.btnSetPath.Location = New System.Drawing.Point(438, 57)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(24, 20)
        Me.btnSetPath.TabIndex = 1
        Me.btnSetPath.Text = "..."
        Me.btnSetPath.UseVisualStyleBackColor = True
        '
        'Parameters
        '
        Me.Parameters.DataSetName = "parameters"
        Me.Parameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParametersBindingSource
        '
        Me.ParametersBindingSource.DataMember = "parameters"
        Me.ParametersBindingSource.DataSource = Me.Parameters
        '
        'TAParameters
        '
        Me.TAParameters.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wolfram Mathematica Player is freely donwloadable here"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 117)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(271, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.wolfram.com/products/player/download.cgi"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(277, 175)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(196, 175)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 451)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnSetPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParKernelPath)
        Me.Name = "frmParameters"
        Me.Text = "parameters setting"
        CType(Me.Parameters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtParKernelPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSetPath As System.Windows.Forms.Button
    Friend WithEvents Parameters As DSS.parameters
    Friend WithEvents ParametersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAParameters As DSS.parametersTableAdapters.parametersTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
