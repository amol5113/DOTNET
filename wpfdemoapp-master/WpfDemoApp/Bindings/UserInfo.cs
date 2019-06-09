using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoApp.Bindings
{
  public class UserInfo
  {
    string _userName;
    int _age;
    string _favColor;


    public UserInfo(string userName, int age, string favColor)
    {
      _userName = userName;
      _age = age;
      _favColor = favColor;
    }

    public string UserName
    {
      get { return _userName; }
      set
      {
        _userName = value;
      }
    }
    public int Age
    {
      get { return _age; }
      set
      {
        _age = value;
      }
    }
    public string FavColor
    {
      get { return _favColor; }
      set
      {
        _favColor = value;
      }
    }
  }
}
