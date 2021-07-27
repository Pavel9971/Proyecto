﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Proyecto_Visual")]
	public partial class BasedeDatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTBL_USUARIO(TBL_USUARIO instance);
    partial void UpdateTBL_USUARIO(TBL_USUARIO instance);
    partial void DeleteTBL_USUARIO(TBL_USUARIO instance);
    #endregion
		
		public BasedeDatosDataContext() : 
				base(global::Proyecto.Properties.Settings.Default.Proyecto_VisualConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_USUARIO> TBL_USUARIO
		{
			get
			{
				return this.GetTable<TBL_USUARIO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_USUARIO")]
	public partial class TBL_USUARIO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_USUARIO;
		
		private string _USU_USUARIO;
		
		private string _USU_CLAVE;
		
		private string _USU_TIPO_USUARIO;
		
		private System.Nullable<char> _USU_ESTADO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_USUARIOChanging(int value);
    partial void OnID_USUARIOChanged();
    partial void OnUSU_USUARIOChanging(string value);
    partial void OnUSU_USUARIOChanged();
    partial void OnUSU_CLAVEChanging(string value);
    partial void OnUSU_CLAVEChanged();
    partial void OnUSU_TIPO_USUARIOChanging(string value);
    partial void OnUSU_TIPO_USUARIOChanged();
    partial void OnUSU_ESTADOChanging(System.Nullable<char> value);
    partial void OnUSU_ESTADOChanged();
    #endregion
		
		public TBL_USUARIO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_USUARIO", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_USUARIO
		{
			get
			{
				return this._ID_USUARIO;
			}
			set
			{
				if ((this._ID_USUARIO != value))
				{
					this.OnID_USUARIOChanging(value);
					this.SendPropertyChanging();
					this._ID_USUARIO = value;
					this.SendPropertyChanged("ID_USUARIO");
					this.OnID_USUARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USU_USUARIO", DbType="VarChar(100)")]
		public string USU_USUARIO
		{
			get
			{
				return this._USU_USUARIO;
			}
			set
			{
				if ((this._USU_USUARIO != value))
				{
					this.OnUSU_USUARIOChanging(value);
					this.SendPropertyChanging();
					this._USU_USUARIO = value;
					this.SendPropertyChanged("USU_USUARIO");
					this.OnUSU_USUARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USU_CLAVE", DbType="VarChar(100)")]
		public string USU_CLAVE
		{
			get
			{
				return this._USU_CLAVE;
			}
			set
			{
				if ((this._USU_CLAVE != value))
				{
					this.OnUSU_CLAVEChanging(value);
					this.SendPropertyChanging();
					this._USU_CLAVE = value;
					this.SendPropertyChanged("USU_CLAVE");
					this.OnUSU_CLAVEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USU_TIPO_USUARIO", DbType="VarChar(100)")]
		public string USU_TIPO_USUARIO
		{
			get
			{
				return this._USU_TIPO_USUARIO;
			}
			set
			{
				if ((this._USU_TIPO_USUARIO != value))
				{
					this.OnUSU_TIPO_USUARIOChanging(value);
					this.SendPropertyChanging();
					this._USU_TIPO_USUARIO = value;
					this.SendPropertyChanged("USU_TIPO_USUARIO");
					this.OnUSU_TIPO_USUARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USU_ESTADO", DbType="Char(1)")]
		public System.Nullable<char> USU_ESTADO
		{
			get
			{
				return this._USU_ESTADO;
			}
			set
			{
				if ((this._USU_ESTADO != value))
				{
					this.OnUSU_ESTADOChanging(value);
					this.SendPropertyChanging();
					this._USU_ESTADO = value;
					this.SendPropertyChanged("USU_ESTADO");
					this.OnUSU_ESTADOChanged();
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