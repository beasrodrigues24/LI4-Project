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
    }
}
