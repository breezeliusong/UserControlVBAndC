' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Public Property ImagePath() As String
        Get
            Return m_ImagePath
        End Get
        Set
            m_ImagePath = Value
        End Set
    End Property
    Private m_ImagePath As String
    Public Sub New()
        Me.InitializeComponent()
        ImagePath = "BlankTrain.png"
    End Sub

End Class
