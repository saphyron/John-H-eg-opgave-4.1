using John_Høeg_opgave_4._1.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace John_Høeg_opgave_4._1.Controllers
{
    public class ConvertController
    {
        public void convertTxtFile()
        {
            var filename = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\A370715.txt";
            var lines = File.ReadLines(filename);
            var class001File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class001File.json";
            var class002File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class002File.json";
            var class003File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class003File.json";
            var class004File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class004File.json";
            var class005File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class005File.json";
            var class006File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class006File.json";
            var class007File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class007File.json";
            var class008File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class008File.json";
            var class009File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class009File.json";
            var class010File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class010File.json";
            var class011File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class011File.json";
            var class012File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class012File.json";
            var class013File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class013File.json";
            var class014File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class014File.json";
            var class015File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class015File.json";
            var class016File = "C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\class016File.json";
            string jsonString = "";
            if (!File.Exists(class001File))
            {
                List<object> list1 = new List<object>();
                List<object> list2 = new List<object>();
                List<object> list3 = new List<object>();
                List<object> list4 = new List<object>();
                List<object> list5 = new List<object>();
                List<object> list6 = new List<object>();
                List<object> list7 = new List<object>();
                List<object> list8 = new List<object>();
                List<object> list9 = new List<object>();
                List<object> list10 = new List<object>();
                List<object> list11 = new List<object>();
                List<object> list12 = new List<object>();
                List<object> list13 = new List<object>();
                List<object> list14 = new List<object>();
                List<object> list15 = new List<object>();
                List<object> list16 = new List<object>();

                foreach (var line in lines)
                {
                    var code = line.Substring(0, 3);
                    switch (code)
                    {
                        case "001":
                            Class001 c001 = new Class001(line);
                            list1.Add(c001);
                            System.Console.WriteLine("File added.");
                            break;
                        case "002":
                            Class002 c002 = new Class002(line);
                            list2.Add(c002);
                            System.Console.WriteLine("File added.");
                            break;
                        case "003":
                            Class003 c003 = new Class003(line);
                            list3.Add(c003);
                            System.Console.WriteLine("File added.");
                            break;
                        case "004":
                            Class004 c004 = new Class004(line);
                            list4.Add(c004);
                            System.Console.WriteLine("File added.");
                            break;
                        case "005":
                            Class005 c005 = new Class005(line);
                            list5.Add(c005);
                            System.Console.WriteLine("File added.");
                            break;
                        case "006":
                            Class006 c006 = new Class006(line);
                            list6.Add(c006);
                            System.Console.WriteLine("File added.");
                            break;
                        case "007":
                            Class007 c007 = new Class007(line);
                            list7.Add(c007);
                            System.Console.WriteLine("File added.");
                            break;
                        case "008":
                            Class008 c008 = new Class008(line);
                            list8.Add(c008);
                            System.Console.WriteLine("File added.");
                            break;
                        case "009":
                            Class009 c009 = new Class009(line);
                            list9.Add(c009);
                            System.Console.WriteLine("File added.");
                            break;
                        case "010":
                            Class010 c010 = new Class010(line);
                            list10.Add(c010);
                            System.Console.WriteLine("File added.");
                            break;
                        case "011":
                            Class011 c011 = new Class011(line);
                            list11.Add(c011);
                            System.Console.WriteLine("File added.");
                            break;
                        case "012":
                            Class012 c012 = new Class012(line);
                            list12.Add(c012);
                            System.Console.WriteLine("File added.");
                            break;
                        case "013":
                            Class013 c013 = new Class013(line);
                            list13.Add(c013);
                            System.Console.WriteLine("File added.");
                            break;
                        case "014":
                            Class014 c014 = new Class014(line);
                            list14.Add(c014);
                            System.Console.WriteLine("File added.");
                            break;
                        case "015":
                            Class015 c015 = new Class015(line);
                            list15.Add(c015);
                            System.Console.WriteLine("File added.");
                            break;
                        case "016":
                            Class016 c016 = new Class016(line);
                            list16.Add(c016);
                            System.Console.WriteLine("File added.");
                            break;
                        default:
                            System.Console.WriteLine($"What to do with code: {code} ?");
                            break;
                    }
                }
                //Class 001
                string jsonString1 = JsonSerializer.Serialize(list1, new JsonSerializerOptions { WriteIndented = true });
                jsonString1 = jsonString1.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class001File, jsonString1);
                //Class 002
                string jsonString2 = JsonSerializer.Serialize(list2, new JsonSerializerOptions { WriteIndented = true });
                jsonString2 = jsonString2.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class002File, jsonString2);
                //Class 003
                string jsonString3 = JsonSerializer.Serialize(list3, new JsonSerializerOptions { WriteIndented = true });
                jsonString3 = jsonString3.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class003File, jsonString3);
                //Class 004
                string jsonString4 = JsonSerializer.Serialize(list4, new JsonSerializerOptions { WriteIndented = true });
                jsonString4 = jsonString4.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class004File, jsonString4);
                //Class 005
                string jsonString5 = JsonSerializer.Serialize(list5, new JsonSerializerOptions { WriteIndented = true });
                jsonString5 = jsonString5.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class005File, jsonString5);
                //Class 006
                string jsonString6 = JsonSerializer.Serialize(list6, new JsonSerializerOptions { WriteIndented = true });
                jsonString6 = jsonString6.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class006File, jsonString6);
                //Class 007
                string jsonString7 = JsonSerializer.Serialize(list7, new JsonSerializerOptions { WriteIndented = true });
                jsonString7 = jsonString7.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class007File, jsonString7);
                //Class 008
                string jsonString8 = JsonSerializer.Serialize(list8, new JsonSerializerOptions { WriteIndented = true });
                jsonString8 = jsonString8.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class008File, jsonString8);
                //Class 009
                string jsonString9 = JsonSerializer.Serialize(list9, new JsonSerializerOptions { WriteIndented = true });
                jsonString9 = jsonString9.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class009File, jsonString9);
                //Class 010
                string jsonString10 = JsonSerializer.Serialize(list10, new JsonSerializerOptions { WriteIndented = true });
                jsonString10 = jsonString10.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class010File, jsonString10);
                //Class 011
                string jsonString11 = JsonSerializer.Serialize(list11, new JsonSerializerOptions { WriteIndented = true });
                jsonString11 = jsonString11.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class011File, jsonString11);
                //Class 012
                string jsonString12 = JsonSerializer.Serialize(list12, new JsonSerializerOptions { WriteIndented = true });
                jsonString12 = jsonString12.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class012File, jsonString12);
                //Class 013
                string jsonString13 = JsonSerializer.Serialize(list13, new JsonSerializerOptions { WriteIndented = true });
                jsonString13 = jsonString13.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class013File, jsonString13);
                //Class 014
                string jsonString14 = JsonSerializer.Serialize(list14, new JsonSerializerOptions { WriteIndented = true });
                jsonString14 = jsonString14.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class014File, jsonString14);
                //Class 015
                string jsonString15 = JsonSerializer.Serialize(list15, new JsonSerializerOptions { WriteIndented = true });
                jsonString15 = jsonString15.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class015File, jsonString15);
                //Class 016
                string jsonString16 = JsonSerializer.Serialize(list16, new JsonSerializerOptions { WriteIndented = true });
                jsonString16 = jsonString16.TrimEnd(',', '\r', '\n');
                File.WriteAllText(class016File, jsonString16);

                System.Console.WriteLine("Convert is finished");



            }
            else { System.Console.WriteLine("File already exist please remove file before creating a new one!"); }
        }
    }
}
