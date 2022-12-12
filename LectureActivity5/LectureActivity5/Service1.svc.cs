using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LectureActivity5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string reverse(string str)
        {
            char[] reversedArray = str.ToCharArray();
            Array.Reverse(reversedArray);
            return new string(reversedArray);
        }
        public int sumOfDigits(int digits) 
        {
            int sumOfNums = 0; //takes in each single digit from the int digits then adds them together
            while (digits > 0)
            {
                sumOfNums += digits % 10;
                digits /= 10;
            }
            return sumOfNums;
        }
        public string filter(string str)
        {
            string filtered = "";
            return filtered;
        }
    }
}
