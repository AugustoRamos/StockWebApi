using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Stock
    {
        public virtual int Id { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Nazev { get; set; }
        public virtual DateTime DZaloz { get; set; }
        public virtual DateTime TZaloz { get; set; }
        public virtual string KodUziv { get; set; }
        public virtual int KodPodSkladu { get; set; }
        public virtual int TypZbozi { get; set; }
        public virtual string Nas { get; set; }
        public virtual string KodSortiment { get; set; }
        public virtual int? KodCenSkup { get; set; }
        public virtual string KodVyrobce { get; set; }
        public virtual int? KodSlevSkup { get; set; }
        public virtual Int16? KodDPH { get; set; }
        public virtual decimal? SPD { get; set; }
        public virtual bool? SPDProc { get; set; }
        public virtual string Jednotka { get; set; }
        public virtual decimal? BaleniZakl { get; set; }
        public virtual decimal? BaleniPal { get; set; }
        public virtual decimal? BaleniAlt { get; set; }
        public virtual string BaleniAltNazev { get; set; }
        public virtual decimal? MinZasoba { get; set; }
        public virtual decimal OptZasoba { get; set; }
        public virtual decimal MaxZasoba { get; set; }
        public virtual decimal Mn { get; set; }
        public virtual decimal RezMn { get; set; }
        public virtual decimal ObjMn { get; set; }
        public virtual decimal? NC { get; set; }
        public virtual decimal? NCP { get; set; }
        public virtual decimal? KC { get; set; }
        public virtual decimal? PCA { get; set; }
        public virtual decimal? PCB { get; set; }
        public virtual decimal? PCC { get; set; }
        public virtual decimal? PCD { get; set; }
        public virtual string Pozn { get; set; }
        public virtual string Intrastat_KodZbozi { get; set; }
        public virtual string Intrastat_KodZeme { get; set; }
        public virtual string Intrastat_KodKraje { get; set; }
        public virtual decimal? Intrastat_Hm { get; set; }
        public virtual string Intrastat_DoplJedn { get; set; }
        public virtual decimal? Intrastat_DoplMn { get; set; }
        public virtual string BarCode { get; set; }
        public virtual string BarCodeBal { get; set; }
        public virtual decimal? Hmotnost { get; set; }
        public virtual decimal? Objem { get; set; }
        public virtual bool? Del { get; set; }
        public virtual decimal? MinExpMn { get; set; }
        public virtual Int16? MinExpMnBaleni { get; set; }
        public virtual Int16? Obaly_Jednotka { get; set; }
        public virtual decimal? Obaly_Mn { get; set; }
        public virtual string ICNejDodav { get; set; }
        public virtual string CPNejDodav { get; set; }
        public virtual string ObrCesta { get; set; }
        public virtual string ObrNazev { get; set; }
        public virtual int CProvozovny { get; set; }
        public virtual string NazevAlt1 { get; set; }
        public virtual string NazevAlt2 { get; set; }
        public virtual decimal PC1 { get; set; }
        public virtual decimal PC2 { get; set; }
        public virtual string PoznText { get; set; }
        public virtual string EshopKratkyPopis { get; set; }
        public virtual string EshopPodrobnyPopis { get; set; }
        public virtual byte PrpPrijem { get; set; }
        public virtual byte PrpExpedice { get; set; }
        public virtual bool PrpVkladatBezVazby { get; set; }
        public virtual string Upzn { get; set; }
        public virtual string PoznText_PlainText { get; set; }
        public virtual bool PrpNevkladatNaZahranicni { get; set; }
        public virtual string MernaJednotka { get; set; }
        public virtual decimal KoefMerneJednotky { get; set; }
        public virtual bool Import { get; set; }
        public virtual string HashImport { get; set; }
        public virtual decimal? VU_Netto_3_0_1 { get; set; }
        public virtual string VU_Sklmisto_3_0_1 { get; set; }
        public virtual string VU_VolnaZ5_3_0_1 { get; set; }
        public virtual string VU_Puvodniznaceni_3_0_1 { get; set; }
        public virtual string VU_Dodavatelskecis_3_0_1 { get; set; }
        public virtual string VU_Dodcislo_3_0_1 { get; set; }
        public virtual string VU_Nostnostkg_3_0_1 { get; set; }
        public virtual string VU_Material_3_0_1 { get; set; }
    }
}
