
Imports Units.Units.Mass

Namespace Global.Units.UnitValue.Mass

    Partial Public NotInheritable Class Kilograms : Inherits AbstractUnitValue(Of Units.Mass.Kilograms)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Mass.Kilograms.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Mass.Kilograms)
            Return New Kilograms(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Kilograms
            Return New Kilograms(x)
        End Operator


    End Class

End Namespace