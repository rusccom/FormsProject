using System;

namespace FormsProject.BaseSelection
{
    [Serializable()]
    public struct DataBaseInfo
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public string Password { get; set; }
        public string DataBase { get; set; }
    }
}
