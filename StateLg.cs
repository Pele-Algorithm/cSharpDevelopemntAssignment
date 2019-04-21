using System;

public class StateLg
{  
	static string stateAndCapital,northCentral,northEast,northWest,southEast,southSouth,southWest;
    public static void Process()
    {
		 stateAndCapital = @" 
		State             Capital
		=========================
   1.   Abia	          Umuahia
   2.   Adamawa	          Yola
   3.   Akwa Ibom	      Uyo
   4.   Anambra	          Awka
   5.   Bauchi	          Bauchi
   6.   Bayelsa           Yenagoa
   7.   Benue	          Makurdi
   8.   Borno	          Maiduguri
   9.   Cross River	      Calabar
  10.   Delta	          Asaba
  11.   Ebonyi 	          Abakaliki
  12.   Edo	              Benin
  13.   Ekiti	          Ado Ekiti
  14.   Enugu             Enugu
  15.   Gombe	          Gombe
  16.   Imo               Owerri
  17.   Jigawa            Dutse
  18.   Kaduna            Kaduna
  19.   Kano	          Kano
  20.   Katsina	          Katsina  
  21.   Kebbi	          Birnin Kebbi
  22.   Kogi	          Lokoja
  23.   Kwara	          Ilorin
  24.   Lagos	          Ikeja
  25.   Nasarawa	      Lafia
  26.   Niger	          Minna
  27.   Ogun	          Abeokuta
  28.   Ondo              Akure
  29.   Osun	          Oshogbo
  30.   Oyo	              Ibadan
  31.   Plateau	          Jos
  32.   Rivers            Port Harcourt
  33.   Sokoto	          Sokoto
  34.   Taraba	          Jalingo
  35.   Yobe	          Damaturu
  36.   Zamfara           Gusau
  37.   FCT               Abuja";
	
     northCentral = @"
     (loosely known as Middle Belt):
     Benue
     Kogi
     Kwara
     Nasarawa
     Niger
     Plateau
     Federal Capital Territory";
		
    northEast = @"
  Adamawa
  Bauchi
  Borno
  Gombe
  Taraba
  Yobe";

    northWest = @"
  Jigawa
  Kaduna
  Kano
  Katsina
  Kebbi
  Sokoto
  Zamfara";

   southEast =@"  
   Abia
   Anambra
   Ebonyi
   Enugu
   Imo";

   southSouth =@"
 Akwa Ibom
 Bayelsa
 Cross River
 Rivers
 Delta
 Edo";

 southWest = @"
 Ekiti
 Lagos
 Ogun
 Ondo
 Osun
 Oyo";
		
 
 //===================================
	bool isDone = false;
	while(!isDone)
	{
	int numS;
	Console.WriteLine("************State&Local.Govt App**************");
	Console.WriteLine("Press 1: List the state and capital in nigeria");
	Console.WriteLine("Press 2: List Gepolitical Zone in nigeria");
	Console.WriteLine("press -1 to exist");
	 bool success = int.TryParse(Console.ReadLine(), out numS);
		if(success)
		{ 
			if(numS == 1)
			{
		   	Console.WriteLine(stateAndCapital);
			Console.WriteLine("enter the number preceding the state to know its local government info");
			int num = int.Parse(Console.ReadLine());
				if(num == 1)
				{
					Console.WriteLine(@"
					Abia State There are seventeen Local Government Areas in Abia State. 
					They are Aba North LGA, Aba South LGA, Arochukwu LGA, Bende LGA, Ikwuano LGA, Isiala Ngwa North LGA,
					Isiala Ngwa South LGA, Isuikwuato LGA, Obi Ngwa LGA, Ohafia LGA, Osisioma Ngwa LGA, Ugwunagbo LGA, 
					Ukwa East LGA, Ukwa West LGA, Umuahia North LGA, Umuahia South LGA, Umu Nneochi LGA. ");
				}
				else if(num == 2)
				{
					
					Console.WriteLine(@"
					There are twenty-one Local Government Areas in Adamawa State.
					They are Demsa LGA, Fufore LGA, Ganye LGA, Girei LGA, Gombi LGA, Guyuk LGA, Hong LGA, Jada LGA, Lamurde LGA,
					Madagali LGA, Maiha LGA, Mayo-Belwa LGA, Michika LGA, Mubi North LGA, Mubi South LGA, Numan LGA, Shelleng LGA,
					Song LGA, Toungo LGA, Yola North LGA, Yola South LGA.");
				}
				else if(num == 3)
				{
					Console.WriteLine(@"
					There thirty-one Local Government Areas in Akwa Ibom State. 
					They are Abak LGA, Eastern Obolo LGA, Eket LGA, Esit-Eket LGA, Essien Udim LGA, Etim-Ekpo LGA, Etinan LGA, 
					Ibeno LGA, Ibesikpo-Asutan LGA, Ibiono-Ibom LGA, Ika LGA, Ikono LGA, Ikot Abasi LGA, Ikot Ekpene LGA, Ini LGA, 
					Itu LGA, Mbo LGA, Mkpat-Enin LGA, Nsit-Atai LGA, Nsit-Ibom LGA, Nsit-Ubium LGA, Obot-Akara LGA, Okobo LGA,
					Onna LGA, Oron LGA, Oruk Anam LGA, Ukanafun LGA, Udung-Uko LGA, Uruan LGA, Urue-Offong/Oruko LGA, Uyo LGA.");
				}
				else if(num == 4)
			    {
					Console.WriteLine(@"There are twenty-one Local Government Areas in Anambra State. 
									  They are Aguata LGA, Awka North LGA, Awka South LGA, Anambra East LGA, Anambra West LGA,
									  Anaocha LGA, Ayamelum LGA, Dunukofia LGA, Ekwusigo LGA, Idemili North LGA, Idemili South LGA,
									  Ihiala LGA, Njikoka LGA, Nnewi North LGA, Nnewi South LGA, Ogbaru LGA, Onitsha North LGA, 
									  Onitsha South LGA, Orumba North LGA, Orumba South LGA, Oyi LGA.");
				}
				else if(num == 5)
				{
					Console.WriteLine(@"
					Bauchi State There are twenty Local Government Areas in Bauchi State.
					They are Bauchi LGA, Tafawa Balewa LGA, Dass LGA, Toro LGA, Bogoro LGA, Ningi LGA, Warji LGA,
					Ganjuwa LGA, Kirfi LGA, Alkaleri LGA, Darazo LGA, Misau LGA, Giade LGA, Shira LGA, Jama'are LGA,
					Katagum LGA, Itas/Gadau LGA, Zaki LGA, Gamawa LGA");
				}
				else if(num == 6)
				{
				   	Console.WriteLine(@"
					There are just eight Local Government Areas in Bayelsa State. 
					They are Brass LGA, Ekeremor LGA, Kolokuma/Opokuma LGA, Nembe LGA, Ogbia LGA, Sagbama LGA, 
					Southern Ijaw LGA, Yenagoa LGA. ");
				}
				else if(num == 8)
				{
				   	Console.WriteLine(@"
					There are twenty-seven Local Government Areas in Borno State. 
					They are Abadan LGA, Askira/Uba LGA, Bama LGA, Bayo LGA, Biu LGA, Chibok LGA, Damboa LGA,
					Dikwagubio LGA, Guzamala LGA, Gwoza LGA, Hawul LGA, Jere LGA, Kaga LGA, Kalka/Balge LGA, 
					Konduga LGA, Kukawa LGA, Kwaya-ku LGA, Mafa LGA, Magumeri LGA, Maiduguri LGA, Marte LGA, Mobbar LGA, 
					Monguno LGA, Ngala LGA, Nganzai LGA, Shani LGA.");
				}
				else if(num == 9)
				{
				   	Console.WriteLine(@"
					There are eighteen Local Government Areas in Cross River State.
					They are Abi LGA, Akamkpa LGA, Akpabuyo LGA, Bakassi LGA, Bekwarra LGA, Biase LGA, Boki LGA,
					Calabar Municipal, Calabar South LGA, Etung LGA, Ikom LGA, Obanliku LGA, Obubra LGA, Obudu LGA, 
					Odukpani LGA, Ogoja LGA, Yakuur LGA, Yala LGA.");
				}
				else if(num == 10)
				{
				   	Console.WriteLine(@"
					There twenty-five Local Government Areas in Delta State. 
					They are Aniocha south LGA, Anioha LGA, Bomadi LGA, Burutu LGA, Ethiope west LGA, Ethiope east LGA,
					Ika south LGA, Ika north east LGA, Isoko south LGA, Isoko north LGA, Ndokwa east LGA, Ndokwa west LGA,
					Okpe LGA, Oshimili north LGA, Oshimili south LGA, Patani LGA, Sapele LGA, Udu LGA, Ughelli south LGA,
					Ughelli north LGA, Ukwuani LGA, Uviwie LGA, Warri central LGA, Warri north LGA, Warri south LGA. ");
				}
				else if(num == 11)
				{
				   	Console.WriteLine(@"
					There are thirteen Local Government Areas in Ebonyi. 
					They are Abakaliki LGA, Afikpo North LGA, Afikpo South (Edda) LGA, Ebonyi LGA, Ezza North LGA,
					Ezza South LGA, Ikwo LGA, Ishielu LGA, Ivo LGA, Izzi LGA, Ohaozara LGA, Ohaukwu LGA, Onicha LGA.");
				}
				else if(num == 7)
				{
				    Console.WriteLine(@"
					There are twenty-two Local Government Areas in Benue State. 
					They are Ado LGA, Agatu LGA, Apa LGA, Buruku LGA, Gboko LGA, Guma LGA, Gwer East LGA, Gwer West LGA,
					Katsina-Ala LGA, Konshisha LGA, Kwande LGA, Logo LGA, Makurdi LGA, Obi LGA, Ogbadibo LGA, Ohimini LGA, 
					Oju LGA, Okpokwu LGA, Otukpo LGA, Tarka LGA, Ukum LGA, Ushongo LGA, Vandeikya LGA.");
				}
				else if(num == 14)
				{
				   	Console.WriteLine(@"
					There are seventeen Local Government Areas in Enugu. 
					They are Aninri LGA, Awgu LGA, Enugu East LGA, Enugu North LGA, Enugu South LGA, Ezeagu LGA,
					Igbo Etiti LGA, Igbo Eze North LGA, Igbo Eze South LGA, Isi Uzo LGA, Nkanu East LGA, Nkanu West LGA,
					Nsukka LGA, Oji River LGA, Udenu LGA, Udi LGA, Uzo-Uwani LGA.");
				}
				else if(num == 12)
				{
				   	Console.WriteLine(@"
					Edo State has eighteen Local Government Areas. 
					They are Akoko-Edo LGA, Egor LGA, Esan Central LGA, Esan North-East LGA, Esan South-East LGA, 
					Esan West LGA, Etsako Central LGA, Etsako East LGA, Etsako West LGA, Igueben LGA, Ikpoba-Okha LGA,
					Oredo LGA, Orhionmwon LGA, Ovia North-East LGA, Ovia South-West LGA, Owan East LGA, Owan West LGA, Uhunmwonde LGA.");
				}
				else if(num == 13)
				{
				   	Console.WriteLine(@"
					Ekiti State has sixteen Local Government Areas. 
					They are Ado-Ekiti LGA, Ikere LGA, Oye LGA, Aiyekire (Gbonyin) LGA, Efon LGA, Ekiti East LGA, 
					Ekiti South-West LGA, Ekiti West LGA, Emure LGA, Ido-Osi LGA, Ijero LGA, Ikole LGA, Ilejemeje LGA, 
					Irepodun/Ifelodun LGA, Ise/Orun LGA, Moba LGA.");
				}
				else if(num == 15)
				{
				   	Console.WriteLine(@"
					Gombe State has eleven Local Government Areas. 
					They are Akko LGA, Balanga LGA, Billiri LGA, Dukku LGA, Dunakaye LGA, Gombe LGA, Kaltungo LGA,
					Kwami LGA, Nafada/Bajoga LGA, Shomgom LGA, Yamaltu/Deba LGA.");
				}
				else if(num == 16)
				{
				   	Console.WriteLine(@"
					Imo State has twenty-seven Local Government Areas. 
					They are Aboh Mbaise LGA, Ahiazu Mbaise LGA, Ehime Mbano LGA, Ezinihitte Mbaise LGA, Ideato North LGA,
					Ideato South LGA, Ihitte/Uboma LGA, Ikeduru LGA, Isiala Mbano LGA, Isu LGA, Mbaitoli LGA, Ngor Okpala LGA,
					Njaba LGA, Nkwerre LGA, Nwangele LGA, Obowo LGA, Oguta LGA, Ohaji/Egbema LGA, Okigwe LGA, Onuimo LGA, 
					Orlu LGA, Orsu LGA, Oru East LGA, Oru West LGA, Owerri Municipal, Owerri North LGA, Owerri West LGA, Nwangele LGA.");
				}
				else if(num == 17)
				{
				   	Console.WriteLine(@"
					There are twenty-seven Local Government Areas in Jigawa.
					 They are Auyo LGA, Babura LGA, Biriniwa LGA, Birnin Kudu LGA, Buji LGA, Dutse LGA, Gagarawa LGA, 
					 Garki LGA, Gumel LGA, Guri LGA, Gwaram LGA, Gwiwa LGA, Hadejia LGA, Jahun LGA, Kafin Hausa LGA, 
					 Kaugama LGA, Kazaure LGA, Kiri Kasama LGA, Kiyawa LGA, Maigatari LGA, Malam Madori LGA, Miga LGA, 
					 Ringim LGA, Roni LGA, Sule Tankarkar LGA, Taura LGA, Yankwashi LGA. ");
				}
				else if(num == 18)
				{
				   	Console.WriteLine(@"
					There are twenty-three Local Government Areas in Kadunna. 
					They are Birnin Gwari LGA, Chikun LGA, Giwa LGA, Igabi LGA, Ikara LGA, Jaba LGA, Jema'a LGA, Kachia LGA, Kaduna North LGA,
					Kaduna South LGA, Kagarko LGA, Kajuru LGA, Kaura LGA, Kauru LGA, Kubau LGA, Kudan LGA, Lere LGA, Makarfi LGA, Sabon Gari LGA,
					Sanga LGA, Soba LGA, Zangon Kataf LGA, Zaria LGA.");
				}
				else if(num == 19)
				{
				   	Console.WriteLine(@"
					Kano State has forty-four Local Government Areas. 
					They are Ajingi LGA, Albasu LGA, Bagwai LGA, Bebeji LGA, Bichi LGA, Bunkure LGA, Dala LGA, Dambatta LGA, 
					Dawakin kudu LGA, Dawakin Tofa LGA, Doguwa LGA, Fagge LGA, Gabasawa LGA, Garko LGA, Garun Mallam LGA, Gaya LGA,
					Gezawa LGA, Gwale LGA, Gwarzo LGA, Kabo LGA, Kano Municipal, Karaye LGA, Kibiya LGA, Kiru LGA, Kumbtso LGA, Kunchi LGA,
					Kura LGA, Madobi LGA, Makoda LGA, Minjibir LGA, Nassarawa LGA, Rano LGA, Rimin Gado LGA, Rogo LGA, Shanono LGA, Sumaila LGA, 
					Takai LGA, Tarauni LGA, Tofa LGA, Tsanyawa LGA, Tudun Wada LGA, Ungogo LGA, Warawa LGA, Wudil LGA.");
				}
				else if(num == 20)
				{
				   	Console.WriteLine(@"
					There are thirty-four Local Government Areas in Katsina State.
					They are Bakori LGA, Batagarawa LGA, Batsari LGA, Baure LGA, Bindawa LGA, Charanchi LGA, Dan Musa LGA, 
					Dandume LGA, Danja LGA, Daura LGA, Dutsi LGA, Dutsin-Ma LGA, Faskari LGA, Funtua LGA, Ingawa LGA, 
					Jibia LGA, Kafur LGA, Kaita LGA, Kankara LGA, Kankia LGA, Katsina LGA, Kurfi LGA, Kusada LGA, Mai'Adua LGA,
					Malumfashi LGA, Mani LGA, Mashi LGA, Matazu LGA, Musawa LGA, Rimi LGA, Sabuwa LGA, Safana LGA, Sandamu LGA, Zango LGA. 
					");
				}
				else if(num == 21)
				{
				   	Console.WriteLine(@"
					There are twenty-one Local Government Areas in Kebbi State. 
					They are Aleiro LGA, Arewa Dandi LGA, Argungu LGA, Augie LGA, Bagudo LGA, Birnin Kebbi LGA, Bunza LGA, 
					Dandi LGA, Fakai LGA, Gwandu LGA, Jega LGA, Kalgo LGA, Koko/Besse LGA, Maiyama LGA, Ngaski LGA, Sakaba LGA,
					Shanga LGA, Suru LGA, Danko/Wasagu LGA, Yauri LGA, Zuru LGA. 
					");
				}
				else if(num == 22)
				{
				   	Console.WriteLine(@"
					Kogi State There are twenty-one Local Government Areas in Kogi State.
					They are Adavi LGA, Ajaokuta LGA, Ankpa LGA, Bassa LGA, Dekina LGA, Ibaji LGA, Idah LGA, Igalamela-Odolu LGA,
					Ijumu LGA, Kabba/Bunu LGA, Koton Karfe LGA, Lokoja LGA, Mopa-Muro LGA, Ofu LGA, Ogori/Magongo LGA, Okehi LGA, Okene LGA,
					Olamaboro LGA, Omala LGA, Yagba East LGA, Yagba West LGA.
					");
				}
				else if(num == 23)
				{
				   	Console.WriteLine(@"
					There are sixteen Local Government Areas in Kwara State. 
					They are Asa LGA, Baruten LGA, Edu LGA, Ekiti LGA, Ifelodun LGA, Ilorin East LGA, Ilorin South LGA, Ilorin West LGA,
					Irepodun LGA, Isin LGA, Kaiama LGA, Moro LGA, Offa LGA, Oke Ero LGA, Oyun LGA, Pategi LGA.
					");
				}
				else if(num == 24)
				{
				   	Console.WriteLine(@"
					Lagos State is divided into twenty Local Government Areas.
					They are Agege LGA, Alimosho Ifelodun LGA, Alimosho LGA, Amuwo-Odofin LGA, Apapa LGA, Badagry LGA, Epe LGA, Eti-Osa LGA,
					Ibeju- Lekki LGA, Ifako/Ijaye LGA, Ikeja LGA, Ikorodu LGA, Kosofe LGA, Lagos Island LGA, Lagos Mainland LGA, Mushin LGA, 
					Ojo LGA, Oshodi –Isolo LGA, Shomolu LGA, Surulere LGA. 
					");
				}
				else if(num == 25)
				{
				   	Console.WriteLine(@"
					Nasarawa State is divided in thirteen Local Government Areas. 
					They are Akwanga LGA, Awe LGA, Doma LGA, Karu LGA, Keana LGA, Keffi LGA, Kokona LGA, Lafia LGA, Nassarawa LGA, 
					Nassarawa/Eggon LGA, Obi LGA, Toto LGA, Wamba LGA.
					");
				}
				else if(num == 26)
				{
				   	Console.WriteLine(@"
					Niger State is divided into twenty-five Local Government Areas.
					They are Agaie LGA, Agwara LGA, Bida LGA, Borgu LGA, Bosso LGA, Chanchaga LGA, Edati LGA, Gbako LGA, Gurara LGA,
					Katcha LGA, Kontagora LGA, Lapai LGA, Lavun LGA, Magama LGA, Mariga LGA, Mashegu LGA, Mokwa LGA, Munya LGA, Paikoro LGA,
					Rafi LGA, Rijau LGA, Shiroro LGA, Suleja LGA, Tafa LGA, Wushishi LGA. 
					");
				}
				else if(num == 27)
				{
				   	Console.WriteLine(@"
					There are twenty Local Government Areas in Ogun State. They are Abeokuta North LGA, Abeokuta South LGA, Ado-Odo/Ota LGA,
					Ewekoro LGA, Ifo LGA, Ijebu East LGA, Ijebu North LGA, Ijebu North East LGA, Ijebu Ode LGA, Ikenne LGA, Imeko Afon LGA, 
					Ipokia LGA, Obafemi Owode LGA, Odogbolu LGA, Odeda LGA, Ogun Waterside LGA, Remo North LGA, Sagamu LGA, Yewa North LGA, 
					Yewa South LGA.");
				}
				else if(num == 28)
				{
				   	Console.WriteLine(@"
					Ondo State is divided in eighteen Local Government Areas. 
					They are Akoko north LGA, Akoko north east LGA, Akoko south east LGA, Akoko south LGA, Akure north LGA, Akure LGA,
					Idanre LGA, Ifedore LGA, Ese Odo LGA, Ilaje LGA, Ile Oluji/Okeigbo LGA, Irele LGA, Odigbo LGA, Okitipupa LGA, Ondo LGA,
					Ondo east LGA, Ose LGA, Owo LGA.");
				}
				else if(num == 29)
				{
				   	Console.WriteLine(@"
					Osun State is divided into thirty Local Government Areas. 
					They are Atakumosa west LGA, Atakumosa east LGA, Ayedaade LGA, Ayedire LGA, Bolawaduro LGA, Boripe, LGA, Ede LGA,
					Ede north LGA, Egbedore LGA, Ejigbo LGA, Ife north LGA, Ife central LGA, Ife south LGA, Ife east LGA, Ifedayo,
					Ifelodun LGA, Ilesha west LGA, Ila- orangun LGA, Ilesah east LGA, Irepodun LGA, Irewole LGA, Isokan LGA, Iwo LGA, 
					Obokun LGA, Odo-otin LGA, ola oluwa LGA, olorunda LGA, Oriade LGA, Orolu LGA, Osogbo LGA.
					");
				}
				else if(num == 30)
				{
				   	Console.WriteLine(@"
					Oyo State is divided into thirty-three Local Government Areas.
					They are Akinyele Moniya LGA, Afijio Jobele LGA, Egbeda Egbeda LGA, Ibadan North Agodi Gate LGA,
					Ibadan North-East Iwo Road LGA, Ibadan North-West LGA, Ibadan South-West Ring Road LGA, Ibadan South-East Mapo LGA,
					Ibarapa Central LGA, Ibarapa East Eruwa LGA, Ido LGA, Irepo LGA, Iseyin LGA, Kajola LGA, Lagelu LGA, 
					Ogbomosho North LGA, Ogbomosho South LGA, Oyo West Ojongbodu LGA, Atiba Ofa Meta LGA, Atisbo Tede LGA, Saki West LGA,
					Saki East LGA, Itesiwaju Otu LGA, Iwajowa LGA, Ibarapa North LGA, Olorunsogo LGA, Oluyole LGA, Ogo Oluwa LGA, Surulere LGA,
					Orelope LGA, Ori Ire LGA, Oyo East LGA, Ona Ara LGA.");
				}
				else if(num == 31)
				{
				   	Console.WriteLine(@"
					Plateau State is divided into seventeen Local Government Areas.
					They are Barkin Ladi LGA, Bassa LGA, Bokkos LGA, Jos East LGA, Jos North LGA, Jos South LGA, Kanam LGA, Kanke LGA,
					Langtang North LGA, Langtang South LGA, Mangu LGA, Mikang LGA, Pankshin LGA, Qua'an Pan LGA, Riyom LGA, Shendam LGA,
					Wase LGA. ");
				}
				else if(num == 32)
				{
				   	Console.WriteLine(@"
					Rivers State is divided into twenty-three Local Government Areas.
					They are Abua-Odual LGA, Ahoada East LGA, Ahoada West LGA, Akuku-Toru LGA, Andoni LGA, Asari-Toru LGA, Bonny LGA, 
					Degema LGA, Eleme LGA, Emohua LGA, Etche LGA, Gokana LGA, Ikwerre LGA, Oyigbo LGA, Khana LGA, Obio-Akpor LGA, 
					Ogba-Egbema-Ndoni LGA, Ogu-bolo LGA, Okrika LGA, Omumma LGA, Opobo-Nkoro LGA, Portharcourt LGA, Tai LGA
					");
				}
				else if(num == 33)
				{
				   	Console.WriteLine(@"
					There are twenty-three Local Government Areas in Sokoto.
					They are Binji LGA, Bodinga LGA, Dange Shuni LGA, Gada LGA, Goronyo LGA, Gudu LGA, Gwadabawa LGA, Illela LGA,
					Isa LGA, Kebbe LGA, Kware LGA, Rabah LGA, Sabon Birni LGA, Shagari LGA, Silame LGA, Sokoto North LGA, Sokoto South LGA,
					Tambuwal LGA, Tangaza LGA, Tureta LGA, Wamako LGA, Wurno LGA, Yabo LGA.
					");
				}
				else if(num == 34)
				{
				   	Console.WriteLine(@"
					There are sixteen Local Government Areas in Taraba State.
					They are Ardo Kola LGA, Bali LGA, Donga LGA, Gashaka LGA, Gassol LGA, Ibi LGA, Jalingo LGA, Karim Lamido LGA, Kurmi LGA,
					Lau LGA, Sardauna LGA, Takum LGA, Ussa LGA, Wukari LGA, Yorro LGA, Zing LGA.
					");
				}
				else if(num == 35)
				{
				   	Console.WriteLine(@"
					There are seventeen Local Government Areas in Yobe State. 
					They are Bade LGA, Bursari LGA, Damaturu LGA, Geidam LGA, Gujba LGA, Gulani LGA, Fika LGA, Fune LGA, Jakusko LGA,
                     Karasuwa LGA, Machina LGA, Nangere LGA, Nguru LGA, Potiskum LGA, Tarmuwa LGA, Yunusari LGA, Yusufari LGA
                     ");
				}
				else if(num == 36)
				{
				   	Console.WriteLine(@"
					There fourteen Local Government Areas in Zamfara State. 
					They are Anka LGA, Bakura LGA, Birnin Magaji/Kiyaw LGA, Bukkuyum LGA, Bungudu LGA, Tsafe LGA, Gummi LGA, Gusau LGA,
					Kaura Namoda LGA, Maradun LGA, Maru LGA, Shinkafi LGA, Talata Mafara LGA, Zurmi LGA.
					");
				}
				else if(num == 37)
				{
				   	Console.WriteLine(@"
					Abuja is divided into six Local Government Areas:
					which are Abaji LGA, Abuja Municipal, Gwagwalada, LGA Kuje, LGA Bwari, LGA Kwali
					");
				}
				else Console.WriteLine("incorrect option!!!,please input the right number");
		
			}
			else if(numS == 2)
			{
			Console.WriteLine(@"
			                   1. North Central
							   2. North East
							   3. North West
							   4. South East
							   5. South South
							   6. South West");
			  Console.WriteLine("Press the number preceding the geopolitical zone to see the states under it");
				      int num = int.Parse(Console.ReadLine());
				      if(num == 1)
					  {
						  Console.WriteLine(northCentral);
					  }
				      if(num == 2)
					  {
						  Console.WriteLine(northEast);
					  }
				      if(num == 3)
					  {
						  Console.WriteLine(northWest);
					  }
				      if(num == 4)
					  {
						  Console.WriteLine(southEast);
					  }
				      if(num == 5)
					  {
						  Console.WriteLine(southSouth);
					  }
				      if(num == 6)
					  {
						  Console.WriteLine(southWest);
					  }
			}
			else if(numS == -1)
			{
			 isDone = true;
			}
			else Console.WriteLine("input correct option");
		
		}
		else
		{
		 Console.WriteLine("please input a correct number");   
		}
	}
	
  }
	

    public static void Main()
    {
      Process();
	  Console.ReadLine();
    }
}using System;

public class StateLg
{  
	static string stateAndCapital,northCentral,northEast,northWest,southEast,southSouth,southWest;
    public static void Process()
    {
		 stateAndCapital = @" 
		State             Capital
		=========================
   1.   Abia	          Umuahia
   2.   Adamawa	          Yola
   3.   Akwa Ibom	      Uyo
   4.   Anambra	          Awka
   5.   Bauchi	          Bauchi
   6.   Bayelsa           Yenagoa
   7.   Benue	          Makurdi
   8.   Borno	          Maiduguri
   9.   Cross River	      Calabar
  10.   Delta	          Asaba
  11.   Ebonyi 	          Abakaliki
  12.   Edo	              Benin
  13.   Ekiti	          Ado Ekiti
  14.   Enugu             Enugu
  15.   Gombe	          Gombe
  16.   Imo               Owerri
  17.   Jigawa            Dutse
  18.   Kaduna            Kaduna
  19.   Kano	          Kano
  20.   Katsina	          Katsina  
  21.   Kebbi	          Birnin Kebbi
  22.   Kogi	          Lokoja
  23.   Kwara	          Ilorin
  24.   Lagos	          Ikeja
  25.   Nasarawa	      Lafia
  26.   Niger	          Minna
  27.   Ogun	          Abeokuta
  28.   Ondo              Akure
  29.   Osun	          Oshogbo
  30.   Oyo	              Ibadan
  31.   Plateau	          Jos
  32.   Rivers            Port Harcourt
  33.   Sokoto	          Sokoto
  34.   Taraba	          Jalingo
  35.   Yobe	          Damaturu
  36.   Zamfara           Gusau
  37.   FCT               Abuja";
	
     northCentral = @"
     (loosely known as Middle Belt):
     Benue
     Kogi
     Kwara
     Nasarawa
     Niger
     Plateau
     Federal Capital Territory";
		
    northEast = @"
  Adamawa
  Bauchi
  Borno
  Gombe
  Taraba
  Yobe";

    northWest = @"
  Jigawa
  Kaduna
  Kano
  Katsina
  Kebbi
  Sokoto
  Zamfara";

   southEast =@"  
   Abia
   Anambra
   Ebonyi
   Enugu
   Imo";

   southSouth =@"
 Akwa Ibom
 Bayelsa
 Cross River
 Rivers
 Delta
 Edo";

 southWest = @"
 Ekiti
 Lagos
 Ogun
 Ondo
 Osun
 Oyo";
		
 
 //===================================
	bool isDone = false;
	while(!isDone)
	{
	int numS;
	Console.WriteLine("************State&Local.Govt App**************");
	Console.WriteLine("Press 1: List the state and capital in nigeria");
	Console.WriteLine("Press 2: List Gepolitical Zone in nigeria");
	Console.WriteLine("press -1 to exist");
	 bool success = int.TryParse(Console.ReadLine(), out numS);
		if(success)
		{ 
			if(numS == 1)
			{
		   	Console.WriteLine(stateAndCapital);
			Console.WriteLine("enter the number preceding the state to know its local government info");
			int num = int.Parse(Console.ReadLine());
				if(num == 1)
				{
					Console.WriteLine(@"
					Abia State There are seventeen Local Government Areas in Abia State. 
					They are Aba North LGA, Aba South LGA, Arochukwu LGA, Bende LGA, Ikwuano LGA, Isiala Ngwa North LGA,
					Isiala Ngwa South LGA, Isuikwuato LGA, Obi Ngwa LGA, Ohafia LGA, Osisioma Ngwa LGA, Ugwunagbo LGA, 
					Ukwa East LGA, Ukwa West LGA, Umuahia North LGA, Umuahia South LGA, Umu Nneochi LGA. ");
				}
				else if(num == 2)
				{
					
					Console.WriteLine(@"
					There are twenty-one Local Government Areas in Adamawa State.
					They are Demsa LGA, Fufore LGA, Ganye LGA, Girei LGA, Gombi LGA, Guyuk LGA, Hong LGA, Jada LGA, Lamurde LGA,
					Madagali LGA, Maiha LGA, Mayo-Belwa LGA, Michika LGA, Mubi North LGA, Mubi South LGA, Numan LGA, Shelleng LGA,
					Song LGA, Toungo LGA, Yola North LGA, Yola South LGA.");
				}
				else if(num == 3)
				{
					Console.WriteLine(@"
					There thirty-one Local Government Areas in Akwa Ibom State. 
					They are Abak LGA, Eastern Obolo LGA, Eket LGA, Esit-Eket LGA, Essien Udim LGA, Etim-Ekpo LGA, Etinan LGA, 
					Ibeno LGA, Ibesikpo-Asutan LGA, Ibiono-Ibom LGA, Ika LGA, Ikono LGA, Ikot Abasi LGA, Ikot Ekpene LGA, Ini LGA, 
					Itu LGA, Mbo LGA, Mkpat-Enin LGA, Nsit-Atai LGA, Nsit-Ibom LGA, Nsit-Ubium LGA, Obot-Akara LGA, Okobo LGA,
					Onna LGA, Oron LGA, Oruk Anam LGA, Ukanafun LGA, Udung-Uko LGA, Uruan LGA, Urue-Offong/Oruko LGA, Uyo LGA.");
				}
				else if(num == 4)
			    {
					Console.WriteLine(@"There are twenty-one Local Government Areas in Anambra State. 
									  They are Aguata LGA, Awka North LGA, Awka South LGA, Anambra East LGA, Anambra West LGA,
									  Anaocha LGA, Ayamelum LGA, Dunukofia LGA, Ekwusigo LGA, Idemili North LGA, Idemili South LGA,
									  Ihiala LGA, Njikoka LGA, Nnewi North LGA, Nnewi South LGA, Ogbaru LGA, Onitsha North LGA, 
									  Onitsha South LGA, Orumba North LGA, Orumba South LGA, Oyi LGA.");
				}
				else if(num == 5)
				{
					Console.WriteLine(@"
					Bauchi State There are twenty Local Government Areas in Bauchi State.
					They are Bauchi LGA, Tafawa Balewa LGA, Dass LGA, Toro LGA, Bogoro LGA, Ningi LGA, Warji LGA,
					Ganjuwa LGA, Kirfi LGA, Alkaleri LGA, Darazo LGA, Misau LGA, Giade LGA, Shira LGA, Jama'are LGA,
					Katagum LGA, Itas/Gadau LGA, Zaki LGA, Gamawa LGA");
				}
				else if(num == 6)
				{
				   	Console.WriteLine(@"
					There are just eight Local Government Areas in Bayelsa State. 
					They are Brass LGA, Ekeremor LGA, Kolokuma/Opokuma LGA, Nembe LGA, Ogbia LGA, Sagbama LGA, 
					Southern Ijaw LGA, Yenagoa LGA. ");
				}
				else if(num == 8)
				{
				   	Console.WriteLine(@"
					There are twenty-seven Local Government Areas in Borno State. 
					They are Abadan LGA, Askira/Uba LGA, Bama LGA, Bayo LGA, Biu LGA, Chibok LGA, Damboa LGA,
					Dikwagubio LGA, Guzamala LGA, Gwoza LGA, Hawul LGA, Jere LGA, Kaga LGA, Kalka/Balge LGA, 
					Konduga LGA, Kukawa LGA, Kwaya-ku LGA, Mafa LGA, Magumeri LGA, Maiduguri LGA, Marte LGA, Mobbar LGA, 
					Monguno LGA, Ngala LGA, Nganzai LGA, Shani LGA.");
				}
				else if(num == 9)
				{
				   	Console.WriteLine(@"
					There are eighteen Local Government Areas in Cross River State.
					They are Abi LGA, Akamkpa LGA, Akpabuyo LGA, Bakassi LGA, Bekwarra LGA, Biase LGA, Boki LGA,
					Calabar Municipal, Calabar South LGA, Etung LGA, Ikom LGA, Obanliku LGA, Obubra LGA, Obudu LGA, 
					Odukpani LGA, Ogoja LGA, Yakuur LGA, Yala LGA.");
				}
				else if(num == 10)
				{
				   	Console.WriteLine(@"
					There twenty-five Local Government Areas in Delta State. 
					They are Aniocha south LGA, Anioha LGA, Bomadi LGA, Burutu LGA, Ethiope west LGA, Ethiope east LGA,
					Ika south LGA, Ika north east LGA, Isoko south LGA, Isoko north LGA, Ndokwa east LGA, Ndokwa west LGA,
					Okpe LGA, Oshimili north LGA, Oshimili south LGA, Patani LGA, Sapele LGA, Udu LGA, Ughelli south LGA,
					Ughelli north LGA, Ukwuani LGA, Uviwie LGA, Warri central LGA, Warri north LGA, Warri south LGA. ");
				}
				else if(num == 11)
				{
				   	Console.WriteLine(@"
					There are thirteen Local Government Areas in Ebonyi. 
					They are Abakaliki LGA, Afikpo North LGA, Afikpo South (Edda) LGA, Ebonyi LGA, Ezza North LGA,
					Ezza South LGA, Ikwo LGA, Ishielu LGA, Ivo LGA, Izzi LGA, Ohaozara LGA, Ohaukwu LGA, Onicha LGA.");
				}
				else if(num == 7)
				{
				    Console.WriteLine(@"
					There are twenty-two Local Government Areas in Benue State. 
					They are Ado LGA, Agatu LGA, Apa LGA, Buruku LGA, Gboko LGA, Guma LGA, Gwer East LGA, Gwer West LGA,
					Katsina-Ala LGA, Konshisha LGA, Kwande LGA, Logo LGA, Makurdi LGA, Obi LGA, Ogbadibo LGA, Ohimini LGA, 
					Oju LGA, Okpokwu LGA, Otukpo LGA, Tarka LGA, Ukum LGA, Ushongo LGA, Vandeikya LGA.");
				}
				else if(num == 14)
				{
				   	Console.WriteLine(@"
					There are seventeen Local Government Areas in Enugu. 
					They are Aninri LGA, Awgu LGA, Enugu East LGA, Enugu North LGA, Enugu South LGA, Ezeagu LGA,
					Igbo Etiti LGA, Igbo Eze North LGA, Igbo Eze South LGA, Isi Uzo LGA, Nkanu East LGA, Nkanu West LGA,
					Nsukka LGA, Oji River LGA, Udenu LGA, Udi LGA, Uzo-Uwani LGA.");
				}
				else if(num == 12)
				{
				   	Console.WriteLine(@"
					Edo State has eighteen Local Government Areas. 
					They are Akoko-Edo LGA, Egor LGA, Esan Central LGA, Esan North-East LGA, Esan South-East LGA, 
					Esan West LGA, Etsako Central LGA, Etsako East LGA, Etsako West LGA, Igueben LGA, Ikpoba-Okha LGA,
					Oredo LGA, Orhionmwon LGA, Ovia North-East LGA, Ovia South-West LGA, Owan East LGA, Owan West LGA, Uhunmwonde LGA.");
				}
				else if(num == 13)
				{
				   	Console.WriteLine(@"
					Ekiti State has sixteen Local Government Areas. 
					They are Ado-Ekiti LGA, Ikere LGA, Oye LGA, Aiyekire (Gbonyin) LGA, Efon LGA, Ekiti East LGA, 
					Ekiti South-West LGA, Ekiti West LGA, Emure LGA, Ido-Osi LGA, Ijero LGA, Ikole LGA, Ilejemeje LGA, 
					Irepodun/Ifelodun LGA, Ise/Orun LGA, Moba LGA.");
				}
				else if(num == 15)
				{
				   	Console.WriteLine(@"
					Gombe State has eleven Local Government Areas. 
					They are Akko LGA, Balanga LGA, Billiri LGA, Dukku LGA, Dunakaye LGA, Gombe LGA, Kaltungo LGA,
					Kwami LGA, Nafada/Bajoga LGA, Shomgom LGA, Yamaltu/Deba LGA.");
				}
				else if(num == 16)
				{
				   	Console.WriteLine(@"
					Imo State has twenty-seven Local Government Areas. 
					They are Aboh Mbaise LGA, Ahiazu Mbaise LGA, Ehime Mbano LGA, Ezinihitte Mbaise LGA, Ideato North LGA,
					Ideato South LGA, Ihitte/Uboma LGA, Ikeduru LGA, Isiala Mbano LGA, Isu LGA, Mbaitoli LGA, Ngor Okpala LGA,
					Njaba LGA, Nkwerre LGA, Nwangele LGA, Obowo LGA, Oguta LGA, Ohaji/Egbema LGA, Okigwe LGA, Onuimo LGA, 
					Orlu LGA, Orsu LGA, Oru East LGA, Oru West LGA, Owerri Municipal, Owerri North LGA, Owerri West LGA, Nwangele LGA.");
				}
				else if(num == 17)
				{
				   	Console.WriteLine(@"
					There are twenty-seven Local Government Areas in Jigawa.
					 They are Auyo LGA, Babura LGA, Biriniwa LGA, Birnin Kudu LGA, Buji LGA, Dutse LGA, Gagarawa LGA, 
					 Garki LGA, Gumel LGA, Guri LGA, Gwaram LGA, Gwiwa LGA, Hadejia LGA, Jahun LGA, Kafin Hausa LGA, 
					 Kaugama LGA, Kazaure LGA, Kiri Kasama LGA, Kiyawa LGA, Maigatari LGA, Malam Madori LGA, Miga LGA, 
					 Ringim LGA, Roni LGA, Sule Tankarkar LGA, Taura LGA, Yankwashi LGA. ");
				}
				else if(num == 18)
				{
				   	Console.WriteLine(@"
					There are twenty-three Local Government Areas in Kadunna. 
					They are Birnin Gwari LGA, Chikun LGA, Giwa LGA, Igabi LGA, Ikara LGA, Jaba LGA, Jema'a LGA, Kachia LGA, Kaduna North LGA,
					Kaduna South LGA, Kagarko LGA, Kajuru LGA, Kaura LGA, Kauru LGA, Kubau LGA, Kudan LGA, Lere LGA, Makarfi LGA, Sabon Gari LGA,
					Sanga LGA, Soba LGA, Zangon Kataf LGA, Zaria LGA.");
				}
				else if(num == 19)
				{
				   	Console.WriteLine(@"
					Kano State has forty-four Local Government Areas. 
					They are Ajingi LGA, Albasu LGA, Bagwai LGA, Bebeji LGA, Bichi LGA, Bunkure LGA, Dala LGA, Dambatta LGA, 
					Dawakin kudu LGA, Dawakin Tofa LGA, Doguwa LGA, Fagge LGA, Gabasawa LGA, Garko LGA, Garun Mallam LGA, Gaya LGA,
					Gezawa LGA, Gwale LGA, Gwarzo LGA, Kabo LGA, Kano Municipal, Karaye LGA, Kibiya LGA, Kiru LGA, Kumbtso LGA, Kunchi LGA,
					Kura LGA, Madobi LGA, Makoda LGA, Minjibir LGA, Nassarawa LGA, Rano LGA, Rimin Gado LGA, Rogo LGA, Shanono LGA, Sumaila LGA, 
					Takai LGA, Tarauni LGA, Tofa LGA, Tsanyawa LGA, Tudun Wada LGA, Ungogo LGA, Warawa LGA, Wudil LGA.");
				}
				else if(num == 20)
				{
				   	Console.WriteLine(@"
					There are thirty-four Local Government Areas in Katsina State.
					They are Bakori LGA, Batagarawa LGA, Batsari LGA, Baure LGA, Bindawa LGA, Charanchi LGA, Dan Musa LGA, 
					Dandume LGA, Danja LGA, Daura LGA, Dutsi LGA, Dutsin-Ma LGA, Faskari LGA, Funtua LGA, Ingawa LGA, 
					Jibia LGA, Kafur LGA, Kaita LGA, Kankara LGA, Kankia LGA, Katsina LGA, Kurfi LGA, Kusada LGA, Mai'Adua LGA,
					Malumfashi LGA, Mani LGA, Mashi LGA, Matazu LGA, Musawa LGA, Rimi LGA, Sabuwa LGA, Safana LGA, Sandamu LGA, Zango LGA. 
					");
				}
				else if(num == 21)
				{
				   	Console.WriteLine(@"
					There are twenty-one Local Government Areas in Kebbi State. 
					They are Aleiro LGA, Arewa Dandi LGA, Argungu LGA, Augie LGA, Bagudo LGA, Birnin Kebbi LGA, Bunza LGA, 
					Dandi LGA, Fakai LGA, Gwandu LGA, Jega LGA, Kalgo LGA, Koko/Besse LGA, Maiyama LGA, Ngaski LGA, Sakaba LGA,
					Shanga LGA, Suru LGA, Danko/Wasagu LGA, Yauri LGA, Zuru LGA. 
					");
				}
				else if(num == 22)
				{
				   	Console.WriteLine(@"
					Kogi State There are twenty-one Local Government Areas in Kogi State.
					They are Adavi LGA, Ajaokuta LGA, Ankpa LGA, Bassa LGA, Dekina LGA, Ibaji LGA, Idah LGA, Igalamela-Odolu LGA,
					Ijumu LGA, Kabba/Bunu LGA, Koton Karfe LGA, Lokoja LGA, Mopa-Muro LGA, Ofu LGA, Ogori/Magongo LGA, Okehi LGA, Okene LGA,
					Olamaboro LGA, Omala LGA, Yagba East LGA, Yagba West LGA.
					");
				}
				else if(num == 23)
				{
				   	Console.WriteLine(@"
					There are sixteen Local Government Areas in Kwara State. 
					They are Asa LGA, Baruten LGA, Edu LGA, Ekiti LGA, Ifelodun LGA, Ilorin East LGA, Ilorin South LGA, Ilorin West LGA,
					Irepodun LGA, Isin LGA, Kaiama LGA, Moro LGA, Offa LGA, Oke Ero LGA, Oyun LGA, Pategi LGA.
					");
				}
				else if(num == 24)
				{
				   	Console.WriteLine(@"
					Lagos State is divided into twenty Local Government Areas.
					They are Agege LGA, Alimosho Ifelodun LGA, Alimosho LGA, Amuwo-Odofin LGA, Apapa LGA, Badagry LGA, Epe LGA, Eti-Osa LGA,
					Ibeju- Lekki LGA, Ifako/Ijaye LGA, Ikeja LGA, Ikorodu LGA, Kosofe LGA, Lagos Island LGA, Lagos Mainland LGA, Mushin LGA, 
					Ojo LGA, Oshodi –Isolo LGA, Shomolu LGA, Surulere LGA. 
					");
				}
				else if(num == 25)
				{
				   	Console.WriteLine(@"
					Nasarawa State is divided in thirteen Local Government Areas. 
					They are Akwanga LGA, Awe LGA, Doma LGA, Karu LGA, Keana LGA, Keffi LGA, Kokona LGA, Lafia LGA, Nassarawa LGA, 
					Nassarawa/Eggon LGA, Obi LGA, Toto LGA, Wamba LGA.
					");
				}
				else if(num == 26)
				{
				   	Console.WriteLine(@"
					Niger State is divided into twenty-five Local Government Areas.
					They are Agaie LGA, Agwara LGA, Bida LGA, Borgu LGA, Bosso LGA, Chanchaga LGA, Edati LGA, Gbako LGA, Gurara LGA,
					Katcha LGA, Kontagora LGA, Lapai LGA, Lavun LGA, Magama LGA, Mariga LGA, Mashegu LGA, Mokwa LGA, Munya LGA, Paikoro LGA,
					Rafi LGA, Rijau LGA, Shiroro LGA, Suleja LGA, Tafa LGA, Wushishi LGA. 
					");
				}
				else if(num == 27)
				{
				   	Console.WriteLine(@"
					There are twenty Local Government Areas in Ogun State. They are Abeokuta North LGA, Abeokuta South LGA, Ado-Odo/Ota LGA,
					Ewekoro LGA, Ifo LGA, Ijebu East LGA, Ijebu North LGA, Ijebu North East LGA, Ijebu Ode LGA, Ikenne LGA, Imeko Afon LGA, 
					Ipokia LGA, Obafemi Owode LGA, Odogbolu LGA, Odeda LGA, Ogun Waterside LGA, Remo North LGA, Sagamu LGA, Yewa North LGA, 
					Yewa South LGA.");
				}
				else if(num == 28)
				{
				   	Console.WriteLine(@"
					Ondo State is divided in eighteen Local Government Areas. 
					They are Akoko north LGA, Akoko north east LGA, Akoko south east LGA, Akoko south LGA, Akure north LGA, Akure LGA,
					Idanre LGA, Ifedore LGA, Ese Odo LGA, Ilaje LGA, Ile Oluji/Okeigbo LGA, Irele LGA, Odigbo LGA, Okitipupa LGA, Ondo LGA,
					Ondo east LGA, Ose LGA, Owo LGA.");
				}
				else if(num == 29)
				{
				   	Console.WriteLine(@"
					Osun State is divided into thirty Local Government Areas. 
					They are Atakumosa west LGA, Atakumosa east LGA, Ayedaade LGA, Ayedire LGA, Bolawaduro LGA, Boripe, LGA, Ede LGA,
					Ede north LGA, Egbedore LGA, Ejigbo LGA, Ife north LGA, Ife central LGA, Ife south LGA, Ife east LGA, Ifedayo,
					Ifelodun LGA, Ilesha west LGA, Ila- orangun LGA, Ilesah east LGA, Irepodun LGA, Irewole LGA, Isokan LGA, Iwo LGA, 
					Obokun LGA, Odo-otin LGA, ola oluwa LGA, olorunda LGA, Oriade LGA, Orolu LGA, Osogbo LGA.
					");
				}
				else if(num == 30)
				{
				   	Console.WriteLine(@"
					Oyo State is divided into thirty-three Local Government Areas.
					They are Akinyele Moniya LGA, Afijio Jobele LGA, Egbeda Egbeda LGA, Ibadan North Agodi Gate LGA,
					Ibadan North-East Iwo Road LGA, Ibadan North-West LGA, Ibadan South-West Ring Road LGA, Ibadan South-East Mapo LGA,
					Ibarapa Central LGA, Ibarapa East Eruwa LGA, Ido LGA, Irepo LGA, Iseyin LGA, Kajola LGA, Lagelu LGA, 
					Ogbomosho North LGA, Ogbomosho South LGA, Oyo West Ojongbodu LGA, Atiba Ofa Meta LGA, Atisbo Tede LGA, Saki West LGA,
					Saki East LGA, Itesiwaju Otu LGA, Iwajowa LGA, Ibarapa North LGA, Olorunsogo LGA, Oluyole LGA, Ogo Oluwa LGA, Surulere LGA,
					Orelope LGA, Ori Ire LGA, Oyo East LGA, Ona Ara LGA.");
				}
				else if(num == 31)
				{
				   	Console.WriteLine(@"
					Plateau State is divided into seventeen Local Government Areas.
					They are Barkin Ladi LGA, Bassa LGA, Bokkos LGA, Jos East LGA, Jos North LGA, Jos South LGA, Kanam LGA, Kanke LGA,
					Langtang North LGA, Langtang South LGA, Mangu LGA, Mikang LGA, Pankshin LGA, Qua'an Pan LGA, Riyom LGA, Shendam LGA,
					Wase LGA. ");
				}
				else if(num == 32)
				{
				   	Console.WriteLine(@"
					Rivers State is divided into twenty-three Local Government Areas.
					They are Abua-Odual LGA, Ahoada East LGA, Ahoada West LGA, Akuku-Toru LGA, Andoni LGA, Asari-Toru LGA, Bonny LGA, 
					Degema LGA, Eleme LGA, Emohua LGA, Etche LGA, Gokana LGA, Ikwerre LGA, Oyigbo LGA, Khana LGA, Obio-Akpor LGA, 
					Ogba-Egbema-Ndoni LGA, Ogu-bolo LGA, Okrika LGA, Omumma LGA, Opobo-Nkoro LGA, Portharcourt LGA, Tai LGA
					");
				}
				else if(num == 33)
				{
				   	Console.WriteLine(@"
					There are twenty-three Local Government Areas in Sokoto.
					They are Binji LGA, Bodinga LGA, Dange Shuni LGA, Gada LGA, Goronyo LGA, Gudu LGA, Gwadabawa LGA, Illela LGA,
					Isa LGA, Kebbe LGA, Kware LGA, Rabah LGA, Sabon Birni LGA, Shagari LGA, Silame LGA, Sokoto North LGA, Sokoto South LGA,
					Tambuwal LGA, Tangaza LGA, Tureta LGA, Wamako LGA, Wurno LGA, Yabo LGA.
					");
				}
				else if(num == 34)
				{
				   	Console.WriteLine(@"
					There are sixteen Local Government Areas in Taraba State.
					They are Ardo Kola LGA, Bali LGA, Donga LGA, Gashaka LGA, Gassol LGA, Ibi LGA, Jalingo LGA, Karim Lamido LGA, Kurmi LGA,
					Lau LGA, Sardauna LGA, Takum LGA, Ussa LGA, Wukari LGA, Yorro LGA, Zing LGA.
					");
				}
				else if(num == 35)
				{
				   	Console.WriteLine(@"
					There are seventeen Local Government Areas in Yobe State. 
					They are Bade LGA, Bursari LGA, Damaturu LGA, Geidam LGA, Gujba LGA, Gulani LGA, Fika LGA, Fune LGA, Jakusko LGA,
                     Karasuwa LGA, Machina LGA, Nangere LGA, Nguru LGA, Potiskum LGA, Tarmuwa LGA, Yunusari LGA, Yusufari LGA
                     ");
				}
				else if(num == 36)
				{
				   	Console.WriteLine(@"
					There fourteen Local Government Areas in Zamfara State. 
					They are Anka LGA, Bakura LGA, Birnin Magaji/Kiyaw LGA, Bukkuyum LGA, Bungudu LGA, Tsafe LGA, Gummi LGA, Gusau LGA,
					Kaura Namoda LGA, Maradun LGA, Maru LGA, Shinkafi LGA, Talata Mafara LGA, Zurmi LGA.
					");
				}
				else if(num == 37)
				{
				   	Console.WriteLine(@"
					Abuja is divided into six Local Government Areas:
					which are Abaji LGA, Abuja Municipal, Gwagwalada, LGA Kuje, LGA Bwari, LGA Kwali
					");
				}
				else Console.WriteLine("incorrect option!!!,please input the right number");
		
			}
			else if(numS == 2)
			{
			Console.WriteLine(@"
			                   1. North Central
							   2. North East
							   3. North West
							   4. South East
							   5. South South
							   6. South West");
			  Console.WriteLine("Press the number preceding the geopolitical zone to see the states under it");
				      int num = int.Parse(Console.ReadLine());
				      if(num == 1)
					  {
						  Console.WriteLine(northCentral);
					  }
				      if(num == 2)
					  {
						  Console.WriteLine(northEast);
					  }
				      if(num == 3)
					  {
						  Console.WriteLine(northWest);
					  }
				      if(num == 4)
					  {
						  Console.WriteLine(southEast);
					  }
				      if(num == 5)
					  {
						  Console.WriteLine(southSouth);
					  }
				      if(num == 6)
					  {
						  Console.WriteLine(southWest);
					  }
			}
			else if(numS == -1)
			{
			 isDone = true;
			}
			else Console.WriteLine("input correct option");
		
		}
		else
		{
		 Console.WriteLine("please input a correct number");   
		}
	}
	
  }
	

    public static void Main()
    {
      Process();
	  Console.ReadLine();
    }
}
