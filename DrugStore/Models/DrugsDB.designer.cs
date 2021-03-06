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

namespace DrugStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DRUG_STORE")]
	public partial class DrugsDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBill_Detail(Bill_Detail instance);
    partial void UpdateBill_Detail(Bill_Detail instance);
    partial void DeleteBill_Detail(Bill_Detail instance);
    partial void InsertBill(Bill instance);
    partial void UpdateBill(Bill instance);
    partial void DeleteBill(Bill instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertDrug(Drug instance);
    partial void UpdateDrug(Drug instance);
    partial void DeleteDrug(Drug instance);
    partial void InsertManufacturer(Manufacturer instance);
    partial void UpdateManufacturer(Manufacturer instance);
    partial void DeleteManufacturer(Manufacturer instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DrugsDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DRUG_STOREConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DrugsDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DrugsDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DrugsDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DrugsDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bill_Detail> Bill_Details
		{
			get
			{
				return this.GetTable<Bill_Detail>();
			}
		}
		
		public System.Data.Linq.Table<Bill> Bills
		{
			get
			{
				return this.GetTable<Bill>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Drug> Drugs
		{
			get
			{
				return this.GetTable<Drug>();
			}
		}
		
		public System.Data.Linq.Table<Manufacturer> Manufacturers
		{
			get
			{
				return this.GetTable<Manufacturer>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bill_Details")]
	public partial class Bill_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Bill_ID;
		
		private int _Drug_Id;
		
		private int _Quantity;
		
		private double _Amount;
		
		private EntityRef<Bill> _Bill;
		
		private EntityRef<Drug> _Drug;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBill_IDChanging(int value);
    partial void OnBill_IDChanged();
    partial void OnDrug_IdChanging(int value);
    partial void OnDrug_IdChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnAmountChanging(double value);
    partial void OnAmountChanged();
    #endregion
		
		public Bill_Detail()
		{
			this._Bill = default(EntityRef<Bill>);
			this._Drug = default(EntityRef<Drug>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bill_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Bill_ID
		{
			get
			{
				return this._Bill_ID;
			}
			set
			{
				if ((this._Bill_ID != value))
				{
					if (this._Bill.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBill_IDChanging(value);
					this.SendPropertyChanging();
					this._Bill_ID = value;
					this.SendPropertyChanged("Bill_ID");
					this.OnBill_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Drug_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Drug_Id
		{
			get
			{
				return this._Drug_Id;
			}
			set
			{
				if ((this._Drug_Id != value))
				{
					if (this._Drug.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDrug_IdChanging(value);
					this.SendPropertyChanging();
					this._Drug_Id = value;
					this.SendPropertyChanged("Drug_Id");
					this.OnDrug_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float NOT NULL")]
		public double Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bill_Bill_Detail", Storage="_Bill", ThisKey="Bill_ID", OtherKey="Bill_Id", IsForeignKey=true)]
		public Bill Bill
		{
			get
			{
				return this._Bill.Entity;
			}
			set
			{
				Bill previousValue = this._Bill.Entity;
				if (((previousValue != value) 
							|| (this._Bill.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bill.Entity = null;
						previousValue.Bill_Details.Remove(this);
					}
					this._Bill.Entity = value;
					if ((value != null))
					{
						value.Bill_Details.Add(this);
						this._Bill_ID = value.Bill_Id;
					}
					else
					{
						this._Bill_ID = default(int);
					}
					this.SendPropertyChanged("Bill");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Drug_Bill_Detail", Storage="_Drug", ThisKey="Drug_Id", OtherKey="Drug_Id", IsForeignKey=true)]
		public Drug Drug
		{
			get
			{
				return this._Drug.Entity;
			}
			set
			{
				Drug previousValue = this._Drug.Entity;
				if (((previousValue != value) 
							|| (this._Drug.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Drug.Entity = null;
						previousValue.Bill_Details.Remove(this);
					}
					this._Drug.Entity = value;
					if ((value != null))
					{
						value.Bill_Details.Add(this);
						this._Drug_Id = value.Drug_Id;
					}
					else
					{
						this._Drug_Id = default(int);
					}
					this.SendPropertyChanged("Drug");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bills")]
	public partial class Bill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Bill_Id;
		
		private System.DateTime _Bill_Date;
		
		private double _Total;
		
		private int _User_Id;
		
		private EntitySet<Bill_Detail> _Bill_Details;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBill_IdChanging(int value);
    partial void OnBill_IdChanged();
    partial void OnBill_DateChanging(System.DateTime value);
    partial void OnBill_DateChanged();
    partial void OnTotalChanging(double value);
    partial void OnTotalChanged();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    #endregion
		
		public Bill()
		{
			this._Bill_Details = new EntitySet<Bill_Detail>(new Action<Bill_Detail>(this.attach_Bill_Details), new Action<Bill_Detail>(this.detach_Bill_Details));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bill_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Bill_Id
		{
			get
			{
				return this._Bill_Id;
			}
			set
			{
				if ((this._Bill_Id != value))
				{
					this.OnBill_IdChanging(value);
					this.SendPropertyChanging();
					this._Bill_Id = value;
					this.SendPropertyChanged("Bill_Id");
					this.OnBill_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bill_Date", DbType="Date NOT NULL")]
		public System.DateTime Bill_Date
		{
			get
			{
				return this._Bill_Date;
			}
			set
			{
				if ((this._Bill_Date != value))
				{
					this.OnBill_DateChanging(value);
					this.SendPropertyChanging();
					this._Bill_Date = value;
					this.SendPropertyChanged("Bill_Date");
					this.OnBill_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Float NOT NULL")]
		public double Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", DbType="Int NOT NULL")]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bill_Bill_Detail", Storage="_Bill_Details", ThisKey="Bill_Id", OtherKey="Bill_ID")]
		public EntitySet<Bill_Detail> Bill_Details
		{
			get
			{
				return this._Bill_Details;
			}
			set
			{
				this._Bill_Details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Bill", Storage="_User", ThisKey="User_Id", OtherKey="User_Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Bills.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Bills.Add(this);
						this._User_Id = value.User_Id;
					}
					else
					{
						this._User_Id = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Bill_Details(Bill_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Bill = this;
		}
		
		private void detach_Bill_Details(Bill_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Bill = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categorys")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Cate_Id;
		
		private string _Cate_Name;
		
		private EntitySet<Drug> _Drugs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCate_IdChanging(int value);
    partial void OnCate_IdChanged();
    partial void OnCate_NameChanging(string value);
    partial void OnCate_NameChanged();
    #endregion
		
		public Category()
		{
			this._Drugs = new EntitySet<Drug>(new Action<Drug>(this.attach_Drugs), new Action<Drug>(this.detach_Drugs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cate_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Cate_Id
		{
			get
			{
				return this._Cate_Id;
			}
			set
			{
				if ((this._Cate_Id != value))
				{
					this.OnCate_IdChanging(value);
					this.SendPropertyChanging();
					this._Cate_Id = value;
					this.SendPropertyChanged("Cate_Id");
					this.OnCate_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cate_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Cate_Name
		{
			get
			{
				return this._Cate_Name;
			}
			set
			{
				if ((this._Cate_Name != value))
				{
					this.OnCate_NameChanging(value);
					this.SendPropertyChanging();
					this._Cate_Name = value;
					this.SendPropertyChanged("Cate_Name");
					this.OnCate_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Drug", Storage="_Drugs", ThisKey="Cate_Id", OtherKey="Category")]
		public EntitySet<Drug> Drugs
		{
			get
			{
				return this._Drugs;
			}
			set
			{
				this._Drugs.Assign(value);
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
		
		private void attach_Drugs(Drug entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = this;
		}
		
		private void detach_Drugs(Drug entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Drugs")]
	public partial class Drug : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Drug_Id;
		
		private string _Drug_Name;
		
		private string _Description;
		
		private string _Images;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<System.DateTime> _MFG;
		
		private System.Nullable<System.DateTime> _EXP;
		
		private System.Nullable<int> _Manufacturer;
		
		private System.Nullable<int> _Category;
		
		private double _Price;
		
		private EntitySet<Bill_Detail> _Bill_Details;
		
		private EntityRef<Category> _Category1;
		
		private EntityRef<Manufacturer> _Manufacturer1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDrug_IdChanging(int value);
    partial void OnDrug_IdChanged();
    partial void OnDrug_NameChanging(string value);
    partial void OnDrug_NameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnMFGChanging(System.Nullable<System.DateTime> value);
    partial void OnMFGChanged();
    partial void OnEXPChanging(System.Nullable<System.DateTime> value);
    partial void OnEXPChanged();
    partial void OnManufacturerChanging(System.Nullable<int> value);
    partial void OnManufacturerChanged();
    partial void OnCategoryChanging(System.Nullable<int> value);
    partial void OnCategoryChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    #endregion
		
		public Drug()
		{
			this._Bill_Details = new EntitySet<Bill_Detail>(new Action<Bill_Detail>(this.attach_Bill_Details), new Action<Bill_Detail>(this.detach_Bill_Details));
			this._Category1 = default(EntityRef<Category>);
			this._Manufacturer1 = default(EntityRef<Manufacturer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Drug_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Drug_Id
		{
			get
			{
				return this._Drug_Id;
			}
			set
			{
				if ((this._Drug_Id != value))
				{
					this.OnDrug_IdChanging(value);
					this.SendPropertyChanging();
					this._Drug_Id = value;
					this.SendPropertyChanged("Drug_Id");
					this.OnDrug_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Drug_Name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Drug_Name
		{
			get
			{
				return this._Drug_Name;
			}
			set
			{
				if ((this._Drug_Name != value))
				{
					this.OnDrug_NameChanging(value);
					this.SendPropertyChanging();
					this._Drug_Name = value;
					this.SendPropertyChanged("Drug_Name");
					this.OnDrug_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MFG", DbType="DateTime")]
		public System.Nullable<System.DateTime> MFG
		{
			get
			{
				return this._MFG;
			}
			set
			{
				if ((this._MFG != value))
				{
					this.OnMFGChanging(value);
					this.SendPropertyChanging();
					this._MFG = value;
					this.SendPropertyChanged("MFG");
					this.OnMFGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXP", DbType="DateTime")]
		public System.Nullable<System.DateTime> EXP
		{
			get
			{
				return this._EXP;
			}
			set
			{
				if ((this._EXP != value))
				{
					this.OnEXPChanging(value);
					this.SendPropertyChanging();
					this._EXP = value;
					this.SendPropertyChanged("EXP");
					this.OnEXPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manufacturer", DbType="Int")]
		public System.Nullable<int> Manufacturer
		{
			get
			{
				return this._Manufacturer;
			}
			set
			{
				if ((this._Manufacturer != value))
				{
					if (this._Manufacturer1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Manufacturer = value;
					this.SendPropertyChanged("Manufacturer");
					this.OnManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="Int")]
		public System.Nullable<int> Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					if (this._Category1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Drug_Bill_Detail", Storage="_Bill_Details", ThisKey="Drug_Id", OtherKey="Drug_Id")]
		public EntitySet<Bill_Detail> Bill_Details
		{
			get
			{
				return this._Bill_Details;
			}
			set
			{
				this._Bill_Details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Drug", Storage="_Category1", ThisKey="Category", OtherKey="Cate_Id", IsForeignKey=true)]
		public Category Category1
		{
			get
			{
				return this._Category1.Entity;
			}
			set
			{
				Category previousValue = this._Category1.Entity;
				if (((previousValue != value) 
							|| (this._Category1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category1.Entity = null;
						previousValue.Drugs.Remove(this);
					}
					this._Category1.Entity = value;
					if ((value != null))
					{
						value.Drugs.Add(this);
						this._Category = value.Cate_Id;
					}
					else
					{
						this._Category = default(Nullable<int>);
					}
					this.SendPropertyChanged("Category1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Manufacturer_Drug", Storage="_Manufacturer1", ThisKey="Manufacturer", OtherKey="Id", IsForeignKey=true)]
		public Manufacturer Manufacturer1
		{
			get
			{
				return this._Manufacturer1.Entity;
			}
			set
			{
				Manufacturer previousValue = this._Manufacturer1.Entity;
				if (((previousValue != value) 
							|| (this._Manufacturer1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Manufacturer1.Entity = null;
						previousValue.Drugs.Remove(this);
					}
					this._Manufacturer1.Entity = value;
					if ((value != null))
					{
						value.Drugs.Add(this);
						this._Manufacturer = value.Id;
					}
					else
					{
						this._Manufacturer = default(Nullable<int>);
					}
					this.SendPropertyChanged("Manufacturer1");
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
		
		private void attach_Bill_Details(Bill_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Drug = this;
		}
		
		private void detach_Bill_Details(Bill_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Drug = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manufacturers")]
	public partial class Manufacturer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Drug> _Drugs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Manufacturer()
		{
			this._Drugs = new EntitySet<Drug>(new Action<Drug>(this.attach_Drugs), new Action<Drug>(this.detach_Drugs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Manufacturer_Drug", Storage="_Drugs", ThisKey="Id", OtherKey="Manufacturer")]
		public EntitySet<Drug> Drugs
		{
			get
			{
				return this._Drugs;
			}
			set
			{
				this._Drugs.Assign(value);
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
		
		private void attach_Drugs(Drug entity)
		{
			this.SendPropertyChanging();
			entity.Manufacturer1 = this;
		}
		
		private void detach_Drugs(Drug entity)
		{
			this.SendPropertyChanging();
			entity.Manufacturer1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Role_Id;
		
		private string _Role_Name;
		
		private string _Description;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRole_IdChanging(int value);
    partial void OnRole_IdChanged();
    partial void OnRole_NameChanging(string value);
    partial void OnRole_NameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Role()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Role_Id
		{
			get
			{
				return this._Role_Id;
			}
			set
			{
				if ((this._Role_Id != value))
				{
					this.OnRole_IdChanging(value);
					this.SendPropertyChanging();
					this._Role_Id = value;
					this.SendPropertyChanged("Role_Id");
					this.OnRole_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Role_Name
		{
			get
			{
				return this._Role_Name;
			}
			set
			{
				if ((this._Role_Name != value))
				{
					this.OnRole_NameChanging(value);
					this.SendPropertyChanging();
					this._Role_Name = value;
					this.SendPropertyChanged("Role_Name");
					this.OnRole_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="Role_Id", OtherKey="Role_Id")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_Id;
		
		private string _User_Namme;
		
		private string _Password;
		
		private string _Full_Name;
		
		private string _Email;
		
		private string _Phone;
		
		private string _Avatar;
		
		private string _Address;
		
		private System.Nullable<int> _Role_Id;
		
		private EntitySet<Bill> _Bills;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    partial void OnUser_NammeChanging(string value);
    partial void OnUser_NammeChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFull_NameChanging(string value);
    partial void OnFull_NameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAvatarChanging(string value);
    partial void OnAvatarChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnRole_IdChanging(System.Nullable<int> value);
    partial void OnRole_IdChanged();
    #endregion
		
		public User()
		{
			this._Bills = new EntitySet<Bill>(new Action<Bill>(this.attach_Bills), new Action<Bill>(this.detach_Bills));
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Namme", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string User_Namme
		{
			get
			{
				return this._User_Namme;
			}
			set
			{
				if ((this._User_Namme != value))
				{
					this.OnUser_NammeChanging(value);
					this.SendPropertyChanging();
					this._User_Namme = value;
					this.SendPropertyChanged("User_Namme");
					this.OnUser_NammeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Full_Name
		{
			get
			{
				return this._Full_Name;
			}
			set
			{
				if ((this._Full_Name != value))
				{
					this.OnFull_NameChanging(value);
					this.SendPropertyChanging();
					this._Full_Name = value;
					this.SendPropertyChanged("Full_Name");
					this.OnFull_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avatar", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Avatar
		{
			get
			{
				return this._Avatar;
			}
			set
			{
				if ((this._Avatar != value))
				{
					this.OnAvatarChanging(value);
					this.SendPropertyChanging();
					this._Avatar = value;
					this.SendPropertyChanged("Avatar");
					this.OnAvatarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Id", DbType="Int")]
		public System.Nullable<int> Role_Id
		{
			get
			{
				return this._Role_Id;
			}
			set
			{
				if ((this._Role_Id != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRole_IdChanging(value);
					this.SendPropertyChanging();
					this._Role_Id = value;
					this.SendPropertyChanged("Role_Id");
					this.OnRole_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Bill", Storage="_Bills", ThisKey="User_Id", OtherKey="User_Id")]
		public EntitySet<Bill> Bills
		{
			get
			{
				return this._Bills;
			}
			set
			{
				this._Bills.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="Role_Id", OtherKey="Role_Id", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._Role_Id = value.Role_Id;
					}
					else
					{
						this._Role_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Role");
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
		
		private void attach_Bills(Bill entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Bills(Bill entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
