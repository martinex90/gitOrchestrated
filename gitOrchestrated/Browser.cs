using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOrchestrated
{
    /// <summary>
    /// Handles the browser automation via Selenium.
    /// </summary>
    public class Browser
    {
        public Browser()
        {
            Console.WriteLine("Product instance created");
        }
        public Browser(int productId,
                        string productName,
                        string descrtiption) : this()
        {
            this.Id = productId;
            this.Name = productName;
            this.Description = description;

        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string SayHello()
        {
            return "Hello " + Name + " (" + Description + ") " + Id;
        }

    }
}
