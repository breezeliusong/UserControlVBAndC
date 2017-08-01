' The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236



Partial Public NotInheritable Class CustomImage
    Inherits UserControl
    Public Sub New()
        Me.InitializeComponent()
        Me.DataContext = Me
    End Sub



    Public Property MySource() As String
        Get
            Return DirectCast(GetValue(MySourceProperty), String)
        End Get
        Set
            SetValue(MySourceProperty, Value)
        End Set
    End Property

    ' Using a DependencyProperty as the backing store for MySource.  This enables animation, styling, binding, etc...
    Public Shared ReadOnly MySourceProperty As DependencyProperty = DependencyProperty.Register("MySource", GetType(String), GetType(CustomImage), New PropertyMetadata(Nothing))



    Public Property MyAngle() As Double
        Get
            Return CDbl(GetValue(MyAngleProperty))
        End Get
        Set
            SetValue(MyAngleProperty, Value)
        End Set
    End Property

    ' Using a DependencyProperty as the backing store for MyAngle.  This enables animation, styling, binding, etc...
    Public Shared ReadOnly MyAngleProperty As DependencyProperty = DependencyProperty.Register("MyAngle", GetType(Double), GetType(CustomImage), New PropertyMetadata(Nothing))


End Class