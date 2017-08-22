using Domain.Models;
using FluentNHibernate.Mapping;

namespace Bradop.StockWebApi.Mapping
{
    public class StockMap : ClassMap<Stock>
    {
        public StockMap()
        {
            Table("zbozi");

            Id(x => x.Id, "id").GeneratedBy.Identity().UnsavedValue(0);

            Map(x => x.Kod, "kod").Length(15);
            Map(x => x.Nazev, "nazev").Length(250);
            Map(x => x.DZaloz, "dZaloz");
            Map(x => x.TZaloz, "tZaloz");
            Map(x => x.KodUziv, "KodUziv");
            Map(x => x.KodPodSkladu, "KodPodSkladu");
            Map(x => x.TypZbozi);
            Map(x => x.Nas, "nas").Length(30);
            Map(x => x.KodSortiment).Length(15);
            Map(x => x.KodCenSkup);
            Map(x => x.KodVyrobce).Length(15);
            Map(x => x.KodSlevSkup);
            Map(x => x.KodDPH);
            Map(x => x.SPD);
            Map(x => x.SPDProc);
            Map(x => x.Jednotka, "jednotka").Length(5);
            Map(x => x.BaleniZakl);
            Map(x => x.BaleniPal);
            Map(x => x.BaleniAlt);
            Map(x => x.BaleniAltNazev).Length(10);
            Map(x => x.MinZasoba);
            Map(x => x.OptZasoba);
            Map(x => x.MaxZasoba);
            Map(x => x.Mn);
            Map(x => x.RezMn);
            Map(x => x.ObjMn);
            Map(x => x.NC);
            Map(x => x.NCP);
            Map(x => x.KC);
            Map(x => x.PCA);
            Map(x => x.PCB);
            Map(x => x.PCC);
            Map(x => x.PCD);
            Map(x => x.Pozn).Length(60);
            Map(x => x.Intrastat_KodZbozi).Length(8);
            Map(x => x.Intrastat_KodZeme).Length(2);
            Map(x => x.Intrastat_KodKraje).Length(2);
            Map(x => x.Intrastat_Hm);
            Map(x => x.Intrastat_DoplJedn).Length(3);
            Map(x => x.Intrastat_DoplMn);
            Map(x => x.BarCode).Length(20);
            Map(x => x.BarCodeBal).Length(20);
            Map(x => x.Hmotnost);
            Map(x => x.Objem);
            Map(x => x.Del, "del");
            Map(x => x.MinExpMn);
            Map(x => x.MinExpMnBaleni);
            Map(x => x.Obaly_Jednotka);
            Map(x => x.Obaly_Mn);
            Map(x => x.ICNejDodav).Length(15);
            Map(x => x.CPNejDodav).Length(5);
            Map(x => x.ObrCesta).Length(200);
            Map(x => x.ObrNazev).Length(250);
            Map(x => x.CProvozovny, "cProvozovny");
            Map(x => x.NazevAlt1).Length(250);
            Map(x => x.NazevAlt2).Length(250);
            Map(x => x.PC1);
            Map(x => x.PC2);
            Map(x => x.PoznText);
            Map(x => x.EshopKratkyPopis, "eshopKratkyPopis");
            Map(x => x.EshopPodrobnyPopis, "eshopPodrobnyPopis");
            Map(x => x.PrpPrijem);
            Map(x => x.PrpExpedice);
            Map(x => x.PrpVkladatBezVazby);
            Map(x => x.Upzn);
            Map(x => x.PoznText_PlainText);
            Map(x => x.PrpNevkladatNaZahranicni);
            Map(x => x.MernaJednotka).Length(5);
            Map(x => x.KoefMerneJednotky);
            Map(x => x.Import);
            Map(x => x.HashImport);
            Map(x => x.VU_Netto_3_0_1);
            Map(x => x.VU_Sklmisto_3_0_1);
            Map(x => x.VU_VolnaZ5_3_0_1);
            Map(x => x.VU_Puvodniznaceni_3_0_1);
            Map(x => x.VU_Dodavatelskecis_3_0_1);
            Map(x => x.VU_Dodcislo_3_0_1);
            Map(x => x.VU_Nostnostkg_3_0_1);
            Map(x => x.VU_Material_3_0_1);
        }
    }
}