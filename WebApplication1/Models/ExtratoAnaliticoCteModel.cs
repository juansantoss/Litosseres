using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ExtratoAnaliticoCteModel
    {
        public int cUF { get; set; }
        public string cCT { get; set; }
        public int CFOP { get; set; }
        public string natOp { get; set; }
        public int mod { get; set; }
        public int serie { get; set; }
        public int nCT { get; set; }
        public string dhEmi { get; set; }
        public int tpImp { get; set; }
        public int tpEmis { get; set; }
        public int cDV { get; set; }
        public int tpAmb { get; set; }
        public int tpCTe { get; set; }
        public int procEmi { get; set; }
        public string verProc { get; set; }
        public int cMunEnv { get; set; }
        public string xMunEnv { get; set; }
        public string UFEnv { get; set; }
        public string modal { get; set; }
        public int tpServ { get; set; }
        public int cMunIni { get; set; }
        public string xMunIni { get; set; }
        public string UFIni { get; set; }
        public int cMunFim { get; set; }
        public string xMunFim { get; set; }
        public string UFFim { get; set; }
        public int retira { get; set; }
        public string indIEToma { get; set; }
        public int toma3 { get; set; }
        public int toma { get; set; }
        public int tpPer { get; set; }
        public string dProg { get; set; }
        public int tpHor { get; set; }
        public string origCalc { get; set; }
        public string destCalc { get; set; }
        public string xObs { get; set; }
        public string xCampo { get; set; }
        public string xTexto { get; set; }
        public string CNPJ_Emitente { get; set; }
        public string IE_Emitente { get; set; }
        public string xNome_Emitente { get; set; }
        public string xFant_Emitente { get; set; }
        public string xLgr_Emitente { get; set; }
        public string nro_Emitente { get; set; }
        public string xBairro_Emitente { get; set; }
        public int cMun_Emitente { get; set; }
        public string xMun_Emitente { get; set; }
        public string CEP_Emitente { get; set; }
        public string UF_Emitente { get; set; }
        public string fone_Emitente { get; set; }
        public string CNPJ_Remetente { get; set; }
        public string IE_Remetente { get; set; }
        public string xNome_Remetente { get; set; }
        public string xFant_Remetente { get; set; }
        public string fone_Remetente { get; set; }
        public string xLgr_Remetente { get; set; }
        public string nro_Remetente { get; set; }
        public string xBairro_Remetente { get; set; }
        public int cMun_Remetente { get; set; }
        public string xMun_Remetente { get; set; }
        public string CEP_Remetente { get; set; }
        public string UF_Remetente { get; set; }
        public int cPais_Remetente { get; set; }
        public string xPais_Remetente { get; set; }
        public string CNPJ_Destinatario { get; set; }
        public string IE_Destinatario { get; set; }
        public string xNome_Destinatario { get; set; }
        public string fone_Destinatario { get; set; }
        public string xLgr_Destinatario { get; set; }
        public string nro_Destinatario { get; set; }
        public string xBairro_Destinatario { get; set; }
        public int cMun_Destinatario { get; set; }
        public string xMun_Destinatario { get; set; }
        public string CEP_Destinatario { get; set; }
        public string UF_Destinatario { get; set; }
        public int cPais_Destinatario { get; set; }
        public string xPais_Destinatario { get; set; }
        public decimal vTPrest { get; set; }
        public decimal vRec { get; set; }
        public string xNome_Comp1 { get; set; }
        public decimal vComp1 { get; set; }
        public string xNome_Comp2 { get; set; }
        public decimal vComp2 { get; set; }
        public int CST_ICMS { get; set; }
        public decimal vBCSTRet { get; set; }
        public decimal vICMSSTRet { get; set; }
        public decimal pICMSSTRet { get; set; }
        public string infAdFisco { get; set; }
        public decimal vCarga { get; set; }
        public string proPred { get; set; }
        public string cUnid { get; set; }
        public string tpMed { get; set; }
        public decimal qCarga { get; set; }
        public decimal vCargaAverb { get; set; }
        public string chave { get; set; }
        public string RNTRC { get; set; }
        public string CNPJ_Autorizado { get; set; }
        public string CNPJ_ResponsavelTec { get; set; }
        public string xContato { get; set; }
        public string email { get; set; }
        public string fone_ResponsavelTec { get; set; }
        public string qrCodCTe { get; set; }
        public string SignatureValue { get; set; }
        public int tpAmb_Proto { get; set; }
        public string verAplic_Proto { get; set; }
        [Key]
        public string chCTe_Proto { get; set; }
        public string dhRecbto_Proto { get; set; }
        public string nProt_Proto { get; set; }
        public string digVal_Proto { get; set; }
        public int cStat_Proto { get; set; }
        public string xMotivo_Proto { get; set; }
    }
}
