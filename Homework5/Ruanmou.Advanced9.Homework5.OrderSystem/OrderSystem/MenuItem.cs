using Newtonsoft.Json;

namespace Ruanmou.Advanced9.Homework5.OrderSystem
{
    [JsonObject]
    public class MenuItem
    {
        /// <summary>
        /// 这个菜单项对应的菜的类的全名。用于反射创建对象。
        /// </summary>
        [JsonProperty("fullTypeName")]
        public string FullTypeName
        {
            get;
            set;
        }

        /// <summary>
        /// 菜的编号
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 菜的名称
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 价钱
        /// </summary>
        [JsonProperty("price")]
        public decimal Price
        {
            get;
            set;
        }
    }
}