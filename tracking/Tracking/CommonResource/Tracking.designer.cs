﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonResource
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Tracking")]
	public partial class TrackingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTracking(Tracking instance);
    partial void UpdateTracking(Tracking instance);
    partial void DeleteTracking(Tracking instance);
    #endregion
		
		public TrackingDataContext() : 
				base(global::CommonResource.Properties.Settings.Default.TrackingConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public TrackingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrackingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrackingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrackingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tracking> Trackings
		{
			get
			{
				return this.GetTable<Tracking>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tracking")]
	public partial class Tracking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _wfinstanceid;
		
		private string _wfname;
		
		private string _currentevent;
		
		private string _bugid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnwfinstanceidChanging(System.Guid value);
    partial void OnwfinstanceidChanged();
    partial void OnwfnameChanging(string value);
    partial void OnwfnameChanged();
    partial void OncurrenteventChanging(string value);
    partial void OncurrenteventChanged();
    partial void OnbugidChanging(string value);
    partial void OnbugidChanged();
    #endregion
		
		public Tracking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wfinstanceid", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid wfinstanceid
		{
			get
			{
				return this._wfinstanceid;
			}
			set
			{
				if ((this._wfinstanceid != value))
				{
					this.OnwfinstanceidChanging(value);
					this.SendPropertyChanging();
					this._wfinstanceid = value;
					this.SendPropertyChanged("wfinstanceid");
					this.OnwfinstanceidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wfname", DbType="NChar(50)")]
		public string wfname
		{
			get
			{
				return this._wfname;
			}
			set
			{
				if ((this._wfname != value))
				{
					this.OnwfnameChanging(value);
					this.SendPropertyChanging();
					this._wfname = value;
					this.SendPropertyChanged("wfname");
					this.OnwfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentevent", DbType="NChar(50)")]
		public string currentevent
		{
			get
			{
				return this._currentevent;
			}
			set
			{
				if ((this._currentevent != value))
				{
					this.OncurrenteventChanging(value);
					this.SendPropertyChanging();
					this._currentevent = value;
					this.SendPropertyChanged("currentevent");
					this.OncurrenteventChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bugid", DbType="NChar(50)")]
		public string bugid
		{
			get
			{
				return this._bugid;
			}
			set
			{
				if ((this._bugid != value))
				{
					this.OnbugidChanging(value);
					this.SendPropertyChanging();
					this._bugid = value;
					this.SendPropertyChanged("bugid");
					this.OnbugidChanged();
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
