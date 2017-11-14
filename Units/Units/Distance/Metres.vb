Imports Units.UnitValue.Distance

Namespace Global.Units.Units.Distance

    Partial Public NotInheritable Class Metres : Inherits AbstractTimeUnits
        Public Shared ReadOnly Property Instance As New Metres
        Private Sub New()
            MyBase.New("m", "metres")
        End Sub

    End Class

End Namespace
