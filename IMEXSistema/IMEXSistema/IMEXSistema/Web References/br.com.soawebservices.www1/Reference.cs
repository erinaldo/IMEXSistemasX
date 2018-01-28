﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BmsSoftware.br.com.soawebservices.www1 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SERASASoap", Namespace="SOAWebServices")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Serialization))]
    public partial class SERASA : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CredNetOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SERASA() {
            this.Url = global::BmsSoftware.Properties.Settings.Default.IMEXSistema_br_com_soawebservices_www1_SERASA;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CredNetCompletedEventHandler CredNetCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("SOAWebServices/CredNet", RequestNamespace="SOAWebServices", ResponseNamespace="SOAWebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CredNet CredNet(Credenciais Credenciais, string Documento, string Estado) {
            object[] results = this.Invoke("CredNet", new object[] {
                        Credenciais,
                        Documento,
                        Estado});
            return ((CredNet)(results[0]));
        }
        
        /// <remarks/>
        public void CredNetAsync(Credenciais Credenciais, string Documento, string Estado) {
            this.CredNetAsync(Credenciais, Documento, Estado, null);
        }
        
        /// <remarks/>
        public void CredNetAsync(Credenciais Credenciais, string Documento, string Estado, object userState) {
            if ((this.CredNetOperationCompleted == null)) {
                this.CredNetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCredNetOperationCompleted);
            }
            this.InvokeAsync("CredNet", new object[] {
                        Credenciais,
                        Documento,
                        Estado}, this.CredNetOperationCompleted, userState);
        }
        
        private void OnCredNetOperationCompleted(object arg) {
            if ((this.CredNetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CredNetCompleted(this, new CredNetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class Credenciais {
        
        private string emailField;
        
        private string senhaField;
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Senha {
            get {
                return this.senhaField;
            }
            set {
                this.senhaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class ProtestosResumo {
        
        private string quantidadeTotalField;
        
        private string dataMenorOcorrenciaField;
        
        private string dataMaiorOcorrenciaField;
        
        private string valorTotalField;
        
        /// <remarks/>
        public string QuantidadeTotal {
            get {
                return this.quantidadeTotalField;
            }
            set {
                this.quantidadeTotalField = value;
            }
        }
        
        /// <remarks/>
        public string DataMenorOcorrencia {
            get {
                return this.dataMenorOcorrenciaField;
            }
            set {
                this.dataMenorOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string DataMaiorOcorrencia {
            get {
                return this.dataMaiorOcorrenciaField;
            }
            set {
                this.dataMaiorOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string ValorTotal {
            get {
                return this.valorTotalField;
            }
            set {
                this.valorTotalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class Protesto {
        
        private string dataOcorrenciaField;
        
        private string valorField;
        
        private string numeroCartorioField;
        
        private string cidadeField;
        
        private string estadoField;
        
        private string subJudiceField;
        
        /// <remarks/>
        public string DataOcorrencia {
            get {
                return this.dataOcorrenciaField;
            }
            set {
                this.dataOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
            }
        }
        
        /// <remarks/>
        public string NumeroCartorio {
            get {
                return this.numeroCartorioField;
            }
            set {
                this.numeroCartorioField = value;
            }
        }
        
        /// <remarks/>
        public string Cidade {
            get {
                return this.cidadeField;
            }
            set {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        public string SubJudice {
            get {
                return this.subJudiceField;
            }
            set {
                this.subJudiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class PendenciaBacen {
        
        private int totalChequesSemFundoField;
        
        private string dataOcorrenciaAntigaField;
        
        private string dataOcorrenciaRecenteField;
        
        private string codigoCompensacaoField;
        
        private string numeroAgenciaField;
        
        private string nomeFantasiaBancoField;
        
        /// <remarks/>
        public int TotalChequesSemFundo {
            get {
                return this.totalChequesSemFundoField;
            }
            set {
                this.totalChequesSemFundoField = value;
            }
        }
        
        /// <remarks/>
        public string DataOcorrenciaAntiga {
            get {
                return this.dataOcorrenciaAntigaField;
            }
            set {
                this.dataOcorrenciaAntigaField = value;
            }
        }
        
        /// <remarks/>
        public string DataOcorrenciaRecente {
            get {
                return this.dataOcorrenciaRecenteField;
            }
            set {
                this.dataOcorrenciaRecenteField = value;
            }
        }
        
        /// <remarks/>
        public string CodigoCompensacao {
            get {
                return this.codigoCompensacaoField;
            }
            set {
                this.codigoCompensacaoField = value;
            }
        }
        
        /// <remarks/>
        public string NumeroAgencia {
            get {
                return this.numeroAgenciaField;
            }
            set {
                this.numeroAgenciaField = value;
            }
        }
        
        /// <remarks/>
        public string NomeFantasiaBanco {
            get {
                return this.nomeFantasiaBancoField;
            }
            set {
                this.nomeFantasiaBancoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class PendenciaVarejo {
        
        private string codigoCompensacaoBancoField;
        
        private string numeroAgenciaField;
        
        private string origemOcorrenciaField;
        
        private string siglaField;
        
        private string numeroLojaFilialField;
        
        /// <remarks/>
        public string CodigoCompensacaoBanco {
            get {
                return this.codigoCompensacaoBancoField;
            }
            set {
                this.codigoCompensacaoBancoField = value;
            }
        }
        
        /// <remarks/>
        public string NumeroAgencia {
            get {
                return this.numeroAgenciaField;
            }
            set {
                this.numeroAgenciaField = value;
            }
        }
        
        /// <remarks/>
        public string OrigemOcorrencia {
            get {
                return this.origemOcorrenciaField;
            }
            set {
                this.origemOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string Sigla {
            get {
                return this.siglaField;
            }
            set {
                this.siglaField = value;
            }
        }
        
        /// <remarks/>
        public string NumeroLojaFilial {
            get {
                return this.numeroLojaFilialField;
            }
            set {
                this.numeroLojaFilialField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class PendenciasFinanceirasResumo {
        
        private string quantidadeTotalField;
        
        private string dataMenorOcorrenciaField;
        
        private string dataMaiorOcorrenciaField;
        
        private string valorTotalField;
        
        /// <remarks/>
        public string QuantidadeTotal {
            get {
                return this.quantidadeTotalField;
            }
            set {
                this.quantidadeTotalField = value;
            }
        }
        
        /// <remarks/>
        public string DataMenorOcorrencia {
            get {
                return this.dataMenorOcorrenciaField;
            }
            set {
                this.dataMenorOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string DataMaiorOcorrencia {
            get {
                return this.dataMaiorOcorrenciaField;
            }
            set {
                this.dataMaiorOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string ValorTotal {
            get {
                return this.valorTotalField;
            }
            set {
                this.valorTotalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class PendenciaFinanceira {
        
        private string dataOcorrenciaField;
        
        private string modalidadeField;
        
        private string avalistaField;
        
        private string valorField;
        
        private string contratoField;
        
        private string origemField;
        
        private string siglaField;
        
        /// <remarks/>
        public string DataOcorrencia {
            get {
                return this.dataOcorrenciaField;
            }
            set {
                this.dataOcorrenciaField = value;
            }
        }
        
        /// <remarks/>
        public string Modalidade {
            get {
                return this.modalidadeField;
            }
            set {
                this.modalidadeField = value;
            }
        }
        
        /// <remarks/>
        public string Avalista {
            get {
                return this.avalistaField;
            }
            set {
                this.avalistaField = value;
            }
        }
        
        /// <remarks/>
        public string Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
            }
        }
        
        /// <remarks/>
        public string Contrato {
            get {
                return this.contratoField;
            }
            set {
                this.contratoField = value;
            }
        }
        
        /// <remarks/>
        public string Origem {
            get {
                return this.origemField;
            }
            set {
                this.origemField = value;
            }
        }
        
        /// <remarks/>
        public string Sigla {
            get {
                return this.siglaField;
            }
            set {
                this.siglaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class AlertaDocumentos {
        
        private string mensagemField;
        
        private string dDD1Field;
        
        private string fone1Field;
        
        private string dDD2Field;
        
        private string fone2Field;
        
        private string dDD3Field;
        
        private string fone3Field;
        
        /// <remarks/>
        public string Mensagem {
            get {
                return this.mensagemField;
            }
            set {
                this.mensagemField = value;
            }
        }
        
        /// <remarks/>
        public string DDD1 {
            get {
                return this.dDD1Field;
            }
            set {
                this.dDD1Field = value;
            }
        }
        
        /// <remarks/>
        public string Fone1 {
            get {
                return this.fone1Field;
            }
            set {
                this.fone1Field = value;
            }
        }
        
        /// <remarks/>
        public string DDD2 {
            get {
                return this.dDD2Field;
            }
            set {
                this.dDD2Field = value;
            }
        }
        
        /// <remarks/>
        public string Fone2 {
            get {
                return this.fone2Field;
            }
            set {
                this.fone2Field = value;
            }
        }
        
        /// <remarks/>
        public string DDD3 {
            get {
                return this.dDD3Field;
            }
            set {
                this.dDD3Field = value;
            }
        }
        
        /// <remarks/>
        public string Fone3 {
            get {
                return this.fone3Field;
            }
            set {
                this.fone3Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CredNet))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class Serialization {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SOAWebServices")]
    public partial class CredNet : Serialization {
        
        private string documentoField;
        
        private string nomeField;
        
        private string situacaoDocumentoField;
        
        private string nomeMaeField;
        
        private string dataNascimentoField;
        
        private string totalOcorrenciasField;
        
        private AlertaDocumentos[] alertaDocumentosField;
        
        private PendenciaFinanceira[] pendenciasFinanceirasField;
        
        private PendenciasFinanceirasResumo pendenciasFinanceirasResumoField;
        
        private PendenciaVarejo[] pendenciasVarejoField;
        
        private PendenciaBacen[] pendenciasBacenField;
        
        private Protesto[] pendenciasProtestosField;
        
        private ProtestosResumo protestosResumoField;
        
        private string mensagemField;
        
        private bool statusField;
        
        /// <remarks/>
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
            }
        }
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string SituacaoDocumento {
            get {
                return this.situacaoDocumentoField;
            }
            set {
                this.situacaoDocumentoField = value;
            }
        }
        
        /// <remarks/>
        public string NomeMae {
            get {
                return this.nomeMaeField;
            }
            set {
                this.nomeMaeField = value;
            }
        }
        
        /// <remarks/>
        public string DataNascimento {
            get {
                return this.dataNascimentoField;
            }
            set {
                this.dataNascimentoField = value;
            }
        }
        
        /// <remarks/>
        public string TotalOcorrencias {
            get {
                return this.totalOcorrenciasField;
            }
            set {
                this.totalOcorrenciasField = value;
            }
        }
        
        /// <remarks/>
        public AlertaDocumentos[] AlertaDocumentos {
            get {
                return this.alertaDocumentosField;
            }
            set {
                this.alertaDocumentosField = value;
            }
        }
        
        /// <remarks/>
        public PendenciaFinanceira[] PendenciasFinanceiras {
            get {
                return this.pendenciasFinanceirasField;
            }
            set {
                this.pendenciasFinanceirasField = value;
            }
        }
        
        /// <remarks/>
        public PendenciasFinanceirasResumo PendenciasFinanceirasResumo {
            get {
                return this.pendenciasFinanceirasResumoField;
            }
            set {
                this.pendenciasFinanceirasResumoField = value;
            }
        }
        
        /// <remarks/>
        public PendenciaVarejo[] PendenciasVarejo {
            get {
                return this.pendenciasVarejoField;
            }
            set {
                this.pendenciasVarejoField = value;
            }
        }
        
        /// <remarks/>
        public PendenciaBacen[] PendenciasBacen {
            get {
                return this.pendenciasBacenField;
            }
            set {
                this.pendenciasBacenField = value;
            }
        }
        
        /// <remarks/>
        public Protesto[] PendenciasProtestos {
            get {
                return this.pendenciasProtestosField;
            }
            set {
                this.pendenciasProtestosField = value;
            }
        }
        
        /// <remarks/>
        public ProtestosResumo ProtestosResumo {
            get {
                return this.protestosResumoField;
            }
            set {
                this.protestosResumoField = value;
            }
        }
        
        /// <remarks/>
        public string Mensagem {
            get {
                return this.mensagemField;
            }
            set {
                this.mensagemField = value;
            }
        }
        
        /// <remarks/>
        public bool Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void CredNetCompletedEventHandler(object sender, CredNetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CredNetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CredNetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CredNet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CredNet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591