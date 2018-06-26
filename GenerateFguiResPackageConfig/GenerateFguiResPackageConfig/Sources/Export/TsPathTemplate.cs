using System;
using System.Collections.Generic;
using System.Text;

public class TsPathTemplate
{
    public static string GuiResPackageConfigReader
    {
        get
        {
            return Setting.Options.templateDir + "/TS/GuiResPackageConfigReader.txt";
        }
    }
}