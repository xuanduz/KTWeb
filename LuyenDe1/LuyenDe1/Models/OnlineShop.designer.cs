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

namespace LuyenDe1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OnlineShop")]
	public partial class OnlineShopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertNavItem(NavItem instance);
    partial void UpdateNavItem(NavItem instance);
    partial void DeleteNavItem(NavItem instance);
    partial void InsertOrderDetail(OrderDetail instance);
    partial void UpdateOrderDetail(OrderDetail instance);
    partial void DeleteOrderDetail(OrderDetail instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public OnlineShopDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["OnlineShopConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineShopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineShopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<NavItem> NavItems
		{
			get
			{
				return this.GetTable<NavItem>();
			}
		}
		
		public System.Data.Linq.Table<OrderDetail> OrderDetails
		{
			get
			{
				return this.GetTable<OrderDetail>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _NameVN;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnNameVNChanging(string value);
    partial void OnNameVNChanged();
    #endregion
		
		public Category()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameVN", DbType="NVarChar(50)")]
		public string NameVN
		{
			get
			{
				return this._NameVN;
			}
			set
			{
				if ((this._NameVN != value))
				{
					this.OnNameVNChanging(value);
					this.SendPropertyChanging();
					this._NameVN = value;
					this.SendPropertyChanged("NameVN");
					this.OnNameVNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Products", ThisKey="Id", OtherKey="CategoryId")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private double _UnitPrice;
		
		private string _Image;
		
		private bool _Available;
		
		private int _CategoryId;
		
		private string _Description;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUnitPriceChanging(double value);
    partial void OnUnitPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnAvailableChanging(bool value);
    partial void OnAvailableChanged();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Product()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Float NOT NULL")]
		public double UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(MAX)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Available", DbType="Bit NOT NULL")]
		public bool Available
		{
			get
			{
				return this._Available;
			}
			set
			{
				if ((this._Available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._Available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", DbType="Int NOT NULL")]
		public int CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_OrderDetails", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category", ThisKey="CategoryId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._CategoryId = value.Id;
					}
					else
					{
						this._CategoryId = default(int);
					}
					this.SendPropertyChanged("Category");
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Fullname;
		
		private string _Email;
		
		private string _Password;
		
		private string _RePassword;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRePasswordChanging(string value);
    partial void OnRePasswordChanged();
    #endregion
		
		public Customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RePassword", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string RePassword
		{
			get
			{
				return this._RePassword;
			}
			set
			{
				if ((this._RePassword != value))
				{
					this.OnRePasswordChanging(value);
					this.SendPropertyChanging();
					this._RePassword = value;
					this.SendPropertyChanged("RePassword");
					this.OnRePasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Orders", ThisKey="Id", OtherKey="CustomerId")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NavItems")]
	public partial class NavItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NavName;
		
		private string _NavNameVN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNavNameChanging(string value);
    partial void OnNavNameChanged();
    partial void OnNavNameVNChanging(string value);
    partial void OnNavNameVNChanged();
    #endregion
		
		public NavItem()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NavName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NavName
		{
			get
			{
				return this._NavName;
			}
			set
			{
				if ((this._NavName != value))
				{
					this.OnNavNameChanging(value);
					this.SendPropertyChanging();
					this._NavName = value;
					this.SendPropertyChanged("NavName");
					this.OnNavNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NavNameVN", DbType="NVarChar(50)")]
		public string NavNameVN
		{
			get
			{
				return this._NavNameVN;
			}
			set
			{
				if ((this._NavNameVN != value))
				{
					this.OnNavNameVNChanging(value);
					this.SendPropertyChanging();
					this._NavNameVN = value;
					this.SendPropertyChanged("NavNameVN");
					this.OnNavNameVNChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderDetails")]
	public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _OrderId;
		
		private string _ProductId;
		
		private double _UnitPrice;
		
		private int _Quantity;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnProductIdChanging(string value);
    partial void OnProductIdChanged();
    partial void OnUnitPriceChanging(double value);
    partial void OnUnitPriceChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
		
		public OrderDetail()
		{
			this._Product = default(EntityRef<Product>);
			this._Order = default(EntityRef<Order>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL")]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Float NOT NULL")]
		public double UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_Product", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(string);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderDetail", Storage="_Order", ThisKey="OrderId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderDetails.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderDetails.Add(this);
						this._OrderId = value.Id;
					}
					else
					{
						this._OrderId = default(int);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CustomerId;
		
		private System.DateTime _OrderDate;
		
		private string _Address;
		
		private System.Nullable<double> _Amount;
		
		private string _Description;
		
		private EntitySet<OrderDetail> _OrderDetails;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnOrderDateChanging(System.DateTime value);
    partial void OnOrderDateChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnAmountChanging(System.Nullable<double> value);
    partial void OnAmountChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Order()
		{
			this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
			this._Customer = default(EntityRef<Customer>);
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
					if (this._Customer.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime NOT NULL")]
		public System.DateTime OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Float")]
		public System.Nullable<double> Amount
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderDetail", Storage="_OrderDetails", ThisKey="Id", OtherKey="OrderId")]
		public EntitySet<OrderDetail> OrderDetails
		{
			get
			{
				return this._OrderDetails;
			}
			set
			{
				this._OrderDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Customer", ThisKey="CustomerId", OtherKey="Id", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._CustomerId = value.Id;
					}
					else
					{
						this._CustomerId = default(int);
					}
					this.SendPropertyChanged("Customer");
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
		
		private void attach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderDetails(OrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
}
#pragma warning restore 1591
