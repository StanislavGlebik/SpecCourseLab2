﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18444
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью wsdl, версия=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "BasicHttpBinding_ILibraryWCFService", Namespace = "http://tempuri.org/")]
public partial class BasicHttpBinding_ILibraryWCFService : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback GetBookContentOperationCompleted;

    /// <remarks/>
    public BasicHttpBinding_ILibraryWCFService()
    {
        this.Url = "http://libraryservice.azurewebsites.net/Service1.svc";
    }

    /// <remarks/>
    public event GetBookContentCompletedEventHandler GetBookContentCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILibraryWCFService/GetBookContent", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string GetBookContent(int code, [System.Xml.Serialization.XmlIgnoreAttribute()] bool codeSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string clientId)
    {
        object[] results = this.Invoke("GetBookContent", new object[] {
                    code,
                    codeSpecified,
                    clientId});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginGetBookContent(int code, bool codeSpecified, string clientId, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("GetBookContent", new object[] {
                    code,
                    codeSpecified,
                    clientId}, callback, asyncState);
    }

    /// <remarks/>
    public string EndGetBookContent(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void GetBookContentAsync(int code, bool codeSpecified, string clientId)
    {
        this.GetBookContentAsync(code, codeSpecified, clientId, null);
    }

    /// <remarks/>
    public void GetBookContentAsync(int code, bool codeSpecified, string clientId, object userState)
    {
        if ((this.GetBookContentOperationCompleted == null))
        {
            this.GetBookContentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBookContentOperationCompleted);
        }
        this.InvokeAsync("GetBookContent", new object[] {
                    code,
                    codeSpecified,
                    clientId}, this.GetBookContentOperationCompleted, userState);
    }

    private void OnGetBookContentOperationCompleted(object arg)
    {
        if ((this.GetBookContentCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetBookContentCompleted(this, new GetBookContentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
// CODEGEN: Необязательный элемент расширения WSDL "PolicyReference" из пространства имен "http://schemas.xmlsoap.org/ws/2004/09/policy" не был обработан.
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "BasicHttpsBinding_ILibraryWCFService", Namespace = "http://tempuri.org/")]
public partial class BasicHttpsBinding_ILibraryWCFService : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback GetBookContentOperationCompleted;

    /// <remarks/>
    public BasicHttpsBinding_ILibraryWCFService()
    {
        this.Url = "https://libraryservice.azurewebsites.net/Service1.svc";
    }

    /// <remarks/>
    public event GetBookContentCompletedEventHandler GetBookContentCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILibraryWCFService/GetBookContent", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string GetBookContent(int code, [System.Xml.Serialization.XmlIgnoreAttribute()] bool codeSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string clientId)
    {
        object[] results = this.Invoke("GetBookContent", new object[] {
                    code,
                    codeSpecified,
                    clientId});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginGetBookContent(int code, bool codeSpecified, string clientId, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("GetBookContent", new object[] {
                    code,
                    codeSpecified,
                    clientId}, callback, asyncState);
    }

    /// <remarks/>
    public string EndGetBookContent(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void GetBookContentAsync(int code, bool codeSpecified, string clientId)
    {
        this.GetBookContentAsync(code, codeSpecified, clientId, null);
    }

    /// <remarks/>
    public void GetBookContentAsync(int code, bool codeSpecified, string clientId, object userState)
    {
        if ((this.GetBookContentOperationCompleted == null))
        {
            this.GetBookContentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBookContentOperationCompleted);
        }
        this.InvokeAsync("GetBookContent", new object[] {
                    code,
                    codeSpecified,
                    clientId}, this.GetBookContentOperationCompleted, userState);
    }

    private void OnGetBookContentOperationCompleted(object arg)
    {
        if ((this.GetBookContentCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetBookContentCompleted(this, new GetBookContentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
public delegate void GetBookContentCompletedEventHandler(object sender, GetBookContentCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetBookContentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal GetBookContentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
        base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}
