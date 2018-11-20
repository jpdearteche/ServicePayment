﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("PaymentServicesModel", "FK_Payment_Status", "Status", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PaymentDataAccess.Model.Status), "Payment", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PaymentDataAccess.Model.Payment), true)]
[assembly: EdmRelationshipAttribute("PaymentServicesModel", "FK_Payment_PaymentType", "PaymentType", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PaymentDataAccess.Model.PaymentType), "Payment", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PaymentDataAccess.Model.Payment), true)]

#endregion

namespace PaymentDataAccess.Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PaymentServicesEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PaymentServicesEntities object using the connection string found in the 'PaymentServicesEntities' section of the application configuration file.
        /// </summary>
        public PaymentServicesEntities() : base("name=PaymentServicesEntities", "PaymentServicesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PaymentServicesEntities object.
        /// </summary>
        public PaymentServicesEntities(string connectionString) : base(connectionString, "PaymentServicesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PaymentServicesEntities object.
        /// </summary>
        public PaymentServicesEntities(EntityConnection connection) : base(connection, "PaymentServicesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Status> Status
        {
            get
            {
                if ((_Status == null))
                {
                    _Status = base.CreateObjectSet<Status>("Status");
                }
                return _Status;
            }
        }
        private ObjectSet<Status> _Status;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Payment> Payment
        {
            get
            {
                if ((_Payment == null))
                {
                    _Payment = base.CreateObjectSet<Payment>("Payment");
                }
                return _Payment;
            }
        }
        private ObjectSet<Payment> _Payment;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PaymentType> PaymentType
        {
            get
            {
                if ((_PaymentType == null))
                {
                    _PaymentType = base.CreateObjectSet<PaymentType>("PaymentType");
                }
                return _PaymentType;
            }
        }
        private ObjectSet<PaymentType> _PaymentType;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Status EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStatus(Status status)
        {
            base.AddObject("Status", status);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Payment EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPayment(Payment payment)
        {
            base.AddObject("Payment", payment);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PaymentType EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPaymentType(PaymentType paymentType)
        {
            base.AddObject("PaymentType", paymentType);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PaymentServicesModel", Name="Payment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Payment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Payment object.
        /// </summary>
        /// <param name="idPayment">Initial value of the IdPayment property.</param>
        /// <param name="paymentNumber">Initial value of the PaymentNumber property.</param>
        /// <param name="clientCode">Initial value of the ClientCode property.</param>
        /// <param name="totalPayment">Initial value of the TotalPayment property.</param>
        /// <param name="paymentDate">Initial value of the PaymentDate property.</param>
        /// <param name="idStatus">Initial value of the IdStatus property.</param>
        /// <param name="idPaymentType">Initial value of the IdPaymentType property.</param>
        /// <param name="orderNumber">Initial value of the OrderNumber property.</param>
        public static Payment CreatePayment(global::System.Int32 idPayment, global::System.String paymentNumber, global::System.String clientCode, global::System.Decimal totalPayment, global::System.DateTime paymentDate, global::System.Int32 idStatus, global::System.Int32 idPaymentType, global::System.String orderNumber)
        {
            Payment payment = new Payment();
            payment.IdPayment = idPayment;
            payment.PaymentNumber = paymentNumber;
            payment.ClientCode = clientCode;
            payment.TotalPayment = totalPayment;
            payment.PaymentDate = paymentDate;
            payment.IdStatus = idStatus;
            payment.IdPaymentType = idPaymentType;
            payment.OrderNumber = orderNumber;
            return payment;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdPayment
        {
            get
            {
                return _IdPayment;
            }
            set
            {
                if (_IdPayment != value)
                {
                    OnIdPaymentChanging(value);
                    ReportPropertyChanging("IdPayment");
                    _IdPayment = StructuralObject.SetValidValue(value, "IdPayment");
                    ReportPropertyChanged("IdPayment");
                    OnIdPaymentChanged();
                }
            }
        }
        private global::System.Int32 _IdPayment;
        partial void OnIdPaymentChanging(global::System.Int32 value);
        partial void OnIdPaymentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PaymentNumber
        {
            get
            {
                return _PaymentNumber;
            }
            set
            {
                OnPaymentNumberChanging(value);
                ReportPropertyChanging("PaymentNumber");
                _PaymentNumber = StructuralObject.SetValidValue(value, false, "PaymentNumber");
                ReportPropertyChanged("PaymentNumber");
                OnPaymentNumberChanged();
            }
        }
        private global::System.String _PaymentNumber;
        partial void OnPaymentNumberChanging(global::System.String value);
        partial void OnPaymentNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ClientCode
        {
            get
            {
                return _ClientCode;
            }
            set
            {
                OnClientCodeChanging(value);
                ReportPropertyChanging("ClientCode");
                _ClientCode = StructuralObject.SetValidValue(value, false, "ClientCode");
                ReportPropertyChanged("ClientCode");
                OnClientCodeChanged();
            }
        }
        private global::System.String _ClientCode;
        partial void OnClientCodeChanging(global::System.String value);
        partial void OnClientCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal TotalPayment
        {
            get
            {
                return _TotalPayment;
            }
            set
            {
                OnTotalPaymentChanging(value);
                ReportPropertyChanging("TotalPayment");
                _TotalPayment = StructuralObject.SetValidValue(value, "TotalPayment");
                ReportPropertyChanged("TotalPayment");
                OnTotalPaymentChanged();
            }
        }
        private global::System.Decimal _TotalPayment;
        partial void OnTotalPaymentChanging(global::System.Decimal value);
        partial void OnTotalPaymentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime PaymentDate
        {
            get
            {
                return _PaymentDate;
            }
            set
            {
                OnPaymentDateChanging(value);
                ReportPropertyChanging("PaymentDate");
                _PaymentDate = StructuralObject.SetValidValue(value, "PaymentDate");
                ReportPropertyChanged("PaymentDate");
                OnPaymentDateChanged();
            }
        }
        private global::System.DateTime _PaymentDate;
        partial void OnPaymentDateChanging(global::System.DateTime value);
        partial void OnPaymentDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdStatus
        {
            get
            {
                return _IdStatus;
            }
            set
            {
                OnIdStatusChanging(value);
                ReportPropertyChanging("IdStatus");
                _IdStatus = StructuralObject.SetValidValue(value, "IdStatus");
                ReportPropertyChanged("IdStatus");
                OnIdStatusChanged();
            }
        }
        private global::System.Int32 _IdStatus;
        partial void OnIdStatusChanging(global::System.Int32 value);
        partial void OnIdStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdPaymentType
        {
            get
            {
                return _IdPaymentType;
            }
            set
            {
                OnIdPaymentTypeChanging(value);
                ReportPropertyChanging("IdPaymentType");
                _IdPaymentType = StructuralObject.SetValidValue(value, "IdPaymentType");
                ReportPropertyChanged("IdPaymentType");
                OnIdPaymentTypeChanged();
            }
        }
        private global::System.Int32 _IdPaymentType;
        partial void OnIdPaymentTypeChanging(global::System.Int32 value);
        partial void OnIdPaymentTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OrderNumber
        {
            get
            {
                return _OrderNumber;
            }
            set
            {
                OnOrderNumberChanging(value);
                ReportPropertyChanging("OrderNumber");
                _OrderNumber = StructuralObject.SetValidValue(value, false, "OrderNumber");
                ReportPropertyChanged("OrderNumber");
                OnOrderNumberChanged();
            }
        }
        private global::System.String _OrderNumber;
        partial void OnOrderNumberChanging(global::System.String value);
        partial void OnOrderNumberChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PaymentServicesModel", "FK_Payment_Status", "Status")]
        public Status Status
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Status>("PaymentServicesModel.FK_Payment_Status", "Status").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Status>("PaymentServicesModel.FK_Payment_Status", "Status").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Status> StatusReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Status>("PaymentServicesModel.FK_Payment_Status", "Status");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Status>("PaymentServicesModel.FK_Payment_Status", "Status", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PaymentServicesModel", "FK_Payment_PaymentType", "PaymentType")]
        public PaymentType PaymentType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PaymentType>("PaymentServicesModel.FK_Payment_PaymentType", "PaymentType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PaymentType>("PaymentServicesModel.FK_Payment_PaymentType", "PaymentType").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<PaymentType> PaymentTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PaymentType>("PaymentServicesModel.FK_Payment_PaymentType", "PaymentType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<PaymentType>("PaymentServicesModel.FK_Payment_PaymentType", "PaymentType", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PaymentServicesModel", Name="PaymentType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PaymentType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PaymentType object.
        /// </summary>
        /// <param name="idPaymentType">Initial value of the IdPaymentType property.</param>
        /// <param name="code">Initial value of the Code property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static PaymentType CreatePaymentType(global::System.Int32 idPaymentType, global::System.String code, global::System.String name, global::System.Boolean isActive)
        {
            PaymentType paymentType = new PaymentType();
            paymentType.IdPaymentType = idPaymentType;
            paymentType.Code = code;
            paymentType.Name = name;
            paymentType.IsActive = isActive;
            return paymentType;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdPaymentType
        {
            get
            {
                return _IdPaymentType;
            }
            set
            {
                if (_IdPaymentType != value)
                {
                    OnIdPaymentTypeChanging(value);
                    ReportPropertyChanging("IdPaymentType");
                    _IdPaymentType = StructuralObject.SetValidValue(value, "IdPaymentType");
                    ReportPropertyChanged("IdPaymentType");
                    OnIdPaymentTypeChanged();
                }
            }
        }
        private global::System.Int32 _IdPaymentType;
        partial void OnIdPaymentTypeChanging(global::System.Int32 value);
        partial void OnIdPaymentTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Code
        {
            get
            {
                return _Code;
            }
            set
            {
                OnCodeChanging(value);
                ReportPropertyChanging("Code");
                _Code = StructuralObject.SetValidValue(value, false, "Code");
                ReportPropertyChanged("Code");
                OnCodeChanged();
            }
        }
        private global::System.String _Code;
        partial void OnCodeChanging(global::System.String value);
        partial void OnCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value, "IsActive");
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PaymentServicesModel", "FK_Payment_PaymentType", "Payment")]
        public EntityCollection<Payment> Payment
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Payment>("PaymentServicesModel.FK_Payment_PaymentType", "Payment");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Payment>("PaymentServicesModel.FK_Payment_PaymentType", "Payment", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PaymentServicesModel", Name="Status")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Status : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Status object.
        /// </summary>
        /// <param name="idStatus">Initial value of the IdStatus property.</param>
        /// <param name="code">Initial value of the Code property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Status CreateStatus(global::System.Int32 idStatus, global::System.String code, global::System.String name)
        {
            Status status = new Status();
            status.IdStatus = idStatus;
            status.Code = code;
            status.Name = name;
            return status;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdStatus
        {
            get
            {
                return _IdStatus;
            }
            set
            {
                if (_IdStatus != value)
                {
                    OnIdStatusChanging(value);
                    ReportPropertyChanging("IdStatus");
                    _IdStatus = StructuralObject.SetValidValue(value, "IdStatus");
                    ReportPropertyChanged("IdStatus");
                    OnIdStatusChanged();
                }
            }
        }
        private global::System.Int32 _IdStatus;
        partial void OnIdStatusChanging(global::System.Int32 value);
        partial void OnIdStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Code
        {
            get
            {
                return _Code;
            }
            set
            {
                OnCodeChanging(value);
                ReportPropertyChanging("Code");
                _Code = StructuralObject.SetValidValue(value, false, "Code");
                ReportPropertyChanged("Code");
                OnCodeChanged();
            }
        }
        private global::System.String _Code;
        partial void OnCodeChanging(global::System.String value);
        partial void OnCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PaymentServicesModel", "FK_Payment_Status", "Payment")]
        public EntityCollection<Payment> Payment
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Payment>("PaymentServicesModel.FK_Payment_Status", "Payment");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Payment>("PaymentServicesModel.FK_Payment_Status", "Payment", value);
                }
            }
        }

        #endregion

    }

    #endregion

}