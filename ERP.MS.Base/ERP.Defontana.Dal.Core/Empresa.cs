//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Defontana.Dal.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public string IDEmpresa { get; set; }
        public string CodLegal { get; set; }
        public string Nombre { get; set; }
        public string Giro { get; set; }
        public string Sigla { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string PoBox { get; set; }
        public string ZIPCode { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string WebSite { get; set; }
        public string DenomCodlegal { get; set; }
        public string subdivciudad { get; set; }
        public string SubDivPais { get; set; }
        public string CasillaPostal { get; set; }
        public string CodigoCorreo { get; set; }
        public string DepProductos { get; set; }
        public string SitioVenta { get; set; }
        public string NumeDocu { get; set; }
        public string MontoDepImp { get; set; }
        public string MontoSinImp { get; set; }
        public string MontoExento { get; set; }
        public string MontoAfecto { get; set; }
        public string NomRepLegal { get; set; }
        public string CodRepLegal { get; set; }
        public string IDCajaComp { get; set; }
        public string IDInsSegur { get; set; }
        public Nullable<decimal> PorcCajaComp { get; set; }
        public Nullable<decimal> PorcInsSegur { get; set; }
        public Nullable<decimal> PorcAdicInsSegur { get; set; }
        public string IDProvCajaComp { get; set; }
        public string IDProvInsSegur { get; set; }
        public Nullable<decimal> EmpPagCajaComp { get; set; }
        public Nullable<decimal> EmpPagInsSegur { get; set; }
        public Nullable<decimal> EmpPagAFP { get; set; }
        public Nullable<decimal> EmpPagIsapre { get; set; }
        public string TempUsaVentas { get; set; }
        public string IDCliente { get; set; }
        public string IDTramoEmp { get; set; }
        public string VtaElectronica { get; set; }
        public string NomContactoVtaElec { get; set; }
        public string FonoContactoVtaElec { get; set; }
        public string FaxContactoVtaElec { get; set; }
        public string EmailContactoVtaElec { get; set; }
        public string UsaSolCotizacion { get; set; }
        public string IDMonedaPesos { get; set; }
        public Nullable<decimal> PorcInpAfIsa { get; set; }
        public string IntContable { get; set; }
        public string IntVenta { get; set; }
        public string IntMovimientos { get; set; }
        public string UsaGratificacion { get; set; }
        public string IntArticulos { get; set; }
        public string intAntPago { get; set; }
        public string IntEmpleados { get; set; }
        public string IntParametrosEmp { get; set; }
        public string CodAreaFax { get; set; }
        public string CodAreaFono { get; set; }
        public string IntUsaCertificado { get; set; }
        public Nullable<int> NumClieSii { get; set; }
        public string UsaCorrecionMovInv { get; set; }
        public string SociedadAnonima { get; set; }
        public string TipoSA { get; set; }
        public Nullable<int> NumSIIFormulario { get; set; }
        public Nullable<int> NumSIIVersion { get; set; }
        public string IntForm3323 { get; set; }
        public string IntExpContab { get; set; }
        public string NuevoFormatoCodLegal { get; set; }
        public string AutorizaValCodLegal { get; set; }
        public string OpcionDeGestion { get; set; }
        public string DocVtaVE { get; set; }
        public string IntCompras { get; set; }
        public string UsaFactElectronica { get; set; }
        public Nullable<decimal> ACTECO1 { get; set; }
        public Nullable<decimal> ACTECO2 { get; set; }
        public Nullable<decimal> ACTECO3 { get; set; }
        public Nullable<decimal> ACTECO4 { get; set; }
        public Nullable<decimal> ACTECO5 { get; set; }
        public Nullable<System.DateTime> FecRes { get; set; }
        public Nullable<decimal> NumRes { get; set; }
        public string SuscritoSign { get; set; }
        public string IntContratos { get; set; }
        public string IntRIM { get; set; }
        public string IntegraInformes { get; set; }
        public string IntInfCons { get; set; }
        public string IntHonorarios { get; set; }
        public string IntFiniquitos { get; set; }
        public string IntExpPedidos { get; set; }
        public string IntExpArticulos { get; set; }
        public string IntExpClientes { get; set; }
        public string IntExpProveedores { get; set; }
        public string RUTAutorizadoSII { get; set; }
        public string CodigoImptoRet { get; set; }
        public string UsaFactCpraElectronica { get; set; }
        public string NomArcAdj { get; set; }
        public Nullable<decimal> SizeArcAdj { get; set; }
        public byte[] ArcAdj { get; set; }
        public string IntOT { get; set; }
        public string PorEmpleados { get; set; }
        public string PorOrdenTrabajo { get; set; }
        public string IntMovimientosEmp { get; set; }
        public string IntClientes { get; set; }
        public string IntProveedores { get; set; }
        public string IntMatriz { get; set; }
        public string IntAF { get; set; }
        public string PorDocElec { get; set; }
        public string IntInvSeries { get; set; }
        public string IntInvLotes { get; set; }
        public string IntInvUbicaciones { get; set; }
        public string IntInvPropiedades { get; set; }
        public string IntMultMovNomina { get; set; }
        public string IntCRM { get; set; }
        public Nullable<decimal> Rubro { get; set; }
        public Nullable<decimal> SubRubro { get; set; }
        public Nullable<decimal> Acteco { get; set; }
        public string IntPagoProv { get; set; }
        public string IntMultiConta { get; set; }
        public string IntForm3327_3328 { get; set; }
        public string IntPedidos { get; set; }
        public string UsaAudit { get; set; }
        public string IntGS1 { get; set; }
        public string IntInnovacion { get; set; }
        public string RegimenesFiscales { get; set; }
        public string IntDefineStockFuturo { get; set; }
        public string IntInformeIFRS { get; set; }
        public string Complementos { get; set; }
        public string IntContBimoneda { get; set; }
        public Nullable<int> IDFormatoCRMPortal { get; set; }
        public string IntGestProyecto { get; set; }
        public string IntArchivosDAOT { get; set; }
        public string IntMovil { get; set; }
        public string IntNotificacionesOT { get; set; }
        public string IntNotificacionesCOT { get; set; }
        public string BCIConnection { get; set; }
        public string ModeloFacturaElectronica { get; set; }
        public string IntBodegaPorUsuario { get; set; }
        public string IntFacturaMultOt { get; set; }
        public string IntConsumoOT { get; set; }
        public string IntInfConfVTAS { get; set; }
        public string IntInfConfCPAS { get; set; }
        public string IntInfConfINV { get; set; }
        public string IntInfConfOT { get; set; }
        public string IntInfConfCOT { get; set; }
        public string IntInfConfPED { get; set; }
        public string IntCnegPorUsuario { get; set; }
        public string IntPos { get; set; }
        public string IntRequisiciones { get; set; }
        public string IntImpOT { get; set; }
        public string IntPeople { get; set; }
        public string BciPyme { get; set; }
        public string IntUsaLiq { get; set; }
        public string IntImgArt { get; set; }
        public string IntImgCot { get; set; }
        public string RegimenEspecial { get; set; }
        public string IntUsaAsocPedidoOP { get; set; }
        public string Ubigeo { get; set; }
        public string IntAgrupacionDetCoti { get; set; }
        public string IntCodAlternativos { get; set; }
        public string IntBalAmericano { get; set; }
        public string IntImpVtaEspecifico { get; set; }
        public string IntOTxGDV { get; set; }
        public string IntFmtoEmailEspecifi { get; set; }
        public string IntNotaCobro { get; set; }
        public string IntUsaAsocDocReq { get; set; }
        public string IntUsaDoctoTraspaso { get; set; }
        public string IntConsumoParcialOT { get; set; }
        public string IntUsaImpListaPrecio { get; set; }
        public string IntAgrupaCtaInfComp { get; set; }
        public string IntUsaPreventaPOS { get; set; }
        public string IntUsaPagoHonoElec { get; set; }
        public string IntFactoring { get; set; }
        public Nullable<bool> UsaCategoriasProductos { get; set; }
    }
}
