using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.Forms.IStore
{
    public class ISData
    {
        [JsonProperty("data")]
        public List<ISOrders> data { get; set; }
    }
    public class ISOrders
    {
        [JsonProperty("Order")]
        public Orders Order { get; set; }

        [JsonProperty("Status")]
        public ListStatus Status { get; set; }

        //[JsonProperty("Delivery")]
        //public List<ListDelivery> Delivery { get; set; }

        //[JsonProperty("Payment")]
        //public List<ListPayment> Payment { get; set; }

        //[JsonProperty("Discount")]
        //public List<ListDiscount> Discount { get; set; }

        //[JsonProperty("Product")]
        //public List<ListProduct> Product { get; set; }

    }

    public class Orders
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("active")]
        public string active { get; set; }

        [JsonProperty("number")]
        public string number { get; set; }

        [JsonProperty("price")]
        public string price { get; set; }

        [JsonProperty("payment_id")]
        public int payment_id { get; set; }

        [JsonProperty("is_payed")]
        public int is_payed { get; set; }

        [JsonProperty("created")]
        public string created { get; set; }

        [JsonProperty("modified")]
        public string modified { get; set; }

        [JsonProperty("user_fullname")]
        public string user_fullname { get; set; }

        [JsonProperty("user_address")]
        public string user_address { get; set; }

        [JsonProperty("user_index")]
        public string user_index { get; set; }

        [JsonProperty("user_city")]
        public string user_city { get; set; }

        [JsonProperty("user_region")]
        public string user_region { get; set; }

        [JsonProperty("comment")]
        public string comment { get; set; }

        [JsonProperty("user_phone")]
        public string user_phone { get; set; }



    }

    [JsonObject]
    public class ListStatus
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("alias")]
        public string alias { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("color")]
        public string color { get; set; }
    }
    public class ListDelivery
    {
        [JsonProperty("id")]
        public string id { get; set; }
    }
    public class ListPayment
    {
        [JsonProperty("id")]
        public string id { get; set; }
    }
    public class ListDiscount
    {
        [JsonProperty("id")]
        public string id { get; set; }
    }
    public class ListProduct
    {
        [JsonProperty("id")]
        public string id { get; set; }
    }

}
