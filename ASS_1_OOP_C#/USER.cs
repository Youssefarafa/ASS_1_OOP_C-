using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_1_OOP_C_
{
    internal class USER
    {
        public int ID {  get; set; }
        public Permissions permissions { get; set; } = Permissions.None;
        public bool[] Permission { get; set; }= new bool[4];
        public Permissions AddPermission(Permissions current, Permissions permissionToAdd)
        {
            if ((current & permissionToAdd) == permissionToAdd)
            {
                Console.WriteLine("The Permission is already exists. ");
                return current;
            }
            else
            {
                return current | permissionToAdd;
            }
        }
        public Permissions RemovePermission(Permissions current, Permissions permissionToRemove)
        {
            if ((current & permissionToRemove) == permissionToRemove)
            {
                return current & ~permissionToRemove; 
            }
            else
            {
                Console.WriteLine("The Permission is already not exists. ");
                return current;
            }
        }
    }
}
