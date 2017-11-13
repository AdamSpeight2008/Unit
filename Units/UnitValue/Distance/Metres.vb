
Namespace Global.Units.UnitValue.Distance

    Partial Public NotInheritable Class Metres : Inherits AbstractUnitValue(Of Units.Distance.Metres)
        Public Sub New(Value As Decimal)
            MyBase.New(Value, Global.Units.Units.Distance.Metres.Instance)
        End Sub

        Public Shared Widening Operator CType(x As Decimal) As Metres
            Return New Metres(x)
        End Operator
    End Class

End Namespace