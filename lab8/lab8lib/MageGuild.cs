using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{
    public delegate Mage MageDelegate(Mage mage);
    public partial class MageGuild : List<Mage>
    {

        public event  MageDelegate OnAddedMage;
        public event MageDelegate OnDeletedMage;
        public void DeleteMage(String name)
        {
            var mage = this.Single(m => m.Name.Equals(name));
            if (mage != null)
            {
                this.Remove(mage);
                OnDeletedMage?.Invoke(mage);
            }
            else
            {
                throw new MageNotExistException($"Mage {name} doesnt exist ");
            }
            
        }

        public void AddMage(Mage mage)
        {
            if(!this.Any(m => m.Name.Equals(mage.Name))){
                this.Add(mage);
                OnAddedMage?.Invoke(mage);
            }
            else
            {
                throw new MageExistException($"Mage {mage.Name} already exist");
            }
           
        }


        public override string ToString()
        {
            String mages = "";
            foreach (var item in this)
            {
                mages += item.ToString() + "\n";
            }
            return mages;
        }

      

    }
}
