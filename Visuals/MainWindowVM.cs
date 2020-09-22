using Models;
using Prism.Commands;
using Services;
using System.ComponentModel;
using System.Windows.Input;

namespace Visuals
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private readonly DelegateCommand _cancelCommand;
        private readonly DelegateCommand _saveShapeCommand;
        private readonly IShapeSaver _shapeSaver;

        public ICommand CancelCommand => _cancelCommand;
        public ICommand SaveShapeCommand => _saveShapeCommand;


        public MainWindowVM(IShapeSaver shapeSaver)
        {
            _cancelCommand = new DelegateCommand(Cancel);
            _saveShapeCommand = new DelegateCommand(SaveShape);
            _shapeSaver = shapeSaver;
        }

        private void SaveShape()
        {
            var shape = new Shape(SelectedShape.Name, SelectedShape.Color, SelectedShape.Size, SelectedShape.X, SelectedShape.Y);
            _shapeSaver.SaveShape(shape);
        }

        private void Cancel()
        {
            SelectedShape = new ShapeVM();
        }

        private ShapeVM _selectedShape;
        public ShapeVM SelectedShape
        {
            get { return _selectedShape; }
            set
            {
                _selectedShape = value;
                OnPropertyChanged(nameof(SelectedShape));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
