using Microsoft.Extensions.Configuration;

namespace Ruanmou.Advanced9.Homework5.OrderSystem
{
    public class Menu
    {
        private static readonly object ForLock = new object();

        private static Menu _instance;

        private IConfiguration _configuration;

        private Menu()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("menu.json");
            var configuration = configurationBuilder.Build();
            _configuration = configuration;
        }

        public static Menu Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (ForLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Menu();
                        }
                    }
                }
                return _instance;
            }
        }

        public MenuItem[] Items
        {
            get
            {
                return _configuration.GetSection("items").Get<MenuItem[]>();
            }
        }
    }
}