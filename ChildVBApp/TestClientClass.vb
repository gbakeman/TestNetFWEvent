Imports ParentCSLib

Public Class TestClientClass
    Inherits EventGenerator

    Public Sub TestRaiseInheritedEvent()
        ' BC31132
        RaiseEvent SomethingHappened()
    End Sub
End Class
