Namespace Global.Units.Units.Electric.Current
    Interface IUnitsKind_Current : Inherits IAbstractUnits
    End Interface

    Partial Public MustInherit Class AbstractCurrentUnits
        Inherits AbstractUnits

        Implements IUnitsKind_Current

        Friend Sub New(Symbol As String, FullName As String)
            Me.Symbol = Symbol
            Me.FullName = FullName
        End Sub
        Public Overrides ReadOnly Property Symbol As String Implements IAbstractUnits.Symbol
        Public Overrides ReadOnly Property FullName As String Implements IAbstractUnits.FullName
    End Class
End Namespace