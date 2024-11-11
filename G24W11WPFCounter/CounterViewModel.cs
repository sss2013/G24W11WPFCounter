
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace G24W11WPFCounter;

class CounterViewModel : INotifyPropertyChanged
{
    private CounterModel _model;
    public CounterViewModel()
    {
        _model = new CounterModel();
    }

    public int Value
    {
        get => _model.Count;
        set
        {
            _model.Count = value;
            OnPropertyChanged(); //callerMemberName을 통해 인자를 생략함.
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propName = "") 
        //callerMemberName -> 프로퍼티 이름인 "value"를 인자로 넘겨준다. 
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
