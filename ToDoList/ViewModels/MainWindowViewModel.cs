using ReactiveUI;
using ToDoList.Services;

namespace ToDoList.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        // 这个视图模型依赖于 ToDoListService
        private ViewModelBase _contentViewModel;
        public MainWindowViewModel() {
            var service = new ToDoListService();
            ToDoList = new ToDoListViewModel(service.GetItems());
            _contentViewModel = ToDoList;
        }

        public ToDoListViewModel ToDoList { get; }

        //private ViewModelBase contentViewModel;
        //public ViewModelBase ContentViewModel {
        //    get => contentViewModel;
        //    set {
        //        if ( contentViewModel != value ) {
        //            contentViewModel = value;
        //            OnPropertyChanged(nameof(ContentViewModel));
        //        }
        //    }
        //}
        public ViewModelBase ContentViewModel {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }


        public void AddItem() {
            ContentViewModel = new AddItemViewModel();
        }
    }
}