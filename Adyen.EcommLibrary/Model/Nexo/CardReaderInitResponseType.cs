﻿/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CardReaderInitResponseType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ResponseType Response;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TrackData", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TrackDataType[] TrackData;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ICCResetDataType ICCResetData;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string[] EntryMode;
}