using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace WpfDemoApp.Bindings
{
  public class Person: INotifyPropertyChanged
  {
    int _age;
    string _name;

    public int Age
    {
      get { return _age; }
      set
      {
        _age = value;
        UpdateProperty("Age");
      }
    }
    public string Name
    {
      get { return _name; }
      set
      {
        _name = value;
        UpdateProperty("Name");
      }
    }

    void UpdateProperty(string propName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propName));
      }
    }
    
    #region INotifyPropertyChanged Members
    public event PropertyChangedEventHandler PropertyChanged; 
    #endregion


  }
}
