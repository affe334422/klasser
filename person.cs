using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace klasser
{
    public class bil
    {
        private string tillverkare;
        private string model;
        private int år;
        private int vikt;

        public void settillverkare(string n){tillverkare = n;}
        public string gettillverkare(){return tillverkare;}

        public void setmodel(string n){model = n;}
        public string getmodel(){return model;}
        
        public void setår(int n){år = n;}
        public int getår(){return år;}
        
        public void setvikt(int n){vikt = n;}
        public int getvikt(){return vikt;}
    }
}
