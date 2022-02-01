using System;

namespace Geres4U.Data.DataModels
{
    public class CategoryDataModel
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public CategoryDataModel(int id)
        {
            ID = id;
            Name = "";
        }

        public CategoryDataModel(Int32 ID, String Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
