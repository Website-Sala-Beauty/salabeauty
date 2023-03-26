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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="salabeauty")]
public partial class dbcsdlDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertkhachhang(khachhang instance);
  partial void Updatekhachhang(khachhang instance);
  partial void Deletekhachhang(khachhang instance);
  #endregion
	
	public dbcsdlDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["salabeautyConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public dbcsdlDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dbcsdlDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dbcsdlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dbcsdlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<khachhang> khachhangs
	{
		get
		{
			return this.GetTable<khachhang>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.khachhang")]
public partial class khachhang : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _ten;
	
	private string _sdt;
	
	private string _email;
	
	private string _password;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntenChanging(string value);
    partial void OntenChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
	
	public khachhang()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string ten
	{
		get
		{
			return this._ten;
		}
		set
		{
			if ((this._ten != value))
			{
				this.OntenChanging(value);
				this.SendPropertyChanging();
				this._ten = value;
				this.SendPropertyChanged("ten");
				this.OntenChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string sdt
	{
		get
		{
			return this._sdt;
		}
		set
		{
			if ((this._sdt != value))
			{
				this.OnsdtChanging(value);
				this.SendPropertyChanging();
				this._sdt = value;
				this.SendPropertyChanged("sdt");
				this.OnsdtChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
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
#pragma warning restore 1591