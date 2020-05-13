using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public abstract class kedi :Animal //kalıtım budur. //abstract olmak zorunda değildir.
    {
        public int runSpeed;
      
        public string getProperties()
        {
            string animalProperties = base.getProperties(); //bağlı olduğu classtan fonku çağırma.
            return animalProperties + "Run Speed: " + runSpeed;
        }
        public override void Move() //burasını sen doldururssun
        {
            throw new NotImplementedException();
        }
    }
}
