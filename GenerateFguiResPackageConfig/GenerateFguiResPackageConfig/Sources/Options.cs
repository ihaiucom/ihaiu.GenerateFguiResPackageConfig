using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CommandLine;

public class Options
{
    // 运行完，是否自动关闭cmd
    [Option("autoEnd", Required = false, Default = true)]
    public bool autoEnd { get; set; }

    // 启动参数设置 配置路径
    [Option("optionSetting", Required = false, Default = "./optionSetting.json")]
    public string optionSetting { get; set; }

    // 资源目录
    [Option("resPath", Required = false, Default = "./res")]
    public string resPath { get; set; }

    // 包名后缀
    [Option("packageFileExtension", Required = false, Default = ".bin")]
    public string packageFileExtension { get; set; }

    

    // 模板目录
    [Option("templateDir", Required = false, Default = "../GenerateFguiResPackageConfig/GenerateFguiResPackageConfig/Template")]
    public string templateDir { get; set; }


    // 代码--代码保存路径
    [Option("codePath", Required = false, Default = "./FairyGUICode")]
    public string codePath { get; set; }


    // 代码--代码类名
    [Option("codeClass", Required = false, Default = "GuiResPackageConfigReader")]
    public string codeClass { get; set; }




    public void Save(string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "./optionSetting.json";

        string json = JsonHelper.ToJsonType(this);
        File.WriteAllText(path, json);
    }

    public static Options Load(string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "./optionSetting.json";

        string json = File.ReadAllText(path);
        Options options = JsonHelper.FromJson<Options>(json);
        return options;
    }
}