﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
 System.ServiceModel.ServiceContractAttribute([Namespace]:="http://WCF_SharePointCallingService", ConfigurationName:="ISharePointItemInserter")>  _
Public Interface ISharePointItemInserter
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://WCF_SharePointCallingService/ISharePointItemInserter/InsertItem", ReplyAction:="http://WCF_SharePointCallingService/ISharePointItemInserter/InsertItemResponse")>  _
    Function InsertItem(ByVal Title As String, ByVal Body As String) As Boolean
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
Public Interface ISharePointItemInserterChannel
    Inherits ISharePointItemInserter, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(),  _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
Partial Public Class SharePointItemInserterClient
    Inherits System.ServiceModel.ClientBase(Of ISharePointItemInserter)
    Implements ISharePointItemInserter
    
    Public Sub New()
        MyBase.New
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String)
        MyBase.New(endpointConfigurationName)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub
    
    Public Function InsertItem(ByVal Title As String, ByVal Body As String) As Boolean Implements ISharePointItemInserter.InsertItem
        Return MyBase.Channel.InsertItem(Title, Body)
    End Function
End Class
