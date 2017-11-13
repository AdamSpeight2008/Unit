Namespace Global.Units.Units.Distance

    Public NotInheritable Class Metres : Inherits AbstractDistanceUnits
        Public Shared ReadOnly Property Instance As New Metres
        Private Sub New()
            MyBase.New("m", "metres")
        End Sub
    End Class

End Namespace
