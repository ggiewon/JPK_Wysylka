using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v2_1E;
using System;
using System.Collections.Generic;
using JPK_WysylkaXML.EditXML.Interfaces.ViewModels.JPK_V7M.v2_1E;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E
{
    public class NaglowekViewModel : INaglowekViewModel
    {
        private readonly JPKNaglowek _deklaracjaNaglowek;

        public NaglowekViewModel(JPKNaglowek deklaracjaNaglowek)
        {
            _deklaracjaNaglowek = deklaracjaNaglowek;
        }

        public string KodSystemowy
        {
            get => _deklaracjaNaglowek.KodFormularza.kodSystemowy;
            set => _deklaracjaNaglowek.KodFormularza.kodSystemowy = value;
        }

        public string WersjaSchemy
        {
            get => _deklaracjaNaglowek.KodFormularza.wersjaSchemy;
            set => _deklaracjaNaglowek.KodFormularza.wersjaSchemy = value;
        }

        public sbyte CelZlozenia
        {
            get => _deklaracjaNaglowek.CelZlozenia.Value;
            set => _deklaracjaNaglowek.CelZlozenia.Value = value;
        }

        public sbyte WariantFormularza
        {
            get => _deklaracjaNaglowek.WariantFormularza;
            set => _deklaracjaNaglowek.WariantFormularza = value;
        }

        public DateTime DataWytworzeniaJPK
        {
            get => _deklaracjaNaglowek.DataWytworzeniaJPK;
            set => _deklaracjaNaglowek.DataWytworzeniaJPK = value;
        }

        public string NazwaSystemu
        {
            get => _deklaracjaNaglowek.NazwaSystemu;
            set => _deklaracjaNaglowek.NazwaSystemu = value;
        }

        public TKodUS KodUrzedu
        {
            get => _deklaracjaNaglowek.KodUrzedu;
            set => _deklaracjaNaglowek.KodUrzedu = value;
        }

        public string Rok
        {
            get => _deklaracjaNaglowek.Rok;
            set => _deklaracjaNaglowek.Rok = value;
        }

        public sbyte Miesiac
        {
            get => _deklaracjaNaglowek.Miesiac;
            set => _deklaracjaNaglowek.Miesiac = value;
        }

        public IEnumerable<Tuple<sbyte, string>> CelZlozeniaItemList => new List<Tuple<sbyte, string>>
        {
            new Tuple<sbyte, string>(1, "Złożenie po raz pierwszy deklaracji za dany okres"),
            new Tuple<sbyte, string>(2, "Korekta deklaracji za dany okres")
        };

        public IEnumerable<Tuple<TKodUS, string>> KodUSItemList =>
            new List<Tuple<TKodUS, string>>
            {
                new Tuple<TKodUS, string>(TKodUS.Item0202, "URZĄD SKARBOWY W BOLESŁAWCU"),
                new Tuple<TKodUS, string>(TKodUS.Item0203, "URZĄD SKARBOWY W BYSTRZYCY KŁODZKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item0204, "URZĄD SKARBOWY W DZIERŻONIOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0205, "URZĄD SKARBOWY W GŁOGOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0206, "URZĄD SKARBOWY W JAWORZE"),
                new Tuple<TKodUS, string>(TKodUS.Item0207, "URZĄD SKARBOWY W JELENIEJ GÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item0208, "URZĄD SKARBOWY W KAMIENNEJ GÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item0209, "URZĄD SKARBOWY W KŁODZKU"),
                new Tuple<TKodUS, string>(TKodUS.Item0210, "URZĄD SKARBOWY W LEGNICY"),
                new Tuple<TKodUS, string>(TKodUS.Item0211, "URZĄD SKARBOWY W LUBANIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0212, "URZĄD SKARBOWY W LUBINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0213, "URZĄD SKARBOWY W LWÓWKU ŚLĄSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0214, "URZĄD SKARBOWY W MILICZU"),
                new Tuple<TKodUS, string>(TKodUS.Item0215, "URZĄD SKARBOWY W NOWEJ RUDZIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0216, "URZĄD SKARBOWY W OLEŚNICY"),
                new Tuple<TKodUS, string>(TKodUS.Item0217, "URZĄD SKARBOWY W OŁAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0218, "URZĄD SKARBOWY W STRZELINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0219, "URZĄD SKARBOWY W ŚRODZIE ŚLĄSKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item0220, "URZĄD SKARBOWY W ŚWIDNICY"),
                new Tuple<TKodUS, string>(TKodUS.Item0221, "URZĄD SKARBOWY W TRZEBNICY"),
                new Tuple<TKodUS, string>(TKodUS.Item0222, "URZĄD SKARBOWY W WAŁBRZYCHU"),
                new Tuple<TKodUS, string>(TKodUS.Item0223, "URZĄD SKARBOWY W WOŁOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0224, "URZĄD SKARBOWY WROCŁAW-FABRYCZNA"),
                new Tuple<TKodUS, string>(TKodUS.Item0225, "URZĄD SKARBOWY WROCŁAW-KRZYKI"),
                new Tuple<TKodUS, string>(TKodUS.Item0226, "URZĄD SKARBOWY WROCŁAW-PSIE POLE"),
                new Tuple<TKodUS, string>(TKodUS.Item0227, "URZĄD SKARBOWY WROCŁAW-STARE MIASTO"),
                new Tuple<TKodUS, string>(TKodUS.Item0228, "URZĄD SKARBOWY WROCŁAW-ŚRÓDMIEŚCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0229, "PIERWSZY URZĄD SKARBOWY WE WROCŁAWIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0230, "URZĄD SKARBOWY W ZĄBKOWICACH ŚLĄSKICH"),
                new Tuple<TKodUS, string>(TKodUS.Item0231, "URZĄD SKARBOWY W ZGORZELCU"),
                new Tuple<TKodUS, string>(TKodUS.Item0232, "URZĄD SKARBOWY W ZŁOTORYI"),
                new Tuple<TKodUS, string>(TKodUS.Item0233, "URZĄD SKARBOWY W GÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item0234, "URZĄD SKARBOWY W POLKOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item0271, "DOLNOŚLĄSKI URZĄD SKARBOWY WE WROCŁAWIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0402, "URZĄD SKARBOWY W ALEKSANDROWIE KUJAWSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0403, "URZĄD SKARBOWY W BRODNICY"),
                new Tuple<TKodUS, string>(TKodUS.Item0404, "PIERWSZY URZĄD SKARBOWY W BYDGOSZCZY"),
                new Tuple<TKodUS, string>(TKodUS.Item0405, "DRUGI URZĄD SKARBOWY W BYDGOSZCZY"),
                new Tuple<TKodUS, string>(TKodUS.Item0406, "TRZECI URZĄD SKARBOWY W BYDGOSZCZY"),
                new Tuple<TKodUS, string>(TKodUS.Item0407, "URZĄD SKARBOWY W CHEŁMNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0408, "URZĄD SKARBOWY W GRUDZIĄDZU"),
                new Tuple<TKodUS, string>(TKodUS.Item0409, "URZĄD SKARBOWY W INOWROCŁAWIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0410, "URZĄD SKARBOWY W LIPNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0411, "URZĄD SKARBOWY W MOGILNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0412, "URZĄD SKARBOWY W NAKLE NAD NOTECIĄ"),
                new Tuple<TKodUS, string>(TKodUS.Item0413, "URZĄD SKARBOWY W RADZIEJOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0414, "URZĄD SKARBOWY W RYPINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0415, "URZĄD SKARBOWY W ŚWIECIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0416, "PIERWSZY URZĄD SKARBOWY W TORUNIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0417, "DRUGI URZĄD SKARBOWY W TORUNIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0418, "URZĄD SKARBOWY W TUCHOLI"),
                new Tuple<TKodUS, string>(TKodUS.Item0419, "URZĄD SKARBOWY W WĄBRZEŹNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0420, "URZĄD SKARBOWY WE WŁOCŁAWKU"),
                new Tuple<TKodUS, string>(TKodUS.Item0421, "URZĄD SKARBOWY W ŻNINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0422, "URZĄD SKARBOWY W GOLUBIU-DOBRZYNIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0423, "URZĄD SKARBOWY W SĘPÓLNIE KRAJEŃSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0471, "KUJAWSKO-POMORSKI URZĄD SKARBOWY W BYDGOSZCZY"),
                new Tuple<TKodUS, string>(TKodUS.Item0602, "URZĄD SKARBOWY W BIAŁEJ PODLASKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item0603, "URZĄD SKARBOWY W BIŁGORAJU"),
                new Tuple<TKodUS, string>(TKodUS.Item0604, "URZĄD SKARBOWY W CHEŁMIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0605, "URZĄD SKARBOWY W HRUBIESZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0606, "URZĄD SKARBOWY W JANOWIE LUBELSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0607, "URZĄD SKARBOWY W KRASNYMSTAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0608, "URZĄD SKARBOWY W KRAŚNIKU"),
                new Tuple<TKodUS, string>(TKodUS.Item0609, "URZĄD SKARBOWY W LUBARTOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0610, "PIERWSZY URZĄD SKARBOWY W LUBLINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0611, "DRUGI URZĄD SKARBOWY W LUBLINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0612, "TRZECI URZĄD SKARBOWY W LUBLINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0613, "URZĄD SKARBOWY W ŁUKOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0614, "URZĄD SKARBOWY W OPOLU LUBELSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0615, "URZĄD SKARBOWY W PARCZEWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0616, "URZĄD SKARBOWY W PUŁAWACH"),
                new Tuple<TKodUS, string>(TKodUS.Item0617, "URZĄD SKARBOWY W RADZYNIU PODLASKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0618, "URZĄD SKARBOWY W TOMASZOWIE LUBELSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0619, "URZĄD SKARBOWY WE WŁODAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0620, "URZĄD SKARBOWY W ZAMOŚCIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0621, "URZĄD SKARBOWY W ŁĘCZNEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item0622, "URZĄD SKARBOWY W RYKACH"),
                new Tuple<TKodUS, string>(TKodUS.Item0671, "LUBELSKI URZĄD SKARBOWY W LUBLINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0802, "URZĄD SKARBOWY W GORZOWIE WIELKOPOLSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0803, "URZĄD SKARBOWY W KROŚNIE ODRZAŃSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item0804, "URZĄD SKARBOWY W MIĘDZYRZECZU"),
                new Tuple<TKodUS, string>(TKodUS.Item0805, "URZĄD SKARBOWY W NOWEJ SOLI"),
                new Tuple<TKodUS, string>(TKodUS.Item0806, "URZĄD SKARBOWY W SŁUBICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item0807, "URZĄD SKARBOWY W ŚWIEBODZINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0808, "PIERWSZY URZĄD SKARBOWY W ZIELONEJ GÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item0809, "DRUGI URZĄD SKARBOWY W ZIELONEJ GÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item0810, "URZĄD SKARBOWY W ŻAGANIU"),
                new Tuple<TKodUS, string>(TKodUS.Item0811, "URZĄD SKARBOWY W ŻARACH"),
                new Tuple<TKodUS, string>(TKodUS.Item0812, "URZĄD SKARBOWY W DREZDENKU"),
                new Tuple<TKodUS, string>(TKodUS.Item0813, "URZĄD SKARBOWY W SULĘCINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0814, "URZĄD SKARBOWY WE WSCHOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item0871, "LUBUSKI URZĄD SKARBOWY W ZIELONEJ GÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item1002, "URZĄD SKARBOWY W BEŁCHATOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1003, "URZĄD SKARBOWY W BRZEZINACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1004, "URZĄD SKARBOWY W GŁOWNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1005, "URZĄD SKARBOWY W KUTNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1006, "URZĄD SKARBOWY W ŁASKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1007, "URZĄD SKARBOWY W ŁOWICZU"),
                new Tuple<TKodUS, string>(TKodUS.Item1008, "PIERWSZY URZĄD SKARBOWY ŁÓDŹ-BAŁUTY"),
                new Tuple<TKodUS, string>(TKodUS.Item1009, "DRUGI URZĄD SKARBOWY ŁÓDŹ-BAŁUTY"),
                new Tuple<TKodUS, string>(TKodUS.Item1010, "PIERWSZY URZĄD SKARBOWY ŁÓDŹ-GÓRNA"),
                new Tuple<TKodUS, string>(TKodUS.Item1011, "DRUGI URZĄD SKARBOWY ŁÓDŹ-GÓRNA"),
                new Tuple<TKodUS, string>(TKodUS.Item1012, "URZĄD SKARBOWY ŁÓDŹ-POLESIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1013, "URZĄD SKARBOWY ŁÓDŹ-ŚRÓDMIEŚCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1014, "URZĄD SKARBOWY ŁÓDŹ-WIDZEW"),
                new Tuple<TKodUS, string>(TKodUS.Item1015, "URZĄD SKARBOWY W OPOCZNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1016, "URZĄD SKARBOWY W PABIANICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1017, "URZĄD SKARBOWY W PIOTRKOWIE TRYBUNALSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1018, "URZĄD SKARBOWY W PODDĘBICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1019, "URZĄD SKARBOWY W RADOMSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1020, "URZĄD SKARBOWY W RAWIE MAZOWIECKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item1021, "URZĄD SKARBOWY W SIERADZU"),
                new Tuple<TKodUS, string>(TKodUS.Item1022, "URZĄD SKARBOWY W SKIERNIEWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1023, "URZĄD SKARBOWY W TOMASZOWIE MAZOWIECKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1024, "URZĄD SKARBOWY W WIELUNIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1025, "URZĄD SKARBOWY W ZDUŃSKIEJ WOLI"),
                new Tuple<TKodUS, string>(TKodUS.Item1026, "URZĄD SKARBOWY W ZGIERZU"),
                new Tuple<TKodUS, string>(TKodUS.Item1027, "URZĄD SKARBOWY W WIERUSZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1028, "URZĄD SKARBOWY W ŁĘCZYCY"),
                new Tuple<TKodUS, string>(TKodUS.Item1029, "URZĄD SKARBOWY W PAJĘCZNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1071, "ŁÓDZKI URZĄD SKARBOWY W ŁODZI"),
                new Tuple<TKodUS, string>(TKodUS.Item1202, "URZĄD SKARBOWY W BOCHNI"),
                new Tuple<TKodUS, string>(TKodUS.Item1203, "URZĄD SKARBOWY W BRZESKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1204, "URZĄD SKARBOWY W CHRZANOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1205, "URZĄD SKARBOWY W DĄBROWIE TARNOWSKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item1206, "URZĄD SKARBOWY W GORLICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1207, "PIERWSZY URZĄD SKARBOWY KRAKÓW"),
                new Tuple<TKodUS, string>(TKodUS.Item1208, "URZĄD SKARBOWY KRAKÓW-KROWODRZA"),
                new Tuple<TKodUS, string>(TKodUS.Item1209, "URZĄD SKARBOWY KRAKÓW-NOWA HUTA"),
                new Tuple<TKodUS, string>(TKodUS.Item1210, "URZĄD SKARBOWY KRAKÓW-PODGÓRZE"),
                new Tuple<TKodUS, string>(TKodUS.Item1211, "URZĄD SKARBOWY KRAKÓW-PRĄDNIK"),
                new Tuple<TKodUS, string>(TKodUS.Item1212, "URZĄD SKARBOWY KRAKÓW-STARE MIASTO"),
                new Tuple<TKodUS, string>(TKodUS.Item1213, "URZĄD SKARBOWY KRAKÓW-ŚRÓDMIEŚCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1214, "URZĄD SKARBOWY W LIMANOWEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item1215, "URZĄD SKARBOWY W MIECHOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1216, "URZĄD SKARBOWY W MYŚLENICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1217, "URZĄD SKARBOWY W NOWYM SĄCZU"),
                new Tuple<TKodUS, string>(TKodUS.Item1218, "URZĄD SKARBOWY W NOWYM TARGU"),
                new Tuple<TKodUS, string>(TKodUS.Item1219, "URZĄD SKARBOWY W OLKUSZU"),
                new Tuple<TKodUS, string>(TKodUS.Item1220, "URZĄD SKARBOWY W OŚWIĘCIMIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1221, "URZĄD SKARBOWY W PROSZOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1222, "URZĄD SKARBOWY W SUCHEJ BESKIDZKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item1223, "PIERWSZY URZĄD SKARBOWY W TARNOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1224, "DRUGI URZĄD SKARBOWY W TARNOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1225, "URZĄD SKARBOWY W WADOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1226, "URZĄD SKARBOWY W WIELICZCE"),
                new Tuple<TKodUS, string>(TKodUS.Item1227, "URZĄD SKARBOWY W ZAKOPANEM"),
                new Tuple<TKodUS, string>(TKodUS.Item1228, "DRUGI URZĄD SKARBOWY KRAKÓW"),
                new Tuple<TKodUS, string>(TKodUS.Item1271, "MAŁOPOLSKI URZĄD SKARBOWY W KRAKOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1402, "URZĄD SKARBOWY W BIAŁOBRZEGACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1403, "URZĄD SKARBOWY W CIECHANOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1404, "URZĄD SKARBOWY W GARWOLINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1405, "URZĄD SKARBOWY W GOSTYNINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1406, "URZĄD SKARBOWY W GRODZISKU MAZOWIECKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1407, "URZĄD SKARBOWY W GRÓJCU"),
                new Tuple<TKodUS, string>(TKodUS.Item1408, "URZĄD SKARBOWY W KOZIENICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1409, "URZĄD SKARBOWY W LEGIONOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1410, "URZĄD SKARBOWY W ŁOSICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1411, "URZĄD SKARBOWY W MAKOWIE MAZOWIECKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1412, "URZĄD SKARBOWY W MIŃSKU MAZOWIECKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1413, "URZĄD SKARBOWY W MŁAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1414, "URZĄD SKARBOWY W NOWYM DWORZE MAZOWIECKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1415, "URZĄD SKARBOWY W OSTROŁĘCE"),
                new Tuple<TKodUS, string>(TKodUS.Item1416, "URZĄD SKARBOWY W OSTROWI MAZOWIECKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item1417, "URZĄD SKARBOWY W OTWOCKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1418, "URZĄD SKARBOWY W PIASECZNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1419, "URZĄD SKARBOWY W PŁOCKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1420, "URZĄD SKARBOWY W PŁOŃSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1421, "URZĄD SKARBOWY W PRUSZKOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1422, "URZĄD SKARBOWY W PRZASNYSZU"),
                new Tuple<TKodUS, string>(TKodUS.Item1423, "URZĄD SKARBOWY W PUŁTUSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1424, "PIERWSZY URZĄD SKARBOWY W RADOMIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1425, "DRUGI URZĄD SKARBOWY W RADOMIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1426, "URZĄD SKARBOWY W SIEDLCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1427, "URZĄD SKARBOWY W SIERPCU"),
                new Tuple<TKodUS, string>(TKodUS.Item1428, "URZĄD SKARBOWY W SOCHACZEWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1429, "URZĄD SKARBOWY W SOKOŁOWIE PODLASKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item1430, "URZĄD SKARBOWY W SZYDŁOWCU"),
                new Tuple<TKodUS, string>(TKodUS.Item1431, "URZĄD SKARBOWY WARSZAWA-BEMOWO"),
                new Tuple<TKodUS, string>(TKodUS.Item1432, "URZĄD SKARBOWY WARSZAWA-BIELANY"),
                new Tuple<TKodUS, string>(TKodUS.Item1433, "URZĄD SKARBOWY WARSZAWA-MOKOTÓW"),
                new Tuple<TKodUS, string>(TKodUS.Item1434, "URZĄD SKARBOWY WARSZAWA-PRAGA"),
                new Tuple<TKodUS, string>(TKodUS.Item1435, "PIERWSZY URZĄD SKARBOWY WARSZAWA-ŚRÓDMIEŚCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1436, "DRUGI URZĄD SKARBOWY WARSZAWA-ŚRÓDMIEŚCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1437, "URZĄD SKARBOWY WARSZAWA-TARGÓWEK"),
                new Tuple<TKodUS, string>(TKodUS.Item1438, "URZĄD SKARBOWY WARSZAWA-URSYNÓW"),
                new Tuple<TKodUS, string>(TKodUS.Item1439, "URZĄD SKARBOWY WARSZAWA-WAWER"),
                new Tuple<TKodUS, string>(TKodUS.Item1440, "URZĄD SKARBOWY WARSZAWA-WOLA"),
                new Tuple<TKodUS, string>(TKodUS.Item1441, "URZĄD SKARBOWY W WĘGROWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1442, "URZĄD SKARBOWY W WOŁOMINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1443, "URZĄD SKARBOWY W WYSZKOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1444, "URZĄD SKARBOWY W ZWOLENIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1445, "URZĄD SKARBOWY W ŻUROMINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1446, "URZĄD SKARBOWY W ŻYRARDOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1447, "URZĄD SKARBOWY W LIPSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1448, "URZĄD SKARBOWY W PRZYSUSZE"),
                new Tuple<TKodUS, string>(TKodUS.Item1449, "TRZECI URZĄD SKARBOWY WARSZAWA-ŚRÓDMIEŚCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1471, "PIERWSZY MAZOWIECKI URZĄD SKARBOWY W WARSZAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1472, "DRUGI MAZOWIECKI URZĄD SKARBOWY W WARSZAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1473, "TRZECI MAZOWIECKI URZĄD SKARBOWY W RADOMIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1602, "URZĄD SKARBOWY W BRZEGU"),
                new Tuple<TKodUS, string>(TKodUS.Item1603, "URZĄD SKARBOWY W GŁUBCZYCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1604, "URZĄD SKARBOWY W KĘDZIERZYNIE-KOŹLU"),
                new Tuple<TKodUS, string>(TKodUS.Item1605, "URZĄD SKARBOWY W KLUCZBORKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1606, "URZĄD SKARBOWY W NAMYSŁOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1607, "URZĄD SKARBOWY W NYSIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1608, "URZĄD SKARBOWY W OLEŚNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1609, "PIERWSZY URZĄD SKARBOWY W OPOLU"),
                new Tuple<TKodUS, string>(TKodUS.Item1610, "DRUGI URZĄD SKARBOWY W OPOLU"),
                new Tuple<TKodUS, string>(TKodUS.Item1611, "URZĄD SKARBOWY W PRUDNIKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1612, "URZĄD SKARBOWY W STRZELCACH OPOLSKICH"),
                new Tuple<TKodUS, string>(TKodUS.Item1613, "URZĄD SKARBOWY W KRAPKOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1671, "OPOLSKI URZĄD SKARBOWY W OPOLU"),
                new Tuple<TKodUS, string>(TKodUS.Item1802, "URZĄD SKARBOWY W BRZOZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1803, "URZĄD SKARBOWY W DĘBICY"),
                new Tuple<TKodUS, string>(TKodUS.Item1804, "URZĄD SKARBOWY W JAROSŁAWIU"),
                new Tuple<TKodUS, string>(TKodUS.Item1805, "URZĄD SKARBOWY W JAŚLE"),
                new Tuple<TKodUS, string>(TKodUS.Item1806, "URZĄD SKARBOWY W KOLBUSZOWEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item1807, "URZĄD SKARBOWY W KROŚNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1808, "URZĄD SKARBOWY W LESKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1809, "URZĄD SKARBOWY W LEŻAJSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1810, "URZĄD SKARBOWY W LUBACZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1811, "URZĄD SKARBOWY W ŁAŃCUCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1812, "URZĄD SKARBOWY W MIELCU"),
                new Tuple<TKodUS, string>(TKodUS.Item1813, "URZĄD SKARBOWY W PRZEMYŚLU"),
                new Tuple<TKodUS, string>(TKodUS.Item1814, "URZĄD SKARBOWY W PRZEWORSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1815, "URZĄD SKARBOWY W ROPCZYCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item1816, "PIERWSZY URZĄD SKARBOWY W RZESZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1817, "URZĄD SKARBOWY W SANOKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1818, "URZĄD SKARBOWY W STALOWEJ WOLI"),
                new Tuple<TKodUS, string>(TKodUS.Item1819, "URZĄD SKARBOWY W STRZYŻOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1820, "URZĄD SKARBOWY W TARNOBRZEGU"),
                new Tuple<TKodUS, string>(TKodUS.Item1821, "URZĄD SKARBOWY W USTRZYKACH DOLNYCH"),
                new Tuple<TKodUS, string>(TKodUS.Item1822, "DRUGI URZĄD SKARBOWY W RZESZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item1823, "URZĄD SKARBOWY W NISKU"),
                new Tuple<TKodUS, string>(TKodUS.Item1871, "PODKARPACKI URZĄD SKARBOWY W RZESZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2002, "URZĄD SKARBOWY W AUGUSTOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2003, "PIERWSZY URZĄD SKARBOWY W BIAŁYMSTOKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2004, "DRUGI URZĄD SKARBOWY W BIAŁYMSTOKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2005, "URZĄD SKARBOWY W BIELSKU PODLASKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item2006, "URZĄD SKARBOWY W GRAJEWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2007, "URZĄD SKARBOWY W KOLNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2008, "URZĄD SKARBOWY W ŁOMŻY"),
                new Tuple<TKodUS, string>(TKodUS.Item2009, "URZĄD SKARBOWY W MOŃKACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2010, "URZĄD SKARBOWY W SIEMIATYCZACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2011, "URZĄD SKARBOWY W SOKÓŁCE"),
                new Tuple<TKodUS, string>(TKodUS.Item2012, "URZĄD SKARBOWY W SUWAŁKACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2013, "URZĄD SKARBOWY W WYSOKIEM MAZOWIECKIEM"),
                new Tuple<TKodUS, string>(TKodUS.Item2014, "URZĄD SKARBOWY W ZAMBROWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2015, "URZĄD SKARBOWY W HAJNÓWCE"),
                new Tuple<TKodUS, string>(TKodUS.Item2071, "PODLASKI URZĄD SKARBOWY W BIAŁYMSTOKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2202, "URZĄD SKARBOWY W BYTOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2203, "URZĄD SKARBOWY W CHOJNICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2204, "URZĄD SKARBOWY W CZŁUCHOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2205, "PIERWSZY URZĄD SKARBOWY W GDAŃSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2206, "DRUGI URZĄD SKARBOWY W GDAŃSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2207, "TRZECI URZĄD SKARBOWY W GDAŃSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2208, "PIERWSZY URZĄD SKARBOWY W GDYNI"),
                new Tuple<TKodUS, string>(TKodUS.Item2209, "DRUGI URZĄD SKARBOWY W GDYNI"),
                new Tuple<TKodUS, string>(TKodUS.Item2210, "URZĄD SKARBOWY W KARTUZACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2211, "URZĄD SKARBOWY W KOŚCIERZYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2212, "URZĄD SKARBOWY W KWIDZYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2213, "URZĄD SKARBOWY W LĘBORKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2214, "URZĄD SKARBOWY W MALBORKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2215, "URZĄD SKARBOWY W PUCKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2216, "URZĄD SKARBOWY W SŁUPSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2217, "URZĄD SKARBOWY W SOPOCIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2218, "URZĄD SKARBOWY W STAROGARDZIE GDAŃSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item2219, "URZĄD SKARBOWY W TCZEWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2220, "URZĄD SKARBOWY W WEJHEROWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2221, "URZĄD SKARBOWY W PRUSZCZU GDAŃSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item2271, "POMORSKI URZĄD SKARBOWY W GDAŃSKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2402, "URZĄD SKARBOWY W BĘDZINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2403, "PIERWSZY URZĄD SKARBOWY W BIELSKU-BIAŁEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2404, "DRUGI URZĄD SKARBOWY W BIELSKU-BIAŁEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2405, "URZĄD SKARBOWY W BYTOMIU"),
                new Tuple<TKodUS, string>(TKodUS.Item2406, "URZĄD SKARBOWY W CHORZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2407, "URZĄD SKARBOWY W CIESZYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2408, "URZĄD SKARBOWY W CZECHOWICACH-DZIEDZICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2409, "PIERWSZY URZĄD SKARBOWY W CZĘSTOCHOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2410, "DRUGI URZĄD SKARBOWY W CZĘSTOCHOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2411, "URZĄD SKARBOWY W DĄBROWIE GÓRNICZEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2412, "PIERWSZY URZĄD SKARBOWY W GLIWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2413, "DRUGI URZĄD SKARBOWY W GLIWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2414, "URZĄD SKARBOWY W JASTRZĘBIU-ZDROJU"),
                new Tuple<TKodUS, string>(TKodUS.Item2415, "URZĄD SKARBOWY W JAWORZNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2416, "PIERWSZY URZĄD SKARBOWY W KATOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2417, "DRUGI URZĄD SKARBOWY W KATOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2418, "URZĄD SKARBOWY W KŁOBUCKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2419, "URZĄD SKARBOWY W LUBLIŃCU"),
                new Tuple<TKodUS, string>(TKodUS.Item2420, "URZĄD SKARBOWY W MIKOŁOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2421, "URZĄD SKARBOWY W MYSŁOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2422, "URZĄD SKARBOWY W MYSZKOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2423, "URZĄD SKARBOWY W PIEKARACH ŚLĄSKICH"),
                new Tuple<TKodUS, string>(TKodUS.Item2424, "URZĄD SKARBOWY W PSZCZYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2425, "URZĄD SKARBOWY W RACIBORZU"),
                new Tuple<TKodUS, string>(TKodUS.Item2426, "URZĄD SKARBOWY W RUDZIE ŚLĄSKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2427, "URZĄD SKARBOWY W RYBNIKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2428, "URZĄD SKARBOWY W SIEMIANOWICACH ŚLĄSKICH"),
                new Tuple<TKodUS, string>(TKodUS.Item2429, "URZĄD SKARBOWY W SOSNOWCU"),
                new Tuple<TKodUS, string>(TKodUS.Item2430, "URZĄD SKARBOWY W TARNOWSKICH GÓRACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2431, "URZĄD SKARBOWY W TYCHACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2432, "URZĄD SKARBOWY W WODZISŁAWIU ŚLĄSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item2433, "URZĄD SKARBOWY W ZABRZU"),
                new Tuple<TKodUS, string>(TKodUS.Item2434, "URZĄD SKARBOWY W ZAWIERCIU"),
                new Tuple<TKodUS, string>(TKodUS.Item2435, "URZĄD SKARBOWY W ŻORACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2436, "URZĄD SKARBOWY W ŻYWCU"),
                new Tuple<TKodUS, string>(TKodUS.Item2471, "PIERWSZY ŚLĄSKI URZĄD SKARBOWY W SOSNOWCU"),
                new Tuple<TKodUS, string>(TKodUS.Item2472, "DRUGI ŚLĄSKI URZĄD SKARBOWY W BIELSKU-BIAŁEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2602, "URZĄD SKARBOWY W BUSKU-ZDROJU"),
                new Tuple<TKodUS, string>(TKodUS.Item2603, "URZĄD SKARBOWY W JĘDRZEJOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2604, "PIERWSZY URZĄD SKARBOWY W KIELCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2605, "DRUGI URZĄD SKARBOWY W KIELCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2606, "URZĄD SKARBOWY W KOŃSKICH"),
                new Tuple<TKodUS, string>(TKodUS.Item2607, "URZĄD SKARBOWY W OPATOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2608, "URZĄD SKARBOWY W OSTROWCU ŚWIĘTOKRZYSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item2609, "URZĄD SKARBOWY W PIŃCZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2610, "URZĄD SKARBOWY W SANDOMIERZU"),
                new Tuple<TKodUS, string>(TKodUS.Item2611, "URZĄD SKARBOWY W SKARŻYSKU-KAMIENNEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2612, "URZĄD SKARBOWY W STARACHOWICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2613, "URZĄD SKARBOWY W STASZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2614, "URZĄD SKARBOWY W KAZIMIERZY WIELKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item2615, "URZĄD SKARBOWY WE WŁOSZCZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2671, "ŚWIĘTOKRZYSKI URZĄD SKARBOWY W KIELCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2802, "URZĄD SKARBOWY W BARTOSZYCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item2803, "URZĄD SKARBOWY W BRANIEWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2804, "URZĄD SKARBOWY W DZIAŁDOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2805, "URZĄD SKARBOWY W ELBLĄGU"),
                new Tuple<TKodUS, string>(TKodUS.Item2806, "URZĄD SKARBOWY W EŁKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2807, "URZĄD SKARBOWY W GIŻYCKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2808, "URZĄD SKARBOWY W IŁAWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2809, "URZĄD SKARBOWY W KĘTRZYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2810, "URZĄD SKARBOWY W NIDZICY"),
                new Tuple<TKodUS, string>(TKodUS.Item2811, "URZĄD SKARBOWY W NOWYM MIEŚCIE LUBAWSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item2812, "URZĄD SKARBOWY W OLECKU"),
                new Tuple<TKodUS, string>(TKodUS.Item2813, "URZĄD SKARBOWY W OLSZTYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2814, "URZĄD SKARBOWY W OSTRÓDZIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2815, "URZĄD SKARBOWY W PISZU"),
                new Tuple<TKodUS, string>(TKodUS.Item2816, "URZĄD SKARBOWY W SZCZYTNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item2871, "WARMIŃSKO-MAZURSKI URZĄD SKARBOWY W OLSZTYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3002, "URZĄD SKARBOWY W CZARNKOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3003, "URZĄD SKARBOWY W GNIEŹNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3004, "URZĄD SKARBOWY W GOSTYNIU"),
                new Tuple<TKodUS, string>(TKodUS.Item3005, "URZĄD SKARBOWY W GRODZISKU WIELKOPOLSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item3006, "URZĄD SKARBOWY W JAROCINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3007, "PIERWSZY URZĄD SKARBOWY W KALISZU"),
                new Tuple<TKodUS, string>(TKodUS.Item3008, "DRUGI URZĄD SKARBOWY W KALISZU"),
                new Tuple<TKodUS, string>(TKodUS.Item3009, "URZĄD SKARBOWY W KĘPNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3010, "URZĄD SKARBOWY W KOLE"),
                new Tuple<TKodUS, string>(TKodUS.Item3011, "URZĄD SKARBOWY W KONINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3012, "URZĄD SKARBOWY W KOŚCIANIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3013, "URZĄD SKARBOWY W KROTOSZYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3014, "URZĄD SKARBOWY W LESZNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3015, "URZĄD SKARBOWY W MIĘDZYCHODZIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3016, "URZĄD SKARBOWY W NOWYM TOMYŚLU"),
                new Tuple<TKodUS, string>(TKodUS.Item3017, "URZĄD SKARBOWY W OSTROWIE WIELKOPOLSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item3018, "URZĄD SKARBOWY W OSTRZESZOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3019, "URZĄD SKARBOWY W PILE"),
                new Tuple<TKodUS, string>(TKodUS.Item3020, "URZĄD SKARBOWY POZNAŃ-GRUNWALD"),
                new Tuple<TKodUS, string>(TKodUS.Item3021, "URZĄD SKARBOWY POZNAŃ-JEŻYCE"),
                new Tuple<TKodUS, string>(TKodUS.Item3022, "URZĄD SKARBOWY POZNAŃ-NOWE MIASTO"),
                new Tuple<TKodUS, string>(TKodUS.Item3023, "PIERWSZY URZĄD SKARBOWY W POZNANIU"),
                new Tuple<TKodUS, string>(TKodUS.Item3025, "URZĄD SKARBOWY POZNAŃ-WINOGRADY"),
                new Tuple<TKodUS, string>(TKodUS.Item3026, "URZĄD SKARBOWY POZNAŃ-WILDA"),
                new Tuple<TKodUS, string>(TKodUS.Item3027, "URZĄD SKARBOWY W RAWICZU"),
                new Tuple<TKodUS, string>(TKodUS.Item3028, "URZĄD SKARBOWY W SŁUPCY"),
                new Tuple<TKodUS, string>(TKodUS.Item3029, "URZĄD SKARBOWY W SZAMOTUŁACH"),
                new Tuple<TKodUS, string>(TKodUS.Item3030, "URZĄD SKARBOWY W ŚREMIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3031, "URZĄD SKARBOWY W ŚRODZIE WIELKOPOLSKIEJ"),
                new Tuple<TKodUS, string>(TKodUS.Item3032, "URZĄD SKARBOWY W TURKU"),
                new Tuple<TKodUS, string>(TKodUS.Item3033, "URZĄD SKARBOWY W WĄGROWCU"),
                new Tuple<TKodUS, string>(TKodUS.Item3034, "URZĄD SKARBOWY W WOLSZTYNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3035, "URZĄD SKARBOWY WE WRZEŚNI"),
                new Tuple<TKodUS, string>(TKodUS.Item3036, "URZĄD SKARBOWY W ZŁOTOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3037, "URZĄD SKARBOWY W CHODZIEŻY"),
                new Tuple<TKodUS, string>(TKodUS.Item3038, "URZĄD SKARBOWY W OBORNIKACH"),
                new Tuple<TKodUS, string>(TKodUS.Item3039, "URZĄD SKARBOWY W PLESZEWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3071, "PIERWSZY WIELKOPOLSKI URZĄD SKARBOWY W POZNANIU"),
                new Tuple<TKodUS, string>(TKodUS.Item3072, "DRUGI WIELKOPOLSKI URZĄD SKARBOWY W KALISZU"),
                new Tuple<TKodUS, string>(TKodUS.Item3202, "URZĄD SKARBOWY W BIAŁOGARDZIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3203, "URZĄD SKARBOWY W CHOSZCZNIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3204, "URZĄD SKARBOWY W DRAWSKU POMORSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item3205, "URZĄD SKARBOWY W GOLENIOWIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3206, "URZĄD SKARBOWY W GRYFICACH"),
                new Tuple<TKodUS, string>(TKodUS.Item3207, "URZĄD SKARBOWY W GRYFINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3208, "URZĄD SKARBOWY W KAMIENIU POMORSKIM"),
                new Tuple<TKodUS, string>(TKodUS.Item3209, "URZĄD SKARBOWY W KOŁOBRZEGU"),
                new Tuple<TKodUS, string>(TKodUS.Item3210, "PIERWSZY URZĄD SKARBOWY W KOSZALINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3211, "DRUGI URZĄD SKARBOWY W KOSZALINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3212, "URZĄD SKARBOWY W MYŚLIBORZU"),
                new Tuple<TKodUS, string>(TKodUS.Item3213, "URZĄD SKARBOWY W PYRZYCACH"),
                new Tuple<TKodUS, string>(TKodUS.Item3214, "URZĄD SKARBOWY W STARGARDZIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3215, "PIERWSZY URZĄD SKARBOWY W SZCZECINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3216, "DRUGI URZĄD SKARBOWY W SZCZECINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3217, "TRZECI URZĄD SKARBOWY W SZCZECINIE"),
                new Tuple<TKodUS, string>(TKodUS.Item3218, "URZĄD SKARBOWY W SZCZECINKU"),
                new Tuple<TKodUS, string>(TKodUS.Item3219, "URZĄD SKARBOWY W ŚWINOUJŚCIU"),
                new Tuple<TKodUS, string>(TKodUS.Item3220, "URZĄD SKARBOWY W WAŁCZU"),
                new Tuple<TKodUS, string>(TKodUS.Item3271, "ZACHODNIOPOMORSKI URZĄD SKARBOWY W SZCZECINIE")
            };

        public IEnumerable<sbyte> WariantFormularzaItemList => new List<sbyte>() {2};
    }
}