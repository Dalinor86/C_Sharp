using Models.AbstractClasses;
using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class Library
    {

      private static Library instance;

      private Library() { }
      
      public static Library GetInstance()
      {
        return instance ?? (instance = new Library());
      }

      public List<LibResource> Resources { get; set; }
    }
}
