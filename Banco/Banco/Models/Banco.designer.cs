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

namespace Banco.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Banco")]
	public partial class BancoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertcliente(cliente instance);
    partial void Updatecliente(cliente instance);
    partial void Deletecliente(cliente instance);
    partial void Insertcredenciales(credenciales instance);
    partial void Updatecredenciales(credenciales instance);
    partial void Deletecredenciales(credenciales instance);
    partial void InsertusuarioXcodigo(usuarioXcodigo instance);
    partial void UpdateusuarioXcodigo(usuarioXcodigo instance);
    partial void DeleteusuarioXcodigo(usuarioXcodigo instance);
    partial void Insertestado(estado instance);
    partial void Updateestado(estado instance);
    partial void Deleteestado(estado instance);
    #endregion
		
		public BancoDataContext() : 
				base(global::Banco.Properties.Settings.Default.BancoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cliente> cliente
		{
			get
			{
				return this.GetTable<cliente>();
			}
		}
		
		public System.Data.Linq.Table<credenciales> credenciales
		{
			get
			{
				return this.GetTable<credenciales>();
			}
		}
		
		public System.Data.Linq.Table<usuarioXcodigo> usuarioXcodigo
		{
			get
			{
				return this.GetTable<usuarioXcodigo>();
			}
		}
		
		public System.Data.Linq.Table<estado> estado
		{
			get
			{
				return this.GetTable<estado>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscar_pregunta")]
		public int buscar_pregunta([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] ref string pregunta)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, mjs, pregunta);
			mjs = ((string)(result.GetParameterValue(1)));
			pregunta = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscar_resp")]
		public int buscar_resp([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string respuesta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, respuesta, mjs);
			mjs = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscar_correo")]
		public int buscar_correo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, mjs);
			mjs = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertar_codigo")]
		public int insertar_codigo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string cod)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, cod);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscar_codigo")]
		public int buscar_codigo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, codigo, mjs);
			mjs = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.nueva_pass")]
		public int nueva_pass([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, pass, mjs);
			mjs = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.registrar")]
		public int registrar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string apellidos, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cedula, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] string pregunta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string respuesta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellidos, usuario, cedula, telefono, direccion, correo, pregunta, respuesta, pass, mjs);
			mjs = ((string)(result.GetParameterValue(10)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscar_credencial")]
		public int buscar_credencial([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usu, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(12)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usu, pass, mjs);
			mjs = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cambiar_estado")]
		public int cambiar_estado([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string estado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, estado);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.verificar_cuenta")]
		public int verificar_cuenta([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string apellidos, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cedula, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] string pregunta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string respuesta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string mjs)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellidos, usuario, cedula, correo, pregunta, respuesta, codigo, mjs);
			mjs = ((string)(result.GetParameterValue(8)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cliente")]
	public partial class cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private string _apellidos;
		
		private string _correo;
		
		private string _direccion;
		
		private int _cedula;
		
		private System.Nullable<int> _telefono;
		
		private string _pregunta;
		
		private string _respuesta;
		
		private EntitySet<credenciales> _credenciales;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidosChanging(string value);
    partial void OnapellidosChanged();
    partial void OncorreoChanging(string value);
    partial void OncorreoChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    partial void OncedulaChanging(int value);
    partial void OncedulaChanged();
    partial void OntelefonoChanging(System.Nullable<int> value);
    partial void OntelefonoChanged();
    partial void OnpreguntaChanging(string value);
    partial void OnpreguntaChanged();
    partial void OnrespuestaChanging(string value);
    partial void OnrespuestaChanged();
    #endregion
		
		public cliente()
		{
			this._credenciales = new EntitySet<credenciales>(new Action<credenciales>(this.attach_credenciales), new Action<credenciales>(this.detach_credenciales));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidos", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string apellidos
		{
			get
			{
				return this._apellidos;
			}
			set
			{
				if ((this._apellidos != value))
				{
					this.OnapellidosChanging(value);
					this.SendPropertyChanging();
					this._apellidos = value;
					this.SendPropertyChanged("apellidos");
					this.OnapellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this.OncorreoChanging(value);
					this.SendPropertyChanging();
					this._correo = value;
					this.SendPropertyChanged("correo");
					this.OncorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="Int NOT NULL")]
		public int cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this.OncedulaChanging(value);
					this.SendPropertyChanging();
					this._cedula = value;
					this.SendPropertyChanged("cedula");
					this.OncedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="Int")]
		public System.Nullable<int> telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pregunta", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string pregunta
		{
			get
			{
				return this._pregunta;
			}
			set
			{
				if ((this._pregunta != value))
				{
					this.OnpreguntaChanging(value);
					this.SendPropertyChanging();
					this._pregunta = value;
					this.SendPropertyChanged("pregunta");
					this.OnpreguntaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_respuesta", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string respuesta
		{
			get
			{
				return this._respuesta;
			}
			set
			{
				if ((this._respuesta != value))
				{
					this.OnrespuestaChanging(value);
					this.SendPropertyChanging();
					this._respuesta = value;
					this.SendPropertyChanged("respuesta");
					this.OnrespuestaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_credenciales", Storage="_credenciales", ThisKey="id", OtherKey="id_cliente")]
		public EntitySet<credenciales> credenciales
		{
			get
			{
				return this._credenciales;
			}
			set
			{
				this._credenciales.Assign(value);
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
		
		private void attach_credenciales(credenciales entity)
		{
			this.SendPropertyChanging();
			entity.cliente = this;
		}
		
		private void detach_credenciales(credenciales entity)
		{
			this.SendPropertyChanging();
			entity.cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.credenciales")]
	public partial class credenciales : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_cliente;
		
		private string _usuario;
		
		private string _pass;
		
		private EntitySet<usuarioXcodigo> _usuarioXcodigo;
		
		private EntitySet<estado> _estado;
		
		private EntityRef<cliente> _cliente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_clienteChanging(int value);
    partial void Onid_clienteChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    #endregion
		
		public credenciales()
		{
			this._usuarioXcodigo = new EntitySet<usuarioXcodigo>(new Action<usuarioXcodigo>(this.attach_usuarioXcodigo), new Action<usuarioXcodigo>(this.detach_usuarioXcodigo));
			this._estado = new EntitySet<estado>(new Action<estado>(this.attach_estado), new Action<estado>(this.detach_estado));
			this._cliente = default(EntityRef<cliente>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cliente", DbType="Int NOT NULL")]
		public int id_cliente
		{
			get
			{
				return this._id_cliente;
			}
			set
			{
				if ((this._id_cliente != value))
				{
					if (this._cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_clienteChanging(value);
					this.SendPropertyChanging();
					this._id_cliente = value;
					this.SendPropertyChanged("id_cliente");
					this.Onid_clienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="credenciales_usuarioXcodigo", Storage="_usuarioXcodigo", ThisKey="id", OtherKey="id_usuario")]
		public EntitySet<usuarioXcodigo> usuarioXcodigo
		{
			get
			{
				return this._usuarioXcodigo;
			}
			set
			{
				this._usuarioXcodigo.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="credenciales_estado", Storage="_estado", ThisKey="id", OtherKey="id_usuario")]
		public EntitySet<estado> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				this._estado.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_credenciales", Storage="_cliente", ThisKey="id_cliente", OtherKey="id", IsForeignKey=true)]
		public cliente cliente
		{
			get
			{
				return this._cliente.Entity;
			}
			set
			{
				cliente previousValue = this._cliente.Entity;
				if (((previousValue != value) 
							|| (this._cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cliente.Entity = null;
						previousValue.credenciales.Remove(this);
					}
					this._cliente.Entity = value;
					if ((value != null))
					{
						value.credenciales.Add(this);
						this._id_cliente = value.id;
					}
					else
					{
						this._id_cliente = default(int);
					}
					this.SendPropertyChanged("cliente");
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
		
		private void attach_usuarioXcodigo(usuarioXcodigo entity)
		{
			this.SendPropertyChanging();
			entity.credenciales = this;
		}
		
		private void detach_usuarioXcodigo(usuarioXcodigo entity)
		{
			this.SendPropertyChanging();
			entity.credenciales = null;
		}
		
		private void attach_estado(estado entity)
		{
			this.SendPropertyChanging();
			entity.credenciales = this;
		}
		
		private void detach_estado(estado entity)
		{
			this.SendPropertyChanging();
			entity.credenciales = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarioXcodigo")]
	public partial class usuarioXcodigo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_usuario;
		
		private string _codigo;
		
		private EntityRef<credenciales> _credenciales;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    #endregion
		
		public usuarioXcodigo()
		{
			this._credenciales = default(EntityRef<credenciales>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", DbType="Int NOT NULL")]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					if (this._credenciales.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="credenciales_usuarioXcodigo", Storage="_credenciales", ThisKey="id_usuario", OtherKey="id", IsForeignKey=true)]
		public credenciales credenciales
		{
			get
			{
				return this._credenciales.Entity;
			}
			set
			{
				credenciales previousValue = this._credenciales.Entity;
				if (((previousValue != value) 
							|| (this._credenciales.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._credenciales.Entity = null;
						previousValue.usuarioXcodigo.Remove(this);
					}
					this._credenciales.Entity = value;
					if ((value != null))
					{
						value.usuarioXcodigo.Add(this);
						this._id_usuario = value.id;
					}
					else
					{
						this._id_usuario = default(int);
					}
					this.SendPropertyChanged("credenciales");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.estado")]
	public partial class estado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_usuario;
		
		private string _estado1;
		
		private EntityRef<credenciales> _credenciales;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void Onestado1Changing(string value);
    partial void Onestado1Changed();
    #endregion
		
		public estado()
		{
			this._credenciales = default(EntityRef<credenciales>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", DbType="Int NOT NULL")]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					if (this._credenciales.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="estado", Storage="_estado1", DbType="VarChar(5)")]
		public string estado1
		{
			get
			{
				return this._estado1;
			}
			set
			{
				if ((this._estado1 != value))
				{
					this.Onestado1Changing(value);
					this.SendPropertyChanging();
					this._estado1 = value;
					this.SendPropertyChanged("estado1");
					this.Onestado1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="credenciales_estado", Storage="_credenciales", ThisKey="id_usuario", OtherKey="id", IsForeignKey=true)]
		public credenciales credenciales
		{
			get
			{
				return this._credenciales.Entity;
			}
			set
			{
				credenciales previousValue = this._credenciales.Entity;
				if (((previousValue != value) 
							|| (this._credenciales.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._credenciales.Entity = null;
						previousValue.estado.Remove(this);
					}
					this._credenciales.Entity = value;
					if ((value != null))
					{
						value.estado.Add(this);
						this._id_usuario = value.id;
					}
					else
					{
						this._id_usuario = default(int);
					}
					this.SendPropertyChanged("credenciales");
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
