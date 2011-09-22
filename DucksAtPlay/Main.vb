Imports HeadFirstPatternsCore.CompositionRocks
Imports HeadFirstPatternsCore.InheritanceNightmare
Imports Castle.Windsor
Imports Castle.MicroKernel.Registration

Public Class Main
    Private _container As IWindsorContainer

    Private Sub Quack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quack.Click
        If (Not IsNothing(lstDuckCollection.SelectedValue)) Then
            Dim duckType = lstDuckCollection.SelectedValue
            Dim Duck = _container.Resolve(lstDuckCollection.SelectedValue)
            lblSelectedDuck.Text = lstDuckCollection.SelectedValue.ToString()
            If (HasMethod(Duck, "Quack")) Then
                Duck.Quack()
            Else
                MsgBox("I cant Quack")
            End If
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
        _container.Register((Component.For(Of SuperDuck).ImplementedBy(Of SuperDuck)()))
        _container.Register((Component.For(Of HeadFirstPatternsCore.CompositionRocks.RubberDuck).ImplementedBy(Of HeadFirstPatternsCore.CompositionRocks.RubberDuck)()))

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
            lblSelectedDuck.Text = lstDuckCollection.SelectedValue.ToString()

            'NOTE Check if the Class implements that method
            If (HasMethod(Duck, "Fly")) Then
                Duck.Fly()
            Else
                MsgBox("I cant Fly")
            End If
        End If
    End Sub

    Private Sub Swim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Swim.Click
        If (Not IsNothing(lstDuckCollection.SelectedValue)) Then
            Dim duckType = lstDuckCollection.SelectedValue
            Dim Duck = _container.Resolve(lstDuckCollection.SelectedValue)
            lblSelectedDuck.Text = lstDuckCollection.SelectedValue.ToString()
            If (HasMethod(Duck, "Swim")) Then
                Duck.Swim()
            Else
                MsgBox("I cant Swim")
            End If
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
End Class
