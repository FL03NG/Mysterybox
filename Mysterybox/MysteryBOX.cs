using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mysterybox
{
    internal class MysteryBOX
    {
        private string _label;
        private string _contains;
        private bool _isexplosive;

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public string Contains
        {
            get { return _contains; }
            set { _contains = value; }
        }
        public bool IsEplosive
        {
            get { return _isexplosive; }
            set { _isexplosive = value; }
        }

        public MysteryBOX(string label, string contains, bool isexplsive)
        {
            Label = label;
            Contains = contains;
            IsEplosive = isexplsive;
        
        }
        public override string ToString() 
        {
            return $" {Label}, {Contains}, {IsEplosive}";
        }
    }
}
