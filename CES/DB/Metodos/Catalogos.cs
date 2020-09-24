using CES.DB.DataSets.CatalogosTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DB.Metodos.Catalogos
{
    #region Productos
    public class dtoProductos
    {
        private int _idProducto = 0;

        public string @operacion { get; set; }
        public int @idProducto { get { return _idProducto; } set { _idProducto = value; } }
        public string @nombre { get; set; }
        public string @descripcion { get; set; }
        public int @idGrupo { get; set; }
        public string @codigo { get; set; }
        public decimal @total { get; set; }
        public decimal @minimo { get; set; }
        public decimal @maximo { get; set; }
        public int @idUm { get; set; }
        public int @idUsuario { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }
        public bool? @activo { get; set; }
        public decimal @precioUnit { get; set; }

        readonly Productos_spTableAdapter oProductos = new Productos_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oProductos.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idProducto, @nombre, @descripcion, @idGrupo, @codigo, @total, @minimo, @maximo, @idUm, @idUsuario, @activo,
                         @indexInicio, @indexFin, @precioUnit);

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

    #region Grupo
    public class dtoGrupo
    {
        private int _idGrupo = 0;

        public string @operacion { get; set; }
        public int @idGrupo { get { return _idGrupo; } set { _idGrupo = value; } }
        public string @grupo { get; set; }
        public int @idUsuario { get; set; }
        public bool? @activo { get; set; }

        readonly Grupo_spTableAdapter oGrupo = new Grupo_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oGrupo.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idGrupo, @grupo, @idUsuario, @activo);

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

    #region UM
    public class dtoUM
    {
        private int _idUm = 0;

        public string @operacion { get; set; }
        public int @idUm { get { return _idUm; } set { _idUm = value; } }
        public string @um { get; set; }
        public string @nombre { get; set; }
        public int @idUsuario { get; set; }
        public bool? @activo { get; set; }

        readonly UM_spTableAdapter oUM = new UM_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oUM.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idUm, @um, @nombre, @idUsuario, @activo);

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

    #region Proveedores
    public class dtoProveedores
    {
        private int _idProveedor = 0;

        public string @operacion { get; set; }
        public int @idProveedor { get { return _idProveedor; } set { _idProveedor = value; } }
        public string @nombre { get; set; }
        public string @RFC { get; set; }
        public string @nomContacto { get; set; }
        public string @telContacto { get; set; }
        public string @mailContacto { get; set; }
        public int @idUsuario { get; set; }
        public bool? @activo { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly Proveedores_spTableAdapter oProveedores = new Proveedores_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oProveedores.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idProveedor, @nombre, @RFC, @nomContacto, @telContacto, @mailContacto, @idUsuario, @activo,
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
}
