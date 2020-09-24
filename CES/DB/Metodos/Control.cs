using CES.DB.DataSets.ControlTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DB.Metodos.Control
{
    #region Entradas
    public class dtoEntradas
    {
        private int _idEntrada = 0;

        public string @operacion { get; set; }
        public int @idEntrada { get { return _idEntrada; } set { _idEntrada = value; } }
        public int @idProveedor { get; set; }
        public int @idUsuarioAlta { get; set; }
        public DateTime? @fechaAlta { get; set; }
        public string @nombreEntrega { get; set; }
        public decimal @total { get; set; }
        public string @folio { get; set; }
        public bool? @activo { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly Entradas_spTableAdapter oEntradas = new Entradas_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oEntradas.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idEntrada, @idProveedor, @idUsuarioAlta, @fechaAlta, @nombreEntrega, @total, @folio, @activo,
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

    #region EntradasPartidas
    public class dtoEntradasPartidas
    {
        private int _idPartida = 0;

        public string @operacion { get; set; }
        public int @idPartida { get { return _idPartida; } set { _idPartida = value; } }
        public int @idEntrada { get; set; }
        public int @idProducto { get; set; }
        public string @code { get; set; }
        public string @producto { get; set; }
        public decimal @pUnitario { get; set; }
        public decimal @pTotal { get; set; }
        public decimal @cantidad { get; set; }
        public bool? @activo { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly EntradasPartidas_spTableAdapter oEntradasPartidas = new EntradasPartidas_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oEntradasPartidas.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idPartida, @idEntrada, @idProducto, @code, @producto, @pUnitario, @pTotal, @cantidad, @activo,
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

    #region Salidas
    public class dtoSalidas
    {
        private int _idSalida = 0;

        public string @operacion { get; set; }
        public int @idSalida { get { return _idSalida; } set { _idSalida = value; } }
        public int @idUsuarioSolicita { get; set; }
        public int @idUsuarioAutoriza { get; set; }
        public string @otroSolicita { get; set; }
        public DateTime? @fechaAlta { get; set; }
        public string @folio { get; set; }
        public bool? @activo { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly Salidas_spTableAdapter oSalidas = new Salidas_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oSalidas.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idSalida, @idUsuarioSolicita, @idUsuarioAutoriza, @otroSolicita, @fechaAlta, @folio, @activo,
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

    #region SalidasPartidas
    public class dtoSalidasPartidas
    {
        private int _idPartida = 0;

        public string @operacion { get; set; }
        public int @idPartida { get { return _idPartida; } set { _idPartida = value; } }
        public int @idSalida { get; set; }
        public int @idProducto { get; set; }
        public string @code { get; set; }
        public string @nombre { get; set; }
        public decimal @cantidad { get; set; }
        public bool? @activo { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly SalidasPartidas_spTableAdapter oSalidasPartidas = new SalidasPartidas_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oSalidasPartidas.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @idPartida, @idSalida, @idProducto, @code, @nombre, @cantidad, @activo,
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


    #region Entradas
    public class dtoBitacora
    {
        private int _id = 0;

        public string @operacion { get; set; }
        public int @id { get { return _id; } set { _id = value; } }
        public DateTime? @fechaAlta { get; set; }
        public string @detalles { get; set; }
        public string @folio { get; set; }
        public int @indexInicio { get; set; }
        public int @indexFin { get; set; }

        readonly Bitacora_spTableAdapter oBitacora = new Bitacora_spTableAdapter();

        public resultTransaction CRUD()
        {
            var result = new resultTransaction();
            var dt = new DataTable();
            try
            {
                dt = oBitacora.GetData(@operacion, ref result.idOut, ref result.hasError, ref result.noError, ref result.messageError,
                         @id, @fechaAlta, @detalles, @folio, @indexInicio, @indexFin);

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
