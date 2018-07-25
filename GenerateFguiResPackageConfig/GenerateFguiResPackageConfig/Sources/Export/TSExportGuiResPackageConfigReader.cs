using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class TSExportGuiResPackageConfigReader
{


    public static List<Package> Read()
    {
        string packageFileExtension = Setting.Options.packageFileExtension.ToLower();
        Dictionary<string, Package> dict = new Dictionary<string, Package>();
        string[] files = Directory.GetFiles(Setting.Options.resPath, "*" + Setting.Options.packageFileExtension);
        string dirname = Path.GetFileName(Setting.Options.resPath);
        foreach(string file in files)
        {
            string name = Path.GetFileName(file);
            Package pkg = new Package();
            pkg.dirname = dirname;
            pkg.resBin = name;
            pkg.packagename = Path.GetFileNameWithoutExtension(name);
            dict.Add(pkg.packagename, pkg);
        }

        files = Directory.GetFiles(Setting.Options.resPath);
        Dictionary<string, bool> soundExts = new Dictionary<string, bool>();
        foreach(var ext in Setting.Options.soundExts)
        {
            soundExts.Add(ext, true);
        }
        foreach (string file in files)
        {
            string name = Path.GetFileName(file);

            if (name.IndexOf("@atlas") != -1)
            {
                string packagename = name.Substring(0, name.IndexOf("@atlas"));
                if (dict.ContainsKey(packagename))
                {
                    Package pkg = dict[packagename];
                    pkg.resAtlas.Add(name);
                }
            }
            else if(soundExts.ContainsKey(Path.GetExtension(name)))
            {
                string packagename = name.Substring(0, name.IndexOf("@"));
                if (dict.ContainsKey(packagename))
                {
                    Package pkg = dict[packagename];
                    pkg.sounds.Add(name);
                }
            }

        }

        List<Package> list = new List<Package>(dict.Values);
        
        return list;
    }

    public static void Export()
    {
        List<Package> pkgList = Read();

        List<object[]> list = new List<object[]>();

        foreach(Package pkg in pkgList)
        {
            list.Add(new object[] { pkg.ToConfigCode()  });
        }
       


        TemplateSystem template = new TemplateSystem(File.ReadAllText(TsPathTemplate.GuiResPackageConfigReader));
        template.AddVariable("classname", Setting.Options.codeClass);
        template.AddVariable("list", list.ToArray());
        string content = template.Parse();
        string path = TsPathOut.GuiResPackageConfigReader;

        PathHelper.CheckPath(path);
        File.WriteAllText(path, content);
    }
}