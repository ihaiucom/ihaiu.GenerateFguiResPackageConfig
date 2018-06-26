using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


public class Package
{
    public string packagename;
    public string resBin;
    public List<string> resAtlas = new List<string>();

    public string ToConfigCode()
    {
        string tab = "            ";
        StringWriter sw = new StringWriter();
        sw.WriteLine( "config = new GuiResPackageConfig();");
        sw.WriteLine(tab + $"config.packageName = \"{packagename}\";");
        sw.WriteLine(tab + $"config.resBin = \"{resBin}\";");

        foreach(string path in resAtlas)
        {
            sw.WriteLine(tab + $"config.resAtlas.push(\"{path}\");");
        }

        sw.WriteLine(tab + "this.addconfig(config)");
        sw.WriteLine("\n\n");

        return sw.ToString();
    }
}