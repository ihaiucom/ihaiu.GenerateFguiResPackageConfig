using System;
using System.Collections.Generic;
using System.Text;


public static class TsPathOut
{
    public static string GuiResPackageConfigReader
    {
        get
        {
            return $"{Setting.Options.codePath}/{Setting.Options.codeClass}.ts";
        }
    }

}