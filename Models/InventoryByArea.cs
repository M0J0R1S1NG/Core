using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class InventoryByArea
    {
       public InventoryByArea()
        {
                
        }
        public int InventoryId {get;set;}
         public string Label {get;set;}
          public string DeliveryAreaName {get;set;}
          public int ID {get;set;}
          public double Quantity {get;set;}
          public double Price {get;set;}
          public string ImageFilePath {get;set;}
          public string InventoryDescription {get;set;}
          public string InventoryGroupId {get;set;}
           public string InventoryCatagory {get;set;}
           public int DeliveryAreaPartner {get;set;}
           public int DeliveryAreaID{get;set;}
           public string Name {get;set;}



    }
}