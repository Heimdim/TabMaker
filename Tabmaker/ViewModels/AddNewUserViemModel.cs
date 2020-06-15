using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Tabmaker.Server.Context;
using Tabmaker.Server.Model;
using Tabmaker.Server.Model.Tournir;

namespace Tabmaker.ViewModels
{
    public class AddNewUserViemModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User AddedUser{ get; set; }

        public ICommand CreateNewUser
        {
            get
            {
                return new DelegateCommand<Window>((w)=>
                {
                    AddedUser = new TournirPlayer(Name, Age);
                    w?.Close();
                });
            }
        }

    }
}
