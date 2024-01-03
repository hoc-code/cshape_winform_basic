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

namespace de2_TranVanLong_0194866
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="quanlycosodulieu")]
	public partial class quanlycosodulieuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
        internal IEnumerable<object> tbl_lopquanlis;

        #region Extensibility Method Definitions
        partial void OnCreated();
    partial void Inserttbl_lopquanly(tbl_lopquanly instance);
    partial void Updatetbl_lopquanly(tbl_lopquanly instance);
    partial void Deletetbl_lopquanly(tbl_lopquanly instance);
    partial void Inserttbl_nhomquyen(tbl_nhomquyen instance);
    partial void Updatetbl_nhomquyen(tbl_nhomquyen instance);
    partial void Deletetbl_nhomquyen(tbl_nhomquyen instance);
    partial void Inserttbl_sinhvien(tbl_sinhvien instance);
    partial void Updatetbl_sinhvien(tbl_sinhvien instance);
    partial void Deletetbl_sinhvien(tbl_sinhvien instance);
    partial void Inserttbl_taikhoan(tbl_taikhoan instance);
    partial void Updatetbl_taikhoan(tbl_taikhoan instance);
    partial void Deletetbl_taikhoan(tbl_taikhoan instance);
    #endregion
		
		public quanlycosodulieuDataContext() : 
				base(global::de2_TranVanLong_0194866.Properties.Settings.Default.quanlycosodulieuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public quanlycosodulieuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public quanlycosodulieuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public quanlycosodulieuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public quanlycosodulieuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_lopquanly> tbl_lopquanlies
		{
			get
			{
				return this.GetTable<tbl_lopquanly>();
			}
		}
		
		public System.Data.Linq.Table<tbl_nhomquyen> tbl_nhomquyens
		{
			get
			{
				return this.GetTable<tbl_nhomquyen>();
			}
		}
		
		public System.Data.Linq.Table<tbl_sinhvien> tbl_sinhviens
		{
			get
			{
				return this.GetTable<tbl_sinhvien>();
			}
		}
		
		public System.Data.Linq.Table<tbl_taikhoan> tbl_taikhoans
		{
			get
			{
				return this.GetTable<tbl_taikhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_lopquanly")]
	public partial class tbl_lopquanly : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _lqlma;
		
		private string _lqlten;
		
		private System.Nullable<int> _lqlkhoahoc;
		
		private EntitySet<tbl_sinhvien> _tbl_sinhviens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnlqlmaChanging(string value);
    partial void OnlqlmaChanged();
    partial void OnlqltenChanging(string value);
    partial void OnlqltenChanged();
    partial void OnlqlkhoahocChanging(System.Nullable<int> value);
    partial void OnlqlkhoahocChanged();
    #endregion
		
		public tbl_lopquanly()
		{
			this._tbl_sinhviens = new EntitySet<tbl_sinhvien>(new Action<tbl_sinhvien>(this.attach_tbl_sinhviens), new Action<tbl_sinhvien>(this.detach_tbl_sinhviens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lqlma", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string lqlma
		{
			get
			{
				return this._lqlma;
			}
			set
			{
				if ((this._lqlma != value))
				{
					this.OnlqlmaChanging(value);
					this.SendPropertyChanging();
					this._lqlma = value;
					this.SendPropertyChanged("lqlma");
					this.OnlqlmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lqlten", DbType="NVarChar(50)")]
		public string lqlten
		{
			get
			{
				return this._lqlten;
			}
			set
			{
				if ((this._lqlten != value))
				{
					this.OnlqltenChanging(value);
					this.SendPropertyChanging();
					this._lqlten = value;
					this.SendPropertyChanged("lqlten");
					this.OnlqltenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lqlkhoahoc", DbType="Int")]
		public System.Nullable<int> lqlkhoahoc
		{
			get
			{
				return this._lqlkhoahoc;
			}
			set
			{
				if ((this._lqlkhoahoc != value))
				{
					this.OnlqlkhoahocChanging(value);
					this.SendPropertyChanging();
					this._lqlkhoahoc = value;
					this.SendPropertyChanged("lqlkhoahoc");
					this.OnlqlkhoahocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_lopquanly_tbl_sinhvien", Storage="_tbl_sinhviens", ThisKey="lqlma", OtherKey="lqlma")]
		public EntitySet<tbl_sinhvien> tbl_sinhviens
		{
			get
			{
				return this._tbl_sinhviens;
			}
			set
			{
				this._tbl_sinhviens.Assign(value);
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
		
		private void attach_tbl_sinhviens(tbl_sinhvien entity)
		{
			this.SendPropertyChanging();
			entity.tbl_lopquanly = this;
		}
		
		private void detach_tbl_sinhviens(tbl_sinhvien entity)
		{
			this.SendPropertyChanging();
			entity.tbl_lopquanly = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_nhomquyen")]
	public partial class tbl_nhomquyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nqma;
		
		private string _nqten;
		
		private string _nqmota;
		
		private EntitySet<tbl_taikhoan> _tbl_taikhoans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnqmaChanging(int value);
    partial void OnnqmaChanged();
    partial void OnnqtenChanging(string value);
    partial void OnnqtenChanged();
    partial void OnnqmotaChanging(string value);
    partial void OnnqmotaChanged();
    #endregion
		
		public tbl_nhomquyen()
		{
			this._tbl_taikhoans = new EntitySet<tbl_taikhoan>(new Action<tbl_taikhoan>(this.attach_tbl_taikhoans), new Action<tbl_taikhoan>(this.detach_tbl_taikhoans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nqma", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int nqma
		{
			get
			{
				return this._nqma;
			}
			set
			{
				if ((this._nqma != value))
				{
					this.OnnqmaChanging(value);
					this.SendPropertyChanging();
					this._nqma = value;
					this.SendPropertyChanged("nqma");
					this.OnnqmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nqten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nqten
		{
			get
			{
				return this._nqten;
			}
			set
			{
				if ((this._nqten != value))
				{
					this.OnnqtenChanging(value);
					this.SendPropertyChanging();
					this._nqten = value;
					this.SendPropertyChanged("nqten");
					this.OnnqtenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nqmota", DbType="NVarChar(100)")]
		public string nqmota
		{
			get
			{
				return this._nqmota;
			}
			set
			{
				if ((this._nqmota != value))
				{
					this.OnnqmotaChanging(value);
					this.SendPropertyChanging();
					this._nqmota = value;
					this.SendPropertyChanged("nqmota");
					this.OnnqmotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_nhomquyen_tbl_taikhoan", Storage="_tbl_taikhoans", ThisKey="nqma", OtherKey="nqma")]
		public EntitySet<tbl_taikhoan> tbl_taikhoans
		{
			get
			{
				return this._tbl_taikhoans;
			}
			set
			{
				this._tbl_taikhoans.Assign(value);
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
		
		private void attach_tbl_taikhoans(tbl_taikhoan entity)
		{
			this.SendPropertyChanging();
			entity.tbl_nhomquyen = this;
		}
		
		private void detach_tbl_taikhoans(tbl_taikhoan entity)
		{
			this.SendPropertyChanging();
			entity.tbl_nhomquyen = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_sinhvien")]
	public partial class tbl_sinhvien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _svma;
		
		private string _svten;
		
		private System.Nullable<byte> _svgioitinh;
		
		private string _svquequan;
		
		private string _lqlma;
		
		private System.Nullable<System.DateTime> _svngaysinh;
		
		private EntityRef<tbl_lopquanly> _tbl_lopquanly;
        internal object lqlten;

        #region Extensibility Method Definitions
        partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsvmaChanging(string value);
    partial void OnsvmaChanged();
    partial void OnsvtenChanging(string value);
    partial void OnsvtenChanged();
    partial void OnsvgioitinhChanging(System.Nullable<byte> value);
    partial void OnsvgioitinhChanged();
    partial void OnsvquequanChanging(string value);
    partial void OnsvquequanChanged();
    partial void OnlqlmaChanging(string value);
    partial void OnlqlmaChanged();
    partial void OnsvngaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnsvngaysinhChanged();
    #endregion
		
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_svma", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string svma
		{
			get
			{
				return this._svma;
			}
			set
			{
				if ((this._svma != value))
				{
					this.OnsvmaChanging(value);
					this.SendPropertyChanging();
					this._svma = value;
					this.SendPropertyChanged("svma");
					this.OnsvmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_svten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string svten
		{
			get
			{
				return this._svten;
			}
			set
			{
				if ((this._svten != value))
				{
					this.OnsvtenChanging(value);
					this.SendPropertyChanging();
					this._svten = value;
					this.SendPropertyChanged("svten");
					this.OnsvtenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_svgioitinh", DbType="TinyInt")]
		public System.Nullable<byte> svgioitinh
		{
			get
			{
				return this._svgioitinh;
			}
			set
			{
				if ((this._svgioitinh != value))
				{
					this.OnsvgioitinhChanging(value);
					this.SendPropertyChanging();
					this._svgioitinh = value;
					this.SendPropertyChanged("svgioitinh");
					this.OnsvgioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_svquequan", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string svquequan
		{
			get
			{
				return this._svquequan;
			}
			set
			{
				if ((this._svquequan != value))
				{
					this.OnsvquequanChanging(value);
					this.SendPropertyChanging();
					this._svquequan = value;
					this.SendPropertyChanged("svquequan");
					this.OnsvquequanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lqlma", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string lqlma
		{
			get
			{
				return this._lqlma;
			}
			set
			{
				if ((this._lqlma != value))
				{
					if (this._tbl_lopquanly.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnlqlmaChanging(value);
					this.SendPropertyChanging();
					this._lqlma = value;
					this.SendPropertyChanged("lqlma");
					this.OnlqlmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_svngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> svngaysinh
		{
			get
			{
				return this._svngaysinh;
			}
			set
			{
				if ((this._svngaysinh != value))
				{
					this.OnsvngaysinhChanging(value);
					this.SendPropertyChanging();
					this._svngaysinh = value;
					this.SendPropertyChanged("svngaysinh");
					this.OnsvngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_lopquanly_tbl_sinhvien", Storage="_tbl_lopquanly", ThisKey="lqlma", OtherKey="lqlma", IsForeignKey=true)]
		public tbl_lopquanly tbl_lopquanly
		{
			get
			{
				return this._tbl_lopquanly.Entity;
			}
			set
			{
				tbl_lopquanly previousValue = this._tbl_lopquanly.Entity;
				if (((previousValue != value) 
							|| (this._tbl_lopquanly.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_lopquanly.Entity = null;
						previousValue.tbl_sinhviens.Remove(this);
					}
					this._tbl_lopquanly.Entity = value;
					if ((value != null))
					{
						value.tbl_sinhviens.Add(this);
						this._lqlma = value.lqlma;
					}
					else
					{
						this._lqlma = default(string);
					}
					this.SendPropertyChanged("tbl_lopquanly");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_taikhoan")]
	public partial class tbl_taikhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _tktaikhoan;
		
		private string _tkmatkhau;
		
		private int _nqma;
		
		private EntityRef<tbl_nhomquyen> _tbl_nhomquyen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntktaikhoanChanging(string value);
    partial void OntktaikhoanChanged();
    partial void OntkmatkhauChanging(string value);
    partial void OntkmatkhauChanged();
    partial void OnnqmaChanging(int value);
    partial void OnnqmaChanged();
    #endregion
		
		public tbl_taikhoan()
		{
			this._tbl_nhomquyen = default(EntityRef<tbl_nhomquyen>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tktaikhoan", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string tktaikhoan
		{
			get
			{
				return this._tktaikhoan;
			}
			set
			{
				if ((this._tktaikhoan != value))
				{
					this.OntktaikhoanChanging(value);
					this.SendPropertyChanging();
					this._tktaikhoan = value;
					this.SendPropertyChanged("tktaikhoan");
					this.OntktaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tkmatkhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tkmatkhau
		{
			get
			{
				return this._tkmatkhau;
			}
			set
			{
				if ((this._tkmatkhau != value))
				{
					this.OntkmatkhauChanging(value);
					this.SendPropertyChanging();
					this._tkmatkhau = value;
					this.SendPropertyChanged("tkmatkhau");
					this.OntkmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nqma", DbType="Int NOT NULL")]
		public int nqma
		{
			get
			{
				return this._nqma;
			}
			set
			{
				if ((this._nqma != value))
				{
					if (this._tbl_nhomquyen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnnqmaChanging(value);
					this.SendPropertyChanging();
					this._nqma = value;
					this.SendPropertyChanged("nqma");
					this.OnnqmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_nhomquyen_tbl_taikhoan", Storage="_tbl_nhomquyen", ThisKey="nqma", OtherKey="nqma", IsForeignKey=true)]
		public tbl_nhomquyen tbl_nhomquyen
		{
			get
			{
				return this._tbl_nhomquyen.Entity;
			}
			set
			{
				tbl_nhomquyen previousValue = this._tbl_nhomquyen.Entity;
				if (((previousValue != value) 
							|| (this._tbl_nhomquyen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_nhomquyen.Entity = null;
						previousValue.tbl_taikhoans.Remove(this);
					}
					this._tbl_nhomquyen.Entity = value;
					if ((value != null))
					{
						value.tbl_taikhoans.Add(this);
						this._nqma = value.nqma;
					}
					else
					{
						this._nqma = default(int);
					}
					this.SendPropertyChanged("tbl_nhomquyen");
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
