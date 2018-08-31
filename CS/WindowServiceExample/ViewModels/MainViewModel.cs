using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace WindowServiceExample.ViewModels {
    public class MainViewModel : ViewModelBase {
        protected MainViewModel() { }

        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        public void ShowFirst() {
            WindowService.Show("FirstWindowView", null, this);
        }
        public void ShowSecond() {
            WindowService.Show("SecondWindowView", null, this);
        }

        public IWindowService WindowService {
            get {
                return GetService<IWindowService>();
            }
        }
    }
}
