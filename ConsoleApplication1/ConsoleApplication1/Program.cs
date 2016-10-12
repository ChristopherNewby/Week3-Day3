using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ChrisProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = "C:\\temp\\Numbers.txt";

            //StreamWriter sw = new StreamWriter(fileName, false);

            //for (int i = 0; i < 101; i++)
            //{
            //    sw.WriteLine(string.Format("The number is {0}", i));
            //}
            //sw.Close();


            //List<Num> Numbers = new List<Num>();

            //StreamReader sr = new StreamReader(fileName);

            //if (File.Exists(fileName))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string temp = sr.ReadLine();
            //        string[] values = temp.Split('\n');

            //        Num newNum = new Num();
            //        newNum.Number = values[0];
            //        Numbers.Add(newNum);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            //foreach (Num c in Numbers)
            //{
            //    Console.WriteLine("{0}", c.Number);
            //}

            //Console.ReadLine();


            List<PLANT> PlantStore = new List<PLANT>();

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\temp\\plant_catalog.xml");

            XmlNode catNode = doc.DocumentElement.SelectSingleNode("/CATALOG");

            foreach (XmlNode child in catNode.ChildNodes)
            {
                PLANT plant = new PLANT();
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    switch (grandChild.Name)
                    {
                        case "COMMON":
                            {
                                plant.COMMON = grandChild.InnerText;
                                break;
                            }
                        case "BOTANICAL":
                            {
                                plant.BOTANICAL = grandChild.InnerText;
                                break;
                            }
                        case "ZONE":
                            {
                                plant.ZONE = grandChild.InnerText;
                                break;
                            }
                        case "LIGHT":
                            {
                                plant.LIGHT = grandChild.InnerText;
                                break;
                            }
                        case "PRICE":
                            {
                                plant.PRICE = grandChild.InnerText;
                                break;
                            }
                        case "AVAILABILITY":
                            {
                                plant.AVAILABILITY = grandChild.InnerText;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                PlantStore.Add(plant);
            }
                               
            for (int i = 0; i < PlantStore.Count ; i++)
            {
                
                Console.WriteLine(string.Format("Plant - {0} ", PlantStore[i].COMMON));
                Console.WriteLine(string.Format("------------------")," ");
                Console.WriteLine(string.Format("Plant Type - {0}", PlantStore[i].BOTANICAL));
                Console.WriteLine(string.Format("Zone - {0} ", PlantStore[i].ZONE));
                Console.WriteLine(string.Format("Light - {0} ", PlantStore[i].LIGHT));
                Console.WriteLine(string.Format("Price - {0} ", PlantStore[i].PRICE));
                Console.WriteLine(string.Format("Availability - {0} ", PlantStore[i].AVAILABILITY));
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
        
    }
}



