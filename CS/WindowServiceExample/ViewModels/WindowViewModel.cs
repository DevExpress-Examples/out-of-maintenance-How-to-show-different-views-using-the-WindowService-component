using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace WindowServiceExample.ViewModels {
    public class WindowViewModel : ViewModelBase {
        protected WindowViewModel() { }

        public static WindowViewModel Create() {
            return ViewModelSource.Create(() => new WindowViewModel());
        }
    }
}
