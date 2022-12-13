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

namespace QLST.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSL")]
	public partial class QLSTDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChucVu(ChucVu instance);
    partial void UpdateChucVu(ChucVu instance);
    partial void DeleteChucVu(ChucVu instance);
    partial void InsertNguoiDung(NguoiDung instance);
    partial void UpdateNguoiDung(NguoiDung instance);
    partial void DeleteNguoiDung(NguoiDung instance);
    #endregion
		
		public QLSTDataDataContext() : 
				base(global::QLST.Properties.Settings.Default.QLSLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLSTDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSTDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSTDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSTDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChucVu> ChucVus
		{
			get
			{
				return this.GetTable<ChucVu>();
			}
		}
		
		public System.Data.Linq.Table<NguoiDung> NguoiDungs
		{
			get
			{
				return this.GetTable<NguoiDung>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChucVu")]
	public partial class ChucVu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChucVu;
		
		private string _TenChucVu;
		
		private EntitySet<NguoiDung> _NguoiDungs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChucVuChanging(int value);
    partial void OnMaChucVuChanged();
    partial void OnTenChucVuChanging(string value);
    partial void OnTenChucVuChanged();
    #endregion
		
		public ChucVu()
		{
			this._NguoiDungs = new EntitySet<NguoiDung>(new Action<NguoiDung>(this.attach_NguoiDungs), new Action<NguoiDung>(this.detach_NguoiDungs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChucVu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaChucVu
		{
			get
			{
				return this._MaChucVu;
			}
			set
			{
				if ((this._MaChucVu != value))
				{
					this.OnMaChucVuChanging(value);
					this.SendPropertyChanging();
					this._MaChucVu = value;
					this.SendPropertyChanged("MaChucVu");
					this.OnMaChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChucVu", DbType="NVarChar(100)")]
		public string TenChucVu
		{
			get
			{
				return this._TenChucVu;
			}
			set
			{
				if ((this._TenChucVu != value))
				{
					this.OnTenChucVuChanging(value);
					this.SendPropertyChanging();
					this._TenChucVu = value;
					this.SendPropertyChanged("TenChucVu");
					this.OnTenChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChucVu_NguoiDung", Storage="_NguoiDungs", ThisKey="MaChucVu", OtherKey="ChucVu")]
		public EntitySet<NguoiDung> NguoiDungs
		{
			get
			{
				return this._NguoiDungs;
			}
			set
			{
				this._NguoiDungs.Assign(value);
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
		
		private void attach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.ChucVu1 = this;
		}
		
		private void detach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.ChucVu1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NguoiDung")]
	public partial class NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDNhanVien;
		
		private string _Ten;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _MatKhau;
		
		private System.Nullable<int> _ChucVu;
		
		private EntityRef<ChucVu> _ChucVu1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDNhanVienChanging(string value);
    partial void OnIDNhanVienChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnChucVuChanging(System.Nullable<int> value);
    partial void OnChucVuChanged();
    #endregion
		
		public NguoiDung()
		{
			this._ChucVu1 = default(EntityRef<ChucVu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNhanVien", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDNhanVien
		{
			get
			{
				return this._IDNhanVien;
			}
			set
			{
				if ((this._IDNhanVien != value))
				{
					this.OnIDNhanVienChanging(value);
					this.SendPropertyChanging();
					this._IDNhanVien = value;
					this.SendPropertyChanged("IDNhanVien");
					this.OnIDNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(100)")]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(100)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="Int")]
		public System.Nullable<int> ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					if (this._ChucVu1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChucVu_NguoiDung", Storage="_ChucVu1", ThisKey="ChucVu", OtherKey="MaChucVu", IsForeignKey=true)]
		public ChucVu ChucVu1
		{
			get
			{
				return this._ChucVu1.Entity;
			}
			set
			{
				ChucVu previousValue = this._ChucVu1.Entity;
				if (((previousValue != value) 
							|| (this._ChucVu1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChucVu1.Entity = null;
						previousValue.NguoiDungs.Remove(this);
					}
					this._ChucVu1.Entity = value;
					if ((value != null))
					{
						value.NguoiDungs.Add(this);
						this._ChucVu = value.MaChucVu;
					}
					else
					{
						this._ChucVu = default(Nullable<int>);
					}
					this.SendPropertyChanged("ChucVu1");
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
