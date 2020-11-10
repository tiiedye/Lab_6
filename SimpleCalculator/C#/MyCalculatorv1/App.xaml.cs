using System.Windows;

namespace MyCalculatorv1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private int Test(int x) 
        {
            int y = 0;
            if (x == 0)
            {
                y = 1;
            }
            else if (x == 1)
            {
                y = 2;
            }
            else
            {
                y = 3;
            }
            return y;
        }
    }
}
