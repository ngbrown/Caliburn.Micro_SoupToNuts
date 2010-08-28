namespace Caliburn.Micro.Hello.WPF
{
    using System.ComponentModel.Composition;
    using System.Windows;

    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        public bool CanSayHello(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        public void SayHello(string name)
        {
            MessageBox.Show(string.Format("Hello {0}!", name));
        }
    }
}