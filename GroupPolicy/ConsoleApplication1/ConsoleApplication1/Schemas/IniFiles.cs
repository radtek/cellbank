﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class IniFiles {
    
    private IniFilesIni[] iniField;
    
    private string clsidField;
    
    private byte disabledField;
    
    private bool disabledFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Ini")]
    public IniFilesIni[] Ini {
        get {
            return this.iniField;
        }
        set {
            this.iniField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string clsid {
        get {
            return this.clsidField;
        }
        set {
            this.clsidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte disabled {
        get {
            return this.disabledField;
        }
        set {
            this.disabledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool disabledSpecified {
        get {
            return this.disabledFieldSpecified;
        }
        set {
            this.disabledFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class IniFilesIni {
    
    private IniFilesIniProperties propertiesField;
    
    private string clsidField;
    
    private string nameField;
    
    private string statusField;
    
    private byte imageField;
    
    private string changedField;
    
    private string uidField;
    
    private string descField;
    
    private bool bypassErrorsField;
    
    private bool bypassErrorsFieldSpecified;
    
    private bool userContextField;
    
    private bool userContextFieldSpecified;
    
    private bool removePolicyField;
    
    private bool removePolicyFieldSpecified;
    
    /// <remarks/>
    public IniFilesIniProperties Properties {
        get {
            return this.propertiesField;
        }
        set {
            this.propertiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string clsid {
        get {
            return this.clsidField;
        }
        set {
            this.clsidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string changed {
        get {
            return this.changedField;
        }
        set {
            this.changedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uid {
        get {
            return this.uidField;
        }
        set {
            this.uidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool bypassErrors {
        get {
            return this.bypassErrorsField;
        }
        set {
            this.bypassErrorsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bypassErrorsSpecified {
        get {
            return this.bypassErrorsFieldSpecified;
        }
        set {
            this.bypassErrorsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool userContext {
        get {
            return this.userContextField;
        }
        set {
            this.userContextField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool userContextSpecified {
        get {
            return this.userContextFieldSpecified;
        }
        set {
            this.userContextFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool removePolicy {
        get {
            return this.removePolicyField;
        }
        set {
            this.removePolicyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool removePolicySpecified {
        get {
            return this.removePolicyFieldSpecified;
        }
        set {
            this.removePolicyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class IniFilesIniProperties {
    
    private string pathField;
    
    private string sectionField;
    
    private string valueField;
    
    private string propertyField;
    
    private string actionField;
    
    private byte disabledField;
    
    private bool disabledFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string section {
        get {
            return this.sectionField;
        }
        set {
            this.sectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte disabled {
        get {
            return this.disabledField;
        }
        set {
            this.disabledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool disabledSpecified {
        get {
            return this.disabledFieldSpecified;
        }
        set {
            this.disabledFieldSpecified = value;
        }
    }
}
