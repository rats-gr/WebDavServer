﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.1055.0.
// 

using System.Xml.Linq;

namespace FubarDev.WebDavServer.Model {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class propfind {
        
        private object[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allprop", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("prop", typeof(prop))]
        [System.Xml.Serialization.XmlElementAttribute("propname", typeof(object))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class location {
        
        private string hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class propstat {
        
        private prop propField;
        
        private string statusField;
        
        private error errorField;
        
        private string responsedescriptionField;
        
        private location locationField;
        
        /// <remarks/>
        public prop prop {
            get {
                return this.propField;
            }
            set {
                this.propField = value;
            }
        }
        
        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public error error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        public string responsedescription {
            get {
                return this.responsedescriptionField;
            }
            set {
                this.responsedescriptionField = value;
            }
        }
        
        /// <remarks/>
        public location location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class prop {
        
        private XElement[] anyField;

        [XmlAttribute("xml:lang", DataType = "language")]
        public string Language { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class error {
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("cannot-modify-protected-property", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("lock-token-matches-request-uri", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("lock-token-submitted", typeof(errorLocktokensubmitted))]
        [System.Xml.Serialization.XmlElementAttribute("no-conflicting-lock", typeof(errorNoconflictinglock))]
        [System.Xml.Serialization.XmlElementAttribute("no-external-entities", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("preserved-live-properties", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("propfind-finite-depth", typeof(object))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    public partial class errorLocktokensubmitted {
        
        private string[] hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", DataType="anyURI")]
        public string[] href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    public partial class errorNoconflictinglock {
        
        private string[] hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", DataType="anyURI")]
        public string[] href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cannot-modify-protected-property")]
        cannotmodifyprotectedproperty,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lock-token-matches-request-uri")]
        locktokenmatchesrequesturi,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lock-token-submitted")]
        locktokensubmitted,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("no-conflicting-lock")]
        noconflictinglock,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("no-external-entities")]
        noexternalentities,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("preserved-live-properties")]
        preservedliveproperties,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("propfind-finite-depth")]
        propfindfinitedepth,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class include {
        
        private XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class lockentry {
        
        private lockscope lockscopeField;
        
        private locktype locktypeField;
        
        /// <remarks/>
        public lockscope lockscope {
            get {
                return this.lockscopeField;
            }
            set {
                this.lockscopeField = value;
            }
        }
        
        /// <remarks/>
        public locktype locktype {
            get {
                return this.locktypeField;
            }
            set {
                this.locktypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class lockscope {
        
        private object itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("exclusive", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("shared", typeof(object))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        exclusive,
        
        /// <remarks/>
        shared,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class locktype {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("write")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class lockroot {
        
        private string hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class locktoken {
        
        private string hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:")]
    public partial class activelock {
        
        private lockscope lockscopeField;
        
        private locktype locktypeField;
        
        private activelockDepth depthField;
        
        private XElement ownerField;
        
        private string timeoutField;
        
        private locktoken locktokenField;
        
        private lockroot lockrootField;
        
        /// <remarks/>
        public lockscope lockscope {
            get {
                return this.lockscopeField;
            }
            set {
                this.lockscopeField = value;
            }
        }
        
        /// <remarks/>
        public locktype locktype {
            get {
                return this.locktypeField;
            }
            set {
                this.locktypeField = value;
            }
        }
        
        /// <remarks/>
        public activelockDepth depth {
            get {
                return this.depthField;
            }
            set {
                this.depthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Name="owner", Namespace="DAV:")]
        public XElement owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }
        
        /// <remarks/>
        public string timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        public locktoken locktoken {
            get {
                return this.locktokenField;
            }
            set {
                this.locktokenField = value;
            }
        }
        
        /// <remarks/>
        public lockroot lockroot {
            get {
                return this.lockrootField;
            }
            set {
                this.lockrootField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    public enum activelockDepth {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        infinity,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="prop-set", Namespace="DAV:")]
    public partial class propset {
        
        private prop propField;

        [XmlAttribute("xml:lang", DataType = "language")]
        public string Language { get; set; }

        /// <remarks/>
        public prop prop {
            get {
                return this.propField;
            }
            set {
                this.propField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="prop-remove", Namespace="DAV:")]
    public partial class propremove {
        
        private prop propField;
        
        /// <remarks/>
        public prop prop {
            get {
                return this.propField;
            }
            set {
                this.propField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        allprop,
        
        /// <remarks/>
        include,
        
        /// <remarks/>
        prop,
        
        /// <remarks/>
        propname,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class multistatus {
        
        private response[] responseField;
        
        private string responsedescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response")]
        public response[] response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }
        
        /// <remarks/>
        public string responsedescription {
            get {
                return this.responsedescriptionField;
            }
            set {
                this.responsedescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class response {
        
        private string hrefField;
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        private error errorField;
        
        private string responsedescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", typeof(string), DataType="anyURI", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("propstat", typeof(propstat), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("status", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public error error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string responsedescription {
            get {
                return this.responsedescriptionField;
            }
            set {
                this.responsedescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemsChoiceType2 {
        
        /// <remarks/>
        href,
        
        /// <remarks/>
        propstat,
        
        /// <remarks/>
        status,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class propertyupdate {
        
        private object[] itemsField;

        [XmlAttribute("xml:lang", DataType = "language")]
        public string Language { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("remove", typeof(propremove))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(propset))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class lockinfo {
        
        private lockscope lockscopeField;
        
        private locktype locktypeField;
        
        private XElement ownerField;
        
        /// <remarks/>
        public lockscope lockscope {
            get {
                return this.lockscopeField;
            }
            set {
                this.lockscopeField = value;
            }
        }
        
        /// <remarks/>
        public locktype locktype {
            get {
                return this.locktypeField;
            }
            set {
                this.locktypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Name="owner", Namespace="DAV:")]
        public XElement owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="DAV:", IsNullable=false)]
    public partial class supportedlock {
        
        private supportedlockLockentry[] lockentryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lockentry")]
        public supportedlockLockentry[] lockentry {
            get {
                return this.lockentryField;
            }
            set {
                this.lockentryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    public partial class supportedlockLockentry {
        
        private lockscope lockscopeField;
        
        private locktype locktypeField;
        
        /// <remarks/>
        public lockscope lockscope {
            get {
                return this.lockscopeField;
            }
            set {
                this.lockscopeField = value;
            }
        }
        
        /// <remarks/>
        public locktype locktype {
            get {
                return this.locktypeField;
            }
            set {
                this.locktypeField = value;
            }
        }
    }
}
