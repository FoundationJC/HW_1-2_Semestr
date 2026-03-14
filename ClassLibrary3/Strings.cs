using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Strings
    {
        private string[] text;

        public Strings(string[] text)
        {
            
            this.text = text;



        }

        public Strings()
        {
            this.text = new string[0];          



        }

        public Strings(Strings other)
        {

            this.text = new string[other.text.Length];

            for(int i = 0; i < other.text.Length; ++i)
            {

                this.text[i] = other.text[i];


            }


        
        }

        public int Count
        {

            get { return this.text.Length; }


        }
    
    
    
        public string this[int index]
        { 
            
            
            get { return this.text[index]; }







        }


        public string Name { get; set; }
        

        ~Strings()
        {

            //NOT NESSESARY


        }



        




    }

}

