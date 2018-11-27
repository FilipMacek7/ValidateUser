using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FluentValidation;

namespace ValidateUser
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DatePicker datePicker = new DatePicker();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CustomerBuilder customer = new CustomerBuilder()
                .WithSurName(surname.Text)
                .WithForeName(forename.Text)        
                .WithBirthDate(Convert.ToDateTime(datePicker.SelectedDate));

            CustomerValidator validator = new CustomerValidator();

            FluentValidation.Results.ValidationResult results = validator.Validate(customer);


            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    result.Text = "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage;
                    if (failure.PropertyName == "Surname")
                    {
                        surname.Background = Brushes.Red;
                    }
                    else if (failure.PropertyName == "Forename")
                    {
                        forename.Background = Brushes.Red;
                    }
                    else if (failure.PropertyName == "Birthdate")
                    {
                        date.Background = Brushes.Red;
                    }
                }
                
            }
            else if (results.IsValid)
            {
                result.Text = "You have been succefuly registred";
                surname.ClearValue(TextBox.BorderBrushProperty);
                forename.ClearValue(TextBox.BorderBrushProperty);
                date.ClearValue(TextBox.BorderBrushProperty);
            }
        }
    }
}
