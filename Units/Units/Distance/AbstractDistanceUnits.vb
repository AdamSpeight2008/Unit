Namespace Global.Units.Units.Distance
    Interface IUnitsKind_Distance : Inherits IAbstractUnits
    End Interface

    Public MustInherit Class AbstractDistanceUnits
        Inherits AbstractUnits

        Implements IUnitsKind_Distance

        Friend Sub New(Symbol As String, FullName As String)
            Me.Symbol = Symbol
            Me.FullName = FullName
        End Sub
        Public Overrides ReadOnly Property Symbol As String Implements IAbstractUnits.Symbol
        Public Overrides ReadOnly Property FullName As String Implements IAbstractUnits.FullName
    End Class
End Namespace