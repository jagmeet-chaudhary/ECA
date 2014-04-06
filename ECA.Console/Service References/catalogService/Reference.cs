﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECA.Console.catalogService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookCategory", Namespace="ECA.Contracts", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class BookCategory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ECA.Console.catalogService.Book> BooksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ECA.Console.catalogService.Book> Books {
            get {
                return this.BooksField;
            }
            set {
                if ((object.ReferenceEquals(this.BooksField, value) != true)) {
                    this.BooksField = value;
                    this.RaisePropertyChanged("Books");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryIdField, value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="ECA.Contracts", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ECA.Console.catalogService.Author AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ECA.Console.catalogService.BookCategory BookCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ECA.Console.catalogService.Genre GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ECA.Console.catalogService.Author Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorId {
            get {
                return this.AuthorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorIdField, value) != true)) {
                    this.AuthorIdField = value;
                    this.RaisePropertyChanged("AuthorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ECA.Console.catalogService.BookCategory BookCategory {
            get {
                return this.BookCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.BookCategoryField, value) != true)) {
                    this.BookCategoryField = value;
                    this.RaisePropertyChanged("BookCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryIdField, value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ECA.Console.catalogService.Genre Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GenreId {
            get {
                return this.GenreIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreIdField, value) != true)) {
                    this.GenreIdField = value;
                    this.RaisePropertyChanged("GenreId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/ECA.Model")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ECA.Console.catalogService.Book> BooksField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorId {
            get {
                return this.AuthorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorIdField, value) != true)) {
                    this.AuthorIdField = value;
                    this.RaisePropertyChanged("AuthorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorName {
            get {
                return this.AuthorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorNameField, value) != true)) {
                    this.AuthorNameField = value;
                    this.RaisePropertyChanged("AuthorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ECA.Console.catalogService.Book> Books {
            get {
                return this.BooksField;
            }
            set {
                if ((object.ReferenceEquals(this.BooksField, value) != true)) {
                    this.BooksField = value;
                    this.RaisePropertyChanged("Books");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Genre", Namespace="http://schemas.datacontract.org/2004/07/ECA.Model")]
    [System.SerializableAttribute()]
    public partial class Genre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ECA.Console.catalogService.Book> BooksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ECA.Console.catalogService.Book> Books {
            get {
                return this.BooksField;
            }
            set {
                if ((object.ReferenceEquals(this.BooksField, value) != true)) {
                    this.BooksField = value;
                    this.RaisePropertyChanged("Books");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GenreId {
            get {
                return this.GenreIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreIdField, value) != true)) {
                    this.GenreIdField = value;
                    this.RaisePropertyChanged("GenreId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GenreName {
            get {
                return this.GenreNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreNameField, value) != true)) {
                    this.GenreNameField = value;
                    this.RaisePropertyChanged("GenreName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogServiceFault", Namespace="ECA.Services.FaultContracts")]
    [System.SerializableAttribute()]
    public partial class CatalogServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="ECA.CatalogServices", ConfigurationName="catalogService.ICatalogService")]
    public interface ICatalogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategory", ReplyAction="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ECA.Console.catalogService.CatalogServiceFault), Action="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryCatalogServiceFau" +
            "lt", Name="CatalogServiceFault")]
        System.Collections.Generic.List<ECA.Console.catalogService.BookCategory> GetAllBooksGroupedByCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategory", ReplyAction="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ECA.Console.catalogService.BookCategory>> GetAllBooksGroupedByCategoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryAsString", ReplyAction="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryAsStringResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ECA.Console.catalogService.CatalogServiceFault), Action="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryAsStringCatalogSe" +
            "rviceFault", Name="CatalogServiceFault")]
        string GetAllBooksGroupedByCategoryAsString(string format);
        
        [System.ServiceModel.OperationContractAttribute(Action="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryAsString", ReplyAction="ECA.CatalogServices/ICatalogService/GetAllBooksGroupedByCategoryAsStringResponse")]
        System.Threading.Tasks.Task<string> GetAllBooksGroupedByCategoryAsStringAsync(string format);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICatalogServiceChannel : ECA.Console.catalogService.ICatalogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CatalogServiceClient : System.ServiceModel.ClientBase<ECA.Console.catalogService.ICatalogService>, ECA.Console.catalogService.ICatalogService {
        
        public CatalogServiceClient() {
        }
        
        public CatalogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CatalogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ECA.Console.catalogService.BookCategory> GetAllBooksGroupedByCategory() {
            return base.Channel.GetAllBooksGroupedByCategory();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ECA.Console.catalogService.BookCategory>> GetAllBooksGroupedByCategoryAsync() {
            return base.Channel.GetAllBooksGroupedByCategoryAsync();
        }
        
        public string GetAllBooksGroupedByCategoryAsString(string format) {
            return base.Channel.GetAllBooksGroupedByCategoryAsString(format);
        }
        
        public System.Threading.Tasks.Task<string> GetAllBooksGroupedByCategoryAsStringAsync(string format) {
            return base.Channel.GetAllBooksGroupedByCategoryAsStringAsync(format);
        }
    }
}