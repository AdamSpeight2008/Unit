Imports Units.UnitValue.Distance

Namespace Global.Units.Units.Distance

    Partial Public NotInheritable Class Metres : Inherits AbstractDistanceUnits
        Public Shared ReadOnly Property Instance As New Metres
        Private Sub New()
            MyBase.New("m", "metres")
        End Sub

        Public Shared Narrowing Operator CType(v As UnitValue.Distance.Millimetres) As Metres
            Throw New NotImplementedException()
        End Operator
    End Class

End Namespace
