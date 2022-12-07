Imports ParentCSLib

Module Module1

    Sub Main()
        Dim testClass = New TestClientClass()

        ' Ask the base class to raise its own event
        testClass.SampleMethod()

        ' Now let the inherited class do it.
        testClass.TestRaiseInheritedEvent()
    End Sub

End Module
