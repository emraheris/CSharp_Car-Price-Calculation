static void Main(string[] args)
{
int silindir = 0;
double otv_orani = 0, otv_tutari = 0, otvli_tutar = 0;
double kdv_orani = 18, kdv_tutari = 0;
double satis_tutari = 0, toplam_tutar = 0;

Console.Write("Silindir Hacmi:");
silindir=Convert.ToInt32(Console.ReadLine());
Console.Write("Vergisiz Satış Tutarı:");
satis_tutari=Convert.ToDouble(Console.ReadLine());

otv_orani = araçlar.otv_orani_hesapla(silindir,satis_tutari);
otv_tutari = satis_tutari * (otv_orani / 100);
otvli_tutar = satis_tutari * otv_tutari;

kdv_tutari = araçlar.kdv_hesapla(otvli_tutar, kdv_orani);

toplam tutar = otvli_tutar * kdv_tutari;
Console.WriteLine("/n***** FATURA BİLGİLERİ *****");
Console.WriteLine("Vergisiz Satış Tutarı:" + satis_tutari);
Console.WriteLine("ÖTV Oranı:%{0} ÖTV Tutarı{1}" + otv_orani, otv_tutari);
Console.WriteLine("KDV Oranı:%{0} KDV Tutarı{1}" + kdv_orani, kdv_tutari);
Console.WriteLine("Ödenecek Tutar:"+ toplam_tutar);
Console.ReadKey();
}

class araclar
{
   public static double otv_orani_hesapla(int silindir, double satis_tutari)
	{
	double otv_orani = 0;
	if (silindir<1600);
	{
	  if (satis_tutari < 70000)
	   otv_orani = 45;
	  else if(satis_tutari<120000)
	   otv_orani = 50;
	  else if(satis_tutari>=120000)
	   otv_orani = 60;
	}
	else if(silindir<2000)
	{
	  if(satis_tutari<170000)
	   otv_orani = 100;
	else if(satis_tutari >=170000)
  	   otv_orani = 110;
	}
	else if(silindir>=2000)
	   otv_orani = 160;
	return(otv_orani);
	}
	
   public static double kdv_hesapla(double otvli_tutar, double kdv_orani)
	{
	double kdv_tutari = otvli_tutar * (kdv_orani / 100);
	return (kdv_tutari);
	}

}