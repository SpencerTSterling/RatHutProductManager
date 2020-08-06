using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatHutProductManager
{
    static class Validator
    {
        /// <summary>
        /// A textbox is passed into IsPresent, returns true if 
        /// the textbox is not null or whitespace
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox box)
        {
            if ( string.IsNullOrWhiteSpace(box.Text) )
            {
                return false;
            } else
            {
                return true;
            }
        }

        /// <summary>
        /// An input is passed into IsInt32, returns true if the input
        /// is successfully converted to an Int32. Otherwise false.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumber(string input)
        {
            try
            {
                Convert.ToDouble(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
