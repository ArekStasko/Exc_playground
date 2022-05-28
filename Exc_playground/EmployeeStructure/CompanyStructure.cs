using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.EmployeeStructure
{
    public class CompanyNode
    {
        public Person root { get; }
        public List<CompanyNode> nodes { get; set; } = new List<CompanyNode>() { };

        public CompanyNode(Person person)
        {
            root = person;
        }

        public void PrintNodes(CompanyNode companyNode)
        {
            Console.WriteLine($"Name: {companyNode.root.Name} ; Role: {companyNode.root.Role}");
           
            if(companyNode.nodes == null || companyNode.nodes.Count == 0)
                return;

            foreach(var node in companyNode.nodes) 
                PrintNodes(node);          
        }
    }

}
