using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    internal class ItemsAndAmount
    {
        string TypeName;
        string Item;
        int Amount;
        public ItemsAndAmount() { }
        public ItemsAndAmount(string typeName,string item, int amount)
        {
            TypeName = typeName;
            Item = item;
            Amount = amount;
        }
        public int GetAmount() { return Amount; }
        public void SetAmount(int amount) { Amount = Amount - amount; }
        public string GetTypeName() { return TypeName; }
        public string GetItem() { return Item; }
    }
    internal class TypeAndAmount
    {
        string Type;
        int Amount;
        public TypeAndAmount() { }

        public TypeAndAmount( string type, int amount)
        {
            Type = type;
            Amount = amount;
        }
        public void PlusAmount(int AmountPLus)
        {
            this.Amount = AmountPLus+ this.Amount;
        }
        public int GetAmount () { return this.Amount; }
    }
}
