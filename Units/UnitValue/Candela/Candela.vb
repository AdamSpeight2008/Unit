
Imports Units.Units.LuminousIntensity

Namespace Global.Units.UnitValue.LuminousIntensity

    Partial Public NotInheritable Class Candela : Inherits AbstractUnitValue(Of Units.LuminousIntensity.Candela)

        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.LuminousIntensity.Candela.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.LuminousIntensity.Candela)
            Return New Candela(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Candela
            Return New Candela(x)
        End Operator


    End Class

End Namespace