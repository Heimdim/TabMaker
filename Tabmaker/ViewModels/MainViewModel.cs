using System.Collections.ObjectModel;
using Tabmaker.Server.Model;
using Tabmaker.Server.Context;
using System.Data.Entity;
using Tabmaker.Server.Model.Tournir;
using System.Windows.Data;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using DevExpress.Mvvm;
using Tabmaker.Views;
using System.Threading.Tasks;

namespace Tabmaker.ViewModels
{
    public class MainViewModel : BaseVM
    {
        UserContext dbUser;

        public User SelectedUser { get; set; }
        public ObservableCollection<User> Users { get; set; }

        public MainViewModel()
        {
            dbUser = new UserContext();

            dbUser.Users.Load();

            Users = new ObservableCollection<User>(dbUser.Users);
            SelectedUser = Users.FirstOrDefault();
        }

        public ICommand AddNewUser
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var w = new AddNewUserWindow();
                    var vm = new AddNewUserViemModel();
                    w.DataContext = vm;
                    w.ShowDialog();

                    var newUser = vm.AddedUser;
                    if (newUser != null)
                    {
                        Users.Add(newUser);
                        if (newUser.Id == 0)
                            dbUser.Entry(newUser).State = EntityState.Added;
                        else
                            dbUser.Entry(newUser).State = EntityState.Modified;
                        dbUser.SaveChanges();
                    }


                });
            }
        }

        public ICommand RemoveSelectedUser
        {
            get
            {
                return new DelegateCommand<User>((user) =>
                {
                    Users.Remove(user);
                    SelectedUser = Users.FirstOrDefault();
                    dbUser.Users.Remove(user);
                    dbUser.SaveChanges();
                }, (video) => video != null);
            }
        }

        public void CreateUser()
        {
            TournirPlayer user = new TournirPlayer("Dima",22);
            dbUser.Users.Add(user);
            dbUser.SaveChanges();
        }
    }
}
