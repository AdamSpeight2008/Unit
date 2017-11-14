Imports Units.UnitValue.Time

Namespace Global.Units.Units.Time

    Partial Public NotInheritable Class Minutes : Inherits AbstractTimeUnits
        Public Shared ReadOnly Property Instance As New Minutes
        Private Sub New()
            MyBase.New("M", "minutes")
        End Sub
    End Class

End Namespace
