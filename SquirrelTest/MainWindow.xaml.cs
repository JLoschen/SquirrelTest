using Squirrel;
using System;
using System.Threading.Tasks;
using System.Windows;
namespace SquirrelTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Update();
        }

        private async Task Update()
        {
            using(var manager = new UpdateManager(@"C: \Users\Josh\Desktop\Releases"))
            {
                await manager.UpdateApp();
            }
        }
    }
}
