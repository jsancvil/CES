using CES.DB.DataSets.ConfigTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DB.Metodos.config
{
    #region Usuarios
    public class dtoUsuarios
    {
        private int _idUsuario = 0;

        public string @operacion { get; set; }
        public int @idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public int @idRol { get; set; }
        public string @nombre { get; set; }
        public string @usuario { get; set; }
        public string @psw { get; set; }
        public int @idDepto { get; set; }
        public string @telefono { get; set; }
        public string @celular { get; set; }
        public string @correo { get; set; }
        public int @idUsuarioA { get; set; }
        public bool? @activo { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly Usuarios_spTableAdapter oUsuarios = new Usuarios_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oUsuarios.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idUsuario, @idRol, @nombre, @usuario, @psw, @idDepto, @telefono, @celular, @correo, @idUsuarioA, @activo,
                         @indexInicio, @indexFin);

                result.dtResult = dt;
                return result;
            }
            catch (SqlException ex)
            {
                result.hasError = true;
                result.dtResult = dt;
                result.noError = ex.ErrorCode;
                result.messageError = string.Format("Error: {0} , {1}, {2} , {3}", ex.Message, ex.Procedure, ex.Source, ex.LineNumber);
                result.idOut = "";

                return result;
            }
        }
    }
    #endregion

    #region Propiedades
    public class dtoPropiedades
    {
        private int _idPropiedad = 0;

        public string @operacion { get; set; }
        public int @idPropiedad { get { return _idPropiedad; } set { _idPropiedad = value; } }
        public string @propiedad { get; set; }
        public string @valor { get; set; }

        readonly Propiedades_spTableAdapter oPropiedades = new Propiedades_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oPropiedades.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idPropiedad, @propiedad, @valor);

                result.dtResult = dt;
                return result;
            }
            catch (SqlException ex)
            {
                result.hasError = true;
                result.dtResult = dt;
                result.noError = ex.ErrorCode;
                result.messageError = string.Format("Error: {0} , {1}, {2} , {3}", ex.Message, ex.Procedure, ex.Source, ex.LineNumber);
                result.idOut = "";

                return result;
            }
        }
    }
    #endregion

    #region TablasPaginado
    public class dtoTablasPaginado
    {
        private int _idPaginado = 0;

        public string @operacion { get; set; }
        public int @idPaginado { get { return _idPaginado; } set { _idPaginado = value; } }
        public string @nombre { get; set; }
        public string @valor { get; set; }
        public bool? @activo { get; set; }

        readonly TablasPaginado_spTableAdapter oTablasPaginado = new TablasPaginado_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oTablasPaginado.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idPaginado, @nombre, @valor, @activo);

                result.dtResult = dt;
                return result;
            }
            catch (SqlException ex)
            {
                result.hasError = true;
                result.dtResult = dt;
                result.noError = ex.ErrorCode;
                result.messageError = string.Format("Error: {0} , {1}, {2} , {3}", ex.Message, ex.Procedure, ex.Source, ex.LineNumber);
                result.idOut = "";

                return result;
            }
        }
    }
    #endregion

    #region Rol
    public class dtoRol
    {
        private int _idRol = 0;

        public string @operacion { get; set; }
        public int @idRol { get { return _idRol; } set { _idRol = value; } }
        public string @rol { get; set; }
        public int @idUsuario { get; set; }
        public bool? @activo { get; set; }

        readonly Rol_spTableAdapter oRol = new Rol_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oRol.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idRol, @rol, @idUsuario, @activo);

                result.dtResult = dt;
                return result;
            }
            catch (SqlException ex)
            {
                result.hasError = true;
                result.dtResult = dt;
                result.noError = ex.ErrorCode;
                result.messageError = string.Format("Error: {0} , {1}, {2} , {3}", ex.Message, ex.Procedure, ex.Source, ex.LineNumber);
                result.idOut = "";

                return result;
            }
        }
    }
    #endregion

    public class ObjetosFunciones
    {
        public DataTable selectByQuery(string query)
        {
            using (var ta = new Objetos_spTableAdapter())
            {
                var dt = ta.GetData(query);
                return dt;
            }
        }
    }
}
