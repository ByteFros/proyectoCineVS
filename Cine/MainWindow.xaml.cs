using Cine.Usuario;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using GUICine2Vista.Peliculas;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Cine
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> listUsers { get; set; }
        public ObservableCollection<Pelicula> Peliculas { get; set; }
        private int intentos = 0;
        public MainWindow()
        {
            InitializeComponent();
            listUsers = new ObservableCollection<User>();
            listUsers.Add(new User("Paco", "Paco@gmail.com", "123",Role.User));
            listUsers.Add(new User("Jose", "Jose@gmail.com", "12", Role.User));
            listUsers.Add(new User("a", "a", "a", Role.Admin));
            listUsers.Add(new User("admin", "admin@admin.com", "admin", Role.Admin));

            Peliculas = new ObservableCollection<Pelicula>();

            DataContext = this;
        

    }

        public User verifyUser(string name , string email , string password)
        {
            foreach(User user in listUsers)
            {
                if(user.user == name && user.email == email && user.password == password)
                {
                    return user;
                }
            }

            return null;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameUser = LoginUserTB.Text;
            string email = LoginEmailTB.Text;
            string pass = LoginPassTB.Password;

            if (string.IsNullOrWhiteSpace(nameUser))
            {
                MessageBox.Show("Por favor ingresa el nombre de usuario");
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor ingresa el correo");
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor ingresa tu contraseña");
                return;
            }

            User usuarioVerificado = verifyUser(nameUser, email, pass);

            if (usuarioVerificado!= null)
            {
                Role rolUsuario = usuarioVerificado.GetRole();
                TablasUser tablasuser = new TablasUser(Peliculas, rolUsuario);
                tablasuser.Show();
                this.Close();
            }
            else 
            {
                intentos++;
                if (intentos >=3)
                {
                    MessageBox.Show("Demasiados intentos fallidos. Me cierro :( ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");

                }
            }
  
        }

        private bool validEmail(string email)
        {
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }
 

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginPassTB_Copiar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginPassTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginPassTB_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

    }
}
