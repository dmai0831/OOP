using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    //when buiding the base class. We have 2 choices to use: Abtract or Concrete?
    //Abstract class cannot be instantiated. Meaning you cannot use the keyword "new" to create it.
    //Concreate can be instantiated. Meaning you can use the new keyword to create one.
    public abstract class EntityBase
    {
        //public: any class can access this property
        //private: accessible only in the class which the property is reside.
        //protected: the base class and all the derived class can access this property
        public bool IsNew { get; set; }

        public bool HasChanges { get; set; }

        public EntityStateOption EntityState { get; set; }

        public bool IsValid {
            get
            {
                return Validate();
            }
        }

        //Virtual keyword: Use this keyword if we want the option for the method to be overriden. When using virtual the medthod has its own implementation but allow the derived class to override it.
        //Abstract keyword: Use this keyword if the method must be overriden. The medthod doesn't have its own implementation so the derive class must imlement it.
        public abstract bool Validate();
    }
}
