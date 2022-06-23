using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EjerciciosAPP_HJMB
{
    class Global
    {
        //Definimos las listas de los continentes y paises
        public static List<Continentes> _continentes = new List<Continentes>
        {
            new Continentes(1, "Africa"),
            new Continentes(2, "America"),
            new Continentes(3, "Asia"),
            new Continentes(4, "Europa")
        };

        public static List<Paises> _paises = new List<Paises>
        {
            //AFRICA            
            new Paises(1,"AO","AGO","Angola","Luanda","244"),
            new Paises(1,"DZ","DZA","Argelia","Algiers","213"),
            new Paises(1,"BJ","BEN","Benín","Porto-Novo","229"),
            new Paises(1,"BW","BWA","Botsuana","Gaborone","267"),
            new Paises(1,"BF","BFA","Burkina Faso","Ouagadougou","226"),
            new Paises(1,"BI","BDI","Burundi","Bujumbura","257"),
            new Paises(1,"CV","CPV","Cabo Verde","Praia","238"),
            new Paises(1,"CM","CMR","Camerún","Yaoundé","237"),
            new Paises(1,"KM","COM","Comoras","Moroni","269"),
            new Paises(1,"CI","CIV","Costa de Marfil","Yamoussoukro","225"),
            new Paises(1,"DJ","DJI","Djibuti","Djibouti","253"),
            new Paises(1,"EG","EGY","Egipto","Cairo","20"),
            new Paises(1,"EH","ESH","El Sáhara Español","El-Aaiun","212"),
            new Paises(1,"ER","ERI","Eritrea","Asmara","291"),
            new Paises(1,"ET","ETH","Etiopía","Addis Ababa","251"),
            new Paises(1,"GA","GAB","Gabón","Libreville","241"),
            new Paises(1,"GM","GMB","Gambia","Banjul","220"),
            new Paises(1,"GH","GHA","Ghana","Accra","233"),
            new Paises(1,"GN","GIN","Guinea","Conakry","224"),
            new Paises(1,"GQ","GNQ","Guinea Ecuatorial","Malabo","240"),
            new Paises(1,"GW","GNB","Guinea-Bissáu","Bissau","245"),
            new Paises(1,"KE","KEN","Kenia","Nairobi","254"),
            new Paises(1,"LS","LSO","Lesoto","Maseru","266"),
            new Paises(1,"LR","LBR","Liberia","Monrovia","231"),
            new Paises(1,"LY","LBY","Libia","Tripolis","218"),
            new Paises(1,"MG","MDG","Madagascar","Antananarivo","261"),
            new Paises(1,"MW","MWI","Malaui","Lilongwe","265"),
            new Paises(1,"ML","MLI","Mali","Bamako","223"),
            new Paises(1,"MA","MAR","Marruecos","Rabat","212"),
            new Paises(1,"MU","MUS","Mauricio","Port Louis","230"),
            new Paises(1,"MR","MRT","Mauritania","Nouakchott","222"),
            new Paises(1,"MZ","MOZ","Mozambique","Maputo","258"),
            new Paises(1,"NA","NAM","Namibia","Windhoek","264"),
            new Paises(1,"NE","NER","Níger","Niamey","227"),
            new Paises(1,"NG","NGA","Nigeria","Abuja","234"),
            new Paises(1,"CF","CAF","República Centroafricana","Bangui","236"),
            new Paises(1,"SS","SSD","República de Sudán del Sur","Juba","211"),
            new Paises(1,"CG","COG","República del Congo","Brazzaville","242"),
            new Paises(1,"CD","COD","República Democrática del Congo","Kinshasa","243"),
            new Paises(1,"RE","REU","Reunión","Saint-Denis","262"),
            new Paises(1,"RW","RWA","Ruanda","Kigali","250"),
            new Paises(1,"SH","SHN","Santa Elena","Jamestown","290"),
            new Paises(1,"ST","STP","Santo Tomé y Príncipe","São Tomé","239"),
            new Paises(1,"SN","SEN","Senegal","Dakar","221"),
            new Paises(1,"SC","SYC","Seychelles","Victoria","248"),
            new Paises(1,"SL","SLE","Sierra Leona","Freetown","232"),
            new Paises(1,"SO","SOM","Somalia","Mogadishu","252"),
            new Paises(1,"ZA","ZAF","Sudáfrica","Pretoria","27"),
            new Paises(1,"SD","SDN","Sudán","Khartoum","249"),
            new Paises(1,"SZ","SWZ","Swazilandia","Mbabane","268"),
            new Paises(1,"TZ","TZA","Tanzania","Dodoma","255"),
            new Paises(1,"TG","TGO","Togo","Lomé","228"),
            new Paises(1,"TN","TUN","Túnez","Tunis","216"),
            new Paises(1,"UG","UGA","Uganda","Kampala","256"),
            new Paises(1,"ZM","ZMB","Zambia","Lusaka","260"),
            new Paises(1,"ZW","ZWE","Zimbabue","Harare","263"),

            //AMERICA
            new Paises(2,"AI","AIA","Anguila","The Valley","+1 264"),
            new Paises(2,"AR","ARG","Argentina","Buenos Aires","54"),
            new Paises(2,"AW","ABW","Aruba","Oranjestad","297"),
            new Paises(2,"BS","BHS","Bahamas","Nassau","1"),
            new Paises(2,"BB","BRB","Barbados","Bridgetown","1"),
            new Paises(2,"BZ","BLZ","Belice","Belmopan","501"),
            new Paises(2,"BM","BMU","Bermudas","Hamilton","1"),
            new Paises(2,"BO","BOL","Bolivia","La Paz","591"),
            new Paises(2,"BR","BRA","Brasil","Brasília","55"),
            new Paises(2,"CA","CAN","Canadá","Ottawa","1"),
            new Paises(2,"CL","CHL","Chile","Santiago","56"),
            new Paises(2,"CO","COL","Colombia","Bogotá","57"),
            new Paises(2,"CR","CRI","Costa Rica","San José","506"),
            new Paises(2,"CU","CUB","Cuba","Havana","53"),
            new Paises(2,"CW","CUW","Curazao","Willemstad","599"),
            new Paises(2,"DM","DMA","Dominica","Roseau","1"),
            new Paises(2,"EC","ECU","Ecuador","Quito","593"),
            new Paises(2,"SV","SLV","El Salvador","San Salvador","503"),
            new Paises(2,"US","USA","Estados Unidos","Washington","1"),
            new Paises(2,"GL","GRL","Groenlandia","Nuuk","299"),
            new Paises(2,"GP","GLP","Guadalupe","Basse-Terre","590"),
            new Paises(2,"GT","GTM","Guatemala","Guatemala City","502"),
            new Paises(2,"GY","GUY","Guyana","Georgetown","592"),
            new Paises(2,"HT","HTI","Haití","Port-au-Prince","509"),
            new Paises(2,"HN","HND","Honduras","Tegucigalpa","504"),
            new Paises(2,"KY","CYM","Islas Caimán","George Town","-344"),
            new Paises(2,"FK","FLK","Islas Malvinas","Stanley","500"),
            new Paises(2,"VG","VGB","Islas Vírgenes Británicas","Road Town","+1 284"),
            new Paises(2,"JM","JAM","Jamaica","Kingston","1"),
            new Paises(2,"MX","MEX","México","Mexico City","52"),
            new Paises(2,"MS","MSR","Montserrat","Plymouth","+1 664"),
            new Paises(2,"NI","NIC","Nicaragua","Managua","505"),
            new Paises(2,"PA","PAN","Panamá","Panama City","507"),
            new Paises(2,"PY","PRY","Paraguay","Asunción","595"),
            new Paises(2,"PE","PER","Perú","Lima","51"),
            new Paises(2,"PR","PRI","Puerto Rico","San Juan","1"),
            new Paises(2,"DO","DOM","República Dominicana","Santo Domingo","1"),
            new Paises(2,"BL","BLM","San Bartolomé","Gustavia","590"),
            new Paises(2,"KN","KNA","San Cristóbal y Nevis","Basseterre","1"),
            new Paises(2,"MF","MAF","San Martín","Marigot","+1 599"),
            new Paises(2,"PM","SPM","San Pedro y Miquelón","Saint-Pierre","508"),
            new Paises(2,"VC","VCT","San Vicente y las Granadinas","Kingstown","1"),
            new Paises(2,"LC","LCA","Santa Lucía","Castries","1"),
            new Paises(2,"SR","SUR","Surinam","Paramaribo","597"),
            new Paises(2,"TT","TTO","Trinidad y Tobago","Port of Spain","1"),
            new Paises(2,"UY","URY","Uruguay","Montevideo","598"),
            new Paises(2,"VE","VEN","Venezuela","Caracas","58"),

            //ASIA
            new Paises(3,"AF","AFG","Afganistán","Kabul","93"),
            new Paises(3,"SA","SAU","Arabia Saudita","Riyadh","966"),
            new Paises(3,"AM","ARM","Armenia","Yerevan","374"),
            new Paises(3,"AZ","AZE","Azerbaiyán","Baku","994"),
            new Paises(3,"BH","BHR","Bahréin","Manama","973"),
            new Paises(3,"BD","BGD","Bangladesh","Dhaka","880"),
            new Paises(3,"MM","MMR","Birmania (Myanmar)","Nay Pyi Taw","95"),
            new Paises(3,"BN","BRN","Brunéi","Bandar Seri Begawan","673"),
            new Paises(3,"BT","BTN","Bután","Thimphu","975"),
            new Paises(3,"KH","KHM","Camboya","Phnom Penh","855"),
            new Paises(3,"CN","CHN","China","Beijing","86"),
            new Paises(3,"KP","PRK","Corea del Norte","Pyongyang","850"),
            new Paises(3,"KR","KOR","Corea del Sur","Seoul","82"),
            new Paises(3,"AE","ARE","Emiratos Árabes Unidos","Abu Dhabi","971"),
            new Paises(3,"PH","PHL","Filipinas","Manila","63"),
            new Paises(3,"GE","GEO","Georgia","Tbilisi","995"),
            new Paises(3,"HK","HKG","Hong Kong","Hong Kong","852"),
            new Paises(3,"IN","IND","India","New Delhi","91"),
            new Paises(3,"ID","IDN","Indonesia","Jakarta","62"),
            new Paises(3,"IQ","IRQ","Irak","Baghdad","964"),
            new Paises(3,"IR","IRN","Irán","Tehran","98"),
            new Paises(3,"IL","ISR","Israel","Jerusalem","972"),
            new Paises(3,"JP","JPN","Japón","Tokyo","81"),
            new Paises(3,"JO","JOR","Jordania","Amman","962"),
            new Paises(3,"KZ","KAZ","Kazajistán","Astana","7"),
            new Paises(3,"KG","KGZ","Kirgizistán","Bishkek","996"),
            new Paises(3,"KW","KWT","Kuwait","Kuwait City","965"),
            new Paises(3,"LA","LAO","Laos","Vientiane","856"),
            new Paises(3,"LB","LBN","Líbano","Beirut","961"),
            new Paises(3,"MO","MAC","Macao","Macao","853"),
            new Paises(3,"MY","MYS","Malasia","Kuala Lumpur","60"),
            new Paises(3,"MV","MDV","Maldivas","Malé","960"),
            new Paises(3,"MN","MNG","Mongolia","Ulan Bator","976"),
            new Paises(3,"NP","NPL","Nepal","Kathmandu","977"),
            new Paises(3,"OM","OMN","Omán","Muscat","968"),
            new Paises(3,"PK","PAK","Pakistán","Islamabad","92"),
            new Paises(3,"QA","QAT","Qatar","Doha","974"),
            new Paises(3,"SG","SGP","Singapur","Singapur","65"),
            new Paises(3,"SY","SYR","Siria","Damascus","963"),
            new Paises(3,"LK","LKA","Sri Lanka","Colombo","94"),
            new Paises(3,"TH","THA","Tailandia","Bangkok","66"),
            new Paises(3,"TW","TWN","Taiwán","Taipei","886"),
            new Paises(3,"TJ","TJK","Tayikistán","Dushanbe","992"),
            new Paises(3,"TM","TKM","Turkmenistán","Ashgabat","993"),
            new Paises(3,"TR","TUR","Turquía","Ankara","90"),
            new Paises(3,"UZ","UZB","Uzbekistán","Tashkent","998"),
            new Paises(3,"VN","VNM","Vietnam","Hanoi","84"),
            new Paises(3,"YE","YEM","Yemen","San‘a’","967"),

            //EUROPA
            new Paises(4,"AL","ALB","Albania","Tirana","355"),
            new Paises(4,"DE","DEU","Alemania","Berlin","49"),
            new Paises(4,"AD","AND","Andorra","Andorra la Vella","376"),
            new Paises(4,"AT","AUT","Austria","Vienna","43"),
            new Paises(4,"BE","BEL","Bélgica","Brussels","32"),
            new Paises(4,"BY","BLR","Bielorrusia","Minsk","375"),
            new Paises(4,"BA","BIH","Bosnia-Herzegovina","Sarajevo","387"),
            new Paises(4,"BG","BGR","Bulgaria","Sofia","359"),
            new Paises(4,"CY","CYP","Chipre","Nicosia","357"),
            new Paises(4,"HR","HRV","Croacia","Zagreb","385"),
            new Paises(4,"DK","DNK","Dinamarca","Copenhagen","45"),
            new Paises(4,"VA","VAT","El Vaticano","Vatican City","39"),
            new Paises(4,"SK","SVK","Eslovaquia","Bratislava","421"),
            new Paises(4,"SI","SVN","Eslovenia","Ljubljana","386"),
            new Paises(4,"ES","ESP","España","Madrid","34"),
            new Paises(4,"EE","EST","Estonia","Tallinn","372"),
            new Paises(4,"FI","FIN","Finlandia","Helsinki","358"),
            new Paises(4,"FR","FRA","Francia","Paris","33"),
            new Paises(4,"GI","GIB","Gibraltar","Gibraltar","350"),
            new Paises(4,"GR","GRC","Grecia","Athens","30"),
            new Paises(4,"NL","NLD","Holanda","Amsterdam","31"),
            new Paises(4,"HU","HUN","Hungría","Budapest","36"),
            new Paises(4,"IE","IRL","Irlanda","Dublin","353"),
            new Paises(4,"IM","IMN","Isla de Man","Douglas, Isle of Man","44"),
            new Paises(4,"IS","ISL","Islandia","Reykjavík","354"),
            new Paises(4,"FO","FRO","Islas Feroe","Tórshavn","298"),
            new Paises(4,"IT","ITA","Italia","Rome","39"),
            new Paises(4,"XK","XKX","Kosovo","Pristina","381"),
            new Paises(4,"LV","LVA","Letonia","Riga","371"),
            new Paises(4,"LI","LIE","Liechtenstein","Vaduz","423"),
            new Paises(4,"LT","LTU","Lituania","Vilnius","370"),
            new Paises(4,"LU","LUX","Luxemburgo","Luxembourg","352"),
            new Paises(4,"MK","MKD","Macedonia","Skopje","389"),
            new Paises(4,"MT","MLT","Malta","Valletta","356"),
            new Paises(4,"MD","MDA","Moldavia","Chişinău","373"),
            new Paises(4,"MC","MCO","Mónaco","Monaco","377"),
            new Paises(4,"ME","MNE","Montenegro","Podgorica","382"),
            new Paises(4,"NO","NOR","Noruega","Oslo","47"),
            new Paises(4,"PL","POL","Polonia","Warsaw","48"),
            new Paises(4,"PT","PRT","Portugal","Lisbon","351"),
            new Paises(4,"GB","GBR","Reino Unido","London","44"),
            new Paises(4,"CZ","CZE","República Checa","Prague","420"),
            new Paises(4,"RO","ROU","Rumanía","Bucharest","40"),
            new Paises(4,"RU","RUS","Rusia","Moscow","7"),
            new Paises(4,"SM","SMR","San Marino","San Marino","378"),
            new Paises(4,"RS","SRB","Serbia","Belgrade","381"),
            new Paises(4,"SE","SWE","Suecia","Stockholm","46"),
            new Paises(4,"CH","CHE","Suiza","Berne","41"),
            new Paises(4,"UA","UKR","Ucrania","Kiev","380")
        };
    }

    public class Continentes
    {
        int id;
        String nombre;

        public Continentes(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }

    public class Paises
    {
        int codContinente;
        String codISO2;
        String codISO3;
        String pais;
        String capital;
        String prefijo;

        public Paises(int codContinente, string codISO2, string codISO3, string pais, string capital, string prefijo)
        {
            this.CodContinente = codContinente;
            this.CodISO2 = codISO2;
            this.CodISO3 = codISO3;
            this.Pais = pais;
            this.Capital = capital;
            this.Prefijo = prefijo;
        }

        public int CodContinente { get => codContinente; set => codContinente = value; }
        public string CodISO2 { get => codISO2; set => codISO2 = value; }
        public string CodISO3 { get => codISO3; set => codISO3 = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Capital { get => capital; set => capital = value; }
        public string Prefijo { get => prefijo; set => prefijo = value; }
    }
}