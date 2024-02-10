using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession
{
    internal struct PhoneBook
    {
        #region Attributes:
        // Attributes:
        string[] names;
        long[] phoneNumber;
        int size;
        #endregion

        #region Properties:
        // Properties:
        public int Size // Read Only Property
        {
            get { return size; }
        }

        // Indexer : Is A Spicial Property [Named Always With Keyword 'this' , And Take Parameters]
        public long this[string Name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if(Name == names[i])
                        return phoneNumber[i];
                }
                return -1;
            }
            set 
            {
                for (int i = 0; i < size; i++)
                {
                    if(Name == names[i])
                    {
                        phoneNumber[i] = value;
                        break;
                    }
                }

            }
        }

        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < size)
                    return $"Position [{index}] - Name '{names[index]}' - Phone Number : {phoneNumber[index]}";
                return "Not An Correct Index";
            }
        }
        #endregion

        //Getter:
        public long GetPhoneNumberUsingName(string Name)
        {
            for (int i = 0; i < names?.Length; i++)
            {
                if(Name == names[i]) 
                    return phoneNumber[i];
            }
            return -1;
        }

        //Setter: [Update]
        public void UpdatePhoneNumberUsingName(string Name , long NewNumber)
        {
            for (int i = 0; i < names?.Length; i++)
            {
                if (Name == names[i])
                {
                    phoneNumber[i] = NewNumber;
                    break;
                }
                    
            }
        }

        #region Constructor:
        //Constructor

        public PhoneBook(int _size)
        {
            names = new string[_size];
            phoneNumber = new long[_size];
            this.size = _size;
        }

        #endregion

        #region Methods:
        //Method

        public void AddPerson(int Position , string Name , long PhoneNumber)
        {
            if(Position >= 0 && Position < this.size)
            {
                names[Position] = Name;
                phoneNumber[Position] = PhoneNumber;
            }
        }

        #endregion
    }
}
