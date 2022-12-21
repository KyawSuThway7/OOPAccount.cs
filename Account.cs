using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentforOOP
{
    public class Account
    {
       
        private string name;
        private string Email;
        private string Adress;

        public void SetName(string name)
        {
            if(name == "")
            {
                throw new ArgumentException("Name Error!");
            }
            else
            {
                this.name = name;
            }
        }
        public void SetEamil1(string Email)
        {
            if (!Email.Contains("@") || !Email.Contains(".com")) 
            {
                throw new ArgumentException("Email Error");
            }
            else
            {
                this.Email = Email;
            }
        }
        public void SetAddress(string Adress)
        {
            if (Adress == "")
            {
                throw new ArgumentException("Name Error!");
            }
            else
            {
                this.Adress = Adress;
            }
        }
        public void showinfo ()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Adress : " + Adress);
            Console.WriteLine();
            Console.WriteLine("\tAccount Discipline");
            Console.WriteLine("You can change Cover Photo three time in one week");
            Console.WriteLine("You can post freely but you cann't post toxic file");
            Console.WriteLine("if you post fake new , our group deleted your account");
        }
    }
}
