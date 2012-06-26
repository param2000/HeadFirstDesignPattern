Imports HeadFirstPatternsCore.CompositionRocks
Imports HeadFirstPatternsCore.InheritanceNightmare
Imports Castle.Windsor
Imports Castle.MicroKernel.Registration
Imports System.Reflection

Public Class Main
    Private _container As IWindsorContainer

    Private Sub Quack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quack.Click
        If (Not IsNothing(lstDuckCollection.SelectedValue)) Then
            Dim duckType = lstDuckCollection.SelectedValue
            Dim Duck = _container.Resolve(lstDuckCollection.SelectedValue)
            PerformBehavior(Duck, "Quack")
        End If
    End Sub

    Private Sub PerformBehavior(ByVal _duck As Object, ByVal behavior As String)
        If (HasMethod(_duck, behavior)) Then
            Dim type = _duck.GetType()
            Dim s = CType(type.InvokeMember(behavior, BindingFlags.InvokeMethod Or BindingFlags.Public Or BindingFlags.Instance Or BindingFlags.ExactBinding, Nothing, _duck, Nothing), [String])
        Else
            MsgBox("I cant " + behavior)
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _container = New WindsorContainer()

        RegisterCOmponents()
        LoadListBox()
    End Sub

    'NOTE register components in container 
    Private Sub RegisterCOmponents()
        _container.Register(Component.For(Of ICanFly).ImplementedBy(Of CanFly)())
        _container.Register(Component.For(Of ICanSwim).ImplementedBy(Of CanSwim)())
        _container.Register(Component.For(Of ICanQuack).ImplementedBy(Of CanQuack)())

        _container.Register((Component.For(Of HeadFirstPatternsCore.CompositionRocks.MallardDuck).ImplementedBy(Of HeadFirstPatternsCore.CompositionRocks.MallardDuck)()))
        _container.Register((Component.For(Of HeadFirstPatternsCore.CompositionRocks.RubberDuck).ImplementedBy(Of HeadFirstPatternsCore.CompositionRocks.RubberDuck)()))
        _container.Register((Component.For(Of HeadFirstPatternsCore.CompositionRocks.CanadianDuck).ImplementedBy(Of HeadFirstPatternsCore.CompositionRocks.CanadianDuck)()))

        _container.Register((Component.For(Of HeadFirstPatternsCore.InheritanceNightmare.MallardDuck).ImplementedBy(Of HeadFirstPatternsCore.InheritanceNightmare.MallardDuck)()))
        _container.Register((Component.For(Of HeadFirstPatternsCore.InheritanceNightmare.RubberDuck).ImplementedBy(Of HeadFirstPatternsCore.InheritanceNightmare.RubberDuck)()))
        _container.Register((Component.For(Of HeadFirstPatternsCore.InheritanceNightmare.CanadianDuck).ImplementedBy(Of HeadFirstPatternsCore.InheritanceNightmare.CanadianDuck)()))

    End Sub

    Private Sub LoadListBox()
        lstDuckCollection.DataSource = New DuckCollection().Ducks
        lstDuckCollection.DisplayMember = "Name"
        lstDuckCollection.ValueMember = "Value"
    End Sub

    Private Sub Fly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fly.Click
        If (Not IsNothing(lstDuckCollection.SelectedValue)) Then
            Dim duckType = lstDuckCollection.SelectedValue
            Dim Duck = _container.Resolve(lstDuckCollection.SelectedValue)
            
            'NOTE Check if the Class implements that method
            PerformBehavior(Duck, "Fly")
        End If
    End Sub

    Private Sub Swim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Swim.Click
        If (Not IsNothing(lstDuckCollection.SelectedValue)) Then
            Dim duckType = lstDuckCollection.SelectedValue
            Dim Duck = _container.Resolve(lstDuckCollection.SelectedValue)
            PerformBehavior(Duck, "Swim")
        End If
    End Sub

    Private Sub ChangeToComposition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToComposition.Click
        lstDuckCollection.DataSource = New ComposistionDuckCollections().Ducks
        lstDuckCollection.DisplayMember = "Name"
        lstDuckCollection.ValueMember = "Value"
    End Sub

    Public Shared Function HasMethod(ByVal objectToCheck As Object, ByVal methodName As String) As Boolean
        Dim type = objectToCheck.GetType()
        If (IsNothing(type.GetMethod(methodName))) Then
            Return False
        End If
        Return True
    End Function

    Private Sub ChangeToInheritance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToInheritance.Click
        lstDuckCollection.DataSource = New DuckCollection().Ducks
        lstDuckCollection.DisplayMember = "Name"
        lstDuckCollection.ValueMember = "Value"
    End Sub

    Private Sub lstDuckCollection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDuckCollection.SelectedIndexChanged
        If (Not IsNothing(lstDuckCollection.SelectedValue)) Then
            lblSelectedDuck.Text = lstDuckCollection.SelectedValue.ToString()
        End If
    End Sub

  
    
End Class
