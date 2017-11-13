Namespace Global.Units.Units.Distance

    Partial Public NotInheritable Class Millimetres : Inherits AbstractDistanceUnits
        Public Shared ReadOnly Property Instance As New Millimetres
        Private Sub New()
            MyBase.New("mm", "millimetres")
        End Sub
    End Class

End Namespace
