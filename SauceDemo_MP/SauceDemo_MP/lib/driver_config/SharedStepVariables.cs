using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo_MP.lib.driver_config
{
    public class SharedStepVariables
    {
        public SD_Website<ChromeDriver> SD_Website { get; set; } = new SD_Website<ChromeDriver>();
    }
}
