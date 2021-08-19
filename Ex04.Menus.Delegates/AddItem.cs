namespace Ex04.Menus.Delegates
{
    public class AddItem : MenuItem
    {
        public delegate void SelectActionDelegate();

        public event SelectActionDelegate ToDoWhenSelected;

        public AddItem()
        {
            ToDoWhenSelected = null;
        }

        public AddItem(string i_Title, SelectActionDelegate i_SelectActionDelegate)
        {
            Title = i_Title;
            ToDoWhenSelected += i_SelectActionDelegate;
        }

        internal override void DoWhenSelected() 
        {
              ToDoWhenSelected.Invoke();
        }
    }
}
