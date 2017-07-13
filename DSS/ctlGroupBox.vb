Public Class DSSTGroupBox

    'Private firstIteration As Boolean

    Public Event DSSTInit()

    Public Property DSSTVisible() As Boolean
        Get
            Return Me.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.Visible = value
            'If value AndAlso Me.firstIteration Then
            If value Then
                'Me.firstIteration = False
                RaiseEvent DSSTInit()
            End If
        End Set
    End Property

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        'Me.firstIteration = True
        Me.Visible = False
    End Sub
End Class
