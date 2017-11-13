Imports Units.Units

Namespace Global.Units.UnitValue.Distace

    Public NotInheritable Class Metres : Inherits UnitValue.AbstractUnitValue(Of Distance.Metres)
        Public Sub New(Value As Decimal)
            MyBase.New(Value, Distance.Metres.Instance)
        End Sub
    End Class

End Namespace