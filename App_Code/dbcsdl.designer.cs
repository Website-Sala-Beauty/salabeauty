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
  partial void Inserttb_User(tb_User instance);
  partial void Updatetb_User(tb_User instance);
  partial void Deletetb_User(tb_User instance);
  partial void Inserttb_LoaiSanPham(tb_LoaiSanPham instance);
  partial void Updatetb_LoaiSanPham(tb_LoaiSanPham instance);
  partial void Deletetb_LoaiSanPham(tb_LoaiSanPham instance);
  partial void Inserttb_SanPham(tb_SanPham instance);
  partial void Updatetb_SanPham(tb_SanPham instance);
  partial void Deletetb_SanPham(tb_SanPham instance);
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
	
	public System.Data.Linq.Table<admin_GroupUser> admin_GroupUsers
	{
		get
		{
			return this.GetTable<admin_GroupUser>();
		}
	}
	
	public System.Data.Linq.Table<tb_User> tb_Users
	{
		get
		{
			return this.GetTable<tb_User>();
		}
	}
	
	public System.Data.Linq.Table<tb_LoaiSanPham> tb_LoaiSanPhams
	{
		get
		{
			return this.GetTable<tb_LoaiSanPham>();
		}
	}
	
	public System.Data.Linq.Table<tb_SanPham> tb_SanPhams
	{
		get
		{
			return this.GetTable<tb_SanPham>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin_GroupUser")]
public partial class admin_GroupUser
{
	
	private int _groupuser_id;
	
	private string _groupuser_name;
	
	private System.Nullable<bool> _groupuser_active;
	
	public admin_GroupUser()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupuser_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
	public int groupuser_id
	{
		get
		{
			return this._groupuser_id;
		}
		set
		{
			if ((this._groupuser_id != value))
			{
				this._groupuser_id = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupuser_name", DbType="NVarChar(MAX)")]
	public string groupuser_name
	{
		get
		{
			return this._groupuser_name;
		}
		set
		{
			if ((this._groupuser_name != value))
			{
				this._groupuser_name = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupuser_active", DbType="Bit")]
	public System.Nullable<bool> groupuser_active
	{
		get
		{
			return this._groupuser_active;
		}
		set
		{
			if ((this._groupuser_active != value))
			{
				this._groupuser_active = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_User")]
public partial class tb_User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _user_Id;
	
	private string _user_FullName;
	
	private string _user_Phone;
	
	private string _user_Email;
	
	private string _user_Password;
	
	private System.Nullable<bool> _user_Active;
	
	private System.Nullable<int> _groupuser_id;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_IdChanging(int value);
    partial void Onuser_IdChanged();
    partial void Onuser_FullNameChanging(string value);
    partial void Onuser_FullNameChanged();
    partial void Onuser_PhoneChanging(string value);
    partial void Onuser_PhoneChanged();
    partial void Onuser_EmailChanging(string value);
    partial void Onuser_EmailChanged();
    partial void Onuser_PasswordChanging(string value);
    partial void Onuser_PasswordChanged();
    partial void Onuser_ActiveChanging(System.Nullable<bool> value);
    partial void Onuser_ActiveChanged();
    partial void Ongroupuser_idChanging(System.Nullable<int> value);
    partial void Ongroupuser_idChanged();
    #endregion
	
	public tb_User()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int user_Id
	{
		get
		{
			return this._user_Id;
		}
		set
		{
			if ((this._user_Id != value))
			{
				this.Onuser_IdChanging(value);
				this.SendPropertyChanging();
				this._user_Id = value;
				this.SendPropertyChanged("user_Id");
				this.Onuser_IdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_FullName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string user_FullName
	{
		get
		{
			return this._user_FullName;
		}
		set
		{
			if ((this._user_FullName != value))
			{
				this.Onuser_FullNameChanging(value);
				this.SendPropertyChanging();
				this._user_FullName = value;
				this.SendPropertyChanged("user_FullName");
				this.Onuser_FullNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Phone", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string user_Phone
	{
		get
		{
			return this._user_Phone;
		}
		set
		{
			if ((this._user_Phone != value))
			{
				this.Onuser_PhoneChanging(value);
				this.SendPropertyChanging();
				this._user_Phone = value;
				this.SendPropertyChanged("user_Phone");
				this.Onuser_PhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Email", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string user_Email
	{
		get
		{
			return this._user_Email;
		}
		set
		{
			if ((this._user_Email != value))
			{
				this.Onuser_EmailChanging(value);
				this.SendPropertyChanging();
				this._user_Email = value;
				this.SendPropertyChanged("user_Email");
				this.Onuser_EmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string user_Password
	{
		get
		{
			return this._user_Password;
		}
		set
		{
			if ((this._user_Password != value))
			{
				this.Onuser_PasswordChanging(value);
				this.SendPropertyChanging();
				this._user_Password = value;
				this.SendPropertyChanged("user_Password");
				this.Onuser_PasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Active", DbType="Bit")]
	public System.Nullable<bool> user_Active
	{
		get
		{
			return this._user_Active;
		}
		set
		{
			if ((this._user_Active != value))
			{
				this.Onuser_ActiveChanging(value);
				this.SendPropertyChanging();
				this._user_Active = value;
				this.SendPropertyChanged("user_Active");
				this.Onuser_ActiveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupuser_id", DbType="Int")]
	public System.Nullable<int> groupuser_id
	{
		get
		{
			return this._groupuser_id;
		}
		set
		{
			if ((this._groupuser_id != value))
			{
				this.Ongroupuser_idChanging(value);
				this.SendPropertyChanging();
				this._groupuser_id = value;
				this.SendPropertyChanged("groupuser_id");
				this.Ongroupuser_idChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_LoaiSanPham")]
public partial class tb_LoaiSanPham : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _loaisanpham_id;
	
	private string _loaisanpham_name;
	
	private System.Nullable<bool> _loaisanpham_hidden;
	
	private string _loaisanpham_image;
	
	private string _loaisanpham_hinhthuc;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onloaisanpham_idChanging(int value);
    partial void Onloaisanpham_idChanged();
    partial void Onloaisanpham_nameChanging(string value);
    partial void Onloaisanpham_nameChanged();
    partial void Onloaisanpham_hiddenChanging(System.Nullable<bool> value);
    partial void Onloaisanpham_hiddenChanged();
    partial void Onloaisanpham_imageChanging(string value);
    partial void Onloaisanpham_imageChanged();
    partial void Onloaisanpham_hinhthucChanging(string value);
    partial void Onloaisanpham_hinhthucChanged();
    #endregion
	
	public tb_LoaiSanPham()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisanpham_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int loaisanpham_id
	{
		get
		{
			return this._loaisanpham_id;
		}
		set
		{
			if ((this._loaisanpham_id != value))
			{
				this.Onloaisanpham_idChanging(value);
				this.SendPropertyChanging();
				this._loaisanpham_id = value;
				this.SendPropertyChanged("loaisanpham_id");
				this.Onloaisanpham_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisanpham_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string loaisanpham_name
	{
		get
		{
			return this._loaisanpham_name;
		}
		set
		{
			if ((this._loaisanpham_name != value))
			{
				this.Onloaisanpham_nameChanging(value);
				this.SendPropertyChanging();
				this._loaisanpham_name = value;
				this.SendPropertyChanged("loaisanpham_name");
				this.Onloaisanpham_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisanpham_hidden", DbType="Bit")]
	public System.Nullable<bool> loaisanpham_hidden
	{
		get
		{
			return this._loaisanpham_hidden;
		}
		set
		{
			if ((this._loaisanpham_hidden != value))
			{
				this.Onloaisanpham_hiddenChanging(value);
				this.SendPropertyChanging();
				this._loaisanpham_hidden = value;
				this.SendPropertyChanged("loaisanpham_hidden");
				this.Onloaisanpham_hiddenChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisanpham_image", DbType="NVarChar(MAX)")]
	public string loaisanpham_image
	{
		get
		{
			return this._loaisanpham_image;
		}
		set
		{
			if ((this._loaisanpham_image != value))
			{
				this.Onloaisanpham_imageChanging(value);
				this.SendPropertyChanging();
				this._loaisanpham_image = value;
				this.SendPropertyChanged("loaisanpham_image");
				this.Onloaisanpham_imageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisanpham_hinhthuc", DbType="NVarChar(MAX)")]
	public string loaisanpham_hinhthuc
	{
		get
		{
			return this._loaisanpham_hinhthuc;
		}
		set
		{
			if ((this._loaisanpham_hinhthuc != value))
			{
				this.Onloaisanpham_hinhthucChanging(value);
				this.SendPropertyChanging();
				this._loaisanpham_hinhthuc = value;
				this.SendPropertyChanged("loaisanpham_hinhthuc");
				this.Onloaisanpham_hinhthucChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_SanPham")]
public partial class tb_SanPham : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _sanpham_id;
	
	private string _sanpham_name;
	
	private System.Nullable<bool> _sanpham_new;
	
	private string _sanpham_image;
	
	private System.Nullable<int> _loaisanpham_id;
	
	private System.Nullable<int> _sanpham_luotmua;
	
	private System.Nullable<decimal> _sanpham_gia;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsanpham_idChanging(int value);
    partial void Onsanpham_idChanged();
    partial void Onsanpham_nameChanging(string value);
    partial void Onsanpham_nameChanged();
    partial void Onsanpham_newChanging(System.Nullable<bool> value);
    partial void Onsanpham_newChanged();
    partial void Onsanpham_imageChanging(string value);
    partial void Onsanpham_imageChanged();
    partial void Onloaisanpham_idChanging(System.Nullable<int> value);
    partial void Onloaisanpham_idChanged();
    partial void Onsanpham_luotmuaChanging(System.Nullable<int> value);
    partial void Onsanpham_luotmuaChanged();
    partial void Onsanpham_giaChanging(System.Nullable<decimal> value);
    partial void Onsanpham_giaChanged();
    #endregion
	
	public tb_SanPham()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sanpham_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int sanpham_id
	{
		get
		{
			return this._sanpham_id;
		}
		set
		{
			if ((this._sanpham_id != value))
			{
				this.Onsanpham_idChanging(value);
				this.SendPropertyChanging();
				this._sanpham_id = value;
				this.SendPropertyChanged("sanpham_id");
				this.Onsanpham_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sanpham_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string sanpham_name
	{
		get
		{
			return this._sanpham_name;
		}
		set
		{
			if ((this._sanpham_name != value))
			{
				this.Onsanpham_nameChanging(value);
				this.SendPropertyChanging();
				this._sanpham_name = value;
				this.SendPropertyChanged("sanpham_name");
				this.Onsanpham_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sanpham_new", DbType="Bit")]
	public System.Nullable<bool> sanpham_new
	{
		get
		{
			return this._sanpham_new;
		}
		set
		{
			if ((this._sanpham_new != value))
			{
				this.Onsanpham_newChanging(value);
				this.SendPropertyChanging();
				this._sanpham_new = value;
				this.SendPropertyChanged("sanpham_new");
				this.Onsanpham_newChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sanpham_image", DbType="NVarChar(MAX)")]
	public string sanpham_image
	{
		get
		{
			return this._sanpham_image;
		}
		set
		{
			if ((this._sanpham_image != value))
			{
				this.Onsanpham_imageChanging(value);
				this.SendPropertyChanging();
				this._sanpham_image = value;
				this.SendPropertyChanged("sanpham_image");
				this.Onsanpham_imageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisanpham_id", DbType="Int")]
	public System.Nullable<int> loaisanpham_id
	{
		get
		{
			return this._loaisanpham_id;
		}
		set
		{
			if ((this._loaisanpham_id != value))
			{
				this.Onloaisanpham_idChanging(value);
				this.SendPropertyChanging();
				this._loaisanpham_id = value;
				this.SendPropertyChanged("loaisanpham_id");
				this.Onloaisanpham_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sanpham_luotmua", DbType="Int")]
	public System.Nullable<int> sanpham_luotmua
	{
		get
		{
			return this._sanpham_luotmua;
		}
		set
		{
			if ((this._sanpham_luotmua != value))
			{
				this.Onsanpham_luotmuaChanging(value);
				this.SendPropertyChanging();
				this._sanpham_luotmua = value;
				this.SendPropertyChanged("sanpham_luotmua");
				this.Onsanpham_luotmuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sanpham_gia", DbType="SmallMoney")]
	public System.Nullable<decimal> sanpham_gia
	{
		get
		{
			return this._sanpham_gia;
		}
		set
		{
			if ((this._sanpham_gia != value))
			{
				this.Onsanpham_giaChanging(value);
				this.SendPropertyChanging();
				this._sanpham_gia = value;
				this.SendPropertyChanged("sanpham_gia");
				this.Onsanpham_giaChanged();
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
