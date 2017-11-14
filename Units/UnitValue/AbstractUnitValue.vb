Namespace Global.Units.UnitValue

    Public Interface IUnitValue(Of TUnits As Units.AbstractUnits)
        ReadOnly Property Value As Decimal
        ReadOnly Property Units As TUnits
    End Interface

    Partial Public MustInherit Class AbstractUnitValue(Of TUnits As Units.AbstractUnits)
        Implements IUnitValue(Of TUnits), IComparable(Of AbstractUnitValue(Of TUnits))

        Friend Sub New(Value As Decimal, Units As TUnits)
            Me.Value = Value
            Me.Units = Units
        End Sub
        Public ReadOnly Property Value As Decimal Implements IUnitValue(Of TUnits).Value
        Public ReadOnly Property Units As TUnits Implements IUnitValue(Of TUnits).Units

        Friend MustOverride Function CreateNew(Value As Decimal) As AbstractUnitValue(Of TUnits)

        Private Function Op_Add(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As AbstractUnitValue(Of TUnits)
            Return L.CreateNew(L.Value + R.Value)
        End Function
        Private Function Op_Sub(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As AbstractUnitValue(Of TUnits)
            Return L.CreateNew(L.Value - R.Value)
        End Function

        Public Shared Operator +(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As AbstractUnitValue(Of TUnits)
            Return L.Op_Add(L, R)
        End Operator
        Public Shared Operator -(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As AbstractUnitValue(Of TUnits)
            Return L.Op_Sub(L, R)
        End Operator
#Region "ToString"
        Public Overrides Function ToString() As String
            Return ToString("")
        End Function
        Public Overloads Function ToString(format As String) As String
            Return $"{Value} {Me.Units.ToString(format)}"
        End Function
#End Region

        Public Function CompareTo(other As AbstractUnitValue(Of TUnits)) As Integer Implements IComparable(Of AbstractUnitValue(Of TUnits)).CompareTo
            If other Is Nothing Then Throw New ArgumentNullException(NameOf(other))
            Return Me.Value.CompareTo(other.Value)
        End Function

#Region "Comparison Operators"
        Public Shared Operator <(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As Boolean
            Return L.CompareTo(R) < 0
        End Operator
        Public Shared Operator <=(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As Boolean
            Return L.CompareTo(R) <= 0
        End Operator
        Public Shared Operator >(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As Boolean
            Return L.CompareTo(R) > 0
        End Operator
        Public Shared Operator >=(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As Boolean
            Return L.CompareTo(R) >= 0
        End Operator
        Public Shared Operator <>(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As Boolean
            Return L.CompareTo(R) <> 0
        End Operator
        Public Shared Operator =(L As AbstractUnitValue(Of TUnits), R As AbstractUnitValue(Of TUnits)) As Boolean
            Return L.CompareTo(R) = 0
        End Operator
#End Region
    End Class

End Namespace