/////////////////////////////////////
// ihaiu.GenerateFguiResPackageConfig生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
    // =====================
    // fgui包资源配置列表
    // ---------------------
    export class GuiResPackageConfigReader
    {
        // 字典
        dict:Dictionary<string, GuiResPackageConfig> = new Dictionary<string, GuiResPackageConfig>();

        // 添加配置
        addconfig(config: GuiResPackageConfig)
        {
            this.dict.add(config.packageName, config);
        }

        // 获取配置
        getconfig(packageName: string)
        {
            return this.dict.getValue(packageName);
        }



        // 初始化
        install()
        {
            let config:GuiResPackageConfig;

			
			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "BlackSkin";
            config.resBin = "BlackSkin.bin";
            config.resAtlas.push("BlackSkin@atlas0.png");
            this.addconfig(config)




			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "Building";
            config.resBin = "Building.bin";
            config.resAtlas.push("Building@atlas0.png");
            this.addconfig(config)




			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "Fx";
            config.resBin = "Fx.bin";
            this.addconfig(config)




			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "Login";
            config.resBin = "Login.bin";
            config.resAtlas.push("Login@atlas0.png");
            config.resAtlas.push("Login@atlas0_1.png");
            this.addconfig(config)




			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "Main";
            config.resBin = "Main.bin";
            config.resAtlas.push("Main@atlas0.png");
            this.addconfig(config)




			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "PfSkin";
            config.resBin = "PfSkin.bin";
            this.addconfig(config)




			config = new GuiResPackageConfig();
            config.resDir = "res";
            config.packageName = "System";
            config.resBin = "System.bin";
            config.resAtlas.push("System@atlas0.png");
            this.addconfig(config)





        }
    }
}
