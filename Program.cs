using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CreateSvgFile
{
    public static void Main()
    {

        string path = @"c:\temp\picture.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>Stadium</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='1500' height='700'>";
        svg += "<rect x=200 y=100 width='700' height='300' fill='rgb(189,186,171)' />\n";
        for (int i = 0; i < 7; i++)
        {
            String xs = (i * 100 + 220).ToString();
            svg += "<rect x='" + xs + "' y='100' width='50' height='300' fill='rgb(109,132,140)' />\n";
        };
        svg += "<ellipse cx='550' cy='100' rx='350' ry='100' fill='rgb(180,170,145)' stroke='black' stroke-width='4'/>\n";
        svg += "<ellipse cx='550' cy='100' rx='315' ry='90' fill='rgb(255,128,0)'/>\n";
        svg += "<ellipse cx='550' cy='100' rx='252' ry='72' fill='rgb(0,128,0)'/>\n";
        svg += "</svg>";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
    }
}
              