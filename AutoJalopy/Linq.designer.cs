﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoJalopy
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyDatabase")]
	public partial class LinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblCar(tblCar instance);
    partial void UpdatetblCar(tblCar instance);
    partial void DeletetblCar(tblCar instance);
    partial void InserttblCustomer(tblCustomer instance);
    partial void UpdatetblCustomer(tblCustomer instance);
    partial void DeletetblCustomer(tblCustomer instance);
    partial void InserttblStaff(tblStaff instance);
    partial void UpdatetblStaff(tblStaff instance);
    partial void DeletetblStaff(tblStaff instance);
    partial void InserttblJob(tblJob instance);
    partial void UpdatetblJob(tblJob instance);
    partial void DeletetblJob(tblJob instance);
    partial void InserttblJobCard(tblJobCard instance);
    partial void UpdatetblJobCard(tblJobCard instance);
    partial void DeletetblJobCard(tblJobCard instance);
    #endregion
		
		public LinqDataContext() : 
				base(global::AutoJalopy.Properties.Settings.Default.MyDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblCar> tblCars
		{
			get
			{
				return this.GetTable<tblCar>();
			}
		}
		
		public System.Data.Linq.Table<tblCustomer> tblCustomers
		{
			get
			{
				return this.GetTable<tblCustomer>();
			}
		}
		
		public System.Data.Linq.Table<tblStaff> tblStaffs
		{
			get
			{
				return this.GetTable<tblStaff>();
			}
		}
		
		public System.Data.Linq.Table<tblJob> tblJobs
		{
			get
			{
				return this.GetTable<tblJob>();
			}
		}
		
		public System.Data.Linq.Table<tblJobCard> tblJobCards
		{
			get
			{
				return this.GetTable<tblJobCard>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCar")]
	public partial class tblCar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Registration;
		
		private string _CarMake;
		
		private string _Model;
		
		private int _CustomerId;
		
		private EntitySet<tblJobCard> _tblJobCards;
		
		private EntityRef<tblCustomer> _tblCustomer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRegistrationChanging(string value);
    partial void OnRegistrationChanged();
    partial void OnCarMakeChanging(string value);
    partial void OnCarMakeChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    #endregion
		
		public tblCar()
		{
			this._tblJobCards = new EntitySet<tblJobCard>(new Action<tblJobCard>(this.attach_tblJobCards), new Action<tblJobCard>(this.detach_tblJobCards));
			this._tblCustomer = default(EntityRef<tblCustomer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Registration", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Registration
		{
			get
			{
				return this._Registration;
			}
			set
			{
				if ((this._Registration != value))
				{
					this.OnRegistrationChanging(value);
					this.SendPropertyChanging();
					this._Registration = value;
					this.SendPropertyChanged("Registration");
					this.OnRegistrationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarMake", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string CarMake
		{
			get
			{
				return this._CarMake;
			}
			set
			{
				if ((this._CarMake != value))
				{
					this.OnCarMakeChanging(value);
					this.SendPropertyChanging();
					this._CarMake = value;
					this.SendPropertyChanged("CarMake");
					this.OnCarMakeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int NOT NULL")]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._tblCustomer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCar_tblJobCard", Storage="_tblJobCards", ThisKey="Registration", OtherKey="Registration")]
		public EntitySet<tblJobCard> tblJobCards
		{
			get
			{
				return this._tblJobCards;
			}
			set
			{
				this._tblJobCards.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCustomer_tblCar", Storage="_tblCustomer", ThisKey="CustomerId", OtherKey="CustomerId", IsForeignKey=true)]
		public tblCustomer tblCustomer
		{
			get
			{
				return this._tblCustomer.Entity;
			}
			set
			{
				tblCustomer previousValue = this._tblCustomer.Entity;
				if (((previousValue != value) 
							|| (this._tblCustomer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCustomer.Entity = null;
						previousValue.tblCars.Remove(this);
					}
					this._tblCustomer.Entity = value;
					if ((value != null))
					{
						value.tblCars.Add(this);
						this._CustomerId = value.CustomerId;
					}
					else
					{
						this._CustomerId = default(int);
					}
					this.SendPropertyChanged("tblCustomer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblJobCards(tblJobCard entity)
		{
			this.SendPropertyChanging();
			entity.tblCar = this;
		}
		
		private void detach_tblJobCards(tblJobCard entity)
		{
			this.SendPropertyChanging();
			entity.tblCar = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCustomer")]
	public partial class tblCustomer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _email;
		
		private string _Phone;
		
		private EntitySet<tblCar> _tblCars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public tblCustomer()
		{
			this._tblCars = new EntitySet<tblCar>(new Action<tblCar>(this.attach_tblCars), new Action<tblCar>(this.detach_tblCars));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCustomer_tblCar", Storage="_tblCars", ThisKey="CustomerId", OtherKey="CustomerId")]
		public EntitySet<tblCar> tblCars
		{
			get
			{
				return this._tblCars;
			}
			set
			{
				this._tblCars.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblCars(tblCar entity)
		{
			this.SendPropertyChanging();
			entity.tblCustomer = this;
		}
		
		private void detach_tblCars(tblCar entity)
		{
			this.SendPropertyChanging();
			entity.tblCustomer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblStaff")]
	public partial class tblStaff : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _Password;
		
		private bool _Admin;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Role;
		
		private EntitySet<tblJobCard> _tblJobCards;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAdminChanging(bool value);
    partial void OnAdminChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    #endregion
		
		public tblStaff()
		{
			this._tblJobCards = new EntitySet<tblJobCard>(new Action<tblJobCard>(this.attach_tblJobCards), new Action<tblJobCard>(this.detach_tblJobCards));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin", DbType="Bit NOT NULL")]
		public bool Admin
		{
			get
			{
				return this._Admin;
			}
			set
			{
				if ((this._Admin != value))
				{
					this.OnAdminChanging(value);
					this.SendPropertyChanging();
					this._Admin = value;
					this.SendPropertyChanged("Admin");
					this.OnAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblStaff_tblJobCard", Storage="_tblJobCards", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<tblJobCard> tblJobCards
		{
			get
			{
				return this._tblJobCards;
			}
			set
			{
				this._tblJobCards.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblJobCards(tblJobCard entity)
		{
			this.SendPropertyChanging();
			entity.tblStaff = this;
		}
		
		private void detach_tblJobCards(tblJobCard entity)
		{
			this.SendPropertyChanging();
			entity.tblStaff = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblJob")]
	public partial class tblJob : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _JobId;
		
		private string _Description;
		
		private EntitySet<tblJobCard> _tblJobCards;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJobIdChanging(int value);
    partial void OnJobIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tblJob()
		{
			this._tblJobCards = new EntitySet<tblJobCard>(new Action<tblJobCard>(this.attach_tblJobCards), new Action<tblJobCard>(this.detach_tblJobCards));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int JobId
		{
			get
			{
				return this._JobId;
			}
			set
			{
				if ((this._JobId != value))
				{
					this.OnJobIdChanging(value);
					this.SendPropertyChanging();
					this._JobId = value;
					this.SendPropertyChanged("JobId");
					this.OnJobIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblJob_tblJobCard", Storage="_tblJobCards", ThisKey="Description", OtherKey="Description")]
		public EntitySet<tblJobCard> tblJobCards
		{
			get
			{
				return this._tblJobCards;
			}
			set
			{
				this._tblJobCards.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblJobCards(tblJobCard entity)
		{
			this.SendPropertyChanging();
			entity.tblJob = this;
		}
		
		private void detach_tblJobCards(tblJobCard entity)
		{
			this.SendPropertyChanging();
			entity.tblJob = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblJobCard")]
	public partial class tblJobCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _JobCardId;
		
		private string _Description;
		
		private int _UserId;
		
		private string _Registration;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _CompletionDate;
		
		private EntityRef<tblCar> _tblCar;
		
		private EntityRef<tblJob> _tblJob;
		
		private EntityRef<tblStaff> _tblStaff;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJobCardIdChanging(int value);
    partial void OnJobCardIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnRegistrationChanging(string value);
    partial void OnRegistrationChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnCompletionDateChanging(System.DateTime value);
    partial void OnCompletionDateChanged();
    #endregion
		
		public tblJobCard()
		{
			this._tblCar = default(EntityRef<tblCar>);
			this._tblJob = default(EntityRef<tblJob>);
			this._tblStaff = default(EntityRef<tblStaff>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobCardId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int JobCardId
		{
			get
			{
				return this._JobCardId;
			}
			set
			{
				if ((this._JobCardId != value))
				{
					this.OnJobCardIdChanging(value);
					this.SendPropertyChanging();
					this._JobCardId = value;
					this.SendPropertyChanged("JobCardId");
					this.OnJobCardIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					if (this._tblJob.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._tblStaff.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Registration", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Registration
		{
			get
			{
				return this._Registration;
			}
			set
			{
				if ((this._Registration != value))
				{
					if (this._tblCar.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRegistrationChanging(value);
					this.SendPropertyChanging();
					this._Registration = value;
					this.SendPropertyChanged("Registration");
					this.OnRegistrationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompletionDate", DbType="DateTime NOT NULL")]
		public System.DateTime CompletionDate
		{
			get
			{
				return this._CompletionDate;
			}
			set
			{
				if ((this._CompletionDate != value))
				{
					this.OnCompletionDateChanging(value);
					this.SendPropertyChanging();
					this._CompletionDate = value;
					this.SendPropertyChanged("CompletionDate");
					this.OnCompletionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCar_tblJobCard", Storage="_tblCar", ThisKey="Registration", OtherKey="Registration", IsForeignKey=true)]
		public tblCar tblCar
		{
			get
			{
				return this._tblCar.Entity;
			}
			set
			{
				tblCar previousValue = this._tblCar.Entity;
				if (((previousValue != value) 
							|| (this._tblCar.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCar.Entity = null;
						previousValue.tblJobCards.Remove(this);
					}
					this._tblCar.Entity = value;
					if ((value != null))
					{
						value.tblJobCards.Add(this);
						this._Registration = value.Registration;
					}
					else
					{
						this._Registration = default(string);
					}
					this.SendPropertyChanged("tblCar");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblJob_tblJobCard", Storage="_tblJob", ThisKey="Description", OtherKey="Description", IsForeignKey=true)]
		public tblJob tblJob
		{
			get
			{
				return this._tblJob.Entity;
			}
			set
			{
				tblJob previousValue = this._tblJob.Entity;
				if (((previousValue != value) 
							|| (this._tblJob.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblJob.Entity = null;
						previousValue.tblJobCards.Remove(this);
					}
					this._tblJob.Entity = value;
					if ((value != null))
					{
						value.tblJobCards.Add(this);
						this._Description = value.Description;
					}
					else
					{
						this._Description = default(string);
					}
					this.SendPropertyChanged("tblJob");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblStaff_tblJobCard", Storage="_tblStaff", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public tblStaff tblStaff
		{
			get
			{
				return this._tblStaff.Entity;
			}
			set
			{
				tblStaff previousValue = this._tblStaff.Entity;
				if (((previousValue != value) 
							|| (this._tblStaff.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblStaff.Entity = null;
						previousValue.tblJobCards.Remove(this);
					}
					this._tblStaff.Entity = value;
					if ((value != null))
					{
						value.tblJobCards.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("tblStaff");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
