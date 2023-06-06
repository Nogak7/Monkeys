using Monkeys.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys.ViewModels
{
    public class MonkeyViewModels : ViewModels
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        private Monkey monkey;
        public Monkey Monkey
        {
            get { return monkey; }
            set { if (value != monkey) { value = monkey; OnPropertyChanged(); } }

        }
    }
}
