
Imports Units.Units.Distance

Namespace Global.Units.UnitValue.Distance

    Partial Public NotInheritable Class Metres : Inherits AbstractUnitValue(Of Units.Distance.Metres)


        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Distance.Metres.Instance)
        End Sub

        Friend Overrides Function CreateNew(Value As Decimal) As AbstractUnitValue(Of Units.Distance.Metres)
            Return New Metres(Value)
        End Function

        Public Shared Widening Operator CType(x As Decimal) As Metres
            Return New Metres(x)
        End Operator

        Public Shared Narrowing Operator CType(x As Metres) As Millimetres
            Return New Millimetres(x.Value * 1000D)
        End Operator

    End Class

End Namespace