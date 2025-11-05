using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    public partial class contacts: Component
    {
        public int id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string email { get; set; }
        public string address { get; set; }


        public contacts()
        {


       
        }

        public contacts(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
