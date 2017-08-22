using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bradop.StockWebApi.DTO
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nazev { get; set; }
        public DateTime DZaloz { get; set; }
        public DateTime TZaloz { get; set; }
        public string KodUziv { get; set; }
        public int KodPodSkladu { get; set; }
        public int TypZbozi { get; set; }
        public string Nas { get; set; }
        public string KodSortiment { get; set; }
        public int? KodCenSkup { get; set; }
        public string KodVyrobce { get; set; }
        public int? KodSlevSkup { get; set; }
        public Int16? KodDPH { get; set; }
        public decimal? SPD { get; set; }
        public bool? SPDProc { get; set; }
        public string Jednotka { get; set; }
        public decimal? BaleniZakl { get; set; }
        public decimal? BaleniPal { get; set; }
        public decimal? BaleniAlt { get; set; }
        public string BaleniAltNazev { get; set; }
        public decimal? MinZasoba { get; set; }
        public decimal OptZasoba { get; set; }
        public decimal MaxZasoba { get; set; }
        public decimal Mn { get; set; }
        public decimal RezMn { get; set; }
        public decimal ObjMn { get; set; }
        public decimal? NC { get; set; }
        public decimal? NCP { get; set; }
        public decimal? KC { get; set; }
        public decimal? PCA { get; set; }
        public decimal? PCB { get; set; }
        public decimal? PCC { get; set; }
        public decimal? PCD { get; set; }
        public string Pozn { get; set; }
        public string Intrastat_KodZbozi { get; set; }
        public string Intrastat_KodZeme { get; set; }
        public string Intrastat_KodKraje { get; set; }
        public decimal? Intrastat_Hm { get; set; }
        public string Intrastat_DoplJedn { get; set; }
        public decimal? Intrastat_DoplMn { get; set; }
        public string BarCode { get; set; }
        public string BarCodeBal { get; set; }
        public decimal? Hmotnost { get; set; }
        public decimal? Objem { get; set; }
        public bool? Del { get; set; }
        public decimal? MinExpMn { get; set; }
        public Int16? MinExpMnBaleni { get; set; }
        public Int16? Obaly_Jednotka { get; set; }
        public decimal? Obaly_Mn { get; set; }
        public string ICNejDodav { get; set; }
        public string CPNejDodav { get; set; }
        public string ObrCesta { get; set; }
        public string ObrNazev { get; set; }
        public int CProvozovny { get; set; }
        public string NazevAlt1 { get; set; }
        public string NazevAlt2 { get; set; }
        public decimal PC1 { get; set; }
        public decimal PC2 { get; set; }
        public string PoznText { get; set; }
        public string EshopKratkyPopis { get; set; }
        public string EshopPodrobnyPopis { get; set; }
        public byte PrpPrijem { get; set; }
        public byte PrpExpedice { get; set; }
        public bool PrpVkladatBezVazby { get; set; }
        public string Upzn { get; set; }
        public string PoznText_PlainText { get; set; }
        public bool PrpNevkladatNaZahranicni { get; set; }
        public string MernaJednotka { get; set; }
        public decimal KoefMerneJednotky { get; set; }
        public bool Import { get; set; }
        public string HashImport { get; set; }
        public decimal? VU_Netto_3_0_1 { get; set; }
        public string VU_Sklmisto_3_0_1 { get; set; }
        public string VU_VolnaZ5_3_0_1 { get; set; }
        public string VU_Puvodniznaceni_3_0_1 { get; set; }
        public string VU_Dodavatelskecis_3_0_1 { get; set; }
        public string VU_Dodcislo_3_0_1 { get; set; }
        public string VU_Nostnostkg_3_0_1 { get; set; }
        public string VU_Material_3_0_1 { get; set; }
    }
}