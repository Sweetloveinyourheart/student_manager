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

namespace DAO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Quanlydiem")]
	public partial class QuanLyDiemDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblGIANG_VIEN(tblGIANG_VIEN instance);
    partial void UpdatetblGIANG_VIEN(tblGIANG_VIEN instance);
    partial void DeletetblGIANG_VIEN(tblGIANG_VIEN instance);
    partial void InserttblKHOA(tblKHOA instance);
    partial void UpdatetblKHOA(tblKHOA instance);
    partial void DeletetblKHOA(tblKHOA instance);
    partial void InserttblLOGIN(tblLOGIN instance);
    partial void UpdatetblLOGIN(tblLOGIN instance);
    partial void DeletetblLOGIN(tblLOGIN instance);
    partial void InserttblLOP(tblLOP instance);
    partial void UpdatetblLOP(tblLOP instance);
    partial void DeletetblLOP(tblLOP instance);
    partial void InserttblMON(tblMON instance);
    partial void UpdatetblMON(tblMON instance);
    partial void DeletetblMON(tblMON instance);
    partial void InserttblSINH_VIEN(tblSINH_VIEN instance);
    partial void UpdatetblSINH_VIEN(tblSINH_VIEN instance);
    partial void DeletetblSINH_VIEN(tblSINH_VIEN instance);
    #endregion
		
		public QuanLyDiemDataContext() : 
				base(global::DAO.Properties.Settings.Default.QuanlydiemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyDiemDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyDiemDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyDiemDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyDiemDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblGIANG_VIEN> tblGIANG_VIENs
		{
			get
			{
				return this.GetTable<tblGIANG_VIEN>();
			}
		}
		
		public System.Data.Linq.Table<tblKET_QUA> tblKET_QUAs
		{
			get
			{
				return this.GetTable<tblKET_QUA>();
			}
		}
		
		public System.Data.Linq.Table<tblKET_QUA2> tblKET_QUA2s
		{
			get
			{
				return this.GetTable<tblKET_QUA2>();
			}
		}
		
		public System.Data.Linq.Table<tblKET_QUA3> tblKET_QUA3s
		{
			get
			{
				return this.GetTable<tblKET_QUA3>();
			}
		}
		
		public System.Data.Linq.Table<tblKHOA> tblKHOAs
		{
			get
			{
				return this.GetTable<tblKHOA>();
			}
		}
		
		public System.Data.Linq.Table<tblLOGIN> tblLOGINs
		{
			get
			{
				return this.GetTable<tblLOGIN>();
			}
		}
		
		public System.Data.Linq.Table<tblLOP> tblLOPs
		{
			get
			{
				return this.GetTable<tblLOP>();
			}
		}
		
		public System.Data.Linq.Table<tblMON> tblMONs
		{
			get
			{
				return this.GetTable<tblMON>();
			}
		}
		
		public System.Data.Linq.Table<tblSINH_VIEN> tblSINH_VIENs
		{
			get
			{
				return this.GetTable<tblSINH_VIEN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblGIANG_VIEN")]
	public partial class tblGIANG_VIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaGV;
		
		private string _TenGV;
		
		private string _GioiTinh;
		
		private string _Phone;
		
		private string _Email;
		
		private string _PhanLoaiGV;
		
		private System.Nullable<bool> _Anh;
		
		private EntitySet<tblMON> _tblMONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaGVChanging(string value);
    partial void OnMaGVChanged();
    partial void OnTenGVChanging(string value);
    partial void OnTenGVChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhanLoaiGVChanging(string value);
    partial void OnPhanLoaiGVChanged();
    partial void OnAnhChanging(System.Nullable<bool> value);
    partial void OnAnhChanged();
    #endregion
		
		public tblGIANG_VIEN()
		{
			this._tblMONs = new EntitySet<tblMON>(new Action<tblMON>(this.attach_tblMONs), new Action<tblMON>(this.detach_tblMONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaGV", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaGV
		{
			get
			{
				return this._MaGV;
			}
			set
			{
				if ((this._MaGV != value))
				{
					this.OnMaGVChanging(value);
					this.SendPropertyChanging();
					this._MaGV = value;
					this.SendPropertyChanged("MaGV");
					this.OnMaGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenGV", DbType="NVarChar(30)")]
		public string TenGV
		{
			get
			{
				return this._TenGV;
			}
			set
			{
				if ((this._TenGV != value))
				{
					this.OnTenGVChanging(value);
					this.SendPropertyChanging();
					this._TenGV = value;
					this.SendPropertyChanged("TenGV");
					this.OnTenGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(15)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhanLoaiGV", DbType="NVarChar(20)")]
		public string PhanLoaiGV
		{
			get
			{
				return this._PhanLoaiGV;
			}
			set
			{
				if ((this._PhanLoaiGV != value))
				{
					this.OnPhanLoaiGVChanging(value);
					this.SendPropertyChanging();
					this._PhanLoaiGV = value;
					this.SendPropertyChanged("PhanLoaiGV");
					this.OnPhanLoaiGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="Bit")]
		public System.Nullable<bool> Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this.OnAnhChanging(value);
					this.SendPropertyChanging();
					this._Anh = value;
					this.SendPropertyChanged("Anh");
					this.OnAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblGIANG_VIEN_tblMON", Storage="_tblMONs", ThisKey="MaGV", OtherKey="MaGV")]
		public EntitySet<tblMON> tblMONs
		{
			get
			{
				return this._tblMONs;
			}
			set
			{
				this._tblMONs.Assign(value);
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
		
		private void attach_tblMONs(tblMON entity)
		{
			this.SendPropertyChanging();
			entity.tblGIANG_VIEN = this;
		}
		
		private void detach_tblMONs(tblMON entity)
		{
			this.SendPropertyChanging();
			entity.tblGIANG_VIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKET_QUA")]
	public partial class tblKET_QUA
	{
		
		private string _MaSV;
		
		private string _HoTen;
		
		private string _MaLop;
		
		private string _MaMon;
		
		private System.Nullable<double> _DiemTB;
		
		private System.Nullable<double> _DiemThiLan1;
		
		private System.Nullable<double> _DiemThiLan2;
		
		private System.Nullable<double> _DiemTongKet;
		
		private string _HanhKiem;
		
		private System.Nullable<int> _HocKi;
		
		private string _GhiChu;
		
		public tblKET_QUA()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this._HoTen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(10)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NVarChar(10)")]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this._MaMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemTB", DbType="Float")]
		public System.Nullable<double> DiemTB
		{
			get
			{
				return this._DiemTB;
			}
			set
			{
				if ((this._DiemTB != value))
				{
					this._DiemTB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemThiLan1", DbType="Float")]
		public System.Nullable<double> DiemThiLan1
		{
			get
			{
				return this._DiemThiLan1;
			}
			set
			{
				if ((this._DiemThiLan1 != value))
				{
					this._DiemThiLan1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemThiLan2", DbType="Float")]
		public System.Nullable<double> DiemThiLan2
		{
			get
			{
				return this._DiemThiLan2;
			}
			set
			{
				if ((this._DiemThiLan2 != value))
				{
					this._DiemThiLan2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemTongKet", DbType="Float")]
		public System.Nullable<double> DiemTongKet
		{
			get
			{
				return this._DiemTongKet;
			}
			set
			{
				if ((this._DiemTongKet != value))
				{
					this._DiemTongKet = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HanhKiem", DbType="NVarChar(20)")]
		public string HanhKiem
		{
			get
			{
				return this._HanhKiem;
			}
			set
			{
				if ((this._HanhKiem != value))
				{
					this._HanhKiem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HocKi", DbType="Int")]
		public System.Nullable<int> HocKi
		{
			get
			{
				return this._HocKi;
			}
			set
			{
				if ((this._HocKi != value))
				{
					this._HocKi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this._GhiChu = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKET_QUA2")]
	public partial class tblKET_QUA2
	{
		
		private string _MaSV;
		
		private string _HoTen;
		
		private string _MaLop;
		
		private string _TenMon;
		
		private string _DiemThiLai;
		
		private string _HocKi;
		
		public tblKET_QUA2()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(10)")]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this._HoTen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(10)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this._TenMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemThiLai", DbType="NVarChar(50)")]
		public string DiemThiLai
		{
			get
			{
				return this._DiemThiLai;
			}
			set
			{
				if ((this._DiemThiLai != value))
				{
					this._DiemThiLai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HocKi", DbType="NVarChar(50)")]
		public string HocKi
		{
			get
			{
				return this._HocKi;
			}
			set
			{
				if ((this._HocKi != value))
				{
					this._HocKi = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKET_QUA3")]
	public partial class tblKET_QUA3
	{
		
		private string _MaSv;
		
		private string _HoTen;
		
		private string _MaLop;
		
		private string _TenMon;
		
		private System.Nullable<double> _DiemHocLai;
		
		private System.Nullable<int> _HocKi;
		
		public tblKET_QUA3()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSv", DbType="NVarChar(50)")]
		public string MaSv
		{
			get
			{
				return this._MaSv;
			}
			set
			{
				if ((this._MaSv != value))
				{
					this._MaSv = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this._HoTen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this._TenMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemHocLai", DbType="Float")]
		public System.Nullable<double> DiemHocLai
		{
			get
			{
				return this._DiemHocLai;
			}
			set
			{
				if ((this._DiemHocLai != value))
				{
					this._DiemHocLai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HocKi", DbType="Int")]
		public System.Nullable<int> HocKi
		{
			get
			{
				return this._HocKi;
			}
			set
			{
				if ((this._HocKi != value))
				{
					this._HocKi = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblKHOA")]
	public partial class tblKHOA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoa;
		
		private string _TenKhoa;
		
		private EntitySet<tblLOP> _tblLOPs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnTenKhoaChanging(string value);
    partial void OnTenKhoaChanged();
    #endregion
		
		public tblKHOA()
		{
			this._tblLOPs = new EntitySet<tblLOP>(new Action<tblLOP>(this.attach_tblLOPs), new Action<tblLOP>(this.detach_tblLOPs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoa", DbType="NVarChar(50)")]
		public string TenKhoa
		{
			get
			{
				return this._TenKhoa;
			}
			set
			{
				if ((this._TenKhoa != value))
				{
					this.OnTenKhoaChanging(value);
					this.SendPropertyChanging();
					this._TenKhoa = value;
					this.SendPropertyChanged("TenKhoa");
					this.OnTenKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKHOA_tblLOP", Storage="_tblLOPs", ThisKey="MaKhoa", OtherKey="MaKhoa")]
		public EntitySet<tblLOP> tblLOPs
		{
			get
			{
				return this._tblLOPs;
			}
			set
			{
				this._tblLOPs.Assign(value);
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
		
		private void attach_tblLOPs(tblLOP entity)
		{
			this.SendPropertyChanging();
			entity.tblKHOA = this;
		}
		
		private void detach_tblLOPs(tblLOP entity)
		{
			this.SendPropertyChanging();
			entity.tblKHOA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblLOGIN")]
	public partial class tblLOGIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDN;
		
		private string _MatKhau;
		
		private string _HoTen;
		
		private string _GioiTinh;
		
		private string _Phone;
		
		private string _Email;
		
		private string _Quyen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDNChanging(string value);
    partial void OnTenDNChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnQuyenChanging(string value);
    partial void OnQuyenChanged();
    #endregion
		
		public tblLOGIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDN", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDN
		{
			get
			{
				return this._TenDN;
			}
			set
			{
				if ((this._TenDN != value))
				{
					this.OnTenDNChanging(value);
					this.SendPropertyChanging();
					this._TenDN = value;
					this.SendPropertyChanged("TenDN");
					this.OnTenDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(50)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quyen", DbType="NVarChar(50)")]
		public string Quyen
		{
			get
			{
				return this._Quyen;
			}
			set
			{
				if ((this._Quyen != value))
				{
					this.OnQuyenChanging(value);
					this.SendPropertyChanging();
					this._Quyen = value;
					this.SendPropertyChanged("Quyen");
					this.OnQuyenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblLOP")]
	public partial class tblLOP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhoa;
		
		private string _MaLop;
		
		private string _TenLop;
		
		private EntitySet<tblSINH_VIEN> _tblSINH_VIENs;
		
		private EntityRef<tblKHOA> _tblKHOA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnTenLopChanging(string value);
    partial void OnTenLopChanged();
    #endregion
		
		public tblLOP()
		{
			this._tblSINH_VIENs = new EntitySet<tblSINH_VIEN>(new Action<tblSINH_VIEN>(this.attach_tblSINH_VIENs), new Action<tblSINH_VIEN>(this.detach_tblSINH_VIENs));
			this._tblKHOA = default(EntityRef<tblKHOA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NVarChar(10)")]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					if (this._tblKHOA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLop", DbType="NVarChar(50)")]
		public string TenLop
		{
			get
			{
				return this._TenLop;
			}
			set
			{
				if ((this._TenLop != value))
				{
					this.OnTenLopChanging(value);
					this.SendPropertyChanging();
					this._TenLop = value;
					this.SendPropertyChanged("TenLop");
					this.OnTenLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblLOP_tblSINH_VIEN", Storage="_tblSINH_VIENs", ThisKey="MaLop", OtherKey="MaLop")]
		public EntitySet<tblSINH_VIEN> tblSINH_VIENs
		{
			get
			{
				return this._tblSINH_VIENs;
			}
			set
			{
				this._tblSINH_VIENs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblKHOA_tblLOP", Storage="_tblKHOA", ThisKey="MaKhoa", OtherKey="MaKhoa", IsForeignKey=true)]
		public tblKHOA tblKHOA
		{
			get
			{
				return this._tblKHOA.Entity;
			}
			set
			{
				tblKHOA previousValue = this._tblKHOA.Entity;
				if (((previousValue != value) 
							|| (this._tblKHOA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblKHOA.Entity = null;
						previousValue.tblLOPs.Remove(this);
					}
					this._tblKHOA.Entity = value;
					if ((value != null))
					{
						value.tblLOPs.Add(this);
						this._MaKhoa = value.MaKhoa;
					}
					else
					{
						this._MaKhoa = default(string);
					}
					this.SendPropertyChanged("tblKHOA");
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
		
		private void attach_tblSINH_VIENs(tblSINH_VIEN entity)
		{
			this.SendPropertyChanging();
			entity.tblLOP = this;
		}
		
		private void detach_tblSINH_VIENs(tblSINH_VIEN entity)
		{
			this.SendPropertyChanging();
			entity.tblLOP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMON")]
	public partial class tblMON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMon;
		
		private string _TenMon;
		
		private System.Nullable<int> _SoDVHT;
		
		private string _MaGV;
		
		private string _HocKi;
		
		private string _MaKhoa;
		
		private EntityRef<tblGIANG_VIEN> _tblGIANG_VIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMonChanging(string value);
    partial void OnMaMonChanged();
    partial void OnTenMonChanging(string value);
    partial void OnTenMonChanged();
    partial void OnSoDVHTChanging(System.Nullable<int> value);
    partial void OnSoDVHTChanged();
    partial void OnMaGVChanging(string value);
    partial void OnMaGVChanged();
    partial void OnHocKiChanging(string value);
    partial void OnHocKiChanged();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    #endregion
		
		public tblMON()
		{
			this._tblGIANG_VIEN = default(EntityRef<tblGIANG_VIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this.OnMaMonChanging(value);
					this.SendPropertyChanging();
					this._MaMon = value;
					this.SendPropertyChanged("MaMon");
					this.OnMaMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this.OnTenMonChanging(value);
					this.SendPropertyChanging();
					this._TenMon = value;
					this.SendPropertyChanged("TenMon");
					this.OnTenMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDVHT", DbType="Int")]
		public System.Nullable<int> SoDVHT
		{
			get
			{
				return this._SoDVHT;
			}
			set
			{
				if ((this._SoDVHT != value))
				{
					this.OnSoDVHTChanging(value);
					this.SendPropertyChanging();
					this._SoDVHT = value;
					this.SendPropertyChanged("SoDVHT");
					this.OnSoDVHTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaGV", DbType="NVarChar(10)")]
		public string MaGV
		{
			get
			{
				return this._MaGV;
			}
			set
			{
				if ((this._MaGV != value))
				{
					if (this._tblGIANG_VIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaGVChanging(value);
					this.SendPropertyChanging();
					this._MaGV = value;
					this.SendPropertyChanged("MaGV");
					this.OnMaGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HocKi", DbType="NVarChar(10)")]
		public string HocKi
		{
			get
			{
				return this._HocKi;
			}
			set
			{
				if ((this._HocKi != value))
				{
					this.OnHocKiChanging(value);
					this.SendPropertyChanging();
					this._HocKi = value;
					this.SendPropertyChanged("HocKi");
					this.OnHocKiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NChar(10)")]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblGIANG_VIEN_tblMON", Storage="_tblGIANG_VIEN", ThisKey="MaGV", OtherKey="MaGV", IsForeignKey=true)]
		public tblGIANG_VIEN tblGIANG_VIEN
		{
			get
			{
				return this._tblGIANG_VIEN.Entity;
			}
			set
			{
				tblGIANG_VIEN previousValue = this._tblGIANG_VIEN.Entity;
				if (((previousValue != value) 
							|| (this._tblGIANG_VIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblGIANG_VIEN.Entity = null;
						previousValue.tblMONs.Remove(this);
					}
					this._tblGIANG_VIEN.Entity = value;
					if ((value != null))
					{
						value.tblMONs.Add(this);
						this._MaGV = value.MaGV;
					}
					else
					{
						this._MaGV = default(string);
					}
					this.SendPropertyChanged("tblGIANG_VIEN");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblSINH_VIEN")]
	public partial class tblSINH_VIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSv;
		
		private string _HoTen;
		
		private string _NgaySinh;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _MaLop;
		
		private EntityRef<tblLOP> _tblLOP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSvChanging(string value);
    partial void OnMaSvChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    #endregion
		
		public tblSINH_VIEN()
		{
			this._tblLOP = default(EntityRef<tblLOP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSv", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSv
		{
			get
			{
				return this._MaSv;
			}
			set
			{
				if ((this._MaSv != value))
				{
					this.OnMaSvChanging(value);
					this.SendPropertyChanging();
					this._MaSv = value;
					this.SendPropertyChanged("MaSv");
					this.OnMaSvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(10)")]
		public string NgaySinh
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(5)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(10)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._tblLOP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblLOP_tblSINH_VIEN", Storage="_tblLOP", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public tblLOP tblLOP
		{
			get
			{
				return this._tblLOP.Entity;
			}
			set
			{
				tblLOP previousValue = this._tblLOP.Entity;
				if (((previousValue != value) 
							|| (this._tblLOP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblLOP.Entity = null;
						previousValue.tblSINH_VIENs.Remove(this);
					}
					this._tblLOP.Entity = value;
					if ((value != null))
					{
						value.tblSINH_VIENs.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(string);
					}
					this.SendPropertyChanged("tblLOP");
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
