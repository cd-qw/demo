using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XbclMes.Entity;

namespace XbclMes.Models
{
    public class MainViewModel
    {
        public ICommand Reload { set; get; }

        public ICommand Setting { set; get; }


        public MainViewModel()
        {
            Reload = new Command<MainPage>((s) => { s.reload(s,new EventArgs()); });
            Setting = new Command<MainPage>((s) => s.set(s, new EventArgs()));
        }
    }
}
