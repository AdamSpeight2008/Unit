Imports Units.UnitValue.Time

Namespace Global.Units.Units.Time

    Partial Public NotInheritable Class Seconds : Inherits AbstractTimeUnits
        Public Shared ReadOnly Property Instance As New Seconds
        Private Sub New()
            MyBase.New("s", "secondes")
        End Sub

    End Class

End Namespace
