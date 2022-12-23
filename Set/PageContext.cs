using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Wpf_HW_2
{
    internal class PageContext : NotifyClass
    {
        static PageContext _currentPageContext = new PageContext();
        public static PageContext CurrentPageContext
        {
            get => _currentPageContext;
            set
            {
                if (_currentPageContext == null)
                {
                    _currentPageContext = value;
                }
            }
        }

        Stack<UserControl> _pages = new Stack<UserControl>();
        public UserControl CurrentPage { get; private set; }

        public void AddPage(UserControl page)
        {
            _pages.Push(page);
            CurrentPage = page;
            OnPropertyChanged("CurrentPage");
        }

        public void DropPage()
        {
            _pages.Pop();
            CurrentPage = _pages.Peek();
            OnPropertyChanged("CurrentPage");
        }

        public void NextPage(UserControl page)
        {
            DropPage();
            AddPage(page);
        }

        public void RefreshPage(params object[] parametrs)
        {
            Type typePage = CurrentPage.GetType();
            CurrentPage = (UserControl)Activator.CreateInstance(typePage, parametrs);
        }

        public void ChangeRootPage(UserControl page)
        {
            _pages.Clear();
            AddPage(page);
        }
    }
}
