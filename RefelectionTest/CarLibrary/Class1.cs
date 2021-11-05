using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * @author jingjiejiang
 * @history Nov 5, 2021
 * 
 */
namespace CarLibrary
{
    public class Car : IEnumerable
    {
        private string name = string.Empty;
        private string prvtVariable = "PrivateVariable";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
