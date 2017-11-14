Namespace Global.Units.Units.Distance

    Partial Public NotInheritable Class Millimetres : Inherits AbstractTimeUnits
        Public Shared ReadOnly Property Instance As New Millimetres
        Private Sub New()
            MyBase.New("mm", "millimetres")
        End Sub
    End Class

End Namespace
