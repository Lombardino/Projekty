using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument FMBXMLDokument = new XmlDocument();

            XmlDocument FMBXMLTowar;

            XmlElement FMBXMLLevel0;
            XmlElement FMBXMLLevel1;
            XmlElement FMBXMLLevel2;
            XmlElement FMBXMLLevel3;
            XmlElement FMBLevel4;
            XmlElement FMBLevel5;
            XmlElement FMBLevel6;
            XmlText FMBText;

            //FMBXMLDokument.InsertBefore(FMBXMLDokument.CreateXmlDeclaration("1.0", "UTF-8", null), FMBXMLDokument.DocumentElement);

            FMBXMLTowar = new XmlDocument();

            //FMBXMLTowar.CreateXmlDeclaration("1.0", "Unicode", null);
            FMBXMLTowar.CreateElement("ROOT", "http://www.stigo.com.pl");
            FMBXMLTowar.InsertBefore(FMBXMLTowar.CreateXmlDeclaration("ROOT", "http://www.stigo.com.pl", null), FMBXMLTowar.DocumentElement);



            FMBXMLLevel0 = FMBXMLTowar.CreateElement("Dokument");
            FMBXMLTowar.AppendChild(FMBXMLLevel0);

            FMBXMLLevel1 = FMBXMLTowar.CreateElement("Naglowek");
            FMBXMLLevel0.AppendChild(FMBXMLLevel1);

            FMBXMLLevel2 = FMBXMLTowar.CreateElement("Nazwa");
            FMBXMLLevel2.AppendChild(FMBXMLTowar.CreateTextNode("NAZWATOWARU"));
            FMBXMLLevel1.AppendChild(FMBXMLLevel2);

            /*
            FMBXMLDokument.CreateElement("ROOT", "http://www.stigo.com.pl");
            
            FMBLevel0 = FMBXMLDokument.CreateElement("Osobowy");
            FMBXMLDokument.AppendChild(FMBLevel0);

            FMBLevel2 = FMBXMLDokument.CreateElement("Opel");
            FMBLevel0.AppendChild(FMBLevel2);

            FMBLevel3 = FMBXMLDokument.CreateElement("Astra");
            FMBLevel2.AppendChild(FMBLevel3);

            FMBLevel4 = FMBXMLDokument.CreateElement("Kolor", "Lala");
            FMBText = FMBXMLDokument.CreateTextNode("Czerwony");
            FMBLevel4.AppendChild(FMBText);
            FMBLevel3.AppendChild(FMBLevel4);

            FMBLevel4 = FMBXMLDokument.CreateElement("Pojemnosc");
            FMBText = FMBXMLDokument.CreateTextNode("6_litrow");
            FMBLevel4.AppendChild(FMBText);
            FMBLevel3.AppendChild(FMBLevel4);

            FMBLevel4 = FMBXMLDokument.CreateElement("","StringRoota","");
            FMBLevel3.AppendChild(FMBLevel4);

            //XmlElement ModelPojemnosc = FMBXMLDokument.CreateElement("Pojemnosc");
            //XmlText ModelPojemnoscText = FMBXMLDokument.CreateTextNode("2.0 16V");
            //ModelPojemnosc.AppendChild(ModelPojemnoscText);
            //Model.AppendChild(ModelPojemnosc);

            //Model = FMBXMLDokument.CreateElement("Corsa");
            //Marka.AppendChild(Model);

            //ModelKolor = FMBXMLDokument.CreateElement("Kolor");
            //ModelKolorText = FMBXMLDokument.CreateTextNode("Zielona");
            //ModelKolor.AppendChild(ModelKolorText);
            //Model.AppendChild(ModelKolor);

            //ModelPojemnosc = FMBXMLDokument.CreateElement("Pojemnosc");
            //ModelPojemnoscText = FMBXMLDokument.CreateTextNode("1.4 8V");
            //ModelPojemnosc.AppendChild(ModelPojemnoscText);
            //Model.AppendChild(ModelPojemnosc);

            //Model = FMBXMLDokument.CreateElement("Vectra");
            //Marka.AppendChild(Model);

            //Model = FMBXMLDokument.CreateElement("Vectra_3");
            //Marka.AppendChild(Model);

            /*
                    XmlElement element2 = doc.CreateElement("level1");
                    element1.AppendChild(element2);

                    XmlElement element3 = doc.CreateElement("level2");
                    XmlText text1 = doc.CreateTextNode("text");
                    element3.AppendChild(text1);
                    element2.AppendChild(element3);

                    XmlElement element4 = doc.CreateElement("level2");
                    XmlText text2 = doc.CreateTextNode("other text");
                    element4.AppendChild(text2);
                    element2.AppendChild(element4); //*/

            FMBXMLTowar.Save("D:\\document.xml");

        }
    }
}
