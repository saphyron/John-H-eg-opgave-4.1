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
            string jsonString = "";
            if (!File.Exists("C:\\Users\\Saphy\\OneDrive\\Softwareudvikling\\SystemIntegration\\John Høeg opgave 4.1\\path.json"))
            {
            TextWriter tsw = new StreamWriter(@"C:\Users\Saphy\OneDrive\Softwareudvikling\SystemIntegration\John Høeg opgave 4.1\path.json", true);
            foreach (var line in lines)
            {
                var code = line.Substring(0, 3);
                switch (code)
                {
                    case "001":
                        Class001 c001 = new Class001(line);
                        jsonString = JsonSerializer.Serialize(c001);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "002":
                        Class002 c002 = new Class002(line);
                        jsonString = JsonSerializer.Serialize(c002);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "003":
                        Class003 c003 = new Class003(line);
                        jsonString = JsonSerializer.Serialize(c003);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "004":
                        Class004 c004 = new Class004(line);
                        jsonString = JsonSerializer.Serialize(c004);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "005":
                        Class005 c005 = new Class005(line);
                        jsonString = JsonSerializer.Serialize(c005);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "006":
                        Class006 c006 = new Class006(line);
                        jsonString = JsonSerializer.Serialize(c006);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "007":
                        Class007 c007 = new Class007(line);
                        jsonString = JsonSerializer.Serialize(c007);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "008":
                        Class008 c008 = new Class008(line);
                        jsonString = JsonSerializer.Serialize(c008);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "009":
                        Class009 c009 = new Class009(line);
                        jsonString = JsonSerializer.Serialize(c009);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "010":
                        Class010 c010 = new Class010(line);
                        jsonString = JsonSerializer.Serialize(c010);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "011":
                        Class011 c011 = new Class011(line);
                        jsonString = JsonSerializer.Serialize(c011);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "012":
                        Class012 c012 = new Class012(line);
                        jsonString = JsonSerializer.Serialize(c012);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "013":
                        Class013 c013 = new Class013(line);
                        jsonString = JsonSerializer.Serialize(c013);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "014":
                        Class014 c014 = new Class014(line);
                        jsonString = JsonSerializer.Serialize(c014);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "015":
                        Class015 c015 = new Class015(line);
                        jsonString = JsonSerializer.Serialize(c015);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    case "016":
                        Class016 c016 = new Class016(line);
                        jsonString = JsonSerializer.Serialize(c016);
                        tsw.WriteLine(jsonString);
                        System.Console.WriteLine(jsonString);
                        break;
                    default:
                        System.Console.WriteLine($"What to do with code: {code} ?");
                        break;
                }
            }
            System.Console.WriteLine("Convert is finished");
            } else { System.Console.WriteLine("File already exist please remove file before creating a new one!"); }
        }  
    }
}
