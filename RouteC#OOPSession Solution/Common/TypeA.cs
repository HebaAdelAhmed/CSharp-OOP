using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    /// <summary>
    /// 
    /// What We Can Write Inside namespace?
    /// 1. Class 
    /// 2. Interface
    /// 3. Struct [Is Stand For Structure]
    /// 4. Enum
    /// 
    /// Allawed Access Modefieres Inside The namespace?
    /// 1. internal [Default Access Modeifier]  -> Can Be Access Inside This Project Only 
    /// 2. public                               -> Can Be Access Inside This Project and Other Project 
    /// </summary>

    /// Default Access Modifires Inside Class Or Struct Is private
    
    /// Default Access Modifires Inside Interface Is public.

    /// Allowed Access Modifiers Inisde Struct?
    /// 1. private
    /// 2. internal
    /// 3. public
    /// Default Access Modifires Inside Class Or Struct Is private
    public class TypeA
    {
        /// What Can I Write Inside Cass Or Struct?
        /// 1. Attributes [Member Variables]
        /// 2. Functions (Constructor - Getter Setter - Method)
        /// 3. Properities  (Full Property , Aotomatic Property , Indexer)
        /// 4. Event
        
        /// What Can I Write Inside Interface ? 
        /// 1. Signature For Property
        /// 2. Signature For Method
        /// 3. Default Implemented Method [C# 8.0 Feature]

        /// Allowed Access Modifiers Inside Class:
        /// 1. private  -> Only Accessable Inside This Class
        /// 2. private protected -> 
        /// 3. protected 
        /// 4. internal
        /// 5. internal protected 
        /// 6.public
        /// We Use A Protected Keyword In Case Of Inherite.
        /// Defaulte Access Modifires Inside Class Or Struct Is private

        /*private*/ int A; // Defaulte is private -> only accessable inside this class
        private protected int B; // -> Accessable in this class only and any class inherite from this class in condition this class in the same project
        protected int C; // -> Will be Accessable in this class and any other class inherite from this class in this project or other projects
        internal int D; // -> Will be Accessable in the same project only
        internal protected int E; // -> Will be accessable in the same project or class in the other project that inherete from this class
        public int F; // -> will be accesable where ever

        public void Print()
        {
            Console.WriteLine(A); // A Is : Accessable in this class only
        }

    }
}
