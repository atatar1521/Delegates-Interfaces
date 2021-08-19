using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class AddItem : MenuItem
    {
        private ISelectInterface m_Select;

        public AddItem()
        {
            m_Select = null;
        }

        public AddItem(string i_Title, ISelectInterface i_Select)
        {
            Title = i_Title;
            Select = i_Select;
        }

        public ISelectInterface Select
        {
            get { return m_Select; }
            set { m_Select = value; }
        }

        internal override void DoWhenSelected()
        {
                Select.Excute();
        }
    }
}
