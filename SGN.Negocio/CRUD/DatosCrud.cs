﻿using Dapper;
using System;
using SGN.Negocio.ORM;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGN.Negocio.CRUD
{
    public class DatosCrud
    {

        protected String cnn = ConfigurationManager.AppSettings["sqlConn.ConnectionString"];

        #region Cat_Actos
        public List<Cat_Actos> ConsultaCatActos()
        {
            try
            {
                List<Cat_Actos> resultado = new List<Cat_Actos>();

                using (var db = new SqlConnection(cnn))
                {
                    resultado = db.Query<Cat_Actos>(sql: "sp_CRUD_Cat_Actos_Select").ToList();
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Cat_Actos_Select, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean AltaCatActos(Cat_Actos values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Actos_Insert", param: new
                    {
                        values.TextoActo,
                        values.Descripcion,
                        values.Activo

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Cat_Actos_Insert, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean ActualizarCatActos(Cat_Actos values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Actos_Update", param: new
                    {
                        values.TextoActo,
                        values.Descripcion,
                        values.Activo

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Cat_Actos_Update, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean EliminarCatActos(Cat_Actos values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Actos_Delete", param: new
                    {
                        values.IdActo

                    }, commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Cat_Actos_Delete, detalle: \n" + ex.Message, ex);
            }
        }
        #endregion

        #region Cat_Estatus

        public List<Cat_Estatus> ConsultaCatEstatus()
        {
            try
            {
                List<Cat_Estatus> resultado = new List<Cat_Estatus>();

                using (var db = new SqlConnection(cnn))
                {
                    resultado = db.Query<Cat_Estatus>(sql: "sp_CRUD_Cat_Estatus_Select").ToList();
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Cat_Estatus_Select, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean AltaCatEstatus(Cat_Estatus values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Estatus_Insert", param: new
                    {
                        values.TextoEstatus,
                        values.Descripcion

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Cat_Estatus_Insert, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean ActualizarCatEstatus(Cat_Estatus values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Estatus_Update ", param: new
                    {
                        values.IdEstatus,
                        values.TextoEstatus,
                        values.Descripcion

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Cat_Estatus_Update, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean EliminarCatEstatus(Cat_Estatus values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Estatus_Delete", param: new
                    {
                        values.IdEstatus

                    }, commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Cat_Estatus_Delete, detalle: \n" + ex.Message, ex);
            }
        }


        #endregion
        #region Cat_Proyectistas

        public List<Cat_Proyectistas> ConsultaCatProyectista()
        {
            try
            {
                List<Cat_Proyectistas> resultado = new List<Cat_Proyectistas>();

                using (var db = new SqlConnection(cnn))
                {
                    resultado = db.Query<Cat_Proyectistas>(sql: "sp_CRUD_Cat_Proyectistas_Select").ToList();
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Cat_Proyectistas_Select, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean AltaCatProyectista(Cat_Proyectistas values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Proyectistas_Insert", param: new
                    {
                        values.NombreProyectista,
                        values.Activo

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Cat_Proyectistas_Insert, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean ActualizarCatEstatus(Cat_Proyectistas values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Proyectistas_Update", param: new
                    {
                        values.idProyectista,
                        values.NombreProyectista,
                        values.Activo

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Cat_Proyectistas_Update, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean EliminarCatEstatus(Cat_Proyectistas values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Cat_Proyectistas_Delete", param: new
                    {
                        values.idProyectista

                    }, commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Cat_Proyectistas_Delete, detalle: \n" + ex.Message, ex);
            }
        }


        #endregion
        #region Expedientes

        public Expedientes ConsultaExpediente(string numExp)
        {
            try
            {
                Expedientes resultado = new Expedientes();

                using (var db = new SqlConnection(cnn))
                {
                    resultado = db.Query<Expedientes>
                        (
                        sql: "sp_CRUD_Expedientes_Select", param: new
                        {
                            IdExpediente = numExp
                        }, commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Expedientes_Select, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean AltaExpediente(Expedientes values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Expedientes_Insert", param: new
                    {

                        values.IdEstatus,
                        values.IdActo,
                        values.FechaIngreso,
                        values.Otorga,
                        values.AfavorDe,
                        values.OperacionProyectada,
                        values.UbicacionPredio,
                        values.Faltantes,
                        values.FechaElaboracion,
                        values.FechaEnvioRPP,
                        values.EsTramitePorSistema,
                        values.FechaPagoBoleta,
                        values.FechaRecibidoRPP,
                        values.NombreProyectista,
                        values.FechaAsignacionProyectista,
                        values.FechaPrevistaTerminoProyectista,
                        values.AvisoPreventivo,
                        values.ISR,
                        values.NotasFirma,
                        values.Escritura,
                        values.Volumen,
                        values.FechaTrasladoEntregado,
                        values.FechaElaboracionDefinitivo,
                        values.FechaEnvioRPPDefinitivo,
                        values.EsTramitePorSistemaDefinitivo,
                        values.FechaPagoBoletaDefinitivo,
                        values.FechaRecibidoRPPDefinitivo,
                        values.FechaRecepcionTerminoEscrituta,
                        values.FechaAsignacionMesa,
                        values.FechaTerminoMesa,
                        values.UbicacionMesa,
                        values.RevisionEntrega,
                        values.AutorizadoEntrega,
                        values.RegistroEntrega,
                        values.FechaRegistroEntrega,
                        values.FechaBoletaPagoRegistroEntrega,
                        values.ParaEntregar,
                        values.FechaSalida,
                        values.ObservacionesTramiteTerminado

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar sp_CRUD_Expedientes_Insert, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean ActualizarExpediente(Expedientes values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Expedientes_Update", param: new
                    {
                        values.IdExpediente,
                        values.IdEstatus,
                        values.IdActo,
                        values.FechaIngreso,
                        values.Otorga,
                        values.AfavorDe,
                        values.OperacionProyectada,
                        values.UbicacionPredio,
                        values.Faltantes,
                        values.FechaElaboracion,
                        values.FechaEnvioRPP,
                        values.EsTramitePorSistema,
                        values.FechaPagoBoleta,
                        values.FechaRecibidoRPP,
                        values.NombreProyectista,
                        values.FechaAsignacionProyectista,
                        values.FechaPrevistaTerminoProyectista,
                        values.AvisoPreventivo,
                        values.ISR,
                        values.NotasFirma,
                        values.Escritura,
                        values.Volumen,
                        values.FechaTrasladoEntregado,
                        values.FechaElaboracionDefinitivo,
                        values.FechaEnvioRPPDefinitivo,
                        values.EsTramitePorSistemaDefinitivo,
                        values.FechaPagoBoletaDefinitivo,
                        values.FechaRecibidoRPPDefinitivo,
                        values.FechaRecepcionTerminoEscrituta,
                        values.FechaAsignacionMesa,
                        values.FechaTerminoMesa,
                        values.UbicacionMesa,
                        values.RevisionEntrega,
                        values.AutorizadoEntrega,
                        values.RegistroEntrega,
                        values.FechaRegistroEntrega,
                        values.FechaBoletaPagoRegistroEntrega,
                        values.ParaEntregar,
                        values.FechaSalida,
                        values.ObservacionesTramiteTerminado

                    }, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Expedientes_Update, detalle: \n" + ex.Message, ex);
            }
        }
        public Boolean EliminarExpediente (Expedientes values)
        {
            try
            {
                using (var db = new SqlConnection(cnn))
                {
                    db.Execute(sql: "sp_CRUD_Expedientes_Delete", param: new
                    {
                        values.IdExpediente

                    }, commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_CRUD_Expedientes_Delete, detalle: \n" + ex.Message, ex);
            }
        }

        #endregion
    }
}
