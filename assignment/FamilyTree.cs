using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class FamilyTree
    {
        private FamilyMember root;
        public FamilyTree(string? rootName, int rootAge)
        {
            root=new FamilyMember(rootName, rootAge);
        }
        public void AddChild(string parentName,string childName,int childAge) 
        {
            FamilyMember parent = FindMember(root, parentName);
            if(parent!=null)
            {
                parent.Children.Add(new FamilyMember(childName, childAge));
                Console.WriteLine($"{childName} is a child of {parentName},");
            }
            else
            {
                Console.WriteLine($"Parent {parentName} not Found. ");
            }
        }
        private  FamilyMember FindMember(FamilyMember current,string name)
        {
            if(current.Name==name)
            {
                return current;
            }
            foreach (var  child in current.Children)
            {
                var result = FindMember(child, name);
                if(result!=null)
                {
                    return result;
                }
            }
            return null;
        }
        public void DisplayFamilyTree(FamilyMember member,int level)
        {
            string indentation = new string(' ', level * 2);
            Console.WriteLine($"{indentation}{member.Name}(Age:{member.Age}");
            foreach (var child  in member.Children)
            {
                DisplayFamilyTree(child, level + 1);
            }

        }

        internal void DisplayFamilyTree()
        {
            throw new NotImplementedException();
        }
    }
}
