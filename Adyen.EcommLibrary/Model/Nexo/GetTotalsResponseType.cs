﻿/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetTotalsResponseType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ResponseType Response;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransactionTotals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TransactionTotalsType[] TransactionTotals;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string POIReconciliationID;
}