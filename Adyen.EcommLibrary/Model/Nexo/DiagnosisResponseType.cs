﻿/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DiagnosisResponseType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ResponseType Response;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LoggedSaleID", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string[] LoggedSaleID;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public POIStatusType POIStatus;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HostStatus", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public HostStatusType[] HostStatus;
}